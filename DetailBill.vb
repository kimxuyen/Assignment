Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmchitiet
    Dim TB As New DataTable
    Dim chuoiKN As String = "workstation id=ASMPS02051.mssql.somee.com;packet size=4096;user id=gaugibbi_SQLLogin_1;pwd=Gau12345;data source=ASMPS02051.mssql.somee.com;persist security info=False;initial catalog=ASMPS02051"
    Public Sub LoadData()
        Dim KN As New SqlConnection(chuoiKN)
        Dim SP As New SqlDataAdapter("Select * from ChiTietHoaDon", KN)
        Try
            SP.Fill(TB)
        Catch ex As Exception

        End Try
        dgv.DataSource = TB
        KN.Close()

    End Sub

    Private Sub frmchitiet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KN As New SqlConnection(chuoiKN)
        Dim loai As New SqlDataAdapter("Select * from ChiTietHoaDon", KN)
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
        Dim DL As String = "Insert into ChiTietHoaDon Values (@MaHD, @SanPhan_MaSP, @SoLuong, @TongTien, @TrangThai, @HoaDon_MaHD)"
        Dim them As New SqlCommand(DL, KN)

        KN.Open()

        Try
            'thêm dữ liệu
            them.Parameters.AddWithValue("@MaHD", txt0.Text)
            them.Parameters.AddWithValue("@SanPhan_MaSP", txt1.Text)
            them.Parameters.AddWithValue("@SoLuong", txt2.Text)
            them.Parameters.AddWithValue("@TongTien", txt3.Text)
            them.Parameters.AddWithValue("@TrangThai", txt4.Text)
            them.Parameters.AddWithValue("@HoaDon_MaHD", txt5.Text)
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
        Dim DL As String = "Update ChiTietSanPham Set MaHD= @MaHD, SanPhan_MaSP = @SanPhan_MaSP, SoLuong = @SoLuong, TongTien = @TongTien, TrangThai = @TrangThai, HoaDon_MaHD = @HoaDon_MaHD"
        Dim them As New SqlCommand(DL, KN)
        Try
            'Thêm Dữ Liệu
            them.Parameters.AddWithValue("@MaHD", txt0.Text)
            them.Parameters.AddWithValue("@SanPhan_MaSP", txt1.Text)
            them.Parameters.AddWithValue("@SoLuong", txt2.Text)
            them.Parameters.AddWithValue("@TongTien", txt3.Text)
            them.Parameters.AddWithValue("@TrangThai", txt4.Text)
            them.Parameters.AddWithValue("@HoaDon_MaHD", txt5.Text)

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
        Dim DL As String = "Delete from ChiTietSanPham Where MaHD = @MaHD"
        Dim Nhap As New SqlCommand(DL, KN)
        Try
            Nhap.Parameters.AddWithValue("@MaHD", txt0.Text)
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


    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim DL As Integer = dgv.CurrentCell.RowIndex
        txt0.Text = dgv.Item(0, DL).Value
        txt1.Text = dgv.Item(1, DL).Value
        txt2.Text = dgv.Item(2, DL).Value
        txt3.Text = dgv.Item(3, DL).Value
        txt4.Text = dgv.Item(4, DL).Value
        txt5.Text = dgv.Item(5, DL).Value
    End Sub
End Class