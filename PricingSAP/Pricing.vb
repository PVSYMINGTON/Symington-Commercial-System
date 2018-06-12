Imports System.Data.SQLite
Imports DevExpress.Spreadsheet

Public Class Pricing

    Public Shared MatnrKmeinDataTable As DataTable
    Public columnMatnr As Global.System.Data.DataColumn


    Private Sheet1 As Worksheet
    Private Sheet2 As Worksheet
    Sub New()

        InitializeComponent()



        estipulacaoDataTable = New DataTable()
        columnNum = New Global.System.Data.DataColumn("Num", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnNum.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnNum)

        columnTipoContrato = New Global.System.Data.DataColumn("TipoContrato", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnTipoContrato.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnTipoContrato)

        columnBeneficiario = New Global.System.Data.DataColumn("Beneficiario", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnBeneficiario.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnBeneficiario)

        columnDataInicio = New Global.System.Data.DataColumn("DataInicio", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnDataInicio.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnDataInicio)

        columnDataFim = New Global.System.Data.DataColumn("DataFim", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnDataFim.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnDataFim)

        columnTipoCondicao = New Global.System.Data.DataColumn("TipoCondicao", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnTipoCondicao.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnTipoCondicao)

        columnMaterial = New Global.System.Data.DataColumn("Material", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnNum.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnMaterial)

        columnValor = New Global.System.Data.DataColumn("Valor", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnValor.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnValor)

        columnkmein = New Global.System.Data.DataColumn("kmein", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnkmein.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnkmein)

        columnvkorg = New Global.System.Data.DataColumn("vkorg", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnvkorg.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnvkorg)


        columnOperacao = New Global.System.Data.DataColumn("Operacao", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        estipulacaoDataTable.Columns.Add(columnOperacao)

        estipulacaoDataTable.PrimaryKey = New DataColumn() {estipulacaoDataTable.Columns("Num"), estipulacaoDataTable.Columns("TipoCondicao"), estipulacaoDataTable.Columns("Material")}


        estipulacaoDataSet.Tables.Add(estipulacaoDataTable)


        SpreadsheetControl1.Document.LoadDocument("c:\commercialSystem\PricingSAP.xlsx")
        Sheet1 = SpreadsheetControl1.Document.Worksheets(0)
        Sheet2 = SpreadsheetControl1.Document.Worksheets(1)

    End Sub


    ' Public filterkeytipo As String
    Public Shared ultimalinha As Integer

    Public Shared filterkeydir As String
    Public Shared filterkeypais As String
    Public Shared filterkeyclifact As String
    Public Shared filterkeyclidest As String
    Public filterkeycomp As String
    Public filterkeytipo As String
    Public filterkeypricelist As String
    Public filterkeyPCDATI As String
    Public filterkeyPCDATF As String
    Public filterkeyCurrency As String
    Public filterkeyPricing As String
  


    Public estipulacaoDataSet As New DataSet
    Public Shared estipulacaoDataTable As DataTable
    Public columnNum As Global.System.Data.DataColumn
    Public columnTipoContrato As Global.System.Data.DataColumn
    Public columnBeneficiario As Global.System.Data.DataColumn
    Public columnDataInicio As Global.System.Data.DataColumn
    Public columnDataFim As Global.System.Data.DataColumn
    Public columnTipoCondicao As Global.System.Data.DataColumn
    Public columnMaterial As Global.System.Data.DataColumn
    Public columnValor As Global.System.Data.DataColumn
    Public columnkmein As Global.System.Data.DataColumn
    Public columnvkorg As Global.System.Data.DataColumn
    Public columnOperacao As Global.System.Data.DataColumn






    Private Sub Pricing_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SapPricingDataset11.SapMateriais1' table. You can move, or remove it, as needed.
        Me.SapMateriais1TableAdapter.Fill(Me.SapPricingDataset11.SapMateriais1)

        SapMateriais1BindingSource.Filter = "wgbez60 = '" & filterkeycomp & "' and tipo= '" & filterkeytipo & "'"
        '

        TextPriceListType.Properties.Items.Clear()

        Me.SapTipoListaPrecosTableAdapter.Fill(Me.SapPricingDataset11.SapTipoListaPrecos)

        For Each row In Me.SapPricingDataset11.SapTipoListaPrecos
            TextPriceListType.Properties.Items.Add(row(0).ToString & " " & row(1).ToString.TrimEnd)
        Next


        SpreadsheetControl1.BeginUpdate()

        Dim testtime As New Stopwatch
        testtime.Start()

        CreatePricing(filterkeydir, filterkeypais, filterkeyclifact, filterkeyclidest, filterkeycomp, filterkeytipo, filterkeypricelist, filterkeyPCDATI, filterkeyPCDATF, filterkeyCurrency)

        testtime.Stop()

        Console.Write(testtime.Elapsed)


        RibbonControl1.Minimized = True

        SpreadsheetControl1.EndUpdate()




    End Sub

    'Private Sub SpreadsheetControl1_CellBeginEdit(sender As System.Object, e As DevExpress.XtraSpreadsheet.SpreadsheetCellCancelEventArgs) Handles SpreadsheetControl1.CellBeginEdit
    '    'If e.ColumnIndex = 1 And e.RowIndex = 1 Then
    '    'Else
    '    '    e.Cancel = True
    '    'End If
    'End Sub

    'Private Sub SpreadsheetControl1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles SpreadsheetControl1.KeyDown
    '    'If (e.KeyCode = Keys.Delete) Then
    '    '    e.Handled = True
    '    'End If
    'End Sub



    Private Sub CreatePricing(ByVal director As String, ByVal pais As String, ByVal clientfact As String, ByVal clientdest As String, ByVal company As String, ByVal tipo As String, ByVal pricelist As String, ByVal PCDATI As String, ByVal PCDATF As String, ByVal Currency As String)
        Try

            Dim MD As String
            Dim mng As String
            Dim ass As String

            '   Dim workbook As IWorkbook = SpreadsheetControl1.Document

            SpreadsheetControl1.BeginUpdate()


            ultimalinha = 24


            Dim bottlecustlist As New Collections.ArrayList
            bottlecustlist.Clear()

            Dim mySelectQuery As String

            Dim myConnectionPricing As New SQLiteConnection ' OleDb.OleDbConnection
            myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
            myConnectionPricing.Open()








            '''''INICIO Invoice Customer Information
            '''''INICIO Invoice Customer Information
            '''''INICIO Invoice Customer Information
            'nome cliente
            Sheet1.Range("D4").Value = clientdest


            Sheet1.Range("C6").Value = (company)
            Sheet1.Range("C7").Value = (tipo)


            'dados cliente
            Dim mySelectQueryclienteDest As String

            mySelectQueryclienteDest = "SELECT  name1, contactname, contacttelephone, contactemail, landx50, clientstat, marketdirector, marketmanager, marketassistant, KATR3, BRSCH  FROM sapclients where kunnr ='" & clientdest & "'"
            Dim myCommandclienteDest As New SQLiteCommand(mySelectQueryclienteDest, myConnectionPricing)
            Dim myReaderclienteDest As SQLiteDataReader
            myReaderclienteDest = myCommandclienteDest.ExecuteReader


            Dim clistat As String
            While myReaderclienteDest.Read()
                Sheet1.Range("C4").Value = (myReaderclienteDest(0)).ToString
                Sheet1.Range("C8").Value = (myReaderclienteDest(1)).ToString
                Sheet1.Range("C9").Value = (myReaderclienteDest(2)).ToString
                Sheet1.Range("C10").Value = (myReaderclienteDest(3)).ToString
                Sheet1.Range("C5").Value = (myReaderclienteDest(4)).ToString
                Sheet1.Range("D12").Value = (clientfact).ToString
                Sheet1.Range("D11").Value = (myReaderclienteDest(5)).ToString
                Sheet1.Range("C18").Value = myReaderclienteDest(9).ToString 'Mainstream/Emerging
                Sheet1.Range("C19").Value = myReaderclienteDest(10).ToString '  ' Distributer Type

                MD = myReaderclienteDest(6).ToString
                mng = myReaderclienteDest(7).ToString
                ass = myReaderclienteDest(8).ToString

                clistat = (myReaderclienteDest(5)).ToString
            End While
            myReaderclienteDest.Close()

            Dim mySelectQueryclienteDestDirector As String
#Disable Warning BC42104 ' Variable 'MD' is used before it has been assigned a value. A null reference exception could result at runtime.
            mySelectQueryclienteDestDirector = "SELECT  name1 FROM sapclients where kunnr ='" & MD & "'"
#Enable Warning BC42104 ' Variable 'MD' is used before it has been assigned a value. A null reference exception could result at runtime.
            Dim myCommandclienteDestDirector As New SQLiteCommand(mySelectQueryclienteDestDirector, myConnectionPricing)
            Sheet1.Range("C15").Value = myCommandclienteDestDirector.ExecuteScalar.ToString ' Director

            Dim mySelectQueryclienteDestManager As String
#Disable Warning BC42104 ' Variable 'mng' is used before it has been assigned a value. A null reference exception could result at runtime.
            mySelectQueryclienteDestManager = "SELECT  name1 FROM sapclients where kunnr ='" & mng & "'"
#Enable Warning BC42104 ' Variable 'mng' is used before it has been assigned a value. A null reference exception could result at runtime.
            Dim myCommandclienteDestManager As New SQLiteCommand(mySelectQueryclienteDestManager, myConnectionPricing)
            Sheet1.Range("C16").Value = myCommandclienteDestManager.ExecuteScalar.ToString   ' Manager

            Dim mySelectQueryclienteDestAssistant As String
#Disable Warning BC42104 ' Variable 'ass' is used before it has been assigned a value. A null reference exception could result at runtime.
            mySelectQueryclienteDestAssistant = "SELECT  name1 FROM sapclients where kunnr ='" & ass & "'"
#Enable Warning BC42104 ' Variable 'ass' is used before it has been assigned a value. A null reference exception could result at runtime.
            Dim myCommandclienteDestAssistant As New SQLiteCommand(mySelectQueryclienteDestAssistant, myConnectionPricing)
            Sheet1.Range("C17").Value = myCommandclienteDestAssistant.ExecuteScalar.ToString  ' Assistant

            Dim mySelectQueryclienteStat As String
#Disable Warning BC42104 ' Variable 'clistat' is used before it has been assigned a value. A null reference exception could result at runtime.
            mySelectQueryclienteStat = "SELECT  name1 FROM sapclients where kunnr ='" & clistat & "'"
#Enable Warning BC42104 ' Variable 'clistat' is used before it has been assigned a value. A null reference exception could result at runtime.
            Dim myCommandclientestat As New SQLiteCommand(mySelectQueryclienteStat, myConnectionPricing)
            Sheet1.Range("c11").Value = myCommandclientestat.ExecuteScalar.ToString
            Sheet1.Range("d11").Value = clistat


            Dim mySelectQueryclientefact As String
            mySelectQueryclientefact = "SELECT  name1 FROM sapclients where kunnr ='" & clientfact & "'"
            Dim myCommandclientefact As New SQLiteCommand(mySelectQueryclientefact, myConnectionPricing)
            Sheet1.Range("C12").Value = myCommandclientefact.ExecuteScalar.ToString



            '''''INICIO Terms & Condition
            '''''INICIO Terms & Condition
            '''''INICIO Terms & Condition
            Dim mySelectQueryCREDIT As String = "SELECT KLIMK, zzdiastoler, ztermtext, zincoterms, advertencia  FROM SAPCLIENTS where kunnr = '" & clientfact & "'"
            Dim myCommandCREDIT As New SQLiteCommand(mySelectQueryCREDIT, myConnectionPricing)
            Dim myReadercredit As SQLiteDataReader
            myReadercredit = myCommandCREDIT.ExecuteReader()
            While myReadercredit.Read
                Sheet1.Range("G7").Value = CDbl(myReadercredit(0)) 'CreditLimit Value
                Sheet1.Range("I7").Value = myReadercredit(1).ToString  ' credit limit DAYS
                Sheet1.Range("G8").Value = myReadercredit(2).ToString   'Payment Terms
                Sheet1.Range("G9").Value = myReadercredit(3).ToString   'Delivery Terms
                Sheet1.Range("I8").Value = myReadercredit(4).ToString   'Tolerance
            End While
            myReadercredit.Close()

            Dim mySelectQueryCREDIT2 As String = "SELECT katr4  FROM SAPCLIENTS where kunnr = '" & clientdest & "'"
            Dim myCommandCREDIT2 As New SQLiteCommand(mySelectQueryCREDIT2, myConnectionPricing)
            Dim myReadercredit2 As SQLiteDataReader
            myReadercredit2 = myCommandCREDIT2.ExecuteReader()
            While myReadercredit2.Read
                Sheet1.Range("G10").Value = myReadercredit2(0).ToString   'Tamanho da Palete
            End While
            myReadercredit2.Close()


            '''''FIM Terms & Condition
            '''''FIM Terms & Condition
            '''''FIM Terms & Condition


            '''''FIM Invoice Customer Information
            '''''FIM Invoice Customer Information
            '''''FIM Invoice Customer Information






            '''''INICIO LOOP Produtos
            '''''INICIO LOOP Produtos
            '''''INICIO LOOP Produtos

            If filterkeyPricing = "931" Then
                mySelectQuery = "SELECT * FROM query2 where tabela='" & filterkeyPricing & "' and pcclid='" & clientdest & "' and pcccli='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "'  ORDER BY PCCPRP, PCORDE, PCACOL"
            ElseIf filterkeyPricing = "932" Then
                mySelectQuery = "SELECT * FROM query2 where tabela='" & filterkeyPricing & "' and pcccli='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "'  ORDER BY PCCPRP, PCORDE, PCACOL"

            ElseIf filterkeyPricing = "933" Then
                mySelectQuery = "SELECT * FROM query2 where tabela='" & filterkeyPricing & "' and pcclid='" & clientdest & "' and pcccli='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "'  ORDER BY PCORDE, PCACOL"
            ElseIf filterkeyPricing = "934" Then
                mySelectQuery = "SELECT * FROM query2 where tabela='" & filterkeyPricing & "' and pcccli='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "'  ORDER BY PCORDE, PCACOL"
            ElseIf filterkeyPricing = "935" Then
                mySelectQuery = "SELECT * FROM query2 where tabela='" & filterkeyPricing & "' and pcclid='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "'  ORDER BY PCORDE, PCACOL"
            ElseIf filterkeyPricing = "936" Then
                mySelectQuery = "SELECT * FROM query2 where tabela='" & filterkeyPricing & "' and pcclid='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "'  ORDER BY PCORDE, PCACOL"
            End If


#Disable Warning BC42104 ' Variable 'mySelectQuery' is used before it has been assigned a value. A null reference exception could result at runtime.
            Dim myCommand As New SQLiteCommand(mySelectQuery, myConnectionPricing)
#Enable Warning BC42104 ' Variable 'mySelectQuery' is used before it has been assigned a value. A null reference exception could result at runtime.
            Dim myReader1 As SQLiteDataReader
            myReader1 = myCommand.ExecuteReader()


            Dim countbottlecust As Integer = 0
            Dim OffInvoiceMarktSup As Integer = 0
            Dim flagfirstrow As Boolean = True

            While myReader1.Read()

                If ultimalinha > 24 Then
                    '' processo antigo Dim rng As Excel.Range = Sheet1.Range("A24").EntireRow
                    '' processo antigo rng.Copy(Sheet1.Range("A" & ultimalinha).EntireRow)
                    Sheet1.Rows(CStr(ultimalinha)).CopyFrom(Sheet1.Rows("24"))


                End If

                If flagfirstrow = True Then

                    Sheet1.Range("G4").Value = (Now.Year)
                    Sheet1.Range("I4").Value = (Today)
                    Sheet1.Range("G5").Value = CStr((myReader1("PCTPRE")).ToString & " " & getSymPriceListType(myReader1("PCTPRE").ToString))
                    Sheet1.Range("I5").Value = (myReader1("TABELA")).ToString
                    Sheet1.Range("G6").Value = (myReader1("PCDATI")).ToString
                    Sheet1.Range("I6").Value = (myReader1("PCDATF")).ToString

                    '''''INICIO Exchange Rates
                    '''''INICIO Exchange Rates
                    '''''INICIO Exchange Rates

                    Sheet1.Range("L18").Value = (myReader1("PCMOED")).ToString
                    If UCase(myReader1("PCMOED").ToString) <> "EUR" Then
                        Dim mySelectQueryEXC As String = "SELECT valor FROM sapcambios where nome='" & myReader1("PCMOED").ToString & "'"
                        Dim myCommandEXC As New SQLiteCommand(mySelectQueryEXC, myConnectionPricing)
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Double'.
                        Dim retEXC As Double = myCommandEXC.ExecuteScalar
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Double'.
                        Sheet1.Range("M18").Value = Math.Abs(retEXC)

                    Else
                        Sheet1.Range("M18").Value = 1
                    End If


                    '''''FIM Exchange Rates
                    '''''FIM Exchange Rates
                    '''''FIM Exchange Rates

                End If



                '''''INICIO LINHA Product
                '''''INICIO LINHA Product
                '''''INICIO LINHA Product


                Me.SapMateriaisQueryTableAdapter1.ClearBeforeFill = True
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Me.SapMateriaisQueryTableAdapter1.Fill(Me.SapPricingDataset11.SapMateriaisQuery, myReader1("PCCPRO"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.


                Dim retDescrProd As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                retDescrProd = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("maktx")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Sheet1.Range("A" & ultimalinha).Value = (retDescrProd)
                If IsDBNull(myReader1("PCCPRP")) Then
                    Sheet1.Range("BW" & ultimalinha).Value = (myReader1("PCCPRO")).ToString
                Else
                    Sheet1.Range("BW" & ultimalinha).Value = (myReader1("PCCPRP")).ToString
                End If


                Dim retUNITProd As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                retUNITProd = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("meins")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Sheet1.Range("BX" & ultimalinha).Value = (retUNITProd)


                Dim retRange As String

#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                retRange = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("RANGE")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Sheet1.Range("B" & ultimalinha).Value = retRange ''Stock


                Dim retEMBALDESC As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                retEMBALDESC = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("DESCR")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Sheet1.Range("C" & ultimalinha).Value = retEMBALDESC




                '''''FIM LINHA Product
                '''''FIM LINHA Product
                '''''FIM LINHA Product


                '''''INICIO LINHA Gross Customer Unit Price
                '''''INICIO LINHA Gross Customer Unit Price
                '''''INICIO LINHA Gross Customer Unit Price
                Sheet1.Range("F" & ultimalinha).Value = CDbl(myReader1("PCPVAC"))
                Try
                    Sheet1.Range("G" & ultimalinha).Value = CDbl(myReader1("PCPVAA"))
                Catch
                End Try
                '''''FIM LINHA Gross Customer Unit Price
                '''''FIM LINHA Gross Customer Unit Price
                '''''FIM LINHA Gross Customer Unit Price

                '''''INICIO LINHA Reference Price
                '''''INICIO LINHA Reference Price
                '''''INICIO LINHA Reference Price
                Try
                    Dim mySelectQueryREFPrice As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    mySelectQueryREFPrice = "SELECT kbetr FROM saprefprice where matnr='" & myReader1("PCCPRO") & "' and zzkatr3='" & Sheet1.Cells("C18").Value.TextValue & "' and datbi >='" & PCDATI & "' and datab <='" & PCDATI & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    Dim myCommandREFPrice As New SQLiteCommand(mySelectQueryREFPrice, myConnectionPricing)
                    Dim retREFPrice As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    retREFPrice = myCommandREFPrice.ExecuteScalar
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    Sheet1.Range("T" & ultimalinha).Value = CDbl(retREFPrice)
                Catch
                    Sheet1.Range("T" & ultimalinha).Value = Nothing
                End Try

                '''''FIM LINHA Reference Price
                '''''FIM LINHA Reference Price
                '''''FIM LINHA Reference Price

                '''''INICIO LINHA Bootling Costs
                '''''INICIO LINHA Bootling Costs
                '''''INICIO LINHA Bootling Costs
                Try
                    Dim mySelectQueryBOTCOSTMOQ As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    mySelectQueryBOTCOSTMOQ = "SELECT kbetr FROM sapbotlcost where matnr='" & myReader1("PCCPRO") & "' and datbi >='" & PCDATI & "' and datab <='" & PCDATI & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    Dim myCommandBOTCOSTMOQ As New SQLiteCommand(mySelectQueryBOTCOSTMOQ, myConnectionPricing)
                    Dim retBOTCOSTMOQ As Decimal
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Decimal'.
                    retBOTCOSTMOQ = myCommandBOTCOSTMOQ.ExecuteScalar
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Decimal'.
                    Sheet1.Range("BS" & ultimalinha).Value = retBOTCOSTMOQ
                Catch
                    Sheet1.Range("BS" & ultimalinha).Value = Nothing
                End Try
                '''''FIM LINHA Bootling Costs
                '''''FIM LINHA Bootling Costs
                '''''FIM LINHA Bootling Costs


                '''''INICIO LINHA Bonus
                '''''INICIO LINHA Bonus
                '''''INICIO LINHA Bonus

                Dim mySelectQueryBonus As String
                mySelectQueryBonus = ""
                If filterkeyPricing = "931" Then
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & filterkeyPricing & "' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                ElseIf filterkeyPricing = "933" Then
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & filterkeyPricing & "' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                ElseIf filterkeyPricing = "932" Then
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & filterkeyPricing & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                ElseIf filterkeyPricing = "934" Then
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & filterkeyPricing & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                ElseIf filterkeyPricing = "935" Then
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & filterkeyPricing & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                ElseIf filterkeyPricing = "936" Then
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & filterkeyPricing & "' and zcldest='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.

                End If

                Dim myCommandBonus As New SQLiteCommand(mySelectQueryBonus, myConnectionPricing)
                Dim retBonus As SQLiteDataReader
                retBonus = myCommandBonus.ExecuteReader(CommandBehavior.SingleRow)
                'atenção -> kbetr = knrmm = Minimum quantity
                'atenção -> knrnm = Free goods quantity
                'atenção -> knrnm = Additional quantity for free goods

                If retBonus.HasRows Then
                    Do While retBonus.Read
                        Sheet1.Range("BT" & ultimalinha).Value = CDbl(retBonus(0))
                        Sheet1.Range("BU" & ultimalinha).Value = CDbl(retBonus(1))
                        Sheet1.Range("BV" & ultimalinha).Value = CDbl(retBonus(2))
                    Loop
                Else
                    Sheet1.Range("BT" & ultimalinha).Value = Nothing
                    Sheet1.Range("BU" & ultimalinha).Value = Nothing
                    Sheet1.Range("BV" & ultimalinha).Value = Nothing
                End If


                '''''FIM LINHA Bonus
                '''''FIM LINHA Bonus
                '''''FIM LINHA Bonus


                '''''INICIO LINHA Estipulaçoes
                '''''INICIO LINHA Estipulaçoes
                '''''INICIO LINHA Estipulaçoes

                Dim mySelectQueryEstipulaçoes As String
                mySelectQueryEstipulaçoes = ""
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryEstipulaçoes = "SELECT knuma,boart, kschl, kbetr, bonem FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi >='" & PCDATF & "' and datab <='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.


                Dim myCommandEstipulaçoes As New SQLiteCommand(mySelectQueryEstipulaçoes, myConnectionPricing)
                Dim retEstipulaçoes As SQLiteDataReader


                retEstipulaçoes = myCommandEstipulaçoes.ExecuteReader
                Dim countcomm = 0
                Do While retEstipulaçoes.Read

                    Dim newRow = Pricing.estipulacaoDataTable.NewRow
                    newRow(0) = retEstipulaçoes("knuma")
                    newRow(1) = retEstipulaçoes("boart")
                    newRow(2) = retEstipulaçoes("bonem")
                    newRow(3) = PCDATI
                    newRow(4) = PCDATF
                    newRow(5) = retEstipulaçoes("kschl")
                    newRow(6) = myReader1("PCCPRO")
#Disable Warning BC42017 ' Late bound resolution; runtime errors could occur.
                    If UCase(retEstipulaçoes("kschl")).ToString.EndsWith("V") Then
#Enable Warning BC42017 ' Late bound resolution; runtime errors could occur.
                        newRow(7) = retEstipulaçoes("kbetr")
                    Else
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                        newRow(7) = retEstipulaçoes("kbetr") / 10
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                    End If
                    newRow(8) = Sheet1.Range("BX" & ultimalinha).Value


                    Pricing.estipulacaoDataTable.Rows.Add(newRow)



                    Dim clientpricesupport As New List(Of String)
                    Dim clientAPsupport As New List(Of String)
                    Dim clientRappel As New List(Of String)


                    Sheet1.Range("AX" & ultimalinha).Value = Nothing
                    Sheet1.Range("AY" & ultimalinha).Value = Nothing
                    Sheet1.Range("AZ" & ultimalinha).Value = Nothing
                    Sheet1.Range("BA" & ultimalinha).Value = Nothing
                    Sheet1.Range("BB" & ultimalinha).Value = Nothing
                    Sheet1.Range("BC" & ultimalinha).Value = Nothing
                    Sheet1.Range("BD" & ultimalinha).Value = Nothing
                    Sheet1.Range("BE" & ultimalinha).Value = Nothing
                    Sheet1.Range("BF" & ultimalinha).Value = Nothing
                    Sheet1.Range("BG" & ultimalinha).Value = Nothing
                    Sheet1.Range("BH" & ultimalinha).Value = Nothing
                    Sheet1.Range("BI" & ultimalinha).Value = Nothing
                    Sheet1.Range("BJ" & ultimalinha).Value = Nothing
                    Sheet1.Range("BK" & ultimalinha).Value = Nothing
                    Sheet1.Range("BL" & ultimalinha).Value = Nothing
                    Sheet1.Range("BM" & ultimalinha).Value = Nothing
                    Sheet1.Range("BN" & ultimalinha).Value = Nothing
                    Sheet1.Range("BO" & ultimalinha).Value = Nothing
                    Sheet1.Range("BP" & ultimalinha).Value = Nothing
                    Sheet1.Range("BQ" & ultimalinha).Value = Nothing
                    Sheet1.Range("BR" & ultimalinha).Value = Nothing




#Disable Warning BC42036 ' Operands of type Object used in expressions for 'Select', 'Case' statements; runtime errors could occur.
                    Select Case retEstipulaçoes("kschl")
#Enable Warning BC42036 ' Operands of type Object used in expressions for 'Select', 'Case' statements; runtime errors could occur.
                        ''Price Support
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        Case "YSCV" ' credit note V
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                            Sheet1.Range("AX" & ultimalinha).Value = Sheet1.Range("AX" & ultimalinha).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        Case "YSCP" ' credit note P
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                            Sheet1.Range("AY" & ultimalinha).Value = Sheet1.Range("AY" & ultimalinha).Value.NumericValue + (retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        Case "YSHV" ' Charged by customer V
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                            Sheet1.Range("AZ" & ultimalinha).Value = Sheet1.Range("AZ" & ultimalinha).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        Case "YSHP" ' Charged by customer P
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                            Sheet1.Range("BA" & ultimalinha).Value = Sheet1.Range("BA" & ultimalinha).Value.NumericValue + (retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.

                            ''A&P Support
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        Case "YAPV"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                            Sheet1.Range("BD" & ultimalinha).Value = Sheet1.Range("BD" & ultimalinha).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                            clientAPsupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        Case "YAPP"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                            Sheet1.Range("BE" & ultimalinha).Value = Sheet1.Range("BE" & ultimalinha).Value.NumericValue + (retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                            clientAPsupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        Case "YABV"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                            Sheet1.Range("BF" & ultimalinha).Value = Sheet1.Range("BF" & ultimalinha).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                            clientAPsupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.

                            ''Rappel....
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        Case "YRRV"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                            Sheet1.Range("BI" & ultimalinha).Value = Sheet1.Range("BI" & ultimalinha).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                            clientRappel.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        Case "YRRP"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                            Sheet1.Range("BJ" & ultimalinha).Value = Sheet1.Range("BJ" & ultimalinha).Value.NumericValue + (retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                            clientRappel.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                            ''Commisions
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        Case "YCOP"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                            countcomm = countcomm + 1
                            If countcomm = 1 Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                                Sheet1.Range("BM" & ultimalinha).Value = CDbl(retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                                Sheet1.Range("BN" & ultimalinha).Value = retEstipulaçoes("bonem").ToString
                            ElseIf countcomm = 2 Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                                Sheet1.Range("BO" & ultimalinha).Value = CDbl(retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                                Sheet1.Range("BP" & ultimalinha).Value = retEstipulaçoes("bonem").ToString
                            ElseIf countcomm = 3 Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                                Sheet1.Range("BQ" & ultimalinha).Value = CDbl(retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                                Sheet1.Range("BR" & ultimalinha).Value = retEstipulaçoes("bonem").ToString
                            Else
                                MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                            End If
                    End Select

                    Dim distinctNamesclientpricesupport = clientpricesupport.Distinct()
                    Dim distinctNamesclientpricesupportitem As String
                    For Each distinctNamesclientpricesupportitem In distinctNamesclientpricesupport
                        Dim stringps = ""
                        stringps = stringps & distinctNamesclientpricesupportitem & " - "
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                        Sheet1.Range("BC" & ultimalinha).Value = stringps.Trim(" - ")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                    Next
                    Dim distinctNamesclientAPsupport = clientAPsupport.Distinct()
                    Dim distinctNamesclientAPsupportitem As String
                    For Each distinctNamesclientAPsupportitem In distinctNamesclientAPsupport
                        Dim stringAP = ""
                        stringAP = stringAP & distinctNamesclientAPsupportitem & " - "
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                        Sheet1.Range("BH" & ultimalinha).Value = stringAP.Trim(" - ")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                    Next
                    Dim distinctNamesclientrappel = clientRappel.Distinct()
                    Dim distinctNamesclientrappelitem As String
                    For Each distinctNamesclientrappelitem In distinctNamesclientrappel
                        Dim stringR = ""
                        stringR = stringR & distinctNamesclientrappelitem & " - "
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                        Sheet1.Range("BL" & ultimalinha).Value = stringR.Trim(" - ")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                    Next

                Loop


                '''''FIM LINHA Estipulaçoes
                '''''FIM LINHA Estipulaçoes
                '''''FIM LINHA Estipulaçoes



                ' '''''INICIO LINHA  VOLUMES(9L)
                ' '''''INICIO LINHA  VOLUMES(9L)
                ' '''''INICIO LINHA  VOLUMES(9L)

                If filterkeyPricing = "936" Then ''''ALEMANHA por CLIENTE ESTATISTICO
                    ''''Vendas por materialforecast
                    Dim mySelectQueryVol9LTotal As String
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    mySelectQueryVol9LTotal = "SELECT SUM(SHIPPED) as exp4, SUM(INHAND) as exp5 FROM sapsalesforpricing WHERE (statsclientnum = '" & clistat & "') AND ([Immaterial] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    Dim myCommandVol9Ltotal As New SQLiteCommand(mySelectQueryVol9LTotal, myConnectionPricing)
                    Dim retVol9Ltotal As SQLiteDataReader
                    Try
                        retVol9Ltotal = myCommandVol9Ltotal.ExecuteReader(CommandBehavior.SingleRow)
                        If Not (retVol9Ltotal(0)) Is DBNull.Value Then Sheet1.Range("CT" & ultimalinha).Value = CDec(retVol9Ltotal(0)) Else Sheet1.Range("CT" & ultimalinha).Value = Nothing
                        If Not (retVol9Ltotal(1)) Is DBNull.Value Then Sheet1.Range("CU" & ultimalinha).Value = CDec(retVol9Ltotal(1)) Else Sheet1.Range("CU" & ultimalinha).Value = Nothing
                        Sheet1.Range("Y" & ultimalinha).Value = Sheet1.Range("CT" & ultimalinha).Value.NumericValue + Sheet1.Range("CU" & ultimalinha).Value.NumericValue
                    Catch ex As Exception
                        Sheet1.Range("Y" & ultimalinha).Value = Nothing
                        Sheet1.Range("CT" & ultimalinha).Value = Nothing
                        Sheet1.Range("CU" & ultimalinha).Value = Nothing
                    End Try


                    ''''Forecast e target
                    Dim mySelectQueryVol9LFore As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    mySelectQueryVol9LFore = "SELECT SUM(FORECA) as exp1, SUM(FORECM) as exp2 FROM sapsales WHERE (statsclientnum = '" & clistat & "') AND ([Material Number] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    Dim myCommandVol9LFore As New SQLiteCommand(mySelectQueryVol9LFore, myConnectionPricing)
                    Dim retVol9LFore As SQLiteDataReader
                    Try
                        retVol9LFore = myCommandVol9LFore.ExecuteReader(CommandBehavior.SingleRow)
                        If Not (retVol9LFore(0)) Is DBNull.Value Then Sheet1.Range("V" & ultimalinha).Value = CDec(retVol9LFore(0)) Else Sheet1.Range("V" & ultimalinha).Value = Nothing
                        If Not (retVol9LFore(1)) Is DBNull.Value Then Sheet1.Range("Z" & ultimalinha).Value = CDec(retVol9LFore(1)) Else Sheet1.Range("Z" & ultimalinha).Value = Nothing
                    Catch ex As Exception
                        Sheet1.Range("V" & ultimalinha).Value = Nothing
                        Sheet1.Range("Z" & ultimalinha).Value = Nothing
                    End Try



                    ''''Last Year
                    Dim mySelectQueryVol9L3 As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    mySelectQueryVol9L3 = "SELECT SUM(SHIPPED) as exp1 FROM sapsalesforpricing WHERE (statsclientnum = '" & clistat & "') AND ([Immaterial] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year - 1 & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    Dim myCommandVol9L3 As New SQLiteCommand(mySelectQueryVol9L3, myConnectionPricing)
                    Dim retVol9L3 As String
                    Try
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        retVol9L3 = myCommandVol9L3.ExecuteScalar
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        If Not (retVol9L3) Is DBNull.Value Then Sheet1.Range("W" & ultimalinha).Value = CDec(retVol9L3) Else Sheet1.Range("W" & ultimalinha).Value = Nothing
                    Catch
                        Sheet1.Range("W" & ultimalinha).Value = Nothing
                    End Try

                Else
                    ''''Vendas por materialforecast
                    Dim mySelectQueryVol9LTotal As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    mySelectQueryVol9LTotal = "SELECT SUM(SHIPPED) as exp4, SUM(INHAND) as exp5 FROM sapsalesforpricing WHERE (invclientnum = '" & clientfact & "') AND (finalclientnum = '" & clientdest & "') AND ([Immaterial] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    Dim myCommandVol9Ltotal As New SQLiteCommand(mySelectQueryVol9LTotal, myConnectionPricing)
                    Dim retVol9Ltotal As SQLiteDataReader
                    Try
                        retVol9Ltotal = myCommandVol9Ltotal.ExecuteReader(CommandBehavior.SingleRow)
                        If Not (retVol9Ltotal(0)) Is DBNull.Value Then Sheet1.Range("CT" & ultimalinha).Value = CDec(retVol9Ltotal(0)) Else Sheet1.Range("CT" & ultimalinha).Value = Nothing
                        If Not (retVol9Ltotal(1)) Is DBNull.Value Then Sheet1.Range("CU" & ultimalinha).Value = CDec(retVol9Ltotal(1)) Else Sheet1.Range("CU" & ultimalinha).Value = Nothing
                        Sheet1.Range("Y" & ultimalinha).Value = Sheet1.Range("CT" & ultimalinha).Value.NumericValue + Sheet1.Range("CU" & ultimalinha).Value.NumericValue
                    Catch ex As Exception
                        Sheet1.Range("Y" & ultimalinha).Value = Nothing
                        Sheet1.Range("CT" & ultimalinha).Value = Nothing
                        Sheet1.Range("CU" & ultimalinha).Value = Nothing
                    End Try


                    ''''Forecast e target
                    Dim mySelectQueryVol9LFore As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    mySelectQueryVol9LFore = "SELECT SUM(FORECA) as exp1, SUM(FORECM) as exp2 FROM sapsales WHERE (invclientnum = '" & clientfact & "') AND (finalclientnum = '" & clientdest & "') AND ([Material Number] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    Dim myCommandVol9LFore As New SQLiteCommand(mySelectQueryVol9LFore, myConnectionPricing)
                    Dim retVol9LFore As SQLiteDataReader
                    Try
                        retVol9LFore = myCommandVol9LFore.ExecuteReader(CommandBehavior.SingleRow)
                        If Not (retVol9LFore(0)) Is DBNull.Value Then Sheet1.Range("V" & ultimalinha).Value = CDec(retVol9LFore(0)) Else Sheet1.Range("V" & ultimalinha).Value = Nothing
                        If Not (retVol9LFore(1)) Is DBNull.Value Then Sheet1.Range("Z" & ultimalinha).Value = CDec(retVol9LFore(1)) Else Sheet1.Range("Z" & ultimalinha).Value = Nothing
                    Catch ex As Exception
                        Sheet1.Range("V" & ultimalinha).Value = Nothing
                        Sheet1.Range("Z" & ultimalinha).Value = Nothing
                    End Try



                    ''''Last Year
                    Dim mySelectQueryVol9L3 As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    mySelectQueryVol9L3 = "SELECT SUM(SHIPPED) as exp1 FROM sapsalesforpricing WHERE (invclientnum = '" & clientfact & "') AND (finalclientnum = '" & clientdest & "') AND ([Immaterial] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year - 1 & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    Dim myCommandVol9L3 As New SQLiteCommand(mySelectQueryVol9L3, myConnectionPricing)
                    Dim retVol9L3 As String
                    Try
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        retVol9L3 = myCommandVol9L3.ExecuteScalar
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        If Not (retVol9L3) Is DBNull.Value Then Sheet1.Range("W" & ultimalinha).Value = CDec(retVol9L3) Else Sheet1.Range("W" & ultimalinha).Value = Nothing
                    Catch
                        Sheet1.Range("W" & ultimalinha).Value = Nothing
                    End Try

                End If

                ' '''''FIM LINHA VOLUMES(9L)
                ' '''''FIM LINHA VOLUMES(9L)
                ' '''''FIM LINHA VOLUMES(9L)


                '''''INICIO LINHA 2 Product
                '''''INICIO LINHA 2 Product
                '''''INICIO LINHA 2 Product
                Sheet1.Range("AC" & ultimalinha).Value = (myReader1("PCCPRO")).ToString



                Dim retEMBALLITRO As Decimal

#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Decimal'.
                retEMBALLITRO = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("LTS")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Decimal'.
                Sheet1.Range("AD" & ultimalinha).Value = (retEMBALLITRO)


                Dim retEMBALCAP As Decimal
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Decimal'.
                retEMBALCAP = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("cap")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Decimal'.
                Try
                    If retEMBALCAP <> 0 Then
                        Sheet1.Range("AE" & ultimalinha).Value = (retEMBALLITRO / retEMBALCAP)
                        Sheet1.Range("E" & ultimalinha).Value = Sheet1.Range("F" & ultimalinha).Value.NumericValue / Sheet1.Range("AE" & ultimalinha).Value.NumericValue

                    Else
                        Sheet1.Range("AE" & ultimalinha).Value = "n/a"
                    End If
                Catch
                    Sheet1.Range("AE" & ultimalinha).Value = "n/a"
                End Try

                '''''FIM LINHA 2 Product
                '''''FIM LINHA 2 Product
                '''''FIM LINHA 2 Product


                '''''INICIO LINHA 2 OFF INVOICE SUPPORT
                '''''INICIO LINHA 2 OFF INVOICE SUPPORT
                '''''INICIO LINHA 2 OFF INVOICE SUPPORT

                If IsDBNull(myReader1("ZDEV")) = False Then
                    Sheet1.Range("AF" & ultimalinha).Value = CDbl(myReader1("ZDEV"))
                Else
                    Sheet1.Range("AF" & ultimalinha).Value = Nothing
                End If

                If IsNumeric(myReader1("ZDEP")) Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                    Sheet1.Range("AG" & ultimalinha).Value = CDbl(myReader1("ZDEP") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                Else
                    Sheet1.Range("AG" & ultimalinha).Value = Nothing

                End If

                If IsDBNull(myReader1("ZDQV")) = False Then
                    Sheet1.Range("AH" & ultimalinha).Value = CDbl(myReader1("ZDQV"))
                Else
                    Sheet1.Range("AH" & ultimalinha).Value = Nothing

                End If

                If IsNumeric(myReader1("ZDQP")) Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                    Sheet1.Range("AI" & ultimalinha).Value = CDbl(myReader1("ZDQP") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                Else
                    Sheet1.Range("AI" & ultimalinha).Value = Nothing

                End If

                If IsDBNull(myReader1("ZDPV")) = False Then
                    Sheet1.Range("AJ" & ultimalinha).Value = CDbl(myReader1("ZDPV"))
                Else
                    Sheet1.Range("AJ" & ultimalinha).Value = Nothing

                End If

                If IsNumeric(myReader1("ZDPP")) Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                    Sheet1.Range("AK" & ultimalinha).Value = CDbl(myReader1("ZDPP") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                Else
                    Sheet1.Range("AK" & ultimalinha).Value = Nothing

                End If

                If IsDBNull(myReader1("ZDRV")) = False Then
                    Sheet1.Range("AL" & ultimalinha).Value = CDbl(myReader1("ZDRV"))
                Else
                    Sheet1.Range("AL" & ultimalinha).Value = Nothing

                End If

                If IsNumeric(myReader1("ZDRP")) Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                    Sheet1.Range("AM" & ultimalinha).Value = CDbl(myReader1("ZDRP") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                Else
                    Sheet1.Range("AM" & ultimalinha).Value = Nothing

                End If

                If IsDBNull(myReader1("ZDLV")) = False Then
                    Sheet1.Range("AN" & ultimalinha).Value = CDbl(myReader1("ZDLV"))
                Else
                    Sheet1.Range("AN" & ultimalinha).Value = Nothing

                End If

                If IsNumeric(myReader1("ZDLP")) Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                    Sheet1.Range("AO" & ultimalinha).Value = CDbl(myReader1("ZDLP") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                Else
                    Sheet1.Range("AO" & ultimalinha).Value = Nothing

                End If

                If IsDBNull(myReader1("ZDTV")) = False Then
                    Sheet1.Range("AP" & ultimalinha).Value = CDbl(myReader1("ZDTV"))
                Else
                    Sheet1.Range("AP" & ultimalinha).Value = Nothing

                End If

                If IsNumeric(myReader1("ZDTP")) Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                    Sheet1.Range("AQ" & ultimalinha).Value = CDbl(myReader1("ZDTP") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                Else
                    Sheet1.Range("AQ" & ultimalinha).Value = Nothing

                End If



                '''''FIM LINHA 2 OFF INVOICE SUPPORT
                '''''FIM LINHA 2 OFF INVOICE SUPPORT
                '''''FIM LINHA 2 OFF INVOICE SUPPORT

                '''''INICIO LINHA 2 EXTRAS ON INVOICE
                '''''INICIO LINHA 2 EXTRAS ON INVOICE
                '''''INICIO LINHA 2 EXTRAS ON INVOICE
                If IsDBNull(myReader1("ZEEC")) = False Then Sheet1.Range("AR" & ultimalinha).Value = CDbl(myReader1("ZEEC")) Else Sheet1.Range("AR" & ultimalinha).Value = Nothing
                If IsDBNull(myReader1("ZEFR")) = False Then Sheet1.Range("AS" & ultimalinha).Value = CDbl(myReader1("ZEFR")) Else Sheet1.Range("AS" & ultimalinha).Value = Nothing
                If IsDBNull(myReader1("ZEIN")) = False Then Sheet1.Range("AT" & ultimalinha).Value = CDbl(myReader1("ZEIN")) Else Sheet1.Range("AT" & ultimalinha).Value = Nothing
                If IsDBNull(myReader1("ZEFI")) = False Then Sheet1.Range("AU" & ultimalinha).Value = CDbl(myReader1("ZEFI")) Else Sheet1.Range("AU" & ultimalinha).Value = Nothing
                If IsDBNull(myReader1("ZESL")) = False Then Sheet1.Range("AV" & ultimalinha).Value = CDbl(myReader1("ZESL")) Else Sheet1.Range("AV" & ultimalinha).Value = Nothing
                If IsDBNull(myReader1("ZESP")) = False Then Sheet1.Range("AW" & ultimalinha).Value = CDbl(myReader1("ZESP")) Else Sheet1.Range("AW" & ultimalinha).Value = Nothing
                '''''FIM LINHA 2 EXTRAS ON INVOICE
                '''''FIM LINHA 2 EXTRAS ON INVOICE
                '''''FIM LINHA 2 EXTRAS ON INVOICE


                '''''INICIO LINHA 2 MOQ
                '''''INICIO LINHA 2 MOQ
                '''''INICIO LINHA 2 MOQ
                'Sheet1.Range("BS" & ultimalinha).value = (myReader1("PCMOQ"))
                '''''FIM LINHA 2 MOQ
                '''''FIM LINHA 2 MOQ
                '''''FIM LINHA 2 MOQ
                '''''INICIO LINHA 2 PCMARK
                '''''INICIO LINHA 2 PCMARK
                '''''INICIO LINHA 2 PCMARK
                'Sheet1.Range("BT" & ultimalinha).value = (myReader1("PCMARK"))
                '''''FIM LINHA 2 PCMARK
                '''''FIM LINHA 2 PCMARK
                '''''FIM LINHA 2 PCMARK

                '''''INICIO LINHA 2 DSQ
                '''''INICIO LINHA 2 DSQ
                '''''INICIO LINHA 2 DSQ
                'If IsDBNull(myReader1("PCBDSQ")) = False Then Sheet1.Range("BU" & ultimalinha).value = (myReader1("PCBDSQ")) Else Sheet1.Range("BU" & ultimalinha).value = ""
                'If IsDBNull(myReader1("PCVDSQ")) = False Then Sheet1.Range("BV" & ultimalinha).value = (myReader1("PCVDSQ")) Else Sheet1.Range("BV" & ultimalinha).value = ""
                '''''FIM LINHA 2 DSQ
                '''''FIM LINHA 2 DSQ
                '''''FIM LINHA 2 DSQ


                ultimalinha = ultimalinha + 1
                flagfirstrow = False

            End While

            ' '''''INICIO VOLUMES(9L) Bottled Matured
            ' '''''INICIO VOLUMES(9L) Bottled Matured
            ' '''''INICIO VOLUMES(9L) Bottled Matured
            Dim querystring As String
            If filterkeyPricing = "936" Then ''''ALEMANHA por CLIENTE ESTATISTICO
                querystring = "(statsclientnum = '" & clistat & "')"
            Else
                querystring = "(finalclientnum = '" & clientdest & "')"
            End If

            ''Crusted
            ''Crusted
            ''Crusted
            Dim mySelectQueryVol9LBM As String = "SELECT SUM(FORECA) as exp1, SUM(SHIPHAND) as exp2, SUM(FORECM) as exp3 FROM sapsales WHERE familia = 'Crusted' AND COMPANY = '" & company & "' AND TIPO = '" & tipo & "' AND " & querystring & " AND Year = '" & Now.Year & "'"
            Dim myCommandVol9LBM As New SQLiteCommand(mySelectQueryVol9LBM, myConnectionPricing)
            Dim retVol9LBM As SQLiteDataReader
            Try
                retVol9LBM = myCommandVol9LBM.ExecuteReader(CommandBehavior.SingleRow)
                If Not (retVol9LBM(0)) Is DBNull.Value Then Sheet1.Range("X6").Value = CDec(retVol9LBM(0))
                If Not (retVol9LBM(1)) Is DBNull.Value Then Sheet1.Range("Y6").Value = CDec(retVol9LBM(1))
                If Not (retVol9LBM(2)) Is DBNull.Value Then Sheet1.Range("Z6").Value = CDec(retVol9LBM(2))
                retVol9LBM.Close()
            Catch
                Sheet1.Range("X6").Value = 0
                Sheet1.Range("Y6").Value = 0
                Sheet1.Range("Z6").Value = 0
            End Try

            ''Trad LBV
            ''Trad LBV
            ''Trad LBV 
            Dim mySelectQueryVol9LBMLBV As String = "SELECT SUM(FORECA) as exp1, SUM(SHIPHAND) as exp2, SUM(FORECM) as exp3 FROM sapsales WHERE familia = 'Bottle Aged LBV' AND COMPANY = '" & company & "' AND TIPO = '" & tipo & "' AND " & querystring & " AND Year = '" & Now.Year & "'"
            Dim myCommandVol9LBMLBV As New SQLiteCommand(mySelectQueryVol9LBMLBV, myConnectionPricing)
            Dim retVol9LBMLBV As SQLiteDataReader
            Try
                retVol9LBMLBV = myCommandVol9LBM.ExecuteReader(CommandBehavior.SingleRow)
                If Not (retVol9LBMLBV(0)) Is DBNull.Value Then Sheet1.Range("X7").Value = CDec(retVol9LBMLBV(0))
                If Not (retVol9LBMLBV(1)) Is DBNull.Value Then Sheet1.Range("Y7").Value = CDec(retVol9LBMLBV(1))
                If Not (retVol9LBMLBV(2)) Is DBNull.Value Then Sheet1.Range("Z7").Value = CDec(retVol9LBMLBV(2))
                retVol9LBMLBV.Close()
            Catch
                Sheet1.Range("X7").Value = 0
                Sheet1.Range("Y7").Value = 0
                Sheet1.Range("Z7").Value = 0
            End Try


            ''Quintas
            ''Quintas
            ''Quintas
            Dim mySelectQueryVol9LBMquintas As String = "SELECT SUM(FORECA) as exp1, SUM(SHIPHAND) as exp2, SUM(FORECM) as exp3 FROM sapsales WHERE SUBSTR(familia,1,6) = 'Quinta' AND COMPANY = '" & company & "' AND TIPO = '" & tipo & "' AND " & querystring & " AND Year = '" & Now.Year & "'"
            Dim myCommandVol9LBMquintas As New SQLiteCommand(mySelectQueryVol9LBMquintas, myConnectionPricing)
            Dim retVol9LBMquintas As SQLiteDataReader
            Try
                retVol9LBMquintas = myCommandVol9LBMquintas.ExecuteReader(CommandBehavior.SingleRow)
                If Not (retVol9LBMquintas(0)) Is DBNull.Value Then Sheet1.Range("X8").Value = CDec(retVol9LBMquintas(0))
                If Not (retVol9LBMquintas(1)) Is DBNull.Value Then Sheet1.Range("Y8").Value = CDec(retVol9LBMquintas(1))
                If Not (retVol9LBMquintas(2)) Is DBNull.Value Then Sheet1.Range("Z8").Value = CDec(retVol9LBMquintas(2))
                retVol9LBMquintas.Close()
            Catch
                Sheet1.Range("X8").Value = 0
                Sheet1.Range("Y8").Value = 0
                Sheet1.Range("Z8").Value = 0
            End Try

            ''Vintage
            ''Vintage
            ''Vintage

            Dim mySelectQueryVol9LBMvintage As String = "SELECT SUM(FORECA) as exp1, SUM(SHIPHAND) as exp2, SUM(FORECM) as exp3 FROM sapsales WHERE SUBSTR(familia,1,7) = 'Vintage' AND COMPANY = '" & company & "' AND TIPO = '" & tipo & "' AND " & querystring & " AND Year = '" & Now.Year & "'"
            Dim myCommandVol9LBMvintage As New SQLiteCommand(mySelectQueryVol9LBMvintage, myConnectionPricing)
            Dim retVol9LBMvintage As SQLiteDataReader
            Try
                retVol9LBMvintage = myCommandVol9LBMvintage.ExecuteReader(CommandBehavior.SingleRow)
                If Not (retVol9LBMvintage(0)) Is DBNull.Value Then Sheet1.Range("X9").Value = CDec(retVol9LBMvintage(0))
                If Not (retVol9LBMvintage(1)) Is DBNull.Value Then Sheet1.Range("Y9").Value = CDec(retVol9LBMvintage(1))
                If Not (retVol9LBMvintage(2)) Is DBNull.Value Then Sheet1.Range("Z9").Value = CDec(retVol9LBMvintage(2))
                retVol9LBMvintage.Close()
            Catch
                Sheet1.Range("X9").Value = 0
                Sheet1.Range("Y9").Value = 0
                Sheet1.Range("Z9").Value = 0
            End Try


            '''''FIM VOLUMES(9L) Bottled Matured
            '''''FIM VOLUMES(9L) Bottled Matured
            '''''FIM VOLUMES(9L) Bottled Matured


            '''''INICIO SUPPORT TOTALS
            '''''INICIO SUPPORT TOTALS
            '''''INICIO SUPPORT TOTALS
            Try


                Dim formulaG15 As String = ""
                formulaG15 = "= (SUM(AR24:AW24)/AD24*9*Y24)"
                For X0 = 25 To ultimalinha - 1
                    If Sheet1.Range("F" & X0).Value <> 0 Then
                        formulaG15 = formulaG15 & "+(SUM(AR" & X0 & ":AW" & X0 & ")/AD" & X0 & "*9*Y" & X0 & ")"
                    End If
                Next
                Sheet1.Range("G15").Formula = formulaG15

                '''''''''''''''''

                Dim formulaG14 As String = ""
                formulaG14 = "= ((AF24+AH24+AJ24+AL24+AN24+AP24)/AD24*9*Y24)+((F24*((K24/100))/AD24*9*Y24))"
                Dim X As Integer
                For X = 25 To ultimalinha - 1
                    If Sheet1.Range("F" & X).Value <> 0 Then
                        formulaG14 = formulaG14 & "+((AF" & X & "+AH" & X & "+AJ" & X & "+AL" & X & "+AN" & X & "+AP" & X & ")/AD" & X & "*9*Y" & X & ")+((F" & X & "*((K" & X & "/100))/AD" & X & "*9*y" & X & "))"
                    End If
                Next
                Sheet1.Range("G14").Formula = formulaG14

                ''''''''''''''''

                Dim formulaI14 As String = ""
                formulaI14 = "=((AX24+AZ24)/AD24*9*Y24) + ((F24*((AY24+BA24)/100))/AD24*9*Y24)"
                Dim X3 As Integer
                For X3 = 25 To ultimalinha - 1
                    If Sheet1.Range("F" & X3).Value <> 0 Then
                        formulaI14 = formulaI14 & "+((AX" & X3 & "+AZ" & X3 & ")/AD" & X3 & "*9*Y" & X3 & ") + ((F" & X3 & "*((AY" & X3 & "+BA" & X3 & ")/100))/AD" & X3 & "*9*Y" & X3 & ")"
                    End If
                Next
                'Sheet1.Range("I14").value = formulaI14

                '''''''''''''''''''''''''''

                Dim formulaI15 As String = ""
                formulaI15 = "= ((BD24/AD24*9*Y24) + ((F24*((BE24)/100))/AD24*9*Y24))"
                Dim X4 As Integer
                For X4 = 25 To ultimalinha - 1
                    If Sheet1.Range("F" & X4).Value <> 0 Then
                        formulaI15 = formulaI15 & "+((BD" & X4 & "/AD" & X4 & "*9*Y" & X4 & ") + ((F" & X4 & "*((BE" & X4 & ")/100))/AD" & X4 & "*9*Y" & X4 & "))"
                    End If
                Next
                Sheet1.Range("I15").Formula = formulaI15

                '''''''''''''''''''''''''''

                Dim formulaI16 As String = ""
                formulaI16 = "= BF24"
                Dim X6 As Integer
                For X6 = 25 To ultimalinha - 1
                    formulaI16 = formulaI16 & "+BF" & X6
                Next
                Sheet1.Range("I16").Formula = formulaI16

                '''''''''''''''''''''''''''

                Dim formulaI17 As String = ""
                formulaI17 = "= ((BI24/AD24*9*Y24) + ((F24*((BJ24)/100))/AD24*9*Y24))"
                Dim X5 As Integer
                For X5 = 25 To ultimalinha - 1
                    If Sheet1.Range("F" & X5).Value <> 0 Then
                        formulaI17 = formulaI17 & "+((BI" & X5 & "/AD" & X5 & "*9*Y" & X5 & ") + ((F" & X5 & "*((BJ" & X5 & ")/100))/AD" & X5 & "*9*Y" & X5 & "))"
                    End If
                Next
                Sheet1.Range("I17").Formula = formulaI17

                '''''''''''''''''''''''''''


                '''''FIM SUPPORT TOTALS
                '''''FIM SUPPORT TOTALS
                '''''FIM SUPPORT TOTALS

                '''''INICIO Sales Data Analysis
                '''''INICIO Sales Data Analysis
                '''''INICIO Sales Data Analysis
                'Shipped-1
                Sheet1.Range("L5").Formula = "= SUM(W24:W" & ultimalinha - 1 & ")"
                Dim formulaShipped1 As String

                formulaShipped1 = "=W24*(M24/$AD24*9/$N$18)"
                Dim XXSH1 As Integer
                For XXSH1 = 25 To ultimalinha - 1
                    formulaShipped1 = formulaShipped1 & "+W" & XXSH1 & "*(M" & XXSH1 & "/$AD" & XXSH1 & "*9/$N$18)"
                Next
                Sheet1.Range("N5").Formula = formulaShipped1

                'Target
                Sheet1.Range("L6").Formula = "= SUM(V24:V" & ultimalinha - 1 & ")"
                Dim formula As String
                formula = "=V24*(M24/$AD24*9/$N$18)"
                Dim XX As Integer
                For XX = 25 To ultimalinha - 1
                    formula = formula & "+V" & XX & "*(M" & XX & "/$AD" & XX & "*9/$N$18)"
                Next
                Sheet1.Range("N6").Formula = formula


                'Forecast
                Sheet1.Range("L7").Formula = "=SUM(Z24:Z" & ultimalinha - 1 & ")"
                Dim formulaforeca As String
                formulaforeca = "=Z24*(M24/$AD24*9/$N$18)"
                Dim XX3 As Integer
                For XX3 = 25 To ultimalinha - 1
                    formulaforeca = formulaforeca & "+Z" & XX3 & "*(M" & XX3 & "/$AD" & XX3 & "*9/$N$18)"
                Next
                Sheet1.Range("N7").Formula = formulaforeca


                'shipHand
                Sheet1.Range("L8").Formula = "= SUM(Y24:Y" & ultimalinha - 1 & ")"
                Dim formula_D As String
                formula_D = "=Y24*(M24/$AD24*9/$N$18)"
                Dim XXXXX As Integer
                For XXXXX = 25 To ultimalinha - 1
                    formula_D = formula_D & "+Y" & XXXXX & "*(M" & XXXXX & "/$AD" & XXXXX & "*9/$N$18)"
                Next
                Sheet1.Range("N8").Formula = formula_D


                '''''FIM Sales Data Analysis
                '''''FIM Sales Data Analysis
                '''''FIM Sales Data Analysis




                '''''INICIO Pricing Analysis
                '''''INICIO Pricing Analysis
                '''''INICIO Pricing Analysis

                Dim formula2a As String
                formula2a = "(Y24*S24"
                Dim X1a As Integer
                For X1a = 25 To ultimalinha - 1
                    formula2a = formula2a & "+Y" & X1a & "*S" & X1a
                Next
                formula2a = formula2a & ")/(L7+L8)"
                formula2a = "= IF(ISERROR(" & formula2a & ");0;" & formula2a & ")"
                Sheet1.Range("M13").Formula = formula2a


                Dim formula2b As String
                formula2b = "(V24*S24"
                Dim X1b As Integer
                For X1b = 25 To ultimalinha - 1
                    formula2b = formula2b & "+V" & X1b & "*S" & X1b
                Next
                formula2b = formula2b & ")/L6"
                formula2b = "= IF(ISERROR(" & formula2b & ");0;" & formula2b & ")"
                Sheet1.Range("N13").Formula = formula2b

                Dim formula2c As String
                formula2c = "(Z24*S24"
                Dim X1c As Integer
                For X1c = 25 To ultimalinha - 1
                    formula2c = formula2c & "+Z" & X1c & "*S" & X1c
                Next
                formula2c = formula2c & ")/(SUM(Z24:Z" & ultimalinha - 1 & "))"
                formula2c = "= IF(ISERROR(" & formula2c & ");0;" & formula2c & ")"
                Sheet1.Range("O13").Formula = formula2c

                '''''Average invoice

                Dim formula2aAI As String
                formula2aAI = "(Y24*M24/AD24*9"
                Dim X1aAI As Integer
                For X1aAI = 25 To ultimalinha - 1
                    formula2aAI = formula2aAI & "+Y" & X1aAI & "*M" & X1aAI & "/AD" & X1aAI & "*9"
                Next
                formula2aAI = formula2aAI & ")/(L7+L8)"
                formula2aAI = "= IF(ISERROR(" & formula2aAI & ");0;" & formula2aAI & ")"
                Sheet1.Range("M14").Formula = formula2aAI


                Dim formula2bAI As String
                formula2bAI = "(V24*M24/AD24*9"
                Dim X1bAI As Integer
                For X1bAI = 25 To ultimalinha - 1
                    formula2bAI = formula2bAI & "+V" & X1bAI & "*M" & X1bAI & "/AD" & X1bAI & "*9"
                Next
                formula2bAI = formula2bAI & ")/L6"
                formula2bAI = "= IF(ISERROR(" & formula2bAI & ");0;" & formula2bAI & ")"
                Sheet1.Range("N14").Formula = formula2bAI

                Dim formula2cAI As String
                formula2cAI = "(Z24*M24/AD24*9"
                Dim X1cAI As Integer
                For X1cAI = 25 To ultimalinha - 1
                    formula2cAI = formula2cAI & "+Z" & X1cAI & "*M" & X1cAI & "/AD" & X1cAI & "*9"
                Next
                formula2cAI = formula2cAI & ")/(SUM(Z24:Z" & ultimalinha - 1 & "))"
                formula2cAI = "= IF(ISERROR(" & formula2cAI & ");0;" & formula2cAI & ")"
                Sheet1.Range("O14").Formula = formula2cAI


                '''''FIM Pricing Analysis
                '''''FIM Pricing Analysis
                '''''FIM Pricing Analysis
            Catch ex As Exception
                ' MsgBox("Too many product to calculate in Excel")
            End Try




            ''Processo antigo    Sheet1.PageSetup.PrintArea = "A1:Z" & ultimalinha - 1
            ''Processo antigo    Sheet1.filterkeycompany = filterkeycomp
            ''Processo antigo    Sheet1.filterkeytipo = filterkeytipo


            myReader1.Close()

            ''''''''''''
            ''''''''''''''
            ''''''''''''''''
            '''''''''''''''
            ''''''''''''''



            myConnectionPricing.Close()

            createPalletes(director, pais, clientfact, clientdest, company, tipo, pricelist, PCDATI, PCDATF, Currency)


            SpreadsheetControl1.EndUpdate()
        Catch
            MsgBox("Erro na Criação Pricing")
        End Try


    End Sub

    Private Sub createPalletes(ByVal director As String, ByVal pais As String, ByVal clientfact As String, ByVal clientdest As String, ByVal company As String, ByVal tipo As String, ByVal pricelist As String, ByVal PCDATI As String, ByVal PCDATF As String, ByVal Currency As String)

        Try


            Dim myConnectionPricing As New SQLiteConnection
            myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
            myConnectionPricing.Open()
            Dim mySelectQuerypal As String
            Dim ultimalinhapal As Integer = 16
            '''''INICIO LOOP Produtos
            '''''INICIO LOOP Produtos
            '''''INICIO LOOP Produtos




            If filterkeyPricing = "933" Then
                mySelectQuerypal = "SELECT * FROM query2 where tabela='" & filterkeyPricing & "' and pcclid='" & clientdest & "' and pcccli='" & clientfact & "' and pcfirm='Não Relevante' and tipo='Secos Paletes' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "'  ORDER BY PCORDE, PCACOL"
            ElseIf filterkeyPricing = "934" Then
                mySelectQuerypal = "SELECT * FROM query2 where tabela='" & filterkeyPricing & "' and pcccli='" & clientfact & "' and pcfirm='Não Relevante' and tipo='Secos Paletes' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "'  ORDER BY PCORDE, PCACOL"
            ElseIf filterkeyPricing = "936" Then
                mySelectQuerypal = "SELECT * FROM query2 where tabela='" & filterkeyPricing & "' and pcclid='" & clientfact & "' and pcfirm='Não Relevante' and tipo='Secos Paletes' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "'  ORDER BY PCORDE, PCACOL"
            Else
                MsgBox("Erro nas tabela de pricing") : Exit Sub
            End If


            Dim myCommand As New SQLiteCommand(mySelectQuerypal, myConnectionPricing)
            Dim myReader1 As SQLiteDataReader
            myReader1 = myCommand.ExecuteReader()
            While myReader1.Read
                Me.SapMateriaisQueryTableAdapter1.ClearBeforeFill = True
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Me.SapMateriaisQueryTableAdapter1.Fill(Me.SapPricingDataset11.SapMateriaisQuery, myReader1("PCCPRO"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.

                Dim retDescrProd As String
                'retDescrProd = myCommandDescrProd.ExecuteScalar
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                retDescrProd = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("maktx")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Sheet2.Range("A" & ultimalinhapal).Value = (retDescrProd)

                ''''caixa /bottle
                Dim retRange As String
                ' retRange = myCommandRange.ExecuteScalar
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                retRange = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("RANGE")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Sheet2.Range("B" & ultimalinhapal).Value = retRange ''Stock

                Dim retEMBALDESC As String
                '  retEMBALDESC = myCommandEMBALDesc.ExecuteScalar
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                retEMBALDESC = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("DESCR")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Sheet2.Range("C" & ultimalinhapal).Value = retEMBALDESC

                '''''FIM LINHA Product
                '''''FIM LINHA Product
                '''''FIM LINHA Product


                '''''INICIO LINHA Gross Customer Unit Price
                '''''INICIO LINHA Gross Customer Unit Price
                '''''INICIO LINHA Gross Customer Unit Price
                Sheet2.Range("D" & ultimalinhapal).Value = CDbl(myReader1("PCPVAC"))

                '''''FIM LINHA Gross Customer Unit Price
                '''''FIM LINHA Gross Customer Unit Price
                '''''FIM LINHA Gross Customer Unit Price

                ultimalinhapal = ultimalinhapal + 1
            End While
        Catch
            MsgBox("Erro na criação Palletes")
        End Try
    End Sub


    Public Function getSymPriceListType(ByVal cod As String) As String
        cod = UCase(cod)
        'Select Case cod
        '    Case "A"
        '        Return "Standard"
        '    Case "B"
        '        Return "Promotional"
        '    Case "C"
        '        Return "Travel Retail"
        '    Case "D"
        '        Return "Specific Customer"
        '    Case "E"
        '        Return "A"
        '    Case "F"
        '        Return "B"
        '    Case "G"
        '        Return "C"
        '    Case "H"
        '        Return "D"
        '    Case Else
        '        Return "??"
        'End Select
        Me.SapTipoListaPrecosTableAdapter.Fill(Me.SapPricingDataset11.SapTipoListaPrecos)

        Dim drarray() As DataRow
        drarray = Me.SapPricingDataset11.SapTipoListaPrecos.Select("PLTYP = '" & cod & "'")
        Return drarray(0)("PTEXT").ToString()

    End Function

    Public Function getSymcompany(ByVal num As String) As String

        Select Case num
            Case "01"
                Return "Warre"
            Case "02"
                Return "Dow´s"
            Case "03"
                Return "Quarles Harris"
            Case "04"
                Return "Graham´s"
            Case "05"
                Return "SFE"
            Case "06"
                Return "Prats & Symington"
            Case "07"
                Return "Vesúvio"
            Case "08"
                Return "Symington Vinhos, S.A."
            Case "10"
                Return "Roriz"
            Case "16"
                Return "Martinez"
            Case "51"
                Return "Gould Campbell"
            Case "52"
                Return "Smith Woodhouse"
            Case "53"
                Return "Cockburn´s Smithes"
            Case "55"
                Return "SFE - Prats & Symington"

            Case Else
                Return "??"
        End Select


    End Function

    Public ReadOnly Property varultimalinha As Integer
        Get
            Return ultimalinha
        End Get
    End Property


#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
    Public Sub recalcular(Optional CAL_PCDATF = "", Optional CAL_PCDATI = "")
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.


#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
        Dim varPCDATI
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
        Dim varPCDATF
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
        Dim tabela
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
        Dim clientdest
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
        Dim clientfact
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
        Dim pricelist
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
        Dim currency
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
        Dim clientstat
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
        SpreadsheetControl1.BeginUpdate()

        If Not CAL_PCDATI.ToString = "" Then
            '''''Datas
            If Mid(Sheet1.Range("G6").Value.ToString, 1, 4) < Format(CAL_PCDATI, "yyyy") Then


                Sheet1.Range("G24:G" & ultimalinha).CopyFrom(Sheet1.Range("F24:F" & ultimalinha))

            End If

            Sheet1.Range("G6").Value = Format(CAL_PCDATI, "yyyyMMdd")
            Sheet1.Range("I6").Value = Format(CAL_PCDATF, "yyyyMMdd")

        End If

        varPCDATI = Sheet1.Range("G6").Value.ToString
        varPCDATF = Sheet1.Range("I6").Value.ToString
        tabela = Sheet1.Range("I5").Value.ToString
        clientdest = Sheet1.Range("D4").Value.ToString
        clientfact = Sheet1.Range("D12").Value.ToString
        pricelist = Sheet1.Range("G5").Value.ToString.Substring(0, 1)
        currency = Sheet1.Range("L18").Value.ToString
        clientstat = Sheet1.Range("D11").Value.ToString


        estipulacaoDataTable.Clear()


        Dim myConnectionPricing As New SQLiteConnection ' OleDb.OleDbConnection
        myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
        myConnectionPricing.Open()

        For Counter = 24 To ultimalinha - 1



            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price
            Try
                Dim mySelectQueryREFPrice As String
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryREFPrice = "SELECT kbetr FROM saprefprice where matnr='" & Sheet1.Range("AC" & Counter).Value.ToString & "' and zzkatr3='" & Sheet1.Range("C18").Value.ToString & "' and datbi >='" & varPCDATI & "' and datab <='" & varPCDATI & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                Dim myCommandREFPrice As New SQLiteCommand(mySelectQueryREFPrice, myConnectionPricing)
                Dim retREFPrice As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                retREFPrice = myCommandREFPrice.ExecuteScalar
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Sheet1.Range("T" & Counter).Value = CDbl(retREFPrice)
            Catch
                Sheet1.Range("T" & Counter).Value = Nothing
            End Try

            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price


            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs
            Try
                Dim mySelectQueryBOTCOSTMOQ As String
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryBOTCOSTMOQ = "SELECT kbetr FROM sapbotlcost where matnr='" & Sheet1.Range("AC" & Counter).Value.ToString & "' and datbi >='" & varPCDATI & "' and datab <='" & varPCDATI & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                Dim myCommandBOTCOSTMOQ As New SQLiteCommand(mySelectQueryBOTCOSTMOQ, myConnectionPricing)
                Dim retBOTCOSTMOQ As Decimal
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Decimal'.
                retBOTCOSTMOQ = myCommandBOTCOSTMOQ.ExecuteScalar
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Decimal'.
                Sheet1.Range("BS" & Counter).Value = retBOTCOSTMOQ
            Catch
                Sheet1.Range("BS" & Counter).Value = Nothing
            End Try

            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs



            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus

            Dim mySelectQueryBonus As String
            mySelectQueryBonus = ""
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
            If tabela = "931" Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Sheet1.Range("AC" & Counter).Value.ToString & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
            ElseIf tabela = "933" Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Sheet1.Range("AC" & Counter).Value.ToString & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
            ElseIf tabela = "932" Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Sheet1.Range("AC" & Counter).Value.ToString & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
            ElseIf tabela = "934" Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Sheet1.Range("AC" & Counter).Value.ToString & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
            ElseIf tabela = "935" Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Sheet1.Range("AC" & Counter).Value.ToString & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
            ElseIf tabela = "936" Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and zcldest='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Sheet1.Range("AC" & Counter).Value.ToString & "'"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.

            End If

            Dim myCommandBonus As New SQLiteCommand(mySelectQueryBonus, myConnectionPricing)
            Dim retBonus As SQLiteDataReader
            retBonus = myCommandBonus.ExecuteReader(CommandBehavior.SingleRow)
            'atenção -> kbetr = knrmm = Minimum quantity
            'atenção -> knrnm = Free goods quantity
            'atenção -> knrnm = Additional quantity for free goods

            If retBonus.HasRows Then
                Do While retBonus.Read
                    Sheet1.Range("BT" & Counter).Value = CDbl(retBonus(0))
                    Sheet1.Range("BU" & Counter).Value = CDbl(retBonus(1))
                    Sheet1.Range("BV" & Counter).Value = CDbl(retBonus(2))
                Loop
            Else
                Sheet1.Range("BT" & Counter).Value = Nothing
                Sheet1.Range("BU" & Counter).Value = Nothing
                Sheet1.Range("BV" & Counter).Value = Nothing
            End If


            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus


            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes

            Sheet1.Range("AX" & Counter).Value = Nothing
            Sheet1.Range("AY" & Counter).Value = Nothing
            Sheet1.Range("AZ" & Counter).Value = Nothing
            Sheet1.Range("BA" & Counter).Value = Nothing
            Sheet1.Range("BB" & Counter).Value = Nothing
            Sheet1.Range("BC" & Counter).Value = Nothing
            Sheet1.Range("BD" & Counter).Value = Nothing
            Sheet1.Range("BE" & Counter).Value = Nothing
            Sheet1.Range("BF" & Counter).Value = Nothing
            Sheet1.Range("BG" & Counter).Value = Nothing
            Sheet1.Range("BH" & Counter).Value = Nothing
            Sheet1.Range("BI" & Counter).Value = Nothing
            Sheet1.Range("BJ" & Counter).Value = Nothing
            Sheet1.Range("BK" & Counter).Value = Nothing
            Sheet1.Range("BM" & Counter).Value = Nothing
            Sheet1.Range("BN" & Counter).Value = Nothing
            Sheet1.Range("BO" & Counter).Value = Nothing
            Sheet1.Range("BP" & Counter).Value = Nothing
            Sheet1.Range("BQ" & Counter).Value = Nothing
            Sheet1.Range("BR" & Counter).Value = Nothing

            Dim mySelectQueryEstipulaçoes As String
            mySelectQueryEstipulaçoes = ""
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
            mySelectQueryEstipulaçoes = "SELECT knuma,boart, kschl, kbetr, bonem FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi >='" & varPCDATF & "' and datab <='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Sheet1.Range("AC" & Counter).Value.ToString & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.


            Dim myCommandEstipulaçoes As New SQLiteCommand(mySelectQueryEstipulaçoes, myConnectionPricing)
            Dim retEstipulaçoes As SQLiteDataReader


            retEstipulaçoes = myCommandEstipulaçoes.ExecuteReader
            Dim countcomm = 0
            Do While retEstipulaçoes.Read

                Dim newRow = estipulacaoDataTable.NewRow
                newRow(0) = retEstipulaçoes("knuma")
                newRow(1) = retEstipulaçoes("boart")
                newRow(2) = retEstipulaçoes("bonem")
                newRow(3) = varPCDATI
                newRow(4) = varPCDATF
                newRow(5) = retEstipulaçoes("kschl")
                newRow(6) = Sheet1.Range("AC" & Counter).Value.ToString
#Disable Warning BC42017 ' Late bound resolution; runtime errors could occur.
                If UCase(retEstipulaçoes("kschl")).ToString.EndsWith("V") Then
#Enable Warning BC42017 ' Late bound resolution; runtime errors could occur.
                    newRow(7) = retEstipulaçoes("kbetr")
                Else
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                    newRow(7) = retEstipulaçoes("kbetr") / 10
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                End If
                newRow(8) = Sheet1.Range("BX" & Counter).Value


                estipulacaoDataTable.Rows.Add(newRow)



                Dim clientpricesupport As New List(Of String)
                Dim clientAPsupport As New List(Of String)
                Dim clientRappel As New List(Of String)







#Disable Warning BC42036 ' Operands of type Object used in expressions for 'Select', 'Case' statements; runtime errors could occur.
                Select Case retEstipulaçoes("kschl")
#Enable Warning BC42036 ' Operands of type Object used in expressions for 'Select', 'Case' statements; runtime errors could occur.
                    ''Price Support
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YSCV" ' credit note V
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                        Sheet1.Range("AX" & Counter).Value = Sheet1.Range("AX" & Counter).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YSCP" ' credit note P
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                        Sheet1.Range("AY" & Counter).Value = Sheet1.Range("AY" & Counter).Value.NumericValue + (retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YSHV" ' Charged by customer V
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                        Sheet1.Range("AZ" & Counter).Value = Sheet1.Range("AZ" & Counter).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YSHP" ' Charged by customer P
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                        Sheet1.Range("BA" & Counter).Value = Sheet1.Range("BA" & Counter).Value.NumericValue + (retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.

                        ''A&P Support
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YAPV"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                        Sheet1.Range("BD" & Counter).Value = Sheet1.Range("BD" & Counter).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientAPsupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YAPP"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                        Sheet1.Range("BE" & Counter).Value = Sheet1.Range("BE" & Counter).Value.NumericValue + (retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientAPsupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YABV"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                        Sheet1.Range("BF" & Counter).Value = Sheet1.Range("BF" & Counter).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientAPsupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.

                        ''Rappel....
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YRRV"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                        Sheet1.Range("BI" & Counter).Value = Sheet1.Range("BI" & Counter).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientRappel.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YRRP"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                        Sheet1.Range("BJ" & Counter).Value = Sheet1.Range("BJ" & Counter).Value.NumericValue + (retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientRappel.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        ''Commisions
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YCOP"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        countcomm = countcomm + 1
                        If countcomm = 1 Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                            Sheet1.Range("BM" & Counter).Value = CDbl(retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                            Sheet1.Range("BN" & Counter).Value = retEstipulaçoes("bonem").ToString
                        ElseIf countcomm = 2 Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                            Sheet1.Range("BO" & Counter).Value = CDbl(retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                            Sheet1.Range("BP" & Counter).Value = retEstipulaçoes("bonem").ToString
                        ElseIf countcomm = 3 Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                            Sheet1.Range("BQ" & Counter).Value = CDbl(retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                            Sheet1.Range("BR" & Counter).Value = retEstipulaçoes("bonem").ToString
                        Else
                            MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                        End If
                End Select

                Dim distinctNamesclientpricesupport = clientpricesupport.Distinct()
                Dim distinctNamesclientpricesupportitem As String
                For Each distinctNamesclientpricesupportitem In distinctNamesclientpricesupport
                    Dim stringps = ""
                    stringps = stringps & distinctNamesclientpricesupportitem & " - "
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                    Sheet1.Range("BC" & Counter).Value = stringps.Trim(" - ")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Next
                Dim distinctNamesclientAPsupport = clientAPsupport.Distinct()
                Dim distinctNamesclientAPsupportitem As String
                For Each distinctNamesclientAPsupportitem In distinctNamesclientAPsupport
                    Dim stringAP = ""
                    stringAP = stringAP & distinctNamesclientAPsupportitem & " - "
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                    Sheet1.Range("BH" & Counter).Value = stringAP.Trim(" - ")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Next
                Dim distinctNamesclientrappel = clientRappel.Distinct()
                Dim distinctNamesclientrappelitem As String
                For Each distinctNamesclientrappelitem In distinctNamesclientrappel
                    Dim stringR = ""
                    stringR = stringR & distinctNamesclientrappelitem & " - "
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                    Sheet1.Range("BL" & Counter).Value = stringR.Trim(" - ")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Next

            Loop


            '''''FIM LINHA Estipulaçoes
            '''''FIM LINHA Estipulaçoes
            '''''FIM LINHA Estipulaçoes

            ' '''''INICIO LINHA  VOLUMES(9L)
            ' '''''INICIO LINHA  VOLUMES(9L)
            ' '''''INICIO LINHA  VOLUMES(9L)

#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
            If tabela = "936" Then ''''ALEMANHA por CLIENTE ESTATISTICO
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                ''''Vendas por materialforecast
                Dim mySelectQueryVol9LTotal As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryVol9LTotal = "SELECT SUM(SHIPPED) as exp4, SUM(INHAND) as exp5 FROM sapsalesforpricing WHERE (statsclientnum = '" & clientstat & "') AND ([Immaterial] = '" & Sheet1.Range("AC" & Counter).Value.ToString & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & currency & "') AND Year = '" & Now.Year & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Dim myCommandVol9Ltotal As New SQLiteCommand(mySelectQueryVol9LTotal, myConnectionPricing)
                Dim retVol9Ltotal As SQLiteDataReader
                Try
                    retVol9Ltotal = myCommandVol9Ltotal.ExecuteReader(CommandBehavior.SingleRow)
                    If Not (retVol9Ltotal(0)) Is DBNull.Value Then Sheet1.Range("CT" & Counter).Value = CDec(retVol9Ltotal(0)) Else Sheet1.Range("CT" & Counter).Value = Nothing
                    If Not (retVol9Ltotal(1)) Is DBNull.Value Then Sheet1.Range("CU" & Counter).Value = CDec(retVol9Ltotal(1)) Else Sheet1.Range("CU" & Counter).Value = Nothing
                    Sheet1.Range("Y" & Counter).Value = Sheet1.Range("CT" & Counter).Value.NumericValue + Sheet1.Range("CU" & Counter).Value.NumericValue
                Catch ex As Exception
                    Sheet1.Range("Y" & Counter).Value = Nothing
                    Sheet1.Range("CT" & Counter).Value = Nothing
                    Sheet1.Range("CU" & Counter).Value = Nothing
                End Try


                ''''Forecast e target
                Dim mySelectQueryVol9LFore As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryVol9LFore = "SELECT SUM(FORECA) as exp1, SUM(FORECM) as exp2 FROM sapsales WHERE (statsclientnum = '" & clientstat & "') AND ([Material Number] = '" & Sheet1.Range("AC" & Counter).Value.ToString & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & currency & "') AND Year = '" & Now.Year & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Dim myCommandVol9LFore As New SQLiteCommand(mySelectQueryVol9LFore, myConnectionPricing)
                Dim retVol9LFore As SQLiteDataReader
                Try
                    retVol9LFore = myCommandVol9LFore.ExecuteReader(CommandBehavior.SingleRow)
                    If Not (retVol9LFore(0)) Is DBNull.Value Then Sheet1.Range("V" & Counter).Value = CDec(retVol9LFore(0)) Else Sheet1.Range("V" & Counter).Value = Nothing
                    If Not (retVol9LFore(1)) Is DBNull.Value Then Sheet1.Range("Z" & Counter).Value = CDec(retVol9LFore(1)) Else Sheet1.Range("Z" & Counter).Value = Nothing
                Catch ex As Exception
                    Sheet1.Range("V" & Counter).Value = Nothing
                    Sheet1.Range("Z" & Counter).Value = Nothing
                End Try



                ''''Last Year
                Dim mySelectQueryVol9L3 As String
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryVol9L3 = "SELECT SUM(SHIPPED) as exp1 FROM sapsalesforpricing WHERE (statsclientnum = '" & clientstat & "') AND ([Immaterial] = '" & Sheet1.Range("AC" & Counter).Value.ToString & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & currency & "') AND Year = '" & Now.Year - 1 & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                Dim myCommandVol9L3 As New SQLiteCommand(mySelectQueryVol9L3, myConnectionPricing)
                Dim retVol9L3 As String
                Try
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    retVol9L3 = myCommandVol9L3.ExecuteScalar
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    If Not (retVol9L3) Is DBNull.Value Then Sheet1.Range("W" & Counter).Value = CDec(retVol9L3) Else Sheet1.Range("W" & Counter).Value = Nothing
                Catch
                    Sheet1.Range("W" & Counter).Value = Nothing
                End Try

            Else
                ''''Vendas por materialforecast
                Dim mySelectQueryVol9LTotal As String
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                mySelectQueryVol9LTotal = "SELECT SUM(SHIPPED) as exp4, SUM(INHAND) as exp5 FROM sapsalesforpricing WHERE (invclientnum = '" & clientfact & "') AND (finalclientnum = '" & clientdest & "') AND ([Immaterial] = '" & Sheet1.Range("AC" & Counter).Value.ToString & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & currency & "') AND Year = '" & Now.Year & "'"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                Dim myCommandVol9Ltotal As New SQLiteCommand(mySelectQueryVol9LTotal, myConnectionPricing)
                Dim retVol9Ltotal As SQLiteDataReader
                Try
                    retVol9Ltotal = myCommandVol9Ltotal.ExecuteReader(CommandBehavior.SingleRow)
                    If Not (retVol9Ltotal(0)) Is DBNull.Value Then Sheet1.Range("CT" & Counter).Value = CDec(retVol9Ltotal(0)) Else Sheet1.Range("CT" & Counter).Value = Nothing
                    If Not (retVol9Ltotal(1)) Is DBNull.Value Then Sheet1.Range("CU" & Counter).Value = CDec(retVol9Ltotal(1)) Else Sheet1.Range("CU" & Counter).Value = Nothing
                    Sheet1.Range("Y" & Counter).Value = Sheet1.Range("CT" & Counter).Value.NumericValue + Sheet1.Range("CU" & Counter).Value.NumericValue
                Catch ex As Exception
                    Sheet1.Range("Y" & Counter).Value = Nothing
                    Sheet1.Range("CT" & Counter).Value = Nothing
                    Sheet1.Range("CU" & Counter).Value = Nothing
                End Try


                ''''Forecast e target
                Dim mySelectQueryVol9LFore As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryVol9LFore = "SELECT SUM(FORECA) as exp1, SUM(FORECM) as exp2 FROM sapsales WHERE (invclientnum = '" & clientfact & "') AND (finalclientnum = '" & clientdest & "') AND ([Material Number] = '" & Sheet1.Range("AC" & Counter).Value.ToString & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & currency & "') AND Year = '" & Now.Year & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Dim myCommandVol9LFore As New SQLiteCommand(mySelectQueryVol9LFore, myConnectionPricing)
                Dim retVol9LFore As SQLiteDataReader
                Try
                    retVol9LFore = myCommandVol9LFore.ExecuteReader(CommandBehavior.SingleRow)
                    If Not (retVol9LFore(0)) Is DBNull.Value Then Sheet1.Range("V" & Counter).Value = CDec(retVol9LFore(0)) Else Sheet1.Range("V" & Counter).Value = Nothing
                    If Not (retVol9LFore(1)) Is DBNull.Value Then Sheet1.Range("Z" & Counter).Value = CDec(retVol9LFore(1)) Else Sheet1.Range("Z" & Counter).Value = Nothing
                Catch ex As Exception
                    Sheet1.Range("V" & Counter).Value = Nothing
                    Sheet1.Range("Z" & Counter).Value = Nothing
                End Try



                ''''Last Year
                Dim mySelectQueryVol9L3 As String
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                mySelectQueryVol9L3 = "SELECT SUM(SHIPPED) as exp1 FROM sapsalesforpricing WHERE (invclientnum = '" & clientfact & "') AND (finalclientnum = '" & clientdest & "') AND ([Immaterial] = '" & Sheet1.Range("AC" & Counter).Value.ToString & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & currency & "') AND Year = '" & Now.Year - 1 & "'"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                Dim myCommandVol9L3 As New SQLiteCommand(mySelectQueryVol9L3, myConnectionPricing)
                Dim retVol9L3 As String
                Try
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    retVol9L3 = myCommandVol9L3.ExecuteScalar
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    If Not (retVol9L3) Is DBNull.Value Then Sheet1.Range("W" & Counter).Value = CDec(retVol9L3) Else Sheet1.Range("W" & Counter).Value = Nothing
                Catch
                    Sheet1.Range("W" & Counter).Value = Nothing
                End Try

            End If

            ' '''''FIM LINHA VOLUMES(9L)
            ' '''''FIM LINHA VOLUMES(9L)
            ' '''''FIM LINHA VOLUMES(9L)




        Next

        myConnectionPricing.Close()
        SpreadsheetControl1.EndUpdate()
    End Sub


  
    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click

#Disable Warning BC42019 ' Operands of type Object used for operator '<='; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '<='; runtime errors could occur.
        If CAL_PCDATF.EditValue <= CAL_PCDATI.EditValue Then MsgBox("Datas Erradas") : Exit Sub
#Enable Warning BC42019 ' Operands of type Object used for operator '<='; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '<='; runtime errors could occur.

        recalcular(CAL_PCDATF.EditValue, CAL_PCDATI.EditValue)

        ' datasalteradas = True

    End Sub

   

    Private Sub Pricing_ClientSizeChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.ClientSizeChanged
#Disable Warning BC42016 ' Implicit conversion from 'Double' to 'Single'.
        SpreadsheetControl1.ActiveView.ZoomFactor = (SpreadsheetControl1.Width * 0.03) / 100
#Enable Warning BC42016 ' Implicit conversion from 'Double' to 'Single'.
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click

        SpreadsheetControl1.BeginUpdate()
        Try




            Sheet1.Rows(CStr(ultimalinha)).CopyFrom(Sheet1.Rows("24"))

#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'DataRowView'.
            Dim row As DataRowView = GridLookUpEdit1.GetSelectedDataRow
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'DataRowView'.
            Sheet1.Range("A" & ultimalinha).Value = (row("MAKTX")).ToString
            Sheet1.Range("C" & ultimalinha).Value = (row("PACKAGE")).ToString
            Sheet1.Range("AC" & ultimalinha).Value = (row("MATNR")).ToString
            Sheet1.Range("BX" & ultimalinha).Value = (row("MEINS")).ToString



            Dim myConnectionPricing As New SQLiteConnection ' OleDb.OleDbConnection
            myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
            myConnectionPricing.Open()

            Dim mySelectQueryRange As String
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            mySelectQueryRange = "SELECT Range FROM SapMateriais where matnr='" & (row("MATNR")) & "'"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
            Dim myCommandRange As New SQLiteCommand(mySelectQueryRange, myConnectionPricing)
            Dim retRange As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            retRange = myCommandRange.ExecuteScalar
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            Sheet1.Range("B" & ultimalinha).Value = retRange






            Dim sqlcommand2 As New SQLiteCommand
            sqlcommand2.Connection = myConnectionPricing
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
            sqlcommand2.CommandText = "SELECT lts FROM SAPEMBALAGENS where ind='" & row("EMBALAGEM") & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
            sqlcommand2.CommandType = CommandType.Text
            Dim retEMBALLts = sqlcommand2.ExecuteScalar
            Sheet1.Range("AD" & ultimalinha).Value = CDbl(retEMBALLts)

            Dim sqlcommand3 As New SQLiteCommand
            sqlcommand3.Connection = myConnectionPricing
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            sqlcommand3.CommandText = "SELECT cap FROM SAPEMBALAGENS where ind='" & row("EMBALAGEM") & "'"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
            sqlcommand3.CommandType = CommandType.Text
            Dim retEMBALcap = sqlcommand3.ExecuteScalar
            Try
#Disable Warning BC42032 ' Operands of type Object used for operator '<>'; use the 'IsNot' operator to test object identity.
                If retEMBALcap <> 0 Then
#Enable Warning BC42032 ' Operands of type Object used for operator '<>'; use the 'IsNot' operator to test object identity.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                    Sheet1.Range("AE" & ultimalinha).Value = CDbl(retEMBALLts / retEMBALcap)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                Else
                    Sheet1.Range("AE" & ultimalinha).Value = "n/a"
                End If
            Catch
                Sheet1.Range("AE" & ultimalinha).Value = "n/a"
            End Try

            Sheet1.Range("E" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("F" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("G" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("T" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("V" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("W" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("Y" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("Z" & ultimalinha).Value = Nothing  '0

            Sheet1.Range("AF" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AG" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AH" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AI" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AJ" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AK" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AL" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AM" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AN" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AO" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AP" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AQ" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AR" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AS" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AT" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AU" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AV" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AW" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AX" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AY" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("AZ" & ultimalinha).Value = Nothing  '0
            
            Sheet1.Range("BA" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BB" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BC" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BD" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BE" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BF" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BG" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BH" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BI" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BJ" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BK" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BL" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BM" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BN" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BO" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BP" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BQ" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BR" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BS" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BT" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BU" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("BV" & ultimalinha).Value = Nothing  '0
          
            Sheet1.Range("CT" & ultimalinha).Value = Nothing  '0
            Sheet1.Range("CU" & ultimalinha).Value = Nothing  '0




            Dim varPCDATI = Sheet1.Range("G6").Value.TextValue
            Dim varPCDATF = Sheet1.Range("I6").Value.TextValue
            Dim tabela = Sheet1.Range("I5").Value.TextValue
            Dim clientdest = Sheet1.Range("D4").Value.TextValue
            Dim clientfact = Sheet1.Range("D12").Value.TextValue
            Dim pricelist = Sheet1.Range("G5").Value.ToString.Substring(0, 1)
            Dim currency = Sheet1.Range("L18").Value.TextValue

            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price

            Dim mySelectQueryREFPrice As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
            mySelectQueryREFPrice = "SELECT kbetr FROM saprefprice where matnr='" & (row("MATNR")) & "' and zzkatr3='" & Sheet1.Range("C18").Value.TextValue & "' and datbi >='" & varPCDATI & "' and datab <='" & varPCDATI & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            Dim myCommandREFPrice As New SQLiteCommand(mySelectQueryREFPrice, myConnectionPricing)
            Dim retREFPrice As String
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            retREFPrice = myCommandREFPrice.ExecuteScalar
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            Sheet1.Range("T" & ultimalinha).Value = CDbl(retREFPrice)


            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price


            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs

            Dim mySelectQueryBOTCOSTMOQ As String
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            mySelectQueryBOTCOSTMOQ = "SELECT kbetr FROM sapbotlcost where matnr='" & row("MATNR") & "' and datbi >='" & varPCDATI & "' and datab <='" & varPCDATI & "'"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
            Dim myCommandBOTCOSTMOQ As New SQLiteCommand(mySelectQueryBOTCOSTMOQ, myConnectionPricing)
            Dim retBOTCOSTMOQ As Decimal
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Decimal'.
            retBOTCOSTMOQ = myCommandBOTCOSTMOQ.ExecuteScalar
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Decimal'.
            Sheet1.Range("BS" & ultimalinha).Value = retBOTCOSTMOQ


            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs



            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus

            Dim mySelectQueryBonus As String
            mySelectQueryBonus = ""
            If tabela = "931" Then
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            ElseIf tabela = "933" Then
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
            ElseIf tabela = "932" Then
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            ElseIf tabela = "934" Then
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
            ElseIf tabela = "935" Then
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            ElseIf tabela = "936" Then
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and zcldest='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
            End If

            ' mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where matnr='" & myReader1("PCCPRO") & "' and tabela = 'KOTN" & filterkeyPricing & "'"
            Dim myCommandBonus As New SQLiteCommand(mySelectQueryBonus, myConnectionPricing)
            Dim retBonus As SQLiteDataReader
            retBonus = myCommandBonus.ExecuteReader(CommandBehavior.SingleRow)
            'atenção -> kbetr = knrmm = Minimum quantity
            'atenção -> knrnm = Free goods quantity
            'atenção -> knrnm = Additional quantity for free goods

            If retBonus.HasRows Then
                Do While retBonus.Read
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                    Sheet1.Range("BT" & ultimalinha).Value = retBonus(0)
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                    Sheet1.Range("BU" & ultimalinha).Value = retBonus(1)
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                    Sheet1.Range("BV" & ultimalinha).Value = retBonus(2)
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                Loop
            Else
                Sheet1.Range("BT" & ultimalinha).Value = ""
                Sheet1.Range("BU" & ultimalinha).Value = ""
                Sheet1.Range("BV" & ultimalinha).Value = ""
            End If


            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus


            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes

            Dim mySelectQueryEstipulaçoes As String
            mySelectQueryEstipulaçoes = ""
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
            mySelectQueryEstipulaçoes = "SELECT kschl, kbetr, bonem FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.


            Dim myCommandEstipulaçoes As New SQLiteCommand(mySelectQueryEstipulaçoes, myConnectionPricing)
            Dim retEstipulaçoes As SQLiteDataReader


            retEstipulaçoes = myCommandEstipulaçoes.ExecuteReader
            Dim countcomm = 0
            Do While retEstipulaçoes.Read

                Dim clientpricesupport As New List(Of String)
                Dim clientAPsupport As New List(Of String)
                Dim clientRappel As New List(Of String)
#Disable Warning BC42036 ' Operands of type Object used in expressions for 'Select', 'Case' statements; runtime errors could occur.
                Select Case retEstipulaçoes("kschl")
#Enable Warning BC42036 ' Operands of type Object used in expressions for 'Select', 'Case' statements; runtime errors could occur.
                    ''Price Support
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YSCV" ' credit note V
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("AX" & ultimalinha).Value = Sheet1.Range("AX" & ultimalinha).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YSCP" ' credit note P
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                        Sheet1.Range("AY" & ultimalinha).Value = Sheet1.Range("AY" & ultimalinha).Value.NumericValue + (retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YSHV" ' Charged by customer V
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                        Sheet1.Range("AZ" & ultimalinha).Value = Sheet1.Range("AZ" & ultimalinha).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YSHP" ' Charged by customer P
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                        Sheet1.Range("BA" & ultimalinha).Value = Sheet1.Range("BA" & ultimalinha).Value.NumericValue + (retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.

                        ''A&P Support
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YAPV"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("BD" & ultimalinha).Value = Sheet1.Range("BD" & ultimalinha).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientAPsupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YAPP"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                        Sheet1.Range("BE" & ultimalinha).Value = Sheet1.Range("BE" & ultimalinha).Value.NumericValue + (retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientAPsupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YABV"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("BF" & ultimalinha).Value = Sheet1.Range("BF" & ultimalinha).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientAPsupport.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.

                        ''Rappel....
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YRRV"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("BI" & ultimalinha).Value = Sheet1.Range("BI" & ultimalinha).Value.NumericValue + retEstipulaçoes("kbetr")
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientRappel.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YRRP"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
                        Sheet1.Range("BJ" & ultimalinha).Value = Sheet1.Range("BJ" & ultimalinha).Value.NumericValue + (retEstipulaçoes("kbetr") / 10)
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientRappel.Add(retEstipulaçoes("bonem"))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        ''Commisions
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YCOP"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        countcomm = countcomm + 1
                        If countcomm = 1 Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                            Sheet1.Range("BM" & ultimalinha).Value = retEstipulaçoes("kbetr") / 10
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                            Sheet1.Range("BN" & ultimalinha).Value = retEstipulaçoes("bonem")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                        ElseIf countcomm = 2 Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                            Sheet1.Range("BO" & ultimalinha).Value = retEstipulaçoes("kbetr") / 10
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                            Sheet1.Range("BP" & ultimalinha).Value = retEstipulaçoes("bonem")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                        ElseIf countcomm = 3 Then
#Disable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                            Sheet1.Range("BQ" & ultimalinha).Value = retEstipulaçoes("kbetr") / 10
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
#Enable Warning BC42019 ' Operands of type Object used for operator '/'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                            Sheet1.Range("BR" & ultimalinha).Value = retEstipulaçoes("bonem")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'CellValue'.
                        Else
                            MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                        End If
                End Select

                Dim distinctNamesclientpricesupport = clientpricesupport.Distinct()
                Dim distinctNamesclientpricesupportitem As String
                For Each distinctNamesclientpricesupportitem In distinctNamesclientpricesupport
                    Dim stringps = ""
                    stringps = stringps & distinctNamesclientpricesupportitem & " - "
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                    Sheet1.Range("BC" & ultimalinha).Value = stringps.Trim(" - ")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Next
                Dim distinctNamesclientAPsupport = clientAPsupport.Distinct()
                Dim distinctNamesclientAPsupportitem As String
                For Each distinctNamesclientAPsupportitem In distinctNamesclientAPsupport
                    Dim stringAP = ""
                    stringAP = stringAP & distinctNamesclientAPsupportitem & " - "
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                    Sheet1.Range("BH" & ultimalinha).Value = stringAP.Trim(" - ")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Next
                Dim distinctNamesclientrappel = clientRappel.Distinct()
                Dim distinctNamesclientrappelitem As String
                For Each distinctNamesclientrappelitem In distinctNamesclientrappel
                    Dim stringR = ""
                    stringR = stringR & distinctNamesclientrappelitem & " - "
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                    Sheet1.Range("BL" & ultimalinha).Value = stringR.Trim(" - ")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Next

            Loop
            myConnectionPricing.Close()

            '''''FIM LINHA Estipulaçoes
            '''''FIM LINHA Estipulaçoes
            '''''FIM LINHA Estipulaçoes







            'Try
            '    Sheet1.Range("S" & ultimalinha).GoalSeek(Globals.Sheet1.Range("T" & ultimalinha), Globals.Sheet1.Range("F" & ultimalinha))
            'Catch
            'End Try


            ultimalinha = ultimalinha + 1

        Catch ex As Exception
            MsgBox("Erro na Inserção do Produto!")
        End Try
        SpreadsheetControl1.EndUpdate()
    End Sub

    Private Sub SimpleButton5_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton5.Click
        SpreadsheetControl1.BeginUpdate()
        Sheet1.Range("G5").Value = TextPriceListType.EditValue.ToString
        recalcular()

        SpreadsheetControl1.EndUpdate()
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click

        Dim form As New FormTreesPricingNew
        form.ShowDialog()
        SpreadsheetControl1.BeginUpdate()
        CreateNewClient()
        recalcular()
        SpreadsheetControl1.EndUpdate()


    End Sub
    Private Sub CreateNewClient()
        Try

       
      
        Dim MD As String
        Dim mng As String
        Dim ass As String





        Dim myConnectionPricing As New SQLiteConnection ' OleDb.OleDbConnection
        myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
        myConnectionPricing.Open()

        '''''INICIO Invoice Customer Information
        '''''INICIO Invoice Customer Information
        '''''INICIO Invoice Customer Information
        'nome cliente
            Sheet1.Range("C4").Value = filterkeyclidest
        'Globals.Sheet1.Range("D11").Value2 = cliente


        'dados cliente
        Dim mySelectQuerycliente As String

            mySelectQuerycliente = "SELECT  kunnr, contactname, contacttelephone, contactemail, landx50, clientstat, marketdirector, marketmanager, marketassistant, KATR3, BRSCH  FROM sapclients where name1 ='" & SQ(filterkeyclidest) & "'"
        Dim myCommandcliente As New SQLiteCommand(mySelectQuerycliente, myConnectionPricing)
        Dim myReadercliente As SQLiteDataReader
        myReadercliente = myCommandcliente.ExecuteReader


        Dim clistat As String
        '     While myReadercliente.Read()
            Sheet1.Range("D4").Value = (myReadercliente(0)).ToString
            Sheet1.Range("C8").Value = (myReadercliente(1)).ToString
            Sheet1.Range("C9").Value = (myReadercliente(2)).ToString
            Sheet1.Range("C10").Value = (myReadercliente(3)).ToString
            Sheet1.Range("C5").Value = (myReadercliente(4)).ToString

            Sheet1.Range("D11").Value = (myReadercliente(5)).ToString
            Sheet1.Range("C18").Value = myReadercliente(9).ToString 'Mainstream/Emerging
            Sheet1.Range("C19").Value = myReadercliente(10).ToString '  ' Distributer Type

            MD = myReadercliente(6).ToString
            mng = myReadercliente(7).ToString
            ass = myReadercliente(8).ToString

            clistat = (myReadercliente(5)).ToString
        '    End While
        myReadercliente.Close()

        Dim mySelectQueryclienteDestDirector As String
        mySelectQueryclienteDestDirector = "SELECT  name1 FROM sapclients where kunnr ='" & MD & "'"
        Dim myCommandclienteDestDirector As New SQLiteCommand(mySelectQueryclienteDestDirector, myConnectionPricing)
            Sheet1.Range("C15").Value = myCommandclienteDestDirector.ExecuteScalar().ToString ' Director

        Dim mySelectQueryclienteDestManager As String
        mySelectQueryclienteDestManager = "SELECT  name1 FROM sapclients where kunnr ='" & mng & "'"
        Dim myCommandclienteDestManager As New SQLiteCommand(mySelectQueryclienteDestManager, myConnectionPricing)
            Sheet1.Range("C16").Value = myCommandclienteDestManager.ExecuteScalar.ToString  ' Manager

        Dim mySelectQueryclienteDestAssistant As String
        mySelectQueryclienteDestAssistant = "SELECT  name1 FROM sapclients where kunnr ='" & ass & "'"
        Dim myCommandclienteDestAssistant As New SQLiteCommand(mySelectQueryclienteDestAssistant, myConnectionPricing)
            Sheet1.Range("C17").Value = myCommandclienteDestAssistant.ExecuteScalar().ToString ' Assistant

        Dim mySelectQueryclienteStat As String
        mySelectQueryclienteStat = "SELECT  name1 FROM sapclients where kunnr ='" & clistat & "'"
        Dim myCommandclientestat As New SQLiteCommand(mySelectQueryclienteStat, myConnectionPricing)
            Sheet1.Range("c11").Value = myCommandclientestat.ExecuteScalar.ToString
            Sheet1.Range("D11").Value = clistat

        '  paisclidest = myReaderclienteDest(4)
        '  clientEst = myReaderclienteDest(5)


        
            Sheet1.Range("C12").Value = filterkeyclifact


        Dim mySelectQueryclienteFact As String
            mySelectQueryclienteFact = "SELECT  KUNNR FROM sapclients where NAME1 ='" & SQ(filterkeyclifact) & "'"
        Dim myCommandclienteEst As New SQLiteCommand(mySelectQueryclienteFact, myConnectionPricing)
        Dim Kunnrclientfact = (myCommandclienteEst.ExecuteScalar)
            Sheet1.Range("D12").Value = Kunnrclientfact.ToString



        '''''INICIO Terms & Condition
        '''''INICIO Terms & Condition
        '''''INICIO Terms & Condition

#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
        Dim mySelectQueryCREDIT As String = "SELECT KLIMK, zzdiastoler, ztermtext, zincoterms, advertencia, katr4  FROM SAPCLIENTS where kunnr = '" & Kunnrclientfact & "'"
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
        Dim myCommandCREDIT As New SQLiteCommand(mySelectQueryCREDIT, myConnectionPricing)
        Dim myReadercredit As SQLiteDataReader
        myReadercredit = myCommandCREDIT.ExecuteReader()
        While myReadercredit.Read
                Sheet1.Range("G7").Value = myReadercredit(0).ToString 'CreditLimit Value
                Sheet1.Range("I7").Value = myReadercredit(1).ToString  ' credit limit DAYS
                Sheet1.Range("G8").Value = myReadercredit(2).ToString  'Payment Terms
                Sheet1.Range("G9").Value = myReadercredit(3).ToString  'Delivery Terms
                Sheet1.Range("I8").Value = myReadercredit(4).ToString  'Tolerance
            'Globals.Sheet1.Range("G10").Value2 = myReadercredit(5) 'Tamanho da Palete
        End While
        myReadercredit.Close()

            Dim mySelectQueryCREDIT2 As String = "SELECT katr4  FROM SAPCLIENTS where kunnr = '" & filterkeyclidest & "'"
        Dim myCommandCREDIT2 As New SQLiteCommand(mySelectQueryCREDIT2, myConnectionPricing)
        Dim myReadercredit2 As SQLiteDataReader
        myReadercredit2 = myCommandCREDIT2.ExecuteReader()
        While myReadercredit2.Read
                Sheet1.Range("G10").Value = myReadercredit2(0).ToString  'Tamanho da Palete
        End While
        myReadercredit2.Close()



        '''''FIM Terms & Condition
        '''''FIM Terms & Condition
        '''''FIM Terms & Condition


        '''''FIM Invoice Customer Information
        '''''FIM Invoice Customer Information
        '''''FIM Invoice Customer Information




        myConnectionPricing.Close()

        Catch ex As Exception

        End Try

    End Sub


    Public Function SQ(ByVal str As String) As String
        SQ = Replace(str, "'", "''", 1, -1, vbTextCompare)
    End Function


    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        SpreadsheetControl1.BeginUpdate()
        MatnrKmeinDataTable = New DataTable()
        columnMatnr = New Global.System.Data.DataColumn("Material", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnMatnr.AllowDBNull = False
        MatnrKmeinDataTable.Columns.Add(columnMatnr)
        columnKmein = New Global.System.Data.DataColumn("Unidade", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnKmein.AllowDBNull = False
        MatnrKmeinDataTable.Columns.Add(columnKmein)

        Dim ultimalinha As Integer = Pricing.ultimalinha
        For Counter2 = 24 To ultimalinha - 1
            Dim newRow = MatnrKmeinDataTable.NewRow
            newRow(0) = Sheet1.Range("AC" & Counter2).Value.ToString
            newRow(1) = Sheet1.Range("BX" & Counter2).Value.ToString
            MatnrKmeinDataTable.Rows.Add(newRow)
        Next
        Dim newRow2 = MatnrKmeinDataTable.NewRow
        newRow2(0) = "ALL"
        newRow2(1) = "ALL"
        MatnrKmeinDataTable.Rows.Add(newRow2)


        Dim form As New FormEstipulacoes
        form.Sheet1cellG6 = Sheet1.Range("G6").Value.ToString
        form.Sheet1cellI6 = Sheet1.Range("I6").Value.ToString
        form.ShowDialog()

        recalcularestipulacoes()
        SpreadsheetControl1.EndUpdate()
    End Sub

    Private Sub recalcularestipulacoes()

        Dim varPCDATI = Sheet1.Range("G6").Value
        Dim varPCDATF = Sheet1.Range("I6").Value
        Dim tabela = Sheet1.Range("I5").Value
        Dim clientdest = Sheet1.Range("D4").Value
        Dim clientfact = Sheet1.Range("D12").Value
        Dim pricelist = Sheet1.Range("G5").Value.ToString.Substring(0, 1)
        Dim currency = Sheet1.Range("L18").Value
        Dim ultimalinha As Integer = Pricing.ultimalinha

        For Counter2 = 24 To ultimalinha - 1

            Sheet1.Range("AX" & Counter2).Value = Nothing
            Sheet1.Range("AY" & Counter2).Value = Nothing
            Sheet1.Range("AZ" & Counter2).Value = Nothing
            Sheet1.Range("BA" & Counter2).Value = Nothing
            Sheet1.Range("BB" & Counter2).Value = Nothing
            Sheet1.Range("BC" & Counter2).Value = Nothing
            Sheet1.Range("BD" & Counter2).Value = Nothing
            Sheet1.Range("BE" & Counter2).Value = Nothing
            Sheet1.Range("BF" & Counter2).Value = Nothing
            Sheet1.Range("BG" & Counter2).Value = Nothing
            Sheet1.Range("BH" & Counter2).Value = Nothing
            Sheet1.Range("BI" & Counter2).Value = Nothing
            Sheet1.Range("BJ" & Counter2).Value = Nothing
            Sheet1.Range("BK" & Counter2).Value = Nothing
            Sheet1.Range("BM" & Counter2).Value = Nothing
            Sheet1.Range("BN" & Counter2).Value = Nothing
            Sheet1.Range("BO" & Counter2).Value = Nothing
            Sheet1.Range("BP" & Counter2).Value = Nothing
            Sheet1.Range("BQ" & Counter2).Value = Nothing
            Sheet1.Range("BR" & Counter2).Value = Nothing

            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes


            Dim varMatnr = Sheet1.Range("AC" & Counter2).Value
            Dim dvalue = From row In estipulacaoDataTable.AsEnumerable()
            Where row.Field(Of String)("Material") = varMatnr
            Dim countcomm = 0

            For Each m In dvalue

                Dim clientpricesupport As New List(Of String)
                Dim clientAPsupport As New List(Of String)
                Dim clientRappel As New List(Of String)
#Disable Warning BC42036 ' Operands of type Object used in expressions for 'Select', 'Case' statements; runtime errors could occur.
                Select Case m(5)
#Enable Warning BC42036 ' Operands of type Object used in expressions for 'Select', 'Case' statements; runtime errors could occur.
                    ''Price Support
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YSCV" ' credit note V
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("AX" & Counter2).Value = CDbl(Sheet1.Range("AX" & Counter2).Value.NumericValue + m(7))
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientpricesupport.Add(m(2))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YSCP" ' credit note P
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("AY" & Counter2).Value = CDbl(Sheet1.Range("AY" & Counter2).Value.NumericValue + (m(7)))
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientpricesupport.Add(m(2))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YSHV" ' Charged by customer V
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("AZ" & Counter2).Value = CDbl(Sheet1.Range("AZ" & Counter2).Value.NumericValue + m(7))
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientpricesupport.Add(m(2))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YSHP" ' Charged by customer P
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("BA" & Counter2).Value = CDbl(Sheet1.Range("BA" & Counter2).Value.NumericValue + (m(7)))
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientpricesupport.Add(m(2))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.

                        ''A&P Support
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YAPV"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("BD" & Counter2).Value = CDbl(Sheet1.Range("BD" & Counter2).Value.NumericValue + m(7))
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientAPsupport.Add(m(2))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YAPP"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("BE" & Counter2).Value = CDbl(Sheet1.Range("BE" & Counter2).Value.NumericValue + (m(7)))
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientAPsupport.Add(m(2))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YABV"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("BF" & Counter2).Value = CDbl(Sheet1.Range("BF" & Counter2).Value.NumericValue + m(7))
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientAPsupport.Add(m(2))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.

                        ''Rappel....
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YRRV"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("BI" & Counter2).Value = CDbl(Sheet1.Range("BI" & Counter2).Value.NumericValue + m(7))
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientRappel.Add(m(2))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YRRP"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
#Disable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
                        Sheet1.Range("BJ" & Counter2).Value = CDbl(Sheet1.Range("BJ" & Counter2).Value.NumericValue + (m(7)))
#Enable Warning BC42019 ' Operands of type Object used for operator '+'; runtime errors could occur.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        clientRappel.Add(m(2))
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                        ''Commisions
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                    Case "YCOP"
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Boolean'.
                        countcomm = countcomm + 1
                        If countcomm = 1 Then
                            Sheet1.Range("BM" & Counter2).Value = CDbl(m(7))
                            Sheet1.Range("BN" & Counter2).Value = m(2).ToString
                        ElseIf countcomm = 2 Then
                            Sheet1.Range("BO" & Counter2).Value = CDbl(m(7))
                            Sheet1.Range("BP" & Counter2).Value = m(2).ToString
                        ElseIf countcomm = 3 Then
                            Sheet1.Range("BQ" & Counter2).Value = CDbl(m(7))
                            Sheet1.Range("BR" & Counter2).Value = m(2).ToString
                        Else
                            MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                        End If
                End Select

                Dim distinctNamesclientpricesupport = clientpricesupport.Distinct()
                Dim distinctNamesclientpricesupportitem As String
                Dim stringps = ""
                For Each distinctNamesclientpricesupportitem In distinctNamesclientpricesupport
                    stringps = stringps & distinctNamesclientpricesupportitem & " - "
                Next
                If stringps.Length > 0 Then Sheet1.Range("BC" & Counter2).Value = stringps.Substring(0, stringps.Length - 3)

                Dim distinctNamesclientAPsupport = clientAPsupport.Distinct()
                Dim distinctNamesclientAPsupportitem As String
                Dim stringAP = ""
                For Each distinctNamesclientAPsupportitem In distinctNamesclientAPsupport
                    stringAP = stringAP & distinctNamesclientAPsupportitem & " - "
                Next
                If stringAP.Length > 0 Then Sheet1.Range("BH" & Counter2).Value = stringAP.Substring(0, stringAP.Length - 3)

                Dim distinctNamesclientrappel = clientRappel.Distinct()
                Dim distinctNamesclientrappelitem As String
                Dim stringR = ""
                For Each distinctNamesclientrappelitem In distinctNamesclientrappel
                    stringR = stringR & distinctNamesclientrappelitem & " - "
                Next
                If stringR.Length > 0 Then Sheet1.Range("BL" & Counter2).Value = stringR.Substring(0, stringR.Length - 3)


            Next
        Next

        '''''FIM LINHA Estipulaçoes
        '''''FIM LINHA Estipulaçoes
        '''''FIM LINHA Estipulaçoes
    End Sub

End Class