Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.Spreadsheet
Imports System.Data.SQLite

Public Class FormEstipulacoes
    Public MatnrKmeinDataTable As DataTable
    Public columnMatnr As Global.System.Data.DataColumn
    Public columnKmein As Global.System.Data.DataColumn

    Private Sub FormEstipulacoes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SapPricingDataset1.SAPT685T' table. You can move, or remove it, as needed.
        'Me.SAPT685TTableAdapter.Fill(Me.SapPricingDataset1.SAPT685T)


        Dim SqlConnection1 As New System.Data.SQLite.SQLiteConnection ' OleDb.OleDbConnection
        SqlConnection1.ConnectionString = My.Settings.PricingConnectionString
        SqlConnection1.Open()

        Dim sqlcommand1 As New SQLiteCommand ' OleDb.OleDbCommand
        sqlcommand1.CommandText = "SELECT KSCHL, VTEXT FROM SAPT685T"
        sqlcommand1.Connection = SqlConnection1
        Dim dtSAPT685T As New DataTable()
        dtSAPT685T.Load(sqlcommand1.ExecuteReader())
        SAPT685TBindingSource.DataSource = dtSAPT685T

        Dim sqlcommand2 As New SQLiteCommand ' OleDb.OleDbCommand
        sqlcommand2.CommandText = "SELECT KNUMA, BOART, BONEM, BOTEXT AS NAME1, DATAB, DATBI, VKORG FROM SapContratos
        WHERE (DATAB <= " & Pricing.worksheet.Range("G6").Value.ToString & ") AND (DATBI >= " & Pricing.worksheet.Range("I6").Value.ToString & ")"
        sqlcommand2.Connection = SqlConnection1
        Dim dtSapContratos As New DataTable()
        dtSapContratos.Load(sqlcommand2.ExecuteReader())
        SapContratosBindingSource.DataSource = dtSapContratos


        If Pricing.worksheet.Range("I5").Value = "946" Then
            SapContratosBindingSource.Filter = "BOART = 'ZEST'"
        Else
            SapContratosBindingSource.Filter = "BOART <> 'ZEST'"
        End If

        MatnrKmeinDataTable = New DataTable()
        columnMatnr = New Global.System.Data.DataColumn("Material", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnMatnr.AllowDBNull = False
        MatnrKmeinDataTable.Columns.Add(columnMatnr)
        columnKmein = New Global.System.Data.DataColumn("Unidade", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnKmein.AllowDBNull = False
        MatnrKmeinDataTable.Columns.Add(columnKmein)


        'Dim ultimalinha As Integer = Globals.Sheet1.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row
        Dim rows As RowCollection = Pricing.worksheet.Rows
        Dim ultimalinha As Integer = rows.LastUsedIndex
        ultimalinha += 1

        For Counter2 = 24 To ultimalinha
            Dim newRow = MatnrKmeinDataTable.NewRow
            newRow(0) = Pricing.worksheet.Range("AC" & Counter2).Value.ToString
            newRow(1) = Pricing.worksheet.Range("BX" & Counter2).Value.ToString
            MatnrKmeinDataTable.Rows.Add(newRow)
        Next
        Dim newRow2 = MatnrKmeinDataTable.NewRow
        newRow2(0) = "ALL"
        newRow2(1) = "ALL"
        MatnrKmeinDataTable.Rows.Add(newRow2)

        RepositoryItemGridLookUpEdit2.DataSource = MatnrKmeinDataTable
        RepositoryItemGridLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        RepositoryItemGridLookUpEdit2.DisplayMember = "Material"
        RepositoryItemGridLookUpEdit2.ValueMember = "Material"


        GridControl1.DataSource = "" 'Globals.ThisWorkbook.estipulacaoDataTable
        GridView1.BestFitColumns()
    End Sub



    Public Sub recalcularestipulacoes()



        Dim varPCDATI = Pricing.worksheet.Range("G6").Value
        Dim varPCDATF = Pricing.worksheet.Range("I6").Value
        Dim tabela = Pricing.worksheet.Range("I5").Value
        Dim clientdest = Pricing.worksheet.Range("D4").Value
        Dim clientfact = Pricing.worksheet.Range("D12").Value
        Dim pricelist = Pricing.worksheet.Range("G5").Value.ToString.Substring(0, 1)
        Dim currency = Pricing.worksheet.Range("L18").Value
        'Dim ultimalinha As Integer = Pricing.worksheet.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row
        Dim rows As RowCollection = Pricing.worksheet.Rows
        Dim ultimalinha As Integer = rows.LastUsedIndex
        ultimalinha += 1
        For Counter2 = 24 To ultimalinha

            Pricing.worksheet.Range("AX" & Counter2).Value = ""
            Pricing.worksheet.Range("AY" & Counter2).Value = ""
            Pricing.worksheet.Range("AZ" & Counter2).Value = ""
            Pricing.worksheet.Range("BA" & Counter2).Value = ""
            Pricing.worksheet.Range("BB" & Counter2).Value = ""
            Pricing.worksheet.Range("BC" & Counter2).Value = ""
            Pricing.worksheet.Range("BD" & Counter2).Value = ""
            Pricing.worksheet.Range("BE" & Counter2).Value = ""
            Pricing.worksheet.Range("BF" & Counter2).Value = ""
            Pricing.worksheet.Range("BG" & Counter2).Value = ""
            Pricing.worksheet.Range("BH" & Counter2).Value = ""
            Pricing.worksheet.Range("BI" & Counter2).Value = ""
            Pricing.worksheet.Range("BJ" & Counter2).Value = ""
            Pricing.worksheet.Range("BM" & Counter2).Value = ""
            Pricing.worksheet.Range("BN" & Counter2).Value = ""
            Pricing.worksheet.Range("BO" & Counter2).Value = ""
            Pricing.worksheet.Range("BP" & Counter2).Value = ""
            Pricing.worksheet.Range("BQ" & Counter2).Value = ""
            Pricing.worksheet.Range("BR" & Counter2).Value = ""

            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes


            Dim varMatnr = Pricing.worksheet.Range("AC" & Counter2).Value

            Dim dvalue = From row In Pricing.estipulacaoDataTable.AsEnumerable()
                         Where row.Field(Of String)("Material") = varMatnr

            Dim countcomm = 0

            For Each m In dvalue

                Dim clientpricesupport As New List(Of String)
                Dim clientAPsupport As New List(Of String)
                Dim clientRappel As New List(Of String)
                Select Case m(5)
                    ''Price Support
                    Case "YSCV" ' Analysis & Others V
                        Pricing.worksheet.Range("BB" & Counter2).Value = Pricing.worksheet.Range("BB" & Counter2).Value + m(7)
                        clientpricesupport.Add(m(2))
                    Case "YSCP" ' Analysis & Others P
                        Pricing.worksheet.Range("BC" & Counter2).Value = Pricing.worksheet.Range("BC" & Counter2).Value + (m(7))
                        clientpricesupport.Add(m(2))


                    Case "YSNV" ' Credit note V
                        Pricing.worksheet.Range("AX" & Counter2).Value = Pricing.worksheet.Range("AX" & Counter2).Value + m(7)
                        clientpricesupport.Add(m(2))
                    Case "YSNP" ' Credit note P
                        Pricing.worksheet.Range("AY" & Counter2).Value = Pricing.worksheet.Range("AY" & Counter2).Value + m(7)
                        clientpricesupport.Add(m(2))

                    Case "YSHV" ' Charged by customer V
                        Pricing.worksheet.Range("AZ" & Counter2).Value = Pricing.worksheet.Range("AZ" & Counter2).Value + m(7)
                        clientpricesupport.Add(m(2))
                    Case "YSHP" ' Charged by customer P
                        Pricing.worksheet.Range("BA" & Counter2).Value = Pricing.worksheet.Range("BA" & Counter2).Value + (m(7))
                        clientpricesupport.Add(m(2))

                        ''A&P Support
                    Case "YAPV"
                        Pricing.worksheet.Range("BD" & Counter2).Value = Pricing.worksheet.Range("BD" & Counter2).Value + m(7)
                        clientAPsupport.Add(m(2))
                    Case "YAPP"
                        Pricing.worksheet.Range("BE" & Counter2).Value = Pricing.worksheet.Range("BE" & Counter2).Value + (m(7))
                        clientAPsupport.Add(m(2))
                    Case "YABV"
                        Pricing.worksheet.Range("BF" & Counter2).Value = Pricing.worksheet.Range("BF" & Counter2).Value + m(7)
                        clientAPsupport.Add(m(2))

                        ''incentives....
                    Case "YOCM"
                        Pricing.worksheet.Range("BI" & Counter2).Value = Pricing.worksheet.Range("BI" & Counter2).Value + m(7)
                        clientRappel.Add(m(2))

                        ''Rappel....
                    Case "YRRV"
                        Pricing.worksheet.Range("BI" & Counter2).Value = Pricing.worksheet.Range("BI" & Counter2).Value + m(7)
                        clientRappel.Add(m(2))
                    Case "YRRP"
                        Pricing.worksheet.Range("BJ" & Counter2).Value = Pricing.worksheet.Range("BJ" & Counter2).Value + (m(7))
                        clientRappel.Add(m(2))


                        ''Commisions
                    Case "YCOP"
                        countcomm = countcomm + 1
                        If countcomm = 1 Then
                            Pricing.worksheet.Range("BM" & Counter2).Value = m(7)
                            Pricing.worksheet.Range("BN" & Counter2).Value = m(2)
                        ElseIf countcomm = 2 Then
                            Pricing.worksheet.Range("BO" & Counter2).Value = m(7)
                            Pricing.worksheet.Range("BP" & Counter2).Value = m(2)
                        ElseIf countcomm = 3 Then
                            Pricing.worksheet.Range("BQ" & Counter2).Value = m(7)
                            Pricing.worksheet.Range("BR" & Counter2).Value = m(2)
                        Else
                            MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                        End If
                    Case "YEST"
                        countcomm = countcomm + 1
                        If countcomm = 1 Then
                            Pricing.worksheet.Range("BM" & Counter2).Value = m(7)
                            Pricing.worksheet.Range("BN" & Counter2).Value = m(2)
                        ElseIf countcomm = 2 Then
                            Pricing.worksheet.Range("BO" & Counter2).Value = m(7)
                            Pricing.worksheet.Range("BP" & Counter2).Value = m(2)
                        ElseIf countcomm = 3 Then
                            Pricing.worksheet.Range("BQ" & Counter2).Value = m(7)
                            Pricing.worksheet.Range("BR" & Counter2).Value = m(2)
                        Else
                            MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                        End If
                End Select

                'Dim distinctNamesclientpricesupport = clientpricesupport.Distinct()
                'Dim distinctNamesclientpricesupportitem As String
                'Dim stringps = ""
                'For Each distinctNamesclientpricesupportitem In distinctNamesclientpricesupport
                '    stringps = stringps & distinctNamesclientpricesupportitem & " - "
                'Next
                'If stringps.Length > 0 Then Pricing.worksheet.Range("BC" & Counter2).Value = stringps.Substring(0, stringps.Length - 3)

                'Dim distinctNamesclientAPsupport = clientAPsupport.Distinct()
                'Dim distinctNamesclientAPsupportitem As String
                'Dim stringAP = ""
                'For Each distinctNamesclientAPsupportitem In distinctNamesclientAPsupport
                '    stringAP = stringAP & distinctNamesclientAPsupportitem & " - "
                'Next
                'If stringAP.Length > 0 Then Pricing.worksheet.Range("BH" & Counter2).Value = stringAP.Substring(0, stringAP.Length - 3)

                'Dim distinctNamesclientrappel = clientRappel.Distinct()
                'Dim distinctNamesclientrappelitem As String
                'Dim stringR = ""
                'For Each distinctNamesclientrappelitem In distinctNamesclientrappel
                '    stringR = stringR & distinctNamesclientrappelitem & " - "
                'Next
                'If stringR.Length > 0 Then Pricing.worksheet.Range("BL" & Counter2).Value = stringR.Substring(0, stringR.Length - 3)


            Next
        Next

        '''''FIM LINHA Estipulaçoes
        '''''FIM LINHA Estipulaçoes
        '''''FIM LINHA Estipulaçoes

    End Sub

    Private Sub FormEstipulacoes_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim view As ColumnView = GridControl1.FocusedView
        view.CloseEditor()
        view.UpdateCurrentRow()

        recalcularestipulacoes()
    End Sub

    Private Sub GridView1_InitNewRow(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim view As GridView = CType(sender, GridView)
        view.SetRowCellValue(e.RowHandle, view.Columns("Operacao"), "Insert")

    End Sub




    Private Sub GridView1_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If e.Column.FieldName = "Valor" Then
            If IsDBNull(GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns("Operacao"))) Then
                GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("Operacao"), "Update")
            End If

        End If
    End Sub


    Private Sub RepositoryItemGridLookUpEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles RepositoryItemGridLookUpEdit1.EditValueChanged
        Dim edit As GridLookUpEdit = CType(sender, GridLookUpEdit)
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(edit.Properties.View, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim val As Object = view.GetRowCellValue(view.FocusedRowHandle, "BOART")
        Dim val2 As Object = view.GetRowCellValue(view.FocusedRowHandle, "BONEM")

        ' Dim val4 As Object = view.GetRowCellValue(view.FocusedRowHandle, "DATAB")
        'Dim val5 As Object = view.GetRowCellValue(view.FocusedRowHandle, "DATBI")

        Dim val4 As Object = Pricing.worksheet.Range("G6").Value
        Dim val5 As Object = Pricing.worksheet.Range("I6").Value


        Dim val6 As Object = view.GetRowCellValue(view.FocusedRowHandle, "VKORG")

        Dim parentView As GridView = CType(Me.GridControl1.FocusedView, GridView)
        parentView.SetFocusedRowCellValue(parentView.Columns("Num"), edit.EditValue)
        parentView.SetFocusedRowCellValue(parentView.Columns("TipoContrato"), val)
        parentView.SetFocusedRowCellValue(parentView.Columns("Beneficiario"), val2)
        parentView.SetFocusedRowCellValue(parentView.Columns("DataInicio"), val4)
        parentView.SetFocusedRowCellValue(parentView.Columns("DataFim"), val5)
        parentView.SetFocusedRowCellValue(parentView.Columns("vkorg"), val6)

        filtarRepositoryItemTipoCond(val)
    End Sub

    Private Sub RepositoryItemGridLookUpEdit2_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles RepositoryItemGridLookUpEdit2.EditValueChanged
        Dim edit As GridLookUpEdit = CType(sender, GridLookUpEdit)
        If edit.EditValue = "ALL" Then

            MsgBox("ALL")
            Dim flagvalor = False
            Dim RetValor As Decimal = 0
            Do While flagvalor = False
                RetValor = InputBox("Valor?")
                If IsNumeric(RetValor) Then flagvalor = True
            Loop

            Dim parentView As GridView = CType(Me.GridControl1.FocusedView, GridView)
            parentView.SetFocusedRowCellValue(parentView.Columns("Material"), Pricing.worksheet.Range("AC24").Value)
            parentView.SetFocusedRowCellValue(parentView.Columns("kmein"), Pricing.worksheet.Range("BX24").Value)
            parentView.SetFocusedRowCellValue(parentView.Columns("Valor"), RetValor)



            Dim val As Object = parentView.GetRowCellValue(parentView.FocusedRowHandle, "Num")
            Dim val2 As Object = parentView.GetRowCellValue(parentView.FocusedRowHandle, "TipoContrato")
            Dim val3 As Object = parentView.GetRowCellValue(parentView.FocusedRowHandle, "Beneficiario")
            Dim val4 As Object = parentView.GetRowCellValue(parentView.FocusedRowHandle, "TipoCondicao")
            Dim val5 As Object = parentView.GetRowCellValue(parentView.FocusedRowHandle, "vkorg")

            Dim varPCDATI = Pricing.worksheet.Range("G6").Value
            Dim varPCDATF = Pricing.worksheet.Range("I6").Value

            'Dim ultimalinha As Integer = Pricing.worksheet.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row
            Dim rows As RowCollection = Pricing.worksheet.Rows
            Dim ultimalinha As Integer = rows.LastUsedIndex


            For Counter2 = 25 To ultimalinha
                If Pricing.worksheet.Range("AD" & Counter2).Value <> 0 Then
                    Dim newRow = Pricing.estipulacaoDataTable.NewRow
                    newRow(0) = val
                    newRow(1) = val2
                    newRow(2) = val3
                    newRow(3) = varPCDATI
                    newRow(4) = varPCDATF
                    newRow(5) = val4
                    newRow(6) = Pricing.worksheet.Range("AC" & Counter2).Value.ToString
                    newRow(7) = RetValor
                    newRow(8) = Pricing.worksheet.Range("BX" & Counter2).Value.ToString
                    newRow(9) = val5
                    newRow(10) = "Insert"
                    Pricing.estipulacaoDataTable.Rows.Add(newRow)
                End If
            Next


        Else

            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(edit.Properties.View, DevExpress.XtraGrid.Views.Grid.GridView)

            Dim val As Object = view.GetRowCellValue(view.FocusedRowHandle, "Unidade")
            If val = "ALL" Then Exit Sub
            Dim parentView As GridView = CType(Me.GridControl1.FocusedView, GridView)
            parentView.SetFocusedRowCellValue(parentView.Columns("kmein"), val)
        End If

    End Sub



    Private Sub filtarRepositoryItemTipoCond(varTipoContrato As String)


        Select Case UCase(varTipoContrato)
            Case "ZAPB"
                SAPT685TBindingSource.Filter = "KSCHL = 'YABV'"
                'RepositoryItemTipoCond.Items.Clear()
                'RepositoryItemTipoCond.Items.Add("YABV")
            Case "ZAPS"
                SAPT685TBindingSource.Filter = "KSCHL = 'YAPP' OR KSCHL = 'YAPV'"
                'RepositoryItemTipoCond.Items.Clear()
                'RepositoryItemTipoCond.Items.Add("YAPP")
                'RepositoryItemTipoCond.Items.Add("YAPV")
            Case "ZCOM"
                SAPT685TBindingSource.Filter = "KSCHL = 'YCOP'"
                'RepositoryItemTipoCond.Items.Clear()
                'RepositoryItemTipoCond.Items.Add("YCOP")
            Case "ZEST"
                SAPT685TBindingSource.Filter = "KSCHL = 'YEST' OR KSCHL = 'YAPP' OR KSCHL = 'YAPV' "
                'RepositoryItemTipoCond.Items.Clear()
                'RepositoryItemTipoCond.Items.Add("YEST")
                'RepositoryItemTipoCond.Items.Add("YAPP")
                'RepositoryItemTipoCond.Items.Add("YAPV")
            Case "ZSYM"
                SAPT685TBindingSource.Filter = "KSCHL = 'YRRP' OR KSCHL = 'YRRV' OR KSCHL = 'YSHP' OR KSCHL = 'YSHV' OR KSCHL = 'YSNP' OR KSCHL = 'YSNV'"

                'RepositoryItemTipoCond.Items.Clear()
                'RepositoryItemTipoCond.Items.Add("YRRP")
                'RepositoryItemTipoCond.Items.Add("YRRV")
                'RepositoryItemTipoCond.Items.Add("YSHP")
                'RepositoryItemTipoCond.Items.Add("YSHV")
            Case "ZOUT"
                SAPT685TBindingSource.Filter = "KSCHL = 'YSCP' OR KSCHL = 'YSCV' "
                'RepositoryItemTipoCond.Items.Clear()
                'RepositoryItemTipoCond.Items.Add("YSCP")
                'RepositoryItemTipoCond.Items.Add("YSCV")
            Case "ZOCM"
                SAPT685TBindingSource.Filter = "KSCHL = 'YOCM'"
                'RepositoryItemTipoCond.Items.Clear()
                'RepositoryItemTipoCond.Items.Add("YOCM")

            Case Else
                RepositoryItemTipoCond.Items.Clear()
        End Select
    End Sub

    'Public Function GetData() As DataTable
    '    Dim table As New DataTable()
    '    table.Columns.Add(New DataColumn("TipoCondição", GetType(String)))
    '    table.Columns.Add(New DataColumn("Nome", GetType(String)))


    '    Dim dvalue = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                 Where row.Field(Of String)("KSCHL") = "YABV"
    '                 Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YABV", dvalue(0)})

    '    Dim dvalue2 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                  Where row.Field(Of String)("KSCHL") = "YAPP"
    '                  Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YAPP", dvalue2(0)})

    '    Dim dvalue3 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                  Where row.Field(Of String)("KSCHL") = "YAPV"
    '                  Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YAPV", dvalue3(0)})

    '    Dim dvalue4 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                  Where row.Field(Of String)("KSCHL") = "YCOP"
    '                  Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YCOP", dvalue4(0)})

    '    Dim dvalue5 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                  Where row.Field(Of String)("KSCHL") = "YEST"
    '                  Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YEST", dvalue5(0)})

    '    Dim dvalue6 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                  Where row.Field(Of String)("KSCHL") = "YRRP"
    '                  Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YRRP", dvalue6(0)})

    '    Dim dvalue7 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                  Where row.Field(Of String)("KSCHL") = "YRRV"
    '                  Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YRRV", dvalue7(0)})

    '    Dim dvalue8 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                  Where row.Field(Of String)("KSCHL") = "YSHP"
    '                  Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YSHP", dvalue8(0)})

    '    Dim dvalue9 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                  Where row.Field(Of String)("KSCHL") = "YSHV"
    '                  Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YSHV", dvalue9(0)})

    '    Dim dvalue10 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                   Where row.Field(Of String)("KSCHL") = "YSCP"
    '                   Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YSCP", dvalue10(0)})

    '    Dim dvalue11 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                   Where row.Field(Of String)("KSCHL") = "YSCV"
    '                   Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YSCV", dvalue11(0)})

    '    Dim dvalue12 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                   Where row.Field(Of String)("KSCHL") = "YOCM"
    '                   Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YOCM", dvalue12(0)})

    '    Dim dvalue13 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                   Where row.Field(Of String)("KSCHL") = "YSNV"
    '                   Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YSNV", dvalue13(0)})

    '    Dim dvalue14 = From row In Me.SapPricingDataset1.SAPT685T.AsEnumerable()
    '                   Where row.Field(Of String)("KSCHL") = "YSNP"
    '                   Select row.Field(Of String)("VTEXT")
    '    table.Rows.Add(New Object() {"YSNP", dvalue14(0)})

    '    Return table
    'End Function



End Class