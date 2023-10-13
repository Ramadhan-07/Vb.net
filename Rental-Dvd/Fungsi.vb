Imports MySql.Data.MySqlClient
Module Fungsi
    Dim serv As String = "Server = localhost" & ";"
    Dim dbase As String = "Database = dbrentaldvd" & ";"
    Dim uid As String = "uid = root" & ";"
    Dim pwd As String = "pwd = " & ";"
    Dim ConString = serv & dbase & uid & pwd & "default command timeout = 3600; Allow User Variables = true"

    Public db As New MySqlConnection(ConString)
    Public myCommand As MySqlCommand
    Public myAdapter As MySqlDataAdapter
    Public myDataset As DataSet
    Public myReader As MySqlDataReader
    Public Sub bukaDB()
        Try
            tutupDB()
            db.Open()
            'MessageBox.Show("Connection Successfully", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Caution!" & ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub tutupDB()
        If db.State = ConnectionState.Open Then
            db.Close()
        End If
    End Sub

    ' Form DVD
    Public Function getTabelDVD() As DataTable
        Dim myDataTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM dvd ORDER BY nodvd", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "nodvd")
            myDataTable = myDataset.Tables(0)
            Return (myDataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Function getViewDVD(ByVal nodvd As String) As DataTable
        Dim myViewTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM dvd WHERE nodvd = @nodvd", db)
            myCommand.Parameters.AddWithValue("@nodvd", nodvd)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "nodvd")
            myViewTable = myDataset.Tables(0)
            Return (myViewTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Sub tambah_menu(ByVal nodvd As String, ByVal film As String, ByVal harga As Integer, ByVal tanggalmasuk As String, ByVal rilis As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO dvd (nodvd, film, harga, tanggalmasuk, rilis) VALUES (@nodvd, @film, @harga, @tanggalmasuk, @rilis)"
        myCommand.Parameters.AddWithValue("@nodvd", nodvd)
        myCommand.Parameters.AddWithValue("@film", film)
        myCommand.Parameters.AddWithValue("@harga", harga)
        myCommand.Parameters.AddWithValue("@tanggalmasuk", tanggalmasuk)
        myCommand.Parameters.AddWithValue("@rilis", rilis)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub hapus_menu(ByVal nodvd As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "DELETE FROM dvd WHERE nodvd = @nodvd"
        myCommand.Parameters.AddWithValue("@nodvd", nodvd)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            bersih_menu()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub bersih_menu()
        With frmDVD
            .txtnodvd.Text = ""
            .txtfilm.Text = ""
            .txtharga.Text = ""
            .txttanggal.Text = ""
            .txtrilis.Text = ""
        End With
    End Sub

    Public Sub ubah_menu(ByVal nodvd As String, ByVal film As String, ByVal harga As Integer, ByVal tanggalmasuk As String, ByVal rilis As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE dvd SET film = @film, harga = @harga, taanggalmasuk = @tanggalmasuk, rilis = @rilis WHERE nodvd = @nodvd"
        myCommand.Parameters.AddWithValue("@nodvd", nodvd)
        myCommand.Parameters.AddWithValue("@film", film)
        myCommand.Parameters.AddWithValue("@harga", harga)
        myCommand.Parameters.AddWithValue("@tanggalmasuk", tanggalmasuk)
        myCommand.Parameters.AddWithValue("@rilis", rilis)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub

    ' Form Member
    Public Function getTabelMember() As DataTable
        Dim myDataTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM member ORDER BY nomember", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "nomember")
            myDataTable = myDataset.Tables(0)
            Return (myDataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Function getViewMember(ByVal noanggota As String) As DataTable
        Dim myViewTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM member WHERE nomember = @nomember", db)
            myCommand.Parameters.AddWithValue("@nomember", noanggota)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "nomember")
            myViewTable = myDataset.Tables(0)
            Return (myViewTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Sub tambah_menu2(ByVal nomember As String, ByVal nama As String, ByVal alamat As String, ByVal kota As String, ByVal nohp As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO member (nomember, nama, alamat, kota, nohp) VALUES (@nomember, @nama, @alamat, @kota, @nohp)"
        myCommand.Parameters.AddWithValue("@nomember", nomember)
        myCommand.Parameters.AddWithValue("@nama", nama)
        myCommand.Parameters.AddWithValue("@alamat", alamat)
        myCommand.Parameters.AddWithValue("@kota", kota)
        myCommand.Parameters.AddWithValue("@nohp", nohp)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub hapus_menu2(ByVal noanggota As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "DELETE FROM member WHERE nomember = @nomember"
        myCommand.Parameters.AddWithValue("@nomember", noanggota)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            bersih_menu2()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub bersih_menu2()
        With frmMember
            .txtMember.Text = ""
            .txtNama.Text = ""
            .txtAlamat.Text = ""
            .txtKota.Text = ""
            .txtNohp.Text = ""
        End With
    End Sub

    Public Sub ubah_menu2(ByVal nomember As String, ByVal nama As String, ByVal alamat As String, ByVal kota As String, ByVal nohp As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE member SET nama = @nama, alamat = @alamat, kota = @kota, nohp = @nohp WHERE nomember = @nomember"
        myCommand.Parameters.AddWithValue("@nomember", nomember)
        myCommand.Parameters.AddWithValue("@nama", nama)
        myCommand.Parameters.AddWithValue("@alamat", alamat)
        myCommand.Parameters.AddWithValue("@kota", kota)
        myCommand.Parameters.AddWithValue("@nohp", nohp)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub

    ' Form Transaksi Penyewaan
    Public Function getTabelSewa() As DataTable
        Dim myDataTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT p.notransaksi, a.nama, b.film, p.tanggalsewa FROM penyewaan p, member a, dvd b WHERE a.nomember = p.nomember AND b.nodvd = p.nodvd ORDER BY notransaksi", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "notransaksi")
            myDataTable = myDataset.Tables(0)
            Return (myDataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Function getViewSewa(ByVal notransaksi As String) As DataTable
        Dim myViewTable As DataTable

        Try
            bukaDB()

            myCommand = New MySqlCommand("p.notransaksi, a.nama, b.nama, p.tanggalsewa FROM penyewaan p, member a, dvd b WHERE b.nodvd = p.nodvd AND a.nomember = p.nomember AND notransaksi = @notransaksi", db)
            myCommand.Parameters.AddWithValue("@notransaksi", notransaksi)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "notransaksi")
            myViewTable = myDataset.Tables(0)
            Return (myViewTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Sub tambah_menu3(ByVal notransaksi As String, ByVal nomember As String, ByVal nodvd As String, ByVal tanggalsewa As Date)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO penyewaan (notransaksi, nomember, nodvd, tanggalsewa) VALUES (@notransaksi, @nomember, @nodvd, @tanggalsewa)"
        myCommand.Parameters.AddWithValue("@notransaksi", notransaksi)
        myCommand.Parameters.AddWithValue("@nomember", nomember)
        myCommand.Parameters.AddWithValue("@tanggalsewa", tanggalsewa)
        myCommand.Parameters.AddWithValue("@nodvd", nodvd)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub hapus_menu3(ByVal notransaksi As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "DELETE FROM penyewaan WHERE notransaksi = @notransaksi"
        myCommand.Parameters.AddWithValue("@notransaksi", notransaksi)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            bersih_menu2()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub bersih_menu3()
        With frmPenyewaan
            .txtnotran.Text = ""
            .txtmem.Text = ""
            .txtdvd.Text = ""
        End With
    End Sub

    Public Sub ubah_menu3(ByVal notransaksi As String, ByVal nomember As String, ByVal nodvd As String, ByVal tanggalsewa As Date)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE member SET nomember = @nomember, nodvd = @nodvd, tanggalsewa = @tanggalsewa WHERE notransaksi = @notransaksi"
        myCommand.Parameters.AddWithValue("@notransaksi", notransaksi)
        myCommand.Parameters.AddWithValue("@nomember", nomember)
        myCommand.Parameters.AddWithValue("@tanggalsewa", tanggalsewa)
        myCommand.Parameters.AddWithValue("@nodvd", nodvd)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub


End Module
