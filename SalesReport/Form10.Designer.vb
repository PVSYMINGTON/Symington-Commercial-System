Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits XtraForm

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
        Me.navBarControl = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItemByMonth = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'navBarControl
        '
        Me.navBarControl.ActiveGroup = Me.NavBarGroup1
        Me.navBarControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.navBarControl.Dock = System.Windows.Forms.DockStyle.Left
        Me.navBarControl.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1, Me.NavBarGroup2})
        Me.navBarControl.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItemByMonth, Me.NavBarItem1, Me.NavBarItem2, Me.NavBarItem6})
        Me.navBarControl.Location = New System.Drawing.Point(0, 0)
        Me.navBarControl.Name = "navBarControl"
        Me.navBarControl.OptionsNavPane.ExpandedWidth = 145
        Me.navBarControl.OptionsNavPane.ShowOverflowPanel = False
        Me.navBarControl.SelectLinkOnPress = False
        Me.navBarControl.Size = New System.Drawing.Size(152, 550)
        Me.navBarControl.TabIndex = 2
        Me.navBarControl.Text = " "
        Me.navBarControl.View = New DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator()
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "9L Sales "
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItemByMonth), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1)})
        Me.NavBarGroup1.LargeImage = Global.CommercialSystem.My.Resources.Resources.Sales_9L
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarItemByMonth
        '
        Me.NavBarItemByMonth.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NavBarItemByMonth.Appearance.Options.UseFont = True
        Me.NavBarItemByMonth.Caption = "By Month"
        Me.NavBarItemByMonth.Name = "NavBarItemByMonth"
        Me.NavBarItemByMonth.SmallImage = Global.CommercialSystem.My.Resources.Resources.toolbar_pivot_table_icon
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "By Month Last Year"
        Me.NavBarItem1.Name = "NavBarItem1"
        Me.NavBarItem1.SmallImage = Global.CommercialSystem.My.Resources.Resources.toolbar_pivot_table_icon
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Sales Values"
        Me.NavBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2)})
        Me.NavBarGroup2.LargeImage = Global.CommercialSystem.My.Resources.Resources.Crystal_Clear_app_kspread
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "By Month"
        Me.NavBarItem2.Name = "NavBarItem2"
        Me.NavBarItem2.SmallImage = Global.CommercialSystem.My.Resources.Resources.toolbar_pivot_table_icon
        '
        'NavBarItem6
        '
        Me.NavBarItem6.Caption = "NavBarItem6"
        Me.NavBarItem6.Name = "NavBarItem6"
        '
        'DocumentManager1
        '
        Me.DocumentManager1.MdiParent = Me
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 550)
        Me.Controls.Add(Me.navBarControl)
        Me.IsMdiContainer = True
        Me.LookAndFeel.SkinName = "Dark Side"
        Me.Name = "Form10"
        Me.Text = "Form1"
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents navBarControl As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItemByMonth As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem6 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

End Class
