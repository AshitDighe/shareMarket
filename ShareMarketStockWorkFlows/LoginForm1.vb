Imports System.Data.SqlClient
Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ' Me.Close()


        Using _Con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stock;")
            Try
                _Con.Open()
                Dim SelectStm As String = "SELECT * FROM Users WHERE username = @UserName AND Password = @Password"
                Dim objCmd As SqlCommand = New SqlCommand(SelectStm, _Con)
                objCmd.Parameters.AddWithValue("@UserName", UsernameTextBox.Text)
                objCmd.Parameters.AddWithValue("@Password", Trim(PasswordTextBox.Text))

                Dim objAdpt As SqlDataAdapter = New SqlDataAdapter(objCmd)

                Dim objDt As DataTable = New DataTable()
                objAdpt.Fill(objDt)

                If objDt.Rows.Count > 0 Then
                    'If user is found, then show the following
                    '' Me.MDIParentShareMarket.Visible = True
                    ''Me.MDIParentShareMarket.Size = New System.Drawing.Size(510, 157)
                    ''Me.MDIParentShareMarket.Visible = False
                    MDIParentShareMarket.Show()
                    Me.Hide()

                Else

                    MessageBox.Show("Please enter your right username and password")


                End If
                _Con.Close()

            Catch ex As Exception
                MessageBox.Show("Failure")

            End Try
        End Using
    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        ''Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''MDIParentShareMarket.Enabled = False

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub
End Class
