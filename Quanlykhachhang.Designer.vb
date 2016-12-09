<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quanlykhachhang
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
        Me.txttenkhachhang = New System.Windows.Forms.TextBox()
        Me.txtsodienthoai = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtmakhachhang = New System.Windows.Forms.TextBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.lblpdiachi = New System.Windows.Forms.Label()
        Me.lblsodienthoai = New System.Windows.Forms.Label()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.lbltenkhachhang = New System.Windows.Forms.Label()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.lblmakhachhang = New System.Windows.Forms.Label()
        Me.dgtkhachhang = New System.Windows.Forms.DataGridView()
        CType(Me.dgtkhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttenkhachhang
        '
        Me.txttenkhachhang.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenkhachhang.Location = New System.Drawing.Point(196, 45)
        Me.txttenkhachhang.Name = "txttenkhachhang"
        Me.txttenkhachhang.Size = New System.Drawing.Size(170, 22)
        Me.txttenkhachhang.TabIndex = 1
        '
        'txtsodienthoai
        '
        Me.txtsodienthoai.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsodienthoai.Location = New System.Drawing.Point(196, 83)
        Me.txtsodienthoai.Name = "txtsodienthoai"
        Me.txtsodienthoai.Size = New System.Drawing.Size(170, 22)
        Me.txtsodienthoai.TabIndex = 1
        '
        'txtdiachi
        '
        Me.txtdiachi.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiachi.Location = New System.Drawing.Point(196, 122)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(170, 22)
        Me.txtdiachi.TabIndex = 1
        '
        'txtmakhachhang
        '
        Me.txtmakhachhang.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmakhachhang.Location = New System.Drawing.Point(196, 12)
        Me.txtmakhachhang.Name = "txtmakhachhang"
        Me.txtmakhachhang.Size = New System.Drawing.Size(170, 22)
        Me.txtmakhachhang.TabIndex = 1
        '
        'btnthem
        '
        Me.btnthem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnthem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.ForeColor = System.Drawing.Color.White
        Me.btnthem.Location = New System.Drawing.Point(435, 11)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(92, 49)
        Me.btnthem.TabIndex = 2
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = False
        '
        'lblpdiachi
        '
        Me.lblpdiachi.AutoSize = True
        Me.lblpdiachi.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpdiachi.Location = New System.Drawing.Point(56, 128)
        Me.lblpdiachi.Name = "lblpdiachi"
        Me.lblpdiachi.Size = New System.Drawing.Size(54, 16)
        Me.lblpdiachi.TabIndex = 0
        Me.lblpdiachi.Text = "Địa chỉ:"
        '
        'lblsodienthoai
        '
        Me.lblsodienthoai.AutoSize = True
        Me.lblsodienthoai.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsodienthoai.Location = New System.Drawing.Point(56, 89)
        Me.lblsodienthoai.Name = "lblsodienthoai"
        Me.lblsodienthoai.Size = New System.Drawing.Size(95, 16)
        Me.lblsodienthoai.TabIndex = 0
        Me.lblsodienthoai.Text = "Số điện thoại:"
        '
        'btnsua
        '
        Me.btnsua.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsua.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsua.ForeColor = System.Drawing.Color.White
        Me.btnsua.Location = New System.Drawing.Point(435, 79)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(92, 49)
        Me.btnsua.TabIndex = 2
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = False
        '
        'lbltenkhachhang
        '
        Me.lbltenkhachhang.AutoSize = True
        Me.lbltenkhachhang.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltenkhachhang.Location = New System.Drawing.Point(56, 51)
        Me.lbltenkhachhang.Name = "lbltenkhachhang"
        Me.lbltenkhachhang.Size = New System.Drawing.Size(112, 16)
        Me.lbltenkhachhang.TabIndex = 0
        Me.lbltenkhachhang.Text = "Tên khách hàng:"
        '
        'btnthoat
        '
        Me.btnthoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnthoat.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.ForeColor = System.Drawing.Color.White
        Me.btnthoat.Location = New System.Drawing.Point(561, 79)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(92, 49)
        Me.btnthoat.TabIndex = 2
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = False
        '
        'btnxoa
        '
        Me.btnxoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnxoa.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.ForeColor = System.Drawing.Color.White
        Me.btnxoa.Location = New System.Drawing.Point(561, 12)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(92, 49)
        Me.btnxoa.TabIndex = 2
        Me.btnxoa.Text = "Xoá"
        Me.btnxoa.UseVisualStyleBackColor = False
        '
        'lblmakhachhang
        '
        Me.lblmakhachhang.AutoSize = True
        Me.lblmakhachhang.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmakhachhang.Location = New System.Drawing.Point(56, 17)
        Me.lblmakhachhang.Name = "lblmakhachhang"
        Me.lblmakhachhang.Size = New System.Drawing.Size(109, 16)
        Me.lblmakhachhang.TabIndex = 0
        Me.lblmakhachhang.Text = "Mã khách hàng:"
        '
        'dgtkhachhang
        '
        Me.dgtkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtkhachhang.Location = New System.Drawing.Point(2, 183)
        Me.dgtkhachhang.Name = "dgtkhachhang"
        Me.dgtkhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtkhachhang.Size = New System.Drawing.Size(705, 311)
        Me.dgtkhachhang.TabIndex = 0
        '
        'Quanlykhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(711, 497)
        Me.Controls.Add(Me.lblmakhachhang)
        Me.Controls.Add(Me.dgtkhachhang)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.txttenkhachhang)
        Me.Controls.Add(Me.lbltenkhachhang)
        Me.Controls.Add(Me.txtsodienthoai)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.lblsodienthoai)
        Me.Controls.Add(Me.txtmakhachhang)
        Me.Controls.Add(Me.lblpdiachi)
        Me.Controls.Add(Me.btnthem)
        Me.Name = "Quanlykhachhang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quanlykhachhang"
        CType(Me.dgtkhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txtsodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtmakhachhang As System.Windows.Forms.TextBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents lblpdiachi As System.Windows.Forms.Label
    Friend WithEvents lblsodienthoai As System.Windows.Forms.Label
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents lbltenkhachhang As System.Windows.Forms.Label
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents lblmakhachhang As System.Windows.Forms.Label
    Friend WithEvents dgtkhachhang As System.Windows.Forms.DataGridView
End Class
