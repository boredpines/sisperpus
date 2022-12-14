Public Class TambahKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Perpustakaan.functions = New FungsiKoleksi
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btntambahkol.Click
        Perpustakaan.functions.GSKategori.Clear()

        If ChkBudaya.Checked() Then
            Perpustakaan.functions.GSKategori.Add("Budaya")
        End If

        If ChkSains.Checked() Then
            Perpustakaan.functions.GSKategori.Add("Sains")
        End If

        If ChkSosial.Checked() Then
            Perpustakaan.functions.GSKategori.Add("Sosial")
        End If

        If ChkTeknologi.Checked() Then
            Perpustakaan.functions.GSKategori.Add("Teknologi")
        End If

        Perpustakaan.functions.GSNamaKoleksi = txtnamakoleksi.Text
        Perpustakaan.functions.GSKoleksi = cbjeniskoleksi.SelectedItem
        Perpustakaan.functions.GSDeskripsi = rtdeskripsi.Text
        Perpustakaan.functions.GSPenerbit = txtpenerbit.Text
        Perpustakaan.functions.GSLokasiRak = txtlokasi.Text
        Perpustakaan.functions.GSstock = txtstock.Text
        Perpustakaan.functions.GSTahunTerbit = txttahun.Text
        Perpustakaan.functions.GSTanggalMasuk = DateTimePicker1.Value.ToString("d MMMM yyyy")

        If validationItemData() IsNot Nothing Then
            MsgBox(validationItemData, MsgBoxStyle.Critical, "Error")
        Else
            Dim convertedKoleksi = Perpustakaan.koleksi.convertKoleksiToString(Perpustakaan.functions.GSKategori)
            Perpustakaan.koleksi.AddDataKoleksiDatabase(Perpustakaan.functions.GSNamaKoleksi,
                                                        Perpustakaan.functions.GSKoleksi,
                                                        Perpustakaan.functions.GSPenerbit,
                                                        Perpustakaan.functions.GSTahunTerbit,
                                                        Perpustakaan.functions.GSDeskripsi,
                                                        Perpustakaan.functions.GSLokasiRak,
                                                        Perpustakaan.functions.GSTanggalMasuk,
                                                        Perpustakaan.functions.GSstock,
                                                        Perpustakaan.functions.GSBahasa,
                                                        convertedKoleksi,
                                                        Perpustakaan.functions.GSFoto)

            Dim infokoleksi = New DisplayKoleksi()
            Me.Close()
            infokoleksi.Show()
            Perpustakaan.functions.GSlistKol.Add(Perpustakaan.functions.GSNamaKoleksi())
        End If

    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.InitialDirectory = "~\Documents"
        OpenFileDialog1.Filter = "Image JPG|*.jpg|Image JPEG|*.jpeg| Image PNG|*.png|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim pickoleksidir = OpenFileDialog1.FileName

        pbtambah.Load(pickoleksidir)
        pbtambah.SizeMode = PictureBoxSizeMode.StretchImage

        Perpustakaan.functions.GSFoto = pickoleksidir.ToString()
        Perpustakaan.functions.GSFoto = Perpustakaan.functions.GSFoto.Replace("\", "/")

    End Sub

    Private Sub rbbahasa_CheckedChanged(sender As Object, e As EventArgs) Handles rbbahasa.CheckedChanged
        Perpustakaan.functions.GSBahasa = rbbahasa.Text
    End Sub

    Private Sub rbinggris_CheckedChanged(sender As Object, e As EventArgs) Handles rbinggris.CheckedChanged
        Perpustakaan.functions.GSBahasa = rbinggris.Text
    End Sub

    Public Function validationItemData()
        Dim errMessage As String

        If Perpustakaan.functions.GSNamaKoleksi.Length = 0 Then
            errMessage = "Harap Masukkan Nama Koleksinya!"
        ElseIf Perpustakaan.functions.GSKoleksi Is Nothing Then
            errMessage = "Harap Tentukan Jenis Koleksinya!"
        ElseIf Perpustakaan.functions.GSFoto Is Nothing Then
            errMessage = "Harap Sertakan Foto Koleksinya!"
        ElseIf Perpustakaan.functions.GSDeskripsi.Length = 0 Then
            errMessage = "Harap Tulis Deskripsi Koleksinya!"
        ElseIf Perpustakaan.functions.GSPenerbit.Length = 0 Then
            errMessage = "Harap Masukkan Penerbit Koleksinya!"
        ElseIf Perpustakaan.functions.GSTahunTerbit.Length = 0 Then
            errMessage = "Harap Masukkan Tahun Terbitnya!"
        ElseIf Perpustakaan.functions.GSLokasiRak.Length = 0 Then
            errMessage = "Harap Masukkan Lokasi Raknya!"
        ElseIf Perpustakaan.functions.GSTanggalMasuk.Length = 0 Then
            errMessage = "Harap Masukkan Tanggal Masuk Koleksinya!"
        ElseIf Perpustakaan.functions.GSstock.Length = 0 Then
            errMessage = "Harap Masukkan Stok Koleksinya!"
        ElseIf Perpustakaan.functions.GSBahasa Is Nothing Then
            errMessage = "Harap Masukkan Bahasa untuk Koleksinya!"
        ElseIf Perpustakaan.functions.GSKategori.Count() = 0 Then
            errMessage = "Harap Masukkan Kategori untuk Koleksinya!"
        End If
        Return errMessage
    End Function

    Private Sub TambahKoleksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class