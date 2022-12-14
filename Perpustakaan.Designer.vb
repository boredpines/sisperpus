<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpustakaan
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
        Me.MenuStripPerpustakaan = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBoxKoleksiBuku = New System.Windows.Forms.ListBox()
        Me.BtnTambahKoleksi = New System.Windows.Forms.Button()
        Me.BtnHapusKoleksi = New System.Windows.Forms.Button()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.namaKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahunTerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_msk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bahasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridKoleksiDB = New System.Windows.Forms.DataGridView()
        Me.btnrem = New System.Windows.Forms.Button()
        Me.btnselect = New System.Windows.Forms.Button()
        Me.btnupkol = New System.Windows.Forms.Button()
        Me.MenuStripPerpustakaan.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridKoleksiDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStripPerpustakaan
        '
        Me.MenuStripPerpustakaan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStripPerpustakaan.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPerpustakaan.Name = "MenuStripPerpustakaan"
        Me.MenuStripPerpustakaan.Size = New System.Drawing.Size(982, 24)
        Me.MenuStripPerpustakaan.TabIndex = 0
        Me.MenuStripPerpustakaan.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'ListBoxKoleksiBuku
        '
        Me.ListBoxKoleksiBuku.FormattingEnabled = True
        Me.ListBoxKoleksiBuku.ItemHeight = 15
        Me.ListBoxKoleksiBuku.Location = New System.Drawing.Point(12, 110)
        Me.ListBoxKoleksiBuku.Name = "ListBoxKoleksiBuku"
        Me.ListBoxKoleksiBuku.Size = New System.Drawing.Size(209, 319)
        Me.ListBoxKoleksiBuku.TabIndex = 1
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnTambahKoleksi.BackgroundImage = Global.Perpustakaan.My.Resources.Resources._67_679828_white_plus_png_plus_icon_white_png_transparent
        Me.BtnTambahKoleksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTambahKoleksi.Location = New System.Drawing.Point(12, 39)
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(50, 50)
        Me.BtnTambahKoleksi.TabIndex = 2
        Me.BtnTambahKoleksi.UseVisualStyleBackColor = False
        '
        'BtnHapusKoleksi
        '
        Me.BtnHapusKoleksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnHapusKoleksi.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.images
        Me.BtnHapusKoleksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHapusKoleksi.Location = New System.Drawing.Point(77, 39)
        Me.BtnHapusKoleksi.Name = "BtnHapusKoleksi"
        Me.BtnHapusKoleksi.Size = New System.Drawing.Size(50, 50)
        Me.BtnHapusKoleksi.TabIndex = 4
        Me.BtnHapusKoleksi.UseVisualStyleBackColor = False
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.namaKoleksi, Me.jenisKoleksi, Me.penerbit, Me.tahunTerbit, Me.tgl_msk, Me.bahasa, Me.kategori})
        Me.DataGridKoleksi.Location = New System.Drawing.Point(227, 110)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.RowTemplate.Height = 25
        Me.DataGridKoleksi.Size = New System.Drawing.Size(743, 319)
        Me.DataGridKoleksi.TabIndex = 5
        '
        'namaKoleksi
        '
        Me.namaKoleksi.HeaderText = "Nama Koleksi"
        Me.namaKoleksi.Name = "namaKoleksi"
        '
        'jenisKoleksi
        '
        Me.jenisKoleksi.HeaderText = "Jenis Koleksi"
        Me.jenisKoleksi.Name = "jenisKoleksi"
        '
        'penerbit
        '
        Me.penerbit.HeaderText = "Penerbit"
        Me.penerbit.Name = "penerbit"
        '
        'tahunTerbit
        '
        Me.tahunTerbit.HeaderText = "Tahun Terbit"
        Me.tahunTerbit.Name = "tahunTerbit"
        '
        'tgl_msk
        '
        Me.tgl_msk.HeaderText = "Tanggal Masuk"
        Me.tgl_msk.Name = "tgl_msk"
        '
        'bahasa
        '
        Me.bahasa.HeaderText = "Bahasa"
        Me.bahasa.Name = "bahasa"
        '
        'kategori
        '
        Me.kategori.HeaderText = "Kategori"
        Me.kategori.Name = "kategori"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(227, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Koleksi Buku"
        '
        'DataGridKoleksiDB
        '
        Me.DataGridKoleksiDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksiDB.Location = New System.Drawing.Point(227, 110)
        Me.DataGridKoleksiDB.Name = "DataGridKoleksiDB"
        Me.DataGridKoleksiDB.RowTemplate.Height = 25
        Me.DataGridKoleksiDB.Size = New System.Drawing.Size(743, 319)
        Me.DataGridKoleksiDB.TabIndex = 7
        '
        'btnrem
        '
        Me.btnrem.Location = New System.Drawing.Point(895, 81)
        Me.btnrem.Name = "btnrem"
        Me.btnrem.Size = New System.Drawing.Size(75, 23)
        Me.btnrem.TabIndex = 8
        Me.btnrem.Text = "Remove"
        Me.btnrem.UseVisualStyleBackColor = True
        '
        'btnselect
        '
        Me.btnselect.Location = New System.Drawing.Point(814, 81)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(75, 23)
        Me.btnselect.TabIndex = 9
        Me.btnselect.Text = "Show"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'btnupkol
        '
        Me.btnupkol.Location = New System.Drawing.Point(733, 81)
        Me.btnupkol.Name = "btnupkol"
        Me.btnupkol.Size = New System.Drawing.Size(75, 23)
        Me.btnupkol.TabIndex = 10
        Me.btnupkol.Text = "Update"
        Me.btnupkol.UseVisualStyleBackColor = True
        '
        'Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 441)
        Me.Controls.Add(Me.btnupkol)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.btnrem)
        Me.Controls.Add(Me.DataGridKoleksiDB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.BtnHapusKoleksi)
        Me.Controls.Add(Me.BtnTambahKoleksi)
        Me.Controls.Add(Me.ListBoxKoleksiBuku)
        Me.Controls.Add(Me.MenuStripPerpustakaan)
        Me.MainMenuStrip = Me.MenuStripPerpustakaan
        Me.MaximizeBox = False
        Me.Name = "Perpustakaan"
        Me.Text = "Koleksi Perpustakaan"
        Me.MenuStripPerpustakaan.ResumeLayout(False)
        Me.MenuStripPerpustakaan.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridKoleksiDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripPerpustakaan As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBoxKoleksiBuku As ListBox
    Friend WithEvents BtnTambahKoleksi As Button
    Friend WithEvents BtnHapusKoleksi As Button
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents namaKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents jenisKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents penerbit As DataGridViewTextBoxColumn
    Friend WithEvents tahunTerbit As DataGridViewTextBoxColumn
    Friend WithEvents tgl_msk As DataGridViewTextBoxColumn
    Friend WithEvents bahasa As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridKoleksiDB As DataGridView
    Friend WithEvents btnrem As Button
    Friend WithEvents btnselect As Button
    Friend WithEvents btnupkol As Button
End Class
