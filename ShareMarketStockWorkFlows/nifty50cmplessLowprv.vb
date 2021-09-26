Public Class nifty50cmplessLowprv
    Private Sub btnload_Click(sender As Object, e As EventArgs)
        ' Dim obj = New DAL()
        'Dim dataset = obj.GetStockListbyCompId(1)
        'DataGridView1.DataSource = dataset.Tables(0)
        'Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub nifty50cmplessLowprv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn() {New DataColumn("Company Name", GetType(String)),
                                               New DataColumn("C.M.P", GetType(String)),
                                                New DataColumn("Prv.Open", GetType(String)),
                                                New DataColumn("Prv.High", GetType(String)),
                                               New DataColumn("Prv.Low", GetType(String))})
        'New DataColumn("C.M.P", GetType(String))})
        dt.Rows.Add("EICHER MOTORS LTD", "	2472.5	", "2558	", "2558	", "2487.1")
        dt.Rows.Add("SHREE CEMENT LTD", "	23685", "	24420.7", "	24499.9", "	23687.4")
        DataGridView1.DataSource = dt
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' DataGridView1.DataBind()
        'End If
    End Sub
End Class