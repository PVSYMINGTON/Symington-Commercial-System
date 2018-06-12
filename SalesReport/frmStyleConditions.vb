Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid

Partial Public Class frmStyleConditions
    Inherits DevExpress.XtraEditors.XtraForm
    Public Sub New(ByVal location As Point, ByVal field As PivotGridField)
        InitializeComponent()
        Me.Location = location
        Me.field = field
        FillData()
    End Sub
    Private WithEvents conditionItem1 As ConditionItem
    Private field As PivotGridField
    Private Sub FillData()
        FormatItemList.Items.Clear()
        If field Is Nothing Then
            Return
        End If
        For i As Integer = 0 To field.PivotGrid.FormatConditions.Count - 1
            '            If field.Equals(field.PivotGrid.FormatConditions(i).Field) Then
            Try
                FormatItemList.Items.Add(New DemoFormatCondition(field.PivotGrid.FormatConditions(i), field.PivotGrid.FormatConditions(i).Field.ToString))
            Catch
            End Try
            'End If
        Next i
        If FormatItemList.Items.Count > 0 Then
            FormatItemList.SelectedIndex = 0
        Else
            conditionItem1.InitItem(Nothing)
        End If
    End Sub

    Private Sub SetRemoveEnabled()
        sbRemove.Enabled = FormatItemList.SelectedIndex > -1
    End Sub

    Private Sub FormatItemList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatItemList.SelectedIndexChanged
        SetRemoveEnabled()
        If FormatItemList.SelectedItem IsNot Nothing Then
            conditionItem1.InitItem(field.PivotGrid.FormatConditions((CType(FormatItemList.SelectedItem, DemoFormatCondition)).Index))
        Else
            conditionItem1.InitItem(Nothing)
        End If

    End Sub

    Private Sub sbAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAdd.Click
        Try
            FormatItemList.Items.BeginUpdate()
            Dim item As PivotGridStyleFormatCondition = New PivotGridStyleFormatCondition()
            'item.Field = Me.field
            item.Field = CBField.SelectedItem
            field.PivotGrid.FormatConditions.Add(item)

            Dim demoCondition As DemoFormatCondition = New DemoFormatCondition(item, item.Field.Caption)
            FormatItemList.Items.Add(demoCondition)
            FormatItemList.SelectedItem = demoCondition
            FormatItemList.Items.EndUpdate()

        Catch

        End Try

    End Sub

    Private Sub sbRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbRemove.Click
        Dim condition As DemoFormatCondition = TryCast(FormatItemList.SelectedItem, DemoFormatCondition)
        If condition Is Nothing Then
            Return
        End If
        field.PivotGrid.FormatConditions.Remove(condition.Condition)
        FormatItemList.Items.Remove(condition)
    End Sub

    Private Sub frmStyleConditions_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub conditionItem1_RefreshValues(ByVal sender As Object, ByVal e As System.EventArgs) Handles conditionItem1.RefreshValues
        FormatItemList.Refresh()
    End Sub



    Public Class DemoFormatCondition
        Private fCondition As PivotGridStyleFormatCondition = Nothing
        Private selecteditem As String
        Public Sub New(ByVal fCondition As PivotGridStyleFormatCondition, ByVal selecteditem As String)
            Me.fCondition = fCondition
            Me.selecteditem = selecteditem
        End Sub
        Public ReadOnly Property Condition() As PivotGridStyleFormatCondition
            Get
                Return fCondition
            End Get
        End Property


        Public Overrides Function ToString() As String
            If Condition Is Nothing Then
                Return "Empty condition"
            End If
            If Condition.Condition <> FormatConditionEnum.None Then
                If Condition.Condition = FormatConditionEnum.Between OrElse Condition.Condition = FormatConditionEnum.NotBetween Then
                    Return String.Format(selecteditem & " - {0} {1:c}, {2:c}", Condition.Condition, Condition.Value1, Condition.Value2)
                Else
                    Return String.Format(selecteditem & " - {0} {1:c}", Condition.Condition, Condition.Value1)
                End If
            End If
            Return String.Format("Condition Item - Index {0}", Index)
        End Function
        Public ReadOnly Property Index() As Integer
            Get
                Return Condition.PivotGrid.FormatConditions.IndexOf(Condition)
            End Get
        End Property
    End Class

   
End Class