<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConditionItem
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.label2 = New DevExpress.XtraEditors.LabelControl()
        Me.ceCustomSummaryCell = New DevExpress.XtraEditors.CheckEdit()
        Me.ceGrandTotalCell = New DevExpress.XtraEditors.CheckEdit()
        Me.ceTotalCell = New DevExpress.XtraEditors.CheckEdit()
        Me.ceCell = New DevExpress.XtraEditors.CheckEdit()
        Me.label4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbVal2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbVal1 = New DevExpress.XtraEditors.LabelControl()
        Me.icbCondition = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.label1 = New DevExpress.XtraEditors.LabelControl()
        Me.propertyGrid1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
        Me.seValue1 = New DevExpress.XtraEditors.TextEdit()
        Me.seValue2 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.ceCustomSummaryCell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceGrandTotalCell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceTotalCell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icbCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.propertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seValue1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seValue2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.label2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.label2.LineLocation = DevExpress.XtraEditors.LineLocation.Left
        Me.label2.Location = New System.Drawing.Point(12, 98)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 13)
        Me.label2.TabIndex = 30
        Me.label2.Text = "Apply To:"
        '
        'ceCustomSummaryCell
        '
        Me.ceCustomSummaryCell.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ceCustomSummaryCell.Location = New System.Drawing.Point(124, 119)
        Me.ceCustomSummaryCell.Name = "ceCustomSummaryCell"
        Me.ceCustomSummaryCell.Properties.Caption = "Custom Total Cell"
        Me.ceCustomSummaryCell.Properties.LookAndFeel.SkinName = "Lilian"
        Me.ceCustomSummaryCell.Size = New System.Drawing.Size(162, 19)
        Me.ceCustomSummaryCell.TabIndex = 25
        Me.ceCustomSummaryCell.Visible = False
        '
        'ceGrandTotalCell
        '
        Me.ceGrandTotalCell.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ceGrandTotalCell.Location = New System.Drawing.Point(194, 93)
        Me.ceGrandTotalCell.Name = "ceGrandTotalCell"
        Me.ceGrandTotalCell.Properties.Caption = "Cell"
        Me.ceGrandTotalCell.Properties.LookAndFeel.SkinName = "Lilian"
        Me.ceGrandTotalCell.Size = New System.Drawing.Size(69, 19)
        Me.ceGrandTotalCell.TabIndex = 24
        '
        'ceTotalCell
        '
        Me.ceTotalCell.Location = New System.Drawing.Point(80, 93)
        Me.ceTotalCell.Name = "ceTotalCell"
        Me.ceTotalCell.Properties.Caption = "Total Cell"
        Me.ceTotalCell.Properties.LookAndFeel.SkinName = "Lilian"
        Me.ceTotalCell.Size = New System.Drawing.Size(108, 19)
        Me.ceTotalCell.TabIndex = 23
        '
        'ceCell
        '
        Me.ceCell.Location = New System.Drawing.Point(10, 119)
        Me.ceCell.Name = "ceCell"
        Me.ceCell.Properties.Caption = "Cell"
        Me.ceCell.Properties.LookAndFeel.SkinName = "Lilian"
        Me.ceCell.Size = New System.Drawing.Size(108, 19)
        Me.ceCell.TabIndex = 22
        Me.ceCell.Visible = False
        '
        'label4
        '
        Me.label4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.label4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.label4.LineLocation = DevExpress.XtraEditors.LineLocation.Left
        Me.label4.Location = New System.Drawing.Point(12, 121)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 13)
        Me.label4.TabIndex = 29
        Me.label4.Text = "Appearance:"
        '
        'lbVal2
        '
        Me.lbVal2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbVal2.LineLocation = DevExpress.XtraEditors.LineLocation.Left
        Me.lbVal2.Location = New System.Drawing.Point(12, 70)
        Me.lbVal2.Name = "lbVal2"
        Me.lbVal2.Size = New System.Drawing.Size(39, 13)
        Me.lbVal2.TabIndex = 28
        Me.lbVal2.Text = "Value 2:"
        '
        'lbVal1
        '
        Me.lbVal1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbVal1.LineLocation = DevExpress.XtraEditors.LineLocation.Left
        Me.lbVal1.Location = New System.Drawing.Point(12, 46)
        Me.lbVal1.Name = "lbVal1"
        Me.lbVal1.Size = New System.Drawing.Size(39, 13)
        Me.lbVal1.TabIndex = 27
        Me.lbVal1.Text = "Value 1:"
        '
        'icbCondition
        '
        Me.icbCondition.EditValue = "imageComboBoxEdit1"
        Me.icbCondition.Location = New System.Drawing.Point(108, 22)
        Me.icbCondition.Name = "icbCondition"
        Me.icbCondition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.icbCondition.Properties.DropDownRows = 10
        Me.icbCondition.Properties.LookAndFeel.SkinName = "Lilian"
        Me.icbCondition.Size = New System.Drawing.Size(132, 20)
        Me.icbCondition.TabIndex = 19
        '
        'label1
        '
        Me.label1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.label1.LineLocation = DevExpress.XtraEditors.LineLocation.Left
        Me.label1.Location = New System.Drawing.Point(12, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 26
        Me.label1.Text = "Condition:"
        '
        'propertyGrid1
        '
        Me.propertyGrid1.Location = New System.Drawing.Point(8, 140)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(278, 192)
        Me.propertyGrid1.TabIndex = 31
        '
        'seValue1
        '
        Me.seValue1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seValue1.Location = New System.Drawing.Point(128, 46)
        Me.seValue1.Name = "seValue1"
        Me.seValue1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.seValue1.Properties.LookAndFeel.SkinName = "Lilian"
        Me.seValue1.Size = New System.Drawing.Size(112, 20)
        Me.seValue1.TabIndex = 20
        '
        'seValue2
        '
        Me.seValue2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seValue2.Location = New System.Drawing.Point(128, 70)
        Me.seValue2.Name = "seValue2"
        Me.seValue2.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.seValue2.Properties.LookAndFeel.SkinName = "Lilian"
        Me.seValue2.Size = New System.Drawing.Size(112, 20)
        Me.seValue2.TabIndex = 21
        '
        'ConditionItem
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.propertyGrid1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.ceGrandTotalCell)
        Me.Controls.Add(Me.ceTotalCell)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.lbVal2)
        Me.Controls.Add(Me.lbVal1)
        Me.Controls.Add(Me.icbCondition)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.ceCustomSummaryCell)
        Me.Controls.Add(Me.ceCell)
        Me.Controls.Add(Me.seValue1)
        Me.Controls.Add(Me.seValue2)
        Me.LookAndFeel.SkinName = "Lilian"
        Me.Name = "ConditionItem"
        Me.Size = New System.Drawing.Size(294, 368)
        CType(Me.ceCustomSummaryCell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceGrandTotalCell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceTotalCell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icbCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.propertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seValue1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seValue2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents ceCustomSummaryCell As DevExpress.XtraEditors.CheckEdit
    Private WithEvents ceGrandTotalCell As DevExpress.XtraEditors.CheckEdit
    Private WithEvents ceTotalCell As DevExpress.XtraEditors.CheckEdit
    Private WithEvents ceCell As DevExpress.XtraEditors.CheckEdit
    Private WithEvents label4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents lbVal2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents lbVal1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents icbCondition As DevExpress.XtraEditors.ImageComboBoxEdit
    Private WithEvents label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents propertyGrid1 As DevExpress.XtraVerticalGrid.PropertyGridControl
    Friend WithEvents seValue1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents seValue2 As DevExpress.XtraEditors.TextEdit

End Class
