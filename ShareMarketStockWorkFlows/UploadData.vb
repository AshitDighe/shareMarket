Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
Public Class UploadData
    Private Sub UploadData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   Dim obj = New DAL()
        '  Dim dataset = obj.GetStockListbyCompId(1)
        Dim connetionString As String = Nothing
        Dim command As SqlCommand
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim ds As DataSet = New DataSet()
        Dim i As Integer = 0
        Dim sql As String = Nothing

        Using _Con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stock;")

            sql = "select Id,companyName from companyDetails"

            If _Con.State = ConnectionState.Closed Then
                _Con.Open()
            End If

            command = New SqlCommand(sql, _Con)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            _Con.Close()
            CmbComanyName.DataSource = ds.Tables(0)
            CmbComanyName.ValueMember = "Id"
            CmbComanyName.DisplayMember = "companyName"
        End Using
    End Sub
    Public Sub deleteData()
        Using _Con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stock;")

            Try

                If _Con.State = ConnectionState.Closed Then
                    _Con.Open()
                End If

                Dim query As String = "delete   Stocklist where compId= " & CmbComanyName.SelectedValue
                Dim _cmd As SqlCommand = New SqlCommand(query, _Con)
                _cmd.ExecuteNonQuery()
            Catch ex As Exception
            Finally
                _Con.Close()
            End Try
        End Using
    End Sub
    Public Sub insert(ByVal dt As DataTable)
        Using _Con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stock;")

            Try

                If _Con.State = ConnectionState.Closed Then
                    _Con.Open()
                End If

                For Each dtRow As DataRow In dt.Rows
                    Dim stockDate = dtRow(0).ToString()
                    Dim series = dtRow(1).ToString()
                    Dim open = dtRow(2).ToString()
                    Dim high = dtRow(3).ToString()
                    Dim low = dtRow(4).ToString()
                    Dim prevclose = dtRow(5).ToString()
                    Dim ltp = dtRow(6).ToString()
                    Dim close = dtRow(7).ToString()
                    Dim vwap = dtRow(8).ToString()
                    Dim Wh = dtRow(9).ToString()
                    Dim Wl = dtRow(10).ToString()
                    Dim volume = dtRow(11).ToString()
                    Dim value = dtRow(12).ToString()
                    Dim nooftrades = dtRow(13).ToString()
                    Dim query As String = "INSERT INTO Stocklist ([stockDate],[series],[open],[HIGH],[low],[PREVCLOSE],[ltp],[close],[vwap],[52WH ],[52WL ],[volume],[value],noOfTrades,compId) values(" & stockDate & ",'" & series & "'," & open & "," & high & "," & low & "," & prevclose & "," & ltp & "," & close & "," & vwap & "," & Wh & "," & Wl & "," & volume & "," & value & "," & nooftrades & "," & CmbComanyName.SelectedValue & ")"
                    Dim _cmd As SqlCommand = New SqlCommand(query, _Con)
                    _cmd.ExecuteNonQuery()
                Next

            Catch ex As Exception
            Finally
                _Con.Close()
            End Try
        End Using
    End Sub
    Public Sub ImportExcel(ByVal filePath As String, ByVal companyId As Integer)
        Using doc As SpreadsheetDocument = SpreadsheetDocument.Open(filePath, False)
            Dim sheet As Sheet = doc.WorkbookPart.Workbook.Sheets.GetFirstChild(Of Sheet)()
            Dim worksheet As Worksheet = (TryCast(doc.WorkbookPart.GetPartById(sheet.Id.Value), WorksheetPart)).Worksheet
            Dim rows As IEnumerable(Of Row) = worksheet.GetFirstChild(Of SheetData)().Descendants(Of Row)()
            Dim dt As DataTable = New DataTable()

            For Each row As Row In rows

                If row.RowIndex.Value = 1 Then

                    For Each cell As Cell In row.Descendants(Of Cell)()
                        dt.Columns.Add(GetValue(doc, cell))
                    Next
                Else
                    dt.Rows.Add()
                    Dim i As Integer = 0

                    For Each cell As Cell In row.Descendants(Of Cell)()

                        If cell.InnerText <> "" Then
                            dt.Rows(dt.Rows.Count - 1)(i) = GetValue(doc, cell)
                            i += 1
                        End If
                    Next
                End If
            Next

            deleteData()
            insert(dt)
        End Using
    End Sub
    Private Function GetValue(ByVal doc As SpreadsheetDocument, ByVal cell As Cell) As String
        Dim value As String = cell.CellValue.InnerText

        If cell.DataType IsNot Nothing AndAlso cell.DataType.Value = CellValues.SharedString Then
            Return doc.WorkbookPart.SharedStringTablePart.SharedStringTable.ChildElements.GetItem(Integer.Parse(value)).InnerText
        End If

        Return value
    End Function

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles Dialog1.HelpRequest

    End Sub

    Private Sub CmbComanyName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbComanyName.SelectedIndexChanged
        Dim message As String = "companyName: " & CmbComanyName.Text
        message += Environment.NewLine
        'message += "Id: " & CmbComanyName.SelectedValue
    End Sub

    Private Sub Btn_uploaddata_Click(sender As Object, e As EventArgs) Handles Btn_uploaddata.Click
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog With {
               .InitialDirectory = "D:\workSpace\stockAnalisis\uploadFiles",
               .Title = "Browse Text Files",
               .CheckFileExists = True,
               .CheckPathExists = True,
               .DefaultExt = "xlsx",
               .Filter = "txt files (*.xlsx)|*.xlsx",
               .FilterIndex = 2,
               .RestoreDirectory = True,
               .ReadOnlyChecked = True,
               .ShowReadOnly = True
           }

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ImportExcel(openFileDialog1.FileName, Convert.ToInt32(CmbComanyName.SelectedValue))
        End If
    End Sub
End Class