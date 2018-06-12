Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors




Public Class FormEstipulacoes
   

    Public Sheet1cellG6 As String
    Public Sheet1cellI6 As String

    Private Sub FormEstipulacoes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.SapContratosTableAdapter.FillBy(Me.SapPricingDataset1.SapContratos, Sheet1cellG6, Sheet1cellI6)

        RepositoryItemGridLookUpEdit2.DataSource = Pricing.MatnrKmeinDataTable
        RepositoryItemGridLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        RepositoryItemGridLookUpEdit2.DisplayMember = "Material"
        RepositoryItemGridLookUpEdit2.ValueMember = "Material"


        GridControl1.DataSource = Pricing.estipulacaoDataTable
        GridView1.BestFitColumns()
    End Sub



    Private Sub FormEstipulacoes_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
#Disable Warning BC42016 ' Implicit conversion from 'BaseView' to 'ColumnView'.
        Dim view As ColumnView = GridControl1.FocusedView
#Enable Warning BC42016 ' Implicit conversion from 'BaseView' to 'ColumnView'.
        view.CloseEditor()
        view.UpdateCurrentRow()


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
        Dim val4 As Object = view.GetRowCellValue(view.FocusedRowHandle, "DATAB")
        Dim val5 As Object = view.GetRowCellValue(view.FocusedRowHandle, "DATBI")
        Dim val6 As Object = view.GetRowCellValue(view.FocusedRowHandle, "VKORG")

        Dim parentView As GridView = CType(Me.GridControl1.FocusedView, GridView)
        parentView.SetFocusedRowCellValue(parentView.Columns("Num"), edit.EditValue)
        parentView.SetFocusedRowCellValue(parentView.Columns("TipoContrato"), val)
        parentView.SetFocusedRowCellValue(parentView.Columns("Beneficiario"), val2)
        parentView.SetFocusedRowCellValue(parentView.Columns("DataInicio"), val4)
        parentView.SetFocusedRowCellValue(parentView.Columns("DataFim"), val5)
        parentView.SetFocusedRowCellValue(parentView.Columns("vkorg"), val6)

#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
        filtarRepositoryItemTipoCond(val)
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
    End Sub

    Private Sub RepositoryItemGridLookUpEdit2_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles RepositoryItemGridLookUpEdit2.EditValueChanged
        Dim edit As GridLookUpEdit = CType(sender, GridLookUpEdit)
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
        If edit.EditValue = "ALL" Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.

            MsgBox("ALL")
            Dim flagvalor = False
            Dim RetValor = 0
            Do While flagvalor = False
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Integer'.
                RetValor = InputBox("Valor?")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Integer'.
                If IsNumeric(RetValor) Then flagvalor = True
            Loop


            Dim dvalue = From row In Pricing.MatnrKmeinDataTable.AsEnumerable()
                          Where Not row.Field(Of String)("Material") = "ALL"
            Dim StartProd = True

            Dim parentView As GridView = CType(Me.GridControl1.FocusedView, GridView)
            Dim val As Object = parentView.GetRowCellValue(parentView.FocusedRowHandle, "Num")
            Dim val2 As Object = parentView.GetRowCellValue(parentView.FocusedRowHandle, "TipoContrato")
            Dim val3 As Object = parentView.GetRowCellValue(parentView.FocusedRowHandle, "Beneficiario")
            Dim val4 As Object = parentView.GetRowCellValue(parentView.FocusedRowHandle, "TipoCondicao")

            For Each m In dvalue
                If StartProd = True Then

                    parentView.SetFocusedRowCellValue(parentView.Columns("Material"), m(0)) ' Sheet1.Range("AC24").value)
                    parentView.SetFocusedRowCellValue(parentView.Columns("kmein"), m(1)) ' Sheet1.Range("BX24").value)
                    parentView.SetFocusedRowCellValue(parentView.Columns("Valor"), RetValor)

                    StartProd = False
                Else

                    Dim newRow = Pricing.estipulacaoDataTable.NewRow
                    newRow(0) = val
                    newRow(1) = val2
                    newRow(2) = val3
                    newRow(3) = Sheet1cellG6
                    newRow(4) = Sheet1cellI6
                    newRow(5) = val4
                    newRow(6) = m(0) 'Sheet1.Range("AC" & Counter2).Value.ToString
                    newRow(7) = RetValor
                    newRow(8) = m(1) 'Sheet1.Range("BX" & Counter2).Value.ToString
                    newRow(9) = "Insert"
                    Pricing.estipulacaoDataTable.Rows.Add(newRow)


                End If


            Next







            Dim ultimalinha As Integer = Pricing.ultimalinha
            For Counter2 = 25 To ultimalinha - 1

               
                ' End If
            Next


        Else

            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(edit.Properties.View, DevExpress.XtraGrid.Views.Grid.GridView)

            Dim val As Object = view.GetRowCellValue(view.FocusedRowHandle, "Unidade")
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
            If val = "ALL" Then Exit Sub
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
            Dim parentView As GridView = CType(Me.GridControl1.FocusedView, GridView)
            parentView.SetFocusedRowCellValue(parentView.Columns("kmein"), val)
        End If

    End Sub



    Private Sub filtarRepositoryItemTipoCond(varTipoContrato As String)


        Select Case UCase(varTipoContrato)
            Case "ZAPB"
                RepositoryItemTipoCond.Items.Clear()
                RepositoryItemTipoCond.Items.Add("YABV")
            Case "ZAPS"
                RepositoryItemTipoCond.Items.Clear()
                RepositoryItemTipoCond.Items.Add("YAPP")
                RepositoryItemTipoCond.Items.Add("YAPV")
            Case "ZCOM"
                RepositoryItemTipoCond.Items.Clear()
                RepositoryItemTipoCond.Items.Add("YCOP")
            Case "ZSYM"
                RepositoryItemTipoCond.Items.Clear()
                RepositoryItemTipoCond.Items.Add("YRRP")
                RepositoryItemTipoCond.Items.Add("YRRV")
                RepositoryItemTipoCond.Items.Add("YSCP")
                RepositoryItemTipoCond.Items.Add("YSCV")
                RepositoryItemTipoCond.Items.Add("YSHP")
                RepositoryItemTipoCond.Items.Add("YSHV")
            Case Else
                RepositoryItemTipoCond.Items.Clear()
        End Select
    End Sub

    'Private Sub RepositoryItemTipoCond_EditValueChanging(sender As System.Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles RepositoryItemTipoCond.EditValueChanging
    '    Dim parentView As GridView = CType(Me.GridControl1.FocusedView, GridView)

    '    Select Case UCase(parentView.GetFocusedRowCellValue(parentView.Columns("TipoContrato")))
    '        Case "ZAPB"
    '            If Not e.NewValue = ("YABV") Then e.Cancel = True
    '        Case "ZAPS"
    '            If Not e.NewValue = ("YAPP") Or Not e.NewValue = ("YAPP") Or _
    '                Not e.NewValue = ("YAPV") Then e.Cancel = True
    '        Case "ZCOM"
    '            If Not e.NewValue = ("YCOP") Then e.Cancel = True
    '        Case "ZSYM"
    '            If Not e.NewValue = ("YRRP") Or Not e.NewValue = ("YRRV") Or _
    '              Not e.NewValue = ("YSCP") Or Not e.NewValue = ("YSCV") Or _
    '                Not e.NewValue = ("YSHP") Or Not e.NewValue = ("YSHV") Then e.Cancel = True
    '        Case Else
    '            e.Cancel = True
    '    End Select


    'End Sub

    Private Sub GridControl1_Click(sender As System.Object, e As System.EventArgs) Handles GridControl1.Click

    End Sub

    ' Private Sub RepositoryItemTipoCond_Popup(sender As System.Object, e As System.EventArgs) Handles RepositoryItemTipoCond.Popup
    'Dim edit As ComboBoxEdit = CType(sender, ComboBoxEdit)
    'Dim parentView As GridView = CType(Me.GridControl1.FocusedView, GridView)
    'Select Case UCase(parentView.GetFocusedRowCellValue(parentView.Columns("TipoContrato")))
    '    Case "ZAPB"
    '        edit.Properties.Items.Clear()
    '        edit.Properties.Items.Add("YABV")
    '    Case "ZAPS"
    '        edit.Properties.Items.Clear()
    '        edit.Properties.Items.Add("YAPP")
    '        edit.Properties.Items.Add("YAPV")
    '    Case "ZCOM"
    '        edit.Properties.Items.Clear()
    '        edit.Properties.Items.Add("YCOP")
    '    Case "ZSYM"
    '        edit.Properties.Items.Clear()
    '        edit.Properties.Items.Add("YRRP")
    '        edit.Properties.Items.Add("YRRV")
    '        edit.Properties.Items.Add("YSCP")
    '        edit.Properties.Items.Add("YSCV")
    '        edit.Properties.Items.Add("YSHP")
    '        edit.Properties.Items.Add("YSHV")
    '    Case Else
    '        edit.Properties.Items.Clear()
    'End Select
    ' End Sub
End Class