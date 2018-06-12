<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPivotComp
    'Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPivotComp))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.fieldShipped = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShippedVar = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldValueShipped = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShippedValueVar = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.SAPSalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommercialSystemDataSet2 = New CommercialSystem.CommercialSystemDataSet2()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStatsClient = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInvClient = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFinalClient = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFinalMarket = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCompany = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBIGTYPE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGRUPO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVINTAGEYESNO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBIGCAT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCATEGORIA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBigFamilies = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFAMILIA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVINTAGEYEAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPackage = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldImmaterial = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMaterialName = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMaterialNumber = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOrderDocument = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBillingDocument = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBOM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFinalClientNum = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStatsClientNum = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStatsMarket = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInvClientNum = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBIGCOMPANIES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInvMarket = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTrademark = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldValueShipHand = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInHandUnit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShippedUnit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShipHandUnit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPriceList = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSalesOrganization = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDivision = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInHand = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldValueInHand = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPricePer9L = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShipHand = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldForeca = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTargetValue = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldForecm = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldForecaValue = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldForecurrent = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPerTarget = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPerTargetInHand = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPerForecast = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCurrency = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRANGE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMarketClass = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPPMD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPOFINCLI = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPOINVCLI = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTARGETEDFAMILY = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRegion = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.filenamexml = New System.Windows.Forms.OpenFileDialog()
        Me.savefilexml = New System.Windows.Forms.SaveFileDialog()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageFiltersApplied = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageLayout = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageTools = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageTopValues = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Top5 = New DevExpress.XtraBars.BarCheckItem()
        Me.Top10 = New DevExpress.XtraBars.BarCheckItem()
        Me.NOTOP = New DevExpress.XtraBars.BarCheckItem()
        Me.RibbonPageOptions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BtConditionalFormat = New DevExpress.XtraBars.BarButtonItem()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.RibbonPageLayoutapplied = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RibbonPageBack = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinsGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.SapSalesTableAdapter1 = New CommercialSystem.CommercialSystemDataSet2TableAdapters.SapSalesTableAdapter()
        Me.SapSalesAmostrasTableAdapter = New CommercialSystem.CommercialSystemDataSet2TableAdapters.SapSalesAmostrasTableAdapter()
        Me.SapSalesCompostosTableAdapter1 = New CommercialSystem.CommercialSystemDataSet2TableAdapters.SapSalesCompostosTableAdapter()
        Me.fieldVINTAGEYESNO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.SapSalesOldReservesTableAdapter1 = New CommercialSystem.CommercialSystemDataSet2TableAdapters.SapSalesOldReservesTableAdapter()
        Me.SapSalesGermanWarehouseTableAdapter1 = New CommercialSystem.CommercialSystemDataSet2TableAdapters.SapSalesGermanWarehouseTableAdapter()
        CType(Me.SAPSalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialSystemDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fieldShipped
        '
        Me.fieldShipped.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldShipped.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldShipped.AreaIndex = 0
        Me.fieldShipped.Caption = "Shipped 9L"
        Me.fieldShipped.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldShipped.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldShipped.FieldName = "Shipped"
        Me.fieldShipped.Name = "fieldShipped"
        '
        'fieldShippedVar
        '
        Me.fieldShippedVar.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldShippedVar.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldShippedVar.AreaIndex = 3
        Me.fieldShippedVar.Caption = "Ship9LVar%"
        Me.fieldShippedVar.FieldName = "Shipped"
        Me.fieldShippedVar.Name = "fieldShippedVar"
        Me.fieldShippedVar.Options.HideEmptyVariationItems = True
        Me.fieldShippedVar.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentVariation
        '
        'fieldValueShipped
        '
        Me.fieldValueShipped.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldValueShipped.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldValueShipped.AreaIndex = 1
        Me.fieldValueShipped.Caption = "Shipped €"
        Me.fieldValueShipped.CellFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldValueShipped.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldValueShipped.EmptyCellText = "-"
        Me.fieldValueShipped.EmptyValueText = "-"
        Me.fieldValueShipped.FieldName = "ValueShipped"
        Me.fieldValueShipped.Name = "fieldValueShipped"
        '
        'fieldShippedValueVar
        '
        Me.fieldShippedValueVar.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldShippedValueVar.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldShippedValueVar.AreaIndex = 4
        Me.fieldShippedValueVar.Caption = "Ship€Var%"
        Me.fieldShippedValueVar.FieldName = "ValueShipped"
        Me.fieldShippedValueVar.Name = "fieldShippedValueVar"
        Me.fieldShippedValueVar.Options.HideEmptyVariationItems = True
        Me.fieldShippedValueVar.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentVariation
        '
        'SAPSalesBindingSource
        '
        Me.SAPSalesBindingSource.DataMember = "SapSales"
        Me.SAPSalesBindingSource.DataSource = Me.CommercialSystemDataSet2
        '
        'CommercialSystemDataSet2
        '
        Me.CommercialSystemDataSet2.DataSetName = "CommercialSystemDataSet2"
        Me.CommercialSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.LookAndFeel.SkinName = "Lilian"
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.PivotGridControl1
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 30, 50)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.ActiveFilterString = ""
        Me.PivotGridControl1.DataSource = Me.SAPSalesBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldYear, Me.fieldDate1, Me.fieldDate, Me.fieldMD, Me.fieldMM, Me.fieldMA, Me.fieldStatsClient, Me.fieldInvClient, Me.fieldFinalClient, Me.fieldFinalMarket, Me.fieldCompany, Me.fieldBIGTYPE, Me.fieldTIPO, Me.fieldGRUPO, Me.fieldVINTAGEYESNO1, Me.fieldBIGCAT, Me.fieldCATEGORIA, Me.fieldBigFamilies, Me.fieldFAMILIA, Me.fieldVINTAGEYEAR, Me.fieldPackage, Me.fieldImmaterial, Me.fieldMaterialName, Me.fieldMaterialNumber, Me.fieldOrderDocument, Me.fieldBillingDocument, Me.fieldBOM, Me.fieldFinalClientNum, Me.fieldStatsClientNum, Me.fieldStatsMarket, Me.fieldInvClientNum, Me.fieldBIGCOMPANIES, Me.fieldInvMarket, Me.fieldTrademark, Me.fieldShipped, Me.fieldValueShipped, Me.fieldValueShipHand, Me.fieldShippedVar, Me.fieldShippedValueVar, Me.fieldInHandUnit, Me.fieldShippedUnit, Me.fieldShipHandUnit, Me.fieldPriceList, Me.fieldSalesOrganization, Me.fieldDivision, Me.fieldInHand, Me.fieldValueInHand, Me.fieldPricePer9L, Me.fieldShipHand, Me.fieldForeca, Me.fieldTargetValue, Me.fieldForecm, Me.fieldForecaValue, Me.fieldForecurrent, Me.fieldPerTarget, Me.fieldPerTargetInHand, Me.fieldPerForecast, Me.fieldCurrency, Me.fieldRANGE, Me.fieldMarketClass, Me.fieldPPMD, Me.fieldPOFINCLI, Me.fieldPOINVCLI, Me.fieldTARGETEDFAMILY, Me.fieldRegion})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 130)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsBehavior.ApplyBestFitOnFieldDragging = True
        Me.PivotGridControl1.OptionsBehavior.BestFitMode = DevExpress.XtraPivotGrid.PivotGridBestFitMode.Cell
        Me.PivotGridControl1.OptionsCustomization.AllowEdit = False
        Me.PivotGridControl1.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Always
        Me.PivotGridControl1.OptionsData.AutoExpandGroups = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsData.DataFieldUnboundExpressionMode = DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues
        Me.PivotGridControl1.OptionsFilterPopup.FieldFilterPopupMode = DevExpress.XtraPivotGrid.FieldFilterPopupMode.Excel
        Me.PivotGridControl1.OptionsFilterPopup.ShowOnlyAvailableItems = True
        Me.PivotGridControl1.OptionsFilterPopup.ToolbarButtons = CType((DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.ShowOnlyAvailableItems Or DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.InvertFilter), DevExpress.XtraPivotGrid.FilterPopupToolbarButtons)
        Me.PivotGridControl1.OptionsLayout.StoreDataSettings = False
        Me.PivotGridControl1.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PivotGridControl1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintHeadersOnEveryPage = True
        Me.PivotGridControl1.OptionsPrint.PrintUnusedFilterFields = False
        Me.PivotGridControl1.OptionsPrint.UsePrintAppearance = True
        Me.PivotGridControl1.OptionsSelection.EnableAppearanceFocusedCell = True
        Me.PivotGridControl1.OptionsView.ShowColumnGrandTotals = False
        Me.PivotGridControl1.OptionsView.ShowGrandTotalsForSingleValues = True
        Me.PivotGridControl1.Size = New System.Drawing.Size(870, 434)
        Me.PivotGridControl1.TabIndex = 2
        '
        'fieldYear
        '
        Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldYear.AreaIndex = 0
        Me.fieldYear.Caption = "Year"
        Me.fieldYear.FieldName = "Year"
        Me.fieldYear.Name = "fieldYear"
        Me.fieldYear.Width = 66
        '
        'fieldDate1
        '
        Me.fieldDate1.AreaIndex = 0
        Me.fieldDate1.Caption = "Month"
        Me.fieldDate1.FieldName = "Date"
        Me.fieldDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
        Me.fieldDate1.Name = "fieldDate1"
        Me.fieldDate1.UnboundFieldName = "fieldDate1"
        '
        'fieldDate
        '
        Me.fieldDate.AreaIndex = 1
        Me.fieldDate.CellFormat.FormatString = "d"
        Me.fieldDate.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldDate.FieldName = "Date"
        Me.fieldDate.Name = "fieldDate"
        Me.fieldDate.ValueFormat.FormatString = "d"
        Me.fieldDate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'fieldMD
        '
        Me.fieldMD.AreaIndex = 2
        Me.fieldMD.Caption = "MD"
        Me.fieldMD.FieldName = "MD"
        Me.fieldMD.Name = "fieldMD"
        '
        'fieldMM
        '
        Me.fieldMM.AreaIndex = 3
        Me.fieldMM.Caption = "MM"
        Me.fieldMM.FieldName = "MM"
        Me.fieldMM.Name = "fieldMM"
        '
        'fieldMA
        '
        Me.fieldMA.AreaIndex = 4
        Me.fieldMA.Caption = "MA"
        Me.fieldMA.FieldName = "MA"
        Me.fieldMA.Name = "fieldMA"
        '
        'fieldStatsClient
        '
        Me.fieldStatsClient.AreaIndex = 5
        Me.fieldStatsClient.Caption = "Stats Customer"
        Me.fieldStatsClient.FieldName = "StatsClient"
        Me.fieldStatsClient.Name = "fieldStatsClient"
        '
        'fieldInvClient
        '
        Me.fieldInvClient.AreaIndex = 6
        Me.fieldInvClient.Caption = "Inv Customer"
        Me.fieldInvClient.FieldName = "InvClient"
        Me.fieldInvClient.Name = "fieldInvClient"
        '
        'fieldFinalClient
        '
        Me.fieldFinalClient.AreaIndex = 7
        Me.fieldFinalClient.Caption = "Final Customer"
        Me.fieldFinalClient.FieldName = "FinalClient"
        Me.fieldFinalClient.Name = "fieldFinalClient"
        '
        'fieldFinalMarket
        '
        Me.fieldFinalMarket.AreaIndex = 8
        Me.fieldFinalMarket.Caption = "Final Market"
        Me.fieldFinalMarket.FieldName = "FinalMarket"
        Me.fieldFinalMarket.MinWidth = 100
        Me.fieldFinalMarket.Name = "fieldFinalMarket"
        '
        'fieldCompany
        '
        Me.fieldCompany.AreaIndex = 9
        Me.fieldCompany.Caption = "Brand"
        Me.fieldCompany.FieldName = "Company"
        Me.fieldCompany.MinWidth = 90
        Me.fieldCompany.Name = "fieldCompany"
        Me.fieldCompany.Width = 90
        '
        'fieldBIGTYPE
        '
        Me.fieldBIGTYPE.AreaIndex = 10
        Me.fieldBIGTYPE.Caption = "Big Type"
        Me.fieldBIGTYPE.FieldName = "BIGTYPE"
        Me.fieldBIGTYPE.Name = "fieldBIGTYPE"
        Me.fieldBIGTYPE.UnboundFieldName = "fieldPortConsumoBrandy"
        Me.fieldBIGTYPE.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'fieldTIPO
        '
        Me.fieldTIPO.AreaIndex = 11
        Me.fieldTIPO.Caption = "Type"
        Me.fieldTIPO.FieldName = "TIPO"
        Me.fieldTIPO.Name = "fieldTIPO"
        '
        'fieldGRUPO
        '
        Me.fieldGRUPO.AreaIndex = 12
        Me.fieldGRUPO.Caption = "Group"
        Me.fieldGRUPO.FieldName = "GRUPO"
        Me.fieldGRUPO.Name = "fieldGRUPO"
        '
        'fieldVINTAGEYESNO1
        '
        Me.fieldVINTAGEYESNO1.AreaIndex = 13
        Me.fieldVINTAGEYESNO1.Caption = "Wood/Bottle Matured"
        Me.fieldVINTAGEYESNO1.FieldName = "VINTAGEYESNO"
        Me.fieldVINTAGEYESNO1.Name = "fieldVINTAGEYESNO1"
        '
        'fieldBIGCAT
        '
        Me.fieldBIGCAT.AreaIndex = 14
        Me.fieldBIGCAT.Caption = "Big Categories"
        Me.fieldBIGCAT.FieldName = "BIGCAT"
        Me.fieldBIGCAT.Name = "fieldBIGCAT"
        '
        'fieldCATEGORIA
        '
        Me.fieldCATEGORIA.AreaIndex = 15
        Me.fieldCATEGORIA.Caption = "Category"
        Me.fieldCATEGORIA.FieldName = "CATEGORIA"
        Me.fieldCATEGORIA.Name = "fieldCATEGORIA"
        '
        'fieldBigFamilies
        '
        Me.fieldBigFamilies.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldBigFamilies.AreaIndex = 16
        Me.fieldBigFamilies.Caption = "Big Families"
        Me.fieldBigFamilies.FieldName = "BIGFAMILIES"
        Me.fieldBigFamilies.Name = "fieldBigFamilies"
        Me.fieldBigFamilies.UnboundFieldName = "fieldBigFamilies"
        '
        'fieldFAMILIA
        '
        Me.fieldFAMILIA.AreaIndex = 17
        Me.fieldFAMILIA.Caption = "Family"
        Me.fieldFAMILIA.FieldName = "FAMILIA"
        Me.fieldFAMILIA.Name = "fieldFAMILIA"
        '
        'fieldVINTAGEYEAR
        '
        Me.fieldVINTAGEYEAR.AreaIndex = 18
        Me.fieldVINTAGEYEAR.Caption = "Vintage Year"
        Me.fieldVINTAGEYEAR.FieldName = "VINTAGEYEAR"
        Me.fieldVINTAGEYEAR.MinWidth = 75
        Me.fieldVINTAGEYEAR.Name = "fieldVINTAGEYEAR"
        Me.fieldVINTAGEYEAR.Width = 75
        '
        'fieldPackage
        '
        Me.fieldPackage.AreaIndex = 19
        Me.fieldPackage.FieldName = "Package"
        Me.fieldPackage.Name = "fieldPackage"
        '
        'fieldImmaterial
        '
        Me.fieldImmaterial.AreaIndex = 20
        Me.fieldImmaterial.Caption = "ZIMA"
        Me.fieldImmaterial.FieldName = "Immaterial"
        Me.fieldImmaterial.Name = "fieldImmaterial"
        '
        'fieldMaterialName
        '
        Me.fieldMaterialName.AreaIndex = 21
        Me.fieldMaterialName.Caption = "Material Name"
        Me.fieldMaterialName.FieldName = "Material Name"
        Me.fieldMaterialName.Name = "fieldMaterialName"
        '
        'fieldMaterialNumber
        '
        Me.fieldMaterialNumber.AreaIndex = 22
        Me.fieldMaterialNumber.Caption = "Material Number"
        Me.fieldMaterialNumber.FieldName = "Material Number"
        Me.fieldMaterialNumber.Name = "fieldMaterialNumber"
        '
        'fieldOrderDocument
        '
        Me.fieldOrderDocument.AreaIndex = 23
        Me.fieldOrderDocument.Caption = "Order Document"
        Me.fieldOrderDocument.FieldName = "Order Document"
        Me.fieldOrderDocument.Name = "fieldOrderDocument"
        '
        'fieldBillingDocument
        '
        Me.fieldBillingDocument.AreaIndex = 24
        Me.fieldBillingDocument.Caption = "Billing Document"
        Me.fieldBillingDocument.FieldName = "Billing Document"
        Me.fieldBillingDocument.Name = "fieldBillingDocument"
        '
        'fieldBOM
        '
        Me.fieldBOM.AreaIndex = 25
        Me.fieldBOM.Caption = "Bill of Material"
        Me.fieldBOM.FieldName = "BOM"
        Me.fieldBOM.Name = "fieldBOM"
        '
        'fieldFinalClientNum
        '
        Me.fieldFinalClientNum.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldFinalClientNum.AreaIndex = 1
        Me.fieldFinalClientNum.Caption = "F. Cust. Num"
        Me.fieldFinalClientNum.FieldName = "FinalClientNum"
        Me.fieldFinalClientNum.Name = "fieldFinalClientNum"
        Me.fieldFinalClientNum.Visible = False
        '
        'fieldStatsClientNum
        '
        Me.fieldStatsClientNum.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldStatsClientNum.AreaIndex = 1
        Me.fieldStatsClientNum.Caption = "Stat. Cust. Num"
        Me.fieldStatsClientNum.FieldName = "StatsClientNum"
        Me.fieldStatsClientNum.Name = "fieldStatsClientNum"
        Me.fieldStatsClientNum.Visible = False
        '
        'fieldStatsMarket
        '
        Me.fieldStatsMarket.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldStatsMarket.AreaIndex = 0
        Me.fieldStatsMarket.Caption = "Stat. Market"
        Me.fieldStatsMarket.FieldName = "StatsMarket"
        Me.fieldStatsMarket.MinWidth = 100
        Me.fieldStatsMarket.Name = "fieldStatsMarket"
        '
        'fieldInvClientNum
        '
        Me.fieldInvClientNum.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldInvClientNum.AreaIndex = 1
        Me.fieldInvClientNum.Caption = "Inv Customer Num"
        Me.fieldInvClientNum.FieldName = "InvClientNum"
        Me.fieldInvClientNum.Name = "fieldInvClientNum"
        Me.fieldInvClientNum.Visible = False
        '
        'fieldBIGCOMPANIES
        '
        Me.fieldBIGCOMPANIES.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldBIGCOMPANIES.AreaIndex = 1
        Me.fieldBIGCOMPANIES.DisplayFolder = "Big Brand"
        Me.fieldBIGCOMPANIES.FieldName = "BIGCOMPANIES"
        Me.fieldBIGCOMPANIES.Name = "fieldBIGCOMPANIES"
        Me.fieldBIGCOMPANIES.Visible = False
        '
        'fieldInvMarket
        '
        Me.fieldInvMarket.AreaIndex = 24
        Me.fieldInvMarket.Caption = "Inv. Market"
        Me.fieldInvMarket.FieldName = "InvMarket"
        Me.fieldInvMarket.MinWidth = 100
        Me.fieldInvMarket.Name = "fieldInvMarket"
        Me.fieldInvMarket.Visible = False
        '
        'fieldTrademark
        '
        Me.fieldTrademark.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldTrademark.AreaIndex = 1
        Me.fieldTrademark.Caption = "Trademark"
        Me.fieldTrademark.FieldName = "Trademark"
        Me.fieldTrademark.MinWidth = 90
        Me.fieldTrademark.Name = "fieldTrademark"
        Me.fieldTrademark.Width = 90
        '
        'fieldValueShipHand
        '
        Me.fieldValueShipHand.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldValueShipHand.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldValueShipHand.Caption = "ShipHand €"
        Me.fieldValueShipHand.CellFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldValueShipHand.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldValueShipHand.EmptyCellText = "-"
        Me.fieldValueShipHand.EmptyValueText = "-"
        Me.fieldValueShipHand.FieldName = "ValueShipHand"
        Me.fieldValueShipHand.Name = "fieldValueShipHand"
        Me.fieldValueShipHand.Visible = False
        '
        'fieldInHandUnit
        '
        Me.fieldInHandUnit.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldInHandUnit.AreaIndex = 17
        Me.fieldInHandUnit.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldInHandUnit.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldInHandUnit.FieldName = "InHandUnit"
        Me.fieldInHandUnit.Name = "fieldInHandUnit"
        Me.fieldInHandUnit.Visible = False
        '
        'fieldShippedUnit
        '
        Me.fieldShippedUnit.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldShippedUnit.AreaIndex = 17
        Me.fieldShippedUnit.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldShippedUnit.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldShippedUnit.FieldName = "ShippedUnit"
        Me.fieldShippedUnit.Name = "fieldShippedUnit"
        Me.fieldShippedUnit.Visible = False
        '
        'fieldShipHandUnit
        '
        Me.fieldShipHandUnit.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldShipHandUnit.AreaIndex = 16
        Me.fieldShipHandUnit.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldShipHandUnit.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldShipHandUnit.FieldName = "ShipHandUnit"
        Me.fieldShipHandUnit.Name = "fieldShipHandUnit"
        Me.fieldShipHandUnit.Visible = False
        '
        'fieldPriceList
        '
        Me.fieldPriceList.AreaIndex = 18
        Me.fieldPriceList.Caption = "Price List"
        Me.fieldPriceList.FieldName = "Price List"
        Me.fieldPriceList.Name = "fieldPriceList"
        Me.fieldPriceList.Visible = False
        '
        'fieldSalesOrganization
        '
        Me.fieldSalesOrganization.AreaIndex = 4
        Me.fieldSalesOrganization.Caption = "Sales Organization"
        Me.fieldSalesOrganization.FieldName = "Sales Organization"
        Me.fieldSalesOrganization.Name = "fieldSalesOrganization"
        Me.fieldSalesOrganization.Visible = False
        '
        'fieldDivision
        '
        Me.fieldDivision.AreaIndex = 4
        Me.fieldDivision.Caption = "Final CustDistChannel"
        Me.fieldDivision.FieldName = "Division"
        Me.fieldDivision.Name = "fieldDivision"
        Me.fieldDivision.Visible = False
        '
        'fieldInHand
        '
        Me.fieldInHand.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldInHand.AreaIndex = 21
        Me.fieldInHand.Caption = "In Hand 9L"
        Me.fieldInHand.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldInHand.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldInHand.FieldName = "InHand"
        Me.fieldInHand.Name = "fieldInHand"
        Me.fieldInHand.Visible = False
        '
        'fieldValueInHand
        '
        Me.fieldValueInHand.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldValueInHand.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldValueInHand.Caption = "In Hand €"
        Me.fieldValueInHand.CellFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldValueInHand.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldValueInHand.FieldName = "ValueInHand"
        Me.fieldValueInHand.Name = "fieldValueInHand"
        Me.fieldValueInHand.Visible = False
        '
        'fieldPricePer9L
        '
        Me.fieldPricePer9L.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldPricePer9L.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPricePer9L.AreaIndex = 2
        Me.fieldPricePer9L.Caption = "Av. Price 9L"
        Me.fieldPricePer9L.CellFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldPricePer9L.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPricePer9L.EmptyCellText = "-"
        Me.fieldPricePer9L.EmptyValueText = "-"
        Me.fieldPricePer9L.Name = "fieldPricePer9L"
        Me.fieldPricePer9L.UnboundExpression = "Iif([fieldShipped] = 0,0  ,[fieldValueShipped] / [fieldShipped] )"
        Me.fieldPricePer9L.UnboundFieldName = "PricePer9L"
        Me.fieldPricePer9L.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'fieldShipHand
        '
        Me.fieldShipHand.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldShipHand.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldShipHand.Caption = "ShipHand 9L"
        Me.fieldShipHand.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldShipHand.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldShipHand.FieldName = "ShipHand"
        Me.fieldShipHand.MinWidth = 100
        Me.fieldShipHand.Name = "fieldShipHand"
        Me.fieldShipHand.Options.ShowValues = False
        Me.fieldShipHand.Visible = False
        '
        'fieldForeca
        '
        Me.fieldForeca.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldForeca.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldForeca.AreaIndex = 5
        Me.fieldForeca.Caption = "Target 9L"
        Me.fieldForeca.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldForeca.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldForeca.EmptyCellText = "-"
        Me.fieldForeca.EmptyValueText = "-"
        Me.fieldForeca.FieldName = "Foreca"
        Me.fieldForeca.Name = "fieldForeca"
        Me.fieldForeca.Visible = False
        '
        'fieldTargetValue
        '
        Me.fieldTargetValue.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldTargetValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTargetValue.AreaIndex = 6
        Me.fieldTargetValue.Caption = "Target Value"
        Me.fieldTargetValue.CellFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldTargetValue.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTargetValue.FieldName = "TargetValue"
        Me.fieldTargetValue.Name = "fieldTargetValue"
        Me.fieldTargetValue.Visible = False
        '
        'fieldForecm
        '
        Me.fieldForecm.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldForecm.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldForecm.AreaIndex = 5
        Me.fieldForecm.Caption = "Forecast 9L"
        Me.fieldForecm.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldForecm.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldForecm.EmptyCellText = "-"
        Me.fieldForecm.EmptyValueText = "-"
        Me.fieldForecm.FieldName = "Forecm"
        Me.fieldForecm.Name = "fieldForecm"
        '
        'fieldForecaValue
        '
        Me.fieldForecaValue.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldForecaValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldForecaValue.Caption = "Forecast €"
        Me.fieldForecaValue.CellFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldForecaValue.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldForecaValue.FieldName = "ForecaValue"
        Me.fieldForecaValue.Name = "fieldForecaValue"
        Me.fieldForecaValue.Visible = False
        '
        'fieldForecurrent
        '
        Me.fieldForecurrent.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldForecurrent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldForecurrent.AreaIndex = 6
        Me.fieldForecurrent.Caption = "Current Forecast 9L"
        Me.fieldForecurrent.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldForecurrent.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldForecurrent.FieldName = "Forecurrent"
        Me.fieldForecurrent.Name = "fieldForecurrent"
        Me.fieldForecurrent.Visible = False
        '
        'fieldPerTarget
        '
        Me.fieldPerTarget.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldPerTarget.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPerTarget.AreaIndex = 6
        Me.fieldPerTarget.Caption = "% Target"
        Me.fieldPerTarget.CellFormat.FormatString = "P"
        Me.fieldPerTarget.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPerTarget.MinWidth = 60
        Me.fieldPerTarget.Name = "fieldPerTarget"
        Me.fieldPerTarget.UnboundExpression = "iif ([fieldForeca] = 0, 0 ,   [fieldShipped] / [fieldForeca])"
        Me.fieldPerTarget.UnboundFieldName = "fieldPerTarget"
        Me.fieldPerTarget.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.fieldPerTarget.Visible = False
        Me.fieldPerTarget.Width = 60
        '
        'fieldPerTargetInHand
        '
        Me.fieldPerTargetInHand.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldPerTargetInHand.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPerTargetInHand.AreaIndex = 6
        Me.fieldPerTargetInHand.Caption = "% Target inc InHand"
        Me.fieldPerTargetInHand.CellFormat.FormatString = "P"
        Me.fieldPerTargetInHand.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPerTargetInHand.MinWidth = 60
        Me.fieldPerTargetInHand.Name = "fieldPerTargetInHand"
        Me.fieldPerTargetInHand.UnboundExpression = "iif ([fieldForeca] = 0, 0 ,  ( [fieldShipped]+ [fieldInHand] ) / [fieldForeca])"
        Me.fieldPerTargetInHand.UnboundFieldName = "fieldPerTargetInHand"
        Me.fieldPerTargetInHand.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.fieldPerTargetInHand.Visible = False
        Me.fieldPerTargetInHand.Width = 60
        '
        'fieldPerForecast
        '
        Me.fieldPerForecast.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldPerForecast.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPerForecast.AreaIndex = 8
        Me.fieldPerForecast.Caption = "% Forecast"
        Me.fieldPerForecast.CellFormat.FormatString = "P"
        Me.fieldPerForecast.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPerForecast.MinWidth = 60
        Me.fieldPerForecast.Name = "fieldPerForecast"
        Me.fieldPerForecast.UnboundExpression = "iif ([fieldForecm] = 0, 0 ,  [fieldShipped] / [fieldForecm])"
        Me.fieldPerForecast.UnboundFieldName = "fieldPerForecast"
        Me.fieldPerForecast.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.fieldPerForecast.Visible = False
        Me.fieldPerForecast.Width = 60
        '
        'fieldCurrency
        '
        Me.fieldCurrency.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldCurrency.AreaIndex = 1
        Me.fieldCurrency.Caption = "Inv. Currency"
        Me.fieldCurrency.FieldName = "Currency"
        Me.fieldCurrency.Name = "fieldCurrency"
        Me.fieldCurrency.Visible = False
        '
        'fieldRANGE
        '
        Me.fieldRANGE.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldRANGE.AreaIndex = 1
        Me.fieldRANGE.Caption = "Stock"
        Me.fieldRANGE.FieldName = "RANGE"
        Me.fieldRANGE.Name = "fieldRANGE"
        Me.fieldRANGE.Visible = False
        '
        'fieldMarketClass
        '
        Me.fieldMarketClass.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldMarketClass.Caption = "Market Classification"
        Me.fieldMarketClass.FieldName = "MarketClass"
        Me.fieldMarketClass.Name = "fieldMarketClass"
        Me.fieldMarketClass.Visible = False
        '
        'fieldPPMD
        '
        Me.fieldPPMD.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldPPMD.Caption = "PPMDD"
        Me.fieldPPMD.FieldName = "PPMD"
        Me.fieldPPMD.Name = "fieldPPMD"
        Me.fieldPPMD.Visible = False
        '
        'fieldPOFINCLI
        '
        Me.fieldPOFINCLI.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldPOFINCLI.Caption = "PO Final Customer"
        Me.fieldPOFINCLI.FieldName = "PO_FINCLI"
        Me.fieldPOFINCLI.Name = "fieldPOFINCLI"
        Me.fieldPOFINCLI.Visible = False
        '
        'fieldPOINVCLI
        '
        Me.fieldPOINVCLI.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldPOINVCLI.Caption = "PO Inv Customer"
        Me.fieldPOINVCLI.FieldName = "PO_INVCLI"
        Me.fieldPOINVCLI.Name = "fieldPOINVCLI"
        Me.fieldPOINVCLI.Visible = False
        '
        'fieldTARGETEDFAMILY
        '
        Me.fieldTARGETEDFAMILY.AreaIndex = 26
        Me.fieldTARGETEDFAMILY.Caption = "Targeted Family"
        Me.fieldTARGETEDFAMILY.FieldName = "TARGETEDFAMILY"
        Me.fieldTARGETEDFAMILY.Name = "fieldTARGETEDFAMILY"
        '
        'fieldRegion
        '
        Me.fieldRegion.AreaIndex = 27
        Me.fieldRegion.FieldName = "Region"
        Me.fieldRegion.Name = "fieldRegion"
        '
        'filenamexml
        '
        Me.filenamexml.Filter = "Layout files|Sales*.xml"
        Me.filenamexml.InitialDirectory = "c:\CommercialSystem\dados"
        Me.filenamexml.RestoreDirectory = True
        '
        'savefilexml
        '
        Me.savefilexml.DefaultExt = "*.xml"
        Me.savefilexml.Filter = "Layout files|Sales*.xml"
        Me.savefilexml.InitialDirectory = "c:\CommercialSystem\dados"
        Me.savefilexml.RestoreDirectory = True
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageFiltersApplied, Me.RibbonPageLayout, Me.RibbonPageTools, Me.RibbonPageTopValues, Me.RibbonPageOptions, Me.RibbonPageLayoutapplied, Me.RibbonPageBack})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Menu"
        '
        'RibbonPageFiltersApplied
        '
        Me.RibbonPageFiltersApplied.AllowMinimize = False
        Me.RibbonPageFiltersApplied.Name = "RibbonPageFiltersApplied"
        Me.RibbonPageFiltersApplied.ShowCaptionButton = False
        Me.RibbonPageFiltersApplied.Text = "Filters applied"
        '
        'RibbonPageLayout
        '
        Me.RibbonPageLayout.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageLayout.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageLayout.Name = "RibbonPageLayout"
        Me.RibbonPageLayout.ShowCaptionButton = False
        Me.RibbonPageLayout.Text = "Layout"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Save Layout"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ImageOptions.LargeImageIndex = 2
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Restore Layout"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ImageOptions.LargeImageIndex = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        ToolTipItem1.Text = "teste"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.BarButtonItem2.SuperTip = SuperToolTip1
        '
        'RibbonPageTools
        '
        Me.RibbonPageTools.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageTools.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageTools.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageTools.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageTools.ItemLinks.Add(Me.BarButtonPrintPreview)
        Me.RibbonPageTools.Name = "RibbonPageTools"
        Me.RibbonPageTools.ShowCaptionButton = False
        Me.RibbonPageTools.Text = "Tools"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Add/Remove Columns"
        Me.BarButtonItem8.Id = 39
        Me.BarButtonItem8.ImageOptions.LargeImageIndex = 7
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Export to Pdf"
        Me.BarButtonItem7.Id = 38
        Me.BarButtonItem7.ImageOptions.LargeImageIndex = 6
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Export to Excel"
        Me.BarButtonItem6.Id = 37
        Me.BarButtonItem6.ImageOptions.LargeImageIndex = 5
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Print"
        Me.BarButtonItem3.Id = 35
        Me.BarButtonItem3.ImageOptions.LargeImageIndex = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonPrintPreview
        '
        Me.BarButtonPrintPreview.Caption = "Print Preview"
        Me.BarButtonPrintPreview.Id = 36
        Me.BarButtonPrintPreview.ImageOptions.LargeImageIndex = 4
        Me.BarButtonPrintPreview.Name = "BarButtonPrintPreview"
        '
        'RibbonPageTopValues
        '
        Me.RibbonPageTopValues.ItemLinks.Add(Me.Top5)
        Me.RibbonPageTopValues.ItemLinks.Add(Me.Top10)
        Me.RibbonPageTopValues.ItemLinks.Add(Me.NOTOP)
        Me.RibbonPageTopValues.Name = "RibbonPageTopValues"
        Me.RibbonPageTopValues.ShowCaptionButton = False
        Me.RibbonPageTopValues.Text = "Top Values"
        '
        'Top5
        '
        Me.Top5.Caption = "TOP 5"
        Me.Top5.GroupIndex = 1
        Me.Top5.Id = 46
        Me.Top5.Name = "Top5"
        '
        'Top10
        '
        Me.Top10.Caption = "TOP 10"
        Me.Top10.GroupIndex = 1
        Me.Top10.Id = 48
        Me.Top10.Name = "Top10"
        '
        'NOTOP
        '
        Me.NOTOP.BindableChecked = True
        Me.NOTOP.Caption = "NO TOP"
        Me.NOTOP.Checked = True
        Me.NOTOP.GroupIndex = 1
        Me.NOTOP.Id = 50
        Me.NOTOP.Name = "NOTOP"
        '
        'RibbonPageOptions
        '
        Me.RibbonPageOptions.AllowMinimize = False
        Me.RibbonPageOptions.ItemLinks.Add(Me.BtConditionalFormat)
        Me.RibbonPageOptions.ItemLinks.Add(Me.BarCheckItem1)
        Me.RibbonPageOptions.Name = "RibbonPageOptions"
        Me.RibbonPageOptions.ShowCaptionButton = False
        Me.RibbonPageOptions.Text = "Options"
        '
        'BtConditionalFormat
        '
        Me.BtConditionalFormat.Caption = "Condicional Format..."
        Me.BtConditionalFormat.Id = 53
        Me.BtConditionalFormat.Name = "BtConditionalFormat"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "Single Values Totals..."
        Me.BarCheckItem1.Id = 54
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'RibbonPageLayoutapplied
        '
        Me.RibbonPageLayoutapplied.AllowMinimize = False
        Me.RibbonPageLayoutapplied.ItemLinks.Add(Me.BarEditItem1)
        Me.RibbonPageLayoutapplied.Name = "RibbonPageLayoutapplied"
        Me.RibbonPageLayoutapplied.ShowCaptionButton = False
        Me.RibbonPageLayoutapplied.Text = "Layout applied"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.CanOpenEdit = False
        Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit2
        Me.BarEditItem1.EditWidth = 200
        Me.BarEditItem1.Id = 52
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Appearance.BorderColor = System.Drawing.Color.Red
        Me.RepositoryItemTextEdit2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RepositoryItemTextEdit2.Appearance.Options.UseBorderColor = True
        Me.RepositoryItemTextEdit2.Appearance.Options.UseFont = True
        Me.RepositoryItemTextEdit2.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RepositoryItemTextEdit2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RibbonPageBack
        '
        Me.RibbonPageBack.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageBack.Name = "RibbonPageBack"
        Me.RibbonPageBack.ShowCaptionButton = False
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "BACK"
        Me.BarButtonItem4.Id = 14
        Me.BarButtonItem4.ImageOptions.LargeImageIndex = 0
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'SkinsGroup
        '
        Me.SkinsGroup.AllowMinimize = False
        Me.SkinsGroup.ItemLinks.Add(Me.RibbonGalleryBarItem1)
        Me.SkinsGroup.Name = "SkinsGroup"
        Me.SkinsGroup.ShowCaptionButton = False
        Me.SkinsGroup.Text = "Skins"
        '
        'RibbonGalleryBarItem1
        '
        Me.RibbonGalleryBarItem1.Caption = "RibbonGalleryBarItem1"
        Me.RibbonGalleryBarItem1.Id = 58
        Me.RibbonGalleryBarItem1.Name = "RibbonGalleryBarItem1"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.AutoHeight = False
        Me.ComboBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RepositoryItemTextEdit1.Appearance.Options.UseFont = True
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.Caption = "Check"
        Me.RepositoryItemCheckEdit3.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.AutoSizeItems = True
        Me.RibbonControl1.Controller = Me.BarAndDockingController1
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem4, Me.BarButtonItem3, Me.BarButtonPrintPreview, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.Top5, Me.Top10, Me.NOTOP, Me.BarEditItem1, Me.BtConditionalFormat, Me.BarCheckItem1, Me.RibbonGalleryBarItem1})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.RibbonControl1.MaxItemId = 61
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemCheckEdit3, Me.RepositoryItemTextEdit2, Me.ComboBoxEdit1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(870, 130)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.SkinsGroup})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Visual"
        '
        'SapSalesTableAdapter1
        '
        Me.SapSalesTableAdapter1.ClearBeforeFill = True
        '
        'SapSalesAmostrasTableAdapter
        '
        Me.SapSalesAmostrasTableAdapter.ClearBeforeFill = True
        '
        'SapSalesCompostosTableAdapter1
        '
        Me.SapSalesCompostosTableAdapter1.ClearBeforeFill = True
        '
        'fieldVINTAGEYESNO
        '
        Me.fieldVINTAGEYESNO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldVINTAGEYESNO.FieldName = "VINTAGEYESNO"
        Me.fieldVINTAGEYESNO.Name = "fieldVINTAGEYESNO"
        '
        'SapSalesOldReservesTableAdapter1
        '
        Me.SapSalesOldReservesTableAdapter1.ClearBeforeFill = True
        '
        'SapSalesGermanWarehouseTableAdapter1
        '
        Me.SapSalesGermanWarehouseTableAdapter1.ClearBeforeFill = True
        '
        'FormPivotComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 564)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FormPivotComp"
        Me.Ribbon = Me.RibbonControl1
        CType(Me.SAPSalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialSystemDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents filenamexml As System.Windows.Forms.OpenFileDialog
    Friend WithEvents savefilexml As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageFiltersApplied As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageLayout As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageTools As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonPrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Top5 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents RibbonPageBack As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPageTopValues As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Top10 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents NOTOP As DevExpress.XtraBars.BarCheckItem
    Private WithEvents RibbonPageLayoutapplied As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

    Friend WithEvents BtConditionalFormat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents Options As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageOptions As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Public WithEvents SkinsGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
    Friend WithEvents SAPSalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldMD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStatsMarket As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStatsClient As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCompany As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTrademark As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVINTAGEYEAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPriceList As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYear As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSalesOrganization As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDivision As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderDocument As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMaterialNumber As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMaterialName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInHand As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldShipped As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents fieldPackage As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFAMILIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFinalClient As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFinalMarket As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInHandUnit As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInvClient As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInvMarket As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldShipHandUnit As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldShippedUnit As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldValueInHand As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldValueShipped As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldShipHand As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPricePer9L As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCATEGORIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldShippedVar As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldShippedValueVar As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldForeca As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldForecm As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBIGTYPE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPerTarget As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPerForecast As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFinalClientNum As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStatsClientNum As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInvClientNum As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGRUPO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCurrency As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRANGE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBigFamilies As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldValueShipHand As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPerTargetInHand As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMarketClass As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBillingDocument As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldImmaterial As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPPMD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPOFINCLI As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPOINVCLI As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents CommercialSystemDataSet2 As CommercialSystemDataSet2
    Friend WithEvents SapSalesTableAdapter1 As CommercialSystemDataSet2TableAdapters.SapSalesTableAdapter
    Friend WithEvents SapSalesAmostrasTableAdapter As CommercialSystemDataSet2TableAdapters.SapSalesAmostrasTableAdapter
    Friend WithEvents SapSalesCompostosTableAdapter1 As CommercialSystemDataSet2TableAdapters.SapSalesCompostosTableAdapter
    Friend WithEvents fieldBIGCAT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBIGCOMPANIES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBOM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVINTAGEYESNO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVINTAGEYESNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTargetValue As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldForecurrent As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldForecaValue As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTARGETEDFAMILY As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SapSalesOldReservesTableAdapter1 As CommercialSystemDataSet2TableAdapters.SapSalesOldReservesTableAdapter
    Friend WithEvents fieldRegion As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SapSalesGermanWarehouseTableAdapter1 As CommercialSystemDataSet2TableAdapters.SapSalesGermanWarehouseTableAdapter
End Class
