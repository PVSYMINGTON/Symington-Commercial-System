Public Class FormCopy
    Dim stopCopy As Boolean
    Public Sub button1_Click(ByVal SourceFilename As String, ByVal DestinationFilename As String)
        lblProgressStatus.Text = ""
        lblStatus.Text = SourceFilename
        pb.Value = 0
        Application.DoEvents()
        stopCopy = False
        Dim oFS As New FileSystem()

        AddHandler oFS.CopyProgress, AddressOf oFS_CopyProgress
        Try

      
        Dim success As Boolean = oFS.CopyFile(SourceFilename, DestinationFilename)
        If success Then
          
            lblProgressStatus.Text = "File copied successfully"
        Else
            lblProgressStatus.Text = "File was not copied successfully"
        End If
        Catch ex As Exception
            MsgBox("Erro! Verifique a sua ligação à rede")
        End Try


    End Sub


    Private Sub oFS_CopyProgress(ByVal sender As Object, ByVal e As FileSystem.CopyProgressEventArgs)
        lblProgressStatus.Text = String.Format("Copied {0} of {1}, {2:P} done, ETA:{3}", e.copiedBytes, e.totalBytes, e.percentage, New TimeSpan(0, 0, 0, 0, CInt(e.eta)).ToString())
        pb.Value = CInt((e.percentage * 100))
        Application.DoEvents()
        If stopCopy Then
            e.Cancel = True
        End If
    End Sub


    Private Sub FormCopy_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
