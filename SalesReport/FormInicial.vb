Imports DevExpress.LookAndFeel
Imports System.Data.SQLite
Imports System.Net

'Imports System.Threading.Tasks
'Imports System.Threading

Public Class FormInicial

    Public utilizador As String
    Sub New()
        InitSkins()
        InitializeComponent()

        utilizador = UCase(GetSetting("SalesReports", "User", "login"))
        Me.HtmlText = "Commercial System " & Application.ProductVersion
        Me.HtmlText = Me.Text & " - (Last update: " & GetSetting("SalesReports", "Updated", "date") & ")"
        Me.HtmlText = Me.Text & " - <b><i><color=yellow>" & utilizador & "</i></b>"


    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle(My.Settings.skin)
    End Sub

    Private Sub NavBarItemByMonth_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonth.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "Sapsales"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Current Sales"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default

    End Sub


    Private Sub NavBarItemByMonth9L_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonth9L.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "Sapsales"
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "By Month 9L"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub NavBarItemByMonth9L_1_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonth9L_1.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "Sapsales"
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "By Month 9L Last Year"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemHistoric9L_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemHistoric.LinkClicked


        Cursor.Current = Cursors.WaitCursor

        Dim FormTreeshist As New FormTreesHist


        With FormTreeshist
            .MdiParent = Me
            .varTabela = "SalesHistorico"
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "History 9L/€"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler FormTreeshist.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default

    End Sub




    Private Sub NavBarItemByMonthComp_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthComp.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "Sapsales"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Sales Comparison"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub NavBarItemByMonthCompLY_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthCompLY.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "Sapsales"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Sales Comparison LY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub NavBarItemIVDP_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemIVDP.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesTrade

        With Formtrees
            .MdiParent = Me

            .varTabela = "SapIVDP"

            .varDatabase = "c:\CommercialSystem\dados\Sapivdp.db3"

            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub



    Private Sub MdiChildClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        ' At this time, the MDI parent's MdiChildren.Length still returns 1
        If (Me.MdiChildren.Length = 1) Then
            navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
        End If
    End Sub


    Private Sub NavBarEditProdPricing_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
        Cursor.Current = Cursors.WaitCursor


        Dim process As New Process()
        Try
            process.StartInfo.FileName = "c:\CommercialSystem\PricingExcelSap.xlsx"
            process.Start()
            process.WaitForInputIdle()
        Catch
        End Try

        Cursor.Current = Cursors.Default
    End Sub



    Private Sub NavBarItemUpload_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemUpload.LinkClicked
        Cursor.Current = Cursors.WaitCursor

        Dim ftp As New Pricing.exportXML

        ftp.ShowDialog()



        Cursor.Current = Cursors.Default
    End Sub



    Private Sub navBarControl_ActiveGroupChanged(sender As System.Object, e As DevExpress.XtraNavBar.NavBarGroupEventArgs) Handles navBarControl.ActiveGroupChanged

        If e.Group.Name = "NavBarGroupPricing" Then
            Timer1.Start()
            Timer2.Start()
        Else
            Timer1.Stop()
            Timer2.Start()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Dim sqlcommand1 As New SQLiteCommand
        'Dim SqlConnection1 As New SQLiteConnection
        'SqlConnection1.ConnectionString = "data source=c:\CommercialSystem\dados\SapPricingupdate.db3"
        'sqlcommand1.CommandText = "SELECT COUNT(PCCPRO) AS quantos FROM paprixf"
        'sqlcommand1.CommandType = CommandType.Text
        'sqlcommand1.Connection = SqlConnection1
        'SqlConnection1.Open()
        'Dim ret As Integer = sqlcommand1.ExecuteScalar
        'SqlConnection1.Close()
        'sqlcommand1.Dispose()

        'If ret > 0 Then
        '    Try
        '        If My.Computer.Network.Ping("192.168.0.231") Then
        '            NavBarItemUpload.Enabled = True
        '            NavBarItemCancelUpload.Enabled = True
        '        Else
        '            NavBarItemUpload.Enabled = False
        '            NavBarItemCancelUpload.Enabled = True
        '        End If
        '    Catch
        '        NavBarItemUpload.Enabled = False
        '        NavBarItemCancelUpload.Enabled = True
        '    End Try
        'Else
        '    NavBarItemUpload.Enabled = False
        '    NavBarItemCancelUpload.Enabled = False
        'End If


        Dim objFileInfo As New IO.FileInfo("c:\CommercialSystem\dados\SapCS.zip")
        'To get the creation, lastaccess, lastwrite time of this file
        Dim dtLastWriteTime As DateTime = objFileInfo.LastWriteTime
        Try
            '  Dim objFileInfo2 As New IO.FileInfo("\\srvsymdata\CommercialSystem\SapCS.zip")
            'Dim dtLastWriteTime2 As DateTime = objFileInfo2.LastWriteTime
            Dim dtLastWriteTime2 As DateTime = ftpgetdate()
            If dtLastWriteTime < dtLastWriteTime2 Then
                NavBarItemUpdatePricing.Enabled = True
            Else
                NavBarItemUpdatePricing.Enabled = False
            End If
        Catch ex As Exception
            NavBarItemUpdatePricing.Enabled = False
        End Try




    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim sqlcommand1 As New SQLiteCommand
        Dim SqlConnection1 As New SQLiteConnection
        SqlConnection1.ConnectionString = "data source=c:\CommercialSystem\dados\SapPricingupdate.db3"
        sqlcommand1.CommandText = "SELECT COUNT(PCCPRO) AS quantos FROM paprixf"
        sqlcommand1.CommandType = CommandType.Text
        sqlcommand1.Connection = SqlConnection1
        SqlConnection1.Open()
        Dim ret As Integer = sqlcommand1.ExecuteScalar
        SqlConnection1.Close()
        sqlcommand1.Dispose()

        If ret > 0 Then
            Try
                If My.Computer.Network.Ping("192.168.0.231") Then
                    NavBarItemUpload.Enabled = True
                    NavBarItemCancelUpload.Enabled = True
                Else
                    NavBarItemUpload.Enabled = False
                    NavBarItemCancelUpload.Enabled = True
                End If
            Catch
                NavBarItemUpload.Enabled = False
                NavBarItemCancelUpload.Enabled = True
            End Try
        Else
            NavBarItemUpload.Enabled = False
            NavBarItemCancelUpload.Enabled = False
        End If

    End Sub

    Private Sub NavBarItemUpdatePricing_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemUpdatePricing.LinkClicked

        Dim ret As MsgBoxResult
        ret = MsgBox("Do you want to update Pricings?", MsgBoxStyle.YesNoCancel, "Update Commercial System")
        If ret = vbNo Then Exit Sub
        If ret = MsgBoxResult.Cancel Then End
        Cursor.Current = Cursors.WaitCursor

        'Dim formcopylive As New FormCopy
        'formcopylive.Show()
        'Cursor.Current = Cursors.WaitCursor

        'formcopylive.button1_Click("\\srvsymdata\CommercialSystem\SapCS.zip", "c:\CommercialSystem\dados\SapCS.zip")
        'Dim formunziplive As New FormUnzip
        'formunziplive.ficheiro = "SapPricing"
        'formunziplive.Show()
        'UnzipFile("c:\CommercialSystem\dados\SapCS.zip", "c:\CommercialSystem\dados\SapCS.db3")
        'formunziplive.Close()
        'formcopylive.Close()

        Try
            Dim formcopyftp As New FormCopyFTP
            formcopyftp.Show()
            Cursor.Current = Cursors.WaitCursor

            formcopyftp.button1_Click("SapCS.zip", "c:\CommercialSystem\dados\SapCS.zip")

            formcopyftp.Close()
        Catch
            MsgBox("Problems accessing Ftp.")
        End Try

        NavBarItemUpdatePricing.Enabled = False
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub NavBarItemCancelUpload_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemCancelUpload.LinkClicked
        Dim ret As MsgBoxResult
        ret = MsgBox("Are you sure?", MsgBoxStyle.YesNo)
        If ret = MsgBoxResult.Yes Then
            Dim SqlConnection1 As New SQLiteConnection
            Dim sqlcommand1 As SQLiteCommand
            SqlConnection1.ConnectionString = "data source=c:\CommercialSystem\dados\SapPricingupdate.db3"
            SqlConnection1.Open()
            sqlcommand1 = New SQLiteCommand("DELETE FROM paprixf", SqlConnection1)
            sqlcommand1.ExecuteScalar()

            Dim sqlcommand2 As SQLiteCommand
            sqlcommand2 = New SQLiteCommand("DELETE FROM SapEstipulacoes", SqlConnection1)
            sqlcommand2.ExecuteScalar()


            SqlConnection1.Close()
        End If
    End Sub


    Private Sub NavBarItemForecast_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemForecast.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim FormSymFIT As New SymFit.Form1

        With FormSymFIT
            .MdiParent = Me
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler FormSymFIT.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub FormInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged, AddressOf UserLookAndFeel_StyleChanged

        Select Case utilizador
            Case "SYMINGTON\PV"
                NavBarItemCreateForeca.Enabled = True
                NavBarItemExportForeca.Enabled = True
                NavBarItemForecast.Enabled = True
                NavBarItemForecastStat.Enabled = True
                NavBarExport.Enabled = True
                NavBarExportStat.Enabled = True
            'NavBarItemCreateForecInhandPeriod2.Visible = True
            Case "SYMINGTON\HS", "SYMINGTON\MMC"
                NavBarItemCreateForeca.Enabled = True
                NavBarItemExportForeca.Enabled = True
                NavBarItemForecast.Enabled = True
                NavBarItemForecastStat.Enabled = True
                NavBarExport.Enabled = True
                NavBarExportStat.Enabled = True

            Case "SYMINGTON\ARSC"
                NavBarExport.Enabled = True
                NavBarExportStat.Enabled = True
                NavBarItemForecast.Enabled = True
                NavBarItemForecastStat.Enabled = True


            'Ana Rodrigues, Emiliano Di Renzo ; Francisco Cepeda; Gonçalo Aragão e Brito ; Gustavo Devesas ; Henry Shotton ; Isabel Monteiro ; João Vasconcelos ; Jorge Nunes ; Mariana Brito ; Miguel Ferreira ; Pedro Leite ; Rui Ribeiro ; Dominic Symington ; Euan Mackay ; Johnny Symington ; José Alvares Ribeiro ; Luis Martins ; Paul Symington ; Rupert Symington 
            Case "SYMINGTON\ACR", "SYMINGTON\EDR", "SYMINGTON\FSC", "SYMINGTON\GAB", "SYMINGTON\GRD", "SYMINGTON\HJS", "SYMINGTON\IPM", "SYMINGTON\JMV", "SYMINGTON\JVN", "SYMINGTON\MFB", "SYMINGTON\MFF", "SYMINGTON\PFL", "SYMINGTON\FRS", "SYMINGTON\RJR", "SYMINGTON\DMS", "SYMINGTON\EMM", "SYMINGTON\JADS", "SYMINGTON\JAR", "SYMINGTON\LMM", "SYMINGTON\PDS", "SYMINGTON\RADS", "SYMINGTON\RDTS", "COMERC_JVN\JORGE", "SYMINGTON\JMCR", "SYMINGTON\AJV", "SYMINGTON\MCG", "SYMINGTON\ARSC", "DESKTOP-7RA9PT2\SOFIAZHANG"
                NavBarExport.Enabled = True
                NavBarExportStat.Enabled = True


            Case "SYMINGTON\IF", "SYMINGTON\LS", "SYMINGTON\PAM", "SYMINGTON\MAC", "SYMINGTON\TC", "SYMINGTON\MLL", "SYMINGTON\MAM", "SYMINGTON\FCL", "SYMINGTON\CLC", "SYMINGTON\MTB", "SYMINGTON\JMCR", "SYMINGTON\RVB", "SYMINGTON\RAP"
                NavBarItemForecast.Enabled = True
                NavBarItemForecastStat.Enabled = True


            Case "SYMINGTON\SYMINOV"
                NavBarItemCreateForeca.Enabled = False
                NavBarItemExportForeca.Enabled = False
                NavBarItemForecast.Enabled = False
                NavBarItemForecastStat.Enabled = False
                NavBarExport.Enabled = False
                NavBarExportStat.Enabled = False
                EditPricing = False
                ViewPricing = False

        End Select
        If EditPricing = False Then

            NavBarItemCancelUpload.Enabled = False
            NavBarItemUpdatePricing.Enabled = False
            NavBarItemUpload.Enabled = False
            NavBarEditPricing.Enabled = False
        End If

        If ViewPricing = False Then

            NavBarEditPricing.Enabled = False
        End If


    End Sub

    Private Sub NavBarItemCreateForeca_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemCreateForeca.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim FormCreateFQ As New Forecast.CreateForecast

        With FormCreateFQ
            .MdiParent = Me
            .Show()

        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler FormCreateFQ.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub NavBarItem365_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem365.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "Sapsales"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "MAT"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub



    Private Sub NavBarItemExportForeca_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemExportForeca.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim FormCreateFQ As New Forecast.CreateForecast

        With FormCreateFQ
            .MdiParent = Me
            .ExportSAP = True
            .Show()

        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler FormCreateFQ.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub



    Private Sub NavBarItemByMonthCompThisyear_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthCompThisyear.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "Sapsales"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Sales Comparison TY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthLY_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthLY.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "Sapsales"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Sales LY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub



    Private Sub NavBarItemForecastStat_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemForecastStat.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formedit As New CSForecast.FormEditForecastSTAT

        With Formedit
            .MdiParent = Me
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formedit.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub



    Private Sub NavBarExport_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarExport.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim FormforecaAll As New CSForecast.FormForecastAll

        With FormforecaAll
            .MdiParent = Me
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler FormforecaAll.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarExportStat_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarExportStat.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim FormforecaStatAll As New CSForecast.FormForecastSTATAll

        With FormforecaStatAll
            .MdiParent = Me
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler FormforecaStatAll.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub NavBarItemByMonthPack_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthPack.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesCompostos"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Packs - Current Sales"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthLYPack_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthLYPack.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesCompostos"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Packs - Sales LY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthCompPack_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthCompPack.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesCompostos"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Packs - Sales Comparison"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthCompThisyearPack_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthCompThisyearPack.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesCompostos"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Packs - Sales Comparison TY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthCompLYPack_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthCompLYPack.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesCompostos"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Packs - Sales Comparison LY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItem365Pack_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem365Pack.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesCompostos"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Packs - MAT"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonth9LPack_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonth9LPack.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesCompostos"
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Packs - By Month 9L"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonth9L_1Pack_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonth9L_1Pack.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesCompostos"
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Packs - By Month 9L Last Year"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthSamples_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthSamples.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesAmostras"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Samples - Current"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthLYSamples_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthLYSamples.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesAmostras"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "Samples - LY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub


    Private Function ftpgetdate() As DateTime

        Dim usn As String = "CommercialSystem\pedroventura"
        Dim PWD As String = "gusto8720"
        Dim ftpfullURI As String = "ftp://waws-prod-am2-019.ftp.azurewebsites.windows.net/"
        Dim FTPRequest As FtpWebRequest = FtpWebRequest.Create(ftpfullURI & "/" & "SapCS.zip")

        With FTPRequest
            .EnableSsl = False
            .Credentials = New NetworkCredential(usn, PWD)
            .KeepAlive = False
            .UseBinary = True
            .UsePassive = True
            .Method = WebRequestMethods.Ftp.GetDateTimestamp
        End With

        Dim response As FtpWebResponse = FTPRequest.GetResponse()
        Dim lastModifiedDate As DateTime = response.LastModified
        Return lastModifiedDate
    End Function



    Private Sub NavBarEditPricing_LinkClicked_1(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarEditPricing.LinkClicked
        Cursor.Current = Cursors.WaitCursor

        Dim process2 As New SAP_Pricing.Pricing

        With process2
            .MdiParent = Me
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler process2.FormClosed, AddressOf MdiChildClosed

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub navBarControl_Click(sender As Object, e As EventArgs) Handles navBarControl.Click

    End Sub

    ''' <summary>
    ''' ''''''''
    ''' '''''''''''''''
    ''' '''''''''''''''
    ''' 'old reserves
    ''' '''''''''''''''''
    ''' .........
    ''' .......
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub NavBarItemByMonthOldRes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthOldRes.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesOldReserves"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "OldReserves - Current Sales"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthLYOldRes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthLYOldRes.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesOldReserves"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "OldReserves - Sales LY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthCompOldRes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthCompOldRes.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesOldReserves"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "OldReserves - Sales Comparison"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthCompThisyearOldRes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthCompThisyearOldRes.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesOldReserves"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "OldReserves - Sales Comparison TY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthCompLYOldRes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthCompLYOldRes.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesOldReserves"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "OldReserves - Sales Comparison LY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItem365OldRes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem365OldRes.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesOldReserves"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "OldReserves - MAT"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonth9LOldRes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonth9LOldRes.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesOldReserves"
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "OldReserves - By Month 9L"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonth9L_1OldRes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonth9L_1OldRes.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapsalesOldReserves"
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Text = "OldReserves - By Month 9L Last Year"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub



    ''' <summary>
    ''' ''''''''
    ''' '''''''''''''''
    ''' '''''''''''''''
    ''' 'German Warehouse
    ''' '''''''''''''''''
    ''' .........
    ''' .......
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub NavBarItemByMonthGer_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthGer.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapSalesGermanWarehouse"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .Label1.Text = "German Warehouse - Current Sales"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthLYGer_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthLYGer.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapSalesGermanWarehouse"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .Label1.Text = "German Warehouse - Sales LY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthCompGer_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthCompGer.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapSalesGermanWarehouse"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .Label1.Text = "German Warehouse - Sales Comparison"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthCompThisyearGer_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthCompThisyearGer.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapSalesGermanWarehouse"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .Label1.Text = "German Warehouse - Sales Comparison TY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonthCompLYGer_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonthCompLYGer.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapSalesGermanWarehouse"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .Label1.Text = "German Warehouse - Sales Comparison LY"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItem365Ger_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem365Ger.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapSalesGermanWarehouse"
            .flagValores = True
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .Label1.Text = "German Warehouse - MAT"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonth9LGer_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonth9LGer.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapSalesGermanWarehouse"
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .Label1.Text = "German Warehouse - By Month 9L"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub NavBarItemByMonth9L_1Ger_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemByMonth9L_1Ger.LinkClicked
        Cursor.Current = Cursors.WaitCursor
        Dim Formtrees As New FormTreesPivot

        With Formtrees
            .MdiParent = Me
            .varTabela = "SapSalesGermanWarehouse"
            .varDatabase = "c:\CommercialSystem\dados\SapCS.db3"
            .Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .Label1.Text = "German Warehouse - By Month 9L Last Year"
            .Show()
        End With
        navBarControl.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        AddHandler Formtrees.FormClosed, AddressOf MdiChildClosed
        Cursor.Current = Cursors.Default
    End Sub











    Private Shared Sub UserLookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim skin As DevExpress.Skins.Skin = DevExpress.Skins.CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        If My.Settings.skin <> skin.Name Then
            My.Settings.skin = skin.Name
            My.Settings.Save()
        End If
    End Sub

    Private Sub NavBarItemPowerBI_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemPowerBI.LinkClicked
        'Process.Start("https://app.powerbi.com/groups/me/dashboards/149b7df2-cecc-4f07-9394-60ff6c8fdfd7/")
        Process.Start("https://app.powerbi.com/groups/me/dashboards/02bbeb8e-56e1-4935-ab1d-214771f0d4e9/")
    End Sub
End Class
