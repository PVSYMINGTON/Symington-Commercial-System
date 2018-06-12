Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Utils.Menu
Imports System.Windows.Forms
Imports System.Drawing

Public Class FormPivotComp
    Public vardatabase As String
    Public vartabela As String
    Public strsel As String
    Public strsel1 As String
    Public filterkeydir As String
    Public filterkeypais As String
    Public filterkeycli As String
    Public filterkeycomp As String
    Public filterkeymarca As String
    Public filterkeytype As String
    Public filterkeygroup As String
    Public filterkeyprod As String
    Public flagfilterkeyprod As String
    Public flagfilterkeydir As String
    Public filterkeyAnocol As String
    Public filterkeypackage As String
    Public filtergrid As Boolean
    Public Groupmarket As Boolean
    Public Groupcompany As Boolean
    Public Grouptype As Boolean
    Public Groupgroup As Boolean
    Public Groupsubcat As Boolean
    Public Groupproduct As Boolean
    Public Grouppackage As Boolean
    Public GroupTrademark As Boolean
    Public GroupVintageYear As Boolean

    Public filtermark As String

    Dim labeldir As New DevExpress.XtraBars.BarEditItem
    Dim labelpais As New DevExpress.XtraBars.BarEditItem
    Dim labelcli As New DevExpress.XtraBars.BarEditItem
    Dim labelcomp As New DevExpress.XtraBars.BarEditItem
    Dim labeltype As New DevExpress.XtraBars.BarEditItem
    Dim labelmarca As New DevExpress.XtraBars.BarEditItem
    Dim labelgroup As New DevExpress.XtraBars.BarEditItem
    Dim labelprod As New DevExpress.XtraBars.BarEditItem
    Dim labelanocol As New DevExpress.XtraBars.BarEditItem
    Dim labelpack As New DevExpress.XtraBars.BarEditItem



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Width = Me.MdiParent.ClientSize.Width - 4
        Me.Height = Me.MdiParent.ClientSize.Height - 4

        If vartabela = "vendasportomescomp2" Or vartabela = "vendasportomescompvalor2" Then
            fieldJAN.Caption = "Jan" & Now.Year - 1
            fieldFEV.Caption = "Fev" & Now.Year - 1
            fieldMAR.Caption = "Mar" & Now.Year - 1
            fieldABE.Caption = "Abr" & Now.Year - 1
            fieldMAI.Caption = "Mai" & Now.Year - 1
            fieldJUN.Caption = "Jun" & Now.Year - 1
            fieldJUL.Caption = "Jul" & Now.Year - 1
            fieldAGO.Caption = "Ago" & Now.Year - 1
            fieldSET.Caption = "Set" & Now.Year - 1
            fieldOUT.Caption = "Out" & Now.Year - 1
            fieldNOV.Caption = "Nov" & Now.Year - 1
            fieldDEZ.Caption = "Dez" & Now.Year - 1

            fieldJAN1.Caption = "Jan" & Now.Year - 2
            fieldFEV1.Caption = "Fev" & Now.Year - 2
            fieldMAR1.Caption = "Mar" & Now.Year - 2
            fieldABR1.Caption = "Abr" & Now.Year - 2
            fieldMAI1.Caption = "Mai" & Now.Year - 2
            fieldJUN1.Caption = "Jun" & Now.Year - 2
            fieldJUL1.Caption = "Jul" & Now.Year - 2
            fieldAGO1.Caption = "Ago" & Now.Year - 2
            fieldSET1.Caption = "Set" & Now.Year - 2
            fieldOUT1.Caption = "Out" & Now.Year - 2
            fieldNOV1.Caption = "Nov" & Now.Year - 2
            fieldDEZ1.Caption = "Dez" & Now.Year - 2

            fieldSales.Caption = "ShippedLY"
            fieldSalesLY.Caption = "ShippYear-2"

        Else
            fieldJAN.Caption = "Jan" & Now.Year
            fieldFEV.Caption = "Fev" & Now.Year
            fieldMAR.Caption = "Mar" & Now.Year
            fieldABE.Caption = "Abr" & Now.Year
            fieldMAI.Caption = "Mai" & Now.Year
            fieldJUN.Caption = "Jun" & Now.Year
            fieldJUL.Caption = "Jul" & Now.Year
            fieldAGO.Caption = "Ago" & Now.Year
            fieldSET.Caption = "Set" & Now.Year
            fieldOUT.Caption = "Out" & Now.Year
            fieldNOV.Caption = "Nov" & Now.Year
            fieldDEZ.Caption = "Dez" & Now.Year

            fieldJAN1.Caption = "Jan" & Now.Year - 1
            fieldFEV1.Caption = "Fev" & Now.Year - 1
            fieldMAR1.Caption = "Mar" & Now.Year - 1
            fieldABR1.Caption = "Abr" & Now.Year - 1
            fieldMAI1.Caption = "Mai" & Now.Year - 1
            fieldJUN1.Caption = "Jun" & Now.Year - 1
            fieldJUL1.Caption = "Jul" & Now.Year - 1
            fieldAGO1.Caption = "Ago" & Now.Year - 1
            fieldSET1.Caption = "Set" & Now.Year - 1
            fieldOUT1.Caption = "Out" & Now.Year - 1
            fieldNOV1.Caption = "Nov" & Now.Year - 1
            fieldDEZ1.Caption = "Dez" & Now.Year - 1

        End If
        If vartabela = "vendasportomescompvalor" Or vartabela = "vendasportomescompvalor2" Then
            fieldForecast.Visible = False
            fieldForecast.Index = -1
            fieldTarget.Visible = False
            fieldTarget.Index = -1
            DifeForeca.Visible = False
            DifeForecastinchand.Visible = False
            DifeForecaTLM.Visible = False
            DifeTarget.Visible = False
            DifeTargetincand.Visible = False
            DifeTargetTLM.Visible = False

            fieldSales.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldForecast.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldHAND.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldSalesYTDLY.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldTarget.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            salesendmonth.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            salesendmonthLY.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldSalesLY.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric

            fieldJAN.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldFEV.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldMAR.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldABE.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldMAI.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldJUN.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldJUL.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldAGO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldSET.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldOUT.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldNOV.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldDEZ.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldJAN1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldFEV1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldMAR1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldABR1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldMAI1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldJUN1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldJUL1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldAGO1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldSET1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldOUT1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldNOV1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldDEZ1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric

            fieldSales.GrandTotalCellFormat.FormatString = "#,##0.0€"
            'fieldForecast.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldHAND.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldSalesYTDLY.GrandTotalCellFormat.FormatString = "#,##0.0€"
            'fieldTarget.GrandTotalCellFormat.FormatString = "#,##0.0€"
            salesendmonth.GrandTotalCellFormat.FormatString = "#,##0.0€"
            salesendmonthLY.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldSalesLY.GrandTotalCellFormat.FormatString = "#,##0.0€"

            fieldJAN.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldFEV.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldMAR.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldABE.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldMAI.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldJUN.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldJUL.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldAGO.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldSET.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldOUT.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldNOV.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldDEZ.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldJAN1.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldFEV1.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldMAR1.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldABR1.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldMAI1.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldJUN1.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldJUL1.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldAGO1.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldSET1.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldOUT1.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldNOV1.GrandTotalCellFormat.FormatString = "#,##0.0€"
            fieldDEZ1.GrandTotalCellFormat.FormatString = "#,##0.0€"


        End If

        '''''''''''''''''''Filtro
        Dim myArraydir() As String = Split(filterkeydir, "'")
        If myArraydir(1) = "%" Then
            'labeldir.Text = "ALL"
        ElseIf myArraydir.Length = 3 Then
            '     Dim labeldir As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labeldir)
            RibbonPageGroup1.ItemLinks.Add(labeldir)
            labeldir.CanOpenEdit = False
            labeldir.Edit = Me.RepositoryItemTextEdit1
            If UCase(flagfilterkeydir) = "DIRECTOR" Then
                labeldir.EditValue = "Director: " & myArraydir(1)
            ElseIf UCase(flagfilterkeydir) = "ASSISTANT" Then
                labeldir.EditValue = "Assistant: " & myArraydir(1)
            Else
                labeldir.EditValue = "Manager: " & myArraydir(1)
            End If
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labeldir.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labeldir.SuperTip = SuperToolTip1
            labeldir.Width = 100 'If(labeldir.EditValue.ToString.Length * 8 > 40, labeldir.EditValue.ToString.Length * 8, 40)
        ElseIf myArraydir.Length > 3 Then
            '   Dim labeldir As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labeldir)
            RibbonPageGroup1.ItemLinks.Add(labeldir)
            labeldir.CanOpenEdit = False
            labeldir.Edit = Me.RepositoryItemTextEdit1
            labeldir.EditValue = myArraydir(1)
            Dim x As Integer
            For x = 3 To myArraydir.Length - 1 Step 2
                labeldir.EditValue = labeldir.EditValue & "/" & myArraydir(x)
                labeldir.Width = 100 'If(labeldir.EditValue.ToString.Length * 8 > 80, labeldir.EditValue.ToString.Length * 8, 80)
            Next x
            If UCase(flagfilterkeydir) = "DIRECTOR" Then
                labeldir.EditValue = "Director: " & labeldir.EditValue
            ElseIf UCase(flagfilterkeydir) = "MANAGER" Then
                labeldir.EditValue = "Manager: " & labeldir.EditValue
            Else
                labeldir.EditValue = "Assistan: " & labeldir.EditValue
            End If
            labeldir.Width = 100
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labeldir.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labeldir.SuperTip = SuperToolTip1
        End If

        Dim myArraydir1() As String = Split(filterkeypais, "'")
        If myArraydir1(1) = "%" Then
            'Label1.Text = "ALL"
        ElseIf myArraydir1.Length = 3 Then
            '    Dim labelpais As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelpais)
            RibbonPageGroup1.ItemLinks.Add(labelpais)
            labelpais.CanOpenEdit = False
            labelpais.Edit = Me.RepositoryItemTextEdit1
            labelpais.EditValue = myArraydir1(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelpais.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelpais.SuperTip = SuperToolTip1
            labelpais.Width = 100 'If(labelpais.EditValue.ToString.Length * 8 > 40, labelpais.EditValue.ToString.Length * 8, 40)
        ElseIf myArraydir1.Length > 3 Then
            '  Dim labelpais As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelpais)
            RibbonPageGroup1.ItemLinks.Add(labelpais)
            labelpais.CanOpenEdit = False
            labelpais.Edit = Me.RepositoryItemTextEdit1
            labelpais.EditValue = myArraydir1(1)
            Dim x As Integer
            For x = 3 To myArraydir1.Length - 1 Step 2
                labelpais.EditValue = labelpais.EditValue & "/" & myArraydir1(x)
                labelpais.Width = 100 'If(labelpais.EditValue.ToString.Length * 8 > 80, labelpais.EditValue.ToString.Length * 8, 80)
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelpais.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelpais.SuperTip = SuperToolTip1
        End If

        Dim myArraydir2() As String = Split(filterkeycli, "'")
        If myArraydir2(1) = "%" Then
            'Label1.Text = "ALL"
        ElseIf myArraydir2.Length = 3 Then
            '  Dim labelcli As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelcli)
            RibbonPageGroup1.ItemLinks.Add(labelcli)
            labelcli.CanOpenEdit = False
            labelcli.Edit = Me.RepositoryItemTextEdit1
            labelcli.EditValue = myArraydir2(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelcli.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelcli.SuperTip = SuperToolTip1
            labelcli.Width = 100 'If(labelcli.EditValue.ToString.Length * 8 > 40, labelcli.EditValue.ToString.Length * 8, 40)
        ElseIf myArraydir2.Length > 3 Then
            '   Dim labelcli As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelcli)
            RibbonPageGroup1.ItemLinks.Add(labelcli)
            labelcli.CanOpenEdit = False
            labelcli.Edit = Me.RepositoryItemTextEdit1
            labelcli.EditValue = myArraydir2(1)
            Dim x As Integer
            For x = 3 To myArraydir2.Length - 1 Step 2
                labelcli.EditValue = labelcli.EditValue & "/" & myArraydir2(x)
                labelcli.Width = 100 'If(labelcli.EditValue.ToString.Length * 8 > 80, labelcli.EditValue.ToString.Length * 8, 80)
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelcli.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelcli.SuperTip = SuperToolTip1
        End If

        Dim myArraydir3() As String = Split(filterkeycomp, "'")
        If myArraydir3(1) = "%" Then
            'labelcomp.Text = "ALL"
        ElseIf myArraydir3.Length = 3 Then
            'Dim labelcomp As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelcomp)
            RibbonPageGroup1.ItemLinks.Add(labelcomp)
            labelcomp.CanOpenEdit = False
            labelcomp.Edit = Me.RepositoryItemTextEdit1
            labelcomp.EditValue = myArraydir3(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelcomp.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelcomp.SuperTip = SuperToolTip1
            labelcomp.Width = 100 'If(labelcomp.EditValue.ToString.Length * 8 > 40, labelcomp.EditValue.ToString.Length * 8, 40)
        ElseIf myArraydir3.Length > 3 Then
            ' Dim labelcomp As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelcomp)
            RibbonPageGroup1.ItemLinks.Add(labelcomp)
            labelcomp.CanOpenEdit = False
            labelcomp.Edit = Me.RepositoryItemTextEdit1
            labelcomp.EditValue = myArraydir3(1)
            Dim x As Integer
            For x = 3 To myArraydir3.Length - 1 Step 2
                labelcomp.EditValue = labelcomp.EditValue & "/" & myArraydir3(x)
                labelcomp.Width = 100 'If(labelcomp.EditValue.ToString.Length * 8 > 80, labelcomp.EditValue.ToString.Length * 8, 80)
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelcomp.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelcomp.SuperTip = SuperToolTip1
        End If

        Dim myArraydir4() As String = Split(filterkeytype, "'")
        If myArraydir4(1) = "%" Then
            'labeltype.Text = "ALL"
        ElseIf myArraydir4.Length = 3 Then
            ' Dim labeltype As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labeltype)
            RibbonPageGroup1.ItemLinks.Add(labeltype)
            labeltype.CanOpenEdit = False
            labeltype.Edit = Me.RepositoryItemTextEdit1
            labeltype.EditValue = myArraydir4(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labeltype.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labeltype.SuperTip = SuperToolTip1

            labeltype.Width = 100 'If(labeltype.EditValue.ToString.Length * 8 > 40, labeltype.EditValue.ToString.Length * 8, 40)
        ElseIf myArraydir4.Length > 3 Then
            '   Dim labeltype As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labeltype)
            RibbonPageGroup1.ItemLinks.Add(labeltype)
            labeltype.CanOpenEdit = False
            labeltype.Edit = Me.RepositoryItemTextEdit1
            labeltype.EditValue = myArraydir4(1)
            Dim x As Integer
            For x = 3 To myArraydir4.Length - 1 Step 2
                labeltype.EditValue = labeltype.EditValue & "/" & myArraydir4(x)
                labeltype.Width = 100 'If(labeltype.EditValue.ToString.Length * 8 > 80, labeltype.EditValue.ToString.Length * 8, 80)
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labeltype.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labeltype.SuperTip = SuperToolTip1

        End If

        Dim correctString As String = filterkeymarca.Replace("''", "´")
        Dim myArraydir5() As String = Split(correctString, "'")
        If myArraydir5(1) = "%" Then
            'labelmarca.Text = "ALL"
        ElseIf myArraydir5.Length = 3 Then
            '  Dim labelmarca As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelmarca)
            RibbonPageGroup1.ItemLinks.Add(labelmarca)
            labelmarca.CanOpenEdit = False
            labelmarca.Edit = Me.RepositoryItemTextEdit1
            labelmarca.EditValue = myArraydir5(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelmarca.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelmarca.SuperTip = SuperToolTip1

            labelmarca.Width = 100 'If(labelmarca.EditValue.ToString.Length * 8 > 40, labelmarca.EditValue.ToString.Length * 8, 40)
        ElseIf myArraydir5.Length > 3 Then
            '  Dim labelmarca As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelmarca)
            RibbonPageGroup1.ItemLinks.Add(labelmarca)
            labelmarca.CanOpenEdit = False
            labelmarca.Edit = Me.RepositoryItemTextEdit1
            labelmarca.EditValue = myArraydir5(1)
            Dim x As Integer
            For x = 3 To myArraydir5.Length - 1 Step 2
                labelmarca.EditValue = labelmarca.EditValue & "/" & myArraydir5(x)
                labelmarca.Width = 100 'If(labelmarca.EditValue.ToString.Length * 8 > 80, labelmarca.EditValue.ToString.Length * 8, 80)
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelmarca.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelmarca.SuperTip = SuperToolTip1

        End If

        Dim myArraydir6() As String = Split(filterkeygroup, "'")
        If myArraydir6(1) = "%" Then
            'labelgroup.Text = "ALL"
        ElseIf myArraydir6.Length = 3 Then
            '  Dim labelgroup As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelgroup)
            RibbonPageGroup1.ItemLinks.Add(labelgroup)
            labelgroup.CanOpenEdit = False
            labelgroup.Edit = Me.RepositoryItemTextEdit1
            labelgroup.EditValue = myArraydir6(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelgroup.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelgroup.SuperTip = SuperToolTip1

            labelgroup.Width = 100 'If(labelgroup.EditValue.ToString.Length * 8 > 40, labelgroup.EditValue.ToString.Length * 8, 40)
        ElseIf myArraydir6.Length > 3 Then
            '    Dim labelgroup As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelgroup)
            RibbonPageGroup1.ItemLinks.Add(labelgroup)
            labelgroup.CanOpenEdit = False
            labelgroup.Edit = Me.RepositoryItemTextEdit1
            labelgroup.EditValue = myArraydir6(1)
            Dim x As Integer
            For x = 3 To myArraydir6.Length - 1 Step 2
                labelgroup.EditValue = labelgroup.EditValue & "/" & myArraydir6(x)
                labelgroup.Width = 100 'If(labelgroup.EditValue.ToString.Length * 8 > 80, labelgroup.EditValue.ToString.Length * 8, 80)
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelgroup.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelgroup.SuperTip = SuperToolTip1

        End If

        Dim myArraydir7() As String = Split(filterkeyprod, "'")
        If myArraydir7(1) = "%" Then
            'labelprod.Text = "ALL"
        ElseIf myArraydir7.Length = 3 Then
            '   Dim labelprod As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelprod)
            RibbonPageGroup1.ItemLinks.Add(labelprod)
            labelprod.CanOpenEdit = False
            labelprod.Edit = Me.RepositoryItemTextEdit1
            If UCase(flagfilterkeyprod) = "SUBCAT" Then labelprod.EditValue = "Subcat: " & myArraydir7(1) Else labelprod.EditValue = "Family: " & myArraydir7(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelprod.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelprod.SuperTip = SuperToolTip1
            labelprod.Width = 100 'If(labelprod.EditValue.ToString.Length * 8 > 40, labelprod.EditValue.ToString.Length * 8, 40)
        ElseIf myArraydir7.Length > 3 Then
            '    Dim labelprod As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelprod)
            RibbonPageGroup1.ItemLinks.Add(labelprod)
            labelprod.CanOpenEdit = False
            labelprod.Edit = Me.RepositoryItemTextEdit1
            labelprod.EditValue = myArraydir7(1)
            Dim x As Integer
            For x = 3 To myArraydir7.Length - 1 Step 2
                labelprod.EditValue = labelprod.EditValue & "/" & myArraydir7(x)
            Next x
            If UCase(flagfilterkeyprod) = "SUBCAT" Then labelprod.EditValue = "Subcat: " & labelprod.EditValue Else labelprod.EditValue = "Family: " & labelprod.EditValue
            labelprod.Width = 100 'If(labelprod.EditValue.ToString.Length * 8 > 80, labelprod.EditValue.ToString.Length * 8, 80)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelprod.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelprod.SuperTip = SuperToolTip1
        End If

        Dim myArraydir8() As String = Split(filterkeyAnocol, "'")
        If myArraydir8(1) = "%" Then
            'labelanocol.Text = "ALL"
        ElseIf myArraydir8.Length = 3 Then
            '   Dim labelanocol As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelanocol)
            RibbonPageGroup1.ItemLinks.Add(labelanocol)
            labelanocol.CanOpenEdit = False
            labelanocol.Edit = Me.RepositoryItemTextEdit1
            labelanocol.EditValue = myArraydir8(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelanocol.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelanocol.SuperTip = SuperToolTip1
            labelanocol.Width = 100 'If(labelanocol.EditValue.ToString.Length * 8 > 40, labelanocol.EditValue.ToString.Length * 8, 40)
        ElseIf myArraydir8.Length > 3 Then
            '    Dim labelanocol As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelanocol)
            RibbonPageGroup1.ItemLinks.Add(labelanocol)
            labelanocol.CanOpenEdit = False
            labelanocol.Edit = Me.RepositoryItemTextEdit1
            labelanocol.EditValue = myArraydir8(1)
            Dim x As Integer
            For x = 3 To myArraydir8.Length - 1 Step 2
                labelanocol.EditValue = labelanocol.EditValue & "/" & myArraydir8(x)
                labelanocol.Width = 100 'If(labelanocol.EditValue.ToString.Length * 8 > 80, labelanocol.EditValue.ToString.Length * 8, 80)
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelanocol.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelanocol.SuperTip = SuperToolTip1
        End If

        Dim myArraydir9() As String = Split(filterkeypackage, "'")
        If myArraydir9(1) = "%" Then
            'labelpack.Text = "ALL"
        ElseIf myArraydir9.Length = 3 Then
            '   Dim labelpack As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelpack)
            RibbonPageGroup1.ItemLinks.Add(labelpack)
            labelpack.CanOpenEdit = False
            labelpack.Edit = Me.RepositoryItemTextEdit1
            labelpack.EditValue = myArraydir9(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelpack.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelpack.SuperTip = SuperToolTip1
            labelpack.Width = 100 'If(labelpack.EditValue.ToString.Length * 8 > 40, labelpack.EditValue.ToString.Length * 8, 40)
        ElseIf myArraydir9.Length > 3 Then
            '    Dim labelpack As New DevExpress.XtraBars.BarEditItem
            RibbonControl1.Items.Add(labelpack)
            RibbonPageGroup1.ItemLinks.Add(labelpack)
            labelpack.CanOpenEdit = False
            labelpack.Edit = Me.RepositoryItemTextEdit1
            labelpack.EditValue = myArraydir9(1)
            Dim x As Integer
            For x = 3 To myArraydir9.Length - 1 Step 2
                labelpack.EditValue = labelpack.EditValue & "/" & myArraydir9(x)
                labelpack.Width = 100 'If(labelpack.EditValue.ToString.Length * 8 > 80, labelpack.EditValue.ToString.Length * 8, 80)
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelpack.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelpack.SuperTip = SuperToolTip1
        End If

        ''''''''''''''end Filtros


        ''''''' label do Layout
        'Dim labellayout As New DevExpress.XtraBars.BarEditItem
        'RibbonControl1.Items.Add(labellayout)
        'Layoutapplied.ItemLinks.Add(labellayout)
        'labellayout.CanOpenEdit = False
        'labellayout.Edit = Me.RepositoryItemTextEdit1
        'labellayout.EditValue = "ShippedtillendlastMonth"

        '  Dim SuperToolTip11 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '  Dim ToolTipItem11 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '  ToolTipItem11.Text = labellayout.EditValue
        '  SuperToolTip11.Items.Add(ToolTipItem11)
        '  labellayout.SuperTip = SuperToolTip11
        '  labellayout.Width = 200






        'RibbonControl1.Minimized = True
        Dim splitstr() As String = {"GROUP"}
        Dim splitstr2() As String = {"VendasportoMesCOMP"}
        Dim result As String = ""
        result = OleDbDataAdapter1.SelectCommand.CommandText
        Dim varstr2() As String = result.Split(splitstr2, StringSplitOptions.None)
        result = varstr2(0) & vartabela & varstr2(1)
        Dim varstr() As String = result.Split(splitstr, StringSplitOptions.None)
        OleDbDataAdapter1.SelectCommand.CommandText = varstr(0) & " " & _
        " WHERE (" & filterkeydir & ") AND (" & filterkeypais & ") AND (" & filterkeycli & ") AND (" & filterkeycomp & ") AND (" & filterkeymarca & ") AND (" & filterkeytype & ") AND (" & filterkeygroup & ") AND (" & filterkeyprod & ") AND (" & filterkeyAnocol & ") AND (" & filterkeypackage & ") AND (Produto LIKE '%" & filtermark & "%') Group " & _
        varstr(1)
        OleDbDataAdapter1.Fill(DataSet11)


    End Sub


    Private Sub PivotGridControl1_CustomUnboundFieldData(ByVal sender As System.Object, ByVal e As DevExpress.XtraPivotGrid.CustomFieldDataEventArgs) Handles PivotGridControl1.CustomUnboundFieldData

        ' If e.Field.Name = "fieldVintage" Then
        ' Dim subs As String
        ' subs = e.GetListSourceColumnValue("Subcat").ToString.ToUpper
        ' If subs.StartsWith("VINTAGE") Or subs.StartsWith("QUINTAS") Then
        ' e.Value = 1
        ' Else
        ' e.Value = 0
        '
        '      End If
        '           End If

        If e.Field Is fieldPortConsumoBrandy Then
            Dim subs As String
            subs = e.GetListSourceColumnValue("Tipo").ToString.ToUpper

            If subs.StartsWith("PORT") Then
                e.Value = "Port"
            ElseIf subs.StartsWith("CONSUMO") Then
                e.Value = "Consumo"
            ElseIf subs.StartsWith("BRANDY") Then
                e.Value = "Brandy"
            Else
                e.Value = "???"
            End If
        End If
        Return
    End Sub


    Private Sub PivotGridControl1_CustomSummary(ByVal sender As System.Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles PivotGridControl1.CustomSummary
        Try

            '############################################################
            '######## Diferença entre as vendas fim do mês anterior
            '############################################################
            If LCase(e.DataField.Name) = "difeendmonth" Then
                Dim vendas As Decimal
                Dim vendasLY As Decimal

                ' Get the record set corresponding to the current cell.
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                ' Iterate through the records and count the orders.
                vendas = 0
                vendasLY = 0
                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As PivotDrillDownDataRow = ds(i)
                    ' Get the order's total sum.

                    If Now.Month > 1 Then vendas = vendas + row(fieldJAN)
                    If Now.Month > 2 Then vendas = vendas + row(fieldFEV)
                    If Now.Month > 3 Then vendas = vendas + row(fieldMAR)
                    If Now.Month > 4 Then vendas = vendas + row(fieldABE)
                    If Now.Month > 5 Then vendas = vendas + row(fieldMAI)
                    If Now.Month > 6 Then vendas = vendas + row(fieldJUN)
                    If Now.Month > 7 Then vendas = vendas + row(fieldJUL)
                    If Now.Month > 8 Then vendas = vendas + row(fieldAGO)
                    If Now.Month > 9 Then vendas = vendas + row(fieldSET)
                    If Now.Month > 10 Then vendas = vendas + row(fieldOUT)
                    If Now.Month > 11 Then vendas = vendas + row(fieldNOV)


                    If Now.Month > 1 Then vendasLY = vendasLY + row(fieldJAN1)
                    If Now.Month > 2 Then vendasLY = vendasLY + row(fieldFEV1)
                    If Now.Month > 3 Then vendasLY = vendasLY + row(fieldMAR1)
                    If Now.Month > 4 Then vendasLY = vendasLY + row(fieldABR1)
                    If Now.Month > 5 Then vendasLY = vendasLY + row(fieldMAI1)
                    If Now.Month > 6 Then vendasLY = vendasLY + row(fieldJUN1)
                    If Now.Month > 7 Then vendasLY = vendasLY + row(fieldJUL1)
                    If Now.Month > 8 Then vendasLY = vendasLY + row(fieldAGO1)
                    If Now.Month > 9 Then vendasLY = vendasLY + row(fieldSET1)
                    If Now.Month > 10 Then vendasLY = vendasLY + row(fieldOUT1)
                    If Now.Month > 11 Then vendasLY = vendasLY + row(fieldNOV1)
                Next
                ' Calculate the percentage.
                If vendasLY <> 0 And vendas <> 0 Then
                    e.CustomValue = vendas / vendasLY - 1
                ElseIf vendasLY = 0 And vendas = 0 Then
                    e.CustomValue = "-"
                ElseIf vendasLY = 0 And vendas <> 0 Then
                    e.CustomValue = 1
                ElseIf vendasLY <> 0 And vendas = 0 Then
                    e.CustomValue = -1
                End If

                '############################################################
                '######## Diferença entre as vendas actuais com as do presente mês de "Last year"
                '############################################################

            ElseIf LCase(e.DataField.Name) = "dife" Then
                Dim vendas As Decimal
                Dim vendasLY As Decimal

                ' Get the record set corresponding to the current cell.
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                ' Iterate through the records and count the orders.

                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As PivotDrillDownDataRow = ds(i)
                    ' Get the order's total sum.

                    vendas = vendas + row(fieldSales)
                    If vartabela = "vendasportomescomp2" Or vartabela = "vendasportomescompvalor2" Then
                        vendasLY = vendasLY + row(fieldJAN1) + row(fieldFEV1) + row(fieldMAR1) + row(fieldABR1) + row(fieldMAI1) + row(fieldJUN1) + row(fieldJUL1) + row(fieldAGO1) + row(fieldSET1) + row(fieldOUT1) + row(fieldNOV1) + row(fieldDEZ1)

                    Else
                        vendasLY = vendasLY + row(fieldJAN1)
                        If Now.Month > 1 Then vendasLY = vendasLY + row(fieldFEV1)
                        If Now.Month > 2 Then vendasLY = vendasLY + row(fieldMAR1)
                        If Now.Month > 3 Then vendasLY = vendasLY + row(fieldABR1)
                        If Now.Month > 4 Then vendasLY = vendasLY + row(fieldMAI1)
                        If Now.Month > 5 Then vendasLY = vendasLY + row(fieldJUN1)
                        If Now.Month > 6 Then vendasLY = vendasLY + row(fieldJUL1)
                        If Now.Month > 7 Then vendasLY = vendasLY + row(fieldAGO1)
                        If Now.Month > 8 Then vendasLY = vendasLY + row(fieldSET1)
                        If Now.Month > 9 Then vendasLY = vendasLY + row(fieldOUT1)
                        If Now.Month > 10 Then vendasLY = vendasLY + row(fieldNOV1)
                        If Now.Month > 11 Then vendasLY = vendasLY + row(fieldDEZ1)

                    End If
                Next
                ' Calculate the percentage.
                If vendasLY <> 0 And vendas <> 0 Then
                    e.CustomValue = vendas / vendasLY - 1
                ElseIf vendasLY = 0 And vendas = 0 Then
                    e.CustomValue = "-"
                ElseIf vendasLY = 0 And vendas <> 0 Then
                    e.CustomValue = 1
                ElseIf vendasLY <> 0 And vendas = 0 Then
                    e.CustomValue = -1
                End If

                '############################################################
                '######## Diferença entre as vendas actuais e target actual
                '############################################################

            ElseIf LCase(e.DataField.Name) = "difetarget" Then
                Dim vendas As Decimal
                Dim target As Decimal

                ' Get the record set corresponding to the current cell.
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                ' Iterate through the records and count the orders.
                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As PivotDrillDownDataRow = ds(i)
                    ' Get the order's total sum.
                    vendas = vendas + row(fieldSales)
                    target = target + row(fieldTarget)

                Next
                ' Calculate the percentage.
                If target <> 0 And vendas <> 0 Then
                    e.CustomValue = vendas / target
                Else
                    e.CustomValue = 0
                End If

                '############################################################
                '######## Shipped Last Year fim do mês corrente
                '############################################################

            ElseIf LCase(e.DataField.Name) = "fieldsalesytdly" Then
                Dim vendas As Decimal
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                vendas = 0
                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As PivotDrillDownDataRow = ds(i)
                    ' Get the order's total sum.
                    vendas = vendas + row(fieldJAN1)
                    If Now.Month > 1 Then vendas = vendas + row(fieldFEV1)
                    If Now.Month > 2 Then vendas = vendas + row(fieldMAR1)
                    If Now.Month > 3 Then vendas = vendas + row(fieldABR1)
                    If Now.Month > 4 Then vendas = vendas + row(fieldMAI1)
                    If Now.Month > 5 Then vendas = vendas + row(fieldJUN1)
                    If Now.Month > 6 Then vendas = vendas + row(fieldJUL1)
                    If Now.Month > 7 Then vendas = vendas + row(fieldAGO1)
                    If Now.Month > 8 Then vendas = vendas + row(fieldSET1)
                    If Now.Month > 9 Then vendas = vendas + row(fieldOUT1)
                    If Now.Month > 10 Then vendas = vendas + row(fieldNOV1)
                    If Now.Month > 11 Then vendas = vendas + row(fieldDEZ1)
                Next
                e.CustomValue = vendas


                '############################################################
                '######## Diferença entre as vendas actuais e forecast actual
                '############################################################

            ElseIf LCase(e.DataField.Name) = "difeforeca" Then
                Dim vendas As Decimal
                Dim forecast As Decimal

                ' Get the record set corresponding to the current cell.
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                ' Iterate through the records and count the orders.
                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As PivotDrillDownDataRow = ds(i)
                    ' Get the order's total sum.
                    vendas = vendas + row(fieldSales)
                    forecast = forecast + row(fieldForecast)

                Next
                ' Calculate the percentage.
                If forecast <> 0 And vendas <> 0 Then
                    e.CustomValue = vendas / forecast
                Else
                    e.CustomValue = 0
                End If

                '############################################################
                '######## Diferença entre as vendas actuais + InHand actual e forecast actual
                '############################################################

            ElseIf LCase(e.DataField.Name) = "difeforecastinchand" Then
                Dim vendas As Decimal
                Dim Inhand As Decimal
                Dim forecast As Decimal


                ' Get the record set corresponding to the current cell.
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                ' Iterate through the records and count the orders.
                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As PivotDrillDownDataRow = ds(i)
                    ' Get the order's total sum.
                    vendas = vendas + row(fieldSales)
                    Inhand = Inhand + row(fieldHAND)
                    forecast = forecast + row(fieldForecast)

                Next
                ' Calculate the percentage.
                If forecast <> 0 And (vendas + Inhand) <> 0 Then
                    e.CustomValue = (vendas + Inhand) / forecast
                Else
                    e.CustomValue = 0
                End If

                '############################################################
                '######## Diferença entre as vendas actuais + InHand actual e Target actual
                '############################################################


            ElseIf LCase(e.DataField.Name) = "difetargetincand" Then
                Dim vendas As Decimal
                Dim Inhand As Decimal
                Dim target As Decimal


                ' Get the record set corresponding to the current cell.
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                ' Iterate through the records and count the orders.
                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As PivotDrillDownDataRow = ds(i)
                    ' Get the order's total sum.
                    vendas = vendas + row(fieldSales)
                    Inhand = Inhand + row(fieldHAND)
                    target = target + row(fieldTarget)

                Next
                ' Calculate the percentage.
                If target <> 0 And (vendas + Inhand) <> 0 Then
                    Try
                        e.CustomValue = (vendas + Inhand) / target
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                Else
                    e.CustomValue = 0
                End If

                '############################################################
                '######## Shipped fim do mês anterior
                '############################################################

            ElseIf LCase(e.DataField.Name) = "salesendmonth" Then
                Dim vendas As Decimal

                ' Get the record set corresponding to the current cell.
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                ' Iterate through the records and count the orders.
                vendas = 0
                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As PivotDrillDownDataRow = ds(i)
                    ' Get the order's total sum.
                    If Now.Month > 1 Then vendas = vendas + row(fieldJAN)
                    If Now.Month > 2 Then vendas = vendas + row(fieldFEV)
                    If Now.Month > 3 Then vendas = vendas + row(fieldMAR)
                    If Now.Month > 4 Then vendas = vendas + row(fieldABE)
                    If Now.Month > 5 Then vendas = vendas + row(fieldMAI)
                    If Now.Month > 6 Then vendas = vendas + row(fieldJUN)
                    If Now.Month > 7 Then vendas = vendas + row(fieldJUL)
                    If Now.Month > 8 Then vendas = vendas + row(fieldAGO)
                    If Now.Month > 9 Then vendas = vendas + row(fieldSET)
                    If Now.Month > 10 Then vendas = vendas + row(fieldOUT)
                    If Now.Month > 11 Then vendas = vendas + row(fieldNOV)

                Next

                e.CustomValue = vendas

                '############################################################
                '######## Shipped Last Year fim do mês anterior
                '############################################################

            ElseIf LCase(e.DataField.Name) = "salesendmonthly" Then
                Dim vendasLY As Decimal


                ' Get the record set corresponding to the current cell.
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                ' Iterate through the records and count the orders.
                vendasLY = 0
                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As PivotDrillDownDataRow = ds(i)
                    ' Get the order's total sum.
                    If Now.Month > 1 Then vendasLY = vendasLY + row(fieldJAN1)
                    If Now.Month > 2 Then vendasLY = vendasLY + row(fieldFEV1)
                    If Now.Month > 3 Then vendasLY = vendasLY + row(fieldMAR1)
                    If Now.Month > 4 Then vendasLY = vendasLY + row(fieldABR1)
                    If Now.Month > 5 Then vendasLY = vendasLY + row(fieldMAI1)
                    If Now.Month > 6 Then vendasLY = vendasLY + row(fieldJUN1)
                    If Now.Month > 7 Then vendasLY = vendasLY + row(fieldJUL1)
                    If Now.Month > 8 Then vendasLY = vendasLY + row(fieldAGO1)
                    If Now.Month > 9 Then vendasLY = vendasLY + row(fieldSET1)
                    If Now.Month > 10 Then vendasLY = vendasLY + row(fieldOUT1)
                    If Now.Month > 11 Then vendasLY = vendasLY + row(fieldNOV1)
                Next
                ' Calculate the percentage.
                e.CustomValue = vendasLY

                '############################################################
                '######## Diferença entre as vendas fim mês anterior e target actual
                '############################################################

            ElseIf LCase(e.DataField.Name) = "difetargettlm" Then
                Dim vendas As Decimal
                Dim target As Decimal

                ' Get the record set corresponding to the current cell.
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                ' Iterate through the records and count the orders.
                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As PivotDrillDownDataRow = ds(i)
                    ' Get the order's total sum.
                    If Now.Month > 1 Then vendas = vendas + row(fieldJAN)
                    If Now.Month > 2 Then vendas = vendas + row(fieldFEV)
                    If Now.Month > 3 Then vendas = vendas + row(fieldMAR)
                    If Now.Month > 4 Then vendas = vendas + row(fieldABE)
                    If Now.Month > 5 Then vendas = vendas + row(fieldMAI)
                    If Now.Month > 6 Then vendas = vendas + row(fieldJUN)
                    If Now.Month > 7 Then vendas = vendas + row(fieldJUL)
                    If Now.Month > 8 Then vendas = vendas + row(fieldAGO)
                    If Now.Month > 9 Then vendas = vendas + row(fieldSET)
                    If Now.Month > 10 Then vendas = vendas + row(fieldOUT)
                    If Now.Month > 11 Then vendas = vendas + row(fieldNOV)
                    target = target + row(fieldTarget)

                Next
                ' Calculate the percentage.
                If target <> 0 And vendas <> 0 Then
                    e.CustomValue = vendas / target
                Else
                    e.CustomValue = 0
                End If

                '############################################################
                '######## Diferença entre as vendas fim mês anterior e forecast actual
                '############################################################

            ElseIf LCase(e.DataField.Name) = "difeforecatlm" Then
                Dim vendas As Decimal
                Dim target As Decimal

                ' Get the record set corresponding to the current cell.
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                ' Iterate through the records and count the orders.
                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As PivotDrillDownDataRow = ds(i)
                    ' Get the order's total sum.
                    If Now.Month > 1 Then vendas = vendas + row(fieldJAN)
                    If Now.Month > 2 Then vendas = vendas + row(fieldFEV)
                    If Now.Month > 3 Then vendas = vendas + row(fieldMAR)
                    If Now.Month > 4 Then vendas = vendas + row(fieldABE)
                    If Now.Month > 5 Then vendas = vendas + row(fieldMAI)
                    If Now.Month > 6 Then vendas = vendas + row(fieldJUN)
                    If Now.Month > 7 Then vendas = vendas + row(fieldJUL)
                    If Now.Month > 8 Then vendas = vendas + row(fieldAGO)
                    If Now.Month > 9 Then vendas = vendas + row(fieldSET)
                    If Now.Month > 10 Then vendas = vendas + row(fieldOUT)
                    If Now.Month > 11 Then vendas = vendas + row(fieldNOV)
                    target = target + row(fieldForecast)

                Next
                ' Calculate the percentage.
                If target <> 0 And vendas <> 0 Then
                    e.CustomValue = vendas / target
                Else
                    e.CustomValue = 0
                End If

                '############################################################
                '######## Shipped Last Year
                '############################################################

            ElseIf LCase(e.DataField.Name) = "fieldsalesly" Then
                Dim vendas As Decimal
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                vendas = 0
                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As PivotDrillDownDataRow = ds(i)
                    ' Get the order's total sum.
                    vendas = vendas + row(fieldJAN1)
                    vendas = vendas + row(fieldFEV1)
                    vendas = vendas + row(fieldMAR1)
                    vendas = vendas + row(fieldABR1)
                    vendas = vendas + row(fieldMAI1)
                    vendas = vendas + row(fieldJUN1)
                    vendas = vendas + row(fieldJUL1)
                    vendas = vendas + row(fieldAGO1)
                    vendas = vendas + row(fieldSET1)
                    vendas = vendas + row(fieldOUT1)
                    vendas = vendas + row(fieldNOV1)
                    vendas = vendas + row(fieldDEZ1)
                Next
                e.CustomValue = vendas
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub PivotGridControl1_CustomAppearance(ByVal sender As System.Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs) Handles PivotGridControl1.CustomAppearance
        If e.RowIndex Mod 2 = 0 Then
            e.Appearance.BackColor = Color.White
        Else
            e.Appearance.BackColor = Color.WhiteSmoke
        End If
        If e.RowValueType = PivotGridValueType.GrandTotal Or e.RowValueType = PivotGridValueType.Total Then
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If savefilexml.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim str As String
            str = savefilexml.FileName
            If str = "" Then Return

            Dim layoutxml As New DevExpress.Utils.OptionsLayoutGrid
            layoutxml.StoreAllOptions = False
            layoutxml.StoreDataSettings = False
            PivotGridControl1.SaveLayoutToXml(str, layoutxml)
            '   PivotGridControl1.RefreshData()
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick


        If filenamexml.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim str As String
            str = filenamexml.FileName
            If str = "" Then Return

            Dim layoutxml As New DevExpress.Utils.OptionsLayoutGrid
            layoutxml.StoreAllOptions = False
            layoutxml.StoreDataSettings = False

            Try



                PivotGridControl1.RestoreLayoutFromXml(str, layoutxml)
                Dim testestr As Array = str.Split("\")
                BarEditItem1.EditValue = testestr(3).Remove(Len(testestr(3)) - 4, 4)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '        For Each field In PivotGridControl1.Fields
            ' field.FilterValues.Clear()
            ' Next
            If vartabela = "vendasportomescomp2" Or vartabela = "vendasportomescompvalor2" Then
                fieldJAN.Caption = "Jan" & Now.Year - 1
                fieldFEV.Caption = "Fev" & Now.Year - 1
                fieldMAR.Caption = "Mar" & Now.Year - 1
                fieldABE.Caption = "Abr" & Now.Year - 1
                fieldMAI.Caption = "Mai" & Now.Year - 1
                fieldJUN.Caption = "Jun" & Now.Year - 1
                fieldJUL.Caption = "Jul" & Now.Year - 1
                fieldAGO.Caption = "Ago" & Now.Year - 1
                fieldSET.Caption = "Set" & Now.Year - 1
                fieldOUT.Caption = "Out" & Now.Year - 1
                fieldNOV.Caption = "Nov" & Now.Year - 1
                fieldDEZ.Caption = "Dez" & Now.Year - 1

                fieldJAN1.Caption = "Jan" & Now.Year - 2
                fieldFEV1.Caption = "Fev" & Now.Year - 2
                fieldMAR1.Caption = "Mar" & Now.Year - 2
                fieldABR1.Caption = "Abr" & Now.Year - 2
                fieldMAI1.Caption = "Mai" & Now.Year - 2
                fieldJUN1.Caption = "Jun" & Now.Year - 2
                fieldJUL1.Caption = "Jul" & Now.Year - 2
                fieldAGO1.Caption = "Ago" & Now.Year - 2
                fieldSET1.Caption = "Set" & Now.Year - 2
                fieldOUT1.Caption = "Out" & Now.Year - 2
                fieldNOV1.Caption = "Nov" & Now.Year - 2
                fieldDEZ1.Caption = "Dez" & Now.Year - 2

                fieldSales.Caption = "ShippedLY"
                fieldSalesLY.Caption = "ShippYear-2"

            Else
                fieldJAN.Caption = "Jan" & Now.Year
                fieldFEV.Caption = "Fev" & Now.Year
                fieldMAR.Caption = "Mar" & Now.Year
                fieldABE.Caption = "Abr" & Now.Year
                fieldMAI.Caption = "Mai" & Now.Year
                fieldJUN.Caption = "Jun" & Now.Year
                fieldJUL.Caption = "Jul" & Now.Year
                fieldAGO.Caption = "Ago" & Now.Year
                fieldSET.Caption = "Set" & Now.Year
                fieldOUT.Caption = "Out" & Now.Year
                fieldNOV.Caption = "Nov" & Now.Year
                fieldDEZ.Caption = "Dez" & Now.Year

                fieldJAN1.Caption = "Jan" & Now.Year - 1
                fieldFEV1.Caption = "Fev" & Now.Year - 1
                fieldMAR1.Caption = "Mar" & Now.Year - 1
                fieldABR1.Caption = "Abr" & Now.Year - 1
                fieldMAI1.Caption = "Mai" & Now.Year - 1
                fieldJUN1.Caption = "Jun" & Now.Year - 1
                fieldJUL1.Caption = "Jul" & Now.Year - 1
                fieldAGO1.Caption = "Ago" & Now.Year - 1
                fieldSET1.Caption = "Set" & Now.Year - 1
                fieldOUT1.Caption = "Out" & Now.Year - 1
                fieldNOV1.Caption = "Nov" & Now.Year - 1
                fieldDEZ1.Caption = "Dez" & Now.Year - 1

            End If



            If vartabela = "vendasportomescompvalor" Or vartabela = "vendasportomescompvalor2" Then
                fieldForecast.Visible = False
                fieldTarget.Visible = False
                DifeForeca.Visible = False
                DifeForecastinchand.Visible = False
                DifeForecaTLM.Visible = False
                DifeTarget.Visible = False
                DifeTargetincand.Visible = False
                DifeTargetTLM.Visible = False
                fieldSales.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldForecast.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldHAND.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldSalesYTDLY.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldTarget.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                salesendmonth.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                salesendmonthLY.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                'Dife.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                'DifeForeca.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                'DifeForecastinchand.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                'DifeTarget.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                'DifeTargetinchand.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldJAN.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldFEV.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldMAR.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldABE.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldMAI.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldJUN.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldJUL.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldAGO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldSET.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldOUT.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldNOV.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldDEZ.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldJAN1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldFEV1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldMAR1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldABR1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldMAI1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldJUN1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldJUL1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldAGO1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldSET1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldOUT1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldNOV1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                fieldDEZ1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric

                fieldSales.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldForecast.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldHAND.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldSalesYTDLY.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldTarget.GrandTotalCellFormat.FormatString = "#,##0.0€"
                salesendmonth.GrandTotalCellFormat.FormatString = "#,##0.0€"
                salesendmonthLY.GrandTotalCellFormat.FormatString = "#,##0.0€"
                'Dife.GrandTotalCellFormat.FormatString = "#,##0.0€"
                'DifeForeca.GrandTotalCellFormat.FormatString = "#,##0.0€"
                'DifeForecastinchand.GrandTotalCellFormat.FormatString = "#,##0.0€"
                'DifeTarget.GrandTotalCellFormat.FormatString = "#,##0.0€"
                'DifeTargetinchand.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldJAN.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldFEV.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldMAR.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldABE.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldMAI.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldJUN.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldJUL.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldAGO.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldSET.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldOUT.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldNOV.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldDEZ.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldJAN1.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldFEV1.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldMAR1.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldABR1.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldMAI1.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldJUN1.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldJUL1.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldAGO1.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldSET1.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldOUT1.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldNOV1.GrandTotalCellFormat.FormatString = "#,##0.0€"
                fieldDEZ1.GrandTotalCellFormat.FormatString = "#,##0.0€"

            End If

        End If
    End Sub

    Private Sub PivotGridControl1_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles PivotGridControl1.FieldValueDisplayText
        Try

            If e.Field Is Nothing Then
                Exit Sub
            End If

            If Not (e.Field Is fieldVintage) Then Return
            If CInt(e.Value) = 1 Then
                e.DisplayText = "Vintage"
            Else
                e.DisplayText = "Non Vintage"
            End If

            Return
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PivotGridControl1_ShowCustomizationForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PivotGridControl1.ShowCustomizationForm
        PivotGridControl1.OptionsView.ShowDataHeaders = True
    End Sub

    Private Sub PivotGridControl1_HideCustomizationForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PivotGridControl1.HideCustomizationForm
        PivotGridControl1.OptionsView.ShowDataHeaders = False

    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.Close()

    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.PrintingSystem.Document.AutoFitToPagesWidth = 1
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.PrintingSystem.Document.AutoFitToPagesWidth = 1
        Dim filename As New FolderBrowserDialog
        filename.ShowDialog()
        Dim str As String
        str = filename.SelectedPath & "\ReportComparison.pdf"
        PrintingSystem1.ExportToPdf(str)
        Process.Start(str)
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Dim ret As Object = DevExpress.XtraEditors.XtraMessageBox.Show("Click 'YES' to create a Formatted File or 'NO' to a Tabular File", "Choose..", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        If ret = 6 Then
            PivotGridControl1.OptionsPrint.MergeColumnFieldValues = True
            PivotGridControl1.OptionsPrint.MergeRowFieldValues = True
        ElseIf ret = 7 Then
            PivotGridControl1.OptionsPrint.MergeColumnFieldValues = False
            PivotGridControl1.OptionsPrint.MergeRowFieldValues = False
        Else
            Exit Sub
        End If
        PrintableComponentLink1.CreateDocument()
        Dim filename As New FolderBrowserDialog
        filename.ShowDialog()
        Dim str As String
        str = filename.SelectedPath & "\ReportComparison.xls"
        PrintingSystem1.ExportToXls(str)
        Process.Start(str)
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.PrintingSystem.Document.AutoFitToPagesWidth = 1

        PrintableComponentLink1.PrintingSystem.PrintDlg()

    End Sub
    Private Sub PrintableComponentLink1_CreateDetailHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        e.Graph.Modifier = DevExpress.XtraPrinting.BrickModifier.ReportHeader
        e.Graph.Font = New Font("Arial", 8, FontStyle.Bold)
        e.Graph.DrawString(" Last update: " & GetSetting("SalesReports", "Updated", "date"), Color.Black, New RectangleF(0, 0, 200, 20), DevExpress.XtraPrinting.BorderSide.None)


        'company
        e.Graph.DrawString(IIf(labelcomp.EditValue = "", "", labelcomp.EditValue), Color.Black, New RectangleF(0, 20, 400, 20), DevExpress.XtraPrinting.BorderSide.None)
        'market & Client
        e.Graph.DrawString(IIf(labelpais.EditValue = "", "", labelpais.EditValue) & "    " & IIf(labelcli.EditValue = "", "", labelcli.EditValue), Color.Black, New RectangleF(0, 40, 400, 20), DevExpress.XtraPrinting.BorderSide.None)
        'Director
        e.Graph.DrawString(IIf(labeldir.EditValue = "", "", labeldir.EditValue), Color.Black, New RectangleF(0, 60, 400, 20), DevExpress.XtraPrinting.BorderSide.None)

        'trademark
        e.Graph.DrawString(IIf(labelmarca.EditValue = "", "", labelmarca.EditValue), Color.Black, New RectangleF(0, 80, 400, 20), DevExpress.XtraPrinting.BorderSide.None)
        ' package
        e.Graph.DrawString(IIf(labelpack.EditValue = "", "", labelpack.EditValue), Color.Black, New RectangleF(0, 100, 400, 20), DevExpress.XtraPrinting.BorderSide.None)

        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Far, StringAlignment.Near)

        e.Graph.DrawString("9L Cases", Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 200, 0, 200, 20), DevExpress.XtraPrinting.BorderSide.None)

        e.Graph.DrawString(IIf(labelgroup.EditValue = "", "", labelgroup.EditValue) & IIf(labeltype.EditValue = "", "", " - " & labeltype.EditValue), Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 400, 20, 400, 20), DevExpress.XtraPrinting.BorderSide.None)

        e.Graph.DrawString(IIf(labelprod.EditValue = "", "", labelprod.EditValue), Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 400, 40, 400, 30), DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(IIf(labelanocol.EditValue = "", "", "Year(s):" & labelanocol.EditValue), Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 400, 70, 400, 20), DevExpress.XtraPrinting.BorderSide.None)

        ''e.Graph.DrawString(IIf(labelmarca.EditValue = "", "", "Filter:" & Label12.Text), Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 400, 90, 400, 20), DevExpress.XtraPrinting.BorderSide.None)

        Dim bitpath As String
        If labeltype.EditValue = "BOB" Then bitpath = Application.StartupPath & "\cruz.gif"
        If Not labeltype.EditValue = "" Then
            Try
                Select Case UCase(labelmarca.EditValue.ToString)
                    Case "QUARLES HARRIS & CA. S.A."
                        bitpath = Application.StartupPath & "\QUA.JPG"
                        '                Case "W & J GRAHAM & CA. S.A."
                    Case "GRAHAM'S"
                        bitpath = Application.StartupPath & "\w &.jpg"
                    Case "WARRE & CA. S.A."
                        bitpath = Application.StartupPath & "\war.JPG"
                    Case "SMITH WOODHOUSE & CA. LDA"
                        bitpath = Application.StartupPath & "\smi.JPG"
                    Case "QUINTA DE RORIZ"
                        bitpath = Application.StartupPath & "\ror.JPG"
                    Case "SILVA & COSENS LTD."
                        If labeltype.EditValue = "BRAND" Then
                            bitpath = Application.StartupPath & "\dow.JPG"
                        Else
                            bitpath = Application.StartupPath & "\cruz.gif"
                        End If
                    Case "SOC.AGR.QUINTA VESUVIO, LDA"
                        bitpath = Application.StartupPath & "\soc.JPG"
                    Case "PRATS E SYMINGTON, LDA."
                        bitpath = Application.StartupPath & "\pes.JPG"
                    Case "GOULD CAMPBELL"
                        bitpath = Application.StartupPath & "\gou.JPG"
                    Case Else
                        bitpath = Application.StartupPath & "\cruz.gif"
                End Select
            Catch ex As Exception
                bitpath = Application.StartupPath & "\cruz.gif"
            End Try
        Else
            bitpath = Application.StartupPath & "\cruz.gif"
        End If

        If LCase(vartabela).StartsWith("vendasmadeira") Then
            bitpath = Application.StartupPath & "\mwc.jpg"
        End If

        Dim imagelist1 As New Bitmap(bitpath)
        Dim r As New RectangleF(0, 0, imagelist1.Width / 3, imagelist1.Height / 3)
        r.Offset((e.Graph.ClientPageSize.Width / 2) - (r.Width / 2), 0)
        e.Graph.DrawImage(imagelist1, r, DevExpress.XtraPrinting.BorderSide.None, Color.Transparent)

        Dim yearstr As String = ""
        If vartabela = "vendasportomescomp2" Then
            yearstr = "" & Now.Year - 2 & "/" & Now.Year - 1
            e.Graph.DrawString("Sales Comparison " & yearstr, Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 450, 50, 150, 40), DevExpress.XtraPrinting.BorderSide.None)
        ElseIf vartabela = "vendasportomescomp" Then
            yearstr = "" & Now.Year - 1 & "/" & Now.Year
            e.Graph.DrawString("Sales Comparison " & yearstr, Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 450, 50, 150, 40), DevExpress.XtraPrinting.BorderSide.None)
        ElseIf vartabela = "vendasportomescompvalor" Then
            yearstr = "" & Now.Year - 1 & "/" & Now.Year
            e.Graph.DrawString("Sales Values Comparison " & yearstr, Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 450, 50, 150, 40), DevExpress.XtraPrinting.BorderSide.None)
        ElseIf vartabela = "vendasportomescompvalor2" Then
            yearstr = "" & Now.Year - 2 & "/" & Now.Year - 1
            e.Graph.DrawString("Sales Values Comparison " & yearstr, Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 450, 50, 150, 40), DevExpress.XtraPrinting.BorderSide.None)


        End If



        'e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near, StringAlignment.Near)
        'e.Graph.Font = New Font("Arial", 10, FontStyle.Bold)


    End Sub
    Private Sub PrintableComponentLink1_CreatePageFooterArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateMarginalFooterArea
        e.Graph.Modifier = DevExpress.XtraPrinting.BrickModifier.MarginalFooter
        Dim format As String = "Page {0} of {1}"
        e.Graph.Font = e.Graph.DefaultFont
        Dim r As RectangleF = New RectangleF(0, 0, 0, e.Graph.Font.Height)
        Dim brick As DevExpress.XtraPrinting.PageInfoBrick = e.Graph.DrawPageInfo(DevExpress.XtraPrinting.PageInfo.NumberOfTotal, format, Color.Black, r, DevExpress.XtraPrinting.BorderSide.None)
        brick.Alignment = DevExpress.XtraPrinting.BrickAlignment.Far
        brick.AutoWidth = True
    End Sub

    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        PivotGridControl1.FieldsCustomization()
    End Sub

    Private Sub pivotGridControl1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PivotGridControl1.MouseClick
        Dim hi As PivotGridHitInfo = PivotGridControl1.CalcHitInfo(New Point(e.X, e.Y))
        If hi.HitTest = PivotGridHitTest.Value Then
            Try
                If hi.ValueInfo.Field.Area = PivotArea.DataArea Then
                    'icbField.EditValue = hi.ValueInfo.Field
                    Dim fielditem As PivotGridField
                    Dim nome As String = ""
                    Dim area As Integer = -1
                    For Each fielditem In PivotGridControl1.Fields

                        If fielditem.Visible = True And fielditem.Area = PivotArea.RowArea Then
                            If fielditem.AreaIndex > area Then
                                area = fielditem.AreaIndex
                                nome = fielditem.Name
                            End If
                        End If
                    Next
                    NOTOP.Checked = True
                    PivotGridControl1.Fields.GetFieldByName(nome).SortBySummaryInfo.Field = hi.ValueInfo.Field
                    If PivotGridControl1.Fields.GetFieldByName(nome).SortOrder = PivotSortOrder.Ascending Then
                        PivotGridControl1.Fields.GetFieldByName(nome).SortOrder = PivotSortOrder.Descending
                    Else
                        PivotGridControl1.Fields.GetFieldByName(nome).SortOrder = PivotSortOrder.Ascending
                    End If
                End If
            Catch
            End Try

        End If

    End Sub ' pivotGridControl1_MouseClick

    Private Sub BarCheckItem1_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Top5.CheckedChanged
        If Top5.Checked = True Then aplicartopvalues(5)
    End Sub

    Private Sub Top10_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Top10.CheckedChanged
        If Top10.Checked = True Then aplicartopvalues(10)
    End Sub

    Private Sub NOTOP_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles NOTOP.CheckedChanged
        If NOTOP.Checked = True Then aplicartopvalues(0)
    End Sub
    Private Sub aplicartopvalues(ByVal valor As Integer)
        Dim fielditem As PivotGridField
        Dim nome As String = ""
        Dim area As Integer = -1
        For Each fielditem In PivotGridControl1.Fields

            If fielditem.Visible = True And fielditem.Area = PivotArea.RowArea Then
                If fielditem.AreaIndex > area Then
                    area = fielditem.AreaIndex
                    nome = fielditem.Name
                End If
            End If
        Next
        PivotGridControl1.Fields.GetFieldByName(nome).TopValueShowOthers = True
        PivotGridControl1.Fields.GetFieldByName(nome).TopValueCount = valor

    End Sub

#Region "Menu Show/hide Totals"

    Private Sub PivotGridControl1_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs) Handles PivotGridControl1.PopupMenuShowing
        If e.MenuType = DevExpress.XtraPivotGrid.PivotGridMenuType.Header Then
            HandleHeaderShowMenu(e)
        End If
    End Sub

    '    Private Sub PivotGridControl1_ShowMenu(ByVal sender As System.Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridMenuEventArgs) Handles PivotGridControl1.ShowMenu
    '   End Sub
    Private Sub HandleHeaderShowMenu(ByVal e As DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs)
        If (Not IsLastAreaField(PivotGridControl1, e.Field)) Then
            CreateToggleTotalsItem(e)
        End If
    End Sub

    Private Function IsLastAreaField(ByVal pivotGridControl As PivotGridControl, ByVal field As PivotGridField) As Boolean
        For i As Integer = 0 To pivotGridControl.Fields.Count - 1
            If pivotGridControl.Fields(i).Visible AndAlso pivotGridControl.Fields(i).Area = field.Area AndAlso pivotGridControl.Fields(i).AreaIndex > field.AreaIndex Then
                Return False
            End If
        Next i
        Return True
    End Function
    Private Sub CreateToggleTotalsItem(ByVal e As DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs)
        Dim isTotalsVisible As Boolean = e.Field.TotalsVisibility <> PivotTotalsVisibility.None
        Dim toggleTotalItem As DXMenuItem
        If isTotalsVisible Then
            toggleTotalItem = New DXMenuItem("Hide Totals", AddressOf ToggleTotalsMenuItemClick)
        Else
            toggleTotalItem = New DXMenuItem("Show Totals", AddressOf ToggleTotalsMenuItemClick)
        End If
        toggleTotalItem.BeginGroup = True
        toggleTotalItem.Tag = e.Field
        e.Menu.Items.Add(toggleTotalItem)
    End Sub

    Private Sub ToggleTotalsMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = CType(sender, DXMenuItem)
        Dim field As PivotGridField = CType(item.Tag, PivotGridField)
        If field.TotalsVisibility = PivotTotalsVisibility.None Then
            field.TotalsVisibility = PivotTotalsVisibility.AutomaticTotals
        Else
            field.TotalsVisibility = PivotTotalsVisibility.None
        End If
    End Sub

#End Region

End Class
