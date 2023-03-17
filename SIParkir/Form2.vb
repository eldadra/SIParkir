Public Class Form2
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class