Public Class Form3
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        MessageBox.Show("Profil berhasil diperbarui", "Atur Profil Berhasil")
    End Sub
End Class