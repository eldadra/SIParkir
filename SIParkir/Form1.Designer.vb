<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        AturProfilToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        LanggananToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        lblPlatNomor = New Label()
        lblTxtPlatNomor = New Label()
        TextBox1 = New TextBox()
        lblJenisKendaraan = New Label()
        ComboBox1 = New ComboBox()
        btnMasuk = New Button()
        btnKeluar = New Button()
        lblBiayaParkir = New Label()
        Label1 = New Label()
        lblDataGridView = New Label()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        lblInformasi = New Label()
        tanggal = New Label()
        lblTanggal = New Label()
        jam = New Label()
        lblJam = New Label()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(562, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AturProfilToolStripMenuItem, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(54, 20)
        SistemToolStripMenuItem.Text = "Sistem"' 
        ' AturProfilToolStripMenuItem
        ' 
        AturProfilToolStripMenuItem.Name = "AturProfilToolStripMenuItem"
        AturProfilToolStripMenuItem.Size = New Size(128, 22)
        AturProfilToolStripMenuItem.Text = "Atur Profil"' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(128, 22)
        LogoutToolStripMenuItem.Text = "Logout"' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LanggananToolStripMenuItem, LaporanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(55, 20)
        AdminToolStripMenuItem.Text = "Admin"' 
        ' LanggananToolStripMenuItem
        ' 
        LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        LanggananToolStripMenuItem.Size = New Size(133, 22)
        LanggananToolStripMenuItem.Text = "Langganan"' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(133, 22)
        LaporanToolStripMenuItem.Text = "Laporan"' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BantuanToolStripMenuItem1, TentangToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(63, 20)
        BantuanToolStripMenuItem.Text = "Bantuan"' 
        ' BantuanToolStripMenuItem1
        ' 
        BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        BantuanToolStripMenuItem1.Size = New Size(118, 22)
        BantuanToolStripMenuItem1.Text = "Bantuan"' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(118, 22)
        TentangToolStripMenuItem.Text = "Tentang"' 
        ' lblPlatNomor
        ' 
        lblPlatNomor.BackColor = SystemColors.ControlLight
        lblPlatNomor.BorderStyle = BorderStyle.FixedSingle
        lblPlatNomor.Font = New Font("Segoe UI", 54F, FontStyle.Bold, GraphicsUnit.Point)
        lblPlatNomor.Location = New Point(12, 37)
        lblPlatNomor.Name = "lblPlatNomor"
        lblPlatNomor.Size = New Size(538, 110)
        lblPlatNomor.TabIndex = 1
        lblPlatNomor.Text = "R 6872 ZH"
        lblPlatNomor.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTxtPlatNomor
        ' 
        lblTxtPlatNomor.AutoSize = True
        lblTxtPlatNomor.Location = New Point(12, 165)
        lblTxtPlatNomor.Name = "lblTxtPlatNomor"
        lblTxtPlatNomor.Size = New Size(77, 15)
        lblTxtPlatNomor.TabIndex = 2
        lblTxtPlatNomor.Text = "Nomor Plat : "' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(95, 162)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 23)
        TextBox1.TabIndex = 3
        ' 
        ' lblJenisKendaraan
        ' 
        lblJenisKendaraan.AutoSize = True
        lblJenisKendaraan.Location = New Point(12, 205)
        lblJenisKendaraan.Name = "lblJenisKendaraan"
        lblJenisKendaraan.Size = New Size(41, 15)
        lblJenisKendaraan.TabIndex = 4
        lblJenisKendaraan.Text = "Jenis : "' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi", "Sepeda", "Bis / Truk"})
        ComboBox1.Location = New Point(95, 205)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 23)
        ComboBox1.TabIndex = 6
        ComboBox1.Text = "Option"' 
        ' btnMasuk
        ' 
        btnMasuk.BackColor = Color.GreenYellow
        btnMasuk.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnMasuk.Location = New Point(95, 248)
        btnMasuk.Name = "btnMasuk"
        btnMasuk.Size = New Size(85, 33)
        btnMasuk.TabIndex = 7
        btnMasuk.Text = "Masuk"
        btnMasuk.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.IndianRed
        btnKeluar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnKeluar.Location = New Point(192, 248)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(85, 33)
        btnKeluar.TabIndex = 8
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' lblBiayaParkir
        ' 
        lblBiayaParkir.AutoSize = True
        lblBiayaParkir.Location = New Point(12, 319)
        lblBiayaParkir.Name = "lblBiayaParkir"
        lblBiayaParkir.Size = New Size(68, 15)
        lblBiayaParkir.TabIndex = 9
        lblBiayaParkir.Text = "Biaya Parkir"' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ControlLight
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(95, 308)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 49)
        Label1.TabIndex = 10
        Label1.Text = "Rp 50.000"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDataGridView
        ' 
        lblDataGridView.AutoSize = True
        lblDataGridView.Location = New Point(324, 165)
        lblDataGridView.Name = "lblDataGridView"
        lblDataGridView.Size = New Size(143, 15)
        lblDataGridView.TabIndex = 11
        lblDataGridView.Text = "Kendaraan sedang parkir :"' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(324, 194)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(226, 216)
        DataGridView1.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(12, 374)
        Label2.Name = "Label2"
        Label2.Size = New Size(265, 1)
        Label2.TabIndex = 14
        ' 
        ' lblInformasi
        ' 
        lblInformasi.AutoSize = True
        lblInformasi.Location = New Point(12, 385)
        lblInformasi.Name = "lblInformasi"
        lblInformasi.Size = New Size(57, 15)
        lblInformasi.TabIndex = 15
        lblInformasi.Text = "Informasi"' 
        ' tanggal
        ' 
        tanggal.AutoSize = True
        tanggal.Location = New Point(12, 409)
        tanggal.Name = "tanggal"
        tanggal.Size = New Size(54, 15)
        tanggal.TabIndex = 16
        tanggal.Text = "Tanggal :"' 
        ' lblTanggal
        ' 
        lblTanggal.Location = New Point(72, 405)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(92, 23)
        lblTanggal.TabIndex = 17
        lblTanggal.Text = "15-03-2023"
        lblTanggal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' jam
        ' 
        jam.AutoSize = True
        jam.Location = New Point(170, 409)
        jam.Name = "jam"
        jam.Size = New Size(34, 15)
        jam.TabIndex = 18
        jam.Text = "Jam :"' 
        ' lblJam
        ' 
        lblJam.Location = New Point(210, 405)
        lblJam.Name = "lblJam"
        lblJam.Size = New Size(67, 23)
        lblJam.TabIndex = 19
        lblJam.Text = "00:00:00"
        lblJam.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(562, 444)
        Controls.Add(lblJam)
        Controls.Add(jam)
        Controls.Add(lblTanggal)
        Controls.Add(tanggal)
        Controls.Add(lblInformasi)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(lblDataGridView)
        Controls.Add(Label1)
        Controls.Add(lblBiayaParkir)
        Controls.Add(btnKeluar)
        Controls.Add(btnMasuk)
        Controls.Add(ComboBox1)
        Controls.Add(lblJenisKendaraan)
        Controls.Add(TextBox1)
        Controls.Add(lblTxtPlatNomor)
        Controls.Add(lblPlatNomor)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = " "
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AturProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPlatNomor As Label
    Friend WithEvents lblTxtPlatNomor As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblJenisKendaraan As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnMasuk As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblBiayaParkir As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDataGridView As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lblInformasi As Label
    Friend WithEvents tanggal As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents jam As Label
    Friend WithEvents lblJam As Label
End Class
