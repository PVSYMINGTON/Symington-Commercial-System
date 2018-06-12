Imports System.IO
Imports System.Windows.Forms
Imports System.Data.SQLite

Public Class FormEscolhasPricings


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
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BtAlterarPricing As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtEnviarPricings As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtEditPricings As System.Windows.Forms.Button
    Friend WithEvents BtviewPL As System.Windows.Forms.Button
    Friend WithEvents BtAnularEnviarPricings As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtUpdatePricings As System.Windows.Forms.Button
    Friend WithEvents BtviewPL_1 As System.Windows.Forms.Button
    Friend WithEvents BtPricingAnalisys As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEscolhasPricings))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtPricingAnalisys = New System.Windows.Forms.Button()
        Me.BtviewPL_1 = New System.Windows.Forms.Button()
        Me.BtUpdatePricings = New System.Windows.Forms.Button()
        Me.BtAnularEnviarPricings = New System.Windows.Forms.Button()
        Me.BtviewPL = New System.Windows.Forms.Button()
        Me.BtEditPricings = New System.Windows.Forms.Button()
        Me.BtEnviarPricings = New System.Windows.Forms.Button()
        Me.BtAlterarPricing = New System.Windows.Forms.Button()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'BackgroundWorker1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 100000
        '
        'BackgroundWorker2
        '
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(5, 527)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 80)
        Me.Button1.TabIndex = 40
        '
        'BtPricingAnalisys
        '
        Me.BtPricingAnalisys.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtPricingAnalisys.BackColor = System.Drawing.Color.Transparent
        Me.BtPricingAnalisys.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtPricingAnalisys.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtPricingAnalisys.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtPricingAnalisys.ForeColor = System.Drawing.Color.Transparent
        Me.BtPricingAnalisys.Image = Global.CommercialSystem.My.Resources.Resources.btnReports
        Me.BtPricingAnalisys.Location = New System.Drawing.Point(775, 98)
        Me.BtPricingAnalisys.Name = "BtPricingAnalisys"
        Me.BtPricingAnalisys.Size = New System.Drawing.Size(265, 80)
        Me.BtPricingAnalisys.TabIndex = 48
        Me.BtPricingAnalisys.Text = "Pricing Analisys   "
        Me.BtPricingAnalisys.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtPricingAnalisys.UseVisualStyleBackColor = False
        Me.BtPricingAnalisys.Visible = False
        '
        'BtviewPL_1
        '
        Me.BtviewPL_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtviewPL_1.BackColor = System.Drawing.Color.Transparent
        Me.BtviewPL_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtviewPL_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtviewPL_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtviewPL_1.ForeColor = System.Drawing.Color.Transparent
        Me.BtviewPL_1.Image = Global.CommercialSystem.My.Resources.Resources.btnPRICING_reverse
        Me.BtviewPL_1.Location = New System.Drawing.Point(775, 12)
        Me.BtviewPL_1.Name = "BtviewPL_1"
        Me.BtviewPL_1.Size = New System.Drawing.Size(265, 80)
        Me.BtviewPL_1.TabIndex = 45
        Me.BtviewPL_1.Text = "View Last Year Price List. "
        Me.BtviewPL_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtviewPL_1.UseVisualStyleBackColor = False
        Me.BtviewPL_1.Visible = False
        '
        'BtUpdatePricings
        '
        Me.BtUpdatePricings.BackColor = System.Drawing.Color.Transparent
        Me.BtUpdatePricings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtUpdatePricings.Enabled = False
        Me.BtUpdatePricings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtUpdatePricings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtUpdatePricings.ForeColor = System.Drawing.Color.Transparent
        Me.BtUpdatePricings.Image = Global.CommercialSystem.My.Resources.Resources.btnpricing7
        Me.BtUpdatePricings.Location = New System.Drawing.Point(0, 438)
        Me.BtUpdatePricings.Name = "BtUpdatePricings"
        Me.BtUpdatePricings.Size = New System.Drawing.Size(256, 80)
        Me.BtUpdatePricings.TabIndex = 44
        Me.BtUpdatePricings.Text = " Get updated Price List" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " from the Server..."
        Me.BtUpdatePricings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtUpdatePricings.UseVisualStyleBackColor = False
        '
        'BtAnularEnviarPricings
        '
        Me.BtAnularEnviarPricings.BackColor = System.Drawing.Color.Transparent
        Me.BtAnularEnviarPricings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtAnularEnviarPricings.Enabled = False
        Me.BtAnularEnviarPricings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtAnularEnviarPricings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAnularEnviarPricings.ForeColor = System.Drawing.Color.Transparent
        Me.BtAnularEnviarPricings.Image = Global.CommercialSystem.My.Resources.Resources.btnpricing6
        Me.BtAnularEnviarPricings.Location = New System.Drawing.Point(0, 352)
        Me.BtAnularEnviarPricings.Name = "BtAnularEnviarPricings"
        Me.BtAnularEnviarPricings.Size = New System.Drawing.Size(256, 80)
        Me.BtAnularEnviarPricings.TabIndex = 43
        Me.BtAnularEnviarPricings.Text = "  Cancel saved changes."
        Me.BtAnularEnviarPricings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtAnularEnviarPricings.UseVisualStyleBackColor = False
        '
        'BtviewPL
        '
        Me.BtviewPL.BackColor = System.Drawing.Color.Transparent
        Me.BtviewPL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtviewPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtviewPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtviewPL.ForeColor = System.Drawing.Color.Transparent
        Me.BtviewPL.Image = Global.CommercialSystem.My.Resources.Resources.btnPRICING_empty
        Me.BtviewPL.Location = New System.Drawing.Point(0, 12)
        Me.BtviewPL.Name = "BtviewPL"
        Me.BtviewPL.Size = New System.Drawing.Size(256, 80)
        Me.BtviewPL.TabIndex = 42
        Me.BtviewPL.Text = "  View current Price List."
        Me.BtviewPL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtviewPL.UseVisualStyleBackColor = False
        Me.BtviewPL.Visible = False
        '
        'BtEditPricings
        '
        Me.BtEditPricings.BackColor = System.Drawing.Color.Transparent
        Me.BtEditPricings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtEditPricings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEditPricings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEditPricings.ForeColor = System.Drawing.Color.Transparent
        Me.BtEditPricings.Image = Global.CommercialSystem.My.Resources.Resources.btnPRICING_empty_2
        Me.BtEditPricings.Location = New System.Drawing.Point(0, 97)
        Me.BtEditPricings.Name = "BtEditPricings"
        Me.BtEditPricings.Size = New System.Drawing.Size(256, 80)
        Me.BtEditPricings.TabIndex = 41
        Me.BtEditPricings.Text = "  Edit current Price List." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Produce new Price List."
        Me.BtEditPricings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtEditPricings.UseVisualStyleBackColor = False
        '
        'BtEnviarPricings
        '
        Me.BtEnviarPricings.BackColor = System.Drawing.Color.Transparent
        Me.BtEnviarPricings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtEnviarPricings.Enabled = False
        Me.BtEnviarPricings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEnviarPricings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEnviarPricings.ForeColor = System.Drawing.Color.Transparent
        Me.BtEnviarPricings.Image = Global.CommercialSystem.My.Resources.Resources.btnpricing5
        Me.BtEnviarPricings.Location = New System.Drawing.Point(0, 267)
        Me.BtEnviarPricings.Name = "BtEnviarPricings"
        Me.BtEnviarPricings.Size = New System.Drawing.Size(256, 80)
        Me.BtEnviarPricings.TabIndex = 38
        Me.BtEnviarPricings.Text = "  Send Price List to Server."
        Me.BtEnviarPricings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtEnviarPricings.UseVisualStyleBackColor = False
        '
        'BtAlterarPricing
        '
        Me.BtAlterarPricing.BackColor = System.Drawing.Color.Transparent
        Me.BtAlterarPricing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtAlterarPricing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtAlterarPricing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAlterarPricing.ForeColor = System.Drawing.Color.Transparent
        Me.BtAlterarPricing.Image = Global.CommercialSystem.My.Resources.Resources.btnPRICING_empty
        Me.BtAlterarPricing.Location = New System.Drawing.Point(0, 182)
        Me.BtAlterarPricing.Name = "BtAlterarPricing"
        Me.BtAlterarPricing.Size = New System.Drawing.Size(256, 80)
        Me.BtAlterarPricing.TabIndex = 29
        Me.BtAlterarPricing.Text = "  Create Pricing Scenarios."
        Me.BtAlterarPricing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtAlterarPricing.UseVisualStyleBackColor = False
        Me.BtAlterarPricing.Visible = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox9.Location = New System.Drawing.Point(216, 136)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(584, 320)
        Me.PictureBox9.TabIndex = 35
        Me.PictureBox9.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.CommercialSystem.My.Resources.Resources.commercialsystembarra1
        Me.PictureBox3.Location = New System.Drawing.Point(648, 640)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(372, 115)
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
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.CommercialSystem.My.Resources.Resources.SAP_logo
        Me.PictureBox1.Location = New System.Drawing.Point(510, 666)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'FormEscolhasPricings
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(1040, 760)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtPricingAnalisys)
        Me.Controls.Add(Me.BtviewPL_1)
        Me.Controls.Add(Me.BtUpdatePricings)
        Me.Controls.Add(Me.BtAnularEnviarPricings)
        Me.Controls.Add(Me.BtviewPL)
        Me.Controls.Add(Me.BtEditPricings)
        Me.Controls.Add(Me.BtEnviarPricings)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtAlterarPricing)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEscolhasPricings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormEscolhasPricings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        BackgroundWorker1.CancelAsync()
        BackgroundWorker2.CancelAsync()

    End Sub



    Private Sub FormEscolhasPricing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        Me.SuspendLayout()
        Me.Width = Me.MdiParent.ClientSize.Width - 4
        Me.Height = Me.MdiParent.ClientSize.Height - 4

        Dim pricingusers As New ArrayList
        Dim forecastusers As New ArrayList
        Dim pricinanalysisusers As New ArrayList
        pricingusers.Add("SYMINGTON\PV")
        pricingusers.Add("SYMINGTON\HS")
        pricingusers.Add("SYMINGTON\JMA")
        pricingusers.Add("SYMINGTON\MMC")
        pricingusers.Add("SYMINGTON\JVN")
        pricingusers.Add("SYMINGTON\GAB")
        pricingusers.Add("SYMINGTON\GRD")
        pricingusers.Add("SYMINGTON\PFL")
        pricingusers.Add("SYMINGTON\JMV")
        pricingusers.Add("SYMINGTON\HJS")
        pricingusers.Add("SYMINGTON\ACR")
        pricingusers.Add("SYMINGTON\LS")
        pricingusers.Add("SYMINGTON\MJ")
        pricingusers.Add("SYMINGTON\DMS")
        pricingusers.Add("SYMINGTON\MLL")
        pricingusers.Add("SYMINGTON\ABM")
        If pricingusers.Contains(UCase(GetSetting("SalesReports", "User", "login"))) Then
            BtviewPL.Visible = True
            ' BtviewPL_1.Visible = True
            'BtAlterarPricing.Visible = True
            'BtEditPricings.Visible = True
            'BtEnviarPricings.Visible = True
            'BtAnularEnviarPricings.Visible = True
        End If

        pricingusers.Add("SYMINGTON\RADS")
        pricingusers.Add("SYMINGTON\JADS")
        '  pricingusers.Add("SYMINGTON\DMS")
        pricingusers.Add("SYMINGTON\PDS")
        pricingusers.Add("SYMINGTON\JAR")
        pricingusers.Add("SYMINGTON\LMM")
        pricingusers.Add("SYMINGTON\EMM")
        If pricingusers.Contains(UCase(GetSetting("SalesReports", "User", "login"))) Then
            BtviewPL.Visible = True
            'BtviewPL_1.Visible = True
            'BtAlterarPricing.Visible = True
            'BtAnularEnviarPricings.Visible = True
            'BtEnviarPricings.Visible = True
            'BtAnularEnviarPricings.Visible = True
        End If

        pricingusers.Add("SYMINGTON\MAC")
        pricingusers.Add("SYMINGTON\MLL")
        pricingusers.Add("SYMINGTON\TC")
        pricingusers.Add("SYMINGTON\ABB")
        pricingusers.Add("SYMINGTON\JD")
        pricingusers.Add("SYMINGTON\RV")
        pricingusers.Add("SYMINGTON\IF")
        pricingusers.Add("SYMINGTON\EAC")
        pricingusers.Add("SYMINGTON\ABM")
        pricingusers.Add("SYMINGTON\AMF")
        pricingusers.Add("SYMINGTON\CAC")
        pricingusers.Add("SYMINGTON\MFF")
        pricingusers.Add("SYMINGTON\MAM")
        If pricingusers.Contains(UCase(GetSetting("SalesReports", "User", "login"))) Then
            BtviewPL.Visible = True
            'BtviewPL_1.Visible = True
        End If



        pricinanalysisusers.Add("SYMINGTON\PV")
        pricinanalysisusers.Add("SYMINGTON\HS")
        pricinanalysisusers.Add("SYMINGTON\EMM")

        If pricinanalysisusers.Contains(UCase(GetSetting("SalesReports", "User", "login"))) Then
            '            BtPricingAnalisys.Visible = True

        End If

        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker2.RunWorkerAsync()

        Timer1.Start()
        Timer2.Start()

        Me.ResumeLayout()

    End Sub




    Private Sub BtAlterarPricing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAlterarPricing.Click
        Cursor.Current = Cursors.WaitCursor
        Me.SuspendLayout()
        Dim formgrid As New Pricing.FormTreesPricing
        With formgrid
            .apaga = False
            .apaga2 = True
            .varDatabase = "c:\CommercialSystem\dados\Pricing.mdb"
            .varTabela = "query1"
            .MdiParent = Me.MdiParent
            .Show()
        End With
        Me.ResumeLayout()
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub BtviewPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtviewPL.Click
        Cursor.Current = Cursors.WaitCursor
        Me.SuspendLayout()
        Dim formgrid As New Pricing.FormTreesPricing
        With formgrid
            .apaga = True
            .varDatabase = "c:\CommercialSystem\dados\PricingSap.mdb"
            .varTabela = "query1"
            .MdiParent = Me.MdiParent
            .Show()
        End With
        Me.ResumeLayout()
        Cursor.Current = Cursors.Default

    End Sub
    Private Sub BtEditPricings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtEditPricings.Click
        Cursor.Current = Cursors.WaitCursor
        Me.SuspendLayout()

        Dim process As New Process()
        Try
            process.StartInfo.FileName = "c:\CommercialSystem\PricingExcelSap.xlsx"
            process.Start()
            process.WaitForInputIdle()
        Catch
        End Try
        Me.ResumeLayout()
        Cursor.Current = Cursors.Default

    End Sub
    Private Sub BtviewPL_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtviewPL_1.Click
        Cursor.Current = Cursors.WaitCursor
        Me.SuspendLayout()
        Dim formgrid As New Pricing.FormTreesPricing
        With formgrid
            .apaga = True
            .varDatabase = "c:\CommercialSystem\dados\Pricing.mdb"
            .varTabela = "query1_1"
            .MdiParent = Me.MdiParent
            .Show()
        End With
        Me.ResumeLayout()
        Cursor.Current = Cursors.Default

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtEnviarPricings.Click
        Cursor.Current = Cursors.WaitCursor
        Me.SuspendLayout()
        Dim ftp As New Pricing.exportXML

        ftp.ShowDialog()

        Me.ResumeLayout()
        Cursor.Current = Cursors.Default




    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        BackgroundWorker2.RunWorkerAsync()
    End Sub




    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim sqlcommand1 As New SQLiteCommand
        Dim SqlConnection1 As New SQLiteConnection
        SqlConnection1.ConnectionString = "data source=c:\CommercialSystem\dados\SapPricingupdate.db3"
        sqlcommand1.CommandText = "SELECT COUNT(PCCPRO) AS quantos FROM paprixf"
        sqlcommand1.CommandType = CommandType.Text
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()
        Dim ret As Integer = sqlcommand1.ExecuteScalar
        SqlConnection1.Close()
        sqlcommand1.Dispose()
        Try
            If ret > 0 Then
                If My.Computer.Network.Ping("192.168.0.245", 1000) Then
                    e.Result = True

                Else
                    e.Result = False
                End If
            Else
                e.Result = False
            End If
        Catch ex As Exception
            e.Result = False
        End Try

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Result = True Then
            BtEnviarPricings.Enabled = True
            BtAnularEnviarPricings.Enabled = True
        Else
            BtEnviarPricings.Enabled = False
            BtAnularEnviarPricings.Enabled = False
        End If
    End Sub

    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

        Try

            Dim objFileInfo As New FileInfo("c:\CommercialSystem\dados\SapCS.zip")
            'To get the creation, lastaccess, lastwrite time of this file
            Dim dtLastWriteTime As DateTime = objFileInfo.LastWriteTime

            Dim objFileInfo2 As New FileInfo("\\ntfserver01\Customer\vendaspt\update\SapCS.zip")
            Dim dtLastWriteTime2 As DateTime = objFileInfo2.LastWriteTime

            If dtLastWriteTime < dtLastWriteTime2 Then
                e.Result = True
            Else
                e.Result = False
            End If

        Catch ex As Exception
            e.Result = False
        End Try

    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If e.Result = True Then
            BtUpdatePricings.Enabled = True
        Else
            BtUpdatePricings.Enabled = False

        End If
    End Sub





    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAnularEnviarPricings.Click
        Dim ret As MsgBoxResult
        ret = MsgBox("Are you sure?", MsgBoxStyle.YesNo)
        If ret = MsgBoxResult.Yes Then
            Dim SqlConnection1 As New SQLiteConnection
            Dim sqlcommand1 As SQLiteCommand
            SqlConnection1.ConnectionString = "data source=c:\CommercialSystem\dados\SapPricingupdate.db3"
            SqlConnection1.Open()
            sqlcommand1 = New SQLiteCommand("DELETE FROM paprixf", SqlConnection1)
            sqlcommand1.ExecuteScalar()
            SqlConnection1.Close()
        End If
    End Sub

    Private Sub BtUpdatePricings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtUpdatePricings.Click

        Dim ret As MsgBoxResult
        ret = MsgBox("Do you want to update Pricings?", MsgBoxStyle.YesNoCancel, "Update Commercial System")
        If ret = vbNo Then Exit Sub
        If ret = MsgBoxResult.Cancel Then End
        Cursor.Current = Cursors.WaitCursor

        Dim formcopylive As New FormCopy
        formcopylive.Show()
        Cursor.Current = Cursors.WaitCursor

        formcopylive.button1_Click("\\ntfserver01\customer\vendaspt\update\SapCS.zip", "c:\CommercialSystem\dados\SapCS.zip")
        Dim formunziplive As New FormUnzip
        formunziplive.ficheiro = "SapPricing"
        formunziplive.Show()
        UnzipFile("c:\CommercialSystem\dados\SapCS.zip", "c:\CommercialSystem\dados\SapCS.db3")
        formunziplive.Close()
        formcopylive.Close()

        BtUpdatePricings.Enabled = False
        Cursor.Current = Cursors.Default
    End Sub



    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtPricingAnalisys.Click

        'Cursor.Current = Cursors.WaitCursor
        'Dim formPivot As New FormPivotPricing
        'formPivot.MdiParent = Me.MdiParent
        'formPivot.Show()
        'Cursor.Current = Cursors.Default


    End Sub

    
End Class