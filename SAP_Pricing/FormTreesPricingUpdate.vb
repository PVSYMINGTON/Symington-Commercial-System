

Imports System.Windows.Forms
Imports System.Data.SQLite


Public Class FormTreesPricingUpdate

    Inherits DevExpress.XtraEditors.XtraForm


    Dim filterkeydir As String
    Dim filterkeypais As String
    Dim filterkeyclifact As String
    Dim filterkeyclidest As String
    Dim filterkeycomp As String
    Dim filterkeytipo As String
    Dim filterkeypricelist As String
    Dim filterkeyPCDATI As String
    Dim filterkeyPCDATF As String
    Dim filterkeyCurrency As String
    ''Dim filterkeyPricing As String = "933" FUSÂO
    Dim filterkeyPricing As String = "943"
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
    Friend WithEvents SapMateriaisQueryTableAdapter1 As SapCSDataSetTableAdapters.Query1TableAdapter
    Friend WithEvents SapPricingDataset11 As SapCSDataSet
    Friend WithEvents SapTipoListaPrecosTableAdapter As SapCSDataSetTableAdapters.SapTipoListaPrecosTableAdapter
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
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
        Me.SapMateriaisQueryTableAdapter1 = New SAP_Pricing.SapCSDataSetTableAdapters.Query1TableAdapter()
        Me.SapPricingDataset11 = New SAP_Pricing.SapCSDataSet()
        Me.SapTipoListaPrecosTableAdapter = New SAP_Pricing.SapCSDataSetTableAdapters.SapTipoListaPrecosTableAdapter()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
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
        Me.Command3.Size = New System.Drawing.Size(72, 69)
        Me.Command3.TabIndex = 8
        Me.Command3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SAP_Pricing.My.Resources.Resources.hana_icon
        Me.PictureBox1.Location = New System.Drawing.Point(510, 600)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 93)
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.SAP_Pricing.My.Resources.Resources.SFE_Logo_Principal
        Me.PictureBox2.Location = New System.Drawing.Point(331, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(358, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = Global.SAP_Pricing.My.Resources.Resources.PricingCommercialsystembarra
        Me.PictureBox3.Location = New System.Drawing.Point(744, 600)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(292, 93)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox8.Location = New System.Drawing.Point(0, 580)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(1037, 113)
        Me.PictureBox8.TabIndex = 27
        Me.PictureBox8.TabStop = False
        '
        'TreeView1a
        '
        Me.TreeView1a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView1a.Appearance.Row.Options.UseTextOptions = True
        Me.TreeView1a.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TreeView1a.FixedLineWidth = 1
        Me.TreeView1a.Location = New System.Drawing.Point(18, 109)
        Me.TreeView1a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView1a.MinWidth = 16
        Me.TreeView1a.Name = "TreeView1a"
        Me.TreeView1a.OptionsBehavior.Editable = False
        Me.TreeView1a.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView1a.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView1a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView1a.OptionsSelection.InvertSelection = True
        Me.TreeView1a.OptionsView.ShowHorzLines = False
        Me.TreeView1a.OptionsView.ShowIndicator = False
        Me.TreeView1a.OptionsView.ShowVertLines = False
        Me.TreeView1a.Size = New System.Drawing.Size(199, 224)
        Me.TreeView1a.TabIndex = 56
        '
        'TreeView4a
        '
        Me.TreeView4a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView4a.FixedLineWidth = 1
        Me.TreeView4a.Location = New System.Drawing.Point(699, 109)
        Me.TreeView4a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView4a.MinWidth = 16
        Me.TreeView4a.Name = "TreeView4a"
        Me.TreeView4a.OptionsBehavior.Editable = False
        Me.TreeView4a.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView4a.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView4a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView4a.OptionsSelection.InvertSelection = True
        Me.TreeView4a.OptionsView.ShowHorzLines = False
        Me.TreeView4a.OptionsView.ShowIndicator = False
        Me.TreeView4a.OptionsView.ShowVertLines = False
        Me.TreeView4a.Size = New System.Drawing.Size(285, 224)
        Me.TreeView4a.TabIndex = 57
        '
        'PopupContainerEdit1
        '
        Me.PopupContainerEdit1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PopupContainerEdit1.EditValue = "Choose Pricing Option..."
        Me.PopupContainerEdit1.Location = New System.Drawing.Point(18, 81)
        Me.PopupContainerEdit1.Name = "PopupContainerEdit1"
        Me.PopupContainerEdit1.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupContainerEdit1.Properties.Appearance.Options.UseFont = True
        Me.PopupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PopupContainerEdit1.Properties.PopupControl = Me.PopupContainerControl1
        Me.PopupContainerEdit1.Size = New System.Drawing.Size(167, 20)
        Me.PopupContainerEdit1.TabIndex = 58
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(726, 173)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(232, 121)
        Me.PopupContainerControl1.TabIndex = 63
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(0, 0)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Final and Invoice Customer"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Invoice Customer"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Stats Customer")})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(232, 121)
        Me.ComboBoxEdit1.TabIndex = 50
        '
        'LabelPriceOption
        '
        Me.LabelPriceOption.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelPriceOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelPriceOption.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPriceOption.Location = New System.Drawing.Point(191, 82)
        Me.LabelPriceOption.Name = "LabelPriceOption"
        Me.LabelPriceOption.Size = New System.Drawing.Size(200, 16)
        Me.LabelPriceOption.TabIndex = 59
        Me.LabelPriceOption.Text = "Final and Invoice Customer"
        Me.LabelPriceOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TreeView3a
        '
        Me.TreeView3a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView3a.FixedLineWidth = 1
        Me.TreeView3a.Location = New System.Drawing.Point(405, 109)
        Me.TreeView3a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView3a.MinWidth = 16
        Me.TreeView3a.Name = "TreeView3a"
        Me.TreeView3a.OptionsBehavior.Editable = False
        Me.TreeView3a.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView3a.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView3a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView3a.OptionsSelection.InvertSelection = True
        Me.TreeView3a.OptionsView.ShowHorzLines = False
        Me.TreeView3a.OptionsView.ShowIndicator = False
        Me.TreeView3a.OptionsView.ShowVertLines = False
        Me.TreeView3a.Size = New System.Drawing.Size(285, 224)
        Me.TreeView3a.TabIndex = 65
        '
        'TreeView2a
        '
        Me.TreeView2a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView2a.FixedLineWidth = 1
        Me.TreeView2a.Location = New System.Drawing.Point(226, 109)
        Me.TreeView2a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView2a.MinWidth = 16
        Me.TreeView2a.Name = "TreeView2a"
        Me.TreeView2a.OptionsBehavior.Editable = False
        Me.TreeView2a.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView2a.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView2a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView2a.OptionsSelection.InvertSelection = True
        Me.TreeView2a.OptionsView.ShowColumns = False
        Me.TreeView2a.OptionsView.ShowHorzLines = False
        Me.TreeView2a.OptionsView.ShowIndicator = False
        Me.TreeView2a.OptionsView.ShowVertLines = False
        Me.TreeView2a.Size = New System.Drawing.Size(170, 224)
        Me.TreeView2a.TabIndex = 66
        '
        'TreeView9a
        '
        Me.TreeView9a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView9a.FixedLineWidth = 1
        Me.TreeView9a.Location = New System.Drawing.Point(691, 353)
        Me.TreeView9a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView9a.MinWidth = 16
        Me.TreeView9a.Name = "TreeView9a"
        Me.TreeView9a.OptionsBehavior.Editable = False
        Me.TreeView9a.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView9a.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView9a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView9a.OptionsSelection.InvertSelection = True
        Me.TreeView9a.OptionsView.ShowColumns = False
        Me.TreeView9a.OptionsView.ShowHorzLines = False
        Me.TreeView9a.OptionsView.ShowIndicator = False
        Me.TreeView9a.OptionsView.ShowVertLines = False
        Me.TreeView9a.Size = New System.Drawing.Size(145, 224)
        Me.TreeView9a.TabIndex = 71
        '
        'TreeView8a
        '
        Me.TreeView8a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView8a.FixedLineWidth = 1
        Me.TreeView8a.Location = New System.Drawing.Point(544, 353)
        Me.TreeView8a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView8a.MinWidth = 16
        Me.TreeView8a.Name = "TreeView8a"
        Me.TreeView8a.OptionsBehavior.Editable = False
        Me.TreeView8a.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView8a.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView8a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView8a.OptionsSelection.InvertSelection = True
        Me.TreeView8a.OptionsView.ShowColumns = False
        Me.TreeView8a.OptionsView.ShowHorzLines = False
        Me.TreeView8a.OptionsView.ShowIndicator = False
        Me.TreeView8a.OptionsView.ShowVertLines = False
        Me.TreeView8a.Size = New System.Drawing.Size(145, 224)
        Me.TreeView8a.TabIndex = 70
        '
        'TreeView7a
        '
        Me.TreeView7a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView7a.FixedLineWidth = 1
        Me.TreeView7a.Location = New System.Drawing.Point(397, 353)
        Me.TreeView7a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView7a.MinWidth = 16
        Me.TreeView7a.Name = "TreeView7a"
        Me.TreeView7a.OptionsBehavior.Editable = False
        Me.TreeView7a.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView7a.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView7a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView7a.OptionsSelection.InvertSelection = True
        Me.TreeView7a.OptionsView.ShowColumns = False
        Me.TreeView7a.OptionsView.ShowHorzLines = False
        Me.TreeView7a.OptionsView.ShowIndicator = False
        Me.TreeView7a.OptionsView.ShowVertLines = False
        Me.TreeView7a.Size = New System.Drawing.Size(145, 224)
        Me.TreeView7a.TabIndex = 69
        '
        'TreeView6a
        '
        Me.TreeView6a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView6a.FixedLineWidth = 1
        Me.TreeView6a.Location = New System.Drawing.Point(250, 353)
        Me.TreeView6a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView6a.MinWidth = 16
        Me.TreeView6a.Name = "TreeView6a"
        Me.TreeView6a.OptionsBehavior.Editable = False
        Me.TreeView6a.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView6a.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView6a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView6a.OptionsSelection.InvertSelection = True
        Me.TreeView6a.OptionsView.ShowColumns = False
        Me.TreeView6a.OptionsView.ShowHorzLines = False
        Me.TreeView6a.OptionsView.ShowIndicator = False
        Me.TreeView6a.OptionsView.ShowVertLines = False
        Me.TreeView6a.Size = New System.Drawing.Size(145, 224)
        Me.TreeView6a.TabIndex = 68
        '
        'TreeView5a
        '
        Me.TreeView5a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView5a.FixedLineWidth = 1
        Me.TreeView5a.Location = New System.Drawing.Point(79, 353)
        Me.TreeView5a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView5a.MinWidth = 16
        Me.TreeView5a.Name = "TreeView5a"
        Me.TreeView5a.OptionsBehavior.Editable = False
        Me.TreeView5a.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView5a.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView5a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView5a.OptionsSelection.InvertSelection = True
        Me.TreeView5a.OptionsView.ShowColumns = False
        Me.TreeView5a.OptionsView.ShowHorzLines = False
        Me.TreeView5a.OptionsView.ShowIndicator = False
        Me.TreeView5a.OptionsView.ShowVertLines = False
        Me.TreeView5a.Size = New System.Drawing.Size(169, 224)
        Me.TreeView5a.TabIndex = 67
        '
        'TreeView10a
        '
        Me.TreeView10a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView10a.FixedLineWidth = 1
        Me.TreeView10a.Location = New System.Drawing.Point(838, 353)
        Me.TreeView10a.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView10a.MinWidth = 16
        Me.TreeView10a.Name = "TreeView10a"
        Me.TreeView10a.OptionsBehavior.Editable = False
        Me.TreeView10a.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView10a.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView10a.OptionsMenu.EnableFooterMenu = False
        Me.TreeView10a.OptionsSelection.InvertSelection = True
        Me.TreeView10a.OptionsView.ShowColumns = False
        Me.TreeView10a.OptionsView.ShowHorzLines = False
        Me.TreeView10a.OptionsView.ShowIndicator = False
        Me.TreeView10a.OptionsView.ShowVertLines = False
        Me.TreeView10a.Size = New System.Drawing.Size(145, 224)
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
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(864, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(94, 56)
        Me.SimpleButton1.TabIndex = 72
        Me.SimpleButton1.Text = "OK"
        '
        'FormTreesPricingUpdate
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.Command3
        Me.ClientSize = New System.Drawing.Size(1037, 693)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelPriceOption)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.TreeView10a)
        Me.Controls.Add(Me.TreeView9a)
        Me.Controls.Add(Me.TreeView8a)
        Me.Controls.Add(Me.TreeView7a)
        Me.Controls.Add(Me.TreeView6a)
        Me.Controls.Add(Me.TreeView5a)
        Me.Controls.Add(Me.TreeView2a)
        Me.Controls.Add(Me.TreeView3a)
        Me.Controls.Add(Me.PopupContainerControl1)
        Me.Controls.Add(Me.PopupContainerEdit1)
        Me.Controls.Add(Me.TreeView4a)
        Me.Controls.Add(Me.TreeView1a)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox2)
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

        ''strsql = "SELECT MARKETDIRECTOR as director, LANDX50 as Pais, PCCCLI as CliFact, PCCLID as CliDest, WGBEZ60 as Company, TIPO, PCTPRE as PriceList, PCDATI, PCDATF , PCMOED as Currency FROM Query1 WHERE ((MARKETMANAGER LIKE '%') OR (MARKETDIRECTOR LIKE 'S/Dir.Resp.')) and tabela='" & filterkeyPricing & "'"
        'strsql = "SELECT MARKETDIRECTOR as director, LANDX50 as Pais, PCCCLI as CliFact, PCCLID as CliDest, WGBEZ60 as Company, TIPO, PCTPRE as PriceList, PCDATI, PCDATF , PCMOED as Currency FROM Query1 WHERE tabela='" & filterkeyPricing & "'  AND (NOT (WGBEZ60 = 'Não Relevante'))"
        ''Alteração MM/MR
        strsql = "SELECT MARKETMANAGER as director, LANDX50 as Pais, PCCCLI as CliFact, PCCLID as CliDest, WGBEZ60 as Company, TIPO, PCTPRE as PriceList, PCDATI, PCDATF , PCMOED as Currency FROM Query1 WHERE tabela='" & filterkeyPricing & "'  AND (NOT (WGBEZ60 = 'Não Relevante'))"





        Dim sqlcommand1 As New SQLiteCommand ' OleDb.OleDbCommand
        Dim SqlConnection1 As New System.Data.SQLite.SQLiteConnection ' OleDb.OleDbConnection
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
            'AddNodes(ds.Tables("Distinctdirector"), "Director", 0)
            AddNodes(ds.Tables("Distinctdirector"), "Market Manager", 0)
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
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .Columns.Add()
                    .Columns(1).VisibleIndex = -1
                    .Columns(1).Caption = "Nº"


                    ' .Columns.Add()
                    '  .Columns(0).VisibleIndex = 0
                    ' .Columns(0).SortOrder = SortOrder.Ascending
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
                    .Columns(0).SortOrder = SortOrder.Ascending
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
                    .Columns(0).SortOrder = SortOrder.Ascending
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
                    .Columns(0).SortOrder = SortOrder.Ascending
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
                    .Columns(0).SortOrder = SortOrder.Ascending
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
                    .Columns(0).SortOrder = SortOrder.Ascending
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
                    .Columns(0).SortOrder = SortOrder.Ascending
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
                    .Columns(0).SortOrder = SortOrder.Ascending
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
                    .Columns(0).SortOrder = SortOrder.Ascending
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
                    .Columns(0).SortOrder = SortOrder.Ascending
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

        Pricing.fecho = True
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
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



        'Cursor.Current = Cursors.WaitCursor



        Pricing.filterkeydir = filterkeydir
        Pricing.filterkeypais = filterkeypais
        Pricing.filterkeyclifact = filterkeyclifact
        Pricing.filterkeyclidest = filterkeyclidest
        Pricing.filterkeycomp = filterkeycomp
        Pricing.filterkeytipo = filterkeytipo
        Pricing.filterkeypricelist = filterkeypricelist
        Pricing.filterkeyPCDATI = filterkeyPCDATI
        Pricing.filterkeyPCDATF = filterkeyPCDATF
        Pricing.filterkeyCurrency = filterkeyCurrency
        Pricing.filterkeyPricing = filterkeyPricing


        'Me.CreatePricing(filterkeydir, filterkeypais, filterkeyclifact, filterkeyclidest, filterkeycomp, filterkeytipo, filterkeypricelist, filterkeyPCDATI, filterkeyPCDATF,
        '                 filterkeyCurrency, filterkeyPricing)

        'Cursor.Current = Cursors.Default
        Me.Close()
    End Sub







    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged

        Dim varquery As String
        LabelPriceOption.Text = ComboBoxEdit1.Properties.Items(ComboBoxEdit1.SelectedIndex).Description

        Dim strsql As String
        Select Case ComboBoxEdit1.SelectedIndex
            Case 0
                ''filterkeyPricing = "933"  FUSÃO
                filterkeyPricing = "943"
                'varquery = "query1"
                'strsql = "SELECT MARKETDIRECTOR as director, LANDX50 as Pais, PCCCLI as CliFact, PCCLID as CliDest, WGBEZ60 as Company, TIPO, PCTPRE as PriceList, PCDATI, PCDATF, PCMOED as Currency FROM " & varquery & " WHERE tabela='" & filterkeyPricing & "'  AND (NOT (WGBEZ60 = 'Não Relevante'))"

            Case 1
                ''filterkeyPricing = "934" FUSÃO
                filterkeyPricing = "944"
                'varquery = "query1CliFact"
                'strsql = "SELECT MARKETDIRECTOR as director, LANDX50 as Pais, PCCCLI as CliFact, PCCCLI as CliDest, WGBEZ60 as Company, TIPO, PCTPRE as PriceList, PCDATI, PCDATF, PCMOED as Currency FROM " & varquery & "  WHERE tabela='" & filterkeyPricing & "'  AND (NOT (WGBEZ60 = 'Não Relevante'))"


            Case 2
                ''filterkeyPricing = "936" FUSÂO
                filterkeyPricing = "946"
                'varquery = "query1CliFact"
                'strsql = "SELECT SapClients.MARKETDIRECTOR as director, SapClients.LANDX50 as Pais, Paprixf.PCCLID as CliFact, Paprixf.PCCLID as CliDest, SapMateriais.WGBEZ60 as Company, " _
                '& "SapMateriais.NIV3 as TIPO, Paprixf.PCTPRE as PriceList, Paprixf.PCDATI, Paprixf.PCDATF, Paprixf.PCMOED as Currency FROM Paprixf LEFT OUTER JOIN " _
                '& "SapClients ON Paprixf.PCCLID = SapClients.KUNNR LEFT OUTER JOIN SapMateriais ON Paprixf.PCCPRO = SapMateriais.MATNR WHERE (Paprixf.tabela = '936') AND (NOT (WGBEZ60 = 'Não Relevante'))"

        End Select
        varquery = "query1"
        strsql = "SELECT MARKETDIRECTOR as director, LANDX50 as Pais, PCCCLI as CliFact, PCCLID as CliDest, WGBEZ60 as Company, TIPO, PCTPRE as PriceList, PCDATI, PCDATF, PCMOED as Currency FROM " & varquery & " WHERE tabela='" & filterkeyPricing & "'  AND (NOT (WGBEZ60 = 'Não Relevante'))"

        Dim reader As SqliteDataReader = Nothing

        ds = New DataSet
        dsHelper = New DataSetHelper.DataSetHelper(ds)

        Dim sqlcommand1 As New SqliteCommand ' OleDb.OleDbCommand
        Dim SqlConnection1 As New SqliteConnection ' OleDb.OleDbConnection
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
