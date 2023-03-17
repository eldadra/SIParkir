<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        lblNamaPelanggan = New Label()
        lblNomorPlat = New Label()
        lblTarifLangganan = New Label()
        lblBerlaku = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        btnTutup = New Button()
        DateTimePicker1 = New DateTimePicker()
        txtTarifLangganan = New TextBox()
        txtNomorPlatPelanggan = New TextBox()
        txtNamPelanggan = New TextBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        lblIDPelanggan = New Label()
        txtIDPelanggan = New TextBox()
        lblJenis = New Label()
        ComboBox1 = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNamaPelanggan
        ' 
        lblNamaPelanggan.AutoSize = True
        lblNamaPelanggan.Location = New Point(29, 35)
        lblNamaPelanggan.Name = "lblNamaPelanggan"
        lblNamaPelanggan.Size = New Size(98, 15)
        lblNamaPelanggan.TabIndex = 0
        lblNamaPelanggan.Text = "Nama Pelanggan"' 
        ' lblNomorPlat
        ' 
        lblNomorPlat.AutoSize = True
        lblNomorPlat.Location = New Point(29, 86)
        lblNomorPlat.Name = "lblNomorPlat"
        lblNomorPlat.Size = New Size(68, 15)
        lblNomorPlat.TabIndex = 1
        lblNomorPlat.Text = "Nomor Plat"' 
        ' lblTarifLangganan
        ' 
        lblTarifLangganan.AutoSize = True
        lblTarifLangganan.Location = New Point(29, 136)
        lblTarifLangganan.Name = "lblTarifLangganan"
        lblTarifLangganan.Size = New Size(91, 15)
        lblTarifLangganan.TabIndex = 2
        lblTarifLangganan.Text = "Tarif Langganan"' 
        ' lblBerlaku
        ' 
        lblBerlaku.AutoSize = True
        lblBerlaku.Location = New Point(29, 189)
        lblBerlaku.Name = "lblBerlaku"
        lblBerlaku.Size = New Size(88, 15)
        lblBerlaku.TabIndex = 3
        lblBerlaku.Text = "Berlaku Hingga"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 243)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 15)
        Label1.TabIndex = 4
        Label1.Text = "Kendaraan Terdaftar Langganan :"' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(29, 271)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(585, 150)
        DataGridView1.TabIndex = 5
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(465, 442)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(149, 43)
        btnTutup.TabIndex = 6
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(173, 183)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 7
        ' 
        ' txtTarifLangganan
        ' 
        txtTarifLangganan.Location = New Point(173, 133)
        txtTarifLangganan.Name = "txtTarifLangganan"
        txtTarifLangganan.Size = New Size(200, 23)
        txtTarifLangganan.TabIndex = 8
        ' 
        ' txtNomorPlatPelanggan
        ' 
        txtNomorPlatPelanggan.Location = New Point(173, 83)
        txtNomorPlatPelanggan.Name = "txtNomorPlatPelanggan"
        txtNomorPlatPelanggan.Size = New Size(200, 23)
        txtNomorPlatPelanggan.TabIndex = 9
        ' 
        ' txtNamPelanggan
        ' 
        txtNamPelanggan.Location = New Point(173, 35)
        txtNamPelanggan.Name = "txtNamPelanggan"
        txtNamPelanggan.Size = New Size(200, 23)
        txtNamPelanggan.TabIndex = 10
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(407, 175)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(66, 31)
        btnTambah.TabIndex = 11
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(476, 173)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(66, 31)
        btnEdit.TabIndex = 12
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(548, 173)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(66, 31)
        btnHapus.TabIndex = 13
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' lblIDPelanggan
        ' 
        lblIDPelanggan.AutoSize = True
        lblIDPelanggan.Location = New Point(407, 38)
        lblIDPelanggan.Name = "lblIDPelanggan"
        lblIDPelanggan.Size = New Size(77, 15)
        lblIDPelanggan.TabIndex = 14
        lblIDPelanggan.Text = "ID Pelanggan"' 
        ' txtIDPelanggan
        ' 
        txtIDPelanggan.BorderStyle = BorderStyle.None
        txtIDPelanggan.Location = New Point(511, 38)
        txtIDPelanggan.Name = "txtIDPelanggan"
        txtIDPelanggan.Size = New Size(103, 16)
        txtIDPelanggan.TabIndex = 15
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(407, 86)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(32, 15)
        lblJenis.TabIndex = 16
        lblJenis.Text = "Jenis"' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi", "Sepeda", "Bis / Truk"})
        ComboBox1.Location = New Point(511, 83)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(103, 23)
        ComboBox1.TabIndex = 17
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(649, 497)
        Controls.Add(ComboBox1)
        Controls.Add(lblJenis)
        Controls.Add(txtIDPelanggan)
        Controls.Add(lblIDPelanggan)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnTambah)
        Controls.Add(txtNamPelanggan)
        Controls.Add(txtNomorPlatPelanggan)
        Controls.Add(txtTarifLangganan)
        Controls.Add(DateTimePicker1)
        Controls.Add(btnTutup)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(lblBerlaku)
        Controls.Add(lblTarifLangganan)
        Controls.Add(lblNomorPlat)
        Controls.Add(lblNamaPelanggan)
        Name = "Form4"
        Text = "SIParkir - Langganan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNamaPelanggan As Label
    Friend WithEvents lblNomorPlat As Label
    Friend WithEvents lblTarifLangganan As Label
    Friend WithEvents lblBerlaku As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTutup As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtTarifLangganan As TextBox
    Friend WithEvents txtNomorPlatPelanggan As TextBox
    Friend WithEvents txtNamPelanggan As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents lblIDPelanggan As Label
    Friend WithEvents txtIDPelanggan As TextBox
    Friend WithEvents lblJenis As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
