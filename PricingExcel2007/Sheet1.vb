Public Class Sheet1
    Public filterkeycompany As String
    Public filterkeytipo As String
    Public fecho As Boolean = False
    Public ready = False
    Public datasalteradas As Boolean = False
    Public bonusalterados As Boolean = False
    Public clientealterado As Boolean = False
    Public TipoListaalterado As Boolean = False

  

    Private Sub Sheet1_BeforeRightClick(ByVal Target As Microsoft.Office.Interop.Excel.Range, ByRef Cancel As System.Boolean) Handles Me.BeforeRightClick
        ''''Antigo Right-Click para apagar a linha (Produto)
        Globals.Sheet1.Unprotect("password2")

        Dim teste = Target.Address
        Dim ret = teste.Split(":")
        If ret.Count = 2 Then
            If ret(0) = ret(1) Then
                If Target.Row > 23 And Globals.Sheet1.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row > 24 Then
                    If datasalteradas = True Or TipoListaalterado = True Or clientealterado = True Then
                        If MsgBox("Quer apagar esta linha?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Target.EntireRow.Delete() : Cancel = True
                        recalcularAftedelete()
                    Else
                        MsgBox("Para apagar preços coloque a zero(0) o mesmo.", MsgBoxStyle.Information)
                    End If
                End If
            End If
        End If
        Globals.Sheet1.Protect("password2", , , , , True, True, True, , , , , , , , )

    End Sub



    Private Sub Sheet1_Change(ByVal Target As Microsoft.Office.Interop.Excel.Range) Handles Me.Change
        If Mid(Target.Address, 1, 2) = "$F" And ready = True Then
            '  Globals.ThisWorkbook.ActionsPane.Controls(0).Controls(3).Controls(7).Enabled = False

        End If
        If Mid(Target.Address, 1, 2) = "$E" Then
            Globals.Sheet1.Range("F" & Target.Row).Value2 = Globals.Sheet1.Range(Target.Address).Value2 * Globals.Sheet1.Range("AE" & Target.Row).Value2

        End If

        If Mid(Target.Address, 1, 3) = "$BT" Or Mid(Target.Address, 1, 3) = "$BU" Or Mid(Target.Address, 1, 3) = "$BV" Then
            If IsNumeric(Target.Value2) Then
                bonusalterados = True
            End If

        End If



    End Sub

    Private Sub Sheet1_Startup(sender As Object, e As System.EventArgs) Handles Me.Startup
        '  Cursor = Cursors.WaitCursor
        Dim form As New FormTreesPricingUpdate
        form.ShowDialog()
        
        If fecho = False Then
            ' Cursor = Cursors.WaitCursor
            Dim clientPane As New UserControl1
            clientPane.inicio = False
            clientPane.novatabela = False
            clientPane.filterkeycompany = filterkeycompany
            clientPane.filterkeytipo = filterkeytipo
            Globals.ThisWorkbook.ActionsPane.Controls.Add(clientPane)
        End If
    End Sub

    Private Sub Sheet1_BeforeDoubleClick(Target As Microsoft.Office.Interop.Excel.Range, ByRef Cancel As System.Boolean) Handles Me.BeforeDoubleClick
        Globals.Sheet1.Unprotect("password2")

        Dim teste = Target.Address
        If Target.Row > 23 And Target.Column > 49 Then
            Dim form As New FormEstipulacoes
            form.ShowDialog()
        End If


        Globals.Sheet1.Protect("password2", , , , , True, True, True, , , , , , , , )
        Cancel = True
    End Sub

  
    Private Sub recalcularAftedelete()

        Dim ultimalinha As Integer = Globals.Sheet1.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row
        ultimalinha = ultimalinha + 1

        '''''INICIO SUPPORT TOTALS
        '''''INICIO SUPPORT TOTALS
        '''''INICIO SUPPORT TOTALS
        '''''Shipinhand
        Try
            Dim formulaX14 As String = ""
            formulaX14 = "=ABS(((AF24+AH24+AJ24+AL24+AN24+AP24)/AD24*9*Y24)+((F24*((K24/100))/AD24*9*Y24)))"
            Dim formulaX15 As String = ""
            formulaX15 = "=ABS(IF(BU24=0,0,BZ24*BV24/(BV24+BU24))*(Y24*9/AD24))"
            Dim formulaZ14 As String = ""
            formulaZ14 = "=ABS(((AX24+AZ24+BI24)/AD24*9*Y24)+((BZ24*((BA24+AY24+BJ24)/100)))/AD24*9*Y24)"
            Dim formulaZ15 As String = ""
            formulaZ15 = "=ABS((BD24/AD24*9*Y24)+((BZ24*((BE24)/100))/AD24*9*Y24))"
            Dim formulaZ16 As String = ""
            formulaZ16 = "=ABS(BF24/AD24*9*Y24)"
            Dim formulaZ17 As String = ""
            formulaZ17 = "=ABS((BB24/AD24*9*Y24)+((BZ24*((BC24)/100))/AD24*9*Y24))"

            For X = 25 To ultimalinha - 1
                If Globals.Sheet1.Range("F" & X).Value2 <> 0 And Globals.Sheet1.Range("AD" & X).Value2 <> 0 Then
                    formulaX14 = formulaX14 & "+ABS(((AF" & X & "+AH" & X & "+AJ" & X & "+AL" & X & "+AN" & X & "+AP" & X & ")/AD" & X & "*9*Y" & X & ")+((F" & X & "*((K" & X & "/100))/AD" & X & "*9*Y" & X & ")))"
                    formulaX15 = formulaX15 & "+ABS(IF(BU" & X & "=0,0,BZ" & X & "*BV" & X & "/(BV" & X & "+BU" & X & "))*(Y" & X & "*9/AD" & X & "))"
                    formulaZ14 = formulaZ14 & "+ABS(((AX" & X & "+AZ" & X & "+BI" & X & ")/AD" & X & "*9*Y" & X & ")+((BZ" & X & "*((BA" & X & "+AY" & X & "+BJ" & X & ")/100)))/AD" & X & "*9*Y" & X & ")"
                    formulaZ15 = formulaZ15 & "+ABS((BD" & X & "/AD" & X & "*9*Y" & X & ")+((BZ" & X & "*((BE" & X & ")/100))/AD" & X & "*9*Y" & X & "))"
                    formulaZ16 = formulaZ16 & "+ABS(BF" & X & "/AD" & X & "*9*Y" & X & ")"
                    formulaZ17 = formulaZ17 & "+ABS((BB" & X & "/AD" & X & "*9*Y" & X & ")+((BZ" & X & "*((BC" & X & ")/100))/AD" & X & "*9*Y" & X & "))"
                End If
            Next
            Globals.Sheet1.Range("X14").Value2 = formulaX14
            Globals.Sheet1.Range("X15").Value2 = formulaX15
            Globals.Sheet1.Range("Z14").Value2 = formulaZ14
            Globals.Sheet1.Range("Z15").Value2 = formulaZ15
            Globals.Sheet1.Range("Z16").Value2 = formulaZ16
            Globals.Sheet1.Range("Z17").Value2 = formulaZ17
        Catch ex As Exception
            MsgBox("Too many products to calculate SUPPORT TOTALS in Excel")
        End Try

        '''''Forecast
        Try
            Dim formulaS14 As String = ""
            formulaS14 = "=ABS(((AF24+AH24+AJ24+AL24+AN24+AP24)/AD24*9*Z24)+((F24*((K24/100))/AD24*9*Z24)))"
            Dim formulaS15 As String = ""
            formulaS15 = "=ABS(IF(BU24=0,0,BZ24*BV24/(BV24+BU24))*(Z24*9/AD24))"
            Dim formulaU14 As String = ""
            formulaU14 = "=ABS(((AX24+AZ24+BI24)/AD24*9*Z24)+((BZ24*((BA24+AY24+BJ24)/100)))/AD24*9*Z24)"
            Dim formulaU15 As String = ""
            formulaU15 = "=ABS((BD24/AD24*9*Z24)+((BZ24*((BE24)/100))/AD24*9*Z24))"
            Dim formulaU16 As String = ""
            formulaU16 = "=ABS(BF24/AD24*9*Z24)"
            Dim formulaU17 As String = ""
            formulaU17 = "=ABS((BB24/AD24*9*Z24)+((BZ24*((BC24)/100))/AD24*9*Z24))"

            For X = 25 To ultimalinha - 1
                If Globals.Sheet1.Range("F" & X).Value2 <> 0 And Globals.Sheet1.Range("AD" & X).Value2 <> 0 Then
                    formulaS14 = formulaS14 & "+ABS(((AF" & X & "+AH" & X & "+AJ" & X & "+AL" & X & "+AN" & X & "+AP" & X & ")/AD" & X & "*9*Z" & X & ")+((F" & X & "*((K" & X & "/100))/AD" & X & "*9*Z" & X & ")))"
                    formulaS15 = formulaS15 & "+ABS(IF(BU" & X & "=0,0,BZ" & X & "*BV" & X & "/(BV" & X & "+BU" & X & "))*(Z" & X & "*9/AD" & X & "))"
                    formulaU14 = formulaU14 & "+ABS(((AX" & X & "+AZ" & X & "+BI" & X & ")/AD" & X & "*9*Z" & X & ")+((BZ" & X & "*((BA" & X & "+AY" & X & "+BJ" & X & ")/100)))/AD" & X & "*9*Z" & X & ")"
                    formulaU15 = formulaU15 & "+ABS((BD" & X & "/AD" & X & "*9*Z" & X & ")+((BZ" & X & "*((BE" & X & ")/100))/AD" & X & "*9*ZY" & X & "))"
                    formulaU16 = formulaU16 & "+ABS(BF" & X & "/AD" & X & "*9*Z" & X & ")"
                    formulaU17 = formulaU17 & "+ABS((BB" & X & "/AD" & X & "*9*Z" & X & ")+((BZ" & X & "*((BC" & X & ")/100))/AD" & X & "*9*Z" & X & "))"
                End If
            Next
            Globals.Sheet1.Range("S14").Value2 = formulaS14
            Globals.Sheet1.Range("S15").Value2 = formulaS15
            Globals.Sheet1.Range("U14").Value2 = formulaU14
            Globals.Sheet1.Range("U15").Value2 = formulaU15
            Globals.Sheet1.Range("U16").Value2 = formulaU16
            Globals.Sheet1.Range("U17").Value2 = formulaU17
        Catch ex As Exception
            MsgBox("Too many products to calculate SUPPORT TOTALS in Excel")
        End Try

        '''''TARGET
        Try
            Dim formulaS5 As String = ""
            formulaS5 = "=ABS(((AF24+AH24+AJ24+AL24+AN24+AP24)/AD24*9*V24)+((F24*((K24/100))/AD24*9*V24)))"
            Dim formulaS6 As String = ""
            formulaS6 = "=ABS(IF(BU24=0,0,BZ24*BV24/(BV24+BU24))*(V24*9/AD24))"
            Dim formulaU5 As String = ""
            formulaU5 = "=ABS(((AX24+AZ24+BI24)/AD24*9*V24)+((BZ24*((BA24+AY24+BJ24)/100)))/AD24*9*V24)"
            Dim formulaU6 As String = ""
            formulaU6 = "=ABS((BD24/AD24*9*V24)+((BZ24*((BE24)/100))/AD24*9*V24))"
            Dim formulaU7 As String = ""
            formulaU7 = "=ABS(BF24/AD24*9*V24)"
            Dim formulaU8 As String = ""
            formulaU8 = "=ABS((BB24/AD24*9*V24)+((BZ24*((BC24)/100))/AD24*9*V24))"

            For X = 25 To ultimalinha - 1
                If Globals.Sheet1.Range("F" & X).Value2 <> 0 And Globals.Sheet1.Range("AD" & X).Value2 <> 0 Then
                    formulaS5 = formulaS5 & "+ABS(((AF" & X & "+AH" & X & "+AJ" & X & "+AL" & X & "+AN" & X & "+AP" & X & ")/AD" & X & "*9*V" & X & ")+((F" & X & "*((K" & X & "/100))/AD" & X & "*9*V" & X & ")))"
                    formulaS6 = formulaS6 & "+ABS(IF(BU" & X & "=0,0,BZ" & X & "*BV" & X & "/(BV" & X & "+BU" & X & "))*(V" & X & "*9/AD" & X & "))"
                    formulaU5 = formulaU5 & "+ABS(((AX" & X & "+AZ" & X & "+BI" & X & ")/AD" & X & "*9*V" & X & ")+((BZ" & X & "*((BA" & X & "+AY" & X & "+BJ" & X & ")/100)))/AD" & X & "*9*V" & X & ")"
                    formulaU6 = formulaU6 & "+ABS((BD" & X & "/AD" & X & "*9*V" & X & ")+((BZ" & X & "*((BE" & X & ")/100))/AD" & X & "*9*ZY" & X & "))"
                    formulaU7 = formulaU7 & "+ABS(BF" & X & "/AD" & X & "*9*V" & X & ")"
                    formulaU8 = formulaU8 & "+ABS((BB" & X & "/AD" & X & "*9*V" & X & ")+((BZ" & X & "*((BC" & X & ")/100))/AD" & X & "*9*V" & X & "))"
                End If
            Next
            Globals.Sheet1.Range("S5").Value2 = formulaS5
            Globals.Sheet1.Range("S6").Value2 = formulaS6
            Globals.Sheet1.Range("U5").Value2 = formulaU5
            Globals.Sheet1.Range("U6").Value2 = formulaU6
            Globals.Sheet1.Range("U7").Value2 = formulaU7
            Globals.Sheet1.Range("U8").Value2 = formulaU8
        Catch ex As Exception
            MsgBox("Too many products to calculate SUPPORT TOTALS in Excel")
        End Try


        '''''FIM SUPPORT TOTALS
        '''''FIM SUPPORT TOTALS
        '''''FIM SUPPORT TOTALS


        '''''INICIO Sales Data Analysis
        '''''INICIO Sales Data Analysis
        '''''INICIO Sales Data Analysis
        Try

            Globals.Sheet1.Range("L5").Value2 = "=SUM(W24:W" & ultimalinha - 1 & ")"
            Globals.Sheet1.Range("L6").Value2 = "=SUM(V24:V" & ultimalinha - 1 & ")"
            Globals.Sheet1.Range("L7").Value2 = "=SUM(Z24:Z" & ultimalinha - 1 & ")"
            Globals.Sheet1.Range("L8").Value2 = "=SUM(CT24:CT" & ultimalinha - 1 & ")"
            Globals.Sheet1.Range("L9").Value2 = "=SUM(CU24:CU" & ultimalinha - 1 & ")"

            Dim formulaN5 As String
            formulaN5 = "=(CB24/AD24*9*L5/M18)"
            Dim formulaN6 As String
            formulaN6 = "=(CB24/AD24*9*L6/M18)"
            Dim formulaN7 As String
            formulaN7 = "=(CB24/AD24*9*L7/M18)"
            Dim formulaN8 As String
            formulaN8 = "=(CB24/AD24*9*L8/M18)"
            Dim formulaN9 As String
            formulaN9 = "=(CB24/AD24*9*L9/M18)"

            Dim X As Integer
            For X = 25 To ultimalinha - 1
                If Globals.Sheet1.Range("AD" & X).Value2 <> 0 Then
                    formulaN5 = formulaN5 & "+(CB" & X & "/AD" & X & "*9*L5/M18)"
                    formulaN6 = formulaN6 & "+(CB" & X & "/AD" & X & "*9*L6/M18)"
                    formulaN7 = formulaN7 & "+(CB" & X & "/AD" & X & "*9*L7/M18)"
                    formulaN8 = formulaN8 & "+(CB" & X & "/AD" & X & "*9*L8/M18)"
                    formulaN9 = formulaN9 & "+(CB" & X & "/AD" & X & "*9*L9/M18)"
                End If
            Next
            Globals.Sheet1.Range("N5").Value2 = formulaN5
            Globals.Sheet1.Range("N6").Value2 = formulaN6
            Globals.Sheet1.Range("N7").Value2 = formulaN7
            Globals.Sheet1.Range("N8").Value2 = formulaN8
            Globals.Sheet1.Range("N9").Value2 = formulaN9
        Catch ex As Exception
            MsgBox("Too many products to calculate SALES DATA ANALYSIS in Excel")
        End Try

        '''''FIM Sales Data Analysis
        '''''FIM Sales Data Analysis
        '''''FIM Sales Data Analysis




        '''''INICIO Pricing Analysis
        '''''INICIO Pricing Analysis
        '''''INICIO Pricing Analysis
        Try
            Dim formulaN14 As String
            formulaN14 = "(Y24*S24"
            Dim formulaO14 As String
            formulaO14 = "(V24*S24"
            Dim formulaP14 As String
            formulaP14 = "(Z24*S24"


            Dim X As Integer
            For X = 25 To ultimalinha - 1
                formulaN14 = formulaN14 & "+Y" & X & "*S" & X
                formulaO14 = formulaO14 & "+V" & X & "*S" & X
                formulaP14 = formulaP14 & "+Z" & X & "*S" & X
            Next
            formulaN14 = formulaN14 & ")/(L7+L8)"
            formulaN14 = "=IF(ISERROR(" & formulaN14 & "),0," & formulaN14 & ")"


            formulaO14 = formulaO14 & ")/L6"
            formulaO14 = "=IF(ISERROR(" & formulaO14 & "),0," & formulaO14 & ")"


            formulaP14 = formulaP14 & ")/L7"
            formulaP14 = "=IF(ISERROR(" & formulaP14 & "),0," & formulaP14 & ")"


            Globals.Sheet1.Range("N14").Value2 = formulaN14
            Globals.Sheet1.Range("O14").Value2 = formulaO14
            Globals.Sheet1.Range("P14").Value2 = formulaP14


        Catch ex As Exception
            MsgBox("Too many products to calculate PRICING ANALYSIS in Excel")
        End Try
        '''''FIM Pricing Analysis
        '''''FIM Pricing Analysis
        '''''FIM Pricing Analysis

        '''''INICIO Notes
        '''''INICIO Notes
        '''''INICIO Notes
        Try
            Dim formulaH13 As String
            formulaH13 = "((BG24/AD24*9*V24)+((BZ24*(BH24/100))/AD24*9*V24))"
            Dim formulaH14 As String
            formulaH14 = "(BM24+BO24+BQ24)/100*BZ24/AD24*9*V24"


            Dim formulaH15 As String
            formulaH15 = "(AR24+AV24+AW24)/AD24*9*V24"
            Dim formulaH16 As String
            formulaH16 = "(AS24+AT24+AU24)/AD24*9*V24"


            Dim X As Integer
            For X = 25 To ultimalinha - 1
                formulaH13 = formulaH13 & "+((BG" & X & "/AD" & X & "*9*V" & X & ")+((BZ" & X & "*(BH" & X & "/100))/AD" & X & "*9*V" & X & "))"
                formulaH14 = formulaH14 & "+(BM" & X & "+BO" & X & "+BQ" & X & ")/100*BZ" & X & "/AD" & X & "*9*V" & X & ""

                formulaH15 = formulaH15 & "+(AR" & X & "+AV" & X & "+AW" & X & ")/AD" & X & "*9*V" & X & ""
                formulaH16 = formulaH16 & "+(AS" & X & "+AT" & X & "+AU" & X & ")/AD" & X & "*9*V" & X & ""
            Next
            formulaH13 = "=(" & formulaH13 & ")*M18"
            formulaH14 = "=ABS(" & formulaH14 & ")*M18"
            formulaH15 = "=ABS(" & formulaH15 & ")/M18"
            formulaH16 = "=ABS(" & formulaH16 & ")/M18"


            Globals.Sheet1.Range("H13").Value2 = formulaH13
            Globals.Sheet1.Range("H14").Value2 = formulaH14
            Globals.Sheet1.Range("H15").Value2 = formulaH15
            Globals.Sheet1.Range("H16").Value2 = formulaH16

        Catch ex As Exception
            MsgBox("Too many products to calculate NOTES in Excel")
        End Try
        '''''FIM Notes
        '''''FIM Notes
        '''''FIM Notes
    End Sub


End Class