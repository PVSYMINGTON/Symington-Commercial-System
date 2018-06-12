



Imports System.Data.SQLite
Imports System.Linq
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors

Public Class UserControl1
    Public inicio As Boolean = True
    Public novatabela As Boolean = True
    Public Shared filterkeycompany As String
    Public Shared filterkeytipo As String


    Public Sub dados()


        Me.SapMateriais1TableAdapter.Fill(Me.SapCSDataSet.SapMateriais1)

        '
        SapMateriais1BindingSource.Filter = "(wgbez60 = '" & filterkeycompany & "' and Niv3= '" & filterkeytipo & "') or (tipo= 'Dry goods Paletes' and meins= 'EA')"


        TextPriceListType.Properties.Items.Clear()
        Me.SapTipoListaPrecosTableAdapter.Fill(Me.SapCSDataSet.SapTipoListaPrecos)

        For Each row In Me.SapCSDataSet.SapTipoListaPrecos
            TextPriceListType.Properties.Items.Add(row(0) & " " & row(1).ToString.TrimEnd)
        Next

    End Sub



    Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim UserIdentityInfo As System.Security.Principal.WindowsIdentity
        UserIdentityInfo = System.Security.Principal.WindowsIdentity.GetCurrent()
        Select Case UCase(UserIdentityInfo.Name())
            Case "SYMINGTON\HS", "SYMINGTON\EMM", "SYMINGTON\JMA", "SYMINGTON\MMC", "SYMINGTON\PV", "SYMINGTON\AMF", "SYMINGTON\PFL", "SYMINGTON\CLC", "SYMINGTON\JMV",
                "SYMINGTON\JVN", "SYMINGTON\GAB", "SYMINGTON\GRD", "SYMINGTON\ACR", "SYMINGTON\RJR", "SYMINGTON\ABM", "SYMINGTON\MFF", "SYMINGTON\IPM", "SYMINGTON\EDR",
                 "COMERC_JVN\JORGE", "SYMINGTON\PAM", "DESKTOP-7RA9PT2\SOFIAZHANG", "SYMINGTON\IF", "SYMINGTON\TC", "SYMINGTON\MAM", "SYMINGTON\FCL", "SYMINGTON\ARSC", "SYMINGTON\ABB", "SYMINGTON\EAC",
                 "SYMINGTON\MLL", "SYMINGTON\MTB", "SYMINGTON\RVB", "SYMINGTON\RAP"

            Case Else '''no access
                Me.Visible = False
                DirectCast(Me.ParentForm, Pricing).DockPanel.Close()
        End Select
    End Sub

    Private Sub ButtonInsDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInsDate.Click



        If CAL_PCDATF.EditValue <= CAL_PCDATI.EditValue Then MsgBox("Datas Erradas") : Exit Sub

        Cursor.Current = Cursors.WaitCursor



        With DirectCast(Me.ParentForm, Pricing)
            .worksheet.Range("G6").Value = Format(CAL_PCDATI.EditValue, "yyyyMMdd")
            .worksheet.Range("I6").Value = Format(CAL_PCDATF.EditValue, "yyyyMMdd")
            .filterkeyPCDATI = Format(CAL_PCDATI.EditValue, "yyyyMMdd")
            .filterkeyPCDATF = Format(CAL_PCDATF.EditValue, "yyyyMMdd")
            .recalcular()
            .datasalteradas = True
        End With
        Cursor.Current = Cursors.Default







    End Sub

    Private Sub ButtonInsertProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInsertProduct.Click
        Dim row As DataRowView = GridLookUpEdit1.GetSelectedDataRow
        Dim htmlText = "<b>Produto:</b><br><color=red>" & row("MAKTX") & "</color><br><b>Ano:</b><br><color=red>" & TextAnoPricing.EditValue & "</color>"

        Dim ret As DialogResult = XtraMessageBox.Show(htmlText, "Confirme, s.f.f.", MessageBoxButtons.OKCancel, DevExpress.Utils.DefaultBoolean.True)
        If ret = DialogResult.Cancel Then
            Exit Sub
        End If


        Pricing.workbook.BeginUpdate()
        Pricing.worksheet.Unprotect("password2")

        ' Try

        ' Access a collection of rows.'
        ' Dim usedrange As Range = Pricing.worksheet.GetUsedRange

        '  Dim bottomRowIndex As Integer = usedrange.BottomRowIndex

        Dim rows As RowCollection = Pricing.worksheet.Rows
        Dim ultimalinha As Integer = rows.LastUsedIndex
        ultimalinha += 1
        'copiar da 1ª linha para a ultima+1
        rows(ultimalinha).CopyFrom(rows("24"))
        'rows(ultimalinha).Font.Color = Color.Black
        Pricing.worksheet.Range("A" & ultimalinha + 1 & ":BV" & ultimalinha + 1).Font.Color = Color.Black



        Pricing.worksheet.Range("A" & ultimalinha + 1).Value = (row("MAKTX")).ToString
        Pricing.worksheet.Range("C" & ultimalinha + 1).Value = (row("PACKAGE")).ToString
        Pricing.worksheet.Range("AC" & ultimalinha + 1).Value = (row("MATNR")).ToString
        Pricing.worksheet.Range("BX" & ultimalinha + 1).Value = (row("MEINS")).ToString


        ''''caixa /bottle

        Dim myConnectionPricing As New SQLiteConnection ' OleDb.OleDbConnection
        myConnectionPricing.ConnectionString = "data source=C:\CommercialSystem\dados\SapCS.db3"
        myConnectionPricing.Open()

        Dim mySelectQueryRange As String
        mySelectQueryRange = "SELECT Range FROM SapMateriais where matnr='" & (row("MATNR")) & "'"
        Dim myCommandRange As New SQLiteCommand(mySelectQueryRange, myConnectionPricing)
        Dim retRange As String
        retRange = myCommandRange.ExecuteScalar
        Pricing.worksheet.Range("B" & ultimalinha + 1).Value = retRange



        Dim sqlcommand2 As New SQLiteCommand
        sqlcommand2.Connection = myConnectionPricing
        sqlcommand2.CommandText = "SELECT lts FROM SAPEMBALAGENS where ind='" & row("EMBALAGEM") & "'"
        sqlcommand2.CommandType = CommandType.Text
        Dim retEMBALLts = sqlcommand2.ExecuteScalar
        Pricing.worksheet.Range("AD" & ultimalinha + 1).Value = (retEMBALLts).ToString

        Dim sqlcommand3 As New SQLiteCommand
        sqlcommand3.Connection = myConnectionPricing
        sqlcommand3.CommandText = "SELECT cap FROM SAPEMBALAGENS where ind='" & row("EMBALAGEM") & "'"
        sqlcommand3.CommandType = CommandType.Text
        Dim retEMBALcap = sqlcommand3.ExecuteScalar
        Try
            If retEMBALcap <> 0 Then
                Pricing.worksheet.Range("AE" & ultimalinha + 1).Value = CDec((retEMBALLts / retEMBALcap))

            Else
                Pricing.worksheet.Range("AE" & ultimalinha + 1).Value = "n/a"
            End If
        Catch
            Pricing.worksheet.Range("AE" & ultimalinha + 1).Value = "n/a"
        End Try
        ''Fusão
        Pricing.worksheet.Range("D" & ultimalinha + 1).Value = TextAnoPricing.EditValue.ToString
        Pricing.worksheet.Range("E" & ultimalinha + 1).Value = Nothing  '0
        Pricing.worksheet.Range("F" & ultimalinha + 1).Value = Nothing '0
        Pricing.worksheet.Range("G" & ultimalinha + 1).Value = Nothing '0
        Pricing.worksheet.Range("T" & ultimalinha + 1).Value = Nothing '0
        Pricing.worksheet.Range("V" & ultimalinha + 1).Value = Nothing '0
        Pricing.worksheet.Range("W" & ultimalinha + 1).Value = Nothing '0
        Pricing.worksheet.Range("Y" & ultimalinha + 1).Value = Nothing '0
        Pricing.worksheet.Range("Z" & ultimalinha + 1).Value = Nothing '0
        Pricing.worksheet.Range("AF" & ultimalinha + 1 & ":BV" & ultimalinha + 1).Value = Nothing '0
        Pricing.worksheet.Range("CT" & ultimalinha + 1 & ":CU" & ultimalinha + 1).Value = Nothing '0


        Dim varPCDATI = Pricing.worksheet.Range("G6").Value.ToString
        Dim varPCDATF = Pricing.worksheet.Range("I6").Value.ToString
        Dim tabela = Pricing.worksheet.Range("I5").Value.ToString
        Dim clientdest = Pricing.worksheet.Range("D4").Value.ToString
        Dim clientfact = Pricing.worksheet.Range("D12").Value.ToString
        Dim pricelist = Pricing.worksheet.Range("G5").Value.ToString.Substring(0, 1)
        Dim currency = Pricing.worksheet.Range("L18").Value.ToString

        '''''INICIO LINHA Reference Price
        '''''INICIO LINHA Reference Price
        '''''INICIO LINHA Reference Price

        Dim mySelectQueryREFPrice As String
        mySelectQueryREFPrice = "SELECT kbetr FROM saprefprice where matnr='" & (row("MATNR")) & "' and ZZANO='" & (TextAnoPricing.EditValue) & "' and zzkatr3='" & Pricing.worksheet.Range("C18").Value.ToString & "' and datbi >='" & varPCDATI & "' and datab <='" & varPCDATI & "'"
        Dim myCommandREFPrice As New SQLiteCommand(mySelectQueryREFPrice, myConnectionPricing)
        Dim retREFPrice As String
        retREFPrice = myCommandREFPrice.ExecuteScalar
        Pricing.worksheet.Range("T" & ultimalinha + 1).Value = CDbl(retREFPrice)


        '''''FIM LINHA Reference Price
        '''''FIM LINHA Reference Price
        '''''FIM LINHA Reference Price


        '''''INICIO LINHA Bootling Costs
        '''''INICIO LINHA Bootling Costs
        '''''INICIO LINHA Bootling Costs

        Dim mySelectQueryBOTCOSTMOQ As String
        mySelectQueryBOTCOSTMOQ = "SELECT kbetr FROM sapbotlcost where matnr='" & row("MATNR") & "' and ZZANO='" & TextAnoPricing.EditValue & "' and datbi >='" & varPCDATI & "' and datab <='" & varPCDATI & "'"
        Dim myCommandBOTCOSTMOQ As New SQLiteCommand(mySelectQueryBOTCOSTMOQ, myConnectionPricing)
        Dim retBOTCOSTMOQ As Decimal
        retBOTCOSTMOQ = myCommandBOTCOSTMOQ.ExecuteScalar
        Pricing.worksheet.Range("BS" & ultimalinha + 1).Value = retBOTCOSTMOQ


        '''''FIM LINHA Bootling Costs
        '''''FIM LINHA Bootling Costs
        '''''FIM LINHA Bootling Costs



        '''''INICIO LINHA Bonus
        '''''INICIO LINHA Bonus
        '''''INICIO LINHA Bonus

        Dim mySelectQueryBonus As String
        mySelectQueryBonus = ""
        If tabela = "943" Then
            mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN953' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "' and ZZANO='" & TextAnoPricing.EditValue & "'"
            ''FUSÃO ElseIf tabela = "934" Then
        ElseIf tabela = "944" Then
            mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN954' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "' and ZZANO='" & TextAnoPricing.EditValue & "'"
            ''FUSÃO ElseIf tabela = "936" Then
        ElseIf tabela = "946" Then
            mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN957' and zcldest='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & row("MATNR") & "' and ZZANO='" & TextAnoPricing.EditValue & "'"
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
                Pricing.worksheet.Range("BT" & ultimalinha + 1).Value = retBonus(0).ToString
                Pricing.worksheet.Range("BU" & ultimalinha + 1).Value = retBonus(1).ToString
                Pricing.worksheet.Range("BV" & ultimalinha + 1).Value = retBonus(2).ToString
            Loop
        Else
            Pricing.worksheet.Range("BT" & ultimalinha + 1).Value = Nothing
            Pricing.worksheet.Range("BU" & ultimalinha + 1).Value = Nothing
            Pricing.worksheet.Range("BV" & ultimalinha + 1).Value = Nothing
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
                    Pricing.worksheet.Range("BB" & ultimalinha + 1).Value = Pricing.worksheet.Range("BB" & ultimalinha + 1).Value + retEstipulaçoes("kbetr")
                    clientpricesupport.Add(retEstipulaçoes("bonem"))
                Case "YSCP" ' Analysis & Others P
                    Pricing.worksheet.Range("BC" & ultimalinha + 1).Value = Pricing.worksheet.Range("BC" & ultimalinha + 1).Value + (retEstipulaçoes("kbetr") / 10)
                    clientpricesupport.Add(retEstipulaçoes("bonem"))


                Case "YSNV" ' Credit note V
                    Pricing.worksheet.Range("AX" & ultimalinha + 1).Value = Pricing.worksheet.Range("AX" & ultimalinha + 1).Value + retEstipulaçoes("kbetr")
                    clientpricesupport.Add(retEstipulaçoes("bonem"))
                Case "YSNP" ' Credit note P
                    Pricing.worksheet.Range("AY" & ultimalinha + 1).Value = Pricing.worksheet.Range("AY" & ultimalinha + 1).Value + (retEstipulaçoes("kbetr") / 10)
                    clientpricesupport.Add(retEstipulaçoes("bonem"))



                Case "YSHV" ' Charged by customer V
                    Pricing.worksheet.Range("AZ" & ultimalinha + 1).Value = Pricing.worksheet.Range("AZ" & ultimalinha + 1).Value + retEstipulaçoes("kbetr")
                    clientpricesupport.Add(retEstipulaçoes("bonem"))
                Case "YSHP" ' Charged by customer P
                    Pricing.worksheet.Range("BA" & ultimalinha + 1).Value = Pricing.worksheet.Range("BA" & ultimalinha + 1).Value + (retEstipulaçoes("kbetr") / 10)
                    clientpricesupport.Add(retEstipulaçoes("bonem"))

                            ''A&P Support
                Case "YAPV"
                    Pricing.worksheet.Range("BD" & ultimalinha + 1).Value = Pricing.worksheet.Range("BD" & ultimalinha + 1).Value + retEstipulaçoes("kbetr")
                    clientAPsupport.Add(retEstipulaçoes("bonem"))
                Case "YAPP"
                    Pricing.worksheet.Range("BE" & ultimalinha + 1).Value = Pricing.worksheet.Range("BE" & ultimalinha + 1).Value + (retEstipulaçoes("kbetr") / 10)
                    clientAPsupport.Add(retEstipulaçoes("bonem"))
                Case "YABV"
                    Pricing.worksheet.Range("BF" & ultimalinha + 1).Value = Pricing.worksheet.Range("BF" & ultimalinha + 1).Value + retEstipulaçoes("kbetr")
                    clientAPsupport.Add(retEstipulaçoes("bonem"))

                            ''incentives....
                Case "YOCM"
                    Pricing.worksheet.Range("BI" & ultimalinha + 1).Value = Pricing.worksheet.Range("BI" & ultimalinha + 1).Value + retEstipulaçoes("kbetr")
                    clientRappel.Add(retEstipulaçoes("bonem"))

                            ''Rappel....
                Case "YRRV"
                    Pricing.worksheet.Range("BI" & ultimalinha + 1).Value = Pricing.worksheet.Range("BI" & ultimalinha + 1).Value + retEstipulaçoes("kbetr")
                    clientRappel.Add(retEstipulaçoes("bonem"))
                Case "YRRP"
                    Pricing.worksheet.Range("BJ" & ultimalinha + 1).Value = Pricing.worksheet.Range("BJ" & ultimalinha + 1).Value + (retEstipulaçoes("kbetr") / 10)
                    clientRappel.Add(retEstipulaçoes("bonem"))

                            ''Commisions
                Case "YCOP"
                    countcomm = countcomm + 1
                    If countcomm = 1 Then
                        Pricing.worksheet.Range("BM" & ultimalinha + 1).Value = retEstipulaçoes("kbetr") / 10
                        Pricing.worksheet.Range("BN" & ultimalinha + 1).Value = retEstipulaçoes("bonem")
                    ElseIf countcomm = 2 Then
                        Pricing.worksheet.Range("BO" & ultimalinha + 1).Value = retEstipulaçoes("kbetr") / 10
                        Pricing.worksheet.Range("BP" & ultimalinha + 1).Value = retEstipulaçoes("bonem")
                    ElseIf countcomm = 3 Then
                        Pricing.worksheet.Range("BQ" & ultimalinha + 1).Value = retEstipulaçoes("kbetr") / 10
                        Pricing.worksheet.Range("BR" & ultimalinha + 1).Value = retEstipulaçoes("bonem")
                    Else
                        MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                    End If
                Case "YEST"
                    countcomm = countcomm + 1
                    If countcomm = 1 Then
                        Pricing.worksheet.Range("BM" & ultimalinha + 1).Value = retEstipulaçoes("kbetr") / 10
                        Pricing.worksheet.Range("BN" & ultimalinha + 1).Value = retEstipulaçoes("bonem")
                    ElseIf countcomm = 2 Then
                        Pricing.worksheet.Range("BO" & ultimalinha + 1).Value = retEstipulaçoes("kbetr") / 10
                        Pricing.worksheet.Range("BP" & ultimalinha + 1).Value = retEstipulaçoes("bonem")
                    ElseIf countcomm = 3 Then
                        Pricing.worksheet.Range("BQ" & ultimalinha + 1).Value = retEstipulaçoes("kbetr") / 10
                        Pricing.worksheet.Range("BR" & ultimalinha + 1).Value = retEstipulaçoes("bonem")
                    Else
                        MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                    End If

            End Select

            'Dim distinctNamesclientpricesupport = clientpricesupport.Distinct()
            'Dim distinctNamesclientpricesupportitem As String
            'For Each distinctNamesclientpricesupportitem In distinctNamesclientpricesupport
            '    Dim stringps = ""
            '    stringps = stringps & distinctNamesclientpricesupportitem & " - "
            '    Form1.worksheet.Range("BC" & ultimalinha + 1).value = stringps.Trim(" - ")
            'Next
            'Dim distinctNamesclientAPsupport = clientAPsupport.Distinct()
            'Dim distinctNamesclientAPsupportitem As String
            'For Each distinctNamesclientAPsupportitem In distinctNamesclientAPsupport
            '    Dim stringAP = ""
            '    stringAP = stringAP & distinctNamesclientAPsupportitem & " - "
            '    Form1.worksheet.Range("BH" & ultimalinha + 1).value = stringAP.Trim(" - ")
            'Next
            'Dim distinctNamesclientrappel = clientRappel.Distinct()
            'Dim distinctNamesclientrappelitem As String
            'For Each distinctNamesclientrappelitem In distinctNamesclientrappel
            '    Dim stringR = ""
            '    stringR = stringR & distinctNamesclientrappelitem & " - "
            '    Form1.worksheet.Range("BL" & ultimalinha + 1).value = stringR.Trim(" - ")
            'Next

        Loop
        myConnectionPricing.Close()

        '''''FIM LINHA Estipulaçoes
        '''''FIM LINHA Estipulaçoes
        '''''FIM LINHA Estipulaçoes



        Pricing.workbook.EndUpdate()



        Try
            'Form1.worksheet.Range("S" & ultimalinha + 1).GoalSeek(Form1.worksheet.Range("T" & ultimalinha + 1), Form1.worksheet.Range("F" & ultimalinha + 1))

            Dim value As Double = CDbl(Pricing.worksheet.Cells("T" & ultimalinha + 1).Value.ToObject)

            'GoalSeek(Pricing.worksheet.Cells("S" & ultimalinha + 1), value, Pricing.worksheet.Cells("F" & ultimalinha + 1))
        Catch ex As Exception

        End Try


        inicio = False
        'Catch ex As Exception
        '    MsgBox("Erro!")
        'End Try
        Pricing.worksheet.Protect("password2", WorksheetProtectionPermissions.FormatColumns)


    End Sub

    Private Sub ButtonGravarPrecos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGravarPrecos.Click


        If Pricing.worksheet.Range("D4").Value = "999991" Or Pricing.worksheet.Range("D4").Value = "999990" Then
            If Not UserNameWindows() = "HS" Then
                MsgBox("Não pode alterar!", MsgBoxStyle.Information, "Erro!")
                Exit Sub
            End If
        End If

        If Pricing.bonusalterados = True Then
            Pricing.worksheet.Unprotect("password2")
            Dim varBT As Boolean
            Dim varBU As Boolean
            Dim varBV As Boolean
            Dim Last_Real_Populated_Row As Integer = Pricing.worksheet.GetUsedRange.BottomRowIndex
            For Counter = 24 To Last_Real_Populated_Row
                varBT = IsNumeric(Pricing.worksheet.Range("BT" & Counter).Value)
                varBU = IsNumeric(Pricing.worksheet.Range("BU" & Counter).Value)
                varBV = IsNumeric(Pricing.worksheet.Range("BV" & Counter).Value)
                If Not (varBT = True And varBU = True And varBV = True) Then
                    If Not (varBT = False And varBU = False And varBV = False) Then
                        MsgBox("Preencha todos os campos de Bónus", MsgBoxStyle.Critical)
                        Pricing.worksheet.Protect("password2", WorksheetProtectionPermissions.FormatColumns)
                        Exit Sub
                    End If
                End If
            Next

        End If


        If Pricing.bonusalterados = True And Pricing.datasalteradas = True Then
            Dim responsebonus As MsgBoxResult
            responsebonus = MsgBox("Alterou os Bónus de Quantidade e a Datas de Validade. Poderá perder os dados de Bónus anteriores se as datas de validade se sobreporem!! Têm a certeza?", MsgBoxStyle.YesNo, "Gravar dados.")
            If responsebonus = MsgBoxResult.No Then Exit Sub
        ElseIf Pricing.bonusalterados = True And Pricing.datasalteradas = False Then
            Dim responsebonus2 As MsgBoxResult
            responsebonus2 = MsgBox("Vai alterar os Bónus de Quantidade. Têm a certeza?", MsgBoxStyle.YesNo, "Gravar dados.")
            If responsebonus2 = MsgBoxResult.No Then Exit Sub
        Else
            Dim response As MsgBoxResult
            response = MsgBox("Têm a certeza?", MsgBoxStyle.YesNo, "Gravar dados.")
            If response = MsgBoxResult.No Then Exit Sub
        End If

        Pricing.worksheet.Unprotect("password2")
        Dim ret As String
        ret = getsavepricing()


        Dim dvaluecheck = From row In Pricing.estipulacaoDataTable.AsEnumerable()
                          Where Not row.Field(Of String)("Operacao") = ""
        If dvaluecheck.Count > 0 Then insertmdbEst()

        Try
            If insertmdb(ret) Then
                Me.ParentForm.Close()
            Else
                Pricing.worksheet.Protect("password2", DevExpress.Spreadsheet.WorksheetProtectionPermissions.Default)
            End If
        Catch ex As Exception
            MsgBox("Erro! " & ex.Message, MsgBoxStyle.Critical)
            Pricing.worksheet.Protect("password2", DevExpress.Spreadsheet.WorksheetProtectionPermissions.Default)
        End Try



    End Sub


    Function insertmdb(ByVal ret As String)



        'Open access-database connection
        Dim cnn As New SQLiteConnection ' OleDbConnection
        Dim transaction As SQLiteTransaction ' OleDbTransaction

        cnn.ConnectionString = "data source=c:\CommercialSystem\dados\SapPricingupdate.db3"
        cnn.Open()
        Dim Last_Real_Populated_Row As Integer = Pricing.worksheet.GetUsedRange.BottomRowIndex
        transaction = cnn.BeginTransaction
        Dim sqlcommand As New SQLiteCommand ' OleDbCommand
        sqlcommand.Connection = cnn
        sqlcommand.Transaction = transaction


        For Counter = 24 To Last_Real_Populated_Row + 1



            If Pricing.worksheet.Range("I5").Value = "931" Or Pricing.worksheet.Range("I5").Value = "932" Then 'se for tabela de produto composto
                If Pricing.worksheet.Range(("BW" & Counter)).Value = "" Then 'se for a linha do produto pai
                    Counter = Counter + 1 ' passa a linha segumite
                End If
            End If




            sqlcommand.CommandText = "INSERT INTO paprixf " _
            & "(PCCCLI, PCCLID, PCCLIE, PCCPRO, PCCPRP, PCVERS, PCTPRE, PCPVAC, PCPIVA, PCACOL, PCMOED, " _
            & "PCDATI, PCDATF, PCPVAA, ZDEV, ZDEP, ZDQV, ZDQP, ZDPV, ZDPP, ZDRV, ZDRP, " _
            & "ZDLV, ZDLP, ZDTV, ZDTP, ZEEC, ZEFR, ZEIN, ZEFI, ZESL, ZESP, KNRMM, KNRNM, KNRZM, " _
            & "PCCSIT, PCUSER, TABELA, vrkme, AnoPricing)" _
            & " VALUES(" _
            & "@paramPCCCLI,@paramPCCLID,@paramPCCLIE,@paramPCCPRO,@paramPCCPRP,@paramPCVERS,@paramPCTPRE,@paramPCPVAC,@paramPCPIVA,@paramPCACOL,@paramPCMOED," _
            & "@paramPCDATI,@paramPCDATF,@paramPCPVAA,@paramZDEV,@paramZDEP,@paramZDQV,@paramZDQP,@paramZDPV,@paramZDPP,@paramZDRV,@paramZDRP," _
            & "@paramZDLV,@paramZDLP,@paramZDTV,@paramZDTP,@paramZEEC,@paramZEFR,@paramZEIN,@paramZEFI,@paramZESL,@paramZESP,@paramKNRMM,@paramKNRNM,@paramKNRZM," _
            & "@paramPCCSIT,@paramPCUSER,@paramTabela,@paramvrkme,@paramAnoPricing)"


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
            sqlcommand.Parameters.Add("@paramAnoPricing", DbType.String)

            sqlcommand.Parameters("@paramPCCCLI").Value = Pricing.worksheet.Range("D12").Value.ToString
            sqlcommand.Parameters("@paramPCCLID").Value = Pricing.worksheet.Range("D4").Value.ToString
            sqlcommand.Parameters("@paramPCCLIE").Value = Pricing.worksheet.Range("D11").Value.ToString
            sqlcommand.Parameters("@paramPCCPRO").Value = Pricing.worksheet.Range(("AC" & Counter)).Value.ToString
            sqlcommand.Parameters("@paramAnoPricing").Value = Pricing.worksheet.Range(("D" & Counter)).Value.ToString
            sqlcommand.Parameters("@paramPCCPRP").Value = Pricing.worksheet.Range(("BW" & Counter)).Value.ToString

            If novatabela = True Then
                sqlcommand.Parameters("@paramPCVERS").Value = 1
            Else
                sqlcommand.Parameters("@paramPCVERS").Value = Pricing.worksheet.Range("I5").Value.ToString
            End If
            sqlcommand.Parameters("@paramPCTPRE").Value = Pricing.worksheet.Range("G5").Value.ToString.Chars(0).ToString
            sqlcommand.Parameters("@paramPCPVAC").Value = CDbl(Pricing.worksheet.Range(("F" & Counter)).Value.ToString)
            Try
                sqlcommand.Parameters("@paramPCPIVA").Value = CInt(Pricing.worksheet.Range(("AE" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramPCPIVA").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramPCACOL").Value = CInt(Pricing.worksheet.Range(("AB" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramPCACOL").Value = Nothing
            End Try



            sqlcommand.Parameters("@paramPCMOED").Value = Pricing.worksheet.Range("L18").Value.ToString

            sqlcommand.Parameters("@paramPCDATI").Value = CInt(Pricing.worksheet.Range("G6").Value.ToString)
            sqlcommand.Parameters("@paramPCDATF").Value = CInt(Pricing.worksheet.Range("I6").Value.ToString)

            Try
                sqlcommand.Parameters("@paramPCPVAA").Value = CDbl(Pricing.worksheet.Range(("G" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramPCPVAA").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZDEV").Value = CDbl(Pricing.worksheet.Range(("AF" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramZDEV").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZDEP").Value = IIf(Pricing.worksheet.Range(("AG" & Counter)).Value Is Nothing, Nothing, Pricing.worksheet.Range(("AG" & Counter)).Value.ToObject * 10)
            Catch
                sqlcommand.Parameters("@paramZDEP").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZDQV").Value = CDbl(Pricing.worksheet.Range(("AH" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramZDQV").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZDQP").Value = IIf(Pricing.worksheet.Range(("AI" & Counter)).Value Is Nothing, Nothing, Pricing.worksheet.Range(("AI" & Counter)).Value.ToObject * 10)
            Catch
                sqlcommand.Parameters("@paramZDQP").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZDPV").Value = CDbl(Pricing.worksheet.Range(("AJ" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramZDPV").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZDPP").Value = IIf(Pricing.worksheet.Range(("AK" & Counter)).Value Is Nothing, Nothing, Pricing.worksheet.Range(("AK" & Counter)).Value.ToObject * 10)
            Catch
                sqlcommand.Parameters("@paramZDPP").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZDRV").Value = CDbl(Pricing.worksheet.Range(("AL" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramZDRV").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZDRP").Value = IIf(Pricing.worksheet.Range(("AM" & Counter)).Value Is Nothing, Nothing, Pricing.worksheet.Range(("AM" & Counter)).Value.ToObject * 10)
            Catch
                sqlcommand.Parameters("@paramZDRP").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZDLV").Value = CDbl(Pricing.worksheet.Range(("AN" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramZDLV").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZDLP").Value = IIf(Pricing.worksheet.Range(("AO" & Counter)).Value Is Nothing, Nothing, Pricing.worksheet.Range(("AO" & Counter)).Value.ToObject * 10)
            Catch
                sqlcommand.Parameters("@paramZDLP").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZDTV").Value = CDbl(Pricing.worksheet.Range(("AP" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramZDTV").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZDTP").Value = IIf(Pricing.worksheet.Range(("AQ" & Counter)).Value Is Nothing, Nothing, Pricing.worksheet.Range(("AQ" & Counter)).Value.ToObject * 10)
            Catch
                sqlcommand.Parameters("@paramZDTP").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZEEC").Value = CDbl(Pricing.worksheet.Range(("AR" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramZEEC").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZEFR").Value = CDbl(Pricing.worksheet.Range(("AS" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramZEFR").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZEIN").Value = CDbl(Pricing.worksheet.Range(("AT" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramZEIN").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZEFI").Value = CDbl(Pricing.worksheet.Range(("AU" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramZEFI").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZESL").Value = CDbl(Pricing.worksheet.Range(("AV" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramZESL").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramZESP").Value = CDbl(Pricing.worksheet.Range(("AW" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramZESP").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramKNRMM").Value = CDbl(Pricing.worksheet.Range(("BT" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramKNRMM").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramKNRNM").Value = CDbl(Pricing.worksheet.Range(("BU" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramKNRNM").Value = Nothing
            End Try
            Try
                sqlcommand.Parameters("@paramKNRZM").Value = CDbl(Pricing.worksheet.Range(("BV" & Counter)).Value.ToString)
            Catch
                sqlcommand.Parameters("@paramKNRZM").Value = Nothing
            End Try


            sqlcommand.Parameters("@paramPCCSIT").Value = "*" ' PCCSIT
            sqlcommand.Parameters("@paramPCUSER").Value = ret ' PCUSER
            sqlcommand.Parameters("@paramTabela").Value = Pricing.worksheet.Range("I5").Value.ToString.Trim("A")  'tabela
            sqlcommand.Parameters("@paramvrkme").Value = Pricing.worksheet.Range(("BX" & Counter)).Value.ToString ' VRKME

            Try
                sqlcommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Erro. Linha duplicada ou já existe gravada localmente!", MsgBoxStyle.Critical)
                transaction.Rollback()
                Return False
                Exit Function
            End Try


        Next


        transaction.Commit()
        cnn.Close()
        cnn = Nothing
        savepricing(ret)
        MsgBox("OK. Preços gravados localmente.")
        Return True





        'Close connections



    End Function

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

        Dim form1 = TryCast(ParentForm, Pricing)

        Dim dvalue = From row In Pricing.estipulacaoDataTable.AsEnumerable()
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
            sqlcommand.Parameters("@paramkunnr").Value = Pricing.worksheet.Range("D12").Value
            sqlcommand.Parameters("@paramzcldest").Value = Pricing.worksheet.Range("D4").Value
            sqlcommand.Parameters("@paramwaerk").Value = Pricing.worksheet.Range("L18").Value
            sqlcommand.Parameters("@parammatnr").Value = m(6)
            sqlcommand.Parameters("@parampltyp").Value = Pricing.worksheet.Range("G5").Value.ToString.Chars(0).ToString
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

        ' Pricing.worksheet.Unprotect("password2")
        DirectCast(ParentForm, Pricing).spreadsheetControl.SaveDocument(nome, DocumentFormat.OpenXml)



        ' Pricing.worksheet.Protect("password2", WorksheetProtectionPermissions.Default)



        Dim form1 = TryCast(ParentForm, Pricing)
        form1.possogravar = False

    End Sub

    Function UserNameWindows() As String

        UserNameWindows = Environ("USERNAME")

    End Function



    Private Sub ButtonAlterarCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAlterarCustomer.Click

        Dim form As New FormTreesPricingNew
        form.ShowDialog()

        Cursor.Current = Cursors.WaitCursor
        DirectCast(Me.ParentForm, Pricing).recalcular()
        DirectCast(ParentForm, Pricing).clientealterado = True

        Cursor.Current = Cursors.Default



    End Sub

    Private Sub ButtonAlterarPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAlterarPL.Click

        Cursor.Current = Cursors.WaitCursor
        With DirectCast(Me.ParentForm, Pricing)
            .worksheet.Cells("G5").Value = TextPriceListType.EditValue.ToString
            .filterkeypricelist = TextPriceListType.EditValue.ToString
            .recalcular()
            .TipoListaalterado = True
        End With
        Cursor.Current = Cursors.Default




    End Sub



    Private Sub recalcular()
        Dim form1 = TryCast(ParentForm, Pricing)


        Dim varPCDATI = Pricing.worksheet.Range("G6").Value.ToString
        Dim varPCDATF = Pricing.worksheet.Range("I6").Value.ToString
        Dim tabela = Pricing.worksheet.Range("I5").Value.ToString
        Dim clientdest = Pricing.worksheet.Range("D4").Value.ToString
        Dim clientfact = Pricing.worksheet.Range("D12").Value.ToString
        Dim pricelist = Pricing.worksheet.Range("G5").Value.ToString.Substring(0, 1)
        Dim currency = Pricing.worksheet.Range("L18").Value.ToString
        Dim ultimalinha As Integer = Pricing.worksheet.GetUsedRange.BottomRowIndex


        For Counter = 24 To ultimalinha

            Dim myConnectionPricing As New SQLiteConnection ' OleDb.OleDbConnection
            myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
            myConnectionPricing.Open()

            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price

            Dim mySelectQueryREFPrice As String
            mySelectQueryREFPrice = "SELECT kbetr FROM saprefprice where matnr='" & Pricing.worksheet.Range("AC" & Counter).Value.ToString & "' and ZZANO='" & Pricing.worksheet.Range("D" & Counter).Value.ToString & " and zzkatr3='" & Pricing.worksheet.Range("C18").Value.ToString & "' and datbi >='" & varPCDATI & "' and datab <='" & varPCDATI & "'"
            Dim myCommandREFPrice As New SQLiteCommand(mySelectQueryREFPrice, myConnectionPricing)
            Dim retREFPrice As String
            retREFPrice = myCommandREFPrice.ExecuteScalar
            Pricing.worksheet.Range("T" & Counter).Value = CDbl(retREFPrice)


            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price


            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs

            Dim mySelectQueryBOTCOSTMOQ As String
            mySelectQueryBOTCOSTMOQ = "SELECT kbetr FROM sapbotlcost where matnr='" & Pricing.worksheet.Range("AC" & Counter).Value.ToObject & "' and ZZANO='" & Pricing.worksheet.Range("D" & Counter).Value.ToString & "' and datbi >='" & varPCDATI & "' and datab <='" & varPCDATI & "'"
            Dim myCommandBOTCOSTMOQ As New SQLiteCommand(mySelectQueryBOTCOSTMOQ, myConnectionPricing)
            Dim retBOTCOSTMOQ As Decimal
            retBOTCOSTMOQ = myCommandBOTCOSTMOQ.ExecuteScalar
            Pricing.worksheet.Range("BS" & Counter).Value = retBOTCOSTMOQ


            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs



            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus

            Dim mySelectQueryBonus As String
            mySelectQueryBonus = ""
            If tabela = "943" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN953' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Pricing.worksheet.Range("AC" & Counter).Value.ToString & "' and ZZANO='" & Pricing.worksheet.Range("D" & Counter).Value.ToString & "'"
                ''FUSÃO  ElseIf tabela = "934" Then
            ElseIf tabela = "944" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN954' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Pricing.worksheet.Range("AC" & Counter).Value.ToString & "' and ZZANO='" & Pricing.worksheet.Range("D" & Counter).Value.ToString & "'"
                ''FUSÃO  ElseIf tabela = "936" Then
            ElseIf tabela = "946" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN956' and zcldest='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & varPCDATF & "' and datab ='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Pricing.worksheet.Range("AC" & Counter).Value.ToString & "' and ZZANO='" & Pricing.worksheet.Range("D" & Counter).Value.ToString & "'"

            End If

            Dim myCommandBonus As New SQLiteCommand(mySelectQueryBonus, myConnectionPricing)
            Dim retBonus As SQLiteDataReader
            retBonus = myCommandBonus.ExecuteReader(CommandBehavior.SingleRow)
            'atenção -> kbetr = knrmm = Minimum quantity
            'atenção -> knrnm = Free goods quantity
            'atenção -> knrnm = Additional quantity for free goods

            If retBonus.HasRows Then
                Do While retBonus.Read
                    Pricing.worksheet.Range("BT" & Counter).Value = retBonus(0)
                    Pricing.worksheet.Range("BU" & Counter).Value = retBonus(1)
                    Pricing.worksheet.Range("BV" & Counter).Value = retBonus(2)
                Loop
            Else
                Pricing.worksheet.Range("BT" & Counter).Value = ""
                Pricing.worksheet.Range("BU" & Counter).Value = ""
                Pricing.worksheet.Range("BV" & Counter).Value = ""
            End If


            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus






            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes

            Dim mySelectQueryEstipulaçoes As String
            mySelectQueryEstipulaçoes = ""
            Pricing.worksheet.Range("AX" & Counter & ":BR" & Counter).Value = Nothing

            Pricing.estipulacaoDataTable.Clear()

            If tabela = "936" Then ''''ALEMANHA por CLIENTE ESTATISTICO
                mySelectQueryEstipulaçoes = "SELECT knuma,boart, kschl, kbetr, bonem, vkorgcond FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='clistat' and pltyp ='" & pricelist & "' and datbi >='" & varPCDATF & "' and datab <='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Pricing.worksheet.Range("AC" & Counter).Value.ToString & "'"
            Else
                mySelectQueryEstipulaçoes = "SELECT knuma,boart, kschl, kbetr, bonem, vkorgcond FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi >='" & varPCDATF & "' and datab <='" & varPCDATI & "' and waerk ='" & currency & "' and matnr='" & Pricing.worksheet.Range("AC" & Counter).Value.ToString & "'"
            End If


            Dim myCommandEstipulaçoes As New SQLiteCommand(mySelectQueryEstipulaçoes, myConnectionPricing)
            Dim retEstipulaçoes As SQLiteDataReader


            retEstipulaçoes = myCommandEstipulaçoes.ExecuteReader
            Dim countcomm = 0
            Do While retEstipulaçoes.Read

                Dim newRow = Pricing.estipulacaoDataTable.NewRow
                newRow(0) = retEstipulaçoes("knuma")
                newRow(1) = retEstipulaçoes("boart")
                newRow(2) = retEstipulaçoes("bonem")
                newRow(3) = varPCDATI
                newRow(4) = varPCDATF
                newRow(5) = retEstipulaçoes("kschl")
                newRow(6) = Pricing.worksheet.Range("AC" & Counter).Value
                If UCase(retEstipulaçoes("kschl")).ToString.EndsWith("V") Then
                    newRow(7) = retEstipulaçoes("kbetr")
                Else
                    newRow(7) = retEstipulaçoes("kbetr") / 10
                End If
                newRow(8) = Pricing.worksheet.Range("BX" & Counter).Value
                newRow(9) = retEstipulaçoes("vkorgcond")

                Pricing.estipulacaoDataTable.Rows.Add(newRow)



                Dim clientpricesupport As New List(Of String)
                Dim clientAPsupport As New List(Of String)
                Dim clientRappel As New List(Of String)
                Select Case retEstipulaçoes("kschl")
                    ''Price Support
                    Case "YSCV" ' Analysis & Others V
                        Pricing.worksheet.Range("BB" & Counter).Value = Pricing.worksheet.Range("BB" & Counter).Value + retEstipulaçoes("kbetr")
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
                    Case "YSCP" ' Analysis & Others P
                        Pricing.worksheet.Range("BC" & Counter).Value = Pricing.worksheet.Range("BC" & Counter).Value + (retEstipulaçoes("kbetr") / 10)
                        clientpricesupport.Add(retEstipulaçoes("bonem"))


                    Case "YSNV" ' Credit note V
                        Pricing.worksheet.Range("AX" & Counter).Value = Pricing.worksheet.Range("AX" & Counter).Value + retEstipulaçoes("kbetr")
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
                    Case "YSNP" ' Credit note P
                        Pricing.worksheet.Range("AY" & Counter).Value = Pricing.worksheet.Range("AY" & Counter).Value + (retEstipulaçoes("kbetr") / 10)
                        clientpricesupport.Add(retEstipulaçoes("bonem"))


                    Case "YSHV" ' Charged by customer V
                        Pricing.worksheet.Range("AZ" & Counter).Value = Pricing.worksheet.Range("AZ" & Counter).Value + retEstipulaçoes("kbetr")
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
                    Case "YSHP" ' Charged by customer P
                        Pricing.worksheet.Range("BA" & Counter).Value = Pricing.worksheet.Range("BA" & Counter).Value + (retEstipulaçoes("kbetr") / 10)
                        clientpricesupport.Add(retEstipulaçoes("bonem"))

                        ''A&P Support
                    Case "YAPV"
                        Pricing.worksheet.Range("BD" & Counter).Value = Pricing.worksheet.Range("BD" & Counter).Value + retEstipulaçoes("kbetr")
                        clientAPsupport.Add(retEstipulaçoes("bonem"))
                    Case "YAPP"
                        Pricing.worksheet.Range("BE" & Counter).Value = Pricing.worksheet.Range("BE" & Counter).Value + (retEstipulaçoes("kbetr") / 10)
                        clientAPsupport.Add(retEstipulaçoes("bonem"))
                    Case "YABV"
                        Pricing.worksheet.Range("BF" & Counter).Value = Pricing.worksheet.Range("BF" & Counter).Value + retEstipulaçoes("kbetr")
                        clientAPsupport.Add(retEstipulaçoes("bonem"))

                        ''incentives....
                    Case "YOCM"
                        Pricing.worksheet.Range("BG" & Counter).Value = Pricing.worksheet.Range("BG" & Counter).Value + retEstipulaçoes("kbetr")
                        clientRappel.Add(retEstipulaçoes("bonem"))

                        ''Rappel....
                    Case "YRRV"
                        Pricing.worksheet.Range("BI" & Counter).Value = Pricing.worksheet.Range("BI" & Counter).Value + retEstipulaçoes("kbetr")
                        clientRappel.Add(retEstipulaçoes("bonem"))
                    Case "YRRP"
                        Pricing.worksheet.Range("BJ" & Counter).Value = Pricing.worksheet.Range("BJ" & Counter).Value + (retEstipulaçoes("kbetr") / 10)
                        clientRappel.Add(retEstipulaçoes("bonem"))
                        ''Commisions normais
                    Case "YCOP"
                        countcomm = countcomm + 1
                        If countcomm = 1 Then
                            Pricing.worksheet.Range("BM" & Counter).Value = retEstipulaçoes("kbetr") / 10
                            Pricing.worksheet.Range("BN" & Counter).Value = retEstipulaçoes("bonem")
                        ElseIf countcomm = 2 Then
                            Pricing.worksheet.Range("BO" & Counter).Value = retEstipulaçoes("kbetr") / 10
                            Pricing.worksheet.Range("BP" & Counter).Value = retEstipulaçoes("bonem")
                        ElseIf countcomm = 3 Then
                            Pricing.worksheet.Range("BQ" & Counter).Value = retEstipulaçoes("kbetr") / 10
                            Pricing.worksheet.Range("BR" & Counter).Value = retEstipulaçoes("bonem")
                        Else
                            MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                        End If
                        ''Commisions smartwine
                    Case "YEST"
                        countcomm = countcomm + 1
                        If countcomm = 1 Then
                            Pricing.worksheet.Range("BM" & Counter).Value = retEstipulaçoes("kbetr") / 10
                            Pricing.worksheet.Range("BN" & Counter).Value = retEstipulaçoes("bonem")
                        ElseIf countcomm = 2 Then
                            Pricing.worksheet.Range("BO" & Counter).Value = retEstipulaçoes("kbetr") / 10
                            Pricing.worksheet.Range("BP" & Counter).Value = retEstipulaçoes("bonem")
                        ElseIf countcomm = 3 Then
                            Pricing.worksheet.Range("BQ" & Counter).Value = retEstipulaçoes("kbetr") / 10
                            Pricing.worksheet.Range("BR" & Counter).Value = retEstipulaçoes("bonem")
                        Else
                            MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                        End If

                End Select

                'Dim distinctNamesclientpricesupport = clientpricesupport.Distinct()
                'Dim distinctNamesclientpricesupportitem As String
                'For Each distinctNamesclientpricesupportitem In distinctNamesclientpricesupport
                '    Dim stringps = ""
                '    stringps = stringps & distinctNamesclientpricesupportitem & " - "
                '    Form1.worksheet.Range("BC" & ultimalinha).Value = stringps.Trim(" - ")
                'Next
                'Dim distinctNamesclientAPsupport = clientAPsupport.Distinct()
                'Dim distinctNamesclientAPsupportitem As String
                'For Each distinctNamesclientAPsupportitem In distinctNamesclientAPsupport
                '    Dim stringAP = ""
                '    stringAP = stringAP & distinctNamesclientAPsupportitem & " - "
                '    Form1.worksheet.Range("BH" & ultimalinha).Value = stringAP.Trim(" - ")
                'Next
                'Dim distinctNamesclientrappel = clientRappel.Distinct()
                'Dim distinctNamesclientrappelitem As String
                'For Each distinctNamesclientrappelitem In distinctNamesclientrappel
                '    Dim stringR = ""
                '    stringR = stringR & distinctNamesclientrappelitem & " - "
                '    Form1.worksheet.Range("BL" & ultimalinha).Value = stringR.Trim(" - ")
                'Next

            Loop


            '''''FIM LINHA Estipulaçoes
            '''''FIM LINHA Estipulaçoes
            '''''FIM LINHA Estipulaçoes







        Next
    End Sub



    Private Sub GoalSeek(cell As DevExpress.Spreadsheet.Cell, value As Double, changingCell As DevExpress.Spreadsheet.Cell)

        Dim delta As Double = 0.1
        Dim previousDistance As Decimal = 0

        While Math.Abs(cell.Value.NumericValue - value) > 0.001
            changingCell.Value = changingCell.Value.NumericValue + delta
            Dim currentDistance As Double = Math.Abs(cell.Value.NumericValue - value)
            delta = currentDistance * delta / (previousDistance - currentDistance)
            previousDistance = currentDistance
        End While




    End Sub



    Private Sub ButtonEstipulacoes_Click(sender As Object, e As EventArgs) Handles ButtonEstipulacoes.Click
        Dim form As New FormEstipulacoes
        form.ShowDialog()
    End Sub



    Private Sub TextAnoPricing_Click(sender As Object, e As EventArgs) Handles TextAnoPricing.Click
        SendKeys.Send("{F2}")
    End Sub

    Private Sub TextAnoPricing_InvalidValue(sender As Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles TextAnoPricing.InvalidValue
        e.ErrorText = "Introduza um ANO correcto."


    End Sub

    Private Sub TextAnoPricing_EditValueChanged(sender As Object, e As EventArgs) Handles TextAnoPricing.EditValueChanged
        If Len(sender.editvalue) = 4 Then TextAnoPricing.DoValidate()
    End Sub
End Class
