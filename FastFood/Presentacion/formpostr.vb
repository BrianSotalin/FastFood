Public Class formpostr
    ' bloque de precios
    Dim minicake As Double = 2.99
    Dim cupcake As Double = 1.99
    Dim chocake As Double = 8.99
    Dim icecream As Double = 10.5


    'bloque stock
    Dim stockcake As Double = 10
    Dim stockcup As Double = 18
    Dim stockchc As Double = 16
    Dim stockicr As Double = 9



    Dim caja As Double = 0
    Dim iva As Double = 0
    Dim subtotal As Double = 0
    Dim total As Double = 0

    Private Sub cargarpr()
        'creamos el procdimiento para cargar el precio y el precio en caja  de los productos
        lbcake.Text = minicake.ToString("C")
        lbchc.Text = chocake.ToString("C")
        lbcup.Text = cupcake.ToString("C")
        lbicr.Text = icecream.ToString("C")


        lblcj.Text = caja.ToString("C")
        lbliva.Text = iva.ToString("C")
        lblsb.Text = subtotal.ToString("C")
        lbltt.Text = total.ToString("C")

    End Sub
    Private Sub cargarstock()
        stckcake.Text = stockcake
        stckchc.Text = stockchc
        stckicr.Text = stockicr
        stckcup.Text = stockcup

    End Sub

    Private Sub MacFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarpr()
        cargarstock()
    End Sub
    Private Function mincake()
        'stock
        stockcake = stockcake - 1
        If stockcake <= 0 Then
            Producto1.Enabled = False
            stckcake.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            stckcake.Text = stockcake
        End If
        'subtotal
        subtotal = subtotal + minicake
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + minicake
        lblcj.Text = caja.ToString("C")

        Return 0

    End Function

    Private Function chococake()
        'stock
        stockchc = stockchc - 1
        If stockchc <= 0 Then
            Producto3.Enabled = False
            stckchc.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            stckchc.Text = stockchc
        End If
        'subtotal
        subtotal = subtotal + chocake
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + chocake
        lblcj.Text = caja.ToString("C")

        Return 0
    End Function
    Private Function helado()
        'stock
        stockicr = stockicr - 1
        If stockicr <= 0 Then
            Producto2.Enabled = False
            stckicr.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            stckicr.Text = stockicr
        End If
        'subtotal
        subtotal = subtotal + icecream
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + icecream
        lblcj.Text = caja.ToString("C")

        Return 0
    End Function
    Private Function cupcup()
        'stock
        stockcup = stockcup - 1
        If stockcup <= 0 Then
            Producto4.Enabled = False
            stckcup.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            stckcup.Text = stockcup
        End If
        'subtotal
        subtotal = subtotal + cupcake
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + cupcake
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
        mincake()
    End Sub



    Private Sub Producto3_Click(sender As Object, e As EventArgs) Handles Producto3.Click
        chococake()
    End Sub

    Private Sub Producto2_Click(sender As Object, e As EventArgs) Handles Producto2.Click
        helado()
    End Sub

    Private Sub Producto4_Click(sender As Object, e As EventArgs) Handles Producto4.Click
        cupcup()
    End Sub

End Class