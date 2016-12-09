
Public Class login




    Private Sub frmdangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Application.Exit()
    End Sub

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        Dim Id As String
        Dim Pw As String

        Id = TextBox1.Text
        Pw = TextBox2.Text

        If Id = "admin" Then
            If Pw = "123" Then
                MessageBox.Show("Đăng Nhập Thành Công")
                DangnhapID = Id
                MatKhauPW = Pw
                Main.ShowDialog()
            Else
                MessageBox.Show("Sai Mật Khẩu")
            End If
        Else
            MessageBox.Show("Sai Tên Đăng Nhập")
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class


