<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCopyFTP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblProgressStatus = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pb = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.pb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProgressStatus
        '
        Me.lblProgressStatus.AutoSize = True
        Me.lblProgressStatus.BackColor = System.Drawing.Color.White
        Me.lblProgressStatus.ForeColor = System.Drawing.Color.Black
        Me.lblProgressStatus.Location = New System.Drawing.Point(12, 59)
        Me.lblProgressStatus.Name = "lblProgressStatus"
        Me.lblProgressStatus.Size = New System.Drawing.Size(52, 13)
        Me.lblProgressStatus.TabIndex = 13
        Me.lblProgressStatus.Text = "Starting..."
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(12, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 12
        Me.lblStatus.Text = "Status"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(12, 29)
        Me.pb.Name = "pb"
        Me.pb.Properties.ShowTitle = True
        Me.pb.Size = New System.Drawing.Size(536, 23)
        Me.pb.TabIndex = 11
        '
        'FormCopyFTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(571, 99)
        Me.Controls.Add(Me.lblProgressStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.pb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCopyFTP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copy File..."
        CType(Me.pb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents lblProgressStatus As System.Windows.Forms.Label
    Private WithEvents lblStatus As System.Windows.Forms.Label

    Friend WithEvents pb As DevExpress.XtraEditors.ProgressBarControl

End Class
