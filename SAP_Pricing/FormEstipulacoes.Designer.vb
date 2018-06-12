<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstipulacoes
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SapContratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVKORG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBOART = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBONEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDATAB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDATBI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKNUMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBeneficiario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataInicio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataFim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoCondicao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTipoCond2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SAPT685TBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMaterial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkmein = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperacao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColVkorg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTipoCond = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapContratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTipoCond2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAPT685TBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTipoCond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTipoCond, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemTipoCond2})
        Me.GridControl1.Size = New System.Drawing.Size(817, 360)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNum, Me.colTipoContrato, Me.colBeneficiario, Me.colDataInicio, Me.colDataFim, Me.colTipoCondicao, Me.colMaterial, Me.colValor, Me.colkmein, Me.colOperacao, Me.GridColVkorg})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colNum
        '
        Me.colNum.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colNum.FieldName = "Num"
        Me.colNum.Name = "colNum"
        Me.colNum.Visible = True
        Me.colNum.VisibleIndex = 0
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.SapContratosBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "KNUMA"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.GridView2
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "KNUMA"
        '
        'SapContratosBindingSource
        '
        Me.SapContratosBindingSource.DataMember = "SapContratos"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVKORG, Me.colBOART, Me.colBONEM, Me.colNAME1, Me.colDATAB, Me.colDATBI, Me.colKNUMA})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GroupCount = 1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colVKORG, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colVKORG
        '
        Me.colVKORG.Caption = "Sales Organization"
        Me.colVKORG.FieldName = "VKORG"
        Me.colVKORG.Name = "colVKORG"
        Me.colVKORG.Visible = True
        Me.colVKORG.VisibleIndex = 0
        '
        'colBOART
        '
        Me.colBOART.Caption = "Agreement Type"
        Me.colBOART.FieldName = "BOART"
        Me.colBOART.Name = "colBOART"
        Me.colBOART.Visible = True
        Me.colBOART.VisibleIndex = 0
        '
        'colBONEM
        '
        Me.colBONEM.Caption = "Cust. Num"
        Me.colBONEM.FieldName = "BONEM"
        Me.colBONEM.Name = "colBONEM"
        Me.colBONEM.Visible = True
        Me.colBONEM.VisibleIndex = 1
        '
        'colNAME1
        '
        Me.colNAME1.Caption = "Description"
        Me.colNAME1.FieldName = "NAME1"
        Me.colNAME1.Name = "colNAME1"
        Me.colNAME1.Visible = True
        Me.colNAME1.VisibleIndex = 2
        '
        'colDATAB
        '
        Me.colDATAB.Caption = "Start Date"
        Me.colDATAB.FieldName = "DATAB"
        Me.colDATAB.Name = "colDATAB"
        Me.colDATAB.Visible = True
        Me.colDATAB.VisibleIndex = 3
        '
        'colDATBI
        '
        Me.colDATBI.Caption = "End Date"
        Me.colDATBI.FieldName = "DATBI"
        Me.colDATBI.Name = "colDATBI"
        Me.colDATBI.Visible = True
        Me.colDATBI.VisibleIndex = 4
        '
        'colKNUMA
        '
        Me.colKNUMA.Caption = "Agreement Num"
        Me.colKNUMA.FieldName = "KNUMA"
        Me.colKNUMA.Name = "colKNUMA"
        Me.colKNUMA.Visible = True
        Me.colKNUMA.VisibleIndex = 5
        '
        'colTipoContrato
        '
        Me.colTipoContrato.FieldName = "TipoContrato"
        Me.colTipoContrato.Name = "colTipoContrato"
        Me.colTipoContrato.OptionsColumn.AllowEdit = False
        Me.colTipoContrato.Visible = True
        Me.colTipoContrato.VisibleIndex = 1
        '
        'colBeneficiario
        '
        Me.colBeneficiario.FieldName = "Beneficiario"
        Me.colBeneficiario.Name = "colBeneficiario"
        Me.colBeneficiario.OptionsColumn.AllowEdit = False
        Me.colBeneficiario.Visible = True
        Me.colBeneficiario.VisibleIndex = 2
        '
        'colDataInicio
        '
        Me.colDataInicio.FieldName = "DataInicio"
        Me.colDataInicio.Name = "colDataInicio"
        Me.colDataInicio.OptionsColumn.AllowEdit = False
        '
        'colDataFim
        '
        Me.colDataFim.FieldName = "DataFim"
        Me.colDataFim.Name = "colDataFim"
        Me.colDataFim.OptionsColumn.AllowEdit = False
        '
        'colTipoCondicao
        '
        Me.colTipoCondicao.ColumnEdit = Me.RepositoryItemTipoCond2
        Me.colTipoCondicao.FieldName = "TipoCondicao"
        Me.colTipoCondicao.Name = "colTipoCondicao"
        Me.colTipoCondicao.Visible = True
        Me.colTipoCondicao.VisibleIndex = 3
        '
        'RepositoryItemTipoCond2
        '
        Me.RepositoryItemTipoCond2.AutoHeight = False
        Me.RepositoryItemTipoCond2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemTipoCond2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemTipoCond2.DataSource = Me.SAPT685TBindingSource
        Me.RepositoryItemTipoCond2.DisplayMember = "KSCHL"
        Me.RepositoryItemTipoCond2.Name = "RepositoryItemTipoCond2"
        Me.RepositoryItemTipoCond2.PopupView = Me.RepositoryItemGridLookUpEdit3View
        Me.RepositoryItemTipoCond2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemTipoCond2.ValueMember = "KSCHL"
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colMaterial
        '
        Me.colMaterial.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colMaterial.FieldName = "Material"
        Me.colMaterial.Name = "colMaterial"
        Me.colMaterial.Visible = True
        Me.colMaterial.VisibleIndex = 4
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.PopupView = Me.RepositoryItemGridLookUpEdit2View
        Me.RepositoryItemGridLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Material"
        Me.GridColumn1.FieldName = "Material"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Unidade"
        Me.GridColumn2.FieldName = "Unidade"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'colValor
        '
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 5
        '
        'colkmein
        '
        Me.colkmein.FieldName = "kmein"
        Me.colkmein.Name = "colkmein"
        '
        'colOperacao
        '
        Me.colOperacao.FieldName = "Operacao"
        Me.colOperacao.Name = "colOperacao"
        Me.colOperacao.OptionsColumn.AllowEdit = False
        Me.colOperacao.Visible = True
        Me.colOperacao.VisibleIndex = 6
        '
        'GridColVkorg
        '
        Me.GridColVkorg.FieldName = "vkorg"
        Me.GridColVkorg.Name = "GridColVkorg"
        Me.GridColVkorg.OptionsColumn.AllowEdit = False
        Me.GridColVkorg.Visible = True
        Me.GridColVkorg.VisibleIndex = 7
        '
        'RepositoryItemTipoCond
        '
        Me.RepositoryItemTipoCond.AutoHeight = False
        Me.RepositoryItemTipoCond.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemTipoCond.Items.AddRange(New Object() {"YABV", "YAPP", "YAPV", "YCOP", "YEST", "YRRP", "YRRV", "YSCP", "YSCV", "YSHP", "YSHV", "YOCM", "YSNP", "YSNV"})
        Me.RepositoryItemTipoCond.Name = "RepositoryItemTipoCond"
        '
        'FormEstipulacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 360)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "FormEstipulacoes"
        Me.Text = "Estipulações"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapContratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTipoCond2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAPT685TBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTipoCond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBeneficiario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataInicio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataFim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoCondicao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTipoCond As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SapPricingDataset1 As SapCSDataSet
    Friend WithEvents SapContratosBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colkmein As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBOART As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBONEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDATAB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDATBI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKNUMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVKORG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColVkorg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTipoCond2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SAPT685TBindingSource As System.Windows.Forms.BindingSource

End Class
