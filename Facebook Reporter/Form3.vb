Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If TextUser.Text = "MUQPRO" And TextPass.Text = "123123ProVBA" Then
            Me.Hide()
            Main.Show()
        Else
            Beep()
        End If
    End Sub
End Class