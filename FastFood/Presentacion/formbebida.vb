Public Class formbebida

    ' bloque de precios
    Dim jugonatural As Double = 2.99
    Dim gaseosa As Double = 1.99
    Dim vinotinto As Double = 8.99
    Dim vinoblanco As Double = 10.5


    'bloque stock
    Dim stockjg As Double = 12
    Dim stockgs As Double = 18
    Dim stockvt As Double = 16
    Dim stockvb As Double = 14



    Dim caja As Double = 0
        Dim iva As Double = 0
        Dim subtotal As Double = 0
        Dim total As Double = 0

        Private Sub cargarpr()
        'creamos el procdimiento para cargar el precio y el precio en caja  de los productos
        lbjgn.Text = jugonatural.ToString("C")
        lbgs.Text = gaseosa.ToString("C")
        lbvnt.Text = vinotinto.ToString("C")
        lbvnbl.Text = vinoblanco.ToString("C")


        lblcj.Text = caja.ToString("C")
        lbliva.Text = iva.ToString("C")
        lblsb.Text = subtotal.ToString("C")
        lbltt.Text = total.ToString("C")

    End Sub
    Private Sub cargarstock()
        stckjg.Text = stockjg
        stckgs.Text = stockgs
        stckvb.Text = stockvb
        stckvt.Text = stockvt

    End Sub

    Private Sub MacFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarpr()
        cargarstock()
    End Sub
    Private Function naturejuice()
        'stock
        stockjg = stockjg - 1
        If stockjg <= 0 Then
            Producto1.Enabled = False
            stckjg.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            stckjg.Text = stockjg
        End If
        'subtotal
        subtotal = subtotal + jugonatural
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + jugonatural
        lblcj.Text = caja.ToString("C")

        Return 0

    End Function

    Private Function cocacola()
        'stock
        stockgs = stockgs - 1
        If stockgs <= 0 Then
            Producto3.Enabled = False
            stckgs.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            stckgs.Text = stockgs
        End If
        'subtotal
        subtotal = subtotal + gaseosa
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + gaseosa
        lblcj.Text = caja.ToString("C")

        Return 0
    End Function
    Private Function vinitoblanco()
        'stock
        stockvb = stockvb - 1
        If stockvb <= 0 Then
            Producto4.Enabled = False
            stckvb.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            stckvb.Text = stockvb
        End If
        'subtotal
        subtotal = subtotal + vinoblanco
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + vinoblanco
        lblcj.Text = caja.ToString("C")

        Return 0
    End Function
    Private Function vinivini()
        'stock
        stockvt = stockvt - 1
        If stockvt <= 0 Then
            Producto3.Enabled = False
            stckvt.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            stckvt.Text = stockvt
        End If
        'subtotal
        subtotal = subtotal + vinotinto
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + vinotinto
        lblcj.Text = caja.ToString("C")

        Return 0
    End Function

    Private Sub fincompra()
        'procedimiento de despedida en compra
        MsgBox(" Gracias por su compra ", vbInformation, "@ MacFood Enterprise | 2021")
    End Sub
    Private Sub cerrar()
        'procedimiento btn cerrar
        Dim salir As String
        salir = MsgBox("¿Estas seguro que desea salir del programa?", vbQuestion + vbYesNo, "@ MacFood Enterprise | 2021")
        If salir = vbYes Then
            Me.Close()
            login.Close()
        End If
    End Sub
    Private Sub neworden()
        subtotal = 0
        iva = 0
        total = 0
        lblsb.Text = subtotal.ToString("C")
        lbliva.Text = iva.ToString("C")
        lbltt.Text = total.ToString("C")
    End Sub

    Private Sub btncobrar_Click(sender As Object, e As EventArgs)
        fincompra()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cerrar()

    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs)
        neworden()
    End Sub



    Private Sub btncobrar_Click_1(sender As Object, e As EventArgs) Handles btncobrar.Click
        fincompra()
    End Sub

    Private Sub btnew_Click_1(sender As Object, e As EventArgs) Handles btnew.Click
        neworden()
    End Sub

    Private Sub Producto1_Click(sender As Object, e As EventArgs) Handles Producto1.Click
        naturejuice()
    End Sub



    Private Sub Producto3_Click(sender As Object, e As EventArgs) Handles Producto3.Click
        cocacola()
    End Sub

    Private Sub Producto2_Click(sender As Object, e As EventArgs) Handles Producto2.Click
        vinitoblanco()
    End Sub

    Private Sub Producto4_Click(sender As Object, e As EventArgs) Handles Producto4.Click
        vinivini()
    End Sub




End Class

