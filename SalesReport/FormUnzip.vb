Public Class FormUnzip
    Public ficheiro As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '500 is equal to half a second.
        lblUnzipBlink.Text = "Unziping " & ficheiro & "..."
        Timer1.Interval = 250
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Timer1.Tag = True Then
            lblUnzipBlink.Text = "Unziping " & ficheiro & "..."
            Timer1.Tag = False
        Else
            lblUnzipBlink.Text = ""
            Timer1.Tag = True
        End If
    End Sub





End Class
