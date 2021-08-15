<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.circle = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btningresar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtpssword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl2 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.circle)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btningresar)
        Me.Panel1.Controls.Add(Me.txtpssword)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.BunifuTileButton1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 451)
        Me.Panel1.TabIndex = 0
        '
        'circle
        '
        Me.circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.circle.Location = New System.Drawing.Point(161, 306)
        Me.circle.Name = "circle"
        Me.circle.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.circle.Size = New System.Drawing.Size(64, 64)
        Me.circle.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(237, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Registrese gratis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(24, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Olvido su contraseña?"
        '
        'btningresar
        '
        Me.btningresar.ActiveBorderThickness = 1
        Me.btningresar.ActiveCornerRadius = 20
        Me.btningresar.ActiveFillColor = System.Drawing.Color.Yellow
        Me.btningresar.ActiveForecolor = System.Drawing.Color.Red
        Me.btningresar.ActiveLineColor = System.Drawing.Color.Yellow
        Me.btningresar.BackColor = System.Drawing.Color.Black
        Me.btningresar.BackgroundImage = CType(resources.GetObject("btningresar.BackgroundImage"), System.Drawing.Image)
        Me.btningresar.ButtonText = "INGRESAR"
        Me.btningresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btningresar.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btningresar.IdleBorderThickness = 1
        Me.btningresar.IdleCornerRadius = 20
        Me.btningresar.IdleFillColor = System.Drawing.Color.Red
        Me.btningresar.IdleForecolor = System.Drawing.Color.Yellow
        Me.btningresar.IdleLineColor = System.Drawing.Color.Red
        Me.btningresar.Location = New System.Drawing.Point(105, 316)
        Me.btningresar.Margin = New System.Windows.Forms.Padding(5)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(181, 41)
        Me.btningresar.TabIndex = 3
        Me.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpssword
        '
        Me.txtpssword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpssword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtpssword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtpssword.HintForeColor = System.Drawing.Color.Empty
        Me.txtpssword.HintText = ""
        Me.txtpssword.isPassword = True
        Me.txtpssword.LineFocusedColor = System.Drawing.Color.White
        Me.txtpssword.LineIdleColor = System.Drawing.Color.Gray
        Me.txtpssword.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtpssword.LineThickness = 3
        Me.txtpssword.Location = New System.Drawing.Point(27, 243)
        Me.txtpssword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpssword.Name = "txtpssword"
        Me.txtpssword.Size = New System.Drawing.Size(309, 33)
        Me.txtpssword.TabIndex = 2
        Me.txtpssword.Text = "Contraseña"
        Me.txtpssword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtname
        '
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtname.HintForeColor = System.Drawing.Color.Empty
        Me.txtname.HintText = ""
        Me.txtname.isPassword = False
        Me.txtname.LineFocusedColor = System.Drawing.Color.White
        Me.txtname.LineIdleColor = System.Drawing.Color.Gray
        Me.txtname.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtname.LineThickness = 3
        Me.txtname.Location = New System.Drawing.Point(27, 189)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(309, 33)
        Me.txtname.TabIndex = 1
        Me.txtname.Text = "Usuario"
        Me.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.Black
        Me.BunifuTileButton1.color = System.Drawing.Color.Black
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.Black
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = CType(resources.GetObject("BunifuTileButton1.Image"), System.Drawing.Image)
        Me.BunifuTileButton1.ImagePosition = 20
        Me.BunifuTileButton1.ImageZoom = 50
        Me.BunifuTileButton1.LabelPosition = 41
        Me.BunifuTileButton1.LabelText = "USER"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(121, 31)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(128, 129)
        Me.BunifuTileButton1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FastFood.My.Resources.Resources.MacFood1
        Me.PictureBox1.Location = New System.Drawing.Point(343, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(358, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 20
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.Panel1
        '
        'GunaDragControl2
        '
        Me.GunaDragControl2.TargetControl = Me
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FastFood.My.Resources.Resources.fastfood2
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtpssword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btningresar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl2 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents circle As Guna.UI.WinForms.GunaWinCircleProgressIndicator
End Class
