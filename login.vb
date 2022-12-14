Imports System.Runtime.CompilerServices

Public Class login
    Public Shared Perpustakaan As Perpustakaan
    Public Shared olog As user

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        olog = New user()
        Perpustakaan = New Perpustakaan()

    End Sub
    Private Sub butlogin_Click(sender As Object, e As EventArgs) Handles butlogin.Click
        olog.GSusername = txtuname.Text
        olog.GSpassword = txtpass.Text

        If olog.GSusername.Length = 0 Or olog.GSpassword.Length = 0 Then
            MsgBox("Please enter your login info", MsgBoxStyle.Critical, "Failed to sign-in")
        Else
            Dim data_user As List(Of String) = olog.CheckAuthDatabase(olog.GSusername, olog.GSpassword)

            If data_user.Count > 0 Then
                Perpustakaan.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect username or password", MsgBoxStyle.Critical, "Failure")
            End If

        End If

    End Sub

    Private Sub txtpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        txtpass.PasswordChar = "*"c
    End Sub

    Private Sub lblreg_Click(sender As Object, e As EventArgs) Handles lblreg.Click
        register.Show()
    End Sub

    Private Sub login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtuname.Select()
        txtuname.Text = ""
        txtpass.Text = ""
    End Sub
End Class