<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPivotComp
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPivotComp))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.fieldJAN = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFEV = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMAR = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldABE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMAI = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldJUN = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldJUL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldAGO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSET = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldOUT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOV = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDEZ = New DevExpress.XtraPivotGrid.PivotGridField
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.VendasportoMesCOMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New Global.CommercialSystem.DataSet1
        Me.fielddirector = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSecretari = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSalesManager = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldpais = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCliente = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldcompany = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldmarca = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldTipo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldGrupo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSubcat = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFamily = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldEmbalagem = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldTarget = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSales = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHAND = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSalesYTDLY = New DevExpress.XtraPivotGrid.PivotGridField
        Me.Dife = New DevExpress.XtraPivotGrid.PivotGridField
        Me.Difeendmonth = New DevExpress.XtraPivotGrid.PivotGridField
        Me.DifeTarget = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldJAN1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFEV1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMAR1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldABR1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMAI1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldJUN1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldJUL1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldAGO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSET1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldOUT1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOV1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDEZ1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldVintage = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPortConsumoBrandy = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldForecast = New DevExpress.XtraPivotGrid.PivotGridField
        Me.DifeForeca = New DevExpress.XtraPivotGrid.PivotGridField
        Me.DifeForecastinchand = New DevExpress.XtraPivotGrid.PivotGridField
        Me.DifeTargetincand = New DevExpress.XtraPivotGrid.PivotGridField
        Me.salesendmonth = New DevExpress.XtraPivotGrid.PivotGridField
        Me.salesendmonthLY = New DevExpress.XtraPivotGrid.PivotGridField
        Me.DifeTargetTLM = New DevExpress.XtraPivotGrid.PivotGridField
        Me.DifeForecaTLM = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSalesLY = New DevExpress.XtraPivotGrid.PivotGridField
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.filenamexml = New System.Windows.Forms.OpenFileDialog
        Me.savefilexml = New System.Windows.Forms.SaveFileDialog
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.Tools = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.Top5 = New DevExpress.XtraBars.BarCheckItem
        Me.Top10 = New DevExpress.XtraBars.BarCheckItem
        Me.NOTOP = New DevExpress.XtraBars.BarCheckItem
        Me.Layoutapplied = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasportoMesCOMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'fieldJAN
        '
        Me.fieldJAN.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldJAN.AreaIndex = 5
        Me.fieldJAN.Caption = "Jan2009"
        Me.fieldJAN.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldJAN.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldJAN.FieldName = "JAN"
        Me.fieldJAN.Name = "fieldJAN"
        Me.fieldJAN.Visible = False
        '
        'fieldFEV
        '
        Me.fieldFEV.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldFEV.AreaIndex = 5
        Me.fieldFEV.Caption = "Fev2009"
        Me.fieldFEV.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldFEV.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldFEV.FieldName = "FEV"
        Me.fieldFEV.Name = "fieldFEV"
        Me.fieldFEV.Visible = False
        '
        'fieldMAR
        '
        Me.fieldMAR.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMAR.AreaIndex = 5
        Me.fieldMAR.Caption = "Mar2009"
        Me.fieldMAR.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldMAR.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMAR.FieldName = "MAR"
        Me.fieldMAR.Name = "fieldMAR"
        Me.fieldMAR.Visible = False
        '
        'fieldABE
        '
        Me.fieldABE.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldABE.AreaIndex = 5
        Me.fieldABE.Caption = "Abr2009"
        Me.fieldABE.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldABE.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldABE.FieldName = "ABE"
        Me.fieldABE.Name = "fieldABE"
        Me.fieldABE.Visible = False
        '
        'fieldMAI
        '
        Me.fieldMAI.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMAI.AreaIndex = 5
        Me.fieldMAI.Caption = "Mai2009"
        Me.fieldMAI.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldMAI.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMAI.FieldName = "MAI"
        Me.fieldMAI.Name = "fieldMAI"
        Me.fieldMAI.Visible = False
        '
        'fieldJUN
        '
        Me.fieldJUN.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldJUN.AreaIndex = 5
        Me.fieldJUN.Caption = "Jun2009"
        Me.fieldJUN.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldJUN.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldJUN.FieldName = "JUN"
        Me.fieldJUN.Name = "fieldJUN"
        Me.fieldJUN.Visible = False
        '
        'fieldJUL
        '
        Me.fieldJUL.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldJUL.AreaIndex = 5
        Me.fieldJUL.Caption = "Jul2009"
        Me.fieldJUL.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldJUL.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldJUL.FieldName = "JUL"
        Me.fieldJUL.Name = "fieldJUL"
        Me.fieldJUL.Visible = False
        '
        'fieldAGO
        '
        Me.fieldAGO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldAGO.AreaIndex = 5
        Me.fieldAGO.Caption = "Ago2009"
        Me.fieldAGO.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldAGO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldAGO.FieldName = "AGO"
        Me.fieldAGO.Name = "fieldAGO"
        Me.fieldAGO.Visible = False
        '
        'fieldSET
        '
        Me.fieldSET.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSET.AreaIndex = 5
        Me.fieldSET.Caption = "Set2009"
        Me.fieldSET.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldSET.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSET.FieldName = "SET"
        Me.fieldSET.Name = "fieldSET"
        Me.fieldSET.Visible = False
        '
        'fieldOUT
        '
        Me.fieldOUT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldOUT.AreaIndex = 5
        Me.fieldOUT.Caption = "Out2009"
        Me.fieldOUT.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldOUT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldOUT.FieldName = "OUT"
        Me.fieldOUT.Name = "fieldOUT"
        Me.fieldOUT.Visible = False
        '
        'fieldNOV
        '
        Me.fieldNOV.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldNOV.AreaIndex = 5
        Me.fieldNOV.Caption = "Nov2009"
        Me.fieldNOV.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldNOV.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldNOV.FieldName = "NOV"
        Me.fieldNOV.Name = "fieldNOV"
        Me.fieldNOV.Visible = False
        '
        'fieldDEZ
        '
        Me.fieldDEZ.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldDEZ.AreaIndex = 5
        Me.fieldDEZ.Caption = "Dez2009"
        Me.fieldDEZ.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldDEZ.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldDEZ.FieldName = "DEZ"
        Me.fieldDEZ.Name = "fieldDEZ"
        Me.fieldDEZ.Visible = False
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = resources.GetString("OleDbSelectCommand1.CommandText")
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\CommercialSystem\dados\dbcomp.mdb"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "VendasportoMesCOMP", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("director", "director"), New System.Data.Common.DataColumnMapping("pais", "pais"), New System.Data.Common.DataColumnMapping("Cliente", "Cliente"), New System.Data.Common.DataColumnMapping("company", "company"), New System.Data.Common.DataColumnMapping("marca", "marca"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Grupo", "Grupo"), New System.Data.Common.DataColumnMapping("Subcat", "Subcat"), New System.Data.Common.DataColumnMapping("Family", "Family"), New System.Data.Common.DataColumnMapping("Embalagem", "Embalagem"), New System.Data.Common.DataColumnMapping("Target", "Target"), New System.Data.Common.DataColumnMapping("SHIPPED", "SHIPPED"), New System.Data.Common.DataColumnMapping("JAN", "JAN"), New System.Data.Common.DataColumnMapping("FEV", "FEV"), New System.Data.Common.DataColumnMapping("MAR", "MAR"), New System.Data.Common.DataColumnMapping("ABE", "ABE"), New System.Data.Common.DataColumnMapping("MAI", "MAI"), New System.Data.Common.DataColumnMapping("JUN", "JUN"), New System.Data.Common.DataColumnMapping("JUL", "JUL"), New System.Data.Common.DataColumnMapping("AGO", "AGO"), New System.Data.Common.DataColumnMapping("SET", "SET"), New System.Data.Common.DataColumnMapping("OUT", "OUT"), New System.Data.Common.DataColumnMapping("NOV", "NOV"), New System.Data.Common.DataColumnMapping("DEZ", "DEZ"), New System.Data.Common.DataColumnMapping("HAND", "HAND"), New System.Data.Common.DataColumnMapping("JAN1", "JAN1"), New System.Data.Common.DataColumnMapping("FEV1", "FEV1"), New System.Data.Common.DataColumnMapping("MAR1", "MAR1"), New System.Data.Common.DataColumnMapping("ABR1", "ABR1"), New System.Data.Common.DataColumnMapping("MAI1", "MAI1"), New System.Data.Common.DataColumnMapping("JUN1", "JUN1"), New System.Data.Common.DataColumnMapping("JUL1", "JUL1"), New System.Data.Common.DataColumnMapping("AGO1", "AGO1"), New System.Data.Common.DataColumnMapping("SET1", "SET1"), New System.Data.Common.DataColumnMapping("OUT1", "OUT1"), New System.Data.Common.DataColumnMapping("NOV1", "NOV1"), New System.Data.Common.DataColumnMapping("DEZ1", "DEZ1"), New System.Data.Common.DataColumnMapping("Forecast", "Forecast"), New System.Data.Common.DataColumnMapping("Assistant", "Secretari"), New System.Data.Common.DataColumnMapping("Manager", "SalesManager")})})
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.PivotGridControl1.Appearance.FieldValueTotal.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldValueTotal.Options.UseTextOptions = True
        Me.PivotGridControl1.Appearance.FieldValueTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridControl1.Appearance.FieldValueTotal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisPath
        Me.PivotGridControl1.Appearance.SelectedCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridControl1.Appearance.SelectedCell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.SelectedCell.Options.UseForeColor = True
        Me.PivotGridControl1.AppearancePrint.FieldValueTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridControl1.AppearancePrint.FieldValueTotal.Options.UseFont = True
        Me.PivotGridControl1.AppearancePrint.FieldValueTotal.Options.UseTextOptions = True
        Me.PivotGridControl1.AppearancePrint.FieldValueTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridControl1.AppearancePrint.FieldValueTotal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisPath
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.DataSource = Me.VendasportoMesCOMPBindingSource
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fielddirector, Me.fieldSecretari, Me.fieldSalesManager, Me.fieldpais, Me.fieldCliente, Me.fieldcompany, Me.fieldmarca, Me.fieldTipo, Me.fieldGrupo, Me.fieldSubcat, Me.fieldFamily, Me.fieldEmbalagem, Me.fieldTarget, Me.fieldSales, Me.fieldHAND, Me.fieldSalesYTDLY, Me.Dife, Me.Difeendmonth, Me.DifeTarget, Me.fieldJAN1, Me.fieldFEV1, Me.fieldMAR1, Me.fieldABR1, Me.fieldMAI1, Me.fieldJUN1, Me.fieldJUL1, Me.fieldAGO1, Me.fieldSET1, Me.fieldOUT1, Me.fieldNOV1, Me.fieldDEZ1, Me.fieldJAN, Me.fieldFEV, Me.fieldMAR, Me.fieldABE, Me.fieldMAI, Me.fieldJUN, Me.fieldJUL, Me.fieldAGO, Me.fieldSET, Me.fieldOUT, Me.fieldNOV, Me.fieldDEZ, Me.fieldVintage, Me.fieldPortConsumoBrandy, Me.fieldForecast, Me.DifeForeca, Me.DifeForecastinchand, Me.DifeTargetincand, Me.salesendmonth, Me.salesendmonthLY, Me.DifeTargetTLM, Me.DifeForecaTLM, Me.fieldSalesLY})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 95)
        Me.PivotGridControl1.LookAndFeel.SkinName = "Lilian"
        Me.PivotGridControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsBehavior.ApplyBestFitOnFieldDragging = True
        Me.PivotGridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.PivotGridControl1.OptionsDataField.AreaIndex = 0
        Me.PivotGridControl1.OptionsDataField.FieldNaming = DevExpress.XtraPivotGrid.DataFieldNaming.Name
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
        Me.PivotGridControl1.OptionsView.ShowColumnHeaders = False
        Me.PivotGridControl1.OptionsView.ShowColumnTotals = False
        Me.PivotGridControl1.OptionsView.ShowDataHeaders = False
        Me.PivotGridControl1.Size = New System.Drawing.Size(870, 411)
        Me.PivotGridControl1.TabIndex = 0
        '
        'VendasportoMesCOMPBindingSource
        '
        Me.VendasportoMesCOMPBindingSource.DataMember = "VendasportoMesCOMP"
        Me.VendasportoMesCOMPBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fielddirector
        '
        Me.fielddirector.AreaIndex = 0
        Me.fielddirector.Caption = "Director"
        Me.fielddirector.FieldName = "director"
        Me.fielddirector.Name = "fielddirector"
        '
        'fieldSecretari
        '
        Me.fieldSecretari.AreaIndex = 1
        Me.fieldSecretari.Caption = "Assistant"
        Me.fieldSecretari.FieldName = "Secretari"
        Me.fieldSecretari.Name = "fieldSecretari"
        '
        'fieldSalesManager
        '
        Me.fieldSalesManager.AreaIndex = 2
        Me.fieldSalesManager.Caption = "Manager"
        Me.fieldSalesManager.FieldName = "SalesManager"
        Me.fieldSalesManager.Name = "fieldSalesManager"
        '
        'fieldpais
        '
        Me.fieldpais.AreaIndex = 3
        Me.fieldpais.Caption = "Market"
        Me.fieldpais.FieldName = "pais"
        Me.fieldpais.Name = "fieldpais"
        '
        'fieldCliente
        '
        Me.fieldCliente.AreaIndex = 4
        Me.fieldCliente.Caption = "Client"
        Me.fieldCliente.FieldName = "Cliente"
        Me.fieldCliente.Name = "fieldCliente"
        '
        'fieldcompany
        '
        Me.fieldcompany.AreaIndex = 5
        Me.fieldcompany.Caption = "Company"
        Me.fieldcompany.FieldName = "company"
        Me.fieldcompany.Name = "fieldcompany"
        '
        'fieldmarca
        '
        Me.fieldmarca.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldmarca.AreaIndex = 2
        Me.fieldmarca.Caption = "Trademark"
        Me.fieldmarca.FieldName = "marca"
        Me.fieldmarca.Name = "fieldmarca"
        '
        'fieldTipo
        '
        Me.fieldTipo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldTipo.AreaIndex = 1
        Me.fieldTipo.Caption = "Type"
        Me.fieldTipo.FieldName = "Tipo"
        Me.fieldTipo.Name = "fieldTipo"
        '
        'fieldGrupo
        '
        Me.fieldGrupo.AreaIndex = 6
        Me.fieldGrupo.Caption = "Group"
        Me.fieldGrupo.FieldName = "Grupo"
        Me.fieldGrupo.Name = "fieldGrupo"
        '
        'fieldSubcat
        '
        Me.fieldSubcat.AreaIndex = 7
        Me.fieldSubcat.Caption = "Subcat"
        Me.fieldSubcat.FieldName = "Subcat"
        Me.fieldSubcat.Name = "fieldSubcat"
        '
        'fieldFamily
        '
        Me.fieldFamily.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldFamily.AreaIndex = 3
        Me.fieldFamily.Caption = "Family"
        Me.fieldFamily.FieldName = "Family"
        Me.fieldFamily.Name = "fieldFamily"
        '
        'fieldEmbalagem
        '
        Me.fieldEmbalagem.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldEmbalagem.AreaIndex = 4
        Me.fieldEmbalagem.Caption = "Package"
        Me.fieldEmbalagem.FieldName = "Embalagem"
        Me.fieldEmbalagem.Name = "fieldEmbalagem"
        Me.fieldEmbalagem.TopValueShowOthers = True
        '
        'fieldTarget
        '
        Me.fieldTarget.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTarget.AreaIndex = 3
        Me.fieldTarget.Caption = "Target"
        Me.fieldTarget.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldTarget.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTarget.FieldName = "Target"
        Me.fieldTarget.Name = "fieldTarget"
        Me.fieldTarget.Visible = False
        '
        'fieldSales
        '
        Me.fieldSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSales.Caption = "Shipped to date"
        Me.fieldSales.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldSales.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSales.FieldName = "SHIPPED"
        Me.fieldSales.Name = "fieldSales"
        Me.fieldSales.Visible = False
        '
        'fieldHAND
        '
        Me.fieldHAND.AreaIndex = 8
        Me.fieldHAND.Caption = "InHand"
        Me.fieldHAND.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldHAND.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldHAND.FieldName = "HAND"
        Me.fieldHAND.Name = "fieldHAND"
        '
        'fieldSalesYTDLY
        '
        Me.fieldSalesYTDLY.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSalesYTDLY.Caption = "Shipped to Month end Last Yr"
        Me.fieldSalesYTDLY.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldSalesYTDLY.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSalesYTDLY.Name = "fieldSalesYTDLY"
        Me.fieldSalesYTDLY.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.fieldSalesYTDLY.UnboundFieldName = "fieldSalesYTDLY"
        Me.fieldSalesYTDLY.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.fieldSalesYTDLY.Visible = False
        '
        'Dife
        '
        Me.Dife.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.Dife.Caption = "%Diff."
        Me.Dife.CellFormat.FormatString = "p1"
        Me.Dife.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Dife.Name = "Dife"
        Me.Dife.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.Dife.UnboundFieldName = "Dife"
        Me.Dife.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.Dife.Visible = False
        '
        'Difeendmonth
        '
        Me.Difeendmonth.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.Difeendmonth.AreaIndex = 2
        Me.Difeendmonth.Caption = "%Diff. end last Month"
        Me.Difeendmonth.CellFormat.FormatString = "p1"
        Me.Difeendmonth.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Difeendmonth.Name = "Difeendmonth"
        Me.Difeendmonth.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.Difeendmonth.UnboundFieldName = "Difeendmonth"
        Me.Difeendmonth.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'DifeTarget
        '
        Me.DifeTarget.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.DifeTarget.Caption = "%Target"
        Me.DifeTarget.CellFormat.FormatString = "p1"
        Me.DifeTarget.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DifeTarget.Name = "DifeTarget"
        Me.DifeTarget.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.DifeTarget.UnboundFieldName = "DifeTarget"
        Me.DifeTarget.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.DifeTarget.Visible = False
        '
        'fieldJAN1
        '
        Me.fieldJAN1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldJAN1.AreaIndex = 0
        Me.fieldJAN1.Caption = "Jan2008"
        Me.fieldJAN1.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldJAN1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldJAN1.FieldName = "JAN1"
        Me.fieldJAN1.Name = "fieldJAN1"
        Me.fieldJAN1.Visible = False
        '
        'fieldFEV1
        '
        Me.fieldFEV1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldFEV1.AreaIndex = 0
        Me.fieldFEV1.Caption = "Fev2008"
        Me.fieldFEV1.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldFEV1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldFEV1.FieldName = "FEV1"
        Me.fieldFEV1.Name = "fieldFEV1"
        Me.fieldFEV1.Visible = False
        '
        'fieldMAR1
        '
        Me.fieldMAR1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMAR1.AreaIndex = 0
        Me.fieldMAR1.Caption = "Mar2008"
        Me.fieldMAR1.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldMAR1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMAR1.FieldName = "MAR1"
        Me.fieldMAR1.Name = "fieldMAR1"
        Me.fieldMAR1.Visible = False
        '
        'fieldABR1
        '
        Me.fieldABR1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldABR1.AreaIndex = 0
        Me.fieldABR1.Caption = "Abr2008"
        Me.fieldABR1.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldABR1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldABR1.FieldName = "ABR1"
        Me.fieldABR1.Name = "fieldABR1"
        Me.fieldABR1.Visible = False
        '
        'fieldMAI1
        '
        Me.fieldMAI1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMAI1.AreaIndex = 0
        Me.fieldMAI1.Caption = "Mai2008"
        Me.fieldMAI1.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldMAI1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMAI1.FieldName = "MAI1"
        Me.fieldMAI1.Name = "fieldMAI1"
        Me.fieldMAI1.Visible = False
        '
        'fieldJUN1
        '
        Me.fieldJUN1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldJUN1.AreaIndex = 0
        Me.fieldJUN1.Caption = "Jun2008"
        Me.fieldJUN1.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldJUN1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldJUN1.FieldName = "JUN1"
        Me.fieldJUN1.Name = "fieldJUN1"
        Me.fieldJUN1.Visible = False
        '
        'fieldJUL1
        '
        Me.fieldJUL1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldJUL1.AreaIndex = 0
        Me.fieldJUL1.Caption = "Jul2008"
        Me.fieldJUL1.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldJUL1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldJUL1.FieldName = "JUL1"
        Me.fieldJUL1.Name = "fieldJUL1"
        Me.fieldJUL1.Visible = False
        '
        'fieldAGO1
        '
        Me.fieldAGO1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldAGO1.AreaIndex = 0
        Me.fieldAGO1.Caption = "Ago2008"
        Me.fieldAGO1.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldAGO1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldAGO1.FieldName = "AGO1"
        Me.fieldAGO1.Name = "fieldAGO1"
        Me.fieldAGO1.Visible = False
        '
        'fieldSET1
        '
        Me.fieldSET1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSET1.AreaIndex = 0
        Me.fieldSET1.Caption = "Set2008"
        Me.fieldSET1.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldSET1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSET1.FieldName = "SET1"
        Me.fieldSET1.Name = "fieldSET1"
        Me.fieldSET1.Visible = False
        '
        'fieldOUT1
        '
        Me.fieldOUT1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldOUT1.AreaIndex = 0
        Me.fieldOUT1.Caption = "Out2008"
        Me.fieldOUT1.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldOUT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldOUT1.FieldName = "OUT1"
        Me.fieldOUT1.Name = "fieldOUT1"
        Me.fieldOUT1.Visible = False
        '
        'fieldNOV1
        '
        Me.fieldNOV1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldNOV1.AreaIndex = 0
        Me.fieldNOV1.Caption = "Nov2008"
        Me.fieldNOV1.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldNOV1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldNOV1.FieldName = "NOV1"
        Me.fieldNOV1.Name = "fieldNOV1"
        Me.fieldNOV1.Visible = False
        '
        'fieldDEZ1
        '
        Me.fieldDEZ1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldDEZ1.AreaIndex = 0
        Me.fieldDEZ1.Caption = "Dez2008"
        Me.fieldDEZ1.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldDEZ1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldDEZ1.FieldName = "DEZ1"
        Me.fieldDEZ1.Name = "fieldDEZ1"
        Me.fieldDEZ1.Visible = False
        '
        'fieldVintage
        '
        Me.fieldVintage.AreaIndex = 8
        Me.fieldVintage.Caption = "Vintage/NonVint"
        Me.fieldVintage.Name = "fieldVintage"
        Me.fieldVintage.Options.ShowInCustomizationForm = False
        Me.fieldVintage.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.fieldVintage.UnboundFieldName = "fieldVintage"
        Me.fieldVintage.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.fieldVintage.Visible = False
        '
        'fieldPortConsumoBrandy
        '
        Me.fieldPortConsumoBrandy.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldPortConsumoBrandy.AreaIndex = 0
        Me.fieldPortConsumoBrandy.Caption = "Port/Consumo/Brandy"
        Me.fieldPortConsumoBrandy.Name = "fieldPortConsumoBrandy"
        Me.fieldPortConsumoBrandy.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldPortConsumoBrandy.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.fieldPortConsumoBrandy.UnboundFieldName = "fieldPortConsumoBrandy"
        Me.fieldPortConsumoBrandy.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'fieldForecast
        '
        Me.fieldForecast.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldForecast.AreaIndex = 4
        Me.fieldForecast.Caption = "Forecast"
        Me.fieldForecast.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldForecast.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldForecast.FieldName = "Forecast"
        Me.fieldForecast.Name = "fieldForecast"
        '
        'DifeForeca
        '
        Me.DifeForeca.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.DifeForeca.AreaIndex = 0
        Me.DifeForeca.Caption = "% Forecast"
        Me.DifeForeca.CellFormat.FormatString = "p1"
        Me.DifeForeca.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DifeForeca.Name = "DifeForeca"
        Me.DifeForeca.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.DifeForeca.UnboundFieldName = "DifeForeca"
        Me.DifeForeca.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.DifeForeca.Visible = False
        '
        'DifeForecastinchand
        '
        Me.DifeForecastinchand.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.DifeForecastinchand.AreaIndex = 8
        Me.DifeForecastinchand.Caption = "% Forecast inc. InHand"
        Me.DifeForecastinchand.CellFormat.FormatString = "p1"
        Me.DifeForecastinchand.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DifeForecastinchand.Name = "DifeForecastinchand"
        Me.DifeForecastinchand.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.DifeForecastinchand.UnboundFieldName = "DifeForecastinchand"
        Me.DifeForecastinchand.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.DifeForecastinchand.Visible = False
        '
        'DifeTargetincand
        '
        Me.DifeTargetincand.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.DifeTargetincand.AreaIndex = 0
        Me.DifeTargetincand.Caption = "% Target inc. InHand"
        Me.DifeTargetincand.CellFormat.FormatString = "p1"
        Me.DifeTargetincand.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DifeTargetincand.Name = "DifeTargetincand"
        Me.DifeTargetincand.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.DifeTargetincand.UnboundFieldName = "DifeTargetinchand"
        Me.DifeTargetincand.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.DifeTargetincand.Visible = False
        '
        'salesendmonth
        '
        Me.salesendmonth.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.salesendmonth.AreaIndex = 0
        Me.salesendmonth.Caption = "Shipped till Last Month"
        Me.salesendmonth.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.salesendmonth.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.salesendmonth.Name = "salesendmonth"
        Me.salesendmonth.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.salesendmonth.UnboundFieldName = "salesendmonth"
        Me.salesendmonth.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'salesendmonthLY
        '
        Me.salesendmonthLY.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.salesendmonthLY.AreaIndex = 1
        Me.salesendmonthLY.Caption = "Shipped till Last Month Last Year"
        Me.salesendmonthLY.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.salesendmonthLY.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.salesendmonthLY.Name = "salesendmonthLY"
        Me.salesendmonthLY.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.salesendmonthLY.UnboundFieldName = "salesendmonthLY"
        Me.salesendmonthLY.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'DifeTargetTLM
        '
        Me.DifeTargetTLM.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.DifeTargetTLM.AreaIndex = 3
        Me.DifeTargetTLM.Caption = "% Target till Last Month"
        Me.DifeTargetTLM.CellFormat.FormatString = "p1"
        Me.DifeTargetTLM.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DifeTargetTLM.Name = "DifeTargetTLM"
        Me.DifeTargetTLM.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.DifeTargetTLM.UnboundFieldName = "DifeTargetTLM"
        Me.DifeTargetTLM.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'DifeForecaTLM
        '
        Me.DifeForecaTLM.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.DifeForecaTLM.AreaIndex = 5
        Me.DifeForecaTLM.Caption = "% Forecast till Last Month"
        Me.DifeForecaTLM.CellFormat.FormatString = "p1"
        Me.DifeForecaTLM.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DifeForecaTLM.Name = "DifeForecaTLM"
        Me.DifeForecaTLM.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.DifeForecaTLM.UnboundFieldName = "DifeForecaTLM"
        Me.DifeForecaTLM.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'fieldSalesLY
        '
        Me.fieldSalesLY.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSalesLY.AreaIndex = 7
        Me.fieldSalesLY.Caption = "Shipped LY"
        Me.fieldSalesLY.CellFormat.FormatString = "#,###.0;-#,###.0;-"
        Me.fieldSalesLY.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSalesLY.Name = "fieldSalesLY"
        Me.fieldSalesLY.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.fieldSalesLY.UnboundFieldName = "fieldSalesLY"
        Me.fieldSalesLY.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.fieldSalesLY.Visible = False
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
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(0, 506)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(870, 58)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'filenamexml
        '
        Me.filenamexml.Filter = "Layout files|*.xml"
        Me.filenamexml.InitialDirectory = "c:\CommercialSystem\dados"
        Me.filenamexml.RestoreDirectory = True
        '
        'savefilexml
        '
        Me.savefilexml.DefaultExt = "*.xml"
        Me.savefilexml.Filter = "Layout files|*.xml"
        Me.savefilexml.InitialDirectory = "c:\CommercialSystem\dados"
        Me.savefilexml.RestoreDirectory = True
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.Tools, Me.RibbonPageGroup4, Me.Layoutapplied, Me.RibbonPageGroup3})
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
        Me.BarEditItem1.EditValue = "ShippedtillendlastMonth"
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
        Me.RibbonControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.BackColor = System.Drawing.Color.SteelBlue
        Me.RibbonControl1.Controller = Me.BarAndDockingController1
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        '
        '
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem4, Me.BarButtonItem3, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.Top5, Me.Top10, Me.NOTOP, Me.BarEditItem1})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.RibbonControl1.MaxItemId = 53
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemCheckEdit3, Me.RepositoryItemTextEdit2})
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(870, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'FormPivotComp
        '
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(870, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPivotComp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasportoMesCOMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents VendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fielddirector As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldpais As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldcompany As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldmarca As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTipo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGrupo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSubcat As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFamily As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEmbalagem As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTarget As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSales As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHAND As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSalesYTDLY As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents Dife As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents DifeTarget As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldJAN1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFEV1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMAR1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldABR1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMAI1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldJUN1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldJUL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAGO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSET1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOUT1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOV1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEZ1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldJAN As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFEV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldABE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMAI As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldJUN As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldJUL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAGO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSET As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEZ As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents fieldVintage As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents VendasportoMesCOMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet11 As Global.CommercialSystem.DataSet1
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents fieldPortConsumoBrandy As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents fieldForecast As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents DifeForeca As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents DifeForecastinchand As DevExpress.XtraPivotGrid.PivotGridField
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
    Friend WithEvents Difeendmonth As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents salesendmonth As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents salesendmonthLY As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents DifeTargetincand As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents DifeTargetTLM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents DifeForecaTLM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSalesLY As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents Layoutapplied As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents fieldSecretari As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSalesManager As DevExpress.XtraPivotGrid.PivotGridField


End Class
