Public Class slidermenu
    Dim slider As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        slider = slider + 2
        If slider = 2 Then
            panelhamburguer.Visible = True
            panelpasta.Visible = False
            panelpizza.Visible = False
        End If
        If slider = 4 Then
            panelhamburguer.Visible = False
            panelpasta.Visible = True
            panelpizza.Visible = False
        End If
        If slider = 6 Then
            panelhamburguer.Visible = False
            panelpasta.Visible = False
            panelpizza.Visible = True
            slider = 0
        End If
    End Sub

    Private Sub slidermenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 4000
    End Sub
End Class