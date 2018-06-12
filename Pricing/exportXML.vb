Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports System.Net
Imports System.Data.SQLite
Imports SAP.Middleware.Connector
Imports System.Windows.Forms

Public Class exportXML



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Cursor.Current = Cursors.WaitCursor

        Dim strsql As String
        Dim reader As SQLiteDataReader
        strsql = "SELECT * FROM paprixf"
        Dim UserIdentityInfo As System.Security.Principal.WindowsIdentity
        ''     Dim strMsg As String
        UserIdentityInfo = System.Security.Principal.WindowsIdentity.GetCurrent()
        UserIdentityInfo.Name.ToString.Remove(0, 10)

        'Dim filenamestr As String = UserIdentityInfo.Name.ToString.Remove(0, 10) & Format(Now, "ddMMhhmmss") & ".XML"
        Dim sqlcommand1 As New SQLiteCommand
        Dim SqlConnection1 As New SQLiteConnection With {
            .ConnectionString = "data source=c:\CommercialSystem\dados\SapPricingupdate.db3"
        }
        sqlcommand1.CommandText = strsql
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        reader = sqlcommand1.ExecuteReader

        Dim ret As String
        While reader.Read


            'o	ZPSY	Preço Symington
            If IsDBNull(reader("PCPVAC")) = False Then
                If reader("PCPVAC") = 0 Then
                    ret = CallRFCSapDeletepricing("ZPSY", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("PCPVAC"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZPSY", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("PCPVAC"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZDEV")) = False Then
                If reader("ZDEV") = 0 Then
                    ret = CallRFCSapDeletepricing("ZDEV", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDEV"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZDEV", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDEV"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZDEP")) = False Then
                If reader("ZDEP") = 0 Then
                    ret = CallRFCSapDeletepricing("ZDEP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDEP"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZDEP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDEP"), reader("TABELA"), reader("vrkme"), False, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZDQV")) = False Then
                If reader("ZDQV") = 0 Then
                    ret = CallRFCSapDeletepricing("ZDQV", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDQV"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZDQV", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDQV"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZDQP")) = False Then
                If reader("ZDQP") = 0 Then
                    ret = CallRFCSapDeletepricing("ZDQP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDQP"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZDQP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDQP"), reader("TABELA"), reader("vrkme"), False, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZDPV")) = False Then
                If reader("ZDPV") = 0 Then
                    ret = CallRFCSapDeletepricing("ZDPV", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDPV"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZDPV", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDPV"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZDPP")) = False Then
                If reader("ZDPP") = 0 Then
                    ret = CallRFCSapDeletepricing("ZDPP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDPP"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZDPP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDPP"), reader("TABELA"), reader("vrkme"), False, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZDRV")) = False Then
                If reader("ZDRV") = 0 Then
                    ret = CallRFCSapDeletepricing("ZDRV", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDRV"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZDRV", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDRV"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZDRP")) = False Then
                If reader("ZDRP") = 0 Then
                    ret = CallRFCSapDeletepricing("ZDRP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDRP"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZDRP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDRP"), reader("TABELA"), reader("vrkme"), False, reader("AnoPricing"))
                    If ret <> 0 Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZDLV")) = False Then
                If reader("ZDLV") = 0 Then
                    ret = CallRFCSapDeletepricing("ZDLV", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDLV"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZDLV", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDLV"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZDLP")) = False Then
                If reader("ZDLP") = 0 Then
                    ret = CallRFCSapDeletepricing("ZDLP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDLP"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZDLP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDLP"), reader("TABELA"), reader("vrkme"), False, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If


            If IsDBNull(reader("ZDTV")) = False Then
                If reader("ZDTV") = 0 Then
                    ret = CallRFCSapDeletepricing("ZDTV", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDTV"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZDTV", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDTV"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZDTP")) = False Then
                If reader("ZDTP") = 0 Then
                    ret = CallRFCSapDeletepricing("ZDTP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDTP"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZDTP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZDTP"), reader("TABELA"), reader("vrkme"), False, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZEEC")) = False Then
                If reader("ZEEC") = 0 Then
                    ret = CallRFCSapDeletepricing("ZEEC", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZEEC"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZEEC", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZEEC"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZEFR")) = False Then
                If reader("ZEFR") = 0 Then
                    ret = CallRFCSapDeletepricing("ZEFR", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZEFR"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZEFR", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZEFR"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZEIN")) = False Then
                If reader("ZEIN") = 0 Then
                    ret = CallRFCSapDeletepricing("ZEIN", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZEIN"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZEIN", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZEIN"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZEFI")) = False Then
                If reader("ZEFI") = 0 Then
                    ret = CallRFCSapDeletepricing("ZEFI", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZEFI"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZEFI", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZEFI"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If


            If IsDBNull(reader("ZESL")) = False Then
                If reader("ZESL") = 0 Then
                    ret = CallRFCSapDeletepricing("ZESL", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZESL"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZESL", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZESL"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("ZESP")) = False Then
                If reader("ZESP") = 0 Then
                    ret = CallRFCSapDeletepricing("ZESP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZESP"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                Else
                    ret = CallRFCSapInsertpricing("ZESP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("ZESP"), reader("TABELA"), reader("vrkme"), True, reader("AnoPricing"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If

            If IsDBNull(reader("KNRMM")) = False And IsDBNull(reader("KNRNM")) = False And IsDBNull(reader("KNRZM")) = False Then
                If reader("KNRMM") = 0 And reader("KNRNM") = 0 And reader("KNRZM") = 0 Then
                    '  ret = callRFCSapDeleteFreeGoods("ZESP", reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCCPRP"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("PCPVAC"), reader("TABELA"), reader("vrkme"), True)
                    'If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                    MsgBox("Atenção!! Não pode zerar os 'Bonus de quantidade'!!")

                Else
                    ret = CallRFCSapInsertFreeGoods(reader("KNRMM"), reader("KNRNM"), reader("KNRZM"), reader("PCCCLI"), reader("PCCLID"), reader("PCMOED"), reader("PCCPRO"), reader("PCTPRE"), reader("PCDATI"), reader("PCDATF"), reader("TABELA"), reader("vrkme"))
                    If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
                End If
            End If




        End While

        reader.Close()
        sqlcommand1 = Nothing


        Insertestipulacoes()


        ret = CallDTS()
        If ret = "Erro" Then
            Cursor.Current = Cursors.WaitCursor
            Me.Close()
            Exit Sub
        End If

        Dim myConnection As New SQLiteConnection
        Dim myCommand As SQLiteCommand
        Dim myCommand2 As SQLiteCommand
        myConnection.ConnectionString = "data source=c:\CommercialSystem\dados\SapPricingupdate.db3"
        myConnection.Open()
        myCommand = New SQLiteCommand("DELETE FROM paprixf", myConnection)
        myCommand.ExecuteNonQuery()

        myCommand2 = New SQLiteCommand("DELETE FROM SapEstipulacoes", myConnection)
        myCommand2.ExecuteNonQuery()

        myConnection.Close()







        Cursor.Current = Cursors.WaitCursor
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Public Function CallDTS()

        Dim jobConnection As SqlConnection
        Dim jobCommand As SqlCommand
        Dim jobReturnValue As SqlParameter
        Dim jobParameter As SqlParameter
        Dim jobResult As Integer

        jobConnection = New SqlConnection(My.MySettings.Default.sqlserverdts)
        jobCommand = New SqlCommand("sp_start_job", jobConnection) With {
            .CommandType = CommandType.StoredProcedure
        }

        jobReturnValue = New SqlParameter("@RETURN_VALUE", SqlDbType.Int) With {
            .Direction = ParameterDirection.ReturnValue
        }
        jobCommand.Parameters.Add(jobReturnValue)

        jobParameter = New SqlParameter("@job_name", SqlDbType.VarChar) With {
            .Direction = ParameterDirection.Input
        }
        jobCommand.Parameters.Add(jobParameter)
        jobParameter.Value = "SAP_CS_UpdatePricing"

        jobConnection.Open()
        Try
            jobCommand.ExecuteNonQuery()
            jobResult = DirectCast(jobCommand.Parameters("@RETURN_VALUE").Value, Integer)
        Catch
            Dim jobCommand2 As SqlCommand
            Dim jobReturnValue2 As SqlParameter
            Dim jobParameter2 As SqlParameter
            Dim jobResult2 As Integer


            jobCommand2 = New SqlCommand("sp_start_job", jobConnection) With {
                .CommandType = CommandType.StoredProcedure
            }

            jobReturnValue2 = New SqlParameter("@RETURN_VALUE", SqlDbType.Int) With {
                .Direction = ParameterDirection.ReturnValue
            }
            jobCommand2.Parameters.Add(jobReturnValue2)
            jobParameter2 = New SqlParameter("@job_name", SqlDbType.VarChar) With {
                .Direction = ParameterDirection.Input
            }
            jobCommand2.Parameters.Add(jobParameter2)
            jobParameter2.Value = "SAP_CS_UpdatePricing_fallback"
            Try
                jobCommand2.ExecuteNonQuery()
                jobResult2 = DirectCast(jobCommand2.Parameters("@RETURN_VALUE").Value, Integer)
                MsgBox("A alteração vai ser submetida com 2 minutos de atraso devido ao servidor estar ocupado", MsgBoxStyle.Information)
            Catch
                MsgBox("A alteração não vai ser submetida pois o servidor devolveu um erro! Volte a enviar dentro de alguns minutos, s.f.f.", MsgBoxStyle.Critical)
                Return "Erro"

            End Try

        End Try

        jobConnection.Close()

        Select Case jobResult
            Case 0

            Case Else
                MsgBox("SQL Server Agent job, RunSISSPackage, failed to start.")
        End Select


#Disable Warning BC42105 ' Function 'callDTS' doesn't return a value on all code paths. A null reference exception could occur at run time when the result is used.
    End Function
#Enable Warning BC42105 ' Function 'callDTS' doesn't return a value on all code paths. A null reference exception could occur at run time when the result is used.

    Private Function CallRFCSapInsertpricing(kschl As String, kunnr As String, zcldest As String, waerk As String, matnr As String, upmat As String, pltyp As String, datab As String, datbi As String, kbetr As Decimal, tabela As String, vrkme As String, applykpein As Boolean, zzano As String) As String


        Try
            Dim SapRfcDestination As RfcDestination = RfcDestinationManager.GetDestination("PRD")
            'Dim SapRfcDestination As RfcDestination = RfcDestinationManager.GetDestination("DEV")
            Dim SapRfcRepository As RfcRepository = SapRfcDestination.Repository
            Dim funcaoSAP As IRfcFunction = SapRfcRepository.CreateFunction("ZSD_INSERT_PRICING_RFC")
            Dim tabelaSAP As IRfcStructure = funcaoSAP.GetStructure("TABELA")
            tabelaSAP.SetValue("kschl", kschl)
            tabelaSAP.SetValue("kunnr", kunnr)
            tabelaSAP.SetValue("ZCLDEST", zcldest)
            tabelaSAP.SetValue("waerk", waerk)
            tabelaSAP.SetValue("matnr", matnr)
            tabelaSAP.SetValue("upmat", upmat)
            tabelaSAP.SetValue("pltyp", pltyp)
            tabelaSAP.SetValue("datab", datab)
            tabelaSAP.SetValue("datbi", datbi)
            tabelaSAP.SetValue("ZZANO", zzano)

            Dim finddec As Decimal = kbetr * 100
            If Int(finddec) <> finddec And applykpein = True Then
                tabelaSAP.SetValue("kbetr", kbetr * 10)
                tabelaSAP.SetValue("kpein", 10)
            Else
                tabelaSAP.SetValue("kbetr", kbetr)
                tabelaSAP.SetValue("kpein", 1)
            End If

            tabelaSAP.SetValue("tabela", tabela)
            tabelaSAP.SetValue("vrkme", vrkme)

            funcaoSAP.Invoke(SapRfcDestination)
            Return "0 "
        Catch ex As Exception

            MessageBox.Show(String.Concat("RfcDestinationManager exception: ", ex.Message), " Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return "error"
        End Try


    End Function

    Private Function CallRFCSapDeletepricing(kschl As String, kunnr As String, zcldest As String, waerk As String, matnr As String, upmat As String, pltyp As String, datab As String, datbi As String, kbetr As Decimal, tabela As String, vrkme As String, applykpein As Boolean, zzano As String) As String


        Try
            Dim SapRfcDestination As RfcDestination = RfcDestinationManager.GetDestination("PRD")
            'Dim SapRfcDestination As RfcDestination = RfcDestinationManager.GetDestination("DEV")
            Dim SapRfcRepository As RfcRepository = SapRfcDestination.Repository
            Dim funcaoSAP As IRfcFunction = SapRfcRepository.CreateFunction("ZSD_DELETE_PRICING_RFC")
            Dim tabelaSAP As IRfcStructure = funcaoSAP.GetStructure("TABELA")
            tabelaSAP.SetValue("kschl", kschl)
            tabelaSAP.SetValue("kunnr", kunnr)
            tabelaSAP.SetValue("ZCLDEST", zcldest)
            tabelaSAP.SetValue("waerk", waerk)
            tabelaSAP.SetValue("matnr", matnr)
            tabelaSAP.SetValue("upmat", upmat)
            tabelaSAP.SetValue("pltyp", pltyp)
            tabelaSAP.SetValue("datab", datab)
            tabelaSAP.SetValue("datbi", datbi)
            tabelaSAP.SetValue("ZZANO", zzano)

            Dim finddec As Decimal = kbetr * 100
            If Int(finddec) <> finddec And applykpein = True Then
                tabelaSAP.SetValue("kbetr", kbetr * 10)
                tabelaSAP.SetValue("kpein", 10)
            Else
                tabelaSAP.SetValue("kbetr", kbetr)
                tabelaSAP.SetValue("kpein", 1)
            End If

            tabelaSAP.SetValue("tabela", tabela)
            tabelaSAP.SetValue("vrkme", vrkme)

            funcaoSAP.Invoke(SapRfcDestination)
            Return "0 "
        Catch ex As Exception

            MessageBox.Show(String.Concat("RfcDestinationManager exception: ", ex.Message), " Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return "error"
        End Try


    End Function

    Private Function CallRFCSapInsertFreeGoods(KNRMM As Decimal, KNRNM As Decimal, KNRZM As Decimal, kunnr As String, zcldest As String, waerk As String, matnr As String, pltyp As String, pcdati As String, pcdatf As String, tabela As String, vrkme As String) As String
        Dim Varkey As String
        Dim tabelabonus As String

        If tabela = 943 Then
            tabelabonus = 933
            Varkey = kunnr & zcldest & waerk.PadRight(5) & matnr.PadRight(18) & pltyp
        ElseIf tabela = 944 Then
            tabelabonus = 934
            Varkey = kunnr & waerk.PadRight(5) & matnr.PadRight(18) & pltyp

        ElseIf tabela = 946 Then ''''alemanha -  clidest contem cliente estatistico
            tabelabonus = 936
            Varkey = zcldest & waerk.PadRight(5) & matnr.PadRight(18) & pltyp
        Else
            Return "Bonus de Quantidade - Tabela desconhecida"
            Exit Function
        End If

        Try
            Dim SapRfcDestination As RfcDestination = RfcDestinationManager.GetDestination("PRD")
            'Dim SapRfcDestination As RfcDestination = RfcDestinationManager.GetDestination("DEV")
            Dim SapRfcRepository As RfcRepository = SapRfcDestination.Repository
            Dim funcaoSAP As IRfcFunction = SapRfcRepository.CreateFunction("ZSD_INSERT_FREEGOODS_RFC")
            Dim tabelaSAPBAPICONDCT As IRfcStructure = funcaoSAP.GetStructure("LS_BAPICONDCT")
            With tabelaSAPBAPICONDCT
                .SetValue("OPERATION", "001")
                .SetValue("COND_USAGE", "N")
                '.SetValue("TABLE_NO", "933")
                .SetValue("TABLE_NO", tabelabonus)
                .SetValue("APPLICATIO", "V")
                .SetValue("COND_TYPE", "ZNA0")
                '.SetValue("VARKEY", "00000007650000000765EUR  045324A002#G      G")
                .SetValue("VARKEY", Varkey)
                '.SetValue("VALID_TO", "20131231")
                .SetValue("VALID_TO", pcdatf)
                '.SetValue("VALID_FROM", "20130101")
                .SetValue("VALID_FROM", pcdati)
                .SetValue("COND_NO", "$")
            End With
            Dim tabelaSAPBAPICONDFG As IRfcStructure = funcaoSAP.GetStructure("LS_BAPICONDFG")
            With tabelaSAPBAPICONDFG
                .SetValue("OPERATION", "001")
                .SetValue("COND_NO", "$")
                ' .SetValue("MIN_FG_QNT", "2")
                .SetValue("MIN_FG_QNT", KNRMM)
                '.SetValue("FG_QNT", "2")
                .SetValue("FG_QNT", KNRNM)
                '.SetValue("UNITFG_QNT", "CX")
                .SetValue("UNITFG_QNT", vrkme)
                '.SetValue("ADD_FG_QNT", "3")
                .SetValue("ADD_FG_QNT", KNRZM)
                '.SetValue("UNITADDQNT", "CX")
                .SetValue("UNITADDQNT", vrkme)
                .SetValue("CALC_TYPE", "2")
                .SetValue("EXCL_INCL", "2")
                .SetValue("EXCL_INCL", "2")
                .SetValue("COND_USAGE", "N")
                .SetValue("TABLE_NO", tabelabonus)
                .SetValue("APPLICATIO", "V")
                .SetValue("COND_TYPE", "ZNA0")
                .SetValue("VARKEY", Varkey)



            End With



            funcaoSAP.Invoke(SapRfcDestination)
            Return "0 "
        Catch ex As Exception

            MessageBox.Show(String.Concat("RfcDestinationManager exception: ", ex.Message), " Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return "Erro ao inserir Bonus em SAP."
        End Try


    End Function

    Public Sub Insertestipulacoes()

        Dim strsql As String
        Dim reader As SQLiteDataReader
        strsql = "SELECT * FROM SapEstipulacoes"
        Dim UserIdentityInfo As System.Security.Principal.WindowsIdentity
        ''     Dim strMsg As String
        UserIdentityInfo = System.Security.Principal.WindowsIdentity.GetCurrent()
        UserIdentityInfo.Name.ToString.Remove(0, 10)

        'Dim filenamestr As String = UserIdentityInfo.Name.ToString.Remove(0, 10) & Format(Now, "ddMMhhmmss") & ".XML"
        Dim sqlcommand1 As New SQLiteCommand
        Dim SqlConnection1 As New SQLiteConnection With {
            .ConnectionString = "data source=c:\CommercialSystem\dados\SapPricingupdate.db3"
        }
        sqlcommand1.CommandText = strsql
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        reader = sqlcommand1.ExecuteReader

        Dim ret As String
        While reader.Read
            If UCase(reader("operacao")) = "INSERT" Then
                ret = CallRFCSapInsertEstipulacao(reader("kschl"), reader("knuma"), reader("boart"), reader("kunnr"), reader("zcldest"), reader("waerk"), reader("matnr"), reader("pltyp"), reader("datab"), reader("datbi"), reader("kbetr"), reader("kmein"), reader("vkorg"), reader("operacao"))
                If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
            ElseIf UCase(reader("operacao")) = "UPDATE" Then
                ret = CallRFCSapUpdateEstipulacao(reader("kschl"), reader("knuma"), reader("boart"), reader("kunnr"), reader("zcldest"), reader("waerk"), reader("matnr"), reader("pltyp"), reader("datab"), reader("datbi"), reader("kbetr"), reader("kmein"), reader("vkorg"), reader("operacao"))
                If ret <> "0 " Then MsgBox("Erro - " & ret, MsgBoxStyle.Critical) : Exit Sub
            End If

        End While
        reader.Close()
        sqlcommand1 = Nothing


    End Sub

    Private Function CallRFCSapInsertEstipulacao(kschl As String, knuma As String, boart As String, kunnr As String, zcldest As String, waerk As String, matnr As String, pltyp As String, datab As String, datbi As String, kbetr As Decimal, kmein As String, vkorg As String, operacao As String) As String


        Try
            Dim SapRfcDestination As RfcDestination = RfcDestinationManager.GetDestination("PRD")
            'Dim SapRfcDestination As RfcDestination = RfcDestinationManager.GetDestination("DEV")
            Dim SapRfcRepository As RfcRepository = SapRfcDestination.Repository
            Dim funcaoSAP As IRfcFunction = SapRfcRepository.CreateFunction("ZSD_INSERT_ESTIPULACOES_RFC")
            Dim tabelaSAP As IRfcStructure = funcaoSAP.GetStructure("Tabela")

            With tabelaSAP

                tabelaSAP.SetValue("kschl", kschl)
                tabelaSAP.SetValue("knuma", knuma)
                tabelaSAP.SetValue("boart", boart)

                tabelaSAP.SetValue("kunnr", kunnr)
                tabelaSAP.SetValue("ZCLDEST", zcldest)
                tabelaSAP.SetValue("waerk", waerk)
                tabelaSAP.SetValue("ZZPMATNSD", matnr)
                tabelaSAP.SetValue("pltyp", pltyp)
                tabelaSAP.SetValue("datab", datab)
                tabelaSAP.SetValue("datbi", datbi)
                tabelaSAP.SetValue("kbetr", kbetr)
                tabelaSAP.SetValue("kmein", kmein)
                tabelaSAP.SetValue("vkorg", vkorg)

            End With


            funcaoSAP.Invoke(SapRfcDestination)
            Return "0 "
        Catch ex As Exception

            MessageBox.Show(String.Concat("RfcDestinationManager exception: ", ex.Message), " Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return "Erro ao inserir Estipulacao em SAP."
        End Try


    End Function

    Private Function CallRFCSapUpdateEstipulacao(kschl As String, knuma As String, boart As String, kunnr As String, zcldest As String, waerk As String, matnr As String, pltyp As String, datab As String, datbi As String, kbetr As Decimal, kmein As String, vkorg As String, operacao As String) As String


        Try
            Dim SapRfcDestination As RfcDestination = RfcDestinationManager.GetDestination("PRD")
            'Dim SapRfcDestination As RfcDestination = RfcDestinationManager.GetDestination("DEV")
            Dim SapRfcRepository As RfcRepository = SapRfcDestination.Repository
            Dim funcaoSAP As IRfcFunction = SapRfcRepository.CreateFunction("ZSD_UPDATE_ESTIPULACOES_RFC")
            Dim tabelaSAP As IRfcStructure = funcaoSAP.GetStructure("Tabela")

            With tabelaSAP

                tabelaSAP.SetValue("kschl", kschl)
                tabelaSAP.SetValue("knuma", knuma)
                tabelaSAP.SetValue("boart", boart)

                tabelaSAP.SetValue("kunnr", kunnr)
                tabelaSAP.SetValue("ZCLDEST", zcldest)
                tabelaSAP.SetValue("waerk", waerk)
                tabelaSAP.SetValue("ZZPMATNSD", matnr)
                tabelaSAP.SetValue("pltyp", pltyp)
                tabelaSAP.SetValue("datab", datab)
                tabelaSAP.SetValue("datbi", datbi)
                tabelaSAP.SetValue("kbetr", kbetr)
                tabelaSAP.SetValue("kmein", kmein)
                tabelaSAP.SetValue("vkorg", vkorg)


            End With


            funcaoSAP.Invoke(SapRfcDestination)
            Return "0 "
        Catch ex As Exception

            MessageBox.Show(String.Concat("RfcDestinationManager exception: ", ex.Message), " Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return "Erro ao alterar Estipulacao em SAP."
        End Try


    End Function




End Class


