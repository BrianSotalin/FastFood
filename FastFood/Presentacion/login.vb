Imports System.Data.SqlClient
Public Class login
    Private Sub ingresar()
        If txtname.Text = "Blady" Then
            If txtpssword.Text = "Sota10" Then
                Me.Hide()
                MacFood.Show()
            Else
                MsgBox("Contraseña  incorrecta ", vbCritical, "@ Mac Food Enterprise | 2021")
            End If

        Else
            MsgBox("Usuario incorrecto ", vbCritical, "@ Mac Food Enterprise | 2021")

        End If
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        If conectar() = 0 Then
            circle.Visible = True
            btningresar.Visible = False
            MsgBox("BDD desconectada")
        Else
            circle.Visible = True
            btningresar.Visible = False
            MsgBox("BDD conectada exitosamente")
        End If
        If txtname.Text = "" Or txtpssword.Text = "" Then
            MsgBox("Existen campos vacios", vbExclamation, "@ MacFood Enterprise | 2021")
            circle.Visible = False
            btningresar.Visible = True
        Else
            Try
                conexion.Open()
                adaptador = New SqlDataAdapter("SELECT * FROM users WHERE name_user='" & txtname.Text & "' AND password='" & txtpssword.Text & "'", conexion)
                tabla.Clear()
                adaptador.Fill(tabla)

                If tabla.Rows.Count = 1 Then
                    Dim fila As DataRow = tabla.Rows(0)
                    Name = Trim(fila("name_user").ToString)
                    MsgBox("Datos verificados", vbInformation, "Operacion Completada")
                    txtname.Text = ""
                    txtpssword.Text = ""
                    Me.Hide()
                    menuprincipal.Show()
                Else
                    MsgBox("Nombre de usuario o contraseña incorrecta", vbExclamation, "@ MacFood Enterprise | 2021")
                    txtname.Text = ""
                    txtpssword.Text = ""
                    circle.Visible = False
                    btningresar.Visible = True
                End If
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "ERROR | @ Mac Food Enterprise 2021")
            End Try
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        circle.Visible = False
    End Sub
End Class