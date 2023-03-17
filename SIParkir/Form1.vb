Public Class Form1

    Private Sub AturProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturProfilToolStripMenuItem.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanggananToolStripMenuItem.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Form5.Show()
        Me.Close()
    End Sub
End Class
