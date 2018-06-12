Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormForecastAll
    Inherits RibbonForm

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
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.CSForecast.SplashScreen1), True, True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormForecastAll))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.DiffTarget = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.iExit = New DevExpress.XtraBars.BarButtonItem()
        Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.iExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.homeRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.fileRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.skinsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.exitRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.SapForecastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colYear = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPeriod = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SapClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCodCliFact1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCodCliFact = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCodCliDest1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodCliDest = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
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
        Me.SapMateriaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SapMateriaisEmbalagemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapClientsMDMMMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapForecastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapMateriaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapMateriaisEmbalagemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapClientsMDMMMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.AutoSizeItems = True
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.iExit, Me.rgbiSkins, Me.iExcel})
        Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.Margin = New System.Windows.Forms.Padding(0)
        Me.ribbonControl.MaxItemId = 76
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.homeRibbonPage})
        Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit9, Me.RepositoryItemLookUpEdit5, Me.RepositoryItemLookUpEdit8, Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemCheckEdit1})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.ribbonControl.ShowToolbarCustomizeItem = False
        Me.ribbonControl.Size = New System.Drawing.Size(952, 131)
        Me.ribbonControl.Toolbar.ShowCustomizeItem = False
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
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
        'iExcel
        '
        Me.iExcel.Caption = "Export"
        Me.iExcel.Id = 66
        Me.iExcel.LargeImageIndex = 10
        Me.iExcel.Name = "iExcel"
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
        'homeRibbonPage
        '
        Me.homeRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.fileRibbonPageGroup, Me.skinsRibbonPageGroup, Me.exitRibbonPageGroup})
        Me.homeRibbonPage.Name = "homeRibbonPage"
        Me.homeRibbonPage.Text = "Home"
        '
        'fileRibbonPageGroup
        '
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
        'exitRibbonPageGroup
        '
        Me.exitRibbonPageGroup.ItemLinks.Add(Me.iExit)
        Me.exitRibbonPageGroup.Name = "exitRibbonPageGroup"
        Me.exitRibbonPageGroup.Text = "Exit"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        '
        'RepositoryItemLookUpEdit9
        '
        Me.RepositoryItemLookUpEdit9.AutoHeight = False
        Me.RepositoryItemLookUpEdit9.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemLookUpEdit9.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit9.Name = "RepositoryItemLookUpEdit9"
        Me.RepositoryItemLookUpEdit9.NullText = ""
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        '
        'RepositoryItemLookUpEdit8
        '
        Me.RepositoryItemLookUpEdit8.AutoHeight = False
        Me.RepositoryItemLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit8.Name = "RepositoryItemLookUpEdit8"
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"2012", "2013", "2014", "2015", "2016"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
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
        'gridControl
        '
        Me.gridControl.DataSource = Me.SapForecastBindingSource
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 131)
        Me.gridControl.MainView = Me.BandedGridView1
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemLookUpEdit7, Me.RepositoryItemLookUpEdit6, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.gridControl.Size = New System.Drawing.Size(952, 643)
        Me.gridControl.TabIndex = 1
        Me.gridControl.UseEmbeddedNavigator = True
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'SapForecastBindingSource
        '
        Me.SapForecastBindingSource.DataSource = GetType(CSForecast.SapForecast)
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.BandPanel.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2})
        Me.BandedGridView1.ColumnPanelRowHeight = 40
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colYear, Me.colPeriod, Me.GridColumn1, Me.colCodCliFact1, Me.colCodCliFact, Me.colCodCliDest1, Me.colCodCliDest, Me.colCompany, Me.colCodigo, Me.colEmbalagem, Me.colDescMaterial, Me.colTPRE, Me.colCurrency, Me.colQuarter1Value, Me.colQuarter2Value, Me.colQuarter3Value, Me.colQuarter4Value, Me.colQuarterSum, Me.colInHand, Me.ColShipped, Me.Target9L, Me.DiffFQAnt, Me.DiffTarget, Me.colFQ1, Me.colFQ2, Me.colFQ3, Me.colFQ4, Me.colAnualValue})
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.DiffTarget
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition1.Value1 = "0"
        Me.BandedGridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.BandedGridView1.GridControl = Me.gridControl
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.BandedGridView1.OptionsBehavior.Editable = False
        Me.BandedGridView1.OptionsBehavior.ImmediateUpdateRowPosition = False
        Me.BandedGridView1.OptionsBehavior.ReadOnly = True
        Me.BandedGridView1.OptionsDetail.AllowZoomDetail = False
        Me.BandedGridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.BandedGridView1.OptionsView.AllowCellMerge = True
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.BandedGridView1.OptionsView.ShowFooter = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        Me.BandedGridView1.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.BandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCodCliFact1, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCodCliDest1, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCodigo, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEmbalagem, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTPRE, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCurrency, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCodCliFact, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCompany, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDescMaterial, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "SalesUnits"
        Me.GridBand1.Columns.Add(Me.colYear)
        Me.GridBand1.Columns.Add(Me.colPeriod)
        Me.GridBand1.Columns.Add(Me.GridColumn1)
        Me.GridBand1.Columns.Add(Me.colCodCliFact1)
        Me.GridBand1.Columns.Add(Me.colCodCliFact)
        Me.GridBand1.Columns.Add(Me.colCodCliDest1)
        Me.GridBand1.Columns.Add(Me.colCodCliDest)
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
        Me.GridBand1.Width = 1075
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
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.GridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn1.Caption = "Final Market"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.GridColumn1.FieldName = "CodCliDest"
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
        'colCodCliFact1
        '
        Me.colCodCliFact1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodCliFact1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCodCliFact1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodCliFact1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodCliFact1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodCliFact1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodCliFact1.Caption = "Inv. Cust. Nº"
        Me.colCodCliFact1.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCodCliFact1.FieldName = "CodCliFact"
        Me.colCodCliFact1.Name = "colCodCliFact1"
        Me.colCodCliFact1.Visible = True
        Me.colCodCliFact1.Width = 30
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "0000000000"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colCodCliFact
        '
        Me.colCodCliFact.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodCliFact.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodCliFact.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodCliFact.Caption = "Invoice Customer"
        Me.colCodCliFact.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colCodCliFact.FieldName = "CodCliFact"
        Me.colCodCliFact.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colCodCliFact.Name = "colCodCliFact"
        Me.colCodCliFact.OptionsColumn.AllowEdit = False
        Me.colCodCliFact.OptionsColumn.ReadOnly = True
        Me.colCodCliFact.Visible = True
        Me.colCodCliFact.Width = 100
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
        'colCodCliDest1
        '
        Me.colCodCliDest1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodCliDest1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCodCliDest1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodCliDest1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodCliDest1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodCliDest1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodCliDest1.Caption = "Final Cust. Nº"
        Me.colCodCliDest1.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCodCliDest1.FieldName = "CodCliDest"
        Me.colCodCliDest1.Name = "colCodCliDest1"
        Me.colCodCliDest1.Visible = True
        Me.colCodCliDest1.Width = 30
        '
        'colCodCliDest
        '
        Me.colCodCliDest.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodCliDest.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodCliDest.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodCliDest.Caption = "Final Customer"
        Me.colCodCliDest.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colCodCliDest.FieldName = "CodCliDest"
        Me.colCodCliDest.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colCodCliDest.Name = "colCodCliDest"
        Me.colCodCliDest.OptionsColumn.AllowEdit = False
        Me.colCodCliDest.OptionsColumn.ReadOnly = True
        Me.colCodCliDest.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colCodCliDest.Visible = True
        Me.colCodCliDest.Width = 100
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
        Me.colCompany.Width = 67
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigo.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colCodigo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCodigo.Caption = "Material Nº"
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
        Me.colTPRE.Width = 30
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
        Me.colQuarter1Value.Caption = "1º Trimestre"
        Me.colQuarter1Value.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colQuarter1Value.DisplayFormat.FormatString = "#,###;-#,###;0"
        Me.colQuarter1Value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuarter1Value.FieldName = "Quarter1Value"
        Me.colQuarter1Value.Name = "colQuarter1Value"
        Me.colQuarter1Value.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colQuarter1Value.Visible = True
        Me.colQuarter1Value.Width = 50
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
        Me.colQuarter2Value.Caption = "2º Trimestre"
        Me.colQuarter2Value.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colQuarter2Value.DisplayFormat.FormatString = "#,###;-#,###;0"
        Me.colQuarter2Value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuarter2Value.FieldName = "Quarter2Value"
        Me.colQuarter2Value.Name = "colQuarter2Value"
        Me.colQuarter2Value.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colQuarter2Value.Visible = True
        Me.colQuarter2Value.Width = 50
        '
        'colQuarter3Value
        '
        Me.colQuarter3Value.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuarter3Value.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colQuarter3Value.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuarter3Value.Caption = "3º Trimestre"
        Me.colQuarter3Value.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colQuarter3Value.DisplayFormat.FormatString = "#,###;-#,###;0"
        Me.colQuarter3Value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuarter3Value.FieldName = "Quarter3Value"
        Me.colQuarter3Value.Name = "colQuarter3Value"
        Me.colQuarter3Value.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colQuarter3Value.Visible = True
        Me.colQuarter3Value.Width = 50
        '
        'colQuarter4Value
        '
        Me.colQuarter4Value.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuarter4Value.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colQuarter4Value.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuarter4Value.Caption = "4º Trimestre"
        Me.colQuarter4Value.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colQuarter4Value.DisplayFormat.FormatString = "#,###;-#,###;0"
        Me.colQuarter4Value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuarter4Value.FieldName = "Quarter4Value"
        Me.colQuarter4Value.Name = "colQuarter4Value"
        Me.colQuarter4Value.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colQuarter4Value.Visible = True
        Me.colQuarter4Value.Width = 50
        '
        'colQuarterSum
        '
        Me.colQuarterSum.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuarterSum.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colQuarterSum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuarterSum.AutoFillDown = True
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
        Me.gridBand2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gridBand2.Caption = "9L"
        Me.gridBand2.Columns.Add(Me.ColShipped)
        Me.gridBand2.Columns.Add(Me.DiffFQAnt)
        Me.gridBand2.Columns.Add(Me.DiffTarget)
        Me.gridBand2.Columns.Add(Me.Target9L)
        Me.gridBand2.Columns.Add(Me.colFQ1)
        Me.gridBand2.Columns.Add(Me.colFQ2)
        Me.gridBand2.Columns.Add(Me.colFQ3)
        Me.gridBand2.Columns.Add(Me.colFQ4)
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
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "YY"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "YY"
        Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'FormForecastAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 774)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "FormForecastAll"
        Me.Ribbon = Me.ribbonControl
        Me.Text = "Forecasts"
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapForecastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapMateriaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapMateriaisEmbalagemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapClientsMDMMMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents homeRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents fileRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents skinsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents exitRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection



    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit




    Friend WithEvents iExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SapForecastBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SapClientsMDMMMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SapClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SapMateriaisEmbalagemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SapMateriaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemLookUpEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colYear As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPeriod As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodCliFact As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodCliFact1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodCliDest1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodCliDest As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompany As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEmbalagem As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescMaterial As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTPRE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCurrency As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuarter1Value As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuarter2Value As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuarter3Value As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuarter4Value As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuarterSum As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInHand As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColShipped As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DiffTarget As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Target9L As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAnualValue As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFQ1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFQ2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFQ3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFQ4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DiffFQAnt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

End Class
