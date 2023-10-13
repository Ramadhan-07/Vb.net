Public Class frmPenyewaan

    Private Sub frmPenyewaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDB()
        DataGridView1.DataSource = getTabelSewa()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtnotran.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        txtmem.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
        txtdvd.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString
        dtpsewa.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            tambah_menu3(txtnotran.Text, txtmem.Text, txtdvd.Text, dtpsewa.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelSewa()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            ubah_menu3(txtnotran.Text, txtmem.Text, txtdvd.Text, dtpsewa.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelSewa()
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        bersih_menu3()
        DataGridView1.DataSource = getTabelSewa()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        hapus_menu3(txtnotran.Text)
        DataGridView1.DataSource = getTabelSewa()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
        frmMenu.Show()
    End Sub
End Class