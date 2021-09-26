Public Class nifty50OpenEqlhigh
    Private Sub btnload_Click(sender As Object, e As EventArgs)
        'Dim obj = New DAL()
        'Dim dataset = obj.GetStockListbyCompId(1)
        'DataGridView1.DataSource = dataset.Tables(0)
        'Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub nifty50OpenEqlhigh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn() {New DataColumn("Company Name", GetType(String)),
                                               New DataColumn("Open", GetType(String)),
                                                New DataColumn("High", GetType(String)),
                                               New DataColumn("Low", GetType(String)),
                                               New DataColumn("C.M.P", GetType(String))})
        dt.Rows.Add("BHARTI AIRTEL LTD", "	508.5", "	508.5	", "502.2	", "502.85")

        DataGridView1.DataSource = dt
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' DataGridView1.DataBind()
        'End If
    End Sub
End Class