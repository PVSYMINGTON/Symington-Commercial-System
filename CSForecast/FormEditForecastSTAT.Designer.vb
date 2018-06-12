<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditForecastSTAT
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.CSForecast.SplashScreen1), True, True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditForecastSTAT))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.colStatusPricing = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colStatusMat = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DiffTarget = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.SapForecastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapMateriaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapMateriaisEmbalagemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapClientsMDMMMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colYear = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPeriod = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodCliFact = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCodCliStat1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodCliStat = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCompany = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colEmbalagem = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescMaterial = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTPRE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCurrency = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colQuarter1Value = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colQuarter2Value = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colQuarter3Value = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colQuarter4Value = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colQuarterSum = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colInHand = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ColShipped = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DiffFQAnt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Target9L = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFQ1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFQ2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFQ3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFQ4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAnualValue = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.iExit = New DevExpress.XtraBars.BarButtonItem()
        Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.iSave = New DevExpress.XtraBars.BarButtonItem()
        Me.iCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.iExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.iClients = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.iClientsMA = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.iYear = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.Iperiod = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.ClearSelect = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.homeRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.fileRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.skinsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.filterRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.exitRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapForecastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapMateriaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapMateriaisEmbalagemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapClientsMDMMMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colStatusPricing
        '
        Me.colStatusPricing.Caption = "colStatusPricing"
        Me.colStatusPricing.FieldName = "colStatusPricing"
        Me.colStatusPricing.Name = "colStatusPricing"
        Me.colStatusPricing.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        '
        'colStatusMat
        '
        Me.colStatusMat.Caption = "colStatusMat"
        Me.colStatusMat.FieldName = "colStatusMat"
        Me.colStatusMat.Name = "colStatusMat"
        Me.colStatusMat.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        '
        'DiffTarget
        '
        Me.DiffTarget.AppearanceHeader.Options.UseTextOptions = True
        Me.DiffTarget.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.DiffTarget.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.DiffTarget.Caption = "DiffTarget"
        Me.DiffTarget.DisplayFormat.FormatString = "#,###.00;-#,###.00;0"
        Me.DiffTarget.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DiffTarget.FieldName = "DifTargetForecast"
        Me.DiffTarget.Name = "DiffTarget"
        Me.DiffTarget.OptionsColumn.AllowEdit = False
        Me.DiffTarget.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.DiffTarget.OptionsColumn.ReadOnly = True
        Me.DiffTarget.UnboundExpression = "[AnualValue] - [Target]"
        Me.DiffTarget.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.DiffTarget.Visible = True
        Me.DiffTarget.Width = 65
        '
        'ribbonImageCollection
        '
        Me.ribbonImageCollection.ImageStream = CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(15, "Undo.png")
        '
        'ribbonImageCollectionLarge
        '
        Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.ribbonImageCollectionLarge.ImageStream = CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(9, "Undo.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(10, "excel_icon.gif")
        '
        'SapForecastBindingSource
        '
        Me.SapForecastBindingSource.DataSource = GetType(CSForecast.SapForecastStat)
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.SapForecastBindingSource
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 130)
        Me.gridControl.MainView = Me.BandedGridView1
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemLookUpEdit7, Me.RepositoryItemLookUpEdit6, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.gridControl.Size = New System.Drawing.Size(951, 644)
        Me.gridControl.TabIndex = 2
        Me.gridControl.UseEmbeddedNavigator = True
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.BandPanel.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2})
        Me.BandedGridView1.ColumnPanelRowHeight = 30
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colYear, Me.colPeriod, Me.GridColumn1, Me.colCodCliFact, Me.colCodCliStat, Me.colCodCliStat1, Me.colCompany, Me.colCodigo, Me.colEmbalagem, Me.colDescMaterial, Me.colTPRE, Me.colCurrency, Me.colQuarter1Value, Me.colQuarter2Value, Me.colQuarter3Value, Me.colQuarter4Value, Me.colQuarterSum, Me.colInHand, Me.ColShipped, Me.Target9L, Me.DiffFQAnt, Me.DiffTarget, Me.colFQ1, Me.colFQ2, Me.colFQ3, Me.colFQ4, Me.colAnualValue, Me.colStatusMat, Me.colStatusPricing})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colStatusPricing
        GridFormatRule1.Name = "FormataFaltadePricing"
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.PredefinedName = "Yellow Fill, Yellow Text"
        FormatConditionRuleValue1.Value1 = False
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.colStatusMat
        GridFormatRule2.Name = "FormataFaltadeProduto"
        FormatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue2.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.PredefinedName = "Red Fill, Red Text"
        FormatConditionRuleValue2.Value1 = True
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.BandedGridView1.FormatRules.Add(GridFormatRule1)
        Me.BandedGridView1.FormatRules.Add(GridFormatRule2)
        Me.BandedGridView1.GridControl = Me.gridControl
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.BandedGridView1.OptionsBehavior.ImmediateUpdateRowPosition = False
        Me.BandedGridView1.OptionsDetail.AllowZoomDetail = False
        Me.BandedGridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.BandedGridView1.OptionsView.AllowCellMerge = True
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.BandedGridView1.OptionsView.ShowFooter = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        Me.BandedGridView1.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.BandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCodigo, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEmbalagem, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTPRE, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCurrency, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCompany, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDescMaterial, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCodCliStat, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "SalesUnits"
        Me.GridBand1.Columns.Add(Me.colYear)
        Me.GridBand1.Columns.Add(Me.colPeriod)
        Me.GridBand1.Columns.Add(Me.colCodCliFact)
        Me.GridBand1.Columns.Add(Me.colCodCliStat1)
        Me.GridBand1.Columns.Add(Me.colCodCliStat)
        Me.GridBand1.Columns.Add(Me.GridColumn1)
        Me.GridBand1.Columns.Add(Me.colCompany)
        Me.GridBand1.Columns.Add(Me.colCodigo)
        Me.GridBand1.Columns.Add(Me.colEmbalagem)
        Me.GridBand1.Columns.Add(Me.colDescMaterial)
        Me.GridBand1.Columns.Add(Me.colTPRE)
        Me.GridBand1.Columns.Add(Me.colCurrency)
        Me.GridBand1.Columns.Add(Me.colQuarter1Value)
        Me.GridBand1.Columns.Add(Me.colQuarter2Value)
        Me.GridBand1.Columns.Add(Me.colQuarter3Value)
        Me.GridBand1.Columns.Add(Me.colQuarter4Value)
        Me.GridBand1.Columns.Add(Me.colQuarterSum)
        Me.GridBand1.Columns.Add(Me.colInHand)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 939
        '
        'colYear
        '
        Me.colYear.AppearanceHeader.Options.UseTextOptions = True
        Me.colYear.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colYear.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYear.Caption = "Year"
        Me.colYear.FieldName = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.Visible = True
        Me.colYear.Width = 32
        '
        'colPeriod
        '
        Me.colPeriod.AppearanceHeader.Options.UseTextOptions = True
        Me.colPeriod.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colPeriod.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPeriod.Caption = "FQ"
        Me.colPeriod.FieldName = "Period"
        Me.colPeriod.Name = "colPeriod"
        Me.colPeriod.Visible = True
        Me.colPeriod.Width = 24
        '
        'colCodCliFact
        '
        Me.colCodCliFact.AppearanceCell.Options.UseTextOptions = True
        Me.colCodCliFact.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCodCliFact.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodCliFact.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodCliFact.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodCliFact.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodCliFact.Caption = "Inv. Cust. Nº"
        Me.colCodCliFact.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCodCliFact.FieldName = "CodCliFact"
        Me.colCodCliFact.Name = "colCodCliFact"
        Me.colCodCliFact.Visible = True
        Me.colCodCliFact.Width = 41
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "0000000000"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colCodCliStat1
        '
        Me.colCodCliStat1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodCliStat1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCodCliStat1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodCliStat1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodCliStat1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodCliStat1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodCliStat1.Caption = "Stat. Cust. Nº"
        Me.colCodCliStat1.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCodCliStat1.FieldName = "CodCliStat"
        Me.colCodCliStat1.Name = "colCodCliStat1"
        Me.colCodCliStat1.Visible = True
        Me.colCodCliStat1.Width = 41
        '
        'colCodCliStat
        '
        Me.colCodCliStat.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodCliStat.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodCliStat.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodCliStat.Caption = "Statistic Customer"
        Me.colCodCliStat.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colCodCliStat.FieldName = "CodCliStat"
        Me.colCodCliStat.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colCodCliStat.Name = "colCodCliStat"
        Me.colCodCliStat.OptionsColumn.AllowEdit = False
        Me.colCodCliStat.OptionsColumn.ReadOnly = True
        Me.colCodCliStat.Visible = True
        Me.colCodCliStat.Width = 100
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KUNNR", "KUNNR", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME1", "NAME1", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LANDX50", "LANDX50", 54, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MARKETASSISTANT", "MARKETASSISTANT", 105, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MARKETDIRECTOR", "MARKETDIRECTOR", 102, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MARKETMANAGER", "MARKETMANAGER", 99, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.SapClientsBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "NAME1"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "KUNNR"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.GridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn1.Caption = "Stats Market"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.GridColumn1.FieldName = "CodCliStat"
        Me.GridColumn1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.Width = 81
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME1", "NAME1", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KUNNR", "KUNNR", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LANDX50", "LANDX50", 54, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MARKETASSISTANT", "MARKETASSISTANT", 105, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MARKETDIRECTOR", "MARKETDIRECTOR", 102, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MARKETMANAGER", "MARKETMANAGER", 99, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.SapClientsBindingSource
        Me.RepositoryItemLookUpEdit4.DisplayMember = "LANDX50"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.ValueMember = "KUNNR"
        '
        'colCompany
        '
        Me.colCompany.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompany.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCompany.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompany.Caption = "Brand"
        Me.colCompany.FieldName = "colCompany"
        Me.colCompany.Name = "colCompany"
        Me.colCompany.OptionsColumn.AllowEdit = False
        Me.colCompany.OptionsColumn.ReadOnly = True
        Me.colCompany.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colCompany.Visible = True
        Me.colCompany.Width = 59
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigo.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodigo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigo.Caption = "Material Number"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCodigo.Visible = True
        Me.colCodigo.Width = 83
        '
        'colEmbalagem
        '
        Me.colEmbalagem.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmbalagem.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colEmbalagem.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmbalagem.Caption = "Embalagem"
        Me.colEmbalagem.FieldName = "colEmbalagem"
        Me.colEmbalagem.Name = "colEmbalagem"
        Me.colEmbalagem.OptionsColumn.AllowEdit = False
        Me.colEmbalagem.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colEmbalagem.OptionsColumn.ReadOnly = True
        Me.colEmbalagem.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colEmbalagem.Visible = True
        Me.colEmbalagem.Width = 76
        '
        'colDescMaterial
        '
        Me.colDescMaterial.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescMaterial.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colDescMaterial.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDescMaterial.Caption = "Material"
        Me.colDescMaterial.FieldName = "colDescMaterial"
        Me.colDescMaterial.Name = "colDescMaterial"
        Me.colDescMaterial.OptionsColumn.AllowEdit = False
        Me.colDescMaterial.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDescMaterial.OptionsColumn.ReadOnly = True
        Me.colDescMaterial.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colDescMaterial.Visible = True
        Me.colDescMaterial.Width = 90
        '
        'colTPRE
        '
        Me.colTPRE.AppearanceHeader.Options.UseTextOptions = True
        Me.colTPRE.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colTPRE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTPRE.Caption = "Pricing List"
        Me.colTPRE.FieldName = "TPRE"
        Me.colTPRE.Name = "colTPRE"
        Me.colTPRE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTPRE.Visible = True
        Me.colTPRE.Width = 20
        '
        'colCurrency
        '
        Me.colCurrency.AppearanceHeader.Options.UseTextOptions = True
        Me.colCurrency.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCurrency.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCurrency.Caption = "Currency"
        Me.colCurrency.FieldName = "Currency"
        Me.colCurrency.Name = "colCurrency"
        Me.colCurrency.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCurrency.Visible = True
        Me.colCurrency.Width = 32
        '
        'colQuarter1Value
        '
        Me.colQuarter1Value.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuarter1Value.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colQuarter1Value.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuarter1Value.Caption = "1ºTrimestre"
        Me.colQuarter1Value.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colQuarter1Value.DisplayFormat.FormatString = "#,###;-#,###;0"
        Me.colQuarter1Value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuarter1Value.FieldName = "Quarter1Value"
        Me.colQuarter1Value.Name = "colQuarter1Value"
        Me.colQuarter1Value.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colQuarter1Value.Visible = True
        Me.colQuarter1Value.Width = 40
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colQuarter2Value
        '
        Me.colQuarter2Value.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuarter2Value.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colQuarter2Value.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuarter2Value.Caption = "2ºTrimestre"
        Me.colQuarter2Value.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colQuarter2Value.DisplayFormat.FormatString = "#,###;-#,###;0"
        Me.colQuarter2Value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuarter2Value.FieldName = "Quarter2Value"
        Me.colQuarter2Value.Name = "colQuarter2Value"
        Me.colQuarter2Value.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colQuarter2Value.Visible = True
        Me.colQuarter2Value.Width = 40
        '
        'colQuarter3Value
        '
        Me.colQuarter3Value.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuarter3Value.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colQuarter3Value.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuarter3Value.Caption = "3ºTrimestre"
        Me.colQuarter3Value.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colQuarter3Value.DisplayFormat.FormatString = "#,###;-#,###;0"
        Me.colQuarter3Value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuarter3Value.FieldName = "Quarter3Value"
        Me.colQuarter3Value.Name = "colQuarter3Value"
        Me.colQuarter3Value.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colQuarter3Value.Visible = True
        Me.colQuarter3Value.Width = 40
        '
        'colQuarter4Value
        '
        Me.colQuarter4Value.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuarter4Value.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colQuarter4Value.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuarter4Value.Caption = "4ºTrimestre"
        Me.colQuarter4Value.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colQuarter4Value.DisplayFormat.FormatString = "#,###;-#,###;0"
        Me.colQuarter4Value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuarter4Value.FieldName = "Quarter4Value"
        Me.colQuarter4Value.Name = "colQuarter4Value"
        Me.colQuarter4Value.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colQuarter4Value.Visible = True
        Me.colQuarter4Value.Width = 40
        '
        'colQuarterSum
        '
        Me.colQuarterSum.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuarterSum.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colQuarterSum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuarterSum.Caption = "Soma Trimestres"
        Me.colQuarterSum.DisplayFormat.FormatString = "#,###.00;-#,###.00;0"
        Me.colQuarterSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuarterSum.FieldName = "colQuarterSum"
        Me.colQuarterSum.Name = "colQuarterSum"
        Me.colQuarterSum.OptionsColumn.AllowEdit = False
        Me.colQuarterSum.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colQuarterSum.OptionsColumn.ReadOnly = True
        Me.colQuarterSum.UnboundExpression = "[Quarter1Value]+[Quarter2Value]+[Quarter3Value]+[Quarter4Value]"
        Me.colQuarterSum.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colQuarterSum.Visible = True
        Me.colQuarterSum.Width = 50
        '
        'colInHand
        '
        Me.colInHand.AppearanceHeader.Options.UseTextOptions = True
        Me.colInHand.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colInHand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInHand.Caption = "Inhand"
        Me.colInHand.DisplayFormat.FormatString = "#,###.00;-#,###.00;0"
        Me.colInHand.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colInHand.FieldName = "colInHand"
        Me.colInHand.Name = "colInHand"
        Me.colInHand.OptionsColumn.AllowEdit = False
        Me.colInHand.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colInHand.OptionsColumn.ReadOnly = True
        Me.colInHand.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colInHand.Visible = True
        Me.colInHand.Width = 50
        '
        'gridBand2
        '
        Me.gridBand2.Caption = "9L"
        Me.gridBand2.Columns.Add(Me.ColShipped)
        Me.gridBand2.Columns.Add(Me.DiffFQAnt)
        Me.gridBand2.Columns.Add(Me.DiffTarget)
        Me.gridBand2.Columns.Add(Me.Target9L)
        Me.gridBand2.Columns.Add(Me.colFQ1)
        Me.gridBand2.Columns.Add(Me.colFQ2)
        Me.gridBand2.Columns.Add(Me.colFQ3)
        Me.gridBand2.Columns.Add(Me.colFQ4)
        Me.gridBand2.Columns.Add(Me.colStatusMat)
        Me.gridBand2.Columns.Add(Me.colStatusPricing)
        Me.gridBand2.Columns.Add(Me.colAnualValue)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 1
        Me.gridBand2.Width = 460
        '
        'ColShipped
        '
        Me.ColShipped.AppearanceHeader.Options.UseTextOptions = True
        Me.ColShipped.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.ColShipped.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColShipped.Caption = "ShipHand"
        Me.ColShipped.DisplayFormat.FormatString = "#,###.00;-#,###.00;0"
        Me.ColShipped.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColShipped.FieldName = "ColShipped"
        Me.ColShipped.Name = "ColShipped"
        Me.ColShipped.OptionsColumn.AllowEdit = False
        Me.ColShipped.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.ColShipped.OptionsColumn.ReadOnly = True
        Me.ColShipped.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ColShipped", "{0:#,###.##}")})
        Me.ColShipped.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ColShipped.Visible = True
        Me.ColShipped.Width = 65
        '
        'DiffFQAnt
        '
        Me.DiffFQAnt.AppearanceHeader.Options.UseTextOptions = True
        Me.DiffFQAnt.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.DiffFQAnt.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.DiffFQAnt.Caption = "DiffFQAnt"
        Me.DiffFQAnt.DisplayFormat.FormatString = "#,###.00;-#,###.00;0"
        Me.DiffFQAnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DiffFQAnt.FieldName = "DiffFQAnt"
        Me.DiffFQAnt.Name = "DiffFQAnt"
        Me.DiffFQAnt.OptionsColumn.AllowEdit = False
        Me.DiffFQAnt.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.DiffFQAnt.OptionsColumn.ReadOnly = True
        Me.DiffFQAnt.UnboundExpression = "[AnualValue] - [Target]"
        Me.DiffFQAnt.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.DiffFQAnt.Visible = True
        Me.DiffFQAnt.Width = 65
        '
        'Target9L
        '
        Me.Target9L.AppearanceHeader.Options.UseTextOptions = True
        Me.Target9L.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.Target9L.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Target9L.Caption = "Target"
        Me.Target9L.DisplayFormat.FormatString = "#,###.00;-#,###.00;0"
        Me.Target9L.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Target9L.FieldName = "Target"
        Me.Target9L.Name = "Target9L"
        Me.Target9L.OptionsColumn.AllowEdit = False
        Me.Target9L.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Target9L.OptionsColumn.ReadOnly = True
        Me.Target9L.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Target", "{0:#,###.##}")})
        Me.Target9L.Visible = True
        Me.Target9L.Width = 65
        '
        'colFQ1
        '
        Me.colFQ1.AppearanceHeader.Options.UseTextOptions = True
        Me.colFQ1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colFQ1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFQ1.Caption = "FQ1"
        Me.colFQ1.DisplayFormat.FormatString = "#,###.00;-#,###.00;0"
        Me.colFQ1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFQ1.FieldName = "FQ1"
        Me.colFQ1.Name = "colFQ1"
        Me.colFQ1.OptionsColumn.AllowEdit = False
        Me.colFQ1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFQ1.OptionsColumn.ReadOnly = True
        Me.colFQ1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FQ1", "{0:#,###.##}")})
        Me.colFQ1.Visible = True
        Me.colFQ1.Width = 50
        '
        'colFQ2
        '
        Me.colFQ2.AppearanceHeader.Options.UseTextOptions = True
        Me.colFQ2.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colFQ2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFQ2.Caption = "FQ2"
        Me.colFQ2.DisplayFormat.FormatString = "#,###.00;-#,###.00;0"
        Me.colFQ2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFQ2.FieldName = "FQ2"
        Me.colFQ2.Name = "colFQ2"
        Me.colFQ2.OptionsColumn.AllowEdit = False
        Me.colFQ2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFQ2.OptionsColumn.ReadOnly = True
        Me.colFQ2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FQ2", "{0:#,###.##}")})
        Me.colFQ2.Visible = True
        Me.colFQ2.Width = 50
        '
        'colFQ3
        '
        Me.colFQ3.AppearanceHeader.Options.UseTextOptions = True
        Me.colFQ3.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colFQ3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFQ3.Caption = "FQ3"
        Me.colFQ3.DisplayFormat.FormatString = "#,###.00;-#,###.00;0"
        Me.colFQ3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFQ3.FieldName = "FQ3"
        Me.colFQ3.Name = "colFQ3"
        Me.colFQ3.OptionsColumn.AllowEdit = False
        Me.colFQ3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFQ3.OptionsColumn.ReadOnly = True
        Me.colFQ3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FQ3", "{0:#,###.##}")})
        Me.colFQ3.Visible = True
        Me.colFQ3.Width = 50
        '
        'colFQ4
        '
        Me.colFQ4.AppearanceHeader.Options.UseTextOptions = True
        Me.colFQ4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colFQ4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFQ4.Caption = "FQ4"
        Me.colFQ4.DisplayFormat.FormatString = "#,###.00;-#,###.00;0"
        Me.colFQ4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFQ4.FieldName = "FQ4"
        Me.colFQ4.Name = "colFQ4"
        Me.colFQ4.OptionsColumn.AllowEdit = False
        Me.colFQ4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFQ4.OptionsColumn.ReadOnly = True
        Me.colFQ4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FQ4", "{0:#,###.##}")})
        Me.colFQ4.Visible = True
        Me.colFQ4.Width = 50
        '
        'colAnualValue
        '
        Me.colAnualValue.AppearanceHeader.Options.UseTextOptions = True
        Me.colAnualValue.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colAnualValue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAnualValue.Caption = "AnualValue"
        Me.colAnualValue.DisplayFormat.FormatString = "#,###.00;-#,###.00;0"
        Me.colAnualValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAnualValue.FieldName = "AnualValue"
        Me.colAnualValue.Name = "colAnualValue"
        Me.colAnualValue.OptionsColumn.AllowEdit = False
        Me.colAnualValue.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colAnualValue.OptionsColumn.ReadOnly = True
        Me.colAnualValue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AnualValue", "{0:#,###.##}")})
        Me.colAnualValue.Width = 72
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MATNR", "MATNR", 58, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAKTX", "MAKTX", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("WGBEZ60", "WGBEZ60", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("VINTAGEYEAR", "VINTAGEYEAR", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.SapMateriaisBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "MAKTX"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "MATNR"
        '
        'RepositoryItemLookUpEdit7
        '
        Me.RepositoryItemLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit7.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MATNR", "MATNR", 58, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAKTX", "MAKTX", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("WGBEZ60", "WGBEZ60", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit7.DataSource = Me.SapMateriaisBindingSource
        Me.RepositoryItemLookUpEdit7.DisplayMember = "WGBEZ60"
        Me.RepositoryItemLookUpEdit7.Name = "RepositoryItemLookUpEdit7"
        Me.RepositoryItemLookUpEdit7.ValueMember = "MATNR"
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.DataSource = Me.SapMateriaisEmbalagemBindingSource
        Me.RepositoryItemLookUpEdit6.DisplayMember = "DESCR"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.ValueMember = "MATNR"
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.AutoSizeItems = True
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.iExit, Me.rgbiSkins, Me.iSave, Me.iCancel, Me.iExcel, Me.iClients, Me.iClientsMA, Me.iYear, Me.Iperiod, Me.ClearSelect, Me.BarEditItem1})
        Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.Margin = New System.Windows.Forms.Padding(0)
        Me.ribbonControl.MaxItemId = 76
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.homeRibbonPage})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.ribbonControl.ShowToolbarCustomizeItem = False
        Me.ribbonControl.Size = New System.Drawing.Size(951, 130)
        Me.ribbonControl.Toolbar.ShowCustomizeItem = False
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'iExit
        '
        Me.iExit.Caption = "Exit"
        Me.iExit.Description = "Closes this program after prompting you to save unsaved data."
        Me.iExit.Hint = "Closes this program after prompting you to save unsaved data"
        Me.iExit.Id = 20
        Me.iExit.ImageIndex = 6
        Me.iExit.LargeImageIndex = 6
        Me.iExit.Name = "iExit"
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "Skins"
        '
        '
        '
        Me.rgbiSkins.Gallery.AllowHoverImages = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rgbiSkins.Gallery.ColumnCount = 4
        Me.rgbiSkins.Gallery.FixedHoverImageSize = False
        Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
        Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        Me.rgbiSkins.Gallery.RowCount = 4
        Me.rgbiSkins.Id = 60
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'iSave
        '
        Me.iSave.Caption = "&Save"
        Me.iSave.Description = "Saves the active document."
        Me.iSave.Hint = "Saves the active document"
        Me.iSave.Id = 16
        Me.iSave.ImageIndex = 4
        Me.iSave.LargeImageIndex = 4
        Me.iSave.Name = "iSave"
        '
        'iCancel
        '
        Me.iCancel.Caption = "Cancelar Alterações"
        Me.iCancel.Id = 62
        Me.iCancel.ImageIndex = 15
        Me.iCancel.LargeImageIndex = 9
        Me.iCancel.Name = "iCancel"
        '
        'iExcel
        '
        Me.iExcel.Caption = "Export"
        Me.iExcel.Id = 66
        Me.iExcel.LargeImageIndex = 10
        Me.iExcel.Name = "iExcel"
        '
        'iClients
        '
        Me.iClients.Caption = "Stat Cust."
        Me.iClients.Edit = Me.RepositoryItemLookUpEdit3
        Me.iClients.EditWidth = 100
        Me.iClients.Id = 68
        Me.iClients.Name = "iClients"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        '
        'iClientsMA
        '
        Me.iClientsMA.Caption = "MA"
        Me.iClientsMA.Edit = Me.RepositoryItemLookUpEdit9
        Me.iClientsMA.EditWidth = 100
        Me.iClientsMA.Id = 69
        Me.iClientsMA.Name = "iClientsMA"
        '
        'RepositoryItemLookUpEdit9
        '
        Me.RepositoryItemLookUpEdit9.AutoHeight = False
        Me.RepositoryItemLookUpEdit9.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemLookUpEdit9.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit9.Name = "RepositoryItemLookUpEdit9"
        Me.RepositoryItemLookUpEdit9.NullText = ""
        '
        'iYear
        '
        Me.iYear.Caption = "Year"
        Me.iYear.Edit = Me.RepositoryItemComboBox1
        Me.iYear.Id = 71
        Me.iYear.Name = "iYear"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"2012", "2013", "2014", "2015", "2016", "2017"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Iperiod
        '
        Me.Iperiod.Caption = "Period"
        Me.Iperiod.Edit = Me.RepositoryItemComboBox2
        Me.Iperiod.Enabled = False
        Me.Iperiod.Id = 72
        Me.Iperiod.Name = "Iperiod"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'ClearSelect
        '
        Me.ClearSelect.Caption = "Clear MA."
        Me.ClearSelect.Id = 74
        Me.ClearSelect.ImageIndex = 6
        Me.ClearSelect.Name = "ClearSelect"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.AllowRightClickInMenu = False
        Me.BarEditItem1.Caption = "Calc. Sales/Target?"
        Me.BarEditItem1.CaptionAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.BarEditItem1.Edit = Me.RepositoryItemCheckEdit1
        Me.BarEditItem1.EditValue = True
        Me.BarEditItem1.Id = 75
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.RepositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueGrayed = False
        '
        'homeRibbonPage
        '
        Me.homeRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.fileRibbonPageGroup, Me.skinsRibbonPageGroup, Me.filterRibbonPageGroup, Me.exitRibbonPageGroup})
        Me.homeRibbonPage.Name = "homeRibbonPage"
        Me.homeRibbonPage.Text = "Home"
        '
        'fileRibbonPageGroup
        '
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iSave)
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iCancel)
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iExcel)
        Me.fileRibbonPageGroup.Name = "fileRibbonPageGroup"
        Me.fileRibbonPageGroup.Text = "File"
        '
        'skinsRibbonPageGroup
        '
        Me.skinsRibbonPageGroup.ItemLinks.Add(Me.rgbiSkins)
        Me.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup"
        Me.skinsRibbonPageGroup.ShowCaptionButton = False
        Me.skinsRibbonPageGroup.Text = "Skins"
        '
        'filterRibbonPageGroup
        '
        Me.filterRibbonPageGroup.ItemLinks.Add(Me.iYear)
        Me.filterRibbonPageGroup.ItemLinks.Add(Me.Iperiod)
        Me.filterRibbonPageGroup.ItemLinks.Add(Me.iClientsMA)
        Me.filterRibbonPageGroup.ItemLinks.Add(Me.iClients)
        Me.filterRibbonPageGroup.ItemLinks.Add(Me.ClearSelect)
        Me.filterRibbonPageGroup.ItemLinks.Add(Me.BarEditItem1)
        Me.filterRibbonPageGroup.Name = "filterRibbonPageGroup"
        Me.filterRibbonPageGroup.Text = "Filtros"
        '
        'exitRibbonPageGroup
        '
        Me.exitRibbonPageGroup.ItemLinks.Add(Me.iExit)
        Me.exitRibbonPageGroup.Name = "exitRibbonPageGroup"
        Me.exitRibbonPageGroup.Text = "Exit"
        '
        'FormEditForecastSTAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 774)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "FormEditForecastSTAT"
        Me.Ribbon = Me.ribbonControl
        Me.Text = "Forecasts Statistic"
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapForecastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapMateriaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapMateriaisEmbalagemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapClientsMDMMMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
    Friend WithEvents SapForecastBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SapClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SapMateriaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SapMateriaisEmbalagemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SapClientsMDMMMABindingSource As System.Windows.Forms.BindingSource
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colYear As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPeriod As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCompany As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEmbalagem As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescMaterial As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTPRE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCurrency As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuarter1Value As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colQuarter2Value As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuarter3Value As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuarter4Value As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuarterSum As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInHand As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColShipped As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DiffFQAnt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DiffTarget As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Target9L As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFQ1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFQ2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFQ3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFQ4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAnualValue As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents iSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents iCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents iExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents iClients As DevExpress.XtraBars.BarEditItem
    Friend WithEvents iClientsMA As DevExpress.XtraBars.BarEditItem
    Friend WithEvents iYear As DevExpress.XtraBars.BarEditItem
    Friend WithEvents Iperiod As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ClearSelect As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Private WithEvents homeRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents fileRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents skinsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents filterRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents exitRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colCodCliStat1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodCliStat As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodCliFact As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStatusMat As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStatusPricing As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand



End Class
