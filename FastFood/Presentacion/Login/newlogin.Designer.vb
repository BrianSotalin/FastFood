<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newlogin))
        Me.btnqu = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblcargando = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btning = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnqu
        '
        Me.btnqu.AnimationHoverSpeed = 0.07!
        Me.btnqu.AnimationSpeed = 0.03!
        Me.btnqu.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnqu.BorderColor = System.Drawing.Color.Black
        Me.btnqu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnqu.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnqu.FocusedColor = System.Drawing.Color.Empty
        Me.btnqu.Font = New System.Drawing.Font("Lucida Calligraphy", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnqu.ForeColor = System.Drawing.Color.White
        Me.btnqu.Image = Nothing
        Me.btnqu.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnqu.Location = New System.Drawing.Point(3, 318)
        Me.btnqu.Name = "btnqu"
        Me.btnqu.OnHoverBaseColor = System.Drawing.Color.Teal
        Me.btnqu.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.btnqu.OnHoverForeColor = System.Drawing.Color.White
        Me.btnqu.OnHoverImage = Nothing
        Me.btnqu.OnPressedColor = System.Drawing.Color.Gray
        Me.btnqu.Size = New System.Drawing.Size(30, 30)
        Me.btnqu.TabIndex = 65
        Me.btnqu.Text = "i"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.DarkRed
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Goldenrod
        Me.ProgressBar1.Location = New System.Drawing.Point(128, 284)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(412, 32)
        Me.ProgressBar1.TabIndex = 66
        '
        'lblcargando
        '
        Me.lblcargando.AutoSize = True
        Me.lblcargando.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcargando.ForeColor = System.Drawing.Color.White
        Me.lblcargando.Location = New System.Drawing.Point(290, 264)
        Me.lblcargando.Name = "lblcargando"
        Me.lblcargando.Size = New System.Drawing.Size(82, 17)
        Me.lblcargando.TabIndex = 67
        Me.lblcargando.Text = "Cargando"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(378, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "0 %"
        '
        'Timer1
        '
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 15
        Me.GunaElipse1.TargetControl = Me
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.FastFood.My.Resources.Resources.fastfood22
        Me.PictureBox6.Location = New System.Drawing.Point(505, 101)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(175, 185)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 64
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.FastFood.My.Resources.Resources.fastfood22
        Me.PictureBox5.Location = New System.Drawing.Point(335, 101)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(175, 185)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 63
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.FastFood.My.Resources.Resources.fastfood22
        Me.PictureBox4.Location = New System.Drawing.Point(164, 101)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(175, 185)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 62
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.FastFood.My.Resources.Resources.fastfood22
        Me.PictureBox3.Location = New System.Drawing.Point(-7, 101)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(175, 185)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 61
        Me.PictureBox3.TabStop = False
        '
        'btning
        '
        Me.btning.ActiveBorderThickness = 1
        Me.btning.ActiveCornerRadius = 20
        Me.btning.ActiveFillColor = System.Drawing.Color.Goldenrod
        Me.btning.ActiveForecolor = System.Drawing.Color.DarkRed
        Me.btning.ActiveLineColor = System.Drawing.Color.Goldenrod
        Me.btning.BackColor = System.Drawing.Color.Black
        Me.btning.BackgroundImage = CType(resources.GetObject("btning.BackgroundImage"), System.Drawing.Image)
        Me.btning.ButtonText = "Ingresar"
        Me.btning.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btning.Font = New System.Drawing.Font("Constantia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btning.ForeColor = System.Drawing.Color.Red
        Me.btning.IdleBorderThickness = 1
        Me.btning.IdleCornerRadius = 20
        Me.btning.IdleFillColor = System.Drawing.Color.DarkRed
        Me.btning.IdleForecolor = System.Drawing.Color.Goldenrod
        Me.btning.IdleLineColor = System.Drawing.Color.DarkRed
        Me.btning.Location = New System.Drawing.Point(128, 282)
        Me.btning.Margin = New System.Windows.Forms.Padding(5)
        Me.btning.Name = "btning"
        Me.btning.Size = New System.Drawing.Size(412, 49)
        Me.btning.TabIndex = 59
        Me.btning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.FastFood.My.Resources.Resources.MacFood2
        Me.PictureBox1.Location = New System.Drawing.Point(128, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(412, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.FastFood.My.Resources.Resources.remove1
        Me.PictureBox7.Location = New System.Drawing.Point(644, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(36, 27)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 70
        Me.PictureBox7.TabStop = False
        '
        'newlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(680, 350)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblcargando)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnqu)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btning)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "newlogin"
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btning As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnqu As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcargando As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents PictureBox7 As PictureBox
End Class
