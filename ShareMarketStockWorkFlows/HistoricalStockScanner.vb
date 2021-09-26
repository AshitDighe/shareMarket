Public Class HistoricalStockScanner
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj = New DAL()
        Dim dataset = obj.GetStockListbyCompId(1)
        DataGridView1.DataSource = dataset.Tables(0)
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub HistoricalStockScanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class