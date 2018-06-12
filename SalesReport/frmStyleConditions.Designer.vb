<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStyleConditions
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FormatItemList = New DevExpress.XtraEditors.ListBoxControl()
        Me.sbRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sbAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.CBField = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.conditionItem1 = New Global.CommercialSystem.ConditionItem()
        CType(Me.FormatItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainerControl1.SuspendLayout()
        CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl1.SuspendLayout()
        CType(Me.CBField.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormatItemList
        '
        Me.FormatItemList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FormatItemList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormatItemList.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.FormatItemList.ItemHeight = 16
        Me.FormatItemList.Location = New System.Drawing.Point(0, 0)
        Me.FormatItemList.Name = "FormatItemList"
        Me.FormatItemList.Size = New System.Drawing.Size(158, 337)
        Me.FormatItemList.TabIndex = 4
        '
        'sbRemove
        '
        Me.sbRemove.Enabled = False
        Me.sbRemove.Location = New System.Drawing.Point(176, 29)
        Me.sbRemove.Name = "sbRemove"
        Me.sbRemove.Size = New System.Drawing.Size(116, 24)
        Me.sbRemove.TabIndex = 1
        Me.sbRemove.Text = "Remove"
        '
        'splitContainerControl1
        '
        Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainerControl1.Location = New System.Drawing.Point(4, 71)
        Me.splitContainerControl1.Name = "splitContainerControl1"
        Me.splitContainerControl1.Panel1.Controls.Add(Me.FormatItemList)
        Me.splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1"
        Me.splitContainerControl1.Panel2.Controls.Add(Me.conditionItem1)
        Me.splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2"
        Me.splitContainerControl1.Size = New System.Drawing.Size(467, 337)
        Me.splitContainerControl1.SplitterPosition = 158
        Me.splitContainerControl1.TabIndex = 7
        Me.splitContainerControl1.Text = "splitContainerControl1"
        '
        'panelControl3
        '
        Me.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.panelControl3.Appearance.Options.UseBackColor = True
        Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelControl3.Location = New System.Drawing.Point(0, 0)
        Me.panelControl3.Name = "panelControl3"
        Me.panelControl3.Size = New System.Drawing.Size(8, 63)
        Me.panelControl3.TabIndex = 2
        '
        'panelControl1
        '
        Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelControl1.Controls.Add(Me.LabelControl1)
        Me.panelControl1.Controls.Add(Me.sbRemove)
        Me.panelControl1.Controls.Add(Me.panelControl3)
        Me.panelControl1.Controls.Add(Me.sbAdd)
        Me.panelControl1.Controls.Add(Me.CBField)
        Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelControl1.Location = New System.Drawing.Point(4, 4)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.panelControl1.Size = New System.Drawing.Size(467, 67)
        Me.panelControl1.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Left
        Me.LabelControl1.Location = New System.Drawing.Point(14, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl1.TabIndex = 34
        Me.LabelControl1.Text = "Field:"
        '
        'sbAdd
        '
        Me.sbAdd.Location = New System.Drawing.Point(14, 29)
        Me.sbAdd.Name = "sbAdd"
        Me.sbAdd.Size = New System.Drawing.Size(156, 24)
        Me.sbAdd.TabIndex = 0
        Me.sbAdd.Text = "Add New Style Condition"
        '
        'CBField
        '
        Me.CBField.Location = New System.Drawing.Point(46, 3)
        Me.CBField.Name = "CBField"
        Me.CBField.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBField.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CBField.Size = New System.Drawing.Size(124, 20)
        Me.CBField.TabIndex = 35
        '
        'conditionItem1
        '
        Me.conditionItem1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.conditionItem1.Appearance.Options.UseBackColor = True
        Me.conditionItem1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.conditionItem1.Location = New System.Drawing.Point(0, 0)
        Me.conditionItem1.LookAndFeel.SkinName = "Lilian"
        Me.conditionItem1.LookAndFeel.UseDefaultLookAndFeel = True
        Me.conditionItem1.Name = "conditionItem1"
        Me.conditionItem1.Size = New System.Drawing.Size(301, 337)
        Me.conditionItem1.TabIndex = 0
        '
        'frmStyleConditions
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 412)
        Me.Controls.Add(Me.splitContainerControl1)
        Me.Controls.Add(Me.panelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LookAndFeel.SkinName = "Lilian"
        Me.LookAndFeel.UseDefaultLookAndFeel = True
        Me.Name = "frmStyleConditions"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Style Conditions Editor"
        CType(Me.FormatItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainerControl1.ResumeLayout(False)
        CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl1.ResumeLayout(False)
        Me.panelControl1.PerformLayout()
        CType(Me.CBField.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents FormatItemList As DevExpress.XtraEditors.ListBoxControl
    Private WithEvents sbRemove As DevExpress.XtraEditors.SimpleButton
    Private WithEvents splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Private WithEvents panelControl3 As DevExpress.XtraEditors.PanelControl
    Private WithEvents panelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents sbAdd As DevExpress.XtraEditors.SimpleButton
    Private WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CBField As DevExpress.XtraEditors.ComboBoxEdit
End Class
