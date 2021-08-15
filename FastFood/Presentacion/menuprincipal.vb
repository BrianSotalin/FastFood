Public Class menuprincipal


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        End
    End Sub



    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If panlfood.Width = 62 Then
            panlfood.Visible = False
            panlfood.Width = 225
            panela.ShowSync(panlfood)
            logoaa.ShowSync(logo)
        Else
            logo.Visible = False
            panlfood.Visible = False
            panlfood.Width = 62
            panela2.ShowSync(panlfood)
        End If
    End Sub
End Class