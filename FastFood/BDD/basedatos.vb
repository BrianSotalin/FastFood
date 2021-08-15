Imports System.Data.SqlClient

Module basedatos
    Public conexion As New SqlConnection
    Public adaptador As SqlDataAdapter
    Public tabla As New DataTable

    Public name As String
    Public user As String
    Public Tuser As String

    Public Function conectar()
        Try
            'conectando BDD
            'conexion=new sqlconection("cada conexion")
            conexion = New SqlConnection("Data Source= DESKTOP-9JM5DC3\SQLEXPRESS; Initial Catalog = macfoodBDD; Integrated Security = True")
            If conexion.State = 1 Then
                conexion.Open()
            Else
                conexion.Close()
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Return False
        End Try

    End Function
End Module
