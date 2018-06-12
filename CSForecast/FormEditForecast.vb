Imports System.ComponentModel
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.LookAndFeel

Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Linq
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Imports DevExpress.XtraPrinting
Imports DevExpress.Export
Imports System.Data.Entity.Core.Objects

Public Class FormEditForecast

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

        ' Dim results4 = From SapMateriais In db.SapMateriais
        '                       Select SapMateriais.MATNR, SapMateriais.MAKTX, SapMateriais.WGBEZ60
        'Dim results5 = From SapMateriaisEmbalagem In db.SapMateriaisEmbalagem
        '                       Select SapMateriaisEmbalagem.MATNR, SapMateriaisEmbalagem.DESCR

        'SapMateriaisBindingSource.DataSource = results4
        'SapMateriaisEmbalagemBindingSource.DataSource = results5


        iYear.EditValue = Now.Year
        Iperiod.EditValue = "4" '' alterar fecho forecast



        ''''Verificar se o periodo está aberto ou não
        ''''Verificar se o periodo está aberto ou não
        Dim cnn As New SqlConnection ' OleDbConnection
        cnn.ConnectionString = "Data Source=SRVSYMDB;Initial Catalog=SalesSystem;Integrated Security=True"
        cnn.Open()
        Dim sqlcommand As New SqlCommand ' OleDbCommand
        sqlcommand.Connection = cnn



        If Iperiod.EditValue = 1 Then
            sqlcommand.CommandText = "SELECT Aberto FROM SapForecastPeriodFlag WHERE (Period = 1)"
        ElseIf Iperiod.EditValue = 2 Then
            sqlcommand.CommandText = "SELECT Aberto FROM SapForecastPeriodFlag WHERE (Period = 2)"
        ElseIf Iperiod.EditValue = 3 Then
            sqlcommand.CommandText = "SELECT Aberto FROM SapForecastPeriodFlag WHERE (Period = 3)"
        ElseIf Iperiod.EditValue = 4 Then
            sqlcommand.CommandText = "SELECT Aberto FROM SapForecastPeriodFlag WHERE (Period = 4)"
        End If
        Dim Flagperiod As Boolean = sqlcommand.ExecuteScalar



        ''''Temporário para permitir alterações
        ''''Temporário para permitir alterações
        ''''Temporário para permitir alterações

        Dim QuarterFQ = 4
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

        Cursor = Cursors.Default

    End Sub


    Private Sub iExit_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExit.ItemClick
        If change = True Then
            MsgBox("Grave ou cancele as alterações", MsgBoxStyle.Critical)
        Else

            Me.Close()
        End If

    End Sub





    Private Sub iSave_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSave.ItemClick
        If MsgBox("Pretende gravar?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim View As ColumnView = gridControl.FocusedView
            If Not (View.PostEditor() And View.UpdateCurrentRow()) Then Return
            If change = True Then
                Try
                    Dim registrosAfetados As Integer = db.SaveChanges()
                    MsgBox(registrosAfetados.ToString() + " alterações feitas")
                    change = False
                Catch ex As Exception
                    MsgBox("error!! " & ex.Message)
                End Try



            Else
                MsgBox("Não houve alteração")

            End If
        End If
    End Sub

    Private Sub iCancel_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCancel.ItemClick
        If MsgBox("Quer cancelar as alterações?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            gridControl.BeginUpdate()
            BandedGridView1.BeginDataUpdate()

            Dim codigo As String = ""
            Try
                codigo = iClients.EditValue
                If codigo <> String.Empty Then
                    Cursor = Cursors.WaitCursor
                    SplashScreenManager.ShowForm(GetType(SplashScreen1))

                    ' db.Refresh(RefreshMode.StoreWins, db.SapForecast)



                    db.Dispose()
                    db = New SalesSystemEntities

                    Dim ano As Integer = iYear.EditValue
                    Dim periodo As Integer = CInt(Iperiod.EditValue)
                    Dim subquery = From p2 In db.queryForecastCliStatwithExceptions Where p2.Clistat = codigo And p2.Year = ano And p2.Period = periodo Select p2

                    Dim ForecastConsulta = From p In db.SapForecast Join query In subquery
                                         On p.CodCliFact Equals query.CodCliFact _
                                         And p.CodCliDest Equals query.CodCliDest _
                                         And p.TPRE Equals query.TPRE _
                                         And p.Currency Equals query.Currency _
                                         And p.Codigo Equals query.Codigo _
                                         And p.Year Equals query.Year _
                                         And p.Period Equals query.Period
                                           Select p
                    DirectCast(ForecastConsulta, ObjectQuery(Of SapForecast)).MergeOption = MergeOption.OverwriteChanges
                    SapForecastBindingSource.DataSource = ForecastConsulta
                    SalesForForecastConsulta2 = db.SapSalesImmaterialforForecastEdit
                    '      Target9LConsulta = db.ForecastEditConsultaTarget9L

                    change = False
                    Cursor = Cursors.Default
                    SplashScreenManager.CloseForm()
                End If
            Catch ex As Exception
                MessageBox.Show("Erro : " & ex.Message)
            End Try
            BandedGridView1.EndDataUpdate()
            gridControl.RefreshDataSource()
            gridControl.EndUpdate()
        End If
    End Sub



    Private Sub bandedGridView1_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles BandedGridView1.CellValueChanged



        If e.Column.FieldName = "Quarter1Value" Or e.Column.FieldName = "Quarter2Value" Or e.Column.FieldName = "Quarter3Value" Or e.Column.FieldName = "Quarter4Value" Then



            change = True
            Dim view As GridView = CType(sender, GridView)
            Dim row = view.GetRow(e.RowHandle)
            row.usercs = utilizador


            Dim onOrd1 = view.GetRowCellValue(e.RowHandle, colQuarter1Value)
            Dim onOrd2 = view.GetRowCellValue(e.RowHandle, colQuarter2Value)
            Dim onOrd3 = view.GetRowCellValue(e.RowHandle, colQuarter3Value)
            Dim onOrd4 = view.GetRowCellValue(e.RowHandle, colQuarter4Value)

            Dim ValorTotalTarget = onOrd1 + onOrd2 + onOrd3 + onOrd4

            ''calcular total forecast somando todos os meses e converter para 9L
            ''calcular total forecast somando todos os meses e converter para 9L
            Dim retValLtsMatnr

            Dim PARCodigo2 As String = view.GetRowCellValue(e.RowHandle, colCodigo).ToString

            Dim EmbConsulta2 = From SapMateriaisEmbalagem In db.SapMateriaisEmbalagem
                               Where SapMateriaisEmbalagem.MATNR = PARCodigo2
                               Select SapMateriaisEmbalagem.LTS
            Try
                retValLtsMatnr = EmbConsulta2.First
                view.SetRowCellValue(e.RowHandle, "AnualValue", ValorTotalTarget * retValLtsMatnr / 9) ' Total

            Catch
                If ValorTotalTarget <> 0 Then
                    MsgBox("erro na obtenção da embalagem!!")
                    If onOrd1 <> 0 Then view.SetRowCellValue(e.RowHandle, colQuarter1Value, 0)
                    If onOrd2 <> 0 Then view.SetRowCellValue(e.RowHandle, colQuarter2Value, 0)
                    If onOrd3 <> 0 Then view.SetRowCellValue(e.RowHandle, colQuarter3Value, 0)
                    If onOrd4 <> 0 Then view.SetRowCellValue(e.RowHandle, colQuarter4Value, 0)
                End If

            End Try

            BandedGridView1.UpdateTotalSummary()
        End If



    End Sub

    Private Sub FormEditForecast_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If change = True Then
            MsgBox("Grave ou cancele as alterações", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
        '  If UnitOfWork2.InTransaction = True Then MsgBox("Grave ou cancele as alterações!", MsgBoxStyle.Exclamation) : e.Cancel = True
    End Sub

    Private Sub bandedGridView1_CustomUnboundColumnData(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles BandedGridView1.CustomUnboundColumnData

        If (e.Column.FieldName = "colInHand" Or e.Column.FieldName = "ColShipped") And e.IsGetData And BarEditItem1.EditValue = True Then
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



            'ElseIf e.Column.FieldName = "Target9L" And e.IsGetData And BarEditItem1.EditValue = True Then
            '    Dim PARCodCliDest = DirectCast(e.Row, CSForecast.SapForecast).CodCliDest
            '    Dim PARCodCliFact = DirectCast(e.Row, CSForecast.SapForecast).CodCliFact
            '    Dim PARCodigo = DirectCast(e.Row, CSForecast.SapForecast).Codigo
            '    Dim PARTPRE = DirectCast(e.Row, CSForecast.SapForecast).TPRE
            '    Dim PARCurrency = DirectCast(e.Row, CSForecast.SapForecast).Currency
            '    Dim PARyear As Integer = DirectCast(e.Row, CSForecast.SapForecast).Year

            '    Dim ret2 = From p In Target9LConsulta
            '              Where p.CodCliDest = PARCodCliDest And p.CodCliFact = PARCodCliFact And p.TPRE = PARTPRE And p.Currency = PARCurrency And p.Codigo = PARCodigo And p.Year = PARyear
            '                        Select p.AnualValue
            '    Try
            '        If Not ret2.FirstOrDefault Is Nothing Then
            '            e.Value = ret2.First.Value
            '        End If
            '    Catch
            '    End Try

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
        ElseIf e.Column.FieldName = "colStatusMat" And e.IsGetData Then
            Dim PARCodigo = DirectCast(e.Row, CSForecast.SapForecast).Codigo

            Dim StatusConsulta = From SapMateriais In db.SapMateriais
                                 Where SapMateriais.MATNR = PARCodigo
                                 Select SapMateriais.STATUS

            Try
                If StatusConsulta.First = "X" Then e.Value = True
            Catch
            End Try


        ElseIf e.Column.FieldName = "colStatusPricing" And e.IsGetData Then
            Dim PARCodCliFact = DirectCast(e.Row, CSForecast.SapForecast).CodCliFact
            Dim PARCodCliDest = DirectCast(e.Row, CSForecast.SapForecast).CodCliDest

            Dim PARCodigo = DirectCast(e.Row, CSForecast.SapForecast).Codigo
            Dim PARTPRE = DirectCast(e.Row, CSForecast.SapForecast).TPRE
            Dim PARCurrency = DirectCast(e.Row, CSForecast.SapForecast).Currency

            If PARCodCliFact = "" Or PARCodCliDest = "" Or PARCodigo = "" Or PARTPRE = "" Or PARCurrency = "" Then Exit Sub


            If PARCodCliFact = "0000000263" Then
                Try
                    Dim statusPricing = From p In db.SapPricingAnalisysforForecast
                                        Where p.INV_CUSTOMER = PARCodCliFact _
                                        And (p.FINAL_CUSTOMER = PARCodCliDest Or p.FINAL_CUSTOMER = PARCodCliFact) _
                                        And p.O_REF_CODE = PARCodigo _
                                        And p.PRICE_LIST_TYPE = PARTPRE _
                                        And p.CURRENCY = PARCurrency
                                        Select p.NNSP_CURR_EUR_9L
                    If IsNothing(statusPricing.FirstOrDefault) Then
                        e.Value = False
                    Else
                        e.Value = True
                    End If
                Catch
                End Try
            Else
                Try
                    Dim statusPricing = From p In db.SapPricingAnalisysforForecast
                                        Where p.INV_CUSTOMER = PARCodCliFact _
                                        And p.FINAL_CUSTOMER = PARCodCliDest _
                                        And p.O_REF_CODE = PARCodigo _
                                        And p.PRICE_LIST_TYPE = PARTPRE _
                                        And p.CURRENCY = PARCurrency
                                        Select p.NNSP_CURR_EUR_9L

                    If IsNothing(statusPricing.FirstOrDefault) Then
                        e.Value = False
                    Else
                        e.Value = True
                    End If
                Catch
                End Try
            End If




        End If

    End Sub


    Private Sub iExcel_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExcel.ItemClick

        Dim filename As New FolderBrowserDialog
        filename.ShowDialog()
        Dim str As String
        str = filename.SelectedPath & "\Forecast" & Now.Hour & Now.Minute & Now.Second & ".xlsx"
        BandedGridView1.OptionsView.AllowCellMerge = False

        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()

        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colStatusMat
        GridFormatRule1.ColumnApplyTo = Me.colQuarter3Value
        GridFormatRule1.Name = "FormataProdutoApagado"
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.PredefinedName = "Red Fill, Red Text"
        FormatConditionRuleValue1.Value1 = True
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule1.Tag = "Red Fill, Red Text"
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.colStatusPricing
        GridFormatRule2.ColumnApplyTo = Me.colQuarter3Value
        GridFormatRule2.Name = "FormataFaltadePricing"
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.PredefinedName = "Yellow Fill, Yellow Text"
        FormatConditionRuleValue2.Value1 = False
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule2.Tag = "Yellow Fill, Yellow Text"


        Me.BandedGridView1.FormatRules.Clear()
        Me.BandedGridView1.FormatRules.Add(GridFormatRule1)
        Me.BandedGridView1.FormatRules.Add(GridFormatRule2)

        Me.BandedGridView1.Columns.ColumnByFieldName("colStatusMat").Visible = True
        Me.BandedGridView1.Columns.ColumnByFieldName("colStatusMat").Width = 1
        Me.BandedGridView1.Columns.ColumnByFieldName("colStatusPricing").Visible = True
        Me.BandedGridView1.Columns.ColumnByFieldName("colStatusPricing").Width = 1


        Dim xlsxOptionsEx As XlsxExportOptionsEx = New XlsxExportOptionsEx
        xlsxOptionsEx.ExportType = ExportType.DataAware

        gridControl.ExportToXlsx(str, xlsxOptionsEx)

        Me.BandedGridView1.Columns.ColumnByFieldName("colStatusMat").Visible = False

        Me.BandedGridView1.Columns.ColumnByFieldName("colStatusPricing").Visible = False



        Me.BandedGridView1.FormatRules.Clear()
        Me.BandedGridView1.FormatRules.Add(GridFormatRule2)
        Me.BandedGridView1.FormatRules.Add(GridFormatRule1)


        BandedGridView1.OptionsView.AllowCellMerge = True


        Process.Start(str)

    End Sub





    Private Sub iClients_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles iClients.EditValueChanged

        If change = True Then
            MsgBox("Grave ou cancele as alterações", MsgBoxStyle.Critical)
        Else


            Dim codigo As String = ""
            Try
                codigo = iClients.EditValue
                If codigo <> String.Empty Then
                    Cursor = Cursors.WaitCursor
                    SplashScreenManager.ShowForm(GetType(SplashScreen1))

                    ''''Vendas

                    '     SalesForForecastConsulta = db.SapImmaterialSales.Where("it.StatsClientId = '" & codigo & "' and it.year = '" & iYear.EditValue & "' and it.price_list <> ''")

                    '     SalesForForecastConsulta.ToArray()

                    SalesForForecastConsulta2 = db.SapSalesImmaterialforForecastEdit

                    '     Target9LConsulta = db.ForecastEditConsultaTarget9L

                    '''''fim vendas


                    'Dim ForecastConsulta As ObjectQuery(Of SapForecast) = db.SapForecast.Where("it.CodCliDest = '" & codigo & "' and it.year = " & iYear.EditValue & " and it.period = " & Iperiod.EditValue)
                    Dim ano As Integer = iYear.EditValue
                    Dim periodo As Integer = CInt(Iperiod.EditValue)
                    Dim subquery = From p2 In db.queryForecastCliStatwithExceptions Where p2.Clistat = codigo And p2.Year = ano And p2.Period = periodo Select p2

                    Dim ForecastConsulta = From p In db.SapForecast Join query In subquery
                                         On p.CodCliFact Equals query.CodCliFact _
                                         And p.CodCliDest Equals query.CodCliDest _
                                         And p.TPRE Equals query.TPRE _
                                         And p.Currency Equals query.Currency _
                                         And p.Codigo Equals query.Codigo _
                                         And p.Year Equals query.Year _
                                         And p.Period Equals query.Period
                                           Select p


                    '  Dim pedidos = From p In db.SapForecast Where p.CodCliDest = codigo

                    SapForecastBindingSource.DataSource = ForecastConsulta
                    Cursor = Cursors.Default
                    BandedGridView1.ClearColumnsFilter()
                    SplashScreenManager.CloseForm()


                End If
            Catch ex As Exception
                MessageBox.Show("Erro : " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub BarEditItem1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles iClientsMA.EditValueChanged
        Dim codigo As String = ""
        Try
            codigo = iClientsMA.EditValue
            If codigo <> String.Empty Then
                Dim pedidos = From p In db.SapClients Where p.MARKETASSISTANT = codigo Select p.KUNNR, p.NAME1, p.LANDX50
                RepositoryItemLookUpEdit3.DataSource = pedidos

            End If
        Catch ex As Exception
            MessageBox.Show("Erro : " & ex.Message)
        End Try
    End Sub


    Private Sub iYear_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles iYear.EditValueChanged
        iClients.EditValue = ""
    End Sub

    Private Sub Iperiod_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles Iperiod.EditValueChanged
        iClients.EditValue = ""
    End Sub

    Private Sub bandedGridView1_InitNewRow(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles BandedGridView1.InitNewRow
        Dim view As GridView = CType(sender, GridView)
        view.SetRowCellValue(e.RowHandle, view.Columns("Year"), iYear.EditValue)
        view.SetRowCellValue(e.RowHandle, view.Columns("Period"), Iperiod.EditValue)
        view.SetRowCellValue(e.RowHandle, view.Columns("statusPricing"), True)
        '  view.SetRowCellValue(e.RowHandle, view.Columns("CodCliDest"), iClients.EditValue)


    End Sub


    Private Sub ClearSelect_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ClearSelect.ItemClick
        iClientsMA.EditValue = ""
        Dim clientes = From p In db.SapClients Select p.KUNNR, p.NAME1, p.LANDX50
        RepositoryItemLookUpEdit3.DataSource = clientes
        RepositoryItemLookUpEdit3.ValueMember = "KUNNR"
        RepositoryItemLookUpEdit3.DisplayMember = "NAME1"
        SapClientsBindingSource.DataSource = clientes

    End Sub

    Private Sub iClients_ShowingEditor(sender As System.Object, e As DevExpress.XtraBars.ItemCancelEventArgs) Handles iClients.ShowingEditor
        If change = True Then
            e.Cancel = True
            MsgBox("Grave ou cancele as alterações", MsgBoxStyle.Critical)
        Else
        End If
    End Sub



    Private Sub bandedGridView1_ValidatingEditor(sender As System.Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles BandedGridView1.ValidatingEditor

        If BandedGridView1.FocusedColumn.FieldName <> "CodCliFact" Then Exit Sub
        e.Value = e.Value.ToString.PadLeft(10, "0")



    End Sub



    Private Sub gridControl_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gridControl.EmbeddedNavigator.ButtonClick

        If (e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove) Then

            Dim res As DialogResult = MessageBox.Show("Apagar linha?", "Apagar dados.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (res = DialogResult.Yes) Then

                change = True
                '      Dim data As CSForecast.SapForecast = SapForecastBindingSource.Current
                '     db.SapForecast.DeleteObject(data)

                'gridControl.RefreshDataSource()


            End If


        Else

            e.Handled = True
            Return

        End If




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

    Private Sub BandedGridView1_ShowingEditor(sender As Object, e As CancelEventArgs) Handles BandedGridView1.ShowingEditor
        'Dim val As Boolean = IIf(IsNothing(BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, colStatusPricing)), True, BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, colStatusPricing))
        'If val <> True Then e.Cancel = True
    End Sub



    ' check for existance of price??
    Private Sub BandedGridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles BandedGridView1.CellValueChanging
        ' Temporary removal
        'If e.Column.FieldName = "Quarter1Value" Or e.Column.FieldName = "Quarter2Value" Or e.Column.FieldName = "Quarter3Value" Or e.Column.FieldName = "Quarter4Value" Then
        '    Dim gridView As GridView = sender
        '    Dim val As Boolean = IIf(IsNothing(BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, colStatusPricing)), True, BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, colStatusPricing))
        '    Try
        '        If val <> True And e.Value <> 0 Then BandedGridView1.CloseEditor()
        '    Catch
        '        BandedGridView1.CloseEditor()
        '    End Try
        'End If

    End Sub
End Class
