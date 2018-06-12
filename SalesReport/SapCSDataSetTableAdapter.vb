Namespace SapCSDataSetTableAdapters


    Partial Public Class SalesHistoricoTableAdapter
        Inherits System.ComponentModel.Component
        Public Property SelectCommand() As SQLite.SQLiteCommand()

            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection
            End Get

            Set(ByVal value As SQLite.SQLiteCommand())
                Me._commandCollection = value
            End Set

        End Property
        Public Function FillByWhere(ByVal dataTable As  _
     SapCSDataSet.SalesHistoricoDataTable, ByVal WhereExp As String) _
     As Integer

            Dim stSelect As String

            stSelect = Me.CommandCollection(0).CommandText
            Try
                Me.CommandCollection(0).CommandText += " WHERE " + WhereExp
                Return Me.Fill(dataTable)
            Catch ex As Exception

            Finally
                Me.CommandCollection(0).CommandText = stSelect
            End Try

        End Function


    End Class


End Namespace