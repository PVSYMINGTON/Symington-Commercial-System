<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateForecast
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.YearValue = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.FQValue = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.ImageEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesSystemDataSet2 = New Forecast.SalesSystemDataSet2()
        Me.SapPricingTableAdapter = New Forecast.SalesSystemDataSet2TableAdapters.SapPricingTableAdapter()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapForecastTableAdapter = New Forecast.SalesSystemDataSet2TableAdapters.SapForecastTableAdapter()
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapImmaterialSalesTableAdapter = New Forecast.SalesSystemDataSet2TableAdapters.SapImmaterialSalesTableAdapter()
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapTarget2014TableAdapter = New Forecast.SalesSystemDataSet2TableAdapters.SapTarget2014TableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SPforecastskuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SPforecastskuTableAdapter = New Forecast.SalesSystemDataSet2TableAdapters.SPforecastskuTableAdapter()
        Me.SapTarget2014StatTableAdapter = New Forecast.SalesSystemDataSet2TableAdapters.SapTarget2014StatTableAdapter()
        Me.SapForecastStatTableAdapter = New Forecast.SalesSystemDataSet2TableAdapters.SapForecastStatTableAdapter()
        Me.SapImmaterialSalesStatTableAdapter = New Forecast.SalesSystemDataSet2TableAdapters.SapImmaterialSalesStatTableAdapter()
        Me.SapSalesCSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapSalesCSTableAdapter = New Forecast.SalesSystemDataSet2TableAdapters.SapSalesCSTableAdapter()
        CType(Me.YearValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.FQValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesSystemDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPforecastskuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapSalesCSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YearValue
        '
        Me.YearValue.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.YearValue.Location = New System.Drawing.Point(12, 28)
        Me.YearValue.Name = "YearValue"
        Me.YearValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.YearValue.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.YearValue.Properties.Mask.EditMask = "0000"
        Me.YearValue.Size = New System.Drawing.Size(139, 20)
        Me.YearValue.StyleController = Me.LayoutControl1
        Me.YearValue.TabIndex = 0
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.AnyOf
        ConditionValidationRule2.ErrorText = "This value is not valid"
        ConditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        ConditionValidationRule2.Values.Add("2012")
        ConditionValidationRule2.Values.Add("2013")
        ConditionValidationRule2.Values.Add("2014")
        ConditionValidationRule2.Values.Add("2015")
        ConditionValidationRule2.Values.Add("2016")
        ConditionValidationRule2.Values.Add("2017")
        ConditionValidationRule2.Values.Add("2018")
        ConditionValidationRule2.Values.Add("2019")
        ConditionValidationRule2.Values.Add("2020")
        ConditionValidationRule2.Values.Add("2021")
        ConditionValidationRule2.Values.Add("2022")
        ConditionValidationRule2.Values.Add("2023")
        ConditionValidationRule2.Values.Add("2024")
        ConditionValidationRule2.Values.Add("2025")
        ConditionValidationRule2.Values.Add("2026")
        ConditionValidationRule2.Values.Add("2027")
        ConditionValidationRule2.Values.Add("2028")
        ConditionValidationRule2.Values.Add("2029")
        ConditionValidationRule2.Values.Add("2030")
        ConditionValidationRule2.Values.Add("2031")
        ConditionValidationRule2.Values.Add("2032")
        ConditionValidationRule2.Values.Add("2033")
        ConditionValidationRule2.Values.Add("2034")
        ConditionValidationRule2.Values.Add("2035")
        ConditionValidationRule2.Values.Add("2036")
        ConditionValidationRule2.Values.Add("2037")
        ConditionValidationRule2.Values.Add("2038")
        ConditionValidationRule2.Values.Add("2039")
        ConditionValidationRule2.Values.Add("2040")
        ConditionValidationRule2.Values.Add("2041")
        ConditionValidationRule2.Values.Add("2042")
        ConditionValidationRule2.Values.Add("2043")
        ConditionValidationRule2.Values.Add("2044")
        ConditionValidationRule2.Values.Add("2045")
        ConditionValidationRule2.Values.Add("2046")
        ConditionValidationRule2.Values.Add("2047")
        ConditionValidationRule2.Values.Add("2048")
        ConditionValidationRule2.Values.Add("2049")
        ConditionValidationRule2.Values.Add("2050")
        ConditionValidationRule2.Values.Add("2051")
        ConditionValidationRule2.Values.Add("2052")
        ConditionValidationRule2.Values.Add("2053")
        ConditionValidationRule2.Values.Add("2054")
        ConditionValidationRule2.Values.Add("2055")
        ConditionValidationRule2.Values.Add("2056")
        ConditionValidationRule2.Values.Add("2057")
        ConditionValidationRule2.Values.Add("2058")
        ConditionValidationRule2.Values.Add("2059")
        ConditionValidationRule2.Values.Add("2060")
        ConditionValidationRule2.Values.Add("2061")
        ConditionValidationRule2.Values.Add("2062")
        ConditionValidationRule2.Values.Add("2063")
        ConditionValidationRule2.Values.Add("2064")
        ConditionValidationRule2.Values.Add("2065")
        ConditionValidationRule2.Values.Add("2066")
        ConditionValidationRule2.Values.Add("2067")
        ConditionValidationRule2.Values.Add("2068")
        ConditionValidationRule2.Values.Add("2069")
        ConditionValidationRule2.Values.Add("2070")
        ConditionValidationRule2.Values.Add("2071")
        ConditionValidationRule2.Values.Add("2072")
        ConditionValidationRule2.Values.Add("2073")
        ConditionValidationRule2.Values.Add("2074")
        ConditionValidationRule2.Values.Add("2075")
        ConditionValidationRule2.Values.Add("2076")
        ConditionValidationRule2.Values.Add("2077")
        ConditionValidationRule2.Values.Add("2078")
        ConditionValidationRule2.Values.Add("2079")
        ConditionValidationRule2.Values.Add("2080")
        ConditionValidationRule2.Values.Add("2081")
        ConditionValidationRule2.Values.Add("2082")
        ConditionValidationRule2.Values.Add("2083")
        ConditionValidationRule2.Values.Add("2084")
        ConditionValidationRule2.Values.Add("2085")
        ConditionValidationRule2.Values.Add("2086")
        ConditionValidationRule2.Values.Add("2087")
        ConditionValidationRule2.Values.Add("2088")
        ConditionValidationRule2.Values.Add("2089")
        ConditionValidationRule2.Values.Add("2090")
        ConditionValidationRule2.Values.Add("2091")
        ConditionValidationRule2.Values.Add("2092")
        ConditionValidationRule2.Values.Add("2093")
        ConditionValidationRule2.Values.Add("2094")
        ConditionValidationRule2.Values.Add("2095")
        ConditionValidationRule2.Values.Add("2096")
        ConditionValidationRule2.Values.Add("2097")
        ConditionValidationRule2.Values.Add("2098")
        ConditionValidationRule2.Values.Add("2099")
        ConditionValidationRule2.Values.Add("2100")
        Me.DxValidationProvider1.SetValidationRule(Me.YearValue, ConditionValidationRule2)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton4)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.FQValue)
        Me.LayoutControl1.Controls.Add(Me.YearValue)
        Me.LayoutControl1.Location = New System.Drawing.Point(99, 182)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(981, 308, 406, 424)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(296, 235)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(12, 174)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(271, 36)
        Me.SimpleButton4.StyleController = Me.LayoutControl1
        Me.SimpleButton4.TabIndex = 7
        Me.SimpleButton4.Text = "Fechar Periodo de Alterações"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(12, 94)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(271, 36)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "Criar FQ Statistic..."
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 134)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(271, 36)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Copiar ficheiro SAP..."
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 54)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(271, 36)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Criar FQ..."
        '
        'FQValue
        '
        Me.FQValue.EditValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.FQValue.Location = New System.Drawing.Point(155, 28)
        Me.FQValue.Name = "FQValue"
        Me.FQValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FQValue.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.FQValue.Properties.IsFloatValue = False
        Me.FQValue.Properties.Mask.EditMask = "n0"
        Me.FQValue.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.FQValue.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.FQValue.Size = New System.Drawing.Size(129, 20)
        Me.FQValue.StyleController = Me.LayoutControl1
        Me.FQValue.TabIndex = 1
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.AnyOf
        ConditionValidationRule1.ErrorText = "This value is not valid"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        ConditionValidationRule1.Values.Add("1")
        ConditionValidationRule1.Values.Add("2")
        ConditionValidationRule1.Values.Add("3")
        ConditionValidationRule1.Values.Add("4")
        ConditionValidationRule1.Values.Add("5")
        Me.DxValidationProvider1.SetValidationRule(Me.FQValue, ConditionValidationRule1)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.SimpleSeparator1, Me.LayoutControlItem5, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(296, 235)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.YearValue
        Me.LayoutControlItem1.CustomizationFormText = "Year"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(143, 40)
        Me.LayoutControlItem1.Text = "Year"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.FQValue
        Me.LayoutControlItem2.CustomizationFormText = "Periodo FQ"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(143, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(133, 40)
        Me.LayoutControlItem2.Text = "Periodo FQ"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(275, 40)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(275, 40)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(276, 40)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton2
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(275, 40)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(275, 40)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(276, 40)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 40)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(276, 2)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton3
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 82)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(275, 40)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(275, 40)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(276, 40)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton4
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 162)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(275, 40)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(275, 40)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(276, 53)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.[Auto]
        '
        'ImageEdit1
        '
        Me.ImageEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImageEdit1.EditValue = Global.Forecast.My.Resources.Resources.cruz
        Me.ImageEdit1.Location = New System.Drawing.Point(12, 12)
        Me.ImageEdit1.Name = "ImageEdit1"
        Me.ImageEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.ImageEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.ImageEdit1.Size = New System.Drawing.Size(469, 132)
        Me.ImageEdit1.TabIndex = 3
        Me.ImageEdit1.TabStop = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(12, 150)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(469, 26)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Criação de novo periodo de Forecast "
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "SapPricing"
        Me.BindingSource1.DataSource = Me.SalesSystemDataSet2
        '
        'SalesSystemDataSet2
        '
        Me.SalesSystemDataSet2.DataSetName = "SalesSystemDataSet2"
        Me.SalesSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SapPricingTableAdapter
        '
        Me.SapPricingTableAdapter.ClearBeforeFill = True
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "SapForecast"
        Me.BindingSource2.DataSource = Me.SalesSystemDataSet2
        '
        'SapForecastTableAdapter
        '
        Me.SapForecastTableAdapter.ClearBeforeFill = True
        '
        'BindingSource3
        '
        Me.BindingSource3.AllowNew = True
        Me.BindingSource3.DataMember = "SapImmaterialSales"
        Me.BindingSource3.DataSource = Me.SalesSystemDataSet2
        '
        'SapImmaterialSalesTableAdapter
        '
        Me.SapImmaterialSalesTableAdapter.ClearBeforeFill = True
        '
        'BindingSource4
        '
        Me.BindingSource4.AllowNew = True
        Me.BindingSource4.DataMember = "SapTarget2014"
        Me.BindingSource4.DataSource = Me.SalesSystemDataSet2
        '
        'SapTarget2014TableAdapter
        '
        Me.SapTarget2014TableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.SPforecastskuBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(460, 489)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(320, 234)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.GridControl1.Visible = False
        '
        'SPforecastskuBindingSource
        '
        Me.SPforecastskuBindingSource.DataMember = "SPforecastsku"
        Me.SPforecastskuBindingSource.DataSource = Me.SalesSystemDataSet2
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'SPforecastskuTableAdapter
        '
        Me.SPforecastskuTableAdapter.ClearBeforeFill = True
        '
        'SapTarget2014StatTableAdapter
        '
        Me.SapTarget2014StatTableAdapter.ClearBeforeFill = True
        '
        'SapForecastStatTableAdapter
        '
        Me.SapForecastStatTableAdapter.ClearBeforeFill = True
        '
        'SapImmaterialSalesStatTableAdapter
        '
        Me.SapImmaterialSalesStatTableAdapter.ClearBeforeFill = True
        '
        'SapSalesCSBindingSource
        '
        Me.SapSalesCSBindingSource.DataMember = "SapSalesCS"
        Me.SapSalesCSBindingSource.DataSource = Me.SalesSystemDataSet2
        '
        'SapSalesCSTableAdapter
        '
        Me.SapSalesCSTableAdapter.ClearBeforeFill = True
        '
        'CreateForecast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 735)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.ImageEdit1)
        Me.Name = "CreateForecast"
        Me.Text = "CreateForecast"
        CType(Me.YearValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.FQValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesSystemDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPforecastskuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapSalesCSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents YearValue As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents FQValue As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SalesSystemDataSet2 As Forecast.SalesSystemDataSet2
    Friend WithEvents SapPricingTableAdapter As Forecast.SalesSystemDataSet2TableAdapters.SapPricingTableAdapter
    Friend WithEvents ImageEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents SapForecastTableAdapter As Forecast.SalesSystemDataSet2TableAdapters.SapForecastTableAdapter
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents SapImmaterialSalesTableAdapter As Forecast.SalesSystemDataSet2TableAdapters.SapImmaterialSalesTableAdapter
    Friend WithEvents BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents SapTarget2014TableAdapter As Forecast.SalesSystemDataSet2TableAdapters.SapTarget2014TableAdapter
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SPforecastskuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SPforecastskuTableAdapter As Forecast.SalesSystemDataSet2TableAdapters.SPforecastskuTableAdapter
    Public WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SapTarget2014StatTableAdapter As Forecast.SalesSystemDataSet2TableAdapters.SapTarget2014StatTableAdapter
    Public WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SapForecastStatTableAdapter As Forecast.SalesSystemDataSet2TableAdapters.SapForecastStatTableAdapter
    Friend WithEvents SapImmaterialSalesStatTableAdapter As Forecast.SalesSystemDataSet2TableAdapters.SapImmaterialSalesStatTableAdapter
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SapSalesCSBindingSource As BindingSource
    Friend WithEvents SapSalesCSTableAdapter As SalesSystemDataSet2TableAdapters.SapSalesCSTableAdapter
End Class
