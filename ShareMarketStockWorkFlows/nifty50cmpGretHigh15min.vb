Public Class nifty50cmpGretHigh15min
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs)
        'Dim obj = New DAL()
        'Dim dataset = obj.GetStockListbyCompId(1)
        'DataGridView1.DataSource = dataset.Tables(0)
        'Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub nifty50cmpGretHigh15min_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn() {New DataColumn("Company Name", GetType(String)),
                                               New DataColumn("C.M.P", GetType(String)),
                                                New DataColumn("15 Min High", GetType(String)),
                                               New DataColumn("15 Min Low", GetType(String))})
        'New DataColumn("C.M.P", GetType(String))})
        dt.Rows.Add("COAL INDIA LTD", "139.65", "136.5", "134.5")
        dt.Rows.Add("GAIL (INDIA) LTD", "	127.05", "	124.5", "	120.05")
        dt.Rows.Add("HCL TECHNOLOGIES LTD", "	875.55	", "871.8	", "865.5")
        dt.Rows.Add("ICICI BANK LTD	", "511.65	", "511.35	", "507")
        dt.Rows.Add("INDUSIND BANK LTD", "	927.35", "	925.75", "	915.1")
        dt.Rows.Add("INFOSYS LTD", "	1168.7", "	1164", "	1155.25")
        dt.Rows.Add("ITC LTD	215.6	", "215.55	", "213.5")
        dt.Rows.Add("KOTAK MAHINDRA BANK LTD", "	1918.45", "	1915.2	", "1893.5")
        dt.Rows.Add("LARSEN & TOUBRO LTD	", "1204.35	", "1199	", "1185.1")
        dt.Rows.Add("NTPC LTD", "	101.35	", "99.65", "	97.65")
        dt.Rows.Add("RELIANCE INDUSTRIES LTD	", "2029.25	", "2024.9	", "2011.3")
        dt.Rows.Add("TATA MOTORS LTD", "	180.7	", "179.65	", "176.65")
        dt.Rows.Add("TATA STEEL LTD	", "620.9	", "620.8", "614.25")
        DataGridView1.DataSource = dt
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' DataGridView1.DataBind()
        'End If

    End Sub
End Class