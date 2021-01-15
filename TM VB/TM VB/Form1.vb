Imports System.Data.OleDb
Public Class FormLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        End
    End Sub

    Private Sub user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Focus()
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtusername.Text = "" Or txtpassword.Text = "" Then
                MessageBox.Show("UserName/Password Masih Kosong!", "Info.")
            Else
                Call koneksi()
                cmd = New OleDbCommand("select * from tbl_user where userr_name= '" & txtusername.Text & "' and pwd= '" & txtpassword.Text & "'", cnn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Sub_Frm.Show()
                    Sub_Frm.lblnama.Text = rd.Item("nama_user")
                    Sub_Frm.lbllevel.Text = rd.Item("tingkatan")
                    If Sub_Frm.lbllevel.Text = "Kasir" Then
                        Sub_Frm.BarangToolStripMenuItem.Enabled = False
                        Sub_Frm.LaporanToolStripMenuItem.Enabled = False
                        Sub_Frm.UserToolStripMenuItem.Enabled = False
                    Else
                        Sub_Frm.BarangToolStripMenuItem.Enabled = True
                        Sub_Frm.LaporanToolStripMenuItem.Enabled = True
                        Sub_Frm.UserToolStripMenuItem.Enabled = True
                    End If
                Else
                    MessageBox.Show("Username/Password Salah !", "Warning !!")
                    txtusername.Text = ""
                    txtpassword.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("UserName/Password Masih Kosong!", "Info.")
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_user where userr_name= '" & txtusername.Text & "' and pwd= '" & txtpassword.Text & "'", cnn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Sub_Frm.Show()
                Sub_Frm.lblnama.Text = rd.Item("nama_user")
                Sub_Frm.lbllevel.Text = rd.Item("tingkatan")
                If Sub_Frm.lbllevel.Text = "Kasir" Then
                    Sub_Frm.BarangToolStripMenuItem.Enabled = False
                    Sub_Frm.LaporanToolStripMenuItem.Enabled = False
                    Sub_Frm.UserToolStripMenuItem.Enabled = False
                Else
                    Sub_Frm.BarangToolStripMenuItem.Enabled = True
                    Sub_Frm.LaporanToolStripMenuItem.Enabled = True
                    Sub_Frm.UserToolStripMenuItem.Enabled = True
                End If
            Else
                MessageBox.Show("Username/Password Salah !", "Warning !!")
                txtusername.Text = ""
                txtpassword.Text = ""
            End If
        End If
    End Sub
End Class