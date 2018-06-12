Partial Class SalesSystemDataSet2
    Partial Public Class SapSalesCSDataTable
        Private Sub SapSalesCSDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ImmaterialColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class SapForecastStatDataTable



    End Class

    Partial Class SapTarget2014STATDataTable

       

      

    End Class

End Class

Namespace SalesSystemDataSet2TableAdapters
    
    Partial Class SapImmaterialSalesStatTableAdapter

    End Class

    Partial Public Class SapImmaterialSalesTableAdapter
    End Class
End Namespace

Namespace SalesSystemDataSet2TableAdapters

    Partial Public Class SapTarget2014TableAdapter
    End Class
End Namespace

Namespace SalesSystemDataSet2TableAdapters
    Partial Public Class SapImmaterialSalesStatTableAdapter
    End Class
End Namespace

Namespace SalesSystemDataSet2TableAdapters
    Partial Public Class SapImmaterialSalesStatTableAdapter
    End Class
End Namespace
