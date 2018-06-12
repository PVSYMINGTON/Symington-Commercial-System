Imports System.Net

Public Class FormCopyFTP
    Dim stopCopy As Boolean
    Public Sub button1_Click(ByVal SourceFilename As String, ByVal DestinationFilename As String)
        lblProgressStatus.Text = "Ligando à Cloud Symington"
        lblStatus.Text = SourceFilename
        pb.Properties.Step = 1
        pb.Properties.PercentView = True
        pb.Properties.Maximum = 4000
        pb.Properties.Minimum = 0


        Application.DoEvents()
        stopCopy = False

        Dim usn As String = "CommercialSystem\pedroventura"
        Dim PWD As String = "gusto8720"
        Dim ftpfullURI As String = "ftp://waws-prod-am2-019.ftp.azurewebsites.windows.net/"


        Dim FTPRequest As FtpWebRequest = FtpWebRequest.Create(ftpfullURI & "/" & SourceFilename)
        With FTPRequest
            .EnableSsl = False
            .Credentials = New NetworkCredential(usn, pwd)
            .KeepAlive = False
            .UseBinary = True
            .UsePassive = True
            .Method = System.Net.WebRequestMethods.Ftp.DownloadFile
        End With

        '   RaiseEvent Trace(Me, "FTPDownload() logging onto ftp")
        Try

            Using FTPResponse As System.Net.FtpWebResponse = CType(FTPRequest.GetResponse, System.Net.FtpWebResponse)
                lblProgressStatus.Text = "Ligado"
                Using responseStream As IO.Stream = FTPResponse.GetResponseStream
                    Using fs As New IO.FileStream(DestinationFilename, IO.FileMode.Create)
                        Dim buffer(2047) As Byte
                        Dim read As Integer = 0

                        Do
                            read = responseStream.Read(buffer, 0, buffer.Length)
                            fs.Write(buffer, 0, read)
                            pb.PerformStep()
                            pb.Update()
                            Application.DoEvents()

                        Loop Until read = 0
                        responseStream.Close()
                        fs.Flush()
                        fs.Close()

                    End Using
                    responseStream.Close()
                End Using
                FTPResponse.Close()
            End Using

        Catch ex As Exception
            MsgBox("Problema na ligação à Internet!")
        End Try




    End Sub




    Private Sub FormCopy_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
