Public Class nifty50OpenEqlLow
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        '  Dim obj = New DAL()
        ' Dim dataset = obj.GetStockListbyCompId(1)
        'DataGridView1.DataSource = dataset.Tables(0)
        'Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub nifty50OpenEqlLow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If Not Me.IsPostBack Then
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn() {New DataColumn("Company Name", GetType(String)),
                                               New DataColumn("Open", GetType(String)),
                                                New DataColumn("High", GetType(String)),
                                               New DataColumn("Low", GetType(String)),
                                               New DataColumn("C.M.P", GetType(String))})
        dt.Rows.Add("Bajaj Finance Limited", "4805", "4868", "4805", "4847.7")
        dt.Rows.Add("KOTAK MAHINDRA BANK LTD", "1893.5", "1918.4", "1893.5", "1916.5")
        dt.Rows.Add("OIL And NATURAL GAS CORPORATION LTD", "92.6", "99.95", "92.6", "99.8")
        dt.Rows.Add("STATE BANK Of INDIA", "270.05", "276.25", "270.05", "273.95")
        DataGridView1.DataSource = dt
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' DataGridView1.DataBind()
        'End If

    End Sub
End Class