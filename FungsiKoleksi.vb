Public Class FungsiKoleksi

    Private namakoleksi As String
    Private combokoleksi As String
    Private rtdeskripsi As String
    Private penerbit As String
    Private tahunterbit As String
    Private lokasirak As String
    Private tanggalmasuk As String
    Private stock As String
    Private bahasa As String
    Private foto As String
    Private kategori As New List(Of String)
    Private list_koleksi As New List(Of String)


    Public Property GSNamaKoleksi() As String
        Get
            Return namakoleksi
        End Get
        Set(value As String)
            namakoleksi = value
        End Set
    End Property

    Public Property GSKoleksi() As String
        Get
            Return combokoleksi
        End Get
        Set(value As String)
            combokoleksi = value
        End Set
    End Property

    Public Property GSDeskripsi() As String
        Get
            Return rtdeskripsi
        End Get
        Set(value As String)
            rtdeskripsi = value
        End Set
    End Property

    Public Property GSPenerbit() As String
        Get
            Return penerbit
        End Get
        Set(value As String)
            penerbit = value
        End Set
    End Property

    Public Property GSTahunTerbit() As String
        Get
            Return tahunterbit
        End Get
        Set(value As String)
            tahunterbit = value
        End Set
    End Property
    Public Property GSLokasiRak() As String
        Get
            Return lokasirak
        End Get
        Set(value As String)
            lokasirak = value
        End Set
    End Property
    Public Property GSTanggalMasuk() As String
        Get
            Return tanggalmasuk
        End Get
        Set(value As String)
            tanggalmasuk = value
        End Set
    End Property
    Public Property GSstock() As String
        Get
            Return stock
        End Get
        Set(value As String)
            stock = value
        End Set
    End Property
    Public Property GSBahasa() As String
        Get
            Return bahasa
        End Get
        Set(value As String)
            bahasa = value
        End Set
    End Property

    Public Property GSFoto() As String
        Get
            Return foto
        End Get
        Set(value As String)
            foto = value
        End Set
    End Property
    Public Property GSlistKol() As List(Of String)
        Get
            Return list_koleksi
        End Get
        Set(value As List(Of String))
            list_koleksi = value
        End Set
    End Property

    Public ReadOnly Property GSKategori() As List(Of String)
        Get
            Return kategori
        End Get
    End Property

    Public Function addKategori(value As String)
        kategori.Add(value)
        Return ""
    End Function

    Public Function resetKategori()
        kategori.Clear()
        Return ""
    End Function

End Class

