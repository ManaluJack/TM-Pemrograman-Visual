Public Class FrmLaporan
    Private Sub btnviewharian_Click(sender As Object, e As EventArgs) Handles btnviewharian.Click
        CRV.SelectionFormula = "totext(tbl_jual.tanggal_jual) ='" & dtpharian.Text & "'"
        CRV.ReportSource = "lapharian.rpt"
        CRV.Refresh()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CRV.SelectionFormula = "month({tbl_jual.tanggal_jual})= " & Month(dtpbulanan.Text) &
            "and year({tbl_jual.tanggal_jual})= (" & Year(dtpbulanan.Text) & ")"
        CRV.ReportSource = "lapbulanan.rpt"
        CRV.Refresh()
    End Sub
End Class