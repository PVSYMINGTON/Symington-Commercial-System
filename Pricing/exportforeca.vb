Public Class exportforecasts

    Private Sub export_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strsql As String
        Dim reader As System.Data.OleDb.OleDbDataReader
        strsql = "foreca2"
        Dim UserIdentityInfo As System.Security.Principal.WindowsIdentity
        ''     Dim strMsg As String
        UserIdentityInfo = System.Security.Principal.WindowsIdentity.GetCurrent()
        UserIdentityInfo.Name.ToString.Remove(0, 10)

        Dim filenamestr As String = UserIdentityInfo.Name.ToString.Remove(0, 10) & Format(Now, "ddMMhhmmss") & ".FFF"
        Dim sqlcommand1 As New OleDb.OleDbCommand
        Dim SqlConnection1 As New OleDb.OleDbConnection
        SqlConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\CommercialSystem\dados\pricingupdate.mdb;Jet OLEDB:Database Password=?$S&F&E?+$;Mode=Read;"
        sqlcommand1.CommandText = strsql
        sqlcommand1.CommandType = CommandType.TableDirect
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        reader = sqlcommand1.ExecuteReader
        Dim flagheader As Boolean = False
        Dim w As IO.StreamWriter
        Dim i As Integer
        Dim col As Integer
        w = New IO.StreamWriter(filenamestr)
        While reader.Read
            If flagheader = False Then
                For i = 0 To reader.FieldCount - 1
                    If i <> 66 Then
                        w.Write(reader.GetName(i))
                        If i < reader.FieldCount - 1 Then
                            w.Write(";")
                        End If
                    End If
                Next i
                w.Write(w.NewLine)
            End If
            flagheader = True

            For col = 0 To reader.FieldCount - 1
                If col <> 66 Then
                    w.Write(Trim(reader.Item(col).ToString))
                    If col < reader.FieldCount - 1 Then
                        w.Write(";")
                    End If
                End If
            Next col
            w.Write(w.NewLine)
        End While
        w.Close()
        reader.Close()
        sqlcommand1 = Nothing

        Try
            Dim clsRequest As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://192.168.0.5:50/" & filenamestr), System.Net.FtpWebRequest)
            clsRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile
            Dim bFile() As Byte = System.IO.File.ReadAllBytes(filenamestr)
            Dim clsStream As System.IO.Stream = clsRequest.GetRequestStream()
            clsStream.Write(bFile, 0, bFile.Length)
            clsStream.Close()
            clsStream.Dispose()
        Catch
            Try
                IO.File.Copy(filenamestr, "\\srvappdb\ftp\" & filenamestr)
            Catch ex As Exception
                MsgBox("Erro na ligação ao servidor", MsgBoxStyle.Critical)
                IO.File.Delete(filenamestr)
                Me.Close()
                Exit Sub
            End Try
        End Try

        Dim myConnection As OleDb.OleDbConnection
        Dim myCommand As OleDb.OleDbCommand
        myConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\CommercialSystem\dados\pricingupdate.mdb;Jet OLEDB:Database Password=?$S&F&E?+$")
        myConnection.Open()
        myCommand = New OleDb.OleDbCommand("DELETE FROM foreca2", myConnection)
        myCommand.ExecuteNonQuery()
        myConnection.Close()
        IO.File.Delete(filenamestr)
        MsgBox("OK", MsgBoxStyle.Information)

        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class