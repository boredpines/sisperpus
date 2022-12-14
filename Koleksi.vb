Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Koleksi

    Private koleksiDataTable As New ArrayList()
    Public Shared dbconn As New MySqlConnection
    Public Shared sqlcommand As New MySqlCommand
    Public Shared sqlread As MySqlDataReader
    Private sqlquery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    Public Function removeKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function convertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append(" | ")
        Next

        ' Convert to string
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function convertStringToKoleksi(Value As String)
        Dim arr() As String = Value.Split(" | ")

        ' Convert to list
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable
        dbconn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        dbconn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi AS 'ID',
                                  nama_koleksi AS 'Nama Koleksi' ,
                                  jenis_koleksi AS 'Jenis Koleksi' ,
                                  penerbit AS 'Penerbit' ,
                                  tahun_terbit AS 'Tahun Terbit' ,
                                  tanggal_masuk_koleksi AS 'Tanggal Masuk' ,
                                  lokasi AS 'Lokasi Rak',
                                  stok AS 'Stock'
                                  FROM koleksi"
        sqlRead = sqlCommand.ExecuteReader
        result.Load(sqlread)
        dbconn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(nama_koleksi As String,
                                       jenis_koleksi As String,
                                       deskripsi_koleksi As String,
                                       penerbit_koleksi As String,
                                       tahun_terbit As String,
                                       lokasi_rak As String,
                                       tanggal_masuk As Date,
                                       stock_koleksi As String,
                                       bahasa_koleksi As String,
                                       kategori_koleksi As String,
                                       dir_gambar As String)

        dbconn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlquery = "INSERT INTO koleksi VALUES('','" _
                & nama_koleksi & "', '" _
                & dir_gambar & "', '" _
                & deskripsi_koleksi & "', '" _
                & penerbit_koleksi & "', '" _
                & jenis_koleksi & "', '" _
                & tahun_terbit & "', '" _
                & lokasi_rak & "', '" _
                & tanggal_masuk.ToString("yyyy/MM/dd") & "', '" _
                & stock_koleksi & "', '" _
                & bahasa_koleksi & "', '" _
                & kategori_koleksi & "')"

            sqlcommand = New MySqlCommand(sqlquery, dbconn)
            sqlread = sqlcommand.ExecuteReader

            dbconn.Close()

            sqlread.Close()
            dbconn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbconn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbconn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        dbconn.Open()

        sqlcommand.Connection = dbconn
        sqlcommand.CommandText = "SELECT id_koleksi,
                                  nama_koleksi,
                                  dir_gambar,
                                  deskripsi,
                                  penerbit,
                                  jenis_koleksi,
                                  tahun_terbit,
                                  lokasi,
                                  DATE_FORMAT(tanggal_masuk_koleksi, '%Y/%m/%d'),
                                  stok,
                                  bahasa,
                                  kategori
                                  FROM koleksi
                                  WHERE id_koleksi='" & ID & "'"

        sqlread = sqlcommand.ExecuteReader


        While sqlread.Read()
            result.Add(sqlread.GetString(0).ToString())
            result.Add(sqlread.GetString(1).ToString())
            result.Add(sqlread.GetString(2).ToString())
            result.Add(sqlread.GetString(3).ToString())
            result.Add(sqlread.GetString(4).ToString())
            result.Add(sqlread.GetString(5).ToString())
            result.Add(sqlread.GetString(6).ToString())
            result.Add(sqlread.GetString(7).ToString())
            result.Add(sqlread.GetString(8).ToString())
            result.Add(sqlread.GetString(9).ToString())
            result.Add(sqlread.GetString(10).ToString())
            result.Add(sqlread.GetString(11).ToString())
        End While

        sqlread.Close()
        dbconn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                       nama_koleksi As String,
                                       jenis_koleksi As String,
                                       deskripsi_koleksi As String,
                                       penerbit_koleksi As String,
                                       tahun_terbit As Integer,
                                       lokasi_rak As String,
                                       tanggal_masuk As String,
                                       stock_koleksi As String,
                                       bahasa_koleksi As String,
                                       kategori_koleksi As String,
                                       dir_gambar As String)

        tahun_terbit = tahun_terbit.ToString()
        dbconn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlquery = "UPDATE koleksi SET " &
                       "nama_koleksi='" & nama_koleksi & "', " &
                       "dir_gambar='" & dir_gambar & "', " &
                       "deskripsi='" & deskripsi_koleksi & "', " &
                       "penerbit='" & penerbit_koleksi & "', " &
                       "jenis_koleksi='" & jenis_koleksi & "', " &
                       "tahun_terbit='" & tahun_terbit & "', " &
                       "lokasi='" & lokasi_rak & "', " &
                       "tanggal_masuk_koleksi='" & tanggal_masuk & "', " &
                       "stok='" & stock_koleksi & "', " &
                       "bahasa='" & bahasa_koleksi & "', " &
                       "kategori='" & kategori_koleksi & "'" &
                       "WHERE id_koleksi ='" & ID & "'"


            sqlcommand = New MySqlCommand(sqlquery, dbconn)
            sqlread = sqlcommand.ExecuteReader

            dbconn.Close()
            sqlread.Close()
            dbconn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbconn.Dispose()
        End Try
    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbconn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        dbconn.Open()

        Try
            sqlcommand.Connection = dbconn
            sqlquery = "DELETE FROM koleksi WHERE id_koleksi = '" & ID & "'"

            Debug.WriteLine(sqlquery)

            sqlcommand = New MySqlCommand(sqlquery, dbconn)
            sqlread = sqlcommand.ExecuteReader

            dbconn.Close()

            sqlread.Close()
            dbconn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbconn.Dispose()
        End Try

    End Function


End Class
