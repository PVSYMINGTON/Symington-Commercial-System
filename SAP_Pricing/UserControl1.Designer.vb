<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    'Inherits System.Windows.Forms.UserControl
    Inherits DevExpress.XtraEditors.XtraUserControl
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
        Me.ButtonInsDate = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.ButtonInsertProduct = New DevExpress.XtraEditors.SimpleButton()
        Me.CAL_PCDATI = New DevExpress.XtraEditors.DateEdit()
        Me.CAL_PCDATF = New DevExpress.XtraEditors.DateEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.ButtonGravarPrecos = New DevExpress.XtraEditors.SimpleButton()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SapMateriais1BindingSource = New System.Windows.Forms.BindingSource()
        Me.SapCSDataSet = New SAP_Pricing.SapCSDataSet()
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
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.ButtonAlterarPL = New DevExpress.XtraEditors.SimpleButton()
        Me.TextPriceListType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.ButtonAlterarCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtonEstipulacoes = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TextAnoPricing = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.SapTipoListaPrecosTableAdapter = New SAP_Pricing.SapCSDataSetTableAdapters.SapTipoListaPrecosTableAdapter()
        Me.SapMateriais1TableAdapter = New SAP_Pricing.SapCSDataSetTableAdapters.SapMateriais1TableAdapter()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager()
        CType(Me.CAL_PCDATI.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAL_PCDATI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAL_PCDATF.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAL_PCDATF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapMateriais1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapCSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextPriceListType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.TextAnoPricing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonInsDate
        '
        Me.ButtonInsDate.Location = New System.Drawing.Point(148, 39)
        Me.ButtonInsDate.Name = "ButtonInsDate"
        Me.ButtonInsDate.Size = New System.Drawing.Size(133, 43)
        Me.ButtonInsDate.TabIndex = 6
        Me.ButtonInsDate.Text = "Inserir estas datas..."
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(12, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Seleccione o Produto..."
        '
        'ButtonInsertProduct
        '
        Me.ButtonInsertProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonInsertProduct.Location = New System.Drawing.Point(5, 86)
        Me.ButtonInsertProduct.Name = "ButtonInsertProduct"
        Me.ButtonInsertProduct.Size = New System.Drawing.Size(139, 46)
        Me.ButtonInsertProduct.TabIndex = 9
        Me.ButtonInsertProduct.Text = "Inserir este produto..."
        '
        'CAL_PCDATI
        '
        Me.CAL_PCDATI.EditValue = New Date(2018, 4, 1, 0, 0, 0, 0)
        Me.CAL_PCDATI.Location = New System.Drawing.Point(15, 23)
        Me.CAL_PCDATI.Name = "CAL_PCDATI"
        Me.CAL_PCDATI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CAL_PCDATI.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CAL_PCDATI.Size = New System.Drawing.Size(100, 20)
        Me.CAL_PCDATI.TabIndex = 2
        '
        'CAL_PCDATF
        '
        Me.CAL_PCDATF.EditValue = New Date(2019, 3, 31, 0, 0, 0, 0)
        Me.CAL_PCDATF.Location = New System.Drawing.Point(15, 62)
        Me.CAL_PCDATF.Name = "CAL_PCDATF"
        Me.CAL_PCDATF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CAL_PCDATF.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CAL_PCDATF.Size = New System.Drawing.Size(100, 20)
        Me.CAL_PCDATF.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Data Inicial"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Data Final"
        '
        'ButtonGravarPrecos
        '
        Me.ButtonGravarPrecos.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.ButtonGravarPrecos.Appearance.Options.UseForeColor = True
        Me.ButtonGravarPrecos.Location = New System.Drawing.Point(82, 15)
        Me.ButtonGravarPrecos.Name = "ButtonGravarPrecos"
        Me.ButtonGravarPrecos.Size = New System.Drawing.Size(133, 46)
        Me.ButtonGravarPrecos.TabIndex = 9
        Me.ButtonGravarPrecos.Text = "Gravar preços..."
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.EditValue = ""
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(4, 24)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.SapMateriais1BindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "MAKTX"
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Properties.ValueMember = "MATNR"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(286, 20)
        Me.GridLookUpEdit1.TabIndex = 11
        '
        'SapMateriais1BindingSource
        '
        Me.SapMateriais1BindingSource.DataMember = "SapMateriais1"
        Me.SapMateriais1BindingSource.DataSource = Me.SapCSDataSet
        '
        'SapCSDataSet
        '
        Me.SapCSDataSet.DataSetName = "SapCSDataSet"
        Me.SapCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label10.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Appearance.Options.UseFont = True
        Me.Label10.Location = New System.Drawing.Point(150, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 42)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Para eliminar, use o botão " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "direito do rato no numero" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "da linha pretendida."
        '
        'ButtonAlterarPL
        '
        Me.ButtonAlterarPL.Location = New System.Drawing.Point(167, 68)
        Me.ButtonAlterarPL.Name = "ButtonAlterarPL"
        Me.ButtonAlterarPL.Size = New System.Drawing.Size(114, 32)
        Me.ButtonAlterarPL.TabIndex = 28
        Me.ButtonAlterarPL.Text = "Alterar PL Type...."
        '
        'TextPriceListType
        '
        Me.TextPriceListType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextPriceListType.Location = New System.Drawing.Point(175, 42)
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
        Me.Label1.Location = New System.Drawing.Point(196, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Price List Type"
        '
        'ButtonAlterarCustomer
        '
        Me.ButtonAlterarCustomer.Location = New System.Drawing.Point(4, 36)
        Me.ButtonAlterarCustomer.Name = "ButtonAlterarCustomer"
        Me.ButtonAlterarCustomer.Size = New System.Drawing.Size(133, 43)
        Me.ButtonAlterarCustomer.TabIndex = 24
        Me.ButtonAlterarCustomer.Text = "Alterar Customer...."
        '
        'ButtonEstipulacoes
        '
        Me.ButtonEstipulacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEstipulacoes.Location = New System.Drawing.Point(75, 5)
        Me.ButtonEstipulacoes.Name = "ButtonEstipulacoes"
        Me.ButtonEstipulacoes.Size = New System.Drawing.Size(140, 46)
        Me.ButtonEstipulacoes.TabIndex = 9
        Me.ButtonEstipulacoes.Text = "Alterar Estipulações"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.ButtonGravarPrecos)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 430)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(298, 81)
        Me.PanelControl1.TabIndex = 1008
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.ButtonEstipulacoes)
        Me.PanelControl2.Location = New System.Drawing.Point(0, 367)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(298, 57)
        Me.PanelControl2.TabIndex = 1009
        Me.PanelControl2.Visible = False
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.ButtonInsertProduct)
        Me.PanelControl3.Controls.Add(Me.GridLookUpEdit1)
        Me.PanelControl3.Controls.Add(Me.Label10)
        Me.PanelControl3.Controls.Add(Me.Label3)
        Me.PanelControl3.Controls.Add(Me.TextAnoPricing)
        Me.PanelControl3.Location = New System.Drawing.Point(0, 224)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(298, 137)
        Me.PanelControl3.TabIndex = 1010
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(26, 54)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Insira o ANO..."
        '
        'TextAnoPricing
        '
        Me.TextAnoPricing.EditValue = "9999"
        Me.TextAnoPricing.Location = New System.Drawing.Point(105, 51)
        Me.TextAnoPricing.Name = "TextAnoPricing"
        Me.TextAnoPricing.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None
        Me.TextAnoPricing.Properties.Mask.BeepOnError = True
        Me.TextAnoPricing.Properties.Mask.EditMask = "((19|20)\d{2})|(9999)"
        Me.TextAnoPricing.Properties.Mask.IgnoreMaskBlank = False
        Me.TextAnoPricing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.TextAnoPricing.Properties.Mask.ShowPlaceHolders = False
        Me.TextAnoPricing.Size = New System.Drawing.Size(100, 20)
        Me.TextAnoPricing.TabIndex = 14
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.CAL_PCDATI)
        Me.PanelControl4.Controls.Add(Me.ButtonInsDate)
        Me.PanelControl4.Controls.Add(Me.Label4)
        Me.PanelControl4.Controls.Add(Me.Label5)
        Me.PanelControl4.Controls.Add(Me.CAL_PCDATF)
        Me.PanelControl4.Location = New System.Drawing.Point(0, 121)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(298, 97)
        Me.PanelControl4.TabIndex = 1011
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.ButtonAlterarPL)
        Me.PanelControl5.Controls.Add(Me.TextPriceListType)
        Me.PanelControl5.Controls.Add(Me.ButtonAlterarCustomer)
        Me.PanelControl5.Controls.Add(Me.Label1)
        Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(298, 115)
        Me.PanelControl5.TabIndex = 1012
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureEdit1.EditValue = Global.SAP_Pricing.My.Resources.Resources.SFE_Logo_Principal
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 521)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ReadOnly = True
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[False]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(298, 96)
        Me.PictureEdit1.TabIndex = 1013
        '
        'SapTipoListaPrecosTableAdapter
        '
        Me.SapTipoListaPrecosTableAdapter.ClearBeforeFill = True
        '
        'SapMateriais1TableAdapter
        '
        Me.SapMateriais1TableAdapter.ClearBeforeFill = True
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PictureEdit1)
        Me.DoubleBuffered = True
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(298, 617)
        CType(Me.CAL_PCDATI.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAL_PCDATI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAL_PCDATF.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAL_PCDATF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapMateriais1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapCSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextPriceListType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.TextAnoPricing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonInsDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl 'System.Windows.Forms.Label
    Friend WithEvents ButtonInsertProduct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CAL_PCDATI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CAL_PCDATF As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl 'System.Windows.Forms.Label
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl 'System.Windows.Forms.Label
    Friend WithEvents ButtonGravarPrecos As DevExpress.XtraEditors.SimpleButton

    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl 'System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ButtonAlterarCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextPriceListType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl 'System.Windows.Forms.Label
    Friend WithEvents ButtonAlterarPL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SapCSDataSet As SapCSDataSet
    Friend WithEvents colMATNR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAKTX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEWBEZ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSUBCATEGORIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVINTAGEYEAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMBALAGEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHANGENR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDATADEALTERACAO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRANGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SapTipoListaPrecosTableAdapter As SapCSDataSetTableAdapters.SapTipoListaPrecosTableAdapter
    Friend WithEvents SapMateriais1BindingSource As BindingSource
    Friend WithEvents SapMateriais1TableAdapter As SapCSDataSetTableAdapters.SapMateriais1TableAdapter
    Friend WithEvents ButtonEstipulacoes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextAnoPricing As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class
