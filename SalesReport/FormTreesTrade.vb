Imports System.Windows.Forms
Imports System.Data.SQLite

Public Class FormTreesTrade
    Inherits System.Windows.Forms.Form

    Public filterkeypais As String
    Public filterkeycli As String
    Public filterkeycomp As String
    Public filterkeymarca As String
    Public filterkeytype As String
    Public filterkeygroup As String
    Public filterkeyprod As String
    Public flagfilterkeyprod As String
    Public filterkeyAnoCol As String
    Public filterkeyPackage As String

    Public Forcefilterkey As String

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
    Friend WithEvents Command3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTreesTrade))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.TreeView3 = New System.Windows.Forms.TreeView()
        Me.TreeView4 = New System.Windows.Forms.TreeView()
        Me.TreeView5 = New System.Windows.Forms.TreeView()
        Me.TreeView6 = New System.Windows.Forms.TreeView()
        Me.TreeView7 = New System.Windows.Forms.TreeView()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.image1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.TreeView1.Location = New System.Drawing.Point(98, 128)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(170, 208)
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
        Me.TreeView2.Location = New System.Drawing.Point(274, 128)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(219, 208)
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
        Me.TreeView3.Location = New System.Drawing.Point(499, 128)
        Me.TreeView3.Name = "TreeView3"
        Me.TreeView3.Size = New System.Drawing.Size(213, 208)
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
        Me.TreeView4.Location = New System.Drawing.Point(718, 128)
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
        Me.TreeView5.Location = New System.Drawing.Point(166, 361)
        Me.TreeView5.Name = "TreeView5"
        Me.TreeView5.Size = New System.Drawing.Size(239, 208)
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
        Me.TreeView6.Location = New System.Drawing.Point(411, 361)
        Me.TreeView6.Name = "TreeView6"
        Me.TreeView6.Size = New System.Drawing.Size(239, 208)
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
        Me.TreeView7.Location = New System.Drawing.Point(656, 361)
        Me.TreeView7.Name = "TreeView7"
        Me.TreeView7.Size = New System.Drawing.Size(218, 208)
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
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 65)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "IVDP Historic"
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
        '
        'FormTreesTrade
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 744)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.image1)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.TreeView7)
        Me.Controls.Add(Me.TreeView6)
        Me.Controls.Add(Me.TreeView5)
        Me.Controls.Add(Me.TreeView4)
        Me.Controls.Add(Me.TreeView3)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox8)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Name = "FormTreesTrade"
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
        Me.Top = 0
        Me.Left = 0
        Me.Width = Me.MdiParent.ClientSize.Width - 4
        Me.Height = Me.MdiParent.ClientSize.Height - 4
        click1 = False
        filterkeypais = "pais like '%'"
        filterkeycli = "cliente like '%'"
        filterkeymarca = "Marca like '%'"
        filterkeycomp = "Company like '%'"
        filterkeytype = "Tipo like '%'"
        filterkeygroup = "Grupo like '%'"
        filterkeyprod = flagfilterkeyprod & " Like '%'"
        Forcefilterkey = "pais like '%'"



        If UCase(GetSetting("SalesReports", "User", "login")) = "SYMINGTON\SYMINOV" Then
            Forcefilterkey = " (pais like'%USA%')"
        End If


        Dim strsql As String
        'Dim reader As System.Data.OleDb.OleDbDataReader
        Dim reader As SQLiteDataReader
        ds = New DataSet
        dsHelper = New DataSetHelper.DataSetHelper(ds)
        strsql = "Select * From " & varTabela & " where " & Forcefilterkey '   "TradeSymHistorico"


        Dim sqlcommand1 As New SQLiteCommand


        Dim SqlConnection1 As New Data.SQLite.SQLiteConnection ' OleDb.OleDbConnection
        SqlConnection1.ConnectionString = My.Settings.SapIVDPConnectionString
        sqlcommand1.CommandText = strsql

        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()



        Dim tabela As New DataTable

        tabela.Columns.Add("pais", Type.GetType("System.String"))
        tabela.Columns.Add("cliente", Type.GetType("System.String"))
        tabela.Columns.Add("company", Type.GetType("System.String"))
        tabela.Columns.Add("Marca", Type.GetType("System.String"))
        tabela.Columns.Add("Tipo", Type.GetType("System.String"))
        tabela.Columns.Add("Grupo", Type.GetType("System.String"))
        tabela.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))

        Dim myRow As DataRow

        reader = sqlcommand1.ExecuteReader



        While reader.Read
            myRow = tabela.NewRow()
            '   myRow("director") = reader.Item(0)
            myRow("pais") = reader.Item(1)
            myRow("cliente") = reader.Item(2)
            myRow("company") = reader.Item(3)
            myRow("Marca") = reader.Item(4)
            myRow("Tipo") = reader.Item(5)
            myRow("Grupo") = reader.Item(6)
            myRow(flagfilterkeyprod) = reader.Item(7)

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

        If Index = -1 Then


            dsHelper.SelectDistinct("Distinctpais", ds.Tables(0), "pais")
            AddNodes(ds.Tables("Distinctpais"), "Market", 0)
            ds.Tables.Remove("Distinctpais")

            dsHelper.SelectDistinct("Distinctcliente", ds.Tables(0), "cliente")
            AddNodes(ds.Tables("Distinctcliente"), "Customer", 1)
            ds.Tables.Remove("Distinctcliente")

            dsHelper.SelectDistinct("Distinctcompany", ds.Tables(0), "company")
            AddNodes(ds.Tables("Distinctcompany"), "Company", 2)
            ds.Tables.Remove("Distinctcompany")

            dsHelper.SelectDistinct("DistinctMarca", ds.Tables(0), "Marca")
            AddNodes(ds.Tables("DistinctMarca"), "Trademark", 3)
            ds.Tables.Remove("DistinctMarca")

            dsHelper.SelectDistinct("DistinctTipo", ds.Tables(0), "Tipo")
            AddNodes(ds.Tables("DistinctTipo"), "Type", 4)
            ds.Tables.Remove("DistinctTipo")

            dsHelper.SelectDistinct("DistinctGrupo", ds.Tables(0), "Grupo")
            AddNodes(ds.Tables("DistinctGrupo"), "Group", 5)
            ds.Tables.Remove("DistinctGrupo")

            dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, ds.Tables(0), flagfilterkeyprod)
            AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagfilterkeyprod, 6)
            ds.Tables.Remove("Distinct" & flagfilterkeyprod)




        Else

            Dim directorDR As DataRow() = ds.Tables(0).Select("(" & filterkeypais _
            & ") and (" & filterkeycli _
            & ") and (" & filterkeycomp & ") and (" & filterkeytype _
            & ") and (" & filterkeymarca & ") and (" & filterkeygroup _
            & ") and (" & filterkeyprod & ") ")


            Dim r As DataRow
            Dim myrow2 As DataRow
            ''      Dim c As DataColumn

            Dim tabeladir As New DataTable

            'Dim workCol As DataColumn = 
            tabeladir.Columns.Add("pais", Type.GetType("System.String"))
            tabeladir.Columns.Add("cliente", Type.GetType("System.String"))
            tabeladir.Columns.Add("company", Type.GetType("System.String"))
            tabeladir.Columns.Add("Marca", Type.GetType("System.String"))
            tabeladir.Columns.Add("Tipo", Type.GetType("System.String"))
            tabeladir.Columns.Add("Grupo", Type.GetType("System.String"))
            tabeladir.Columns.Add(flagfilterkeyprod, Type.GetType("System.String"))


            For Each r In directorDR
                myrow2 = tabeladir.NewRow()
                myrow2("pais") = r.Item(0)
                myrow2("cliente") = r.Item(1)
                myrow2("company") = r.Item(2)
                myrow2("Marca") = r.Item(3)
                myrow2("Tipo") = r.Item(4)
                myrow2("Grupo") = r.Item(5)
                myrow2(flagfilterkeyprod) = r.Item(6)

                tabeladir.Rows.Add(myrow2)
            Next r

            If Index = 0 Then
                dsHelper.SelectDistinct("Distinctcliente", tabeladir, "cliente")
                AddNodes(ds.Tables("Distinctcliente"), "Customer", 1)
                ds.Tables.Remove("Distinctcliente")
            End If
            If Index < 2 Then
                dsHelper.SelectDistinct("Distinctcompany", tabeladir, "company")
                AddNodes(ds.Tables("Distinctcompany"), "Company", 2)
                ds.Tables.Remove("Distinctcompany")
            End If
           
            If Index < 3 Then
                dsHelper.SelectDistinct("DistinctMarca", tabeladir, "Marca")
                AddNodes(ds.Tables("DistinctMarca"), "Trademark", 3)
                ds.Tables.Remove("DistinctMarca")

            End If
            If Index < 4 Then
                dsHelper.SelectDistinct("DistinctTipo", tabeladir, "Tipo")
                AddNodes(ds.Tables("DistinctTipo"), "Type", 4)
                ds.Tables.Remove("DistinctTipo")

            End If
            If Index < 5 Then
                dsHelper.SelectDistinct("DistinctGrupo", tabeladir, "Grupo")
                AddNodes(ds.Tables("DistinctGrupo"), "Group", 5)
                ds.Tables.Remove("DistinctGrupo")
            End If
            If Index < 6 Then
                dsHelper.SelectDistinct("Distinct" & flagfilterkeyprod, tabeladir, flagfilterkeyprod)
                AddNodes(ds.Tables("Distinct" & flagfilterkeyprod), flagfilterkeyprod, 6)
                ds.Tables.Remove("Distinct" & flagfilterkeyprod)
            End If

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


        If Index = -1 Then
            TreeView1.Nodes(0).Nodes(0).Checked = True
            TreeView2.Nodes(0).Nodes(0).Checked = True
            TreeView3.Nodes(0).Nodes(0).Checked = True
            TreeView4.Nodes(0).Nodes(0).Checked = True
            TreeView5.Nodes(0).Nodes(0).Checked = True
            TreeView6.Nodes(0).Nodes(0).Checked = True
            TreeView7.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 0 Then
            TreeView2.Nodes(0).Nodes(0).Checked = True
            TreeView3.Nodes(0).Nodes(0).Checked = True
            TreeView4.Nodes(0).Nodes(0).Checked = True
            TreeView5.Nodes(0).Nodes(0).Checked = True
            TreeView6.Nodes(0).Nodes(0).Checked = True
            TreeView7.Nodes(0).Nodes(0).Checked = True
        End If

        If Index = 1 Then

            TreeView3.Nodes(0).Nodes(0).Checked = True
            TreeView4.Nodes(0).Nodes(0).Checked = True
            TreeView5.Nodes(0).Nodes(0).Checked = True
            TreeView6.Nodes(0).Nodes(0).Checked = True
            TreeView7.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 2 Then
            TreeView4.Nodes(0).Nodes(0).Checked = True
            TreeView5.Nodes(0).Nodes(0).Checked = True
            TreeView6.Nodes(0).Nodes(0).Checked = True
            TreeView7.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 3 Then
            TreeView5.Nodes(0).Nodes(0).Checked = True
            TreeView6.Nodes(0).Nodes(0).Checked = True
            TreeView7.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 4 Then
            TreeView6.Nodes(0).Nodes(0).Checked = True
            TreeView7.Nodes(0).Nodes(0).Checked = True
        End If
        If Index = 5 Then
            TreeView7.Nodes(0).Nodes(0).Checked = True
        End If


        TreeView1.EndUpdate()
        TreeView2.EndUpdate()
        TreeView3.EndUpdate()
        TreeView4.EndUpdate()
        TreeView5.EndUpdate()
        TreeView6.EndUpdate()
        TreeView7.EndUpdate()

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






        End Select
    End Sub



    Private Sub TreeView1_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeCheck
        If e.Node.Text = "Market" Then e.Cancel() = True

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
        varstr = "Pais like '"
        'varstr = vbNullString
        For Each xt In TreeView1.Nodes(0).Nodes
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
            treefill(0)
        Catch
            TreeView1.Nodes(0).Nodes(0).Checked = True
        End Try


    End Sub
    Private Sub treeview1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
        e.Cancel = True

    End Sub


    Private Sub treeview2_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView2.BeforeCheck
        If e.Node.Text = "Customer" Then e.Cancel() = True

    End Sub
    Private Sub treeview2_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView2.AfterCheck
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
        varstr = "Cliente like '"
        'varstr = vbNullString
        For Each xt In TreeView2.Nodes(0).Nodes
            If LCase(xt.Text) = "trade" Then xt.Checked = True
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
            treefill(1)
        Catch
            TreeView2.Nodes(0).Nodes(0).Checked = True
        End Try


    End Sub
    Private Sub treeview2_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView2.BeforeSelect
        e.Cancel = True

    End Sub

    Private Sub treeview3_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView3.BeforeCheck
        If e.Node.Text = "Brand" Then e.Cancel() = True

    End Sub
    Private Sub treeview3_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView3.AfterCheck
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
        varstr = "Company like '"
        'varstr = vbNullString
        For Each xt In TreeView3.Nodes(0).Nodes
            If LCase(xt.Text) = "trade" Then xt.Checked = True
            If xt.Checked = True Then
                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR Company like '"
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
            treefill(2)
        Catch
            TreeView3.Nodes(0).Nodes(0).Checked = True
        End Try


    End Sub
    Private Sub treeview3_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView3.BeforeSelect
        e.Cancel = True

    End Sub

    Private Sub treeview4_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView4.BeforeCheck
        If e.Node.Text = "Trademark" Then e.Cancel() = True

    End Sub
    Private Sub treeview4_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView4.AfterCheck
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
        varstr = "Marca like '"
        'varstr = vbNullString
        For Each xt In TreeView4.Nodes(0).Nodes
            If LCase(xt.Text) = "trade" Then xt.Checked = True
            If xt.Checked = True Then

                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR Marca like '"
            End If
        Next

        Try
            filterkeymarca = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 16)
            filterkeygroup = "Grupo like '%'"
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "Anocol like '%'"
            filterkeyPackage = "embalagem like '%'"
            treefill(3)
        Catch
            TreeView4.Nodes(0).Nodes(0).Checked = True
        End Try


    End Sub
    Private Sub treeview4_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView4.BeforeSelect
        e.Cancel = True

    End Sub

    Private Sub treeview5_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView5.BeforeCheck
        If e.Node.Text = "Type" Then e.Cancel() = True

    End Sub
    Private Sub treeview5_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView5.AfterCheck
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
        varstr = "Tipo like '"
        'varstr = vbNullString
        For Each xt In TreeView5.Nodes(0).Nodes
            If LCase(xt.Text) = "port trade" Then xt.Checked = True
            If xt.Checked = True Then

                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR Tipo like '"
            End If
        Next
        Try
            filterkeytype = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 15)
            filterkeygroup = "Grupo like '%'"
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "Anocol like '%'"
            filterkeyPackage = "embalagem like '%'"
            treefill(4)
        Catch
            TreeView5.Nodes(0).Nodes(0).Checked = True
        End Try


    End Sub
    Private Sub treeview5_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView5.BeforeSelect
        e.Cancel = True

    End Sub

    Private Sub treeview6_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView6.BeforeCheck
        If e.Node.Text = "Group" Then e.Cancel() = True

    End Sub
    Private Sub treeview6_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView6.AfterCheck
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
        varstr = "Grupo like '"
        'varstr = vbNullString
        For Each xt In TreeView6.Nodes(0).Nodes
            If LCase(xt.Text) = "trade" Then xt.Checked = True
            If xt.Checked = True Then

                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR Grupo like '"
            End If
        Next
        Try
            filterkeygroup = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 16)
            filterkeyprod = flagfilterkeyprod & " Like '%'"
            filterkeyAnoCol = "Anocol like '%'"
            filterkeyPackage = "embalagem like '%'"
            treefill(5)
        Catch
            TreeView6.Nodes(0).Nodes(0).Checked = True
        End Try


    End Sub
    Private Sub treeview6_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView6.BeforeSelect
        e.Cancel = True

    End Sub

    Private Sub treeview7_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView7.BeforeCheck
        If e.Node.Text = flagfilterkeyprod Then e.Cancel() = True

    End Sub
    Private Sub treeview7_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView7.AfterCheck
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

        varstr = flagfilterkeyprod & " Like '"

        For Each xt In TreeView7.Nodes(0).Nodes
            If LCase(xt.Text) = "trade" Then xt.Checked = True
            If xt.Checked = True Then

                varstr = varstr & IIf(xt.Text = "ALL", "%", SQ(xt.Text)) & "' OR " & flagfilterkeyprod & " LIKE '"

            End If
        Next
        Try
            filterkeyprod = Microsoft.VisualBasic.Left(varstr, Len(varstr) - 17)
            filterkeyAnoCol = "Anocol like '%'"
            filterkeyPackage = "embalagem like '%'"
            '            treefill(7)

        Catch
            TreeView7.Nodes(0).Nodes(0).Checked = True
        End Try

    End Sub
    Private Sub treeview7_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView7.BeforeSelect
        e.Cancel = True

    End Sub


    Public Function SQ(ByVal str As String) As String
        SQ = Replace(str, "'", "''", 1, -1, vbTextCompare)
    End Function



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Cursor.Current = Cursors.WaitCursor
        Dim formpivot As New FormPivotTrade
        With formpivot
            '.vardatabase = varDatabase
            .vartabela = varTabela
            .filterkeypais = filterkeypais
            .filterkeycli = filterkeycli
            .filterkeycomp = filterkeycomp
            .filterkeymarca = filterkeymarca
            .filterkeytype = filterkeytype
            .filterkeygroup = filterkeygroup
            .filterkeyprod = filterkeyprod
            .flagfilterkeyprod = flagfilterkeyprod

            .filtergrid = filtergrid

            .Groupsubcat = True
            .MdiParent = Me.MdiParent
            .Show()
        End With

        Cursor.Current = Cursors.Default


    End Sub

    Private Sub Command3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command3.Click
        Me.Close()
    End Sub
End Class
