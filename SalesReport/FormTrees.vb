Imports System.Windows.Forms

Public Class FormTrees
    Inherits System.Windows.Forms.Form

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
    Dim tabela As New DataTable
    'Dim dv As DataView
    Dim ds As DataSet, dsHelper As DataSetHelper.DataSetHelper
    Friend WithEvents btSwitchDirManAssist As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button


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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView3 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView4 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView5 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView6 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView7 As System.Windows.Forms.TreeView
    Friend WithEvents image1 As System.Windows.Forms.PictureBox
    Friend WithEvents Text1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Command3 As System.Windows.Forms.Button
    Friend WithEvents Command1 As System.Windows.Forms.Button
    Friend WithEvents Command2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TreeView8 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView9 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView10 As System.Windows.Forms.TreeView
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonGroupPackage As System.Windows.Forms.Button
    Friend WithEvents ButtonGroupProduct As System.Windows.Forms.Button
    Friend WithEvents ButtonGroupMarket As System.Windows.Forms.Button
    Friend WithEvents ButtonGroupSubCat As System.Windows.Forms.Button
    Friend WithEvents ButtonGroupTrademark As System.Windows.Forms.Button
    Friend WithEvents ButtonGroupVintageYear As System.Windows.Forms.Button
    Friend WithEvents btSwitchCatFam As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTrees))
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.TreeView2 = New System.Windows.Forms.TreeView
        Me.TreeView3 = New System.Windows.Forms.TreeView
        Me.TreeView4 = New System.Windows.Forms.TreeView
        Me.TreeView5 = New System.Windows.Forms.TreeView
        Me.TreeView6 = New System.Windows.Forms.TreeView
        Me.TreeView7 = New System.Windows.Forms.TreeView
        Me.Command3 = New System.Windows.Forms.Button
        Me.image1 = New System.Windows.Forms.PictureBox
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Command1 = New System.Windows.Forms.Button
        Me.Command2 = New System.Windows.Forms.Button
        Me.ButtonGroupPackage = New System.Windows.Forms.Button
        Me.ButtonGroupProduct = New System.Windows.Forms.Button
        Me.ButtonGroupMarket = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.TreeView8 = New System.Windows.Forms.TreeView
        Me.TreeView9 = New System.Windows.Forms.TreeView
        Me.TreeView10 = New System.Windows.Forms.TreeView
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ButtonGroupSubCat = New System.Windows.Forms.Button
        Me.ButtonGroupTrademark = New System.Windows.Forms.Button
        Me.ButtonGroupVintageYear = New System.Windows.Forms.Button
        Me.btSwitchCatFam = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btSwitchDirManAssist = New System.Windows.Forms.Button
        CType(Me.image1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView1.BackColor = System.Drawing.Color.Wheat
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ForeColor = System.Drawing.Color.Black
        Me.TreeView1.HideSelection = False
        Me.TreeView1.ItemHeight = 14
        Me.TreeView1.Location = New System.Drawing.Point(8, 138)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(168, 198)
        Me.TreeView1.TabIndex = 0
        '
        'TreeView2
        '
        Me.TreeView2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView2.BackColor = System.Drawing.Color.Wheat
        Me.TreeView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView2.CheckBoxes = True
        Me.TreeView2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView2.ForeColor = System.Drawing.Color.Black
        Me.TreeView2.HideSelection = False
        Me.TreeView2.ItemHeight = 14
        Me.TreeView2.Location = New System.Drawing.Point(184, 128)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(248, 208)
        Me.TreeView2.TabIndex = 1
        '
        'TreeView3
        '
        Me.TreeView3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView3.BackColor = System.Drawing.Color.Wheat
        Me.TreeView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView3.CheckBoxes = True
        Me.TreeView3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView3.ForeColor = System.Drawing.Color.Black
        Me.TreeView3.HideSelection = False
        Me.TreeView3.ItemHeight = 14
        Me.TreeView3.Location = New System.Drawing.Point(440, 128)
        Me.TreeView3.Name = "TreeView3"
        Me.TreeView3.Size = New System.Drawing.Size(272, 208)
        Me.TreeView3.TabIndex = 2
        '
        'TreeView4
        '
        Me.TreeView4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView4.BackColor = System.Drawing.Color.Wheat
        Me.TreeView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView4.CheckBoxes = True
        Me.TreeView4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView4.ForeColor = System.Drawing.Color.Black
        Me.TreeView4.HideSelection = False
        Me.TreeView4.ItemHeight = 14
        Me.TreeView4.Location = New System.Drawing.Point(720, 128)
        Me.TreeView4.Name = "TreeView4"
        Me.TreeView4.Size = New System.Drawing.Size(232, 208)
        Me.TreeView4.TabIndex = 3
        '
        'TreeView5
        '
        Me.TreeView5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView5.BackColor = System.Drawing.Color.Wheat
        Me.TreeView5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView5.CheckBoxes = True
        Me.TreeView5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView5.ForeColor = System.Drawing.Color.Black
        Me.TreeView5.HideSelection = False
        Me.TreeView5.ItemHeight = 14
        Me.TreeView5.Location = New System.Drawing.Point(8, 360)
        Me.TreeView5.Name = "TreeView5"
        Me.TreeView5.Size = New System.Drawing.Size(144, 208)
        Me.TreeView5.TabIndex = 4
        '
        'TreeView6
        '
        Me.TreeView6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView6.BackColor = System.Drawing.Color.Wheat
        Me.TreeView6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView6.CheckBoxes = True
        Me.TreeView6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView6.ForeColor = System.Drawing.Color.Black
        Me.TreeView6.HideSelection = False
        Me.TreeView6.ItemHeight = 14
        Me.TreeView6.Location = New System.Drawing.Point(160, 360)
        Me.TreeView6.Name = "TreeView6"
        Me.TreeView6.Size = New System.Drawing.Size(168, 208)
        Me.TreeView6.TabIndex = 5
        '
        'TreeView7
        '
        Me.TreeView7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView7.BackColor = System.Drawing.Color.Wheat
        Me.TreeView7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView7.CheckBoxes = True
        Me.TreeView7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView7.ForeColor = System.Drawing.Color.Black
        Me.TreeView7.HideSelection = False
        Me.TreeView7.ItemHeight = 14
        Me.TreeView7.Location = New System.Drawing.Point(336, 360)
        Me.TreeView7.Name = "TreeView7"
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
        Me.Command3.Location = New System.Drawing.Point(935, 0)
        Me.Command3.Name = "Command3"
        Me.Command3.Size = New System.Drawing.Size(72, 64)
        Me.Command3.TabIndex = 8
        Me.Command3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command3.UseVisualStyleBackColor = False
        '
        'image1
        '
        Me.image1.Image = CType(resources.GetObject("image1.Image"), System.Drawing.Image)
        Me.image1.Location = New System.Drawing.Point(0, 8)
        Me.image1.Name = "image1"
        Me.image1.Size = New System.Drawing.Size(244, 77)
        Me.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.image1.TabIndex = 8
        Me.image1.TabStop = False
        Me.image1.Visible = False
        '
        'Text1
        '
        Me.Text1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Text1.BackColor = System.Drawing.Color.BurlyWood
        Me.Text1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.Text1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.Location = New System.Drawing.Point(356, 600)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(304, 21)
        Me.Text1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 598)
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
        Me.Command1.Location = New System.Drawing.Point(791, 0)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(72, 64)
        Me.Command1.TabIndex = 12
        Me.Command1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command1.UseVisualStyleBackColor = False
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
        Me.Command2.Location = New System.Drawing.Point(863, 0)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(72, 64)
        Me.Command2.TabIndex = 13
        Me.Command2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command2.UseVisualStyleBackColor = False
        '
        'ButtonGroupPackage
        '
        Me.ButtonGroupPackage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupPackage.BackColor = System.Drawing.Color.Transparent
        Me.ButtonGroupPackage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGroupPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGroupPackage.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGroupPackage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGroupPackage.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonGroupPackage.Location = New System.Drawing.Point(720, 320)
        Me.ButtonGroupPackage.Name = "ButtonGroupPackage"
        Me.ButtonGroupPackage.Size = New System.Drawing.Size(72, 64)
        Me.ButtonGroupPackage.TabIndex = 14
        Me.ButtonGroupPackage.Text = "Package"
        Me.ButtonGroupPackage.UseVisualStyleBackColor = False
        Me.ButtonGroupPackage.Visible = False
        '
        'ButtonGroupProduct
        '
        Me.ButtonGroupProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupProduct.BackColor = System.Drawing.Color.Transparent
        Me.ButtonGroupProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGroupProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGroupProduct.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGroupProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGroupProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonGroupProduct.Location = New System.Drawing.Point(720, 384)
        Me.ButtonGroupProduct.Name = "ButtonGroupProduct"
        Me.ButtonGroupProduct.Size = New System.Drawing.Size(72, 64)
        Me.ButtonGroupProduct.TabIndex = 15
        Me.ButtonGroupProduct.Text = "Product"
        Me.ButtonGroupProduct.UseVisualStyleBackColor = False
        Me.ButtonGroupProduct.Visible = False
        '
        'ButtonGroupMarket
        '
        Me.ButtonGroupMarket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupMarket.BackColor = System.Drawing.Color.Transparent
        Me.ButtonGroupMarket.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGroupMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGroupMarket.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGroupMarket.ForeColor = System.Drawing.Color.Maroon
        Me.ButtonGroupMarket.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonGroupMarket.Location = New System.Drawing.Point(720, 64)
        Me.ButtonGroupMarket.Name = "ButtonGroupMarket"
        Me.ButtonGroupMarket.Size = New System.Drawing.Size(72, 64)
        Me.ButtonGroupMarket.TabIndex = 16
        Me.ButtonGroupMarket.Text = "Market"
        Me.ButtonGroupMarket.UseVisualStyleBackColor = False
        Me.ButtonGroupMarket.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(719, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 64)
        Me.Button4.TabIndex = 17
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'TreeView8
        '
        Me.TreeView8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView8.BackColor = System.Drawing.Color.Wheat
        Me.TreeView8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView8.CheckBoxes = True
        Me.TreeView8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView8.ForeColor = System.Drawing.Color.Black
        Me.TreeView8.HideSelection = False
        Me.TreeView8.ItemHeight = 14
        Me.TreeView8.Location = New System.Drawing.Point(480, 376)
        Me.TreeView8.Name = "TreeView8"
        Me.TreeView8.Size = New System.Drawing.Size(192, 208)
        Me.TreeView8.TabIndex = 18
        '
        'TreeView9
        '
        Me.TreeView9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView9.BackColor = System.Drawing.Color.Wheat
        Me.TreeView9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView9.CheckBoxes = True
        Me.TreeView9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView9.ForeColor = System.Drawing.Color.Black
        Me.TreeView9.HideSelection = False
        Me.TreeView9.ItemHeight = 14
        Me.TreeView9.Location = New System.Drawing.Point(680, 360)
        Me.TreeView9.Name = "TreeView9"
        Me.TreeView9.Size = New System.Drawing.Size(120, 208)
        Me.TreeView9.TabIndex = 19
        '
        'TreeView10
        '
        Me.TreeView10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView10.BackColor = System.Drawing.Color.Wheat
        Me.TreeView10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView10.CheckBoxes = True
        Me.TreeView10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView10.ForeColor = System.Drawing.Color.Black
        Me.TreeView10.HideSelection = False
        Me.TreeView10.ItemHeight = 14
        Me.TreeView10.Location = New System.Drawing.Point(808, 360)
        Me.TreeView10.Name = "TreeView10"
        Me.TreeView10.Size = New System.Drawing.Size(192, 208)
        Me.TreeView10.TabIndex = 20
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox8.Location = New System.Drawing.Point(0, 608)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(1008, 136)
        Me.PictureBox8.TabIndex = 27
        Me.PictureBox8.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.CommercialSystem.My.Resources.Resources.commercialsystembarra1
        Me.PictureBox3.Location = New System.Drawing.Point(624, 624)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(372, 115)
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "By Month"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 80)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'ButtonGroupSubCat
        '
        Me.ButtonGroupSubCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupSubCat.BackColor = System.Drawing.Color.Transparent
        Me.ButtonGroupSubCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGroupSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGroupSubCat.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGroupSubCat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGroupSubCat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonGroupSubCat.Location = New System.Drawing.Point(720, 192)
        Me.ButtonGroupSubCat.Name = "ButtonGroupSubCat"
        Me.ButtonGroupSubCat.Size = New System.Drawing.Size(72, 64)
        Me.ButtonGroupSubCat.TabIndex = 30
        Me.ButtonGroupSubCat.Text = "Family or SubCat"
        Me.ButtonGroupSubCat.UseVisualStyleBackColor = False
        Me.ButtonGroupSubCat.Visible = False
        '
        'ButtonGroupTrademark
        '
        Me.ButtonGroupTrademark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupTrademark.BackColor = System.Drawing.Color.Transparent
        Me.ButtonGroupTrademark.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGroupTrademark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGroupTrademark.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGroupTrademark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGroupTrademark.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonGroupTrademark.Location = New System.Drawing.Point(720, 128)
        Me.ButtonGroupTrademark.Name = "ButtonGroupTrademark"
        Me.ButtonGroupTrademark.Size = New System.Drawing.Size(72, 64)
        Me.ButtonGroupTrademark.TabIndex = 31
        Me.ButtonGroupTrademark.Text = "Trade mark"
        Me.ButtonGroupTrademark.UseVisualStyleBackColor = False
        Me.ButtonGroupTrademark.Visible = False
        '
        'ButtonGroupVintageYear
        '
        Me.ButtonGroupVintageYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupVintageYear.BackColor = System.Drawing.Color.Transparent
        Me.ButtonGroupVintageYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGroupVintageYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGroupVintageYear.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGroupVintageYear.ForeColor = System.Drawing.Color.Blue
        Me.ButtonGroupVintageYear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonGroupVintageYear.Location = New System.Drawing.Point(720, 256)
        Me.ButtonGroupVintageYear.Name = "ButtonGroupVintageYear"
        Me.ButtonGroupVintageYear.Size = New System.Drawing.Size(72, 64)
        Me.ButtonGroupVintageYear.TabIndex = 32
        Me.ButtonGroupVintageYear.Text = "Vintage Year"
        Me.ButtonGroupVintageYear.UseVisualStyleBackColor = False
        Me.ButtonGroupVintageYear.Visible = False
        '
        'btSwitchCatFam
        '
        Me.btSwitchCatFam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSwitchCatFam.BackColor = System.Drawing.Color.BurlyWood
        Me.btSwitchCatFam.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSwitchCatFam.Image = CType(resources.GetObject("btSwitchCatFam.Image"), System.Drawing.Image)
        Me.btSwitchCatFam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSwitchCatFam.Location = New System.Drawing.Point(496, 344)
        Me.btSwitchCatFam.Name = "btSwitchCatFam"
        Me.btSwitchCatFam.Size = New System.Drawing.Size(152, 24)
        Me.btSwitchCatFam.TabIndex = 33
        Me.btSwitchCatFam.Text = "Family or Subcategory"
        Me.btSwitchCatFam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSwitchCatFam.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Info
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(863, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 64)
        Me.Button1.TabIndex = 34
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Visible = False
        '
        'btSwitchDirManAssist
        '
        Me.btSwitchDirManAssist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSwitchDirManAssist.BackColor = System.Drawing.Color.BurlyWood
        Me.btSwitchDirManAssist.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSwitchDirManAssist.Image = CType(resources.GetObject("btSwitchDirManAssist.Image"), System.Drawing.Image)
        Me.btSwitchDirManAssist.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btSwitchDirManAssist.Location = New System.Drawing.Point(32, 107)
        Me.btSwitchDirManAssist.Name = "btSwitchDirManAssist"
        Me.btSwitchDirManAssist.Size = New System.Drawing.Size(120, 25)
        Me.btSwitchDirManAssist.TabIndex = 35
        Me.btSwitchDirManAssist.Text = "Dir/Assist/Manag"
        Me.btSwitchDirManAssist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSwitchDirManAssist.UseVisualStyleBackColor = False
        '
        'FormTrees
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1008, 744)
        Me.ControlBox = False
        Me.Controls.Add(Me.btSwitchDirManAssist)
        Me.Controls.Add(Me.btSwitchCatFam)
        Me.Controls.Add(Me.ButtonGroupProduct)
        Me.Controls.Add(Me.ButtonGroupPackage)
        Me.Controls.Add(Me.ButtonGroupVintageYear)
        Me.Controls.Add(Me.ButtonGroupTrademark)
        Me.Controls.Add(Me.ButtonGroupSubCat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TreeView10)
        Me.Controls.Add(Me.TreeView8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ButtonGroupMarket)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.image1)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.TreeView7)
        Me.Controls.Add(Me.TreeView6)
        Me.Controls.Add(Me.TreeView5)
        Me.Controls.Add(Me.TreeView4)
        Me.Controls.Add(Me.TreeView3)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.TreeView9)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTrees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Choose Criteria"
        CType(Me.image1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub FormTrees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        flagfilterkeyprod = "Subcat"
        flagfilterkeydir = "director"
        Me.Top = 0
        Me.Left = 0
        Me.Width = Me.MdiParent.ClientSize.Width - 4
        Me.Height = Me.MdiParent.ClientSize.Height - 4
        click1 = False
        filterkeydir = flagfilterkeydir & " like '%'"
        filterkeypais = "pais like '%'"
        filterkeycli = "cliente like '%'"
        filterkeycomp = "Company like '%'"
        filterkeymarca = "Marca like '%'"
        filterkeytype = "Tipo like '%'"
        filterkeygroup = "Grupo like '%'"
        filterkeyprod = flagfilterkeyprod & " Like '%'"
        filterkeyAnoCol = "Anocol like '%'"
        filterkeyPackage = "embalagem like '%'"

        If varTabela = "vendasmadeirahistfull" Then
            Button4.Visible = True
            btSwitchCatFam.Enabled = False
        End If
        If varTabela = "vendasportohistfull" Then Button4.Visible = True
        If varTabela = "vendasportomesfull" Then Button4.Visible = True
        If varTabela = "vendasmadeiramesfull" Then Button4.Visible = True
        If varTabela = "vendasmadeiramesfullano1" Then Button4.Visible = True
        If varTabela = "vendasportomesfullano1" Then Button4.Visible = True
        If varTabela = "vendasportomescomp" Or varTabela = "vendasportomescomp2" Or varTabela = "vendasportomescompvalor" Or varTabela = "vendasportomescompvalor2" Or varTabela = "vendasmadeiramescomp" Then
            Button1.Visible = True
            Command1.Visible = False
            Command2.Visible = False
        End If


        Dim strsql As String
        'Dim reader As System.Data.SqlClient.SqlDataReader
        Dim reader As System.Data.OleDb.OleDbDataReader
        ds = New DataSet
        dsHelper = New DataSetHelper.DataSetHelper(ds)
        strsql = "SELECT " & flagfilterkeydir & ", pais, cliente, company, Tipo, Marca, Grupo, " & flagfilterkeyprod & ", Anocol, embalagem  FROM " & varTabela

        Dim sqlcommand1 As New OleDb.OleDbCommand
        Dim SqlConnection1 As New OleDb.OleDbConnection
        SqlConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=" & varDatabase & ";Mode=Read"
        sqlcommand1.CommandText = strsql
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        Dim tabela As New DataTable

        'Dim workCol As DataColumn = 
        tabela.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
        tabela.Columns.Add("pais", Type.GetType("System.String"))
        tabela.Columns.Add("cliente", Type.GetType("System.String"))
        tabela.Columns.Add("company", Type.GetType("System.String"))
        tabela.Columns.Add("Tipo", Type.GetType("System.String"))
        tabela.Columns.Add("Marca", Type.GetType("System.String"))
        tabela.Columns.Add("Grupo", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
        tabela.Columns.Add("Anocol", Type.GetType("System.String"))
        tabela.Columns.Add("embalagem", Type.GetType("System.String"))
        Dim myRow As DataRow

        reader = sqlcommand1.ExecuteReader



        While reader.Read
            myRow = tabela.NewRow()
            myRow(flagfilterkeydir) = reader.Item(0)
            myRow("pais") = reader.Item(1)
            myRow("cliente") = reader.Item(2)
            myRow("company") = reader.Item(3)
            myRow("Tipo") = reader.Item(4)
            myRow("Marca") = reader.Item(5)
            myRow("Grupo") = reader.Item(6)
            myRow(flagfilterkeyprod) = reader.Item(7)
            myRow("Anocol") = reader.Item(8)
            myRow("embalagem") = reader.Item(9)
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

            dsHelper.SelectDistinct("Distinct" & flagfilterkeydir, ds.Tables(0), flagfilterkeydir)
            AddNodes(ds.Tables("Distinct" & flagfilterkeydir), flagfilterkeydir, 0)
            ds.Tables.Remove("Distinct" & flagfilterkeydir)

            dsHelper.SelectDistinct("Distinctpais", ds.Tables(0), "pais")
            AddNodes(ds.Tables("Distinctpais"), "Market", 1)
            ds.Tables.Remove("Distinctpais")

            dsHelper.SelectDistinct("Distinctcliente", ds.Tables(0), "cliente")
            AddNodes(ds.Tables("Distinctcliente"), "Customer", 2)
            ds.Tables.Remove("Distinctcliente")

            dsHelper.SelectDistinct("Distinctcompany", ds.Tables(0), "company")
            If varTabela.Contains("madeira") Then
                AddNodes(ds.Tables("Distinctcompany"), "Casta", 3)
            Else
                AddNodes(ds.Tables("Distinctcompany"), "Company", 3)
            End If
            ds.Tables.Remove("Distinctcompany")

            dsHelper.SelectDistinct("DistinctTipo", ds.Tables(0), "Tipo")
            AddNodes(ds.Tables("DistinctTipo"), "Type", 4)
            ds.Tables.Remove("DistinctTipo")

            dsHelper.SelectDistinct("DistinctMarca", ds.Tables(0), "Marca")
            AddNodes(ds.Tables("DistinctMarca"), "Trademark", 5)
            ds.Tables.Remove("DistinctMarca")

            dsHelper.SelectDistinct("DistinctGrupo", ds.Tables(0), "Grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, ds.Tables(0), flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagfilterkeyprod, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", ds.Tables(0), "Anocol")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctPackage", ds.Tables(0), "embalagem")
            AddNodes(ds.Tables("DistinctPackage"), "Package", 9)
            ds.Tables.Remove("DistinctPackage")


        End If
        If Index = 0 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeymarca & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")


            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add("pais", Type.GetType("System.String"))
            tabeladir.Columns.Add("cliente", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("Marca", Type.GetType("System.String"))
            tabeladir.Columns.Add("Grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("Anocol", Type.GetType("System.String"))
            tabeladir.Columns.Add("embalagem", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2(flagfilterkeydir) = r.Item(0)
                myrow2("pais") = r.Item(1)
                myrow2("cliente") = r.Item(2)
                myrow2("company") = r.Item(3)
                myrow2("Tipo") = r.Item(4)
                myrow2("Marca") = r.Item(5)
                myrow2("Grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("Anocol") = r.Item(8)
                myrow2("embalagem") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r

            dsHelper.SelectDistinct("Distinctpais", tabeladir, "pais")
            AddNodes(ds.Tables("Distinctpais"), "Market", 1)
            ds.Tables.Remove("Distinctpais")

            dsHelper.SelectDistinct("Distinctcliente", tabeladir, "cliente")
            AddNodes(ds.Tables("Distinctcliente"), "Customer", 2)
            ds.Tables.Remove("Distinctcliente")

            dsHelper.SelectDistinct("Distinctcompany", tabeladir, "company")
            AddNodes(ds.Tables("Distinctcompany"), "Company", 3)
            ds.Tables.Remove("Distinctcompany")

            dsHelper.SelectDistinct("DistinctTipo", tabeladir, "Tipo")
            AddNodes(ds.Tables("DistinctTipo"), "Type", 4)
            ds.Tables.Remove("DistinctTipo")

            dsHelper.SelectDistinct("DistinctMarca", tabeladir, "Marca")
            AddNodes(ds.Tables("DistinctMarca"), "Trademark", 5)
            ds.Tables.Remove("DistinctMarca")

            dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "Grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagfilterkeyprod, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "Anocol")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctEmbalagem", tabeladir, "embalagem")
            AddNodes(ds.Tables("DistinctEmbalagem"), "Package", 9)
            ds.Tables.Remove("DistinctEmbalagem")

            tabeladir = Nothing
        End If

        If Index = 1 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeymarca & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")


            Dim r As DataRow
            Dim myrow2 As DataRow
            ''     Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add("pais", Type.GetType("System.String"))
            tabeladir.Columns.Add("cliente", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("Marca", Type.GetType("System.String"))
            tabeladir.Columns.Add("Grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("Anocol", Type.GetType("System.String"))
            tabeladir.Columns.Add("embalagem", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2(flagfilterkeydir) = r.Item(0)
                myrow2("pais") = r.Item(1)
                myrow2("cliente") = r.Item(2)
                myrow2("company") = r.Item(3)
                myrow2("Tipo") = r.Item(4)
                myrow2("Marca") = r.Item(5)
                myrow2("Grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("Anocol") = r.Item(8)
                myrow2("embalagem") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r

            dsHelper.SelectDistinct("Distinctcliente", tabeladir, "cliente")
            AddNodes(ds.Tables("Distinctcliente"), "Customer", 2)
            ds.Tables.Remove("Distinctcliente")

            dsHelper.SelectDistinct("Distinctcompany", tabeladir, "company")
            AddNodes(ds.Tables("Distinctcompany"), "Company", 3)
            ds.Tables.Remove("Distinctcompany")

            dsHelper.SelectDistinct("DistinctTipo", tabeladir, "Tipo")
            AddNodes(ds.Tables("DistinctTipo"), "Type", 4)
            ds.Tables.Remove("DistinctTipo")

            dsHelper.SelectDistinct("DistinctMarca", tabeladir, "Marca")
            AddNodes(ds.Tables("DistinctMarca"), "Trademark", 5)
            ds.Tables.Remove("DistinctMarca")

            dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "Grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagfilterkeyprod, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "Anocol")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctEmbalagem", tabeladir, "embalagem")
            AddNodes(ds.Tables("DistinctEmbalagem"), "Package", 9)
            ds.Tables.Remove("DistinctEmbalagem")

            tabeladir = Nothing
        End If

        If Index = 2 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeymarca & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''   Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add("pais", Type.GetType("System.String"))
            tabeladir.Columns.Add("cliente", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("Marca", Type.GetType("System.String"))
            tabeladir.Columns.Add("Grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("Anocol", Type.GetType("System.String"))
            tabeladir.Columns.Add("embalagem", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2(flagfilterkeydir) = r.Item(0)
                myrow2("pais") = r.Item(1)
                myrow2("cliente") = r.Item(2)
                myrow2("company") = r.Item(3)
                myrow2("Tipo") = r.Item(4)
                myrow2("Marca") = r.Item(5)
                myrow2("Grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("Anocol") = r.Item(8)
                myrow2("embalagem") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r

            dsHelper.SelectDistinct("Distinctcompany", tabeladir, "company")
            AddNodes(ds.Tables("Distinctcompany"), "Company", 3)
            ds.Tables.Remove("Distinctcompany")

            dsHelper.SelectDistinct("DistinctTipo", tabeladir, "Tipo")
            AddNodes(ds.Tables("DistinctTipo"), "Type", 4)
            ds.Tables.Remove("DistinctTipo")

            dsHelper.SelectDistinct("DistinctMarca", tabeladir, "Marca")
            AddNodes(ds.Tables("DistinctMarca"), "Trademark", 5)
            ds.Tables.Remove("DistinctMarca")

            dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "Grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagfilterkeyprod, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "Anocol")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctEmbalagem", tabeladir, "embalagem")
            AddNodes(ds.Tables("DistinctEmbalagem"), "Package", 9)
            ds.Tables.Remove("DistinctEmbalagem")

            tabeladir = Nothing
        End If

        If Index = 3 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeymarca & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")


            Dim r As DataRow
            Dim myrow2 As DataRow
            ''  Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add("pais", Type.GetType("System.String"))
            tabeladir.Columns.Add("cliente", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("Marca", Type.GetType("System.String"))
            tabeladir.Columns.Add("Grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("Anocol", Type.GetType("System.String"))
            tabeladir.Columns.Add("embalagem", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2(flagfilterkeydir) = r.Item(0)
                myrow2("pais") = r.Item(1)
                myrow2("cliente") = r.Item(2)
                myrow2("company") = r.Item(3)
                myrow2("Tipo") = r.Item(4)
                myrow2("Marca") = r.Item(5)
                myrow2("Grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("Anocol") = r.Item(8)
                myrow2("embalagem") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r


            dsHelper.SelectDistinct("DistinctTipo", tabeladir, "Tipo")
            AddNodes(ds.Tables("DistinctTipo"), "Type", 4)
            ds.Tables.Remove("DistinctTipo")

            dsHelper.SelectDistinct("DistinctMarca", tabeladir, "Marca")
            AddNodes(ds.Tables("DistinctMarca"), "Trademark", 5)
            ds.Tables.Remove("DistinctMarca")

            dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "Grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagfilterkeyprod, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "Anocol")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctEmbalagem", tabeladir, "embalagem")
            AddNodes(ds.Tables("DistinctEmbalagem"), "Package", 9)
            ds.Tables.Remove("DistinctEmbalagem")

            tabeladir = Nothing
        End If

        If Index = 4 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeymarca & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")


            Dim r As DataRow
            Dim myrow2 As DataRow
            ''  Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add("pais", Type.GetType("System.String"))
            tabeladir.Columns.Add("cliente", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("Marca", Type.GetType("System.String"))
            tabeladir.Columns.Add("Grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("Anocol", Type.GetType("System.String"))
            tabeladir.Columns.Add("embalagem", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2(flagfilterkeydir) = r.Item(0)
                myrow2("pais") = r.Item(1)
                myrow2("cliente") = r.Item(2)
                myrow2("company") = r.Item(3)
                myrow2("Tipo") = r.Item(4)
                myrow2("Marca") = r.Item(5)
                myrow2("Grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("Anocol") = r.Item(8)
                myrow2("embalagem") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r



            dsHelper.SelectDistinct("DistinctMarca", tabeladir, "Marca")
            AddNodes(ds.Tables("DistinctMarca"), "Trademark", 5)
            ds.Tables.Remove("DistinctMarca")

            dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "Grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagfilterkeyprod, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "Anocol")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctEmbalagem", tabeladir, "embalagem")
            AddNodes(ds.Tables("DistinctEmbalagem"), "Package", 9)
            ds.Tables.Remove("DistinctEmbalagem")

            tabeladir = Nothing
        End If

        If Index = 5 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeymarca & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add("pais", Type.GetType("System.String"))
            tabeladir.Columns.Add("cliente", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("Marca", Type.GetType("System.String"))
            tabeladir.Columns.Add("Grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("Anocol", Type.GetType("System.String"))
            tabeladir.Columns.Add("embalagem", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2(flagfilterkeydir) = r.Item(0)
                myrow2("pais") = r.Item(1)
                myrow2("cliente") = r.Item(2)
                myrow2("company") = r.Item(3)
                myrow2("Tipo") = r.Item(4)
                myrow2("Marca") = r.Item(5)
                myrow2("Grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("Anocol") = r.Item(8)
                myrow2("embalagem") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r

            dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "Grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 6)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagfilterkeyprod, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "Anocol")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctEmbalagem", tabeladir, "embalagem")
            AddNodes(ds.Tables("DistinctEmbalagem"), "Package", 9)
            ds.Tables.Remove("DistinctEmbalagem")

            tabeladir = Nothing
        End If
        If Index = 6 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeymarca & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''   Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add("pais", Type.GetType("System.String"))
            tabeladir.Columns.Add("cliente", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("Marca", Type.GetType("System.String"))
            tabeladir.Columns.Add("Grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("Anocol", Type.GetType("System.String"))
            tabeladir.Columns.Add("embalagem", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2(flagfilterkeydir) = r.Item(0)
                myrow2("pais") = r.Item(1)
                myrow2("cliente") = r.Item(2)
                myrow2("company") = r.Item(3)
                myrow2("Tipo") = r.Item(4)
                myrow2("Marca") = r.Item(5)
                myrow2("Grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("Anocol") = r.Item(8)
                myrow2("embalagem") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagfilterkeyprod, 7)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)

            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "Anocol")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctEmbalagem", tabeladir, "embalagem")
            AddNodes(ds.Tables("DistinctEmbalagem"), "Package", 9)
            ds.Tables.Remove("DistinctEmbalagem")

            tabeladir = Nothing
        End If
        If Index = 7 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeymarca & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")


            Dim r As DataRow
            Dim myrow2 As DataRow
            ''  Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add("pais", Type.GetType("System.String"))
            tabeladir.Columns.Add("cliente", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("Marca", Type.GetType("System.String"))
            tabeladir.Columns.Add("Grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("Anocol", Type.GetType("System.String"))
            tabeladir.Columns.Add("embalagem", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2(flagfilterkeydir) = r.Item(0)
                myrow2("pais") = r.Item(1)
                myrow2("cliente") = r.Item(2)
                myrow2("company") = r.Item(3)
                myrow2("Tipo") = r.Item(4)
                myrow2("Marca") = r.Item(5)
                myrow2("Grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("Anocol") = r.Item(8)
                myrow2("embalagem") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r



            dsHelper.SelectDistinct("DistinctAnocol", tabeladir, "Anocol")
            AddNodes(ds.Tables("DistinctAnocol"), "VintageYear", 8)
            ds.Tables.Remove("DistinctAnocol")

            dsHelper.SelectDistinct("DistinctEmbalagem", tabeladir, "embalagem")
            AddNodes(ds.Tables("DistinctEmbalagem"), "Package", 9)
            ds.Tables.Remove("DistinctEmbalagem")

            tabeladir = Nothing
        End If
        If Index = 8 Then
            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeydir _
            & ") and (" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeymarca & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") and (" & filterkeyAnoCol _
            & ") and (" & filterkeyPackage & ")")

            Dim r As DataRow
            Dim myrow2 As DataRow
            ''  Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
            tabeladir.Columns.Add("pais", Type.GetType("System.String"))
            tabeladir.Columns.Add("cliente", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("Marca", Type.GetType("System.String"))
            tabeladir.Columns.Add("Grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
            tabeladir.Columns.Add("Anocol", Type.GetType("System.String"))
            tabeladir.Columns.Add("embalagem", Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2(flagfilterkeydir) = r.Item(0)
                myrow2("pais") = r.Item(1)
                myrow2("cliente") = r.Item(2)
                myrow2("company") = r.Item(3)
                myrow2("Tipo") = r.Item(4)
                myrow2("Marca") = r.Item(5)
                myrow2("Grupo") = r.Item(6)
                myrow2(flagfilterkeyprod) = r.Item(7)
                myrow2("Anocol") = r.Item(8)
                myrow2("embalagem") = r.Item(9)
                tabeladir.Rows.Add(myrow2)
            Next r


            dsHelper.SelectDistinct("DistinctEmbalagem", tabeladir, "embalagem")
            AddNodes(ds.Tables("DistinctEmbalagem"), "Package", 9)
            ds.Tables.Remove("DistinctEmbalagem")

            tabeladir = Nothing
        End If
        ' Cleanup

        TreeView1.Nodes(0).Expand()
        TreeView2.Nodes(0).Expand()
        TreeView3.Nodes(0).Expand()
        TreeView4.Nodes(0).Expand()
        TreeView5.Nodes(0).Expand()
        TreeView6.Nodes(0).Expand()
        TreeView7.Nodes(0).Expand()
        TreeView8.Nodes(0).Expand()
        TreeView9.Nodes(0).Expand()
        TreeView10.Nodes(0).Expand()


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

        Select Case t
            Case 0

                With TreeView1.Nodes
                    nodxA = .Add(nome)
                    nodxA.Tag = nome
                    nodxA.EnsureVisible()
                    nodx = TreeView1.Nodes(nodxA.Index).Nodes.Add("ALL")
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            nodx = TreeView1.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))
                        End If
                    Next
                End With
            Case 1
                With TreeView2

                    nodxA = .Nodes.Add(nome)
                    nodxA.Tag = nome
                    nodxA.EnsureVisible()
                    nodx = .Nodes(nodxA.Index).Nodes.Add("ALL")
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            nodx = TreeView2.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))
                        End If
                    Next
                End With
            Case 2
                With TreeView3

                    nodxA = .Nodes.Add(nome)
                    nodxA.Tag = nome
                    nodxA.EnsureVisible()
                    nodx = .Nodes(nodxA.Index).Nodes.Add("ALL")
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            nodx = TreeView3.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))
                        End If
                    Next
                End With
            Case 3
                With TreeView4

                    nodxA = .Nodes.Add(nome)
                    nodxA.Tag = nome
                    nodxA.EnsureVisible()
                    nodx = .Nodes(nodxA.Index).Nodes.Add("ALL")
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            nodx = TreeView4.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))
                        End If
                    Next
                End With
            Case 4
                With TreeView5

                    nodxA = .Nodes.Add(nome)
                    nodxA.Tag = nome
                    nodxA.EnsureVisible()
                    nodx = .Nodes(nodxA.Index).Nodes.Add("ALL")
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            nodx = TreeView5.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))
                        End If
                    Next
                End With
            Case 5
                With TreeView6

                    nodxA = .Nodes.Add(nome)
                    nodxA.Tag = nome
                    nodxA.EnsureVisible()
                    nodx = .Nodes(nodxA.Index).Nodes.Add("ALL")
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            nodx = TreeView6.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))
                        End If
                    Next
                End With
            Case 6
                With TreeView7

                    nodxA = .Nodes.Add(nome)
                    nodxA.Tag = nome
                    nodxA.EnsureVisible()
                    nodx = .Nodes(nodxA.Index).Nodes.Add("ALL")
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            nodx = TreeView7.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))
                        End If
                    Next
                End With



            Case 7
                With TreeView8

                    nodxA = .Nodes.Add(nome)
                    nodxA.Tag = nome
                    nodxA.EnsureVisible()
                    nodx = .Nodes(nodxA.Index).Nodes.Add("ALL")
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            nodx = TreeView8.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))
                        End If
                    Next
                End With

            Case 8
                With TreeView9

                    nodxA = .Nodes.Add(nome)
                    nodxA.Tag = nome
                    nodxA.EnsureVisible()
                    nodx = .Nodes(nodxA.Index).Nodes.Add("ALL")
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            nodx = TreeView9.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))
                        End If
                    Next
                End With
            Case 9
                With TreeView10

                    nodxA = .Nodes.Add(nome)
                    nodxA.Tag = nome
                    nodxA.EnsureVisible()
                    nodx = .Nodes(nodxA.Index).Nodes.Add("ALL")
                    s = vbNullString
                    Dim x As Integer
                    For x = 0 To rs.Rows.Count - 1
                        On Error Resume Next
                        If rs.Rows(x).Item(0) <> s Then
                            nodx = TreeView10.Nodes(nodxA.Index).Nodes.Add(rs.Rows(x).Item(0))
                        End If
                    Next
                End With

        End Select
    End Sub

    Private Sub Command2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Command2.Click
        filtergrid = True
        Cursor.Current = Cursors.WaitCursor
        Select Case varTabela

            Case "vendasportomescomp"
                Dim formgrid As New FormComp
                With formgrid
                    .vardatabase = varDatabase
                    .filterkeydir = filterkeydir
                    .flagfilterkeydir = flagfilterkeydir

                    .filterkeypais = filterkeypais
                    .filterkeycli = filterkeycli
                    .filterkeycomp = filterkeycomp
                    .filterkeymarca = filterkeymarca
                    .filterkeytype = filterkeytype
                    .filterkeygroup = filterkeygroup
                    .filterkeyprod = filterkeyprod
                    .flagfilterkeyprod = flagfilterkeyprod
                    .filterkeyanocol = filterkeyAnoCol
                    .filterkeypackage = filterkeyPackage
                    .filtergrid = filtergrid
                    .filtermark = Text1.Text
                    .FormComp_Load()
                End With
                Cursor.Current = Cursors.Default











        End Select

    End Sub
    Private Sub Command3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command3.Click
        Me.Close()
    End Sub


    Private Sub TreeView1_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView2.BeforeCheck
        If e.Node.Text = flagfilterkeydir Then e.Cancel() = True

    End Sub
    Private Sub TreeView1_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCheck
        If flagWork = True Then Exit Sub
        If Not e.Node.Text = "ALL" And Not e.Action = TreeViewAction.ByMouse Then Exit Sub
        If Not e.Node.Text = "ALL" Then TreeView1.Nodes(0).Nodes(0).Checked = False : Exit Sub

        Dim xt As TreeNode
        If e.Node.Text = "ALL" And TreeView1.Nodes(0).Nodes(0).Checked Then
            For Each xt In TreeView1.Nodes(0).Nodes
                If Not xt.Text = "ALL" Then xt.Checked = False
            Next
        End If


        Dim varstr As String
        varstr = flagfilterkeydir & " like '"
        'varstr = vbNullString
        For Each xt In TreeView1.Nodes(0).Nodes
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR " & flagfilterkeydir & " like '"
            End If
        Next
        Try
            filterkeydir = Microsoft.VisualBasic.Left(varstr, Len(varstr) - (19 + (Len(flagfilterkeydir) - 8)))
            filterkeypais = "Pais like '%'"
            filterkeycli = "Cliente like '%'"
            filterkeycomp = "Company like '%'"
            filterkeymarca = "Marca like '%'"
            filterkeytype = "Tipo like '%'"
            filterkeygroup = "Grupo like '%'"
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "Anocol like '%'"
            filterkeyPackage = "embalagem like '%'"
            treefill(0)
        Catch
            TreeView1.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

    End Sub
    Private Sub TreeView1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
        e.Cancel = True

    End Sub

    Private Sub TreeView2_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView2.BeforeCheck
        If e.Node.Text = "Market" Then e.Cancel() = True

    End Sub
    Private Sub TreeView2_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView2.AfterCheck
        If flagWork = True Then Exit Sub
        If Not e.Node.Text = "ALL" And Not e.Action = TreeViewAction.ByMouse Then Exit Sub
        If Not e.Node.Text = "ALL" Then TreeView2.Nodes(0).Nodes(0).Checked = False : Exit Sub

        Dim xt As TreeNode
        If e.Node.Text = "ALL" And TreeView2.Nodes(0).Nodes(0).Checked Then
            For Each xt In TreeView2.Nodes(0).Nodes
                If Not xt.Text = "ALL" Then xt.Checked = False
            Next
        End If


        Dim varstr As String
        varstr = "Pais like '"
        'varstr = vbNullString
        For Each xt In TreeView2.Nodes(0).Nodes
            If xt.Checked = True Then

                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR Pais like '"
            End If
        Next
        Try
            filterkeypais = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 15)
            filterkeycli = "Cliente like '%'"
            filterkeycomp = "Company like '%'"
            filterkeymarca = "Marca like '%'"
            filterkeytype = "Tipo like '%'"
            filterkeygroup = "Grupo like '%'"
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "Anocol like '%'"
            filterkeyPackage = "embalagem like '%'"
            treefill(1)
        Catch
            TreeView2.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

    End Sub
    Private Sub TreeView2_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView2.BeforeSelect
        e.Cancel = True

    End Sub

    Private Sub TreeView3_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView3.BeforeCheck
        If e.Node.Text = "Customer" Then e.Cancel() = True

    End Sub
    Private Sub TreeView3_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView3.AfterCheck
        If flagWork = True Then Exit Sub
        If Not e.Node.Text = "ALL" And Not e.Action = TreeViewAction.ByMouse Then Exit Sub
        If Not e.Node.Text = "ALL" Then TreeView3.Nodes(0).Nodes(0).Checked = False : Exit Sub

        Dim xt As TreeNode
        If e.Node.Text = "ALL" And TreeView3.Nodes(0).Nodes(0).Checked Then
            For Each xt In TreeView3.Nodes(0).Nodes
                If Not xt.Text = "ALL" Then xt.Checked = False
            Next
        End If


        Dim varstr As String
        varstr = "Cliente LIKE '"
        'varstr = vbNullString
        For Each xt In TreeView3.Nodes(0).Nodes
            If xt.Checked = True Then

                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR Cliente like '"
            End If
        Next
        Try
            filterkeycli = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 18)
            filterkeycomp = "Company like '%'"
            filterkeymarca = "Marca like '%'"
            filterkeytype = "Tipo like '%'"
            filterkeygroup = "Grupo like '%'"
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "Anocol like '%'"
            filterkeyPackage = "embalagem like '%'"
            treefill(2)
        Catch
            TreeView3.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

    End Sub
    Private Sub TreeView3_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView3.BeforeSelect
        e.Cancel = True

    End Sub

    Private Sub TreeView4_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView4.BeforeCheck
        If varTabela.Contains("madeira") Then
            If e.Node.Text = "Casta" Then e.Cancel() = True
        Else
            If e.Node.Text = "Company" Then e.Cancel() = True
        End If
    End Sub
    Private Sub TreeView4_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView4.AfterCheck
        If flagWork = True Then Exit Sub
        If Not e.Node.Text = "ALL" And Not e.Action = TreeViewAction.ByMouse Then Exit Sub
        If Not e.Node.Text = "ALL" Then TreeView4.Nodes(0).Nodes(0).Checked = False : Exit Sub

        Dim xt As TreeNode
        If e.Node.Text = "ALL" And TreeView4.Nodes(0).Nodes(0).Checked Then
            For Each xt In TreeView4.Nodes(0).Nodes
                If Not xt.Text = "ALL" Then xt.Checked = False
            Next
        End If


        Dim varstr As String
        varstr = "Company LIKE '"
        'varstr = vbNullString
        For Each xt In TreeView4.Nodes(0).Nodes
            If xt.Checked = True Then

                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR Company LIKE '"
            End If
        Next
        Try
            filterkeycomp = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 18)
            filterkeymarca = "Marca like '%'"
            filterkeytype = "Tipo like '%'"
            filterkeygroup = "Grupo like '%'"

            filterkeyprod = flagfilterkeyprod & " Like '%'"

            filterkeyAnoCol = "Anocol like '%'"
            filterkeyPackage = "embalagem like '%'"
            treefill(3)
        Catch
            TreeView4.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString

    End Sub
    Private Sub TreeView4_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView4.BeforeSelect
        e.Cancel = True

    End Sub

    Private Sub TreeView5_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView5.BeforeCheck
        If e.Node.Text = "Type" Then e.Cancel() = True

    End Sub
    Private Sub TreeView5_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView5.AfterCheck
        If flagWork = True Then Exit Sub

        If Not e.Node.Text = "ALL" And Not e.Action = TreeViewAction.ByMouse Then Exit Sub
        If Not e.Node.Text = "ALL" Then TreeView5.Nodes(0).Nodes(0).Checked = False : Exit Sub

        Dim xt As TreeNode
        If e.Node.Text = "ALL" And TreeView5.Nodes(0).Nodes(0).Checked Then
            For Each xt In TreeView5.Nodes(0).Nodes
                If Not xt.Text = "ALL" Then xt.Checked = False
            Next
        End If

        Dim varstr As String
        varstr = "Tipo LIKE '"
        'varstr = vbNullString
        For Each xt In TreeView5.Nodes(0).Nodes
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR tipo LIKE '"
            End If
        Next
        Try
            'filterkeymarca = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 16)
            filterkeytype = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 15)
            filterkeymarca = "Marca like '%'"
            filterkeygroup = "Grupo like '%'"

            filterkeyprod = flagfilterkeyprod & " Like '%'"

            filterkeyAnoCol = "Anocol like '%'"
            filterkeyPackage = "embalagem like '%'"
            treefill(4)
        Catch
            TreeView5.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString
    End Sub
    Private Sub TreeView5_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView5.BeforeSelect
        e.Cancel = True

    End Sub

    Private Sub TreeView6_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView6.BeforeCheck
        If e.Node.Text = "Trademark" Then e.Cancel = True
    End Sub
    Private Sub TreeView6_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView6.AfterCheck
        If flagWork = True Then Exit Sub
        If Not e.Node.Text = "ALL" And Not e.Action = TreeViewAction.ByMouse Then Exit Sub
        If Not e.Node.Text = "ALL" Then TreeView6.Nodes(0).Nodes(0).Checked = False : Exit Sub

        Dim xt As TreeNode
        If e.Node.Text = "ALL" And TreeView6.Nodes(0).Nodes(0).Checked Then
            For Each xt In TreeView6.Nodes(0).Nodes
                If Not xt.Text = "ALL" Then xt.Checked = False
            Next
        End If

        Dim varstr As String
        varstr = "Marca LIKE '"
        For Each xt In TreeView6.Nodes(0).Nodes
            If xt.Checked = True Then

                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR Marca LIKE '"

            End If
        Next
        Try
            filterkeymarca = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 16)
            filterkeygroup = "Grupo like '%'"

            filterkeyprod = flagfilterkeyprod & " Like '%'"

            filterkeyAnoCol = "Anocol like '%'"
            filterkeyPackage = "embalagem like '%'"
            treefill(5)
        Catch
            TreeView6.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString
    End Sub
    Private Sub TreeView6_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView6.BeforeSelect
        e.Cancel = True
    End Sub

    Private Sub TreeView7_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView7.BeforeCheck
        If e.Node.Text = "Group" Then e.Cancel() = True
    End Sub
    Private Sub TreeView7_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView7.AfterCheck
        If flagWork = True Then Exit Sub

        If Not e.Node.Text = "ALL" And Not e.Action = TreeViewAction.ByMouse Then Exit Sub
        If Not e.Node.Text = "ALL" Then TreeView7.Nodes(0).Nodes(0).Checked = False : Exit Sub

        Dim xt As TreeNode
        If e.Node.Text = "ALL" And TreeView7.Nodes(0).Nodes(0).Checked Then
            For Each xt In TreeView7.Nodes(0).Nodes
                If Not xt.Text = "ALL" Then xt.Checked = False
            Next
        End If


        Dim varstr As String
        varstr = "grupo LIKE '"
        For Each xt In TreeView7.Nodes(0).Nodes
            If xt.Checked = True Then

                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR grupo LIKE '"
            End If
        Next
        Try
            filterkeygroup = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 16)

            filterkeyprod = flagfilterkeyprod & " Like '%'"

            filterkeyAnoCol = "Anocol like '%'"
            filterkeyPackage = "embalagem like '%'"
            treefill(6)

        Catch
            TreeView7.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString
    End Sub
    Private Sub TreeView7_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView7.BeforeSelect
        e.Cancel = True
    End Sub

    Private Sub TreeView8_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView8.BeforeCheck
        If e.Node.Text = flagfilterkeyprod Then e.Cancel() = True

    End Sub
    Private Sub TreeView8_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView8.AfterCheck
        If flagWork = True Then Exit Sub

        If Not e.Node.Text = "ALL" And Not e.Action = TreeViewAction.ByMouse Then Exit Sub
        If Not e.Node.Text = "ALL" Then TreeView8.Nodes(0).Nodes(0).Checked = False : Exit Sub

        Dim xt As TreeNode
        If e.Node.Text = "ALL" And TreeView8.Nodes(0).Nodes(0).Checked Then
            For Each xt In TreeView8.Nodes(0).Nodes
                If Not xt.Text = "ALL" Then xt.Checked = False
            Next
        End If

        Dim varstr As String

        varstr = flagfilterkeyprod & " Like '"


        For Each xt In TreeView8.Nodes(0).Nodes
            If xt.Checked = True Then

                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR " & flagfilterkeyprod & " LIKE '"

            End If
        Next
        Try
            filterkeyprod = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 17)
            filterkeyAnoCol = "Anocol like '%'"
            filterkeyPackage = "embalagem like '%'"
            treefill(7)

        Catch
            TreeView8.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString
    End Sub
    Private Sub TreeView8_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView8.BeforeSelect
        e.Cancel = True
    End Sub

    Private Sub TreeView9_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView9.BeforeCheck
        If e.Node.Text = "VintageYear" Then e.Cancel() = True
    End Sub
    Private Sub TreeView9_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView9.AfterCheck
        If flagWork = True Then Exit Sub

        If Not e.Node.Text = "ALL" And Not e.Action = TreeViewAction.ByMouse Then Exit Sub
        If Not e.Node.Text = "ALL" Then TreeView9.Nodes(0).Nodes(0).Checked = False : Exit Sub

        Dim xt As TreeNode
        If e.Node.Text = "ALL" And TreeView9.Nodes(0).Nodes(0).Checked Then
            For Each xt In TreeView9.Nodes(0).Nodes
                If Not xt.Text = "ALL" Then xt.Checked = False
            Next
        End If



        Dim varstr As String
        varstr = "anoCol LIKE '"
        For Each xt In TreeView9.Nodes(0).Nodes
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR Anocol LIKE '"
            End If
        Next
        Try

            filterkeyAnoCol = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 17)
            filterkeyPackage = "embalagem like '%'"
            treefill(8)

        Catch
            TreeView9.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString
    End Sub
    Private Sub TreeView9_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView9.BeforeSelect
        e.Cancel = True
    End Sub

    Private Sub TreeView10_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView10.BeforeCheck
        If e.Node.Text = "Package" Then e.Cancel() = True
    End Sub
    Private Sub TreeView10_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView10.AfterCheck
        If flagWork = True Then Exit Sub
        If Not e.Node.Text = "ALL" And Not e.Action = TreeViewAction.ByMouse Then Exit Sub
        If Not e.Node.Text = "ALL" Then TreeView10.Nodes(0).Nodes(0).Checked = False : Exit Sub

        Dim xt As TreeNode
        If e.Node.Text = "ALL" And TreeView10.Nodes(0).Nodes(0).Checked Then
            For Each xt In TreeView10.Nodes(0).Nodes
                If Not xt.Text = "ALL" Then xt.Checked = False
            Next
        End If


        Dim varstr As String
        varstr = "embalagem LIKE '"
        For Each xt In TreeView10.Nodes(0).Nodes
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR embalagem LIKE '"
            End If
        Next
        Try

            filterkeyPackage = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 20)
            ' treefill(8)

        Catch
            TreeView10.Nodes(0).Nodes(0).Checked = True
        End Try

        Text1.Text = vbNullString
    End Sub
    Private Sub TreeView10_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView10.BeforeSelect
        e.Cancel = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ButtonGroupMarket.BringToFront()
        ButtonGroupTrademark.BringToFront()
        ButtonGroupSubCat.BringToFront()
        ButtonGroupVintageYear.BringToFront()
        ButtonGroupPackage.BringToFront()
        ButtonGroupProduct.BringToFront()

        ButtonGroupMarket.Visible = True Xor ButtonGroupMarket.Visible
        ButtonGroupTrademark.Visible = True Xor ButtonGroupTrademark.Visible
        ButtonGroupSubCat.Visible = True Xor ButtonGroupSubCat.Visible
        ButtonGroupVintageYear.Visible = True Xor ButtonGroupVintageYear.Visible
        ButtonGroupPackage.Visible = True Xor ButtonGroupPackage.Visible
        ButtonGroupProduct.Visible = True Xor ButtonGroupProduct.Visible
    End Sub

    Public Function SQ(ByVal str As String) As String
        SQ = Replace(str, "'", "''", 1, -1, vbTextCompare)
    End Function






    Private Sub btSwitchCatFam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSwitchCatFam.Click
        If flagfilterkeyprod = "Subcat" Then
            flagfilterkeyprod = "Family"
        Else
            flagfilterkeyprod = "Subcat"
        End If

        filterkeydir = flagfilterkeydir & " like '%'"
        filterkeypais = "pais like '%'"
        filterkeycli = "cliente like '%'"
        filterkeycomp = "Company like '%'"
        filterkeymarca = "Marca like '%'"
        filterkeytype = "Tipo like '%'"
        filterkeygroup = "Grupo like '%'"

        filterkeyprod = flagfilterkeyprod & " Like '%'"

        filterkeyAnoCol = "Anocol like '%'"
        filterkeyPackage = "embalagem like '%'"

        Dim strsql As String
        'Dim reader As System.Data.SqlClient.SqlDataReader
        Dim reader As System.Data.OleDb.OleDbDataReader
        ds = New DataSet
        dsHelper = New DataSetHelper.DataSetHelper(ds)
        strsql = "SELECT " & flagfilterkeydir & ", pais, cliente, company, Tipo, Marca, Grupo, " & flagfilterkeyprod & ", Anocol, embalagem  FROM " & varTabela

        Dim sqlcommand1 As New OleDb.OleDbCommand
        Dim SqlConnection1 As New OleDb.OleDbConnection
        SqlConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=" & varDatabase & ";Mode=Read"
        sqlcommand1.CommandText = strsql
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        Dim tabela As New DataTable

        'Dim workCol As DataColumn = 
        tabela.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
        tabela.Columns.Add("pais", Type.GetType("System.String"))
        tabela.Columns.Add("cliente", Type.GetType("System.String"))
        tabela.Columns.Add("company", Type.GetType("System.String"))
        tabela.Columns.Add("Tipo", Type.GetType("System.String"))
        tabela.Columns.Add("Marca", Type.GetType("System.String"))
        tabela.Columns.Add("Grupo", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
        tabela.Columns.Add("Anocol", Type.GetType("System.String"))
        tabela.Columns.Add("embalagem", Type.GetType("System.String"))
        Dim myRow As DataRow

        reader = sqlcommand1.ExecuteReader



        While reader.Read
            myRow = tabela.NewRow()
            myRow(flagfilterkeydir) = reader.Item(0)
            myRow("pais") = reader.Item(1)
            myRow("cliente") = reader.Item(2)
            myRow("company") = reader.Item(3)
            myRow("Tipo") = reader.Item(4)
            myRow("Marca") = reader.Item(5)
            myRow("Grupo") = reader.Item(6)
            myRow(flagfilterkeyprod) = reader.Item(7)
            myRow("Anocol") = reader.Item(8)
            myRow("embalagem") = reader.Item(9)
            tabela.Rows.Add(myRow)
        End While

        ds.Tables.Add(tabela)
        reader.Close()
        SqlConnection1.Close()



        treefill(-1)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case varTabela

            Case "vendasportomescomp", "vendasmadeiramescomp"
                Cursor.Current = Cursors.WaitCursor
                Dim formpivot As New FormPivotComp
                With formpivot
                    '.vardatabase = varDatabase
                    .vartabela = varTabela
                    .filterkeydir = filterkeydir
                    .flagfilterkeydir = flagfilterkeydir

                    .filterkeypais = filterkeypais
                    .filterkeycli = filterkeycli
                    .filterkeycomp = filterkeycomp
                    .filterkeymarca = filterkeymarca
                    .filterkeytype = filterkeytype
                    .filterkeygroup = filterkeygroup
                    .filterkeyprod = filterkeyprod
                    .flagfilterkeyprod = flagfilterkeyprod
                    .filterkeyAnocol = filterkeyAnoCol
                    .filterkeypackage = filterkeyPackage
                    .filtergrid = filtergrid

                    .Groupsubcat = True
                    .filtermark = Text1.Text
                    .MdiParent = Me.MdiParent
                    .Show()
                End With
                Cursor.Current = Cursors.Default
            Case "vendasportomescomp2"
                Cursor.Current = Cursors.WaitCursor
                Dim formpivot As New FormPivotComp
                With formpivot
                    '.vardatabase = varDatabase
                    .vartabela = varTabela
                    .filterkeydir = filterkeydir
                    .flagfilterkeydir = flagfilterkeydir

                    .filterkeypais = filterkeypais
                    .filterkeycli = filterkeycli
                    .filterkeycomp = filterkeycomp
                    .filterkeymarca = filterkeymarca
                    .filterkeytype = filterkeytype
                    .filterkeygroup = filterkeygroup
                    .filterkeyprod = filterkeyprod
                    .flagfilterkeyprod = flagfilterkeyprod
                    .filterkeyAnocol = filterkeyAnoCol
                    .filterkeypackage = filterkeyPackage
                    .filtergrid = filtergrid

                    .Groupsubcat = True
                    .filtermark = Text1.Text
                    .MdiParent = Me.MdiParent
                    .Show()
                End With
                Cursor.Current = Cursors.Default

            Case "vendasportomescompvalor"
                Cursor.Current = Cursors.WaitCursor
                Dim formpivot As New FormPivotComp
                With formpivot
                    '.vardatabase = varDatabase
                    .vartabela = varTabela
                    .filterkeydir = filterkeydir
                    .flagfilterkeydir = flagfilterkeydir

                    .filterkeypais = filterkeypais
                    .filterkeycli = filterkeycli
                    .filterkeycomp = filterkeycomp
                    .filterkeymarca = filterkeymarca
                    .filterkeytype = filterkeytype
                    .filterkeygroup = filterkeygroup
                    .filterkeyprod = filterkeyprod
                    .flagfilterkeyprod = flagfilterkeyprod
                    .filterkeyAnocol = filterkeyAnoCol
                    .filterkeypackage = filterkeyPackage
                    .filtergrid = filtergrid

                    .Groupsubcat = True
                    .filtermark = Text1.Text
                    .MdiParent = Me.MdiParent
                    .Show()
                End With
                Cursor.Current = Cursors.Default

        End Select

    End Sub

    Private Sub btSwitchDirManAssist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSwitchDirManAssist.Click

        If flagfilterkeydir = "director" Then
            flagfilterkeydir = "Secretari"
        ElseIf flagfilterkeydir = "Secretari" Then
            flagfilterkeydir = "SalesManager"
        Else
            flagfilterkeydir = "director"
        End If

        filterkeydir = flagfilterkeydir & " like '%'"
        filterkeypais = "pais like '%'"
        filterkeycli = "cliente like '%'"
        filterkeycomp = "Company like '%'"
        filterkeymarca = "Marca like '%'"
        filterkeytype = "Tipo like '%'"
        filterkeygroup = "Grupo like '%'"

        filterkeyprod = flagfilterkeyprod & " Like '%'"

        filterkeyAnoCol = "Anocol like '%'"
        filterkeyPackage = "embalagem like '%'"

        Dim strsql As String
        'Dim reader As System.Data.SqlClient.SqlDataReader
        Dim reader As System.Data.OleDb.OleDbDataReader
        ds = New DataSet
        dsHelper = New DataSetHelper.DataSetHelper(ds)
        strsql = "SELECT " & flagfilterkeydir & ", pais, cliente, company, Tipo, Marca, Grupo, " & flagfilterkeyprod & ", Anocol, embalagem  FROM " & varTabela

        Dim sqlcommand1 As New OleDb.OleDbCommand
        Dim SqlConnection1 As New OleDb.OleDbConnection
        SqlConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=" & varDatabase & ";Mode=Read"
        sqlcommand1.CommandText = strsql
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        Dim tabela As New DataTable

        'Dim workCol As DataColumn = 
        tabela.Columns.Add(flagfilterkeydir, Type.GetType("System.String"))
        tabela.Columns.Add("pais", Type.GetType("System.String"))
        tabela.Columns.Add("cliente", Type.GetType("System.String"))
        tabela.Columns.Add("company", Type.GetType("System.String"))
        tabela.Columns.Add("Tipo", Type.GetType("System.String"))
        tabela.Columns.Add("Marca", Type.GetType("System.String"))
        tabela.Columns.Add("Grupo", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))
        tabela.Columns.Add("Anocol", Type.GetType("System.String"))
        tabela.Columns.Add("embalagem", Type.GetType("System.String"))
        Dim myRow As DataRow
        Try
            reader = sqlcommand1.ExecuteReader
        Catch
            MsgBox("Faltam dados sales Manager!")
            Exit Sub
        End Try



        While reader.Read
            myRow = tabela.NewRow()
            myRow(flagfilterkeydir) = reader.Item(0)
            myRow("pais") = reader.Item(1)
            myRow("cliente") = reader.Item(2)
            myRow("company") = reader.Item(3)
            myRow("Tipo") = reader.Item(4)
            myRow("Marca") = reader.Item(5)
            myRow("Grupo") = reader.Item(6)
            myRow(flagfilterkeyprod) = reader.Item(7)
            myRow("Anocol") = reader.Item(8)
            myRow("embalagem") = reader.Item(9)
            tabela.Rows.Add(myRow)
        End While

        ds.Tables.Add(tabela)
        reader.Close()
        SqlConnection1.Close()



        treefill(-1)




    End Sub
End Class
