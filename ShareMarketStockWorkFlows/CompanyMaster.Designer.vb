<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_master = New System.Windows.Forms.TabPage()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_CompanyName = New System.Windows.Forms.TextBox()
        Me.CompanyDetails = New System.Windows.Forms.TabPage()
        Me.Dgv_complist = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage_detail = New System.Windows.Forms.TabPage()
        Me.btnViewData = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbCompanyName = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_master.SuspendLayout()
        Me.CompanyDetails.SuspendLayout()
        CType(Me.Dgv_complist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_detail.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_master)
        Me.TabControl1.Controls.Add(Me.CompanyDetails)
        Me.TabControl1.Controls.Add(Me.TabPage_detail)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1900, 1026)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_master
        '
        Me.TabPage_master.Controls.Add(Me.btn_save)
        Me.TabPage_master.Controls.Add(Me.Label1)
        Me.TabPage_master.Controls.Add(Me.txt_CompanyName)
        Me.TabPage_master.Location = New System.Drawing.Point(4, 29)
        Me.TabPage_master.Name = "TabPage_master"
        Me.TabPage_master.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_master.Size = New System.Drawing.Size(1892, 993)
        Me.TabPage_master.TabIndex = 0
        Me.TabPage_master.Text = "Comapny Master"
        Me.TabPage_master.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(212, 164)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(184, 59)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Company Name"
        '
        'txt_CompanyName
        '
        Me.txt_CompanyName.Location = New System.Drawing.Point(212, 56)
        Me.txt_CompanyName.Name = "txt_CompanyName"
        Me.txt_CompanyName.Size = New System.Drawing.Size(408, 26)
        Me.txt_CompanyName.TabIndex = 0
        '
        'CompanyDetails
        '
        Me.CompanyDetails.Controls.Add(Me.Dgv_complist)
        Me.CompanyDetails.Controls.Add(Me.Label3)
        Me.CompanyDetails.Location = New System.Drawing.Point(4, 29)
        Me.CompanyDetails.Name = "CompanyDetails"
        Me.CompanyDetails.Size = New System.Drawing.Size(1892, 993)
        Me.CompanyDetails.TabIndex = 2
        Me.CompanyDetails.Text = "CompanyDetails"
        Me.CompanyDetails.UseVisualStyleBackColor = True
        '
        'Dgv_complist
        '
        Me.Dgv_complist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_complist.Location = New System.Drawing.Point(45, 86)
        Me.Dgv_complist.Name = "Dgv_complist"
        Me.Dgv_complist.RowHeadersWidth = 62
        Me.Dgv_complist.RowTemplate.Height = 28
        Me.Dgv_complist.Size = New System.Drawing.Size(887, 713)
        Me.Dgv_complist.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Company List"
        '
        'TabPage_detail
        '
        Me.TabPage_detail.Controls.Add(Me.btnViewData)
        Me.TabPage_detail.Controls.Add(Me.Label2)
        Me.TabPage_detail.Controls.Add(Me.CmbCompanyName)
        Me.TabPage_detail.Controls.Add(Me.DataGridView1)
        Me.TabPage_detail.Location = New System.Drawing.Point(4, 29)
        Me.TabPage_detail.Name = "TabPage_detail"
        Me.TabPage_detail.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_detail.Size = New System.Drawing.Size(1892, 993)
        Me.TabPage_detail.TabIndex = 1
        Me.TabPage_detail.Text = "CompanyData"
        Me.TabPage_detail.UseVisualStyleBackColor = True
        '
        'btnViewData
        '
        Me.btnViewData.Location = New System.Drawing.Point(661, 41)
        Me.btnViewData.Name = "btnViewData"
        Me.btnViewData.Size = New System.Drawing.Size(153, 42)
        Me.btnViewData.TabIndex = 3
        Me.btnViewData.Text = "View Data"
        Me.btnViewData.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Company List"
        '
        'CmbCompanyName
        '
        Me.CmbCompanyName.FormattingEnabled = True
        Me.CmbCompanyName.Location = New System.Drawing.Point(259, 49)
        Me.CmbCompanyName.Name = "CmbCompanyName"
        Me.CmbCompanyName.Size = New System.Drawing.Size(268, 28)
        Me.CmbCompanyName.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1861, 871)
        Me.DataGridView1.TabIndex = 0
        '
        'CompanyMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "CompanyMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_master.ResumeLayout(False)
        Me.TabPage_master.PerformLayout()
        Me.CompanyDetails.ResumeLayout(False)
        Me.CompanyDetails.PerformLayout()
        CType(Me.Dgv_complist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_detail.ResumeLayout(False)
        Me.TabPage_detail.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_master As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_CompanyName As TextBox
    Friend WithEvents TabPage_detail As TabPage
    Friend WithEvents btn_save As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnViewData As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbCompanyName As ComboBox
    Friend WithEvents CompanyDetails As TabPage
    Friend WithEvents Dgv_complist As DataGridView
    Friend WithEvents Label3 As Label
End Class
