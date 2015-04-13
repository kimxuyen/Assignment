<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmHT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmNV = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmQT = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmQLSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmLSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmQLHD = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHD = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCTHD = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmKH = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmHT, Me.tsmNV, Me.tsmQT})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmHT
        '
        Me.tsmHT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐăngXuấtToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.tsmHT.Name = "tsmHT"
        Me.tsmHT.Size = New System.Drawing.Size(80, 21)
        Me.tsmHT.Text = "Hệ Thống"
        '
        'ĐăngXuấtToolStripMenuItem
        '
        Me.ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
        Me.ĐăngXuấtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ĐăngXuấtToolStripMenuItem.Text = "Login"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'tsmNV
        '
        Me.tsmNV.Name = "tsmNV"
        Me.tsmNV.Size = New System.Drawing.Size(84, 21)
        Me.tsmNV.Text = "Nhân Viên"
        '
        'tsmQT
        '
        Me.tsmQT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmQLSP, Me.tsmQLHD, Me.tsmKH})
        Me.tsmQT.Name = "tsmQT"
        Me.tsmQT.Size = New System.Drawing.Size(74, 21)
        Me.tsmQT.Text = "Quản Trị"
        '
        'tsmQLSP
        '
        Me.tsmQLSP.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSP, Me.tsmLSP})
        Me.tsmQLSP.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.tsmQLSP.Name = "tsmQLSP"
        Me.tsmQLSP.Size = New System.Drawing.Size(207, 22)
        Me.tsmQLSP.Text = "Quản Lý Sản Phẩm"
        '
        'tsmSP
        '
        Me.tsmSP.Name = "tsmSP"
        Me.tsmSP.Size = New System.Drawing.Size(170, 22)
        Me.tsmSP.Text = "Sản Phẩm"
        '
        'tsmLSP
        '
        Me.tsmLSP.Name = "tsmLSP"
        Me.tsmLSP.Size = New System.Drawing.Size(170, 22)
        Me.tsmLSP.Text = "Loại Sản Phẩm"
        '
        'tsmQLHD
        '
        Me.tsmQLHD.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmHD, Me.tsmCTHD})
        Me.tsmQLHD.Name = "tsmQLHD"
        Me.tsmQLHD.Size = New System.Drawing.Size(207, 22)
        Me.tsmQLHD.Text = "Quản Lý Hóa Đơn"
        '
        'tsmHD
        '
        Me.tsmHD.Name = "tsmHD"
        Me.tsmHD.Size = New System.Drawing.Size(185, 22)
        Me.tsmHD.Text = "Hóa Đơn"
        '
        'tsmCTHD
        '
        Me.tsmCTHD.Name = "tsmCTHD"
        Me.tsmCTHD.Size = New System.Drawing.Size(185, 22)
        Me.tsmCTHD.Text = "Chi Tiết Hóa Đơn"
        '
        'tsmKH
        '
        Me.tsmKH.Name = "tsmKH"
        Me.tsmKH.Size = New System.Drawing.Size(207, 22)
        Me.tsmKH.Text = "Quản Lý Khách Hàng"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 357)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANG CHÍNH"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmHT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmNV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmQT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmQLSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmLSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmQLHD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmHD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCTHD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmKH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngXuấtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
