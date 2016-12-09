Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Quanlynhanvien
    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online
    'Tạo chuỗi kết nối để kết nối tới Database Online
    Dim chuoiconnect As String = "workstation id=assignment.mssql.somee.com;packet size=4096;user id=superbo1408_SQLLogin_1;pwd=vasc543foe;data source=assignment.mssql.somee.com;persist security info=False;initial catalog=assignment"
    Private Sub Quanlynhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        dgvnhanvien.DataSource = database.DefaultView
    End Sub

    Private Sub dgvnhanvien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvnhanvien.CellContentClick
        Dim index As Integer = dgvnhanvien.CurrentCell.RowIndex
        txtmanhanvien.Text = dgvnhanvien.Item(0, index).Value
        txttennhanvien.Text = dgvnhanvien.Item(1, index).Value
        txtpassword.Text = dgvnhanvien.Item(2, index).Value

    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into NhanVien values (@MaNhanVien,@TenNhanVien,@Password)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@MaNhanVien", txtmanhanvien.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TenNhanVien", txttennhanvien.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Password", txtpassword.Text)



            'Exucute là ghi dữ liệu vào Database
            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Không thêm được!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)
        database.Clear()

        Query3.Fill(database)
        dgvnhanvien.DataSource = database.DefaultView
    End Sub
    Private Sub Loaddata()
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)
        connect.Open()
        Query1.Fill(database)
        dgvnhanvien.DataSource = database.DefaultView
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim Ketnoi1 As New SqlConnection(chuoiconnect)
        Ketnoi1.Open()
        Dim Stradd1 As String = "Update NhanVien set TenNhanVien=@TenNhanVien,Password=@Password where MaNhanVien=@MaNhanVien"
        Dim com As New SqlCommand(Stradd1, Ketnoi1)
        Try
            com.Parameters.AddWithValue("@MaNhanVien", txtmanhanvien.Text)
            com.Parameters.AddWithValue("@TenNhanVien", txttennhanvien.Text)
            com.Parameters.AddWithValue("@Password", txtpassword.Text)


            com.ExecuteNonQuery()
            Ketnoi1.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        database.Clear()
        dgvnhanvien.DataSource = database
        dgvnhanvien.DataSource = Nothing
        Loaddata()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection(chuoiconnect)
        ketnoi.Open()
        Dim xoadl As String = "Delete from NhanVien where MaNhanVien=@MaNhanVien"
        Dim lenh As New SqlCommand(xoadl, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaNhanVien", txtmanhanvien.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        database.Clear()
        dgvnhanvien.DataSource = database
        dgvnhanvien.DataSource = Nothing
        Loaddata()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
End Class
