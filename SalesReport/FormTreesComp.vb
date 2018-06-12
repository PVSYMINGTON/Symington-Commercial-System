Imports System.Windows.Forms

Public Class FormTreesComp
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
    Public groupkey As String
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
    Public posiçao As Integer = 0
    Dim ds As DataSet, dsHelper As DataSetHelper.DataSetHelper
    Friend WithEvents btSwitchDirManAssist As System.Windows.Forms.Button

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Command2 As System.Windows.Forms.Button
    Friend WithEvents TreeView8 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView9 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView10 As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TreeView11 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView12 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView13 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView14 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView15 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView16 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView17 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView18 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView19 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView20 As System.Windows.Forms.TreeView
    Friend WithEvents command3 As System.Windows.Forms.Button
    Friend WithEvents btSwitchCatFam As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTreesComp))
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.TreeView2 = New System.Windows.Forms.TreeView
        Me.TreeView3 = New System.Windows.Forms.TreeView
        Me.TreeView4 = New System.Windows.Forms.TreeView
        Me.TreeView5 = New System.Windows.Forms.TreeView
        Me.TreeView6 = New System.Windows.Forms.TreeView
        Me.TreeView7 = New System.Windows.Forms.TreeView
        Me.image1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Command2 = New System.Windows.Forms.Button
        Me.TreeView8 = New System.Windows.Forms.TreeView
        Me.TreeView9 = New System.Windows.Forms.TreeView
        Me.TreeView10 = New System.Windows.Forms.TreeView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btSwitchCatFam = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TreeView11 = New System.Windows.Forms.TreeView
        Me.TreeView12 = New System.Windows.Forms.TreeView
        Me.TreeView13 = New System.Windows.Forms.TreeView
        Me.TreeView14 = New System.Windows.Forms.TreeView
        Me.TreeView15 = New System.Windows.Forms.TreeView
        Me.TreeView16 = New System.Windows.Forms.TreeView
        Me.TreeView17 = New System.Windows.Forms.TreeView
        Me.TreeView18 = New System.Windows.Forms.TreeView
        Me.TreeView19 = New System.Windows.Forms.TreeView
        Me.TreeView20 = New System.Windows.Forms.TreeView
        Me.command3 = New System.Windows.Forms.Button
        Me.btSwitchDirManAssist = New System.Windows.Forms.Button
        CType(Me.image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.Wheat
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ForeColor = System.Drawing.Color.Black
        Me.TreeView1.HideSelection = False
        Me.TreeView1.ItemHeight = 14
        Me.TreeView1.Location = New System.Drawing.Point(72, 34)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(120, 174)
        Me.TreeView1.TabIndex = 0
        '
        'TreeView2
        '
        Me.TreeView2.BackColor = System.Drawing.Color.Wheat
        Me.TreeView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView2.CheckBoxes = True
        Me.TreeView2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView2.ForeColor = System.Drawing.Color.Black
        Me.TreeView2.HideSelection = False
        Me.TreeView2.ItemHeight = 14
        Me.TreeView2.Location = New System.Drawing.Point(200, 0)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(248, 208)
        Me.TreeView2.TabIndex = 1
        '
        'TreeView3
        '
        Me.TreeView3.BackColor = System.Drawing.Color.Wheat
        Me.TreeView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView3.CheckBoxes = True
        Me.TreeView3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView3.ForeColor = System.Drawing.Color.Black
        Me.TreeView3.HideSelection = False
        Me.TreeView3.ItemHeight = 14
        Me.TreeView3.Location = New System.Drawing.Point(456, 0)
        Me.TreeView3.Name = "TreeView3"
        Me.TreeView3.Size = New System.Drawing.Size(272, 208)
        Me.TreeView3.TabIndex = 2
        '
        'TreeView4
        '
        Me.TreeView4.BackColor = System.Drawing.Color.Wheat
        Me.TreeView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView4.CheckBoxes = True
        Me.TreeView4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView4.ForeColor = System.Drawing.Color.Black
        Me.TreeView4.HideSelection = False
        Me.TreeView4.ItemHeight = 14
        Me.TreeView4.Location = New System.Drawing.Point(736, 0)
        Me.TreeView4.Name = "TreeView4"
        Me.TreeView4.Size = New System.Drawing.Size(232, 208)
        Me.TreeView4.TabIndex = 3
        '
        'TreeView5
        '
        Me.TreeView5.BackColor = System.Drawing.Color.Wheat
        Me.TreeView5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView5.CheckBoxes = True
        Me.TreeView5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView5.ForeColor = System.Drawing.Color.Black
        Me.TreeView5.HideSelection = False
        Me.TreeView5.ItemHeight = 14
        Me.TreeView5.Location = New System.Drawing.Point(0, 216)
        Me.TreeView5.Name = "TreeView5"
        Me.TreeView5.Size = New System.Drawing.Size(168, 208)
        Me.TreeView5.TabIndex = 4
        '
        'TreeView6
        '
        Me.TreeView6.BackColor = System.Drawing.Color.Wheat
        Me.TreeView6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView6.CheckBoxes = True
        Me.TreeView6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView6.ForeColor = System.Drawing.Color.Black
        Me.TreeView6.HideSelection = False
        Me.TreeView6.ItemHeight = 14
        Me.TreeView6.Location = New System.Drawing.Point(176, 216)
        Me.TreeView6.Name = "TreeView6"
        Me.TreeView6.Size = New System.Drawing.Size(152, 208)
        Me.TreeView6.TabIndex = 5
        '
        'TreeView7
        '
        Me.TreeView7.BackColor = System.Drawing.Color.Wheat
        Me.TreeView7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView7.CheckBoxes = True
        Me.TreeView7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView7.ForeColor = System.Drawing.Color.Black
        Me.TreeView7.HideSelection = False
        Me.TreeView7.ItemHeight = 14
        Me.TreeView7.Location = New System.Drawing.Point(336, 216)
        Me.TreeView7.Name = "TreeView7"
        Me.TreeView7.Size = New System.Drawing.Size(136, 208)
        Me.TreeView7.TabIndex = 6
        '
        'image1
        '
        Me.image1.Image = CType(resources.GetObject("image1.Image"), System.Drawing.Image)
        Me.image1.Location = New System.Drawing.Point(0, 0)
        Me.image1.Name = "image1"
        Me.image1.Size = New System.Drawing.Size(150, 69)
        Me.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.image1.TabIndex = 8
        Me.image1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Comparison"
        '
        'Command2
        '
        Me.Command2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Command2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Command2.ForeColor = System.Drawing.SystemColors.Info
        Me.Command2.Image = CType(resources.GetObject("Command2.Image"), System.Drawing.Image)
        Me.Command2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Command2.Location = New System.Drawing.Point(856, 0)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(72, 64)
        Me.Command2.TabIndex = 13
        Me.Command2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TreeView8
        '
        Me.TreeView8.BackColor = System.Drawing.Color.Wheat
        Me.TreeView8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView8.CheckBoxes = True
        Me.TreeView8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView8.ForeColor = System.Drawing.Color.Black
        Me.TreeView8.HideSelection = False
        Me.TreeView8.ItemHeight = 14
        Me.TreeView8.Location = New System.Drawing.Point(480, 232)
        Me.TreeView8.Name = "TreeView8"
        Me.TreeView8.Size = New System.Drawing.Size(184, 208)
        Me.TreeView8.TabIndex = 18
        '
        'TreeView9
        '
        Me.TreeView9.BackColor = System.Drawing.Color.Wheat
        Me.TreeView9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView9.CheckBoxes = True
        Me.TreeView9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView9.ForeColor = System.Drawing.Color.Black
        Me.TreeView9.HideSelection = False
        Me.TreeView9.ItemHeight = 14
        Me.TreeView9.Location = New System.Drawing.Point(672, 216)
        Me.TreeView9.Name = "TreeView9"
        Me.TreeView9.Size = New System.Drawing.Size(128, 208)
        Me.TreeView9.TabIndex = 19
        '
        'TreeView10
        '
        Me.TreeView10.BackColor = System.Drawing.Color.Wheat
        Me.TreeView10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView10.CheckBoxes = True
        Me.TreeView10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView10.ForeColor = System.Drawing.Color.Black
        Me.TreeView10.HideSelection = False
        Me.TreeView10.ItemHeight = 14
        Me.TreeView10.Location = New System.Drawing.Point(808, 216)
        Me.TreeView10.Name = "TreeView10"
        Me.TreeView10.Size = New System.Drawing.Size(200, 208)
        Me.TreeView10.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btSwitchDirManAssist)
        Me.Panel1.Controls.Add(Me.btSwitchCatFam)
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Controls.Add(Me.TreeView2)
        Me.Panel1.Controls.Add(Me.TreeView3)
        Me.Panel1.Controls.Add(Me.TreeView4)
        Me.Panel1.Controls.Add(Me.TreeView5)
        Me.Panel1.Controls.Add(Me.TreeView6)
        Me.Panel1.Controls.Add(Me.TreeView7)
        Me.Panel1.Controls.Add(Me.TreeView8)
        Me.Panel1.Controls.Add(Me.TreeView9)
        Me.Panel1.Controls.Add(Me.TreeView10)
        Me.Panel1.Location = New System.Drawing.Point(0, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 440)
        Me.Panel1.TabIndex = 21
        '
        'btSwitchCatFam
        '
        Me.btSwitchCatFam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSwitchCatFam.BackColor = System.Drawing.Color.BurlyWood
        Me.btSwitchCatFam.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSwitchCatFam.Image = CType(resources.GetObject("btSwitchCatFam.Image"), System.Drawing.Image)
        Me.btSwitchCatFam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSwitchCatFam.Location = New System.Drawing.Point(496, 208)
        Me.btSwitchCatFam.Name = "btSwitchCatFam"
        Me.btSwitchCatFam.Size = New System.Drawing.Size(152, 24)
        Me.btSwitchCatFam.TabIndex = 34
        Me.btSwitchCatFam.Text = "Family or Subcategory"
        Me.btSwitchCatFam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSwitchCatFam.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(312, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(488, 40)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Select Universe : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.UseMnemonic = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 25.0!)
        Me.ListBox1.ForeColor = System.Drawing.Color.Black
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.ItemHeight = 38
        Me.ListBox1.Items.AddRange(New Object() {"Market Director", "Market", "Client", "Company", "Type", "Trademark", "Group", "Subcat", "Family", "Vintage Year", "Package"})
        Me.ListBox1.Location = New System.Drawing.Point(600, 456)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(250, 300)
        Me.ListBox1.TabIndex = 21
        Me.ListBox1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.TreeView11)
        Me.Panel2.Controls.Add(Me.TreeView12)
        Me.Panel2.Controls.Add(Me.TreeView13)
        Me.Panel2.Controls.Add(Me.TreeView14)
        Me.Panel2.Controls.Add(Me.TreeView15)
        Me.Panel2.Controls.Add(Me.TreeView16)
        Me.Panel2.Controls.Add(Me.TreeView17)
        Me.Panel2.Controls.Add(Me.TreeView18)
        Me.Panel2.Controls.Add(Me.TreeView19)
        Me.Panel2.Controls.Add(Me.TreeView20)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(0, 536)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1008, 424)
        Me.Panel2.TabIndex = 22
        Me.Panel2.Visible = False
        '
        'TreeView11
        '
        Me.TreeView11.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TreeView11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView11.HideSelection = False
        Me.TreeView11.ItemHeight = 14
        Me.TreeView11.Location = New System.Drawing.Point(72, 0)
        Me.TreeView11.Name = "TreeView11"
        Me.TreeView11.Size = New System.Drawing.Size(120, 208)
        Me.TreeView11.TabIndex = 21
        '
        'TreeView12
        '
        Me.TreeView12.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TreeView12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView12.HideSelection = False
        Me.TreeView12.ItemHeight = 14
        Me.TreeView12.Location = New System.Drawing.Point(200, 0)
        Me.TreeView12.Name = "TreeView12"
        Me.TreeView12.Size = New System.Drawing.Size(248, 208)
        Me.TreeView12.TabIndex = 22
        '
        'TreeView13
        '
        Me.TreeView13.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TreeView13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView13.HideSelection = False
        Me.TreeView13.ItemHeight = 14
        Me.TreeView13.Location = New System.Drawing.Point(456, 0)
        Me.TreeView13.Name = "TreeView13"
        Me.TreeView13.Size = New System.Drawing.Size(272, 208)
        Me.TreeView13.TabIndex = 23
        '
        'TreeView14
        '
        Me.TreeView14.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TreeView14.CheckBoxes = True
        Me.TreeView14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView14.HideSelection = False
        Me.TreeView14.ItemHeight = 14
        Me.TreeView14.Location = New System.Drawing.Point(736, 0)
        Me.TreeView14.Name = "TreeView14"
        Me.TreeView14.Size = New System.Drawing.Size(232, 208)
        Me.TreeView14.TabIndex = 24
        '
        'TreeView15
        '
        Me.TreeView15.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TreeView15.CheckBoxes = True
        Me.TreeView15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView15.HideSelection = False
        Me.TreeView15.ItemHeight = 14
        Me.TreeView15.Location = New System.Drawing.Point(0, 216)
        Me.TreeView15.Name = "TreeView15"
        Me.TreeView15.Size = New System.Drawing.Size(168, 208)
        Me.TreeView15.TabIndex = 25
        '
        'TreeView16
        '
        Me.TreeView16.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TreeView16.CheckBoxes = True
        Me.TreeView16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView16.HideSelection = False
        Me.TreeView16.ItemHeight = 14
        Me.TreeView16.Location = New System.Drawing.Point(176, 216)
        Me.TreeView16.Name = "TreeView16"
        Me.TreeView16.Size = New System.Drawing.Size(152, 208)
        Me.TreeView16.TabIndex = 26
        '
        'TreeView17
        '
        Me.TreeView17.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TreeView17.CheckBoxes = True
        Me.TreeView17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView17.HideSelection = False
        Me.TreeView17.ItemHeight = 14
        Me.TreeView17.Location = New System.Drawing.Point(336, 216)
        Me.TreeView17.Name = "TreeView17"
        Me.TreeView17.Size = New System.Drawing.Size(136, 208)
        Me.TreeView17.TabIndex = 27
        '
        'TreeView18
        '
        Me.TreeView18.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TreeView18.CheckBoxes = True
        Me.TreeView18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView18.HideSelection = False
        Me.TreeView18.ItemHeight = 14
        Me.TreeView18.Location = New System.Drawing.Point(480, 216)
        Me.TreeView18.Name = "TreeView18"
        Me.TreeView18.Size = New System.Drawing.Size(184, 208)
        Me.TreeView18.TabIndex = 28
        '
        'TreeView19
        '
        Me.TreeView19.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TreeView19.CheckBoxes = True
        Me.TreeView19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView19.HideSelection = False
        Me.TreeView19.ItemHeight = 14
        Me.TreeView19.Location = New System.Drawing.Point(672, 216)
        Me.TreeView19.Name = "TreeView19"
        Me.TreeView19.Size = New System.Drawing.Size(128, 208)
        Me.TreeView19.TabIndex = 29
        '
        'TreeView20
        '
        Me.TreeView20.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TreeView20.CheckBoxes = True
        Me.TreeView20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView20.HideSelection = False
        Me.TreeView20.ItemHeight = 14
        Me.TreeView20.Location = New System.Drawing.Point(808, 216)
        Me.TreeView20.Name = "TreeView20"
        Me.TreeView20.Size = New System.Drawing.Size(200, 208)
        Me.TreeView20.TabIndex = 30
        '
        'command3
        '
        Me.command3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.command3.BackColor = System.Drawing.Color.Transparent
        Me.command3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.command3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.command3.ForeColor = System.Drawing.Color.White
        Me.command3.Image = CType(resources.GetObject("command3.Image"), System.Drawing.Image)
        Me.command3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.command3.Location = New System.Drawing.Point(928, 0)
        Me.command3.Name = "command3"
        Me.command3.Size = New System.Drawing.Size(72, 64)
        Me.command3.TabIndex = 23
        Me.command3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.command3.UseVisualStyleBackColor = False
        '
        'btSwitchDirManAssist
        '
        Me.btSwitchDirManAssist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSwitchDirManAssist.BackColor = System.Drawing.Color.BurlyWood
        Me.btSwitchDirManAssist.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSwitchDirManAssist.Image = CType(resources.GetObject("btSwitchDirManAssist.Image"), System.Drawing.Image)
        Me.btSwitchDirManAssist.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btSwitchDirManAssist.Location = New System.Drawing.Point(72, 3)
        Me.btSwitchDirManAssist.Name = "btSwitchDirManAssist"
        Me.btSwitchDirManAssist.Size = New System.Drawing.Size(120, 25)
        Me.btSwitchDirManAssist.TabIndex = 36
        Me.btSwitchDirManAssist.Text = "Dir/Assist/Manag"
        Me.btSwitchDirManAssist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSwitchDirManAssist.UseVisualStyleBackColor = False
        '
        'FormTreesComp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1008, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.image1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.command3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTreesComp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Choose Criteria"
        CType(Me.image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FormTreesComp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        ''      Dim x As Integer

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
            AddNodes(ds.Tables("Distinctcompany"), "Company", 3)
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
            ''        Dim c As DataColumn

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
            ''       Dim c As DataColumn

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
            ''       Dim c As DataColumn

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
            ''       Dim c As DataColumn

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
        Select Case posiçao
            Case 0

                Panel1.Enabled = False
                Panel1.Visible = False
                ListBox1.Top = Me.Height / 2 - 150
                ListBox1.Left = Me.Width / 2 - 125
                ListBox1.Visible = True
                ListBox1.SelectedIndex = 0
                groupkey = ListBox1.SelectedItem
                Label2.Text = "Select Grouping: "
                posiçao = 2
            Case 1
                '   Me.BackColor = Color.DarkSeaGreen
                '  ListBox1.Visible = False
                ' ListBox1.Enabled = False
                'Panel2.Top = Panel1.Top
                'Panel2.Left = Panel1.Left

                'Panel2.Enabled = True
                'Panel2.Visible = True
                'treefill2(-1)
                'Label2.Text = "Select Total for Comparison: "
                'posiçao = 2

            Case Else
                Dim formcomp As New FormComp
                With formcomp
                    .vardatabase = varDatabase
                    .vartabela = varTabela
                    .filterkeydir = filterkeydir
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
                    .groupkey = groupkey
                    .FormComp_Load()
                End With
                Cursor.Current = Cursors.Default

        End Select

    End Sub
    Private Sub Command3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles command3.Click
        Select Case posiçao
            Case 2


                'Panel1.Enabled = False
                Panel1.Enabled = True
                'Panel1.Visible = False
                Panel1.Visible = True
                'ListBox1.Top = Me.Height / 2 - 150
                'ListBox1.Left = Me.Width / 2 - 125
                'ListBox1.Visible = True
                ListBox1.Visible = False
                'ListBox1.SelectedIndex = 0
                'groupkey = ListBox1.SelectedItem
                Label2.Text = "Select Universe : "
                posiçao = 0
            Case Else

                Me.Close()
        End Select
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

        '     Text1.Text = vbNullString

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

        '  Text1.Text = vbNullString

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

        '    Text1.Text = vbNullString

    End Sub
    Private Sub TreeView3_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView3.BeforeSelect
        e.Cancel = True

    End Sub

    Private Sub TreeView4_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView4.BeforeCheck
        If e.Node.Text = "Company" Then e.Cancel() = True

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

        ' Text1.Text = vbNullString

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

        '        Text1.Text = vbNullString
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

        '   Text1.Text = vbNullString
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

        '   Text1.Text = vbNullString
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

        '  Text1.Text = vbNullString
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

        '    Text1.Text = vbNullString
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

        '  Text1.Text = vbNullString
    End Sub
    Private Sub TreeView10_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView10.BeforeSelect
        e.Cancel = True
    End Sub



    Public Function SQ(ByVal str As String) As String
        SQ = Replace(str, "'", "''", 1, -1, vbTextCompare)
    End Function


    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        groupkey = ListBox1.SelectedItem
    End Sub



    Private Sub btSwitchCatFam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSwitchCatFam.Click
        If flagfilterkeyprod = "Subcat" Then
            flagfilterkeyprod = "Family"
        Else
            flagfilterkeyprod = "Subcat"
        End If

        filterkeydir = "director like '%'"
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
        strsql = "SELECT director, pais, cliente, company, Tipo, Marca, Grupo, " & flagfilterkeyprod & ", Anocol, embalagem  FROM " & varTabela

        Dim sqlcommand1 As New OleDb.OleDbCommand
        Dim SqlConnection1 As New OleDb.OleDbConnection
        SqlConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=" & varDatabase & ";Mode=Read"
        sqlcommand1.CommandText = strsql
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()

        Dim tabela As New DataTable

        'Dim workCol As DataColumn = 
        tabela.Columns.Add("director", Type.GetType("System.String"))
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
            myRow("director") = reader.Item(0)
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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

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
