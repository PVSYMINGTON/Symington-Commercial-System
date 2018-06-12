<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPivotTrade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPivotTrade))
        Dim PivotGridFieldSortCondition2 As DevExpress.XtraPivotGrid.PivotGridFieldSortCondition = New DevExpress.XtraPivotGrid.PivotGridFieldSortCondition()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim PointOptions2 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Me.fieldorigem = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO8 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO9 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO10 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.SapIVDPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IvpDataSet1 = New CommercialSystem.ivpDataSet()
        Me.fieldDirector = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldpais = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCliente = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldcompany = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldmarca = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTipo = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGrupo = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSubcat = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO11 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldano = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVNO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVNO2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVNO3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVNO4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVNO5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVNO6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVNO7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVNO8 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVNO9 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVNO10 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVNO11 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.filenamexml = New System.Windows.Forms.OpenFileDialog()
        Me.savefilexml = New System.Windows.Forms.SaveFileDialog()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageFiltersApplied = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageLayout = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonIVDPCompany = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonIVDPGroup = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonIVDPMarketStatistics = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonIVDPMarketShareCountry = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonIVDPOrigem = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonIVDPSubcat = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonIVDPTipo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonIVDPTotal = New DevExpress.XtraBars.BarButtonItem()
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
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.SapIVDPTableAdapter = New CommercialSystem.ivpDataSetTableAdapters.sapIVDPTableAdapter()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapIVDPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IvpDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fieldorigem
        '
        Me.fieldorigem.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldorigem.AreaIndex = 0
        Me.fieldorigem.Caption = "origem"
        Me.fieldorigem.FieldName = "origem"
        Me.fieldorigem.KPIGraphic = DevExpress.XtraPivotGrid.PivotKPIGraphic.None
        Me.fieldorigem.Name = "fieldorigem"
        Me.fieldorigem.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldorigem.Width = 103
        '
        'fieldANO1
        '
        Me.fieldANO1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO1.AreaIndex = 0
        Me.fieldANO1.Caption = "ANO1"
        Me.fieldANO1.CellFormat.FormatString = "#,###;#,###;-"
        Me.fieldANO1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO1.FieldName = "ANO1"
        Me.fieldANO1.Name = "fieldANO1"
        Me.fieldANO1.Width = 65
        '
        'fieldANO2
        '
        Me.fieldANO2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO2.AreaIndex = 1
        Me.fieldANO2.Caption = "ANO2"
        Me.fieldANO2.CellFormat.FormatString = "#,###;#,###;-"
        Me.fieldANO2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO2.FieldName = "ANO2"
        Me.fieldANO2.Name = "fieldANO2"
        Me.fieldANO2.RunningTotal = True
        Me.fieldANO2.Visible = False
        Me.fieldANO2.Width = 62
        '
        'fieldANO3
        '
        Me.fieldANO3.AreaIndex = 7
        Me.fieldANO3.Caption = "ANO3"
        Me.fieldANO3.CellFormat.FormatString = "#,###;#,###;-"
        Me.fieldANO3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO3.FieldName = "ANO3"
        Me.fieldANO3.Name = "fieldANO3"
        Me.fieldANO3.Visible = False
        Me.fieldANO3.Width = 79
        '
        'fieldANO4
        '
        Me.fieldANO4.AreaIndex = 8
        Me.fieldANO4.Caption = "ANO4"
        Me.fieldANO4.CellFormat.FormatString = "#,###;#,###;-"
        Me.fieldANO4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO4.FieldName = "ANO4"
        Me.fieldANO4.Name = "fieldANO4"
        Me.fieldANO4.Visible = False
        '
        'fieldANO5
        '
        Me.fieldANO5.AreaIndex = 9
        Me.fieldANO5.Caption = "ANO5"
        Me.fieldANO5.CellFormat.FormatString = "#,###;#,###;-"
        Me.fieldANO5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO5.FieldName = "ANO5"
        Me.fieldANO5.Name = "fieldANO5"
        Me.fieldANO5.Visible = False
        '
        'fieldANO6
        '
        Me.fieldANO6.AreaIndex = 10
        Me.fieldANO6.Caption = "ANO6"
        Me.fieldANO6.CellFormat.FormatString = "#,###;#,###;-"
        Me.fieldANO6.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO6.FieldName = "ANO6"
        Me.fieldANO6.Name = "fieldANO6"
        Me.fieldANO6.Visible = False
        '
        'fieldANO7
        '
        Me.fieldANO7.AreaIndex = 11
        Me.fieldANO7.Caption = "ANO7"
        Me.fieldANO7.CellFormat.FormatString = "#,###;#,###;-"
        Me.fieldANO7.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO7.FieldName = "ANO7"
        Me.fieldANO7.Name = "fieldANO7"
        Me.fieldANO7.Visible = False
        '
        'fieldANO8
        '
        Me.fieldANO8.AreaIndex = 12
        Me.fieldANO8.Caption = "ANO8"
        Me.fieldANO8.CellFormat.FormatString = "#,###;#,###;-"
        Me.fieldANO8.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO8.FieldName = "ANO8"
        Me.fieldANO8.Name = "fieldANO8"
        Me.fieldANO8.Visible = False
        '
        'fieldANO9
        '
        Me.fieldANO9.AreaIndex = 13
        Me.fieldANO9.Caption = "ANO9"
        Me.fieldANO9.CellFormat.FormatString = "#,###;#,###;-"
        Me.fieldANO9.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO9.FieldName = "ANO9"
        Me.fieldANO9.Name = "fieldANO9"
        Me.fieldANO9.Visible = False
        '
        'fieldANO10
        '
        Me.fieldANO10.AreaIndex = 14
        Me.fieldANO10.Caption = "ANO10"
        Me.fieldANO10.CellFormat.FormatString = "#,###;#,###;-"
        Me.fieldANO10.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO10.FieldName = "ANO10"
        Me.fieldANO10.Name = "fieldANO10"
        Me.fieldANO10.Visible = False
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
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 30, 50)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.SapIVDPBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldorigem, Me.fieldDirector, Me.fieldpais, Me.fieldCliente, Me.fieldcompany, Me.fieldmarca, Me.fieldTipo, Me.fieldGrupo, Me.fieldSubcat, Me.fieldANO1, Me.fieldANO2, Me.fieldANO3, Me.fieldANO4, Me.fieldANO5, Me.fieldANO6, Me.fieldANO7, Me.fieldANO8, Me.fieldANO9, Me.fieldANO10, Me.fieldANO11, Me.fieldano, Me.fieldVNO1, Me.fieldVNO2, Me.fieldVNO3, Me.fieldVNO4, Me.fieldVNO5, Me.fieldVNO6, Me.fieldVNO7, Me.fieldVNO8, Me.fieldVNO9, Me.fieldVNO10, Me.fieldVNO11})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsBehavior.ApplyBestFitOnFieldDragging = True
        Me.PivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
        Me.PivotGridControl1.OptionsChartDataSource.MaxAllowedSeriesCount = 100
        Me.PivotGridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.PivotGridControl1.OptionsDataField.AreaIndex = 11
        Me.PivotGridControl1.OptionsDataField.FieldNaming = DevExpress.XtraPivotGrid.DataFieldNaming.Name
        Me.PivotGridControl1.OptionsDataField.RowHeaderWidth = 40
        Me.PivotGridControl1.OptionsPrint.PageSettings.Landscape = True
        Me.PivotGridControl1.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.UsePrintAppearance = True
        Me.PivotGridControl1.OptionsView.ShowColumnGrandTotals = False
        Me.PivotGridControl1.Size = New System.Drawing.Size(870, 281)
        Me.PivotGridControl1.TabIndex = 0
        '
        'SapIVDPBindingSource
        '
        Me.SapIVDPBindingSource.DataMember = "SapIVDP"
        Me.SapIVDPBindingSource.DataSource = Me.IvpDataSet1
        '
        'IvpDataSet1
        '
        Me.IvpDataSet1.DataSetName = "ivpDataSet"
        Me.IvpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldDirector
        '
        Me.fieldDirector.AreaIndex = 0
        Me.fieldDirector.Caption = "Market Director"
        Me.fieldDirector.FieldName = "Director"
        Me.fieldDirector.Name = "fieldDirector"
        '
        'fieldpais
        '
        Me.fieldpais.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldpais.AreaIndex = 0
        Me.fieldpais.Caption = "Market"
        Me.fieldpais.FieldName = "pais"
        Me.fieldpais.Name = "fieldpais"
        PivotGridFieldSortCondition2.Field = Me.fieldorigem
        PivotGridFieldSortCondition2.Value = "Trade"
        Me.fieldpais.SortBySummaryInfo.Conditions.Add(PivotGridFieldSortCondition2)
        Me.fieldpais.SortBySummaryInfo.Field = Me.fieldANO1
        Me.fieldpais.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldpais.TopValueCount = 10
        Me.fieldpais.TopValueShowOthers = True
        Me.fieldpais.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldpais.Width = 153
        '
        'fieldCliente
        '
        Me.fieldCliente.AreaIndex = 1
        Me.fieldCliente.Caption = "Client"
        Me.fieldCliente.FieldName = "Cliente"
        Me.fieldCliente.Name = "fieldCliente"
        '
        'fieldcompany
        '
        Me.fieldcompany.AreaIndex = 2
        Me.fieldcompany.Caption = "Brand"
        Me.fieldcompany.FieldName = "company"
        Me.fieldcompany.Name = "fieldcompany"
        Me.fieldcompany.Width = 78
        '
        'fieldmarca
        '
        Me.fieldmarca.AreaIndex = 4
        Me.fieldmarca.Caption = "Trademark"
        Me.fieldmarca.FieldName = "marca"
        Me.fieldmarca.Name = "fieldmarca"
        Me.fieldmarca.Width = 79
        '
        'fieldTipo
        '
        Me.fieldTipo.AreaIndex = 3
        Me.fieldTipo.Caption = "Type"
        Me.fieldTipo.FieldName = "Tipo"
        Me.fieldTipo.Name = "fieldTipo"
        Me.fieldTipo.Width = 79
        '
        'fieldGrupo
        '
        Me.fieldGrupo.AreaIndex = 6
        Me.fieldGrupo.Caption = "Group"
        Me.fieldGrupo.FieldName = "Grupo"
        Me.fieldGrupo.KPIGraphic = DevExpress.XtraPivotGrid.PivotKPIGraphic.None
        Me.fieldGrupo.Name = "fieldGrupo"
        Me.fieldGrupo.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldGrupo.Width = 64
        '
        'fieldSubcat
        '
        Me.fieldSubcat.AreaIndex = 5
        Me.fieldSubcat.Caption = "Subcat"
        Me.fieldSubcat.FieldName = "Subcat"
        Me.fieldSubcat.KPIGraphic = DevExpress.XtraPivotGrid.PivotKPIGraphic.None
        Me.fieldSubcat.Name = "fieldSubcat"
        Me.fieldSubcat.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldSubcat.Width = 79
        '
        'fieldANO11
        '
        Me.fieldANO11.AreaIndex = 15
        Me.fieldANO11.Caption = "ANO11"
        Me.fieldANO11.CellFormat.FormatString = "#,###;#,###;-"
        Me.fieldANO11.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO11.FieldName = "ANO11"
        Me.fieldANO11.Name = "fieldANO11"
        Me.fieldANO11.Visible = False
        '
        'fieldano
        '
        Me.fieldano.AreaIndex = 15
        Me.fieldano.Caption = "ano"
        Me.fieldano.CellFormat.FormatString = "#,###€;#,###€;-"
        Me.fieldano.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldano.FieldName = "ano"
        Me.fieldano.Name = "fieldano"
        Me.fieldano.Visible = False
        '
        'fieldVNO1
        '
        Me.fieldVNO1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldVNO1.AreaIndex = 1
        Me.fieldVNO1.Caption = "ANO1€"
        Me.fieldVNO1.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO1.FieldName = "VNO1"
        Me.fieldVNO1.Name = "fieldVNO1"
        Me.fieldVNO1.Visible = False
        '
        'fieldVNO2
        '
        Me.fieldVNO2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldVNO2.AreaIndex = 1
        Me.fieldVNO2.Caption = "ANO2€"
        Me.fieldVNO2.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO2.FieldName = "VNO2"
        Me.fieldVNO2.Name = "fieldVNO2"
        Me.fieldVNO2.Visible = False
        '
        'fieldVNO3
        '
        Me.fieldVNO3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldVNO3.AreaIndex = 1
        Me.fieldVNO3.Caption = "ANO3€"
        Me.fieldVNO3.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO3.FieldName = "VNO3"
        Me.fieldVNO3.Name = "fieldVNO3"
        Me.fieldVNO3.Visible = False
        '
        'fieldVNO4
        '
        Me.fieldVNO4.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldVNO4.AreaIndex = 1
        Me.fieldVNO4.Caption = "ANO4€"
        Me.fieldVNO4.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO4.FieldName = "VNO4"
        Me.fieldVNO4.Name = "fieldVNO4"
        Me.fieldVNO4.Visible = False
        '
        'fieldVNO5
        '
        Me.fieldVNO5.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldVNO5.AreaIndex = 1
        Me.fieldVNO5.Caption = "ANO5€"
        Me.fieldVNO5.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO5.FieldName = "VNO5"
        Me.fieldVNO5.Name = "fieldVNO5"
        Me.fieldVNO5.Visible = False
        '
        'fieldVNO6
        '
        Me.fieldVNO6.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldVNO6.AreaIndex = 1
        Me.fieldVNO6.Caption = "ANO6€"
        Me.fieldVNO6.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO6.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO6.FieldName = "VNO6"
        Me.fieldVNO6.Name = "fieldVNO6"
        Me.fieldVNO6.Visible = False
        '
        'fieldVNO7
        '
        Me.fieldVNO7.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldVNO7.AreaIndex = 1
        Me.fieldVNO7.Caption = "ANO7€"
        Me.fieldVNO7.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO7.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO7.FieldName = "VNO7"
        Me.fieldVNO7.Name = "fieldVNO7"
        Me.fieldVNO7.Visible = False
        '
        'fieldVNO8
        '
        Me.fieldVNO8.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldVNO8.AreaIndex = 1
        Me.fieldVNO8.Caption = "ANO8€"
        Me.fieldVNO8.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO8.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO8.FieldName = "VNO8"
        Me.fieldVNO8.Name = "fieldVNO8"
        Me.fieldVNO8.Visible = False
        '
        'fieldVNO9
        '
        Me.fieldVNO9.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldVNO9.AreaIndex = 1
        Me.fieldVNO9.Caption = "ANO9€"
        Me.fieldVNO9.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO9.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO9.FieldName = "VNO9"
        Me.fieldVNO9.Name = "fieldVNO9"
        Me.fieldVNO9.Visible = False
        '
        'fieldVNO10
        '
        Me.fieldVNO10.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldVNO10.AreaIndex = 1
        Me.fieldVNO10.Caption = "ANO10€"
        Me.fieldVNO10.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO10.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO10.FieldName = "VNO10"
        Me.fieldVNO10.Name = "fieldVNO10"
        Me.fieldVNO10.Visible = False
        '
        'fieldVNO11
        '
        Me.fieldVNO11.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldVNO11.AreaIndex = 1
        Me.fieldVNO11.Caption = "ANO11€"
        Me.fieldVNO11.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO11.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO11.FieldName = "VNO11"
        Me.fieldVNO11.Name = "fieldVNO11"
        Me.fieldVNO11.Visible = False
        '
        'filenamexml
        '
        Me.filenamexml.Filter = "Layout files|IVDP*.xml"
        Me.filenamexml.InitialDirectory = "c:\CommercialSystem\dados"
        Me.filenamexml.RestoreDirectory = True
        '
        'savefilexml
        '
        Me.savefilexml.DefaultExt = "*.xml"
        Me.savefilexml.Filter = "Layout files|IVDP*.xml"
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
        Me.RibbonPageLayout.ItemLinks.Add(Me.BarSubItem1, False, "", "", True)
        Me.RibbonPageLayout.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageLayout.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageLayout.Name = "RibbonPageLayout"
        Me.RibbonPageLayout.ShowCaptionButton = False
        Me.RibbonPageLayout.Text = "Layout"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Escolha..."
        Me.BarSubItem1.Id = 63
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonIVDPCompany), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonIVDPGroup), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonIVDPMarketStatistics), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonIVDPMarketShareCountry), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonIVDPOrigem), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonIVDPSubcat), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonIVDPTipo), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonIVDPTotal)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonIVDPCompany
        '
        Me.BarButtonIVDPCompany.Caption = "Trade/SFE Companies"
        Me.BarButtonIVDPCompany.Id = 64
        Me.BarButtonIVDPCompany.Name = "BarButtonIVDPCompany"
        '
        'BarButtonIVDPGroup
        '
        Me.BarButtonIVDPGroup.Caption = "Trade/SFE by Group"
        Me.BarButtonIVDPGroup.Id = 65
        Me.BarButtonIVDPGroup.Name = "BarButtonIVDPGroup"
        Me.BarButtonIVDPGroup.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonIVDPMarketStatistics
        '
        Me.BarButtonIVDPMarketStatistics.Caption = "Trade/SFE Companies Share"
        Me.BarButtonIVDPMarketStatistics.Id = 66
        Me.BarButtonIVDPMarketStatistics.Name = "BarButtonIVDPMarketStatistics"
        Me.BarButtonIVDPMarketStatistics.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonIVDPMarketShareCountry
        '
        Me.BarButtonIVDPMarketShareCountry.Caption = "Trade/SFE Market Share"
        Me.BarButtonIVDPMarketShareCountry.Id = 67
        Me.BarButtonIVDPMarketShareCountry.Name = "BarButtonIVDPMarketShareCountry"
        Me.BarButtonIVDPMarketShareCountry.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonIVDPOrigem
        '
        Me.BarButtonIVDPOrigem.Caption = "Trade/SFE Top 10 Markets"
        Me.BarButtonIVDPOrigem.Id = 68
        Me.BarButtonIVDPOrigem.Name = "BarButtonIVDPOrigem"
        '
        'BarButtonIVDPSubcat
        '
        Me.BarButtonIVDPSubcat.Caption = "Trade/SFE by Subcat"
        Me.BarButtonIVDPSubcat.Id = 69
        Me.BarButtonIVDPSubcat.Name = "BarButtonIVDPSubcat"
        '
        'BarButtonIVDPTipo
        '
        Me.BarButtonIVDPTipo.Caption = "Trade/SFE by Type"
        Me.BarButtonIVDPTipo.Id = 70
        Me.BarButtonIVDPTipo.Name = "BarButtonIVDPTipo"
        '
        'BarButtonIVDPTotal
        '
        Me.BarButtonIVDPTotal.Caption = "Trade Historic"
        Me.BarButtonIVDPTotal.Id = 71
        Me.BarButtonIVDPTotal.Name = "BarButtonIVDPTotal"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Save Layout"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.LargeImageIndex = 2
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Restore Layout"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.LargeImageIndex = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        ToolTipItem2.Text = "teste"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.BarButtonItem2.SuperTip = SuperToolTip2
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
        Me.BarButtonItem8.LargeImageIndex = 7
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Export to Pdf"
        Me.BarButtonItem7.Id = 38
        Me.BarButtonItem7.LargeImageIndex = 6
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Export to Excel"
        Me.BarButtonItem6.Id = 37
        Me.BarButtonItem6.LargeImageIndex = 5
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Print"
        Me.BarButtonItem3.Id = 35
        Me.BarButtonItem3.LargeImageIndex = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonPrintPreview
        '
        Me.BarButtonPrintPreview.Caption = "Print Preview"
        Me.BarButtonPrintPreview.Id = 36
        Me.BarButtonPrintPreview.LargeImageIndex = 4
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
        Me.BarEditItem1.Id = 52
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 200
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
        Me.BarButtonItem4.LargeImageIndex = 0
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
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem4, Me.BarButtonItem3, Me.BarButtonPrintPreview, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.Top5, Me.Top10, Me.NOTOP, Me.BarEditItem1, Me.BtConditionalFormat, Me.BarCheckItem1, Me.RibbonGalleryBarItem1, Me.BarSubItem1, Me.BarButtonIVDPCompany, Me.BarButtonIVDPGroup, Me.BarButtonIVDPMarketStatistics, Me.BarButtonIVDPMarketShareCountry, Me.BarButtonIVDPOrigem, Me.BarButtonIVDPSubcat, Me.BarButtonIVDPTipo, Me.BarButtonIVDPTotal})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.RibbonControl1.MaxItemId = 72
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(870, 131)
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
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 131)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PivotGridControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ChartControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(870, 433)
        Me.SplitContainerControl1.SplitterPosition = 147
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ChartControl1
        '
        Me.ChartControl1.DataAdapter = Me.SapIVDPTableAdapter
        Me.ChartControl1.DataSource = Me.PivotGridControl1
#Disable Warning BC40000 ' 'Public Overloads Property AlwaysShowZeroLevel As Boolean' is obsolete: 'This property is obsolete now. Use AxisBase.WholeRange.AlwaysShowZeroLevel instead.'.
#Disable Warning BC40000 ' 'Public Overloads ReadOnly Property Range As AxisRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation.'.
        XyDiagram2.AxisX.Range.AlwaysShowZeroLevel = True
#Enable Warning BC40000 ' 'Public Overloads ReadOnly Property Range As AxisRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation.'.
#Enable Warning BC40000 ' 'Public Overloads Property AlwaysShowZeroLevel As Boolean' is obsolete: 'This property is obsolete now. Use AxisBase.WholeRange.AlwaysShowZeroLevel instead.'.
#Disable Warning BC40000 ' 'Public Overloads ReadOnly Property ScrollingRange As ScrollingRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation. '.
#Disable Warning BC40000 ' 'Public Overloads ReadOnly Property Range As AxisRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation.'.
        XyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
#Enable Warning BC40000 ' 'Public Overloads ReadOnly Property Range As AxisRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation.'.
#Enable Warning BC40000 ' 'Public Overloads ReadOnly Property ScrollingRange As ScrollingRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation. '.
#Disable Warning BC40000 ' 'Public Overloads Property SideMarginsEnabled As Boolean' is obsolete: 'This property is obsolete now. Use AxisBase.VisualRange.AutoSideMargins instead. To calculate side margins automatically, enable the VisualRange.AutoSideMargins property. When the VisualRange.AutoSideMargins property is disabled it becomes possible to specify custom side margins values using the VisualRange.SideMarginsValue property.'.
#Disable Warning BC40000 ' 'Public Overloads ReadOnly Property Range As AxisRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation.'.
        XyDiagram2.AxisX.Range.SideMarginsEnabled = True
#Enable Warning BC40000 ' 'Public Overloads ReadOnly Property Range As AxisRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation.'.
#Enable Warning BC40000 ' 'Public Overloads Property SideMarginsEnabled As Boolean' is obsolete: 'This property is obsolete now. Use AxisBase.VisualRange.AutoSideMargins instead. To calculate side margins automatically, enable the VisualRange.AutoSideMargins property. When the VisualRange.AutoSideMargins property is disabled it becomes possible to specify custom side margins values using the VisualRange.SideMarginsValue property.'.
        XyDiagram2.AxisX.Title.Text = "Market"
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
#Disable Warning BC40000 ' 'Public Overloads Property AlwaysShowZeroLevel As Boolean' is obsolete: 'This property is obsolete now. Use AxisBase.WholeRange.AlwaysShowZeroLevel instead.'.
#Disable Warning BC40000 ' 'Public Overloads ReadOnly Property Range As AxisRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation.'.
        XyDiagram2.AxisY.Range.AlwaysShowZeroLevel = True
#Enable Warning BC40000 ' 'Public Overloads ReadOnly Property Range As AxisRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation.'.
#Enable Warning BC40000 ' 'Public Overloads Property AlwaysShowZeroLevel As Boolean' is obsolete: 'This property is obsolete now. Use AxisBase.WholeRange.AlwaysShowZeroLevel instead.'.
#Disable Warning BC40000 ' 'Public Overloads ReadOnly Property ScrollingRange As ScrollingRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation. '.
#Disable Warning BC40000 ' 'Public Overloads ReadOnly Property Range As AxisRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation.'.
        XyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
#Enable Warning BC40000 ' 'Public Overloads ReadOnly Property Range As AxisRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation.'.
#Enable Warning BC40000 ' 'Public Overloads ReadOnly Property ScrollingRange As ScrollingRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation. '.
#Disable Warning BC40000 ' 'Public Overloads Property SideMarginsEnabled As Boolean' is obsolete: 'This property is obsolete now. Use AxisBase.VisualRange.AutoSideMargins instead. To calculate side margins automatically, enable the VisualRange.AutoSideMargins property. When the VisualRange.AutoSideMargins property is disabled it becomes possible to specify custom side margins values using the VisualRange.SideMarginsValue property.'.
#Disable Warning BC40000 ' 'Public Overloads ReadOnly Property Range As AxisRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation.'.
        XyDiagram2.AxisY.Range.SideMarginsEnabled = True
#Enable Warning BC40000 ' 'Public Overloads ReadOnly Property Range As AxisRange' is obsolete: 'This property is obsolete now. To specify a custom range, use the AxisBase.VisualRange and AxisBase.WholeRange properties instead. For more information, see the corresponding topic in the documentation.'.
#Enable Warning BC40000 ' 'Public Overloads Property SideMarginsEnabled As Boolean' is obsolete: 'This property is obsolete now. Use AxisBase.VisualRange.AutoSideMargins instead. To calculate side margins automatically, enable the VisualRange.AutoSideMargins property. When the VisualRange.AutoSideMargins property is disabled it becomes possible to specify custom side margins values using the VisualRange.SideMarginsValue property.'.
        XyDiagram2.AxisY.Title.Text = "ANO1"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram2.EnableAxisXScrolling = True
        XyDiagram2.EnableAxisXZooming = True
        XyDiagram2.EnableAxisYScrolling = True
        XyDiagram2.EnableAxisYZooming = True
        Me.ChartControl1.Diagram = XyDiagram2
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.MaxHorizontalPercentage = 30.0R
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesDataMember = "Series"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
        Me.ChartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        PointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PointOptions2.ValueNumericOptions.Precision = 0
#Disable Warning BC40000 ' 'Public Overloads Property PointOptions As PointOptions' is obsolete: 'This property is obsolete now. Use the TextPattern property instead.'.
        SideBySideBarSeriesLabel2.PointOptions = PointOptions2
#Enable Warning BC40000 ' 'Public Overloads Property PointOptions As PointOptions' is obsolete: 'This property is obsolete now. Use the TextPattern property instead.'.
        SideBySideBarSeriesLabel2.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.TopInside
        SideBySideBarSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        Me.ChartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.ChartControl1.Size = New System.Drawing.Size(870, 147)
        Me.ChartControl1.TabIndex = 0
        '
        'SapIVDPTableAdapter
        '
        Me.SapIVDPTableAdapter.ClearBeforeFill = True
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Id = -1
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Id = -1
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'FormPivotTrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 564)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FormPivotTrade"
        Me.Ribbon = Me.RibbonControl1
        Me.Text = "Trade Statistics"
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapIVDPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IvpDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    '  Friend WithEvents SapIVDPTableAdapter As CommercialSystem.ivpDataSetTableAdapters.sapIVDPTableAdapter
    Friend WithEvents IvpDataSet1 As CommercialSystem.ivpDataSet
    Friend WithEvents SapIVDPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents fieldANO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldano As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonIVDPCompany As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonIVDPGroup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonIVDPMarketStatistics As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonIVDPMarketShareCountry As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonIVDPOrigem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonIVDPSubcat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonIVDPTipo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonIVDPTotal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents fieldorigem As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDirector As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldpais As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldcompany As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldmarca As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTipo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGrupo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSubcat As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVNO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SapIVDPTableAdapter As CommercialSystem.ivpDataSetTableAdapters.sapIVDPTableAdapter
    Friend WithEvents fieldVNO2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVNO3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVNO4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVNO5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVNO6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVNO7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVNO8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVNO9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVNO10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVNO11 As DevExpress.XtraPivotGrid.PivotGridField


End Class
