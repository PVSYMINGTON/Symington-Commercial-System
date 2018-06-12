Imports System.Data.OleDb
Imports System.Data.SQLite
Imports Microsoft.VisualStudio.Tools.Applications
Imports Microsoft.VisualStudio.Tools.Applications.Runtime
Imports System.Diagnostics

Public Class UserControl1
    Public inicio As Boolean = True
    Public novatabela As Boolean = True
    Public filterkeycompany As String
    Public filterkeytipo As String
    Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Me.SapMateriais1TableAdapter.Fill(Me.SapPricingDataset1.SapMateriais1)

       

        '
        SapMateriaisBindingSource.Filter = "(wgbez60 = '" & filterkeycompany & "' and Niv3= '" & filterkeytipo & "') or (tipo= 'Dry goods Paletes' and meins= 'EA')"

        '


        TextPriceListType.Properties.Items.Clear()
        Me.SapTipoListaPrecosTableAdapter.Fill(Me.SapPricingDataset1.SapTipoListaPrecos)

        For Each row In Me.SapPricingDataset1.SapTipoListaPrecos
            TextPriceListType.Properties.Items.Add(row(0) & " " & row(1).ToString.TrimEnd)
        Next



    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If CAL_PCDATF.EditValue <= CAL_PCDATI.EditValue Then MsgBox("Datas Erradas") : Exit Sub
        Globals.Sheet1.Unprotect("password2")
        Dim ultimalinha As Integer = Globals.Sheet1.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row

        '''''Datas
        If Mid(Globals.Sheet1.Range("G6").Value2, 1, 4) < Format(CAL_PCDATI.EditValue, "yyyy") Then
            Dim rng As Excel.Range = Globals.Sheet1.Range("F24:F" & ultimalinha)
            rng.Copy(Globals.Sheet1.Range("G24:G" & ultimalinha))
        End If

        Globals.Sheet1.Range("G6").Value2 = Format(CAL_PCDATI.EditValue, "yyyyMMdd")
        Globals.Sheet1.Range("I6").Value2 = Format(CAL_PCDATF.EditValue, "yyyyMMdd")


        recalcular()

        Globals.Sheet1.datasalteradas = True


        Globals.Sheet1.Protect("password2", , , , , True, True, True, , , , , , , , )

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Globals.Sheet1.Unprotect("password2")
        Dim ultimalinha As Integer = Globals.Sheet1.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row
        Try
            If inicio = False Then
                Dim rng As Excel.Range = Globals.Sheet1.Range("A24").EntireRow
                rng.Copy(Globals.Sheet1.Range("A" & ultimalinha + 1).EntireRow)
                Dim rngStatusAftercopy As Excel.Range = Globals.Sheet1.Range("A" & ultimalinha + 1, "BV" & ultimalinha + 1)
                rngStatusAftercopy.Font.Color = System.Drawing.Color.Black

                ' Dim row As DataRowView = SapMateriaisBindingSource.Item(GridLookUpEdit1.Properties.GetIndexByKeyValue(GridLookUpEdit1.EditValue))
                Dim row As DataRowView = GridLookUpEdit1.GetSelectedDataRow
                Globals.Sheet1.Range("A" & ultimalinha + 1).Value2 = (row("MAKTX"))
                Globals.Sheet1.Range("C" & ultimalinha + 1).Value2 = (row("PACKAGE"))
                Globals.Sheet1.Range("AC" & ultimalinha + 1).Value2 = (row("MATNR"))
                Globals.Sheet1.Range("BX" & ultimalinha + 1).Value2 = (row("MEINS"))

                'If IsDBNull(row("MATNRPAI")) Then
                '    Globals.Sheet1.Range("BW" & ultimalinha).Value2 = (row("MATNR"))
                'Else
                '    Globals.Sheet1.Range("BW" & ultimalinha).Value2 = (row("MATNRPAI"))
                'End If

                ''''caixa /bottle

                Dim myConnectionPricing As New SQLiteConnection ' OleDb.OleDbConnection
                myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
                myConnectionPricing.Open()

                Dim mySelectQueryRange As String
                mySelectQueryRange = "SELECT Range FROM SapMateriais where matnr='" & (row("MATNR")) & "'"
                Dim myCommandRange As New SQLiteCommand(mySelectQueryRange, myConnectionPricing)
                Dim retRange As String
                retRange = myCommandRange.ExecuteScalar
                Globals.Sheet1.Range("B" & ultimalinha + 1).Value2 = retRange






                Dim sqlcommand2 As New SQLiteCommand
                sqlcommand2.Connection = myConnectionPricing
                sqlcommand2.CommandText = "SELECT lts FROM SAPEMBALAGENS where ind='" & row("EMBALAGEM") & "'"
                sqlcommand2.CommandType = CommandType.Text
                Dim retEMBALLts = sqlcommand2.ExecuteScalar
                Globals.Sheet1.Range("AD" & ultimalinha + 1).Value2 = (retEMBALLts)

                Dim sqlcommand3 As New SQLiteCommand
                sqlcommand3.Connection = myConnectionPricing
                sqlcommand3.CommandText = "SELECT cap FROM SAPEMBALAGENS where ind='" & row("EMBALAGEM") & "'"
                sqlcommand3.CommandType = CommandType.Text
                Dim retEMBALcap = sqlcommand3.ExecuteScalar
                Try
                    If retEMBALcap <> 0 Then
                        Globals.Sheet1.Range("AE" & ultimalinha + 1).Value2 = (retEMBALLts / retEMBALcap)
                    Else
                        Globals.Sheet1.Range("AE" & ultimalinha + 1).Value2 = "n/a"
                    End If
                Catch
                    Globals.Sheet1.Range("AE" & ultimalinha + 1).Value2 = "n/a"
                End Try

                Globals.Sheet1.Range("E" & ultimalinha + 1).Value2 = ""  '0
                Globals.Sheet1.Range("F" & ultimalinha + 1).Value2 = ""  '0
                Globals.Sheet1.Range("G" & ultimalinha + 1).Value2 = ""  '0
                Globals.Sheet1.Range("T" & ultimalinha + 1).Value2 = ""  '0
                Globals.Sheet1.Range("V" & ultimalinha + 1).Value2 = ""  '0
                Globals.Sheet1.Range("W" & ultimalinha + 1).Value2 = ""  '0
                Globals.Sheet1.Range("Y" & ultimalinha + 1).Value2 = ""  '0
                Globals.Sheet1.Range("Z" & ultimalinha + 1).Value2 = ""  '0
                Globals.Sheet1.Range("AF" & ultimalinha + 1 & ":BV" & ultimalinha + 1).Value2 = ""  '0
                Globals.Sheet1.Range("CT" & ultimalinha + 1 & ":CU" & ultimalinha + 1).Value2 = ""  '0


                Dim varPCDATI = Globals.Sheet1.Range("G6").Value2
                Dim varPCDATF = Globals.Sheet1.Range("I6").Value2
                Dim tabela = Globals.Sheet1.Range("I5").Value2
                Dim clientdest = Globals.Sheet1.Range("D4").Value2
                Dim clientfact = Globals.Sheet1.Range("D12").Value2
                Dim pricelist = Globals.Sheet1.Range("G5").Value2.ToString.Substring(0, 1)
                Dim currency = Globals.Sheet1.Range("L18").Value2

                '''''INICIO LINHA Reference Price
                '''''INICIO LINHA Reference Price
                '''''INICIO LINHA Reference Price

                Dim mySelectQueryREFPrice As String
                mySelectQueryREFPrice = "SELECT kbetr FROM saprefprice where matnr='" & (row("MATNR")) & "' and zzkatr3='" & Globals.Sheet1.Range("C18").Value2 & "' and datbi >='" & varPCDATI & "' and datab <='" & varPCDATI & "'"
                Dim myCommandREFPrice As New SQLiteCommand(mySelectQueryREFPrice, myConnectionPricing)
                Dim retREFPrice As String
                retREFPrice = myCommandREFPrice.ExecuteScalar
                Globals.Sheet1.Range("T" & ultimalinha + 1).Value2 = CDbl(retREFPrice)


                '''''FIM LINHA Reference Price
                '''''FIM LINHA Reference Price
                '''''FIM LINHA Reference Price


                '''''INICIO LINHA Bootling Costs
                '''''INICIO LINHA Bootling Costs
                '''''INICIO LINHA Bootling Costs

                Dim mySelectQueryBOTCOSTMOQ As String
                mySelectQueryBOTCOSTMOQ = "SELECT kbetr FROM sapbotlcost where matnr='" & row("MATNR") & "' and datbi >='" & varPCDATI & "' and datab <='" & varPCDATI & "'"
                Dim myCommandBOTCOSTMOQ As New SQLiteCommand(mySelectQueryBOTCOSTMOQ, myConnectionPricing)
                Dim retBOTCOSTMOQ As Decimal
                retBOTCOSTMOQ = myCommandBOTCOSTMOQ.ExecuteScalar
                Globals.Sheet1.Range("BS" & ultimalinha + 1).Value2 = retBOTCOSTMOQ


                '''''FIM LINHA Bootling Costs
                '''''FIM LINHA Bootling Costs
                '''''FIM LINHA Bootling Costs



                '''''INICIO LINHA Bonus
                '''''INICIO LINHA Bonus
                '''''INICIO LINHA Bonus

                Dim mySelectQueryBonus As String
                mySelectQueryBonus = ""
                If tabela = "931" Then
                    mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
                ElseIf tabela = "933" Then
                    mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
                ElseIf tabela = "932" Then
                    mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
                ElseIf tabela = "934" Then
                    mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
                ElseIf tabela = "935" Then
                    mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
                ElseIf tabela = "936" Then
                    mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and zcldest='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"
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
                        Globals.Sheet1.Range("BT" & ultimalinha + 1).Value2 = retBonus(0)
                        Globals.Sheet1.Range("BU" & ultimalinha + 1).Value2 = retBonus(1)
                        Globals.Sheet1.Range("BV" & ultimalinha + 1).Value2 = retBonus(2)
                    Loop
                Else
                    Globals.Sheet1.Range("BT" & ultimalinha + 1).Value2 = ""
                    Globals.Sheet1.Range("BU" & ultimalinha + 1).Value2 = ""
                    Globals.Sheet1.Range("BV" & ultimalinha + 1).Value2 = ""
                End If


                '''''FIM LINHA Bonus
                '''''FIM LINHA Bonus
                '''''FIM LINHA Bonus


                '''''INICIO LINHA Estipulaçoes
                '''''INICIO LINHA Estipulaçoes
                '''''INICIO LINHA Estipulaçoes

                Dim mySelectQueryEstipulaçoes As String
                mySelectQueryEstipulaçoes = ""
                mySelectQueryEstipulaçoes = "SELECT kschl, kbetr, bonem FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "'"


                Dim myCommandEstipulaçoes As New SQLiteCommand(mySelectQueryEstipulaçoes, myConnectionPricing)
                Dim retEstipulaçoes As SQLiteDataReader


                retEstipulaçoes = myCommandEstipulaçoes.ExecuteReader
                Dim countcomm = 0
                Do While retEstipulaçoes.Read

                    Dim clientpricesupport As New List(Of String)
                    Dim clientAPsupport As New List(Of String)
                    Dim clientRappel As New List(Of String)
                    Select Case retEstipulaçoes("kschl")
                        ''Price Support
                        Case "YSCV" ' Analysis & Others V
                            Globals.Sheet1.Range("BB" & ultimalinha + 1).Value2 = Globals.Sheet1.Range("BB" & ultimalinha + 1).Value2 + retEstipulaçoes("kbetr")
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
                        Case "YSCP" ' Analysis & Others P
                            Globals.Sheet1.Range("BC" & ultimalinha + 1).Value2 = Globals.Sheet1.Range("BC" & ultimalinha + 1).Value2 + (retEstipulaçoes("kbetr") / 10)
                            clientpricesupport.Add(retEstipulaçoes("bonem"))


                        Case "YSNV" ' Credit note V
                            Globals.Sheet1.Range("AX" & ultimalinha + 1).Value2 = Globals.Sheet1.Range("AX" & ultimalinha + 1).Value2 + retEstipulaçoes("kbetr")
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
                        Case "YSNP" ' Credit note P
                            Globals.Sheet1.Range("AY" & ultimalinha + 1).Value2 = Globals.Sheet1.Range("AY" & ultimalinha + 1).Value2 + (retEstipulaçoes("kbetr") / 10)
                            clientpricesupport.Add(retEstipulaçoes("bonem"))



                        Case "YSHV" ' Charged by customer V
                            Globals.Sheet1.Range("AZ" & ultimalinha + 1).Value2 = Globals.Sheet1.Range("AZ" & ultimalinha + 1).Value2 + retEstipulaçoes("kbetr")
                            clientpricesupport.Add(retEstipulaçoes("bonem"))
                        Case "YSHP" ' Charged by customer P
                            Globals.Sheet1.Range("BA" & ultimalinha + 1).Value2 = Globals.Sheet1.Range("BA" & ultimalinha + 1).Value2 + (retEstipulaçoes("kbetr") / 10)
                            clientpricesupport.Add(retEstipulaçoes("bonem"))

                            ''A&P Support
                        Case "YAPV"
                            Globals.Sheet1.Range("BD" & ultimalinha + 1).Value2 = Globals.Sheet1.Range("BD" & ultimalinha + 1).Value2 + retEstipulaçoes("kbetr")
                            clientAPsupport.Add(retEstipulaçoes("bonem"))
                        Case "YAPP"
                            Globals.Sheet1.Range("BE" & ultimalinha + 1).Value2 = Globals.Sheet1.Range("BE" & ultimalinha + 1).Value2 + (retEstipulaçoes("kbetr") / 10)
                            clientAPsupport.Add(retEstipulaçoes("bonem"))
                        Case "YABV"
                            Globals.Sheet1.Range("BF" & ultimalinha + 1).Value2 = Globals.Sheet1.Range("BF" & ultimalinha + 1).Value2 + retEstipulaçoes("kbetr")
                            clientAPsupport.Add(retEstipulaçoes("bonem"))

                            ''incentives....
                        Case "YOCM"
                            Globals.Sheet1.Range("BI" & ultimalinha + 1).Value2 = Globals.Sheet1.Range("BI" & ultimalinha + 1).Value2 + retEstipulaçoes("kbetr")
                            clientRappel.Add(retEstipulaçoes("bonem"))

                            ''Rappel....
                        Case "YRRV"
                            Globals.Sheet1.Range("BI" & ultimalinha + 1).Value2 = Globals.Sheet1.Range("BI" & ultimalinha + 1).Value2 + retEstipulaçoes("kbetr")
                            clientRappel.Add(retEstipulaçoes("bonem"))
                        Case "YRRP"
                            Globals.Sheet1.Range("BJ" & ultimalinha + 1).Value2 = Globals.Sheet1.Range("BJ" & ultimalinha + 1).Value2 + (retEstipulaçoes("kbetr") / 10)
                            clientRappel.Add(retEstipulaçoes("bonem"))

                            ''Commisions
                        Case "YCOP"
                            countcomm = countcomm + 1
                            If countcomm = 1 Then
                                Globals.Sheet1.Range("BM" & ultimalinha + 1).Value2 = retEstipulaçoes("kbetr") / 10
                                Globals.Sheet1.Range("BN" & ultimalinha + 1).Value2 = retEstipulaçoes("bonem")
                            ElseIf countcomm = 2 Then
                                Globals.Sheet1.Range("BO" & ultimalinha + 1).Value2 = retEstipulaçoes("kbetr") / 10
                                Globals.Sheet1.Range("BP" & ultimalinha + 1).Value2 = retEstipulaçoes("bonem")
                            ElseIf countcomm = 3 Then
                                Globals.Sheet1.Range("BQ" & ultimalinha + 1).Value2 = retEstipulaçoes("kbetr") / 10
                                Globals.Sheet1.Range("BR" & ultimalinha + 1).Value2 = retEstipulaçoes("bonem")
                            Else
                                MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                            End If
                        Case "YEST"
                            countcomm = countcomm + 1
                            If countcomm = 1 Then
                                Globals.Sheet1.Range("BM" & ultimalinha + 1).Value2 = retEstipulaçoes("kbetr") / 10
                                Globals.Sheet1.Range("BN" & ultimalinha + 1).Value2 = retEstipulaçoes("bonem")
                            ElseIf countcomm = 2 Then
                                Globals.Sheet1.Range("BO" & ultimalinha + 1).Value2 = retEstipulaçoes("kbetr") / 10
                                Globals.Sheet1.Range("BP" & ultimalinha + 1).Value2 = retEstipulaçoes("bonem")
                            ElseIf countcomm = 3 Then
                                Globals.Sheet1.Range("BQ" & ultimalinha + 1).Value2 = retEstipulaçoes("kbetr") / 10
                                Globals.Sheet1.Range("BR" & ultimalinha + 1).Value2 = retEstipulaçoes("bonem")
                            Else
                                MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                            End If

                    End Select

                    'Dim distinctNamesclientpricesupport = clientpricesupport.Distinct()
                    'Dim distinctNamesclientpricesupportitem As String
                    'For Each distinctNamesclientpricesupportitem In distinctNamesclientpricesupport
                    '    Dim stringps = ""
                    '    stringps = stringps & distinctNamesclientpricesupportitem & " - "
                    '    Globals.Sheet1.Range("BC" & ultimalinha + 1).Value2 = stringps.Trim(" - ")
                    'Next
                    'Dim distinctNamesclientAPsupport = clientAPsupport.Distinct()
                    'Dim distinctNamesclientAPsupportitem As String
                    'For Each distinctNamesclientAPsupportitem In distinctNamesclientAPsupport
                    '    Dim stringAP = ""
                    '    stringAP = stringAP & distinctNamesclientAPsupportitem & " - "
                    '    Globals.Sheet1.Range("BH" & ultimalinha + 1).Value2 = stringAP.Trim(" - ")
                    'Next
                    'Dim distinctNamesclientrappel = clientRappel.Distinct()
                    'Dim distinctNamesclientrappelitem As String
                    'For Each distinctNamesclientrappelitem In distinctNamesclientrappel
                    '    Dim stringR = ""
                    '    stringR = stringR & distinctNamesclientrappelitem & " - "
                    '    Globals.Sheet1.Range("BL" & ultimalinha + 1).Value2 = stringR.Trim(" - ")
                    'Next

                Loop
                myConnectionPricing.Close()

                '''''FIM LINHA Estipulaçoes
                '''''FIM LINHA Estipulaçoes
                '''''FIM LINHA Estipulaçoes







                Try
                    Globals.Sheet1.Range("S" & ultimalinha + 1).GoalSeek(Globals.Sheet1.Range("T" & ultimalinha + 1), Globals.Sheet1.Range("F" & ultimalinha + 1))
                Catch
                End Try


            Else
                'Dim row As DataRowView = PAPRECFBindingSource.Item(GridLookUpEdit1.Properties.GetIndexByKeyValue(GridLookUpEdit1.EditValue))
                'Globals.Sheet1.Range("A" & ultimalinha).Value2 = (row("Descri"))
                'Globals.Sheet1.Range("B" & ultimalinha).Value2 = (row("MQACOL"))
                'Globals.Sheet1.Range("C" & ultimalinha).Value2 = (row("Embal"))
                'Globals.Sheet1.Range("AC" & ultimalinha).Value2 = (row("CODPRO"))
                'Globals.Sheet1.Range("F" & ultimalinha).Value2 = 0
            End If
            inicio = False
        Catch ex As Exception
            MsgBox("Erro!")
        End Try
        Globals.Sheet1.Protect("password2", , , , , True, True, True, , , , , , , , )
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If Globals.Sheet1.Range("D4").Value2 = "999991" Or Globals.Sheet1.Range("D4").Value2 = "999990" Then
            If Not UserNameWindows() = "HS" Then
                MsgBox("Não pode alterar!", MsgBoxStyle.Information, "Erro!")
                Exit Sub
            End If
        End If

        If Globals.Sheet1.bonusalterados = True Then
            Globals.Sheet1.Unprotect("password2")
            Dim varBT As Boolean
            Dim varBU As Boolean
            Dim varBV As Boolean
            Dim Last_Real_Populated_Row As Integer = Globals.Sheet1.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row
            For Counter = 24 To Last_Real_Populated_Row
                varBT = IsNumeric(Globals.Sheet1.Range("BT" & Counter).Value2)
                varBU = IsNumeric(Globals.Sheet1.Range("BU" & Counter).Value2)
                varBV = IsNumeric(Globals.Sheet1.Range("BV" & Counter).Value2)
                If Not (varBT = True And varBU = True And varBV = True) Then
                    If Not (varBT = False And varBU = False And varBV = False) Then
                        MsgBox("Preencha todos os campos de Bónus", MsgBoxStyle.Critical)
                        Globals.Sheet1.Protect("password2", , , , , True, True, True, , , , , , , , )
                        Exit Sub
                    End If
                End If
            Next

        End If


        If Globals.Sheet1.bonusalterados = True And Globals.Sheet1.datasalteradas = True Then
            Dim responsebonus As MsgBoxResult
            responsebonus = MsgBox("Alterou os Bónus de Quantidade e a Datas de Validade. Poderá perder os dados de Bónus anteriores se as datas de validade se sobreporem!! Têm a certeza?", MsgBoxStyle.YesNo, "Gravar dados.")
            If responsebonus = MsgBoxResult.No Then Exit Sub
        ElseIf Globals.Sheet1.bonusalterados = True And Globals.Sheet1.datasalteradas = False Then
            Dim responsebonus2 As MsgBoxResult
            responsebonus2 = MsgBox("Vai alterar os Bónus de Quantidade. Têm a certeza?", MsgBoxStyle.YesNo, "Gravar dados.")
            If responsebonus2 = MsgBoxResult.No Then Exit Sub
        Else
            Dim response As MsgBoxResult
            response = MsgBox("Têm a certeza?", MsgBoxStyle.YesNo, "Gravar dados.")
            If response = MsgBoxResult.No Then Exit Sub
        End If

        Globals.Sheet1.Unprotect("password2")
        Dim ret As String
        ret = getsavepricing()


        Dim dvaluecheck = From row In Globals.ThisWorkbook.estipulacaoDataTable.AsEnumerable()
      Where Not row.Field(Of String)("Operacao") = ""
        If dvaluecheck.Count > 0 Then insertmdbEst()


        insertmdb(ret)
        Globals.Sheet1.Protect("password2", , , , , True, True, True, , , , , , , , )
    End Sub


    Sub insertmdb(ByVal ret As String)
        'Open access-database connection
        Dim cnn As New SQLiteConnection ' OleDbConnection
        Dim transaction As SQLiteTransaction ' OleDbTransaction

        cnn.ConnectionString = "data source=c:\CommercialSystem\dados\SapPricingupdate.db3"
        cnn.Open()
        Dim Last_Real_Populated_Row As Integer = Globals.Sheet1.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row
        transaction = cnn.BeginTransaction
        Dim sqlcommand As New SQLiteCommand ' OleDbCommand
        sqlcommand.Connection = cnn
        sqlcommand.Transaction = transaction


        For Counter = 24 To Last_Real_Populated_Row



            If Globals.Sheet1.Range("I5").Value2 = "931" Or Globals.Sheet1.Range("I5").Value2 = "932" Then 'se for tabela de produto composto
                If Globals.Sheet1.Range(("BW" & Counter)).Value2 = "" Then 'se for a linha do produto pai
                    Counter = Counter + 1 ' passa a linha segumite
                End If
            End If




            sqlcommand.CommandText = "INSERT INTO paprixf " _
            & "(PCCCLI, PCCLID, PCCLIE, PCCPRO, PCCPRP, PCVERS, PCTPRE, PCPVAC, PCPIVA, PCACOL, PCMOED, " _
            & "PCDATI, PCDATF, PCPVAA, ZDEV, ZDEP, ZDQV, ZDQP, ZDPV, ZDPP, ZDRV, ZDRP, " _
            & "ZDLV, ZDLP, ZDTV, ZDTP, ZEEC, ZEFR, ZEIN, ZEFI, ZESL, ZESP, KNRMM, KNRNM, KNRZM, " _
            & "PCCSIT, PCUSER, TABELA, vrkme)" _
            & " VALUES(" _
            & "@paramPCCCLI,@paramPCCLID,@paramPCCLIE,@paramPCCPRO,@paramPCCPRP,@paramPCVERS,@paramPCTPRE,@paramPCPVAC,@paramPCPIVA,@paramPCACOL,@paramPCMOED," _
            & "@paramPCDATI,@paramPCDATF,@paramPCPVAA,@paramZDEV,@paramZDEP,@paramZDQV,@paramZDQP,@paramZDPV,@paramZDPP,@paramZDRV,@paramZDRP," _
            & "@paramZDLV,@paramZDLP,@paramZDTV,@paramZDTP,@paramZEEC,@paramZEFR,@paramZEIN,@paramZEFI,@paramZESL,@paramZESP,@paramKNRMM,@paramKNRNM,@paramKNRZM," _
            & "@paramPCCSIT,@paramPCUSER,@paramTabela,@paramvrkme)"


            sqlcommand.Parameters.Add("@paramPCCCLI", DbType.String)
            sqlcommand.Parameters.Add("@paramPCCLID", DbType.String)
            sqlcommand.Parameters.Add("@paramPCCLIE", DbType.String)
            sqlcommand.Parameters.Add("@paramPCCPRO", DbType.String)
            sqlcommand.Parameters.Add("@paramPCCPRP", DbType.String)
            sqlcommand.Parameters.Add("@paramPCVERS", DbType.String)
            sqlcommand.Parameters.Add("@paramPCTPRE", DbType.String)
            sqlcommand.Parameters.Add("@paramPCPVAC", DbType.Double)
            sqlcommand.Parameters.Add("@paramPCPIVA", DbType.VarNumeric)
            sqlcommand.Parameters.Add("@paramPCACOL", DbType.VarNumeric)
            sqlcommand.Parameters.Add("@paramPCMOED", DbType.String)

            sqlcommand.Parameters.Add("@paramPCDATI", DbType.VarNumeric)
            sqlcommand.Parameters.Add("@paramPCDATF", DbType.VarNumeric)
            sqlcommand.Parameters.Add("@paramPCPVAA", DbType.Double)
            sqlcommand.Parameters.Add("@paramZDEV", DbType.Double)
            sqlcommand.Parameters.Add("@paramZDEP", DbType.Double)
            sqlcommand.Parameters.Add("@paramZDQV", DbType.Double)
            sqlcommand.Parameters.Add("@paramZDQP", DbType.Double)
            sqlcommand.Parameters.Add("@paramZDPV", DbType.Double)
            sqlcommand.Parameters.Add("@paramZDPP", DbType.Double)
            sqlcommand.Parameters.Add("@paramZDRV", DbType.Double)
            sqlcommand.Parameters.Add("@paramZDRP", DbType.Double)

            sqlcommand.Parameters.Add("@paramZDLV", DbType.Double)
            sqlcommand.Parameters.Add("@paramZDLP", DbType.Double)
            sqlcommand.Parameters.Add("@paramZDTV", DbType.Double)
            sqlcommand.Parameters.Add("@paramZDTP", DbType.Double)
            sqlcommand.Parameters.Add("@paramZEEC", DbType.Double)
            sqlcommand.Parameters.Add("@paramZEFR", DbType.Double)
            sqlcommand.Parameters.Add("@paramZEIN", DbType.Double)
            sqlcommand.Parameters.Add("@paramZEFI", DbType.Double)
            sqlcommand.Parameters.Add("@paramZESL", DbType.Double)
            sqlcommand.Parameters.Add("@paramZESP", DbType.Double)

            sqlcommand.Parameters.Add("@paramKNRMM", DbType.Double)
            sqlcommand.Parameters.Add("@paramKNRNM", DbType.Double)
            sqlcommand.Parameters.Add("@paramKNRZM", DbType.Double)

            sqlcommand.Parameters.Add("@paramPCCSIT", DbType.String)
            sqlcommand.Parameters.Add("@paramPCUSER", DbType.String)
            sqlcommand.Parameters.Add("@paramTabela", DbType.String)
            sqlcommand.Parameters.Add("@paramvrkme", DbType.String)


            sqlcommand.Parameters("@paramPCCCLI").Value = Globals.Sheet1.Range("D12").Value2
            sqlcommand.Parameters("@paramPCCLID").Value = Globals.Sheet1.Range("D4").Value2
            sqlcommand.Parameters("@paramPCCLIE").Value = Globals.Sheet1.Range("D11").Value2
            sqlcommand.Parameters("@paramPCCPRO").Value = Globals.Sheet1.Range(("AC" & Counter)).Value2
            sqlcommand.Parameters("@paramPCCPRP").Value = Globals.Sheet1.Range(("BW" & Counter)).Value2

            If novatabela = True Then
                sqlcommand.Parameters("@paramPCVERS").Value = 1
            Else
                sqlcommand.Parameters("@paramPCVERS").Value = Globals.Sheet1.Range("I5").Value2
            End If
            sqlcommand.Parameters("@paramPCTPRE").Value = Globals.Sheet1.Range("G5").Value2.ToString.Chars(0).ToString
            sqlcommand.Parameters("@paramPCPVAC").Value = Globals.Sheet1.Range(("F" & Counter)).Value2
            sqlcommand.Parameters("@paramPCPIVA").Value = Globals.Sheet1.Range(("AE" & Counter)).Value2
            sqlcommand.Parameters("@paramPCACOL").Value = Globals.Sheet1.Range(("AB" & Counter)).Value2
            sqlcommand.Parameters("@paramPCMOED").Value = Globals.Sheet1.Range("L18").Value2

            sqlcommand.Parameters("@paramPCDATI").Value = Globals.Sheet1.Range("G6").Value2
            sqlcommand.Parameters("@paramPCDATF").Value = Globals.Sheet1.Range("I6").Value2
            sqlcommand.Parameters("@paramPCPVAA").Value = Globals.Sheet1.Range(("G" & Counter)).Value2


            sqlcommand.Parameters("@paramZDEV").Value = Globals.Sheet1.Range(("AF" & Counter)).Value2
            sqlcommand.Parameters("@paramZDEP").Value = IIf(Globals.Sheet1.Range(("AG" & Counter)).Value2 Is Nothing, Nothing, Globals.Sheet1.Range(("AG" & Counter)).Value2 * 10)

            sqlcommand.Parameters("@paramZDQV").Value = Globals.Sheet1.Range(("AH" & Counter)).Value2
            sqlcommand.Parameters("@paramZDQP").Value = IIf(Globals.Sheet1.Range(("AI" & Counter)).Value2 Is Nothing, Nothing, Globals.Sheet1.Range(("AI" & Counter)).Value2 * 10)

            sqlcommand.Parameters("@paramZDPV").Value = Globals.Sheet1.Range(("AJ" & Counter)).Value2
            sqlcommand.Parameters("@paramZDPP").Value = IIf(Globals.Sheet1.Range(("AK" & Counter)).Value2 Is Nothing, Nothing, Globals.Sheet1.Range(("AK" & Counter)).Value2 * 10)

            sqlcommand.Parameters("@paramZDRV").Value = Globals.Sheet1.Range(("AL" & Counter)).Value2
            sqlcommand.Parameters("@paramZDRP").Value = IIf(Globals.Sheet1.Range(("AM" & Counter)).Value2 Is Nothing, Nothing, Globals.Sheet1.Range(("AM" & Counter)).Value2 * 10)

            sqlcommand.Parameters("@paramZDLV").Value = Globals.Sheet1.Range(("AN" & Counter)).Value2
            sqlcommand.Parameters("@paramZDLP").Value = IIf(Globals.Sheet1.Range(("AO" & Counter)).Value2 Is Nothing, Nothing, Globals.Sheet1.Range(("AO" & Counter)).Value2 * 10)

            sqlcommand.Parameters("@paramZDTV").Value = Globals.Sheet1.Range(("AP" & Counter)).Value2
            sqlcommand.Parameters("@paramZDTP").Value = IIf(Globals.Sheet1.Range(("AQ" & Counter)).Value2 Is Nothing, Nothing, Globals.Sheet1.Range(("AQ" & Counter)).Value2 * 10)


            sqlcommand.Parameters("@paramZEEC").Value = Globals.Sheet1.Range(("AR" & Counter)).Value2
            sqlcommand.Parameters("@paramZEFR").Value = Globals.Sheet1.Range(("AS" & Counter)).Value2
            sqlcommand.Parameters("@paramZEIN").Value = Globals.Sheet1.Range(("AT" & Counter)).Value2
            sqlcommand.Parameters("@paramZEFI").Value = Globals.Sheet1.Range(("AU" & Counter)).Value2
            sqlcommand.Parameters("@paramZESL").Value = Globals.Sheet1.Range(("AV" & Counter)).Value2
            sqlcommand.Parameters("@paramZESP").Value = Globals.Sheet1.Range(("AW" & Counter)).Value2

            sqlcommand.Parameters("@paramKNRMM").Value = Globals.Sheet1.Range(("BT" & Counter)).Value2
            sqlcommand.Parameters("@paramKNRNM").Value = Globals.Sheet1.Range(("BU" & Counter)).Value2
            sqlcommand.Parameters("@paramKNRZM").Value = Globals.Sheet1.Range(("BV" & Counter)).Value2



            sqlcommand.Parameters("@paramPCCSIT").Value = "*" ' PCCSIT
            sqlcommand.Parameters("@paramPCUSER").Value = ret ' PCUSER
            sqlcommand.Parameters("@paramTabela").Value = Globals.Sheet1.Range("I5").Value2.ToString.Trim("A")  'tabela
            sqlcommand.Parameters("@paramvrkme").Value = Globals.Sheet1.Range(("BX" & Counter)).Value2 ' VRKME

            Try
                sqlcommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                transaction.Rollback()
                Exit Sub
            End Try


        Next


        transaction.Commit()
        cnn.Close()
        cnn = Nothing
        savepricing(ret)
        MsgBox("OK. Preços gravados localmente.")
        Globals.ThisWorkbook.Close(False)





        'Close connections



    End Sub

    Sub insertmdbEst()
        'Open access-database connection
        Dim cnn As New SQLiteConnection ' OleDbConnection
        Dim transaction As SQLiteTransaction ' OleDbTransaction

        cnn.ConnectionString = "data source=c:\CommercialSystem\dados\SapPricingupdate.db3"
        cnn.Open()
        transaction = cnn.BeginTransaction
        Dim sqlcommand As New SQLiteCommand ' OleDbCommand
        sqlcommand.Connection = cnn
        sqlcommand.Transaction = transaction

        Dim dvalue = From row In Globals.ThisWorkbook.estipulacaoDataTable.AsEnumerable()
        Where Not row.Field(Of String)("Operacao") = ""
        Dim countcomm = 0

        For Each m In dvalue

            sqlcommand.CommandText = "INSERT INTO SapEstipulacoes" _
                         & " (KNUMA, BUKRS, VKORG, VTWEG, SPART, BOART, ERDAT," _
                         & " AEDAT, AEZET, BONEM, KONADATAB, KONADATBI, BOSTA, kschl," _
                         & " kunnr, zcldest, waerk, matnr, pltyp, datbi, datab, knumh," _
                         & " kbetr, kmein, Operacao)" _
                         & " VALUES " _
                         & "(@paramKNUMA,@paramBUKRS,@paramVKORG,@paramVTWEG,@paramSPART,@paramBOART,@paramERDAT," _
                         & "@paramAEDAT,@paramAEZET,@paramBONEM,@paramKONADATAB,@paramKONADATBI,@paramBOSTA,@paramkschl," _
                         & "@paramkunnr,@paramzcldest,@paramwaerk,@parammatnr,@parampltyp,@paramdatbi,@paramdatab,@paramknumh," _
                         & "@paramkbetr,@paramkmein,@paramOperacao)"

            sqlcommand.Parameters.Add("@paramKNUMA", DbType.String)
            sqlcommand.Parameters.Add("@paramBUKRS", DbType.String)
            sqlcommand.Parameters.Add("@paramVKORG", DbType.String)
            sqlcommand.Parameters.Add("@paramVTWEG", DbType.String)
            sqlcommand.Parameters.Add("@paramSPART", DbType.String)
            sqlcommand.Parameters.Add("@paramBOART", DbType.String)
            sqlcommand.Parameters.Add("@paramERDAT", DbType.String)
            sqlcommand.Parameters.Add("@paramAEDAT", DbType.String)
            sqlcommand.Parameters.Add("@paramAEZET", DbType.String)
            sqlcommand.Parameters.Add("@paramBONEM", DbType.String)
            sqlcommand.Parameters.Add("@paramKONADATAB", DbType.String)
            sqlcommand.Parameters.Add("@paramKONADATBI", DbType.String)
            sqlcommand.Parameters.Add("@paramBOSTA", DbType.String)
            sqlcommand.Parameters.Add("@paramkschl", DbType.String)
            sqlcommand.Parameters.Add("@paramkunnr", DbType.String)
            sqlcommand.Parameters.Add("@paramzcldest", DbType.String)
            sqlcommand.Parameters.Add("@paramwaerk", DbType.String)
            sqlcommand.Parameters.Add("@parammatnr", DbType.String)
            sqlcommand.Parameters.Add("@parampltyp", DbType.String)
            sqlcommand.Parameters.Add("@paramdatbi", DbType.String)
            sqlcommand.Parameters.Add("@paramdatab", DbType.String)
            sqlcommand.Parameters.Add("@paramknumh", DbType.String)
            sqlcommand.Parameters.Add("@paramkbetr", DbType.Double)
            sqlcommand.Parameters.Add("@paramkmein", DbType.String)

            sqlcommand.Parameters.Add("@paramOperacao", DbType.String)


            sqlcommand.Parameters("@paramKNUMA").Value = m(0)
            sqlcommand.Parameters("@paramBUKRS").Value = ""
            sqlcommand.Parameters("@paramVKORG").Value = m(9)    ' @paramvkorgcond
            sqlcommand.Parameters("@paramVTWEG").Value = ""
            sqlcommand.Parameters("@paramSPART").Value = ""
            sqlcommand.Parameters("@paramBOART").Value = m(1)
            sqlcommand.Parameters("@paramERDAT").Value = ""
            sqlcommand.Parameters("@paramAEDAT").Value = ""
            sqlcommand.Parameters("@paramAEZET").Value = ""
            sqlcommand.Parameters("@paramBONEM").Value = m(2)
            sqlcommand.Parameters("@paramKONADATAB").Value = m(3)
            sqlcommand.Parameters("@paramKONADATBI").Value = m(4)
            sqlcommand.Parameters("@paramBOSTA").Value = ""
            sqlcommand.Parameters("@paramkschl").Value = m(5)
            sqlcommand.Parameters("@paramkunnr").Value = Globals.Sheet1.Range("D12").Value2
            sqlcommand.Parameters("@paramzcldest").Value = Globals.Sheet1.Range("D4").Value2
            sqlcommand.Parameters("@paramwaerk").Value = Globals.Sheet1.Range("L18").Value2
            sqlcommand.Parameters("@parammatnr").Value = m(6)
            sqlcommand.Parameters("@parampltyp").Value = Globals.Sheet1.Range("G5").Value2.ToString.Chars(0).ToString
            sqlcommand.Parameters("@paramdatab").Value = m(3)
            sqlcommand.Parameters("@paramdatbi").Value = m(4)
            sqlcommand.Parameters("@paramknumh").Value = ""

            sqlcommand.Parameters("@paramkbetr").Value = m(7) '''' VALOR % ou € ??????
           
            sqlcommand.Parameters("@paramkmein").Value = m(8)

            sqlcommand.Parameters("@paramOperacao").Value = m(10)


            Try
                sqlcommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                transaction.Rollback()
                Exit Sub
            End Try


        Next


        transaction.Commit()
        cnn.Close()
        cnn = Nothing

        MsgBox("OK. Estipulaçoes gravadas localmente.")





        'Close connections



    End Sub




    Public Function getsavepricing()
        getsavepricing = "c:\CommercialSystem\dados\PricingExcel\pricing" & DatePart("yyyy", Now) & "_" & DatePart("y", Now) & "_" & DatePart("h", Now) & "_" & DatePart("n", Now) & "_" & DatePart("s", Now) & UserNameWindows() & ".XLSX"

    End Function
    Public Sub savepricing(ByVal nome)

        My.Computer.FileSystem.CreateDirectory("c:\CommercialSystem\dados\PricingExcel")
        My.Computer.FileSystem.CurrentDirectory = "c:\CommercialSystem\dados\PricingExcel"
        Globals.ThisWorkbook.ActionsPane.Clear()
        'Globals.ThisWorkbook.RemoveCustomization()
        Globals.ThisWorkbook.possogravar = True
        'Globals.ThisWorkbook.SaveAs(nome, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel12, "", "password2")
        '  Globals.ThisWorkbook.SaveAs(nome, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel12)


   
            Try
                Globals.ThisWorkbook.SaveCopyAs(nome)
                If (ServerDocument.IsCustomized(nome)) Then
                    ServerDocument.RemoveCustomization(nome)
                End If

                Dim newWB As Excel.Workbook
                Dim excelApp As Excel.Application = Globals.ThisWorkbook.Application

                newWB = excelApp.Workbooks.Open(nome, AddToMru:=False)



                'Scrub storage controls and VBA project reference.
                Dim ws As Excel.Worksheet
                Dim index As Integer

                For Each ws In newWB.Worksheets
                    For index = 1 To ws.Shapes.Count
                        If ws.Shapes.Item(index).Name Like "TrinStgClass*" Then
                            ws.Shapes.Item(index).Delete()
                        End If
                    Next index
                Next ws



                'WB must be saved and closed or the code that attempts to remove the reference will fail.
                newWB.Save()
                newWB.Close()



                'Re-open the WB and remove the Storage Control VBA project reference.
                newWB = excelApp.Workbooks.Open(nome, AddToMru:=False)
                For index = 1 To newWB.VBProject.References.Count
                    If newWB.VBProject.References.Item(index).Name = "VSTOStgLib" Then
                        newWB.VBProject.References.Remove(newWB.VBProject.References.Item(index))
                        Exit For
                    End If
                Next index

                newWB.Save()
                newWB.Close()
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show("The customization could not be removed." & _
                    vbLf & ex.Message)
            End Try

        Globals.ThisWorkbook.possogravar = False

    End Sub

    Function UserNameWindows() As String

        UserNameWindows = Environ("USERNAME")

    End Function

    Sub protectsheet()
        Globals.Sheet1.Protect("password2", , , , , True, True, True, , , , , , , , )

    End Sub


    Private Sub CAL_PCDATF_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CAL_PCDATF.EditValueChanged

    End Sub

    Private Sub LookUpEdit4_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click

        Dim form As New FormTreesPricingNew
        form.ShowDialog()
        Globals.Sheet1.Unprotect("password2")
        recalcular()
        Globals.Sheet1.clientealterado = True

        Globals.Sheet1.Protect("password2", , , , , True, True, True, , , , , , , , )
    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Globals.Sheet1.Unprotect("password2")
        Globals.Sheet1.Range("G5").Value2 = TextPriceListType.EditValue
        recalcular()

        Globals.Sheet1.TipoListaalterado = True

        Globals.Sheet1.Protect("password2", , , , , True, True, True, , , , , , , , )
    End Sub

    Private Sub recalcular()
        Dim varPCDATI = Globals.Sheet1.Range("G6").Value2
        Dim varPCDATF = Globals.Sheet1.Range("I6").Value2
        Dim tabela = Globals.Sheet1.Range("I5").Value2
        Dim clientdest = Globals.Sheet1.Range("D4").Value2
        Dim clientfact = Globals.Sheet1.Range("D12").Value2
        Dim pricelist = Globals.Sheet1.Range("G5").Value2.ToString.Substring(0, 1)
        Dim currency = Globals.Sheet1.Range("L18").Value2
        Dim ultimalinha As Integer = Globals.Sheet1.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row


        For Counter = 24 To ultimalinha

            Dim myConnectionPricing As New SQLiteConnection ' OleDb.OleDbConnection
            myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
            myConnectionPricing.Open()

            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price

            Dim mySelectQueryREFPrice As String
            mySelectQueryREFPrice = "SELECT kbetr FROM saprefprice where matnr='" & Globals.Sheet1.Range("AC" & Counter).Value2 & "' and zzkatr3='" & Globals.Sheet1.Range("C18").Value2 & "' and datbi >='" & varPCDATI & "' and datab <='" & varPCDATI & "'"
            Dim myCommandREFPrice As New SQLiteCommand(mySelectQueryREFPrice, myConnectionPricing)
            Dim retREFPrice As String
            retREFPrice = myCommandREFPrice.ExecuteScalar
            Globals.Sheet1.Range("T" & Counter).Value2 = CDbl(retREFPrice)


            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price


            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs

            Dim mySelectQueryBOTCOSTMOQ As String
            mySelectQueryBOTCOSTMOQ = "SELECT kbetr FROM sapbotlcost where matnr='" & Globals.Sheet1.Range("AC" & Counter).Value2 & "' and datbi >='" & varPCDATI & "' and datab <='" & varPCDATI & "'"
            Dim myCommandBOTCOSTMOQ As New SQLiteCommand(mySelectQueryBOTCOSTMOQ, myConnectionPricing)
            Dim retBOTCOSTMOQ As Decimal
            retBOTCOSTMOQ = myCommandBOTCOSTMOQ.ExecuteScalar
            Globals.Sheet1.Range("BS" & Counter).Value2 = retBOTCOSTMOQ


            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs



            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus

            Dim mySelectQueryBonus As String
            mySelectQueryBonus = ""
            If tabela = "931" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Globals.Sheet1.Range("AC" & Counter).Value2 & "'"
            ElseIf tabela = "933" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Globals.Sheet1.Range("AC" & Counter).Value2 & "'"
            ElseIf tabela = "932" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Globals.Sheet1.Range("AC" & Counter).Value2 & "'"
            ElseIf tabela = "934" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Globals.Sheet1.Range("AC" & Counter).Value2 & "'"
            ElseIf tabela = "935" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Globals.Sheet1.Range("AC" & Counter).Value2 & "'"
            ElseIf tabela = "936" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & tabela & "' and zcldest='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Globals.Sheet1.Range("AC" & Counter).Value2 & "'"

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
                    Globals.Sheet1.Range("BT" & Counter).Value2 = retBonus(0)
                    Globals.Sheet1.Range("BU" & Counter).Value2 = retBonus(1)
                    Globals.Sheet1.Range("BV" & Counter).Value2 = retBonus(2)
                Loop
            Else
                Globals.Sheet1.Range("BT" & Counter).Value2 = ""
                Globals.Sheet1.Range("BU" & Counter).Value2 = ""
                Globals.Sheet1.Range("BV" & Counter).Value2 = ""
            End If


            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus


     



            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes

            Dim mySelectQueryEstipulaçoes As String
            mySelectQueryEstipulaçoes = ""
            Globals.Sheet1.Range("AX" & Counter & ":BR" & Counter).Value2 = Nothing

            Globals.ThisWorkbook.estipulacaoDataTable.Clear()

            If tabela = "936" Then ''''ALEMANHA por CLIENTE ESTATISTICO
                mySelectQueryEstipulaçoes = "SELECT knuma,boart, kschl, kbetr, bonem, vkorgcond FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='clistat' and pltyp ='" & pricelist & "' and datbi >='" & varPCDATF & "' and datab <='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Globals.Sheet1.Range("AC" & Counter).Value2 & "'"
            Else
                mySelectQueryEstipulaçoes = "SELECT knuma,boart, kschl, kbetr, bonem, vkorgcond FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi >='" & varPCDATF & "' and datab <='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Globals.Sheet1.Range("AC" & Counter).Value2 & "'"
            End If


            Dim myCommandEstipulaçoes As New SQLiteCommand(mySelectQueryEstipulaçoes, myConnectionPricing)
            Dim retEstipulaçoes As SQLiteDataReader


            retEstipulaçoes = myCommandEstipulaçoes.ExecuteReader
            Dim countcomm = 0
            Do While retEstipulaçoes.Read

                Dim newRow = Globals.ThisWorkbook.estipulacaoDataTable.NewRow
                newRow(0) = retEstipulaçoes("knuma")
                newRow(1) = retEstipulaçoes("boart")
                newRow(2) = retEstipulaçoes("bonem")
                newRow(3) = varPCDATI
                newRow(4) = varPCDATF
                newRow(5) = retEstipulaçoes("kschl")
                newRow(6) = Globals.Sheet1.Range("AC" & Counter).Value2
                If UCase(retEstipulaçoes("kschl")).ToString.EndsWith("V") Then
                    newRow(7) = retEstipulaçoes("kbetr")
                Else
                    newRow(7) = retEstipulaçoes("kbetr") / 10
                End If
                newRow(8) = Globals.Sheet1.Range("BX" & Counter).Value2
                newRow(9) = retEstipulaçoes("vkorgcond")

                Globals.ThisWorkbook.estipulacaoDataTable.Rows.Add(newRow)



                Dim clientpricesupport As New List(Of String)
                Dim clientAPsupport As New List(Of String)
                Dim clientRappel As New List(Of String)
                Select Case retEstipulaçoes("kschl")
                    ''Price Support
                    Case "YSCV" ' Analysis & Others V
                        Globals.Sheet1.Range("BB" & Counter).Value2 = Globals.Sheet1.Range("BB" & Counter).Value2 + retEstipulaçoes("kbetr")
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
                    Case "YSCP" ' Analysis & Others P
                        Globals.Sheet1.Range("BC" & Counter).Value2 = Globals.Sheet1.Range("BC" & Counter).Value2 + (retEstipulaçoes("kbetr") / 10)
                        clientpricesupport.Add(retEstipulaçoes("bonem"))


                    Case "YSNV" ' Credit note V
                        Globals.Sheet1.Range("AX" & Counter).Value2 = Globals.Sheet1.Range("AX" & Counter).Value2 + retEstipulaçoes("kbetr")
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
                    Case "YSNP" ' Credit note P
                        Globals.Sheet1.Range("AY" & Counter).Value2 = Globals.Sheet1.Range("AY" & Counter).Value2 + (retEstipulaçoes("kbetr") / 10)
                        clientpricesupport.Add(retEstipulaçoes("bonem"))


                    Case "YSHV" ' Charged by customer V
                        Globals.Sheet1.Range("AZ" & Counter).Value2 = Globals.Sheet1.Range("AZ" & Counter).Value2 + retEstipulaçoes("kbetr")
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
                    Case "YSHP" ' Charged by customer P
                        Globals.Sheet1.Range("BA" & Counter).Value2 = Globals.Sheet1.Range("BA" & Counter).Value2 + (retEstipulaçoes("kbetr") / 10)
                        clientpricesupport.Add(retEstipulaçoes("bonem"))

                        ''A&P Support
                    Case "YAPV"
                        Globals.Sheet1.Range("BD" & Counter).Value2 = Globals.Sheet1.Range("BD" & Counter).Value2 + retEstipulaçoes("kbetr")
                        clientAPsupport.Add(retEstipulaçoes("bonem"))
                    Case "YAPP"
                        Globals.Sheet1.Range("BE" & Counter).Value2 = Globals.Sheet1.Range("BE" & Counter).Value2 + (retEstipulaçoes("kbetr") / 10)
                        clientAPsupport.Add(retEstipulaçoes("bonem"))
                    Case "YABV"
                        Globals.Sheet1.Range("BF" & Counter).Value2 = Globals.Sheet1.Range("BF" & Counter).Value2 + retEstipulaçoes("kbetr")
                        clientAPsupport.Add(retEstipulaçoes("bonem"))

                        ''incentives....
                    Case "YOCM"
                        Globals.Sheet1.Range("BG" & Counter).Value2 = Globals.Sheet1.Range("BG" & Counter).Value2 + retEstipulaçoes("kbetr")
                        clientRappel.Add(retEstipulaçoes("bonem"))

                        ''Rappel....
                    Case "YRRV"
                        Globals.Sheet1.Range("BI" & Counter).Value2 = Globals.Sheet1.Range("BI" & Counter).Value2 + retEstipulaçoes("kbetr")
                        clientRappel.Add(retEstipulaçoes("bonem"))
                    Case "YRRP"
                        Globals.Sheet1.Range("BJ" & Counter).Value2 = Globals.Sheet1.Range("BJ" & Counter).Value2 + (retEstipulaçoes("kbetr") / 10)
                        clientRappel.Add(retEstipulaçoes("bonem"))
                        ''Commisions normais
                    Case "YCOP"
                        countcomm = countcomm + 1
                        If countcomm = 1 Then
                            Globals.Sheet1.Range("BM" & Counter).Value2 = retEstipulaçoes("kbetr") / 10
                            Globals.Sheet1.Range("BN" & Counter).Value2 = retEstipulaçoes("bonem")
                        ElseIf countcomm = 2 Then
                            Globals.Sheet1.Range("BO" & Counter).Value2 = retEstipulaçoes("kbetr") / 10
                            Globals.Sheet1.Range("BP" & Counter).Value2 = retEstipulaçoes("bonem")
                        ElseIf countcomm = 3 Then
                            Globals.Sheet1.Range("BQ" & Counter).Value2 = retEstipulaçoes("kbetr") / 10
                            Globals.Sheet1.Range("BR" & Counter).Value2 = retEstipulaçoes("bonem")
                        Else
                            MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                        End If
                        ''Commisions smartwine
                    Case "YEST"
                        countcomm = countcomm + 1
                        If countcomm = 1 Then
                            Globals.Sheet1.Range("BM" & Counter).Value2 = retEstipulaçoes("kbetr") / 10
                            Globals.Sheet1.Range("BN" & Counter).Value2 = retEstipulaçoes("bonem")
                        ElseIf countcomm = 2 Then
                            Globals.Sheet1.Range("BO" & Counter).Value2 = retEstipulaçoes("kbetr") / 10
                            Globals.Sheet1.Range("BP" & Counter).Value2 = retEstipulaçoes("bonem")
                        ElseIf countcomm = 3 Then
                            Globals.Sheet1.Range("BQ" & Counter).Value2 = retEstipulaçoes("kbetr") / 10
                            Globals.Sheet1.Range("BR" & Counter).Value2 = retEstipulaçoes("bonem")
                        Else
                            MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                        End If

                End Select

                'Dim distinctNamesclientpricesupport = clientpricesupport.Distinct()
                'Dim distinctNamesclientpricesupportitem As String
                'For Each distinctNamesclientpricesupportitem In distinctNamesclientpricesupport
                '    Dim stringps = ""
                '    stringps = stringps & distinctNamesclientpricesupportitem & " - "
                '    Globals.Sheet1.Range("BC" & ultimalinha).Value2 = stringps.Trim(" - ")
                'Next
                'Dim distinctNamesclientAPsupport = clientAPsupport.Distinct()
                'Dim distinctNamesclientAPsupportitem As String
                'For Each distinctNamesclientAPsupportitem In distinctNamesclientAPsupport
                '    Dim stringAP = ""
                '    stringAP = stringAP & distinctNamesclientAPsupportitem & " - "
                '    Globals.Sheet1.Range("BH" & ultimalinha).Value2 = stringAP.Trim(" - ")
                'Next
                'Dim distinctNamesclientrappel = clientRappel.Distinct()
                'Dim distinctNamesclientrappelitem As String
                'For Each distinctNamesclientrappelitem In distinctNamesclientrappel
                '    Dim stringR = ""
                '    stringR = stringR & distinctNamesclientrappelitem & " - "
                '    Globals.Sheet1.Range("BL" & ultimalinha).Value2 = stringR.Trim(" - ")
                'Next

            Loop


            '''''FIM LINHA Estipulaçoes
            '''''FIM LINHA Estipulaçoes
            '''''FIM LINHA Estipulaçoes







        Next
    End Sub

    Private Sub SapMateriaisBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles SapMateriaisBindingSource.CurrentChanged

    End Sub
End Class
