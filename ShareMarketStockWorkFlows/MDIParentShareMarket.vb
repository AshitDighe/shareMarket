Imports System.Windows.Forms

Public Class MDIParentShareMarket

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber
        
        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren

            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParentShareMarket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NewMDIChild As New LoginForm1()
        ''Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me

        'Display the new form.

        ''MDIParentShareMarket.Show()
        NewMDIChild.Show()




    End Sub

    Private Sub ToolStripMenuItem_CompanyMaster_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_CompanyMaster.Click
        Dim NewMDIChild As New CompanyMaster()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ToolStripMenuItem_OpenEqlLow_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_OpenEqlLow.Click
        Dim NewMDIChild As New nifty50OpenEqlLow()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ToolStripMenuItemUploadData_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemUploadData.Click
        Dim NewMDIChild As New UploadData()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub stockalldata_Click(sender As Object, e As EventArgs) Handles HistoricalStockScanner.Click
        Dim NewMDIChild As New HistoricalStockScanner()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ToolStripMenuItem_OpenEqlhigh_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_OpenEqlhigh.Click
        Dim NewMDIChild As New nifty50OpenEqlhigh()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ToolStripMenuItem_cmplesslow_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_cmplesslow.Click
        Dim NewMDIChild As New nifty50cmplessLowprv()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ToolStripMenuItem_cpmGrethigh_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_cpmGrethigh.Click
        Dim NewMDIChild As New nifty50cmpGretHighprv()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ToolStripMenuItem_cmpGretHigh_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_cmpGretHigh.Click
        Dim NewMDIChild As New nifty50cmpGretHigh15min()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ToolStripMenuItem_cmplessLow15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_cmplessLow15.Click
        Dim NewMDIChild As New nifty50cmplessLow15min()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ToolStripMenuItem_cmplesshighweek_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_cmplesshighweek.Click
        Dim NewMDIChild As New nifty50CMPless52weekHigh()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ToolStripMenuItem_cmplessloweek_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_cmplessloweek.Click
        Dim NewMDIChild As New nifty50cmpless52weekLow()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked

    End Sub
End Class
