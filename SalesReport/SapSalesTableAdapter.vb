Namespace CommercialSystemDataSet2TableAdapters


    Partial Public Class SapSalesTableAdapter
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
        Public Function FillByWhere(ByVal dataTable As _
     CommercialSystemDataSet2.SapSalesDataTable, ByVal WhereExp As String) _
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


    Partial Public Class SapSalesCompostosTableAdapter
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
        Public Function FillByWhere(ByVal dataTable As _
     CommercialSystemDataSet2.SapSalesCompostosDataTable, ByVal WhereExp As String) _
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


    Partial Public Class SapSalesOldReservesTableAdapter
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
        Public Function FillByWhere(ByVal dataTable As _
     CommercialSystemDataSet2.SapSalesOldReservesDataTable, ByVal WhereExp As String) _
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

    Partial Public Class SapSalesAmostrasTableAdapter
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
        Public Function FillByWhere(ByVal dataTable As _
     CommercialSystemDataSet2.SapSalesAmostrasDataTable, ByVal WhereExp As String) _
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


    Partial Public Class SapSalesGermanWarehouseTableAdapter
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
        Public Function FillByWhere(ByVal dataTable As _
     CommercialSystemDataSet2.SapSalesGermanWarehouseDataTable, ByVal WhereExp As String) _
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