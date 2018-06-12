Imports System.ComponentModel
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors



Public Class Form10
    Dim initialWidth As Integer = -1
    Sub New()
        InitSkins()
        InitializeComponent()

    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        ' UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
        UserLookAndFeel.Default.SetSkinStyle(My.Settings.skin)
    End Sub

    Private Sub navBarControl_Click(sender As System.Object, e As System.EventArgs) Handles navBarControl.Click

    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonth.LinkClicked

        Dim formgrid As New FormPivotMesFull
        With formgrid

            .vartabela = "Sapsales"
            .MdiParent = Me
            .Show()
        End With



      
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
       
    End Sub

   
End Class
