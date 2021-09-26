Public Class nifty50cmpGretHighprv
    Private Sub btnload_Click(sender As Object, e As EventArgs)
        'Dim obj = New DAL()
        'Dim dataset = obj.GetStockListbyCompId(1)
        'DataGridView1.DataSource = dataset.Tables(0)
        'Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub nifty50cmpGretHighprv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn() {New DataColumn("Company Name", GetType(String)),
                                               New DataColumn("C.M.P", GetType(String)),
                                                New DataColumn("Prv.Open", GetType(String)),
                                                New DataColumn("Prv.High", GetType(String)),
                                               New DataColumn("Prv.Low", GetType(String))})
        'New DataColumn("C.M.P", GetType(String))})
        dt.Rows.Add("BHARAT PETROLEUM CORPORATION LTD", "	405	", "395.1	", "401.5	", "387.1")
        dt.Rows.Add("COAL INDIA LTD", "	138.85", "	135.2", "	135.45	", "132.8")
        dt.Rows.Add("GAIL (INDIA) LTD", "	126.9", "	122.75", "	123.45", "	119.35")
        dt.Rows.Add("HINDUSTAN UNILEVER LTD", "	2367.45	2290", "	2357.9	", "2275.05")
        dt.Rows.Add("INDIAN OIL CORPORATION LTD", "	95.65", "	93.9", "	93.9", "	91.15")
        dt.Rows.Add("INDUSIND BANK LTD", "	930.15", "	917.95", "	927", "	905")
        dt.Rows.Add("ITC LTD", "	216.1", "	206.65", "	213.65	", "203.15")
        dt.Rows.Add("KOTAK MAHINDRA BANK LTD", "	1920.5	", "1900	", "1919.9	", "1859.85")
        dt.Rows.Add("LARSEN & TOUBRO LTD", "	1194.25", "	1182", "	1193.75", "	1170.05")
        dt.Rows.Add("NTPC LTD", "	100.8", "	98.4", "	99.35", "	96.5")
        dt.Rows.Add("OIL AND NATURAL GAS CORPORATION LTD", "	99.4	", "91	", "92.2	", "88.7")
        dt.Rows.Add("RELIANCE INDUSTRIES LTD", "	2030.05	", "2021.6", "	2028.5", "	2001")
        dt.Rows.Add("STATE BANK OF INDIA", "	272.35	", "269	", "271	", "265.55")
        dt.Rows.Add("TATA STEEL LTD", "	621.7	", "606	", "614", "	593.5"
)
        DataGridView1.DataSource = dt
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' DataGridView1.DataBind()
        'End If

    End Sub
End Class