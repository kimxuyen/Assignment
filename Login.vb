Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub btnDN_Click(sender As Object, e As EventArgs) Handles btnDN.Click
        Dim chuoikn As String = "workstation id=ASMPS02051.mssql.somee.com;packet size=4096;user id=gaugibbi_SQLLogin_1;pwd=Gau12345;data source=ASMPS02051.mssql.somee.com;persist security info=False;initial catalog=ASMPS02051"
        Dim KN As SqlConnection = New SqlConnection(chuoikn)
        Dim NV As New SqlDataAdapter("select * from NhanVien Where Taikhoan='" & txtDN.Text & "'and MatKhau='" & txtMK.Text & "' ", KN)
        Dim TB As New DataTable

        Try
            KN.Open()
            NV.Fill(TB)
            If TB.Rows.Count > 0 Then
                MessageBox.Show("Chúc Mừng Kết Nối Thành Công")
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Xem lại Mật Khẩu và Tài khoản")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub

End Class
