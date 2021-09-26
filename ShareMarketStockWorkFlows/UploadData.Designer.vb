<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadData
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
        Me.Dialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbComanyName = New System.Windows.Forms.ComboBox()
        Me.Btn_uploaddata = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Dialog1
        '
        Me.Dialog1.SelectedPath = "D:\workSpace\shareMarket\uploadFiles"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company Name"
        '
        'CmbComanyName
        '
        Me.CmbComanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbComanyName.FormattingEnabled = True
        Me.CmbComanyName.Location = New System.Drawing.Point(281, 74)
        Me.CmbComanyName.Name = "CmbComanyName"
        Me.CmbComanyName.Size = New System.Drawing.Size(312, 33)
        Me.CmbComanyName.TabIndex = 1
        '
        'Btn_uploaddata
        '
        Me.Btn_uploaddata.Location = New System.Drawing.Point(652, 62)
        Me.Btn_uploaddata.Name = "Btn_uploaddata"
        Me.Btn_uploaddata.Size = New System.Drawing.Size(207, 58)
        Me.Btn_uploaddata.TabIndex = 2
        Me.Btn_uploaddata.Text = "Upload data"
        Me.Btn_uploaddata.UseVisualStyleBackColor = True
        '
        'UploadData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 498)
        Me.Controls.Add(Me.Btn_uploaddata)
        Me.Controls.Add(Me.CmbComanyName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UploadData"
        Me.Text = "UploadData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dialog1 As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbComanyName As ComboBox
    Friend WithEvents Btn_uploaddata As Button
End Class
