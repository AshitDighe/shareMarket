Public Class nifty50cmplessLow15min
    Private Sub btnload_Click(sender As Object, e As EventArgs)
        'Dim obj = New DAL()
        ' Dim dataset = obj.GetStockListbyCompId(1)
        'DataGridView1.DataSource = dataset.Tables(0)
        'Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub nifty50cmplessLow15min_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn() {New DataColumn("Company Name", GetType(String)),
                                               New DataColumn("C.M.P", GetType(String)),
                                                New DataColumn("15 Min High", GetType(String)),
                                               New DataColumn("15 Min Low", GetType(String))})
        'New DataColumn("C.M.P", GetType(String))})
        dt.Rows.Add("ASIAN PAINTS LTD	", "2510.5", "	2536.9	", "2512.6")
        dt.Rows.Add("AXIS BANK LTD", "	623.25", "	628.35	", "623.55")
        dt.Rows.Add("BHARTI AIRTEL LTD", "	503.8	", "508.5", "	504.6")
        dt.Rows.Add("BRITANNIA INDUSTRIES LTD	", "3717.45", "	3777	", "3727.75")
        dt.Rows.Add("DR.REDDY'S LABORATORIES LTD	", "5047.8	", "5084.05	", "5055.1")
        dt.Rows.Add("EICHER MOTORS LTD	", "2476.2", "	2507.95", "	2477.15")
        dt.Rows.Add("HDFC Bank Ltd	", "1376.55", "	1395", "	1385.4")
        dt.Rows.Add("MAHINDRA & MAHINDRA LTD	", "736.55", "	744.4", "	738.15")
        DataGridView1.DataSource = dt
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' DataGridView1.DataBind()
        'End If
    End Sub
End Class