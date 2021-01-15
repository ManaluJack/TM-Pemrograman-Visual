Imports System.Data.OleDb
Public Class FrmBarang
    Sub tampil_barang()
        cmd = New OleDbCommand("select * from tbl_barang", cnn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
        Loop
    End Sub
    Private Sub FrmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBPenjualanDataSet.tbl_barang' table. You can move, or remove it, as needed.
        Me.Tbl_barangTableAdapter.Fill(Me.DBPenjualanDataSet.tbl_barang)
        Call koneksi()
        Call tampil_barang()
        txtcari.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cmd = New OleDbCommand("select * from tbl_barang where nama_barang like '%" & txtcari.Text & "%'", cnn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
        Loop
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnolahdata.Click
        Frm_input_barang.ShowDialog()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    Private Sub btnfist_Click(sender As Object, e As EventArgs) Handles btnfist.Click
        Me.TblbarangBindingSource.MoveFirst()
    End Sub

    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        Me.TblbarangBindingSource.MovePrevious()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.TblbarangBindingSource.MoveNext()
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        Me.TblbarangBindingSource.MoveLast()
    End Sub

End Class