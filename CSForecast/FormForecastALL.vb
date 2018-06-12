Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins

Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.Common
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
#Disable Warning BC40056 ' Namespace or type specified in the Imports 'System.Data.Objects' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports System.Data.Objects
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'System.Data.Objects' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports System.Linq
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Data.Entity.Core.Objects

Public Class FormForecastAll

    Dim prevcolumn As Columns.GridColumn = Nothing
    Dim prevrow As Integer = -1
    Dim utilizador As String
    Dim db As New SalesSystemEntities
    ' Dim ForecastLista As New List(Of SapForecast)
    '  Dim SalesForForecastConsulta As ObjectQuery(Of SapImmaterialSales)
    Dim SalesForForecastConsulta2 As ObjectQuery(Of SapSalesImmaterialforForecastEdit)
    '  Dim Target9LConsulta As ObjectQuery(Of ForecastEditConsultaTarget9L)

    Dim indiceAtual As Integer
    Dim change As Boolean = False
    Dim limpou As Boolean = False
    Dim salestable As New DataTable
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()



    End Sub
    Sub InitSkins()

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle(My.Settings.skin)

    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor

        utilizador = UCase(GetSetting("SalesReports", "User", "login"))

        Dim clientesma = From p In db.SapClientsMDMMMA Select p.KUNNRMA, p.MA Distinct
        RepositoryItemLookUpEdit9.DataSource = clientesma
        RepositoryItemLookUpEdit9.ValueMember = "KUNNRMA"
        RepositoryItemLookUpEdit9.DisplayMember = "MA"
        SapClientsMDMMMABindingSource.DataSource = clientesma

        Dim clientes = From p In db.SapClients Select p.KUNNR, p.NAME1, p.LANDX50
        RepositoryItemLookUpEdit3.DataSource = clientes
        RepositoryItemLookUpEdit3.ValueMember = "KUNNR"
        RepositoryItemLookUpEdit3.DisplayMember = "NAME1"
        SapClientsBindingSource.DataSource = clientes

        Dim QuarterFQ = 4

        ''''Verificar se o periodo está aberto ou não
        ''''Verificar se o periodo está aberto ou não
        Dim cnn As New SqlConnection ' OleDbConnection
        cnn.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        cnn.Open()
        Dim sqlcommand As New SqlCommand ' OleDbCommand
        sqlcommand.Connection = cnn
        If QuarterFQ = 1 Then
            sqlcommand.CommandText = "SELECT Aberto FROM SapForecastPeriodFlag WHERE (Period = 1)"
        ElseIf QuarterFQ = 2 Then
            sqlcommand.CommandText = "SELECT Aberto FROM SapForecastPeriodFlag WHERE (Period = 2)"
        ElseIf QuarterFQ = 3 Then
            sqlcommand.CommandText = "SELECT Aberto FROM SapForecastPeriodFlag WHERE (Period = 3)"
        ElseIf QuarterFQ = 4 Then
            sqlcommand.CommandText = "SELECT Aberto FROM SapForecastPeriodFlag WHERE (Period = 4)"
        End If
        Dim Flagperiod As Boolean = sqlcommand.ExecuteScalar


        ''''Temporário para permitir alterações
        ''''Temporário para permitir alterações
        ''''Temporário para permitir alterações


        Select Case QuarterFQ ''''''''Month(Now)
            Case 1

                If Flagperiod = True Then
                    Dim item As GridColumnSummaryItem = BandedGridView1.Columns("FQ1").Summary.Item(0)
                    item.FieldName = "AnualValue"
                    BandedGridView1.Columns("FQ1").FieldName = "AnualValue"
                    BandedGridView1.Columns.ColumnByName("DiffFQAnt").UnboundExpression = "[AnualValue] - [Target]"
                Else
                    Dim item As GridColumnSummaryItem = BandedGridView1.Columns("FQ1").Summary.Item(0)
                    item.FieldName = "FQ1"
                    BandedGridView1.Columns("FQ1").FieldName = "FQ1"
                    BandedGridView1.Columns("AnualValue").Visible = True
                    BandedGridView1.Columns.ColumnByName("DiffFQAnt").UnboundExpression = "[AnualValue] - [FQ1]"
                End If

            Case 2
                BandedGridView1.Columns("Quarter1Value").OptionsColumn.ReadOnly = True
                BandedGridView1.Columns("Quarter1Value").OptionsColumn.AllowEdit = False
                BandedGridView1.Columns("Quarter1Value").AppearanceCell.BackColor = Color.Silver
                If Flagperiod = True Then
                    Dim item As GridColumnSummaryItem = BandedGridView1.Columns("FQ2").Summary.Item(0)
                    item.FieldName = "AnualValue"
                    BandedGridView1.Columns("FQ2").FieldName = "AnualValue"
                    BandedGridView1.Columns.ColumnByName("DiffFQAnt").UnboundExpression = "[AnualValue] - [FQ1]"
                Else
                    Dim item As GridColumnSummaryItem = BandedGridView1.Columns("FQ2").Summary.Item(0)
                    item.FieldName = "FQ2"
                    BandedGridView1.Columns("FQ2").FieldName = "FQ2"
                    BandedGridView1.Columns("AnualValue").Visible = True
                    BandedGridView1.Columns.ColumnByName("DiffFQAnt").UnboundExpression = "[AnualValue] - [FQ2]"

                End If
                BandedGridView1.Columns("FQ3").Visible = False
                BandedGridView1.Columns("FQ4").Visible = False

            Case 3
                BandedGridView1.Columns("Quarter1Value").OptionsColumn.ReadOnly = True
                BandedGridView1.Columns("Quarter1Value").AppearanceCell.BackColor = Color.Silver
                BandedGridView1.Columns("Quarter1Value").OptionsColumn.AllowEdit = False
                BandedGridView1.Columns("Quarter2Value").OptionsColumn.ReadOnly = True
                BandedGridView1.Columns("Quarter2Value").AppearanceCell.BackColor = Color.Silver
                BandedGridView1.Columns("Quarter2Value").OptionsColumn.AllowEdit = False
                If Flagperiod = True Then
                    Dim item As GridColumnSummaryItem = BandedGridView1.Columns("FQ3").Summary.Item(0)
                    item.FieldName = "AnualValue"
                    BandedGridView1.Columns("FQ3").FieldName = "AnualValue"
                    BandedGridView1.Columns.ColumnByName("DiffFQAnt").UnboundExpression = "[AnualValue] - [FQ2]"
                Else
                    Dim item As GridColumnSummaryItem = BandedGridView1.Columns("FQ3").Summary.Item(0)
                    item.FieldName = "FQ3"
                    BandedGridView1.Columns("FQ3").FieldName = "FQ3"
                    BandedGridView1.Columns("AnualValue").Visible = True
                    BandedGridView1.Columns.ColumnByName("DiffFQAnt").UnboundExpression = "[AnualValue] - [FQ3]"
                End If

                BandedGridView1.Columns("FQ4").Visible = False
            Case 4
                BandedGridView1.Columns("Quarter1Value").OptionsColumn.ReadOnly = True
                BandedGridView1.Columns("Quarter1Value").AppearanceCell.BackColor = Color.Silver
                BandedGridView1.Columns("Quarter1Value").OptionsColumn.AllowEdit = False
                BandedGridView1.Columns("Quarter2Value").OptionsColumn.ReadOnly = True
                BandedGridView1.Columns("Quarter2Value").AppearanceCell.BackColor = Color.Silver
                BandedGridView1.Columns("Quarter2Value").OptionsColumn.AllowEdit = False
                BandedGridView1.Columns("Quarter3Value").OptionsColumn.ReadOnly = True
                BandedGridView1.Columns("Quarter3Value").AppearanceCell.BackColor = Color.Silver
                BandedGridView1.Columns("Quarter3Value").OptionsColumn.AllowEdit = False
                If Flagperiod = True Then
                    Dim item As GridColumnSummaryItem = BandedGridView1.Columns("FQ4").Summary.Item(0)
                    item.FieldName = "AnualValue"
                    BandedGridView1.Columns("FQ4").FieldName = "AnualValue"
                    BandedGridView1.Columns.ColumnByName("DiffFQAnt").UnboundExpression = "[AnualValue] - [FQ3]"
                Else
                    Dim item As GridColumnSummaryItem = BandedGridView1.Columns("FQ4").Summary.Item(0)
                    item.FieldName = "FQ4"
                    BandedGridView1.Columns("FQ4").FieldName = "FQ4"
                    BandedGridView1.Columns("AnualValue").Visible = True
                    BandedGridView1.Columns.ColumnByName("DiffFQAnt").UnboundExpression = "[AnualValue] - [FQ4]"
                End If


        End Select






        Try

            Cursor = Cursors.WaitCursor


            ''''Vendas

            '     SalesForForecastConsulta = db.SapImmaterialSales.Where("it.StatsClientId = '" & codigo & "' and it.year = '" & iYear.EditValue & "' and it.price_list <> ''")

            '     SalesForForecastConsulta.ToArray()

            SalesForForecastConsulta2 = db.SapSalesImmaterialforForecastEdit

            '   Target9LConsulta = db.ForecastEditConsultaTarget9L

            '''''fim vendas


            'Dim ForecastConsulta As ObjectQuery(Of SapForecast) = db.SapForecast.Where("it.CodCliDest = '" & codigo & "' and it.year = " & iYear.EditValue & " and it.period = " & Iperiod.EditValue)
            Dim ano As Integer = 2017
            Dim periodo As Integer = 4
            ' Dim subquery = From p2 In db.queryForecastCliStatwithExceptions Where p2.Year = ano And p2.Period = periodo Select p2

            Dim ForecastConsulta = From p In db.SapForecast
                                   Where p.Year = ano And p.Period = periodo
                                   Select p




            SapForecastBindingSource.DataSource = ForecastConsulta
            Cursor = Cursors.Default
            BandedGridView1.ClearColumnsFilter()



        Catch ex As Exception
            MessageBox.Show("Erro : " & ex.Message)
        End Try

        Cursor = Cursors.Default

    End Sub


    Private Sub iExit_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExit.ItemClick
        If change = True Then
            MsgBox("Grave ou cancele as alterações", MsgBoxStyle.Critical)
        Else

            Me.Close()
        End If

    End Sub






    Private Sub bandedGridView1_CustomUnboundColumnData(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles BandedGridView1.CustomUnboundColumnData

        If (e.Column.FieldName = "colInHand" Or e.Column.FieldName = "ColShipped") And e.IsGetData Then
            Dim PARCodCliDest = DirectCast(e.Row, CSForecast.SapForecast).CodCliDest
            Dim PARCodCliFact = DirectCast(e.Row, CSForecast.SapForecast).CodCliFact
            Dim PARCodigo = DirectCast(e.Row, CSForecast.SapForecast).Codigo
            Dim PARTPRE = DirectCast(e.Row, CSForecast.SapForecast).TPRE
            Dim PARCurrency = DirectCast(e.Row, CSForecast.SapForecast).Currency
            Try


                Dim ret = From p In SalesForForecastConsulta2
                          Where p.InvClientID = PARCodCliFact _
                          And p.FinalClientID = PARCodCliDest _
                          And p.Immaterial_Number = PARCodigo _
                          And p.Price_List = PARTPRE _
                          And p.Currency = PARCurrency
                          Select inhand = p.InHand, shiphand = p.Shipped9L + p.InHand9L

                If Not ret.FirstOrDefault Is Nothing Then
                    If e.Column.FieldName = "colInHand" Then
                        e.Value = ret.First.inhand
                    Else
                        e.Value = ret.First.shiphand
                    End If


                End If

            Catch
            End Try




        ElseIf e.Column.FieldName = "colEmbalagem" And e.IsGetData Then
            Dim PARCodigo = DirectCast(e.Row, CSForecast.SapForecast).Codigo

            Dim EmbConsulta = From SapMateriaisEmbalagem In db.SapMateriaisEmbalagem
                              Where SapMateriaisEmbalagem.MATNR = PARCodigo
                              Select SapMateriaisEmbalagem.DESCR
            Try
                e.Value = EmbConsulta.First
            Catch
            End Try
        ElseIf e.Column.FieldName = "colCompany" And e.IsGetData Then
            Dim PARCodigo = DirectCast(e.Row, CSForecast.SapForecast).Codigo

            Dim CompConsulta = From SapMateriais In db.SapMateriais
                               Where SapMateriais.MATNR = PARCodigo
                               Select SapMateriais.WGBEZ60

            Try
                e.Value = CompConsulta.First
            Catch
            End Try
        ElseIf e.Column.FieldName = "colDescMaterial" And e.IsGetData Then
            Dim PARCodigo = DirectCast(e.Row, CSForecast.SapForecast).Codigo

            Dim DescConsulta = From SapMateriais In db.SapMateriais
                               Where SapMateriais.MATNR = PARCodigo
                               Select SapMateriais.MAKTX

            Try
                e.Value = DescConsulta.First
            Catch
            End Try
        End If

    End Sub


    Private Sub iExcel_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExcel.ItemClick

        Dim filename As New FolderBrowserDialog
        filename.ShowDialog()
        Dim str As String
        str = filename.SelectedPath & "\Forecast" & Now.Hour & Now.Minute & Now.Second & ".xlsx"
        BandedGridView1.OptionsView.AllowCellMerge = False
        gridControl.ExportToXlsx(str)

        BandedGridView1.OptionsView.AllowCellMerge = True


        Process.Start(str)

    End Sub


    Private Sub bandedGridView1_CustomDrawBandHeader(ByVal sender As Object, ByVal e As BandHeaderCustomDrawEventArgs) Handles BandedGridView1.CustomDrawBandHeader
        e.Painter.DrawObject(e.Info)
        Dim currentBand As GridBand = TryCast(e.Band, GridBand)
        If currentBand IsNot Nothing AndAlso currentBand.Caption.Contains("SalesUnits") Then
            DrawVerticalDividedLine(e.Graphics, e.Bounds, 8)
        End If
        e.Handled = True
    End Sub

    Private Sub bandedGridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles BandedGridView1.CustomDrawColumnHeader
        e.Painter.DrawObject(e.Info)
        Dim currentColumn As BandedGridColumn = TryCast(e.Column, BandedGridColumn)
        If currentColumn IsNot Nothing AndAlso currentColumn.FieldName.Contains("InHand") Then
            DrawVerticalDividedLine(e.Graphics, e.Bounds, 8)
        End If
        e.Handled = True
    End Sub

    Private Sub bandedGridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles BandedGridView1.CustomDrawCell
        Dim currentColumn As BandedGridColumn = TryCast(e.Column, BandedGridColumn)
        If currentColumn IsNot Nothing AndAlso currentColumn.FieldName.Contains("InHand") Then
            Dim drawBounds As New Rectangle(e.Bounds.X, (TryCast(e.Cell, GridCellInfo)).Bounds.Y, e.Bounds.Width, (TryCast(e.Cell, GridCellInfo)).Bounds.Height)
            DrawVerticalDividedLine(e.Graphics, drawBounds, 4)
        End If
    End Sub

    Private Sub DrawVerticalDividedLine(ByVal graphics As Graphics, ByVal r As Rectangle, ByVal penWidth As Integer)
        Dim bandViewInfo As BandedGridViewInfo = TryCast(BandedGridView1.GetViewInfo(), BandedGridViewInfo)
        Dim vertLineColor As Color = bandViewInfo.PaintAppearance.VertLine.ForeColor
        graphics.DrawLine(New Pen(vertLineColor, penWidth), New Point(r.X + r.Width, r.Y), New Point(r.X + r.Width, r.Y + r.Height))

    End Sub


End Class
