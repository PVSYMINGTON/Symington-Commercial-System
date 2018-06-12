Imports System.Data.SqlClient
Imports System.Linq

Imports System.Data.DataTableExtensions
Imports EnterpriseDT.Net.Ftp

Public Class CreateForecast
    Public retrow As New Collection
    Public ExportSAP As Boolean = False


    Private Function GetLastDayOfLastMonth() As Integer
        Dim dtTo As New DateTime(Now.Year, Now.Month - 1, 1)
        dtTo = dtTo.AddMonths(1)
        dtTo = dtTo.AddDays(-(dtTo.Day))
        Return dtTo.Day
    End Function




    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click

        If MsgBox("Ano: " & YearValue.EditValue & " - FQ: " & FQValue.EditValue, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Me.Enabled = False


        If FQValue.EditValue = 1 Then
            ''Se for escolhido o FQ 1 - copiar do target  e aplicar percentagens  

            calcularFQ1()
        ElseIf FQValue.EditValue = 5 Then
            calcularFQ5()
        Else
            calcularFQ2_3_4()

        End If
        SimpleButton1.Text = "Criar FQ..."
        Me.Cursor = Cursors.Default
        Me.Enabled = True

    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        If MsgBox("Ano: " & YearValue.EditValue & " - FQ: " & FQValue.EditValue, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Me.Enabled = False


        If FQValue.EditValue = 1 Then
            ''Se for escolhido o FQ 1 - copiar do target  e aplicar percentagens  
            calcularFQ1STAT()
        ElseIf FQValue.EditValue = 5 Then
            calcularFQ5_Stat()
        Else
            calcularFQ2_3_4STAT()
        End If
        SimpleButton3.Text = "Criar FQ Statistic..."
        Me.Cursor = Cursors.Default
        Me.Enabled = True
    End Sub


    Private Sub CreateForecast_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'SalesSystemDataSet2.SapSalesCS' table. You can move, or remove it, as needed.
        'Me.SapSalesCSTableAdapter.Fill(Me.SalesSystemDataSet2.SapSalesCS)

        YearValue.Value = Now.Year
        If ExportSAP = False Then
            Dim cnn As New SqlConnection ' OleDbConnection
            cnn.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
            cnn.Open()
            Dim sqlcommandPercentagens As New SqlCommand ' 
            sqlcommandPercentagens.Connection = cnn
            sqlcommandPercentagens.CommandText = "select * from SapForecastMonthPer where year =" & YearValue.EditValue
            Dim ret = sqlcommandPercentagens.ExecuteReader(CommandBehavior.SingleRow)

            While ret.Read
                retrow.Add(ret(1), "1")
                retrow.Add(ret(2), "2")
                retrow.Add(ret(3), "3")
                retrow.Add(ret(4), "4")
                retrow.Add(ret(5), "5")
                retrow.Add(ret(6), "6")
                retrow.Add(ret(7), "7")
                retrow.Add(ret(8), "8")
                retrow.Add(ret(9), "9")
                retrow.Add(ret(10), "10")
                retrow.Add(ret(11), "11")
                retrow.Add(ret(12), "12")
            End While
            cnn.Close()
            SimpleButton1.Enabled = True
            SimpleButton2.Enabled = False

        Else
            SimpleButton1.Enabled = False
            SimpleButton2.Enabled = True
        End If

    End Sub

    Private Function calcularValoresforecastrestante(flagMes As Integer, p1 As Object, p2 As Object, p3 As Object, p4 As Object, p5 As Object, p6 As Object, p7 As Object, p8 As Object, p9 As Object, p10 As Object, p11 As Object, p12 As Object, pAnnual As Object)
        Dim valorrestante As Decimal = 0
        Select Case flagMes
            Case 1
                valorrestante = p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12
            Case 2
                valorrestante = p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12
            Case 3
                valorrestante = p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12
            Case 4
                valorrestante = p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12
            Case 5
                valorrestante = p6 + p7 + p8 + p9 + p10 + p11 + p12
            Case 6
                valorrestante = p7 + p8 + p9 + p10 + p11 + p12
            Case 7
                valorrestante = p8 + p9 + p10 + p11 + p12
            Case 8
                valorrestante = p9 + p10 + p11 + p12
            Case 9
                valorrestante = p10 + p11 + p12
            Case 10
                valorrestante = p11 + p12
            Case 11
                valorrestante = p12
        End Select


        Return valorrestante
    End Function


    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        GridControl1.Visible = True
        SPforecastskuTableAdapter.Fill(Me.SalesSystemDataSet2.SPforecastsku, CInt(YearValue.EditValue), CInt(FQValue.EditValue))
        GridView1.PopulateColumns()
        Dim stringfile = "c:\forecastSKU" & CInt(YearValue.EditValue) & CInt(FQValue.EditValue) & ".csv"
        Dim stringfileremote = "forecastSKU_" & CInt(YearValue.EditValue) & "_" & CInt(FQValue.EditValue) & ".csv"
        Dim exporttexto = New DevExpress.XtraPrinting.TextExportOptions
        exporttexto.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text
        exporttexto.Separator = ";"
        GridView1.ExportToText(stringfile, exporttexto)
        GridControl1.Visible = False
        Dim host As String = "192.168.0.2"
        Dim user As String = "sapftp"
        Dim password As String = "sapftp1234"

        Dim ftp As FTPClient = Nothing


        Try
            ftp = New FTPClient
            ftp.RemoteHost = host
            ftp.Connect()
            ftp.Login(user, password)
            ftp.ChDir("SAP")
            ftp.ChDir("QAS")
            ftp.ChDir("IN")
            ftp.ChDir("FORECAST")
            ftp.TransferType = FTPTransferType.BINARY
            ftp.Put(stringfile, stringfileremote)
            ftp.Quit()
            MsgBox("ok, ficheiro enviado...")
        Catch ex As Exception

            MsgBox(" Problemas as enviar a informação.  " & vbCrLf & ex.Message)

        End Try

        Dim stringfile2 = "c:\forecastSKU" & CInt(YearValue.EditValue) & CInt(FQValue.EditValue) & ".xlsx"

        '  Dim exportxlsx = New DevExpress.XtraPrinting.XlsxExportOptions
        ' exportxlsx.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text
        GridView1.ExportToXlsx(stringfile2)
        Process.Start(stringfile2)

    End Sub


    Private Sub calcularFQ1()
        Dim utilizador As String
        utilizador = UCase(GetSetting("SalesReports", "User", "login"))

        Dim cnn As New SqlConnection ' OleDbConnection
        cnn.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        Me.SapTarget2014TableAdapter.Fill(Me.SalesSystemDataSet2.SapTarget2014)


        cnn.Open()


        Try
            Dim row As DataRow
            For Each row In Me.SalesSystemDataSet2.SapTarget2014.Rows
                Dim quarter1, quarter2, quarter3, quarter4, total As Double

                ''''query às percentagens

                Dim sqlcommandQueryvendas As New SqlCommand
                sqlcommandQueryvendas.Connection = cnn
                sqlcommandQueryvendas.CommandText = "SELECT Qt1,Qt2,Qt3,Qt4 FROM  SapForecastQuarterDistribucion " _
                & "WHERE (Year = @Year) and (Period = @Period) and (Codigo = @Codigo)"

                sqlcommandQueryvendas.Parameters.AddWithValue("@Year", YearValue.EditValue) ' Ano
                sqlcommandQueryvendas.Parameters.AddWithValue("@Period", 1)   ' Mes
                sqlcommandQueryvendas.Parameters.AddWithValue("@Codigo", row(2))   ' Immaterial

                Dim result = sqlcommandQueryvendas.ExecuteReader

                While result.Read
                    quarter1 = result(0)
                    quarter2 = result(1)
                    quarter3 = result(2)
                    quarter4 = result(3)

                End While
                result.Close()

                total = quarter1 + quarter2 + quarter3 + quarter4


                Dim sqlcommand As New SqlCommand ' OleDbCommand
                sqlcommand.Connection = cnn

                Dim Quarter1final = 0, Quarter2final = 0, Quarter3final = 0, Quarter4final = 0
                Select Case total
                    Case 0
                        Quarter1final = row(6)
                    Case Else
                        Quarter1final = row(6) * If(total = 0, 0, (quarter1 / total))
                        Quarter2final = row(6) * If(total = 0, 0, (quarter2 / total))
                        Quarter3final = row(6) * If(total = 0, 0, (quarter3 / total))
                        Quarter4final = row(6) * If(total = 0, 0, (quarter4 / total))

                End Select

                Dim restanteacolocar As Double = row(6) - (Quarter1final + Quarter2final + Quarter3final + Quarter4final)

                If Not restanteacolocar = 0.0 Then
                    If Quarter4final > 0 Then
                        Quarter4final = Quarter4final + restanteacolocar

                    ElseIf (Quarter3final > 0) Then
                        Quarter3final = Quarter3final + restanteacolocar

                    ElseIf (Quarter2final > 0) Then
                        Quarter2final = Quarter2final + restanteacolocar

                    ElseIf (Quarter1final > 0) Then
                        Quarter1final = Quarter1final + restanteacolocar

                    End If


                End If

                sqlcommand.CommandText = "INSERT INTO SapForecast (CodCliFact, CodCliDest, Codigo, TPRE, Currency, Year, Period, Quarter1Value, Quarter2Value, Quarter3Value, Quarter4Value, AnualValue, UserCS, Target) VALUES(" _
                & "@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10,@param11," _
                & "@param20,@param21,@param22)"
                sqlcommand.Parameters.AddWithValue("@param1", row(0)) ' cliente fatura
                sqlcommand.Parameters.AddWithValue("@param2", row(1)) '  cliente destino
                sqlcommand.Parameters.AddWithValue("@param3", row(2))   ' Código
                sqlcommand.Parameters.AddWithValue("@param4", row(3))   ' Lista de preço
                sqlcommand.Parameters.AddWithValue("@param5", row(4))    ' moeda
                sqlcommand.Parameters.AddWithValue("@param6", YearValue.EditValue)   'ANO
                sqlcommand.Parameters.AddWithValue("@param7", FQValue.EditValue)   ' periodo
                sqlcommand.Parameters.AddWithValue("@param8", Quarter1final)   ' MES1
                sqlcommand.Parameters.AddWithValue("@param9", Quarter2final) ' MES2
                sqlcommand.Parameters.AddWithValue("@param10", Quarter3final)  ' MES3
                sqlcommand.Parameters.AddWithValue("@param11", Quarter4final)  ' MES4

                sqlcommand.Parameters.AddWithValue("@param20", row(5))   ' Annualvalue
                sqlcommand.Parameters.AddWithValue("@param21", utilizador) ' user
                sqlcommand.Parameters.AddWithValue("@param22", row(5)) ' TARGET9L
                Try
                    sqlcommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
                    Exit Sub
                End Try

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        cnn.Close()
    End Sub
    Private Sub calcularFQ1STAT()
        Dim utilizador As String
        utilizador = UCase(GetSetting("SalesReports", "User", "login"))
        Dim cnn As New SqlConnection ' OleDbConnection
        cnn.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        Me.SapTarget2014StatTableAdapter.Fill(Me.SalesSystemDataSet2.SapTarget2014STAT)


        cnn.Open()


        Try
            Dim row As DataRow
            For Each row In Me.SalesSystemDataSet2.SapTarget2014STAT.Rows
                Dim quarter1, quarter2, quarter3, quarter4, total As Double

                ''''query às percentagens

                Dim sqlcommandQueryvendas As New SqlCommand
                sqlcommandQueryvendas.Connection = cnn
                sqlcommandQueryvendas.CommandText = "SELECT Qt1,Qt2,Qt3,Qt4 FROM  SapForecastQuarterDistribucion " _
                & "WHERE (Year = @Year) and (Period = @Period) and (Codigo = @Codigo)"

                sqlcommandQueryvendas.Parameters.AddWithValue("@Year", YearValue.EditValue) ' Ano
                sqlcommandQueryvendas.Parameters.AddWithValue("@Period", 1)   ' Mes
                sqlcommandQueryvendas.Parameters.AddWithValue("@Codigo", row(1))   ' Immaterial

                Dim result = sqlcommandQueryvendas.ExecuteReader

                While result.Read
                    quarter1 = result(0)
                    quarter2 = result(1)
                    quarter3 = result(2)
                    quarter4 = result(3)

                End While
                result.Close()

                total = quarter1 + quarter2 + quarter3 + quarter4


                Dim sqlcommand As New SqlCommand ' OleDbCommand
                sqlcommand.Connection = cnn

                Dim Quarter1final = 0, Quarter2final = 0, Quarter3final = 0, Quarter4final = 0
                Select Case total
                    Case 0
                        Quarter1final = row(5)
                    Case Else
                        Quarter1final = row(5) * If(total = 0, 0, (quarter1 / total))
                        Quarter2final = row(5) * If(total = 0, 0, (quarter2 / total))
                        Quarter3final = row(5) * If(total = 0, 0, (quarter3 / total))
                        Quarter4final = row(5) * If(total = 0, 0, (quarter4 / total))

                End Select

                Dim restanteacolocar As Double = row(5) - (Quarter1final + Quarter2final + Quarter3final + Quarter4final)

                If Not restanteacolocar = 0.0 Then
                    If Quarter4final > 0 Then
                        Quarter4final = Quarter4final + restanteacolocar

                    ElseIf (Quarter3final > 0) Then
                        Quarter3final = Quarter3final + restanteacolocar

                    ElseIf (Quarter2final > 0) Then
                        Quarter2final = Quarter2final + restanteacolocar

                    ElseIf (Quarter1final > 0) Then
                        Quarter1final = Quarter1final + restanteacolocar

                    End If


                End If

                sqlcommand.CommandText = "INSERT INTO SapForecastStat (CodCliStat, Codigo, TPRE, Currency, Year, Period, Quarter1Value, Quarter2Value, Quarter3Value, Quarter4Value, AnualValue, UserCS, Target) VALUES(" _
                & "@param1,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10,@param11," _
                & "@param20,@param21,@param22)"
                sqlcommand.Parameters.AddWithValue("@param1", row(0)) ' cliente statistic
                'sqlcommand.Parameters.AddWithValue("@param2", row(1)) '  cliente destino
                sqlcommand.Parameters.AddWithValue("@param3", row(1))   ' Código
                sqlcommand.Parameters.AddWithValue("@param4", row(2))   ' Lista de preço
                sqlcommand.Parameters.AddWithValue("@param5", row(3))    ' moeda
                sqlcommand.Parameters.AddWithValue("@param6", YearValue.EditValue)   'ANO
                sqlcommand.Parameters.AddWithValue("@param7", FQValue.EditValue)   ' periodo
                sqlcommand.Parameters.AddWithValue("@param8", Quarter1final)   ' MES1
                sqlcommand.Parameters.AddWithValue("@param9", Quarter2final) ' MES2
                sqlcommand.Parameters.AddWithValue("@param10", Quarter3final)  ' MES3
                sqlcommand.Parameters.AddWithValue("@param11", Quarter4final)  ' MES4

                sqlcommand.Parameters.AddWithValue("@param20", row(4))   ' Annualvalue
                sqlcommand.Parameters.AddWithValue("@param21", utilizador) ' user
                sqlcommand.Parameters.AddWithValue("@param22", row(4)) ' TARGET9L
                Try
                    sqlcommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
                    Exit Sub
                End Try

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        cnn.Close()
    End Sub
    Private Sub calcularFQ2_3_4()
        Dim countrows As Integer = -1
        Dim utilizador As String
        utilizador = UCase(GetSetting("SalesReports", "User", "login"))
        ''''inserir novas linhas de Forecast para vendas realizadas depois do ultimo FQ
        ''''inserir novas linhas de Forecast para vendas realizadas depois do ultimo FQ

        Dim TableInserir As DataTable
        TableInserir = New DataTable("TableName")
        Dim columnCodCliFact As DataColumn = New DataColumn("CodCliFact")
        columnCodCliFact.DataType = System.Type.GetType("System.String")
        Dim columnCodCliDest As DataColumn = New DataColumn("CodCliDest")
        columnCodCliDest.DataType = System.Type.GetType("System.String")
        Dim columnCodigo As DataColumn = New DataColumn("Codigo")
        columnCodigo.DataType = System.Type.GetType("System.String")
        Dim columnTPRE As DataColumn = New DataColumn("TPRE")
        columnTPRE.DataType = System.Type.GetType("System.String")
        Dim columnCurrency As DataColumn = New DataColumn("Currency")
        columnCurrency.DataType = System.Type.GetType("System.String")

        TableInserir.Columns.Add(columnCodCliFact)
        TableInserir.Columns.Add(columnCodCliDest)
        TableInserir.Columns.Add(columnCodigo)
        TableInserir.Columns.Add(columnTPRE)
        TableInserir.Columns.Add(columnCurrency)

        Dim cnn3 As New SqlConnection ' OleDbConnection
        cnn3.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        cnn3.Open()
        Dim sqlcommandVendas As New SqlCommand ' OleDbCommand
        sqlcommandVendas.Connection = cnn3
        sqlcommandVendas.CommandText = "SELECT InvClientID, FinalClientID, [Immaterial Number], [Price List], Currency, SUM(ShippedUnits) AS ShippedUnits FROM SapImmaterialSales2 WHERE (SPTAG >= @datainicio) AND (SPTAG <= @datafim) GROUP BY InvClientID, FinalClientID, [Immaterial Number], [Price List], Currency"
        sqlcommandVendas.Parameters.AddWithValue("@datainicio", YearValue.EditValue & "-01-01")
        Dim ultimomes = Month(Now) - 1
        sqlcommandVendas.Parameters.AddWithValue("@datafim", YearValue.EditValue & "-" & ultimomes.ToString().PadLeft(2, "0") & "-" & GetLastDayOfLastMonth())

        Dim datareadervendas As SqlDataReader = sqlcommandVendas.ExecuteReader
        While datareadervendas.Read

            countrows = countrows + 1
            SimpleButton1.Text = "A verificar Vendas sem Forecast -> " & countrows
            Application.DoEvents()

            ''''''''Verificar se existe no FQ anterior
            Dim cnn5 As New SqlConnection ' OleDbConnection
            cnn5.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
            cnn5.Open()
            Dim sqlcommandVerifysales As New SqlCommand ' OleDbCommand
            sqlcommandVerifysales.Connection = cnn5

            sqlcommandVerifysales.CommandText = "select * from SapForecast where CodCliFact = @param1 And CodCliDest= @param2 And Codigo = @param3 And TPRE = @param4 And Currency = @param5 And Year = @param6 And Period = @param7"
            sqlcommandVerifysales.Parameters.AddWithValue("@param1", datareadervendas(0)) ' cliente fatura
            sqlcommandVerifysales.Parameters.AddWithValue("@param2", datareadervendas(1)) '  cliente destino
            sqlcommandVerifysales.Parameters.AddWithValue("@param3", datareadervendas(2))   ' Código
            sqlcommandVerifysales.Parameters.AddWithValue("@param4", datareadervendas(3))   ' Lista de preço
            sqlcommandVerifysales.Parameters.AddWithValue("@param5", datareadervendas(4))    ' moeda
            sqlcommandVerifysales.Parameters.AddWithValue("@param6", YearValue.EditValue)   'ANO
            sqlcommandVerifysales.Parameters.AddWithValue("@param7", FQValue.EditValue - 1)   ' periodo
            Try
                Dim retforecast = sqlcommandVerifysales.ExecuteScalar
                If IsNothing(retforecast) Then
                    ''''''''Inserir na tabela temporaria
                    Dim Row1 As DataRow
                    Row1 = TableInserir.NewRow()

                    Row1.Item("CodCliFact") = datareadervendas(0) ' cliente fatura
                    Row1.Item("CodCliDest") = datareadervendas(1) '  cliente destino
                    Row1.Item("Codigo") = datareadervendas(2)   ' Código
                    Row1.Item("TPRE") = datareadervendas(3)   ' Lista de preço
                    Row1.Item("Currency") = datareadervendas(4)    ' moeda
                    TableInserir.Rows.Add(Row1)

                End If
            Catch ex As Exception

            End Try
            cnn5.Close()


        End While

        cnn3.Close()

        ''''inserir no novo Forecast
        Dim cnn As New SqlConnection ' OleDbConnection

        cnn.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        cnn.Open()
        Me.SapForecastTableAdapter.Fill(Me.SalesSystemDataSet2.SapForecast, YearValue.EditValue, FQValue.EditValue - 1)

        For Each row In TableInserir.Rows
            Me.SalesSystemDataSet2.SapForecast.AddSapForecastRow(row(0), row(1), row(2), row(3), row(4), YearValue.EditValue, FQValue.EditValue - 1, 0, 0, 0, 0, 0, utilizador, Date.Now, 0, 0, 0, 0, 0)
        Next


        Dim transaction As SqlTransaction
        transaction = cnn.BeginTransaction("FORECAST")
        countrows = -1
        Try
            Dim row As DataRow
            For Each row In Me.SalesSystemDataSet2.SapForecast.Rows
                countrows = countrows + 1
                SimpleButton1.Text = "processados " & countrows & " de " & Me.SalesSystemDataSet2.SapForecast.Rows.Count
                Application.DoEvents()
                Dim flagQuarter As Integer
                Dim sqlcommand As New SqlCommand ' OleDbCommand
                sqlcommand.Connection = cnn
                sqlcommand.Transaction = transaction
                sqlcommand.CommandText = "INSERT INTO SapForecast (CodCliFact, CodCliDest, Codigo, TPRE, Currency, Year, Period, " _
                & "Quarter1Value, Quarter2Value, Quarter3Value, Quarter4Value, AnualValue, UserCS, FQ1, FQ2, FQ3, FQ4, Target) VALUES(" _
                & "@param1,@param2,@param3,@param4,@param5,@param6,@param7," _
                & "@param8,@param9,@param10,@param11,@param12,@param13,@param14,@param15,@param16,@param17,@param18)"
                sqlcommand.Parameters.AddWithValue("@param1", row(0)) ' cliente fatura
                sqlcommand.Parameters.AddWithValue("@param2", row(1)) '  cliente destino
                sqlcommand.Parameters.AddWithValue("@param3", row(2))   ' Código
                sqlcommand.Parameters.AddWithValue("@param4", row(3))   ' Lista de preço
                sqlcommand.Parameters.AddWithValue("@param5", row(4))    ' moeda
                sqlcommand.Parameters.AddWithValue("@param6", YearValue.EditValue)   'ANO
                sqlcommand.Parameters.AddWithValue("@param7", FQValue.EditValue)   ' periodo

                Dim valordiferençaTargetSales = 0

                ''Persistencia dos valores mensais
                Dim ValorFQQuarter1 = row(7)
                Dim ValorFQQuarter2 = row(8)
                Dim ValorFQQuarter3 = row(9)
                Dim ValorFQQuarter4 = row(10)

                ''calcular vendas dos meses já passados
                ''calcular vendas dos meses já passados
                ''calcular vendas dos meses já passados

                If FQValue.EditValue = 2 Then
                    Me.SalesSystemDataSet2.SapImmaterialSales.Clear()
                    flagQuarter = 2
                    Me.SapImmaterialSalesTableAdapter.Fill(Me.SalesSystemDataSet2.SapImmaterialSales, YearValue.EditValue & "-04-01", YearValue.EditValue, row(0), row(1), row(2), row(3), row(4))
                    If Me.SalesSystemDataSet2.SapImmaterialSales.Rows.Count > 0 Then
                        row(7) = Me.SalesSystemDataSet2.SapImmaterialSales.Rows(0).Item("ShippedUnits")
                    Else
                        row(7) = 0
                    End If
                    ' sqlcommand.Parameters.AddWithValue("@param8", row(7)) ' MES1
                    valordiferençaTargetSales = valordiferençaTargetSales + (ValorFQQuarter1 - row(7))

                End If

                If FQValue.EditValue = 3 Then
                    Me.SalesSystemDataSet2.SapImmaterialSales.Clear()
                    flagQuarter = 3
                    Me.SapImmaterialSalesTableAdapter.Fill(Me.SalesSystemDataSet2.SapImmaterialSales, YearValue.EditValue & "-07-01", YearValue.EditValue, row(0), row(1), row(2), row(3), row(4))
                    If Me.SalesSystemDataSet2.SapImmaterialSales.Rows.Count > 0 Then
                        row(8) = Me.SalesSystemDataSet2.SapImmaterialSales.Rows(0).Item("ShippedUnits") - row(7)
                    Else
                        row(8) = 0
                    End If
                    ' sqlcommand.Parameters.AddWithValue("@param9", row(8)) ' MES2
                    valordiferençaTargetSales = valordiferençaTargetSales + (ValorFQQuarter2 - row(8))
                End If

                If FQValue.EditValue = 4 Then
                    Me.SalesSystemDataSet2.SapImmaterialSales.Clear()
                    flagQuarter = 4
                    Me.SapImmaterialSalesTableAdapter.Fill(Me.SalesSystemDataSet2.SapImmaterialSales, YearValue.EditValue & "-10-01", YearValue.EditValue, row(0), row(1), row(2), row(3), row(4))
                    If Me.SalesSystemDataSet2.SapImmaterialSales.Rows.Count > 0 Then
                        row(9) = Me.SalesSystemDataSet2.SapImmaterialSales.Rows(0).Item("ShippedUnits") - row(8) - row(7)
                    Else
                        row(9) = 0
                    End If
                    ' sqlcommand.Parameters.AddWithValue("@param10", row(9))   ' MES3
                    valordiferençaTargetSales = valordiferençaTargetSales + (ValorFQQuarter3 - row(9))
                End If

                ''adiciona o target restante ao trimestre seguinte 
                If valordiferençaTargetSales > 0 Then
                    If FQValue.EditValue = 2 Then row(8) = row(8) + valordiferençaTargetSales
                    If FQValue.EditValue = 3 Then row(9) = row(9) + valordiferençaTargetSales
                    If FQValue.EditValue = 4 Then row(10) = row(10) + valordiferençaTargetSales
                End If

                If valordiferençaTargetSales < 0 Then
                    If FQValue.EditValue = 2 Then

                        If row(8) + valordiferençaTargetSales < 0 Then
                            valordiferençaTargetSales = valordiferençaTargetSales + row(8)
                            row(8) = 0
                            If row(9) + valordiferençaTargetSales < 0 Then
                                valordiferençaTargetSales = valordiferençaTargetSales + row(9)
                                row(9) = 0
                                If row(10) + valordiferençaTargetSales < 0 Then
                                    row(10) = 0
                                Else
                                    row(10) = row(10) + valordiferençaTargetSales
                                End If
                            Else
                                row(9) = row(9) + valordiferençaTargetSales
                            End If
                        Else
                            row(8) = row(8) + valordiferençaTargetSales
                        End If
                    End If

                    If FQValue.EditValue = 3 Then
                        If row(9) + valordiferençaTargetSales < 0 Then
                            valordiferençaTargetSales = valordiferençaTargetSales + row(9)
                            row(9) = 0
                            If row(10) + valordiferençaTargetSales < 0 Then
                                row(10) = 0
                            Else
                                row(10) = row(10) + valordiferençaTargetSales
                            End If
                        Else
                            row(9) = row(9) + valordiferençaTargetSales
                        End If
                    End If


                    If FQValue.EditValue = 4 Then
                        If row(10) + valordiferençaTargetSales < 0 Then
                            row(10) = 0
                        Else
                            row(10) = row(10) + valordiferençaTargetSales
                        End If
                    End If

                End If



                sqlcommand.Parameters.AddWithValue("@param8", row(7)) ' quarter1
                sqlcommand.Parameters.AddWithValue("@param9", row(8)) ' quarter2
                sqlcommand.Parameters.AddWithValue("@param10", row(9)) ' quarter3
                sqlcommand.Parameters.AddWithValue("@param11", row(10)) ' quarter4

                ''calcular total target somando todos os meses e converter para 9L
                ''calcular total target somando todos os meses e converter para 9L
                Dim ValorTotalTarget = row(7) + row(8) + row(9) + row(10)
                Dim retValLtsMatnr


                Dim cnn2 As New SqlConnection ' OleDbConnection
                cnn2.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
                cnn2.Open()
                Dim sqlcommandValor9l As New SqlCommand ' OleDbCommand
                sqlcommandValor9l.Connection = cnn2
                sqlcommandValor9l.CommandText = "SELECT SapEmbalagens.LTS FROM SapMateriais INNER JOIN SapEmbalagens ON SapMateriais.EMBALAGEM = SapEmbalagens.IND WHERE (SapMateriais.MATNR = @MATNR)"
                sqlcommandValor9l.Parameters.AddWithValue("@MATNR", row(2))   ' Código
                Try
                    retValLtsMatnr = sqlcommandValor9l.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Erro na obtenção da Embalagem do Material " & row(2), MsgBoxStyle.Critical)
                    cnn2.Close()
                    Exit Sub
                End Try
                cnn2.Close()



                sqlcommand.Parameters.AddWithValue("@param12", ValorTotalTarget * retValLtsMatnr / 9) ' Total
                sqlcommand.Parameters.AddWithValue("@param13", utilizador) ' user

                If FQValue.EditValue = 2 Then
                    sqlcommand.Parameters.AddWithValue("@param14", row(14)) ' fq1
                    sqlcommand.Parameters.AddWithValue("@param15", 0) ' fq2
                    sqlcommand.Parameters.AddWithValue("@param16", 0) ' fq3
                    sqlcommand.Parameters.AddWithValue("@param17", 0) ' fq4
                ElseIf FQValue.EditValue = 3 Then
                    sqlcommand.Parameters.AddWithValue("@param14", row(14)) ' fq1
                    sqlcommand.Parameters.AddWithValue("@param15", row(15)) ' fq2
                    sqlcommand.Parameters.AddWithValue("@param16", 0) ' fq3
                    sqlcommand.Parameters.AddWithValue("@param17", 0) ' fq4
                ElseIf FQValue.EditValue = 4 Then
                    sqlcommand.Parameters.AddWithValue("@param14", row(14)) ' fq1
                    sqlcommand.Parameters.AddWithValue("@param15", row(15)) ' fq2
                    sqlcommand.Parameters.AddWithValue("@param16", row(16)) ' fq3
                    sqlcommand.Parameters.AddWithValue("@param17", 0) ' fq4

                End If


                sqlcommand.Parameters.AddWithValue("@param18", row(18)) ' target
                Try
                    sqlcommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    transaction.Rollback()

                    MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
                    Exit Sub
                End Try

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            transaction.Commit()

            MsgBox("OK")
        Catch ex As Exception
            Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
            Console.WriteLine("  Message: {0}", ex.Message)

            ' Attempt to roll back the transaction.
            Try
                transaction.Rollback()
                MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
            Catch ex2 As Exception
                ' This catch block will handle any errors that may have occurred
                ' on the server that would cause the rollback to fail, such as
                ' a closed connection.
                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                Console.WriteLine("  Message: {0}", ex2.Message)
            End Try
        End Try

        cnn.Close()



    End Sub

    Private Sub calcularFQ2_3_4STAT()
        Dim countrows As Integer = -1
        Dim utilizador As String
        utilizador = UCase(GetSetting("SalesReports", "User", "login"))
        ''''inserir novas linhas de Forecast para vendas realizadas depois do ultimo FQ
        ''''inserir novas linhas de Forecast para vendas realizadas depois do ultimo FQ

        Dim TableInserir As DataTable
        TableInserir = New DataTable("TableName")

        Dim columnCodCliInv As DataColumn = New DataColumn("CodCliInv")
        columnCodCliInv.DataType = System.Type.GetType("System.String")

        Dim columnCodCliStat As DataColumn = New DataColumn("CodCliStat")
        columnCodCliStat.DataType = System.Type.GetType("System.String")
        Dim columnCodigo As DataColumn = New DataColumn("Codigo")
        columnCodigo.DataType = System.Type.GetType("System.String")
        Dim columnTPRE As DataColumn = New DataColumn("TPRE")
        columnTPRE.DataType = System.Type.GetType("System.String")
        Dim columnCurrency As DataColumn = New DataColumn("Currency")
        columnCurrency.DataType = System.Type.GetType("System.String")

        TableInserir.Columns.Add(columnCodCliInv)
        TableInserir.Columns.Add(columnCodCliStat)
        TableInserir.Columns.Add(columnCodigo)
        TableInserir.Columns.Add(columnTPRE)
        TableInserir.Columns.Add(columnCurrency)

        Dim cnn3 As New SqlConnection ' OleDbConnection
        cnn3.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        cnn3.Open()
        Dim sqlcommandVendas As New SqlCommand ' OleDbCommand
        sqlcommandVendas.Connection = cnn3
        sqlcommandVendas.CommandText = "SELECT InvClientID, StatClientID, [Immaterial Number], [Price List], Currency, SUM(ShippedUnits) AS ShippedUnits FROM SapImmaterialSales2Stat WHERE (SPTAG >= @datainicio) AND (SPTAG <= @datafim) GROUP BY InvClientID, StatClientID, [Immaterial Number], [Price List], Currency"
        sqlcommandVendas.Parameters.AddWithValue("@datainicio", YearValue.EditValue & "-01-01")
        Dim ultimomes = Month(Now) - 1
        sqlcommandVendas.Parameters.AddWithValue("@datafim", YearValue.EditValue & "-" & ultimomes.ToString().PadLeft(2, "0") & "-" & GetLastDayOfLastMonth())

        Dim datareadervendas As SqlDataReader = sqlcommandVendas.ExecuteReader
        While datareadervendas.Read

            countrows = countrows + 1
            SimpleButton3.Text = "A verificar Vendas sem Forecast -> " & countrows
            Application.DoEvents()

            ''''''''Verificar se existe no FQ anterior
            Dim cnn5 As New SqlConnection ' OleDbConnection
            cnn5.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
            cnn5.Open()
            Dim sqlcommandVerifysales As New SqlCommand ' OleDbCommand
            sqlcommandVerifysales.Connection = cnn5

            sqlcommandVerifysales.CommandText = "select * from SapForecastSTAT where CodCliFact = @param0 and CodCliStat = @param1 And Codigo = @param3 And TPRE = @param4 And Currency = @param5 And Year = @param6 And Period = @param7"

            sqlcommandVerifysales.Parameters.AddWithValue("@param0", datareadervendas(0)) ' cliente Factura

            sqlcommandVerifysales.Parameters.AddWithValue("@param1", datareadervendas(1)) ' cliente Stat

            sqlcommandVerifysales.Parameters.AddWithValue("@param3", datareadervendas(2))   ' Código
            sqlcommandVerifysales.Parameters.AddWithValue("@param4", datareadervendas(3))   ' Lista de preço
            sqlcommandVerifysales.Parameters.AddWithValue("@param5", datareadervendas(4))    ' moeda
            sqlcommandVerifysales.Parameters.AddWithValue("@param6", YearValue.EditValue)   'ANO
            sqlcommandVerifysales.Parameters.AddWithValue("@param7", FQValue.EditValue - 1)   ' periodo
            Try
                Dim retforecast = sqlcommandVerifysales.ExecuteScalar
                If IsNothing(retforecast) Then
                    ''''''''Inserir na tabela temporaria
                    Dim Row1 As DataRow
                    Row1 = TableInserir.NewRow()

                    Row1.Item("CodCliInv") = datareadervendas(0) ' cliente fatura
                    Row1.Item("CodCliStat") = datareadervendas(1) ' cliente  stat
                    Row1.Item("Codigo") = datareadervendas(2)   ' Código
                    Row1.Item("TPRE") = datareadervendas(3)   ' Lista de preço
                    Row1.Item("Currency") = datareadervendas(4)    ' moeda
                    TableInserir.Rows.Add(Row1)

                End If
            Catch ex As Exception

            End Try
            cnn5.Close()


        End While

        cnn3.Close()

        ''''inserir no novo Forecast
        Dim cnn As New SqlConnection ' OleDbConnection

        cnn.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        cnn.Open()
        Me.SapForecastStatTableAdapter.Fill(Me.SalesSystemDataSet2.SapForecastStat, YearValue.EditValue, FQValue.EditValue - 1)

        For Each row In TableInserir.Rows
            Me.SalesSystemDataSet2.SapForecastStat.AddSapForecastStatRow(row(0), row(1), row(2), row(3), row(4), YearValue.EditValue, FQValue.EditValue - 1, 0, 0, 0, 0, 0, utilizador, Date.Now, 0, 0, 0, 0, 0)
        Next


        Dim transaction As SqlTransaction
        transaction = cnn.BeginTransaction("FORECASTSTAT")
        countrows = -1
        Try
            Dim row As DataRow
            For Each row In Me.SalesSystemDataSet2.SapForecastStat.Rows

                Dim ParClientefatura263

                If row(0) = "0000000263" Then
                    ParClientefatura263 = True
                Else
                    row(0) = row(1)
                    ParClientefatura263 = False
                End If


                countrows = countrows + 1
                SimpleButton3.Text = "processados " & countrows & " de " & Me.SalesSystemDataSet2.SapForecastStat.Rows.Count
                Application.DoEvents()
                Dim flagQuarter As Integer
                Dim sqlcommand As New SqlCommand ' OleDbCommand
                sqlcommand.Connection = cnn
                sqlcommand.Transaction = transaction
                sqlcommand.CommandText = "INSERT INTO SapForecaststat (CodCliFact, CodCliStat, Codigo, TPRE, Currency, Year, Period, " _
                & "Quarter1Value, Quarter2Value, Quarter3Value, Quarter4Value, AnualValue, UserCS, FQ1, FQ2, FQ3, FQ4, Target) VALUES(" _
                & "@param0,@param1,@param3,@param4,@param5,@param6,@param7," _
                & "@param8,@param9,@param10,@param11,@param12,@param13,@param14,@param15,@param16,@param17,@param18)"

                sqlcommand.Parameters.AddWithValue("@param0", row(0)) ' cliente fact
                sqlcommand.Parameters.AddWithValue("@param1", row(1)) ' cliente stat

                sqlcommand.Parameters.AddWithValue("@param3", row(2))   ' Código
                sqlcommand.Parameters.AddWithValue("@param4", row(3))   ' Lista de preço
                sqlcommand.Parameters.AddWithValue("@param5", row(4))    ' moeda
                sqlcommand.Parameters.AddWithValue("@param6", YearValue.EditValue)   'ANO
                sqlcommand.Parameters.AddWithValue("@param7", FQValue.EditValue)   ' periodo

                Dim valordiferençaTargetSales = 0

                ''Persistencia dos valores mensais
                Dim ValorFQQuarter1 = row(7)
                Dim ValorFQQuarter2 = row(8)
                Dim ValorFQQuarter3 = row(9)
                Dim ValorFQQuarter4 = row(10)

                ''calcular vendas dos meses já passados
                ''calcular vendas dos meses já passados
                ''calcular vendas dos meses já passados

                If FQValue.EditValue = 2 Then
                    Me.SalesSystemDataSet2.SapImmaterialSalesStat.Clear()
                    flagQuarter = 2

                    If ParClientefatura263 = True Then
                        Me.SapImmaterialSalesStatTableAdapter.Fill(Me.SalesSystemDataSet2.SapImmaterialSalesStat, YearValue.EditValue & "-04-01", YearValue.EditValue, row(0), row(1), row(2), row(3), row(4))
                        If Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows.Count > 0 Then
                            row(7) = Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows(0).Item("ShippedUnits")
                        Else
                            row(7) = 0
                        End If
                        valordiferençaTargetSales = valordiferençaTargetSales + (ValorFQQuarter1 - row(7))
                    Else
                        Me.SapImmaterialSalesStatTableAdapter.FillBy(Me.SalesSystemDataSet2.SapImmaterialSalesStat, YearValue.EditValue & "-04-01", YearValue.EditValue, row(1), row(2), row(3), row(4))
                        If Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows.Count > 0 Then
                            row(7) = Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows(0).Item("ShippedUnits")
                        Else
                            row(7) = 0
                        End If
                        valordiferençaTargetSales = valordiferençaTargetSales + (ValorFQQuarter1 - row(7))
                    End If

                End If

                    If FQValue.EditValue = 3 Then
                    Me.SalesSystemDataSet2.SapImmaterialSalesStat.Clear()
                    flagQuarter = 3

                    If row(1) = "0000004709" Then
                        Debug.Write("0")

                    End If

                    If ParClientefatura263 = True Then
                            Me.SapImmaterialSalesStatTableAdapter.Fill(Me.SalesSystemDataSet2.SapImmaterialSalesStat, YearValue.EditValue & "-07-01", YearValue.EditValue, row(0), row(1), row(2), row(3), row(4))
                            If Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows.Count > 0 Then
                                row(8) = Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows(0).Item("ShippedUnits") - row(7)
                            Else
                                row(8) = 0
                            End If
                            valordiferençaTargetSales = valordiferençaTargetSales + (ValorFQQuarter2 - row(8))
                        Else
                            Me.SapImmaterialSalesStatTableAdapter.FillBy(Me.SalesSystemDataSet2.SapImmaterialSalesStat, YearValue.EditValue & "-07-01", YearValue.EditValue, row(1), row(2), row(3), row(4))
                            If Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows.Count > 0 Then
                                row(8) = Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows(0).Item("ShippedUnits") - row(7)
                            Else
                                row(8) = 0
                            End If
                            valordiferençaTargetSales = valordiferençaTargetSales + (ValorFQQuarter2 - row(8))
                        End If



                    End If




                    If FQValue.EditValue = 4 Then
                    Me.SalesSystemDataSet2.SapImmaterialSalesStat.Clear()
                    flagQuarter = 4
                    If ParClientefatura263 = True Then

                        Me.SapImmaterialSalesStatTableAdapter.Fill(Me.SalesSystemDataSet2.SapImmaterialSalesStat, YearValue.EditValue & "-10-01", YearValue.EditValue, row(0), row(1), row(2), row(3), row(4))
                        If Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows.Count > 0 Then
                            row(9) = Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows(0).Item("ShippedUnits") - row(8) - row(7)
                        Else
                            row(9) = 0
                        End If

                        valordiferençaTargetSales = valordiferençaTargetSales + (ValorFQQuarter3 - row(9))
                    Else
                        Me.SapImmaterialSalesStatTableAdapter.FillBy(Me.SalesSystemDataSet2.SapImmaterialSalesStat, YearValue.EditValue & "-10-01", YearValue.EditValue, row(1), row(2), row(3), row(4))
                        If Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows.Count > 0 Then
                            row(9) = Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows(0).Item("ShippedUnits") - row(8) - row(7)
                        Else
                            row(9) = 0
                        End If

                        valordiferençaTargetSales = valordiferençaTargetSales + (ValorFQQuarter3 - row(9))
                    End If

                End If

                    ''adiciona o target restante ao trimestre seguinte 
                    If valordiferençaTargetSales > 0 Then
                    If FQValue.EditValue = 2 Then row(8) = row(8) + valordiferençaTargetSales
                    If FQValue.EditValue = 3 Then row(9) = row(9) + valordiferençaTargetSales
                    If FQValue.EditValue = 4 Then row(10) = row(10) + valordiferençaTargetSales
                End If

                If valordiferençaTargetSales < 0 Then
                    If FQValue.EditValue = 2 Then

                        If row(8) + valordiferençaTargetSales < 0 Then
                            valordiferençaTargetSales = valordiferençaTargetSales + row(8)
                            row(8) = 0
                            If row(9) + valordiferençaTargetSales < 0 Then
                                valordiferençaTargetSales = valordiferençaTargetSales + row(9)
                                row(9) = 0
                                If row(10) + valordiferençaTargetSales < 0 Then
                                    row(10) = 0
                                Else
                                    row(10) = row(10) + valordiferençaTargetSales
                                End If
                            Else
                                row(9) = row(9) + valordiferençaTargetSales
                            End If
                        Else
                            row(8) = row(8) + valordiferençaTargetSales
                        End If
                    End If

                    If FQValue.EditValue = 3 Then
                        If row(9) + valordiferençaTargetSales < 0 Then
                            valordiferençaTargetSales = valordiferençaTargetSales + row(9)
                            row(9) = 0
                            If row(10) + valordiferençaTargetSales < 0 Then
                                row(10) = 0
                            Else
                                row(10) = row(10) + valordiferençaTargetSales
                            End If
                        Else
                            row(9) = row(9) + valordiferençaTargetSales
                        End If
                    End If


                    If FQValue.EditValue = 4 Then
                        If row(10) + valordiferençaTargetSales < 0 Then
                            row(10) = 0
                        Else
                            row(10) = row(10) + valordiferençaTargetSales
                        End If
                    End If

                End If



                sqlcommand.Parameters.AddWithValue("@param8", row(7)) ' quarter1
                sqlcommand.Parameters.AddWithValue("@param9", row(8)) ' quarter2
                sqlcommand.Parameters.AddWithValue("@param10", row(9)) ' quarter3
                sqlcommand.Parameters.AddWithValue("@param11", row(10)) ' quarter4

                ''calcular total target somando todos os meses e converter para 9L
                ''calcular total target somando todos os meses e converter para 9L
                Dim ValorTotalTarget = row(7) + row(8) + row(9) + row(10)
                Dim retValLtsMatnr


                Dim cnn2 As New SqlConnection ' OleDbConnection
                cnn2.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
                cnn2.Open()
                Dim sqlcommandValor9l As New SqlCommand ' OleDbCommand
                sqlcommandValor9l.Connection = cnn2
                sqlcommandValor9l.CommandText = "SELECT SapEmbalagens.LTS FROM SapMateriais INNER JOIN SapEmbalagens ON SapMateriais.EMBALAGEM = SapEmbalagens.IND WHERE (SapMateriais.MATNR = @MATNR)"
                sqlcommandValor9l.Parameters.AddWithValue("@MATNR", row(2))   ' Código
                Try
                    retValLtsMatnr = sqlcommandValor9l.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Erro na obtenção da Embalagem do Material " & row(2), MsgBoxStyle.Critical)
                    cnn2.Close()
                    Exit Sub
                End Try
                cnn2.Close()



                sqlcommand.Parameters.AddWithValue("@param12", ValorTotalTarget * retValLtsMatnr / 9) ' Total
                sqlcommand.Parameters.AddWithValue("@param13", utilizador) ' user

                If FQValue.EditValue = 2 Then
                    sqlcommand.Parameters.AddWithValue("@param14", row(14)) ' fq1
                    sqlcommand.Parameters.AddWithValue("@param15", 0) ' fq2
                    sqlcommand.Parameters.AddWithValue("@param16", 0) ' fq3
                    sqlcommand.Parameters.AddWithValue("@param17", 0) ' fq4
                ElseIf FQValue.EditValue = 3 Then
                    sqlcommand.Parameters.AddWithValue("@param14", row(14)) ' fq1
                    sqlcommand.Parameters.AddWithValue("@param15", row(15)) ' fq2
                    sqlcommand.Parameters.AddWithValue("@param16", 0) ' fq3
                    sqlcommand.Parameters.AddWithValue("@param17", 0) ' fq4
                ElseIf FQValue.EditValue = 4 Then
                    sqlcommand.Parameters.AddWithValue("@param14", row(14)) ' fq1
                    sqlcommand.Parameters.AddWithValue("@param15", row(15)) ' fq2
                    sqlcommand.Parameters.AddWithValue("@param16", row(16)) ' fq3
                    sqlcommand.Parameters.AddWithValue("@param17", 0) ' fq4

                End If


                sqlcommand.Parameters.AddWithValue("@param18", row(18)) ' target
                Try
                    sqlcommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    transaction.Rollback()

                    MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
                    Exit Sub
                End Try

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            transaction.Commit()

            MsgBox("OK")
        Catch ex As Exception
            Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
            Console.WriteLine("  Message: {0}", ex.Message)

            ' Attempt to roll back the transaction.
            Try
                transaction.Rollback()
                MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
            Catch ex2 As Exception
                ' This catch block will handle any errors that may have occurred
                ' on the server that would cause the rollback to fail, such as
                ' a closed connection.
                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                Console.WriteLine("  Message: {0}", ex2.Message)
            End Try
        End Try

        cnn.Close()

    End Sub


    Private Sub calcularFQ5()
        Dim countrows As Integer = -1
        Dim utilizador As String
        utilizador = UCase(GetSetting("SalesReports", "User", "login"))


        '''''inserir no novo Forecast
        Dim cnn As New SqlConnection ' OleDbConnection

        cnn.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        cnn.Open()
        Me.SapForecastTableAdapter.Fill(Me.SalesSystemDataSet2.SapForecast, YearValue.EditValue, FQValue.EditValue - 1)
        'For Each row In TableInserir.Rows
        '    Me.SalesSystemDataSet2.SapForecast.AddSapForecastRow(row(0), row(1), row(2), row(3), row(4), YearValue.EditValue, FQValue.EditValue - 1, 0, 0, 0, 0, 0, utilizador, Date.Now, 0, 0, 0, 0, 0)
        'Next


        Dim transaction As SqlTransaction
        transaction = cnn.BeginTransaction("FORECAST")
        countrows = -1
        Try
            Dim row As DataRow
            For Each row In Me.SalesSystemDataSet2.SapForecast.Rows
                countrows = countrows + 1
                SimpleButton1.Text = "processados " & countrows & " de " & Me.SalesSystemDataSet2.SapForecast.Rows.Count
                Application.DoEvents()
                Dim sqlcommand As New SqlCommand ' OleDbCommand
                sqlcommand.Connection = cnn
                sqlcommand.Transaction = transaction
                sqlcommand.CommandText = "INSERT INTO SapForecast (CodCliFact, CodCliDest, Codigo, TPRE, Currency, Year, Period, " _
                & "Quarter1Value, Quarter2Value, Quarter3Value, Quarter4Value, AnualValue, UserCS, FQ1, FQ2, FQ3, FQ4, Target) VALUES(" _
                & "@param1,@param2,@param3,@param4,@param5,@param6,@param7," _
                & "@param8,@param9,@param10,@param11,@param12,@param13,@param14,@param15,@param16,@param17,@param18)"
                sqlcommand.Parameters.AddWithValue("@param1", row(0)) ' cliente fatura
                sqlcommand.Parameters.AddWithValue("@param2", row(1)) '  cliente destino
                sqlcommand.Parameters.AddWithValue("@param3", row(2))   ' Código
                sqlcommand.Parameters.AddWithValue("@param4", row(3))   ' Lista de preço
                sqlcommand.Parameters.AddWithValue("@param5", row(4))    ' moeda
                sqlcommand.Parameters.AddWithValue("@param6", YearValue.EditValue)   'ANO
                sqlcommand.Parameters.AddWithValue("@param7", FQValue.EditValue)   ' periodo

                Dim valordiferençaTargetSales = 0

                ''Persistencia dos valores mensais
                Dim ValorFQQuarter1 = row(7)
                Dim ValorFQQuarter2 = row(8)
                Dim ValorFQQuarter3 = row(9)
                Dim ValorFQQuarter4 = row(10)

                ''calcular vendas dos meses já passados
                ''calcular vendas dos meses já passados
                ''calcular vendas dos meses já passados


                Dim retShippedUnits

                Me.SalesSystemDataSet2.SapImmaterialSales.Clear()

                Me.SapImmaterialSalesTableAdapter.Fill(Me.SalesSystemDataSet2.SapImmaterialSales, YearValue.EditValue & "-12-31", YearValue.EditValue, row(0), row(1), row(2), row(3), row(4))
                If Me.SalesSystemDataSet2.SapImmaterialSales.Rows.Count > 0 Then
                    row(10) = Me.SalesSystemDataSet2.SapImmaterialSales.Rows(0).Item("ShippedUnits") - row(9) - row(8) - row(7)
                    retShippedUnits = Me.SalesSystemDataSet2.SapImmaterialSales.Rows(0).Item("ShippedUnits")
                Else
                    row(10) = 0
                    retShippedUnits = 0
                End If


                sqlcommand.Parameters.AddWithValue("@param8", row(7)) ' quarter1
                sqlcommand.Parameters.AddWithValue("@param9", row(8)) ' quarter2
                sqlcommand.Parameters.AddWithValue("@param10", row(9)) ' quarter3
                sqlcommand.Parameters.AddWithValue("@param11", row(10)) ' quarter4



                ''calcular total target somando todos os meses e converter para 9L
                ''calcular total target somando todos os meses e converter para 9L
                Dim ValorTotalANNUALunits = row(7) + row(8) + row(9) + row(10)
                Dim retValLtsMatnr


                Dim cnn2 As New SqlConnection ' OleDbConnection
                cnn2.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
                cnn2.Open()
                Dim sqlcommandValor9l As New SqlCommand ' OleDbCommand
                sqlcommandValor9l.Connection = cnn2
                sqlcommandValor9l.CommandText = "SELECT SapEmbalagens.LTS FROM SapMateriais INNER JOIN SapEmbalagens ON SapMateriais.EMBALAGEM = SapEmbalagens.IND WHERE (SapMateriais.MATNR = @MATNR)"
                sqlcommandValor9l.Parameters.AddWithValue("@MATNR", row(2))   ' Código
                Try
                    retValLtsMatnr = sqlcommandValor9l.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Erro na obtenção da Embalagem do Material " & row(2), MsgBoxStyle.Critical)
                    cnn2.Close()
                    Exit Sub
                End Try
                cnn2.Close()



                sqlcommand.Parameters.AddWithValue("@param12", retShippedUnits * retValLtsMatnr / 9) ' Total
                sqlcommand.Parameters.AddWithValue("@param13", utilizador) ' user
                sqlcommand.Parameters.AddWithValue("@param14", row(14)) ' fq1
                sqlcommand.Parameters.AddWithValue("@param15", row(15)) ' fq2
                sqlcommand.Parameters.AddWithValue("@param16", row(16)) ' fq3
                sqlcommand.Parameters.AddWithValue("@param17", row(17)) ' fq4
                sqlcommand.Parameters.AddWithValue("@param18", row(18)) ' target
                Try
                    sqlcommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    transaction.Rollback()

                    MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
                    Exit Sub
                End Try

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            transaction.Commit()

            MsgBox("OK")
        Catch ex As Exception
            Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
            Console.WriteLine("  Message: {0}", ex.Message)

            ' Attempt to roll back the transaction.
            Try
                transaction.Rollback()
                MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
            Catch ex2 As Exception
                ' This catch block will handle any errors that may have occurred
                ' on the server that would cause the rollback to fail, such as
                ' a closed connection.
                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                Console.WriteLine("  Message: {0}", ex2.Message)
            End Try
        End Try

        cnn.Close()



    End Sub
    Private Sub calcularFQ5_Stat()
        Dim countrows As Integer = -1
        Dim utilizador As String
        utilizador = UCase(GetSetting("SalesReports", "User", "login"))


        '''''inserir no novo Forecast
        Dim cnn As New SqlConnection ' OleDbConnection

        cnn.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        cnn.Open()
        Me.SapForecastStatTableAdapter.Fill(Me.SalesSystemDataSet2.SapForecastStat, YearValue.EditValue, FQValue.EditValue - 1)


        Dim transaction As SqlTransaction
        transaction = cnn.BeginTransaction("FORECAST")
        countrows = -1
        Try
            Dim row As DataRow
            For Each row In Me.SalesSystemDataSet2.SapForecastStat.Rows
                Dim ParClientefatura263

                If row(0) = "0000000263" Then
                    ParClientefatura263 = True
                Else
                    row(0) = row(1)
                    ParClientefatura263 = False
                End If



                countrows = countrows + 1
                SimpleButton1.Text = "processados " & countrows & " de " & Me.SalesSystemDataSet2.SapForecastStat.Rows.Count
                Application.DoEvents()
                Dim sqlcommand As New SqlCommand ' OleDbCommand
                sqlcommand.Connection = cnn
                sqlcommand.Transaction = transaction
                sqlcommand.CommandText = "INSERT INTO SapForecaststat (CodCliFact, CodCliStat, Codigo, TPRE, Currency, Year, Period, " _
                & "Quarter1Value, Quarter2Value, Quarter3Value, Quarter4Value, AnualValue, UserCS, FQ1, FQ2, FQ3, FQ4, Target) VALUES(" _
                & "@param1,@param2,@param3,@param4,@param5,@param6,@param7," _
                & "@param8,@param9,@param10,@param11,@param12,@param13,@param14,@param15,@param16,@param17,@param18)"
                sqlcommand.Parameters.AddWithValue("@param1", row(0)) ' cliente fatura
                sqlcommand.Parameters.AddWithValue("@param2", row(1)) '   cliente stat
                sqlcommand.Parameters.AddWithValue("@param3", row(2))   ' Código
                sqlcommand.Parameters.AddWithValue("@param4", row(3))   ' Lista de preço
                sqlcommand.Parameters.AddWithValue("@param5", row(4))    ' moeda
                sqlcommand.Parameters.AddWithValue("@param6", YearValue.EditValue)   'ANO
                sqlcommand.Parameters.AddWithValue("@param7", FQValue.EditValue)   ' periodo

                Dim valordiferençaTargetSales = 0

                ''Persistencia dos valores mensais
                Dim ValorFQQuarter1 = row(7)
                Dim ValorFQQuarter2 = row(8)
                Dim ValorFQQuarter3 = row(9)
                Dim ValorFQQuarter4 = row(10)

                ''calcular vendas dos meses já passados
                ''calcular vendas dos meses já passados
                ''calcular vendas dos meses já passados


                Dim retShippedUnits

                Me.SalesSystemDataSet2.SapImmaterialSalesStat.Clear()

                If ParClientefatura263 = True Then
                    Me.SapImmaterialSalesStatTableAdapter.Fill(Me.SalesSystemDataSet2.SapImmaterialSalesStat, YearValue.EditValue & "-12-31", YearValue.EditValue, row(0), row(1), row(2), row(3), row(4))
                    If Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows.Count > 0 Then
                        row(10) = Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows(0).Item("ShippedUnits") - row(9) - row(8) - row(7)
                        retShippedUnits = Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows(0).Item("ShippedUnits")
                    Else
                        row(10) = 0
                        retShippedUnits = 0
                    End If
                Else
                    Me.SapImmaterialSalesStatTableAdapter.FillBy(Me.SalesSystemDataSet2.SapImmaterialSalesStat, YearValue.EditValue & "-12-31", YearValue.EditValue, row(1), row(2), row(3), row(4))
                    If Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows.Count > 0 Then
                        row(10) = Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows(0).Item("ShippedUnits") - row(9) - row(8) - row(7)
                        retShippedUnits = Me.SalesSystemDataSet2.SapImmaterialSalesStat.Rows(0).Item("ShippedUnits")
                    Else
                        row(10) = 0
                        retShippedUnits = 0
                    End If

                End If
                sqlcommand.Parameters.AddWithValue("@param8", row(7)) ' quarter1
                sqlcommand.Parameters.AddWithValue("@param9", row(8)) ' quarter2
                sqlcommand.Parameters.AddWithValue("@param10", row(9)) ' quarter3
                sqlcommand.Parameters.AddWithValue("@param11", row(10)) ' quarter4



                ''calcular total target somando todos os meses e converter para 9L
                ''calcular total target somando todos os meses e converter para 9L

                Dim retValLtsMatnr


                Dim cnn2 As New SqlConnection ' OleDbConnection
                cnn2.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
                cnn2.Open()
                Dim sqlcommandValor9l As New SqlCommand ' OleDbCommand
                sqlcommandValor9l.Connection = cnn2
                sqlcommandValor9l.CommandText = "SELECT SapEmbalagens.LTS FROM SapMateriais INNER JOIN SapEmbalagens ON SapMateriais.EMBALAGEM = SapEmbalagens.IND WHERE (SapMateriais.MATNR = @MATNR)"
                sqlcommandValor9l.Parameters.AddWithValue("@MATNR", row(2))   ' Código
                Try
                    retValLtsMatnr = sqlcommandValor9l.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Erro na obtenção da Embalagem do Material " & row(2), MsgBoxStyle.Critical)
                    cnn2.Close()
                    Exit Sub
                End Try
                cnn2.Close()



                sqlcommand.Parameters.AddWithValue("@param12", retShippedUnits * retValLtsMatnr / 9) ' Total
                sqlcommand.Parameters.AddWithValue("@param13", utilizador) ' user
                sqlcommand.Parameters.AddWithValue("@param14", row(14)) ' fq1
                sqlcommand.Parameters.AddWithValue("@param15", row(15)) ' fq2
                sqlcommand.Parameters.AddWithValue("@param16", row(16)) ' fq3
                sqlcommand.Parameters.AddWithValue("@param17", row(17)) ' fq4
                sqlcommand.Parameters.AddWithValue("@param18", row(18)) ' target
                Try
                    sqlcommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    transaction.Rollback()

                    MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
                    Exit Sub
                End Try

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            transaction.Commit()

            MsgBox("OK")
        Catch ex As Exception
            Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
            Console.WriteLine("  Message: {0}", ex.Message)

            ' Attempt to roll back the transaction.
            Try
                transaction.Rollback()
                MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
            Catch ex2 As Exception
                ' This catch block will handle any errors that may have occurred
                ' on the server that would cause the rollback to fail, such as
                ' a closed connection.
                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                Console.WriteLine("  Message: {0}", ex2.Message)
            End Try
        End Try

        cnn.Close()



    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        ''Fechar periodo de alterações. Congelar "Annual value" para coluna FQ1/2/3/4


        Dim cnn As New SqlConnection ' OleDbConnection
        cnn.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        cnn.Open()
        Dim transaction As SqlTransaction
        transaction = cnn.BeginTransaction("FORECAST")
        Dim sqlcommand As New SqlCommand ' OleDbCommand
        sqlcommand.Connection = cnn
        sqlcommand.Transaction = transaction

        If FQValue.EditValue = 1 Then
            sqlcommand.CommandText = "UPDATE SapForecast SET FQ1 = AnualValue WHERE (Year = " & YearValue.EditValue & ") AND (Period = 1)"
        ElseIf FQValue.EditValue = 2 Then
            sqlcommand.CommandText = "UPDATE SapForecast SET FQ2 = AnualValue WHERE (Year = " & YearValue.EditValue & ") AND (Period = 2)"
        ElseIf FQValue.EditValue = 3 Then
            sqlcommand.CommandText = "UPDATE SapForecast SET FQ3 = AnualValue WHERE (Year = " & YearValue.EditValue & ") AND (Period = 3)"
        ElseIf FQValue.EditValue = 4 Then
            sqlcommand.CommandText = "UPDATE SapForecast SET FQ4 = AnualValue WHERE (Year = " & YearValue.EditValue & ") AND (Period = 4)"
        End If

        Dim retQuestion = MsgBox("Fechar alterações ao Forecast do periodo " & FQValue.EditValue & " do ano " & YearValue.EditValue & " ?", MsgBoxStyle.OkCancel)
        If retQuestion = vbCancel Then Exit Sub

        Try
            sqlcommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            transaction.Rollback()
            MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
            Exit Sub
        End Try

        Try
            transaction.Commit()
            MsgBox("OK")
        Catch ex As Exception
            Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
            Console.WriteLine("  Message: {0}", ex.Message)
            ' Attempt to roll back the transaction.
            Try
                transaction.Rollback()
                MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
            Catch ex2 As Exception

                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                Console.WriteLine("  Message: {0}", ex2.Message)
            End Try
        End Try
        cnn.Close()


        Dim cnn2 As New SqlConnection ' OleDbConnection
        cnn2.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        cnn2.Open()
        Dim transaction2 As SqlTransaction
        transaction2 = cnn2.BeginTransaction("FORECASTSTAT")
        Dim sqlcommand2 As New SqlCommand ' OleDbCommand
        sqlcommand2.Connection = cnn2
        sqlcommand2.Transaction = transaction2

        If FQValue.EditValue = 1 Then
            sqlcommand2.CommandText = "UPDATE SapForecastSTAT SET FQ1 = AnualValue WHERE (Year = " & YearValue.EditValue & ") AND (Period = 1)"
        ElseIf FQValue.EditValue = 2 Then
            sqlcommand2.CommandText = "UPDATE SapForecastSTAT SET FQ2 = AnualValue WHERE (Year = " & YearValue.EditValue & ") AND (Period = 2)"
        ElseIf FQValue.EditValue = 3 Then
            sqlcommand2.CommandText = "UPDATE SapForecastSTAT SET FQ3 = AnualValue WHERE (Year = " & YearValue.EditValue & ") AND (Period = 3)"
        ElseIf FQValue.EditValue = 4 Then
            sqlcommand2.CommandText = "UPDATE SapForecastSTAT SET FQ4 = AnualValue WHERE (Year = " & YearValue.EditValue & ") AND (Period = 4)"
        End If

        Try
            sqlcommand2.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            transaction2.Rollback()
            MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
            Exit Sub
        End Try

        Try
            transaction2.Commit()
            MsgBox("OK")
        Catch ex As Exception
            Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
            Console.WriteLine("  Message: {0}", ex.Message)
            ' Attempt to roll back the transaction.
            Try
                transaction2.Rollback()
                MsgBox("Inserçao en Database cancelada", MsgBoxStyle.Critical)
            Catch ex2 As Exception
                ' This catch block will handle any errors that may have occurred
                ' on the server that would cause the rollback to fail, such as
                ' a closed connection.
                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                Console.WriteLine("  Message: {0}", ex2.Message)
            End Try
        End Try
        cnn2.Close()

        Dim cnn3 As New SqlConnection ' OleDbConnection
        cnn3.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        cnn3.Open()
        Dim sqlcommand3 As New SqlCommand ' OleDbCommand
        sqlcommand3.Connection = cnn3
        If FQValue.EditValue = 1 Then
            sqlcommand3.CommandText = "UPDATE SapForecastPeriodFlag SET Aberto = 0 WHERE (Period = 1)"
        ElseIf FQValue.EditValue = 2 Then
            sqlcommand3.CommandText = "UPDATE SapForecastPeriodFlag SET Aberto = 0 WHERE (Period = 2)"
        ElseIf FQValue.EditValue = 3 Then
            sqlcommand3.CommandText = "UPDATE SapForecastPeriodFlag SET Aberto = 0 WHERE (Period = 3)"
        ElseIf FQValue.EditValue = 4 Then
            sqlcommand3.CommandText = "UPDATE SapForecastPeriodFlag SET Aberto = 0 WHERE (Period = 4)"
        End If
        sqlcommand3.ExecuteNonQuery()
        cnn3.Close()

    End Sub
End Class