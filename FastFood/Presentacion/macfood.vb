Public Class MacFood
    ' bloque de precios
    Dim cordonbleu As Double = 4.99
    Dim friesbacon As Double = 3.99
    Dim baconburguer As Double = 6.99
    Dim nuggets As Double = 3.5
    Dim ravioli As Double = 4.5
    Dim hotdog As Double = 5.99

    'bloque stock
    Dim stockcb As Double = 20
    Dim stockfb As Double = 18
    Dim stockbb As Double = 20
    Dim stockng As Double = 12
    Dim stockrv As Double = 16
    Dim stockhd As Double = 10

    Dim caja As Double = 0
    Dim iva As Double = 0
    Dim subtotal As Double = 0
    Dim total As Double = 0

    Private Sub cargarpr()
        'creamos el procdimiento para cargar el precio y el precio en caja  de los productos
        lblcb.Text = cordonbleu.ToString("C")
        lblfriesb.Text = friesbacon.ToString("C")
        lblbb.Text = baconburguer.ToString("C")
        lblnugets.Text = nuggets.ToString("C")
        lblrv.Text = ravioli.ToString("C")
        lblhotdog.Text = hotdog.ToString("C")

        lblcj.Text = caja.ToString("C")
        lbliva.Text = iva.ToString("C")
        lblsb.Text = subtotal.ToString("C")
        lbltt.Text = total.ToString("C")

    End Sub
    Private Sub cargarstock()
        lbcb.Text = stockcb
        lbfb.Text = stockfb
        lbb.Text = stockbb
        lbng.Text = stockng
        lbrv.Text = stockrv
        lbhd.Text = stockhd

    End Sub

    Private Sub MacFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarpr()
        cargarstock()
    End Sub
    Private Function bleu()
        'stock
        stockcb = stockcb - 1
        If stockcb <= 0 Then
            Producto1.Enabled = False
            lbcb.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            lbcb.Text = stockcb
        End If
        'subtotal
        subtotal = subtotal + cordonbleu
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + cordonbleu
        lblcj.Text = caja.ToString("C")

        Return 0

    End Function
    Private Function papasbacon()
        'stock
        stockfb = stockfb - 1
        If stockfb <= 0 Then
            Producto3.Enabled = False
            lbfb.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            lbfb.Text = stockfb
        End If
        'subtotal
        subtotal = subtotal + friesbacon
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + friesbacon
        lblcj.Text = caja.ToString("C")

        Return 0
    End Function
    Private Function burguertocino()
        'stock
        stockbb = stockbb - 1
        If stockbb <= 0 Then
            Producto5.Enabled = False
            lbb.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            lbb.Text = stockbb
        End If
        'subtotal
        subtotal = subtotal + baconburguer
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + baconburguer
        lblcj.Text = caja.ToString("C")

        Return 0
    End Function
    Private Function nuggpollo()
        'stock
        stockng = stockng - 1
        If stockng <= 0 Then
            Producto2.Enabled = False
            lbng.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            lbng.Text = stockng
        End If
        'subtotal
        subtotal = subtotal + nuggets
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + nuggets
        lblcj.Text = caja.ToString("C")

        Return 0
    End Function
    Private Function pastaravioli()
        'stock
        stockrv = stockrv - 1
        If stockrv <= 0 Then
            Producto4.Enabled = False
            lbrv.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            lbrv.Text = stockrv
        End If
        'subtotal
        subtotal = subtotal + ravioli
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + ravioli
        lblcj.Text = caja.ToString("C")

        Return 0
    End Function
    Private Function perritohot()
        'stock
        stockhd = stockhd - 1
        If stockhd <= 0 Then
            Producto6.Enabled = False
            lbhd.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            lbhd.Text = stockhd
        End If
        'subtotal
        subtotal = subtotal + hotdog
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + hotdog
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
        bleu()
    End Sub

    Private Sub Producto5_Click(sender As Object, e As EventArgs) Handles Producto5.Click
        burguertocino()
    End Sub

    Private Sub Producto3_Click(sender As Object, e As EventArgs) Handles Producto3.Click
        papasbacon()
    End Sub

    Private Sub Producto2_Click(sender As Object, e As EventArgs) Handles Producto2.Click
        nuggpollo()
    End Sub

    Private Sub Producto4_Click(sender As Object, e As EventArgs) Handles Producto4.Click
        pastaravioli()
    End Sub

    Private Sub Producto6_Click(sender As Object, e As EventArgs) Handles Producto6.Click
        perritohot()
    End Sub


End Class
