Public Class DisplayKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(Perpustakaan.functions.GSFoto) Then
            PictureBox1.Load(Perpustakaan.functions.GSFoto)
        End If

        lblnamakoleksi.Text = Perpustakaan.functions.GSNamaKoleksi
        lbljeniskoleksi.Text = Perpustakaan.functions.GSKoleksi
        lbldeskripsi.Text = Perpustakaan.functions.GSDeskripsi
        lblpenerbit.Text = Perpustakaan.functions.GSPenerbit
        lbltahun.Text = Perpustakaan.functions.GSTahunTerbit
        lbllokasi.Text = Perpustakaan.functions.GSLokasiRak
        lbltanggal.Text = Perpustakaan.functions.GSTanggalMasuk
        lblstok.Text = Perpustakaan.functions.GSstock
        lblbahasa.Text = Perpustakaan.functions.GSBahasa
        lbkategori.Items.Clear()

        For Each list In Perpustakaan.functions.GSKategori
            lbkategori.Items.Add(list)
        Next

        Perpustakaan.functions.GSKategori.Clear()

    End Sub
    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class