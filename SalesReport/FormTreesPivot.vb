Imports System.Windows.Forms
Imports System.Data.SQLite

Public Class FormTreesPivot
    Inherits DevExpress.XtraEditors.XtraForm
    Dim Forcefilterkey As String ' Permissão
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
    Public flagfilterkeycli As String
    Public flagfilterkeypais As String

    Public flagnomedir As String
    Public flagnomecli As String
    Public flagnomepais As String


    Public filterkeyAnoCol As String
    Public filterkeyPackage As String
    Public filtergrid As Boolean
    Public filtergrid1 As Boolean
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
    Public flagValores As Boolean = False

    Dim tabela As New DataTable
    'Dim dv As DataView
    Dim ds As DataSet, dsHelper As DataSetHelper.DataSetHelper

    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents SwitchDirManAssist As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Button1 As System.Windows.Forms.Button



       
    Dim flagkeyprod As String = "Categoria"
    Dim flagkeydir As String = "MM"
    Dim flagkeycli As String = "StatsClient AS Cliente"
    Friend WithEvents SwitchStaInvFinal As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents SwitchCatFam As DevExpress.XtraEditors.RadioGroup
    Dim flagkeypais As String = "StatsMarket AS Pais"
    Dim flagCabecalhoProd As String = "Category"

       

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
    Friend WithEvents TreeView1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView2 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView3 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView4 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView5 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView6 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView7 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView8 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView9 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeView10 As DevExpress.XtraTreeList.TreeList
    'Friend WithEvents Text1 As System.Windows.Forms.TextBox
    Friend WithEvents Text1 As DevExpress.XtraEditors.TextEdit

    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Command3 As System.Windows.Forms.Button
    Friend WithEvents Command1 As System.Windows.Forms.Button
    Friend WithEvents Command2 As System.Windows.Forms.Button

    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTreesPivot))
        Me.TreeView1 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView7 = New DevExpress.XtraTreeList.TreeList()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.Text1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.TreeView8 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView9 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView10 = New DevExpress.XtraTreeList.TreeList()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TreeView2 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView3 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView4 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView5 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeView6 = New DevExpress.XtraTreeList.TreeList()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SwitchDirManAssist = New DevExpress.XtraEditors.RadioGroup()
        Me.SwitchStaInvFinal = New DevExpress.XtraEditors.RadioGroup()
        Me.SwitchCatFam = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.TreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Text1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwitchDirManAssist.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwitchStaInvFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwitchCatFam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView1.FixedLineWidth = 1
        Me.TreeView1.Location = New System.Drawing.Point(53, 116)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView1.MinWidth = 16
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.OptionsBehavior.Editable = False
        Me.TreeView1.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseDownFocused
        Me.TreeView1.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView1.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView1.OptionsMenu.EnableFooterMenu = False
        Me.TreeView1.OptionsSelection.InvertSelection = True
        Me.TreeView1.OptionsSelection.MultiSelect = True
        Me.TreeView1.OptionsView.ShowButtons = False
        Me.TreeView1.OptionsView.ShowCheckBoxes = True
        Me.TreeView1.OptionsView.ShowColumns = False
        Me.TreeView1.OptionsView.ShowHorzLines = False
        Me.TreeView1.OptionsView.ShowIndicator = False
        Me.TreeView1.OptionsView.ShowRoot = False
        Me.TreeView1.OptionsView.ShowVertLines = False
        Me.TreeView1.Size = New System.Drawing.Size(124, 208)
        Me.TreeView1.TabIndex = 0
        '
        'TreeView7
        '
        Me.TreeView7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView7.FixedLineWidth = 1
        Me.TreeView7.Location = New System.Drawing.Point(312, 334)
        Me.TreeView7.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView7.MinWidth = 16
        Me.TreeView7.Name = "TreeView7"
        Me.TreeView7.OptionsBehavior.Editable = False
        Me.TreeView7.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView7.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView7.OptionsMenu.EnableFooterMenu = False
        Me.TreeView7.OptionsSelection.InvertSelection = True
        Me.TreeView7.OptionsSelection.MultiSelect = True
        Me.TreeView7.OptionsView.ShowButtons = False
        Me.TreeView7.OptionsView.ShowCheckBoxes = True
        Me.TreeView7.OptionsView.ShowColumns = False
        Me.TreeView7.OptionsView.ShowHorzLines = False
        Me.TreeView7.OptionsView.ShowIndicator = False
        Me.TreeView7.OptionsView.ShowRoot = False
        Me.TreeView7.OptionsView.ShowVertLines = False
        Me.TreeView7.Size = New System.Drawing.Size(136, 208)
        Me.TreeView7.TabIndex = 6
        '
        'Command3
        '
        Me.Command3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Command3.BackColor = System.Drawing.Color.Transparent
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Command3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Command3.ForeColor = System.Drawing.Color.White
        Me.Command3.Image = CType(resources.GetObject("Command3.Image"), System.Drawing.Image)
        Me.Command3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Command3.Location = New System.Drawing.Point(903, 0)
        Me.Command3.Name = "Command3"
        Me.Command3.Size = New System.Drawing.Size(72, 64)
        Me.Command3.TabIndex = 8
        Me.Command3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command3.UseVisualStyleBackColor = False
        '
        'Text1
        '
        Me.Text1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Text1.Location = New System.Drawing.Point(171, 569)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(304, 20)
        Me.Text1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 567)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Filter Products..."
        '
        'Command1
        '
        Me.Command1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Command1.BackColor = System.Drawing.Color.Transparent
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Command1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Command1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.Color.White
        Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
        Me.Command1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Command1.Location = New System.Drawing.Point(759, 0)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(72, 64)
        Me.Command1.TabIndex = 12
        Me.Command1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command1.UseVisualStyleBackColor = False
        Me.Command1.Visible = False
        '
        'Command2
        '
        Me.Command2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Command2.BackColor = System.Drawing.Color.Transparent
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Command2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Command2.ForeColor = System.Drawing.Color.White
        Me.Command2.Image = CType(resources.GetObject("Command2.Image"), System.Drawing.Image)
        Me.Command2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Command2.Location = New System.Drawing.Point(831, 0)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(72, 64)
        Me.Command2.TabIndex = 13
        Me.Command2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command2.UseVisualStyleBackColor = False
        '
        'TreeView8
        '
        Me.TreeView8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView8.FixedLineWidth = 1
        Me.TreeView8.Location = New System.Drawing.Point(459, 358)
        Me.TreeView8.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView8.MinWidth = 16
        Me.TreeView8.Name = "TreeView8"
        Me.TreeView8.OptionsBehavior.Editable = False
        Me.TreeView8.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView8.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView8.OptionsMenu.EnableFooterMenu = False
        Me.TreeView8.OptionsSelection.InvertSelection = True
        Me.TreeView8.OptionsSelection.MultiSelect = True
        Me.TreeView8.OptionsView.ShowButtons = False
        Me.TreeView8.OptionsView.ShowCheckBoxes = True
        Me.TreeView8.OptionsView.ShowColumns = False
        Me.TreeView8.OptionsView.ShowHorzLines = False
        Me.TreeView8.OptionsView.ShowIndicator = False
        Me.TreeView8.OptionsView.ShowRoot = False
        Me.TreeView8.OptionsView.ShowVertLines = False
        Me.TreeView8.Size = New System.Drawing.Size(192, 184)
        Me.TreeView8.TabIndex = 7
        '
        'TreeView9
        '
        Me.TreeView9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView9.FixedLineWidth = 1
        Me.TreeView9.Location = New System.Drawing.Point(659, 334)
        Me.TreeView9.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView9.MinWidth = 16
        Me.TreeView9.Name = "TreeView9"
        Me.TreeView9.OptionsBehavior.Editable = False
        Me.TreeView9.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView9.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView9.OptionsMenu.EnableFooterMenu = False
        Me.TreeView9.OptionsSelection.InvertSelection = True
        Me.TreeView9.OptionsSelection.MultiSelect = True
        Me.TreeView9.OptionsView.ShowButtons = False
        Me.TreeView9.OptionsView.ShowCheckBoxes = True
        Me.TreeView9.OptionsView.ShowColumns = False
        Me.TreeView9.OptionsView.ShowHorzLines = False
        Me.TreeView9.OptionsView.ShowIndicator = False
        Me.TreeView9.OptionsView.ShowRoot = False
        Me.TreeView9.OptionsView.ShowVertLines = False
        Me.TreeView9.Size = New System.Drawing.Size(114, 208)
        Me.TreeView9.TabIndex = 8
        '
        'TreeView10
        '
        Me.TreeView10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView10.FixedLineWidth = 1
        Me.TreeView10.Location = New System.Drawing.Point(781, 334)
        Me.TreeView10.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView10.MinWidth = 16
        Me.TreeView10.Name = "TreeView10"
        Me.TreeView10.OptionsBehavior.Editable = False
        Me.TreeView10.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView10.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView10.OptionsMenu.EnableFooterMenu = False
        Me.TreeView10.OptionsSelection.InvertSelection = True
        Me.TreeView10.OptionsSelection.MultiSelect = True
        Me.TreeView10.OptionsView.ShowButtons = False
        Me.TreeView10.OptionsView.ShowCheckBoxes = True
        Me.TreeView10.OptionsView.ShowColumns = False
        Me.TreeView10.OptionsView.ShowHorzLines = False
        Me.TreeView10.OptionsView.ShowIndicator = False
        Me.TreeView10.OptionsView.ShowRoot = False
        Me.TreeView10.OptionsView.ShowVertLines = False
        Me.TreeView10.Size = New System.Drawing.Size(192, 208)
        Me.TreeView10.TabIndex = 9
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox8.Location = New System.Drawing.Point(0, 557)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(976, 136)
        Me.PictureBox8.TabIndex = 27
        Me.PictureBox8.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.CommercialSystem.My.Resources.Resources.commercialsystembarra1
        Me.PictureBox3.Location = New System.Drawing.Point(592, 572)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(372, 115)
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.MaximumSize = New System.Drawing.Size(177, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 70)
        Me.Label1.TabIndex = 9
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CommercialSystem.My.Resources.Resources.bymonth
        Me.PictureBox1.Location = New System.Drawing.Point(0, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 80)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Info
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(831, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 64)
        Me.Button1.TabIndex = 34
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Visible = False
        '
        'TreeView2
        '
        Me.TreeView2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView2.FixedLineWidth = 1
        Me.TreeView2.Location = New System.Drawing.Point(192, 139)
        Me.TreeView2.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView2.MinWidth = 16
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.OptionsBehavior.Editable = False
        Me.TreeView2.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView2.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView2.OptionsMenu.EnableFooterMenu = False
        Me.TreeView2.OptionsSelection.InvertSelection = True
        Me.TreeView2.OptionsSelection.MultiSelect = True
        Me.TreeView2.OptionsView.ShowButtons = False
        Me.TreeView2.OptionsView.ShowCheckBoxes = True
        Me.TreeView2.OptionsView.ShowColumns = False
        Me.TreeView2.OptionsView.ShowHorzLines = False
        Me.TreeView2.OptionsView.ShowIndicator = False
        Me.TreeView2.OptionsView.ShowRoot = False
        Me.TreeView2.OptionsView.ShowVertLines = False
        Me.TreeView2.Size = New System.Drawing.Size(139, 185)
        Me.TreeView2.TabIndex = 1
        '
        'TreeView3
        '
        Me.TreeView3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView3.FixedLineWidth = 1
        Me.TreeView3.Location = New System.Drawing.Point(348, 139)
        Me.TreeView3.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView3.MinWidth = 16
        Me.TreeView3.Name = "TreeView3"
        Me.TreeView3.OptionsBehavior.Editable = False
        Me.TreeView3.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView3.OptionsMenu.EnableFooterMenu = False
        Me.TreeView3.OptionsSelection.InvertSelection = True
        Me.TreeView3.OptionsSelection.MultiSelect = True
        Me.TreeView3.OptionsView.ShowButtons = False
        Me.TreeView3.OptionsView.ShowCheckBoxes = True
        Me.TreeView3.OptionsView.ShowColumns = False
        Me.TreeView3.OptionsView.ShowHorzLines = False
        Me.TreeView3.OptionsView.ShowIndicator = False
        Me.TreeView3.OptionsView.ShowRoot = False
        Me.TreeView3.OptionsView.ShowVertLines = False
        Me.TreeView3.Size = New System.Drawing.Size(191, 185)
        Me.TreeView3.TabIndex = 2
        '
        'TreeView4
        '
        Me.TreeView4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView4.FixedLineWidth = 1
        Me.TreeView4.Location = New System.Drawing.Point(554, 116)
        Me.TreeView4.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView4.MinWidth = 16
        Me.TreeView4.Name = "TreeView4"
        Me.TreeView4.OptionsBehavior.Editable = False
        Me.TreeView4.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView4.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView4.OptionsMenu.EnableFooterMenu = False
        Me.TreeView4.OptionsSelection.InvertSelection = True
        Me.TreeView4.OptionsSelection.MultiSelect = True
        Me.TreeView4.OptionsView.ShowButtons = False
        Me.TreeView4.OptionsView.ShowCheckBoxes = True
        Me.TreeView4.OptionsView.ShowColumns = False
        Me.TreeView4.OptionsView.ShowHorzLines = False
        Me.TreeView4.OptionsView.ShowIndicator = False
        Me.TreeView4.OptionsView.ShowRoot = False
        Me.TreeView4.OptionsView.ShowVertLines = False
        Me.TreeView4.Size = New System.Drawing.Size(179, 208)
        Me.TreeView4.TabIndex = 3
        '
        'TreeView5
        '
        Me.TreeView5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView5.FixedLineWidth = 1
        Me.TreeView5.Location = New System.Drawing.Point(746, 116)
        Me.TreeView5.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView5.MinWidth = 16
        Me.TreeView5.Name = "TreeView5"
        Me.TreeView5.OptionsBehavior.Editable = False
        Me.TreeView5.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView5.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView5.OptionsMenu.EnableFooterMenu = False
        Me.TreeView5.OptionsSelection.InvertSelection = True
        Me.TreeView5.OptionsSelection.MultiSelect = True
        Me.TreeView5.OptionsView.ShowButtons = False
        Me.TreeView5.OptionsView.ShowCheckBoxes = True
        Me.TreeView5.OptionsView.ShowColumns = False
        Me.TreeView5.OptionsView.ShowHorzLines = False
        Me.TreeView5.OptionsView.ShowIndicator = False
        Me.TreeView5.OptionsView.ShowRoot = False
        Me.TreeView5.OptionsView.ShowVertLines = False
        Me.TreeView5.Size = New System.Drawing.Size(183, 208)
        Me.TreeView5.TabIndex = 4
        '
        'TreeView6
        '
        Me.TreeView6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView6.FixedLineWidth = 1
        Me.TreeView6.Location = New System.Drawing.Point(5, 334)
        Me.TreeView6.Margin = New System.Windows.Forms.Padding(0)
        Me.TreeView6.MinWidth = 16
        Me.TreeView6.Name = "TreeView6"
        Me.TreeView6.OptionsBehavior.Editable = False
        Me.TreeView6.OptionsFind.AllowIncrementalSearch = True
        Me.TreeView6.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeView6.OptionsMenu.EnableFooterMenu = False
        Me.TreeView6.OptionsSelection.InvertSelection = True
        Me.TreeView6.OptionsSelection.MultiSelect = True
        Me.TreeView6.OptionsView.ShowButtons = False
        Me.TreeView6.OptionsView.ShowCheckBoxes = True
        Me.TreeView6.OptionsView.ShowColumns = False
        Me.TreeView6.OptionsView.ShowHorzLines = False
        Me.TreeView6.OptionsView.ShowIndicator = False
        Me.TreeView6.OptionsView.ShowRoot = False
        Me.TreeView6.OptionsView.ShowVertLines = False
        Me.TreeView6.Size = New System.Drawing.Size(297, 208)
        Me.TreeView6.TabIndex = 5
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = Global.CommercialSystem.My.Resources.Resources.SAP_logo
        Me.PictureBox4.Location = New System.Drawing.Point(454, 594)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(132, 71)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 63
        Me.PictureBox4.TabStop = False
        '
        'SwitchDirManAssist
        '
        Me.SwitchDirManAssist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SwitchDirManAssist.EditValue = "MM"
        Me.SwitchDirManAssist.Location = New System.Drawing.Point(192, 116)
        Me.SwitchDirManAssist.Name = "SwitchDirManAssist"
        Me.SwitchDirManAssist.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.SwitchDirManAssist.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("MM", "MM"), New DevExpress.XtraEditors.Controls.RadioGroupItem("MD", "MR"), New DevExpress.XtraEditors.Controls.RadioGroupItem("MA", "MA")})
        Me.SwitchDirManAssist.Size = New System.Drawing.Size(139, 20)
        Me.SwitchDirManAssist.TabIndex = 64
        '
        'SwitchStaInvFinal
        '
        Me.SwitchStaInvFinal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SwitchStaInvFinal.EditValue = "Statistic"
        Me.SwitchStaInvFinal.Location = New System.Drawing.Point(348, 116)
        Me.SwitchStaInvFinal.Name = "SwitchStaInvFinal"
        Me.SwitchStaInvFinal.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.SwitchStaInvFinal.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Statistic", "Statistic"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Invoice", "Invoice"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Final", "Final")})
        Me.SwitchStaInvFinal.Size = New System.Drawing.Size(191, 20)
        Me.SwitchStaInvFinal.TabIndex = 65
        '
        'SwitchCatFam
        '
        Me.SwitchCatFam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SwitchCatFam.EditValue = "Category"
        Me.SwitchCatFam.Location = New System.Drawing.Point(459, 334)
        Me.SwitchCatFam.Name = "SwitchCatFam"
        Me.SwitchCatFam.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.SwitchCatFam.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Category", "Category"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Family", "Family")})
        Me.SwitchCatFam.Size = New System.Drawing.Size(192, 21)
        Me.SwitchCatFam.TabIndex = 66
        '
        'FormTreesPivot
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(976, 693)
        Me.Controls.Add(Me.SwitchCatFam)
        Me.Controls.Add(Me.TreeView6)
        Me.Controls.Add(Me.TreeView5)
        Me.Controls.Add(Me.TreeView10)
        Me.Controls.Add(Me.TreeView7)
        Me.Controls.Add(Me.TreeView9)
        Me.Controls.Add(Me.TreeView8)
        Me.Controls.Add(Me.SwitchStaInvFinal)
        Me.Controls.Add(Me.SwitchDirManAssist)
        Me.Controls.Add(Me.TreeView4)
        Me.Controls.Add(Me.TreeView3)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox8)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormTreesPivot"
        Me.Text = "Choose Filters."
        CType(Me.TreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Text1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwitchDirManAssist.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwitchStaInvFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwitchCatFam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FormTreesPivot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        flagfilterkeyprod = "Categoria"

        'flagfilterkeydir = "MD"
        flagfilterkeydir = "MM"
        flagfilterkeycli = "StatsClient"
        flagfilterkeypais = "StatsMarket"

        flagnomedir = "MM"
        flagnomecli = "Stats Customer"
        flagnomepais = "Stats Market"



        Me.Top = 0
        Me.Left = 0

        click1 = False

        Forcefilterkey = " MM like '%'"

        If flagValores = True Then

            Dim utilizador As String
            utilizador = UCase(GetSetting("SalesReports", "User", "login"))

            Select Case utilizador
                Case "SYMINGTON\FSC", "PPWLAN\PETERST", "SYMINGTON\VM", "SYMINGTON\MFB", "SYMINGTON\JMV", "SYMINGTON\JVN", "SYMINGTON\HJS", "SYMINGTON\PFL", "SYMINGTON\FRS", "SYMINGTON\HS", "SYMINGTON\EMM", "SYMINGTON\JMA", "SYMINGTON\MMC", "SYMINGTON\DMS", "SYMINGTON\JADS", "SYMINGTON\RADS", "SYMINGTON\RDTS", "SYMINGTON\PDS", "SYMINGTON\CAS", "SYMINGTON\PRS", "SYMINGTON\AMF", "SYMINGTON\CAC", "SYMINGTON\JAR", "SYMINGTON\LMM", "SYMINGTON\GAB", "SYMINGTON\ABB", "SYMINGTON\ABM", "SYMINGTON\GRD", "SYMINGTON\CEM", "SYMINGTON\CMV", "SYMINGTON\HBS", "SYMINGTON\ZAR", "SYMINGTON\AJV", "SYMINGTON\MCG", "SYMINGTON\JL", "SYMINGTON\RJR", "SYMINGTON\EOR", "SYMINGTON\EG", "SYMINGTON\SMD", "SYMINGTON\JMCR", "SYMINGTON\RJMR", "SYMINGTON\JV", "SYMINGTON\SAS", "SYMINGTON\SDO", "SYMINGTON\LBG", "SYMINGTON\PSC", "SYMINGTON\IPM", "SYMINGTON\ASC", "SYMINGTON\MCC", "SYMINGTON\ASK", "SYMINGTON\PAS", "SYMINGTON\DHC", "SYMINGTON\EDR", "COMERC_JVN\JORGE", "SYMINGTON\ARSC", "SYMINGTON\BMP", "SYMINGTON\ALM", "SYMINGTON\MFA", "SYMINGTON\TFO", "SYMINGTON\PUD", "SYMINGTON\PMDS", "DESKTOP-7RA9PT2\SOFIAZHANG"
                    Forcefilterkey = " MM like '%'"
                Case "SYMINGTON\PV"
                    Forcefilterkey = " MM like '%'"
                    ' Forcefilterkey = " MD like 'EMM'"
                Case "SYMINGTON\IF"
                    Forcefilterkey = " MM like '%'"
                Case "SYMINGTON\TC"
                    Forcefilterkey = " MM like '%'"
                Case "SYMINGTON\MAM"
                    Forcefilterkey = " MM like '%'"
                Case "SYMINGTON\RVB"
                    Forcefilterkey = " MM like '%'"
                Case "SYMINGTON\RAP"
                    Forcefilterkey = " MM like '%'"


                Case "SYMINGTON\FCL"
                    Forcefilterkey = " MM like '%'"
                Case "SYMINGTON\EAC"
                    Forcefilterkey = " MM like '%'"
                Case "SYMINGTON\MAC"
                    Forcefilterkey = " MM like '%'"
                    'Forcefilterkey = " (MD like 'JADS' OR pais like 'canada')"
                Case "SYMINGTON\CLC"
                    Forcefilterkey = " MM like '%'"
                Case "SYMINGTON\LS"
                    Forcefilterkey = " MM like '%'"
                    'Forcefilterkey = " (MD like 'JAR' OR MD like 'DMS')"
                Case "SYMINGTON\MTB"
                    Forcefilterkey = " MM like '%'"
                    'Forcefilterkey = " (MD like 'JAR' OR MD like 'DMS')"
                Case "SYMINGTON\PAM"
                    Forcefilterkey = " MM like '%'"
                    'Forcefilterkey = " (MD like 'JAR' OR MD like 'DMS')"
                Case "SYMINGTON\MLL"
                    Forcefilterkey = " MM like '%'"
                    'Forcefilterkey = " (MD like 'LMM' OR MD like 'EMM - ASIA')"
                Case "SYMINGTON\ACR"
                    Forcefilterkey = " MM like '%'"
                Case "SYMINGTON\MFF"
                    Forcefilterkey = " (Company like 'Prats%' OR Company like '%roriz%')"
                Case "SYMINGTON\SYMINOV"
                    Forcefilterkey = " (StatsMarket like'%USA%')"

                Case Else
                    Forcefilterkey = "MM like 'NAO TEM ACESSO'"
                    MsgBox("Sem acesso definido!!" & vbCrLf & "No access granted!!", MsgBoxStyle.Exclamation, "Erro")
            End Select
        End If



        If UCase(GetSetting("SalesReports", "User", "login")) = "SYMINGTON\SYMINOV" Then
            Forcefilterkey = " (StatsMarket like'%USA%')"

        End If

        filterkeyregion = "region like '%'"
        filterkeydir = flagfilterkeydir & " like '%'"
        filterkeypais = flagfilterkeypais & " like '%'"
        filterkeycli = flagfilterkeycli & " like '%'"
        filterkeycomp = "company like '%'"
        filterkeymarca = "Trademark like '%'"
        filterkeytype = "Tipo like '%'"
        filterkeygroup = "grupo like '%'"
        filterkeyprod = flagfilterkeyprod & " Like '%'"
        filterkeyAnoCol = "VINTAGEYEAR like '%'"
        filterkeyPackage = "Package like '%'"



        Dim strsql As String
        Dim reader As SQLiteDataReader

        ds = New DataSet
        dsHelper = New DataSetHelper.DataSetHelper(ds)

        If Label1.Text = "By Month 9L" Or Label1.Text = "Packs - By Month 9L" Or Label1.Text = "OldReserves - By Month 9L" Or Label1.Text = "German Warehouse - By Month 9L" Then
            ' strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "


        ElseIf Label1.Text = "By Month 9L Last Year" Or Label1.Text = "Packs - By Month 9L Last Year" Or Label1.Text = "OldReserves - By Month 9L Last Year" Or Label1.Text = "German Warehouse - By Month 9L Last Year" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString - 1 & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "


        ElseIf Label1.Text = "Current Sales" Or Label1.Text = "Packs - Current Sales" Or Label1.Text = "OldReserves - Current Sales" Or Label1.Text = "Samples - Current" Or Label1.Text = "German Warehouse - Current Sales" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "


        ElseIf Label1.Text = "Sales LY" Or Label1.Text = "Packs - Sales LY" Or Label1.Text = "OldReserves - Sales LY" Or Label1.Text = "German Warehouse - Sales LY" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString - 1 & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "Sales Comparison" Or Label1.Text = "Packs - Sales Comparison" Or Label1.Text = "OldReserves - Sales Comparison" Or Label1.Text = "German Warehouse - Sales Comparison" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year >= '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "Sales Comparison LY" Or Label1.Text = "Packs - Sales Comparison LY" Or Label1.Text = "OldReserves - Sales Comparison LY" Or Label1.Text = "German Warehouse - Sales Comparison LY" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year >= '" & Now.Year.ToString - 2 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "Sales Comparison TY" Or Label1.Text = "Packs - Sales Comparison TY" Or Label1.Text = "OldReserves - Sales Comparison TY" Or Label1.Text = "German Warehouse - Sales Comparison TY" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year >= '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "MAT" Or Label1.Text = "Packs - MAT" Or Label1.Text = "OldReserves - MAT" Or Label1.Text = "German Warehouse - MAT" Then
            strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " WHERE (MD <> '') AND (Company <> '') AND (Package <> '') AND " & Forcefilterkey & ""
        End If

        Dim sqlcommand1 As New SQLiteCommand


        Dim SqlConnection1 As New Data.SQLite.SQLiteConnection ' OleDb.OleDbConnection
        SqlConnection1.ConnectionString = My.Settings.SAPcommercialsystem
        sqlcommand1.CommandText = strsql
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        Dim tabela As New DataTable

        tabela.Columns.Add("Region", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
        tabela.Columns.Add("Tipo", Type.GetType("System.String"))
        tabela.Columns.Add("company", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
        '  tabela.Columns.Add("Trademark", Type.GetType("System.String"))
        tabela.Columns.Add("grupo", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
        tabela.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
        tabela.Columns.Add("Package", Type.GetType("System.String"))
        Dim myRow As DataRow

        reader = sqlcommand1.ExecuteReader

        While reader.Read
            myRow = tabela.NewRow()
            myRow("Region") = reader.Item(0)
            myRow(flagfilterkeydir) = reader.Item(1)
            myRow(flagfilterkeypais) = reader.Item(2)
            myRow("Tipo") = reader.Item(3)
            myRow("company") = reader.Item(4)
            myRow(flagfilterkeycli) = reader.Item(5)
            myRow("grupo") = reader.Item(6)
            myRow(flagfilterkeyprod) = reader.Item(7)
            myRow("VINTAGEYEAR") = reader.Item(8)
            myRow("Package") = reader.Item(9)
            tabela.Rows.Add(myRow)
        End While

        ds.Tables.Add(tabela)
        reader.Close()
        SqlConnection1.Close()



        treefill(-1)


    End Sub
    Private Sub treefill(ByVal Index As Integer)
        flagWork = True
        TreeView1.BeginUpdate()
        TreeView2.BeginUpdate()
        TreeView3.BeginUpdate()

        TreeView4.BeginUpdate()

        TreeView5.BeginUpdate()

        TreeView6.BeginUpdate()

        TreeView7.BeginUpdate()
        TreeView8.BeginUpdate()
        TreeView9.BeginUpdate()
        TreeView10.BeginUpdate()
        filtergrid = False
        Cursor.Current = Cursors.WaitCursor
        ''    Dim x As Integer
        If Index < 0 Then TreeView1.Nodes.Clear()
        If Index < 1 Then TreeView2.Nodes.Clear()
        If Index < 2 Then TreeView3.Nodes.Clear()

        If Index < 3 Then TreeView4.Nodes.Clear()

        If Index < 4 Then TreeView5.Nodes.Clear()

        If Index < 5 Then TreeView6.Nodes.Clear()
        If Index < 6 Then TreeView7.Nodes.Clear()
        If Index < 7 Then TreeView8.Nodes.Clear()
        If Index < 8 Then TreeView9.Nodes.Clear()
        If Index < 9 Then TreeView10.Nodes.Clear()


        If Index = -1 Then

            dsHelper.SelectDistinct("DistinctRegion", ds.Tables(0), "region")
            AddNodes(ds.Tables("DistinctRegion"), "Region", 0)
            ds.Tables.Remove("DistinctRegion")


            dsHelper.SelectDistinct("Distinct" & flagfilterkeydir, ds.Tables(0), flagfilterkeydir)
            AddNodes(ds.Tables("Distinct" & flagfilterkeydir), flagnomedir, 1)
            ds.Tables.Remove("Distinct" & flagfilterkeydir)

            dsHelper.SelectDistinct("Distinct" & flagfilterkeypais, ds.Tables(0), flagfilterkeypais)
            AddNodes(ds.Tables("Distinct" & flagfilterkeypais), flagnomepais, 2)
            ds.Tables.Remove("Distinct" & flagfilterkeypais)

            dsHelper.SelectDistinct("DistinctTipo", ds.Tables(0), "Tipo")
            AddNodes(ds.Tables("DistinctTipo"), "Type", 3)
            ds.Tables.Remove("DistinctTipo")

            dsHelper.SelectDistinct("Distinctcompany", ds.Tables(0), "company")
            AddNodes(ds.Tables("Distinctcompany"), "Brand", 4)
            ds.Tables.Remove("Distinctcompany")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeycli, ds.Tables(0), flagfilterkeycli)
            AddNodes(ds.Tables("Distinct" & flagfilterkeycli), flagnomecli, 5)
            ds.Tables.Remove("Distinct" & flagfilterkeycli)


            'dsHelper.SelectDistinct("DistinctMarca", ds.Tables(0), "Trademark")
            'AddNodes(ds.Tables("DistinctMarca"), "Trademark", 5)
            'ds.Tables.Remove("DistinctMarca")

            dsHelper.SelectDistinct("DistinctGrupo", ds.Tables(0), "grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, ds.Tables(0), flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagCabecalhoProd, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", ds.Tables(0), "VINTAGEYEAR")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctPackage", ds.Tables(0), "Package")
            AddNodes(ds.Tables("DistinctPackage"), "Package", 9)
            ds.Tables.Remove("DistinctPackage")


        End If
        If Index = 0 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeyregion _
            & ") and (" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")
            '& ") and (" & filterkeymarca & ") and (" & filterkeygroup _

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add("Region", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
            'tabeladir.Columns.Add("Trademark", Type.GetType("System.String"))
            tabeladir.Columns.Add("grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
            tabeladir.Columns.Add("Package", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2("Region") = r.Item(0)
                myrow2(flagfilterkeydir) = r.Item(1)
                myrow2(flagfilterkeypais) = r.Item(2)
                myrow2("Tipo") = r.Item(3)
                myrow2("company") = r.Item(4)
                myrow2(flagfilterkeycli) = r.Item(5)
                'myrow2("Trademark") = r.Item(5)
                myrow2("grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("VINTAGEYEAR") = r.Item(8)
                myrow2("Package") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r


            ' dsHelper.SelectDistinct("DistinctRegion", tabeladir, "region")
            'AddNodes(ds.Tables("DistinctRegion"), "Region", 0)
            'ds.Tables.Remove("DistinctRegion")

            '            dsHelper.SelectDistinct("Distinctpais", tabeladir, "pais")
            '           AddNodes(ds.Tables("Distinctpais"), "Market", 1)
            '          ds.Tables.Remove("Distinctpais")


            dsHelper.SelectDistinct("Distinct" & flagfilterkeydir, tabeladir, flagfilterkeydir)
            AddNodes(ds.Tables("Distinct" & flagfilterkeydir), flagnomedir, 1)
            ds.Tables.Remove("Distinct" & flagfilterkeydir)



            dsHelper.SelectDistinct("Distinct" & flagfilterkeypais, tabeladir, flagfilterkeypais)
            AddNodes(ds.Tables("Distinct" & flagfilterkeypais), flagfilterkeypais, 2)
            ds.Tables.Remove("Distinct" & flagfilterkeypais)

            dsHelper.SelectDistinct("DistinctTipo", tabeladir, "Tipo")
            AddNodes(ds.Tables("DistinctTipo"), "Type", 3)
            ds.Tables.Remove("DistinctTipo")

            dsHelper.SelectDistinct("Distinctcompany", tabeladir, "company")
            AddNodes(ds.Tables("Distinctcompany"), "Brand", 4)
            ds.Tables.Remove("Distinctcompany")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeycli, tabeladir, flagfilterkeycli)
            AddNodes(ds.Tables("Distinct" & flagfilterkeycli), flagnomecli, 5)
            ds.Tables.Remove("Distinct" & flagfilterkeycli)

            'dsHelper.SelectDistinct("Distinctcliente", tabeladir, "cliente")
            'AddNodes(ds.Tables("Distinctcliente"), "Customer", 2)
            'ds.Tables.Remove("Distinctcliente")





            'dsHelper.SelectDistinct("DistinctMarca", tabeladir, "Trademark")
            'AddNodes(ds.Tables("DistinctMarca"), "Trademark", 5)
            'ds.Tables.Remove("DistinctMarca")

            dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagCabecalhoProd, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "VINTAGEYEAR")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctPackage", tabeladir, "Package")
            AddNodes(ds.Tables("DistinctPackage"), "Package", 9)
            ds.Tables.Remove("DistinctPackage")

            tabeladir = Nothing
        End If

        If Index = 1 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeyregion _
            & ") and (" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")
            '& ") and (" & filterkeymarca & ") and (" & filterkeygroup _

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add("Region", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
            'tabeladir.Columns.Add("Trademark", Type.GetType("System.String"))
            tabeladir.Columns.Add("grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
            tabeladir.Columns.Add("Package", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2("Region") = r.Item(0)
                myrow2(flagfilterkeydir) = r.Item(1)
                myrow2(flagfilterkeypais) = r.Item(2)
                myrow2("Tipo") = r.Item(3)
                myrow2("company") = r.Item(4)
                myrow2(flagfilterkeycli) = r.Item(5)
                'myrow2("Trademark") = r.Item(5)
                myrow2("grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("VINTAGEYEAR") = r.Item(8)
                myrow2("Package") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r

            dsHelper.SelectDistinct("Distinct" & flagfilterkeypais, tabeladir, flagfilterkeypais)
            AddNodes(ds.Tables("Distinct" & flagfilterkeypais), flagfilterkeypais, 2)
            ds.Tables.Remove("Distinct" & flagfilterkeypais)

            dsHelper.SelectDistinct("DistinctTipo", tabeladir, "Tipo")
            AddNodes(ds.Tables("DistinctTipo"), "Type", 3)
            ds.Tables.Remove("DistinctTipo")

            dsHelper.SelectDistinct("Distinctcompany", tabeladir, "company")
            AddNodes(ds.Tables("Distinctcompany"), "Brand", 4)
            ds.Tables.Remove("Distinctcompany")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeycli, tabeladir, flagfilterkeycli)
            AddNodes(ds.Tables("Distinct" & flagfilterkeycli), flagnomecli, 5)
            ds.Tables.Remove("Distinct" & flagfilterkeycli)

            dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagCabecalhoProd, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "VINTAGEYEAR")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctPackage", tabeladir, "Package")
            AddNodes(ds.Tables("DistinctPackage"), "Package", 9)
            ds.Tables.Remove("DistinctPackage")


            tabeladir = Nothing
        End If

        If Index = 2 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeyregion _
            & ") and (" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")
            '& ") and (" & filterkeymarca & ") and (" & filterkeygroup _

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add("Region", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
            'tabeladir.Columns.Add("Trademark", Type.GetType("System.String"))
            tabeladir.Columns.Add("grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
            tabeladir.Columns.Add("Package", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2("Region") = r.Item(0)
                myrow2(flagfilterkeydir) = r.Item(1)
                myrow2(flagfilterkeypais) = r.Item(2)
                myrow2("Tipo") = r.Item(3)
                myrow2("company") = r.Item(4)
                myrow2(flagfilterkeycli) = r.Item(5)
                'myrow2("Trademark") = r.Item(5)
                myrow2("grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("VINTAGEYEAR") = r.Item(8)
                myrow2("Package") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r



            dsHelper.SelectDistinct("DistinctTipo", tabeladir, "Tipo")
            AddNodes(ds.Tables("DistinctTipo"), "Type", 3)
            ds.Tables.Remove("DistinctTipo")

            dsHelper.SelectDistinct("Distinctcompany", tabeladir, "company")
            AddNodes(ds.Tables("Distinctcompany"), "Brand", 4)
            ds.Tables.Remove("Distinctcompany")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeycli, tabeladir, flagfilterkeycli)
            AddNodes(ds.Tables("Distinct" & flagfilterkeycli), flagnomecli, 5)
            ds.Tables.Remove("Distinct" & flagfilterkeycli)

            dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagCabecalhoProd, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "VINTAGEYEAR")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctPackage", tabeladir, "Package")
            AddNodes(ds.Tables("DistinctPackage"), "Package", 9)
            ds.Tables.Remove("DistinctPackage")


            tabeladir = Nothing
        End If

        If Index = 3 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeyregion _
            & ") and (" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")
            '& ") and (" & filterkeymarca & ") and (" & filterkeygroup _

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add("Region", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
            'tabeladir.Columns.Add("Trademark", Type.GetType("System.String"))
            tabeladir.Columns.Add("grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
            tabeladir.Columns.Add("Package", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2("Region") = r.Item(0)
                myrow2(flagfilterkeydir) = r.Item(1)
                myrow2(flagfilterkeypais) = r.Item(2)
                myrow2("Tipo") = r.Item(3)
                myrow2("company") = r.Item(4)
                myrow2(flagfilterkeycli) = r.Item(5)
                'myrow2("Trademark") = r.Item(5)
                myrow2("grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("VINTAGEYEAR") = r.Item(8)
                myrow2("Package") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r



            dsHelper.SelectDistinct("Distinctcompany", tabeladir, "company")
            AddNodes(ds.Tables("Distinctcompany"), "Brand", 4)
            ds.Tables.Remove("Distinctcompany")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeycli, tabeladir, flagfilterkeycli)
            AddNodes(ds.Tables("Distinct" & flagfilterkeycli), flagnomecli, 5)
            ds.Tables.Remove("Distinct" & flagfilterkeycli)

            dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagCabecalhoProd, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "VINTAGEYEAR")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctPackage", tabeladir, "Package")
            AddNodes(ds.Tables("DistinctPackage"), "Package", 9)
            ds.Tables.Remove("DistinctPackage")


            tabeladir = Nothing
        End If

        If Index = 4 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeyregion _
            & ") and (" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")
            '& ") and (" & filterkeymarca & ") and (" & filterkeygroup _

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add("Region", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
            'tabeladir.Columns.Add("Trademark", Type.GetType("System.String"))
            tabeladir.Columns.Add("grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
            tabeladir.Columns.Add("Package", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2("Region") = r.Item(0)
                myrow2(flagfilterkeydir) = r.Item(1)
                myrow2(flagfilterkeypais) = r.Item(2)
                myrow2("Tipo") = r.Item(3)
                myrow2("company") = r.Item(4)
                myrow2(flagfilterkeycli) = r.Item(5)
                'myrow2("Trademark") = r.Item(5)
                myrow2("grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("VINTAGEYEAR") = r.Item(8)
                myrow2("Package") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r



            dsHelper.SelectDistinct("Distinct" & flagfilterkeycli, tabeladir, flagfilterkeycli)
            AddNodes(ds.Tables("Distinct" & flagfilterkeycli), flagnomecli, 5)
            ds.Tables.Remove("Distinct" & flagfilterkeycli)

            dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagCabecalhoProd, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "VINTAGEYEAR")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctPackage", tabeladir, "Package")
            AddNodes(ds.Tables("DistinctPackage"), "Package", 9)
            ds.Tables.Remove("DistinctPackage")


            tabeladir = Nothing
        End If

        If Index = 5 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeyregion _
            & ") and (" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")
            '& ") and (" & filterkeymarca & ") and (" & filterkeygroup _

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add("Region", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
            'tabeladir.Columns.Add("Trademark", Type.GetType("System.String"))
            tabeladir.Columns.Add("grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
            tabeladir.Columns.Add("Package", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2("Region") = r.Item(0)
                myrow2(flagfilterkeydir) = r.Item(1)
                myrow2(flagfilterkeypais) = r.Item(2)
                myrow2("Tipo") = r.Item(3)
                myrow2("company") = r.Item(4)
                myrow2(flagfilterkeycli) = r.Item(5)
                'myrow2("Trademark") = r.Item(5)
                myrow2("grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("VINTAGEYEAR") = r.Item(8)
                myrow2("Package") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r



            dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagCabecalhoProd, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "VINTAGEYEAR")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctPackage", tabeladir, "Package")
            AddNodes(ds.Tables("DistinctPackage"), "Package", 9)
            ds.Tables.Remove("DistinctPackage")


            tabeladir = Nothing

            tabeladir = Nothing
        End If
        If Index = 6 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeyregion _
            & ") and (" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")
            '& ") and (" & filterkeymarca & ") and (" & filterkeygroup _

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add("Region", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
            'tabeladir.Columns.Add("Trademark", Type.GetType("System.String"))
            tabeladir.Columns.Add("grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
            tabeladir.Columns.Add("Package", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2("Region") = r.Item(0)
                myrow2(flagfilterkeydir) = r.Item(1)
                myrow2(flagfilterkeypais) = r.Item(2)
                myrow2("Tipo") = r.Item(3)
                myrow2("company") = r.Item(4)
                myrow2(flagfilterkeycli) = r.Item(5)
                'myrow2("Trademark") = r.Item(5)
                myrow2("grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("VINTAGEYEAR") = r.Item(8)
                myrow2("Package") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r



            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagCabecalhoProd, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "VINTAGEYEAR")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctPackage", tabeladir, "Package")
            AddNodes(ds.Tables("DistinctPackage"), "Package", 9)
            ds.Tables.Remove("DistinctPackage")


            tabeladir = Nothing
        End If
        If Index = 7 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeyregion _
            & ") and (" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")
            '& ") and (" & filterkeymarca & ") and (" & filterkeygroup _

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add("Region", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
            'tabeladir.Columns.Add("Trademark", Type.GetType("System.String"))
            tabeladir.Columns.Add("grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
            tabeladir.Columns.Add("Package", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2("Region") = r.Item(0)
                myrow2(flagfilterkeydir) = r.Item(1)
                myrow2(flagfilterkeypais) = r.Item(2)
                myrow2("Tipo") = r.Item(3)
                myrow2("company") = r.Item(4)
                myrow2(flagfilterkeycli) = r.Item(5)
                'myrow2("Trademark") = r.Item(5)
                myrow2("grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("VINTAGEYEAR") = r.Item(8)
                myrow2("Package") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r




            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "VINTAGEYEAR")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctPackage", tabeladir, "Package")
            AddNodes(ds.Tables("DistinctPackage"), "Package", 9)
            ds.Tables.Remove("DistinctPackage")


            tabeladir = Nothing
        End If
        If Index = 8 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeyregion _
            & ") and (" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")
            '& ") and (" & filterkeymarca & ") and (" & filterkeygroup _

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add("Region", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
            'tabeladir.Columns.Add("Trademark", Type.GetType("System.String"))
            tabeladir.Columns.Add("grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
            tabeladir.Columns.Add("Package", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2("Region") = r.Item(0)
                myrow2(flagfilterkeydir) = r.Item(1)
                myrow2(flagfilterkeypais) = r.Item(2)
                myrow2("Tipo") = r.Item(3)
                myrow2("company") = r.Item(4)
                myrow2(flagfilterkeycli) = r.Item(5)
                'myrow2("Trademark") = r.Item(5)
                myrow2("grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("VINTAGEYEAR") = r.Item(8)
                myrow2("Package") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r



            dsHelper.SelectDistinct("DistinctPackage", tabeladir, "Package")
            AddNodes(ds.Tables("DistinctPackage"), "Package", 9)
            ds.Tables.Remove("DistinctPackage")


            tabeladir = Nothing
        End If
        ' Cleanup

        TreeView1.Nodes(0).Expanded = True
        TreeView2.Nodes(0).Expanded = True
        TreeView3.Nodes(0).Expanded = True
        TreeView4.Nodes(0).Expanded = True
        TreeView5.Nodes(0).Expanded = True
        TreeView6.Nodes(0).Expanded = True

        TreeView7.Nodes(0).Expanded = True
        TreeView8.Nodes(0).Expanded = True
        TreeView9.Nodes(0).Expanded = True
        TreeView10.Nodes(0).Expanded = True


        If Index = -1 Then
            TreeView1.Nodes(0).Nodes(0).Checked = True
            TreeView2.Nodes(0).Nodes(0).Checked = True
            TreeView3.Nodes(0).Nodes(0).Checked = True
            TreeView4.Nodes(0).Nodes(0).Checked = True
            TreeView5.Nodes(0).Nodes(0).Checked = True
            TreeView6.Nodes(0).Nodes(0).Checked = True
            TreeView7.Nodes(0).Nodes(0).Checked = True
            TreeView8.Nodes(0).Nodes(0).Checked = True
            TreeView9.Nodes(0).Nodes(0).Checked = True
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 0 Then

            TreeView2.Nodes(0).Nodes(0).Checked = True
            TreeView3.Nodes(0).Nodes(0).Checked = True
            TreeView4.Nodes(0).Nodes(0).Checked = True
            TreeView5.Nodes(0).Nodes(0).Checked = True
            TreeView6.Nodes(0).Nodes(0).Checked = True
            TreeView7.Nodes(0).Nodes(0).Checked = True
            TreeView8.Nodes(0).Nodes(0).Checked = True
            TreeView9.Nodes(0).Nodes(0).Checked = True
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 1 Then
            TreeView3.Nodes(0).Nodes(0).Checked = True
            TreeView4.Nodes(0).Nodes(0).Checked = True
            TreeView5.Nodes(0).Nodes(0).Checked = True
            TreeView6.Nodes(0).Nodes(0).Checked = True
            TreeView7.Nodes(0).Nodes(0).Checked = True
            TreeView8.Nodes(0).Nodes(0).Checked = True
            TreeView9.Nodes(0).Nodes(0).Checked = True
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 2 Then

            TreeView4.Nodes(0).Nodes(0).Checked = True
            TreeView5.Nodes(0).Nodes(0).Checked = True
            TreeView6.Nodes(0).Nodes(0).Checked = True
            TreeView7.Nodes(0).Nodes(0).Checked = True
            TreeView8.Nodes(0).Nodes(0).Checked = True
            TreeView9.Nodes(0).Nodes(0).Checked = True
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 3 Then

            TreeView5.Nodes(0).Nodes(0).Checked = True
            TreeView6.Nodes(0).Nodes(0).Checked = True
            TreeView7.Nodes(0).Nodes(0).Checked = True
            TreeView8.Nodes(0).Nodes(0).Checked = True
            TreeView9.Nodes(0).Nodes(0).Checked = True
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 4 Then
            TreeView6.Nodes(0).Nodes(0).Checked = True
            TreeView7.Nodes(0).Nodes(0).Checked = True
            TreeView8.Nodes(0).Nodes(0).Checked = True
            TreeView9.Nodes(0).Nodes(0).Checked = True
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 5 Then
            TreeView7.Nodes(0).Nodes(0).Checked = True
            TreeView8.Nodes(0).Nodes(0).Checked = True
            TreeView9.Nodes(0).Nodes(0).Checked = True
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 6 Then

            TreeView8.Nodes(0).Nodes(0).Checked = True
            TreeView9.Nodes(0).Nodes(0).Checked = True
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 7 Then
            TreeView9.Nodes(0).Nodes(0).Checked = True
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 8 Then
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End If

        TreeView1.EndUpdate()
        TreeView2.EndUpdate()
        TreeView3.EndUpdate()

        TreeView4.EndUpdate()

        TreeView5.EndUpdate()

        TreeView6.EndUpdate()
        TreeView7.EndUpdate()
        TreeView8.EndUpdate()
        TreeView9.EndUpdate()
        TreeView10.EndUpdate()

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

                With TreeView1
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node .
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    .AppendNode(New Object() {" ALL"}, rootNode)
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

                End With
            Case 1

                With TreeView2
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node .
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    .AppendNode(New Object() {" ALL"}, rootNode)
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

                End With
            Case 2



                With TreeView3
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node .
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    .AppendNode(New Object() {" ALL"}, rootNode)
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

                End With




            Case 3

                With TreeView4
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node .
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    .AppendNode(New Object() {" ALL"}, rootNode)
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

                End With
            Case 4


                With TreeView5
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node .
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    .AppendNode(New Object() {" ALL"}, rootNode)
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

                End With

            Case 5

                With TreeView6
                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node .
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    .AppendNode(New Object() {" ALL"}, rootNode)
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

                End With



            Case 6
                With TreeView7

                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node .
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    .AppendNode(New Object() {" ALL"}, rootNode)
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

                End With



            Case 7
                With TreeView8

                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node .
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    .AppendNode(New Object() {" ALL"}, rootNode)
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
                End With

            Case 8
                With TreeView9

                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node .
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    .AppendNode(New Object() {" ALL"}, rootNode)
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
                End With
            Case 9
                With TreeView10

                    .Columns.Add()
                    .Columns(0).VisibleIndex = 0
                    .Columns(0).SortOrder = SortOrder.Ascending
                    .BeginUnboundLoad()
                    ' Create a root node .
                    Dim parentForRootNodes As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing
                    Dim rootNode As DevExpress.XtraTreeList.Nodes.TreeListNode = .AppendNode(New Object() {nome}, parentForRootNodes)
                    .AppendNode(New Object() {" ALL"}, rootNode)
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
                End With

        End Select
    End Sub

    Private Sub Command2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Command2.Click
        filtergrid = True
        Cursor.Current = Cursors.WaitCursor


        If Label1.Text = "Sales Comparison" Or Label1.Text = "Packs - Sales Comparison" Or Label1.Text = "OldReserves - Sales Comparison" Or Label1.Text = "German Warehouse - Sales Comparison" Then
            Dim formgrid As New FormPivotComp
            With formgrid
                .varstrCaption = Label1.Text
                .vardatabase = varDatabase
                .vartabela = varTabela
                .filterkeyregion = filterkeyregion
                .filterkeydir = filterkeydir
                .flagfilterkeydir = flagfilterkeydir
                .filterkeypais = filterkeypais
                .flagfilterkeypais = flagfilterkeypais
                .filterkeycli = filterkeycli
                .flagfilterkeycli = flagfilterkeycli
                .filterkeycomp = filterkeycomp
                .filterkeymarca = filterkeymarca
                .filterkeytype = filterkeytype
                .filterkeygroup = filterkeygroup
                .filterkeyprod = filterkeyprod
                .flagfilterkeyprod = flagfilterkeyprod
                .filterkeyAnocol = filterkeyAnoCol
                .filterkeypackage = filterkeyPackage
                .filtergrid = filtergrid
                .filtermark = Text1.Text
                .flagValores = flagValores
                .Forcefilterkey = Forcefilterkey
                .MdiParent = Me.MdiParent
                .Show()
            End With
            Cursor.Current = Cursors.Default
        ElseIf Label1.Text = "Sales Comparison LY" Or Label1.Text = "Packs - Sales Comparison LY" Or Label1.Text = "OldReserves - Sales Comparison LY" Or Label1.Text = "German Warehouse - Sales Comparison LY" Then
            Dim formgrid As New FormPivotComp
            With formgrid
                .varstrCaption = Label1.Text
                .vardatabase = varDatabase
                .vartabela = varTabela
                .filterkeyregion = filterkeyregion
                .filterkeydir = filterkeydir
                .flagfilterkeydir = flagfilterkeydir
                .filterkeypais = filterkeypais
                .flagfilterkeypais = flagfilterkeypais
                .filterkeycli = filterkeycli
                .flagfilterkeycli = flagfilterkeycli
                .filterkeycomp = filterkeycomp
                .filterkeymarca = filterkeymarca
                .filterkeytype = filterkeytype
                .filterkeygroup = filterkeygroup
                .filterkeyprod = filterkeyprod
                .flagfilterkeyprod = flagfilterkeyprod
                .filterkeyAnocol = filterkeyAnoCol
                .filterkeypackage = filterkeyPackage
                .filtergrid = filtergrid
                .filtermark = Text1.Text
                .flagValores = flagValores
                .Forcefilterkey = Forcefilterkey
                .MdiParent = Me.MdiParent
                .Show()
            End With
            Cursor.Current = Cursors.Default
        ElseIf Label1.Text = "Sales Comparison TY" Or Label1.Text = "Packs - Sales Comparison TY" Or Label1.Text = "OldReserves - Sales Comparison TY" Or Label1.Text = "German Warehouse - Sales Comparison TY" Then
            Dim formgrid As New FormPivotComp
            With formgrid
                .varstrCaption = Label1.Text
                .vardatabase = varDatabase
                .vartabela = varTabela
                .filterkeyregion = filterkeyregion
                .filterkeydir = filterkeydir
                .flagfilterkeydir = flagfilterkeydir
                .filterkeypais = filterkeypais
                .flagfilterkeypais = flagfilterkeypais
                .filterkeycli = filterkeycli
                .flagfilterkeycli = flagfilterkeycli
                .filterkeycomp = filterkeycomp
                .filterkeymarca = filterkeymarca
                .filterkeytype = filterkeytype
                .filterkeygroup = filterkeygroup
                .filterkeyprod = filterkeyprod
                .flagfilterkeyprod = flagfilterkeyprod
                .filterkeyAnocol = filterkeyAnoCol
                .filterkeypackage = filterkeyPackage
                .filtergrid = filtergrid
                .filtermark = Text1.Text
                .flagValores = flagValores
                .Forcefilterkey = Forcefilterkey
                .MdiParent = Me.MdiParent
                .Show()
            End With
            Cursor.Current = Cursors.Default
        ElseIf Label1.Text = "Sales LY" Or Label1.Text = "Packs - Sales LY" Or Label1.Text = "OldReserves - Sales LY" Or Label1.Text = "German Warehouse - Sales LY" Then
            Dim formgrid As New FormPivotMesFull
            With formgrid
                .varstrCaption = Label1.Text
                .vardatabase = varDatabase
                .vartabela = varTabela
                .filterkeyregion = filterkeyregion
                .filterkeydir = filterkeydir
                .flagfilterkeydir = flagfilterkeydir
                .filterkeypais = filterkeypais
                .flagfilterkeypais = flagfilterkeypais
                .filterkeycli = filterkeycli
                .flagfilterkeycli = flagfilterkeycli
                .filterkeycomp = filterkeycomp
                .filterkeymarca = filterkeymarca
                .filterkeytype = filterkeytype
                .filterkeygroup = filterkeygroup
                .filterkeyprod = filterkeyprod
                .flagfilterkeyprod = flagfilterkeyprod
                .filterkeyAnocol = filterkeyAnoCol
                .filterkeypackage = filterkeyPackage
                .filtergrid = filtergrid
                .filtermark = Text1.Text
                .flagValores = flagValores
                .Forcefilterkey = Forcefilterkey
                .MdiParent = Me.MdiParent
                .Show()
            End With
            Cursor.Current = Cursors.Default
        ElseIf Label1.Text = "Current Sales" Or Label1.Text = "Packs - Current Sales" Or Label1.Text = "OldReserves - Current Sales" Or Label1.Text = "Samples - Current" Or Label1.Text = "German Warehouse - Current Sales" Then
            Dim formgrid As New FormPivotMesFull
            With formgrid
                .varstrCaption = Label1.Text
                .vardatabase = varDatabase
                .vartabela = varTabela
                .filterkeyregion = filterkeyregion
                .filterkeydir = filterkeydir
                .flagfilterkeydir = flagfilterkeydir
                .filterkeypais = filterkeypais
                .flagfilterkeypais = flagfilterkeypais
                .filterkeycli = filterkeycli
                .flagfilterkeycli = flagfilterkeycli
                .filterkeycomp = filterkeycomp
                .filterkeymarca = filterkeymarca
                .filterkeytype = filterkeytype
                .filterkeygroup = filterkeygroup
                .filterkeyprod = filterkeyprod
                .flagfilterkeyprod = flagfilterkeyprod
                .filterkeyAnocol = filterkeyAnoCol
                .filterkeypackage = filterkeyPackage
                .filtergrid = filtergrid
                .filtermark = Text1.Text
                .flagValores = flagValores
                .Forcefilterkey = Forcefilterkey
                .MdiParent = Me.MdiParent
                .Show()
            End With
            Cursor.Current = Cursors.Default
        ElseIf Label1.Text = "MAT" Or Label1.Text = "Packs - MAT" Or Label1.Text = "OldReserves - MAT" Or Label1.Text = "German Warehouse - MAT" Then
            Dim formgrid As New FormPivotMesFull
            With formgrid
                .varstrCaption = Label1.Text
                .vardatabase = varDatabase
                .vartabela = varTabela
                .filterkeyregion = filterkeyregion
                .filterkeydir = filterkeydir
                .flagfilterkeydir = flagfilterkeydir
                .filterkeypais = filterkeypais
                .flagfilterkeypais = flagfilterkeypais
                .filterkeycli = filterkeycli
                .flagfilterkeycli = flagfilterkeycli
                .filterkeycomp = filterkeycomp
                .filterkeymarca = filterkeymarca
                .filterkeytype = filterkeytype
                .filterkeygroup = filterkeygroup
                .filterkeyprod = filterkeyprod
                .flagfilterkeyprod = flagfilterkeyprod
                .filterkeyAnocol = filterkeyAnoCol
                .filterkeypackage = filterkeyPackage
                .filtergrid = filtergrid
                .filtermark = Text1.Text
                .flagValores = flagValores
                .Forcefilterkey = Forcefilterkey
                .MdiParent = Me.MdiParent
                .Show()
            End With
            Cursor.Current = Cursors.Default
        ElseIf Label1.Text = "By Month 9L" Or Label1.Text = "Packs - By Month 9L" Or Label1.Text = "OldReserves - By Month 9L" Or Label1.Text = "German Warehouse - By Month 9L" Then
            Dim formgrid As New FormPivotMesFull
            With formgrid
                .varstrCaption = Label1.Text
                .vardatabase = varDatabase
                .vartabela = varTabela
                .filterkeyregion = filterkeyregion
                .filterkeydir = filterkeydir
                .flagfilterkeydir = flagfilterkeydir
                .filterkeypais = filterkeypais
                .flagfilterkeypais = flagfilterkeypais
                .filterkeycli = filterkeycli
                .flagfilterkeycli = flagfilterkeycli
                .filterkeycomp = filterkeycomp
                .filterkeymarca = filterkeymarca
                .filterkeytype = filterkeytype
                .filterkeygroup = filterkeygroup
                .filterkeyprod = filterkeyprod
                .flagfilterkeyprod = flagfilterkeyprod
                .filterkeyAnocol = filterkeyAnoCol
                .filterkeypackage = filterkeyPackage
                .filtergrid = filtergrid
                .filtermark = Text1.Text
                .flagValores = flagValores
                .Forcefilterkey = Forcefilterkey
                .MdiParent = Me.MdiParent
                .Show()
            End With
            Cursor.Current = Cursors.Default
        ElseIf Label1.Text = "By Month 9L Last Year" Or Label1.Text = "Packs - By Month 9L Last Year" Or Label1.Text = "OldReserves - By Month 9L Last Year" Or Label1.Text = "German Warehouse - By Month 9L Last Year" Then
            Dim formgrid As New FormPivotMesFull
            With formgrid
                .varstrCaption = Label1.Text
                .vardatabase = varDatabase
                .vartabela = varTabela
                .filterkeyregion = filterkeyregion
                .filterkeydir = filterkeydir
                .flagfilterkeydir = flagfilterkeydir
                .filterkeypais = filterkeypais
                .flagfilterkeypais = flagfilterkeypais
                .filterkeycli = filterkeycli
                .flagfilterkeycli = flagfilterkeycli
                .filterkeycomp = filterkeycomp
                .filterkeymarca = filterkeymarca
                .filterkeytype = filterkeytype
                .filterkeygroup = filterkeygroup
                .filterkeyprod = filterkeyprod
                .flagfilterkeyprod = flagfilterkeyprod
                .filterkeyAnocol = filterkeyAnoCol
                .filterkeypackage = filterkeyPackage
                .filtergrid = filtergrid
                .filtermark = Text1.Text
                .flagValores = flagValores
                .Forcefilterkey = Forcefilterkey
                .MdiParent = Me.MdiParent
                .Show()
            End With
            Cursor.Current = Cursors.Default

        End If



    End Sub
    Private Sub Command3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command3.Click
        Me.Close()
    End Sub


    Private Sub TreeView1_BeforeFocusNode(sender As Object, e As DevExpress.XtraTreeList.BeforeFocusNodeEventArgs) Handles TreeView1.BeforeFocusNode, TreeView2.BeforeFocusNode, TreeView3.BeforeFocusNode, TreeView4.BeforeFocusNode, TreeView5.BeforeFocusNode, TreeView6.BeforeFocusNode, TreeView7.BeforeFocusNode, TreeView8.BeforeFocusNode, TreeView9.BeforeFocusNode, TreeView10.BeforeFocusNode
        If DirectCast(sender, DevExpress.XtraTreeList.TreeList).State = DevExpress.XtraTreeList.TreeListState.IncrementalSearch Then Exit Sub
        If e.Node.GetDisplayText(0) = sender.Nodes(0)(0) Then Exit Sub
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.CheckState = CheckState.Checked Then Exit Sub
        e.Node.Checked = e.Node.Checked Xor True
    End Sub


    Private Sub TreeView1_BeforeCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles TreeView1.BeforeCheckNode
        'If e.Node.GetDisplayText(0) = flagnomedir Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = "Region" Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.CheckState = CheckState.Checked Then e.CanCheck = False
    End Sub

    Private Sub TreeView1_NodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.NodeChangedEventArgs) Handles TreeView1.NodeChanged
        If flagWork = True Then Exit Sub

        If Not e.Node.GetDisplayText(0) = " ALL" And TreeView1.Nodes(0).Nodes(0).Checked = True Then TreeView1.Nodes(0).Nodes(0).Checked = False : Exit Sub
        flagWork = True

        Dim varstr As String


        Dim xt1 As DevExpress.XtraTreeList.Nodes.TreeListNode
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.Checked Then
            For Each xt1 In TreeView1.Nodes(0).Nodes
                If Not xt1.GetDisplayText(0) = " ALL" Then xt1.Checked = False
            Next
        End If

        'varstr = flagfilterkeydir & " like '"
        varstr = "Region like '"

        Dim xt As DevExpress.XtraTreeList.Nodes.TreeListNode

        For Each xt In TreeView1.Nodes(0).Nodes
            If xt.Checked = True Then
                'varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR " & flagfilterkeydir & " like '"
                varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR Region like '"
            End If
        Next
        'If varstr = flagfilterkeydir & " like '" Then
        '    varstr = varstr & "%" & "' OR " & flagfilterkeydir & " like '"
        '    TreeView1.Nodes(0).Nodes(0).Checked = True
        'End If
        If varstr = "Region like '" Then
            varstr = varstr & "%" & "' OR Region like '"
            TreeView1.Nodes(0).Nodes(0).Checked = True
        End If

        Try
            filterkeyregion = Microsoft.VisualBasic.Left(varstr, Len(varstr) - (17))
            'filterkeydir = Microsoft.VisualBasic.Left(varstr, Len(varstr) - (19 + (Len(flagfilterkeydir) - 8)))
            filterkeydir = flagfilterkeydir & " like '%'"
            filterkeypais = flagfilterkeypais & " like '%'"
            filterkeycli = flagfilterkeycli & " like '%'"
            filterkeycomp = "company like '%'"
            filterkeymarca = "Trademark like '%'"
            filterkeytype = "Tipo like '%'"
            filterkeygroup = "grupo like '%'"
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "VINTAGEYEAR like '%'"
            filterkeyPackage = "Package like '%'"
            treefill(0)
        Catch
            TreeView1.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString




        click1 = False




    End Sub

    Private Sub TreeView2_BeforeCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles TreeView2.BeforeCheckNode
        'If e.Node.GetDisplayText(0) = flagnomepais Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = flagnomedir Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.CheckState = CheckState.Checked Then e.CanCheck = False
    End Sub



    Private Sub TreeView2_NodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.NodeChangedEventArgs) Handles TreeView2.NodeChanged
        If flagWork = True Then Exit Sub

        If Not e.Node.GetDisplayText(0) = " ALL" And TreeView2.Nodes(0).Nodes(0).Checked = True Then TreeView2.Nodes(0).Nodes(0).Checked = False : Exit Sub
        flagWork = True

        Dim varstr As String


        Dim xt1 As DevExpress.XtraTreeList.Nodes.TreeListNode
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.Checked Then
            For Each xt1 In TreeView2.Nodes(0).Nodes
                If Not xt1.GetDisplayText(0) = " ALL" Then xt1.Checked = False
            Next
        End If

        varstr = flagfilterkeydir & " like '"
        'varstr = flagfilterkeypais & " like '"

        Dim xt As DevExpress.XtraTreeList.Nodes.TreeListNode

        For Each xt In TreeView2.Nodes(0).Nodes
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR " & flagfilterkeydir & " like '"
                'varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR " & flagfilterkeypais & " like '"
            End If
        Next
        If varstr = flagfilterkeydir & " like '" Then
            varstr = varstr & "%" & "' OR " & flagfilterkeydir & " like '"
            TreeView2.Nodes(0).Nodes(0).Checked = True
        End If

        'If varstr = flagfilterkeypais & " like '" Then
        'varstr = varstr & "%" & "' OR " & flagfilterkeypais & " like '"
        'TreeView2.Nodes(0).Nodes(0).Checked = True
        'End If
        Try

            filterkeydir = Microsoft.VisualBasic.Left(varstr, Len(varstr) - (19 + (Len(flagfilterkeydir) - 8)))

            filterkeypais = flagfilterkeypais & " like '%'"
            filterkeycli = flagfilterkeycli & " like '%'"
            filterkeycomp = "company like '%'"
            filterkeymarca = "Trademark like '%'"
            filterkeytype = "Tipo like '%'"
            filterkeygroup = "grupo like '%'"
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "VINTAGEYEAR like '%'"
            filterkeyPackage = "Package like '%'"

            ' filterkeypais = Microsoft.VisualBasic.Left(varstr, Len(varstr) - (19 + (Len(flagfilterkeypais) - 8)))
            treefill(1)
        Catch
            TreeView2.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

        click1 = False


    End Sub

    Private Sub TreeView3_BeforeCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles TreeView3.BeforeCheckNode
        'If e.Node.GetDisplayText(0) = flagnomecli Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = flagnomepais Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.CheckState = CheckState.Checked Then e.CanCheck = False
    End Sub
    Private Sub TreeView3_NodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.NodeChangedEventArgs) Handles TreeView3.NodeChanged
        If flagWork = True Then Exit Sub
        If Not e.Node.GetDisplayText(0) = " ALL" And TreeView3.Nodes(0).Nodes(0).Checked = True Then TreeView3.Nodes(0).Nodes(0).Checked = False : Exit Sub
        flagWork = True

        Dim varstr As String


        Dim xt1 As DevExpress.XtraTreeList.Nodes.TreeListNode
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.Checked Then
            For Each xt1 In TreeView3.Nodes(0).Nodes
                If Not xt1.GetDisplayText(0) = " ALL" Then xt1.Checked = False
            Next
        End If

        varstr = flagfilterkeypais & " like '"
        'varstr = flagfilterkeycli & " like '"

        Dim xt As DevExpress.XtraTreeList.Nodes.TreeListNode

        For Each xt In TreeView3.Nodes(0).Nodes
            If xt.Checked = True Then
                'varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR " & flagfilterkeycli & " like '"
                varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR " & flagfilterkeypais & " like '"
            End If
        Next
        'If varstr = flagfilterkeycli & " like '" Then
        ' varstr = varstr & "%" & "' OR " & flagfilterkeycli & " like '"
        ' TreeView3.Nodes(0).Nodes(0).Checked = True
        ' End If

        If varstr = flagfilterkeypais & " like '" Then
            varstr = varstr & "%" & "' OR " & flagfilterkeypais & " like '"
            TreeView3.Nodes(0).Nodes(0).Checked = True
        End If

        Try

            'filterkeycli = Microsoft.VisualBasic.Left(varstr, Len(varstr) - (19 + (Len(flagfilterkeycli) - 8)))
            filterkeypais = Microsoft.VisualBasic.Left(varstr, Len(varstr) - (19 + (Len(flagfilterkeypais) - 8)))
            filterkeycomp = "company like '%'"
            filterkeymarca = "Trademark like '%'"
            filterkeytype = "Tipo like '%'"
            filterkeygroup = "grupo like '%'"
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "VINTAGEYEAR like '%'"
            filterkeyPackage = "Package like '%'"
            treefill(2)
        Catch
            TreeView3.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

        click1 = False


    End Sub

    Private Sub TreeView4_BeforeCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles TreeView4.BeforeCheckNode
        If e.Node.GetDisplayText(0) = "Type" Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.CheckState = CheckState.Checked Then e.CanCheck = False
    End Sub
    Private Sub TreeView4_NodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.NodeChangedEventArgs) Handles TreeView4.NodeChanged
        If flagWork = True Then Exit Sub

        If Not e.Node.GetDisplayText(0) = " ALL" And TreeView4.Nodes(0).Nodes(0).Checked = True Then TreeView4.Nodes(0).Nodes(0).Checked = False : Exit Sub
        flagWork = True

        Dim varstr As String


        Dim xt1 As DevExpress.XtraTreeList.Nodes.TreeListNode
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.Checked Then
            For Each xt1 In TreeView4.Nodes(0).Nodes
                If Not xt1.GetDisplayText(0) = " ALL" Then xt1.Checked = False
            Next
        End If

        varstr = "Tipo LIKE '"
        Dim xt As DevExpress.XtraTreeList.Nodes.TreeListNode

        For Each xt In TreeView4.Nodes(0).Nodes
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR Tipo LIKE '"

            End If
        Next
        If varstr = "Tipo LIKE '" Then
            varstr = "Tipo LIKE '%' OR Tipo LIKE '"
            TreeView4.Nodes(0).Nodes(0).Checked = True
        End If

        Try
            filterkeytype = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 15)
            filterkeycomp = "company like '%'"
            ' filterkeymarca = "Trademark like '%'"

            filterkeygroup = "grupo like '%'"
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "VINTAGEYEAR like '%'"
            filterkeyPackage = "Package like '%'"
            treefill(3)
        Catch
            TreeView4.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

        click1 = False


    End Sub

    Private Sub TreeView5_BeforeCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles TreeView5.BeforeCheckNode
        If e.Node.GetDisplayText(0) = "Brand" Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.CheckState = CheckState.Checked Then e.CanCheck = False
    End Sub
    Private Sub TreeView5_NodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.NodeChangedEventArgs) Handles TreeView5.NodeChanged
        If flagWork = True Then Exit Sub

        If Not e.Node.GetDisplayText(0) = " ALL" And TreeView5.Nodes(0).Nodes(0).Checked = True Then TreeView5.Nodes(0).Nodes(0).Checked = False : Exit Sub
        flagWork = True

        Dim varstr As String


        Dim xt1 As DevExpress.XtraTreeList.Nodes.TreeListNode
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.Checked Then
            For Each xt1 In TreeView5.Nodes(0).Nodes
                If Not xt1.GetDisplayText(0) = " ALL" Then xt1.Checked = False
            Next
        End If

        varstr = "company LIKE '"
        Dim xt As DevExpress.XtraTreeList.Nodes.TreeListNode

        For Each xt In TreeView5.Nodes(0).Nodes
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR company LIKE '"
            End If
        Next
        If varstr = "company LIKE '" Then
            varstr = "company LIKE '%' OR company LIKE '"
            TreeView5.Nodes(0).Nodes(0).Checked = True
        End If

        Try

            filterkeycomp = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 18)
            filterkeygroup = "grupo like '%'"
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "VINTAGEYEAR like '%'"
            filterkeyPackage = "Package like '%'"
            treefill(4)
        Catch
            TreeView5.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

        click1 = False


    End Sub

    Private Sub TreeView6_BeforeCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles TreeView6.BeforeCheckNode
        If e.Node.GetDisplayText(0) = flagnomecli Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.CheckState = CheckState.Checked Then e.CanCheck = False
    End Sub
    Private Sub treeview6_NodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.NodeChangedEventArgs) Handles TreeView6.NodeChanged
        If flagWork = True Then Exit Sub

        If Not e.Node.GetDisplayText(0) = " ALL" And TreeView6.Nodes(0).Nodes(0).Checked = True Then TreeView6.Nodes(0).Nodes(0).Checked = False : Exit Sub
        flagWork = True

        Dim varstr As String


        Dim xt1 As DevExpress.XtraTreeList.Nodes.TreeListNode
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.Checked Then
            For Each xt1 In TreeView6.Nodes(0).Nodes
                If Not xt1.GetDisplayText(0) = " ALL" Then xt1.Checked = False
            Next
        End If
        varstr = flagfilterkeycli & " like '"

        Dim xt As DevExpress.XtraTreeList.Nodes.TreeListNode

        For Each xt In TreeView6.Nodes(0).Nodes
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR " & flagfilterkeycli & " like '"

            End If
        Next


        If varstr = flagfilterkeycli & " like '" Then
            varstr = varstr & "%" & "' OR " & flagfilterkeycli & " like '"
            TreeView6.Nodes(0).Nodes(0).Checked = True
        End If
        Try
            filterkeycli = Microsoft.VisualBasic.Left(varstr, Len(varstr) - (19 + (Len(flagfilterkeycli) - 8)))

            filterkeygroup = "grupo like '%'"
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "VINTAGEYEAR like '%'"
            filterkeyPackage = "Package like '%'"
            treefill(5)
        Catch
            TreeView6.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

        click1 = False


    End Sub

    Private Sub TreeView7_BeforeCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles TreeView7.BeforeCheckNode
        If e.Node.GetDisplayText(0) = "Group" Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.CheckState = CheckState.Checked Then e.CanCheck = False
    End Sub
    Private Sub treeview7_NodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.NodeChangedEventArgs) Handles TreeView7.NodeChanged
        If flagWork = True Then Exit Sub

        If Not e.Node.GetDisplayText(0) = " ALL" And TreeView7.Nodes(0).Nodes(0).Checked = True Then TreeView7.Nodes(0).Nodes(0).Checked = False : Exit Sub
        flagWork = True

        Dim varstr As String


        Dim xt1 As DevExpress.XtraTreeList.Nodes.TreeListNode
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.Checked Then
            For Each xt1 In TreeView7.Nodes(0).Nodes
                If Not xt1.GetDisplayText(0) = " ALL" Then xt1.Checked = False
            Next
        End If

        varstr = "grupo LIKE '"
        Dim xt As DevExpress.XtraTreeList.Nodes.TreeListNode

        For Each xt In TreeView7.Nodes(0).Nodes
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR grupo LIKE '"
            End If
        Next
        If varstr = "grupo LIKE '" Then
            varstr = "grupo LIKE '%' OR grupo LIKE '"
            TreeView7.Nodes(0).Nodes(0).Checked = True
        End If

        Try

            filterkeygroup = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 15)
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "VINTAGEYEAR like '%'"
            filterkeyPackage = "Package like '%'"
            treefill(6)
        Catch
            TreeView7.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

        click1 = False


    End Sub

    Private Sub TreeView8_BeforeCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles TreeView8.BeforeCheckNode
        If e.Node.GetDisplayText(0) = flagCabecalhoProd Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.CheckState = CheckState.Checked Then e.CanCheck = False
    End Sub
    Private Sub treeview8_NodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.NodeChangedEventArgs) Handles TreeView8.NodeChanged
        If flagWork = True Then Exit Sub

        If Not e.Node.GetDisplayText(0) = " ALL" And TreeView8.Nodes(0).Nodes(0).Checked = True Then TreeView8.Nodes(0).Nodes(0).Checked = False : Exit Sub
        flagWork = True

        Dim varstr As String


        Dim xt1 As DevExpress.XtraTreeList.Nodes.TreeListNode
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.Checked Then
            For Each xt1 In TreeView8.Nodes(0).Nodes
                If Not xt1.GetDisplayText(0) = " ALL" Then xt1.Checked = False
            Next
        End If

        varstr = flagfilterkeyprod & " Like '"
        Dim xt As DevExpress.XtraTreeList.Nodes.TreeListNode

        For Each xt In TreeView8.Nodes(0).Nodes
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR " & flagfilterkeyprod & " LIKE '"

            End If
        Next
        If varstr = flagfilterkeyprod & " Like '" Then
            varstr = flagfilterkeyprod & " LIKE '%' OR " & flagfilterkeyprod & " Like '"
            TreeView8.Nodes(0).Nodes(0).Checked = True
        End If

        Try

            filterkeyprod = Microsoft.VisualBasic.Left(varstr, Len(varstr) - (Len(flagfilterkeyprod) + 11))
            filterkeyAnoCol = "VINTAGEYEAR like '%'"
            filterkeyPackage = "Package like '%'"
            treefill(7)
        Catch
            TreeView8.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

        click1 = False


    End Sub

    Private Sub TreeView9_BeforeCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles TreeView9.BeforeCheckNode
        If e.Node.GetDisplayText(0) = "VintageYear" Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.CheckState = CheckState.Checked Then e.CanCheck = False
    End Sub
    Private Sub treeview9_NodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.NodeChangedEventArgs) Handles TreeView9.NodeChanged
        If flagWork = True Then Exit Sub

        If Not e.Node.GetDisplayText(0) = " ALL" And TreeView9.Nodes(0).Nodes(0).Checked = True Then TreeView9.Nodes(0).Nodes(0).Checked = False : Exit Sub
        flagWork = True

        Dim varstr As String


        Dim xt1 As DevExpress.XtraTreeList.Nodes.TreeListNode
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.Checked Then
            For Each xt1 In TreeView9.Nodes(0).Nodes
                If Not xt1.GetDisplayText(0) = " ALL" Then xt1.Checked = False
            Next
        End If

        varstr = "VINTAGEYEAR LIKE '"
        Dim xt As DevExpress.XtraTreeList.Nodes.TreeListNode

        For Each xt In TreeView9.Nodes(0).Nodes
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR VINTAGEYEAR LIKE '"

            End If
        Next
        If varstr = "VINTAGEYEAR LIKE '" Then
            varstr = "VINTAGEYEAR LIKE '%' OR VINTAGEYEAR Like '"
            TreeView9.Nodes(0).Nodes(0).Checked = True
        End If

        Try

            filterkeyAnoCol = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 21)
            filterkeyPackage = "Package like '%'"
            treefill(8)
        Catch
            TreeView9.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

        click1 = False


    End Sub


    Private Sub treeview10_BeforeCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles TreeView10.BeforeCheckNode
        If e.Node.GetDisplayText(0) = "Package" Then e.CanCheck = False
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.CheckState = CheckState.Checked Then e.CanCheck = False
    End Sub
    Private Sub treeview10_NodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.NodeChangedEventArgs) Handles TreeView10.NodeChanged
        If flagWork = True Then Exit Sub

        If Not e.Node.GetDisplayText(0) = " ALL" And TreeView10.Nodes(0).Nodes(0).Checked = True Then TreeView10.Nodes(0).Nodes(0).Checked = False : Exit Sub
        flagWork = True

        Dim varstr As String


        Dim xt1 As DevExpress.XtraTreeList.Nodes.TreeListNode
        If e.Node.GetDisplayText(0) = " ALL" And e.Node.Checked Then
            For Each xt1 In TreeView10.Nodes(0).Nodes
                If Not xt1.GetDisplayText(0) = " ALL" Then xt1.Checked = False
            Next
        End If

        varstr = "Package LIKE '"
        Dim xt As DevExpress.XtraTreeList.Nodes.TreeListNode

        For Each xt In TreeView10.Nodes(0).Nodes
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.GetDisplayText(0) = " ALL", "%", SQ(xt.GetDisplayText(0))) & "' OR Package LIKE '"

            End If
        Next
        If varstr = "Package LIKE '" Then
            varstr = "Package LIKE '%' OR Package LIKE '"
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End If

        Try

            filterkeyPackage = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 17)
        Catch
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

        click1 = False

        flagWork = False
    End Sub



    Public Function SQ(ByVal str As String) As String
        SQ = Replace(str, "'", "''", 1, -1, vbTextCompare)
    End Function




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Select Case varTabela

        '    Case "vendasportomescomp", "vendasmadeiramescomp"
        '        Cursor.Current = Cursors.WaitCursor
        '        Dim formpivot As New FormPivotComp
        '        With formpivot
        '            .vartabela = varTabela
        '            .filterkeydir = filterkeydir
        '            .flagfilterkeydir = flagfilterkeydir

        '            .filterkeypais = filterkeypais
        '            .filterkeycli = filterkeycli
        '            .filterkeycomp = filterkeycomp
        '            .filterkeymarca = filterkeymarca
        '            .filterkeytype = filterkeytype
        '            .filterkeygroup = filterkeygroup
        '            .filterkeyprod = filterkeyprod
        '            .flagfilterkeyprod = flagfilterkeyprod
        '            .filterkeyAnocol = filterkeyAnoCol
        '            .filterkeypackage = filterkeyPackage
        '            .filtergrid = filtergrid

        '            .Groupsubcat = True
        '            .filtermark = Text1.Text
        '            .MdiParent = Me.MdiParent
        '            .Show()
        '        End With
        '        Cursor.Current = Cursors.Default
        '    Case "vendasportomescomp2"
        '        Cursor.Current = Cursors.WaitCursor
        '        Dim formpivot As New FormPivotComp
        '        With formpivot

        '            .vartabela = varTabela
        '            .filterkeydir = filterkeydir
        '            .flagfilterkeydir = flagfilterkeydir

        '            .filterkeypais = filterkeypais
        '            .filterkeycli = filterkeycli
        '            .filterkeycomp = filterkeycomp
        '            .filterkeymarca = filterkeymarca
        '            .filterkeytype = filterkeytype
        '            .filterkeygroup = filterkeygroup
        '            .filterkeyprod = filterkeyprod
        '            .flagfilterkeyprod = flagfilterkeyprod
        '            .filterkeyAnocol = filterkeyAnoCol
        '            .filterkeypackage = filterkeyPackage
        '            .filtergrid = filtergrid

        '            .Groupsubcat = True
        '            .filtermark = Text1.Text
        '            .MdiParent = Me.MdiParent
        '            .Show()
        '        End With
        '        Cursor.Current = Cursors.Default

        '    Case "vendasportomescompvalor"
        '        Cursor.Current = Cursors.WaitCursor
        '        Dim formpivot As New FormPivotComp
        '        With formpivot

        '            .vartabela = varTabela
        '            .filterkeydir = filterkeydir
        '            .flagfilterkeydir = flagfilterkeydir

        '            .filterkeypais = filterkeypais
        '            .filterkeycli = filterkeycli
        '            .filterkeycomp = filterkeycomp
        '            .filterkeymarca = filterkeymarca
        '            .filterkeytype = filterkeytype
        '            .filterkeygroup = filterkeygroup
        '            .filterkeyprod = filterkeyprod
        '            .flagfilterkeyprod = flagfilterkeyprod
        '            .filterkeyAnocol = filterkeyAnoCol
        '            .filterkeypackage = filterkeyPackage
        '            .filtergrid = filtergrid

        '            .Groupsubcat = True
        '            .filtermark = Text1.Text
        '            .MdiParent = Me.MdiParent
        '            .Show()
        '        End With
        '        Cursor.Current = Cursors.Default

        'End Select

    End Sub





    Private Sub SwitchDirManAssist_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SwitchDirManAssist.SelectedIndexChanged
        If sender.selectedindex = 2 Then
            flagfilterkeydir = "MA"
            flagnomedir = "MA"
            flagkeydir = "MA"

        ElseIf sender.selectedindex = 1 Then
            flagfilterkeydir = "MD"
            flagnomedir = "MR"
            flagkeydir = "MD as MR"
        Else 
            flagfilterkeydir = "MM"
            flagnomedir = "MM"
            flagkeydir = "MM"
        End If
        filterkeyregion = "region like '%'"
        filterkeydir = flagfilterkeydir & " like '%'"
        filterkeypais = flagfilterkeypais & " Like '%'"
        filterkeycli = flagfilterkeycli & " like '%'"
        filterkeycomp = "company like '%'"
        filterkeymarca = "Trademark like '%'"
        filterkeytype = "Tipo like '%'"
        filterkeygroup = "grupo like '%'"
        filterkeyprod = flagfilterkeyprod & " Like '%'"
        filterkeyAnoCol = "VINTAGEYEAR like '%'"
        filterkeyPackage = "Package like '%'"

        Dim strsql As String
        Dim reader As SQLiteDataReader

        ds = New DataSet
        dsHelper = New DataSetHelper.DataSetHelper(ds)

        If Label1.Text = "By Month 9L" Or Label1.Text = "Packs - By Month 9L" Or Label1.Text = "OldReserves - By Month 9L" Then
            ' strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "


        ElseIf Label1.Text = "By Month 9L Last Year" Or Label1.Text = "Packs - By Month 9L Last Year" Or Label1.Text = "OldReserves - By Month 9L Last Year" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString - 1 & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "


        ElseIf Label1.Text = "Current Sales" Or Label1.Text = "Packs - Current Sales" Or Label1.Text = "OldReserves - Current Sales" Or Label1.Text = "Samples - Current" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "


        ElseIf Label1.Text = "Sales LY" Or Label1.Text = "Packs - Sales LY" Or Label1.Text = "OldReserves - Sales LY" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString - 1 & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "Sales Comparison" Or Label1.Text = "Packs - Sales Comparison" Or Label1.Text = "OldReserves - Sales Comparison" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year >= '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "Sales Comparison LY" Or Label1.Text = "Packs - Sales Comparison LY" Or Label1.Text = "OldReserves - Sales Comparison LY" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year >= '" & Now.Year.ToString - 2 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "Sales Comparison TY" Or Label1.Text = "Packs - Sales Comparison TY" Or Label1.Text = "OldReserves - Sales Comparison TY" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year >= '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "MAT" Or Label1.Text = "Packs - MAT" Or Label1.Text = "OldReserves - MAT" Then
            strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " WHERE (MD <> '') AND (Company <> '') AND (Package <> '') AND " & Forcefilterkey & ""
        End If



        Dim sqlcommand1 As New SQLiteCommand


        Dim SqlConnection1 As New Data.SQLite.SQLiteConnection
        SqlConnection1.ConnectionString = My.Settings.SAPcommercialsystem
        sqlcommand1.CommandText = strsql
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        Dim tabela As New DataTable



        tabela.Columns.Add("Region", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
        tabela.Columns.Add("Tipo", Type.GetType("System.String"))
        tabela.Columns.Add("company", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
        '  tabela.Columns.Add("Trademark", Type.GetType("System.String"))
        tabela.Columns.Add("grupo", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
        tabela.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
        tabela.Columns.Add("Package", Type.GetType("System.String"))





        Dim myRow As DataRow

        reader = sqlcommand1.ExecuteReader



        While reader.Read
            myRow = tabela.NewRow()
            myRow("Region") = reader.Item(0)
            myRow(flagfilterkeydir) = reader.Item(1)
            myRow(flagfilterkeypais) = reader.Item(2)
            myRow("Tipo") = reader.Item(3)
            myRow("company") = reader.Item(4)
            myRow(flagfilterkeycli) = reader.Item(5)
            myRow("grupo") = reader.Item(6)
            myRow(flagfilterkeyprod) = reader.Item(7)
            myRow("VINTAGEYEAR") = reader.Item(8)
            myRow("Package") = reader.Item(9)
            tabela.Rows.Add(myRow)
        End While

        ds.Tables.Add(tabela)
        reader.Close()
        SqlConnection1.Close()



        treefill(-1)

    End Sub

    Private Sub SwitchStaInvFinal_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SwitchStaInvFinal.SelectedIndexChanged
        If sender.selectedindex = 1 Then
            flagfilterkeycli = "InvClient"
            flagnomecli = "Invoicing Customer"
            flagfilterkeypais = "InvMarket"
            flagnomepais = "Invoicing Market"
        ElseIf sender.selectedindex = 2 Then
            flagfilterkeycli = "FinalClient"
            flagnomecli = "Final Customer"
            flagfilterkeypais = "FinalMarket"
            flagnomepais = "Final Market"
        Else
            flagfilterkeycli = "StatsClient"
            flagnomecli = "Stats Customer"
            flagfilterkeypais = "StatsMarket"
            flagnomepais = "Stats Market"
        End If

        filterkeydir = flagfilterkeydir & " like '%'"
        filterkeypais = flagfilterkeypais & " Like '%'"
        filterkeycli = flagfilterkeycli & " like '%'"
        filterkeycomp = "company like '%'"
        filterkeymarca = "Trademark like '%'"
        filterkeytype = "Tipo like '%'"
        filterkeygroup = "grupo like '%'"
        filterkeyprod = flagfilterkeyprod & " Like '%'"
        filterkeyAnoCol = "VINTAGEYEAR like '%'"
        filterkeyPackage = "Package like '%'"

        Dim strsql As String
        Dim reader As SQLiteDataReader

        ds = New DataSet
        dsHelper = New DataSetHelper.DataSetHelper(ds)

        If Label1.Text = "By Month 9L" Or Label1.Text = "Packs - By Month 9L" Or Label1.Text = "OldReserves - By Month 9L" Then
            ' strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "


        ElseIf Label1.Text = "By Month 9L Last Year" Or Label1.Text = "Packs - By Month 9L Last Year" Or Label1.Text = "OldReserves - By Month 9L Last Year" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString - 1 & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "


        ElseIf Label1.Text = "Current Sales" Or Label1.Text = "Packs - Current Sales" Or Label1.Text = "OldReserves - Current Sales" Or Label1.Text = "Samples - Current" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "


        ElseIf Label1.Text = "Sales LY" Or Label1.Text = "Packs - Sales LY" Or Label1.Text = "OldReserves - Sales LY" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString - 1 & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "Sales Comparison" Or Label1.Text = "Packs - Sales Comparison" Or Label1.Text = "OldReserves - Sales Comparison" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year >= '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "Sales Comparison LY" Or Label1.Text = "Packs - Sales Comparison LY" Or Label1.Text = "OldReserves - Sales Comparison LY" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year >= '" & Now.Year.ToString - 2 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "Sales Comparison TY" Or Label1.Text = "Packs - Sales Comparison TY" Or Label1.Text = "OldReserves - Sales Comparison TY" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year >= '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "MAT" Or Label1.Text = "Packs - MAT" Or Label1.Text = "OldReserves - MAT" Then
            strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " WHERE (MD <> '') AND (Company <> '') AND (Package <> '') AND " & Forcefilterkey & ""
        End If


        Dim sqlcommand1 As New SQLiteCommand


        Dim SqlConnection1 As New Data.SQLite.SQLiteConnection
        SqlConnection1.ConnectionString = My.Settings.SAPcommercialsystem
        sqlcommand1.CommandText = strsql
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        Dim tabela As New DataTable

        tabela.Columns.Add("Region", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
        tabela.Columns.Add("Tipo", Type.GetType("System.String"))
        tabela.Columns.Add("company", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
        '  tabela.Columns.Add("Trademark", Type.GetType("System.String"))
        tabela.Columns.Add("grupo", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
        tabela.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
        tabela.Columns.Add("Package", Type.GetType("System.String"))
        Dim myRow As DataRow

        reader = sqlcommand1.ExecuteReader



        While reader.Read
            myRow = tabela.NewRow()
            myRow("Region") = reader.Item(0)
            myRow(flagfilterkeydir) = reader.Item(1)
            myRow(flagfilterkeypais) = reader.Item(2)
            myRow("Tipo") = reader.Item(3)
            myRow("company") = reader.Item(4)
            myRow(flagfilterkeycli) = reader.Item(5)
            myRow("grupo") = reader.Item(6)
            myRow(flagfilterkeyprod) = reader.Item(7)
            myRow("VINTAGEYEAR") = reader.Item(8)
            myRow("Package") = reader.Item(9)
            tabela.Rows.Add(myRow)
        End While

        ds.Tables.Add(tabela)
        reader.Close()
        SqlConnection1.Close()



        treefill(-1)
    End Sub

    Private Sub SwitchCatFam_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SwitchCatFam.SelectedIndexChanged
        If sender.selectedindex = 0 Then
            flagfilterkeyprod = "Categoria"
            flagkeyprod = "Categoria"
            flagCabecalhoProd = "Category"

        Else
            flagfilterkeyprod = "Familia"
            flagkeyprod = "Familia as Family"
            flagCabecalhoProd = "Family"
        End If


        filterkeydir = flagfilterkeydir & " like '%'"
        filterkeypais = flagfilterkeypais & " Like '%'"
        filterkeycli = flagfilterkeycli & " like '%'"
        filterkeycomp = "company like '%'"
        filterkeymarca = "Trademark like '%'"
        filterkeytype = "Tipo like '%'"
        filterkeygroup = "grupo like '%'"
        filterkeyprod = flagfilterkeyprod & " Like '%'"
        filterkeyAnoCol = "VINTAGEYEAR like '%'"
        filterkeyPackage = "Package like '%'"

        Dim strsql As String
        Dim reader As SQLiteDataReader

        ds = New DataSet
        dsHelper = New DataSetHelper.DataSetHelper(ds)


        If Label1.Text = "By Month 9L" Or Label1.Text = "Packs - By Month 9L" Or Label1.Text = "OldReserves - By Month 9L" Then
            ' strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "


        ElseIf Label1.Text = "By Month 9L Last Year" Or Label1.Text = "Packs - By Month 9L Last Year" Or Label1.Text = "OldReserves - By Month 9L Last Year" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString - 1 & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "


        ElseIf Label1.Text = "Current Sales" Or Label1.Text = "Packs - Current Sales" Or Label1.Text = "OldReserves - Current Sales" Or Label1.Text = "Samples - Current" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "


        ElseIf Label1.Text = "Sales LY" Or Label1.Text = "Packs - Sales LY" Or Label1.Text = "OldReserves - Sales LY" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey & " and (year = '" & Now.Year.ToString - 1 & "')"
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year = '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "Sales Comparison" Or Label1.Text = "Packs - Sales Comparison" Or Label1.Text = "OldReserves - Sales Comparison" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year >= '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "Sales Comparison LY" Or Label1.Text = "Packs - Sales Comparison LY" Or Label1.Text = "OldReserves - Sales Comparison LY" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year >= '" & Now.Year.ToString - 2 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "Sales Comparison TY" Or Label1.Text = "Packs - Sales Comparison TY" Or Label1.Text = "OldReserves - Sales Comparison TY" Then
            'strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where " & Forcefilterkey
            strsql = "SELECT region, " & flagkeydir & ", " & flagkeypais & " , Tipo, company,  " & flagkeycli & ", grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " where year >= '" & Now.Year.ToString - 1 & "'" _
            & " GROUP BY region, " & flagfilterkeydir & ", " & flagfilterkeypais & " , Tipo, company,  " & flagfilterkeycli & ", grupo , " & flagfilterkeyprod & ", VINTAGEYEAR , Package "

        ElseIf Label1.Text = "MAT" Or Label1.Text = "Packs - MAT" Or Label1.Text = "OldReserves - MAT" Then
            strsql = "SELECT " & flagkeydir & ", " & flagkeypais & " , " & flagkeycli & ", company, Tipo, Trademark , grupo , " & flagkeyprod & ", VINTAGEYEAR , Package FROM " & varTabela & " WHERE (MD <> '') AND (Company <> '') AND (Package <> '') AND " & Forcefilterkey & ""
        End If

        Dim sqlcommand1 As New SQLiteCommand


        Dim SqlConnection1 As New Data.SQLite.SQLiteConnection
        SqlConnection1.ConnectionString = My.Settings.SAPcommercialsystem
        sqlcommand1.CommandText = strsql
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        Dim tabela As New DataTable

        tabela.Columns.Add("Region", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeypais, Type.GetType("System.String"))
        tabela.Columns.Add("Tipo", Type.GetType("System.String"))
        tabela.Columns.Add("company", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeycli, Type.GetType("System.String"))
        '  tabela.Columns.Add("Trademark", Type.GetType("System.String"))
        tabela.Columns.Add("grupo", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
        tabela.Columns.Add("VINTAGEYEAR", Type.GetType("System.String"))
        tabela.Columns.Add("Package", Type.GetType("System.String"))
        Dim myRow As DataRow

        reader = sqlcommand1.ExecuteReader



        While reader.Read
            myRow = tabela.NewRow()
            myRow("Region") = reader.Item(0)
            myRow(flagfilterkeydir) = reader.Item(1)
            myRow(flagfilterkeypais) = reader.Item(2)
            myRow("Tipo") = reader.Item(3)
            myRow("company") = reader.Item(4)
            myRow(flagfilterkeycli) = reader.Item(5)
            myRow("grupo") = reader.Item(6)
            myRow(flagfilterkeyprod) = reader.Item(7)
            myRow("VINTAGEYEAR") = reader.Item(8)
            myRow("Package") = reader.Item(9)
            tabela.Rows.Add(myRow)
        End While

        ds.Tables.Add(tabela)
        reader.Close()
        SqlConnection1.Close()



        treefill(-1)

    End Sub


End Class
