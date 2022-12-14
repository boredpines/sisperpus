Public Class updatekoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(Perpustakaan.functions.GSFoto) Then
            pbupdate.Load(Perpustakaan.functions.GSFoto)
        End If

        txtnamakoleksi.Text = Perpustakaan.functions.GSNamaKoleksi
        cbjeniskoleksi.SelectedItem = Perpustakaan.functions.GSKoleksi
        rtdeskripsi.Text = Perpustakaan.functions.GSDeskripsi
        txtpenerbit.Text = Perpustakaan.functions.GSPenerbit
        txttahun.Text = Perpustakaan.functions.GSTahunTerbit
        txtlokasi.Text = Perpustakaan.functions.GSLokasiRak
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker1.Text = Perpustakaan.functions.GSTanggalMasuk
        txtstock.Text = Perpustakaan.functions.GSstock

        If Perpustakaan.functions.GSBahasa() = "Bahasa Indonesia" Then
            rbbahasa.Checked = True
        Else
            rbinggris.Checked = True
        End If

        For Each info_tambah In Perpustakaan.functions.GSKategori
            If info_tambah = "Sains" Then
                ChkSains.Checked = True
            ElseIf info_tambah = "Sosial" Then
                ChkSosial.Checked = True
            ElseIf info_tambah = "Teknologi" Then
                ChkTeknologi.Checked = True
            ElseIf info_tambah = "Budaya" Then
                ChkBudaya.Checked = True
            End If
        Next

        Perpustakaan.functions.resetKategori()

    End Sub
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Perpustakaan.functions.GSNamaKoleksi = txtnamakoleksi.Text.ToString()
        Perpustakaan.functions.GSKoleksi = cbjeniskoleksi.SelectedItem.ToString()
        Perpustakaan.functions.GSDeskripsi = rtdeskripsi.Text.ToString()
        Perpustakaan.functions.GSPenerbit = txtpenerbit.Text.ToString()
        Perpustakaan.functions.GSLokasiRak = txtlokasi.Text.ToString()
        Perpustakaan.functions.GSstock = txtstock.Text.ToString()
        Perpustakaan.functions.GSTahunTerbit = txttahun.Text.ToString()
        Perpustakaan.functions.GSTanggalMasuk = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        Perpustakaan.functions.resetKategori()

        If rbinggris.Checked Then
            Perpustakaan.functions.GSBahasa = rbinggris.Text
        ElseIf rbbahasa.Checked Then
            Perpustakaan.functions.GSBahasa = rbbahasa.Text
        End If

        If ChkBudaya.Checked() Then
            Perpustakaan.functions.addKategori(ChkBudaya.Text)
        End If

        If ChkSains.Checked() Then
            Perpustakaan.functions.addKategori(ChkSains.Text)
        End If

        If ChkSosial.Checked() Then
            Perpustakaan.functions.addKategori(ChkSosial.Text)
        End If

        If ChkTeknologi.Checked() Then
            Perpustakaan.functions.addKategori(ChkTeknologi.Text)
        End If

        Dim convertedKoleksi = Perpustakaan.koleksi.convertKoleksiToString(Perpustakaan.functions.GSKategori)
        Perpustakaan.koleksi.UpdateDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksiDB,
                                                            Perpustakaan.functions.GSNamaKoleksi,
                                                            Perpustakaan.functions.GSKoleksi,
                                                            Perpustakaan.functions.GSDeskripsi,
                                                            Perpustakaan.functions.GSPenerbit,
                                                            Perpustakaan.functions.GSTahunTerbit,
                                                            Perpustakaan.functions.GSLokasiRak,
                                                            Perpustakaan.functions.GSTanggalMasuk,
                                                            Perpustakaan.functions.GSstock,
                                                            Perpustakaan.functions.GSBahasa,
                                                            convertedKoleksi,
                                                            Perpustakaan.functions.GSFoto)
        Perpustakaan.functions.GSlistKol.Clear()
        Dim updateddisplay = New DisplayKoleksi
        updateddisplay.Show()
        Me.Close()

    End Sub

    Private Sub btnpicup_Click(sender As Object, e As EventArgs) Handles btnpicup.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|Image|*.bmp|All Format|*.*"
        OpenFileDialog1.ShowDialog()
        Dim picKoleksiDir As String = OpenFileDialog1.FileName
        If OpenFileDialog1.FileName.Length > 0 Then
            pbupdate.Load(picKoleksiDir)
        End If
        Perpustakaan.functions.GSFoto = picKoleksiDir
        Perpustakaan.functions.GSFoto = Perpustakaan.functions.GSFoto.Replace("\", "/")

    End Sub
End Class