Imports DevExpress.Spreadsheet
Imports System.IO
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.XtraSpreadsheet.Commands
Imports DevExpress.XtraSpreadsheet.Menu
Imports System.Data.SQLite
Imports System.Globalization

Public Class Pricing

    Public Shared worksheet As Worksheet

    Public Shared workbook As IWorkbook


    Public filterkeycompany As String
    Public Shared fecho As Boolean = False
    Public ready = False
    Public Shared datasalteradas As Boolean = False
    Public Shared bonusalterados As Boolean = False
    Public clientealterado As Boolean = False
    Public TipoListaalterado As Boolean = False


    Public Shared filterkeydir As String
    Public Shared filterkeypais As String
    Public Shared filterkeyclifact As String
    Public Shared filterkeyclidest As String
    Public Shared filterkeycomp As String
    Public Shared filterkeytipo As String
    Public Shared filterkeypricelist As String
    Public Shared filterkeyPCDATI As String
    Public Shared filterkeyPCDATF As String
    Public Shared filterkeyCurrency As String
    ''FUSÃO
    ''Public Shared filterkeyPricing As String = "933"
    Public Shared filterkeyPricing As String = "943"
    Public Forcefilterkeydir As String ' Permissão




    Public possogravar As Boolean = False

    Public estipulacaoDataSet As New DataSet
    Public Shared estipulacaoDataTable As DataTable
    Public columnNum As Global.System.Data.DataColumn
    Public columnTipoContrato As Global.System.Data.DataColumn
    Public columnBeneficiario As Global.System.Data.DataColumn
    Public columnDataInicio As Global.System.Data.DataColumn
    Public columnDataFim As Global.System.Data.DataColumn
    Public columnTipoCondicao As Global.System.Data.DataColumn
    Public columnMaterial As Global.System.Data.DataColumn
    Public columnAnoPricing As Global.System.Data.DataColumn
    Public columnValor As Global.System.Data.DataColumn
    Public columnkmein As Global.System.Data.DataColumn
    Public columnvkorg As Global.System.Data.DataColumn
    Public columnOperacao As Global.System.Data.DataColumn








    Sub New()
        ' InitSkins()
        InitializeComponent()
        ' Me.InitSkinGallery()


        ''TABELA DE ESTIPULAÇÕES
        ''TABELA DE ESTIPULAÇÕES

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
        columnAnoPricing = New Global.System.Data.DataColumn("AnoPricing", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnAnoPricing.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnAnoPricing)
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


    End Sub





    Public Sub CreatePricing(ByVal clientfact As String, ByVal clientdest As String, ByVal company As String, ByVal tipo As String, ByVal pricelist As String, ByVal PCDATI As String, ByVal PCDATF As String, ByVal Currency As String)
        'Dim MD As String
        'Dim mng As String
        'Dim ass As String

        '  Me.SapTipoListaPrecosTableAdapter.Fill(Me.SapPricingDataset1.SapTipoListaPrecos)



        Dim ultimalinha As Integer = 24
        'Dim clientEst As Integer
        spreadsheetControl.BeginUpdate()
        workbook.BeginUpdate()
        worksheet.Unprotect("password2")






        Dim bottlecustlist As New ArrayList
        bottlecustlist.Clear()

        Dim mySelectQuery As String = ""

        Dim myConnectionPricing As New SQLiteConnection ' OleDb.OleDbConnection
        myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
        myConnectionPricing.Open()



        '    Dim count As Integer = 0
        Dim countbottlecust As Integer = 0
        Dim OffInvoiceMarktSup As Integer = 0
        Dim flagfirstrow As Boolean = True

        Dim flagprodutopai As String = ""
        Dim linhasprodutopai As New Collection
        Dim rows As RowCollection = worksheet.Rows

        Dim clistat As String


        '''''INICIO LOOP Produtos
        '''''INICIO LOOP Produtos
        '''''INICIO LOOP Produtos

        ''If filterkeyPricing = "933" Then FUSÃO
        If filterkeyPricing = "943" Then
            mySelectQuery = "SELECT * FROM paprixF_final where " _
            & "tabela='" & filterkeyPricing & "' and pcclid='" & clientdest & "' and pcccli='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "OR " _
            & "tabela='" & filterkeyPricing & "' and pcclid='" & clientdest & "' and pcccli='" & clientfact & "' and tipo='Paletes' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "ORDER BY PCCPRP, PCORDE, PCACOL"

            ''ElseIf filterkeyPricing = "934" Then FUSÃO
        ElseIf filterkeyPricing = "944" Then
            mySelectQuery = "SELECT * FROM paprixF_final where " _
            & "tabela='" & filterkeyPricing & "' and pcccli='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "OR " _
            & "tabela='" & filterkeyPricing & "' and pcccli='" & clientfact & "' and tipo='Paletes' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "ORDER BY PCCPRP, PCORDE, PCACOL"


            ''ElseIf filterkeyPricing = "936" Then FUSÃO
        ElseIf filterkeyPricing = "946" Then
            mySelectQuery = "SELECT * FROM paprixF_final where " _
            & "tabela='" & filterkeyPricing & "' and pcclid='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "OR " _
            & "tabela='" & filterkeyPricing & "' and pcclid='" & clientfact & "' and tipo='Paletes' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "ORDER BY PCCPRP, PCORDE, PCACOL"
        End If


        Dim myCommand As New SQLiteCommand(mySelectQuery, myConnectionPricing)
        Dim myReader1 As SQLiteDataReader
        myReader1 = myCommand.ExecuteReader()






        While myReader1.Read()



            If ultimalinha > 24 Then
                ' Access a collection of rows.
                'copiar da 1ª linha para a ultima+1
                rows(ultimalinha - 1).CopyFrom(rows("24"))
            End If

            If flagfirstrow = True Then



                '''''INICIO Invoice Customer Information
                '''''INICIO Invoice Customer Information
                '''''INICIO Invoice Customer Information
                'nome cliente
                worksheet.Cells("D4").Value = clientdest

                'worksheet.cell("D6").Value = (company)
                worksheet.Cells("C6").Value = (company)
                worksheet.Cells("C7").Value = (tipo)


                'dados cliente
                ' Dim mySelectQueryclienteDest As String

                ' mySelectQueryclienteDest = "SELECT  name1, contactname, contacttelephone, contactemail, landx50, clientstat, marketdirector, marketmanager, marketassistant, KATR3, BRSCH , katr4 FROM sapclients where kunnr ='" & clientdest & "'"
                '  Dim myCommandclienteDest As New SQLiteCommand(mySelectQueryclienteDest, myConnectionPricing)
                '  Dim myReaderclienteDest As SQLiteDataReader
                ' myReaderclienteDest = myCommandclienteDest.ExecuteReader(Data.CommandBehavior.SingleRow)


                Dim katr4 As String = ""


                worksheet.Cells("C4").Value = myReader1("CliDestName").ToString
                worksheet.Cells("C8").Value = myReader1("contactname").ToString
                worksheet.Cells("C9").Value = myReader1("contacttelephone").ToString
                worksheet.Cells("C10").Value = myReader1("contactemail").ToString
                worksheet.Cells("C5").Value = myReader1("landx50").ToString
                worksheet.Cells("D12").Value = (clientfact)
                ' worksheet.Cells("D11").Value = myReader1("PCCLIE").ToString
                worksheet.Cells("C18").Value = myReader1("KATR3").ToString  'Mainstream/Emerging
                worksheet.Cells("C19").Value = myReader1("BRSCH").ToString  '  ' Distributer Type

                'MD = myReader1("MARKETDIRECTOR")
                ' mng = myReader1("marketmanager")
                'ass = myReader1("marketassistant")

                clistat = (myReader1("PCCLIE"))

                katr4 = myReader1("katr4")



                '  Dim mySelectQueryclienteDestDirector As String
                ' mySelectQueryclienteDestDirector = "SELECT  name1 FROM sapclients where kunnr ='" & MD & "'"
                'Dim myCommandclienteDestDirector As New SQLiteCommand(mySelectQueryclienteDestDirector, myConnectionPricing)
                'worksheet.Cells("C15").Value = myReader1("MD_Name").ToString  ' myCommandclienteDestDirector.ExecuteScalar().ToString  ' Director
                ''alteração MR
                worksheet.Cells("C15").Value = myReader1("MM_Name").ToString


                'Dim mySelectQueryclienteDestManager As String
                'mySelectQueryclienteDestManager = "SELECT  name1 FROM sapclients where kunnr ='" & mng & "'"
                'Dim myCommandclienteDestManager As New SQLiteCommand(mySelectQueryclienteDestManager, myConnectionPricing)
                'worksheet.Cells("C16").Value = myReader1("MM_Name").ToString  ' myCommandclienteDestManager.ExecuteScalar.ToString   ' Manager
                ''alteração MR
                worksheet.Cells("C16").Value = myReader1("MD_Name").ToString


                ' Dim mySelectQueryclienteDestAssistant As String
                ' mySelectQueryclienteDestAssistant = "SELECT  name1 FROM sapclients where kunnr ='" & ass & "'"
                ' Dim myCommandclienteDestAssistant As New SQLiteCommand(mySelectQueryclienteDestAssistant, myConnectionPricing)
                worksheet.Cells("C17").Value = myReader1("MA_Name").ToString  ' myCommandclienteDestAssistant.ExecuteScalar().ToString  ' Assistant


                'Dim mySelectQueryclienteStat As String
                'mySelectQueryclienteStat = "SELECT  name1 FROM sapclients where kunnr ='" & clistat & "'"
                'Dim myCommandclientestat As New SQLiteCommand(mySelectQueryclienteStat, myConnectionPricing)
                worksheet.Cells("c11").Value = myReader1("StatsClient_Name").ToString '  myCommandclientestat.ExecuteScalar().ToString
                worksheet.Cells("d11").Value = myReader1("PCCLIE").ToString


                ' Dim mySelectQueryclientefact As String
                'mySelectQueryclientefact = "SELECT  name1, KLIMK, zzdiastoler, ztermtext, zincoterms, advertencia  FROM SAPCLIENTS where kunnr ='" & clientfact & "'"
                'Dim myCommandclientefact As New SQLiteCommand(mySelectQueryclientefact, myConnectionPricing)
                'Dim myReadercredit As SQLiteDataReader
                'myReadercredit = myCommandclientefact.ExecuteReader(Data.CommandBehavior.SingleRow)
                'While myReadercredit.Read
                worksheet.Cells("C12").Value = myReader1("InvoiceClient_Name").ToString

                '''''INICIO Terms & Condition
                '''''INICIO Terms & Condition
                '''''INICIO Terms & Condition


                worksheet.Cells("G7").Value = myReader1("InvoiceClient_KLIMK").ToString  'CreditLimit Value
                worksheet.Cells("I7").Value = myReader1("InvoiceClient_zzdiastoler").ToString  ' myReadercredit(2).ToString  ' credit limit DAYS
                worksheet.Cells("G8").Value = myReader1("InvoiceClient_ztermtext").ToString  ' myReadercredit(3).ToString  'Payment Terms
                worksheet.Cells("G9").Value = myReader1("InvoiceClient_zincoterms").ToString  ' = myReadercredit(4).ToString  'Delivery Terms
                worksheet.Cells("I8").Value = myReader1("InvoiceClient_advertencia").ToString  ' myReadercredit(5).ToString  'Tolerance
                ' End While
                'myReadercredit.Close()

                worksheet.Cells("G10").Value = katr4 'Tamanho da Palete



                '''''FIM Terms & Condition
                '''''FIM Terms & Condition
                '''''FIM Terms & Condition


                '''''FIM Invoice Customer Information
                '''''FIM Invoice Customer Information
                '''''FIM Invoice Customer Information






                worksheet.Cells("G4").Value = (Now.Year)
                worksheet.Cells("I4").Value = (Today)
                worksheet.Cells("G5").Value = pricelist & " " & myReader1("ListaPrecos").ToString ' getSymPriceListType(myReader1("PCTPRE"))).ToString

                worksheet.Cells("I5").Value = filterkeyPricing ' myReader1("TABELA").ToString
                worksheet.Cells("G6").Value = PCDATI
                worksheet.Cells("I6").Value = PCDATF

                '''''INICIO Exchange Rates
                '''''INICIO Exchange Rates
                '''''INICIO Exchange Rates

                worksheet.Cells("L18").Value = myReader1("PCMOED").ToString
                If UCase(myReader1("PCMOED")) <> "EUR" Then
                    Dim mySelectQueryEXC As String = "Select valor FROM sapcambios where nome='" & myReader1("PCMOED") & "'"
                    Dim myCommandEXC As New SQLiteCommand(mySelectQueryEXC, myConnectionPricing)
                    Dim retEXC As Double = myCommandEXC.ExecuteScalar
                    worksheet.Cells("M18").Value = Math.Abs(retEXC)

                    '    Dim mySelectQueryEXC1 As String = "SELECT RTCOMP FROM cambios1 where RTMOED='" & myReader1("PCMOED") & "'"
                    '    Dim myCommandEXC1 As New OleDbCommand(mySelectQueryEXC1, myConnectionPricing)
                    '    Dim retEXC1 As Double = myCommandEXC1.ExecuteScalar
                    '    worksheet.cells("N18").Value = retEXC1
                Else
                    worksheet.Cells("M18").Value = 1
                End If


                '''''FIM Exchange Rates
                '''''FIM Exchange Rates
                '''''FIM Exchange Rates

            End If




            '''''INICIO LINHA Product
            '''''INICIO LINHA Product
            '''''INICIO LINHA Product


            'SapMateriaisQueryTableAdapter1.ClearBeforeFill = True
            'SapMateriaisQueryTableAdapter1.Fill(SapPricingDataset1.SapMateriaisQuery, myReader1("PCCPRO"))



            'Dim retDescrProd As String
            'retDescrProd = Me.SapPricingDataset1.SapMateriaisQuery.Rows(0).Item("maktx")

            worksheet.Cells("A" & ultimalinha).Value = myReader1("maktx").ToString
            worksheet.Cells("BW" & ultimalinha).Value = myReader1("PCCPRO").ToString

            ''''caixa /bottle
            'Dim retUNITProd As String
            'retUNITProd = Me.SapPricingDataset1.SapMateriaisQuery.Rows(0).Item("meins")
            worksheet.Cells("BX" & ultimalinha).Value = myReader1("meins").ToString


            ' Dim retRange As String
            ' retRange = Me.SapPricingDataset1.SapMateriaisQuery.Rows(0).Item("RANGE")
            worksheet.Cells("B" & ultimalinha).Value = myReader1("RANGE").ToString ''Stock


            ' Dim retEMBALDESC As String
            ' retEMBALDESC = Me.SapPricingDataset1.SapMateriaisQuery.Rows(0).Item("DESCR")
            worksheet.Cells("C" & ultimalinha).Value = myReader1("Emb_DESCR").ToString

            ''Fusão
            worksheet.Cells("D" & ultimalinha).Value = myReader1("AnoPricing").ToString


            ''''status do Material
            Dim retSTATUS As String
            retSTATUS = myReader1("STATUS").ToString  ' Me.SapPricingDataset1.SapMateriaisQuery.Rows(0).Item("STATUS")

            If retSTATUS = "X" Then
                '                rows(ultimalinha - 1).Font.Color = Color.Red
                worksheet.Range("A" & ultimalinha & ":BV" & ultimalinha).Font.Color = System.Drawing.Color.Red

            Else

                'rows(ultimalinha - 1).Font.Color = Color.Black
                worksheet.Range("A" & ultimalinha & ":BV" & ultimalinha).Font.Color = System.Drawing.Color.Black
            End If



            '''''FIM LINHA Product
            '''''FIM LINHA Product
            '''''FIM LINHA Product


            '''''INICIO LINHA Gross Customer Unit Price
            '''''INICIO LINHA Gross Customer Unit Price
            '''''INICIO LINHA Gross Customer Unit Price



            worksheet.Cells("F" & ultimalinha).Value = (myReader1("PCPVAC")).ToString

            If IsDBNull(myReader1("PCPVAA")) Then
                worksheet.Cells("G" & ultimalinha).Value = Nothing
            Else
                worksheet.Cells("G" & ultimalinha).Value = (myReader1("PCPVAA")).ToString
            End If

            '''''FIM LINHA Gross Customer Unit Price
            '''''FIM LINHA Gross Customer Unit Price
            '''''FIM LINHA Gross Customer Unit Price

            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price

            Dim mySelectQueryREFPrice As String
            mySelectQueryREFPrice = "SELECT kbetr FROM saprefprice where matnr='" & myReader1("PCCPRO") & "' and ZZANO='" & myReader1("AnoPricing") & "' and zzkatr3='" & worksheet.Cells("C18").Value.ToString & "' and datbi >='" & PCDATI & "' and datab <='" & PCDATI & "'"
            Dim myCommandREFPrice As New SQLiteCommand(mySelectQueryREFPrice, myConnectionPricing)
            Dim retREFPrice As Decimal
            retREFPrice = myCommandREFPrice.ExecuteScalar
            worksheet.Cells("T" & ultimalinha).Value = (retREFPrice)



            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price

            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs

            Dim mySelectQueryBOTCOSTMOQ As String
            mySelectQueryBOTCOSTMOQ = "SELECT kbetr FROM sapbotlcost where matnr='" & myReader1("PCCPRO") & "' and ZZANO='" & myReader1("AnoPricing") & "' and datbi >='" & PCDATI & "' and datab <='" & PCDATI & "'"
            Dim myCommandBOTCOSTMOQ As New SQLiteCommand(mySelectQueryBOTCOSTMOQ, myConnectionPricing)
            Dim retBOTCOSTMOQ As Decimal
            retBOTCOSTMOQ = myCommandBOTCOSTMOQ.ExecuteScalar

            worksheet.Cells("BS" & ultimalinha).Value = retBOTCOSTMOQ


            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs


            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus

            Dim mySelectQueryBonus As String
            mySelectQueryBonus = ""
            ''FUSÂO

            If filterkeyPricing = "943" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN953' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "' and ZZANO='" & myReader1("AnoPricing") & "'"
            ElseIf filterkeyPricing = "944" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN954' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "' and ZZANO='" & myReader1("AnoPricing") & "'"
            ElseIf filterkeyPricing = "946" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN957' and zcldest='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "' and ZZANO='" & myReader1("AnoPricing") & "'"
            End If







            Dim myCommandBonus As New SQLiteCommand(mySelectQueryBonus, myConnectionPricing)
            Dim retBonus As SQLiteDataReader
            retBonus = myCommandBonus.ExecuteReader(CommandBehavior.SingleRow)
            'atenção -> kbetr = knrmm = Minimum quantity
            'atenção -> knrnm = Free goods quantity
            'atenção -> knrnm = Additional quantity for free goods

            If retBonus.HasRows Then
                Do While retBonus.Read
                    worksheet.Cells("BT" & ultimalinha).Value = CDec(retBonus(0))
                    worksheet.Cells("BU" & ultimalinha).Value = CDec(retBonus(1))
                    worksheet.Cells("BV" & ultimalinha).Value = CDec(retBonus(2))
                Loop
            Else
                worksheet.Cells("BT" & ultimalinha).Value = Nothing
                worksheet.Cells("BU" & ultimalinha).Value = Nothing
                worksheet.Cells("BV" & ultimalinha).Value = Nothing
            End If


            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus


            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes

            Dim mySelectQueryEstipulaçoes As String = ""
            worksheet.Range("AX" & ultimalinha & ":BR" & ultimalinha).Value = Nothing
            ''FUSÂO
            ''If filterkeyPricing = "936" Then ''''ALEMANHA por CLIENTE ESTATISTICO
            If filterkeyPricing = "946" Then ''''ALEMANHA por CLIENTE ESTATISTICO

                mySelectQueryEstipulaçoes = "SELECT knuma,boart, kschl, kbetr, bonem, vkorgcond FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='clistat' and pltyp ='" & pricelist & "' and datbi >='" & PCDATF & "' and datab <='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "' and ZZANO='" & myReader1("AnoPricing") & "'"
            Else
                mySelectQueryEstipulaçoes = "SELECT knuma,boart, kschl, kbetr, bonem, vkorgcond FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi >='" & PCDATF & "' and datab <='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "' and ZZANO='" & myReader1("AnoPricing") & "'"
            End If


            Dim myCommandEstipulaçoes As New SQLiteCommand(mySelectQueryEstipulaçoes, myConnectionPricing)
            Dim retEstipulaçoes As SQLiteDataReader


            retEstipulaçoes = myCommandEstipulaçoes.ExecuteReader
            Dim countcomm = 0

            If retBonus.HasRows Then


                Do While retEstipulaçoes.Read

                    Dim newRow = estipulacaoDataTable.NewRow
                    newRow(0) = retEstipulaçoes("knuma")
                    newRow(1) = retEstipulaçoes("boart")
                    newRow(2) = retEstipulaçoes("bonem")
                    newRow(3) = PCDATI
                    newRow(4) = PCDATF
                    newRow(5) = retEstipulaçoes("kschl")
                    newRow(6) = myReader1("PCCPRO")
                    newRow(7) = myReader1("AnoPricing")
                    If UCase(retEstipulaçoes("kschl")).ToString.EndsWith("V") Then
                        newRow(8) = retEstipulaçoes("kbetr")
                    Else
                        newRow(8) = retEstipulaçoes("kbetr") / 10
                    End If
                    newRow(9) = worksheet.Cells("BX" & ultimalinha).Value
                    newRow(10) = retEstipulaçoes("vkorgcond")

                    estipulacaoDataTable.Rows.Add(newRow)

                    Dim clientpricesupport As New List(Of String)
                    Dim clientAPsupport As New List(Of String)
                    Dim clientRappel As New List(Of String)
                    Select Case retEstipulaçoes("kschl")
                    ''Price Support
                        Case "YSCV" ' Analysis & Others V
                            worksheet.Cells("BB" & ultimalinha).Value = CDbl(worksheet.Cells("BB" & ultimalinha).Value.ToObject + retEstipulaçoes("kbetr"))
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
                        Case "YSCP" ' Analysis & Others P
                            worksheet.Cells("BC" & ultimalinha).Value = CDbl(worksheet.Cells("BC" & ultimalinha).Value.ToObject + (retEstipulaçoes("kbetr") / 10))
                            clientpricesupport.Add(retEstipulaçoes("bonem"))

                        Case "YSNV" ' Credit note V
                            worksheet.Cells("AX" & ultimalinha).Value = CDbl(worksheet.Cells("AX" & ultimalinha).Value.ToObject + retEstipulaçoes("kbetr"))
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
                        Case "YSNP" ' Credit note P
                            worksheet.Cells("AY" & ultimalinha).Value = CDbl(worksheet.Cells("AY" & ultimalinha).Value.ToObject + (retEstipulaçoes("kbetr") / 10))
                            clientpricesupport.Add(retEstipulaçoes("bonem"))


                        Case "YSHV" ' Charged by customer V
                            worksheet.Cells("AZ" & ultimalinha).Value = CDbl(worksheet.Cells("AZ" & ultimalinha).Value.ToObject + retEstipulaçoes("kbetr"))
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
                        Case "YSHP" ' Charged by customer P
                            worksheet.Cells("BA" & ultimalinha).Value = CDbl(worksheet.Cells("BA" & ultimalinha).Value.ToObject + (retEstipulaçoes("kbetr") / 10))
                            clientpricesupport.Add(retEstipulaçoes("bonem"))

                        ''A&P Support
                        Case "YAPV"
                            worksheet.Cells("BD" & ultimalinha).Value = CDbl(worksheet.Cells("BD" & ultimalinha).Value.ToObject + retEstipulaçoes("kbetr"))
                            clientAPsupport.Add(retEstipulaçoes("bonem"))
                        Case "YAPP"
                            worksheet.Cells("BE" & ultimalinha).Value = CDbl(worksheet.Cells("BE" & ultimalinha).Value.ToObject + (retEstipulaçoes("kbetr") / 10))
                            clientAPsupport.Add(retEstipulaçoes("bonem"))
                        Case "YABV"
                            worksheet.Cells("BF" & ultimalinha).Value = CDbl(CDbl(worksheet.Cells("BF" & ultimalinha).Value.ToObject + retEstipulaçoes("kbetr")))
                            clientAPsupport.Add(retEstipulaçoes("bonem"))

                        ''incentives....
                        Case "YOCM"
                            worksheet.Cells("BG" & ultimalinha).Value = CDbl(worksheet.Cells("BG" & ultimalinha).Value.ToObject + retEstipulaçoes("kbetr"))
                            clientRappel.Add(retEstipulaçoes("bonem"))

                        ''Rappel....
                        Case "YRRV"
                            worksheet.Cells("BI" & ultimalinha).Value = CDbl(worksheet.Cells("BI" & ultimalinha).Value.ToObject + retEstipulaçoes("kbetr"))
                            clientRappel.Add(retEstipulaçoes("bonem"))
                        Case "YRRP"
                            worksheet.Cells("BJ" & ultimalinha).Value = CDbl(worksheet.Cells("BJ" & ultimalinha).Value.ToObject + (retEstipulaçoes("kbetr") / 10))
                            clientRappel.Add(retEstipulaçoes("bonem"))
                        ''Commisions normais
                        Case "YCOP"
                            countcomm = countcomm + 1
                            If countcomm = 1 Then
                                worksheet.Cells("BM" & ultimalinha).Value = CDbl(retEstipulaçoes("kbetr") / 10)
                                worksheet.Cells("BN" & ultimalinha).Value = CDbl(retEstipulaçoes("bonem"))
                            ElseIf countcomm = 2 Then
                                worksheet.Cells("BO" & ultimalinha).Value = CDbl(retEstipulaçoes("kbetr") / 10)
                                worksheet.Cells("BP" & ultimalinha).Value = CDbl(retEstipulaçoes("bonem"))
                            ElseIf countcomm = 3 Then
                                worksheet.Cells("BQ" & ultimalinha).Value = CDbl(retEstipulaçoes("kbetr") / 10)
                                worksheet.Cells("BR" & ultimalinha).Value = CDbl(retEstipulaçoes("bonem"))
                            Else
                                MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                            End If
                        ''Commisions smartwine
                        Case "YEST"
                            countcomm = countcomm + 1
                            If countcomm = 1 Then
                                worksheet.Cells("BM" & ultimalinha).Value = CDbl(retEstipulaçoes("kbetr") / 10)
                                worksheet.Cells("BN" & ultimalinha).Value = CDbl(retEstipulaçoes("bonem"))
                            ElseIf countcomm = 2 Then
                                worksheet.Cells("BO" & ultimalinha).Value = CDbl(retEstipulaçoes("kbetr") / 10)
                                worksheet.Cells("BP" & ultimalinha).Value = CDbl(retEstipulaçoes("bonem"))
                            ElseIf countcomm = 3 Then
                                worksheet.Cells("BQ" & ultimalinha).Value = CDbl(retEstipulaçoes("kbetr") / 10)
                                worksheet.Cells("BR" & ultimalinha).Value = CDbl(retEstipulaçoes("bonem"))
                            Else
                                MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                            End If

                    End Select



                Loop
            End If

            '''''FIM LINHA Estipulaçoes
            '''''FIM LINHA Estipulaçoes
            '''''FIM LINHA Estipulaçoes



            ' '''''INICIO LINHA  VOLUMES(9L)
            ' '''''INICIO LINHA  VOLUMES(9L)
            ' '''''INICIO LINHA  VOLUMES(9L)




            Try

                If Not myReader1("SHIPPED") Is DBNull.Value Then worksheet.Cells("CT" & ultimalinha).Value = CDec(myReader1("SHIPPED"))
                If Not myReader1("INHAND") Is DBNull.Value Then worksheet.Cells("CU" & ultimalinha).Value = CDec(myReader1("INHAND"))
                worksheet.Cells("Y" & ultimalinha).Value = worksheet.Cells("CT" & ultimalinha).Value.NumericValue + worksheet.Cells("CU" & ultimalinha).Value.NumericValue
                If Not (myReader1("FORECA")) Is DBNull.Value Then worksheet.Cells("V" & ultimalinha).Value = CDec(myReader1("FORECA"))
                If Not (myReader1("FORECM")) Is DBNull.Value Then worksheet.Cells("Z" & ultimalinha).Value = CDec(myReader1("FORECM"))
                If Not myReader1("SHIPPED-1") Is DBNull.Value Then worksheet.Cells("W" & ultimalinha).Value = CDec(myReader1("SHIPPED-1"))
            Catch ex As Exception
                worksheet.Cells("Y" & ultimalinha).Value = Nothing
                worksheet.Cells("CT" & ultimalinha).Value = Nothing
                worksheet.Cells("CU" & ultimalinha).Value = Nothing
                worksheet.Cells("V" & ultimalinha).Value = Nothing
                worksheet.Cells("Z" & ultimalinha).Value = Nothing
                worksheet.Cells("W" & ultimalinha).Value = Nothing
            End Try





            ' '''''FIM LINHA VOLUMES(9L)
            ' '''''FIM LINHA VOLUMES(9L)
            ' '''''FIM LINHA VOLUMES(9L)


            '''''INICIO LINHA 2 Product
            '''''INICIO LINHA 2 Product
            '''''INICIO LINHA 2 Product
            worksheet.Cells("AC" & ultimalinha).Value = (myReader1("PCCPRO")).ToString


            Dim retEMBALLITRO As Decimal
            retEMBALLITRO = myReader1("LTS") ' SapPricingDataset1.SapMateriaisQuery.Rows(0).Item("LTS")
            worksheet.Cells("AD" & ultimalinha).Value = (retEMBALLITRO)

            Dim retEMBALCAP As Decimal
            retEMBALCAP = myReader1("cap") 'SapPricingDataset1.SapMateriaisQuery.Rows(0).Item("cap")

            Try
                If retEMBALCAP <> 0 Then
                    worksheet.Cells("AE" & ultimalinha).Value = (retEMBALLITRO / retEMBALCAP)
                    If worksheet.Cells("F" & ultimalinha).Value.ToString <> "" Then
                        worksheet.Cells("E" & ultimalinha).Value = worksheet.Cells("F" & ultimalinha).Value.ToString / worksheet.Cells("AE" & ultimalinha).Value.ToString
                    End If
                Else
                    worksheet.Cells("AE" & ultimalinha).Value = "n/a"
                    worksheet.Cells("E" & ultimalinha).Value = "n/a"
                End If
            Catch
                worksheet.Cells("AE" & ultimalinha).Value = "n/a"
                worksheet.Cells("E" & ultimalinha).Value = "n/a"
            End Try

            '''''FIM LINHA 2 Product
            '''''FIM LINHA 2 Product
            '''''FIM LINHA 2 Product


            '''''INICIO LINHA 2 OFF INVOICE SUPPORT
            '''''INICIO LINHA 2 OFF INVOICE SUPPORT
            '''''INICIO LINHA 2 OFF INVOICE SUPPORT

            If IsDBNull(myReader1("ZDEV")) = False Then
                worksheet.Cells("AF" & ultimalinha).Value = CDec(myReader1("ZDEV"))
            Else
                worksheet.Cells("AF" & ultimalinha).Value = Nothing
            End If

            If IsNumeric(myReader1("ZDEP")) Then
                worksheet.Cells("AG" & ultimalinha).Value = CDec(myReader1("ZDEP") / 10)
            Else
                worksheet.Cells("AG" & ultimalinha).Value = Nothing

            End If

            If IsDBNull(myReader1("ZDQV")) = False Then
                worksheet.Cells("AH" & ultimalinha).Value = CDec(myReader1("ZDQV"))
            Else
                worksheet.Cells("AH" & ultimalinha).Value = Nothing

            End If

            If IsNumeric(myReader1("ZDQP")) Then
                worksheet.Cells("AI" & ultimalinha).Value = CDec(myReader1("ZDQP") / 10)
            Else
                worksheet.Cells("AI" & ultimalinha).Value = Nothing

            End If

            If IsDBNull(myReader1("ZDPV")) = False Then
                worksheet.Cells("AJ" & ultimalinha).Value = CDec(myReader1("ZDPV"))
            Else
                worksheet.Cells("AJ" & ultimalinha).Value = Nothing

            End If

            If IsNumeric(myReader1("ZDPP")) Then
                worksheet.Cells("AK" & ultimalinha).Value = CDec(myReader1("ZDPP") / 10)
            Else
                worksheet.Cells("AK" & ultimalinha).Value = Nothing

            End If

            If IsDBNull(myReader1("ZDRV")) = False Then
                worksheet.Cells("AL" & ultimalinha).Value = CDec(myReader1("ZDRV"))
            Else
                worksheet.Cells("AL" & ultimalinha).Value = Nothing

            End If

            If IsNumeric(myReader1("ZDRP")) Then
                worksheet.Cells("AM" & ultimalinha).Value = CDec(myReader1("ZDRP") / 10)
            Else
                worksheet.Cells("AM" & ultimalinha).Value = Nothing

            End If

            If IsDBNull(myReader1("ZDLV")) = False Then
                worksheet.Cells("AN" & ultimalinha).Value = CDbl(myReader1("ZDLV"))
            Else
                worksheet.Cells("AN" & ultimalinha).Value = Nothing

            End If

            If IsNumeric(myReader1("ZDLP")) Then
                worksheet.Cells("AO" & ultimalinha).Value = CDec(myReader1("ZDLP") / 10)
            Else
                worksheet.Cells("AO" & ultimalinha).Value = Nothing

            End If

            If IsDBNull(myReader1("ZDTV")) = False Then
                worksheet.Cells("AP" & ultimalinha).Value = CDec(myReader1("ZDTV"))
            Else
                worksheet.Cells("AP" & ultimalinha).Value = Nothing

            End If

            If IsNumeric(myReader1("ZDTP")) Then
                worksheet.Cells("AQ" & ultimalinha).Value = CDec(myReader1("ZDTP") / 10)
            Else
                worksheet.Cells("AQ" & ultimalinha).Value = Nothing

            End If



            '''''FIM LINHA 2 OFF INVOICE SUPPORT
            '''''FIM LINHA 2 OFF INVOICE SUPPORT
            '''''FIM LINHA 2 OFF INVOICE SUPPORT

            '''''INICIO LINHA 2 EXTRAS ON INVOICE
            '''''INICIO LINHA 2 EXTRAS ON INVOICE
            '''''INICIO LINHA 2 EXTRAS ON INVOICE
            If IsDBNull(myReader1("ZEEC")) = False Then worksheet.Cells("AR" & ultimalinha).Value = CDec(myReader1("ZEEC")) Else worksheet.Cells("AR" & ultimalinha).Value = Nothing
            If IsDBNull(myReader1("ZEFR")) = False Then worksheet.Cells("AS" & ultimalinha).Value = CDec(myReader1("ZEFR")) Else worksheet.Cells("AS" & ultimalinha).Value = Nothing
            If IsDBNull(myReader1("ZEIN")) = False Then worksheet.Cells("AT" & ultimalinha).Value = CDec(myReader1("ZEIN")) Else worksheet.Cells("AT" & ultimalinha).Value = Nothing
            If IsDBNull(myReader1("ZEFI")) = False Then worksheet.Cells("AU" & ultimalinha).Value = CDec(myReader1("ZEFI")) Else worksheet.Cells("AU" & ultimalinha).Value = Nothing
            If IsDBNull(myReader1("ZESL")) = False Then worksheet.Cells("AV" & ultimalinha).Value = CDec(myReader1("ZESL")) Else worksheet.Cells("AV" & ultimalinha).Value = Nothing
            If IsDBNull(myReader1("ZESP")) = False Then worksheet.Cells("AW" & ultimalinha).Value = CDec(myReader1("ZESP")) Else worksheet.Cells("AW" & ultimalinha).Value = Nothing
            '''''FIM LINHA 2 EXTRAS ON INVOICE
            '''''FIM LINHA 2 EXTRAS ON INVOICE
            '''''FIM LINHA 2 EXTRAS ON INVOICE


            '''''INICIO LINHA 2 MOQ
            '''''INICIO LINHA 2 MOQ
            '''''INICIO LINHA 2 MOQ
            'worksheet.cells("BS" & ultimalinha).Value = (myReader1("PCMOQ"))
            '''''FIM LINHA 2 MOQ
            '''''FIM LINHA 2 MOQ
            '''''FIM LINHA 2 MOQ
            '''''INICIO LINHA 2 PCMARK
            '''''INICIO LINHA 2 PCMARK
            '''''INICIO LINHA 2 PCMARK
            'worksheet.cells("BT" & ultimalinha).Value = (myReader1("PCMARK"))
            '''''FIM LINHA 2 PCMARK
            '''''FIM LINHA 2 PCMARK
            '''''FIM LINHA 2 PCMARK

            '''''INICIO LINHA 2 DSQ
            '''''INICIO LINHA 2 DSQ
            '''''INICIO LINHA 2 DSQ
            'If IsDBNull(myReader1("PCBDSQ")) = False Then worksheet.cells("BU" & ultimalinha).Value = (myReader1("PCBDSQ")) Else worksheet.cells("BU" & ultimalinha).Value = ""
            'If IsDBNull(myReader1("PCVDSQ")) = False Then worksheet.cells("BV" & ultimalinha).Value = (myReader1("PCVDSQ")) Else worksheet.cells("BV" & ultimalinha).Value = ""
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
        ''FUSÂO
        ''If filterkeyPricing = "936" Then ''''ALEMANHA por CLIENTE ESTATISTICO
        If filterkeyPricing = "946" Then ''''ALEMANHA por CLIENTE ESTATISTICO
            querystring = "(statsclientnum = '" & clistat & "')"
        Else
            querystring = "(finalclientnum = '" & clientdest & "')"
        End If

        ''Crusted
        ''Crusted
        ''Crusted
        Dim mySelectQueryVol9LBM As String = "SELECT SUM(FORECA) as exp1, SUM(SHIPHAND) as exp2, SUM(FORECM) as exp3 FROM sapsales WHERE familia = 'Crusted' AND COMPANY = '" & company & "' AND TIPO like '%" & tipo & "%' AND " & querystring & " AND Year = '" & Now.Year & "'"
        Dim myCommandVol9LBM As New SQLiteCommand(mySelectQueryVol9LBM, myConnectionPricing)
        Dim retVol9LBM As SQLiteDataReader
        Try
            retVol9LBM = myCommandVol9LBM.ExecuteReader(CommandBehavior.SingleRow)
            Do While retVol9LBM.Read
                If Not (retVol9LBM(0)) Is DBNull.Value Then worksheet.Cells("X6").Value = CDec(retVol9LBM(0))
                If Not (retVol9LBM(1)) Is DBNull.Value Then worksheet.Cells("Y6").Value = CDec(retVol9LBM(1))
                If Not (retVol9LBM(2)) Is DBNull.Value Then worksheet.Cells("Z6").Value = CDec(retVol9LBM(2))
            Loop
        Catch
            worksheet.Cells("X6").Value = 0
            worksheet.Cells("Y6").Value = 0
            worksheet.Cells("Z6").Value = 0
        End Try

        ''Trad LBV
        ''Trad LBV
        ''Trad LBV 
        Dim mySelectQueryVol9LBMLBV As String = "SELECT SUM(FORECA) as exp1, SUM(SHIPHAND) as exp2, SUM(FORECM) as exp3 FROM sapsales WHERE familia = 'Bottle Aged LBV' AND COMPANY = '" & company & "' AND TIPO like '%" & tipo & "%' AND " & querystring & " AND Year = '" & Now.Year & "'"
        Dim myCommandVol9LBMLBV As New SQLiteCommand(mySelectQueryVol9LBMLBV, myConnectionPricing)
        Dim retVol9LBMLBV As SQLiteDataReader
        Try
            retVol9LBMLBV = myCommandVol9LBM.ExecuteReader(CommandBehavior.SingleRow)
            Do While retVol9LBMLBV.Read
                If Not (retVol9LBMLBV(0)) Is DBNull.Value Then worksheet.Cells("X7").Value = CDec(retVol9LBMLBV(0))
                If Not (retVol9LBMLBV(1)) Is DBNull.Value Then worksheet.Cells("Y7").Value = CDec(retVol9LBMLBV(1))
                If Not (retVol9LBMLBV(2)) Is DBNull.Value Then worksheet.Cells("Z7").Value = CDec(retVol9LBMLBV(2))
            Loop
        Catch
            worksheet.Cells("X7").Value = 0
            worksheet.Cells("Y7").Value = 0
            worksheet.Cells("Z7").Value = 0
        End Try


        ''Quintas
        ''Quintas
        ''Quintas
        Dim mySelectQueryVol9LBMquintas As String = "SELECT SUM(FORECA) as exp1, SUM(SHIPHAND) as exp2, SUM(FORECM) as exp3 FROM sapsales WHERE SUBSTR(familia,1,6) = 'Quinta' AND COMPANY = '" & company & "' AND TIPO  like '%" & tipo & "' AND " & querystring & " AND Year = '" & Now.Year & "'"
        Dim myCommandVol9LBMquintas As New SQLiteCommand(mySelectQueryVol9LBMquintas, myConnectionPricing)
        Dim retVol9LBMquintas As SQLiteDataReader
        Try
            retVol9LBMquintas = myCommandVol9LBMquintas.ExecuteReader(CommandBehavior.SingleRow)
            Do While retVol9LBMquintas.Read
                If Not (retVol9LBMquintas(0)) Is DBNull.Value Then worksheet.Cells("X8").Value = CDec(retVol9LBMquintas(0))
                If Not (retVol9LBMquintas(1)) Is DBNull.Value Then worksheet.Cells("Y8").Value = CDec(retVol9LBMquintas(1))
                If Not (retVol9LBMquintas(2)) Is DBNull.Value Then worksheet.Cells("Z8").Value = CDec(retVol9LBMquintas(2))
            Loop
        Catch
            worksheet.Cells("X8").Value = 0
            worksheet.Cells("Y8").Value = 0
            worksheet.Cells("Z8").Value = 0
        End Try

        ''Vintage
        ''Vintage
        ''Vintage

        Dim mySelectQueryVol9LBMvintage As String = "SELECT SUM(FORECA) as exp1, SUM(SHIPHAND) as exp2, SUM(FORECM) as exp3 FROM sapsales WHERE SUBSTR(familia,1,7) = 'Vintage' AND COMPANY = '" & company & "' AND TIPO  like '%" & tipo & "%' AND " & querystring & " AND Year = '" & Now.Year & "'"
        Dim myCommandVol9LBMvintage As New SQLiteCommand(mySelectQueryVol9LBMvintage, myConnectionPricing)
        Dim retVol9LBMvintage As SQLiteDataReader
        Try
            retVol9LBMvintage = myCommandVol9LBMvintage.ExecuteReader(CommandBehavior.SingleRow)
#Disable Warning BC42104 ' Variable 'retVol9LBMquintas' is used before it has been assigned a value. A null reference exception could result at runtime.
            Do While retVol9LBMquintas.Read
#Enable Warning BC42104 ' Variable 'retVol9LBMquintas' is used before it has been assigned a value. A null reference exception could result at runtime.
                If Not (retVol9LBMvintage(0)) Is DBNull.Value Then worksheet.Cells("X9").Value = CDec(retVol9LBMvintage(0))
                If Not (retVol9LBMvintage(1)) Is DBNull.Value Then worksheet.Cells("Y9").Value = CDec(retVol9LBMvintage(1))
                If Not (retVol9LBMvintage(2)) Is DBNull.Value Then worksheet.Cells("Z9").Value = CDec(retVol9LBMvintage(2))
            Loop

        Catch
            worksheet.Cells("X9").Value = 0
            worksheet.Cells("Y9").Value = 0
            worksheet.Cells("Z9").Value = 0
        End Try


        '''''FIM VOLUMES(9L) Bottled Matured
        '''''FIM VOLUMES(9L) Bottled Matured
        '''''FIM VOLUMES(9L) Bottled Matured


        '''''INICIO SUPPORT TOTALS
        '''''INICIO SUPPORT TOTALS
        '''''INICIO SUPPORT TOTALS
        '''''Shipinhand
        Try
            Dim formulaX14 As String = ""
            formulaX14 = "=ABS(((AF24+AH24+AJ24+AL24+AN24+AP24)/AD24*9*Y24)+((F24*((K24/100))/AD24*9*Y24)))"
            Dim formulaX15 As String = ""
            formulaX15 = "=ABS(IF(BU24=0;0;BZ24*BV24/(BV24+BU24))*(Y24*9/AD24))"
            Dim formulaZ14 As String = ""
            formulaZ14 = "=ABS(((AX24+AZ24+BI24)/AD24*9*Y24)+((BZ24*((BA24+AY24+BJ24)/100)))/AD24*9*Y24)"
            Dim formulaZ15 As String = ""
            formulaZ15 = "=ABS((BD24/AD24*9*Y24)+((BZ24*((BE24)/100))/AD24*9*Y24))"
            Dim formulaZ16 As String = ""
            formulaZ16 = "=ABS(BF24/AD24*9*Y24)"
            Dim formulaZ17 As String = ""
            formulaZ17 = "=ABS((BB24/AD24*9*Y24)+((BZ24*((BC24)/100))/AD24*9*Y24))"

            For X = 25 To ultimalinha - 1
                If worksheet.Cells("F" & X).Value <> 0 And worksheet.Cells("AD" & X).Value <> 0 Then
                    formulaX14 = formulaX14 & "+ABS(((AF" & X & "+AH" & X & "+AJ" & X & "+AL" & X & "+AN" & X & "+AP" & X & ")/AD" & X & "*9*Y" & X & ")+((F" & X & "*((K" & X & "/100))/AD" & X & "*9*Y" & X & ")))"
                    formulaX15 = formulaX15 & "+ABS(IF(BU" & X & "=0;0;BZ" & X & "*BV" & X & "/(BV" & X & "+BU" & X & "))*(Y" & X & "*9/AD" & X & "))"
                    formulaZ14 = formulaZ14 & "+ABS(((AX" & X & "+AZ" & X & "+BI" & X & ")/AD" & X & "*9*Y" & X & ")+((BZ" & X & "*((BA" & X & "+AY" & X & "+BJ" & X & ")/100)))/AD" & X & "*9*Y" & X & ")"
                    formulaZ15 = formulaZ15 & "+ABS((BD" & X & "/AD" & X & "*9*Y" & X & ")+((BZ" & X & "*((BE" & X & ")/100))/AD" & X & "*9*Y" & X & "))"
                    formulaZ16 = formulaZ16 & "+ABS(BF" & X & "/AD" & X & "*9*Y" & X & ")"
                    formulaZ17 = formulaZ17 & "+ABS((BB" & X & "/AD" & X & "*9*Y" & X & ")+((BZ" & X & "*((BC" & X & ")/100))/AD" & X & "*9*Y" & X & "))"
                End If
            Next
            worksheet.Cells("X14").Formula = formulaX14
            worksheet.Cells("X15").Formula = formulaX15
            worksheet.Cells("Z14").Formula = formulaZ14
            worksheet.Cells("Z15").Formula = formulaZ15
            worksheet.Cells("Z16").Formula = formulaZ16
            worksheet.Cells("Z17").Formula = formulaZ17
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Too many products to calculate SUPPORT TOTALS in Excel")
        End Try

        '''''Forecast
        Try
            Dim formulaS14 As String = ""
            formulaS14 = "=ABS(((AF24+AH24+AJ24+AL24+AN24+AP24)/AD24*9*Z24)+((F24*((K24/100))/AD24*9*Z24)))"
            Dim formulaS15 As String = ""
            formulaS15 = "=ABS(IF(BU24=0;0;BZ24*BV24/(BV24+BU24))*(Z24*9/AD24))"
            Dim formulaU14 As String = ""
            formulaU14 = "=ABS(((AX24+AZ24+BI24)/AD24*9*Z24)+((BZ24*((BA24+AY24+BJ24)/100)))/AD24*9*Z24)"
            Dim formulaU15 As String = ""
            formulaU15 = "=ABS((BD24/AD24*9*Z24)+((BZ24*((BE24)/100))/AD24*9*Z24))"
            Dim formulaU16 As String = ""
            formulaU16 = "=ABS(BF24/AD24*9*Z24)"
            Dim formulaU17 As String = ""
            formulaU17 = "=ABS((BB24/AD24*9*Z24)+((BZ24*((BC24)/100))/AD24*9*Z24))"

            For X = 25 To ultimalinha - 1
                If worksheet.Cells("F" & X).Value <> 0 And worksheet.Cells("AD" & X).Value <> 0 Then
                    formulaS14 = formulaS14 & "+ABS(((AF" & X & "+AH" & X & "+AJ" & X & "+AL" & X & "+AN" & X & "+AP" & X & ")/AD" & X & "*9*Z" & X & ")+((F" & X & "*((K" & X & "/100))/AD" & X & "*9*Z" & X & ")))"
                    formulaS15 = formulaS15 & "+ABS(IF(BU" & X & "=0;0;BZ" & X & "*BV" & X & "/(BV" & X & "+BU" & X & "))*(Z" & X & "*9/AD" & X & "))"
                    formulaU14 = formulaU14 & "+ABS(((AX" & X & "+AZ" & X & "+BI" & X & ")/AD" & X & "*9*Z" & X & ")+((BZ" & X & "*((BA" & X & "+AY" & X & "+BJ" & X & ")/100)))/AD" & X & "*9*Z" & X & ")"
                    formulaU15 = formulaU15 & "+ABS((BD" & X & "/AD" & X & "*9*Z" & X & ")+((BZ" & X & "*((BE" & X & ")/100))/AD" & X & "*9*ZY" & X & "))"
                    formulaU16 = formulaU16 & "+ABS(BF" & X & "/AD" & X & "*9*Z" & X & ")"
                    formulaU17 = formulaU17 & "+ABS((BB" & X & "/AD" & X & "*9*Z" & X & ")+((BZ" & X & "*((BC" & X & ")/100))/AD" & X & "*9*Z" & X & "))"
                End If
            Next
            worksheet.Cells("S14").Formula = formulaS14
            worksheet.Cells("S15").Formula = formulaS15
            worksheet.Cells("U14").Formula = formulaU14
            worksheet.Cells("U15").Formula = formulaU15
            worksheet.Cells("U16").Formula = formulaU16
            worksheet.Cells("U17").Formula = formulaU17
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Too many products to calculate SUPPORT TOTALS in Excel")
        End Try

        '''''TARGET
        Try
            Dim formulaS5 As String = ""
            formulaS5 = "=ABS(((AF24+AH24+AJ24+AL24+AN24+AP24)/AD24*9*V24)+((F24*((K24/100))/AD24*9*V24)))"
            Dim formulaS6 As String = ""
            formulaS6 = "=ABS(IF(BU24=0;0;BZ24*BV24/(BV24+BU24))*(V24*9/AD24))"
            Dim formulaU5 As String = ""
            formulaU5 = "=ABS(((AX24+AZ24+BI24)/AD24*9*V24)+((BZ24*((BA24+AY24+BJ24)/100)))/AD24*9*V24)"
            Dim formulaU6 As String = ""
            formulaU6 = "=ABS((BD24/AD24*9*V24)+((BZ24*((BE24)/100))/AD24*9*V24))"
            Dim formulaU7 As String = ""
            formulaU7 = "=ABS(BF24/AD24*9*V24)"
            Dim formulaU8 As String = ""
            formulaU8 = "=ABS((BB24/AD24*9*V24)+((BZ24*((BC24)/100))/AD24*9*V24))"

            For X = 25 To ultimalinha - 1
                If worksheet.Cells("F" & X).Value <> 0 And worksheet.Cells("AD" & X).Value <> 0 Then
                    formulaS5 = formulaS5 & "+ABS(((AF" & X & "+AH" & X & "+AJ" & X & "+AL" & X & "+AN" & X & "+AP" & X & ")/AD" & X & "*9*V" & X & ")+((F" & X & "*((K" & X & "/100))/AD" & X & "*9*V" & X & ")))"
                    formulaS6 = formulaS6 & "+ABS(IF(BU" & X & "=0;0;BZ" & X & "*BV" & X & "/(BV" & X & "+BU" & X & "))*(V" & X & "*9/AD" & X & "))"
                    formulaU5 = formulaU5 & "+ABS(((AX" & X & "+AZ" & X & "+BI" & X & ")/AD" & X & "*9*V" & X & ")+((BZ" & X & "*((BA" & X & "+AY" & X & "+BJ" & X & ")/100)))/AD" & X & "*9*V" & X & ")"
                    formulaU6 = formulaU6 & "+ABS((BD" & X & "/AD" & X & "*9*V" & X & ")+((BZ" & X & "*((BE" & X & ")/100))/AD" & X & "*9*ZY" & X & "))"
                    formulaU7 = formulaU7 & "+ABS(BF" & X & "/AD" & X & "*9*V" & X & ")"
                    formulaU8 = formulaU8 & "+ABS((BB" & X & "/AD" & X & "*9*V" & X & ")+((BZ" & X & "*((BC" & X & ")/100))/AD" & X & "*9*V" & X & "))"
                End If
            Next
            worksheet.Cells("S5").Formula = formulaS5
            worksheet.Cells("S6").Formula = formulaS6
            worksheet.Cells("U5").Formula = formulaU5
            worksheet.Cells("U6").Formula = formulaU6
            worksheet.Cells("U7").Formula = formulaU7
            worksheet.Cells("U8").Formula = formulaU8
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Too many products to calculate SUPPORT TOTALS in Excel")
        End Try


        '''''FIM SUPPORT TOTALS
        '''''FIM SUPPORT TOTALS
        '''''FIM SUPPORT TOTALS


        '''''INICIO Sales Data Analysis
        '''''INICIO Sales Data Analysis
        '''''INICIO Sales Data Analysis
        Try

            worksheet.Cells("L5").Formula = "=SUM(W24:W" & ultimalinha - 1 & ")"
            worksheet.Cells("L6").Formula = "=SUM(V24:V" & ultimalinha - 1 & ")"
            worksheet.Cells("L7").Formula = "=SUM(Z24:Z" & ultimalinha - 1 & ")"
            worksheet.Cells("L8").Formula = "=SUM(CT24:CT" & ultimalinha - 1 & ")"
            worksheet.Cells("L9").Formula = "=SUM(CU24:CU" & ultimalinha - 1 & ")"

            Dim formulaN5 As String
            formulaN5 = "=(CB24/AD24*9*W24/M18)"
            Dim formulaN6 As String
            formulaN6 = "=(CB24/AD24*9*V24/M18)"
            Dim formulaN7 As String
            formulaN7 = "=(CB24/AD24*9*Z24/M18)"
            Dim formulaN8 As String
            formulaN8 = "=(CB24/AD24*9*CT24/M18)"
            Dim formulaN9 As String
            formulaN9 = "=(CB24/AD24*9*CU24/M18)"

            Dim X As Integer
            For X = 25 To ultimalinha - 1
                If worksheet.Cells("AD" & X).Value <> 0 Then
                    formulaN5 = formulaN5 & "+(CB" & X & "/AD" & X & "*9*W" & X & "/M18)"
                    formulaN6 = formulaN6 & "+(CB" & X & "/AD" & X & "*9*V" & X & "/M18)"
                    formulaN7 = formulaN7 & "+(CB" & X & "/AD" & X & "*9*Z" & X & "/M18)"
                    formulaN8 = formulaN8 & "+(CB" & X & "/AD" & X & "*9*CT" & X & "/M18)"
                    formulaN9 = formulaN9 & "+(CB" & X & "/AD" & X & "*9*CU" & X & "/M18)"
                End If
            Next
            worksheet.Cells("N5").Formula = formulaN5
            worksheet.Cells("N6").Formula = formulaN6
            worksheet.Cells("N7").Formula = formulaN7
            worksheet.Cells("N8").Formula = formulaN8
            worksheet.Cells("N9").Formula = formulaN9
        Catch ex As Exception
            MsgBox("Too many products to calculate SALES DATA ANALYSIS in Excel")
        End Try

        '''''FIM Sales Data Analysis
        '''''FIM Sales Data Analysis
        '''''FIM Sales Data Analysis




        '''''INICIO Pricing Analysis
        '''''INICIO Pricing Analysis
        '''''INICIO Pricing Analysis
        Try
            Dim formulaN14 As String
            'formulaN14 = "(Y24*S24"
            formulaN14 = "(CT24*S24"
            Dim formulaO14 As String
            formulaO14 = "(V24*S24"
            Dim formulaP14 As String
            formulaP14 = "(Z24*S24"


            Dim X As Integer
            For X = 25 To ultimalinha - 1
                'formulaN14 = formulaN14 & "+Y" & X & "*S" & X
                formulaN14 = formulaN14 & "+CT" & X & "*S" & X
                formulaO14 = formulaO14 & "+V" & X & "*S" & X
                formulaP14 = formulaP14 & "+Z" & X & "*S" & X
            Next
            'formulaN14 = formulaN14 & ")/(L7+L8)"
            formulaN14 = formulaN14 & ")/(L8)"
            formulaN14 = "=IF(ISERROR(" & formulaN14 & ");0;" & formulaN14 & ")"


            formulaO14 = formulaO14 & ")/L6"
            formulaO14 = "=IF(ISERROR(" & formulaO14 & ");0;" & formulaO14 & ")"


            formulaP14 = formulaP14 & ")/L7"
            formulaP14 = "=IF(ISERROR(" & formulaP14 & ");0;" & formulaP14 & ")"


            worksheet.Cells("N14").Formula = formulaN14
            worksheet.Cells("O14").Formula = formulaO14
            worksheet.Cells("P14").Formula = formulaP14


        Catch ex As Exception
            MsgBox("Too many products to calculate PRICING ANALYSIS in Excel")
        End Try
        '''''FIM Pricing Analysis
        '''''FIM Pricing Analysis
        '''''FIM Pricing Analysis

        '''''INICIO Notes
        '''''INICIO Notes
        '''''INICIO Notes
        Try
            Dim formulaH13 As String
            formulaH13 = "((BG24/AD24*9*V24)+((BZ24*(BH24/100))/AD24*9*V24))"
            Dim formulaH14 As String
            formulaH14 = "(BM24+BO24+BQ24)/100*BZ24/AD24*9*V24"


            Dim formulaH15 As String
            formulaH15 = "(AR24+AV24+AW24)/AD24*9*V24"
            Dim formulaH16 As String
            formulaH16 = "(AS24+AT24+AU24)/AD24*9*V24"


            Dim X As Integer
            For X = 25 To ultimalinha - 1
                If worksheet.Cells("AD" & X).Value <> 0 Then
                    formulaH13 = formulaH13 & "+((BG" & X & "/AD" & X & "*9*V" & X & ")+((BZ" & X & "*(BH" & X & "/100))/AD" & X & "*9*V" & X & "))"
                    formulaH14 = formulaH14 & "+(BM" & X & "+BO" & X & "+BQ" & X & ")/100*BZ" & X & "/AD" & X & "*9*V" & X & ""

                    formulaH15 = formulaH15 & "+(AR" & X & "+AV" & X & "+AW" & X & ")/AD" & X & "*9*V" & X & ""
                    formulaH16 = formulaH16 & "+(AS" & X & "+AT" & X & "+AU" & X & ")/AD" & X & "*9*V" & X & ""
                End If
            Next
            formulaH13 = "=(" & formulaH13 & ")*M18"
            formulaH14 = "=ABS(" & formulaH14 & ")*M18"
            formulaH15 = "=ABS(" & formulaH15 & ")/M18"
            formulaH16 = "=ABS(" & formulaH16 & ")/M18"


            worksheet.Cells("H13").Formula = formulaH13
            worksheet.Cells("H14").Formula = formulaH14
            worksheet.Cells("H15").Formula = formulaH15
            worksheet.Cells("H16").Formula = formulaH16

        Catch ex As Exception
            MsgBox("Too many products to calculate NOTES in Excel")
        End Try
        '''''FIM Notes
        '''''FIM Notes
        '''''FIM Notes


        'For Each linhaproduto In linhasprodutopai
        '    worksheet.cells(linhaproduto).Borders.SetAllBorders(Color.Red, BorderLineStyle.Double)
        '    'worksheet.cells(linhaproduto)..ColorIndex = 43
        '    worksheet.cells(linhaproduto).Font.Bold = True
        'Next


        'cells.DeleteRow(23 + count)
        worksheet.SetPrintRange(worksheet.Range("A1:Z" & ultimalinha - 1))
        'filterkeycompany = filterkeycomp
        ready = True
        worksheet.Protect("password2", WorksheetProtectionPermissions.FormatColumns)
        myReader1.Close()

        ''''''''''''
        ''''''''''''''
        ''''''''''''''''
        '''''''''''''''
        ''''''''''''''

        spreadsheetControl.Document.DocumentSettings.Calculation.Mode = CalculationMode.Automatic
        workbook.Calculate()
        'spreadsheetControl.Refresh()
        workbook.EndUpdate()
        'worksheet.EnableCalculation = True


        myConnectionPricing.Close()

        '  createPalletes(director, pais, clientfact, clientdest, company, tipo, pricelist, PCDATI, PCDATF, Currency)


        spreadsheetControl.EndUpdate()


    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        fecho = False
        'Using stream As New FileStream("c:\commercialsystem\PricingExcelSAP.xlsx", FileMode.Open)
        Using stream As New FileStream("c:\commercialsystem\PricingExcelSAP.template", FileMode.Open)

            spreadsheetControl.LoadDocument(stream, DocumentFormat.OpenXml)
        End Using
        spreadsheetControl.Options.Import.OpenXml.OverrideCalculationMode = Import.CalculationModeOverride.Manual

        'Access a workbook.
        workbook = spreadsheetControl.Document
        workbook.Options.Culture = New System.Globalization.CultureInfo("pt-PT")

        workbook.Protect("password2", True, True)

        worksheet = workbook.Worksheets(0)

        ' Protect a worksheet. Prevent users from making changes to worksheet elements.
        If Not worksheet.IsProtected Then
            worksheet.Protect("password2", WorksheetProtectionPermissions.FormatColumns)
        End If

        ribbonControl.SelectedPage = ViewRibbonPage1
        ribbonControl.Minimized = True
        worksheet.ActiveView.ShowGridlines = False




    End Sub

    Private Sub Pricing_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim formtrees As New FormTreesPricingUpdate
        formtrees.ShowDialog()


        Cursor.Current = Cursors.WaitCursor
        SplashScreenManager1.ShowForm(Me, GetType(WaitForm1), True, True, False)
        If fecho = True Then
            SplashScreenManager1.CloseForm(False)
            Me.Close()

        Else
            Cursor.Current = Cursors.WaitCursor
            CreatePricing(filterkeyclifact, filterkeyclidest, filterkeycomp, filterkeytipo, filterkeypricelist, filterkeyPCDATI, filterkeyPCDATF, filterkeyCurrency)
            Cursor.Current = Cursors.Default
        End If

        Dim UserControl11 As UserControl1 = New SAP_Pricing.UserControl1()
        Me.DockPanel2_Container.Controls.Add(UserControl11)

        UserControl11.BackColor = System.Drawing.Color.Transparent
        UserControl11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        UserControl11.Dock = System.Windows.Forms.DockStyle.Fill
        UserControl11.Location = New System.Drawing.Point(0, 0)
        UserControl11.Name = "UserControl11"
        UserControl11.Size = New System.Drawing.Size(301, 526)
        UserControl11.TabIndex = 4
        UserControl11.filterkeytipo = filterkeytipo
        UserControl11.filterkeycompany = filterkeycomp

        UserControl11.dados()
        SplashScreenManager1.CloseForm(False)

        Cursor.Current = Cursors.Default
    End Sub


    Public Sub recalcular()
        recalcular(filterkeyclifact, filterkeyclidest, filterkeycomp, filterkeytipo, filterkeypricelist, filterkeyPCDATI, filterkeyPCDATF, filterkeyCurrency)

    End Sub

    Private Sub recalcular(ByVal clientfact As String, ByVal clientdest As String, ByVal company As String, ByVal tipo As String, ByVal pricelist As String, ByVal PCDATI As String, ByVal PCDATF As String, ByVal Currency As String)
        '  Dim varPCDATI = Globals.Sheet1.Range("G6").Value2
        '  Dim varPCDATF = Globals.Sheet1.Range("I6").Value2
        '   Dim tabela = Globals.Sheet1.Range("I5").Value2
        '   Dim clientdest = Globals.Sheet1.Range("D4").Value2
        ''   Dim clientfact = Globals.Sheet1.Range("D12").Value2
        '  Dim pricelist = Globals.Sheet1.Range("G5").Value2.ToString.Substring(0, 1)
        '   Dim currency = Globals.Sheet1.Range("L18").Value2
        Dim rows As RowCollection = worksheet.Rows
        Dim ultimalinha As Integer = rows.LastUsedIndex
        Dim myConnectionPricing As New SQLiteConnection ' OleDb.OleDbConnection
        myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
        myConnectionPricing.Open()

        For Counter = 24 To ultimalinha + 1



            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price

            Dim mySelectQueryREFPrice As String
            mySelectQueryREFPrice = "SELECT kbetr FROM saprefprice where matnr='" & worksheet.Cells("AC" & Counter).Value.ToString & "' and ZZANO='" & worksheet.Cells("D" & Counter).Value.ToString & "' and zzkatr3='" & worksheet.Cells("C18").Value.ToString & "' and datbi >='" & PCDATI & "' and datab <='" & PCDATI & "'"
            Dim myCommandREFPrice As New SQLiteCommand(mySelectQueryREFPrice, myConnectionPricing)
            Dim retREFPrice As Decimal
            retREFPrice = myCommandREFPrice.ExecuteScalar
            worksheet.Cells("T" & Counter).Value = (retREFPrice)



            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price

            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs

            Dim mySelectQueryBOTCOSTMOQ As String
            mySelectQueryBOTCOSTMOQ = "SELECT kbetr FROM sapbotlcost where matnr='" & worksheet.Cells("AC" & Counter).Value.ToString & "' and ZZANO='" & worksheet.Cells("D" & Counter).Value.ToString & "' and datbi >='" & PCDATI & "' and datab <='" & PCDATI & "'"
            Dim myCommandBOTCOSTMOQ As New SQLiteCommand(mySelectQueryBOTCOSTMOQ, myConnectionPricing)
            Dim retBOTCOSTMOQ As Decimal
            retBOTCOSTMOQ = myCommandBOTCOSTMOQ.ExecuteScalar

            worksheet.Cells("BS" & Counter).Value = retBOTCOSTMOQ


            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs


            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus

            Dim mySelectQueryBonus As String
            mySelectQueryBonus = ""
            ''FUSÃO If filterkeyPricing = "933" Then
            If filterkeyPricing = "943" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN953' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & worksheet.Cells("AC" & Counter).Value.ToString & "' and ZZANO='" & worksheet.Cells("D" & Counter).Value.ToString & "'"
                ''FUSÃO  ElseIf filterkeyPricing = "934" Then
            ElseIf filterkeyPricing = "944" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN954' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & worksheet.Cells("AC" & Counter).Value.ToString & "' and ZZANO='" & worksheet.Cells("D" & Counter).Value.ToString & "'"
                ''FUSÃO  ElseIf filterkeyPricing = "936" Then
            ElseIf filterkeyPricing = "946" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN957' and zcldest='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & worksheet.Cells("AC" & Counter).Value.ToString & "' and ZZANO='" & worksheet.Cells("D" & Counter).Value.ToString & "'"

            End If


            Dim myCommandBonus As New SQLiteCommand(mySelectQueryBonus, myConnectionPricing)
            Dim retBonus As SQLiteDataReader
            retBonus = myCommandBonus.ExecuteReader(CommandBehavior.SingleRow)
            'atenção -> kbetr = knrmm = Minimum quantity
            'atenção -> knrnm = Free goods quantity
            'atenção -> knrnm = Additional quantity for free goods

            If retBonus.HasRows Then
                Do While retBonus.Read
                    worksheet.Cells("BT" & Counter).Value = CDec(retBonus(0))
                    worksheet.Cells("BU" & Counter).Value = CDec(retBonus(1))
                    worksheet.Cells("BV" & Counter).Value = CDec(retBonus(2))
                Loop
            Else
                worksheet.Cells("BT" & Counter).Value = Nothing
                worksheet.Cells("BU" & Counter).Value = Nothing
                worksheet.Cells("BV" & Counter).Value = Nothing
            End If


            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus


            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes

            Dim mySelectQueryEstipulaçoes As String = ""
            worksheet.Range("AX" & Counter & ":BR" & Counter).Value = Nothing

            If filterkeyPricing = "936" Then ''''ALEMANHA por CLIENTE ESTATISTICO
                mySelectQueryEstipulaçoes = "SELECT knuma,boart, kschl, kbetr, bonem, vkorgcond FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='clistat' and pltyp ='" & pricelist & "' and datbi >='" & PCDATF & "' and datab <='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & worksheet.Cells("AC" & Counter).Value.ToString & "'"
            Else
                mySelectQueryEstipulaçoes = "SELECT knuma,boart, kschl, kbetr, bonem, vkorgcond FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi >='" & PCDATF & "' and datab <='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & worksheet.Cells("AC" & Counter).Value.ToString & "'"
            End If


            Dim myCommandEstipulaçoes As New SQLiteCommand(mySelectQueryEstipulaçoes, myConnectionPricing)
            Dim retEstipulaçoes As SQLiteDataReader


            retEstipulaçoes = myCommandEstipulaçoes.ExecuteReader
            Dim countcomm = 0

            If retBonus.HasRows Then


                Do While retEstipulaçoes.Read

                    Dim newRow = estipulacaoDataTable.NewRow
                    newRow(0) = retEstipulaçoes("knuma")
                    newRow(1) = retEstipulaçoes("boart")
                    newRow(2) = retEstipulaçoes("bonem")
                    newRow(3) = PCDATI
                    newRow(4) = PCDATF
                    newRow(5) = retEstipulaçoes("kschl")
                    newRow(6) = worksheet.Cells("AC" & Counter).Value.ToString
                    If UCase(retEstipulaçoes("kschl")).ToString.EndsWith("V") Then
                        newRow(7) = retEstipulaçoes("kbetr")
                    Else
                        newRow(7) = retEstipulaçoes("kbetr") / 10
                    End If
                    newRow(8) = worksheet.Cells("BX" & Counter).Value
                    newRow(9) = retEstipulaçoes("vkorgcond")

                    estipulacaoDataTable.Rows.Add(newRow)

                    Dim clientpricesupport As New List(Of String)
                    Dim clientAPsupport As New List(Of String)
                    Dim clientRappel As New List(Of String)
                    Select Case retEstipulaçoes("kschl")
                    ''Price Support
                        Case "YSCV" ' Analysis & Others V
                            worksheet.Cells("BB" & Counter).Value = CDbl(worksheet.Cells("BB" & Counter).Value.ToObject + retEstipulaçoes("kbetr"))
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
                        Case "YSCP" ' Analysis & Others P
                            worksheet.Cells("BC" & Counter).Value = CDbl(worksheet.Cells("BC" & Counter).Value.ToObject + (retEstipulaçoes("kbetr") / 10))
                            clientpricesupport.Add(retEstipulaçoes("bonem"))

                        Case "YSNV" ' Credit note V
                            worksheet.Cells("AX" & Counter).Value = CDbl(worksheet.Cells("AX" & Counter).Value.ToObject + retEstipulaçoes("kbetr"))
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
                        Case "YSNP" ' Credit note P
                            worksheet.Cells("AY" & Counter).Value = CDbl(worksheet.Cells("AY" & Counter).Value.ToObject + (retEstipulaçoes("kbetr") / 10))
                            clientpricesupport.Add(retEstipulaçoes("bonem"))


                        Case "YSHV" ' Charged by customer V
                            worksheet.Cells("AZ" & Counter).Value = CDbl(worksheet.Cells("AZ" & Counter).Value.ToObject + retEstipulaçoes("kbetr"))
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
                        Case "YSHP" ' Charged by customer P
                            worksheet.Cells("BA" & Counter).Value = CDbl(worksheet.Cells("BA" & Counter).Value.ToObject + (retEstipulaçoes("kbetr") / 10))
                            clientpricesupport.Add(retEstipulaçoes("bonem"))

                        ''A&P Support
                        Case "YAPV"
                            worksheet.Cells("BD" & Counter).Value = CDbl(worksheet.Cells("BD" & Counter).Value.ToObject + retEstipulaçoes("kbetr"))
                            clientAPsupport.Add(retEstipulaçoes("bonem"))
                        Case "YAPP"
                            worksheet.Cells("BE" & Counter).Value = CDbl(worksheet.Cells("BE" & Counter).Value.ToObject + (retEstipulaçoes("kbetr") / 10))
                            clientAPsupport.Add(retEstipulaçoes("bonem"))
                        Case "YABV"
                            worksheet.Cells("BF" & Counter).Value = CDbl(CDbl(worksheet.Cells("BF" & Counter).Value.ToObject + retEstipulaçoes("kbetr")))
                            clientAPsupport.Add(retEstipulaçoes("bonem"))

                        ''incentives....
                        Case "YOCM"
                            worksheet.Cells("BG" & Counter).Value = CDbl(worksheet.Cells("BG" & Counter).Value.ToObject + retEstipulaçoes("kbetr"))
                            clientRappel.Add(retEstipulaçoes("bonem"))

                        ''Rappel....
                        Case "YRRV"
                            worksheet.Cells("BI" & Counter).Value = CDbl(worksheet.Cells("BI" & Counter).Value.ToObject + retEstipulaçoes("kbetr"))
                            clientRappel.Add(retEstipulaçoes("bonem"))
                        Case "YRRP"
                            worksheet.Cells("BJ" & Counter).Value = CDbl(worksheet.Cells("BJ" & Counter).Value.ToObject + (retEstipulaçoes("kbetr") / 10))
                            clientRappel.Add(retEstipulaçoes("bonem"))
                        ''Commisions normais
                        Case "YCOP"
                            countcomm = countcomm + 1
                            If countcomm = 1 Then
                                worksheet.Cells("BM" & Counter).Value = CDbl(retEstipulaçoes("kbetr") / 10)
                                worksheet.Cells("BN" & Counter).Value = CDbl(retEstipulaçoes("bonem"))
                            ElseIf countcomm = 2 Then
                                worksheet.Cells("BO" & Counter).Value = CDbl(retEstipulaçoes("kbetr") / 10)
                                worksheet.Cells("BP" & Counter).Value = CDbl(retEstipulaçoes("bonem"))
                            ElseIf countcomm = 3 Then
                                worksheet.Cells("BQ" & Counter).Value = CDbl(retEstipulaçoes("kbetr") / 10)
                                worksheet.Cells("BR" & Counter).Value = CDbl(retEstipulaçoes("bonem"))
                            Else
                                MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                            End If
                        ''Commisions smartwine
                        Case "YEST"
                            countcomm = countcomm + 1
                            If countcomm = 1 Then
                                worksheet.Cells("BM" & Counter).Value = CDbl(retEstipulaçoes("kbetr") / 10)
                                worksheet.Cells("BN" & Counter).Value = CDbl(retEstipulaçoes("bonem"))
                            ElseIf countcomm = 2 Then
                                worksheet.Cells("BO" & Counter).Value = CDbl(retEstipulaçoes("kbetr") / 10)
                                worksheet.Cells("BP" & Counter).Value = CDbl(retEstipulaçoes("bonem"))
                            ElseIf countcomm = 3 Then
                                worksheet.Cells("BQ" & Counter).Value = CDbl(retEstipulaçoes("kbetr") / 10)
                                worksheet.Cells("BR" & Counter).Value = CDbl(retEstipulaçoes("bonem"))
                            Else
                                MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                            End If

                    End Select



                Loop
            End If

            '''''FIM LINHA Estipulaçoes
            '''''FIM LINHA Estipulaçoes
            '''''FIM LINHA Estipulaçoes







        Next
    End Sub


    Private Sub spreadsheetControl_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles spreadsheetControl.PopupMenuShowing
        'If e.MenuType = SpreadsheetMenuType.Cell Then
        ' Remove the "Clear Contents" menu item.
        e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem)

        If e.MenuType = SpreadsheetMenuType.RowHeading And (DirectCast(sender, DevExpress.XtraSpreadsheet.SpreadsheetControl).ActiveCell).RowIndex >= 23 Then

            ' Insert a new item into the Spreadsheet popup menu and handle its click event.
            Dim myItem As New SpreadsheetMenuItem("Apagar Linha", New EventHandler(AddressOf MyClickHandler))
            e.Menu.Items.Add(myItem)

        End If
    End Sub

    Public Sub MyClickHandler(ByVal sender As Object, ByVal e As EventArgs)
        If datasalteradas = True Or TipoListaalterado = True Or clientealterado = True Then
            If MsgBox("Quer apagar esta linha?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                spreadsheetControl.ActiveWorksheet.Rows(spreadsheetControl.ActiveCell.RowIndex).Delete()
                recalcular()
            End If

        Else

            MsgBox("Para apagar preços coloque a zero(0) o mesmo.", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub spreadsheetControl_Leave(sender As Object, e As EventArgs) Handles spreadsheetControl.Leave
        spreadsheetControl.CloseCellEditor(CellEditorEnterValueMode.ActiveCell)
    End Sub
    Public Function SQ(ByVal str As String) As String
        SQ = Replace(str, "'", "''", 1, -1, vbTextCompare)
    End Function



    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonSaveAS.ItemClick
        worksheet.Unprotect("password2")
        spreadsheetControl.SaveDocumentAs()
        worksheet.Protect("password2", WorksheetProtectionPermissions.FormatColumns)
    End Sub

    Private Sub spreadsheetControl_CellEndEdit(sender As Object, e As SpreadsheetCellValidatingEventArgs) Handles spreadsheetControl.CellEndEdit
        e.EditorText = e.EditorText.Replace(".", ",")
    End Sub

    Private Sub spreadsheetControl_CellBeginEdit(sender As Object, e As SpreadsheetCellCancelEventArgs) Handles spreadsheetControl.CellBeginEdit
        If e.Cell.ColumnIndex = 3 Then
            MsgBox("Insira um novo produto, se pretende alterar o ano!", MsgBoxStyle.Exclamation)
            e.Cancel = True
        End If
    End Sub
End Class
