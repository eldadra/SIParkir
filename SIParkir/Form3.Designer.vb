<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnTutup = New Button()
        btnSimpan = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblPasswordLama = New Label()
        lblUsername = New Label()
        TextBox1 = New TextBox()
        lblPasswordBaru = New Label()
        TextBox2 = New TextBox()
        lblKonfirmasiPassword = New Label()
        SuspendLayout()
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(327, 259)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(89, 43)
        btnTutup.TabIndex = 11
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(235, 259)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(89, 43)
        btnSimpan.TabIndex = 10
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(235, 107)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(181, 23)
        txtPassword.TabIndex = 9
        ' 
        ' txtUsername
        ' 
        txtUsername.Enabled = False
        txtUsername.Location = New Point(235, 63)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(181, 23)
        txtUsername.TabIndex = 8
        ' 
        ' lblPasswordLama
        ' 
        lblPasswordLama.Location = New Point(114, 106)
        lblPasswordLama.Name = "lblPasswordLama"
        lblPasswordLama.Size = New Size(115, 23)
        lblPasswordLama.TabIndex = 7
        lblPasswordLama.Text = "Password Lama"
        lblPasswordLama.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblUsername
        ' 
        lblUsername.Location = New Point(114, 62)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(99, 23)
        lblUsername.TabIndex = 6
        lblUsername.Text = "Username"
        lblUsername.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(235, 152)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(181, 23)
        TextBox1.TabIndex = 13
        ' 
        ' lblPasswordBaru
        ' 
        lblPasswordBaru.Location = New Point(114, 151)
        lblPasswordBaru.Name = "lblPasswordBaru"
        lblPasswordBaru.Size = New Size(115, 23)
        lblPasswordBaru.TabIndex = 12
        lblPasswordBaru.Text = "Password Baru"
        lblPasswordBaru.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(235, 203)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(181, 23)
        TextBox2.TabIndex = 15
        ' 
        ' lblKonfirmasiPassword
        ' 
        lblKonfirmasiPassword.Location = New Point(114, 195)
        lblKonfirmasiPassword.Name = "lblKonfirmasiPassword"
        lblKonfirmasiPassword.Size = New Size(115, 37)
        lblKonfirmasiPassword.TabIndex = 14
        lblKonfirmasiPassword.Text = "Konfirmasi Password"
        lblKonfirmasiPassword.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(570, 356)
        Controls.Add(TextBox2)
        Controls.Add(lblKonfirmasiPassword)
        Controls.Add(TextBox1)
        Controls.Add(lblPasswordBaru)
        Controls.Add(btnTutup)
        Controls.Add(btnSimpan)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPasswordLama)
        Controls.Add(lblUsername)
        Name = "Form3"
        Text = "SIParkir - Ubah Profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTutup As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPasswordLama As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblPasswordBaru As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblKonfirmasiPassword As Label
End Class
