<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPivotMesFull
    'Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPivotMesFull))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
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
        Me.fieldBigType = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGRUPO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVintage_NonVint = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBigCat = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCATEGORIA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.FieldBigFamilies = New DevExpress.XtraPivotGrid.PivotGridField()
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
        Me.fieldBigCompanies = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTrademark = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDate2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInHand = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShipped = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInvMarket = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShipHand = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldValueInHand = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldValueShipped = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldValueShipHand = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPricePer9L = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInHandUnit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShippedUnit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShipHandUnit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPriceList = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSalesOrganization = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDivision = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldForeca = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTargetVal = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldForecm = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldForecaValue = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldForecurrent = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPerTarget = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPerTargetINHAND = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPerForeca = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCurrency = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRANGE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMarketClass = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPPMD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPOFINCLI = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPOINVCLI = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTARGETEDFAMILY = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRegion = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SapTipoListaPrecosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.filenamexml = New System.Windows.Forms.OpenFileDialog()
        Me.savefilexml = New System.Windows.Forms.SaveFileDialog()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageFiltersApplied = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageLayout = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
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
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SapSalesTableAdapter1 = New CommercialSystem.CommercialSystemDataSet2TableAdapters.SapSalesTableAdapter()
        Me.SapSalesCompostosTableAdapter1 = New CommercialSystem.CommercialSystemDataSet2TableAdapters.SapSalesCompostosTableAdapter()
        Me.SapSalesAmostrasTableAdapter1 = New CommercialSystem.CommercialSystemDataSet2TableAdapters.SapSalesAmostrasTableAdapter()
        Me.SapTipoListaPrecosTableAdapter = New CommercialSystem.CommercialSystemDataSet2TableAdapters.SapTipoListaPrecosTableAdapter()
        Me.SapSalesOldReservesTableAdapter1 = New CommercialSystem.CommercialSystemDataSet2TableAdapters.SapSalesOldReservesTableAdapter()
        Me.SapSalesGermanWarehouseTableAdapter1 = New CommercialSystem.CommercialSystemDataSet2TableAdapters.SapSalesGermanWarehouseTableAdapter()
        CType(Me.SAPSalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialSystemDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapTipoListaPrecosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ImageCollection1.Images.SetKeyName(8, "Save_As.png")
        Me.ImageCollection1.Images.SetKeyName(9, "Undo.png")
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
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldYear, Me.fieldDate1, Me.fieldDate, Me.fieldMD, Me.fieldMM, Me.fieldMA, Me.fieldStatsClient, Me.fieldInvClient, Me.fieldFinalClient, Me.fieldFinalMarket, Me.fieldCompany, Me.fieldBigType, Me.fieldTIPO, Me.fieldGRUPO, Me.fieldVintage_NonVint, Me.fieldBigCat, Me.fieldCATEGORIA, Me.FieldBigFamilies, Me.fieldFAMILIA, Me.fieldVINTAGEYEAR, Me.fieldPackage, Me.fieldImmaterial, Me.fieldMaterialName, Me.fieldMaterialNumber, Me.fieldOrderDocument, Me.fieldBillingDocument, Me.fieldBOM, Me.fieldFinalClientNum, Me.fieldStatsClientNum, Me.fieldStatsMarket, Me.fieldInvClientNum, Me.fieldBigCompanies, Me.fieldTrademark, Me.fieldDate2, Me.fieldInHand, Me.fieldShipped, Me.fieldInvMarket, Me.fieldShipHand, Me.fieldValueInHand, Me.fieldValueShipped, Me.fieldValueShipHand, Me.fieldPricePer9L, Me.fieldInHandUnit, Me.fieldShippedUnit, Me.fieldShipHandUnit, Me.fieldPriceList, Me.fieldSalesOrganization, Me.fieldDivision, Me.fieldForeca, Me.fieldTargetVal, Me.fieldForecm, Me.fieldForecaValue, Me.fieldForecurrent, Me.fieldPerTarget, Me.fieldPerTargetINHAND, Me.fieldPerForeca, Me.fieldCurrency, Me.fieldRANGE, Me.fieldMarketClass, Me.fieldPPMD, Me.fieldPOFINCLI, Me.fieldPOINVCLI, Me.fieldTARGETEDFAMILY, Me.fieldRegion})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 130)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsBehavior.ApplyBestFitOnFieldDragging = True
        Me.PivotGridControl1.OptionsBehavior.BestFitMode = DevExpress.XtraPivotGrid.PivotGridBestFitMode.Cell
        Me.PivotGridControl1.OptionsBehavior.CopyToClipboardWithFieldValues = True
        Me.PivotGridControl1.OptionsCustomization.AllowEdit = False
        Me.PivotGridControl1.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Always
        Me.PivotGridControl1.OptionsData.DataFieldUnboundExpressionMode = DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues
        Me.PivotGridControl1.OptionsFilterPopup.FieldFilterPopupMode = DevExpress.XtraPivotGrid.FieldFilterPopupMode.Excel
        Me.PivotGridControl1.OptionsFilterPopup.ShowOnlyAvailableItems = True
        Me.PivotGridControl1.OptionsFilterPopup.ToolbarButtons = CType((DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.ShowOnlyAvailableItems Or DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.InvertFilter), DevExpress.XtraPivotGrid.FilterPopupToolbarButtons)
        Me.PivotGridControl1.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PivotGridControl1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintHeadersOnEveryPage = True
        Me.PivotGridControl1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintUnusedFilterFields = False
        Me.PivotGridControl1.OptionsPrint.UsePrintAppearance = True
        Me.PivotGridControl1.OptionsSelection.EnableAppearanceFocusedCell = True
        Me.PivotGridControl1.OptionsView.ShowGrandTotalsForSingleValues = True
        Me.PivotGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.PivotGridControl1.Size = New System.Drawing.Size(997, 434)
        Me.PivotGridControl1.TabIndex = 2
        '
        'fieldYear
        '
        Me.fieldYear.AreaIndex = 0
        Me.fieldYear.Caption = "Year"
        Me.fieldYear.FieldName = "Year"
        Me.fieldYear.Name = "fieldYear"
        '
        'fieldDate1
        '
        Me.fieldDate1.AreaIndex = 1
        Me.fieldDate1.Caption = "Month"
        Me.fieldDate1.FieldName = "Date"
        Me.fieldDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
        Me.fieldDate1.Name = "fieldDate1"
        Me.fieldDate1.UnboundFieldName = "fieldDate1"
        '
        'fieldDate
        '
        Me.fieldDate.AreaIndex = 2
        Me.fieldDate.CellFormat.FormatString = "d"
        Me.fieldDate.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldDate.FieldName = "Date"
        Me.fieldDate.Name = "fieldDate"
        Me.fieldDate.ValueFormat.FormatString = "d"
        Me.fieldDate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'fieldMD
        '
        Me.fieldMD.AreaIndex = 3
        Me.fieldMD.Caption = "MR"
        Me.fieldMD.FieldName = "MD"
        Me.fieldMD.Name = "fieldMD"
        '
        'fieldMM
        '
        Me.fieldMM.AreaIndex = 4
        Me.fieldMM.Caption = "MM"
        Me.fieldMM.FieldName = "MM"
        Me.fieldMM.Name = "fieldMM"
        '
        'fieldMA
        '
        Me.fieldMA.AreaIndex = 5
        Me.fieldMA.Caption = "MA"
        Me.fieldMA.FieldName = "MA"
        Me.fieldMA.Name = "fieldMA"
        '
        'fieldStatsClient
        '
        Me.fieldStatsClient.AreaIndex = 6
        Me.fieldStatsClient.Caption = "Stats Customer"
        Me.fieldStatsClient.FieldName = "StatsClient"
        Me.fieldStatsClient.Name = "fieldStatsClient"
        '
        'fieldInvClient
        '
        Me.fieldInvClient.AreaIndex = 7
        Me.fieldInvClient.Caption = "Inv Customer"
        Me.fieldInvClient.FieldName = "InvClient"
        Me.fieldInvClient.Name = "fieldInvClient"
        '
        'fieldFinalClient
        '
        Me.fieldFinalClient.AreaIndex = 8
        Me.fieldFinalClient.Caption = "Final Customer"
        Me.fieldFinalClient.FieldName = "FinalClient"
        Me.fieldFinalClient.Name = "fieldFinalClient"
        '
        'fieldFinalMarket
        '
        Me.fieldFinalMarket.AreaIndex = 9
        Me.fieldFinalMarket.Caption = "Final Market"
        Me.fieldFinalMarket.FieldName = "FinalMarket"
        Me.fieldFinalMarket.MinWidth = 100
        Me.fieldFinalMarket.Name = "fieldFinalMarket"
        '
        'fieldCompany
        '
        Me.fieldCompany.AreaIndex = 10
        Me.fieldCompany.Caption = "Brand"
        Me.fieldCompany.FieldName = "Company"
        Me.fieldCompany.MinWidth = 90
        Me.fieldCompany.Name = "fieldCompany"
        Me.fieldCompany.Width = 90
        '
        'fieldBigType
        '
        Me.fieldBigType.AreaIndex = 11
        Me.fieldBigType.Caption = "Big Type"
        Me.fieldBigType.FieldName = "BIGTYPE"
        Me.fieldBigType.Name = "fieldBigType"
        '
        'fieldTIPO
        '
        Me.fieldTIPO.AreaIndex = 12
        Me.fieldTIPO.Caption = "Type"
        Me.fieldTIPO.FieldName = "TIPO"
        Me.fieldTIPO.Name = "fieldTIPO"
        '
        'fieldGRUPO
        '
        Me.fieldGRUPO.AreaIndex = 13
        Me.fieldGRUPO.Caption = "Group"
        Me.fieldGRUPO.FieldName = "GRUPO"
        Me.fieldGRUPO.Name = "fieldGRUPO"
        '
        'fieldVintage_NonVint
        '
        Me.fieldVintage_NonVint.AreaIndex = 14
        Me.fieldVintage_NonVint.Caption = "Wood/Bottle Matured"
        Me.fieldVintage_NonVint.FieldName = "VINTAGEYESNO"
        Me.fieldVintage_NonVint.Name = "fieldVintage_NonVint"
        '
        'fieldBigCat
        '
        Me.fieldBigCat.AreaIndex = 15
        Me.fieldBigCat.Caption = "Big Categories"
        Me.fieldBigCat.FieldName = "BIGCAT"
        Me.fieldBigCat.Name = "fieldBigCat"
        '
        'fieldCATEGORIA
        '
        Me.fieldCATEGORIA.AreaIndex = 16
        Me.fieldCATEGORIA.Caption = "Category"
        Me.fieldCATEGORIA.FieldName = "CATEGORIA"
        Me.fieldCATEGORIA.Name = "fieldCATEGORIA"
        '
        'FieldBigFamilies
        '
        Me.FieldBigFamilies.AreaIndex = 17
        Me.FieldBigFamilies.Caption = "Big Families"
        Me.FieldBigFamilies.FieldName = "BIGFAMILIES"
        Me.FieldBigFamilies.Name = "FieldBigFamilies"
        '
        'fieldFAMILIA
        '
        Me.fieldFAMILIA.AreaIndex = 18
        Me.fieldFAMILIA.Caption = "Family"
        Me.fieldFAMILIA.FieldName = "FAMILIA"
        Me.fieldFAMILIA.Name = "fieldFAMILIA"
        '
        'fieldVINTAGEYEAR
        '
        Me.fieldVINTAGEYEAR.AreaIndex = 19
        Me.fieldVINTAGEYEAR.Caption = "Vintage Year"
        Me.fieldVINTAGEYEAR.FieldName = "VINTAGEYEAR"
        Me.fieldVINTAGEYEAR.MinWidth = 75
        Me.fieldVINTAGEYEAR.Name = "fieldVINTAGEYEAR"
        Me.fieldVINTAGEYEAR.Width = 75
        '
        'fieldPackage
        '
        Me.fieldPackage.AreaIndex = 20
        Me.fieldPackage.FieldName = "Package"
        Me.fieldPackage.Name = "fieldPackage"
        '
        'fieldImmaterial
        '
        Me.fieldImmaterial.AreaIndex = 21
        Me.fieldImmaterial.Caption = "ZIMA"
        Me.fieldImmaterial.FieldName = "Immaterial"
        Me.fieldImmaterial.Name = "fieldImmaterial"
        '
        'fieldMaterialName
        '
        Me.fieldMaterialName.AreaIndex = 22
        Me.fieldMaterialName.Caption = "Material Name"
        Me.fieldMaterialName.FieldName = "Material Name"
        Me.fieldMaterialName.Name = "fieldMaterialName"
        '
        'fieldMaterialNumber
        '
        Me.fieldMaterialNumber.AreaIndex = 23
        Me.fieldMaterialNumber.Caption = "Material Number"
        Me.fieldMaterialNumber.FieldName = "Material Number"
        Me.fieldMaterialNumber.Name = "fieldMaterialNumber"
        '
        'fieldOrderDocument
        '
        Me.fieldOrderDocument.AreaIndex = 24
        Me.fieldOrderDocument.Caption = "Order Document"
        Me.fieldOrderDocument.FieldName = "Order Document"
        Me.fieldOrderDocument.Name = "fieldOrderDocument"
        '
        'fieldBillingDocument
        '
        Me.fieldBillingDocument.AreaIndex = 25
        Me.fieldBillingDocument.Caption = "Billing Document"
        Me.fieldBillingDocument.FieldName = "Billing Document"
        Me.fieldBillingDocument.Name = "fieldBillingDocument"
        '
        'fieldBOM
        '
        Me.fieldBOM.AreaIndex = 26
        Me.fieldBOM.Caption = "B.O.M."
        Me.fieldBOM.FieldName = "BOM"
        Me.fieldBOM.Name = "fieldBOM"
        '
        'fieldFinalClientNum
        '
        Me.fieldFinalClientNum.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldFinalClientNum.AreaIndex = 0
        Me.fieldFinalClientNum.Caption = "F. Cust. Num"
        Me.fieldFinalClientNum.FieldName = "FinalClientNum"
        Me.fieldFinalClientNum.Name = "fieldFinalClientNum"
        Me.fieldFinalClientNum.Visible = False
        '
        'fieldStatsClientNum
        '
        Me.fieldStatsClientNum.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldStatsClientNum.AreaIndex = 0
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
        Me.fieldInvClientNum.AreaIndex = 0
        Me.fieldInvClientNum.Caption = "Inv Customer Num"
        Me.fieldInvClientNum.FieldName = "InvClientNum"
        Me.fieldInvClientNum.Name = "fieldInvClientNum"
        Me.fieldInvClientNum.Visible = False
        '
        'fieldBigCompanies
        '
        Me.fieldBigCompanies.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldBigCompanies.Caption = "Big Brand"
        Me.fieldBigCompanies.FieldName = "BIGCOMPANIES"
        Me.fieldBigCompanies.Name = "fieldBigCompanies"
        Me.fieldBigCompanies.Visible = False
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
        'fieldDate2
        '
        Me.fieldDate2.AreaIndex = 24
        Me.fieldDate2.Caption = "Yearly"
        Me.fieldDate2.FieldName = "Date"
        Me.fieldDate2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.YearAge
        Me.fieldDate2.GroupIntervalNumericRange = 1
        Me.fieldDate2.Name = "fieldDate2"
        Me.fieldDate2.Options.ShowInCustomizationForm = False
        Me.fieldDate2.UnboundFieldName = "fieldDate2"
        Me.fieldDate2.Visible = False
        '
        'fieldInHand
        '
        Me.fieldInHand.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldInHand.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldInHand.AreaIndex = 0
        Me.fieldInHand.Caption = "In Hand 9L"
        Me.fieldInHand.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldInHand.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldInHand.EmptyCellText = "-"
        Me.fieldInHand.EmptyValueText = "-"
        Me.fieldInHand.FieldName = "InHand"
        Me.fieldInHand.MinWidth = 75
        Me.fieldInHand.Name = "fieldInHand"
        Me.fieldInHand.Options.ShowValues = False
        '
        'fieldShipped
        '
        Me.fieldShipped.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldShipped.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldShipped.AreaIndex = 2
        Me.fieldShipped.Caption = "Shipped 9L"
        Me.fieldShipped.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldShipped.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldShipped.EmptyCellText = "-"
        Me.fieldShipped.EmptyValueText = "-"
        Me.fieldShipped.FieldName = "Shipped"
        Me.fieldShipped.MinWidth = 75
        Me.fieldShipped.Name = "fieldShipped"
        '
        'fieldInvMarket
        '
        Me.fieldInvMarket.AreaIndex = 27
        Me.fieldInvMarket.Caption = "Inv. Market"
        Me.fieldInvMarket.FieldName = "InvMarket"
        Me.fieldInvMarket.MinWidth = 100
        Me.fieldInvMarket.Name = "fieldInvMarket"
        Me.fieldInvMarket.Visible = False
        '
        'fieldShipHand
        '
        Me.fieldShipHand.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldShipHand.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldShipHand.AreaIndex = 5
        Me.fieldShipHand.Caption = "ShipHand 9L"
        Me.fieldShipHand.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldShipHand.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldShipHand.EmptyCellText = "-"
        Me.fieldShipHand.EmptyValueText = "-"
        Me.fieldShipHand.FieldName = "ShipHand"
        Me.fieldShipHand.MinWidth = 75
        Me.fieldShipHand.Name = "fieldShipHand"
        Me.fieldShipHand.Options.ShowValues = False
        '
        'fieldValueInHand
        '
        Me.fieldValueInHand.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldValueInHand.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldValueInHand.AreaIndex = 1
        Me.fieldValueInHand.Caption = "In Hand €"
        Me.fieldValueInHand.CellFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldValueInHand.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldValueInHand.EmptyCellText = "-"
        Me.fieldValueInHand.EmptyValueText = "-"
        Me.fieldValueInHand.FieldName = "ValueInHand"
        Me.fieldValueInHand.MinWidth = 75
        Me.fieldValueInHand.Name = "fieldValueInHand"
        Me.fieldValueInHand.Options.ShowValues = False
        Me.fieldValueInHand.Width = 75
        '
        'fieldValueShipped
        '
        Me.fieldValueShipped.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldValueShipped.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldValueShipped.AreaIndex = 3
        Me.fieldValueShipped.Caption = "Shipped €"
        Me.fieldValueShipped.CellFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldValueShipped.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldValueShipped.EmptyCellText = "-"
        Me.fieldValueShipped.EmptyValueText = "-"
        Me.fieldValueShipped.FieldName = "ValueShipped"
        Me.fieldValueShipped.MinWidth = 75
        Me.fieldValueShipped.Name = "fieldValueShipped"
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
        'fieldPricePer9L
        '
        Me.fieldPricePer9L.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldPricePer9L.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPricePer9L.AreaIndex = 4
        Me.fieldPricePer9L.Caption = "Av. Price 9L"
        Me.fieldPricePer9L.CellFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldPricePer9L.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPricePer9L.EmptyCellText = "-"
        Me.fieldPricePer9L.EmptyValueText = "-"
        Me.fieldPricePer9L.MinWidth = 75
        Me.fieldPricePer9L.Name = "fieldPricePer9L"
        Me.fieldPricePer9L.Options.ShowValues = False
        Me.fieldPricePer9L.UnboundExpression = "iif ([fieldShipped] = 0, 0 , [fieldValueShipped] / [fieldShipped] )"
        Me.fieldPricePer9L.UnboundFieldName = "PricePer9L"
        Me.fieldPricePer9L.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'fieldInHandUnit
        '
        Me.fieldInHandUnit.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldInHandUnit.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldInHandUnit.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldInHandUnit.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldInHandUnit.EmptyCellText = "-"
        Me.fieldInHandUnit.EmptyValueText = "-"
        Me.fieldInHandUnit.FieldName = "InHandUnit"
        Me.fieldInHandUnit.Name = "fieldInHandUnit"
        Me.fieldInHandUnit.Visible = False
        '
        'fieldShippedUnit
        '
        Me.fieldShippedUnit.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldShippedUnit.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldShippedUnit.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldShippedUnit.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldShippedUnit.EmptyCellText = "-"
        Me.fieldShippedUnit.EmptyValueText = "-"
        Me.fieldShippedUnit.FieldName = "ShippedUnit"
        Me.fieldShippedUnit.Name = "fieldShippedUnit"
        Me.fieldShippedUnit.Visible = False
        '
        'fieldShipHandUnit
        '
        Me.fieldShipHandUnit.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldShipHandUnit.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldShipHandUnit.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldShipHandUnit.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldShipHandUnit.EmptyCellText = "-"
        Me.fieldShipHandUnit.EmptyValueText = "-"
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
        'fieldForeca
        '
        Me.fieldForeca.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldForeca.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldForeca.AreaIndex = 6
        Me.fieldForeca.Caption = "Target 9L"
        Me.fieldForeca.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldForeca.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldForeca.EmptyCellText = "-"
        Me.fieldForeca.EmptyValueText = "-"
        Me.fieldForeca.FieldName = "Foreca"
        Me.fieldForeca.MinWidth = 50
        Me.fieldForeca.Name = "fieldForeca"
        Me.fieldForeca.Options.ShowValues = False
        '
        'fieldTargetVal
        '
        Me.fieldTargetVal.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldTargetVal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTargetVal.AreaIndex = 9
        Me.fieldTargetVal.Caption = "Target Value"
        Me.fieldTargetVal.CellFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldTargetVal.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTargetVal.EmptyCellText = "-"
        Me.fieldTargetVal.EmptyValueText = "-"
        Me.fieldTargetVal.FieldName = "TargetValue"
        Me.fieldTargetVal.MinWidth = 50
        Me.fieldTargetVal.Name = "fieldTargetVal"
        Me.fieldTargetVal.Options.ShowValues = False
        Me.fieldTargetVal.Visible = False
        '
        'fieldForecm
        '
        Me.fieldForecm.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldForecm.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldForecm.AreaIndex = 7
        Me.fieldForecm.Caption = "Forecast 9L"
        Me.fieldForecm.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldForecm.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldForecm.EmptyCellText = "-"
        Me.fieldForecm.EmptyValueText = "-"
        Me.fieldForecm.FieldName = "Forecm"
        Me.fieldForecm.MinWidth = 50
        Me.fieldForecm.Name = "fieldForecm"
        Me.fieldForecm.Options.ShowValues = False
        '
        'fieldForecaValue
        '
        Me.fieldForecaValue.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldForecaValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldForecaValue.AreaIndex = 9
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
        Me.fieldForecurrent.Caption = "Current Forecast 9L"
        Me.fieldForecurrent.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldForecurrent.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldForecurrent.EmptyCellText = "-"
        Me.fieldForecurrent.EmptyValueText = "-"
        Me.fieldForecurrent.FieldName = "Forecurrent"
        Me.fieldForecurrent.MinWidth = 50
        Me.fieldForecurrent.Name = "fieldForecurrent"
        Me.fieldForecurrent.Options.ShowValues = False
        Me.fieldForecurrent.Visible = False
        '
        'fieldPerTarget
        '
        Me.fieldPerTarget.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldPerTarget.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPerTarget.AreaIndex = 7
        Me.fieldPerTarget.Caption = "% Target"
        Me.fieldPerTarget.CellFormat.FormatString = "P"
        Me.fieldPerTarget.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPerTarget.Name = "fieldPerTarget"
        Me.fieldPerTarget.Options.ShowValues = False
        Me.fieldPerTarget.UnboundExpression = "iif ([fieldForeca] = 0, 0 ,   [fieldShipped] / [fieldForeca])"
        Me.fieldPerTarget.UnboundFieldName = "fieldPerTarget"
        Me.fieldPerTarget.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.fieldPerTarget.Visible = False
        '
        'fieldPerTargetINHAND
        '
        Me.fieldPerTargetINHAND.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldPerTargetINHAND.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPerTargetINHAND.AreaIndex = 8
        Me.fieldPerTargetINHAND.Caption = "% Target inc InHand"
        Me.fieldPerTargetINHAND.CellFormat.FormatString = "P"
        Me.fieldPerTargetINHAND.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPerTargetINHAND.Name = "fieldPerTargetINHAND"
        Me.fieldPerTargetINHAND.Options.ShowValues = False
        Me.fieldPerTargetINHAND.UnboundExpression = "iif ([fieldForeca] = 0, 0 ,   ([fieldShipped] + [fieldInHand])/ [fieldForeca])"
        Me.fieldPerTargetINHAND.UnboundFieldName = "fieldPerTargetINHAND"
        Me.fieldPerTargetINHAND.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.fieldPerTargetINHAND.Visible = False
        '
        'fieldPerForeca
        '
        Me.fieldPerForeca.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldPerForeca.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPerForeca.AreaIndex = 8
        Me.fieldPerForeca.Caption = "% Forecast"
        Me.fieldPerForeca.CellFormat.FormatString = "P"
        Me.fieldPerForeca.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPerForeca.Name = "fieldPerForeca"
        Me.fieldPerForeca.Options.ShowValues = False
        Me.fieldPerForeca.UnboundExpression = "iif ([fieldForecm] = 0, 0 ,   [fieldShipped] / [fieldForecm])"
        Me.fieldPerForeca.UnboundFieldName = "fieldPerForeca"
        Me.fieldPerForeca.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'fieldCurrency
        '
        Me.fieldCurrency.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldCurrency.AreaIndex = 3
        Me.fieldCurrency.Caption = "Inv. Currency"
        Me.fieldCurrency.FieldName = "Currency"
        Me.fieldCurrency.Name = "fieldCurrency"
        Me.fieldCurrency.Visible = False
        '
        'fieldRANGE
        '
        Me.fieldRANGE.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldRANGE.AreaIndex = 0
        Me.fieldRANGE.Caption = "Stock"
        Me.fieldRANGE.FieldName = "RANGE"
        Me.fieldRANGE.Name = "fieldRANGE"
        Me.fieldRANGE.Visible = False
        '
        'fieldMarketClass
        '
        Me.fieldMarketClass.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldMarketClass.AreaIndex = 0
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
        Me.fieldTARGETEDFAMILY.AreaIndex = 27
        Me.fieldTARGETEDFAMILY.Caption = "Targeted Family"
        Me.fieldTARGETEDFAMILY.FieldName = "TARGETEDFAMILY"
        Me.fieldTARGETEDFAMILY.Name = "fieldTARGETEDFAMILY"
        '
        'fieldRegion
        '
        Me.fieldRegion.AreaIndex = 28
        Me.fieldRegion.Caption = "Region"
        Me.fieldRegion.FieldName = "Region"
        Me.fieldRegion.Name = "fieldRegion"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.SapTipoListaPrecosBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "PTEXT"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'SapTipoListaPrecosBindingSource
        '
        Me.SapTipoListaPrecosBindingSource.DataMember = "SapTipoListaPrecos"
        Me.SapTipoListaPrecosBindingSource.DataSource = Me.CommercialSystemDataSet2
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
        Me.RibbonPageLayout.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageLayout.ItemLinks.Add(Me.BarButtonItem9)
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
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Save as Default"
        Me.BarButtonItem5.Id = 61
        Me.BarButtonItem5.ImageOptions.LargeImageIndex = 8
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Reset Default"
        Me.BarButtonItem9.Id = 62
        Me.BarButtonItem9.ImageOptions.LargeImageIndex = 9
        Me.BarButtonItem9.Name = "BarButtonItem9"
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
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.AutoSizeItems = True
        Me.RibbonControl1.Controller = Me.BarAndDockingController1
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem4, Me.BarButtonItem3, Me.BarButtonPrintPreview, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.Top5, Me.Top10, Me.NOTOP, Me.BarEditItem1, Me.BtConditionalFormat, Me.BarCheckItem1, Me.RibbonGalleryBarItem1, Me.BarButtonItem5, Me.BarButtonItem9})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.RibbonControl1.MaxItemId = 63
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(997, 130)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.SkinsGroup})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Visual"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'SapSalesTableAdapter1
        '
        Me.SapSalesTableAdapter1.ClearBeforeFill = True
        '
        'SapSalesCompostosTableAdapter1
        '
        Me.SapSalesCompostosTableAdapter1.ClearBeforeFill = True
        '
        'SapSalesAmostrasTableAdapter1
        '
        Me.SapSalesAmostrasTableAdapter1.ClearBeforeFill = True
        '
        'SapTipoListaPrecosTableAdapter
        '
        Me.SapTipoListaPrecosTableAdapter.ClearBeforeFill = True
        '
        'SapSalesOldReservesTableAdapter1
        '
        Me.SapSalesOldReservesTableAdapter1.ClearBeforeFill = True
        '
        'SapSalesGermanWarehouseTableAdapter1
        '
        Me.SapSalesGermanWarehouseTableAdapter1.ClearBeforeFill = True
        '
        'FormPivotMesFull
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 564)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FormPivotMesFull"
        Me.Ribbon = Me.RibbonControl1
        CType(Me.SAPSalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialSystemDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapTipoListaPrecosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents fieldForeca As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldForecm As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents fieldGRUPO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPerTarget As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPerForeca As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFinalClientNum As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStatsClientNum As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInvClientNum As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCurrency As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRANGE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents FieldBigFamilies As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDate2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldValueShipHand As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPerTargetINHAND As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMarketClass As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBillingDocument As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldImmaterial As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPPMD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPOFINCLI As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPOINVCLI As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents CommercialSystemDataSet2 As CommercialSystemDataSet2
    Friend WithEvents SapSalesTableAdapter1 As CommercialSystemDataSet2TableAdapters.SapSalesTableAdapter
    Friend WithEvents SapSalesCompostosTableAdapter1 As CommercialSystemDataSet2TableAdapters.SapSalesCompostosTableAdapter
    Friend WithEvents SapSalesAmostrasTableAdapter1 As CommercialSystemDataSet2TableAdapters.SapSalesAmostrasTableAdapter
    Friend WithEvents fieldForecurrent As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBigCompanies As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVintage_NonVint As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBigType As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBigCat As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTargetVal As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBOM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldForecaValue As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SapTipoListaPrecosBindingSource As BindingSource
    Friend WithEvents SapTipoListaPrecosTableAdapter As CommercialSystemDataSet2TableAdapters.SapTipoListaPrecosTableAdapter
    Friend WithEvents fieldTARGETEDFAMILY As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SapSalesOldReservesTableAdapter1 As CommercialSystemDataSet2TableAdapters.SapSalesOldReservesTableAdapter
    Friend WithEvents fieldRegion As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SapSalesGermanWarehouseTableAdapter1 As CommercialSystemDataSet2TableAdapters.SapSalesGermanWarehouseTableAdapter
End Class
