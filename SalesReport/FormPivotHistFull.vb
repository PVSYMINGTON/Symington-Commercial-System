Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraBars
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars.Helpers
Imports System.Windows.Forms
Imports System.Drawing

Imports System.ComponentModel
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPrinting
Imports DevExpress.Export



Public Class FormPivotHistFull

    Sub New()
        InitSkins()
        InitializeComponent()

    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        ' UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
        UserLookAndFeel.Default.SetSkinStyle(My.Settings.skin)
    End Sub


    Public varstrCaption As String
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
    Public flagfilterkeypais As String
    Public flagfilterkeycli As String
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
    Public flagValores As Boolean = False
    Public filtermark As String
    Public Forcefilterkey As String

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
        'TODO: This line of code loads data into the 'SapCSDataSet.SalesHistorico' table. You can move, or remove it, as needed.





        Me.Top = 0
        Me.Left = 0
        Me.Width = Me.MdiParent.ClientSize.Width - 4
        Me.Height = Me.MdiParent.ClientSize.Height - 4
        Me.Text = varstrCaption
        SkinHelper.InitSkinGallery(RibbonGalleryBarItem1, True)

        AddHandler DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged, AddressOf UserLookAndFeel_StyleChanged






        '''''''''''''''''''Filtro
        'Dim myArraydir() As String = Split(filterkeydir, "'")
        'If myArraydir(1) = "%" Then

        'ElseIf myArraydir.Length = 3 Then

        '    RibbonControl1.Items.Add(labeldir)
        '    RibbonPageGroup1.ItemLinks.Add(labeldir)
        '    labeldir.CanOpenEdit = False
        '    labeldir.Edit = Me.RepositoryItemTextEdit1
        '    If UCase(flagfilterkeydir) = "DIRECTOR" Then
        '        labeldir.EditValue = "Director: " & myArraydir(1)
        '    ElseIf UCase(flagfilterkeydir) = "SECRETARIA" Then
        '        labeldir.EditValue = "Assistant: " & myArraydir(1)
        '    Else
        '        labeldir.EditValue = "Manager: " & myArraydir(1)
        '    End If
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labeldir.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labeldir.SuperTip = SuperToolTip1
        '    labeldir.Width = 100
        'ElseIf myArraydir.Length > 3 Then

        '    RibbonControl1.Items.Add(labeldir)
        '    RibbonPageGroup1.ItemLinks.Add(labeldir)
        '    labeldir.CanOpenEdit = False
        '    labeldir.Edit = Me.RepositoryItemTextEdit1
        '    labeldir.EditValue = myArraydir(1)
        '    Dim x As Integer
        '    For x = 3 To myArraydir.Length - 1 Step 2
        '        labeldir.EditValue = labeldir.EditValue & "/" & myArraydir(x)
        '        labeldir.Width = 100
        '    Next x
        '    If UCase(flagfilterkeydir) = "DIRECTOR" Then
        '        labeldir.EditValue = "Director: " & labeldir.EditValue
        '    ElseIf UCase(flagfilterkeydir) = "SECRETARIA" Then
        '        labeldir.EditValue = "Assistant: " & labeldir.EditValue
        '    Else
        '        labeldir.EditValue = "Manager: " & labeldir.EditValue
        '    End If
        '    labeldir.Width = 100
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labeldir.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labeldir.SuperTip = SuperToolTip1
        'End If

        'Dim myArraydir1() As String = Split(filterkeypais, "'")
        'If myArraydir1(1) = "%" Then

        'ElseIf myArraydir1.Length = 3 Then

        '    RibbonControl1.Items.Add(labelpais)
        '    RibbonPageGroup1.ItemLinks.Add(labelpais)
        '    labelpais.CanOpenEdit = False
        '    labelpais.Edit = Me.RepositoryItemTextEdit1

        '    If (flagfilterkeypais) = "Pais" Then
        '        labelpais.EditValue = "Stats Market: " & myArraydir1(1)
        '    ElseIf (flagfilterkeypais) = "PaisFact" Then
        '        labelpais.EditValue = "Invoicing Market: " & myArraydir1(1)
        '    Else
        '        labelpais.EditValue = "Final Market: " & myArraydir1(1)
        '    End If


        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelpais.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelpais.SuperTip = SuperToolTip1
        '    labelpais.Width = 100
        'ElseIf myArraydir1.Length > 3 Then
        '    RibbonControl1.Items.Add(labelpais)
        '    RibbonPageGroup1.ItemLinks.Add(labelpais)
        '    labelpais.CanOpenEdit = False
        '    labelpais.Edit = Me.RepositoryItemTextEdit1
        '    labelpais.EditValue = myArraydir1(1)
        '    Dim x As Integer
        '    For x = 3 To myArraydir1.Length - 1 Step 2
        '        labelpais.EditValue = labelpais.EditValue & "/" & myArraydir1(x)
        '        labelpais.Width = 100 'If(labelpais.EditValue.ToString.Length * 8 > 80, labelpais.EditValue.ToString.Length * 8, 80)
        '    Next x
        '    If (flagfilterkeypais) = "Pais" Then
        '        labelpais.EditValue = "Stats Market: " & labelpais.EditValue
        '    ElseIf (flagfilterkeypais) = "PaisFact" Then
        '        labelpais.EditValue = "Invoicing Market: " & labelpais.EditValue
        '    Else
        '        labelpais.EditValue = "Final Market: " & labelpais.EditValue
        '    End If
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelpais.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelpais.SuperTip = SuperToolTip1
        'End If

        'Dim myArraydir2() As String = Split(filterkeycli, "'")
        'If myArraydir2(1) = "%" Then
        'ElseIf myArraydir2.Length = 3 Then
        '    RibbonControl1.Items.Add(labelcli)
        '    RibbonPageGroup1.ItemLinks.Add(labelcli)
        '    labelcli.CanOpenEdit = False
        '    labelcli.Edit = Me.RepositoryItemTextEdit1
        '    If (flagfilterkeycli) = "Cliente" Then
        '        labelcli.EditValue = "Stats Cust: " & myArraydir2(1)
        '    ElseIf (flagfilterkeycli) = "ClienteFact" Then
        '        labelcli.EditValue = "Invoic Cust: " & myArraydir2(1)
        '    Else
        '        labelcli.EditValue = "Final Cust: " & myArraydir2(1)
        '    End If

        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelcli.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelcli.SuperTip = SuperToolTip1
        '    labelcli.Width = 100 'If(labelcli.EditValue.ToString.Length * 8 > 40, labelcli.EditValue.ToString.Length * 8, 40)
        'ElseIf myArraydir2.Length > 3 Then
        '    RibbonControl1.Items.Add(labelcli)
        '    RibbonPageGroup1.ItemLinks.Add(labelcli)
        '    labelcli.CanOpenEdit = False
        '    labelcli.Edit = Me.RepositoryItemTextEdit1
        '    labelcli.EditValue = myArraydir2(1)
        '    Dim x As Integer
        '    For x = 3 To myArraydir2.Length - 1 Step 2
        '        labelcli.EditValue = labelcli.EditValue & "/" & myArraydir2(x)
        '        labelcli.Width = 100 'If(labelcli.EditValue.ToString.Length * 8 > 80, labelcli.EditValue.ToString.Length * 8, 80)
        '    Next x

        '    If (flagfilterkeycli) = "Cliente" Then
        '        labelcli.EditValue = "Stats Cust: " & labelcli.EditValue
        '    ElseIf (flagfilterkeycli) = "ClienteFact" Then
        '        labelcli.EditValue = "Invoic Cust: " & labelcli.EditValue
        '    Else
        '        labelcli.EditValue = "Final Cust: " & labelcli.EditValue
        '    End If

        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelcli.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelcli.SuperTip = SuperToolTip1
        'End If

        'Dim myArraydir3() As String = Split(filterkeycomp, "'")
        'If myArraydir3(1) = "%" Then
        'ElseIf myArraydir3.Length = 3 Then
        '    RibbonControl1.Items.Add(labelcomp)
        '    RibbonPageGroup1.ItemLinks.Add(labelcomp)
        '    labelcomp.CanOpenEdit = False
        '    labelcomp.Edit = Me.RepositoryItemTextEdit1
        '    labelcomp.EditValue = myArraydir3(1)
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelcomp.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelcomp.SuperTip = SuperToolTip1
        '    labelcomp.Width = 100 'If(labelcomp.EditValue.ToString.Length * 8 > 40, labelcomp.EditValue.ToString.Length * 8, 40)
        'ElseIf myArraydir3.Length > 3 Then
        '    RibbonControl1.Items.Add(labelcomp)
        '    RibbonPageGroup1.ItemLinks.Add(labelcomp)
        '    labelcomp.CanOpenEdit = False
        '    labelcomp.Edit = Me.RepositoryItemTextEdit1
        '    labelcomp.EditValue = myArraydir3(1)
        '    Dim x As Integer
        '    For x = 3 To myArraydir3.Length - 1 Step 2
        '        labelcomp.EditValue = labelcomp.EditValue & "/" & myArraydir3(x)
        '        labelcomp.Width = 100 'If(labelcomp.EditValue.ToString.Length * 8 > 80, labelcomp.EditValue.ToString.Length * 8, 80)
        '    Next x
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelcomp.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelcomp.SuperTip = SuperToolTip1
        'End If

        'Dim myArraydir4() As String = Split(filterkeytype, "'")
        'If myArraydir4(1) = "%" Then
        'ElseIf myArraydir4.Length = 3 Then
        '    RibbonControl1.Items.Add(labeltype)
        '    RibbonPageGroup1.ItemLinks.Add(labeltype)
        '    labeltype.CanOpenEdit = False
        '    labeltype.Edit = Me.RepositoryItemTextEdit1
        '    labeltype.EditValue = myArraydir4(1)
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labeltype.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labeltype.SuperTip = SuperToolTip1

        '    labeltype.Width = 100 'If(labeltype.EditValue.ToString.Length * 8 > 40, labeltype.EditValue.ToString.Length * 8, 40)
        'ElseIf myArraydir4.Length > 3 Then
        '    RibbonControl1.Items.Add(labeltype)
        '    RibbonPageGroup1.ItemLinks.Add(labeltype)
        '    labeltype.CanOpenEdit = False
        '    labeltype.Edit = Me.RepositoryItemTextEdit1
        '    labeltype.EditValue = myArraydir4(1)
        '    Dim x As Integer
        '    For x = 3 To myArraydir4.Length - 1 Step 2
        '        labeltype.EditValue = labeltype.EditValue & "/" & myArraydir4(x)
        '        labeltype.Width = 100 'If(labeltype.EditValue.ToString.Length * 8 > 80, labeltype.EditValue.ToString.Length * 8, 80)
        '    Next x
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labeltype.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labeltype.SuperTip = SuperToolTip1

        'End If

        'Dim correctString As String = filterkeymarca.Replace("''", "´")
        'Dim myArraydir5() As String = Split(correctString, "'")
        'If myArraydir5(1) = "%" Then
        'ElseIf myArraydir5.Length = 3 Then
        '    RibbonControl1.Items.Add(labelmarca)
        '    RibbonPageGroup1.ItemLinks.Add(labelmarca)
        '    labelmarca.CanOpenEdit = False
        '    labelmarca.Edit = Me.RepositoryItemTextEdit1
        '    labelmarca.EditValue = myArraydir5(1)
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelmarca.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelmarca.SuperTip = SuperToolTip1

        '    labelmarca.Width = 100 'If(labelmarca.EditValue.ToString.Length * 8 > 40, labelmarca.EditValue.ToString.Length * 8, 40)
        'ElseIf myArraydir5.Length > 3 Then
        '    RibbonControl1.Items.Add(labelmarca)
        '    RibbonPageGroup1.ItemLinks.Add(labelmarca)
        '    labelmarca.CanOpenEdit = False
        '    labelmarca.Edit = Me.RepositoryItemTextEdit1
        '    labelmarca.EditValue = myArraydir5(1)
        '    Dim x As Integer
        '    For x = 3 To myArraydir5.Length - 1 Step 2
        '        labelmarca.EditValue = labelmarca.EditValue & "/" & myArraydir5(x)
        '        labelmarca.Width = 100 'If(labelmarca.EditValue.ToString.Length * 8 > 80, labelmarca.EditValue.ToString.Length * 8, 80)
        '    Next x
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelmarca.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelmarca.SuperTip = SuperToolTip1

        'End If

        'Dim myArraydir6() As String = Split(filterkeygroup, "'")
        'If myArraydir6(1) = "%" Then
        'ElseIf myArraydir6.Length = 3 Then
        '    RibbonControl1.Items.Add(labelgroup)
        '    RibbonPageGroup1.ItemLinks.Add(labelgroup)
        '    labelgroup.CanOpenEdit = False
        '    labelgroup.Edit = Me.RepositoryItemTextEdit1
        '    labelgroup.EditValue = myArraydir6(1)
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelgroup.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelgroup.SuperTip = SuperToolTip1

        '    labelgroup.Width = 100 'If(labelgroup.EditValue.ToString.Length * 8 > 40, labelgroup.EditValue.ToString.Length * 8, 40)
        'ElseIf myArraydir6.Length > 3 Then
        '    RibbonControl1.Items.Add(labelgroup)
        '    RibbonPageGroup1.ItemLinks.Add(labelgroup)
        '    labelgroup.CanOpenEdit = False
        '    labelgroup.Edit = Me.RepositoryItemTextEdit1
        '    labelgroup.EditValue = myArraydir6(1)
        '    Dim x As Integer
        '    For x = 3 To myArraydir6.Length - 1 Step 2
        '        labelgroup.EditValue = labelgroup.EditValue & "/" & myArraydir6(x)
        '        labelgroup.Width = 100 'If(labelgroup.EditValue.ToString.Length * 8 > 80, labelgroup.EditValue.ToString.Length * 8, 80)
        '    Next x
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelgroup.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelgroup.SuperTip = SuperToolTip1

        'End If

        'Dim myArraydir7() As String = Split(filterkeyprod, "'")
        'If myArraydir7(1) = "%" Then
        'ElseIf myArraydir7.Length = 3 Then
        '    RibbonControl1.Items.Add(labelprod)
        '    RibbonPageGroup1.ItemLinks.Add(labelprod)
        '    labelprod.CanOpenEdit = False
        '    labelprod.Edit = Me.RepositoryItemTextEdit1
        '    If UCase(flagfilterkeyprod) = "SUBCAT" Then labelprod.EditValue = "Subcat: " & myArraydir7(1) Else labelprod.EditValue = "Family: " & myArraydir7(1)
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelprod.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelprod.SuperTip = SuperToolTip1
        '    labelprod.Width = 100 'If(labelprod.EditValue.ToString.Length * 8 > 40, labelprod.EditValue.ToString.Length * 8, 40)
        'ElseIf myArraydir7.Length > 3 Then
        '    RibbonControl1.Items.Add(labelprod)
        '    RibbonPageGroup1.ItemLinks.Add(labelprod)
        '    labelprod.CanOpenEdit = False
        '    labelprod.Edit = Me.RepositoryItemTextEdit1
        '    labelprod.EditValue = myArraydir7(1)
        '    Dim x As Integer
        '    For x = 3 To myArraydir7.Length - 1 Step 2
        '        labelprod.EditValue = labelprod.EditValue & "/" & myArraydir7(x)
        '    Next x
        '    If UCase(flagfilterkeyprod) = "SUBCAT" Then labelprod.EditValue = "Subcat: " & labelprod.EditValue Else labelprod.EditValue = "Family: " & labelprod.EditValue
        '    labelprod.Width = 100 'If(labelprod.EditValue.ToString.Length * 8 > 80, labelprod.EditValue.ToString.Length * 8, 80)
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelprod.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelprod.SuperTip = SuperToolTip1
        'End If

        'Dim myArraydir8() As String = Split(filterkeyAnocol, "'")
        'If myArraydir8(1) = "%" Then
        'ElseIf myArraydir8.Length = 3 Then
        '    RibbonControl1.Items.Add(labelanocol)
        '    RibbonPageGroup1.ItemLinks.Add(labelanocol)
        '    labelanocol.CanOpenEdit = False
        '    labelanocol.Edit = Me.RepositoryItemTextEdit1
        '    labelanocol.EditValue = myArraydir8(1)
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelanocol.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelanocol.SuperTip = SuperToolTip1
        '    labelanocol.Width = 100 'If(labelanocol.EditValue.ToString.Length * 8 > 40, labelanocol.EditValue.ToString.Length * 8, 40)
        'ElseIf myArraydir8.Length > 3 Then
        '    RibbonControl1.Items.Add(labelanocol)
        '    RibbonPageGroup1.ItemLinks.Add(labelanocol)
        '    labelanocol.CanOpenEdit = False
        '    labelanocol.Edit = Me.RepositoryItemTextEdit1
        '    labelanocol.EditValue = myArraydir8(1)
        '    Dim x As Integer
        '    For x = 3 To myArraydir8.Length - 1 Step 2
        '        labelanocol.EditValue = labelanocol.EditValue & "/" & myArraydir8(x)
        '        labelanocol.Width = 100 'If(labelanocol.EditValue.ToString.Length * 8 > 80, labelanocol.EditValue.ToString.Length * 8, 80)
        '    Next x
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelanocol.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelanocol.SuperTip = SuperToolTip1
        'End If

        'Dim myArraydir9() As String = Split(filterkeypackage, "'")
        'If myArraydir9(1) = "%" Then
        'ElseIf myArraydir9.Length = 3 Then
        '    RibbonControl1.Items.Add(labelpack)
        '    RibbonPageGroup1.ItemLinks.Add(labelpack)
        '    labelpack.CanOpenEdit = False
        '    labelpack.Edit = Me.RepositoryItemTextEdit1
        '    labelpack.EditValue = myArraydir9(1)
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelpack.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelpack.SuperTip = SuperToolTip1
        '    labelpack.Width = 100 'If(labelpack.EditValue.ToString.Length * 8 > 40, labelpack.EditValue.ToString.Length * 8, 40)
        'ElseIf myArraydir9.Length > 3 Then
        '    RibbonControl1.Items.Add(labelpack)
        '    RibbonPageGroup1.ItemLinks.Add(labelpack)
        '    labelpack.CanOpenEdit = False
        '    labelpack.Edit = Me.RepositoryItemTextEdit1
        '    labelpack.EditValue = myArraydir9(1)
        '    Dim x As Integer
        '    For x = 3 To myArraydir9.Length - 1 Step 2
        '        labelpack.EditValue = labelpack.EditValue & "/" & myArraydir9(x)
        '        labelpack.Width = 100 'If(labelpack.EditValue.ToString.Length * 8 > 80, labelpack.EditValue.ToString.Length * 8, 80)
        '    Next x
        '    Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        '    Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        '    ToolTipItem1.Text = labelpack.EditValue
        '    SuperToolTip1.Items.Add(ToolTipItem1)
        '    labelpack.SuperTip = SuperToolTip1
        'End If

        ''''''''''''''end Filtros

        ''''' estagiarios INOV

        If UCase(GetSetting("SalesReports", "User", "login")) = "SYMINGTON\SYMINOV" Then
            fieldVNO1.Visible = False
            fieldVNO1.Options.ShowInCustomizationForm = False
            fieldVNO2.Visible = False
            fieldVNO2.Options.ShowInCustomizationForm = False
            fieldVNO3.Visible = False
            fieldVNO3.Options.ShowInCustomizationForm = False
            fieldVNO4.Visible = False
            fieldVNO4.Options.ShowInCustomizationForm = False
            fieldVNO5.Visible = False
            fieldVNO5.Options.ShowInCustomizationForm = False
            fieldVNO6.Visible = False
            fieldVNO6.Options.ShowInCustomizationForm = False
            fieldVNO7.Visible = False
            fieldVNO7.Options.ShowInCustomizationForm = False
            fieldVNO8.Visible = False
            fieldVNO8.Options.ShowInCustomizationForm = False
            fieldVNO9.Visible = False
            fieldVNO9.Options.ShowInCustomizationForm = False
            fieldVNO10.Visible = False
            fieldVNO10.Options.ShowInCustomizationForm = False
            fieldVNO11.Visible = False
            fieldVNO11.Options.ShowInCustomizationForm = False
        End If


        If (flagfilterkeypais) = "Pais" Then
            fieldPais.Visible = True
            fieldPaisFact.Visible = False
            fieldPaisDest.Visible = False
        ElseIf (flagfilterkeypais) = "PaisFact" Then
            fieldPaisFact.AreaIndex = fieldPais.AreaIndex
            fieldPais.Visible = False
            fieldPaisDest.Visible = False
        Else

            fieldPaisDest.AreaIndex = fieldPais.AreaIndex
            fieldPais.Visible = False
            fieldPaisFact.Visible = False

        End If

        If (flagfilterkeycli) = "Cliente" Then
            fieldCliente.Visible = True
            fieldClienteFact.Visible = False
            fieldClienteDest.Visible = False
        ElseIf (flagfilterkeycli) = "ClienteFact" Then
            fieldClienteFact.AreaIndex = fieldCliente.AreaIndex
            fieldCliente.Visible = False
            fieldClienteDest.Visible = False
        Else
            fieldClienteDest.AreaIndex = fieldCliente.AreaIndex
            fieldCliente.Visible = False
            fieldClienteFact.Visible = False
        End If


        '   RibbonControl1.Minimized = True




        If Forcefilterkey Is Nothing Or Forcefilterkey = "" Then
            Dim Filterstr As String = "(" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And (Produto LIKE '%" & filtermark & "%')"
            ' SalesHistoricoBindingSource.Filter = UCase(Filterstr)
            Me.SalesHistoricoTableAdapter.FillByWhere(Me.SapCSDataSet.SalesHistorico, Filterstr)
        Else

            'trata force forcefilterkey
            Forcefilterkey = Forcefilterkey.Replace("cliente", "StatsClient")


            Dim Filterstr As String = "(" & Forcefilterkey & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And (Produto LIKE '%" & filtermark & "%')"
            '  SalesHistoricoBindingSource.Filter = UCase(Filterstr)
            Me.SalesHistoricoTableAdapter.FillByWhere(Me.SapCSDataSet.SalesHistorico, Filterstr)
        End If






        fieldANO1.Caption = SapCSDataSet.SalesHistorico(0).ANO - 1
        fieldANO2.Caption = SapCSDataSet.SalesHistorico(0).ANO - 2
        fieldANO3.Caption = SapCSDataSet.SalesHistorico(0).ANO - 3
        fieldANO4.Caption = SapCSDataSet.SalesHistorico(0).ANO - 4
        fieldANO5.Caption = SapCSDataSet.SalesHistorico(0).ANO - 5
        fieldANO6.Caption = SapCSDataSet.SalesHistorico(0).ANO - 6
        fieldANO7.Caption = SapCSDataSet.SalesHistorico(0).ANO - 7
        fieldANO8.Caption = SapCSDataSet.SalesHistorico(0).ANO - 8
        fieldANO9.Caption = SapCSDataSet.SalesHistorico(0).ANO - 9
        fieldANO10.Caption = SapCSDataSet.SalesHistorico(0).ANO - 10
        fieldANO11.Caption = SapCSDataSet.SalesHistorico(0).ANO - 11
        fieldVNO1.Caption = SapCSDataSet.SalesHistorico(0).ANO - 1 & " €"
        fieldVNO2.Caption = SapCSDataSet.SalesHistorico(0).ANO - 2 & " €"
        fieldVNO3.Caption = SapCSDataSet.SalesHistorico(0).ANO - 3 & " €"
        fieldVNO4.Caption = SapCSDataSet.SalesHistorico(0).ANO - 4 & " €"
        fieldVNO5.Caption = SapCSDataSet.SalesHistorico(0).ANO - 5 & " €"
        fieldVNO6.Caption = SapCSDataSet.SalesHistorico(0).ANO - 6 & " €"
        fieldVNO7.Caption = SapCSDataSet.SalesHistorico(0).ANO - 7 & " €"
        fieldVNO8.Caption = SapCSDataSet.SalesHistorico(0).ANO - 8 & " €"
        fieldVNO9.Caption = SapCSDataSet.SalesHistorico(0).ANO - 9 & " €"
        fieldVNO10.Caption = SapCSDataSet.SalesHistorico(0).ANO - 10 & " €"
        fieldVNO11.Caption = SapCSDataSet.SalesHistorico(0).ANO - 11 & " €"










        SortFields(PivotGridControl1)

    End Sub


    Private Sub PivotGridControl1_CustomUnboundFieldData(ByVal sender As System.Object, ByVal e As DevExpress.XtraPivotGrid.CustomFieldDataEventArgs) Handles PivotGridControl1.CustomUnboundFieldData

        If e.Field.Name = "fieldVintage" Then
            Try
                Dim subs As String
                subs = e.GetListSourceColumnValue("SUBCAT").ToString.ToUpper
                If subs.StartsWith("VINTAGE") Or subs.StartsWith("QUINTAS") Then
                    e.Value = 1
                Else
                    e.Value = 0

                End If
            Catch
            End Try

        ElseIf e.Field Is fieldPortConsumoBrandy Then
            Try

                Dim subs As String
                subs = e.GetListSourceColumnValue("TIPO").ToString.ToUpper

                If subs.StartsWith("PORT") Then
                    e.Value = "Port"
                ElseIf subs.StartsWith("CONSUMO") Then
                    e.Value = "Consumo"
                ElseIf subs.StartsWith("BRANDY") Then
                    e.Value = "Brandy"
                Else
                    e.Value = "???"
                End If
            Catch ex As Exception

            End Try

        End If
        Return
    End Sub





    'Private Sub PivotGridControl1_CustomAppearance(ByVal sender As System.Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs) Handles PivotGridControl1.CustomAppearance
    '    If PivotGridControl1.FormatConditions.Count > 0 Then Exit Sub
    '    If e.RowIndex Mod 2 = 0 Then
    '        e.Appearance.BackColor = Color.White
    '    Else
    '        e.Appearance.BackColor = Color.WhiteSmoke
    '    End If
    '    If e.RowValueType = PivotGridValueType.GrandTotal Or e.RowValueType = PivotGridValueType.Total Then
    '        e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
    '    End If
    'End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        MsgBox("O nome do ficheiro deve começar por 'Sales'." & vbCrLf & "The name of the file must start with 'Sales'." & vbCrLf & "Ex: ', Ex: 'SalesByPackage'", MsgBoxStyle.Information, "Commercial System")
        If savefilexml.ShowDialog() = DialogResult.OK Then
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


        If filenamexml.ShowDialog() = DialogResult.OK Then
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

        End If
    End Sub

    Private Sub PivotGridControl1_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles PivotGridControl1.FieldValueDisplayText
        Try

            If e.Field Is Nothing Then
                Exit Sub
            End If

            If Not (e.Field Is fieldVintage) Then Return
            If CInt(e.Value) = 1 Then
                'e.DisplayText = "Vintage"
                e.DisplayText = "Bottle Matured"
            Else
                'e.DisplayText = "Non Vintage"
                e.DisplayText = "Wood Matured"
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
        RemoveHandler DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged, AddressOf UserLookAndFeel_StyleChanged


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
        Dim ret2 As Object = DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to open the file?", "Choose..", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        If ret2 = 6 Then Process.Start(str)

    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Dim ret As Object = DevExpress.XtraEditors.XtraMessageBox.Show("Click 'YES' to create a Formatted File or 'NO' to a Tabular File", "Choose..", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        If ret = 6 Then
            PivotGridControl1.OptionsPrint.MergeColumnFieldValues = True
            PivotGridControl1.OptionsPrint.MergeRowFieldValues = True
            PrintableComponentLink1.CreateDocument()
            Dim filename As New FolderBrowserDialog
            filename.ShowDialog()
            Dim str As String
            str = filename.SelectedPath & "\SalesReport" & Now.Hour & Now.Minute & Now.Second & ".xlsx"
            PrintingSystem1.ExportToXlsx(str)
            Dim ret2 As Object = DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to open the file?", "Choose..", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If ret2 = 6 Then Process.Start(str)

        ElseIf ret = 7 Then
            PivotGridControl1.OptionsPrint.MergeColumnFieldValues = False
            PivotGridControl1.OptionsPrint.MergeRowFieldValues = False
            PivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False

            PivotGridControl1.OptionsView.ShowRowGrandTotals = False
            PivotGridControl1.OptionsView.ShowColumnGrandTotals = False
            PivotGridControl1.OptionsView.ShowColumnTotals = False
            PivotGridControl1.OptionsView.ShowRowTotals = False


            Dim filename As New FolderBrowserDialog
            filename.ShowDialog()
            Dim str As String
            str = filename.SelectedPath & "\SalesReport" & Now.Hour & Now.Minute & Now.Second & ".xlsx"


            Dim xlsxOptionsEx As XlsxExportOptionsEx = New XlsxExportOptionsEx
            xlsxOptionsEx.ExportType = ExportType.DataAware

            xlsxOptionsEx.AllowGrouping = DevExpress.Utils.DefaultBoolean.False
            xlsxOptionsEx.RawDataMode = True
            xlsxOptionsEx.ShowGroupSummaries = DevExpress.Utils.DefaultBoolean.False
            PivotGridControl1.ExportToXlsx(str, xlsxOptionsEx)

            'PivotGridControl1.ExportToXlsx(str)
            Dim ret2 As Object = DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to open the file?", "Choose..", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If ret2 = 6 Then Process.Start(str)



            PivotGridControl1.OptionsView.ShowRowGrandTotals = True
            PivotGridControl1.OptionsView.ShowColumnGrandTotals = True
            PivotGridControl1.OptionsView.ShowColumnTotals = True
            PivotGridControl1.OptionsView.ShowRowTotals = True

        Else
            Exit Sub
        End If

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

        bitpath = "c:\commercialsystem\" & "\cruz.gif"
        If Not labelcomp.EditValue = "" Then
            Try
                Select Case UCase(labelcomp.EditValue.ToString)
                    Case "QUARLES HARRIS"
                        bitpath = "c:\commercialsystem\" & "\QUA.JPG"
                    Case "GRAHAM’S"
                        bitpath = "c:\commercialsystem\" & "\w &.jpg"
                    Case "WARRE"
                        bitpath = "c:\commercialsystem\" & "\war.JPG"
                    Case "S.W."
                        bitpath = "c:\commercialsystem\" & "\smi.JPG"
                    Case "QUINTA DO RORIZ"
                        bitpath = "c:\commercialsystem\" & "\ror.JPG"
                    Case "SILVA & COSENS"
                        bitpath = "c:\commercialsystem\" & "\dow.JPG"
                    Case "QUINTA DO VESÚVIO"
                        bitpath = "c:\commercialsystem\" & "\soc.JPG"
                    Case "PRATS & SYMINGTON"
                        bitpath = "c:\commercialsystem\" & "\pes.JPG"
                    Case "GOULD CAMPBELL"
                        bitpath = "c:\commercialsystem\" & "\gou.JPG"
                    Case "COCKBURN’S"
                        bitpath = "c:\commercialsystem\" & "\cock.JPG"
                    Case "MARTINEZ"
                        bitpath = "c:\commercialsystem\" & "\mar.JPG"

                    Case Else

                        bitpath = "c:\commercialsystem\" & "\cruz.gif"
                End Select
            Catch ex As Exception
                bitpath = "c:\commercialsystem\" & "\cruz.gif"
            End Try
        Else
            bitpath = "c:\commercialsystem\" & "\cruz.gif"
        End If
        If Not labeltype.EditValue = "" Then
            If labeltype.EditValue.ToString.Contains("BOB") Then bitpath = "c:\commercialsystem\" & "\cruz.gif"
        End If


        Dim imagelist1 As New Bitmap(bitpath)
        Dim r As New RectangleF(0, 0, imagelist1.Width / 3, imagelist1.Height / 3)
        r.Offset((e.Graph.ClientPageSize.Width / 2) - (r.Width / 2), 0)
        e.Graph.DrawImage(imagelist1, r, DevExpress.XtraPrinting.BorderSide.None, Color.Transparent)

        Dim yearstr As String = ""



        If UCase(varstrCaption) = "HISTORY 9L" Then

            e.Graph.DrawString("Historic 9L", Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 450, 50, 150, 40), DevExpress.XtraPrinting.BorderSide.None)

        ElseIf UCase(varstrCaption) = "HISTORY VALUES" Then
            yearstr = Now.Year
            e.Graph.DrawString("Historic Values", Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 450, 50, 150, 40), DevExpress.XtraPrinting.BorderSide.None)

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

    Private Sub Top5_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Top5.CheckedChanged
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



    Private Sub savefilexml_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles savefilexml.FileOk
        If savefilexml.FileName.StartsWith("c:\CommercialSystem\dados\Sales", StringComparison.InvariantCultureIgnoreCase) And savefilexml.FileName.EndsWith(".XML", StringComparison.InvariantCultureIgnoreCase) Then

        Else
            MsgBox("Erro no nome do ficheiro.", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
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



    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtConditionalFormat.ItemClick
        Dim s As PivotCellBaseEventArgs = PivotGridControl1.Cells.GetFocusedCellInfo
        Dim Meupoint As New Point
        Meupoint = New Point(e.Link.Bounds.Left, e.Link.Bounds.Top + BtConditionalFormat.Size.Height + 20)

        Dim dlg As frmStyleConditions = New frmStyleConditions(Meupoint, fieldSalesManager)


        Dim fieldPivot As PivotGridField
        For Each fieldPivot In PivotGridControl1.Fields ' lista
            dlg.CBField.Properties.Items.Add(fieldPivot)
        Next

        dlg.ShowDialog()

    End Sub



    Private Sub BarCheckItem1_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.CheckedChanged
        If BarCheckItem1.Checked = True Then
            PivotGridControl1.OptionsView.ShowCustomTotalsForSingleValues = True
            PivotGridControl1.OptionsView.ShowGrandTotalsForSingleValues = True
            PivotGridControl1.OptionsView.ShowTotalsForSingleValues = True
        Else
            PivotGridControl1.OptionsView.ShowCustomTotalsForSingleValues = False
            PivotGridControl1.OptionsView.ShowGrandTotalsForSingleValues = False
            PivotGridControl1.OptionsView.ShowTotalsForSingleValues = False

        End If
    End Sub

    Private Shared Sub UserLookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim skin As DevExpress.Skins.Skin = DevExpress.Skins.CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        If My.Settings.skin <> skin.Name Then
            My.Settings.skin = skin.Name
            My.Settings.Save()
        End If
    End Sub


    Private Sub PivotGridControl1_FieldAreaChanged(sender As Object, e As PivotFieldEventArgs) Handles PivotGridControl1.FieldAreaChanged
        If (e.Field.Area <> PivotArea.FilterArea) Then Exit Sub
        SortFields(sender)

    End Sub


    Private Sub SortFields(pivot As PivotGridControl)
        Dim fields As New Generic.List(Of PivotGridField)()
        For Each f As PivotGridField In pivot.Fields
            If f.Visible AndAlso f.Area = PivotArea.FilterArea Then
                fields.Add(f)
            End If
        Next
        fields.Sort(New Comparison(Of PivotGridField)(Function(f1 As PivotGridField, f2 As PivotGridField) System.Collections.Comparer.DefaultInvariant.Compare(f1.ToString(), f2.ToString())))
        For i As Integer = 0 To fields.Count - 1
            fields(i).AreaIndex = i
        Next
    End Sub
End Class
