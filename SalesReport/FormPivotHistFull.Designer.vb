<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPivotHistFull
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPivotHistFull))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
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
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.SalesHistoricoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapCSDataSet = New SapCSDataSet()
        Me.fieldDirector = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSalesManager = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSecretaria = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPais = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPaisDest = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPaisFact = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCliente = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldClienteDest = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldClienteFact = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCompany = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSUBCATID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGRUPO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANOCOL = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMarca = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSUBCAT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFamilia = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEmbalagem = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProduto = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVintage = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCodigo = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCodCli = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCodCliDest = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCodCliFact = New DevExpress.XtraPivotGrid.PivotGridField()
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
        Me.fieldANO11 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPortConsumoBrandy = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBRSCH = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.filenamexml = New System.Windows.Forms.OpenFileDialog()
        Me.savefilexml = New System.Windows.Forms.SaveFileDialog()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.Tools = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Top5 = New DevExpress.XtraBars.BarCheckItem()
        Me.Top10 = New DevExpress.XtraBars.BarCheckItem()
        Me.NOTOP = New DevExpress.XtraBars.BarCheckItem()
        Me.OptionsGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BtConditionalFormat = New DevExpress.XtraBars.BarButtonItem()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.Layoutapplied = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinsGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.SalesHistoricoTableAdapter = New SapCSDataSetTableAdapters.SalesHistoricoTableAdapter()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesHistoricoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapCSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fieldVNO1
        '
        Me.fieldVNO1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldVNO1.AreaIndex = 9
        Me.fieldVNO1.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO1.FieldName = "VNO1"
        Me.fieldVNO1.MinWidth = 50
        Me.fieldVNO1.Name = "fieldVNO1"
        Me.fieldVNO1.TotalCellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO1.TotalValueFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO1.ValueFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldVNO1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldVNO2
        '
        Me.fieldVNO2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldVNO2.AreaIndex = 7
        Me.fieldVNO2.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO2.FieldName = "VNO2"
        Me.fieldVNO2.MinWidth = 50
        Me.fieldVNO2.Name = "fieldVNO2"
        Me.fieldVNO2.TotalCellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO2.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO2.TotalValueFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO2.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO2.ValueFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldVNO2.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldVNO3
        '
        Me.fieldVNO3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldVNO3.AreaIndex = 5
        Me.fieldVNO3.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO3.FieldName = "VNO3"
        Me.fieldVNO3.MinWidth = 50
        Me.fieldVNO3.Name = "fieldVNO3"
        Me.fieldVNO3.TotalCellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO3.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO3.TotalValueFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO3.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO3.ValueFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldVNO3.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldVNO4
        '
        Me.fieldVNO4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldVNO4.AreaIndex = 3
        Me.fieldVNO4.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO4.FieldName = "VNO4"
        Me.fieldVNO4.MinWidth = 50
        Me.fieldVNO4.Name = "fieldVNO4"
        Me.fieldVNO4.TotalCellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO4.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO4.TotalValueFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO4.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO4.ValueFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldVNO4.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldVNO5
        '
        Me.fieldVNO5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldVNO5.AreaIndex = 1
        Me.fieldVNO5.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO5.FieldName = "VNO5"
        Me.fieldVNO5.MinWidth = 50
        Me.fieldVNO5.Name = "fieldVNO5"
        Me.fieldVNO5.TotalCellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO5.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO5.TotalValueFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO5.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO5.ValueFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldVNO5.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldVNO6
        '
        Me.fieldVNO6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldVNO6.AreaIndex = 21
        Me.fieldVNO6.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO6.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO6.FieldName = "VNO6"
        Me.fieldVNO6.MinWidth = 50
        Me.fieldVNO6.Name = "fieldVNO6"
        Me.fieldVNO6.TotalCellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO6.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO6.TotalValueFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO6.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO6.ValueFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldVNO6.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO6.Visible = False
        '
        'fieldVNO7
        '
        Me.fieldVNO7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldVNO7.AreaIndex = 19
        Me.fieldVNO7.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO7.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO7.FieldName = "VNO7"
        Me.fieldVNO7.MinWidth = 50
        Me.fieldVNO7.Name = "fieldVNO7"
        Me.fieldVNO7.TotalCellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO7.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO7.TotalValueFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO7.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO7.ValueFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldVNO7.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO7.Visible = False
        '
        'fieldVNO8
        '
        Me.fieldVNO8.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldVNO8.AreaIndex = 17
        Me.fieldVNO8.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO8.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO8.FieldName = "VNO8"
        Me.fieldVNO8.MinWidth = 50
        Me.fieldVNO8.Name = "fieldVNO8"
        Me.fieldVNO8.TotalCellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO8.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO8.TotalValueFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO8.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO8.ValueFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldVNO8.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO8.Visible = False
        '
        'fieldVNO9
        '
        Me.fieldVNO9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldVNO9.AreaIndex = 15
        Me.fieldVNO9.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO9.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO9.FieldName = "VNO9"
        Me.fieldVNO9.MinWidth = 50
        Me.fieldVNO9.Name = "fieldVNO9"
        Me.fieldVNO9.TotalCellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO9.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO9.TotalValueFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO9.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO9.ValueFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldVNO9.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO9.Visible = False
        '
        'fieldVNO10
        '
        Me.fieldVNO10.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldVNO10.AreaIndex = 13
        Me.fieldVNO10.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO10.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO10.FieldName = "VNO10"
        Me.fieldVNO10.MinWidth = 50
        Me.fieldVNO10.Name = "fieldVNO10"
        Me.fieldVNO10.TotalCellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO10.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO10.TotalValueFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO10.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO10.ValueFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldVNO10.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO10.Visible = False
        '
        'fieldVNO11
        '
        Me.fieldVNO11.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldVNO11.AreaIndex = 11
        Me.fieldVNO11.CellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO11.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO11.FieldName = "VNO11"
        Me.fieldVNO11.MinWidth = 50
        Me.fieldVNO11.Name = "fieldVNO11"
        Me.fieldVNO11.TotalCellFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO11.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO11.TotalValueFormat.FormatString = "#,##0 €;-#,##0 €;-"
        Me.fieldVNO11.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO11.ValueFormat.FormatString = "#,##0.0 €;-#,##0.0 €;-"
        Me.fieldVNO11.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldVNO11.Visible = False
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.AppearancePrint.FieldValueTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridControl1.AppearancePrint.FieldValueTotal.Options.UseFont = True
        Me.PivotGridControl1.AppearancePrint.FieldValueTotal.Options.UseTextOptions = True
        Me.PivotGridControl1.AppearancePrint.FieldValueTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridControl1.AppearancePrint.FieldValueTotal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisPath
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.DataSource = Me.SalesHistoricoBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldDirector, Me.fieldSalesManager, Me.fieldSecretaria, Me.fieldPais, Me.fieldPaisDest, Me.fieldPaisFact, Me.fieldCliente, Me.fieldClienteDest, Me.fieldClienteFact, Me.fieldCompany, Me.fieldSUBCATID, Me.fieldGRUPO, Me.fieldANOCOL, Me.fieldMarca, Me.fieldSUBCAT, Me.fieldTIPO, Me.fieldFamilia, Me.fieldEmbalagem, Me.fieldProduto, Me.fieldVintage, Me.fieldCodigo, Me.fieldCodCli, Me.fieldCodCliDest, Me.fieldCodCliFact, Me.fieldANO1, Me.fieldANO2, Me.fieldANO3, Me.fieldANO4, Me.fieldANO5, Me.fieldANO6, Me.fieldANO7, Me.fieldANO8, Me.fieldANO9, Me.fieldANO10, Me.fieldANO11, Me.fieldVNO1, Me.fieldVNO2, Me.fieldVNO3, Me.fieldVNO4, Me.fieldVNO5, Me.fieldVNO6, Me.fieldVNO7, Me.fieldVNO8, Me.fieldVNO9, Me.fieldVNO10, Me.fieldVNO11, Me.fieldPortConsumoBrandy, Me.fieldANO, Me.fieldBRSCH})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 131)
        Me.PivotGridControl1.LookAndFeel.SkinName = "Lilian"
        Me.PivotGridControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsBehavior.ApplyBestFitOnFieldDragging = True
        Me.PivotGridControl1.OptionsBehavior.BestFitMode = DevExpress.XtraPivotGrid.PivotGridBestFitMode.Cell
        Me.PivotGridControl1.OptionsCustomization.AllowEdit = False
        Me.PivotGridControl1.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Always
        Me.PivotGridControl1.OptionsData.DataFieldUnboundExpressionMode = DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues
        Me.PivotGridControl1.OptionsFilterPopup.FieldFilterPopupMode = DevExpress.XtraPivotGrid.FieldFilterPopupMode.Excel
        Me.PivotGridControl1.OptionsFilterPopup.ShowOnlyAvailableItems = True
        Me.PivotGridControl1.OptionsFilterPopup.ToolbarButtons = CType((DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.ShowOnlyAvailableItems Or DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.InvertFilter), DevExpress.XtraPivotGrid.FilterPopupToolbarButtons)
        Me.PivotGridControl1.OptionsLayout.Columns.StoreAllOptions = True
        Me.PivotGridControl1.OptionsLayout.Columns.StoreAppearance = True
        Me.PivotGridControl1.OptionsLayout.StoreAppearance = True
        Me.PivotGridControl1.OptionsLayout.StoreDataSettings = False
        Me.PivotGridControl1.OptionsPrint.PageSettings.Landscape = True
        Me.PivotGridControl1.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintHeadersOnEveryPage = True
        Me.PivotGridControl1.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.UsePrintAppearance = True
        Me.PivotGridControl1.OptionsSelection.EnableAppearanceFocusedCell = True
        Me.PivotGridControl1.OptionsView.ShowGrandTotalsForSingleValues = True
        Me.PivotGridControl1.Size = New System.Drawing.Size(880, 438)
        Me.PivotGridControl1.TabIndex = 0
        '
        'SalesHistoricoBindingSource
        '
        Me.SalesHistoricoBindingSource.DataMember = "SalesHistorico"
        Me.SalesHistoricoBindingSource.DataSource = Me.SapCSDataSet
        '
        'SapCSDataSet
        '
        Me.SapCSDataSet.DataSetName = "SapCSDataSet"
        Me.SapCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldDirector
        '
        Me.fieldDirector.AreaIndex = 0
        Me.fieldDirector.Caption = "Director"
        Me.fieldDirector.FieldName = "Director"
        Me.fieldDirector.Name = "fieldDirector"
        Me.fieldDirector.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldSalesManager
        '
        Me.fieldSalesManager.AreaIndex = 1
        Me.fieldSalesManager.Caption = "Market Manager"
        Me.fieldSalesManager.FieldName = "SalesManager"
        Me.fieldSalesManager.Name = "fieldSalesManager"
        Me.fieldSalesManager.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldSecretaria
        '
        Me.fieldSecretaria.AreaIndex = 2
        Me.fieldSecretaria.Caption = "Market Assistant"
        Me.fieldSecretaria.FieldName = "Secretaria"
        Me.fieldSecretaria.Name = "fieldSecretaria"
        Me.fieldSecretaria.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldPais
        '
        Me.fieldPais.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldPais.AreaIndex = 0
        Me.fieldPais.Caption = "Stats Market"
        Me.fieldPais.FieldName = "Pais"
        Me.fieldPais.Name = "fieldPais"
        Me.fieldPais.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldPaisDest
        '
        Me.fieldPaisDest.AreaIndex = 14
        Me.fieldPaisDest.Caption = "Final Market"
        Me.fieldPaisDest.FieldName = "PaisDest"
        Me.fieldPaisDest.Name = "fieldPaisDest"
        Me.fieldPaisDest.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldPaisFact
        '
        Me.fieldPaisFact.AreaIndex = 16
        Me.fieldPaisFact.Caption = "Invoicing Market"
        Me.fieldPaisFact.FieldName = "PaisFact"
        Me.fieldPaisFact.Name = "fieldPaisFact"
        Me.fieldPaisFact.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldCliente
        '
        Me.fieldCliente.AreaIndex = 3
        Me.fieldCliente.Caption = "Stats Customer"
        Me.fieldCliente.FieldName = "Cliente"
        Me.fieldCliente.Name = "fieldCliente"
        Me.fieldCliente.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldClienteDest
        '
        Me.fieldClienteDest.AreaIndex = 15
        Me.fieldClienteDest.Caption = "Final Customer"
        Me.fieldClienteDest.FieldName = "ClienteDest"
        Me.fieldClienteDest.Name = "fieldClienteDest"
        Me.fieldClienteDest.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldClienteFact
        '
        Me.fieldClienteFact.AreaIndex = 17
        Me.fieldClienteFact.Caption = "Invoicing Customer"
        Me.fieldClienteFact.FieldName = "ClienteFact"
        Me.fieldClienteFact.Name = "fieldClienteFact"
        Me.fieldClienteFact.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldCompany
        '
        Me.fieldCompany.AreaIndex = 4
        Me.fieldCompany.Caption = "Brand"
        Me.fieldCompany.FieldName = "Company"
        Me.fieldCompany.Name = "fieldCompany"
        Me.fieldCompany.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldSUBCATID
        '
        Me.fieldSUBCATID.AreaIndex = 2
        Me.fieldSUBCATID.FieldName = "SUBCATID"
        Me.fieldSUBCATID.Name = "fieldSUBCATID"
        Me.fieldSUBCATID.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldSUBCATID.Visible = False
        '
        'fieldGRUPO
        '
        Me.fieldGRUPO.AreaIndex = 5
        Me.fieldGRUPO.Caption = "Group"
        Me.fieldGRUPO.FieldName = "GRUPO"
        Me.fieldGRUPO.Name = "fieldGRUPO"
        Me.fieldGRUPO.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldANOCOL
        '
        Me.fieldANOCOL.AreaIndex = 9
        Me.fieldANOCOL.Caption = "VintageYear"
        Me.fieldANOCOL.FieldName = "ANOCOL"
        Me.fieldANOCOL.Name = "fieldANOCOL"
        Me.fieldANOCOL.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldMarca
        '
        Me.fieldMarca.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMarca.AreaIndex = 1
        Me.fieldMarca.Caption = "Trademark"
        Me.fieldMarca.FieldName = "Marca"
        Me.fieldMarca.Name = "fieldMarca"
        Me.fieldMarca.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldMarca.Width = 79
        '
        'fieldSUBCAT
        '
        Me.fieldSUBCAT.AreaIndex = 7
        Me.fieldSUBCAT.Caption = "Category"
        Me.fieldSUBCAT.FieldName = "SUBCAT"
        Me.fieldSUBCAT.Name = "fieldSUBCAT"
        Me.fieldSUBCAT.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldTIPO
        '
        Me.fieldTIPO.AreaIndex = 6
        Me.fieldTIPO.Caption = "Type"
        Me.fieldTIPO.FieldName = "TIPO"
        Me.fieldTIPO.Name = "fieldTIPO"
        Me.fieldTIPO.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldFamilia
        '
        Me.fieldFamilia.AreaIndex = 8
        Me.fieldFamilia.Caption = "Family"
        Me.fieldFamilia.FieldName = "Familia"
        Me.fieldFamilia.Name = "fieldFamilia"
        Me.fieldFamilia.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldEmbalagem
        '
        Me.fieldEmbalagem.AreaIndex = 10
        Me.fieldEmbalagem.Caption = "Package"
        Me.fieldEmbalagem.FieldName = "Embalagem"
        Me.fieldEmbalagem.Name = "fieldEmbalagem"
        Me.fieldEmbalagem.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldEmbalagem.Width = 70
        '
        'fieldProduto
        '
        Me.fieldProduto.AreaIndex = 13
        Me.fieldProduto.Caption = "Material Name"
        Me.fieldProduto.FieldName = "Produto"
        Me.fieldProduto.Name = "fieldProduto"
        Me.fieldProduto.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldVintage
        '
        Me.fieldVintage.AreaIndex = 11
        'Me.fieldVintage.Caption = "Vintage/NonVint"
        Me.fieldVintage.Caption = "Wood/Bottle Matured"
        Me.fieldVintage.Name = "fieldVintage"
        Me.fieldVintage.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldVintage.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.fieldVintage.UnboundFieldName = "fieldVintage"
        Me.fieldVintage.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'fieldCodigo
        '
        Me.fieldCodigo.AreaIndex = 14
        Me.fieldCodigo.Caption = "Material Number"
        Me.fieldCodigo.FieldName = "Codigo"
        Me.fieldCodigo.Name = "fieldCodigo"
        Me.fieldCodigo.Visible = False
        '
        'fieldCodCli
        '
        Me.fieldCodCli.AreaIndex = 17
        Me.fieldCodCli.Caption = "Stats Customer Num"
        Me.fieldCodCli.FieldName = "CodCli"
        Me.fieldCodCli.Name = "fieldCodCli"
        Me.fieldCodCli.Visible = False
        '
        'fieldCodCliDest
        '
        Me.fieldCodCliDest.AreaIndex = 17
        Me.fieldCodCliDest.Caption = "Final Customer Num"
        Me.fieldCodCliDest.FieldName = "CodCliDest"
        Me.fieldCodCliDest.Name = "fieldCodCliDest"
        Me.fieldCodCliDest.Visible = False
        '
        'fieldCodCliFact
        '
        Me.fieldCodCliFact.AreaIndex = 17
        Me.fieldCodCliFact.Caption = "Inv Customer Num"
        Me.fieldCodCliFact.FieldName = "CodCliFact"
        Me.fieldCodCliFact.Name = "fieldCodCliFact"
        Me.fieldCodCliFact.Visible = False
        '
        'fieldANO1
        '
        Me.fieldANO1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO1.AreaIndex = 8
        Me.fieldANO1.CellFormat.FormatString = "#,##0;-#,##0;-"
        Me.fieldANO1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO1.FieldName = "ANO1"
        Me.fieldANO1.MinWidth = 50
        Me.fieldANO1.Name = "fieldANO1"
        '
        'fieldANO2
        '
        Me.fieldANO2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO2.AreaIndex = 6
        Me.fieldANO2.CellFormat.FormatString = "#,##0;-#,##0;-"
        Me.fieldANO2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO2.FieldName = "ANO2"
        Me.fieldANO2.MinWidth = 50
        Me.fieldANO2.Name = "fieldANO2"
        '
        'fieldANO3
        '
        Me.fieldANO3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO3.AreaIndex = 4
        Me.fieldANO3.CellFormat.FormatString = "#,##0;-#,##0;-"
        Me.fieldANO3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO3.FieldName = "ANO3"
        Me.fieldANO3.MinWidth = 50
        Me.fieldANO3.Name = "fieldANO3"
        '
        'fieldANO4
        '
        Me.fieldANO4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO4.AreaIndex = 2
        Me.fieldANO4.CellFormat.FormatString = "#,##0;-#,##0;-"
        Me.fieldANO4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO4.FieldName = "ANO4"
        Me.fieldANO4.MinWidth = 50
        Me.fieldANO4.Name = "fieldANO4"
        '
        'fieldANO5
        '
        Me.fieldANO5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO5.AreaIndex = 0
        Me.fieldANO5.CellFormat.FormatString = "#,##0;-#,##0;-"
        Me.fieldANO5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO5.FieldName = "ANO5"
        Me.fieldANO5.MinWidth = 50
        Me.fieldANO5.Name = "fieldANO5"
        '
        'fieldANO6
        '
        Me.fieldANO6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO6.AreaIndex = 5
        Me.fieldANO6.CellFormat.FormatString = "#,##0;-#,##0;-"
        Me.fieldANO6.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO6.FieldName = "ANO6"
        Me.fieldANO6.MinWidth = 50
        Me.fieldANO6.Name = "fieldANO6"
        Me.fieldANO6.Visible = False
        '
        'fieldANO7
        '
        Me.fieldANO7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO7.AreaIndex = 4
        Me.fieldANO7.CellFormat.FormatString = "#,##0;-#,##0;-"
        Me.fieldANO7.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO7.FieldName = "ANO7"
        Me.fieldANO7.MinWidth = 50
        Me.fieldANO7.Name = "fieldANO7"
        Me.fieldANO7.Visible = False
        '
        'fieldANO8
        '
        Me.fieldANO8.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO8.AreaIndex = 3
        Me.fieldANO8.CellFormat.FormatString = "#,##0;-#,##0;-"
        Me.fieldANO8.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO8.FieldName = "ANO8"
        Me.fieldANO8.MinWidth = 50
        Me.fieldANO8.Name = "fieldANO8"
        Me.fieldANO8.Visible = False
        '
        'fieldANO9
        '
        Me.fieldANO9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO9.AreaIndex = 2
        Me.fieldANO9.CellFormat.FormatString = "#,##0;-#,##0;-"
        Me.fieldANO9.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO9.FieldName = "ANO9"
        Me.fieldANO9.MinWidth = 50
        Me.fieldANO9.Name = "fieldANO9"
        Me.fieldANO9.Visible = False
        '
        'fieldANO10
        '
        Me.fieldANO10.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO10.AreaIndex = 1
        Me.fieldANO10.CellFormat.FormatString = "#,##0;-#,##0;-"
        Me.fieldANO10.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO10.FieldName = "ANO10"
        Me.fieldANO10.MinWidth = 50
        Me.fieldANO10.Name = "fieldANO10"
        Me.fieldANO10.Visible = False
        '
        'fieldANO11
        '
        Me.fieldANO11.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldANO11.AreaIndex = 0
        Me.fieldANO11.CellFormat.FormatString = "#,##0;-#,##0;-"
        Me.fieldANO11.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldANO11.FieldName = "ANO11"
        Me.fieldANO11.MinWidth = 50
        Me.fieldANO11.Name = "fieldANO11"
        Me.fieldANO11.Visible = False
        '
        'fieldPortConsumoBrandy
        '
        Me.fieldPortConsumoBrandy.AreaIndex = 12
        Me.fieldPortConsumoBrandy.Caption = "Port/Consumo/Brandy"
        Me.fieldPortConsumoBrandy.Name = "fieldPortConsumoBrandy"
        Me.fieldPortConsumoBrandy.UnboundFieldName = "fieldPortConsumoBrandy"
        Me.fieldPortConsumoBrandy.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'fieldANO
        '
        Me.fieldANO.AreaIndex = 18
        Me.fieldANO.FieldName = "ANO"
        Me.fieldANO.Name = "fieldANO"
        Me.fieldANO.Options.ShowInCustomizationForm = False
        Me.fieldANO.Visible = False
        '
        'fieldBRSCH
        '
        Me.fieldBRSCH.AreaIndex = 18
        Me.fieldBRSCH.FieldName = "BRSCH"
        Me.fieldBRSCH.Name = "fieldBRSCH"
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.LookAndFeel.SkinName = "Lilian"
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
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
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 30, 50)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
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
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.Tools, Me.RibbonPageGroup4, Me.OptionsGroup, Me.Layoutapplied, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Menu"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Filters applied"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Layout"
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
        ToolTipItem1.Text = "teste"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.BarButtonItem2.SuperTip = SuperToolTip1
        '
        'Tools
        '
        Me.Tools.ItemLinks.Add(Me.BarButtonItem8)
        Me.Tools.ItemLinks.Add(Me.BarButtonItem7)
        Me.Tools.ItemLinks.Add(Me.BarButtonItem6)
        Me.Tools.ItemLinks.Add(Me.BarButtonItem3)
        Me.Tools.ItemLinks.Add(Me.BarButtonItem5)
        Me.Tools.Name = "Tools"
        Me.Tools.ShowCaptionButton = False
        Me.Tools.Text = "Tools"
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
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Print Preview"
        Me.BarButtonItem5.Id = 36
        Me.BarButtonItem5.LargeImageIndex = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.Top5)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.Top10)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.NOTOP)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Top Values"
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
        'OptionsGroup
        '
        Me.OptionsGroup.AllowMinimize = False
        Me.OptionsGroup.ItemLinks.Add(Me.BtConditionalFormat)
        Me.OptionsGroup.ItemLinks.Add(Me.BarCheckItem1)
        Me.OptionsGroup.Name = "OptionsGroup"
        Me.OptionsGroup.ShowCaptionButton = False
        Me.OptionsGroup.Text = "Options"
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
        'Layoutapplied
        '
        Me.Layoutapplied.AllowMinimize = False
        Me.Layoutapplied.ItemLinks.Add(Me.BarEditItem1)
        Me.Layoutapplied.Name = "Layoutapplied"
        Me.Layoutapplied.ShowCaptionButton = False
        Me.Layoutapplied.Text = "Layout applied"
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
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
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
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RepositoryItemTextEdit1.Appearance.Options.UseFont = True
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.AutoSizeItems = True
        Me.RibbonControl1.Controller = Me.BarAndDockingController1
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem4, Me.BarButtonItem3, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.Top5, Me.Top10, Me.NOTOP, Me.BarEditItem1, Me.BtConditionalFormat, Me.BarCheckItem1, Me.RibbonGalleryBarItem1})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.RibbonControl1.MaxItemId = 55
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemCheckEdit3, Me.RepositoryItemTextEdit2})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(880, 131)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.SkinsGroup})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Visuals"
        '
        'SalesHistoricoTableAdapter
        '
        Me.SalesHistoricoTableAdapter.ClearBeforeFill = True
        '
        'FormPivotHistFull
        '
        Me.ClientSize = New System.Drawing.Size(880, 569)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FormPivotHistFull"
        Me.Ribbon = Me.RibbonControl1
        Me.Text = "Sales Historic"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesHistoricoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapCSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents VendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldSUBCAT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFamilia As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents fieldVintage As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents filenamexml As System.Windows.Forms.OpenFileDialog
    Friend WithEvents savefilexml As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Tools As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Top5 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Top10 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents NOTOP As DevExpress.XtraBars.BarCheckItem
    Private WithEvents Layoutapplied As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents fieldSecretaria As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGRUPO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSalesManager As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPais As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEmbalagem As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProduto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSUBCATID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMarca As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANOCOL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDirector As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCompany As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPaisDest As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPaisFact As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldClienteDest As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldClienteFact As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCodigo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCodCli As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCodCliDest As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCodCliFact As DevExpress.XtraPivotGrid.PivotGridField
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
    Friend WithEvents fieldVNO1 As DevExpress.XtraPivotGrid.PivotGridField
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
    Friend WithEvents fieldPortConsumoBrandy As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO As DevExpress.XtraPivotGrid.PivotGridField

    Friend WithEvents Options As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents OptionsGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtConditionalFormat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Public WithEvents SkinsGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
    Friend WithEvents SapCSDataSet As SapCSDataSet
    Friend WithEvents SalesHistoricoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesHistoricoTableAdapter As SapCSDataSetTableAdapters.SalesHistoricoTableAdapter
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents fieldBRSCH As DevExpress.XtraPivotGrid.PivotGridField



End Class
