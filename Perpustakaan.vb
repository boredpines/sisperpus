Public Class Perpustakaan

    Public Shared functions As FungsiKoleksi
    Public Shared selected As String
    Public Shared koleksi As Koleksi
    Public selectedTableKoleksi As Integer
    Public selectedTableKoleksiDB As Integer
    Public selectedTableKoleksiNama As String
    Dim selectedRow As DataGridViewRow

    Public Sub updateDataTableArrayList()
        DataGridKoleksiDB.Rows.Clear()
        For Each rowKoleksi In koleksi.getKoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(1),
                                         rowKoleksi(2),
                                         rowKoleksi(3),
                                         rowKoleksi(4),
                                         rowKoleksi(7),
                                         rowKoleksi(9),
                                         rowKoleksi(10),
                                         rowKoleksi(8),
                                         rowKoleksi(9)}
            DataGridKoleksiDB.Rows.Add(dataTable)
        Next
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        functions = New FungsiKoleksi()
        koleksi = New Koleksi()
        reloaddatatable()


    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim add = New TambahKoleksi
        add.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        Dim add = New TambahKoleksi
        add.Show()
    End Sub

    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'For Each kel In functions.GSlistKol
        '    ListBoxKoleksiBuku.Items.Add(kel)
        'Next
        'functions.GSlistKol.Clear()
        'updateDataTableArrayList()
        reloaddatatable()

    End Sub

    Private Sub BtnHapusKoleksi_Click(sender As Object, e As EventArgs) Handles BtnHapusKoleksi.Click
        selected = ListBoxKoleksiBuku.SelectedItem()
        If selected IsNot Nothing Then
            HapusKoleksi.Show()
        Else
            MsgBox("Pilih koleksi yang ingin dihapus", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub reloaddatatable()
        DataGridKoleksiDB.DataSource = koleksi.GetDataKoleksiDatabase()
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
    End Sub

    Private Sub DataGridKoleksiDB_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksiDB.CellClick
        Dim index As Integer = e.RowIndex

        selectedRow = DataGridKoleksiDB.Rows(index)
        selectedTableKoleksiDB = selectedRow.Cells(0).Value

    End Sub
    Public Sub showSelectedDB()
        Dim selectedKoleksi As List(Of String) = koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksiDB)
        functions.GSNamaKoleksi = selectedKoleksi(1)
        functions.GSKoleksi = selectedKoleksi(5)
        functions.GSDeskripsi = selectedKoleksi(3)
        functions.GSPenerbit = selectedKoleksi(4)
        functions.GSTahunTerbit = selectedKoleksi(6)
        functions.GSLokasiRak = selectedKoleksi(7)
        functions.GSTanggalMasuk = selectedKoleksi(8)
        functions.GSstock = selectedKoleksi(9)
        functions.GSBahasa = selectedKoleksi(10)
        Dim dataKoleksi As List(Of String) = koleksi.convertStringToKoleksi(selectedKoleksi(11))

        For Each info_tambah In dataKoleksi
            functions.addKategori(info_tambah)
        Next

        functions.GSFoto = selectedKoleksi(2)

    End Sub

    Private Sub btnupkol_Click(sender As Object, e As EventArgs) Handles btnupkol.Click
        functions.resetKategori()
        Try
            showSelectedDB()
            updatekoleksi.Show()

        Catch ex As Exception
            MsgBox("You Must Min. 1 Collection", MsgBoxStyle.Critical, "Failure")
        End Try
    End Sub

    Private Sub btnrem_Click(sender As Object, e As EventArgs) Handles btnrem.Click
        If selectedRow IsNot Nothing Then
            selectedTableKoleksiNama = selectedRow.Cells(1).Value
            HapusKoleksi.lblhapus.Text = selectedTableKoleksiNama
            Dim delform = New HapusKoleksi()
            delform.Show()
        Else
            MsgBox("You Must Min. 1 Collection", MsgBoxStyle.Critical, "Failure")
        End If
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        functions.resetKategori()
        Try
            showSelectedDB()
            DisplayKoleksi.Show()

        Catch ex As Exception
            MsgBox("You Must Min. 1 Collection", MsgBoxStyle.Critical, "Failure")
        End Try

    End Sub
End Class