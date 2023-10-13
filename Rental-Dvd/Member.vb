Public Class frmMember

    Private Sub frmMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDB()
        DataGridView1.DataSource = getTabelMember()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtMember.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        txtNama.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
        txtAlamat.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString
        txtKota.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString
        txtNohp.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub


    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            tambah_menu2(txtMember.Text, txtNama.Text, txtAlamat.Text, txtKota.Text, txtNohp.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelMember()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            ubah_menu2(txtMember.Text, txtNama.Text, txtAlamat.Text, txtKota.Text, Integer.Parse(txtNohp.Text))
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelMember()
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        bersih_menu2()
        DataGridView1.DataSource = getTabelMember()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        hapus_menu2(txtMember.Text)
        DataGridView1.DataSource = getTabelMember()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
        frmMenu.Show()
    End Sub
End Class