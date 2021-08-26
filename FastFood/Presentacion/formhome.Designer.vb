<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formhome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formhome))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomTextbox2 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "VISION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MISION"
        '
        'BunifuCustomTextbox1
        '
        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomTextbox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(37, 273)
        Me.BunifuCustomTextbox1.Multiline = True
        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(717, 68)
        Me.BunifuCustomTextbox1.TabIndex = 6
        Me.BunifuCustomTextbox1.Text = resources.GetString("BunifuCustomTextbox1.Text")
        '
        'BunifuCustomTextbox2
        '
        Me.BunifuCustomTextbox2.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomTextbox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomTextbox2.Location = New System.Drawing.Point(37, 139)
        Me.BunifuCustomTextbox2.Multiline = True
        Me.BunifuCustomTextbox2.Name = "BunifuCustomTextbox2"
        Me.BunifuCustomTextbox2.Size = New System.Drawing.Size(717, 80)
        Me.BunifuCustomTextbox2.TabIndex = 7
        Me.BunifuCustomTextbox2.Text = resources.GetString("BunifuCustomTextbox2.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FastFood.My.Resources.Resources.bbr
        Me.PictureBox1.Location = New System.Drawing.Point(319, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'formhome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(784, 367)
        Me.Controls.Add(Me.BunifuCustomTextbox2)
        Me.Controls.Add(Me.BunifuCustomTextbox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "formhome"
        Me.Text = "formcomb"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomTextbox2 As WindowsFormsControlLibrary1.BunifuCustomTextbox
End Class
