<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.CAL_PCDATI = New DevExpress.XtraEditors.DateEdit()
        Me.CAL_PCDATF = New DevExpress.XtraEditors.DateEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SapMateriaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapPricingDataset1 = New PricingExcel2007.SapPricingDataset1()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMATNR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAKTX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEWBEZ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFamilia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSUBCATEGORIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVINTAGEYEAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEMBALAGEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCHANGENR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDATADEALTERACAO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRANGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextPriceListType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SapMateriais1TableAdapter = New PricingExcel2007.SapPricingDataset1TableAdapters.SapMateriais1TableAdapter()
        Me.SapTipoListaPrecosTableAdapter = New PricingExcel2007.SapPricingDataset1TableAdapters.SapTipoListaPrecosTableAdapter()
        CType(Me.CAL_PCDATI.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAL_PCDATI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAL_PCDATF.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAL_PCDATF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapMateriaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapPricingDataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.TextPriceListType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(150, 50)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(133, 43)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "Inserir estas datas..."
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Seleccione o Produto..."
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Location = New System.Drawing.Point(6, 59)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(132, 46)
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "Inserir este produto..."
        '
        'CAL_PCDATI
        '
        Me.CAL_PCDATI.EditValue = New Date(2017, 4, 1, 0, 0, 0, 0)
        Me.CAL_PCDATI.Location = New System.Drawing.Point(17, 34)
        Me.CAL_PCDATI.Name = "CAL_PCDATI"
        Me.CAL_PCDATI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CAL_PCDATI.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CAL_PCDATI.Size = New System.Drawing.Size(100, 20)
        Me.CAL_PCDATI.TabIndex = 2
        '
        'CAL_PCDATF
        '
        Me.CAL_PCDATF.EditValue = New Date(2018, 3, 31, 0, 0, 0, 0)
        Me.CAL_PCDATF.Location = New System.Drawing.Point(17, 73)
        Me.CAL_PCDATF.Name = "CAL_PCDATF"
        Me.CAL_PCDATF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CAL_PCDATF.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CAL_PCDATF.Size = New System.Drawing.Size(100, 20)
        Me.CAL_PCDATF.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Data Inicial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Data Final"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.SimpleButton3.Appearance.Options.UseForeColor = True
        Me.SimpleButton3.Location = New System.Drawing.Point(83, 384)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(133, 46)
        Me.SimpleButton3.TabIndex = 9
        Me.SimpleButton3.Text = "Gravar preços..."
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GridLookUpEdit1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.SimpleButton2)
        Me.Panel1.Location = New System.Drawing.Point(1, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 136)
        Me.Panel1.TabIndex = 1004
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.EditValue = ""
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(6, 24)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.SapMateriaisBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "MAKTX"
        Me.GridLookUpEdit1.Properties.ValueMember = "MATNR"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(286, 20)
        Me.GridLookUpEdit1.TabIndex = 11
        '
        'SapMateriaisBindingSource
        '
        Me.SapMateriaisBindingSource.DataMember = "SapMateriais1"
        Me.SapMateriaisBindingSource.DataSource = Me.SapPricingDataset1
        '
        'SapPricingDataset1
        '
        Me.SapPricingDataset1.DataSetName = "SapPricingDataset1"
        Me.SapPricingDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMATNR, Me.colMAKTX, Me.colEWBEZ, Me.colFamilia, Me.colSUBCATEGORIA, Me.colVINTAGEYEAR, Me.colEMBALAGEM, Me.colCHANGENR, Me.colDATADEALTERACAO, Me.colRANGE})
        Me.GridLookUpEdit1View.CustomizationFormBounds = New System.Drawing.Rectangle(1047, 458, 216, 199)
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.GroupCount = 1
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFamilia, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colMATNR
        '
        Me.colMATNR.Caption = "Código"
        Me.colMATNR.FieldName = "MATNR"
        Me.colMATNR.Name = "colMATNR"
        Me.colMATNR.Visible = True
        Me.colMATNR.VisibleIndex = 1
        Me.colMATNR.Width = 176
        '
        'colMAKTX
        '
        Me.colMAKTX.Caption = "Descrição"
        Me.colMAKTX.FieldName = "MAKTX"
        Me.colMAKTX.Name = "colMAKTX"
        Me.colMAKTX.Visible = True
        Me.colMAKTX.VisibleIndex = 2
        Me.colMAKTX.Width = 310
        '
        'colEWBEZ
        '
        Me.colEWBEZ.Caption = "Trademark"
        Me.colEWBEZ.FieldName = "EWBEZ"
        Me.colEWBEZ.Name = "colEWBEZ"
        Me.colEWBEZ.Visible = True
        Me.colEWBEZ.VisibleIndex = 0
        Me.colEWBEZ.Width = 108
        '
        'colFamilia
        '
        Me.colFamilia.Caption = "Family"
        Me.colFamilia.FieldName = "FAMILIA"
        Me.colFamilia.Name = "colFamilia"
        Me.colFamilia.Visible = True
        Me.colFamilia.VisibleIndex = 1
        Me.colFamilia.Width = 117
        '
        'colSUBCATEGORIA
        '
        Me.colSUBCATEGORIA.Caption = "Subcat"
        Me.colSUBCATEGORIA.FieldName = "SUBCATEGORIA"
        Me.colSUBCATEGORIA.Name = "colSUBCATEGORIA"
        Me.colSUBCATEGORIA.Width = 125
        '
        'colVINTAGEYEAR
        '
        Me.colVINTAGEYEAR.FieldName = "VINTAGEYEAR"
        Me.colVINTAGEYEAR.Name = "colVINTAGEYEAR"
        Me.colVINTAGEYEAR.Visible = True
        Me.colVINTAGEYEAR.VisibleIndex = 3
        Me.colVINTAGEYEAR.Width = 162
        '
        'colEMBALAGEM
        '
        Me.colEMBALAGEM.Caption = "Package"
        Me.colEMBALAGEM.FieldName = "Package"
        Me.colEMBALAGEM.Name = "colEMBALAGEM"
        Me.colEMBALAGEM.Visible = True
        Me.colEMBALAGEM.VisibleIndex = 4
        Me.colEMBALAGEM.Width = 182
        '
        'colCHANGENR
        '
        Me.colCHANGENR.FieldName = "CHANGENR"
        Me.colCHANGENR.Name = "colCHANGENR"
        Me.colCHANGENR.Width = 37
        '
        'colDATADEALTERACAO
        '
        Me.colDATADEALTERACAO.FieldName = "DATADEALTERACAO"
        Me.colDATADEALTERACAO.Name = "colDATADEALTERACAO"
        Me.colDATADEALTERACAO.Width = 66
        '
        'colRANGE
        '
        Me.colRANGE.Caption = "Stock"
        Me.colRANGE.FieldName = "RANGE"
        Me.colRANGE.Name = "colRANGE"
        Me.colRANGE.Visible = True
        Me.colRANGE.VisibleIndex = 5
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(144, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 46)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Para eliminar, use o botão " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "direito do rato no numero" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "da linha pretendida."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CAL_PCDATI)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.CAL_PCDATF)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Location = New System.Drawing.Point(1, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(297, 150)
        Me.Panel2.TabIndex = 1005
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.SimpleButton5)
        Me.Panel3.Controls.Add(Me.TextPriceListType)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.SimpleButton4)
        Me.Panel3.Location = New System.Drawing.Point(1, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(297, 91)
        Me.Panel3.TabIndex = 1006
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(169, 51)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(114, 32)
        Me.SimpleButton5.TabIndex = 28
        Me.SimpleButton5.Text = "Alterar PL Type...."
        '
        'TextPriceListType
        '
        Me.TextPriceListType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextPriceListType.Location = New System.Drawing.Point(169, 25)
        Me.TextPriceListType.Name = "TextPriceListType"
        Me.TextPriceListType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TextPriceListType.Properties.DropDownRows = 8
        Me.TextPriceListType.Properties.Items.AddRange(New Object() {"A Standard", "B Promotional", "C Travel Retail", "D Specific Customer", "E A", "F B", "G C", "H D"})
        Me.TextPriceListType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TextPriceListType.Size = New System.Drawing.Size(114, 20)
        Me.TextPriceListType.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Price List Type"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(6, 19)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(133, 43)
        Me.SimpleButton4.TabIndex = 24
        Me.SimpleButton4.Text = "Alterar Customer...."
        '
        'SapMateriais1TableAdapter
        '
        Me.SapMateriais1TableAdapter.ClearBeforeFill = True
        '
        'SapTipoListaPrecosTableAdapter
        '
        Me.SapTipoListaPrecosTableAdapter.ClearBeforeFill = True
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(298, 450)
        CType(Me.CAL_PCDATI.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAL_PCDATI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAL_PCDATF.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAL_PCDATF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapMateriaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapPricingDataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.TextPriceListType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CAL_PCDATI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CAL_PCDATF As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton

    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextPriceListType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SapMateriaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SapPricingDataset1 As PricingExcel2007.SapPricingDataset1
    Friend WithEvents colMATNR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAKTX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEWBEZ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSUBCATEGORIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVINTAGEYEAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMBALAGEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHANGENR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDATADEALTERACAO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SapMateriais1TableAdapter As PricingExcel2007.SapPricingDataset1TableAdapters.SapMateriais1TableAdapter
    Friend WithEvents colRANGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SapTipoListaPrecosTableAdapter As PricingExcel2007.SapPricingDataset1TableAdapters.SapTipoListaPrecosTableAdapter

End Class
