Imports System.Data.SqlClient
Public Class CompanyMaster
    Public Sub insert()
        Using _Con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stock;")
            '' Dim query As String = "Insert into companyDetails ([companyName]) values @companyName)"
            Dim cmd As SqlCommand = New SqlCommand("Insert into companyDetails ([companyName]) values ('" + txt_CompanyName.Text + "')", _Con)
            ''cmd.Parameters.Add("@companyName", txt_CompanyName.Text)
            _Con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Records Successfully Added!", MsgBoxStyle.Information, "Add New Companyname!")
            txt_CompanyName.Text = ""


            If _Con.State = ConnectionState.Open Then
                _Con.Close()
            End If
        End Using
    End Sub
    Private Sub TabPage_master_Click(sender As Object, e As EventArgs) Handles TabPage_master.Click

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click



        Using _Con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stock;")


            If txt_CompanyName.Text = "" Then
                MsgBox("please fill-up fields!", MsgBoxStyle.Exclamation, "add new Companyname!")
            Else
                Dim query As String = "select * from companydetails where companyname=@companyname "
                _Con.Open()
                Dim _cmd As SqlCommand = New SqlCommand(query, _Con)
                _cmd.Parameters.Add("@companyname", txt_CompanyName.Text)


                Using reader As SqlDataReader = _cmd.ExecuteReader()

                    If reader.HasRows Then
                        ' User already exists
                        MsgBox("Companyname Already Exist!", MsgBoxStyle.Exclamation, "Add New Companyname!")
                    Else
                        insert()
                    End If

                End Using
                _Con.Close()
            End If

        End Using
    End Sub

    Private Sub CompanyMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj = New DAL()
        Dim dataset = obj.GetCompanydetailsbyId(CmbCompanyName.SelectedValue)
        CmbCompanyName.DataSource = dataset.Tables(0)
        CmbCompanyName.ValueMember = "Id"
        CmbCompanyName.DisplayMember = "companyName"

        ''  Dim obj = New DAL()
        ''Dim dataset = obj.GetCompanydetailsbyId(1)
        Dgv_complist.DataSource = dataset.Tables(0)
        Me.Dgv_complist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub TabPage_detail_Click(sender As Object, e As EventArgs) Handles TabPage_detail.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CmbCompanyName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCompanyName.SelectedIndexChanged
        Dim message As String = "companyName: " & CmbCompanyName.Text
        message += Environment.NewLine
        'message += "Id: " & CmbCompanyName.SelectedValue
    End Sub

    Private Sub btnViewData_Click(sender As Object, e As EventArgs) Handles btnViewData.Click
        Dim obj = New DAL()
        Dim dataset = obj.GetStockListbyCompId(CmbCompanyName.SelectedValue)
        DataGridView1.DataSource = dataset.Tables(0)
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Dgv_complist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_complist.CellContentClick


    End Sub

    Private Sub CompanyDetails_Click(sender As Object, e As EventArgs) Handles CompanyDetails.Click

    End Sub
End Class