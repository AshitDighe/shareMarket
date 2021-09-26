Imports System.Data.SqlClient

Public Class DAL

    Public Function GetStockListbyCompId(compId As Integer)

        Dim ds As DataSet = New DataSet()

        Dim connetionString As String = Nothing
        Dim command As SqlCommand
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()

        Dim i As Integer = 0
        Dim sql As String = Nothing

        Using _Con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stock;")
            sql = "select * from Stocklist where compId=" & compId

            If _Con.State = ConnectionState.Closed Then
                _Con.Open()
            End If

            command = New SqlCommand(sql, _Con)
            adapter.SelectCommand = command
            adapter.Fill(ds)

            adapter.Dispose()
            command.Dispose()
            Return ds



            _Con.Close()
        End Using
    End Function
    Public Function GetCompanydetailsbyId(compId As Integer)
        Dim ds As DataSet = New DataSet()
        Dim connetionString As String = Nothing
        Dim command As SqlCommand
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()

        Dim i As Integer = 0
        Dim sql As String = Nothing

        Using _Con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stock;")

            sql = "select Id,companyName from companyDetails"

            If _Con.State = ConnectionState.Closed Then
                _Con.Open()
            End If

            command = New SqlCommand(sql, _Con)
            adapter.SelectCommand = command
            adapter.Fill(ds)

            adapter.Dispose()
            command.Dispose()
            Return ds
            _Con.Close()
        End Using
    End Function
End Class
