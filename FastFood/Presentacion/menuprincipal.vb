Public Class menuprincipal
    Dim acumulador As Integer = 51
    'Metodo para abrir formulario secundario
    Private Sub AbrirformEnPanel(Of miform As {Form, New})()
        Dim formulario As Form
        'estoy  busando el formulario dentro del conjunto de formularios
        formulario = panlcont.Controls.OfType(Of miform)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New miform()
            formulario.TopLevel = False
            'cambiamos los stilos del formulario
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = Dock.Fill
            panlcont.Controls.Add(formulario)
            panlcont.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub
    Private Sub tiempo()
        acumulador += 50
        ac.Text = acumulador
        If acumulador >= 50 Then
            panelhamburguer.Visible = True
            panelpasta.Visible = False
            panelpizza.Visible = False
        End If
        If acumulador >= 250 Then
            panelhamburguer.Visible = False
            panelpasta.Visible = True
            panelpizza.Visible = False
        End If
        If acumulador >= 350 Then
            panelhamburguer.Visible = False
            panelpasta.Visible = False
            panelpizza.Visible = True
            acumulador = 100
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        End
    End Sub
    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If panlfood.Width = 62 Then
            panlfood.Visible = False
            panlfood.Width = 186
            panela.ShowSync(panlfood)
            logoaa.ShowSync(logo)
        Else
            logo.Visible = False
            panlfood.Visible = False
            panlfood.Width = 62
            panela2.ShowSync(panlfood)
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiempo()
    End Sub

    Private Sub menuprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ac.Text = acumulador
    End Sub

    Private Sub btncomida_Click(sender As Object, e As EventArgs) Handles btncomida.Click
        AbrirformEnPanel(Of MacFood)()
    End Sub

    Private Sub btnbebida_Click(sender As Object, e As EventArgs) Handles btnbebida.Click
        AbrirformEnPanel(Of formbebida)()
    End Sub

    Private Sub btncombo_Click(sender As Object, e As EventArgs) Handles btncombo.Click
        AbrirformEnPanel(Of slidermenu)()
    End Sub

    Private Sub btnpostre_Click(sender As Object, e As EventArgs) Handles btnpostre.Click
        AbrirformEnPanel(Of formpostr)()
    End Sub

    Private Sub btnusers_Click(sender As Object, e As EventArgs) Handles btnusers.Click
        AbrirformEnPanel(Of frmus)()
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        AbrirformEnPanel(Of formhome)()
    End Sub
End Class