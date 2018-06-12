
Public Class ThisWorkbook
    Public possogravar As Boolean = False

    Public estipulacaoDataSet As New DataSet
    Public estipulacaoDataTable As DataTable
    Public columnNum As Global.System.Data.DataColumn
    Public columnTipoContrato As Global.System.Data.DataColumn
    Public columnBeneficiario As Global.System.Data.DataColumn
    Public columnDataInicio As Global.System.Data.DataColumn
    Public columnDataFim As Global.System.Data.DataColumn
    Public columnTipoCondicao As Global.System.Data.DataColumn
    Public columnMaterial As Global.System.Data.DataColumn
    Public columnValor As Global.System.Data.DataColumn
    Public columnkmein As Global.System.Data.DataColumn
    Public columnvkorg As Global.System.Data.DataColumn
    Public columnOperacao As Global.System.Data.DataColumn

    Private Sub ThisWorkbook_BeforeSave(ByVal SaveAsUI As Boolean, ByRef Cancel As Boolean) Handles Me.BeforeSave
        If possogravar = False Then
            Cancel = True
            MsgBox("Symington Comercial System - Pricing" & vbCrLf & "This worksheet cannot be saved! Please answer 'NO'", vbCritical)
        End If
    End Sub

    Private Sub ThisWorkbook_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup



        estipulacaoDataTable = New DataTable()
        columnNum = New Global.System.Data.DataColumn("Num", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnNum.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnNum)

        columnTipoContrato = New Global.System.Data.DataColumn("TipoContrato", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnTipoContrato.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnTipoContrato)

        columnBeneficiario = New Global.System.Data.DataColumn("Beneficiario", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnBeneficiario.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnBeneficiario)

        columnDataInicio = New Global.System.Data.DataColumn("DataInicio", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnDataInicio.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnDataInicio)

        columnDataFim = New Global.System.Data.DataColumn("DataFim", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnDataFim.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnDataFim)

        columnTipoCondicao = New Global.System.Data.DataColumn("TipoCondicao", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnTipoCondicao.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnTipoCondicao)

        columnMaterial = New Global.System.Data.DataColumn("Material", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnNum.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnMaterial)

        columnValor = New Global.System.Data.DataColumn("Valor", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnValor.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnValor)

        columnkmein = New Global.System.Data.DataColumn("kmein", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnkmein.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnkmein)

        columnvkorg = New Global.System.Data.DataColumn("vkorg", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        columnvkorg.AllowDBNull = False
        estipulacaoDataTable.Columns.Add(columnvkorg)

        columnOperacao = New Global.System.Data.DataColumn("Operacao", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        estipulacaoDataTable.Columns.Add(columnOperacao)

        estipulacaoDataTable.PrimaryKey = New DataColumn() {estipulacaoDataTable.Columns("Num"), estipulacaoDataTable.Columns("TipoCondicao"), estipulacaoDataTable.Columns("Material")}


        estipulacaoDataSet.Tables.Add(estipulacaoDataTable)




        Globals.ThisWorkbook.Protect("password2", True)

        ' Load the ClientUserControl into the actions pane.
        Me.ActionsPane.HorizontalScroll.Enabled = True

    End Sub
    Private Sub ThisWorkbook_WindowActivate(ByVal Wn As Excel.Window) Handles Me.WindowActivate
        Try
            Application.DisplayDocumentActionTaskPane = True

        Catch ex As Exception

        End Try

    End Sub
    

End Class



