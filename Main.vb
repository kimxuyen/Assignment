Public Class frmMain

    Private Sub tsmSP_Click(sender As Object, e As EventArgs) Handles tsmSP.Click
        frmQL.Show()

    End Sub

    Private Sub tsmLSP_Click(sender As Object, e As EventArgs) Handles tsmLSP.Click
        frmSP.Show()
    End Sub

    Private Sub tsmHD_Click(sender As Object, e As EventArgs) Handles tsmHD.Click
        frmHD.Show()
    End Sub

    Private Sub tsmCTHD_Click(sender As Object, e As EventArgs) Handles tsmCTHD.Click
        frmchitiet.Show()
    End Sub

    Private Sub tsmKH_Click(sender As Object, e As EventArgs) Handles tsmKH.Click
        frmKH.Show()
    End Sub

    Private Sub tsmNV_Click(sender As Object, e As EventArgs) Handles tsmNV.Click
        frmNV.Show()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        frmLogin.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Application.Exit()

    End Sub
End Class