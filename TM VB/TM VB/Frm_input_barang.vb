Imports System.Data.OleDb
Public Class Frm_input_barang
    Sub bersih()
        txtkodebarang.Clear()
        txtnama.Clear()
        txthbeli.Clear()
        txthjual.Clear()
        txtqty.Clear()
        cmbjenis.Text = ""
        cmbsatuan.Text = ""
        txtkodebarang.Focus()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Frm_input_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call bersih()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtkodebarang.Text = "" Or txtnama.Text = "" Or txthbeli.Text = "" Or txthjual.Text = "" Or txtqty.Text = "" Or cmbjenis.Text = "" Or cmbsatuan.Text = "" Then
            MessageBox.Show("Data Tidak Boleh Kosong !!", "Pesan!")
            txtkodebarang.Focus()
        Else
            'Pengecekan Database Apakah Kode Barang Sudah Ada.
            cmd = New OleDbCommand("select * from tbl_barang where kode_barang= '" & txtkodebarang.Text & "'", cnn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then
                'Melakukan Penyimpanan Data Ke Database
                cmd = New OleDbCommand("insert into tbl_barang values ('" & txtkodebarang.Text &
                                       "','" & txtnama.Text &
                                       "','" & cmbjenis.Text &
                                       "','" & cmbsatuan.Text &
                                       "','" & txthbeli.Text &
                                       "','" & txthjual.Text &
                                       "','" & txtqty.Text &
                                       "')", cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil Ditambahkan")
                Call bersih()
                Call FrmBarang.tampil_barang()
                txtkodebarang.Focus()
            End If
        End If
    End Sub

    Private Sub txtkode_TextChanged(sender As Object, e As EventArgs) Handles txtkodebarang.TextChanged
        cmd = New OleDbCommand("select * from tbl_barang where kode_barang= '" & txtkodebarang.Text & "'", cnn)
        rd = cmd.ExecuteReader
        rd.Read()
        'Memanggil Data Berdasakan Kode
        If rd.HasRows = True Then
            txtnama.Text = rd(1)
            cmbjenis.Text = rd(2)
            cmbsatuan.Text = rd(3)
            txthbeli.Text = rd(4)
            txthjual.Text = rd(5)
            txtqty.Text = rd(6)
        Else
            txtnama.Clear()
            txthbeli.Clear()
            txthjual.Clear()
            txtqty.Clear()
            cmbjenis.Text = ""
            cmbsatuan.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtkodebarang.Text = "" Then
            MessageBox.Show("Pilih Kode Barang Yang Ingin Di Hapus !!", "Pesan!")
            txtkodebarang.Focus()
        Else
            If MessageBox.Show("Ingin Hapus Data ??", "Konfirmasi!!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("delete from tbl_barang where kode_barang='" & txtkodebarang.Text & "'", cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil Di Hapus..")
                Call bersih()
                Call FrmBarang.tampil_barang()
            Else
                txtkodebarang.Clear()
                txtnama.Clear()
                txthbeli.Clear()
                txthjual.Clear()
                txtqty.Clear()
                cmbjenis.Text = ""
                cmbsatuan.Text = ""
                txtkodebarang.Focus()
            End If
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtkodebarang.Text = "" Then
            MessageBox.Show("Masukkan Kode Barang Yang Ingin Di Edit!", "Pesan!")
            txtkodebarang.Focus()
        Else
            'Pengeditan Data Berdasarkan Kode Barang Yang Dipanggil
            cmd = New OleDbCommand("Update tbl_barang set nama_barang= '" & txtnama.Text &
                                    "',jenis_barang='" & cmbjenis.Text &
                                    "',satuan_barang='" & cmbsatuan.Text &
                                    "',harga_beli='" & txthbeli.Text &
                                    "',harga_jual='" & txthjual.Text &
                                    "',stok='" & txtqty.Text &
                                    "'where kode_barang='" & txtkodebarang.Text & "'", cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Edit.")
            Call bersih()
            Call FrmBarang.tampil_barang()
            txtkodebarang.Focus()
        End If
    End Sub
End Class