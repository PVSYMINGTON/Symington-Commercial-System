

Imports System.Windows.Forms
Imports System.Data.SQLite


Public Class FormTreesPricingUpdate

    Inherits System.Windows.Forms.Form


    Public filterkeydir As String
    Public filterkeypais As String
    Public filterkeyclifact As String
    Public filterkeyclidest As String
    Public filterkeycomp As String
    Public filterkeytipo As String
    Public filterkeypricelist As String
    Public filterkeyPCDATI As String
    Public filterkeyPCDATF As String
    Public filterkeyCurrency As String
    Public filterkeyPricing As String = "933"
    Dim Forcefilterkeydir As String ' Permissão


    Public filtergrid As Boolean




    Public varTabela As String
    Public varDatabase As String
    Public flagWork As Boolean
    Public click1 As Boolean
    Public click2 As Boolean
    Public click3 As Boolean
    Public click4 As Boolean
    Public click5 As Boolean
    Public click6 As Boolean
    Public click7 As Boolean
    Public click8 As Boolean
    Public click9 As Boolean
    Public click10 As Boolean




    Dim tabela As New DataTable
    'Dim dv As DataView
    Dim ds As DataSet, dsHelper As DataSetHelper.DataSetHelper
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TreeView1a As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView4a As DevExpress.XtraTreeList.TreeList
    Friend WithEvents PopupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents LabelPriceOption As System.Windows.Forms.Label
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents TreeView3a As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView9a As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView8a As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView7a As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView6a As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView5a As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView10a As DevExpress.XtraTreeList.TreeList
    Friend WithEvents SapMateriaisQueryTableAdapter1 As PricingExcel2007.SapPricingDataset1TableAdapters.SapMateriaisQueryTableAdapter
    Friend WithEvents SapPricingDataset11 As PricingExcel2007.SapPricingDataset1
    Friend WithEvents SapTipoListaPrecosTableAdapter As PricingExcel2007.SapPricingDataset1TableAdapters.SapTipoListaPrecosTableAdapter
    Friend WithEvents TreeView2a As DevExpress.XtraTreeList.TreeList


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Command3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTreesPricingUpdate))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.TreeView1a = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView4a = New DevExpress.XtraTreeList.TreeList()
        Me.PopupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelPriceOption = New System.Windows.Forms.Label()
        Me.TreeView3a = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView2a = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView9a = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView8a = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView7a = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView6a = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView5a = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView10a = New DevExpress.XtraTreeList.TreeList()
        Me.SapMateriaisQueryTableAdapter1 = New PricingExcel2007.SapPricingDataset1TableAdapters.SapMateriaisQueryTableAdapter()
        Me.SapPricingDataset11 = New PricingExcel2007.SapPricingDataset1()
        Me.SapTipoListaPrecosTableAdapter = New PricingExcel2007.SapPricingDataset1TableAdapters.SapTipoListaPrecosTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView1a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView4a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView3a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView2a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView9a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView8a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView7a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView6a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView5a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView10a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapPricingDataset11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(835, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 52)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Command3
        '
        Me.Command3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Command3.BackColor = System.Drawing.Color.Transparent
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Command3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Command3.ForeColor = System.Drawing.Color.White
        Me.Command3.Image = CType(resources.GetObject("Command3.Image"), System.Drawing.Image)
        Me.Command3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Command3.Location = New System.Drawing.Point(964, 0)
        Me.Command3.Name = "Command3"
        Me.Command3.Size = New System.Drawing.Size(72, 64)
        Me.Command3.TabIndex = 8
        Me.Command3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.PricingExcel2007.My.Resources.Resources.hana_icon
        Me.PictureBox1.Location = New System.Drawing.Point(478, 595)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.PricingExcel2007.My.Resources.Resources.SFE_Logo_Principal
        Me.PictureBox2.Location = New System.Drawing.Point(348, 10)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(307, 155)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.PricingExcel2007.My.Resources.Resources.PricingCommercialsystembarra
        Me.PictureBox3.Image = Global.PricingExcel2007.My.Resources.Resources.PricingCommercialsystembarraGold
        Me.PictureBox3.Location = New System.Drawing.Point(653, 573)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(372, 115)
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox8.Location = New System.Drawing.Point(0, 557)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(1037, 136)
        Me.PictureBox8.TabIndex = 27
        Me.PictureBox8.TabStop = False
        '
        'TreeView1a
        '
        Me.TreeView1a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView1a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView1a.Appearance.Empty.Options.UseBackColor = True
        Me.TreeView1a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView1a.Appearance.Row.Options.UseBackColor = True
        Me.TreeView1a.Appearance.Row.Options.UseTextOptions = True
        Me.TreeView1a.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TreeView1a.FixedLineWidth = 1
        Me.TreeView1a.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1a.Location = New System.Drawing.Point(18, 126)
        Me.TreeView1a.LookAndFeel.SkinName = "Black"
        Me.TreeView1a.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TreeView1a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView1a.MinWidth = -1
        Me.TreeView1a.Name = "TreeView1a"
        Me.TreeView1a.OptionsBehavior.AllowIncrementalSearch = True
        Me.TreeView1a.OptionsBehavior.Editable = False
        Me.TreeView1a.OptionsBehavior.ExpandNodesOnIncrementalSearch = True
        Me.TreeView1a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView1a.OptionsSelection.InvertSelection = True
        Me.TreeView1a.OptionsView.ShowHorzLines = False
        Me.TreeView1a.OptionsView.ShowIndicator = False
        Me.TreeView1a.OptionsView.ShowVertLines = False
        Me.TreeView1a.Size = New System.Drawing.Size(199, 208)
        Me.TreeView1a.TabIndex = 56
        '
        'TreeView4a
        '
        Me.TreeView4a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView4a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView4a.Appearance.Empty.Options.UseBackColor = True
        Me.TreeView4a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView4a.Appearance.Row.Options.UseBackColor = True
        Me.TreeView4a.FixedLineWidth = 1
        Me.TreeView4a.Location = New System.Drawing.Point(699, 126)
        Me.TreeView4a.LookAndFeel.SkinName = "Black"
        Me.TreeView4a.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TreeView4a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView4a.MinWidth = -1
        Me.TreeView4a.Name = "TreeView4a"
        Me.TreeView4a.OptionsBehavior.AllowIncrementalSearch = True
        Me.TreeView4a.OptionsBehavior.Editable = False
        Me.TreeView4a.OptionsBehavior.ExpandNodesOnIncrementalSearch = True
        Me.TreeView4a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView4a.OptionsSelection.InvertSelection = True
        Me.TreeView4a.OptionsView.ShowHorzLines = False
        Me.TreeView4a.OptionsView.ShowIndicator = False
        Me.TreeView4a.OptionsView.ShowVertLines = False
        Me.TreeView4a.Size = New System.Drawing.Size(285, 208)
        Me.TreeView4a.TabIndex = 57
        '
        'PopupContainerEdit1
        '
        Me.PopupContainerEdit1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PopupContainerEdit1.EditValue = "Choose Pricing Option..."
        Me.PopupContainerEdit1.Location = New System.Drawing.Point(78, 99)
        Me.PopupContainerEdit1.Name = "PopupContainerEdit1"
        Me.PopupContainerEdit1.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupContainerEdit1.Properties.Appearance.Options.UseFont = True
        Me.PopupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PopupContainerEdit1.Properties.PopupControl = Me.PopupContainerControl1
        Me.PopupContainerEdit1.Size = New System.Drawing.Size(167, 26)
        Me.PopupContainerEdit1.TabIndex = 58
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(70, 5)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(232, 112)
        Me.PopupContainerControl1.TabIndex = 63
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(0, 0)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Final and Invoice Customer"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Invoice Customer"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Stats Customer")})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(232, 112)
        Me.ComboBoxEdit1.TabIndex = 50
        '
        'LabelPriceOption
        '
        Me.LabelPriceOption.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelPriceOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelPriceOption.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPriceOption.Location = New System.Drawing.Point(251, 101)
        Me.LabelPriceOption.Name = "LabelPriceOption"
        Me.LabelPriceOption.Size = New System.Drawing.Size(336, 15)
        Me.LabelPriceOption.TabIndex = 59
        Me.LabelPriceOption.Text = "Final and Invoice Customer"
        Me.LabelPriceOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TreeView3a
        '
        Me.TreeView3a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView3a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView3a.Appearance.Empty.Options.UseBackColor = True
        Me.TreeView3a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView3a.Appearance.Row.Options.UseBackColor = True
        Me.TreeView3a.FixedLineWidth = 1
        Me.TreeView3a.Location = New System.Drawing.Point(405, 126)
        Me.TreeView3a.LookAndFeel.SkinName = "Black"
        Me.TreeView3a.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TreeView3a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView3a.MinWidth = -1
        Me.TreeView3a.Name = "TreeView3a"
        Me.TreeView3a.OptionsBehavior.AllowIncrementalSearch = True
        Me.TreeView3a.OptionsBehavior.Editable = False
        Me.TreeView3a.OptionsBehavior.ExpandNodesOnIncrementalSearch = True
        Me.TreeView3a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView3a.OptionsSelection.InvertSelection = True
        Me.TreeView3a.OptionsView.ShowHorzLines = False
        Me.TreeView3a.OptionsView.ShowIndicator = False
        Me.TreeView3a.OptionsView.ShowVertLines = False
        Me.TreeView3a.Size = New System.Drawing.Size(285, 208)
        Me.TreeView3a.TabIndex = 65
        '
        'TreeView2a
        '
        Me.TreeView2a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView2a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView2a.Appearance.Empty.Options.UseBackColor = True
        Me.TreeView2a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView2a.Appearance.Row.Options.UseBackColor = True
        Me.TreeView2a.FixedLineWidth = 1
        Me.TreeView2a.Location = New System.Drawing.Point(226, 126)
        Me.TreeView2a.LookAndFeel.SkinName = "Black"
        Me.TreeView2a.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TreeView2a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView2a.MinWidth = -1
        Me.TreeView2a.Name = "TreeView2a"
        Me.TreeView2a.OptionsBehavior.AllowIncrementalSearch = True
        Me.TreeView2a.OptionsBehavior.Editable = False
        Me.TreeView2a.OptionsBehavior.ExpandNodesOnIncrementalSearch = True
        Me.TreeView2a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView2a.OptionsSelection.InvertSelection = True
        Me.TreeView2a.OptionsView.ShowColumns = False
        Me.TreeView2a.OptionsView.ShowHorzLines = False
        Me.TreeView2a.OptionsView.ShowIndicator = False
        Me.TreeView2a.OptionsView.ShowVertLines = False
        Me.TreeView2a.Size = New System.Drawing.Size(170, 208)
        Me.TreeView2a.TabIndex = 66
        '
        'TreeView9a
        '
        Me.TreeView9a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView9a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView9a.Appearance.Empty.Options.UseBackColor = True
        Me.TreeView9a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView9a.Appearance.Row.Options.UseBackColor = True
        Me.TreeView9a.FixedLineWidth = 1
        Me.TreeView9a.Location = New System.Drawing.Point(691, 353)
        Me.TreeView9a.LookAndFeel.SkinName = "Black"
        Me.TreeView9a.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TreeView9a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView9a.MinWidth = -1
        Me.TreeView9a.Name = "TreeView9a"
        Me.TreeView9a.OptionsBehavior.AllowIncrementalSearch = True
        Me.TreeView9a.OptionsBehavior.Editable = False
        Me.TreeView9a.OptionsBehavior.ExpandNodesOnIncrementalSearch = True
        Me.TreeView9a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView9a.OptionsSelection.InvertSelection = True
        Me.TreeView9a.OptionsView.ShowColumns = False
        Me.TreeView9a.OptionsView.ShowHorzLines = False
        Me.TreeView9a.OptionsView.ShowIndicator = False
        Me.TreeView9a.OptionsView.ShowVertLines = False
        Me.TreeView9a.Size = New System.Drawing.Size(145, 208)
        Me.TreeView9a.TabIndex = 71
        '
        'TreeView8a
        '
        Me.TreeView8a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView8a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView8a.Appearance.Empty.Options.UseBackColor = True
        Me.TreeView8a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView8a.Appearance.Row.Options.UseBackColor = True
        Me.TreeView8a.FixedLineWidth = 1
        Me.TreeView8a.Location = New System.Drawing.Point(544, 353)
        Me.TreeView8a.LookAndFeel.SkinName = "Black"
        Me.TreeView8a.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TreeView8a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView8a.MinWidth = -1
        Me.TreeView8a.Name = "TreeView8a"
        Me.TreeView8a.OptionsBehavior.AllowIncrementalSearch = True
        Me.TreeView8a.OptionsBehavior.Editable = False
        Me.TreeView8a.OptionsBehavior.ExpandNodesOnIncrementalSearch = True
        Me.TreeView8a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView8a.OptionsSelection.InvertSelection = True
        Me.TreeView8a.OptionsView.ShowColumns = False
        Me.TreeView8a.OptionsView.ShowHorzLines = False
        Me.TreeView8a.OptionsView.ShowIndicator = False
        Me.TreeView8a.OptionsView.ShowVertLines = False
        Me.TreeView8a.Size = New System.Drawing.Size(145, 208)
        Me.TreeView8a.TabIndex = 70
        '
        'TreeView7a
        '
        Me.TreeView7a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView7a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView7a.Appearance.Empty.Options.UseBackColor = True
        Me.TreeView7a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView7a.Appearance.Row.Options.UseBackColor = True
        Me.TreeView7a.FixedLineWidth = 1
        Me.TreeView7a.Location = New System.Drawing.Point(397, 353)
        Me.TreeView7a.LookAndFeel.SkinName = "Black"
        Me.TreeView7a.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TreeView7a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView7a.MinWidth = -1
        Me.TreeView7a.Name = "TreeView7a"
        Me.TreeView7a.OptionsBehavior.AllowIncrementalSearch = True
        Me.TreeView7a.OptionsBehavior.Editable = False
        Me.TreeView7a.OptionsBehavior.ExpandNodesOnIncrementalSearch = True
        Me.TreeView7a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView7a.OptionsSelection.InvertSelection = True
        Me.TreeView7a.OptionsView.ShowColumns = False
        Me.TreeView7a.OptionsView.ShowHorzLines = False
        Me.TreeView7a.OptionsView.ShowIndicator = False
        Me.TreeView7a.OptionsView.ShowVertLines = False
        Me.TreeView7a.Size = New System.Drawing.Size(145, 208)
        Me.TreeView7a.TabIndex = 69
        '
        'TreeView6a
        '
        Me.TreeView6a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView6a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView6a.Appearance.Empty.Options.UseBackColor = True
        Me.TreeView6a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView6a.Appearance.Row.Options.UseBackColor = True
        Me.TreeView6a.FixedLineWidth = 1
        Me.TreeView6a.Location = New System.Drawing.Point(250, 353)
        Me.TreeView6a.LookAndFeel.SkinName = "Black"
        Me.TreeView6a.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TreeView6a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView6a.MinWidth = -1
        Me.TreeView6a.Name = "TreeView6a"
        Me.TreeView6a.OptionsBehavior.AllowIncrementalSearch = True
        Me.TreeView6a.OptionsBehavior.Editable = False
        Me.TreeView6a.OptionsBehavior.ExpandNodesOnIncrementalSearch = True
        Me.TreeView6a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView6a.OptionsSelection.InvertSelection = True
        Me.TreeView6a.OptionsView.ShowColumns = False
        Me.TreeView6a.OptionsView.ShowHorzLines = False
        Me.TreeView6a.OptionsView.ShowIndicator = False
        Me.TreeView6a.OptionsView.ShowVertLines = False
        Me.TreeView6a.Size = New System.Drawing.Size(145, 208)
        Me.TreeView6a.TabIndex = 68
        '
        'TreeView5a
        '
        Me.TreeView5a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView5a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView5a.Appearance.Empty.Options.UseBackColor = True
        Me.TreeView5a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView5a.Appearance.Row.Options.UseBackColor = True
        Me.TreeView5a.FixedLineWidth = 1
        Me.TreeView5a.Location = New System.Drawing.Point(79, 353)
        Me.TreeView5a.LookAndFeel.SkinName = "Black"
        Me.TreeView5a.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TreeView5a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView5a.MinWidth = -1
        Me.TreeView5a.Name = "TreeView5a"
        Me.TreeView5a.OptionsBehavior.AllowIncrementalSearch = True
        Me.TreeView5a.OptionsBehavior.Editable = False
        Me.TreeView5a.OptionsBehavior.ExpandNodesOnIncrementalSearch = True
        Me.TreeView5a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView5a.OptionsSelection.InvertSelection = True
        Me.TreeView5a.OptionsView.ShowColumns = False
        Me.TreeView5a.OptionsView.ShowHorzLines = False
        Me.TreeView5a.OptionsView.ShowIndicator = False
        Me.TreeView5a.OptionsView.ShowVertLines = False
        Me.TreeView5a.Size = New System.Drawing.Size(169, 208)
        Me.TreeView5a.TabIndex = 67
        '
        'TreeView10a
        '
        Me.TreeView10a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView10a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView10a.Appearance.Empty.Options.UseBackColor = True
        Me.TreeView10a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView10a.Appearance.Row.Options.UseBackColor = True
        Me.TreeView10a.FixedLineWidth = 1
        Me.TreeView10a.Location = New System.Drawing.Point(838, 353)
        Me.TreeView10a.LookAndFeel.SkinName = "Black"
        Me.TreeView10a.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TreeView10a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView10a.MinWidth = -1
        Me.TreeView10a.Name = "TreeView10a"
        Me.TreeView10a.OptionsBehavior.AllowIncrementalSearch = True
        Me.TreeView10a.OptionsBehavior.Editable = False
        Me.TreeView10a.OptionsBehavior.ExpandNodesOnIncrementalSearch = True
        Me.TreeView10a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView10a.OptionsSelection.InvertSelection = True
        Me.TreeView10a.OptionsView.ShowColumns = False
        Me.TreeView10a.OptionsView.ShowHorzLines = False
        Me.TreeView10a.OptionsView.ShowIndicator = False
        Me.TreeView10a.OptionsView.ShowVertLines = False
        Me.TreeView10a.Size = New System.Drawing.Size(145, 208)
        Me.TreeView10a.TabIndex = 71
        '
        'SapMateriaisQueryTableAdapter1
        '
        Me.SapMateriaisQueryTableAdapter1.ClearBeforeFill = True
        '
        'SapPricingDataset11
        '
        Me.SapPricingDataset11.DataSetName = "SapPricingDataset1"
        Me.SapPricingDataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SapTipoListaPrecosTableAdapter
        '
        Me.SapTipoListaPrecosTableAdapter.ClearBeforeFill = True
        '
        'FormTreesPricingUpdate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Command3
        Me.ClientSize = New System.Drawing.Size(1037, 693)
        Me.ControlBox = False
        Me.Controls.Add(Me.TreeView10a)
        Me.Controls.Add(Me.TreeView9a)
        Me.Controls.Add(Me.TreeView8a)
        Me.Controls.Add(Me.TreeView7a)
        Me.Controls.Add(Me.TreeView6a)
        Me.Controls.Add(Me.TreeView5a)
        Me.Controls.Add(Me.TreeView2a)
        Me.Controls.Add(Me.TreeView3a)
        Me.Controls.Add(Me.PopupContainerControl1)
        Me.Controls.Add(Me.LabelPriceOption)
        Me.Controls.Add(Me.PopupContainerEdit1)
        Me.Controls.Add(Me.TreeView4a)
        Me.Controls.Add(Me.TreeView1a)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormTreesPricingUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Criteria"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView1a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView4a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView3a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView2a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView9a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView8a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView7a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView6a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView5a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView10a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapPricingDataset11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FormTreesPricing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SapPricingDataset11.SapTipoListaPrecos' table. You can move, or remove it, as needed.
        Me.SapTipoListaPrecosTableAdapter.Fill(Me.SapPricingDataset11.SapTipoListaPrecos)
        'Instantiate the License class
        'Pass only the name of the license file embedded in the assembly
        ' license.SetLicense("Aspose.Cells.lic")

        'Me.Top = 0
        'Me.Left = 0
        'Me.Width = Me.MdiParent.ClientSize.Width - 4
        'Me.Height = Me.MdiParent.ClientSize.Height - 4
        click1 = False
        filterkeydir = "%"
        filterkeypais = "%"
        filterkeyclifact = "%"
        filterkeyclidest = "%"
        filterkeycomp = "%"
        filterkeytipo = "%"
        filterkeypricelist = "%"
        filterkeyPCDATI = "%"
        filterkeyPCDATF = "%"
        filterkeyCurrency = "%"

        Forcefilterkeydir = "SalesMan like '%'"
        '''''''''''''''''
        Dim utilizador As String
        utilizador = UCase(GetSetting("SalesReports", "User", "login"))
        Select Case utilizador
            Case "SYMINGTON\HS", "SYMINGTON\EMM", "SYMINGTON\JMA", "SYMINGTON\MMC", "SYMINGTON\DMS", "SYMINGTON\JADS", "SYMINGTON\RADS", "SYMINGTON\RDTS", "SYMINGTON\PDS", "SYMINGTON\AMF", "SYMINGTON\CAC"
                Exit Select

            Case "SYMINGTON\HS", "SYMINGTON\EMM", "SYMINGTON\JMA", "SYMINGTON\MMC", "SYMINGTON\PV", "SYMINGTON\AMF", "SYMINGTON\PFL", "SYMINGTON\CLC", "SYMINGTON\JMV",
                "SYMINGTON\JVN", "SYMINGTON\GAB", "SYMINGTON\GRD", "SYMINGTON\ACR", "SYMINGTON\RJR", "SYMINGTON\ABM", "SYMINGTON\MFF", "SYMINGTON\IPM", "SYMINGTON\EDR",
                 "COMERC_JVN\JORGE", "SYMINGTON\PAM", "DESKTOP-7RA9PT2\SOFIAZHANG", "SYMINGTON\IF", "SYMINGTON\TC", "SYMINGTON\MAM", "SYMINGTON\FCL", "SYMINGTON\ARSC", "SYMINGTON\ABB", "SYMINGTON\EAC",
                 "SYMINGTON\MLL", "SYMINGTON\MTB", "SYMINGTON\RVB", "SYMINGTON\RAP"
                Exit Select

            Case "SYMINGTON\PV"

            Case "SYMINGTON\GAB"
                Forcefilterkeydir = "SalesMan like '02'"
            Case "SYMINGTON\GRD"
                Forcefilterkeydir = "SalesMan like '08'"
            Case "SYMINGTON\PFL"
                Forcefilterkeydir = "SalesMan like '04'"
            Case "SYMINGTON\JVN"
                Forcefilterkeydir = "SalesMan like '07'"
            Case "COMERC_JVN\JORGE"
                Forcefilterkeydir = "SalesMan like '07'"
            Case "SYMINGTON\IPM"
                Forcefilterkeydir = "SalesMan like '07'"
            Case "SYMINGTON\EDR"
                Forcefilterkeydir = "SalesMan like '07'"
            Case "SYMINGTON\JMV"
                Forcefilterkeydir = "SalesMan like '05'"
            Case "SYMINGTON\HJS"
                Forcefilterkeydir = "SalesMan like '06'"
            Case "SYMINGTON\ACR"
                Forcefilterkeydir = "SalesMan like '03'"
            Case "SYMINGTON\RJR"
                Forcefilterkeydir = "SalesMan like '09'"
            Case "SYMINGTON\MFF"
                Forcefilterkeydir = "SalesMan like '09'"
            Case "SYMINGTON\LS"
                Forcefilterkeydir = "Director like 'JAR' and SalesMan like '99'"
            Case "SYMINGTON\MTB"
                Forcefilterkeydir = "Director like 'JAR' and SalesMan like '99'"
            Case "SYMINGTON\MLL"
                Forcefilterkeydir = "Director like 'LMM' and SalesMan like '99'"

            Case "SYMINGTON\CLC"
                Forcefilterkeydir = "(SalesMan like '01') or (Director like 'RADS' and SalesMan like '99')"

            Case "SYMINGTON\ABM"
                Forcefilterkeydir = "(CliDest = '3337')"




            Case "SYMINGTON\JAR"
                Forcefilterkeydir = "Director like 'JAR'"
            Case "SYMINGTON\LMM"
                Forcefilterkeydir = "Director like 'LMM'"
            Case "SYMINGTON\DMS"
                Forcefilterkeydir = "Director like 'DMS'"



            Case "SYMINGTON\MAC"
                Forcefilterkeydir = "ComercAssist = 1"


            Case "SYMINGTON\TC"
                Forcefilterkeydir = "ComercAssist = 8"
            Case "SYMINGTON\ABB"
                Forcefilterkeydir = "ComercAssist = 12"
            Case "SYMINGTON\EAC"
                Forcefilterkeydir = "ComercAssist = 10"
            Case "SYMINGTON\JD"
                Forcefilterkeydir = "ComercAssist = 4"

            Case "SYMINGTON\RV"
                Forcefilterkeydir = "ComercAssist = 17"
            Case "SYMINGTON\IF"
                Forcefilterkeydir = "ComercAssist = 6"
            Case "SYMINGTON\MAM"
                Forcefilterkeydir = "ComercAssist = 21"
            Case "SYMINGTON\FCL"
                Forcefilterkeydir = "ComercAssist = 21"
            Case "SYMINGTON\PAM"
                Forcefilterkeydir = "ComercAssist = 22"

            Case Else
                filterkeydir = "director like 'NAO TEM ACESSO'"
                Forcefilterkeydir = "director like 'NAO TEM ACESSO'"
                MsgBox("Sem acesso definido!!" & vbCrLf & "No access granted!!", MsgBoxStyle.Exclamation, "Erro")

        End Select


        Dim strsql As String

        Dim reader As SQLiteDataReader

        ds = New DataSet
        dsHelper = New DataSetHelper.DataSetHelper(ds)
       
        'strsql = "SELECT MARKETDIRECTOR as director, LANDX50 as Pais, PCCCLI as CliFact, PCCLID as CliDest, WGBEZ60 as Company, TIPO, PCTPRE as PriceList, PCDATI, PCDATF , PCMOED as Currency FROM Query1 WHERE ((MARKETMANAGER LIKE '%') OR (MARKETDIRECTOR LIKE 'S/Dir.Resp.')) and tabela='" & filterkeyPricing & "'"
        strsql = "SELECT MARKETDIRECTOR as director, LANDX50 as Pais, PCCCLI as CliFact, PCCLID as CliDest, WGBEZ60 as Company, TIPO, PCTPRE as PriceList, PCDATI, PCDATF , PCMOED as Currency FROM Query1 WHERE tabela='" & filterkeyPricing & "'  AND (NOT (WGBEZ60 = 'Não Relevante'))"






        Dim sqlcommand1 As New SQLiteCommand ' OleDb.OleDbCommand
        Dim SqlConnection1 As New Data.SQLite.SQLiteConnection ' OleDb.OleDbConnection
        SqlConnection1.ConnectionString = My.Settings.PricingConnectionString
        sqlcommand1.CommandText = strsql
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()


        Dim tabela As New DataTable
        tabela.Columns.Add("director", Type.GetType("System.String"))
        tabela.Columns.Add("pais", Type.GetType("System.String"))
        tabela.Columns.Add("clifact", Type.GetType("System.String"))
        tabela.Columns.Add("clidest", Type.GetType("System.String"))
        tabela.Columns.Add("company", Type.GetType("System.String"))
        tabela.Columns.Add("tipo", Type.GetType("System.String"))
        tabela.Columns.Add("pricelist", Type.GetType("System.String"))
        tabela.Columns.Add("PCDATI", Type.GetType("System.String"))
        tabela.Columns.Add("PCDATF", Type.GetType("System.String"))
        tabela.Columns.Add("Currency", Type.GetType("System.String"))


        Dim myRow As DataRow

        reader = sqlcommand1.ExecuteReader



        While reader.Read
            myRow = tabela.NewRow()
            myRow("director") = reader.Item(0)
            myRow("pais") = reader.Item(1)
            myRow("clifact") = reader.Item(2)
            myRow("clidest") = reader.Item(3)
            myRow("company") = reader.Item(4)
            myRow("tipo") = reader.Item(5)
            myRow("pricelist") = reader.Item(6)
            myRow("PCDATI") = reader.Item(7)
            myRow("PCDATF") = reader.Item(8)
            myRow("Currency") = reader.Item(9)

            tabela.Rows.Add(myRow)
        End While

        ds.Tables.Add(tabela)
        reader.Close()
        SqlConnection1.Close()

        treefill(-1)

    End Sub
    Private Sub treefill(ByVal Index As Integer)
        flagWork = True
        TreeView1a.BeginUpdate()
        TreeView2a.BeginUpdate()
        TreeView3a.BeginUpdate()
        TreeView4a.BeginUpdate()
        TreeView5a.BeginUpdate()
        TreeView6a.BeginUpdate()
        TreeView7a.BeginUpdate()
        TreeView8a.BeginUpdate()
        TreeView9a.BeginUpdate()
        TreeView10a.BeginUpdate()

        filtergrid = False
        Cursor.Current = Cursors.WaitCursor
        ''    Dim x As Integer


        If Index < 0 Then TreeView1a.Nodes.Clear()
        If Index < 1 Then TreeView2a.Nodes.Clear()
        If Index < 2 Then TreeView3a.Nodes.Clear()
        If Index < 3 Then TreeView4a.Nodes.Clear()
        If Index < 4 Then TreeView5a.Nodes.Clear()
        If Index < 5 Then TreeView6a.Nodes.Clear()
        If Index < 6 Then TreeView7a.Nodes.Clear()
        If Index < 7 Then TreeView8a.Nodes.Clear()
        If Index < 8 Then TreeView9a.Nodes.Clear()
        If Index < 9 Then TreeView10a.Nodes.Clear()


        If Index = -1 Then

            dsHelper.SelectDistinct("Distinctdirector", ds.Tables(0), "director")
            AddNodes(ds.Tables("Distinctdirector"), "Director", 0)
            ds.Tables.Remove("Distinctdirector")


            dsHelper.SelectDistinct("Distinctpais", ds.Tables(0), "pais")
            AddNodes(ds.Tables("Distinctpais"), "Final Market", 1)
            ds.Tables.Remove("Distinctpais")

            dsHelper.SelectDistinct("Distinctclifact", ds.Tables(0), "clifact")
            AddNodes(ds.Tables("Distinctclifact"), "Invoicing Customer", 2)
            ds.Tables.Remove("Distinctclifact")

            dsHelper.SelectDistinct("Distinctclidest", ds.Tables(0), "clidest")
            AddNodes(ds.Tables("Distinctclidest"), "Final Customer", 3)
            ds.Tables.Remove("Distinctclidest")

            dsHelper.SelectDistinct("Distinctcompany", ds.Tables(0), "company")
            AddNodes(ds.Tables("Distinctcompany"), "Company", 4)
            ds.Tables.Remove("Distinctcompany")

            dsHelper.SelectDistinct("DistinctTipo", ds.Tables(0), "Tipo")
            AddNodes(ds.Tables("DistinctTipo"), "Type", 5)
            ds.Tables.Remove("DistinctTipo")

            dsHelper.SelectDistinct("Distinctpricelist", ds.Tables(0), "pricelist")
            AddNodes(ds.Tables("Distinctpricelist"), "Price List Type", 6)
            ds.Tables.Remove("Distinctpricelist")

            dsHelper.SelectDistinct("DistinctPCDATI", ds.Tables(0), "PCDATI")
            AddNodes(ds.Tables("DistinctPCDATI"), "Data Inicial", 7)
            ds.Tables.Remove("DistinctPCDATI")

            dsHelper.SelectDistinct("DistinctPCDATF", ds.Tables(0), "PCDATF")
            AddNodes(ds.Tables("DistinctPCDATF"), "Data Final", 8)
            ds.Tables.Remove("DistinctPCDATF")

            dsHelper.SelectDistinct("DistinctCurrency", ds.Tables(0), "Currency")
            AddNodes(ds.Tables("DistinctCurrency"), "Currency", 9)
            ds.Tables.Remove("DistinctCurrency")


        Else

            Dim directorDR As DataRow() = ds.Tables(0).Select("(director like '" & filterkeydir _
            & "') and (pais like '" & filterkeypais & "') and (clifact like '" & filterkeyclifact _
            & "') and (clidest like '" & filterkeyclidest & "') and (company like '" & filterkeycomp _
            & "') and (tipo like '" & filterkeytipo & "') and (pricelist like '" & filterkeypricelist _
            & "') and (PCDATI like '" & filterkeyPCDATI & "') and (PCDATF like '" & filterkeyPCDATF _
            & "') and (Currency like '" & filterkeyCurrency & "')")

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            tabeladir.Columns.Add("director", Type.GetType("System.String"))
            tabeladir.Columns.Add("pais", Type.GetType("System.String"))
            tabeladir.Columns.Add("clifact", Type.GetType("System.String"))
            tabeladir.Columns.Add("clidest", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add("tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("pricelist", Type.GetType("System.String"))
            tabeladir.Columns.Add("PCDATI", Type.GetType("System.String"))
            tabeladir.Columns.Add("PCDATF", Type.GetType("System.String"))
            tabeladir.Columns.Add("Currency", Type.GetType("System.String"))




            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2("director") = r.Item(0)
                myrow2("pais") = r.Item(1)
                myrow2("clifact") = r.Item(2)
                myrow2("clidest") = r.Item(3)
                myrow2("company") = r.Item(4)
                myrow2("tipo") = r.Item(5)
                myrow2("pricelist") = r.Item(6)
                myrow2("PCDATI") = r.Item(7)
                myrow2("PCDATF") = r.Item(8)
                myrow2("Currency") = r.Item(9)


                tabeladir.Rows.Add(myrow2)
            Next r

            If Index = 0 Then
                dsHelper.SelectDistinct("Distinctpais", tabeladir, "pais")
                AddNodes(ds.Tables("Distinctpais"), "Final Market", 1)
                ds.Tables.Remove("Distinctpais")
            End If

            If Index < 2 Then
                dsHelper.SelectDistinct("Distinctclifact", tabeladir, "clifact")
                AddNodes(ds.Tables("Distinctclifact"), "Invoicing Customer", 2)
                ds.Tables.Remove("Distinctclifact")
            End If

            If Index < 3 Then
                dsHelper.SelectDistinct("Distinctclidest", tabeladir, "clidest")
                AddNodes(ds.Tables("Distinctclidest"), "Final Customer", 3)
                ds.Tables.Remove("Distinctclidest")

            End If

            If Index < 4 Then
                dsHelper.SelectDistinct("Distinctcompany", tabeladir, "company")
                AddNodes(ds.Tables("Distinctcompany"), "Company", 4)
                ds.Tables.Remove("Distinctcompany")

            End If
            If Index < 5 Then
                dsHelper.SelectDistinct("DistinctTipo", tabeladir, "Tipo")
                AddNodes(ds.Tables("DistinctTipo"), "Type", 5)
                ds.Tables.Remove("DistinctTipo")
            End If
            If Index < 6 Then
                dsHelper.SelectDistinct("Distinctpricelist", tabeladir, "pricelist")
                AddNodes(ds.Tables("Distinctpricelist"), "Price List Type", 6)
                ds.Tables.Remove("Distinctpricelist")
            End If
            If Index < 7 Then
                dsHelper.SelectDistinct("DistinctPCDATI", tabeladir, "PCDATI")
                AddNodes(ds.Tables("DistinctPCDATI"), "Data Inicial", 7)
                ds.Tables.Remove("DistinctPCDATI")
            End If
            If Index < 8 Then
                dsHelper.SelectDistinct("DistinctPCDATF", tabeladir, "PCDATF")
                AddNodes(ds.Tables("DistinctPCDATF"), "Data Final", 8)
                ds.Tables.Remove("DistinctPCDATF")
            End If
            If Index < 9 Then
                dsHelper.SelectDistinct("DistinctCurrency", tabeladir, "Currency")
                AddNodes(ds.Tables("DistinctCurrency"), "Currency", 9)
                ds.Tables.Remove("DistinctCurrency")
            End If



            tabeladir = Nothing
        End If

        ' Cleanup

        TreeView1a.Nodes(0).Expanded = True
        TreeView2a.Nodes(0).Expanded = True
        TreeView3a.Nodes(0).Expanded = True

        TreeView4a.Nodes(0).Expanded = True
        TreeView5a.Nodes(0).Expanded = True
        TreeView6a.Nodes(0).Expanded = True
        TreeView7a.Nodes(0).Expanded = True
        TreeView8a.Nodes(0).Expanded = True
        TreeView9a.Nodes(0).Expanded = True
        TreeView10a.Nodes(0).Expanded = True



        If Index = -1 Then
            If TreeView1a.Nodes(0).Nodes.Count > 1 Then TreeView1a.Selection.Set(TreeView1a.Nodes(0))
            If TreeView2a.Nodes(0).Nodes.Count > 1 Then TreeView2a.Selection.Set(TreeView2a.Nodes(0))
            If TreeView3a.Nodes(0).Nodes.Count > 1 Then TreeView3a.Selection.Set(TreeView3a.Nodes(0))
            If TreeView4a.Nodes(0).Nodes.Count > 1 Then TreeView4a.Selection.Set(TreeView4a.Nodes(0))
            If TreeView5a.Nodes(0).Nodes.Count > 1 Then TreeView5a.Selection.Set(TreeView5a.Nodes(0))
            If TreeView6a.Nodes(0).Nodes.Count > 1 Then TreeView6a.Selection.Set(TreeView6a.Nodes(0))
            If TreeView7a.Nodes(0).Nodes.Count > 1 Then TreeView7a.Selection.Set(TreeView7a.Nodes(0))
            If TreeView8a.Nodes(0).Nodes.Count > 1 Then TreeView8a.Selection.Set(TreeView8a.Nodes(0))
            If TreeView9a.Nodes(0).Nodes.Count > 1 Then TreeView9a.Selection.Set(TreeView9a.Nodes(0))
            If TreeView10a.Nodes(0).Nodes.Count > 1 Then TreeView10a.Selection.Set(TreeView10a.Nodes(0))

        End If
        If Index = 0 Then
            If TreeView2a.Nodes(0).Nodes.Count > 1 Then TreeView2a.Selection.Set(TreeView2a.Nodes(0))
            If TreeView3a.Nodes(0).Nodes.Count > 1 Then TreeView3a.Selection.Set(TreeView3a.Nodes(0))
            If TreeView4a.Nodes(0).Nodes.Count > 1 Then TreeView4a.Selection.Set(TreeView4a.Nodes(0))
            If TreeView5a.Nodes(0).Nodes.Count > 1 Then TreeView5a.Selection.Set(TreeView5a.Nodes(0))
            If TreeView6a.Nodes(0).Nodes.Count > 1 Then TreeView6a.Selection.Set(TreeView6a.Nodes(0))
            If TreeView7a.Nodes(0).Nodes.Count > 1 Then TreeView7a.Selection.Set(TreeView7a.Nodes(0))
            If TreeView8a.Nodes(0).Nodes.Count > 1 Then TreeView8a.Selection.Set(TreeView8a.Nodes(0))
            If TreeView9a.Nodes(0).Nodes.Count > 1 Then TreeView9a.Selection.Set(TreeView9a.Nodes(0))
            If TreeView10a.Nodes(0).Nodes.Count > 1 Then TreeView10a.Selection.Set(TreeView10a.Nodes(0))
        End If

        If Index = 1 Then
            If TreeView3a.Nodes(0).Nodes.Count > 1 Then TreeView3a.Selection.Set(TreeView3a.Nodes(0))
            If TreeView4a.Nodes(0).Nodes.Count > 1 Then TreeView4a.Selection.Set(TreeView4a.Nodes(0))
            If TreeView5a.Nodes(0).Nodes.Count > 1 Then TreeView5a.Selection.Set(TreeView5a.Nodes(0))
            If TreeView6a.Nodes(0).Nodes.Count > 1 Then TreeView6a.Selection.Set(TreeView6a.Nodes(0))
            If TreeView7a.Nodes(0).Nodes.Count > 1 Then TreeView7a.Selection.Set(TreeView7a.Nodes(0))
            If TreeView8a.Nodes(0).Nodes.Count > 1 Then TreeView8a.Selection.Set(TreeView8a.Nodes(0))
            If TreeView9a.Nodes(0).Nodes.Count > 1 Then TreeView9a.Selection.Set(TreeView9a.Nodes(0))
            If TreeView10a.Nodes(0).Nodes.Count > 1 Then TreeView10a.Selection.Set(TreeView10a.Nodes(0))
        End If
        If Index = 2 Then
            If TreeView4a.Nodes(0).Nodes.Count > 1 Then TreeView4a.Selection.Set(TreeView4a.Nodes(0))
            If TreeView5a.Nodes(0).Nodes.Count > 1 Then TreeView5a.Selection.Set(TreeView5a.Nodes(0))
            If TreeView6a.Nodes(0).Nodes.Count > 1 Then TreeView6a.Selection.Set(TreeView6a.Nodes(0))
            If TreeView7a.Nodes(0).Nodes.Count > 1 Then TreeView7a.Selection.Set(TreeView7a.Nodes(0))
            If TreeView8a.Nodes(0).Nodes.Count > 1 Then TreeView8a.Selection.Set(TreeView8a.Nodes(0))
            If TreeView9a.Nodes(0).Nodes.Count > 1 Then TreeView9a.Selection.Set(TreeView9a.Nodes(0))
            If TreeView10a.Nodes(0).Nodes.Count > 1 Then TreeView10a.Selection.Set(TreeView10a.Nodes(0))
        End If
        If Index = 3 Then
            If TreeView5a.Nodes(0).Nodes.Count > 1 Then TreeView5a.Selection.Set(TreeView5a.Nodes(0))
            If TreeView6a.Nodes(0).Nodes.Count > 1 Then TreeView6a.Selection.Set(TreeView6a.Nodes(0))
            If TreeView7a.Nodes(0).Nodes.Count > 1 Then TreeView7a.Selection.Set(TreeView7a.Nodes(0))
            If TreeView8a.Nodes(0).Nodes.Count > 1 Then TreeView8a.Selection.Set(TreeView8a.Nodes(0))
            If TreeView9a.Nodes(0).Nodes.Count > 1 Then TreeView9a.Selection.Set(TreeView9a.Nodes(0))
            If TreeView10a.Nodes(0).Nodes.Count > 1 Then TreeView10a.Selection.Set(TreeView10a.Nodes(0))
        End If
        If Index = 4 Then
            If TreeView6a.Nodes(0).Nodes.Count > 1 Then TreeView6a.Selection.Set(TreeView6a.Nodes(0))
            If TreeView7a.Nodes(0).Nodes.Count > 1 Then TreeView7a.Selection.Set(TreeView7a.Nodes(0))
            If TreeView8a.Nodes(0).Nodes.Count > 1 Then TreeView8a.Selection.Set(TreeView8a.Nodes(0))
            If TreeView9a.Nodes(0).Nodes.Count > 1 Then TreeView9a.Selection.Set(TreeView9a.Nodes(0))
            If TreeView10a.Nodes(0).Nodes.Count > 1 Then TreeView10a.Selection.Set(TreeView10a.Nodes(0))
        End If
        If Index = 5 Then
            If TreeView7a.Nodes(0).Nodes.Count > 1 Then TreeView7a.Selection.Set(TreeView7a.Nodes(0))
            If TreeView8a.Nodes(0).Nodes.Count > 1 Then TreeView8a.Selection.Set(TreeView8a.Nodes(0))
            If TreeView9a.Nodes(0).Nodes.Count > 1 Then TreeView9a.Selection.Set(TreeView9a.Nodes(0))
            If TreeView10a.Nodes(0).Nodes.Count > 1 Then TreeView10a.Selection.Set(TreeView10a.Nodes(0))
        End If

        If Index = 6 Then
            If TreeView8a.Nodes(0).Nodes.Count > 1 Then TreeView8a.Selection.Set(TreeView8a.Nodes(0))
            If TreeView9a.Nodes(0).Nodes.Count > 1 Then TreeView9a.Selection.Set(TreeView9a.Nodes(0))
            If TreeView10a.Nodes(0).Nodes.Count > 1 Then TreeView10a.Selection.Set(TreeView10a.Nodes(0))
        End If
        If Index = 7 Then
            If TreeView9a.Nodes(0).Nodes.Count > 1 Then TreeView9a.Selection.Set(TreeView9a.Nodes(0))
            If TreeView10a.Nodes(0).Nodes.Count > 1 Then TreeView10a.Selection.Set(TreeView10a.Nodes(0))
        End If
        If Index = 8 Then
            If TreeView10a.Nodes(0).Nodes.Count > 1 Then TreeView10a.Selection.Set(TreeView10a.Nodes(0))
        End If


        TreeView1a.EndUpdate()
        TreeView2a.EndUpdate()
        TreeView3a.EndUpdate()
        TreeView4a.EndUpdate()
        TreeView5a.EndUpdate()
        TreeView6a.EndUpdate()
        TreeView7a.EndUpdate()
        TreeView8a.EndUpdate()
        TreeView9a.EndUpdate()
        TreeView10a.EndUpdate()

        Me.Cursor = Cursors.Default
        flagWork = False

    End Sub
    Private Sub AddNodes(ByRef rs As DataTable, ByVal nome As String, ByVal t As Integer)

        Dim s As String
        Dim nodxA As TreeNode
        Dim nodx As TreeNode
        Dim ret As String

        Select Case t
            Case 0

                With TreeView1a

                    Dim myConnectionPricing As New SQLiteConnection
                    myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
                    myConnectionPricing.Open()
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).Caption = "Name"
                    .Columns(0).SortOrder = Windows.Forms.SortOrder.Ascending
                    .Columns.Add()
                    .Columns(1).VisibleIndex = -1
                    .Columns(1).Caption = "Nº"


                    ' .Columns.Add()
                    '  .Columns(0).VisibleIndex = 0
                    ' .Columns(0).SortOrder = Windows.Forms.SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next

                        If rs.Rows(x).Item(0) <> s Then
                            Dim SelectQueryDir As String
                            SelectQueryDir = "SELECT name1 FROM sapclients where kunnr='" & rs.Rows(x).Item(0) & "'"
                            Dim myCommandDir As New SQLiteCommand(SelectQueryDir, myConnectionPricing)
                            ret = myCommandDir.ExecuteScalar
                            ' Create a child node for the node1             
                            .AppendNode(New Object() {ret, rs.Rows(x).Item(0)}, rootNode)

                        End If
                    Next

                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    '.Columns(1).Width = 100
                    myConnectionPricing.Close()
                    If TreeView1a.Nodes(0).Nodes.Count = 1 Then TreeView1a.FocusedNode = TreeView1a.Nodes(0).Nodes(0) : filterkeydir = TreeView1a.Nodes(0).Nodes(0).GetDisplayText(1)



                End With
            Case 1

                With TreeView2a
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = Windows.Forms.SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            .AppendNode(New Object() {rs.Rows(x).Item(0)}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    If TreeView2a.Nodes(0).Nodes.Count = 1 Then TreeView2a.FocusedNode = TreeView2a.Nodes(0).Nodes(0) : filterkeypais = TreeView2a.Nodes(0).Nodes(0).GetDisplayText(0)
                End With

            Case 2
                With TreeView3a
                    Dim myConnectionPricing As New SQLiteConnection
                    myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
                    myConnectionPricing.Open()
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).Caption = "Name"
                    .Columns(0).SortOrder = Windows.Forms.SortOrder.Ascending
                    .Columns.Add()
                    .Columns(1).VisibleIndex = 1
                    .Columns(1).Caption = "Nº"


                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
#Disable Warning BC42104 ' Variable 's' is used before it has been assigned a value. A null reference exception could result at runtime.
                        If rs.Rows(x).Item(0) <> s Then
#Enable Warning BC42104 ' Variable 's' is used before it has been assigned a value. A null reference exception could result at runtime.
                            Dim SelectQuerycliFact As String
                            SelectQuerycliFact = "SELECT  name1 FROM sapclients where kunnr='" & rs.Rows(x).Item(0) & "'"
                            Dim myCommandcliente As New SQLiteCommand(SelectQuerycliFact, myConnectionPricing)
                            ret = myCommandcliente.ExecuteScalar
                            ' Create a child node for the node1             
                            .AppendNode(New Object() {ret, rs.Rows(x).Item(0)}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    .Columns(1).Width = 100
                    myConnectionPricing.Close()
                    If TreeView3a.Nodes(0).Nodes.Count = 1 Then TreeView3a.FocusedNode = TreeView3a.Nodes(0).Nodes(0) : filterkeyclifact = TreeView3a.Nodes(0).Nodes(0).GetDisplayText(1)

                End With
            Case 3

                With TreeView4a
                    Dim myConnectionPricing As New SQLiteConnection
                    myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
                    myConnectionPricing.Open()
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).Caption = "Name"
                    .Columns(0).SortOrder = Windows.Forms.SortOrder.Ascending
                    .Columns.Add()
                    .Columns(1).VisibleIndex = 1
                    .Columns(1).Caption = "Nº"

                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            Dim SelectQuerycliFact As String
                            SelectQuerycliFact = "SELECT  name1 FROM sapclients where kunnr='" & rs.Rows(x).Item(0) & "'"
                            Dim myCommandcliente As New SQLiteCommand(SelectQuerycliFact, myConnectionPricing)
                            ret = myCommandcliente.ExecuteScalar
                            ' Create a child node for the node1             
                            .AppendNode(New Object() {ret, rs.Rows(x).Item(0)}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    .Columns(1).Width = 100
                    myConnectionPricing.Close()
                    If TreeView4a.Nodes(0).Nodes.Count = 1 Then TreeView4a.FocusedNode = TreeView4a.Nodes(0).Nodes(0) : filterkeyclidest = TreeView4a.Nodes(0).Nodes(0).GetDisplayText(1)

                End With
            Case 4
                With TreeView5a
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = Windows.Forms.SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            .AppendNode(New Object() {rs.Rows(x).Item(0)}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    If TreeView5a.Nodes(0).Nodes.Count = 1 Then TreeView5a.FocusedNode = TreeView5a.Nodes(0).Nodes(0) : filterkeycomp = SQ(TreeView5a.Nodes(0).Nodes(0).GetDisplayText(0))
                End With
            Case 5
                With TreeView6a
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = Windows.Forms.SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            .AppendNode(New Object() {rs.Rows(x).Item(0)}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    If TreeView6a.Nodes(0).Nodes.Count = 1 Then TreeView6a.FocusedNode = TreeView6a.Nodes(0).Nodes(0) : filterkeytipo = TreeView6a.Nodes(0).Nodes(0).GetDisplayText(0)
                End With
            Case 6
                With TreeView7a
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = Windows.Forms.SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            .AppendNode(New Object() {rs.Rows(x).Item(0)}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    If TreeView7a.Nodes(0).Nodes.Count = 1 Then TreeView7a.FocusedNode = TreeView7a.Nodes(0).Nodes(0) : filterkeypricelist = TreeView7a.Nodes(0).Nodes(0).GetDisplayText(0)
                End With

            Case 7
                With TreeView8a
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = Windows.Forms.SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            .AppendNode(New Object() {rs.Rows(x).Item(0)}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    If TreeView8a.Nodes(0).Nodes.Count = 1 Then TreeView8a.FocusedNode = TreeView8a.Nodes(0).Nodes(0) : filterkeyPCDATI = TreeView8a.Nodes(0).Nodes(0).GetDisplayText(0)
                End With
            Case 8
                With TreeView9a
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = Windows.Forms.SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            .AppendNode(New Object() {rs.Rows(x).Item(0)}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    If TreeView9a.Nodes(0).Nodes.Count = 1 Then TreeView9a.FocusedNode = TreeView9a.Nodes(0).Nodes(0) : filterkeyPCDATF = TreeView9a.Nodes(0).Nodes(0).GetDisplayText(0)
                End With
            Case 9
                With TreeView10a
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = Windows.Forms.SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node . 
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            .AppendNode(New Object() {rs.Rows(x).Item(0)}, rootNode)

                        End If
                    Next
                    .EndUnboundLoad()
                    .BestFitColumns(True)
                    If TreeView10a.Nodes(0).Nodes.Count = 1 Then TreeView10a.FocusedNode = TreeView10a.Nodes(0).Nodes(0) : filterkeyCurrency = TreeView10a.Nodes(0).Nodes(0).GetDisplayText(0)
                End With





        End Select
    End Sub


    Private Sub TreeView1a_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView1a.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String

        varstr = vbNullString
        varstr = e.Node.GetDisplayText(1) ' e.Node.Name


        filterkeydir = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Director", "%", varstr)
        filterkeypais = "%"
        filterkeyclifact = "%"
        filterkeyclidest = "%"
        filterkeycomp = "%"
        filterkeytipo = "%"
        filterkeypricelist = "%"
        filterkeyPCDATI = "%"
        filterkeyPCDATF = "%"
        filterkeyCurrency = "%"

        treefill(0)

        click1 = False
    End Sub

    Private Sub TreeView2a_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView2a.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String

        varstr = vbNullString
        varstr = e.Node.GetDisplayText(0) ' e.Node.Name

        filterkeypais = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Final Market", "%", varstr)
        filterkeyclifact = "%"
        filterkeyclidest = "%"
        filterkeycomp = "%"
        filterkeytipo = "%"
        filterkeypricelist = "%"
        filterkeyPCDATI = "%"
        filterkeyPCDATF = "%"
        filterkeyCurrency = "%"
        treefill(1)

        click2 = False
    End Sub

    Private Sub TreeView3a_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView3a.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String

        varstr = vbNullString
        varstr = e.Node.GetDisplayText(1) ' e.Node.Name

        filterkeyclifact = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Invoicing Customer", "%", varstr)
        filterkeyclidest = "%"
        filterkeycomp = "%"
        filterkeytipo = "%"
        filterkeypricelist = "%"
        filterkeyPCDATI = "%"
        filterkeyPCDATF = "%"
        filterkeyCurrency = "%"

        treefill(2)

        click3 = False
    End Sub
    Private Sub TreeView4a_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView4a.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String

        varstr = vbNullString
        varstr = e.Node.GetDisplayText(1) ' e.Node.Name


        filterkeyclidest = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Final Customer", "%", varstr)
        filterkeycomp = "%"
        filterkeytipo = "%"
        filterkeypricelist = "%"
        filterkeyPCDATI = "%"
        filterkeyPCDATF = "%"
        filterkeyCurrency = "%"

        treefill(3)

        click4 = False
    End Sub

    Private Sub TreeView5a_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView5a.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String

        varstr = vbNullString
        varstr = e.Node.GetDisplayText(0) ' e.Node.Name

        filterkeycomp = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Brand", "%", SQ(e.Node.GetDisplayText(0)))
        filterkeytipo = "%"
        filterkeypricelist = "%"
        filterkeyPCDATI = "%"
        filterkeyPCDATF = "%"
        filterkeyCurrency = "%"

        treefill(4)

        click5 = False
    End Sub
    Private Sub TreeView6a_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView6a.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String

        varstr = vbNullString
        varstr = e.Node.GetDisplayText(0) ' e.Node.Name

        filterkeytipo = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Type", "%", varstr)
        filterkeypricelist = "%"
        filterkeyPCDATI = "%"
        filterkeyPCDATF = "%"
        filterkeyCurrency = "%"

        treefill(5)

        click6 = False
    End Sub
    Private Sub TreeView7a_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView7a.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String

        varstr = vbNullString
        varstr = e.Node.GetDisplayText(0) ' e.Node.Name

        filterkeypricelist = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Price List Type", "%", varstr)
        filterkeyPCDATI = "%"
        filterkeyPCDATF = "%"
        filterkeyCurrency = "%"

        treefill(6)

        click7 = False
    End Sub
    Private Sub TreeView8a_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView8a.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String

        varstr = vbNullString
        varstr = e.Node.GetDisplayText(0) ' e.Node.Name

        filterkeyPCDATI = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Data Inicial", "%", varstr)
        filterkeyPCDATF = "%"
        filterkeyCurrency = "%"

        treefill(7)

        click8 = False
    End Sub
    Private Sub TreeView9a_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView9a.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String

        varstr = vbNullString
        varstr = e.Node.GetDisplayText(0) ' e.Node.Name

        filterkeyPCDATF = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Data Final", "%", varstr)
        filterkeyCurrency = "%"
        treefill(8)

        click9 = False
    End Sub
    Private Sub TreeView10a_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeView10a.FocusedNodeChanged
        If flagWork = True Then Exit Sub
        flagWork = True
        Dim varstr As String

        varstr = vbNullString
        varstr = e.Node.GetDisplayText(0) ' e.Node.Name


        filterkeyCurrency = IIf(e.Node.GetDisplayText(0) = "ALL" Or e.Node.GetDisplayText(0) = "Currency", "%", varstr)
        treefill(9)

        click10 = False
    End Sub


    Public Function SQ(ByVal str As String) As String
        SQ = Replace(str, "'", "''", 1, -1, vbTextCompare)
    End Function
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



    Private Sub Command3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command3.Click
        Globals.Sheet1.fecho = True
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TreeView1a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView1a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView2a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView2a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView3a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView3a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView4a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView4a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView5a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView5a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView6a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView6a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView7a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView7a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView8a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView8a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView9a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView9a.Appearance.Row.BackColor = System.Drawing.Color.Wheat
        Me.TreeView10a.Appearance.Empty.BackColor = System.Drawing.Color.Wheat
        Me.TreeView10a.Appearance.Row.BackColor = System.Drawing.Color.Wheat

        Dim flagfalta As Boolean = False
        If TreeView1a.FocusedNode.Level = 0 Then
            Me.TreeView1a.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView1a.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If
        If TreeView2a.FocusedNode.Level = 0 Then
            Me.TreeView2a.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView2a.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If
        If TreeView3a.FocusedNode.Level = 0 Then
            Me.TreeView3a.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView3a.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If

        If TreeView4a.FocusedNode.Level = 0 Then
            Me.TreeView4a.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView4a.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If

        If TreeView5a.FocusedNode.Level = 0 Then
            Me.TreeView5a.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView5a.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If
        If TreeView6a.FocusedNode.Level = 0 Then
            Me.TreeView6a.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView6a.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If
        If TreeView7a.FocusedNode.Level = 0 Then
            Me.TreeView7a.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView7a.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If
        If TreeView8a.FocusedNode.Level = 0 Then
            Me.TreeView8a.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView8a.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If
        If TreeView9a.FocusedNode.Level = 0 Then
            Me.TreeView9a.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView9a.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If
        If TreeView10a.FocusedNode.Level = 0 Then
            Me.TreeView10a.Appearance.Empty.BackColor = System.Drawing.Color.IndianRed
            Me.TreeView10a.Appearance.Row.BackColor = System.Drawing.Color.IndianRed
            flagfalta = True
        End If



        If flagfalta = True Then MsgBox("Seleccione as opções em falta...") : Exit Sub



        Windows.Forms.Cursor.Current = Windows.Forms.Cursors.WaitCursor

        CreatePricing(filterkeydir, filterkeypais, filterkeyclifact, filterkeyclidest, filterkeycomp, filterkeytipo, filterkeypricelist, filterkeyPCDATI, filterkeyPCDATF, filterkeyCurrency)

        Windows.Forms.Cursor.Current = Windows.Forms.Cursors.Default

    End Sub




    Private Sub CreatePricing(ByVal director As String, ByVal pais As String, ByVal clientfact As String, ByVal clientdest As String, ByVal company As String, ByVal tipo As String, ByVal pricelist As String, ByVal PCDATI As String, ByVal PCDATF As String, ByVal Currency As String)
        Dim MD As String
        Dim mng As String
        Dim ass As String


        Dim ultimalinha As Integer = 24
        'Dim clientEst As Integer

        Globals.Sheet1.Unprotect("password2")
        Globals.Sheet1.ready = False
        Dim bottlecustlist As New Collections.ArrayList
        bottlecustlist.Clear()

        Dim mySelectQuery As String

        Dim myConnectionPricing As New SQLiteConnection ' OleDb.OleDbConnection
        myConnectionPricing.ConnectionString = My.Settings.PricingConnectionString
        myConnectionPricing.Open()


        Globals.Sheet1.EnableCalculation = False


        Globals.ThisWorkbook.Application.EnableEvents = False



        '''''INICIO Invoice Customer Information
        '''''INICIO Invoice Customer Information
        '''''INICIO Invoice Customer Information
        'nome cliente
        Globals.Sheet1.Range("D4").Value2 = clientdest

        'Globals.Sheet1.Range("D6").Value2 = (company)
        Globals.Sheet1.Range("C6").Value2 = (company)
        Globals.Sheet1.Range("C7").Value2 = (tipo)


        'dados cliente
        Dim mySelectQueryclienteDest As String

        mySelectQueryclienteDest = "SELECT  name1, contactname, contacttelephone, contactemail, landx50, clientstat, marketdirector, marketmanager, marketassistant, KATR3, BRSCH  FROM sapclients where kunnr ='" & clientdest & "'"
        Dim myCommandclienteDest As New SQLiteCommand(mySelectQueryclienteDest, myConnectionPricing)
        Dim myReaderclienteDest As SQLiteDataReader
        myReaderclienteDest = myCommandclienteDest.ExecuteReader


        Dim clistat As String
        While myReaderclienteDest.Read()
            Globals.Sheet1.Range("C4").Value2 = (myReaderclienteDest(0))
            Globals.Sheet1.Range("C8").Value2 = (myReaderclienteDest(1))
            Globals.Sheet1.Range("C9").Value2 = (myReaderclienteDest(2))
            Globals.Sheet1.Range("C10").Value2 = (myReaderclienteDest(3))
            Globals.Sheet1.Range("C5").Value2 = (myReaderclienteDest(4))
            Globals.Sheet1.Range("D12").Value2 = (clientfact)
            Globals.Sheet1.Range("D11").Value2 = (myReaderclienteDest(5))
            Globals.Sheet1.Range("C18").Value2 = myReaderclienteDest(9) 'Mainstream/Emerging
            Globals.Sheet1.Range("C19").Value2 = myReaderclienteDest(10) '  ' Distributer Type

            MD = myReaderclienteDest(6)
            mng = myReaderclienteDest(7)
            ass = myReaderclienteDest(8)

            clistat = (myReaderclienteDest(5))
        End While
        myReaderclienteDest.Close()

        Dim mySelectQueryclienteDestDirector As String
#Disable Warning BC42104 ' Variable 'MD' is used before it has been assigned a value. A null reference exception could result at runtime.
        mySelectQueryclienteDestDirector = "SELECT  name1 FROM sapclients where kunnr ='" & MD & "'"
#Enable Warning BC42104 ' Variable 'MD' is used before it has been assigned a value. A null reference exception could result at runtime.
        Dim myCommandclienteDestDirector As New SQLiteCommand(mySelectQueryclienteDestDirector, myConnectionPricing)
        Globals.Sheet1.Range("C15").Value2 = myCommandclienteDestDirector.ExecuteScalar() ' Director

        Dim mySelectQueryclienteDestManager As String
#Disable Warning BC42104 ' Variable 'mng' is used before it has been assigned a value. A null reference exception could result at runtime.
        mySelectQueryclienteDestManager = "SELECT  name1 FROM sapclients where kunnr ='" & mng & "'"
#Enable Warning BC42104 ' Variable 'mng' is used before it has been assigned a value. A null reference exception could result at runtime.
        Dim myCommandclienteDestManager As New SQLiteCommand(mySelectQueryclienteDestManager, myConnectionPricing)
        Globals.Sheet1.Range("C16").Value2 = myCommandclienteDestManager.ExecuteScalar  ' Manager

        Dim mySelectQueryclienteDestAssistant As String
#Disable Warning BC42104 ' Variable 'ass' is used before it has been assigned a value. A null reference exception could result at runtime.
        mySelectQueryclienteDestAssistant = "SELECT  name1 FROM sapclients where kunnr ='" & ass & "'"
#Enable Warning BC42104 ' Variable 'ass' is used before it has been assigned a value. A null reference exception could result at runtime.
        Dim myCommandclienteDestAssistant As New SQLiteCommand(mySelectQueryclienteDestAssistant, myConnectionPricing)
        Globals.Sheet1.Range("C17").Value2 = myCommandclienteDestAssistant.ExecuteScalar() ' Assistant

        Dim mySelectQueryclienteStat As String
#Disable Warning BC42104 ' Variable 'clistat' is used before it has been assigned a value. A null reference exception could result at runtime.
        mySelectQueryclienteStat = "SELECT  name1 FROM sapclients where kunnr ='" & clistat & "'"
#Enable Warning BC42104 ' Variable 'clistat' is used before it has been assigned a value. A null reference exception could result at runtime.
        Dim myCommandclientestat As New SQLiteCommand(mySelectQueryclienteStat, myConnectionPricing)
        Globals.Sheet1.Range("c11").Value2 = myCommandclientestat.ExecuteScalar
        Globals.Sheet1.Range("d11").Value2 = clistat

        '  paisclidest = myReaderclienteDest(4)
        '  clientEst = myReaderclienteDest(5)


        Dim mySelectQueryclientefact As String
        mySelectQueryclientefact = "SELECT  name1 FROM sapclients where kunnr ='" & clientfact & "'"
        Dim myCommandclientefact As New SQLiteCommand(mySelectQueryclientefact, myConnectionPricing)
        Globals.Sheet1.Range("C12").Value2 = (myCommandclientefact.ExecuteScalar)

     

        '''''INICIO Terms & Condition
        '''''INICIO Terms & Condition
        '''''INICIO Terms & Condition
        Dim mySelectQueryCREDIT As String = "SELECT KLIMK, zzdiastoler, ztermtext, zincoterms, advertencia, katr4  FROM SAPCLIENTS where kunnr = '" & clientfact & "'"
        Dim myCommandCREDIT As New SQLiteCommand(mySelectQueryCREDIT, myConnectionPricing)
        Dim myReadercredit As SQLiteDataReader
        myReadercredit = myCommandCREDIT.ExecuteReader()
        While myReadercredit.Read
            Globals.Sheet1.Range("G7").Value2 = myReadercredit(0) 'CreditLimit Value
            Globals.Sheet1.Range("I7").Value2 = myReadercredit(1) ' credit limit DAYS
            Globals.Sheet1.Range("G8").Value2 = myReadercredit(2) 'Payment Terms
            Globals.Sheet1.Range("G9").Value2 = myReadercredit(3) 'Delivery Terms
            Globals.Sheet1.Range("I8").Value2 = myReadercredit(4) 'Tolerance
            'Globals.Sheet1.Range("G10").Value2 = myReadercredit(5) 'Tamanho da Palete
        End While
        myReadercredit.Close()

        Dim mySelectQueryCREDIT2 As String = "SELECT katr4  FROM SAPCLIENTS where kunnr = '" & clientdest & "'"
        Dim myCommandCREDIT2 As New SQLiteCommand(mySelectQueryCREDIT2, myConnectionPricing)
        Dim myReadercredit2 As SQLiteDataReader
        myReadercredit2 = myCommandCREDIT2.ExecuteReader()
        While myReadercredit2.Read
            Globals.Sheet1.Range("G10").Value2 = myReadercredit2(0) 'Tamanho da Palete
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
            mySelectQuery = "SELECT * FROM query2 where " _
            & "tabela='" & filterkeyPricing & "' and pcclid='" & clientdest & "' and pcccli='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "OR " _
            & "tabela='" & filterkeyPricing & "' and pcclid='" & clientdest & "' and pcccli='" & clientfact & "' and tipo='Paletes' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "ORDER BY PCCPRP, PCORDE, PCACOL"

        ElseIf filterkeyPricing = "932" Then
            mySelectQuery = "SELECT * FROM query2 where " _
            & "tabela='" & filterkeyPricing & "' and pcccli='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "OR " _
            & "tabela='" & filterkeyPricing & "' and pcccli='" & clientfact & "' and tipo='Paletes' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "ORDER BY PCCPRP, PCORDE, PCACOL"

        ElseIf filterkeyPricing = "933" Then
            mySelectQuery = "SELECT * FROM query2 where " _
            & "tabela='" & filterkeyPricing & "' and pcclid='" & clientdest & "' and pcccli='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "OR " _
            & "tabela='" & filterkeyPricing & "' and pcclid='" & clientdest & "' and pcccli='" & clientfact & "' and tipo='Paletes' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "ORDER BY PCCPRP, PCORDE, PCACOL"

        ElseIf filterkeyPricing = "934" Then
            mySelectQuery = "SELECT * FROM query2 where " _
            & "tabela='" & filterkeyPricing & "' and pcccli='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "OR " _
            & "tabela='" & filterkeyPricing & "' and pcccli='" & clientfact & "' and tipo='Paletes' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "ORDER BY PCCPRP, PCORDE, PCACOL"

        ElseIf filterkeyPricing = "935" Then
            mySelectQuery = "SELECT * FROM query2 where " _
            & "tabela='" & filterkeyPricing & "' and pcclid='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "OR " _
            & "tabela='" & filterkeyPricing & "' and pcclid='" & clientfact & "' and tipo='Paletes' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "ORDER BY PCCPRP, PCORDE, PCACOL"

        ElseIf filterkeyPricing = "936" Then
            mySelectQuery = "SELECT * FROM query2 where " _
            & "tabela='" & filterkeyPricing & "' and pcclid='" & clientfact & "' and pcfirm='" & company & "' and tipo='" & tipo & "' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "OR " _
            & "tabela='" & filterkeyPricing & "' and pcclid='" & clientfact & "' and tipo='Paletes' and PCTPRE='" & pricelist & "' and PCDATI=" & PCDATI & " and PCDATF=" & PCDATF & " and PCMOED='" & Currency & "' " _
            & "ORDER BY PCCPRP, PCORDE, PCACOL"
        End If


#Disable Warning BC42104 ' Variable 'mySelectQuery' is used before it has been assigned a value. A null reference exception could result at runtime.
        Dim myCommand As New SQLiteCommand(mySelectQuery, myConnectionPricing)
#Enable Warning BC42104 ' Variable 'mySelectQuery' is used before it has been assigned a value. A null reference exception could result at runtime.
        Dim myReader1 As SQLiteDataReader
        myReader1 = myCommand.ExecuteReader()

        '    Dim count As Integer = 0
        Dim countbottlecust As Integer = 0
        Dim OffInvoiceMarktSup As Integer = 0
        Dim flagfirstrow As Boolean = True

        Dim flagprodutopai As String = ""
        Dim linhasprodutopai As New Collection

        While myReader1.Read()



            If ultimalinha > 24 Then
                Dim rng As Excel.Range = Globals.Sheet1.Range("A24").EntireRow
                rng.Copy(Globals.Sheet1.Range("A" & ultimalinha).EntireRow)
            End If

            If flagfirstrow = True Then
        
                Globals.Sheet1.Range("G4").Value2 = (Now.Year)
                Globals.Sheet1.Range("I4").Value2 = (Today)
                Globals.Sheet1.Range("G5").Value2 = (myReader1("PCTPRE")) & " " & getSymPriceListType(myReader1("PCTPRE"))
                'Globals.Sheet1.Range("I5").Value2 = (myReader1("PCVERS"))
                Globals.Sheet1.Range("I5").Value2 = (myReader1("TABELA"))
                Globals.Sheet1.Range("G6").Value2 = (myReader1("PCDATI"))
                Globals.Sheet1.Range("I6").Value2 = (myReader1("PCDATF"))

                '''''INICIO Exchange Rates
                '''''INICIO Exchange Rates
                '''''INICIO Exchange Rates

                Globals.Sheet1.Range("L18").Value2 = (myReader1("PCMOED"))
                If UCase(myReader1("PCMOED")) <> "EUR" Then
                    Dim mySelectQueryEXC As String = "SELECT valor FROM sapcambios where nome='" & myReader1("PCMOED") & "'"
                    Dim myCommandEXC As New SQLiteCommand(mySelectQueryEXC, myConnectionPricing)
                    Dim retEXC As Double = myCommandEXC.ExecuteScalar
                    Globals.Sheet1.Range("M18").Value2 = Math.Abs(retEXC)

                    '    Dim mySelectQueryEXC1 As String = "SELECT RTCOMP FROM cambios1 where RTMOED='" & myReader1("PCMOED") & "'"
                    '    Dim myCommandEXC1 As New OleDbCommand(mySelectQueryEXC1, myConnectionPricing)
                    '    Dim retEXC1 As Double = myCommandEXC1.ExecuteScalar
                    '    Globals.Sheet1.Range("N18").Value2 = retEXC1
                Else
                    Globals.Sheet1.Range("M18").Value2 = 1
                End If


                '''''FIM Exchange Rates
                '''''FIM Exchange Rates
                '''''FIM Exchange Rates

            End If




            '''''INICIO LINHA Product
            '''''INICIO LINHA Product
            '''''INICIO LINHA Product


            Me.SapMateriaisQueryTableAdapter1.ClearBeforeFill = True
            Me.SapMateriaisQueryTableAdapter1.Fill(Me.SapPricingDataset11.SapMateriaisQuery, myReader1("PCCPRO"))

            If filterkeyPricing = "931" Or filterkeyPricing = "932" Then

                If flagprodutopai <> myReader1("PCCPRP") Then
                    Dim mySelectQueryDescrProdPAI As String

                    mySelectQueryDescrProdPAI = "SELECT maktx FROM SapMateriais where matnr='" & myReader1("PCCPRP") & "'"
                    Dim myCommandDescrProdPAI As New SQLiteCommand(mySelectQueryDescrProdPAI, myConnectionPricing)
                    Dim retDescrProdPAI As String
                    retDescrProdPAI = myCommandDescrProdPAI.ExecuteScalar
                    Globals.Sheet1.Range("A" & ultimalinha).Value2 = (retDescrProdPAI)
                    Globals.Sheet1.Range("AC" & ultimalinha).Value2 = (myReader1("PCCPRP"))

                    linhasprodutopai.Add("A" & ultimalinha)


                    ultimalinha = ultimalinha + 1
                    flagfirstrow = False
                    flagprodutopai = myReader1("PCCPRP")


                    Dim rng As Excel.Range = Globals.Sheet1.Range("A24").EntireRow
                    rng.Copy(Globals.Sheet1.Range("A" & ultimalinha).EntireRow)





                End If
            End If

             Dim retDescrProd As String
            'retDescrProd = myCommandDescrProd.ExecuteScalar
            retDescrProd = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("maktx")
            Globals.Sheet1.Range("A" & ultimalinha).Value2 = (retDescrProd)
            If IsDBNull(myReader1("PCCPRP")) Then
                Globals.Sheet1.Range("BW" & ultimalinha).Value2 = (myReader1("PCCPRO"))
            Else
                Globals.Sheet1.Range("BW" & ultimalinha).Value2 = (myReader1("PCCPRP"))
            End If

            ''''caixa /bottle
           
            Dim retUNITProd As String

            retUNITProd = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("meins")
            Globals.Sheet1.Range("BX" & ultimalinha).Value2 = (retUNITProd)

    
            Dim retRange As String

            retRange = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("RANGE")
            Globals.Sheet1.Range("B" & ultimalinha).Value2 = retRange ''Stock


       
    
            Dim retEMBALDESC As String
            '  retEMBALDESC = myCommandEMBALDesc.ExecuteScalar
            retEMBALDESC = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("DESCR")
            Globals.Sheet1.Range("C" & ultimalinha).Value2 = retEMBALDESC

            ''''status do Material
            ''''status do Material
            Dim retSTATUS As String
            retSTATUS = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("STATUS")
            If retSTATUS = "X" Then
                Dim rngStatus As Excel.Range = Globals.Sheet1.Range("A" & ultimalinha, "BV" & ultimalinha)
                rngStatus.Font.Color = System.Drawing.Color.Red
            Else
                Dim rngStatus As Excel.Range = Globals.Sheet1.Range("A" & ultimalinha, "BV" & ultimalinha)
                rngStatus.Font.Color = System.Drawing.Color.Black
            End If



            '''''FIM LINHA Product
            '''''FIM LINHA Product
            '''''FIM LINHA Product


            '''''INICIO LINHA Gross Customer Unit Price
            '''''INICIO LINHA Gross Customer Unit Price
            '''''INICIO LINHA Gross Customer Unit Price
            Globals.Sheet1.Range("F" & ultimalinha).Value2 = (myReader1("PCPVAC"))
            Globals.Sheet1.Range("G" & ultimalinha).Value2 = (myReader1("PCPVAA"))

            '''''FIM LINHA Gross Customer Unit Price
            '''''FIM LINHA Gross Customer Unit Price
            '''''FIM LINHA Gross Customer Unit Price

            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price
            '''''INICIO LINHA Reference Price

            Dim mySelectQueryREFPrice As String
            mySelectQueryREFPrice = "SELECT kbetr FROM saprefprice where matnr='" & myReader1("PCCPRO") & "' and zzkatr3='" & Globals.Sheet1.Range("C18").Value2 & "' and datbi >='" & PCDATI & "' and datab <='" & PCDATI & "'"
            Dim myCommandREFPrice As New SQLiteCommand(mySelectQueryREFPrice, myConnectionPricing)
            Dim retREFPrice As String
            retREFPrice = myCommandREFPrice.ExecuteScalar
            Globals.Sheet1.Range("T" & ultimalinha).Value2 = CDbl(retREFPrice)



            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price
            '''''FIM LINHA Reference Price

            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs
            '''''INICIO LINHA Bootling Costs

            Dim mySelectQueryBOTCOSTMOQ As String
            mySelectQueryBOTCOSTMOQ = "SELECT kbetr FROM sapbotlcost where matnr='" & myReader1("PCCPRO") & "' and datbi >='" & PCDATI & "' and datab <='" & PCDATI & "'"
            Dim myCommandBOTCOSTMOQ As New SQLiteCommand(mySelectQueryBOTCOSTMOQ, myConnectionPricing)
            Dim retBOTCOSTMOQ As Decimal
            retBOTCOSTMOQ = myCommandBOTCOSTMOQ.ExecuteScalar

            Globals.Sheet1.Range("BS" & ultimalinha).Value2 = retBOTCOSTMOQ
         

            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs
            '''''FIM LINHA Bootling Costs


            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus
            '''''INICIO LINHA Bonus

            Dim mySelectQueryBonus As String
            mySelectQueryBonus = ""
            If filterkeyPricing = "931" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & filterkeyPricing & "' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
            ElseIf filterkeyPricing = "933" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & filterkeyPricing & "' and zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
            ElseIf filterkeyPricing = "932" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & filterkeyPricing & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
            ElseIf filterkeyPricing = "934" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & filterkeyPricing & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
            ElseIf filterkeyPricing = "935" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & filterkeyPricing & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
            ElseIf filterkeyPricing = "936" Then
                mySelectQueryBonus = "SELECT kbetr, knrnm, knrzm  FROM sapbonusconditions where tabela= 'KOTN" & filterkeyPricing & "' and zcldest='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi ='" & PCDATF & "' and datab ='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"



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
                    Globals.Sheet1.Range("BT" & ultimalinha).Value2 = retBonus(0)
                    Globals.Sheet1.Range("BU" & ultimalinha).Value2 = retBonus(1)
                    Globals.Sheet1.Range("BV" & ultimalinha).Value2 = retBonus(2)
                Loop
            Else
                Globals.Sheet1.Range("BT" & ultimalinha).Value2 = ""
                Globals.Sheet1.Range("BU" & ultimalinha).Value2 = ""
                Globals.Sheet1.Range("BV" & ultimalinha).Value2 = ""
            End If


            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus
            '''''FIM LINHA Bonus


            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes
            '''''INICIO LINHA Estipulaçoes

            Dim mySelectQueryEstipulaçoes As String
            mySelectQueryEstipulaçoes = ""
            Globals.Sheet1.Range("AX" & ultimalinha & ":BR" & ultimalinha).Value2 = Nothing

            If filterkeyPricing = "936" Then ''''ALEMANHA por CLIENTE ESTATISTICO
                mySelectQueryEstipulaçoes = "SELECT knuma,boart, kschl, kbetr, bonem, vkorgcond FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='clistat' and pltyp ='" & pricelist & "' and datbi >='" & PCDATF & "' and datab <='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
            Else
                mySelectQueryEstipulaçoes = "SELECT knuma,boart, kschl, kbetr, bonem, vkorgcond FROM SapEstipulacoes where zcldest='" & clientdest & "' and kunnr='" & clientfact & "' and pltyp ='" & pricelist & "' and datbi >='" & PCDATF & "' and datab <='" & PCDATI & "' and waerk ='" & Currency & "' and matnr='" & myReader1("PCCPRO") & "'"
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
                newRow(3) = PCDATI
                newRow(4) = PCDATF
                newRow(5) = retEstipulaçoes("kschl")
                newRow(6) = myReader1("PCCPRO")
                If UCase(retEstipulaçoes("kschl")).ToString.EndsWith("V") Then
                    newRow(7) = retEstipulaçoes("kbetr")
                Else
                    newRow(7) = retEstipulaçoes("kbetr") / 10
                End If
                newRow(8) = Globals.Sheet1.Range("BX" & ultimalinha).Value2
                newRow(9) = retEstipulaçoes("vkorgcond")

                Globals.ThisWorkbook.estipulacaoDataTable.Rows.Add(newRow)

                Dim clientpricesupport As New List(Of String)
                Dim clientAPsupport As New List(Of String)
                Dim clientRappel As New List(Of String)
                Select Case retEstipulaçoes("kschl")
                    ''Price Support
                    Case "YSCV" ' Analysis & Others V
                        Globals.Sheet1.Range("BB" & ultimalinha).Value2 = Globals.Sheet1.Range("BB" & ultimalinha).Value2 + retEstipulaçoes("kbetr")
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
                    Case "YSCP" ' Analysis & Others P
                        Globals.Sheet1.Range("BC" & ultimalinha).Value2 = Globals.Sheet1.Range("BC" & ultimalinha).Value2 + (retEstipulaçoes("kbetr") / 10)
                        clientpricesupport.Add(retEstipulaçoes("bonem"))

                    Case "YSNV" ' Credit note V
                        Globals.Sheet1.Range("AX" & ultimalinha).Value2 = Globals.Sheet1.Range("AX" & ultimalinha).Value2 + retEstipulaçoes("kbetr")
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
                    Case "YSNP" ' Credit note P
                        Globals.Sheet1.Range("AY" & ultimalinha).Value2 = Globals.Sheet1.Range("AY" & ultimalinha).Value2 + (retEstipulaçoes("kbetr") / 10)
                        clientpricesupport.Add(retEstipulaçoes("bonem"))


                    Case "YSHV" ' Charged by customer V
                        Globals.Sheet1.Range("AZ" & ultimalinha).Value2 = Globals.Sheet1.Range("AZ" & ultimalinha).Value2 + retEstipulaçoes("kbetr")
                        clientpricesupport.Add(retEstipulaçoes("bonem"))
                    Case "YSHP" ' Charged by customer P
                        Globals.Sheet1.Range("BA" & ultimalinha).Value2 = Globals.Sheet1.Range("BA" & ultimalinha).Value2 + (retEstipulaçoes("kbetr") / 10)
                        clientpricesupport.Add(retEstipulaçoes("bonem"))

                        ''A&P Support
                    Case "YAPV"
                        Globals.Sheet1.Range("BD" & ultimalinha).Value2 = Globals.Sheet1.Range("BD" & ultimalinha).Value2 + retEstipulaçoes("kbetr")
                        clientAPsupport.Add(retEstipulaçoes("bonem"))
                    Case "YAPP"
                        Globals.Sheet1.Range("BE" & ultimalinha).Value2 = Globals.Sheet1.Range("BE" & ultimalinha).Value2 + (retEstipulaçoes("kbetr") / 10)
                        clientAPsupport.Add(retEstipulaçoes("bonem"))
                    Case "YABV"
                        Globals.Sheet1.Range("BF" & ultimalinha).Value2 = Globals.Sheet1.Range("BF" & ultimalinha).Value2 + retEstipulaçoes("kbetr")
                        clientAPsupport.Add(retEstipulaçoes("bonem"))

                        ''incentives....
                    Case "YOCM"
                        Globals.Sheet1.Range("BG" & ultimalinha).Value2 = Globals.Sheet1.Range("BG" & ultimalinha).Value2 + retEstipulaçoes("kbetr")
                        clientRappel.Add(retEstipulaçoes("bonem"))

                        ''Rappel....
                    Case "YRRV"
                        Globals.Sheet1.Range("BI" & ultimalinha).Value2 = Globals.Sheet1.Range("BI" & ultimalinha).Value2 + retEstipulaçoes("kbetr")
                        clientRappel.Add(retEstipulaçoes("bonem"))
                    Case "YRRP"
                        Globals.Sheet1.Range("BJ" & ultimalinha).Value2 = Globals.Sheet1.Range("BJ" & ultimalinha).Value2 + (retEstipulaçoes("kbetr") / 10)
                        clientRappel.Add(retEstipulaçoes("bonem"))
                        ''Commisions normais
                    Case "YCOP"
                        countcomm = countcomm + 1
                        If countcomm = 1 Then
                            Globals.Sheet1.Range("BM" & ultimalinha).Value2 = retEstipulaçoes("kbetr") / 10
                            Globals.Sheet1.Range("BN" & ultimalinha).Value2 = retEstipulaçoes("bonem")
                        ElseIf countcomm = 2 Then
                            Globals.Sheet1.Range("BO" & ultimalinha).Value2 = retEstipulaçoes("kbetr") / 10
                            Globals.Sheet1.Range("BP" & ultimalinha).Value2 = retEstipulaçoes("bonem")
                        ElseIf countcomm = 3 Then
                            Globals.Sheet1.Range("BQ" & ultimalinha).Value2 = retEstipulaçoes("kbetr") / 10
                            Globals.Sheet1.Range("BR" & ultimalinha).Value2 = retEstipulaçoes("bonem")
                        Else
                            MsgBox("erro no nº de comissionistas", MsgBoxStyle.Exclamation)
                        End If
                        ''Commisions smartwine
                    Case "YEST"
                        countcomm = countcomm + 1
                        If countcomm = 1 Then
                            Globals.Sheet1.Range("BM" & ultimalinha).Value2 = retEstipulaçoes("kbetr") / 10
                            Globals.Sheet1.Range("BN" & ultimalinha).Value2 = retEstipulaçoes("bonem")
                        ElseIf countcomm = 2 Then
                            Globals.Sheet1.Range("BO" & ultimalinha).Value2 = retEstipulaçoes("kbetr") / 10
                            Globals.Sheet1.Range("BP" & ultimalinha).Value2 = retEstipulaçoes("bonem")
                        ElseIf countcomm = 3 Then
                            Globals.Sheet1.Range("BQ" & ultimalinha).Value2 = retEstipulaçoes("kbetr") / 10
                            Globals.Sheet1.Range("BR" & ultimalinha).Value2 = retEstipulaçoes("bonem")
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



            ' '''''INICIO LINHA  VOLUMES(9L)
            ' '''''INICIO LINHA  VOLUMES(9L)
            ' '''''INICIO LINHA  VOLUMES(9L)

            If filterkeyPricing = "936" Then ''''ALEMANHA por CLIENTE ESTATISTICO
                ''''Vendas por materialforecast
                Dim mySelectQueryVol9LTotal As String
                mySelectQueryVol9LTotal = "SELECT SUM(SHIPPED) as exp4, SUM(INHAND) as exp5 FROM sapsalesforpricing WHERE (statsclientnum = '" & clistat & "') AND ([Immaterial] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year & "'"
                Dim myCommandVol9Ltotal As New SQLiteCommand(mySelectQueryVol9LTotal, myConnectionPricing)
                Dim retVol9Ltotal As SQLiteDataReader
                Try
                    retVol9Ltotal = myCommandVol9Ltotal.ExecuteReader(CommandBehavior.SingleRow)
                    Do While retVol9Ltotal.Read
                        If Not (retVol9Ltotal(0)) Is DBNull.Value Then Globals.Sheet1.Range("CT" & ultimalinha).Value2 = CDec(retVol9Ltotal(0)) Else Globals.Sheet1.Range("CT" & ultimalinha).Value2 = Nothing
                        If Not (retVol9Ltotal(1)) Is DBNull.Value Then Globals.Sheet1.Range("CU" & ultimalinha).Value2 = CDec(retVol9Ltotal(1)) Else Globals.Sheet1.Range("CU" & ultimalinha).Value2 = Nothing
                        Globals.Sheet1.Range("Y" & ultimalinha).Value2 = Globals.Sheet1.Range("CT" & ultimalinha).Value2 + Globals.Sheet1.Range("CU" & ultimalinha).Value2
                    Loop
                Catch ex As Exception
                    Globals.Sheet1.Range("Y" & ultimalinha).Value2 = Nothing
                    Globals.Sheet1.Range("CT" & ultimalinha).Value2 = Nothing
                    Globals.Sheet1.Range("CU" & ultimalinha).Value2 = Nothing
                End Try


                ''''Forecast e target
                Dim mySelectQueryVol9LFore As String
                mySelectQueryVol9LFore = "SELECT SUM(FORECA) as exp1, SUM(FORECM) as exp2 FROM sapsales WHERE (statsclientnum = '" & clistat & "') AND ([Material Number] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year & "'"
                Dim myCommandVol9LFore As New SQLiteCommand(mySelectQueryVol9LFore, myConnectionPricing)
                Dim retVol9LFore As SQLiteDataReader
                Try
                    retVol9LFore = myCommandVol9LFore.ExecuteReader(CommandBehavior.SingleRow)
                    Do While retVol9LFore.Read
                        If Not (retVol9LFore(0)) Is DBNull.Value Then Globals.Sheet1.Range("V" & ultimalinha).Value2 = CDec(retVol9LFore(0)) Else Globals.Sheet1.Range("V" & ultimalinha).Value2 = Nothing
                        If Not (retVol9LFore(1)) Is DBNull.Value Then Globals.Sheet1.Range("Z" & ultimalinha).Value2 = CDec(retVol9LFore(1)) Else Globals.Sheet1.Range("Z" & ultimalinha).Value2 = Nothing
                    Loop
                Catch ex As Exception
                    Globals.Sheet1.Range("V" & ultimalinha).Value2 = Nothing
                    Globals.Sheet1.Range("Z" & ultimalinha).Value2 = Nothing
                End Try



                ''''Last Year
                Dim mySelectQueryVol9L3 As String
                mySelectQueryVol9L3 = "SELECT SUM(SHIPPED) as exp1 FROM sapsalesforpricing WHERE (statsclientnum = '" & clistat & "') AND ([Immaterial] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year - 1 & "'"
                Dim myCommandVol9L3 As New SQLiteCommand(mySelectQueryVol9L3, myConnectionPricing)
                Dim retVol9L3 As String
                Try
                    retVol9L3 = myCommandVol9L3.ExecuteScalar
                    If Not (retVol9L3) Is DBNull.Value Then Globals.Sheet1.Range("W" & ultimalinha).Value2 = CDec(retVol9L3) Else Globals.Sheet1.Range("W" & ultimalinha).Value2 = Nothing
                Catch
                    Globals.Sheet1.Range("W" & ultimalinha).Value2 = Nothing
                End Try

            Else
                ''''Vendas por materialforecast
                Dim mySelectQueryVol9LTotal As String
                mySelectQueryVol9LTotal = "SELECT SUM(SHIPPED) as exp4, SUM(INHAND) as exp5 FROM sapsalesforpricing WHERE (invclientnum = '" & clientfact & "') AND (finalclientnum = '" & clientdest & "') AND ([Immaterial] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year & "'"
                Dim myCommandVol9Ltotal As New SQLiteCommand(mySelectQueryVol9LTotal, myConnectionPricing)
                Dim retVol9Ltotal As SQLiteDataReader
                Try
                    retVol9Ltotal = myCommandVol9Ltotal.ExecuteReader(CommandBehavior.SingleRow)
                    Do While retVol9Ltotal.Read
                        If Not (retVol9Ltotal(0)) Is DBNull.Value Then Globals.Sheet1.Range("CT" & ultimalinha).Value2 = CDec(retVol9Ltotal(0)) Else Globals.Sheet1.Range("CT" & ultimalinha).Value2 = Nothing
                        If Not (retVol9Ltotal(1)) Is DBNull.Value Then Globals.Sheet1.Range("CU" & ultimalinha).Value2 = CDec(retVol9Ltotal(1)) Else Globals.Sheet1.Range("CU" & ultimalinha).Value2 = Nothing
                        Globals.Sheet1.Range("Y" & ultimalinha).Value2 = Globals.Sheet1.Range("CT" & ultimalinha).Value2 + Globals.Sheet1.Range("CU" & ultimalinha).Value2
                    Loop
                Catch ex As Exception
                    Globals.Sheet1.Range("Y" & ultimalinha).Value2 = Nothing
                    Globals.Sheet1.Range("CT" & ultimalinha).Value2 = Nothing
                    Globals.Sheet1.Range("CU" & ultimalinha).Value2 = Nothing
                End Try


                ''''Forecast e target
                Dim mySelectQueryVol9LFore As String
                mySelectQueryVol9LFore = "SELECT SUM(FORECA) FROM sapsales WHERE (invclientnum = '" & clientfact & "') AND (finalclientnum = '" & clientdest & "') AND ([Material Number] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year & "'"
                Dim myCommandVol9LFore As New SQLiteCommand(mySelectQueryVol9LFore, myConnectionPricing)

                Dim retVol9LFore As String
                Try

                    retVol9LFore = myCommandVol9LFore.ExecuteScalar
                    If Not retVol9LFore Is DBNull.Value Then Globals.Sheet1.Range("V" & ultimalinha).Value2 = CDec(retVol9LFore) Else Globals.Sheet1.Range("V" & ultimalinha).Value2 = Nothing
                Catch ex As Exception
                    Globals.Sheet1.Range("V" & ultimalinha).Value2 = Nothing
                End Try

                Dim mySelectQueryVol9LForem As String
                mySelectQueryVol9LForem = "SELECT SUM(FORECM) FROM sapsales WHERE (invclientnum = '" & clientfact & "') AND (finalclientnum = '" & clientdest & "') AND ([Material Number] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year & "'"
                Dim myCommandVol9LForeM As New SQLiteCommand(mySelectQueryVol9LForem, myConnectionPricing)
                'Dim retVol9LFore As SQLiteDataReader
                Dim retVol9LForeM As String
                Try
                    retVol9LForeM = myCommandVol9LForeM.ExecuteScalar
                    If Not (retVol9LForeM) Is DBNull.Value Then Globals.Sheet1.Range("Z" & ultimalinha).Value2 = CDec(retVol9LForeM) Else Globals.Sheet1.Range("Z" & ultimalinha).Value2 = Nothing
                Catch ex As Exception

                    Globals.Sheet1.Range("Z" & ultimalinha).Value2 = Nothing
                End Try



                ''''Last Year
                Dim mySelectQueryVol9L3 As String
                mySelectQueryVol9L3 = "SELECT SUM(SHIPPED) as exp1 FROM sapsalesforpricing WHERE (invclientnum = '" & clientfact & "') AND (finalclientnum = '" & clientdest & "') AND ([Immaterial] = '" & myReader1("PCCPRO") & "') AND ([Price List] = '" & pricelist & "') AND (Currency = '" & Currency & "') AND Year = '" & Now.Year - 1 & "'"
                Dim myCommandVol9L3 As New SQLiteCommand(mySelectQueryVol9L3, myConnectionPricing)
                Dim retVol9L3 As String
                Try
                    retVol9L3 = myCommandVol9L3.ExecuteScalar
                    If Not (retVol9L3) Is DBNull.Value Then Globals.Sheet1.Range("W" & ultimalinha).Value2 = CDec(retVol9L3) Else Globals.Sheet1.Range("W" & ultimalinha).Value2 = Nothing
                Catch
                    Globals.Sheet1.Range("W" & ultimalinha).Value2 = Nothing
                End Try

            End If

            ' '''''FIM LINHA VOLUMES(9L)
            ' '''''FIM LINHA VOLUMES(9L)
            ' '''''FIM LINHA VOLUMES(9L)


            '''''INICIO LINHA 2 Product
            '''''INICIO LINHA 2 Product
            '''''INICIO LINHA 2 Product
            Globals.Sheet1.Range("AC" & ultimalinha).Value2 = (myReader1("PCCPRO"))


            'Dim mySelectQueryEMBALLITRO As String
            'mySelectQueryEMBALLITRO = "SELECT LTS FROM SAPEMBALAGENS where IND='" & retEMBAL & "'"
            'Dim myCommandEMBALLITRO As New SQLiteCommand(mySelectQueryEMBALLITRO, myConnectionPricing)
            Dim retEMBALLITRO As Decimal
            '  retEMBALLITRO = myCommandEMBALLITRO.ExecuteScalar
            retEMBALLITRO = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("LTS")
            Globals.Sheet1.Range("AD" & ultimalinha).Value2 = (retEMBALLITRO)

            'Dim mySelectQueryEMBALCAP As String
            'mySelectQueryEMBALCAP = "SELECT cap FROM SAPEMBALAGENS where ind='" & retEMBAL & "'"
            'Dim myCommandEMBALCAP As New SQLiteCommand(mySelectQueryEMBALCAP, myConnectionPricing)
            Dim retEMBALCAP As Decimal
            'retEMBALCAP = myCommandEMBALCAP.ExecuteScalar
            retEMBALCAP = Me.SapPricingDataset11.SapMateriaisQuery.Rows(0).Item("cap")
            Try
                If retEMBALCAP <> 0 Then
                    Globals.Sheet1.Range("AE" & ultimalinha).Value2 = (retEMBALLITRO / retEMBALCAP)
                    Globals.Sheet1.Range("E" & ultimalinha).Value2 = Globals.Sheet1.Range("F" & ultimalinha).Value2 / Globals.Sheet1.Range("AE" & ultimalinha).Value2

                Else
                    Globals.Sheet1.Range("AE" & ultimalinha).Value2 = "n/a"
                    Globals.Sheet1.Range("E" & ultimalinha).Value2 = "n/a"
                End If
            Catch
                Globals.Sheet1.Range("AE" & ultimalinha).Value2 = "n/a"
                Globals.Sheet1.Range("E" & ultimalinha).Value2 = "n/a"
            End Try

            '''''FIM LINHA 2 Product
            '''''FIM LINHA 2 Product
            '''''FIM LINHA 2 Product


            '''''INICIO LINHA 2 OFF INVOICE SUPPORT
            '''''INICIO LINHA 2 OFF INVOICE SUPPORT
            '''''INICIO LINHA 2 OFF INVOICE SUPPORT

            If IsDBNull(myReader1("ZDEV")) = False Then
                Globals.Sheet1.Range("AF" & ultimalinha).Value2 = myReader1("ZDEV")
            Else
                Globals.Sheet1.Range("AF" & ultimalinha).Value2 = ""
            End If

            If IsNumeric(myReader1("ZDEP")) Then
                Globals.Sheet1.Range("AG" & ultimalinha).Value2 = myReader1("ZDEP") / 10
            Else
                Globals.Sheet1.Range("AG" & ultimalinha).Value2 = ""

            End If

            If IsDBNull(myReader1("ZDQV")) = False Then
                Globals.Sheet1.Range("AH" & ultimalinha).Value2 = myReader1("ZDQV")
            Else
                Globals.Sheet1.Range("AH" & ultimalinha).Value2 = ""

            End If

            If IsNumeric(myReader1("ZDQP")) Then
                Globals.Sheet1.Range("AI" & ultimalinha).Value2 = myReader1("ZDQP") / 10
            Else
                Globals.Sheet1.Range("AI" & ultimalinha).Value2 = ""

            End If

            If IsDBNull(myReader1("ZDPV")) = False Then
                Globals.Sheet1.Range("AJ" & ultimalinha).Value2 = myReader1("ZDPV")
            Else
                Globals.Sheet1.Range("AJ" & ultimalinha).Value2 = ""

            End If

            If IsNumeric(myReader1("ZDPP")) Then
                Globals.Sheet1.Range("AK" & ultimalinha).Value2 = myReader1("ZDPP") / 10
            Else
                Globals.Sheet1.Range("AK" & ultimalinha).Value2 = ""

            End If

            If IsDBNull(myReader1("ZDRV")) = False Then
                Globals.Sheet1.Range("AL" & ultimalinha).Value2 = myReader1("ZDRV")
            Else
                Globals.Sheet1.Range("AL" & ultimalinha).Value2 = ""

            End If

            If IsNumeric(myReader1("ZDRP")) Then
                Globals.Sheet1.Range("AM" & ultimalinha).Value2 = myReader1("ZDRP") / 10
            Else
                Globals.Sheet1.Range("AM" & ultimalinha).Value2 = ""

            End If

            If IsDBNull(myReader1("ZDLV")) = False Then
                Globals.Sheet1.Range("AN" & ultimalinha).Value2 = myReader1("ZDLV")
            Else
                Globals.Sheet1.Range("AN" & ultimalinha).Value2 = ""

            End If

            If IsNumeric(myReader1("ZDLP")) Then
                Globals.Sheet1.Range("AO" & ultimalinha).Value2 = myReader1("ZDLP") / 10
            Else
                Globals.Sheet1.Range("AO" & ultimalinha).Value2 = ""

            End If

            If IsDBNull(myReader1("ZDTV")) = False Then
                Globals.Sheet1.Range("AP" & ultimalinha).Value2 = myReader1("ZDTV")
            Else
                Globals.Sheet1.Range("AP" & ultimalinha).Value2 = ""

            End If

            If IsNumeric(myReader1("ZDTP")) Then
                Globals.Sheet1.Range("AQ" & ultimalinha).Value2 = myReader1("ZDTP") / 10
            Else
                Globals.Sheet1.Range("AQ" & ultimalinha).Value2 = ""

            End If



            '''''FIM LINHA 2 OFF INVOICE SUPPORT
            '''''FIM LINHA 2 OFF INVOICE SUPPORT
            '''''FIM LINHA 2 OFF INVOICE SUPPORT

            '''''INICIO LINHA 2 EXTRAS ON INVOICE
            '''''INICIO LINHA 2 EXTRAS ON INVOICE
            '''''INICIO LINHA 2 EXTRAS ON INVOICE
            If IsDBNull(myReader1("ZEEC")) = False Then Globals.Sheet1.Range("AR" & ultimalinha).Value2 = myReader1("ZEEC") Else Globals.Sheet1.Range("AR" & ultimalinha).Value2 = ""
            If IsDBNull(myReader1("ZEFR")) = False Then Globals.Sheet1.Range("AS" & ultimalinha).Value2 = myReader1("ZEFR") Else Globals.Sheet1.Range("AS" & ultimalinha).Value2 = ""
            If IsDBNull(myReader1("ZEIN")) = False Then Globals.Sheet1.Range("AT" & ultimalinha).Value2 = myReader1("ZEIN") Else Globals.Sheet1.Range("AT" & ultimalinha).Value2 = ""
            If IsDBNull(myReader1("ZEFI")) = False Then Globals.Sheet1.Range("AU" & ultimalinha).Value2 = myReader1("ZEFI") Else Globals.Sheet1.Range("AU" & ultimalinha).Value2 = ""
            If IsDBNull(myReader1("ZESL")) = False Then Globals.Sheet1.Range("AV" & ultimalinha).Value2 = myReader1("ZESL") Else Globals.Sheet1.Range("AV" & ultimalinha).Value2 = ""
            If IsDBNull(myReader1("ZESP")) = False Then Globals.Sheet1.Range("AW" & ultimalinha).Value2 = myReader1("ZESP") Else Globals.Sheet1.Range("AW" & ultimalinha).Value2 = ""
            '''''FIM LINHA 2 EXTRAS ON INVOICE
            '''''FIM LINHA 2 EXTRAS ON INVOICE
            '''''FIM LINHA 2 EXTRAS ON INVOICE


            '''''INICIO LINHA 2 MOQ
            '''''INICIO LINHA 2 MOQ
            '''''INICIO LINHA 2 MOQ
            'Globals.Sheet1.Range("BS" & ultimalinha).Value2 = (myReader1("PCMOQ"))
            '''''FIM LINHA 2 MOQ
            '''''FIM LINHA 2 MOQ
            '''''FIM LINHA 2 MOQ
            '''''INICIO LINHA 2 PCMARK
            '''''INICIO LINHA 2 PCMARK
            '''''INICIO LINHA 2 PCMARK
            'Globals.Sheet1.Range("BT" & ultimalinha).Value2 = (myReader1("PCMARK"))
            '''''FIM LINHA 2 PCMARK
            '''''FIM LINHA 2 PCMARK
            '''''FIM LINHA 2 PCMARK

            '''''INICIO LINHA 2 DSQ
            '''''INICIO LINHA 2 DSQ
            '''''INICIO LINHA 2 DSQ
            'If IsDBNull(myReader1("PCBDSQ")) = False Then Globals.Sheet1.Range("BU" & ultimalinha).Value2 = (myReader1("PCBDSQ")) Else Globals.Sheet1.Range("BU" & ultimalinha).Value2 = ""
            'If IsDBNull(myReader1("PCVDSQ")) = False Then Globals.Sheet1.Range("BV" & ultimalinha).Value2 = (myReader1("PCVDSQ")) Else Globals.Sheet1.Range("BV" & ultimalinha).Value2 = ""
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
        Dim mySelectQueryVol9LBM As String = "SELECT SUM(FORECA) as exp1, SUM(SHIPHAND) as exp2, SUM(FORECM) as exp3 FROM sapsales WHERE familia = 'Crusted' AND COMPANY = '" & company & "' AND TIPO like '%" & tipo & "%' AND " & querystring & " AND Year = '" & Now.Year & "'"
        Dim myCommandVol9LBM As New SQLiteCommand(mySelectQueryVol9LBM, myConnectionPricing)
        Dim retVol9LBM As SQLiteDataReader
        Try
            retVol9LBM = myCommandVol9LBM.ExecuteReader(CommandBehavior.SingleRow)
            Do While retVol9LBM.Read
                If Not (retVol9LBM(0)) Is DBNull.Value Then Globals.Sheet1.Range("X6").Value2 = CDec(retVol9LBM(0))
                If Not (retVol9LBM(1)) Is DBNull.Value Then Globals.Sheet1.Range("Y6").Value2 = CDec(retVol9LBM(1))
                If Not (retVol9LBM(2)) Is DBNull.Value Then Globals.Sheet1.Range("Z6").Value2 = CDec(retVol9LBM(2))
            Loop
        Catch
            Globals.Sheet1.Range("X6").Value2 = 0
            Globals.Sheet1.Range("Y6").Value2 = 0
            Globals.Sheet1.Range("Z6").Value2 = 0
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
                If Not (retVol9LBMLBV(0)) Is DBNull.Value Then Globals.Sheet1.Range("X7").Value2 = CDec(retVol9LBMLBV(0))
                If Not (retVol9LBMLBV(1)) Is DBNull.Value Then Globals.Sheet1.Range("Y7").Value2 = CDec(retVol9LBMLBV(1))
                If Not (retVol9LBMLBV(2)) Is DBNull.Value Then Globals.Sheet1.Range("Z7").Value2 = CDec(retVol9LBMLBV(2))
            Loop
        Catch
            Globals.Sheet1.Range("X7").Value2 = 0
            Globals.Sheet1.Range("Y7").Value2 = 0
            Globals.Sheet1.Range("Z7").Value2 = 0
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
                If Not (retVol9LBMquintas(0)) Is DBNull.Value Then Globals.Sheet1.Range("X8").Value2 = CDec(retVol9LBMquintas(0))
                If Not (retVol9LBMquintas(1)) Is DBNull.Value Then Globals.Sheet1.Range("Y8").Value2 = CDec(retVol9LBMquintas(1))
                If Not (retVol9LBMquintas(2)) Is DBNull.Value Then Globals.Sheet1.Range("Z8").Value2 = CDec(retVol9LBMquintas(2))
            Loop
        Catch
            Globals.Sheet1.Range("X8").Value2 = 0
            Globals.Sheet1.Range("Y8").Value2 = 0
            Globals.Sheet1.Range("Z8").Value2 = 0
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
                If Not (retVol9LBMvintage(0)) Is DBNull.Value Then Globals.Sheet1.Range("X9").Value2 = CDec(retVol9LBMvintage(0))
                If Not (retVol9LBMvintage(1)) Is DBNull.Value Then Globals.Sheet1.Range("Y9").Value2 = CDec(retVol9LBMvintage(1))
                If Not (retVol9LBMvintage(2)) Is DBNull.Value Then Globals.Sheet1.Range("Z9").Value2 = CDec(retVol9LBMvintage(2))
            Loop

        Catch
            Globals.Sheet1.Range("X9").Value2 = 0
            Globals.Sheet1.Range("Y9").Value2 = 0
            Globals.Sheet1.Range("Z9").Value2 = 0
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
            formulaX15 = "=ABS(IF(BU24=0,0,BZ24*BV24/(BV24+BU24))*(Y24*9/AD24))"
            Dim formulaZ14 As String = ""
            formulaZ14 = "=ABS(((AX24+AZ24+BI24)/AD24*9*Y24)+((BZ24*((BA24+AY24+BJ24)/100)))/AD24*9*Y24)"
            Dim formulaZ15 As String = ""
            formulaZ15 = "=ABS((BD24/AD24*9*Y24)+((BZ24*((BE24)/100))/AD24*9*Y24))"
            Dim formulaZ16 As String = ""
            formulaZ16 = "=ABS(BF24/AD24*9*Y24)"
            Dim formulaZ17 As String = ""
            formulaZ17 = "=ABS((BB24/AD24*9*Y24)+((BZ24*((BC24)/100))/AD24*9*Y24))"

            For X = 25 To ultimalinha - 1
                If Globals.Sheet1.Range("F" & X).Value2 <> 0 And Globals.Sheet1.Range("AD" & X).Value2 <> 0 Then
                    formulaX14 = formulaX14 & "+ABS(((AF" & X & "+AH" & X & "+AJ" & X & "+AL" & X & "+AN" & X & "+AP" & X & ")/AD" & X & "*9*Y" & X & ")+((F" & X & "*((K" & X & "/100))/AD" & X & "*9*Y" & X & ")))"
                    formulaX15 = formulaX15 & "+ABS(IF(BU" & X & "=0,0,BZ" & X & "*BV" & X & "/(BV" & X & "+BU" & X & "))*(Y" & X & "*9/AD" & X & "))"
                    formulaZ14 = formulaZ14 & "+ABS(((AX" & X & "+AZ" & X & "+BI" & X & ")/AD" & X & "*9*Y" & X & ")+((BZ" & X & "*((BA" & X & "+AY" & X & "+BJ" & X & ")/100)))/AD" & X & "*9*Y" & X & ")"
                    formulaZ15 = formulaZ15 & "+ABS((BD" & X & "/AD" & X & "*9*Y" & X & ")+((BZ" & X & "*((BE" & X & ")/100))/AD" & X & "*9*Y" & X & "))"
                    formulaZ16 = formulaZ16 & "+ABS(BF" & X & "/AD" & X & "*9*Y" & X & ")"
                    formulaZ17 = formulaZ17 & "+ABS((BB" & X & "/AD" & X & "*9*Y" & X & ")+((BZ" & X & "*((BC" & X & ")/100))/AD" & X & "*9*Y" & X & "))"
                End If
            Next
            Globals.Sheet1.Range("X14").Value2 = formulaX14
            Globals.Sheet1.Range("X15").Value2 = formulaX15
            Globals.Sheet1.Range("Z14").Value2 = formulaZ14
            Globals.Sheet1.Range("Z15").Value2 = formulaZ15
            Globals.Sheet1.Range("Z16").Value2 = formulaZ16
            Globals.Sheet1.Range("Z17").Value2 = formulaZ17
        Catch ex As Exception
            MsgBox("Too many products to calculate SUPPORT TOTALS in Excel")
        End Try

        '''''Forecast
        Try
            Dim formulaS14 As String = ""
            formulaS14 = "=ABS(((AF24+AH24+AJ24+AL24+AN24+AP24)/AD24*9*Z24)+((F24*((K24/100))/AD24*9*Z24)))"
            Dim formulaS15 As String = ""
            formulaS15 = "=ABS(IF(BU24=0,0,BZ24*BV24/(BV24+BU24))*(Z24*9/AD24))"
            Dim formulaU14 As String = ""
            formulaU14 = "=ABS(((AX24+AZ24+BI24)/AD24*9*Z24)+((BZ24*((BA24+AY24+BJ24)/100)))/AD24*9*Z24)"
            Dim formulaU15 As String = ""
            formulaU15 = "=ABS((BD24/AD24*9*Z24)+((BZ24*((BE24)/100))/AD24*9*Z24))"
            Dim formulaU16 As String = ""
            formulaU16 = "=ABS(BF24/AD24*9*Z24)"
            Dim formulaU17 As String = ""
            formulaU17 = "=ABS((BB24/AD24*9*Z24)+((BZ24*((BC24)/100))/AD24*9*Z24))"

            For X = 25 To ultimalinha - 1
                If Globals.Sheet1.Range("F" & X).Value2 <> 0 And Globals.Sheet1.Range("AD" & X).Value2 <> 0 Then
                    formulaS14 = formulaS14 & "+ABS(((AF" & X & "+AH" & X & "+AJ" & X & "+AL" & X & "+AN" & X & "+AP" & X & ")/AD" & X & "*9*Z" & X & ")+((F" & X & "*((K" & X & "/100))/AD" & X & "*9*Z" & X & ")))"
                    formulaS15 = formulaS15 & "+ABS(IF(BU" & X & "=0,0,BZ" & X & "*BV" & X & "/(BV" & X & "+BU" & X & "))*(Z" & X & "*9/AD" & X & "))"
                    formulaU14 = formulaU14 & "+ABS(((AX" & X & "+AZ" & X & "+BI" & X & ")/AD" & X & "*9*Z" & X & ")+((BZ" & X & "*((BA" & X & "+AY" & X & "+BJ" & X & ")/100)))/AD" & X & "*9*Z" & X & ")"
                    formulaU15 = formulaU15 & "+ABS((BD" & X & "/AD" & X & "*9*Z" & X & ")+((BZ" & X & "*((BE" & X & ")/100))/AD" & X & "*9*ZY" & X & "))"
                    formulaU16 = formulaU16 & "+ABS(BF" & X & "/AD" & X & "*9*Z" & X & ")"
                    formulaU17 = formulaU17 & "+ABS((BB" & X & "/AD" & X & "*9*Z" & X & ")+((BZ" & X & "*((BC" & X & ")/100))/AD" & X & "*9*Z" & X & "))"
                End If
            Next
            Globals.Sheet1.Range("S14").Value2 = formulaS14
            Globals.Sheet1.Range("S15").Value2 = formulaS15
            Globals.Sheet1.Range("U14").Value2 = formulaU14
            Globals.Sheet1.Range("U15").Value2 = formulaU15
            Globals.Sheet1.Range("U16").Value2 = formulaU16
            Globals.Sheet1.Range("U17").Value2 = formulaU17
        Catch ex As Exception
            MsgBox("Too many products to calculate SUPPORT TOTALS in Excel")
        End Try

        '''''TARGET
        Try
            Dim formulaS5 As String = ""
            formulaS5 = "=ABS(((AF24+AH24+AJ24+AL24+AN24+AP24)/AD24*9*V24)+((F24*((K24/100))/AD24*9*V24)))"
            Dim formulaS6 As String = ""
            formulaS6 = "=ABS(IF(BU24=0,0,BZ24*BV24/(BV24+BU24))*(V24*9/AD24))"
            Dim formulaU5 As String = ""
            formulaU5 = "=ABS(((AX24+AZ24+BI24)/AD24*9*V24)+((BZ24*((BA24+AY24+BJ24)/100)))/AD24*9*V24)"
            Dim formulaU6 As String = ""
            formulaU6 = "=ABS((BD24/AD24*9*V24)+((BZ24*((BE24)/100))/AD24*9*V24))"
            Dim formulaU7 As String = ""
            formulaU7 = "=ABS(BF24/AD24*9*V24)"
            Dim formulaU8 As String = ""
            formulaU8 = "=ABS((BB24/AD24*9*V24)+((BZ24*((BC24)/100))/AD24*9*V24))"

            For X = 25 To ultimalinha - 1
                If Globals.Sheet1.Range("F" & X).Value2 <> 0 And Globals.Sheet1.Range("AD" & X).Value2 <> 0 Then
                    formulaS5 = formulaS5 & "+ABS(((AF" & X & "+AH" & X & "+AJ" & X & "+AL" & X & "+AN" & X & "+AP" & X & ")/AD" & X & "*9*V" & X & ")+((F" & X & "*((K" & X & "/100))/AD" & X & "*9*V" & X & ")))"
                    formulaS6 = formulaS6 & "+ABS(IF(BU" & X & "=0,0,BZ" & X & "*BV" & X & "/(BV" & X & "+BU" & X & "))*(V" & X & "*9/AD" & X & "))"
                    formulaU5 = formulaU5 & "+ABS(((AX" & X & "+AZ" & X & "+BI" & X & ")/AD" & X & "*9*V" & X & ")+((BZ" & X & "*((BA" & X & "+AY" & X & "+BJ" & X & ")/100)))/AD" & X & "*9*V" & X & ")"
                    formulaU6 = formulaU6 & "+ABS((BD" & X & "/AD" & X & "*9*V" & X & ")+((BZ" & X & "*((BE" & X & ")/100))/AD" & X & "*9*ZY" & X & "))"
                    formulaU7 = formulaU7 & "+ABS(BF" & X & "/AD" & X & "*9*V" & X & ")"
                    formulaU8 = formulaU8 & "+ABS((BB" & X & "/AD" & X & "*9*V" & X & ")+((BZ" & X & "*((BC" & X & ")/100))/AD" & X & "*9*V" & X & "))"
                End If
            Next
            Globals.Sheet1.Range("S5").Value2 = formulaS5
            Globals.Sheet1.Range("S6").Value2 = formulaS6
            Globals.Sheet1.Range("U5").Value2 = formulaU5
            Globals.Sheet1.Range("U6").Value2 = formulaU6
            Globals.Sheet1.Range("U7").Value2 = formulaU7
            Globals.Sheet1.Range("U8").Value2 = formulaU8
        Catch ex As Exception
            MsgBox("Too many products to calculate SUPPORT TOTALS in Excel")
        End Try


        '''''FIM SUPPORT TOTALS
        '''''FIM SUPPORT TOTALS
        '''''FIM SUPPORT TOTALS


        '''''INICIO Sales Data Analysis
        '''''INICIO Sales Data Analysis
        '''''INICIO Sales Data Analysis
        Try

            Globals.Sheet1.Range("L5").Value2 = "=SUM(W24:W" & ultimalinha - 1 & ")"
            Globals.Sheet1.Range("L6").Value2 = "=SUM(V24:V" & ultimalinha - 1 & ")"
            Globals.Sheet1.Range("L7").Value2 = "=SUM(Z24:Z" & ultimalinha - 1 & ")"
            Globals.Sheet1.Range("L8").Value2 = "=SUM(CT24:CT" & ultimalinha - 1 & ")"
            Globals.Sheet1.Range("L9").Value2 = "=SUM(CU24:CU" & ultimalinha - 1 & ")"

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
                If Globals.Sheet1.Range("AD" & X).Value2 <> 0 Then
                    formulaN5 = formulaN5 & "+(CB" & X & "/AD" & X & "*9*W" & X & "/M18)"
                    formulaN6 = formulaN6 & "+(CB" & X & "/AD" & X & "*9*V" & X & "/M18)"
                    formulaN7 = formulaN7 & "+(CB" & X & "/AD" & X & "*9*Z" & X & "/M18)"
                    formulaN8 = formulaN8 & "+(CB" & X & "/AD" & X & "*9*CT" & X & "/M18)"
                    formulaN9 = formulaN9 & "+(CB" & X & "/AD" & X & "*9*CU" & X & "/M18)"
                End If
            Next
            Globals.Sheet1.Range("N5").Value2 = formulaN5
            Globals.Sheet1.Range("N6").Value2 = formulaN6
            Globals.Sheet1.Range("N7").Value2 = formulaN7
            Globals.Sheet1.Range("N8").Value2 = formulaN8
            Globals.Sheet1.Range("N9").Value2 = formulaN9
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
            formulaN14 = "=IF(ISERROR(" & formulaN14 & "),0," & formulaN14 & ")"


            formulaO14 = formulaO14 & ")/L6"
            formulaO14 = "=IF(ISERROR(" & formulaO14 & "),0," & formulaO14 & ")"


            formulaP14 = formulaP14 & ")/L7"
            formulaP14 = "=IF(ISERROR(" & formulaP14 & "),0," & formulaP14 & ")"


            Globals.Sheet1.Range("N14").Value2 = formulaN14
            Globals.Sheet1.Range("O14").Value2 = formulaO14
            Globals.Sheet1.Range("P14").Value2 = formulaP14
          

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
                If Globals.Sheet1.Range("AD" & X).Value2 <> 0 Then
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


            Globals.Sheet1.Range("H13").Value2 = formulaH13
            Globals.Sheet1.Range("H14").Value2 = formulaH14
            Globals.Sheet1.Range("H15").Value2 = formulaH15
            Globals.Sheet1.Range("H16").Value2 = formulaH16

        Catch ex As Exception
            MsgBox("Too many products to calculate NOTES in Excel")
        End Try
        '''''FIM Notes
        '''''FIM Notes
        '''''FIM Notes


        For Each linhaproduto In linhasprodutopai
            Globals.Sheet1.Range(linhaproduto).Borders.ColorIndex = 10
            Globals.Sheet1.Range(linhaproduto).Interior.ColorIndex = 43
            Globals.Sheet1.Range(linhaproduto).Font.Bold = True
        Next


        'cells.DeleteRow(23 + count)
        Globals.Sheet1.PageSetup.PrintArea = "A1:Z" & ultimalinha - 1
        Globals.Sheet1.filterkeycompany = filterkeycomp
        Globals.Sheet1.filterkeytipo = filterkeytipo
        Globals.Sheet1.ready = True
        Globals.Sheet1.Protect("password2", , , , , True, True, True, , , , , , , , )
        myReader1.Close()

        ''''''''''''
        ''''''''''''''
        ''''''''''''''''
        '''''''''''''''
        ''''''''''''''

        Globals.ThisWorkbook.Application.EnableEvents = True
        Globals.Sheet1.EnableCalculation = True


        myConnectionPricing.Close()

        '  createPalletes(director, pais, clientfact, clientdest, company, tipo, pricelist, PCDATI, PCDATF, Currency)


        Me.Close()


    End Sub

 


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged

        Dim varquery As String
        LabelPriceOption.Text = ComboBoxEdit1.Properties.Items(ComboBoxEdit1.SelectedIndex).Description

        Dim strsql As String
        Select Case ComboBoxEdit1.SelectedIndex
            Case 0
                filterkeyPricing = "933"
                varquery = "query1"
                strsql = "SELECT MARKETDIRECTOR as director, LANDX50 as Pais, PCCCLI as CliFact, PCCLID as CliDest, WGBEZ60 as Company, TIPO, PCTPRE as PriceList, PCDATI, PCDATF, PCMOED as Currency FROM " & varquery & " WHERE tabela='" & filterkeyPricing & "'  AND (NOT (WGBEZ60 = 'Não Relevante'))"

                '''''excepção
                'Dim utilizador As String
                'utilizador = UCase(GetSetting("SalesReports", "User", "login"))
                'If utilizador = "SYMINGTON\PAM" Then
                '    strsql = "SELECT MARKETDIRECTOR as director, LANDX50 as Pais, PCCCLI as CliFact, PCCLID as CliDest, WGBEZ60 as Company, TIPO, PCTPRE as PriceList, PCDATI, PCDATF, PCMOED as Currency FROM " & varquery & " WHERE tabela='" & filterkeyPricing & "'  AND (NOT (WGBEZ60 = 'Não Relevante')) AND (PCCLID = '0000000543' OR PCCLID = '0000007190' OR PCCLID = '0000008570')"
                'End If
            Case 1
                filterkeyPricing = "934"
                varquery = "query1CliFact"
                strsql = "SELECT MARKETDIRECTOR as director, LANDX50 as Pais, PCCCLI as CliFact, PCCCLI as CliDest, WGBEZ60 as Company, TIPO, PCTPRE as PriceList, PCDATI, PCDATF, PCMOED as Currency FROM " & varquery & "  WHERE tabela='" & filterkeyPricing & "'  AND (NOT (WGBEZ60 = 'Não Relevante'))"

                '''''excepção
                'Dim utilizador As String
                'utilizador = UCase(GetSetting("SalesReports", "User", "login"))
                'If utilizador = "SYMINGTON\PAM" Then
                '    strsql = "SELECT MARKETDIRECTOR as director, LANDX50 as Pais, PCCCLI as CliFact, PCCLID as CliDest, WGBEZ60 as Company, TIPO, PCTPRE as PriceList, PCDATI, PCDATF, PCMOED as Currency FROM " & varquery & " WHERE tabela='" & filterkeyPricing & "'  AND (NOT (WGBEZ60 = 'Não Relevante')) AND (PCCLID = '0000000543' OR PCCLID = '0000007190' OR PCCLID = '0000008570')"
                'End If
            Case 2
                filterkeyPricing = "936"
                varquery = "query1CliFact"
                strsql = "SELECT SapClients.MARKETDIRECTOR as director, SapClients.LANDX50 as Pais, Paprixf.PCCLID as CliFact, Paprixf.PCCLID as CliDest, SapMateriais.WGBEZ60 as Company, " _
                & "SapMateriais.NIV3 as TIPO, Paprixf.PCTPRE as PriceList, Paprixf.PCDATI, Paprixf.PCDATF, Paprixf.PCMOED as Currency FROM Paprixf LEFT OUTER JOIN " _
                & "SapClients ON Paprixf.PCCLID = SapClients.KUNNR LEFT OUTER JOIN SapMateriais ON Paprixf.PCCPRO = SapMateriais.MATNR WHERE (Paprixf.tabela = '936') AND (NOT (WGBEZ60 = 'Não Relevante'))"

                '''''excepção
                'Dim utilizador As String
                'utilizador = UCase(GetSetting("SalesReports", "User", "login"))
                'If utilizador = "SYMINGTON\PAM" Then
                '    strsql = "SELECT SapClients.MARKETDIRECTOR as director, SapClients.LANDX50 as Pais, Paprixf.PCCLID as CliFact, Paprixf.PCCLID as CliDest, SapMateriais.WGBEZ60 as Company, " _
                '    & "SapMateriais.NIV3 as TIPO, Paprixf.PCTPRE as PriceList, Paprixf.PCDATI, Paprixf.PCDATF, Paprixf.PCMOED as Currency FROM Paprixf LEFT OUTER JOIN " _
                '    & "SapClients ON Paprixf.PCCLID = SapClients.KUNNR LEFT OUTER JOIN SapMateriais ON Paprixf.PCCPRO = SapMateriais.MATNR WHERE (Paprixf.tabela = '936') AND (NOT (WGBEZ60 = 'Não Relevante'))  AND (Paprixf.PCCLID = '0000000543' OR Paprixf.PCCLID = '0000007190' OR Paprixf.PCCLID = '0000008570')"

                'End If
        End Select

        Dim reader As SQLiteDataReader = Nothing

        ds = New DataSet
        dsHelper = New DataSetHelper.DataSetHelper(ds)

        Dim sqlcommand1 As New SQLiteCommand ' OleDb.OleDbCommand
        Dim SqlConnection1 As New SQLiteConnection ' OleDb.OleDbConnection
        SqlConnection1.ConnectionString = My.Settings.PricingConnectionString
#Disable Warning BC42104 ' Variable 'strsql' is used before it has been assigned a value. A null reference exception could result at runtime.
        sqlcommand1.CommandText = strsql
#Enable Warning BC42104 ' Variable 'strsql' is used before it has been assigned a value. A null reference exception could result at runtime.
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        Dim tabela As New DataTable
        tabela.Columns.Add("director", Type.GetType("System.String"))
        tabela.Columns.Add("pais", Type.GetType("System.String"))
        tabela.Columns.Add("clifact", Type.GetType("System.String"))
        tabela.Columns.Add("clidest", Type.GetType("System.String"))
        tabela.Columns.Add("company", Type.GetType("System.String"))
        tabela.Columns.Add("tipo", Type.GetType("System.String"))
        tabela.Columns.Add("pricelist", Type.GetType("System.String"))
        tabela.Columns.Add("PCDATI", Type.GetType("System.String"))
        tabela.Columns.Add("PCDATF", Type.GetType("System.String"))
        tabela.Columns.Add("Currency", Type.GetType("System.String"))


        Dim myRow As DataRow

        reader = sqlcommand1.ExecuteReader



        While reader.Read
            myRow = tabela.NewRow()
            myRow("director") = reader.Item(0)
            myRow("pais") = reader.Item(1)
            myRow("clifact") = reader.Item(2)
            myRow("clidest") = reader.Item(3)
            myRow("company") = reader.Item(4)
            myRow("tipo") = reader.Item(5)
            myRow("pricelist") = reader.Item(6)
            myRow("PCDATI") = reader.Item(7)
            myRow("PCDATF") = reader.Item(8)
            myRow("Currency") = reader.Item(9)

            tabela.Rows.Add(myRow)
        End While

        ds.Tables.Add(tabela)
        reader.Close()
        SqlConnection1.Close()

        treefill(-1)

        PopupContainerEdit1.ClosePopup()
    End Sub
End Class
