<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quanlynhanvien
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
        Me.dgvnhanvien = New System.Windows.Forms.DataGridView()
        Me.lblmanhanvien = New System.Windows.Forms.Label()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lbltennhanvien = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.txtmanhanvien = New System.Windows.Forms.TextBox()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txttennhanvien = New System.Windows.Forms.TextBox()
        CType(Me.dgvnhanvien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvnhanvien
        '
        Me.dgvnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvnhanvien.Location = New System.Drawing.Point(21, 144)
        Me.dgvnhanvien.Name = "dgvnhanvien"
        Me.dgvnhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvnhanvien.Size = New System.Drawing.Size(704, 286)
        Me.dgvnhanvien.TabIndex = 15
        '
        'lblmanhanvien
        '
        Me.lblmanhanvien.AutoSize = True
        Me.lblmanhanvien.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmanhanvien.Location = New System.Drawing.Point(75, 20)
        Me.lblmanhanvien.Name = "lblmanhanvien"
        Me.lblmanhanvien.Size = New System.Drawing.Size(98, 16)
        Me.lblmanhanvien.TabIndex = 4
        Me.lblmanhanvien.Text = "Mã nhân viên:"
        '
        'btnxoa
        '
        Me.btnxoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnxoa.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.ForeColor = System.Drawing.Color.White
        Me.btnxoa.Location = New System.Drawing.Point(580, 11)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(92, 49)
        Me.btnxoa.TabIndex = 11
        Me.btnxoa.Text = "Xoá"
        Me.btnxoa.UseVisualStyleBackColor = False
        '
        'btnthem
        '
        Me.btnthem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnthem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.ForeColor = System.Drawing.Color.White
        Me.btnthem.Location = New System.Drawing.Point(454, 10)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(92, 49)
        Me.btnthem.TabIndex = 12
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = False
        '
        'btnthoat
        '
        Me.btnthoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnthoat.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.ForeColor = System.Drawing.Color.White
        Me.btnthoat.Location = New System.Drawing.Point(580, 78)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(92, 49)
        Me.btnthoat.TabIndex = 13
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(215, 12)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(170, 20)
        Me.TextBox3.TabIndex = 7
        '
        'lbltennhanvien
        '
        Me.lbltennhanvien.AutoSize = True
        Me.lbltennhanvien.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltennhanvien.Location = New System.Drawing.Point(75, 61)
        Me.lbltennhanvien.Name = "lbltennhanvien"
        Me.lbltennhanvien.Size = New System.Drawing.Size(101, 16)
        Me.lbltennhanvien.TabIndex = 5
        Me.lbltennhanvien.Text = "Tên nhân viên:"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(215, 93)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(170, 20)
        Me.txtpassword.TabIndex = 8
        '
        'btnsua
        '
        Me.btnsua.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsua.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsua.ForeColor = System.Drawing.Color.White
        Me.btnsua.Location = New System.Drawing.Point(454, 78)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(92, 49)
        Me.btnsua.TabIndex = 14
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = False
        '
        'txtmanhanvien
        '
        Me.txtmanhanvien.Location = New System.Drawing.Point(215, 12)
        Me.txtmanhanvien.Name = "txtmanhanvien"
        Me.txtmanhanvien.Size = New System.Drawing.Size(170, 20)
        Me.txtmanhanvien.TabIndex = 9
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(75, 101)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(75, 16)
        Me.lblpassword.TabIndex = 6
        Me.lblpassword.Text = "Password:"
        '
        'txttennhanvien
        '
        Me.txttennhanvien.Location = New System.Drawing.Point(215, 56)
        Me.txttennhanvien.Name = "txttennhanvien"
        Me.txttennhanvien.Size = New System.Drawing.Size(170, 20)
        Me.txttennhanvien.TabIndex = 10
        '
        'Quanlynhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(746, 442)
        Me.Controls.Add(Me.dgvnhanvien)
        Me.Controls.Add(Me.lblmanhanvien)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lbltennhanvien)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.txtmanhanvien)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.txttennhanvien)
        Me.Name = "Quanlynhanvien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quanlynhanvien1"
        CType(Me.dgvnhanvien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvnhanvien As System.Windows.Forms.DataGridView
    Friend WithEvents lblmanhanvien As System.Windows.Forms.Label
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lbltennhanvien As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents txtmanhanvien As System.Windows.Forms.TextBox
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents txttennhanvien As System.Windows.Forms.TextBox
End Class
