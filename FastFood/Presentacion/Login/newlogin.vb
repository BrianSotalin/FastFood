Public Class newlogin
    Dim contador As Integer
    Private Sub newlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblcargando.Visible = False
        Label1.Visible = False
        ProgressBar1.Visible = False
    End Sub

    Private Sub btning_Click(sender As Object, e As EventArgs) Handles btning.Click
        btning.Visible = False
        Timer1.Start()
        ProgressBar1.Visible = True
        lblcargando.Visible = True
        Label1.Visible = True



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If contador < 100 Then
            ProgressBar1.Value = contador
            contador = contador + 1
            Label1.Text = ProgressBar1.Value & ("%")
        Else
            Timer1.Enabled = False
            Me.Hide()
            menuprincipal.Show()
        End If
    End Sub

    Private Sub btnqu_Click(sender As Object, e As EventArgs) Handles btnqu.Click
        infoapp.ShowDialog()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        End
    End Sub
End Class