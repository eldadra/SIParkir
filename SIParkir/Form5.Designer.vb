<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        lblPeriode = New Label()
        ComboBox1 = New ComboBox()
        lblTahun = New Label()
        txtTahun = New TextBox()
        lblLaporan = New Label()
        TextBox1 = New TextBox()
        btnTampilLaporan = New Button()
        btnTutup = New Button()
        SuspendLayout()
        ' 
        ' lblPeriode
        ' 
        lblPeriode.AutoSize = True
        lblPeriode.Location = New Point(26, 41)
        lblPeriode.Name = "lblPeriode"
        lblPeriode.Size = New Size(47, 15)
        lblPeriode.TabIndex = 0
        lblPeriode.Text = "Periode"' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        ComboBox1.Location = New Point(88, 38)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.Location = New Point(26, 84)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(39, 15)
        lblTahun.TabIndex = 2
        lblTahun.Text = "Tahun"' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(88, 84)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(121, 23)
        txtTahun.TabIndex = 3
        ' 
        ' lblLaporan
        ' 
        lblLaporan.AutoSize = True
        lblLaporan.Location = New Point(26, 153)
        lblLaporan.Name = "lblLaporan"
        lblLaporan.Size = New Size(50, 15)
        lblLaporan.TabIndex = 4
        lblLaporan.Text = "Laporan"' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(26, 182)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(496, 227)
        TextBox1.TabIndex = 5
        ' 
        ' btnTampilLaporan
        ' 
        btnTampilLaporan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnTampilLaporan.Location = New Point(426, 51)
        btnTampilLaporan.Name = "btnTampilLaporan"
        btnTampilLaporan.Size = New Size(96, 36)
        btnTampilLaporan.TabIndex = 6
        btnTampilLaporan.Text = "Tampilkan"
        btnTampilLaporan.UseVisualStyleBackColor = True
        ' 
        ' btnTutup
        ' 
        btnTutup.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnTutup.Location = New Point(426, 431)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(96, 36)
        btnTutup.TabIndex = 7
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(536, 479)
        Controls.Add(btnTutup)
        Controls.Add(btnTampilLaporan)
        Controls.Add(TextBox1)
        Controls.Add(lblLaporan)
        Controls.Add(txtTahun)
        Controls.Add(lblTahun)
        Controls.Add(ComboBox1)
        Controls.Add(lblPeriode)
        Name = "Form5"
        Text = "SIParkir - Laporan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPeriode As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblTahun As Label
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents lblLaporan As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnTampilLaporan As Button
    Friend WithEvents btnTutup As Button
End Class
