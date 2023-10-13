Public Class frmMenu

    Private Sub BtnSewa_Click(sender As Object, e As EventArgs) Handles BtnSewa.Click
        frmPenyewaan.Show()
    End Sub

    Private Sub BtnMember_Click(sender As Object, e As EventArgs) Handles BtnMember.Click
        frmMember.Show()
    End Sub

    Private Sub BtnDvd_Click(sender As Object, e As EventArgs) Handles BtnDvd.Click
        frmDVD.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
