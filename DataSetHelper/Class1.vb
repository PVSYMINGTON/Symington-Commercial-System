Public Class DataSetHelper
    Public ds As DataSet
    Private m_FieldInfo As ArrayList, m_FieldList As String


    Public Sub New(ByVal DataSet As DataSet)
        ds = DataSet
    End Sub

    Public Sub New()
        ds = Nothing
    End Sub

    Private Class FieldInfo
        Public RelationName As String
        Public FieldName As String      ' source table field name
        Public FieldAlias As String     ' destination table field name
        Public Aggregate As String
    End Class

    Private Sub ParseFieldList(ByVal FieldList As String, Optional ByVal AllowRelation As Boolean = False)
        '
        ' Parses FieldList into FieldInfo objects and adds them to the m_FieldInfo private member
        '
        ' FieldList syntax: [relationname.]fieldname[ alias],...
        '
        If m_FieldList = FieldList Then Exit Sub
        m_FieldInfo = New ArrayList
        m_FieldList = FieldList
        Dim Field As FieldInfo, FieldParts() As String, Fields() As String = FieldList.Split(",")
        Dim I As Integer
        For I = 0 To Fields.Length - 1
            Field = New FieldInfo
            '
            ' Parse FieldAlias
            '
            FieldParts = Fields(I).Trim().Split(" ")
            Select Case FieldParts.Length
                Case 1
                    ' to be set at the end of the loop
                Case 2
                    Field.FieldAlias = FieldParts(1)
                Case Else
                    Throw New ArgumentException("Too many spaces in field definition: '" & Fields(I) & "'.")
            End Select
            '
            ' Parse FieldName and RelationName
            '
            FieldParts = FieldParts(0).Split(".")
            Select Case FieldParts.Length
                Case 1
                    Field.FieldName = FieldParts(0)
                Case 2
                    If Not AllowRelation Then Throw New ArgumentException("Relation specifiers not allowed in field list: '" & Fields(I) & "'.")
                    '                End If
                    Field.RelationName = FieldParts(0).Trim()
                    Field.FieldName = FieldParts(1).Trim()
                Case Else
                    Throw New ArgumentException("Invalid field definition: '" & Fields(I) & "'.")
            End Select
            If Field.FieldAlias = "" Then Field.FieldAlias = Field.FieldName
            m_FieldInfo.Add(Field)
        Next
    End Sub
    Public Function CreateJoinTable(ByVal TableName As String, _
                                    ByVal SourceTable As DataTable, _
                                    ByVal FieldList As String) As DataTable
        '
        ' Creates a table based on fields of another table and related parent tables
        '
        ' FieldList syntax: [relationname.]fieldname[ alias][,[relationname.]fieldname[ alias]]...
        '
        If FieldList = "" Then
            Throw New ArgumentException("You must specify at least one field in the field list.")
            ' Return CreateTable(TableName, SourceTable)
        Else
            Dim dt As New DataTable(TableName)
            ParseFieldList(FieldList, True)
            Dim Field As FieldInfo, dc As DataColumn
            For Each Field In m_FieldInfo
                If Field.RelationName = "" Then
                    dc = SourceTable.Columns(Field.FieldName)
                    dt.Columns.Add(Field.FieldAlias, dc.DataType)
                Else
                    dc = SourceTable.ParentRelations(Field.RelationName).ParentTable.Columns(Field.FieldName)
                    dt.Columns.Add(Field.FieldAlias, dc.DataType)
                End If
            Next
        If Not ds Is Nothing Then ds.Tables.Add(dt)
        Return dt
    End If
    End Function

End Class
