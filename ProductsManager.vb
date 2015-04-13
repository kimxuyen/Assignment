Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQL
    Dim TB As New DataTable
    Dim chuoiKN As String = "workstation id=ASMPS02051.mssql.somee.com;packet size=4096;user id=gaugibbi_SQLLogin_1;pwd=Gau12345;data source=ASMPS02051.mssql.somee.com;persist security info=False;initial catalog=ASMPS02051"

    Public Sub LoadData()
        Dim KN As New SqlConnection(chuoiKN)
        Dim SP As New SqlDataAdapter("Select * from SanPhan", KN)
        Try
            SP.Fill(TB)
        Catch ex As Exception

        End Try
        dgv.DataSource = TB
        KN.Close()

    End Sub
    Private Sub frmQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KN As New SqlConnection(chuoiKN)
        Dim SP As New SqlDataAdapter("Select * from SanPhan", KN)
        Try
            KN.Open()
            'Nhập dữ liệu
            SP.Fill(TB)
            
        Catch ex As Exception
        End Try
        'Hiển Thị dữ liệu từ DB ra datagridview
        dgv.DataSource = TB
        KN.Close()
    End Sub

    

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim KN As New SqlConnection(chuoiKN) 'Kết Nối vào chuoiKN
        Dim DL As String = "Insert into SanPhan Values (@MaSP, @TenSP, @LoaiSanPham_MaLoai, @GiaSP, @TGSuDung, @SLNhapVe, @SLXuatRa, @ChiTietSP)"
        Dim them As New SqlCommand(DL, KN)

        KN.Open()

        Try
        'thêm dữ liệu
        them.Parameters.AddWithValue("@MaSP", txtmsp.Text)
        them.Parameters.AddWithValue("@TenSP", txttsp.Text)
            them.Parameters.AddWithValue("@LoaiSanPham_MaLoai", txtml.Text)
        them.Parameters.AddWithValue("@GiaSP", txtgsp.Text)
        them.Parameters.AddWithValue("@TGSuDung", txttgsd.Text)
        them.Parameters.AddWithValue("@SLNhapVe", txtslnv.Text)
        them.Parameters.AddWithValue("@SLXuatRa", txtslxr.Text)
        them.Parameters.AddWithValue("@ChiTietSP", txtctsp.Text)
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
        Dim DL As String = "Update SanPhan Set MaSP = @MaSP, TenSP = @TenSP, LoaiSanPham_MaLoai = @LoaiSanPham_MaLoai, GiaSP = @GiaSP, TGSuDung = @TGSuDung, SLNhapVe = @SLNhapVe, SLXuatRa = @SLXuatRa, ChiTietSP = @ChiTietSP"
        Dim them As New SqlCommand(DL, KN)
        Try
            'Thêm Dữ Liệu
            them.Parameters.AddWithValue("@MaSP", txtmsp.Text)
            them.Parameters.AddWithValue("@TenSP", txttsp.Text)
            them.Parameters.AddWithValue("@LoaiSanPham_MaLoai", txtml.Text)
            them.Parameters.AddWithValue("@GiaSP", txtgsp.Text)
            them.Parameters.AddWithValue("@TGSuDung", txttgsd.Text)
            them.Parameters.AddWithValue("@SLNhapVe", txtslnv.Text)
            them.Parameters.AddWithValue("@SLXuatRa", txtslxr.Text)
            them.Parameters.AddWithValue("@ChiTietSP", txtctsp.Text)
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
        Dim DL As String = "Delete from SanPhan Where MaSP = @MaSP"
        Dim Nhap As New SqlCommand(DL, KN)
        Try
            Nhap.Parameters.AddWithValue("@MaSP", txtmsp.Text)
            Nhap.ExecuteNonQuery()
            KN.Close()

        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành công")
        End Try
        TB.Clear()
        dgv.DataSource = TB
        dgv.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Application.Exit()

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim DL As Integer = dgv.CurrentCell.RowIndex
        txtmsp.Text = dgv.Item(0, DL).Value
        txttsp.Text = dgv.Item(1, DL).Value
        txtml.Text = dgv.Item(2, DL).Value
        txtgsp.Text = dgv.Item(3, DL).Value
        txttgsd.Text = dgv.Item(4, DL).Value
        txtslnv.Text = dgv.Item(5, DL).Value
        txtslxr.Text = dgv.Item(6, DL).Value
        txtctsp.Text = dgv.Item(7, DL).Value
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class
