

Public Class FormLogin
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
    Public WithEvents txtuser As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.White
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuser.CausesValidation = False
        Me.txtuser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.No
        Me.txtuser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtuser.Location = New System.Drawing.Point(138, 62)
        Me.txtuser.MaxLength = 0
        Me.txtuser.Name = "txtuser"
        Me.txtuser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtuser.Size = New System.Drawing.Size(136, 26)
        Me.txtuser.TabIndex = 8
        Me.txtuser.TabStop = False
        Me.txtuser.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(50, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username:"
        Me.Label1.Visible = False
        '
        'FormLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(339, 185)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.Opacity = 0.8R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region




    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Show()
        'Me.TopMost = True

        Dim UserIdentityInfo As System.Security.Principal.WindowsIdentity
        ''     Dim strMsg As String
        UserIdentityInfo = System.Security.Principal.WindowsIdentity.GetCurrent()
        txtuser.Text = UserIdentityInfo.Name()

        'txtuser.Refresh()
        'Label1.Refresh()
        'PictureBox1.Refresh()
        'PictureBox2.Refresh()

        Select Case UCase(UserIdentityInfo.Name())
            Case "SYMINGTON\HS", "SYMINGTON\EMM", "SYMINGTON\JMA", "SYMINGTON\MMC", "SYMINGTON\PV", "SYMINGTON\AMF", "SYMINGTON\PFL", "SYMINGTON\FRS", "SYMINGTON\CLC", "SYMINGTON\JMV",
                "SYMINGTON\JVN", "SYMINGTON\GAB", "SYMINGTON\GRD", "SYMINGTON\ACR", "SYMINGTON\RJR", "SYMINGTON\ABM", "SYMINGTON\MFF", "SYMINGTON\IPM", "SYMINGTON\EDR",
                 "COMERC_JVN\JORGE", "SYMINGTON\PAM", "DESKTOP-7RA9PT2\SOFIAZHANG", "SYMINGTON\IF", "SYMINGTON\TC", "SYMINGTON\MAM", "SYMINGTON\FCL", "SYMINGTON\ARSC", "SYMINGTON\ABB", "SYMINGTON\EAC",
                 "SYMINGTON\MLL", "SYMINGTON\MTB", "SYMINGTON\DMS", "SYMINGTON\JADS", "SYMINGTON\RADS", "SYMINGTON\RDTS", "SYMINGTON\PDS", "SYMINGTON\CAS", "SYMINGTON\PRS", "SYMINGTON\RVB", "SYMINGTON\RAP"
                EditPricing = True
                ViewPricing = True

            Case "SYMINGTON\MFB", "SYMINGTON\HJS", "SYMINGTON\CAC",
                 "SYMINGTON\JAR", "SYMINGTON\LMM", "SYMINGTON\FSC", "SYMINGTON\ASC", "SYMINGTON\MCC", "SYMINGTON\ASK", "SYMINGTON\PAS", "SYMINGTON\DHC", "SYMINGTON\PSC", "SYMINGTON\RJMR", "SYMINGTON\ZAR",
                 "SYMINGTON\CEM", "SYMINGTON\BMP", "SYMINGTON\ALM", "SYMINGTON\MFA", "SYMINGTON\TFO", "SYMINGTON\PUD", "SYMINGTON\PMDS"
                ViewPricing = True
        End Select



        'System.Threading.Thread.Sleep(1250)
        SaveSetting("SalesReports", "User", "login", txtuser.Text)
        Me.Close()



        'Dim user As String

        'Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\CommercialSystem\dados\db2.mdb"
        'user = "select * from acesso" & " where user= '" & txtuser.Text.Remove(0, 10) & "'"

        'Using connection As New OleDbConnection(con)
        '    Dim command As New OleDbCommand(user, connection)
        '    connection.Open()
        '    Dim reader As OleDbDataReader = command.ExecuteReader()
        '    If reader.HasRows = False Then
        '        If Not (UCase(txtuser.Text)) = "PPWLAN\PETERST" And Not (UCase(txtuser.Text)) = "PPWLAN\DIXIEGL" And Not (UCase(txtuser.Text)) = "AT_PC\ADMINISTRADOR" And Not (UCase(txtuser.Text)) = "ANTONIOBELEZAPC\ANTONIOBELEZA" Then
        '            MsgBox("O utilizador " & txtuser.Text & ", não têm acesso")
        '            End
        '        End If
        '    End If
        '    reader.Close()
        'End Using





    End Sub


    'Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click


    '    SaveSetting("SalesReports", "User", "login", txtuser.Text)
    '    Me.Close()


    'End Sub


    'Private Sub txtuser_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    If KeyAscii = 13 Then
    '        ' txtpassword.Focus()
    '    End If


    '    If KeyAscii = 0 Then
    '        eventArgs.Handled = True
    '    End If
    'End Sub


End Class
