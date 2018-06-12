Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraBars
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars.Helpers
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPrinting
Imports DevExpress.Export

Public Class FormPivotComp



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
    Public filterkeyregion As String
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

    Dim labelregion As New BarEditItem
    Dim labeldir As New BarEditItem
    Dim labelpais As New BarEditItem
    Dim labelcli As New BarEditItem
    Dim labelcomp As New BarEditItem
    Dim labeltype As New BarEditItem
    Dim labelmarca As New BarEditItem
    Dim labelgroup As New BarEditItem
    Dim labelprod As New BarEditItem
    Dim labelanocol As New BarEditItem
    Dim labelpacka As New BarEditItem



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.Top = 0
        Me.Left = 0
        Me.Text = varstrCaption
        SkinHelper.InitSkinGallery(RibbonGalleryBarItem1, True)

        AddHandler DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged, AddressOf UserLookAndFeel_StyleChanged





        ' '''''''''''''''''''Filtro
        Dim myArraydir10() As String = Split(filterkeyregion, "'")
        If myArraydir10(1) = "%" Then
        ElseIf myArraydir10.Length = 3 Then
            RibbonControl1.Items.Add(labelregion)
            RibbonPageFiltersApplied.ItemLinks.Add(labelregion)
            labelregion.CanOpenEdit = False
            labelregion.Edit = Me.RepositoryItemTextEdit1
            labelregion.EditValue = myArraydir10(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelregion.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelregion.SuperTip = SuperToolTip1
            labelregion.Width = 100
        ElseIf myArraydir10.Length > 3 Then
            RibbonControl1.Items.Add(labelregion)
            RibbonPageFiltersApplied.ItemLinks.Add(labelregion)
            labelregion.CanOpenEdit = False
            labelregion.Edit = Me.RepositoryItemTextEdit1
            labelregion.EditValue = myArraydir10(1)
            Dim x As Integer
            For x = 3 To myArraydir10.Length - 1 Step 2
                labelregion.EditValue = labelregion.EditValue & "/" & myArraydir10(x)
                labelregion.Width = 100
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelregion.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelregion.SuperTip = SuperToolTip1
        End If

        Dim myArraydir() As String = Split(filterkeydir, "'")
        If myArraydir(1) = "%" Then
        ElseIf myArraydir.Length = 3 Then
            RibbonControl1.Items.Add(labeldir)
            RibbonPageFiltersApplied.ItemLinks.Add(labeldir)
            labeldir.CanOpenEdit = False
            labeldir.Edit = Me.RepositoryItemTextEdit1
            If UCase(flagfilterkeydir) = "MD" Then
                labeldir.EditValue = "Representative: " & myArraydir(1)
            ElseIf UCase(flagfilterkeydir) = "MA" Then
                labeldir.EditValue = "Assistant: " & myArraydir(1)
            Else
                labeldir.EditValue = "Manager: " & myArraydir(1)
            End If
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labeldir.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labeldir.SuperTip = SuperToolTip1
            labeldir.Width = 100
        ElseIf myArraydir.Length > 3 Then
            RibbonControl1.Items.Add(labeldir)
            RibbonPageFiltersApplied.ItemLinks.Add(labeldir)
            labeldir.CanOpenEdit = False
            labeldir.Edit = Me.RepositoryItemTextEdit1
            labeldir.EditValue = myArraydir(1)
            Dim x As Integer
            For x = 3 To myArraydir.Length - 1 Step 2
                labeldir.EditValue = labeldir.EditValue & "/" & myArraydir(x)
                labeldir.Width = 100
            Next x
            If UCase(flagfilterkeydir) = "MD" Then
                labeldir.EditValue = "Representative: " & labeldir.EditValue
            ElseIf UCase(flagfilterkeydir) = "MA" Then
                labeldir.EditValue = "Assistant: " & labeldir.EditValue
            Else
                labeldir.EditValue = "Manager: " & labeldir.EditValue
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
        ElseIf myArraydir1.Length = 3 Then
            RibbonControl1.Items.Add(labelpais)
            RibbonPageFiltersApplied.ItemLinks.Add(labelpais)
            labelpais.CanOpenEdit = False
            labelpais.Edit = Me.RepositoryItemTextEdit1

            If (flagfilterkeypais) = "StatsMarket" Then
                labelpais.EditValue = "Stats Market: " & myArraydir1(1)
            ElseIf (flagfilterkeypais) = "InvMarket" Then
                labelpais.EditValue = "Invoicing Market: " & myArraydir1(1)

                PivotGridControl1.Fields("StatsMarket").Area = PivotArea.FilterArea
                PivotGridControl1.Fields("StatsMarket").AreaIndex = 6

                PivotGridControl1.Fields("InvMarket").Area = PivotArea.RowArea
                PivotGridControl1.Fields("InvMarket").AreaIndex = 0
            Else
                labelpais.EditValue = "Final Market: " & myArraydir1(1)
                PivotGridControl1.Fields("StatsMarket").Area = PivotArea.FilterArea
                PivotGridControl1.Fields("StatsMarket").AreaIndex = 6

                PivotGridControl1.Fields("FinalMarket").Area = PivotArea.RowArea
                PivotGridControl1.Fields("FinalMarket").AreaIndex = 0
            End If


            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelpais.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelpais.SuperTip = SuperToolTip1
            labelpais.Width = 100
        ElseIf myArraydir1.Length > 3 Then
            RibbonControl1.Items.Add(labelpais)
            RibbonPageFiltersApplied.ItemLinks.Add(labelpais)
            labelpais.CanOpenEdit = False
            labelpais.Edit = Me.RepositoryItemTextEdit1
            labelpais.EditValue = myArraydir1(1)
            Dim x As Integer
            For x = 3 To myArraydir1.Length - 1 Step 2
                labelpais.EditValue = labelpais.EditValue & "/" & myArraydir1(x)
                labelpais.Width = 100
            Next x
            If (flagfilterkeypais) = "StatsMarket" Then
                labelpais.EditValue = "Stats Market: " & labelpais.EditValue
            ElseIf (flagfilterkeypais) = "InvMarket" Then
                labelpais.EditValue = "Invoicing Market: " & labelpais.EditValue
                PivotGridControl1.Fields("StatsMarket").Area = PivotArea.FilterArea
                PivotGridControl1.Fields("StatsMarket").AreaIndex = 6

                PivotGridControl1.Fields("InvMarket").Area = PivotArea.RowArea
                PivotGridControl1.Fields("InvMarket").AreaIndex = 0
            Else
                labelpais.EditValue = "Final Market: " & labelpais.EditValue
                PivotGridControl1.Fields("StatsMarket").Area = PivotArea.FilterArea
                PivotGridControl1.Fields("StatsMarket").AreaIndex = 6

                PivotGridControl1.Fields("FinalMarket").Area = PivotArea.RowArea
                PivotGridControl1.Fields("FinalMarket").AreaIndex = 0

            End If
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelpais.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelpais.SuperTip = SuperToolTip1
        End If

        Dim myArraydir2() As String = Split(filterkeycli, "'")
        If myArraydir2(1) = "%" Then

        ElseIf myArraydir2.Length = 3 Then
            RibbonControl1.Items.Add(labelcli)
            RibbonPageFiltersApplied.ItemLinks.Add(labelcli)
            labelcli.CanOpenEdit = False
            labelcli.Edit = Me.RepositoryItemTextEdit1
            If (flagfilterkeycli) = "StatsClient" Then
                labelcli.EditValue = "Stats Cust: " & myArraydir2(1)
            ElseIf (flagfilterkeycli) = "InvClient" Then
                labelcli.EditValue = "Invoic Cust: " & myArraydir2(1)
            Else
                labelcli.EditValue = "Final Cust: " & myArraydir2(1)
            End If

            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelcli.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelcli.SuperTip = SuperToolTip1
            labelcli.Width = 100
        ElseIf myArraydir2.Length > 3 Then

            RibbonControl1.Items.Add(labelcli)
            RibbonPageFiltersApplied.ItemLinks.Add(labelcli)
            labelcli.CanOpenEdit = False
            labelcli.Edit = Me.RepositoryItemTextEdit1
            labelcli.EditValue = myArraydir2(1)
            Dim x As Integer
            For x = 3 To myArraydir2.Length - 1 Step 2
                labelcli.EditValue = labelcli.EditValue & "/" & myArraydir2(x)
                labelcli.Width = 100
            Next x

            If (flagfilterkeycli) = "StatsClient" Then
                labelcli.EditValue = "Stats Cust: " & labelcli.EditValue
            ElseIf (flagfilterkeycli) = "InvClient" Then
                labelcli.EditValue = "Invoic Cust: " & labelcli.EditValue
            Else
                labelcli.EditValue = "Final Cust: " & labelcli.EditValue
            End If

            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelcli.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelcli.SuperTip = SuperToolTip1
        End If

        Dim myArraydir3() As String = Split(filterkeycomp.Replace("''", "’"), "'")
        If myArraydir3(1) = "%" Then
        ElseIf myArraydir3.Length = 3 Then
            RibbonControl1.Items.Add(labelcomp)
            RibbonPageFiltersApplied.ItemLinks.Add(labelcomp)
            labelcomp.CanOpenEdit = False
            labelcomp.Edit = Me.RepositoryItemTextEdit1
            labelcomp.EditValue = myArraydir3(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelcomp.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelcomp.SuperTip = SuperToolTip1
            labelcomp.Width = 100
        ElseIf myArraydir3.Length > 3 Then

            RibbonControl1.Items.Add(labelcomp)
            RibbonPageFiltersApplied.ItemLinks.Add(labelcomp)
            labelcomp.CanOpenEdit = False
            labelcomp.Edit = Me.RepositoryItemTextEdit1
            labelcomp.EditValue = myArraydir3(1)
            Dim x As Integer
            For x = 3 To myArraydir3.Length - 1 Step 2
                labelcomp.EditValue = labelcomp.EditValue & "/" & myArraydir3(x)
                labelcomp.Width = 100
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelcomp.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelcomp.SuperTip = SuperToolTip1
        End If

        Dim myArraydir4() As String = Split(filterkeytype, "'")
        If myArraydir4(1) = "%" Then

        ElseIf myArraydir4.Length = 3 Then

            RibbonControl1.Items.Add(labeltype)
            RibbonPageFiltersApplied.ItemLinks.Add(labeltype)
            labeltype.CanOpenEdit = False
            labeltype.Edit = Me.RepositoryItemTextEdit1
            labeltype.EditValue = myArraydir4(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labeltype.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labeltype.SuperTip = SuperToolTip1

            labeltype.Width = 100
        ElseIf myArraydir4.Length > 3 Then

            RibbonControl1.Items.Add(labeltype)
            RibbonPageFiltersApplied.ItemLinks.Add(labeltype)
            labeltype.CanOpenEdit = False
            labeltype.Edit = Me.RepositoryItemTextEdit1
            labeltype.EditValue = myArraydir4(1)
            Dim x As Integer
            For x = 3 To myArraydir4.Length - 1 Step 2
                labeltype.EditValue = labeltype.EditValue & "/" & myArraydir4(x)
                labeltype.Width = 100
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

        ElseIf myArraydir5.Length = 3 Then

            RibbonControl1.Items.Add(labelmarca)
            RibbonPageFiltersApplied.ItemLinks.Add(labelmarca)
            labelmarca.CanOpenEdit = False
            labelmarca.Edit = Me.RepositoryItemTextEdit1
            labelmarca.EditValue = myArraydir5(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelmarca.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelmarca.SuperTip = SuperToolTip1

            labelmarca.Width = 100
        ElseIf myArraydir5.Length > 3 Then

            RibbonControl1.Items.Add(labelmarca)
            RibbonPageFiltersApplied.ItemLinks.Add(labelmarca)
            labelmarca.CanOpenEdit = False
            labelmarca.Edit = Me.RepositoryItemTextEdit1
            labelmarca.EditValue = myArraydir5(1)
            Dim x As Integer
            For x = 3 To myArraydir5.Length - 1 Step 2
                labelmarca.EditValue = labelmarca.EditValue & "/" & myArraydir5(x)
                labelmarca.Width = 100
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelmarca.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelmarca.SuperTip = SuperToolTip1

        End If

        Dim myArraydir6() As String = Split(filterkeygroup, "'")
        If myArraydir6(1) = "%" Then

        ElseIf myArraydir6.Length = 3 Then

            RibbonControl1.Items.Add(labelgroup)
            RibbonPageFiltersApplied.ItemLinks.Add(labelgroup)
            labelgroup.CanOpenEdit = False
            labelgroup.Edit = Me.RepositoryItemTextEdit1
            labelgroup.EditValue = myArraydir6(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelgroup.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelgroup.SuperTip = SuperToolTip1

            labelgroup.Width = 100
        ElseIf myArraydir6.Length > 3 Then

            RibbonControl1.Items.Add(labelgroup)
            RibbonPageFiltersApplied.ItemLinks.Add(labelgroup)
            labelgroup.CanOpenEdit = False
            labelgroup.Edit = Me.RepositoryItemTextEdit1
            labelgroup.EditValue = myArraydir6(1)
            Dim x As Integer
            For x = 3 To myArraydir6.Length - 1 Step 2
                labelgroup.EditValue = labelgroup.EditValue & "/" & myArraydir6(x)
                labelgroup.Width = 100
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelgroup.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelgroup.SuperTip = SuperToolTip1

        End If

        Dim myArraydir7() As String = Split(filterkeyprod, "'")
        If myArraydir7(1) = "%" Then

        ElseIf myArraydir7.Length = 3 Then

            RibbonControl1.Items.Add(labelprod)
            RibbonPageFiltersApplied.ItemLinks.Add(labelprod)
            labelprod.CanOpenEdit = False
            labelprod.Edit = Me.RepositoryItemTextEdit1
            If UCase(flagfilterkeyprod) = "CATEGORIA" Then labelprod.EditValue = "Category: " & myArraydir7(1) Else labelprod.EditValue = "Family: " & myArraydir7(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelprod.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelprod.SuperTip = SuperToolTip1
            labelprod.Width = 100
        ElseIf myArraydir7.Length > 3 Then

            RibbonControl1.Items.Add(labelprod)
            RibbonPageFiltersApplied.ItemLinks.Add(labelprod)
            labelprod.CanOpenEdit = False
            labelprod.Edit = Me.RepositoryItemTextEdit1
            labelprod.EditValue = myArraydir7(1)
            Dim x As Integer
            For x = 3 To myArraydir7.Length - 1 Step 2
                labelprod.EditValue = labelprod.EditValue & "/" & myArraydir7(x)
            Next x
            If UCase(flagfilterkeyprod) = "CATEGORIA" Then labelprod.EditValue = "Category: " & labelprod.EditValue Else labelprod.EditValue = "Family: " & labelprod.EditValue
            labelprod.Width = 100
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelprod.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelprod.SuperTip = SuperToolTip1
        End If

        Dim myArraydir8() As String = Split(filterkeyAnocol, "'")
        If myArraydir8(1) = "%" Then

        ElseIf myArraydir8.Length = 3 Then

            RibbonControl1.Items.Add(labelanocol)
            RibbonPageFiltersApplied.ItemLinks.Add(labelanocol)
            labelanocol.CanOpenEdit = False
            labelanocol.Edit = Me.RepositoryItemTextEdit1
            labelanocol.EditValue = myArraydir8(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelanocol.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelanocol.SuperTip = SuperToolTip1
            labelanocol.Width = 100
        ElseIf myArraydir8.Length > 3 Then

            RibbonControl1.Items.Add(labelanocol)
            RibbonPageFiltersApplied.ItemLinks.Add(labelanocol)
            labelanocol.CanOpenEdit = False
            labelanocol.Edit = Me.RepositoryItemTextEdit1
            labelanocol.EditValue = myArraydir8(1)
            Dim x As Integer
            For x = 3 To myArraydir8.Length - 1 Step 2
                labelanocol.EditValue = labelanocol.EditValue & "/" & myArraydir8(x)
                labelanocol.Width = 100
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelanocol.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelanocol.SuperTip = SuperToolTip1
        End If

        Dim myArraydir9() As String = Split(filterkeypackage, "'")
        If myArraydir9(1) = "%" Then

        ElseIf myArraydir9.Length = 3 Then

            RibbonControl1.Items.Add(labelpacka)
            RibbonPageFiltersApplied.ItemLinks.Add(labelpacka)
            labelpacka.CanOpenEdit = False
            labelpacka.Edit = Me.RepositoryItemTextEdit1
            labelpacka.EditValue = myArraydir9(1)
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelpacka.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelpacka.SuperTip = SuperToolTip1
            labelpacka.Width = 100
        ElseIf myArraydir9.Length > 3 Then

            RibbonControl1.Items.Add(labelpacka)
            RibbonPageFiltersApplied.ItemLinks.Add(labelpacka)
            labelpacka.CanOpenEdit = False
            labelpacka.Edit = Me.RepositoryItemTextEdit1
            labelpacka.EditValue = myArraydir9(1)
            Dim x As Integer
            For x = 3 To myArraydir9.Length - 1 Step 2
                labelpacka.EditValue = labelpacka.EditValue & "/" & myArraydir9(x)
                labelpacka.Width = 100
            Next x
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
            ToolTipItem1.Text = labelpacka.EditValue
            SuperToolTip1.Items.Add(ToolTipItem1)
            labelpacka.SuperTip = SuperToolTip1
        End If

        ' ''''''''''''''end Filtros

        ''''' estagiarios INOV

        If UCase(GetSetting("SalesReports", "User", "login")) = "SYMINGTON\SYMINOV" Then
            fieldValueShipHand.Visible = False
            fieldValueShipHand.Options.ShowInCustomizationForm = False
            fieldValueInHand.Visible = False
            fieldValueInHand.Options.ShowInCustomizationForm = False
            fieldValueShipped.Visible = False
            fieldValueShipped.Options.ShowInCustomizationForm = False
            fieldPricePer9L.Visible = False
            fieldPricePer9L.Options.ShowInCustomizationForm = False

        End If




        ' Mudanças de tabela...
        If flagValores = False Then
            fieldValueInHand.Visible = False
            fieldValueInHand.Options.ShowInCustomizationForm = False
            fieldValueShipped.Visible = False
            fieldValueShipped.Options.ShowInCustomizationForm = False
            fieldPricePer9L.Visible = False
            fieldPricePer9L.Options.ShowInCustomizationForm = False
            fieldDate1.Area = PivotArea.ColumnArea
        End If


        If Forcefilterkey Is Nothing Or Forcefilterkey = "" Then
            If varstrCaption = "Sales Comparison LY" Then
                Dim Filterstr As String = "( Year = '" & Today.Year - 1 & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And  (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 2 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSales, Filterstr)
                'PivotGridControl1.Prefilter.CriteriaString = "([" & fieldDate.PrefilterColumnName & "] < #" & DateTime.Today.AddYears(-1).ToString("d", System.Globalization.CultureInfo.InvariantCulture) & "# AND [" & fieldYear.PrefilterColumnName & "] = '" & Today.Year.ToString - 1 & "') or ([" & fieldDate.PrefilterColumnName & "] < #" & DateTime.Today.ToString("d", System.Globalization.CultureInfo.InvariantCulture) & "# AND [" & fieldYear.PrefilterColumnName & "] = '" & Today.Year.ToString & "')"
            ElseIf varstrCaption = "Sales Comparison TY" Then
                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSales, Filterstr)
                'PivotGridControl1.Pre1filter.CriteriaString = "([" & fieldDate.PrefilterColumnName & "] < #" & DateTime.Today.AddYears(-1).ToString("d", System.Globalization.CultureInfo.InvariantCulture) & "# AND [" & fieldYear.PrefilterColumnName & "] = '" & Today.Year.ToString - 1 & "') or ([" & fieldDate.PrefilterColumnName & "] < #" & DateTime.Today.ToString("d", System.Globalization.CultureInfo.InvariantCulture) & "# AND [" & fieldYear.PrefilterColumnName & "] = '" & Today.Year.ToString & "')"


                ''''''packs
                ''''''packs
            ElseIf varstrCaption = "Packs - Sales Comparison LY" Then
                Dim Filterstr As String = "( Year = '" & Today.Year - 1 & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 2 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesCompostosTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesCompostos, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesCompostos"

            ElseIf varstrCaption = "Packs - Sales Comparison TY" Then
                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesCompostosTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesCompostos, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesCompostos"

            ElseIf varstrCaption = "Packs - Sales Comparison" Then

                Dim dia As String = Now.Day.ToString("00")
                Dim mes As String = Now.Month.ToString("00")

                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And ([Date] < Datetime('" & Now.Year & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And ([Date] < Datetime('" & Now.Year - 1 & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"
                Me.SapSalesCompostosTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesCompostos, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesCompostos"

                ''''''packs
                ''''''packs



                ''''''OldReserves
                ''''''OldReserves
            ElseIf varstrCaption = "OldReserves - Sales Comparison LY" Then
                Dim Filterstr As String = "( Year = '" & Today.Year - 1 & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 2 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesOldReservesTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesOldReserves, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesOldReserves"

            ElseIf varstrCaption = "OldReserves - Sales Comparison TY" Then
                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesOldReservesTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesOldReserves, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesOldReserves"

            ElseIf varstrCaption = "OldReserves - Sales Comparison" Then

                Dim dia As String = Now.Day.ToString("00")
                Dim mes As String = Now.Month.ToString("00")

                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And ([Date] < Datetime('" & Now.Year & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And ([Date] < Datetime('" & Now.Year - 1 & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"
                Me.SapSalesOldReservesTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesOldReserves, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesOldReserves"

                ''''''OldReserves
                ''''''OldReserves







                ''''SAMPLES'''''''
            ElseIf UCase(varstrCaption) = "SAMPLES - CURRENT" Then
                'trata force forcefilterkey
                Forcefilterkey = Forcefilterkey.Replace("cliente", "StatsClient")
                Dim Filterstr As String = "([Year] = '" & Now.Year.ToString & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesAmostrasTableAdapter.FillByWhere(Me.CommercialSystemDataSet2.SapSalesAmostras, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesAmostras"


            ElseIf UCase(varstrCaption) = "SAMPLES - LY" Then
                'trata force forcefilterkey
                Forcefilterkey = Forcefilterkey.Replace("cliente", "StatsClient")
                Dim Filterstr As String = "([Year] = '" & Now.Year.ToString - 1 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesAmostrasTableAdapter.FillByWhere(Me.CommercialSystemDataSet2.SapSalesAmostras, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesAmostras"


                ''''SAMPLES'''''''


                ''''''germanwarehouse
                ''''''germanwarehouse
            ElseIf varstrCaption = "German Warehouse - Sales Comparison LY" Then
                Dim Filterstr As String = "( Year = '" & Today.Year - 1 & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 2 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesGermanWarehouseTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesGermanWarehouse, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesOldReserves"

            ElseIf varstrCaption = "German Warehouse - Sales Comparison TY" Then
                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesGermanWarehouseTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesGermanWarehouse, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesOldReserves"

            ElseIf varstrCaption = "German Warehouse - Sales Comparison" Then

                Dim dia As String = Now.Day.ToString("00")
                Dim mes As String = Now.Month.ToString("00")

                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And ([Date] < Datetime('" & Now.Year & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And ([Date] < Datetime('" & Now.Year - 1 & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"
                Me.SapSalesGermanWarehouseTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesGermanWarehouse, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesOldReserves"

                ''''''OldReserves
                ''''''OldReserves









            Else
                Dim dia As String = Now.Day.ToString("00")
                Dim mes As String = Now.Month.ToString("00")

                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And ([Date] < Datetime('" & Now.Year & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And ([Date] < Datetime('" & Now.Year - 1 & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"
                Me.SapSalesTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSales, Filterstr)
                ' PivotGridControl1.Prefilter.CriteriaString = "([" & fieldDate.PrefilterColumnName & "] < #" & DateTime.Today.AddYears(-1).ToString("d", System.Globalization.CultureInfo.InvariantCulture) & "# AND [" & fieldYear.PrefilterColumnName & "] = '" & Today.Year.ToString - 1 & "') or ([" & fieldDate.PrefilterColumnName & "] < #" & DateTime.Today.ToString("d", System.Globalization.CultureInfo.InvariantCulture) & "# AND [" & fieldYear.PrefilterColumnName & "] = '" & Today.Year.ToString & "')"
            End If


        Else

            'trata force forcefilterkey
            Forcefilterkey = Forcefilterkey.Replace("cliente", "StatsClient")

            '  Dim Filterstr As String = "( Year = '" & Today.Year & "' Or Year = '" & Today.Year - 1 & "') And (" & Forcefilterkey & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

            If varstrCaption = "Sales Comparison LY" Then


                Dim Filterstr As String = "( Year = '" & Today.Year - 1 & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 2 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSales, Filterstr)
                'PivotGridControl1.Prefilter.CriteriaString = "([" & fieldDate.PrefilterColumnName & "] < #" & DateTime.Today.AddYears(-1).ToString("d", System.Globalization.CultureInfo.InvariantCulture) & "# AND [" & fieldYear.PrefilterColumnName & "] = '" & Today.Year.ToString - 1 & "') or ([" & fieldDate.PrefilterColumnName & "] < #" & DateTime.Today.ToString("d", System.Globalization.CultureInfo.InvariantCulture) & "# AND [" & fieldYear.PrefilterColumnName & "] = '" & Today.Year.ToString & "')"

            ElseIf varstrCaption = "Sales Comparison TY" Then


                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSales, Filterstr)
                'PivotGridControl1.Prefilter.CriteriaString = "([" & fieldDate.PrefilterColumnName & "] < #" & DateTime.Today.AddYears(-1).ToString("d", System.Globalization.CultureInfo.InvariantCulture) & "# AND [" & fieldYear.PrefilterColumnName & "] = '" & Today.Year.ToString - 1 & "') or ([" & fieldDate.PrefilterColumnName & "] < #" & DateTime.Today.ToString("d", System.Globalization.CultureInfo.InvariantCulture) & "# AND [" & fieldYear.PrefilterColumnName & "] = '" & Today.Year.ToString & "')"

                ''''''packs
                ''''''packs


            ElseIf varstrCaption = "Packs - Sales Comparison TY" Then
                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesCompostosTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesCompostos, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesCompostos"

            ElseIf varstrCaption = "Packs - Sales Comparison LY" Then
                Dim Filterstr As String = "( Year = '" & Today.Year - 1 & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 2 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesCompostosTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesCompostos, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesCompostos"

            ElseIf varstrCaption = "Packs - Sales Comparison" Then

                Dim dia As String = Now.Day.ToString("00")
                Dim mes As String = Now.Month.ToString("00")

                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And ([Date] < Datetime('" & Now.Year & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And ([Date] < Datetime('" & Now.Year - 1 & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"
                Me.SapSalesCompostosTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesCompostos, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesCompostos"

                ''''''packs
                ''''''packs



                ''''''OldReserves
                ''''''OldReserves


            ElseIf varstrCaption = "OldReserves - Sales Comparison TY" Then
                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesOldReservesTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesOldReserves, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesOldReserves"

            ElseIf varstrCaption = "OldReserves - Sales Comparison LY" Then
                Dim Filterstr As String = "( Year = '" & Today.Year - 1 & "' ) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 2 & "') And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesOldReservesTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesOldReserves, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesOldReserves"

            ElseIf varstrCaption = "OldReserves - Sales Comparison" Then

                Dim dia As String = Now.Day.ToString("00")
                Dim mes As String = Now.Month.ToString("00")

                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And ([Date] < Datetime('" & Now.Year & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And ([Date] < Datetime('" & Now.Year - 1 & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"
                Me.SapSalesOldReservesTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSalesOldReserves, Filterstr)
                Me.SAPSalesBindingSource.DataMember = "SapSalesOldReserves"

                ''''''OldReserves
                ''''''OldReserves







            Else

                Dim dia As String = Now.Day.ToString("00")
                Dim mes As String = Now.Month.ToString("00")

                Dim Filterstr As String = "( Year = '" & Today.Year & "' ) And ([Date] < Datetime('" & Now.Year & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')" _
                                        & " OR " _
                                        & "( Year = '" & Today.Year - 1 & "') And ([Date] < Datetime('" & Now.Year - 1 & "-" & mes & "-" & dia & " 00:00:00')) And (" & Forcefilterkey & ") And (" & filterkeyregion & ") And (" & filterkeydir & ") And (" & filterkeypais & ") And (" & filterkeycli & ") And (" & filterkeycomp & ") And (" & filterkeymarca & ") And (" & filterkeytype & ") And (" & filterkeygroup & ") And (" & filterkeyprod & ") And (" & filterkeyAnocol & ") And (" & filterkeypackage & ") And ([Material Name] LIKE '%" & filtermark & "%')"

                Me.SapSalesTableAdapter1.FillByWhere(Me.CommercialSystemDataSet2.SapSales, Filterstr)
                'PivotGridControl1.Prefilter.CriteriaString = "([" & fieldDate.PrefilterColumnName & "] < #" & DateTime.Today.AddYears(-1).ToString("d", System.Globalization.CultureInfo.InvariantCulture) & "# AND [" & fieldYear.PrefilterColumnName & "] = '" & Today.Year.ToString - 1 & "') or ([" & fieldDate.PrefilterColumnName & "] < #" & DateTime.Today.ToString("d", System.Globalization.CultureInfo.InvariantCulture) & "# AND [" & fieldYear.PrefilterColumnName & "] = '" & Today.Year.ToString & "')"

            End If
        End If







        '    PivotGridControl1.BestFit()

        SortFields(PivotGridControl1)

    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        MsgBox("O nome do ficheiro deve começar por 'Sales'." & vbCrLf & "The name of the file must start with 'Sales'." & vbCrLf & "Ex: ', Ex: 'SalesByPackage'", MsgBoxStyle.Information, "Commercial System")
        If savefilexml.ShowDialog() = DialogResult.OK Then
            Dim str As String
            str = savefilexml.FileName
            If str = "" Then Return

            ' Dim layoutxml As New DevExpress.Utils.OptionsLayoutGrid
            ' layoutxml.StoreAllOptions = False
            ' layoutxml.StoreDataSettings = False
            ' PivotGridControl1.SaveLayoutToXml(str, layoutxml)
            PivotGridControl1.SaveLayoutToXml(str)
            '   PivotGridControl1.RefreshData()
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick


        If filenamexml.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim str As String
            str = filenamexml.FileName
            If str = "" Then Return

            '    Dim layoutxml As New DevExpress.Utils.OptionsLayoutGrid
            '   layoutxml.StoreAllOptions = False
            '   layoutxml.StoreDataSettings = False

            Try



                ' PivotGridControl1.RestoreLayoutFromXml(str, layoutxml)
                PivotGridControl1.RestoreLayoutFromXml(str)
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

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.Close()
        RemoveHandler DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged, AddressOf UserLookAndFeel_StyleChanged
    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonPrintPreview.ItemClick
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
        Dim ret As Object = DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to open the file?", "Choose..", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        If ret = 6 Then Process.Start(str)



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
        e.Graph.DrawString(IIf(labelpacka.EditValue = "", "", labelpacka.EditValue), Color.Black, New RectangleF(0, 100, 400, 20), DevExpress.XtraPrinting.BorderSide.None)

        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Far, StringAlignment.Near)

        e.Graph.DrawString("9L Cases", Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 200, 0, 200, 20), DevExpress.XtraPrinting.BorderSide.None)

        e.Graph.DrawString(IIf(labelgroup.EditValue = "", "", labelgroup.EditValue) & IIf(labeltype.EditValue = "", "", " - " & labeltype.EditValue), Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 400, 20, 400, 20), DevExpress.XtraPrinting.BorderSide.None)

        e.Graph.DrawString(IIf(labelprod.EditValue = "", "", labelprod.EditValue), Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 400, 40, 400, 30), DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(IIf(labelanocol.EditValue = "", "", "Vintage Year:" & labelanocol.EditValue), Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 400, 70, 400, 20), DevExpress.XtraPrinting.BorderSide.None)


        Dim bitpath As String
        bitpath = "c:\commercialsystem\" & "\cruz.gif"
        If Not labelcomp.EditValue = "" Then
            Try
                Select Case UCase(labelcomp.EditValue.ToString)
                    Case "QUARLES HARRIS"
                        bitpath = "c:\commercialsystem\" & "\QUA.JPG"
                    Case "GRAHAM’S"
                        bitpath = "c:\commercialsystem\" & "\w &.jpg"
                    Case "WARRE’S"
                        bitpath = "c:\commercialsystem\" & "\war.JPG"
                    Case "SMITH WOODHOUSE"
                        bitpath = "c:\commercialsystem\" & "\smi.JPG"
                    Case "RORIZ VINTAGE"
                        bitpath = "c:\commercialsystem\" & "\ror.JPG"
                    Case "DOW’S"
                        bitpath = "c:\commercialsystem\" & "\dow.JPG"
                    Case "VESÚVIO"
                        bitpath = "c:\commercialsystem\" & "\soc.JPG"
                    Case "PRATS & SYMINGTON"
                        bitpath = "c:\commercialsystem\" & "\pes.JPG"
                    Case "GOULD CAMPBELL"
                        bitpath = "c:\commercialsystem\" & "\gou.JPG"
                    Case "COCKBURN’S"
                        bitpath = "c:\commercialsystem\" & "\cock.JPG"
                    Case "MARTINEZ GASSIOT"
                        bitpath = "c:\commercialsystem\" & "\mar.JPG"
                    Case Else
                        bitpath = "c:\commercialsystem\" & "\cruz.gif"
                End Select
            Catch ex As Exception
                bitpath = "c:\commercialsystem\" & "\cruz.gif"
            End Try
        End If
        If Not labeltype.EditValue = "" Then
            If labeltype.EditValue.ToString.Contains("BOB") Then bitpath = "c:\commercialsystem\" & "\cruz.gif"
        End If

        Dim imagelist1 As New Bitmap(bitpath)
        Dim r As New RectangleF(0, 0, imagelist1.Width / 3, imagelist1.Height / 3)
        r.Offset((e.Graph.ClientPageSize.Width / 2) - (r.Width / 2), 0)
        e.Graph.DrawImage(imagelist1, r, DevExpress.XtraPrinting.BorderSide.None, Color.Transparent)

        Dim yearstr As String = ""



        If UCase(varstrCaption).EndsWith("SALES COMPARISON") Then
            yearstr = Now.Year - 1
            e.Graph.DrawString("Comparison Report " & Now.Year & "/" & yearstr, Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 450, 50, 150, 40), DevExpress.XtraPrinting.BorderSide.None)

        ElseIf UCase(varstrCaption).EndsWith("SALES COMPARISON LY") Then

            e.Graph.DrawString("Comparison Report " & Now.Year - 1 & "/" & Now.Year - 2, Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 450, 50, 150, 40), DevExpress.XtraPrinting.BorderSide.None)
        ElseIf UCase(varstrCaption).EndsWith("SALES COMPARISON TY") Then

            e.Graph.DrawString("Comparison Report " & Now.Year & "/" & Now.Year - 1, Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 450, 50, 150, 40), DevExpress.XtraPrinting.BorderSide.None)

        ElseIf UCase(varstrCaption).EndsWith("BY MONTH 9L") Then
            yearstr = Now.Year
            e.Graph.DrawString("Sales Report " & yearstr, Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 450, 50, 150, 40), DevExpress.XtraPrinting.BorderSide.None)

        ElseIf UCase(varstrCaption).EndsWith("CURRENT SALES") Then
            yearstr = Now.Year
            e.Graph.DrawString("Current Sales ", Color.Black, New RectangleF(e.Graph.ClientPageSize.Width() - 450, 50, 150, 40), DevExpress.XtraPrinting.BorderSide.None)

        End If



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

        Dim dlg As frmStyleConditions = New frmStyleConditions(Meupoint, fieldMM)


        Dim fieldPivot As PivotGridField
        For Each fieldPivot In PivotGridControl1.Fields ' lista
            dlg.CBField.Properties.Items.Add(fieldPivot)
        Next

        dlg.ShowDialog()

    End Sub



    Private Sub BarCheckItem1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.CheckedChanged
        If BarCheckItem1.Checked = True Then
            PivotGridControl1.OptionsView.ShowCustomTotalsForSingleValues = True
            'PivotGridControl1.OptionsView.ShowGrandTotalsForSingleValues = True
            PivotGridControl1.OptionsView.ShowTotalsForSingleValues = True
        Else
            PivotGridControl1.OptionsView.ShowCustomTotalsForSingleValues = False
            'PivotGridControl1.OptionsView.ShowGrandTotalsForSingleValues = False
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


    Private Sub pivotGridControl1_FieldFilterChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldEventArgs) Handles PivotGridControl1.FieldFilterChanged


        Dim barstaticitemitem As BarItemLink
        Dim updates As New Collection
        If e.Field.FilterValues.HasFilter Then
            Dim ret As Boolean = False
            For Each barstaticitemitem In RibbonPageFiltersApplied.ItemLinks
                If barstaticitemitem.Caption = "Filtros em " & e.Field.Caption Then ret = True
            Next
            If ret = False Then
                Dim barstaticitemFilter As New BarStaticItem
                barstaticitemFilter.Caption = "Filtros em " & e.Field.Caption
                barstaticitemFilter.Name = "Filtros em " & e.Field.Caption

                barstaticitemFilter.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
             Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
                barstaticitemFilter.ItemAppearance.Normal.Options.UseFont = True

                barstaticitemFilter.AutoSize = BarStaticItemSize.Content

                RibbonPageFiltersApplied.ItemLinks.Add(barstaticitemFilter)
                Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
                Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
                ToolTipItem1.Text = barstaticitemFilter.Caption
                SuperToolTip1.Items.Add(ToolTipItem1)
                barstaticitemFilter.SuperTip = SuperToolTip1
            End If
        Else

            For Each barstaticitemitem In RibbonPageFiltersApplied.ItemLinks
                If barstaticitemitem.Caption = "Filtros em " & e.Field.Caption Then RibbonPageFiltersApplied.ItemLinks.Remove(barstaticitemitem) : Exit For
            Next
        End If
    End Sub
    Private SearchPropertyName As String



    Private Sub PivotGridControl1_FieldValueDisplayText(sender As System.Object, e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles PivotGridControl1.FieldValueDisplayText
        If Not e.Field Is Nothing AndAlso e.Field.FieldName = "Month" Then
            e.DisplayText = Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.AbbreviatedMonthNames(CInt(Fix(e.Value - 1)))
        End If
    End Sub



    Private Sub PivotGridControl1_CustomUnboundFieldData(ByVal sender As System.Object, ByVal e As DevExpress.XtraPivotGrid.CustomFieldDataEventArgs) Handles PivotGridControl1.CustomUnboundFieldData

        If e.Field.Name = "fieldVintage" Then
            Try
                Dim subs As String
                subs = e.GetListSourceColumnValue("FAMILIA").ToString.ToUpper
                If subs.StartsWith("VINTAGE") Or subs.StartsWith("QUINTAS") Then
                    'e.Value = "Vintage"
                    e.Value = "Bottle Matured"
                Else
                    'e.Value = "Non Vintage"
                    e.Value = "Wood Matured"

                End If
            Catch
            End Try

        ElseIf e.Field Is fieldBIGTYPE Then
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
                    e.Value = "Others"
                End If
            Catch ex As Exception

            End Try

        End If
        Return
    End Sub

    Private Sub PivotGridControl1_CustomGroupInterval(sender As System.Object, e As DevExpress.XtraPivotGrid.PivotCustomGroupIntervalEventArgs) Handles PivotGridControl1.CustomGroupInterval
        If e.Field.Caption = "Big Brand" Then
            If UCase(e.Value.ToString()) = "WARRE" Then
                e.GroupValue = "Warre"
                Return
            ElseIf UCase(e.Value.ToString()) = "SILVA & COSENS" Then
                e.GroupValue = "Silva & Cosens"
                Return
            ElseIf UCase(e.Value.ToString()) = "GRAHAM'S" Then
                e.GroupValue = "Graham’s"
                Return
            ElseIf UCase(e.Value.ToString()) = "SFE" Then
                e.GroupValue = "SFE"
                Return
            ElseIf UCase(e.Value.ToString()) = "COCKBURN’S" Then
                e.GroupValue = "Cockburn’s"
                Return
            Else
                e.GroupValue = "Others"
                Return
            End If
        ElseIf e.Field.Caption = "Big Families" Then
            If UCase(e.Value.ToString()) = "RUBY" _
                Or UCase(e.Value.ToString()) = "TAWNY" _
                  Or UCase(e.Value.ToString()) = "WHITE" _
                    Or UCase(e.Value.ToString()) = "DRY WHITE" _
                      Or UCase(e.Value.ToString()) = "EXTRA DRY" _
                        Or UCase(e.Value.ToString()) = "FINE WHITE" _
                          Or UCase(e.Value.ToString()) = "LAGRIMA" _
                           Or UCase(e.Value.ToString()) = "MASTER BLEND FINE WHITE" _
                             Or UCase(e.Value.ToString()) = "MASTER BLEND RUBY" _
                               Or UCase(e.Value.ToString()) = "MASTER BLEND TAWNY" _
                                Or UCase(e.Value.ToString()) = "CHRISTMAS" _
                                Or UCase(e.Value.ToString()) = "HERITAGE" _
                                   Or UCase(e.Value.ToString()) = "MIDNIGHT" _
                                      Or UCase(e.Value.ToString()) = "ROSE" _
                Or UCase(e.Value.ToString()) = "RUBY" Then
                e.GroupValue = "R/T/W/R"
                Return
            ElseIf UCase(e.Value.ToString()) = "10 Y.O." _
                  Or UCase(e.Value.ToString()) = "MASTER BLEND 10 Y.O." _
                    Or UCase(e.Value.ToString()) = "OTIMA 10 Y.O." _
                Or UCase(e.Value.ToString()) = "20 Y.O." _
                  Or UCase(e.Value.ToString()) = "OTIMA 20 Y.O." _
                Or UCase(e.Value.ToString()) = "30 Y.O." _
                Or UCase(e.Value.ToString()) = "40 Y.O." Then
                e.GroupValue = "Aged Tawnies"
                Return
            ElseIf UCase(e.Value.ToString()) = "BOTTLE AGED LBV" Then
                e.GroupValue = "Bottle Matured LBV"
                Return
            ElseIf UCase(e.Value.ToString()) = "MODERN LBV" _
                    Or UCase(e.Value.ToString()) = "MASTER BLEND LBV" Then
                e.GroupValue = "Modern LBV"
                Return
            ElseIf UCase(e.Value.ToString()) = "COLHEITAS" Then
                e.GroupValue = "Colheitas"
                Return
            ElseIf UCase(e.Value.ToString()) = "RESERVE" _
                 Or UCase(e.Value.ToString()) = "FINEST RESERVE" _
                  Or UCase(e.Value.ToString()) = "LODGE RESERVE" _
                     Or UCase(e.Value.ToString()) = "MASTER BLEND FINEST RESERVE" _
                        Or UCase(e.Value.ToString()) = "RESERVE RUBY" _
                           Or UCase(e.Value.ToString()) = "RESERVE TAWNY" _
                              Or UCase(e.Value.ToString()) = "NIRVANA" _
                                 Or UCase(e.Value.ToString()) = "SIX GRAPES" _
                                    Or UCase(e.Value.ToString()) = "THE TAWNY" _
                                       Or UCase(e.Value.ToString()) = "TRADEMARK" _
                                          Or UCase(e.Value.ToString()) = "VPPUB RESERVE RUBY" _
                                             Or UCase(e.Value.ToString()) = "WARRIOR" _
                    Or UCase(e.Value.ToString()) = "BOARDROOM" Then
                e.GroupValue = "Reserves"
                Return
            ElseIf UCase(e.Value.ToString()) = "CRUSTED" Then
                e.GroupValue = "Crusted"
                Return
            ElseIf UCase(e.Value.ToString()) = "QUINTAS" _
                 Or UCase(e.Value.ToString()) = "QUINTA EN-PRIMEUR" Then
                e.GroupValue = "Quintas"
                Return
            ElseIf UCase(e.Value.ToString()) = "VINTAGE" _
                Or UCase(e.Value.ToString()) = "VINTAGE EN-PRIMEUR" Then
                e.GroupValue = "Vintage"
                Return
            Else
                e.GroupValue = "Others"
                Return
            End If
        Else
            Return
        End If

    End Sub




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




#Region "Hide Empty Columns"
    Protected Sub pivotGrid_CustomFieldValueCells(ByVal sender As Object, ByVal e As PivotCustomFieldValueCellsEventArgs) Handles PivotGridControl1.CustomFieldValueCells
        HideEmptyValues(True, e)
    End Sub

    Private Sub HideEmptyValues(ByVal isColumn As Boolean, ByVal e As PivotCustomFieldValueCellsEventArgs)
        For i As Integer = e.GetCellCount(isColumn) - 1 To 0 Step -1
            Dim cell As FieldValueCell = e.GetCell(isColumn, i)
            If cell Is Nothing Or cell.Field Is Nothing Then
                Continue For
            ElseIf Not (cell.Field.Caption = "Target") And Not (cell.Field.Caption = "Forecast €") And Not (cell.Field.Caption = "% Target") And Not (cell.Field.Caption = "% Forecast") And Not (cell.Field.Caption.StartsWith("In Hand")) Then
                Continue For

            End If
            If cell.EndLevel = e.GetLevelCount(isColumn) - 1 Then
                If IsValueEmpty(isColumn, cell.MaxIndex, e) Then
                    e.Remove(cell)
                End If
            End If
        Next i
    End Sub

    Private Function IsValueEmpty(ByVal isColumn As Boolean, ByVal valueIndex As Integer, ByVal e As PivotCustomFieldValueCellsEventArgs) As Boolean
        If isColumn Then
            Return IsCollumnEmpty(valueIndex, e)
        End If
    End Function

    Private Function IsCollumnEmpty(ByVal columnIndex As Integer, ByVal e As PivotCustomFieldValueCellsEventArgs) As Boolean


        For j As Integer = 0 To e.RowCount - 1
            Dim value As Decimal = Convert.ToDecimal(e.GetCellValue(columnIndex, j))
            If value <> 0 Then
                Return False
            End If
        Next j
        Return True

    End Function
#End Region

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
