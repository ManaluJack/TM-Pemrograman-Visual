Public Class Sub_Frm
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FrmBarang.ShowDialog()
    End Sub

    Private Sub Sub_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        date_clock.Text = DateTime.Now.ToString("ss:mm:hh tt    dd/MM/yyyy")
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        FrmBarang.ShowDialog()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Frmpenjualan.Show()
    End Sub

    Private Sub BarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem1.Click
        AxCrystalReport1.ReportFileName = "lapbarang.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub HarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HarianToolStripMenuItem.Click
        FrmLapPenjualan.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        End
    End Sub

    Private Sub ChangeUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeUserToolStripMenuItem.Click
        On Error Resume Next
        Me.Hide()
        FormLogin.Visible = False
        FormLogin.txtusername.Text = ""
        FormLogin.txtpassword.Text = ""
        FormLogin.ShowDialog()
        FormLogin.txtusername.Focus()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        Form_User.ShowDialog()
    End Sub
End Class