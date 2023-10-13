Public Class frmDVD

    Private Sub frmDVD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDB()
        DataGridView1.DataSource = getTabelDVD()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtnodvd.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        txtfilm.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
        txtharga.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString
        txttanggal.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString
        txtrilis.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            tambah_menu(txtnodvd.Text, txtfilm.Text, Integer.Parse(txtharga.Text), txttanggal.Text, txtrilis.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelDVD()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            ubah_menu(txtnodvd.Text, txtfilm.Text, Integer.Parse(txtharga.Text), txttanggal.Text, txtrilis.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelDVD()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        bersih_menu()
        DataGridView1.DataSource = getTabelDVD()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        hapus_menu(txtnodvd.Text)
        DataGridView1.DataSource = getTabelDVD()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
        frmMenu.Show()
    End Sub
End Class