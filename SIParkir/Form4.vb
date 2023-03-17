Public Class Form4
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        MessageBox.Show("Data langganan berhasil ditambahkan", "Tambah Data")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        MessageBox.Show("Data langganan berhasil diperbarui", "Edit Data")
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        MessageBox.Show("Data langganan berhasil dihapus", "Hapus Data")
    End Sub
End Class