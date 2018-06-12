Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pricing
    Inherits RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pricing))
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SpreadsheetCommandBarCheckItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
        Me.SpreadsheetCommandBarCheckItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
        Me.SpreadsheetCommandBarButtonItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.BarButtonSaveAS = New DevExpress.XtraBars.BarButtonItem()
        Me.FileRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FileRibbonPage()
        Me.CommonRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup()
        Me.InfoRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup()
        Me.ViewRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ViewRibbonPage()
        Me.ShowRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ShowRibbonPageGroup()
        Me.ZoomRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ZoomRibbonPageGroup()
        Me.spreadsheetControl = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.spreadsheetFormulaBarPanel = New System.Windows.Forms.Panel()
        Me.splitterControl = New DevExpress.XtraEditors.SplitterControl()
        Me.formulaBarNameBoxSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.spreadsheetNameBoxControl = New DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl()
        Me.spreadsheetFormulaBarControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl()
        Me.SpreadsheetBarController1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager()
        Me.DockPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.SapPricingDataset1 = New SAP_Pricing.SapCSDataSet()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.SAP_Pricing.WaitForm1), True, True)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spreadsheetFormulaBarPanel.SuspendLayout()
        CType(Me.formulaBarNameBoxSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.formulaBarNameBoxSplitContainerControl.SuspendLayout()
        CType(Me.spreadsheetNameBoxControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpreadsheetBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel.SuspendLayout()
        CType(Me.SapPricingDataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.SpreadsheetCommandBarCheckItem1, Me.SpreadsheetCommandBarCheckItem2, Me.SpreadsheetCommandBarButtonItem1, Me.SpreadsheetCommandBarButtonItem2, Me.SpreadsheetCommandBarButtonItem3, Me.SpreadsheetCommandBarButtonItem8, Me.SpreadsheetCommandBarButtonItem9, Me.SpreadsheetCommandBarButtonItem10, Me.SpreadsheetCommandBarButtonItem11, Me.SpreadsheetCommandBarButtonItem12, Me.SpreadsheetCommandBarButtonItem13, Me.SpreadsheetCommandBarButtonItem14, Me.SpreadsheetCommandBarButtonItem15, Me.SpreadsheetCommandBarButtonItem16, Me.SpreadsheetCommandBarButtonItem17, Me.BarButtonSaveAS})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 2
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.OptionsTouch.ShowTouchUISelectorInQAT = True
        Me.ribbonControl.OptionsTouch.ShowTouchUISelectorVisibilityItemInQATMenu = True
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1, Me.ViewRibbonPage1})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowToolbarCustomizeItem = False
        Me.ribbonControl.Size = New System.Drawing.Size(1100, 143)
        Me.ribbonControl.Toolbar.ShowCustomizeItem = False
        '
        'SpreadsheetCommandBarCheckItem1
        '
        Me.SpreadsheetCommandBarCheckItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.SpreadsheetCommandBarCheckItem1.CommandName = "ViewShowGridlines"
        Me.SpreadsheetCommandBarCheckItem1.Id = 1
        Me.SpreadsheetCommandBarCheckItem1.Name = "SpreadsheetCommandBarCheckItem1"
        '
        'SpreadsheetCommandBarCheckItem2
        '
        Me.SpreadsheetCommandBarCheckItem2.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.SpreadsheetCommandBarCheckItem2.CommandName = "ViewShowHeadings"
        Me.SpreadsheetCommandBarCheckItem2.Id = 2
        Me.SpreadsheetCommandBarCheckItem2.Name = "SpreadsheetCommandBarCheckItem2"
        '
        'SpreadsheetCommandBarButtonItem1
        '
        Me.SpreadsheetCommandBarButtonItem1.CommandName = "ViewZoomOut"
        Me.SpreadsheetCommandBarButtonItem1.Id = 3
        Me.SpreadsheetCommandBarButtonItem1.Name = "SpreadsheetCommandBarButtonItem1"
        '
        'SpreadsheetCommandBarButtonItem2
        '
        Me.SpreadsheetCommandBarButtonItem2.CommandName = "ViewZoomIn"
        Me.SpreadsheetCommandBarButtonItem2.Id = 4
        Me.SpreadsheetCommandBarButtonItem2.Name = "SpreadsheetCommandBarButtonItem2"
        '
        'SpreadsheetCommandBarButtonItem3
        '
        Me.SpreadsheetCommandBarButtonItem3.CommandName = "ViewZoom100Percent"
        Me.SpreadsheetCommandBarButtonItem3.Id = 5
        Me.SpreadsheetCommandBarButtonItem3.Name = "SpreadsheetCommandBarButtonItem3"
        '
        'SpreadsheetCommandBarButtonItem8
        '
        Me.SpreadsheetCommandBarButtonItem8.CommandName = "FileNew"
        Me.SpreadsheetCommandBarButtonItem8.Id = 11
        Me.SpreadsheetCommandBarButtonItem8.Name = "SpreadsheetCommandBarButtonItem8"
        '
        'SpreadsheetCommandBarButtonItem9
        '
        Me.SpreadsheetCommandBarButtonItem9.CommandName = "FileOpen"
        Me.SpreadsheetCommandBarButtonItem9.Id = 12
        Me.SpreadsheetCommandBarButtonItem9.Name = "SpreadsheetCommandBarButtonItem9"
        '
        'SpreadsheetCommandBarButtonItem10
        '
        Me.SpreadsheetCommandBarButtonItem10.CommandName = "FileSave"
        Me.SpreadsheetCommandBarButtonItem10.Id = 13
        Me.SpreadsheetCommandBarButtonItem10.Name = "SpreadsheetCommandBarButtonItem10"
        '
        'SpreadsheetCommandBarButtonItem11
        '
        Me.SpreadsheetCommandBarButtonItem11.CommandName = "FileSaveAs"
        Me.SpreadsheetCommandBarButtonItem11.Id = 14
        Me.SpreadsheetCommandBarButtonItem11.Name = "SpreadsheetCommandBarButtonItem11"
        Me.SpreadsheetCommandBarButtonItem11.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'SpreadsheetCommandBarButtonItem12
        '
        Me.SpreadsheetCommandBarButtonItem12.CommandName = "FileQuickPrint"
        Me.SpreadsheetCommandBarButtonItem12.Id = 15
        Me.SpreadsheetCommandBarButtonItem12.Name = "SpreadsheetCommandBarButtonItem12"
        '
        'SpreadsheetCommandBarButtonItem13
        '
        Me.SpreadsheetCommandBarButtonItem13.CommandName = "FilePrint"
        Me.SpreadsheetCommandBarButtonItem13.Id = 16
        Me.SpreadsheetCommandBarButtonItem13.Name = "SpreadsheetCommandBarButtonItem13"
        '
        'SpreadsheetCommandBarButtonItem14
        '
        Me.SpreadsheetCommandBarButtonItem14.CommandName = "FilePrintPreview"
        Me.SpreadsheetCommandBarButtonItem14.Id = 17
        Me.SpreadsheetCommandBarButtonItem14.Name = "SpreadsheetCommandBarButtonItem14"
        '
        'SpreadsheetCommandBarButtonItem15
        '
        Me.SpreadsheetCommandBarButtonItem15.CommandName = "FileUndo"
        Me.SpreadsheetCommandBarButtonItem15.Id = 18
        Me.SpreadsheetCommandBarButtonItem15.Name = "SpreadsheetCommandBarButtonItem15"
        '
        'SpreadsheetCommandBarButtonItem16
        '
        Me.SpreadsheetCommandBarButtonItem16.CommandName = "FileRedo"
        Me.SpreadsheetCommandBarButtonItem16.Id = 19
        Me.SpreadsheetCommandBarButtonItem16.Name = "SpreadsheetCommandBarButtonItem16"
        '
        'SpreadsheetCommandBarButtonItem17
        '
        Me.SpreadsheetCommandBarButtonItem17.CommandName = "FileShowDocumentProperties"
        Me.SpreadsheetCommandBarButtonItem17.Id = 20
        Me.SpreadsheetCommandBarButtonItem17.Name = "SpreadsheetCommandBarButtonItem17"
        '
        'BarButtonSaveAS
        '
        Me.BarButtonSaveAS.Caption = "Save As"
        Me.BarButtonSaveAS.Id = 1
        Me.BarButtonSaveAS.ImageOptions.Image = CType(resources.GetObject("BarButtonSaveAS.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonSaveAS.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonSaveAS.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonSaveAS.Name = "BarButtonSaveAS"
        '
        'FileRibbonPage1
        '
        Me.FileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.CommonRibbonPageGroup1, Me.InfoRibbonPageGroup1})
        Me.FileRibbonPage1.Name = "FileRibbonPage1"
        '
        'CommonRibbonPageGroup1
        '
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem8)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem9)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem10)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.BarButtonSaveAS)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem11)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem12)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem13)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem14)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem15)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem16)
        Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
        '
        'InfoRibbonPageGroup1
        '
        Me.InfoRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem17)
        Me.InfoRibbonPageGroup1.Name = "InfoRibbonPageGroup1"
        '
        'ViewRibbonPage1
        '
        Me.ViewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ShowRibbonPageGroup1, Me.ZoomRibbonPageGroup1})
        Me.ViewRibbonPage1.Name = "ViewRibbonPage1"
        '
        'ShowRibbonPageGroup1
        '
        Me.ShowRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarCheckItem1)
        Me.ShowRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarCheckItem2)
        Me.ShowRibbonPageGroup1.Name = "ShowRibbonPageGroup1"
        '
        'ZoomRibbonPageGroup1
        '
        Me.ZoomRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem1)
        Me.ZoomRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem2)
        Me.ZoomRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem3)
        Me.ZoomRibbonPageGroup1.Name = "ZoomRibbonPageGroup1"
        '
        'spreadsheetControl
        '
        Me.spreadsheetControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spreadsheetControl.Location = New System.Drawing.Point(0, 25)
        Me.spreadsheetControl.MenuManager = Me.ribbonControl
        Me.spreadsheetControl.Name = "spreadsheetControl"
        Me.spreadsheetControl.Options.Behavior.CreateNew = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.spreadsheetControl.Options.Behavior.Open = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.spreadsheetControl.Options.Behavior.Save = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.spreadsheetControl.Options.Behavior.SaveAs = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.spreadsheetControl.Options.Behavior.Worksheet.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.spreadsheetControl.Options.Behavior.Worksheet.Hide = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.spreadsheetControl.Options.Behavior.Worksheet.Rename = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.spreadsheetControl.Options.DocumentCapabilities.Charts = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.spreadsheetControl.Options.DocumentCapabilities.Shapes = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.spreadsheetControl.Options.DocumentCapabilities.Sparklines = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.spreadsheetControl.Options.Import.Csv.Encoding = CType(resources.GetObject("spreadsheetControl.Options.Import.Csv.Encoding"), System.Text.Encoding)
        Me.spreadsheetControl.Options.Import.Txt.Encoding = CType(resources.GetObject("spreadsheetControl.Options.Import.Txt.Encoding"), System.Text.Encoding)
        Me.spreadsheetControl.Size = New System.Drawing.Size(790, 528)
        Me.spreadsheetControl.TabIndex = 1
        Me.spreadsheetControl.Text = "spreadsheetControl1"
        '
        'spreadsheetFormulaBarPanel
        '
        Me.spreadsheetFormulaBarPanel.Controls.Add(Me.spreadsheetControl)
        Me.spreadsheetFormulaBarPanel.Controls.Add(Me.splitterControl)
        Me.spreadsheetFormulaBarPanel.Controls.Add(Me.formulaBarNameBoxSplitContainerControl)
        Me.spreadsheetFormulaBarPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spreadsheetFormulaBarPanel.Location = New System.Drawing.Point(0, 143)
        Me.spreadsheetFormulaBarPanel.Name = "spreadsheetFormulaBarPanel"
        Me.spreadsheetFormulaBarPanel.Size = New System.Drawing.Size(790, 553)
        Me.spreadsheetFormulaBarPanel.TabIndex = 3
        '
        'splitterControl
        '
        Me.splitterControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.splitterControl.Location = New System.Drawing.Point(0, 20)
        Me.splitterControl.MinSize = 20
        Me.splitterControl.Name = "splitterControl"
        Me.splitterControl.Size = New System.Drawing.Size(790, 5)
        Me.splitterControl.TabIndex = 2
        Me.splitterControl.TabStop = False
        '
        'formulaBarNameBoxSplitContainerControl
        '
        Me.formulaBarNameBoxSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.formulaBarNameBoxSplitContainerControl.Location = New System.Drawing.Point(0, 0)
        Me.formulaBarNameBoxSplitContainerControl.MinimumSize = New System.Drawing.Size(0, 20)
        Me.formulaBarNameBoxSplitContainerControl.Name = "formulaBarNameBoxSplitContainerControl"
        Me.formulaBarNameBoxSplitContainerControl.Panel1.Controls.Add(Me.spreadsheetNameBoxControl)
        Me.formulaBarNameBoxSplitContainerControl.Panel2.Controls.Add(Me.spreadsheetFormulaBarControl1)
        Me.formulaBarNameBoxSplitContainerControl.Size = New System.Drawing.Size(790, 20)
        Me.formulaBarNameBoxSplitContainerControl.SplitterPosition = 145
        Me.formulaBarNameBoxSplitContainerControl.TabIndex = 3
        '
        'spreadsheetNameBoxControl
        '
        Me.spreadsheetNameBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spreadsheetNameBoxControl.EditValue = "A1"
        Me.spreadsheetNameBoxControl.Location = New System.Drawing.Point(0, 0)
        Me.spreadsheetNameBoxControl.Name = "spreadsheetNameBoxControl"
        Me.spreadsheetNameBoxControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spreadsheetNameBoxControl.Size = New System.Drawing.Size(145, 20)
        Me.spreadsheetNameBoxControl.SpreadsheetControl = Me.spreadsheetControl
        Me.spreadsheetNameBoxControl.TabIndex = 0
        '
        'spreadsheetFormulaBarControl1
        '
        Me.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spreadsheetFormulaBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.spreadsheetFormulaBarControl1.MinimumSize = New System.Drawing.Size(0, 20)
        Me.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1"
        Me.spreadsheetFormulaBarControl1.Size = New System.Drawing.Size(640, 20)
        Me.spreadsheetFormulaBarControl1.SpreadsheetControl = Me.spreadsheetControl
        Me.spreadsheetFormulaBarControl1.TabIndex = 0
        '
        'SpreadsheetBarController1
        '
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarCheckItem1)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarCheckItem2)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem1)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem2)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem3)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem8)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem9)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem10)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem11)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem12)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem13)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem14)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem15)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem16)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem17)
        Me.SpreadsheetBarController1.Control = Me.spreadsheetControl
        '
        'DockManager1
        '
        Me.DockManager1.DockingOptions.HideImmediatelyOnAutoHide = True
        Me.DockManager1.DockMode = DevExpress.XtraBars.Docking.Helpers.DockMode.Standard
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel.ID = New System.Guid("3084723e-0ec6-429c-8339-77c3319cbba6")
        Me.DockPanel.Location = New System.Drawing.Point(790, 143)
        Me.DockPanel.Name = "DockPanel"
        Me.DockPanel.Options.AllowDockAsTabbedDocument = False
        Me.DockPanel.Options.AllowDockBottom = False
        Me.DockPanel.Options.AllowDockFill = False
        Me.DockPanel.Options.AllowDockLeft = False
        Me.DockPanel.Options.AllowDockTop = False
        Me.DockPanel.Options.AllowFloating = False
        Me.DockPanel.Options.FloatOnDblClick = False
        Me.DockPanel.Options.ResizeDirection = DevExpress.XtraBars.Docking.Helpers.ResizeDirection.Left
        Me.DockPanel.Options.ShowCloseButton = False
        Me.DockPanel.Options.ShowMaximizeButton = False
        Me.DockPanel.OriginalSize = New System.Drawing.Size(310, 200)
        Me.DockPanel.Size = New System.Drawing.Size(310, 553)
        Me.DockPanel.Text = "SAP Pricing Operations"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(301, 526)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'SapPricingDataset1
        '
        Me.SapPricingDataset1.DataSetName = "SapPricingDataset1"
        Me.SapPricingDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'Pricing
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 696)
        Me.Controls.Add(Me.spreadsheetFormulaBarPanel)
        Me.Controls.Add(Me.DockPanel)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "Pricing"
        Me.Ribbon = Me.ribbonControl
        Me.Text = "Pricing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spreadsheetFormulaBarPanel.ResumeLayout(False)
        CType(Me.formulaBarNameBoxSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.formulaBarNameBoxSplitContainerControl.ResumeLayout(False)
        CType(Me.spreadsheetNameBoxControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpreadsheetBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel.ResumeLayout(False)
        CType(Me.SapPricingDataset1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents spreadsheetFormulaBarPanel As System.Windows.Forms.Panel
    Private WithEvents splitterControl As DevExpress.XtraEditors.SplitterControl
    Private WithEvents formulaBarNameBoxSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Private WithEvents spreadsheetNameBoxControl As DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl
    Private WithEvents spreadsheetFormulaBarControl1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl
    Friend WithEvents SpreadsheetBarController1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController
    'Friend WithEvents SpreadsheetCommandBarButtonItem158 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    'Friend WithEvents SpreadsheetCommandBarButtonItem160 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    'Friend WithEvents SpreadsheetCommandBarButtonItem161 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    'Friend WithEvents SpreadsheetCommandBarButtonItem162 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    'Friend WithEvents SpreadsheetCommandBarButtonItem163 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    'Friend WithEvents SpreadsheetCommandBarButtonItem164 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    'Friend WithEvents SpreadsheetCommandBarButtonItem175 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    'Friend WithEvents SpreadsheetCommandBarButtonItem176 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    'Friend WithEvents SpreadsheetCommandBarCheckItem41 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
    'Friend WithEvents SpreadsheetCommandBarButtonItem177 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    'Friend WithEvents SpreadsheetCommandBarButtonItem178 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    'Friend WithEvents UserControl11 As UserControl1
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer

    Friend WithEvents SapPricingDataset1 As SapCSDataSet
    Friend WithEvents SpreadsheetCommandBarCheckItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
    Friend WithEvents SpreadsheetCommandBarCheckItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
    Friend WithEvents SpreadsheetCommandBarButtonItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents FileRibbonPage1 As DevExpress.XtraSpreadsheet.UI.FileRibbonPage
    Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup
    Friend WithEvents InfoRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup
    Friend WithEvents ViewRibbonPage1 As DevExpress.XtraSpreadsheet.UI.ViewRibbonPage
    Friend WithEvents ShowRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ShowRibbonPageGroup
    Friend WithEvents ZoomRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ZoomRibbonPageGroup
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents BarButtonSaveAS As DevExpress.XtraBars.BarButtonItem
    Public WithEvents spreadsheetControl As DevExpress.XtraSpreadsheet.SpreadsheetControl
End Class
