Public Class nifty50CMPless52weekHigh
    Private Sub Btnload_Click(sender As Object, e As EventArgs)
        'Dim obj = New DAL()
        'Dim dataset = obj.GetStockListbyCompId(1)
        'DataGridView1.DataSource = dataset.Tables(0)
        'Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub nifty50CMPless52weekHigh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn() {New DataColumn("Company Name", GetType(String)),
                                               New DataColumn("C.M.P", GetType(String)),
                                                New DataColumn("52 Week High", GetType(String)),
                                                New DataColumn("52 Week Low", GetType(String)),
                                               New DataColumn("52 Week Date", GetType(String))})
        'New DataColumn("C.M.P", GetType(String))})
        '  dt.Rows.Add("COAL INDIA LTD", "139.65", "136.5", "134.5")
        ' dt.Rows.Add("GAIL (INDIA) LTD", "	127.05", "	124.5", "	120.05")
        'dt.Rows.Add("HCL TECHNOLOGIES LTD", "	875.55	", "871.8	", "865.5")
        DataGridView1.DataSource = dt
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
End Class