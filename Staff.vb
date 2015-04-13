Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmNV
    Dim TB As New DataTable
    Dim chuoiKN As String = "workstation id=ASMPS02051.mssql.somee.com;packet size=4096;user id=gaugibbi_SQLLogin_1;pwd=Gau12345;data source=ASMPS02051.mssql.somee.com;persist security info=False;initial catalog=ASMPS02051"
    Public Sub LoadData()
        Dim KN As New SqlConnection(chuoiKN)
        Dim SP As New SqlDataAdapter("Select * from NhanVien", KN)
        Try
            SP.Fill(TB)
        Catch ex As Exception

        End Try
        dgv.DataSource = TB
        KN.Close()

    End Sub
    Private Sub frmNV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KN As New SqlConnection(chuoiKN)
        Dim loai As New SqlDataAdapter("Select * from NhanVien", KN)
        Try
            KN.Open()
            'Nhập dữ liệu
            loai.Fill(TB)

        Catch ex As Exception
        End Try
        'Hiển Thị dữ liệu từ DB ra datagridview
        dgv.DataSource = TB
        KN.Close()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim KN As New SqlConnection(chuoiKN) 'Kết Nối vào chuoiKN
        Dim DL As String = "Insert into NhanVien Values (@MaNhanVien, @TenNhanVien, @TaiKhoan, @MatKhau)"
        Dim them As New SqlCommand(DL, KN)

        KN.Open()

        Try
            'thêm dữ liệu
            them.Parameters.AddWithValue("@MaNhanVien", txt0.Text)
            them.Parameters.AddWithValue("@TenNhanVien", txt1.Text)
            them.Parameters.AddWithValue("@TaiKhoan", txt2.Text)
            them.Parameters.AddWithValue("@MatKhau", txt3.Text)
            'Thực thi câu lệnh Insert dữ liệu
            them.ExecuteNonQuery()
            KN.Close()
        Catch ex As Exception
            MessageBox.Show("Thêm Dữ Liệu Thành Công")
        End Try
        TB.Clear()
        dgv.DataSource = TB
        dgv.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim KN As New SqlConnection(chuoiKN)
        KN.Open()
        'sữa dữ liệu
        Dim DL As String = "Update SanPhan Set MaNhanVien = @MaNhanVien, TenNhanVien = @TenNhanVien, TaiKhoan = @TaiKhoan, MatKhau = @MatKhau"
        Dim them As New SqlCommand(DL, KN)
        Try
            'Thêm Dữ Liệu
            them.Parameters.AddWithValue("@MaNhanVien", txt0.Text)
            them.Parameters.AddWithValue("@TenNhanVien", txt1.Text)
            them.Parameters.AddWithValue("@TaiKhoan", txt2.Text)
            them.Parameters.AddWithValue("@MatKhau", txt3.Text)

            'Thực thi câu lệnh
            them.ExecuteNonQuery()
            KN.Close()

        Catch ex As Exception
            MessageBox.Show("Chỉnh Sữa Thành Công")
        End Try
        'mở lại sản phẩm
        TB.Clear()
        dgv.DataSource = TB
        dgv.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim KN As New SqlConnection(chuoiKN)
        KN.Open()
        Dim DL As String = "Delete from NhanVien Where MaNhanVien = @MaNhanVien"
        Dim Nhap As New SqlCommand(DL, KN)
        Try
            Nhap.Parameters.AddWithValue("@MaNhanVien", txt0.Text)
            Nhap.ExecuteNonQuery()
            KN.Close()

        Catch ex As Exception
            MessageBox.Show("Xóa Thành công")
        End Try
        TB.Clear()
        dgv.DataSource = TB
        dgv.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class