<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updatekoleksi
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
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.ChkBudaya = New System.Windows.Forms.CheckBox()
        Me.ChkTeknologi = New System.Windows.Forms.CheckBox()
        Me.ChkSosial = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkSains = New System.Windows.Forms.CheckBox()
        Me.rbinggris = New System.Windows.Forms.RadioButton()
        Me.rbbahasa = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txttahun = New System.Windows.Forms.TextBox()
        Me.txtlokasi = New System.Windows.Forms.TextBox()
        Me.txtpenerbit = New System.Windows.Forms.TextBox()
        Me.rtdeskripsi = New System.Windows.Forms.RichTextBox()
        Me.cbjeniskoleksi = New System.Windows.Forms.ComboBox()
        Me.txtnamakoleksi = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnpicup = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pbupdate = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbupdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnupdate
        '
        Me.btnupdate.AutoSize = True
        Me.btnupdate.Location = New System.Drawing.Point(635, 514)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(99, 25)
        Me.btnupdate.TabIndex = 45
        Me.btnupdate.Text = "Update Koleksi"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'ChkBudaya
        '
        Me.ChkBudaya.AutoSize = True
        Me.ChkBudaya.Location = New System.Drawing.Point(103, 48)
        Me.ChkBudaya.Name = "ChkBudaya"
        Me.ChkBudaya.Size = New System.Drawing.Size(65, 19)
        Me.ChkBudaya.TabIndex = 3
        Me.ChkBudaya.Text = "Budaya"
        Me.ChkBudaya.UseVisualStyleBackColor = True
        '
        'ChkTeknologi
        '
        Me.ChkTeknologi.AutoSize = True
        Me.ChkTeknologi.Location = New System.Drawing.Point(103, 23)
        Me.ChkTeknologi.Name = "ChkTeknologi"
        Me.ChkTeknologi.Size = New System.Drawing.Size(77, 19)
        Me.ChkTeknologi.TabIndex = 2
        Me.ChkTeknologi.Text = "Teknologi"
        Me.ChkTeknologi.UseVisualStyleBackColor = True
        '
        'ChkSosial
        '
        Me.ChkSosial.AutoSize = True
        Me.ChkSosial.Location = New System.Drawing.Point(10, 48)
        Me.ChkSosial.Name = "ChkSosial"
        Me.ChkSosial.Size = New System.Drawing.Size(56, 19)
        Me.ChkSosial.TabIndex = 1
        Me.ChkSosial.Text = "Sosial"
        Me.ChkSosial.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkBudaya)
        Me.GroupBox2.Controls.Add(Me.ChkTeknologi)
        Me.GroupBox2.Controls.Add(Me.ChkSosial)
        Me.GroupBox2.Controls.Add(Me.ChkSains)
        Me.GroupBox2.Location = New System.Drawing.Point(310, 444)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 95)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'ChkSains
        '
        Me.ChkSains.AutoSize = True
        Me.ChkSains.Location = New System.Drawing.Point(10, 23)
        Me.ChkSains.Name = "ChkSains"
        Me.ChkSains.Size = New System.Drawing.Size(53, 19)
        Me.ChkSains.TabIndex = 0
        Me.ChkSains.Text = "Sains"
        Me.ChkSains.UseVisualStyleBackColor = True
        '
        'rbinggris
        '
        Me.rbinggris.AutoSize = True
        Me.rbinggris.Location = New System.Drawing.Point(6, 47)
        Me.rbinggris.Name = "rbinggris"
        Me.rbinggris.Size = New System.Drawing.Size(63, 19)
        Me.rbinggris.TabIndex = 1
        Me.rbinggris.TabStop = True
        Me.rbinggris.Text = "English"
        Me.rbinggris.UseVisualStyleBackColor = True
        '
        'rbbahasa
        '
        Me.rbbahasa.AutoSize = True
        Me.rbbahasa.Location = New System.Drawing.Point(6, 22)
        Me.rbbahasa.Name = "rbbahasa"
        Me.rbbahasa.Size = New System.Drawing.Size(116, 19)
        Me.rbbahasa.TabIndex = 0
        Me.rbbahasa.TabStop = True
        Me.rbbahasa.Text = "Bahasa Indonesia"
        Me.rbbahasa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbinggris)
        Me.GroupBox1.Controls.Add(Me.rbbahasa)
        Me.GroupBox1.Location = New System.Drawing.Point(310, 350)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 83)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(310, 283)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(234, 23)
        Me.DateTimePicker1.TabIndex = 42
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(310, 316)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(234, 23)
        Me.txtstock.TabIndex = 41
        '
        'txttahun
        '
        Me.txttahun.Location = New System.Drawing.Point(310, 208)
        Me.txttahun.Name = "txttahun"
        Me.txttahun.Size = New System.Drawing.Size(234, 23)
        Me.txttahun.TabIndex = 40
        '
        'txtlokasi
        '
        Me.txtlokasi.Location = New System.Drawing.Point(310, 245)
        Me.txtlokasi.Name = "txtlokasi"
        Me.txtlokasi.Size = New System.Drawing.Size(234, 23)
        Me.txtlokasi.TabIndex = 39
        '
        'txtpenerbit
        '
        Me.txtpenerbit.Location = New System.Drawing.Point(310, 167)
        Me.txtpenerbit.Name = "txtpenerbit"
        Me.txtpenerbit.Size = New System.Drawing.Size(234, 23)
        Me.txtpenerbit.TabIndex = 38
        '
        'rtdeskripsi
        '
        Me.rtdeskripsi.Location = New System.Drawing.Point(310, 94)
        Me.rtdeskripsi.Name = "rtdeskripsi"
        Me.rtdeskripsi.Size = New System.Drawing.Size(234, 65)
        Me.rtdeskripsi.TabIndex = 37
        Me.rtdeskripsi.Text = ""
        '
        'cbjeniskoleksi
        '
        Me.cbjeniskoleksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjeniskoleksi.FormattingEnabled = True
        Me.cbjeniskoleksi.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran ", "Majalah", "Publikasi", "Penelitian", "Komik", "Kitab"})
        Me.cbjeniskoleksi.Location = New System.Drawing.Point(310, 60)
        Me.cbjeniskoleksi.Name = "cbjeniskoleksi"
        Me.cbjeniskoleksi.Size = New System.Drawing.Size(234, 23)
        Me.cbjeniskoleksi.TabIndex = 36
        '
        'txtnamakoleksi
        '
        Me.txtnamakoleksi.Location = New System.Drawing.Point(310, 18)
        Me.txtnamakoleksi.Name = "txtnamakoleksi"
        Me.txtnamakoleksi.Size = New System.Drawing.Size(234, 23)
        Me.txtnamakoleksi.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(157, 444)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Kategori"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(157, 350)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Bahasa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(157, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Stock "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(157, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 15)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Tanggal Masuk Koleksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(157, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Lokasi Rak"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Tahun Terbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Penerbit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Deskripsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Jenis Koleksi "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nama Koleksi"
        '
        'btnpicup
        '
        Me.btnpicup.AutoSize = True
        Me.btnpicup.Location = New System.Drawing.Point(15, 165)
        Me.btnpicup.Name = "btnpicup"
        Me.btnpicup.Size = New System.Drawing.Size(104, 25)
        Me.btnpicup.TabIndex = 24
        Me.btnpicup.Text = "Update Gambar"
        Me.btnpicup.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pbupdate
        '
        Me.pbupdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbupdate.Location = New System.Drawing.Point(12, 12)
        Me.pbupdate.Name = "pbupdate"
        Me.pbupdate.Size = New System.Drawing.Size(107, 147)
        Me.pbupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbupdate.TabIndex = 23
        Me.pbupdate.TabStop = False
        '
        'updatekoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 561)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.txttahun)
        Me.Controls.Add(Me.txtlokasi)
        Me.Controls.Add(Me.txtpenerbit)
        Me.Controls.Add(Me.rtdeskripsi)
        Me.Controls.Add(Me.cbjeniskoleksi)
        Me.Controls.Add(Me.txtnamakoleksi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnpicup)
        Me.Controls.Add(Me.pbupdate)
        Me.MaximizeBox = False
        Me.Name = "updatekoleksi"
        Me.Text = "Update Koleksi"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbupdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnupdate As Button
    Friend WithEvents ChkBudaya As CheckBox
    Friend WithEvents ChkTeknologi As CheckBox
    Friend WithEvents ChkSosial As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChkSains As CheckBox
    Friend WithEvents rbinggris As RadioButton
    Friend WithEvents rbbahasa As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txttahun As TextBox
    Friend WithEvents txtlokasi As TextBox
    Friend WithEvents txtpenerbit As TextBox
    Friend WithEvents rtdeskripsi As RichTextBox
    Friend WithEvents cbjeniskoleksi As ComboBox
    Friend WithEvents txtnamakoleksi As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnpicup As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pbupdate As PictureBox
End Class
