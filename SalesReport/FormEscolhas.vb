Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing

Public Class FormEscolhas


    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Panelvalores As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Buttonmesvalores As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Buttonlastyearvalores As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents Button39 As System.Windows.Forms.Button
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents PanelTrade As System.Windows.Forms.Panel
    Friend WithEvents BtCompTrade As System.Windows.Forms.Button
    Friend WithEvents BtCompTrade_Hist As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button30 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEscolhas))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.PanelTrade = New System.Windows.Forms.Panel()
        Me.BtCompTrade = New System.Windows.Forms.Button()
        Me.BtCompTrade_Hist = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.Button39 = New System.Windows.Forms.Button()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panelvalores = New System.Windows.Forms.Panel()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Buttonmesvalores = New System.Windows.Forms.Button()
        Me.Buttonlastyearvalores = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTrade.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panelvalores.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.CommercialSystem.My.Resources.Resources.SAP_logo
        Me.PictureBox1.Location = New System.Drawing.Point(509, 657)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Button38
        '
        Me.Button38.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button38.ForeColor = System.Drawing.Color.Transparent
        Me.Button38.Image = Global.CommercialSystem.My.Resources.Resources.btnpricing
        Me.Button38.Location = New System.Drawing.Point(-8, 470)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(256, 80)
        Me.Button38.TabIndex = 40
        '
        'PanelTrade
        '
        Me.PanelTrade.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelTrade.BackColor = System.Drawing.Color.Transparent
        Me.PanelTrade.BackgroundImage = Global.CommercialSystem.My.Resources.Resources.COMMERCIAL_SYSTEM_janelasalesreportTrade
        Me.PanelTrade.Controls.Add(Me.BtCompTrade)
        Me.PanelTrade.Controls.Add(Me.BtCompTrade_Hist)
        Me.PanelTrade.Controls.Add(Me.Label1)
        Me.PanelTrade.Location = New System.Drawing.Point(470, 16)
        Me.PanelTrade.Name = "PanelTrade"
        Me.PanelTrade.Size = New System.Drawing.Size(498, 218)
        Me.PanelTrade.TabIndex = 39
        Me.PanelTrade.Visible = False
        '
        'BtCompTrade
        '
        Me.BtCompTrade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtCompTrade.BackColor = System.Drawing.Color.White
        Me.BtCompTrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCompTrade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCompTrade.ForeColor = System.Drawing.Color.Maroon
        Me.BtCompTrade.Location = New System.Drawing.Point(16, 56)
        Me.BtCompTrade.Name = "BtCompTrade"
        Me.BtCompTrade.Size = New System.Drawing.Size(128, 26)
        Me.BtCompTrade.TabIndex = 41
        Me.BtCompTrade.Text = "Comparison"
        Me.BtCompTrade.UseVisualStyleBackColor = False
        '
        'BtCompTrade_Hist
        '
        Me.BtCompTrade_Hist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtCompTrade_Hist.BackColor = System.Drawing.Color.White
        Me.BtCompTrade_Hist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCompTrade_Hist.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCompTrade_Hist.ForeColor = System.Drawing.Color.Maroon
        Me.BtCompTrade_Hist.Location = New System.Drawing.Point(168, 45)
        Me.BtCompTrade_Hist.Name = "BtCompTrade_Hist"
        Me.BtCompTrade_Hist.Size = New System.Drawing.Size(128, 24)
        Me.BtCompTrade_Hist.TabIndex = 42
        Me.BtCompTrade_Hist.Text = "Historic"
        Me.BtCompTrade_Hist.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(477, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.CommercialSystem.My.Resources.Resources.COMMERCIAL_SYSTEN_janelasalesreport
        Me.Panel1.Controls.Add(Me.Button40)
        Me.Panel1.Controls.Add(Me.Button39)
        Me.Panel1.Controls.Add(Me.Button37)
        Me.Panel1.Controls.Add(Me.Button33)
        Me.Panel1.Controls.Add(Me.Button32)
        Me.Panel1.Controls.Add(Me.Button35)
        Me.Panel1.Controls.Add(Me.Button36)
        Me.Panel1.Controls.Add(Me.Button34)
        Me.Panel1.Controls.Add(Me.Button29)
        Me.Panel1.Controls.Add(Me.Button23)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(321, 203)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 417)
        Me.Panel1.TabIndex = 34
        '
        'Button40
        '
        Me.Button40.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button40.BackColor = System.Drawing.Color.White
        Me.Button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button40.ForeColor = System.Drawing.Color.Maroon
        Me.Button40.Location = New System.Drawing.Point(168, 376)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(128, 24)
        Me.Button40.TabIndex = 40
        Me.Button40.Text = "LastYear/ThisYear"
        Me.Button40.UseVisualStyleBackColor = False
        Me.Button40.Visible = False
        '
        'Button39
        '
        Me.Button39.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button39.BackColor = System.Drawing.Color.White
        Me.Button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button39.ForeColor = System.Drawing.Color.Maroon
        Me.Button39.Location = New System.Drawing.Point(168, 347)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(128, 24)
        Me.Button39.TabIndex = 39
        Me.Button39.Text = "LastYear/ThisYear"
        Me.Button39.UseVisualStyleBackColor = False
        Me.Button39.Visible = False
        '
        'Button37
        '
        Me.Button37.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button37.BackColor = System.Drawing.Color.White
        Me.Button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button37.ForeColor = System.Drawing.Color.Maroon
        Me.Button37.Location = New System.Drawing.Point(16, 376)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(128, 24)
        Me.Button37.TabIndex = 37
        Me.Button37.Text = "Comp. By Month"
        Me.Button37.UseVisualStyleBackColor = False
        Me.Button37.Visible = False
        '
        'Button33
        '
        Me.Button33.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button33.BackColor = System.Drawing.Color.White
        Me.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button33.ForeColor = System.Drawing.Color.Maroon
        Me.Button33.Location = New System.Drawing.Point(16, 347)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(128, 24)
        Me.Button33.TabIndex = 36
        Me.Button33.Text = "Comparison"
        Me.Button33.UseVisualStyleBackColor = False
        Me.Button33.Visible = False
        '
        'Button32
        '
        Me.Button32.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button32.BackColor = System.Drawing.Color.White
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.ForeColor = System.Drawing.Color.Maroon
        Me.Button32.Location = New System.Drawing.Point(16, 283)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(128, 24)
        Me.Button32.TabIndex = 35
        Me.Button32.Text = "By Month - Last Year"
        Me.Button32.UseVisualStyleBackColor = False
        Me.Button32.Visible = False
        '
        'Button35
        '
        Me.Button35.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button35.BackColor = System.Drawing.Color.White
        Me.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button35.ForeColor = System.Drawing.Color.Maroon
        Me.Button35.Location = New System.Drawing.Point(168, 163)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(128, 24)
        Me.Button35.TabIndex = 17
        Me.Button35.Text = "LastYear/ThisYear"
        Me.Button35.UseVisualStyleBackColor = False
        Me.Button35.Visible = False
        '
        'Button36
        '
        Me.Button36.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button36.BackColor = System.Drawing.Color.White
        Me.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button36.ForeColor = System.Drawing.Color.Maroon
        Me.Button36.Location = New System.Drawing.Point(168, 131)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(128, 24)
        Me.Button36.TabIndex = 16
        Me.Button36.Text = "Year-2/LastYear"
        Me.Button36.UseVisualStyleBackColor = False
        Me.Button36.Visible = False
        '
        'Button34
        '
        Me.Button34.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button34.BackColor = System.Drawing.Color.White
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button34.ForeColor = System.Drawing.Color.Maroon
        Me.Button34.Location = New System.Drawing.Point(16, 146)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(128, 24)
        Me.Button34.TabIndex = 15
        Me.Button34.Text = "Comparison"
        Me.Button34.UseVisualStyleBackColor = False
        Me.Button34.Visible = False
        '
        'Button29
        '
        Me.Button29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button29.BackColor = System.Drawing.Color.White
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.ForeColor = System.Drawing.Color.Maroon
        Me.Button29.Location = New System.Drawing.Point(168, 190)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(128, 24)
        Me.Button29.TabIndex = 14
        Me.Button29.Text = "LastYear/ThisYear"
        Me.Button29.UseVisualStyleBackColor = False
        Me.Button29.Visible = False
        '
        'Button23
        '
        Me.Button23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button23.BackColor = System.Drawing.Color.White
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ForeColor = System.Drawing.Color.Maroon
        Me.Button23.Location = New System.Drawing.Point(168, 158)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(128, 24)
        Me.Button23.TabIndex = 13
        Me.Button23.Text = "Year-2/LastYear"
        Me.Button23.UseVisualStyleBackColor = False
        Me.Button23.Visible = False
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Location = New System.Drawing.Point(478, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(16, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "By Month"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Maroon
        Me.Button5.Location = New System.Drawing.Point(16, 81)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 24)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "By Month - Last Year"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Maroon
        Me.Button2.Location = New System.Drawing.Point(16, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "By Year"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button15
        '
        Me.Button15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button15.BackColor = System.Drawing.Color.White
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.Maroon
        Me.Button15.Location = New System.Drawing.Point(16, 176)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(128, 24)
        Me.Button15.TabIndex = 11
        Me.Button15.Text = "Comp. By Month"
        Me.Button15.UseVisualStyleBackColor = False
        Me.Button15.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Maroon
        Me.Button3.Location = New System.Drawing.Point(16, 252)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 24)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "By Month"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Maroon
        Me.Button4.Location = New System.Drawing.Point(16, 313)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 24)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "By Year"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Panelvalores
        '
        Me.Panelvalores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panelvalores.BackColor = System.Drawing.Color.Transparent
        Me.Panelvalores.BackgroundImage = Global.CommercialSystem.My.Resources.Resources.COMMERCIAL_SYSTEM_janelasalesreportValues
        Me.Panelvalores.Controls.Add(Me.Button14)
        Me.Panelvalores.Controls.Add(Me.Button21)
        Me.Panelvalores.Controls.Add(Me.Button31)
        Me.Panelvalores.Controls.Add(Me.Button30)
        Me.Panelvalores.Controls.Add(Me.Label6)
        Me.Panelvalores.Controls.Add(Me.Buttonmesvalores)
        Me.Panelvalores.Controls.Add(Me.Buttonlastyearvalores)
        Me.Panelvalores.Controls.Add(Me.Button25)
        Me.Panelvalores.Controls.Add(Me.Button26)
        Me.Panelvalores.Controls.Add(Me.Button27)
        Me.Panelvalores.Controls.Add(Me.Button28)
        Me.Panelvalores.Controls.Add(Me.Button24)
        Me.Panelvalores.Location = New System.Drawing.Point(353, 83)
        Me.Panelvalores.Name = "Panelvalores"
        Me.Panelvalores.Size = New System.Drawing.Size(498, 365)
        Me.Panelvalores.TabIndex = 34
        Me.Panelvalores.Visible = False
        '
        'Button14
        '
        Me.Button14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button14.BackColor = System.Drawing.Color.White
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.Maroon
        Me.Button14.Location = New System.Drawing.Point(168, 161)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(128, 24)
        Me.Button14.TabIndex = 43
        Me.Button14.Text = "LastYear/ThisYear"
        Me.Button14.UseVisualStyleBackColor = False
        Me.Button14.Visible = False
        '
        'Button21
        '
        Me.Button21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button21.BackColor = System.Drawing.Color.White
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.Maroon
        Me.Button21.Location = New System.Drawing.Point(16, 142)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(128, 26)
        Me.Button21.TabIndex = 41
        Me.Button21.Text = "Comparison"
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button31.BackColor = System.Drawing.Color.White
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button31.ForeColor = System.Drawing.Color.Maroon
        Me.Button31.Location = New System.Drawing.Point(168, 127)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(128, 24)
        Me.Button31.TabIndex = 42
        Me.Button31.Text = "Year-2/LastYear"
        Me.Button31.UseVisualStyleBackColor = False
        Me.Button31.Visible = False
        '
        'Button30
        '
        Me.Button30.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button30.BackColor = System.Drawing.Color.White
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.ForeColor = System.Drawing.Color.Maroon
        Me.Button30.Location = New System.Drawing.Point(168, 189)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(128, 24)
        Me.Button30.TabIndex = 40
        Me.Button30.Text = "LastYear/ThisYear"
        Me.Button30.UseVisualStyleBackColor = False
        Me.Button30.Visible = False
        '
        'Label6
        '
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Location = New System.Drawing.Point(477, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 12
        '
        'Buttonmesvalores
        '
        Me.Buttonmesvalores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Buttonmesvalores.BackColor = System.Drawing.Color.White
        Me.Buttonmesvalores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buttonmesvalores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonmesvalores.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonmesvalores.ForeColor = System.Drawing.Color.DarkRed
        Me.Buttonmesvalores.Location = New System.Drawing.Point(16, 55)
        Me.Buttonmesvalores.Name = "Buttonmesvalores"
        Me.Buttonmesvalores.Size = New System.Drawing.Size(128, 24)
        Me.Buttonmesvalores.TabIndex = 1
        Me.Buttonmesvalores.Text = "By Month"
        Me.Buttonmesvalores.UseVisualStyleBackColor = False
        '
        'Buttonlastyearvalores
        '
        Me.Buttonlastyearvalores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Buttonlastyearvalores.BackColor = System.Drawing.Color.White
        Me.Buttonlastyearvalores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonlastyearvalores.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonlastyearvalores.ForeColor = System.Drawing.Color.Maroon
        Me.Buttonlastyearvalores.Location = New System.Drawing.Point(16, 85)
        Me.Buttonlastyearvalores.Name = "Buttonlastyearvalores"
        Me.Buttonlastyearvalores.Size = New System.Drawing.Size(128, 24)
        Me.Buttonlastyearvalores.TabIndex = 2
        Me.Buttonlastyearvalores.Text = "By Month - Last Year"
        Me.Buttonlastyearvalores.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button25.BackColor = System.Drawing.Color.White
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.ForeColor = System.Drawing.Color.Maroon
        Me.Button25.Location = New System.Drawing.Point(16, 115)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(128, 24)
        Me.Button25.TabIndex = 3
        Me.Button25.Text = "By Year"
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button26.BackColor = System.Drawing.Color.White
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.ForeColor = System.Drawing.Color.Maroon
        Me.Button26.Location = New System.Drawing.Point(16, 172)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(128, 26)
        Me.Button26.TabIndex = 11
        Me.Button26.Text = "Comp. By Month"
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button27.BackColor = System.Drawing.Color.White
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.ForeColor = System.Drawing.Color.Maroon
        Me.Button27.Location = New System.Drawing.Point(16, 264)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(128, 24)
        Me.Button27.TabIndex = 4
        Me.Button27.Text = "By Month"
        Me.Button27.UseVisualStyleBackColor = False
        Me.Button27.Visible = False
        '
        'Button28
        '
        Me.Button28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button28.BackColor = System.Drawing.Color.White
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.ForeColor = System.Drawing.Color.Maroon
        Me.Button28.Location = New System.Drawing.Point(16, 296)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(128, 24)
        Me.Button28.TabIndex = 5
        Me.Button28.Text = "By Year"
        Me.Button28.UseVisualStyleBackColor = False
        Me.Button28.Visible = False
        '
        'Button24
        '
        Me.Button24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button24.BackColor = System.Drawing.Color.White
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.Color.Maroon
        Me.Button24.Location = New System.Drawing.Point(168, 157)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(128, 24)
        Me.Button24.TabIndex = 39
        Me.Button24.Text = "Year-2/LastYear"
        Me.Button24.UseVisualStyleBackColor = False
        Me.Button24.Visible = False
        '
        'Button22
        '
        Me.Button22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button22.Enabled = False
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.ForeColor = System.Drawing.Color.Transparent
        Me.Button22.Image = CType(resources.GetObject("Button22.Image"), System.Drawing.Image)
        Me.Button22.Location = New System.Drawing.Point(-8, 88)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(256, 80)
        Me.Button22.TabIndex = 38
        Me.Button22.Visible = False
        '
        'Button20
        '
        Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.ForeColor = System.Drawing.Color.Transparent
        Me.Button20.Image = CType(resources.GetObject("Button20.Image"), System.Drawing.Image)
        Me.Button20.Location = New System.Drawing.Point(-8, 173)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(256, 80)
        Me.Button20.TabIndex = 32
        Me.Button20.Visible = False
        '
        'Button17
        '
        Me.Button17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.ForeColor = System.Drawing.Color.Transparent
        Me.Button17.Image = CType(resources.GetObject("Button17.Image"), System.Drawing.Image)
        Me.Button17.Location = New System.Drawing.Point(-8, 8)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(256, 80)
        Me.Button17.TabIndex = 29
        '
        'Button16
        '
        Me.Button16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.ForeColor = System.Drawing.Color.Transparent
        Me.Button16.Image = CType(resources.GetObject("Button16.Image"), System.Drawing.Image)
        Me.Button16.Location = New System.Drawing.Point(0, 648)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(200, 80)
        Me.Button16.TabIndex = 28
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.CommercialSystem.My.Resources.Resources.commercialsystembarra1
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(647, 640)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(371, 115)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox8.Location = New System.Drawing.Point(0, 624)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(1040, 136)
        Me.PictureBox8.TabIndex = 26
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox9.BackgroundImage = Global.CommercialSystem.My.Resources.Resources.fundoCommercialSystem
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox9.InitialImage = Nothing
        Me.PictureBox9.Location = New System.Drawing.Point(216, 136)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(584, 320)
        Me.PictureBox9.TabIndex = 35
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Visible = False
        '
        'FormEscolhas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1040, 760)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button38)
        Me.Controls.Add(Me.PanelTrade)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panelvalores)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEscolhas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTrade.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panelvalores.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '  Cursor.Current = Cursors.WaitCursor
        '  Dim Formtrees As New FormTreesPivot
        '  With Formtrees
        '.MdiParent = Me.MdiParent
        '  .varTabela = "Sapsales"
        '  .varDatabase = "c:\CommercialSystem\dados\db3.mdb"

        '  .Label1.Text = "By Month"
        ' ' .Show()
        '  End With
        '  Cursor.Current = Cursors.Default


        Cursor.Current = Cursors.WaitCursor



        Dim formgrid As New FormPivotMesFull
        With formgrid

            .vartabela = "Sapsales"
            .MdiParent = Me.MdiParent
            .Show()
        End With
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Cursor.Current = Cursors.WaitCursor
        'Dim Formtrees As New FormTrees
        Dim Formtrees As New FormTreesPivot
        With Formtrees
            .MdiParent = Me.MdiParent
            .varTabela = "SALESCOMPLETISSIMOHISTORICOQUANT"
            .varDatabase = "c:\CommercialSystem\dados\db3.mdb"

            .Label1.Text = "History"
            '   .image1.Image = PictureBox1.Image
            .Show()
        End With
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTrees
        With Formtrees
            .MdiParent = Me.MdiParent
            .varTabela = "vendasmadeiramesfull"
            .varDatabase = "c:\CommercialSystem\dados\db2.mdb"
            .Label1.Font = New System.Drawing.Font("Arial", 12)
            .Label1.Text = "Madeira By Month "
            '  .image1.Image = PictureBox2.Image
            .Show()
        End With
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTrees
        With Formtrees
            .MdiParent = Me.MdiParent
            .varTabela = "vendasmadeirahistfull"
            .varDatabase = "c:\CommercialSystem\dados\db2.mdb"
            .Label1.Font = New System.Drawing.Font("Arial", 12)
            .Label1.Text = "Madeira History"
            '  .image1.Image = PictureBox2.Image
            .Show()
        End With
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Cursor.Current = Cursors.WaitCursor
        'Dim Formtrees As New FormTrees
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me.MdiParent
            '.varTabela = "vendasportomesfullano1"
            '.varDatabase = "c:\CommercialSystem\dados\db2.mdb"
            .varTabela = "SALESCOMPLETISSIMOQUANTANO1"
            .varDatabase = "c:\CommercialSystem\dados\db3.mdb"
            .Label1.Font = New System.Drawing.Font("Arial", 12)
            .Label1.Text = "By Month - Last Year"
            '    .image1.Image = PictureBox1.Image
            .Show()
        End With

        Cursor.Current = Cursors.Default

    End Sub



    Private Sub Command3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Application.Exit()
    End Sub







    Private Sub FormEscolhas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        Me.SuspendLayout()
        Me.Width = Me.MdiParent.ClientSize.Width - 4
        Me.Height = Me.MdiParent.ClientSize.Height - 4
        Panelvalores.Location = New Point(300, 128)
        PanelTrade.Location = New Point(300, 128)
        Panel1.Location = New Point(300, 128)
        Me.ResumeLayout()

        '  Label1_Click(Me, e)
        Me.MdiParent.Text = Me.MdiParent.Text & " - (Last update: " & GetSetting("SalesReports", "Updated", "date") & ")"
        Dim editusers As New ArrayList
        editusers.Add("PV")
        editusers.Add("IF")
        editusers.Add("MMC")
        If editusers.Contains(UCase(GetSetting("SalesReports", "User", "login"))) Then
            'EditDepl.Enabled = True
        End If



        'Button22.Enabled = True
        'Button22.Visible = True




    End Sub











    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Cursor.Current = Cursors.WaitCursor

        Dim formescolhaspricing As New FormEscolhasPricings
        formescolhaspricing.MdiParent = Me.MdiParent
        formescolhaspricing.Show()

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Panel1.Visible = True

        Panelvalores.Visible = False
        PanelTrade.Visible = False
    End Sub

    Private Sub Button17_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button17.MouseDown

    End Sub

    Private Sub Button17_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button17.MouseHover
        'Button17.Image = Image.FromFile("C:\Documents and Settings\brq\Os meus documentos\salesdesign\btnsales2.png")
    End Sub

    Private Sub Button17_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button17.MouseLeave
        'Button17.Image = Image.FromFile("C:\Documents and Settings\brq\Os meus documentos\salesdesign\btnsales.png")
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel1.Visible = False

        Panelvalores.Visible = False
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Panel1.Visible = False

        Panelvalores.Visible = False
    End Sub

    Private Sub Label4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel1.Visible = False

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel1.Visible = False

        Panelvalores.Visible = False
    End Sub

    Private Sub Buttonmesvalores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonmesvalores.Click
        Cursor.Current = Cursors.WaitCursor
        Dim FormTreesVal As New FormTreesPivot
        'Dim FormTreesVal As New FormTreesValor
        With FormTreesVal

            .MdiParent = Me.MdiParent
            .varTabela = "salescompletissimo"
            '.varTabela = "vendasportomesfullvalor"
            .varDatabase = "c:\CommercialSystem\dados\db3.mdb"
            .Label1.Font = New System.Drawing.Font("Arial", 12)
            .Label1.Text = "Values By Month"
            .flagValores = True
            .Show()
        End With

        Cursor.Current = Cursors.Default

    End Sub



    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Panelvalores.Visible = False
        Panel1.Visible = False

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Panelvalores.Visible = True
        Panel1.Visible = False

        PanelTrade.Visible = False
    End Sub

    Private Sub Panelvalores_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panelvalores.MouseDown
        Panelvalores.DoDragDrop(Panelvalores, DragDropEffects.Copy)
    End Sub

    Private Sub Panelvalores_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Panelvalores.DragEnter
        ' See if the data includes a Label.
        If e.Data.GetDataPresent(GetType(Panel)) Then
            ' There is Label data. Allow copy.
            e.Effect = DragDropEffects.Copy
            ' Highlight the control.
            Panelvalores.BorderStyle = BorderStyle.FixedSingle
        Else
            ' There is no Panel. Prohibit drop.
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Panelvalores_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panelvalores.DragLeave
        Panelvalores.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub Panelvalores_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Panelvalores.DragDrop
        Dim lbl As Label = DirectCast( _
     e.Data.GetData(GetType(Label)), Label)
        Dim p As Panel = DirectCast(e.Data.GetData(GetType(Panel)), Panel)
        Panelvalores.Text = p.Text
        Panelvalores.BackColor = p.BackColor
        Panelvalores.BorderStyle = BorderStyle.Fixed3D
        'lblLabelTarget.Text = lbl.Text
        'lblLabelTarget.BackColor = lbl.BackColor
        'lblLabelTarget.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        'Cursor.Current = Cursors.WaitCursor
        'Me.SuspendLayout()
        'Dim formgrid As New IVPSTATS.FormGridIVP
        'With formgrid
        ' .MdiParent = Me.MdiParent
        ' .Show()
        ' End With
        ' Me.ResumeLayout()
        'Cursor.Current = Cursors.Default

        Panelvalores.Visible = False
        Panel1.Visible = False

        PanelTrade.Visible = True
    End Sub


    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Button24.Visible = True
        Button30.Visible = True
        Button14.Visible = False
        Button31.Visible = False
    End Sub



    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Cursor.Current = Cursors.WaitCursor
        Button23.Visible = False
        Button29.Visible = False
        Dim Formtreescomp As New FormTreesComp
        With Formtreescomp
            .MdiParent = Me.MdiParent
            .varTabela = "vendasportomescomp"
            .varDatabase = "c:\CommercialSystem\dados\dbcomp.mdb"
            '.image1.Image = PictureBox1.Image
            .Show()
        End With
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Cursor.Current = Cursors.WaitCursor
        Button23.Visible = False
        Button29.Visible = False
        Dim Formtreescomp As New FormTreesComp
        With Formtreescomp
            .MdiParent = Me.MdiParent
            .varTabela = "vendasportomescomp2"
            .varDatabase = "c:\CommercialSystem\dados\dbcomp.mdb"
            '.image1.Image = PictureBox1.Image
            .Show()
        End With
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub Buttonlastyearvalores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonlastyearvalores.Click
        Cursor.Current = Cursors.WaitCursor
        Dim FormTreesVal As New FormTreesPivot
        'Dim FormTreesVal As New FormTreesValor
        With FormTreesVal

            .MdiParent = Me.MdiParent
            .varTabela = "SALESCOMPLETISSIMOANO1"
            .varDatabase = "c:\CommercialSystem\dados\db3.mdb"

            '.varTabela = "vendasportomesfullvalorAno1"
            '.varDatabase = "c:\CommercialSystem\dados\db2.mdb"

            .Label1.Font = New System.Drawing.Font("Arial", 12)
            .Label1.Text = "Values By Month" & vbCrLf & " Last Year"
            .flagValores = True
            .Show()
        End With
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Cursor.Current = Cursors.WaitCursor
        Button23.Visible = False
        Button29.Visible = False
        Dim Formtreescomp As New FormTreesComp
        With Formtreescomp
            .MdiParent = Me.MdiParent
            .varTabela = "vendasportomescompvalor"
            .varDatabase = "c:\CommercialSystem\dados\dbcomp.mdb"
            ' .image1.Image = PictureBox1.Image
            .Show()
        End With
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Button35.Visible = False
        Button36.Visible = False

        Button23.Visible = Button23.Visible Xor True
        Button29.Visible = Button29.Visible Xor True

    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        Button23.Visible = False
        Button29.Visible = False

        Button35.Visible = Button35.Visible Xor True
        Button36.Visible = Button36.Visible Xor True

    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click


        Cursor.Current = Cursors.WaitCursor
        Button35.Visible = False
        Button36.Visible = False
        Dim Formtrees As New FormTrees
        With Formtrees
            .MdiParent = Me.MdiParent
            .varTabela = "vendasportomescomp"
            .varDatabase = "c:\CommercialSystem\dados\dbcomp.mdb"
            .Label1.Font = New System.Drawing.Font("Arial", 12)
            .Label1.Text = "Comparison" & vbCrLf & "   LastYear/ThisYear"
            .Label2.Visible = False
            .Text1.Visible = False
            .Show()
        End With
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        Cursor.Current = Cursors.WaitCursor
        Button35.Visible = False
        Button36.Visible = False
        Dim Formtrees As New FormTrees
        With Formtrees
            .MdiParent = Me.MdiParent
            .varTabela = "vendasportomescomp2"
            .varDatabase = "c:\CommercialSystem\dados\dbcomp.mdb"
            .Label1.Font = New System.Drawing.Font("Arial", 12)
            .Label1.Text = "Comparison" & vbCrLf & "   Year-2/LastYear"
            .Label2.Visible = False
            .Text1.Visible = False
            .Show()
        End With
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Cursor.Current = Cursors.WaitCursor
        Button14.Visible = False
        Button31.Visible = False
        Dim Formtrees As New FormTreesValor
        With Formtrees
            .MdiParent = Me.MdiParent
            .varTabela = "vendasportomescompvalor"
            .varDatabase = "c:\CommercialSystem\dados\dbcomp.mdb"
            .Label1.Font = New System.Drawing.Font("Arial", 12)
            .Label1.Text = "Values Comparison" & vbCrLf & "   LastYear/ThisYear"
            .Label2.Visible = False
            .Text1.Visible = False
            .Show()
        End With
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub Button21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Button14.Visible = True
        Button31.Visible = True
        Button24.Visible = False
        Button30.Visible = False

    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        ''''??? comparision by month
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        ''''helas


        Cursor.Current = Cursors.WaitCursor
        Button14.Visible = False
        Button31.Visible = False
        Dim Formtrees As New FormTreesValor
        With Formtrees
            .MdiParent = Me.MdiParent
            .varTabela = "vendasportomescompvalor2"
            .varDatabase = "c:\CommercialSystem\dados\dbcomp.mdb"
            .Label1.Font = New System.Drawing.Font("Arial", 12)
            .Label1.Text = "Values Comparison" & vbCrLf & "   Year-2/LastYear"

            .Label2.Visible = False
            .Text1.Visible = False
            .Show()
        End With
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click

    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTrees

        With Formtrees
            .MdiParent = Me.MdiParent
            .varTabela = "vendasmadeiramesfullano1"
            .varDatabase = "c:\CommercialSystem\dados\db2.mdb"
            .Label1.Font = New System.Drawing.Font("Arial", 12)
            .Label1.Text = "Madeira By Month " & vbCrLf & "Last Year"
            '    .image1.Image = PictureBox1.Image
            .Show()
        End With

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        'Comparison
        Button40.Visible = False

        Button39.Visible = Button39.Visible Xor True
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        'Comparison by month 
        Button39.Visible = False

        Button40.Visible = Button40.Visible Xor True

    End Sub


    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        'Comparison year
        Cursor.Current = Cursors.WaitCursor
        Button39.Visible = False
        Dim Formtrees As New FormTrees
        With Formtrees
            .MdiParent = Me.MdiParent
            .varTabela = "vendasmadeiramescomp"
            .varDatabase = "c:\CommercialSystem\dados\dbcomp.mdb"
            .Label1.Font = New System.Drawing.Font("Arial", 12)
            .Label1.Text = "Madeira Comparison" & vbCrLf & "   LastYear/ThisYear"
            .Label2.Visible = False
            .Text1.Visible = False
            .Show()
        End With
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        'Comparison by month year
        Cursor.Current = Cursors.WaitCursor
        Button40.Visible = False
        Dim Formtreescomp As New FormTreesComp
        With Formtreescomp
            .MdiParent = Me.MdiParent
            .varTabela = "vendasmadeiramescomp"
            .varDatabase = "c:\CommercialSystem\dados\dbcomp.mdb"
            '.image1.Image = PictureBox1.Image
            .Show()
        End With
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub BtCompTrade_Hist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCompTrade_Hist.Click
        Cursor.Current = Cursors.WaitCursor
        'Dim FormPivotTrade As New FormPivotTrade
        Dim FormTreeTrade As New FormTreesTrade
        'With FormPivotTrade
        With FormTreeTrade
            .MdiParent = Me.MdiParent
            .varTabela = "TradeSymHistorico"
            .varDatabase = "c:\CommercialSystem\dados\ivp.mdb"
            '            .Label1.Font = New System.Drawing.Font("Arial", 12)
            '            .Label1.Text = "Trade Comparison" & vbCrLf & "   Historic"
            .Show()
        End With
        Cursor.Current = Cursors.Default



    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Cursor.Current = Cursors.WaitCursor
        'Dim Formtrees As New FormTrees
        Dim Formtrees As New FormTreesPivot
        With Formtrees
            .MdiParent = Me.MdiParent
            .varTabela = "SALESCOMPLETISSIMOHISTORICO"
            .varDatabase = "c:\CommercialSystem\dados\db3.mdb"
            .Label1.Text = "History"
            .flagValores = True
            .Show()
        End With
        Cursor.Current = Cursors.Default
    End Sub
End Class