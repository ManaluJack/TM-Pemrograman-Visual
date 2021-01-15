Imports System.Data.OleDb
Public Class Form_User
    Sub bersih()
        txtkodeuser.Clear()
        txtnamauser.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtlevel.Clear()
        txtkodeuser.Focus()
    End Sub
    Sub tampil_user()
        cmd = New OleDbCommand("select * from tbl_user", cnn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
        Loop
    End Sub
    Private Sub Form_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call bersih()
        Call tampil_user()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtkodeuser.Text = "" Or txtnamauser.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Or txtlevel.Text = "" Then
            MessageBox.Show("Data Tidak Boleh Kosong !!", "Pesan!")
            txtkodeuser.Focus()
        Else
            'Pengecekan Database Apakah Kode User Sudah Ada.
            cmd = New OleDbCommand("select * from tbl_user where kode_user= '" & txtkodeuser.Text & "'", cnn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then
                'Melakukan Penyimpanan Data Ke Database
                cmd = New OleDbCommand("insert into tbl_user values ('" & txtkodeuser.Text &
                                       "','" & txtnamauser.Text &
                                       "','" & txtusername.Text &
                                       "','" & txtpassword.Text &
                                       "','" & txtlevel.Text &
                                       "')", cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil Ditambahkan")
                Call bersih()
                Call tampil_user()
                txtkodeuser.Focus()
            End If
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtkodeuser.Text = "" Then
            MessageBox.Show("Masukkan Kode User Yang Ingin Di Edit!", "Pesan!")
            txtkodeuser.Focus()
        Else
            'Pengeditan Data Berdasarkan Kode User Yang Dipanggil
            cmd = New OleDbCommand("Update tbl_user set nama_user= '" & txtnamauser.Text &
                                    "',userr_name='" & txtusername.Text &
                                    "',pwd='" & txtpassword.Text &
                                    "',tingkatan='" & txtlevel.Text &
                                    "'where kode_user='" & txtkodeuser.Text & "'", cnn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil di Edit.", "Info !")
            Call bersih()
            Call tampil_user()
            txtkodeuser.Focus()
        End If
    End Sub

    Private Sub txtkodeuser_TextChanged(sender As Object, e As EventArgs) Handles txtkodeuser.TextChanged
        cmd = New OleDbCommand("select * from tbl_user where kode_user= '" & txtkodeuser.Text & "'", cnn)
        rd = cmd.ExecuteReader
        rd.Read()
        'Memanggil Data Berdasakan Kode User
        If rd.HasRows = True Then
            txtnamauser.Text = rd(1)
            txtusername.Text = rd(2)
            txtpassword.Text = rd(3)
            txtlevel.Text = rd(4)
        Else
            txtnamauser.Clear()
            txtusername.Clear()
            txtpassword.Clear()
            txtlevel.Clear()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtkodeuser.Text = "" Then
            MessageBox.Show("Pilih Kode User Yang Ingin Di Hapus !!", "Pesan!")
            txtkodeuser.Focus()
        Else
            If MessageBox.Show("Ingin Hapus Data ??", "Konfirmasi!!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("delete from tbl_user where kode_user='" & txtkodeuser.Text & "'", cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil Di Hapus..")
                Call bersih()
                Call tampil_user()
            Else
                txtkodeuser.Clear()
                txtnamauser.Clear()
                txtusername.Clear()
                txtpassword.Clear()
                txtlevel.Clear()
                txtkodeuser.Focus()
            End If
        End If
    End Sub
End Class