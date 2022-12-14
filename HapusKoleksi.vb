Public Class HapusKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblhapus.Text = Perpustakaan.selectedTableKoleksiNama
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnconhapus.Click
        'Dim indexitem = 0
        'Perpustakaan.ListBoxKoleksiBuku.Items.RemoveAt(Perpustakaan.ListBoxKoleksiBuku.SelectedIndex)
        'MessageBox.Show("Data berhasil dihapus!")

        'For Each item In Perpustakaan.koleksi.getKoleksiDataTable()
        '    If item(0) Is Perpustakaan.ListBoxKoleksiBuku.SelectedItem() Then
        '        indexitem = Perpustakaan.koleksi.getKoleksiDataTable().IndexOf(item)

        '    End If
        'Next

        'Perpustakaan.koleksi.removeKoleksiDataTable(indexitem)
        Perpustakaan.koleksi.DeleteDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksiDB)



        Me.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class