<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.Location = New Point(110, 80)
        lblUsername.Name = "lblUsername"
        lblUsername.Padding = New Padding(10, 0, 10, 0)
        lblUsername.Size = New Size(99, 23)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        lblUsername.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPassword
        ' 
        lblPassword.Location = New Point(110, 137)
        lblPassword.Name = "lblPassword"
        lblPassword.Padding = New Padding(10, 0, 10, 0)
        lblPassword.Size = New Size(99, 23)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password"
        lblPassword.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(215, 81)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(181, 23)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(215, 137)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(181, 23)
        txtPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(215, 195)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(89, 43)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(310, 195)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(89, 43)
        btnKeluar.TabIndex = 5
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(570, 356)
        Controls.Add(btnKeluar)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Name = "Form2"
        Text = "SIParkir - Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnKeluar As Button
End Class
