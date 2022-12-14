Public Class register
    Private Sub butreg_Click(sender As Object, e As EventArgs) Handles butreg.Click

        login.olog.GSusername = tbuname.Text
        login.olog.GSpassword = tbpass.Text

        If tbuname.Text.Length > 0 And tbpass.Text.Length > 0 Then
            login.olog.AddUsersDatabase(login.olog.GSusername, login.olog.GSpassword)
            Me.Close()
        Else
            MsgBox("Please enter the correct info.", MsgBoxStyle.Critical, "Failure")
        End If


    End Sub

    Private Sub lbllog_Click(sender As Object, e As EventArgs) Handles lbllog.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub register_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tbuname.Select()
        tbuname.Text = ""
        tbpass.Text = ""

    End Sub

    Private Sub tbpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbpass.KeyPress
        tbpass.PasswordChar = "*"c

    End Sub
End Class