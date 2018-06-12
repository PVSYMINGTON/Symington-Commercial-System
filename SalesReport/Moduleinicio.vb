Imports System.IO
Imports Microsoft.WindowsAzure.Storage
Imports Microsoft.WindowsAzure.Storage.Blob


Imports System.IO.Compression
Imports System.Globalization
Imports System.Threading

Module Moduleinicio
    '  Dim formabout As New FormAbout
    ' Dim formsales As New FormSales
    Dim formlogin As New FormLogin
    Public CommandLine As String
    Public EditPricing As Boolean = False
    Public ViewPricing As Boolean = False

    Public Sub main()

        'DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = New System.Drawing.Font("Calibri Light", 11)

        ' Thread.CurrentThread.Name = "MainThread"
        Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-PT")



        updatesales()


        formlogin.ShowDialog()
        '  formabout.Close()
        ' formsales.ShowDialog()
        Dim frm As New FormInicial
        frm.ShowDialog()
    End Sub


    Sub updatesales()
        Dim ret As MsgBoxResult
        ret = MsgBox("Do you want to update your Sales?", MsgBoxStyle.YesNoCancel, "Update Commercial System")
        If ret = vbNo Then Exit Sub
        If ret = MsgBoxResult.Cancel Then End
        'Try

        'If My.Computer.Network.Ping("srvsymdata.symington.org") = True Then
        '    Dim MyAutoUpdate As New AutoUpdate
        '    ' test if an update is needed and quit the program if so.    
        '    If MyAutoUpdate.AutoUpdate(CommandLine) Then End 'Exit Sub
        '    ' here goes your regular code in the main sub



        '    Dim formcopylive As New FormCopy
        '    formcopylive.Show()
        '    Cursor.Current = Cursors.WaitCursor

        '    formcopylive.button1_Click("\\srvsymdata\CommercialSystem\SapCS.zip", "c:\CommercialSystem\dados\SapCS.zip")
        '    formcopylive.button1_Click("\\srvsymdata\CommercialSystem\SapIVDP.zip", "c:\CommercialSystem\dados\SapIVDP.zip")
        '    formcopylive.Close()


        'Else
        'Dim MyAutoUpdate As New AzureAutoUpdate
        '    ' test if an update is needed and quit the program if so.    
        '    If MyAutoUpdate.AutoUpdate(CommandLine) Then End 'Exit Sub
        '    ' here goes your regular code in the main sub


        '    Dim formcopyftp As New FormCopyFTP
        '    formcopyftp.Show()
        '    Cursor.Current = Cursors.WaitCursor

        '    formcopyftp.button1_Click("SapCS.zip", "c:\CommercialSystem\dados\SapCS.zip")

        '    formcopyftp.Close()


        'End If

        'Catch ex As Exception
        Try

            Dim MyAutoUpdate As New AzureAutoUpdate
            ' test if an update is needed and quit the program if so.    
            If MyAutoUpdate.AutoUpdate(CommandLine) Then End 'Exit Sub
            ' here goes your regular code in the main sub

            Try
                Dim formcopyftp As New FormCopyFTP
                formcopyftp.Show()
                Cursor.Current = Cursors.WaitCursor

                formcopyftp.button1_Click("SapCS.zip", "c:\CommercialSystem\dados\SapCS.zip")

                formcopyftp.Close()
            Catch
                MsgBox("Problems accessing Ftp.")
            End Try

        Catch


            MsgBox("Problems accessing Internet.")
            Exit Sub
        End Try




        'Dim formunziplive As New FormUnzip
        'formunziplive.ficheiro = "SapCS"
        'formunziplive.Show()
        'UnzipFile("c:\CommercialSystem\dados\SapCS.zip", "c:\CommercialSystem\dados\SapCS.db3")
        Unzip("c:\CommercialSystem\dados\SapCS.zip", "c:\CommercialSystem\dados")
        ' formunziplive.Close()

        'Dim formunziplive2 As New FormUnzip
        'formunziplive2.ficheiro = "SapIVDP"
        'formunziplive2.Show()
        'UnzipFile("c:\CommercialSystem\dados\SapIVDP.zip", "c:\CommercialSystem\dados\SapIVDP.db3")
        Unzip("c:\CommercialSystem\dados\SapIVDP.zip", "c:\CommercialSystem\dados")
        'formunziplive2.Close()


        SaveSetting("SalesReports", "Updated", "Date", Today)
        Cursor.Current = Cursors.Default





    End Sub


    Public Sub Unzip(ByVal zipPath As String, ByVal pathToExtract As String)
        Using archive As ZipArchive = ZipFile.OpenRead(zipPath)
            For Each entry As ZipArchiveEntry In archive.Entries

                entry.ExtractToFile(Path.Combine(pathToExtract, entry.FullName), True)

            Next
        End Using



    End Sub




    Public Class AutoUpdate

        Public Function AutoUpdate(ByRef CommandLine As String) As Boolean
            Dim Key As String = "&**#@!" ' any unique sequence of characters
            ' the file with the update information
            Dim sfile As String = "update.dat"
            ' the Assembly name 
            Dim AssemblyName As String = System.Reflection.Assembly.GetEntryAssembly.GetName.Name
            ' here you need to change the web address 
            Dim RemotePath As String = "\\srvsymdata\AppsAutoUpdate\"
            ' where are the files for a specific system
            Dim RemoteUri As String = RemotePath & AssemblyName & "\"

            ' clean up the command line getting rid of the key
            CommandLine = Replace(Microsoft.VisualBasic.Command(), Key, "")
            ' Verify if was called by the autoupdate
            If InStr(Microsoft.VisualBasic.Command(), Key) > 0 Then
                Try
                    ' try to delete the AutoUpdate program, 
                    ' since it is not needed anymore
                    System.IO.File.Delete(Application.StartupPath & "\autoupdate.exe")
                Catch ex As Exception
                End Try
                ' return false means that no update is needed
                Return False
            Else
                ' was called by the user
                Dim ret As Boolean = False ' Default - no update needed

                Try
                    Dim file2 As System.IO.StreamReader = System.IO.File.OpenText(RemoteUri & sfile)
                    Dim contents As String = file2.ReadToEnd()
                    file2.Close()
                    ' if something was read
                    If contents <> "" Then
                        ' Break the contents 
                        Dim x() As String = Split(contents, "|")
                        ' the first parameter is the version. if it's 
                        ' greater then the current version starts the 
                        ' update process
                        If x(0) > Application.ProductVersion Then
                            ' assembly the parameter to be passed to the auto 
                            ' update program
                            ' x(1) is the files that need to be 
                            ' updated separated by "?"
                            Dim arg As String = Application.ExecutablePath & "|" & RemoteUri & "|" & x(1) & "|" & Key & "|" & Microsoft.VisualBasic.Command()
                            ' Download the auto update program to the application 
                            ' path, so you always have the last version runing
                            System.IO.File.Copy(RemoteUri & "autoupdate.exe", Application.StartupPath & "\autoupdate.exe", True)
                            ' Call the auto update program with all the parameters
                            System.Diagnostics.Process.Start(Application.StartupPath & "\autoupdate.exe", arg)
                            ' return true - auto update in progress
                            ret = True
                        End If
                    End If
                Catch ex As Exception
                    ' if there is an error return true, 
                    ' what means that the application
                    ' should be closed
                    ret = False
                    ' something went wrong...continue
                    'MsgBox("There was a problem runing the Auto Update." & vbCr & "Please Contact [contact info]" & vbCr & ex.Message, MsgBoxStyle.Critical)
                End Try
                Return ret
            End If
        End Function
    End Class

    Public Class AzureAutoUpdate

        Public Function AutoUpdate(ByRef CommandLine As String) As Boolean
            Dim Key As String = "&**#@!" ' any unique sequence of characters
            ' the file with the update information
            Dim sfile As String = "update.dat"
            ' the Assembly name 
            Dim AssemblyName As String = System.Reflection.Assembly.GetEntryAssembly.GetName.Name


            ' clean up the command line getting rid of the key
            CommandLine = Replace(Microsoft.VisualBasic.Command(), Key, "")
            ' Verify if was called by the autoupdate
            If InStr(Microsoft.VisualBasic.Command(), Key) > 0 Then
                Try
                    ' try to delete the AutoUpdate program, 
                    ' since it is not needed anymore
                    System.IO.File.Delete(Application.StartupPath & "\autoupdate.exe")
                Catch ex As Exception
                End Try
                ' return false means that no update is needed
                Return False
            Else
                ' was called by the user
                Dim ret As Boolean = False ' Default - no update needed

                Try
                    ' Parse the connection string for the storage account.
                    Dim storageAccount As CloudStorageAccount = CloudStorageAccount.Parse(My.Settings("StorageConnectionString"))
                    Dim fileClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()
                    Dim share As CloudBlobContainer = fileClient.GetContainerReference("csdata")
                    Dim sourceFile As CloudBlockBlob = share.GetBlockBlobReference(sfile)

                    Dim file2 As New MemoryStream
                    sourceFile.DownloadToStream(file2)
                    Dim contents As String = System.Text.Encoding.UTF8.GetString(file2.ToArray())


                    file2.Close()
                    ' if something was read
                    If contents <> "" Then
                        ' Break the contents 
                        Dim x() As String = Split(contents, "|")
                        ' the first parameter is the version. if it's 
                        ' greater then the current version starts the 
                        ' update process
                        If x(0) > Application.ProductVersion Then
                            ' assembly the parameter to be passed to the auto 
                            ' update program
                            ' x(1) is the files that need to be 
                            ' updated separated by "?"
                            Dim RemoteUri As String = "naointeressa"
                            Dim arg As String = Application.ExecutablePath & "|" & RemoteUri & "|" & x(1) & "|" & Key & "|" & Microsoft.VisualBasic.Command()
                            ' Download the auto update program to the application 
                            ' path, so you always have the last version runing
                            ' Parse the connection string for the storage account.
                            Dim sourceEXEFile As CloudBlockBlob = share.GetBlockBlobReference("AutoUpdate.exe")
                            sourceEXEFile.DownloadToFile(Application.StartupPath & "\AutoUpdate.exe", FileMode.Create)

                            ' Call the auto update program with all the parameters
                            System.Diagnostics.Process.Start(Application.StartupPath & "\Autoupdate.exe", arg)
                            ' return true - auto update in progress
                            ret = True
                        End If
                    End If
                Catch ex As Exception
                    ' if there is an error return true, 
                    ' what means that the application
                    ' should be closed
                    ret = False
                    ' something went wrong...continue
                    'MsgBox("There was a problem runing the Auto Update." & vbCr & "Please Contact [contact info]" & vbCr & ex.Message, MsgBoxStyle.Critical)
                End Try
                Return ret
            End If
        End Function
    End Class


End Module
