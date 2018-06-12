Imports Microsoft.WindowsAzure.Storage
Imports Microsoft.WindowsAzure.Storage.Blob
Imports System.Configuration
Imports System.Windows.Forms

Public Class WaitForm1
    Sub New()
        InitializeComponent()
        Me.progressPanel1.AutoHeight = True
        Me.Properties.UseFadeInEffect = False

    End Sub

    Public Overrides Sub SetCaption(ByVal caption As String)
        MyBase.SetCaption(caption)
        Me.progressPanel1.Caption = caption
    End Sub

    Public Overrides Sub SetDescription(ByVal description As String)
        MyBase.SetDescription(description)
        Me.progressPanel1.Description = description
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Private Sub WaitForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Show()
        Refresh()
        Application.DoEvents()

        programa()
        Application.DoEvents()
        Application.Exit()
    End Sub

    Public Enum WaitFormCommand
        SomeCommandId
    End Enum

    Public Sub programa()
        Dim ExeFile As String ' the program that called the auto update
        Dim RemoteUri As String ' the web location of the files
        Dim Files() As String ' the list of files to be updated
        Dim Key As String ' the key used by the program when called back 
        ' to know that the program was launched by the 
        ' Auto Update program

        Dim CommandLine As String ' the command line passed to the original 

        Try
            ' Get the parameters sent by the application
            Dim param() As String = Split(Microsoft.VisualBasic.Command(), "|")
            ExeFile = param(0)
            RemoteUri = param(1)
            ' the files to be updated should be separeted by "?"
            Files = Split(param(2), "?")
            Key = param(3)
            CommandLine = param(4)
        Catch ex As Exception
            ' if the parameters wasn't right just terminate the program
            ' this will happen if the program wasn't called by the system 
            ' to be updated
            Exit Sub
        End Try

        Application.DoEvents()
        ' Parse the connection string for the storage account.
        Dim storageAccount As CloudStorageAccount = CloudStorageAccount.Parse(My.Settings("StorageConnectionString"))
        Dim fileClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()
        Dim share As CloudBlobContainer = fileClient.GetContainerReference("csdata")
        Application.DoEvents()

        Try

            ' Process each file 
            For i As Integer = 0 To Files.Length - 1
                Me.SetDescription("Updating file: " & i + 1 & " of " & Files.Length & " - " & Files(i))
                Application.DoEvents()
                Try
                    ' try to rename the current file before download the new one
                    ' this is a good procedure since the file can be in use
                    IO.File.Move(Application.StartupPath & "\" & Files(i), Application.StartupPath & "\" & Now.TimeOfDay.TotalMilliseconds & ".old")
                Catch ex As Exception
                End Try
                ' download the new version
                Dim sourceFile As CloudBlockBlob = share.GetBlockBlobReference(Files(i))
                sourceFile.DownloadToFile(Application.StartupPath & "\" & Files(i), IO.FileMode.Create)

            Next
            ' Call back the system with the original command line 
            ' with the key at the end
            System.Diagnostics.Process.Start(ExeFile, CommandLine & Key)
            ' do some clean up -  delete all .old files (if possible) 
            ' in the current directory
            ' if some file stays it will be cleaned next time
            Dim S As String = Dir(Application.StartupPath & "\*.old")
            Do While S <> ""
                Application.DoEvents()
                Try
                    IO.File.Delete(Application.StartupPath & "\" & S)
                Catch ex As Exception
                End Try
                S = Dir()
            Loop
        Catch ex As Exception
            ' something went wrong... 
            MsgBox("There was a problem runing the Auto Update." & vbCr &
                "Please Contact IT Department" & vbCr & ex.Message,
                MsgBoxStyle.Critical)
        End Try
    End Sub


End Class
