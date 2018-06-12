'Imports System.Data.OleDb
Imports Aspose.Cells
Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing

Public Class FormComp


    Public vardatabase As String
    Public vartabela As String
    Public strsel As String
    Public strsel1 As String
    Public strsel2 As String
    Public strsel3 As String
    Public filterkeydir As String
    Public filterkeypais As String
    Public filterkeycli As String
    Public filterkeycomp As String
    Public filterkeymarca As String
    Public filterkeytype As String
    Public filterkeygroup As String
    Public filterkeyprod As String
    Public flagfilterkeyprod As String
    Public flagfilterkeydir As String
    Public filtergrid As Boolean
    Public filtermark As String
    Public filterkeyanocol As String
    Public filterkeypackage As String
    Public groupkey As String
    Public orderkey As String
    Public x As String
    Public y As String


    Public Sub FormComp_Load()
        'Instantiate the License class
        'Dim license As Aspose.Cells.License = New Aspose.Cells.License
        ''Pass only the name of the license file embedded in the assembly
        'license.SetLicense("Aspose.Cells.lic")

        preencheGridTipo3() ' exploded



    End Sub


    Public Sub FillGridWithData3(ByVal strsel As String)
        'Dim currentCursor As Cursor = Cursor.Current
        'Cursor.Current = Cursors.WaitCursor
        'Dim conANO As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\CommercialSystem\dados\db2.mdb"
        'Dim myConnectionANO As New System.Data.OleDb.OleDbConnection(conANO)
        'myConnectionANO.Open()
        'Dim myCommandANO As New System.Data.OleDb.OleDbCommand("select max(ano) from VendasPortoHistFULL", myConnectionANO)
        'If vartabela.StartsWith("vendasmadeira") Then myCommandANO = New System.Data.OleDb.OleDbCommand("select max(ano) from VendasmadeiraHistFULL", myConnectionANO)


        'Dim myReaderANO As Integer
        'myReaderANO = myCommandANO.ExecuteScalar



        'Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\CommercialSystem\dados\dbcomp.mdb"
        'Dim myConnection As New System.Data.OleDb.OleDbConnection(con)
        'myConnection.Open()
        'Dim myCommand As New System.Data.OleDb.OleDbCommand(strsel, myConnection)
        'Dim myReader As System.Data.OleDb.OleDbDataReader
        'myReader = myCommand.ExecuteReader()
        'Dim excel As Workbook = New Workbook
        'Dim designerFile As String = "c:\CommercialSystem\dados\statstemplates\Monthly Reports Comparisons.xls"

        'excel.Open(designerFile)
        'Dim sheet1 As Worksheet = excel.Worksheets(0)
        'Dim cells As Cells = sheet1.Cells
        'Dim startrow As Integer = 17
        'Dim count As Integer = 1
        'Dim strFormulaTotal1 As String = "="
        'Dim strFormulaTotal2 As String = "="
        'Dim strFormulaTotal3 As String = "="
        'Dim strFormulaTotal4 As String = "="
        'Dim strFormulaTotal5 As String = "="
        'Dim strFormulaTotal6 As String = "="
        'Dim strFormulaTotal7 As String = "="
        'Dim strFormulaTotal8 As String = "="
        'Dim strFormulaTotal9 As String = "="
        'Dim strFormulaTotal10 As String = "="
        'Dim strFormulaTotal11 As String = "="
        'Dim strFormulaTotal12 As String = "="

        'Dim AstrFormulaTotal1 As String = "="
        'Dim AstrFormulaTotal2 As String = "="
        'Dim AstrFormulaTotal3 As String = "="
        'Dim AstrFormulaTotal4 As String = "="
        'Dim AstrFormulaTotal5 As String = "="
        'Dim AstrFormulaTotal6 As String = "="
        'Dim AstrFormulaTotal7 As String = "="
        'Dim AstrFormulaTotal8 As String = "="
        'Dim AstrFormulaTotal9 As String = "="
        'Dim AstrFormulaTotal10 As String = "="
        'Dim AstrFormulaTotal11 As String = "="
        'Dim AstrFormulaTotal12 As String = "="
        'Dim AstrFormulaTotalForeca As String = "="

        'Dim stringUniverso As String = ""
        'Dim stringGrupo As String = ""

        'Dim myArraydir() As String = Split(filterkeydir, "'")
        'If myArraydir(1) = "%" Then
        'ElseIf myArraydir.Length = 3 Then
        '    stringUniverso = stringUniverso & myArraydir(1) & "/"
        'ElseIf myArraydir.Length > 3 Then
        '    stringUniverso = stringUniverso & myArraydir(1) & "/"
        '    Dim x As Integer
        '    For x = 3 To myArraydir.Length - 1 Step 2
        '        stringUniverso = stringUniverso & myArraydir(1) & "/"
        '    Next x
        'End If


        'Dim myArraypais() As String = Split(filterkeypais, "'")
        'If myArraypais(1) = "%" Then
        'ElseIf myArraypais.Length = 3 Then
        '    stringUniverso = stringUniverso & myArraypais(1) & "/"
        'ElseIf myArraypais.Length > 3 Then
        '    stringUniverso = stringUniverso & myArraypais(1) & "/"
        '    Dim x As Integer
        '    For x = 3 To myArraypais.Length - 1 Step 2
        '        stringUniverso = stringUniverso & myArraypais(1) & "/"
        '    Next x
        'End If

        'Dim myArraycli() As String = Split(filterkeycli, "'")
        'If myArraycli(1) = "%" Then
        'ElseIf myArraycli.Length = 3 Then
        '    stringUniverso = stringUniverso & myArraycli(1) & "/"
        'ElseIf myArraycli.Length > 3 Then
        '    stringUniverso = stringUniverso & myArraycli(1) & "/"
        '    Dim x As Integer
        '    For x = 3 To myArraycli.Length - 1 Step 2
        '        stringUniverso = stringUniverso & myArraycli(1) & "/"
        '    Next x
        'End If

        'Dim myArray1() As String = Split(filterkeycomp, "'")
        'If myArray1(1) = "%" Then
        'ElseIf myArray1.Length = 3 Then
        '    stringUniverso = stringUniverso & myArray1(1) & "/"
        'ElseIf myArray1.Length > 3 Then
        '    stringUniverso = stringUniverso & myArray1(1) & "/"
        '    Dim x As Integer
        '    For x = 3 To myArray1.Length - 1 Step 2
        '        stringUniverso = stringUniverso & myArray1(1) & "/"
        '    Next x
        'End If

        'Dim myArray2() As String = Split(filterkeytype, "'")
        'If myArray2(1) = "%" Then
        'ElseIf myArray2.Length = 3 Then
        '    stringUniverso = stringUniverso & myArray2(1) & "/"
        'ElseIf myArray2.Length > 3 Then
        '    stringUniverso = stringUniverso & myArray2(1) & "/"
        '    Dim x As Integer
        '    For x = 3 To myArray2.Length - 1 Step 2
        '        stringUniverso = stringUniverso & myArray2(x) & "/"
        '    Next x
        'End If

        'Dim myArray3() As String = Split(filterkeymarca, "'")
        'If myArray3(1) = "%" Then
        'ElseIf myArray3.Length = 3 Then
        '    stringUniverso = stringUniverso & myArray3(1) & "/"
        'ElseIf myArray3.Length > 3 Then
        '    stringUniverso = stringUniverso & myArray3(1) & "/"
        '    Dim x As Integer
        '    For x = 3 To myArray3.Length - 1 Step 2
        '        stringUniverso = stringUniverso & myArray3(x) & "/"
        '    Next x
        'End If

        'Dim myArray4() As String = Split(filterkeygroup, "'")
        'If myArray4(1) = "%" Then
        'ElseIf myArray4.Length = 3 Then
        '    stringUniverso = stringUniverso & myArray4(1) & "/"
        'ElseIf myArray4.Length > 3 Then
        '    stringUniverso = stringUniverso & myArray4(1) & "/"
        '    Dim x As Integer
        '    For x = 3 To myArray4.Length - 1 Step 2
        '        stringUniverso = stringUniverso & myArray4(x) & "/"
        '    Next x
        'End If

        'Dim myArray5() As String = Split(filterkeyprod, "'")
        'If myArray5(1) = "%" Then
        'ElseIf myArray5.Length = 3 Then
        '    If UCase(flagfilterkeyprod) = "SUBCAT" Then stringUniverso = stringUniverso & "Subcat: " & myArray5(1) & "/" Else stringUniverso = stringUniverso & "Family: " & myArray5(1) & "/"
        'ElseIf myArray5.Length > 3 Then

        '    If UCase(flagfilterkeyprod) = "SUBCAT" Then stringUniverso = stringUniverso & "Subcat: " & myArray5(1) & "/" Else stringUniverso = stringUniverso & "Family: " & myArray5(1) & "/"

        '    Dim x As Integer
        '    For x = 3 To myArray5.Length - 1 Step 2
        '        If UCase(flagfilterkeyprod) = "SUBCAT" Then stringUniverso = stringUniverso & "Subcat: " & myArray5(x) & "/" Else stringUniverso = stringUniverso & "Family: " & myArray5(1) & "/"
        '    Next x
        'End If



        'stringGrupo = " Grouped by " & groupkey

        'cells(7, 0).PutValue(stringUniverso)
        'cells(8, 0).PutValue(stringGrupo)
        'Select Case LCase(vartabela)

        '    Case "vendasportomescomp", "vendasmadeiramescomp", "vendasportomescompvalor"
        '        cells(11, 1).PutValue(myReaderANO - 1)
        '        cells(13, 1).PutValue(myReaderANO)
        '        cells(17, 1).PutValue(myReaderANO - 1)
        '        cells(19, 1).PutValue(myReaderANO)
        '        cells(16, 2).PutValue("Target " & myReaderANO)
        '        cells(22, 2).PutValue("Target " & myReaderANO)

        '    Case "vendasportomescomp2", "vendasportomescompvalor2"
        '        cells(11, 1).PutValue(myReaderANO - 2)
        '        cells(13, 1).PutValue(myReaderANO - 1)
        '        cells(17, 1).PutValue(myReaderANO - 2)
        '        cells(19, 1).PutValue(myReaderANO - 1)
        '        cells(16, 2).PutValue("Target " & myReaderANO - 1)
        '        cells(22, 2).PutValue("Target " & myReaderANO - 1)

        'End Select
        'While myReader.Read

        '    strFormulaTotal1 = strFormulaTotal1 & cells(startrow - 7 + (7 * count), 3).Name & "+"
        '    strFormulaTotal2 = strFormulaTotal2 & cells(startrow - 7 + (7 * count), 4).Name & "+"
        '    strFormulaTotal3 = strFormulaTotal3 & cells(startrow - 7 + (7 * count), 5).Name & "+"
        '    strFormulaTotal4 = strFormulaTotal4 & cells(startrow - 7 + (7 * count), 6).Name & "+"
        '    strFormulaTotal5 = strFormulaTotal5 & cells(startrow - 7 + (7 * count), 7).Name & "+"
        '    strFormulaTotal6 = strFormulaTotal6 & cells(startrow - 7 + (7 * count), 8).Name & "+"
        '    strFormulaTotal7 = strFormulaTotal7 & cells(startrow - 7 + (7 * count), 9).Name & "+"
        '    strFormulaTotal8 = strFormulaTotal8 & cells(startrow - 7 + (7 * count), 10).Name & "+"
        '    strFormulaTotal9 = strFormulaTotal9 & cells(startrow - 7 + (7 * count), 11).Name & "+"
        '    strFormulaTotal10 = strFormulaTotal10 & cells(startrow - 7 + (7 * count), 12).Name & "+"
        '    strFormulaTotal11 = strFormulaTotal11 & cells(startrow - 7 + (7 * count), 13).Name & "+"
        '    strFormulaTotal12 = strFormulaTotal12 & cells(startrow - 7 + (7 * count), 14).Name & "+"

        '    AstrFormulaTotal1 = AstrFormulaTotal1 & cells(startrow + 2 - 7 + (7 * count), 3).Name & "+"
        '    AstrFormulaTotal2 = AstrFormulaTotal2 & cells(startrow + 2 - 7 + (7 * count), 4).Name & "+"
        '    AstrFormulaTotal3 = AstrFormulaTotal3 & cells(startrow + 2 - 7 + (7 * count), 5).Name & "+"
        '    AstrFormulaTotal4 = AstrFormulaTotal4 & cells(startrow + 2 - 7 + (7 * count), 6).Name & "+"
        '    AstrFormulaTotal5 = AstrFormulaTotal5 & cells(startrow + 2 - 7 + (7 * count), 7).Name & "+"
        '    AstrFormulaTotal6 = AstrFormulaTotal6 & cells(startrow + 2 - 7 + (7 * count), 8).Name & "+"
        '    AstrFormulaTotal7 = AstrFormulaTotal7 & cells(startrow + 2 - 7 + (7 * count), 9).Name & "+"
        '    AstrFormulaTotal8 = AstrFormulaTotal8 & cells(startrow + 2 - 7 + (7 * count), 10).Name & "+"
        '    AstrFormulaTotal9 = AstrFormulaTotal9 & cells(startrow + 2 - 7 + (7 * count), 11).Name & "+"
        '    AstrFormulaTotal10 = AstrFormulaTotal10 & cells(startrow + 2 - 7 + (7 * count), 12).Name & "+"
        '    AstrFormulaTotal11 = AstrFormulaTotal11 & cells(startrow + 2 - 7 + (7 * count), 13).Name & "+"
        '    AstrFormulaTotal12 = AstrFormulaTotal12 & cells(startrow + 2 - 7 + (7 * count), 14).Name & "+"
        '    Select Case LCase(vartabela)
        '        Case "vendasportomescomp", "vendasmadeiramescomp"
        '            AstrFormulaTotalForeca = AstrFormulaTotalForeca & cells(startrow + 3 - 7 + (7 * count), 15).Name & "+"
        '    End Select

        '    cells(startrow - 7 + (7 * count), 0).PutValue(myReader.Item(0))
        '    cells(startrow - 7 + (7 * count), 3).PutValue(myReader.Item(1))
        '    cells(startrow - 7 + (7 * count), 4).PutValue(myReader.Item(2))
        '    cells(startrow - 7 + (7 * count), 5).PutValue(myReader.Item(3))
        '    cells(startrow - 7 + (7 * count), 6).PutValue(myReader.Item(4))
        '    cells(startrow - 7 + (7 * count), 7).PutValue(myReader.Item(5))
        '    cells(startrow - 7 + (7 * count), 8).PutValue(myReader.Item(6))
        '    cells(startrow - 7 + (7 * count), 9).PutValue(myReader.Item(7))
        '    cells(startrow - 7 + (7 * count), 10).PutValue(myReader.Item(8))
        '    cells(startrow - 7 + (7 * count), 11).PutValue(myReader.Item(9))
        '    cells(startrow - 7 + (7 * count), 12).PutValue(myReader.Item(10))
        '    cells(startrow - 7 + (7 * count), 13).PutValue(myReader.Item(11))
        '    cells(startrow - 7 + (7 * count), 14).PutValue(myReader.Item(12))


        '    cells(startrow + 2 - 7 + (7 * count), 3).PutValue(myReader.Item(13))
        '    If Now.Month >= 2 Then cells(startrow + 2 - 7 + (7 * count), 4).PutValue(myReader.Item(14))
        '    If Now.Month >= 3 Then cells(startrow + 2 - 7 + (7 * count), 5).PutValue(myReader.Item(15))
        '    If Now.Month >= 4 Then cells(startrow + 2 - 7 + (7 * count), 6).PutValue(myReader.Item(16))
        '    If Now.Month >= 5 Then cells(startrow + 2 - 7 + (7 * count), 7).PutValue(myReader.Item(17))
        '    If Now.Month >= 6 Then cells(startrow + 2 - 7 + (7 * count), 8).PutValue(myReader.Item(18))
        '    If Now.Month >= 7 Then cells(startrow + 2 - 7 + (7 * count), 9).PutValue(myReader.Item(19))
        '    If Now.Month >= 8 Then cells(startrow + 2 - 7 + (7 * count), 10).PutValue(myReader.Item(20))
        '    If Now.Month >= 9 Then cells(startrow + 2 - 7 + (7 * count), 11).PutValue(myReader.Item(21))
        '    If Now.Month >= 10 Then cells(startrow + 2 - 7 + (7 * count), 12).PutValue(myReader.Item(22))
        '    If Now.Month >= 11 Then cells(startrow + 2 - 7 + (7 * count), 13).PutValue(myReader.Item(23))
        '    If Now.Month >= 12 Then cells(startrow + 2 - 7 + (7 * count), 14).PutValue(myReader.Item(24))
        '    Select Case LCase(vartabela)
        '        Case "vendasportomescomp", "vendasmadeiramescomp"
        '            cells(startrow + 3 - 7 + (7 * count), 15).PutValue(myReader.Item(25)) ' forecast
        '    End Select

        '    If count > 1 Then
        '        cells(startrow - 7 + (7 * count), 0).Style = cells(17, 0).Style
        '        cells(startrow - 7 + (7 * count), 1).Style = cells(17, 1).Style
        '        cells(startrow - 7 + (7 * count), 2).Style = cells(17, 2).Style
        '        cells(startrow - 7 + (7 * count), 3).Style = cells(17, 3).Style
        '        cells(startrow - 7 + (7 * count), 4).Style = cells(17, 4).Style
        '        cells(startrow - 7 + (7 * count), 5).Style = cells(17, 5).Style
        '        cells(startrow - 7 + (7 * count), 6).Style = cells(17, 6).Style
        '        cells(startrow - 7 + (7 * count), 7).Style = cells(17, 7).Style
        '        cells(startrow - 7 + (7 * count), 8).Style = cells(17, 8).Style
        '        cells(startrow - 7 + (7 * count), 9).Style = cells(17, 9).Style
        '        cells(startrow - 7 + (7 * count), 10).Style = cells(17, 10).Style
        '        cells(startrow - 7 + (7 * count), 11).Style = cells(17, 11).Style
        '        cells(startrow - 7 + (7 * count), 12).Style = cells(17, 12).Style
        '        cells(startrow - 7 + (7 * count), 13).Style = cells(17, 13).Style
        '        cells(startrow - 7 + (7 * count), 14).Style = cells(17, 14).Style
        '        cells(startrow - 7 + (7 * count), 15).Style = cells(17, 15).Style
        '        cells(startrow - 7 + (7 * count), 16).Style = cells(17, 16).Style

        '        cells(startrow + 1 - 7 + (7 * count), 0).Style = cells(18, 0).Style
        '        cells(startrow + 1 - 7 + (7 * count), 1).Style = cells(18, 1).Style
        '        cells(startrow + 1 - 7 + (7 * count), 2).Style = cells(18, 2).Style
        '        cells(startrow + 1 - 7 + (7 * count), 3).Style = cells(18, 3).Style
        '        cells(startrow + 1 - 7 + (7 * count), 4).Style = cells(18, 4).Style
        '        cells(startrow + 1 - 7 + (7 * count), 5).Style = cells(18, 5).Style
        '        cells(startrow + 1 - 7 + (7 * count), 6).Style = cells(18, 6).Style
        '        cells(startrow + 1 - 7 + (7 * count), 7).Style = cells(18, 7).Style
        '        cells(startrow + 1 - 7 + (7 * count), 8).Style = cells(18, 8).Style
        '        cells(startrow + 1 - 7 + (7 * count), 9).Style = cells(18, 9).Style
        '        cells(startrow + 1 - 7 + (7 * count), 10).Style = cells(18, 10).Style
        '        cells(startrow + 1 - 7 + (7 * count), 11).Style = cells(18, 11).Style
        '        cells(startrow + 1 - 7 + (7 * count), 12).Style = cells(18, 12).Style
        '        cells(startrow + 1 - 7 + (7 * count), 13).Style = cells(18, 13).Style
        '        cells(startrow + 1 - 7 + (7 * count), 14).Style = cells(18, 14).Style
        '        cells(startrow + 1 - 7 + (7 * count), 15).Style = cells(18, 15).Style
        '        cells(startrow + 1 - 7 + (7 * count), 16).Style = cells(18, 16).Style

        '        cells(startrow + 2 - 7 + (7 * count), 0).Style = cells(19, 0).Style
        '        cells(startrow + 2 - 7 + (7 * count), 1).Style = cells(19, 1).Style
        '        cells(startrow + 2 - 7 + (7 * count), 2).Style = cells(19, 2).Style
        '        cells(startrow + 2 - 7 + (7 * count), 3).Style = cells(19, 3).Style
        '        cells(startrow + 2 - 7 + (7 * count), 4).Style = cells(19, 4).Style
        '        cells(startrow + 2 - 7 + (7 * count), 5).Style = cells(19, 5).Style
        '        cells(startrow + 2 - 7 + (7 * count), 6).Style = cells(19, 6).Style
        '        cells(startrow + 2 - 7 + (7 * count), 7).Style = cells(19, 7).Style
        '        cells(startrow + 2 - 7 + (7 * count), 8).Style = cells(19, 8).Style
        '        cells(startrow + 2 - 7 + (7 * count), 9).Style = cells(19, 9).Style
        '        cells(startrow + 2 - 7 + (7 * count), 10).Style = cells(19, 10).Style
        '        cells(startrow + 2 - 7 + (7 * count), 11).Style = cells(19, 11).Style
        '        cells(startrow + 2 - 7 + (7 * count), 12).Style = cells(19, 12).Style
        '        cells(startrow + 2 - 7 + (7 * count), 13).Style = cells(19, 13).Style
        '        cells(startrow + 2 - 7 + (7 * count), 14).Style = cells(19, 14).Style
        '        cells(startrow + 2 - 7 + (7 * count), 15).Style = cells(19, 15).Style
        '        cells(startrow + 2 - 7 + (7 * count), 16).Style = cells(19, 16).Style

        '        cells(startrow + 3 - 7 + (7 * count), 0).Style = cells(20, 0).Style
        '        cells(startrow + 3 - 7 + (7 * count), 1).Style = cells(20, 1).Style
        '        cells(startrow + 3 - 7 + (7 * count), 2).Style = cells(20, 2).Style
        '        cells(startrow + 3 - 7 + (7 * count), 3).Style = cells(20, 3).Style
        '        cells(startrow + 3 - 7 + (7 * count), 4).Style = cells(20, 4).Style
        '        cells(startrow + 3 - 7 + (7 * count), 5).Style = cells(20, 5).Style
        '        cells(startrow + 3 - 7 + (7 * count), 6).Style = cells(20, 6).Style
        '        cells(startrow + 3 - 7 + (7 * count), 7).Style = cells(20, 7).Style
        '        cells(startrow + 3 - 7 + (7 * count), 8).Style = cells(20, 8).Style
        '        cells(startrow + 3 - 7 + (7 * count), 9).Style = cells(20, 9).Style
        '        cells(startrow + 3 - 7 + (7 * count), 10).Style = cells(20, 10).Style
        '        cells(startrow + 3 - 7 + (7 * count), 11).Style = cells(20, 11).Style
        '        cells(startrow + 3 - 7 + (7 * count), 12).Style = cells(20, 12).Style
        '        cells(startrow + 3 - 7 + (7 * count), 13).Style = cells(20, 13).Style
        '        cells(startrow + 3 - 7 + (7 * count), 14).Style = cells(20, 14).Style
        '        cells(startrow + 3 - 7 + (7 * count), 15).Style = cells(20, 15).Style
        '        cells(startrow + 3 - 7 + (7 * count), 16).Style = cells(20, 16).Style

        '        cells(startrow + 4 - 7 + (7 * count), 0).Style = cells(21, 0).Style
        '        cells(startrow + 4 - 7 + (7 * count), 1).Style = cells(21, 1).Style
        '        cells(startrow + 4 - 7 + (7 * count), 2).Style = cells(21, 2).Style
        '        cells(startrow + 4 - 7 + (7 * count), 3).Style = cells(21, 3).Style
        '        cells(startrow + 4 - 7 + (7 * count), 4).Style = cells(21, 4).Style
        '        cells(startrow + 4 - 7 + (7 * count), 5).Style = cells(21, 5).Style
        '        cells(startrow + 4 - 7 + (7 * count), 6).Style = cells(21, 6).Style
        '        cells(startrow + 4 - 7 + (7 * count), 7).Style = cells(21, 7).Style
        '        cells(startrow + 4 - 7 + (7 * count), 8).Style = cells(21, 8).Style
        '        cells(startrow + 4 - 7 + (7 * count), 9).Style = cells(21, 9).Style
        '        cells(startrow + 4 - 7 + (7 * count), 10).Style = cells(21, 10).Style
        '        cells(startrow + 4 - 7 + (7 * count), 11).Style = cells(21, 11).Style
        '        cells(startrow + 4 - 7 + (7 * count), 12).Style = cells(21, 12).Style
        '        cells(startrow + 4 - 7 + (7 * count), 13).Style = cells(21, 13).Style
        '        cells(startrow + 4 - 7 + (7 * count), 14).Style = cells(21, 14).Style
        '        cells(startrow + 4 - 7 + (7 * count), 15).Style = cells(21, 15).Style
        '        cells(startrow + 4 - 7 + (7 * count), 16).Style = cells(21, 16).Style

        '        cells(startrow + 5 - 7 + (7 * count), 0).Style = cells(22, 0).Style
        '        cells(startrow + 5 - 7 + (7 * count), 1).Style = cells(22, 1).Style
        '        cells(startrow + 5 - 7 + (7 * count), 2).Style = cells(22, 2).Style
        '        cells(startrow + 5 - 7 + (7 * count), 3).Style = cells(22, 3).Style
        '        cells(startrow + 5 - 7 + (7 * count), 4).Style = cells(22, 4).Style
        '        cells(startrow + 5 - 7 + (7 * count), 5).Style = cells(22, 5).Style
        '        cells(startrow + 5 - 7 + (7 * count), 6).Style = cells(22, 6).Style
        '        cells(startrow + 5 - 7 + (7 * count), 7).Style = cells(22, 7).Style
        '        cells(startrow + 5 - 7 + (7 * count), 8).Style = cells(22, 8).Style
        '        cells(startrow + 5 - 7 + (7 * count), 9).Style = cells(22, 9).Style
        '        cells(startrow + 5 - 7 + (7 * count), 10).Style = cells(22, 10).Style
        '        cells(startrow + 5 - 7 + (7 * count), 11).Style = cells(22, 11).Style
        '        cells(startrow + 5 - 7 + (7 * count), 12).Style = cells(22, 12).Style
        '        cells(startrow + 5 - 7 + (7 * count), 13).Style = cells(22, 13).Style
        '        cells(startrow + 5 - 7 + (7 * count), 14).Style = cells(22, 14).Style
        '        cells(startrow + 5 - 7 + (7 * count), 15).Style = cells(22, 15).Style
        '        cells(startrow + 5 - 7 + (7 * count), 16).Style = cells(22, 16).Style

        '        cells(startrow + 6 - 7 + (7 * count), 0).Style = cells(23, 0).Style
        '        cells(startrow + 6 - 7 + (7 * count), 1).Style = cells(23, 1).Style
        '        cells(startrow + 6 - 7 + (7 * count), 2).Style = cells(23, 2).Style
        '        cells(startrow + 6 - 7 + (7 * count), 3).Style = cells(23, 3).Style
        '        cells(startrow + 6 - 7 + (7 * count), 4).Style = cells(23, 4).Style
        '        cells(startrow + 6 - 7 + (7 * count), 5).Style = cells(23, 5).Style
        '        cells(startrow + 6 - 7 + (7 * count), 6).Style = cells(23, 6).Style
        '        cells(startrow + 6 - 7 + (7 * count), 7).Style = cells(23, 7).Style
        '        cells(startrow + 6 - 7 + (7 * count), 8).Style = cells(23, 8).Style
        '        cells(startrow + 6 - 7 + (7 * count), 9).Style = cells(23, 9).Style
        '        cells(startrow + 6 - 7 + (7 * count), 10).Style = cells(23, 10).Style
        '        cells(startrow + 6 - 7 + (7 * count), 11).Style = cells(23, 11).Style
        '        cells(startrow + 6 - 7 + (7 * count), 12).Style = cells(23, 12).Style
        '        cells(startrow + 6 - 7 + (7 * count), 13).Style = cells(23, 13).Style
        '        cells(startrow + 6 - 7 + (7 * count), 14).Style = cells(23, 14).Style
        '        cells(startrow + 6 - 7 + (7 * count), 15).Style = cells(23, 15).Style
        '        cells(startrow + 6 - 7 + (7 * count), 16).Style = cells(23, 16).Style

        '        cells(startrow - 7 + (7 * count), 1).PutValue(cells(17, 1).Value)
        '        cells(startrow - 7 + (7 * count), 2).PutValue(cells(17, 2).Value)
        '        cells(startrow + 1 - 7 + (7 * count), 2).PutValue(cells(18, 2).Value)

        '        cells(startrow + 2 - 7 + (7 * count), 1).PutValue(cells(19, 1).Value)
        '        cells(startrow + 2 - 7 + (7 * count), 2).PutValue(cells(19, 2).Value)
        '        cells(startrow + 3 - 7 + (7 * count), 2).PutValue(cells(20, 2).Value)

        '        cells(startrow + 4 - 7 + (7 * count), 1).PutValue(cells(21, 1).Value)
        '        cells(startrow + 4 - 7 + (7 * count), 2).PutValue(cells(21, 2).Value)
        '        cells(startrow + 5 - 7 + (7 * count), 2).PutValue(cells(22, 2).Value)

        '        cells(startrow + 6 - 7 + (7 * count), 1).PutValue(cells(23, 1).Value)

        '        cells.Merge(startrow - 7 + (7 * count), 0, 7, 1)
        '        cells.Merge(startrow - 7 + (7 * count), 1, 2, 1)
        '        cells.Merge(startrow + 2 - 7 + (7 * count), 1, 2, 1)
        '        cells.Merge(startrow + 4 - 7 + (7 * count), 1, 2, 1)
        '        cells.Merge(startrow + 6 - 7 + (7 * count), 1, 1, 2)


        '        cells(startrow + 1 - 7 + (7 * count), 3).R1C1Formula = cells(startrow + 1, 3).R1C1Formula
        '        cells(startrow + 1 - 7 + (7 * count), 4).R1C1Formula = cells(startrow + 1, 4).R1C1Formula
        '        cells(startrow + 1 - 7 + (7 * count), 5).R1C1Formula = cells(startrow + 1, 5).R1C1Formula
        '        cells(startrow + 1 - 7 + (7 * count), 6).R1C1Formula = cells(startrow + 1, 6).R1C1Formula
        '        cells(startrow + 1 - 7 + (7 * count), 7).R1C1Formula = cells(startrow + 1, 7).R1C1Formula
        '        cells(startrow + 1 - 7 + (7 * count), 8).R1C1Formula = cells(startrow + 1, 8).R1C1Formula
        '        cells(startrow + 1 - 7 + (7 * count), 9).R1C1Formula = cells(startrow + 1, 9).R1C1Formula
        '        cells(startrow + 1 - 7 + (7 * count), 10).R1C1Formula = cells(startrow + 1, 10).R1C1Formula
        '        cells(startrow + 1 - 7 + (7 * count), 11).R1C1Formula = cells(startrow + 1, 11).R1C1Formula
        '        cells(startrow + 1 - 7 + (7 * count), 12).R1C1Formula = cells(startrow + 1, 12).R1C1Formula
        '        cells(startrow + 1 - 7 + (7 * count), 13).R1C1Formula = cells(startrow + 1, 13).R1C1Formula
        '        cells(startrow + 1 - 7 + (7 * count), 14).R1C1Formula = cells(startrow + 1, 14).R1C1Formula
        '        cells(startrow + 1 - 7 + (7 * count), 15).R1C1Formula = cells(startrow + 1, 15).R1C1Formula

        '        cells(startrow + 3 - 7 + (7 * count), 3).R1C1Formula = cells(startrow + 3, 3).R1C1Formula
        '        cells(startrow + 3 - 7 + (7 * count), 4).R1C1Formula = cells(startrow + 3, 4).R1C1Formula
        '        cells(startrow + 3 - 7 + (7 * count), 5).R1C1Formula = cells(startrow + 3, 5).R1C1Formula
        '        cells(startrow + 3 - 7 + (7 * count), 6).R1C1Formula = cells(startrow + 3, 6).R1C1Formula
        '        cells(startrow + 3 - 7 + (7 * count), 7).R1C1Formula = cells(startrow + 3, 7).R1C1Formula
        '        cells(startrow + 3 - 7 + (7 * count), 8).R1C1Formula = cells(startrow + 3, 8).R1C1Formula
        '        cells(startrow + 3 - 7 + (7 * count), 9).R1C1Formula = cells(startrow + 3, 9).R1C1Formula
        '        cells(startrow + 3 - 7 + (7 * count), 10).R1C1Formula = cells(startrow + 3, 10).R1C1Formula
        '        cells(startrow + 3 - 7 + (7 * count), 11).R1C1Formula = cells(startrow + 3, 11).R1C1Formula
        '        cells(startrow + 3 - 7 + (7 * count), 12).R1C1Formula = cells(startrow + 3, 12).R1C1Formula
        '        cells(startrow + 3 - 7 + (7 * count), 13).R1C1Formula = cells(startrow + 3, 13).R1C1Formula
        '        cells(startrow + 3 - 7 + (7 * count), 14).R1C1Formula = cells(startrow + 3, 14).R1C1Formula
        '        Select Case LCase(vartabela)
        '            Case "vendasportomescomp2", "vendasmadeiramescomp2"
        '                cells(startrow + 3 - 7 + (7 * count), 15).R1C1Formula = cells(startrow + 3, 15).R1C1Formula
        '        End Select





        '        cells(startrow + 4 - 7 + (7 * count), 3).R1C1Formula = cells(startrow + 4, 3).R1C1Formula
        '        cells(startrow + 4 - 7 + (7 * count), 4).R1C1Formula = cells(startrow + 4, 4).R1C1Formula
        '        cells(startrow + 4 - 7 + (7 * count), 5).R1C1Formula = cells(startrow + 4, 5).R1C1Formula
        '        cells(startrow + 4 - 7 + (7 * count), 6).R1C1Formula = cells(startrow + 4, 6).R1C1Formula
        '        cells(startrow + 4 - 7 + (7 * count), 7).R1C1Formula = cells(startrow + 4, 7).R1C1Formula
        '        cells(startrow + 4 - 7 + (7 * count), 8).R1C1Formula = cells(startrow + 4, 8).R1C1Formula
        '        cells(startrow + 4 - 7 + (7 * count), 9).R1C1Formula = cells(startrow + 4, 9).R1C1Formula
        '        cells(startrow + 4 - 7 + (7 * count), 10).R1C1Formula = cells(startrow + 4, 10).R1C1Formula
        '        cells(startrow + 4 - 7 + (7 * count), 11).R1C1Formula = cells(startrow + 4, 11).R1C1Formula
        '        cells(startrow + 4 - 7 + (7 * count), 12).R1C1Formula = cells(startrow + 4, 12).R1C1Formula
        '        cells(startrow + 4 - 7 + (7 * count), 13).R1C1Formula = cells(startrow + 4, 13).R1C1Formula
        '        cells(startrow + 4 - 7 + (7 * count), 14).R1C1Formula = cells(startrow + 4, 14).R1C1Formula
        '        cells(startrow + 4 - 7 + (7 * count), 15).R1C1Formula = cells(startrow + 4, 15).R1C1Formula

        '        cells(startrow + 5 - 7 + (7 * count), 3).R1C1Formula = cells(startrow + 5, 3).R1C1Formula
        '        cells(startrow + 5 - 7 + (7 * count), 4).R1C1Formula = cells(startrow + 5, 4).R1C1Formula
        '        cells(startrow + 5 - 7 + (7 * count), 5).R1C1Formula = cells(startrow + 5, 5).R1C1Formula
        '        cells(startrow + 5 - 7 + (7 * count), 6).R1C1Formula = cells(startrow + 5, 6).R1C1Formula
        '        cells(startrow + 5 - 7 + (7 * count), 7).R1C1Formula = cells(startrow + 5, 7).R1C1Formula
        '        cells(startrow + 5 - 7 + (7 * count), 8).R1C1Formula = cells(startrow + 5, 8).R1C1Formula
        '        cells(startrow + 5 - 7 + (7 * count), 9).R1C1Formula = cells(startrow + 5, 9).R1C1Formula
        '        cells(startrow + 5 - 7 + (7 * count), 10).R1C1Formula = cells(startrow + 5, 10).R1C1Formula
        '        cells(startrow + 5 - 7 + (7 * count), 11).R1C1Formula = cells(startrow + 5, 11).R1C1Formula
        '        cells(startrow + 5 - 7 + (7 * count), 12).R1C1Formula = cells(startrow + 5, 12).R1C1Formula
        '        cells(startrow + 5 - 7 + (7 * count), 13).R1C1Formula = cells(startrow + 5, 13).R1C1Formula
        '        cells(startrow + 5 - 7 + (7 * count), 14).R1C1Formula = cells(startrow + 5, 14).R1C1Formula

        '        cells(startrow + 6 - 7 + (7 * count), 3).R1C1Formula = cells(startrow + 6, 3).R1C1Formula
        '        cells(startrow + 6 - 7 + (7 * count), 4).R1C1Formula = cells(startrow + 6, 4).R1C1Formula
        '        cells(startrow + 6 - 7 + (7 * count), 5).R1C1Formula = cells(startrow + 6, 5).R1C1Formula
        '        cells(startrow + 6 - 7 + (7 * count), 6).R1C1Formula = cells(startrow + 6, 6).R1C1Formula
        '        cells(startrow + 6 - 7 + (7 * count), 7).R1C1Formula = cells(startrow + 6, 7).R1C1Formula
        '        cells(startrow + 6 - 7 + (7 * count), 8).R1C1Formula = cells(startrow + 6, 8).R1C1Formula
        '        cells(startrow + 6 - 7 + (7 * count), 9).R1C1Formula = cells(startrow + 6, 9).R1C1Formula
        '        cells(startrow + 6 - 7 + (7 * count), 10).R1C1Formula = cells(startrow + 6, 10).R1C1Formula
        '        cells(startrow + 6 - 7 + (7 * count), 11).R1C1Formula = cells(startrow + 6, 11).R1C1Formula
        '        cells(startrow + 6 - 7 + (7 * count), 12).R1C1Formula = cells(startrow + 6, 12).R1C1Formula
        '        cells(startrow + 6 - 7 + (7 * count), 13).R1C1Formula = cells(startrow + 6, 13).R1C1Formula
        '        cells(startrow + 6 - 7 + (7 * count), 14).R1C1Formula = cells(startrow + 6, 14).R1C1Formula
        '        cells(startrow + 6 - 7 + (7 * count), 15).R1C1Formula = cells(startrow + 6, 15).R1C1Formula

        '    End If




        '    count = count + 1
        'End While
        'strFormulaTotal1 = strFormulaTotal1.TrimEnd("+")
        'strFormulaTotal2 = strFormulaTotal2.TrimEnd("+")
        'strFormulaTotal3 = strFormulaTotal3.TrimEnd("+")
        'strFormulaTotal4 = strFormulaTotal4.TrimEnd("+")
        'strFormulaTotal5 = strFormulaTotal5.TrimEnd("+")
        'strFormulaTotal6 = strFormulaTotal6.TrimEnd("+")
        'strFormulaTotal7 = strFormulaTotal7.TrimEnd("+")
        'strFormulaTotal8 = strFormulaTotal8.TrimEnd("+")
        'strFormulaTotal9 = strFormulaTotal9.TrimEnd("+")
        'strFormulaTotal10 = strFormulaTotal10.TrimEnd("+")
        'strFormulaTotal11 = strFormulaTotal11.TrimEnd("+")
        'strFormulaTotal12 = strFormulaTotal12.TrimEnd("+")
        'cells("D12").Formula = strFormulaTotal1
        'cells("E12").Formula = strFormulaTotal2
        'cells("F12").Formula = strFormulaTotal3
        'cells("G12").Formula = strFormulaTotal4
        'cells("H12").Formula = strFormulaTotal5
        'cells("I12").Formula = strFormulaTotal6
        'cells("J12").Formula = strFormulaTotal7
        'cells("K12").Formula = strFormulaTotal8
        'cells("L12").Formula = strFormulaTotal9
        'cells("M12").Formula = strFormulaTotal10
        'cells("N12").Formula = strFormulaTotal11
        'cells("O12").Formula = strFormulaTotal12

        'AstrFormulaTotal1 = AstrFormulaTotal1.TrimEnd("+")
        'AstrFormulaTotal2 = AstrFormulaTotal2.TrimEnd("+")
        'AstrFormulaTotal3 = AstrFormulaTotal3.TrimEnd("+")
        'AstrFormulaTotal4 = AstrFormulaTotal4.TrimEnd("+")
        'AstrFormulaTotal5 = AstrFormulaTotal5.TrimEnd("+")
        'AstrFormulaTotal6 = AstrFormulaTotal6.TrimEnd("+")
        'AstrFormulaTotal7 = AstrFormulaTotal7.TrimEnd("+")
        'AstrFormulaTotal8 = AstrFormulaTotal8.TrimEnd("+")
        'AstrFormulaTotal9 = AstrFormulaTotal9.TrimEnd("+")
        'AstrFormulaTotal10 = AstrFormulaTotal10.TrimEnd("+")
        'AstrFormulaTotal11 = AstrFormulaTotal11.TrimEnd("+")
        'AstrFormulaTotal12 = AstrFormulaTotal12.TrimEnd("+")
        'AstrFormulaTotalForeca = AstrFormulaTotalForeca.TrimEnd("+")
        'cells("D14").Formula = AstrFormulaTotal1
        'Select Case LCase(vartabela)
        '    Case "vendasportomescomp", "vendasmadeiramescomp"
        '        If Now.Month >= 2 Then cells("E14").Formula = AstrFormulaTotal2
        '        If Now.Month >= 3 Then cells("F14").Formula = AstrFormulaTotal3
        '        If Now.Month >= 4 Then cells("G14").Formula = AstrFormulaTotal4
        '        If Now.Month >= 5 Then cells("H14").Formula = AstrFormulaTotal5
        '        If Now.Month >= 6 Then cells("I14").Formula = AstrFormulaTotal6
        '        If Now.Month >= 7 Then cells("J14").Formula = AstrFormulaTotal7
        '        If Now.Month >= 8 Then cells("K14").Formula = AstrFormulaTotal8
        '        If Now.Month >= 9 Then cells("L14").Formula = AstrFormulaTotal9
        '        If Now.Month >= 10 Then cells("M14").Formula = AstrFormulaTotal10
        '        If Now.Month >= 11 Then cells("N14").Formula = AstrFormulaTotal11
        '        If Now.Month >= 12 Then cells("O14").Formula = AstrFormulaTotal12
        '        cells("P15").Formula = AstrFormulaTotalForeca
        '    Case Else
        '        cells("E14").Formula = AstrFormulaTotal2
        '        cells("F14").Formula = AstrFormulaTotal3
        '        cells("G14").Formula = AstrFormulaTotal4
        '        cells("H14").Formula = AstrFormulaTotal5
        '        cells("I14").Formula = AstrFormulaTotal6
        '        cells("J14").Formula = AstrFormulaTotal7
        '        cells("K14").Formula = AstrFormulaTotal8
        '        cells("L14").Formula = AstrFormulaTotal9
        '        cells("M14").Formula = AstrFormulaTotal10
        '        cells("N14").Formula = AstrFormulaTotal11
        '        cells("O14").Formula = AstrFormulaTotal12
        '        cells("P15").Formula = "=O15"
        'End Select




        'excel.ShowTabs = False
        'sheet1.IsGridlinesVisible = False
        'cells("P8").Style.HorizontalAlignment = TextAlignmentType.Right
        'cells("P8").Style.Font.Color = Color.Red
        'cells("P8").Style.Font.IsBold = True
        'If vartabela.StartsWith("vendasmadeira") Then
        '    cells("P8").PutValue("MWC - Comparison by Month")
        'Else
        '    cells("P8").PutValue("Symington - Comparison by Month")
        'End If

        'myReader.Close()
        'myConnection.Close()
        'excel.Save("c:\CommercialSystem\excel\Monthly Reports Comparisons.xls", FileFormatType.Excel2003)
        'Process.Start("c:\CommercialSystem\excel\Monthly Reports Comparisons.xls")
        'Cursor.Current = currentCursor
    End Sub

    Public Sub preencheGridTipo3()

        Select Case groupkey.ToString
            Case "Market Director"
                groupkey = "director"
                orderkey = "SUM(FORECA) DESC"
            Case "Market"
                groupkey = "pais"
                orderkey = "SUM(FORECA) DESC"
            Case "Client"
                groupkey = "cliente"
                orderkey = "SUM(FORECA) DESC"
            Case "Company"
                groupkey = "Company"
                orderkey = "SUM(FORECA) DESC"
            Case "Type"
                groupkey = "Tipo"
                orderkey = "SUM(FORECA) DESC"
            Case "Trademark"
                groupkey = "Marca"
                orderkey = "SUM(FORECA) DESC"
            Case "Group"
                groupkey = "Grupo"
                orderkey = "SUM(FORECA) DESC"
            Case "Subcat"
                groupkey = "subcat, subcatid"
                orderkey = "subcatid ASC"
               
            Case "Family"
                groupkey = "Family"
                orderkey = "SUM(FORECA) DESC"

            Case "Vintage Year"
                groupkey = "Anocol"
                orderkey = "SUM(FORECA) DESC"
            Case "Package"
                groupkey = "embalagem"
                orderkey = "SUM(FORECA) DESC"

        End Select

        strsel1 = "SELECT " & groupkey & ", SUM(JAN1), SUM(FEV1) , SUM(MAR1) , SUM(ABR1) , SUM(MAI1) , SUM(JUN1) , SUM(JUL1) , SUM(AGO1) , SUM(SET1) , SUM(OUT1) , SUM(NOV1) ,  SUM(DEZ1) , SUM(JAN) , SUM(FEV) , SUM(MAR) , SUM(ABR) , SUM(MAI) , SUM(JUN) , SUM(JUL) , SUM(AGO) , SUM(`SET`), SUM(OUT) , SUM(NOV) , SUM(DEZ) , sum(foreca) From " & vartabela _
                & " WHERE (" & filterkeydir & ") AND (" & filterkeypais & ") AND (" & filterkeycli & ") AND (" & filterkeycomp & ") AND (" & filterkeytype & ") AND (" & filterkeymarca & ") AND (" & filterkeygroup & ") AND (" & filterkeyprod & ") AND (" & filterkeyanocol & ") and (" & filterkeypackage & ")  GROUP BY " & groupkey & " ORDER BY " & orderkey

        If groupkey = "subcat, subcatid" Then
            strsel1 = "SELECT subcat , SUM(JAN1), SUM(FEV1) , SUM(MAR1) , SUM(ABR1) , SUM(MAI1) , SUM(JUN1) , SUM(JUL1) , SUM(AGO1) , SUM(SET1) , SUM(OUT1) , SUM(NOV1) ,  SUM(DEZ1) , SUM(JAN) , SUM(FEV) , SUM(MAR) , SUM(ABR) , SUM(MAI) , SUM(JUN) , SUM(JUL) , SUM(AGO) , SUM(`SET`), SUM(OUT) , SUM(NOV) , SUM(DEZ) , sum(foreca), subcatid From " & vartabela _
                & " WHERE (" & filterkeydir & ") AND (" & filterkeypais & ") AND (" & filterkeycli & ") AND (" & filterkeycomp & ") AND (" & filterkeytype & ") AND (" & filterkeymarca & ") AND (" & filterkeygroup & ") AND (" & filterkeyprod & ") AND (" & filterkeyanocol & ") and (" & filterkeypackage & ")  GROUP BY " & groupkey & " ORDER BY " & orderkey

        End If


        Dim currentCursor As Cursor = Cursor.Current



        FillGridWithData3(strsel1)

    End Sub

    Public Function SQ(ByVal str As String) As String
        SQ = Replace(str, "'", "''", 1, -1, vbTextCompare)
    End Function
End Class


Public Class YesNoFormatProvider
    Implements IFormatProvider, ICustomFormatter
    Public Function GetFormat(ByVal type As System.Type) As Object Implements IFormatProvider.GetFormat
        Return Me
    End Function
    Public Function Format(ByVal _format As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
        If Convert.ToBoolean(arg) Then
            Return "Yes"
        Else
            Return "No"
        End If
    End Function
End Class
