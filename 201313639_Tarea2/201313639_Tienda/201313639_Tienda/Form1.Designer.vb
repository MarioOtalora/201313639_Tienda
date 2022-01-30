<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Texazucar = New System.Windows.Forms.TextBox()
        Me.Texarroz = New System.Windows.Forms.TextBox()
        Me.Texfrijol = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.todototal = New System.Windows.Forms.Label()
        Me.desprec = New System.Windows.Forms.Label()
        Me.calciva = New System.Windows.Forms.Label()
        Me.totalsiniva = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Exit3 = New System.Windows.Forms.Button()
        Me.Clean2 = New System.Windows.Forms.Button()
        Me.Acept1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.totaciva = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Texazucar)
        Me.GroupBox1.Controls.Add(Me.Texarroz)
        Me.GroupBox1.Controls.Add(Me.Texfrijol)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(269, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 245)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese Artículos"
        '
        'Texazucar
        '
        Me.Texazucar.Location = New System.Drawing.Point(115, 81)
        Me.Texazucar.Name = "Texazucar"
        Me.Texazucar.Size = New System.Drawing.Size(260, 23)
        Me.Texazucar.TabIndex = 5
        Me.Texazucar.Text = "0.0"
        '
        'Texarroz
        '
        Me.Texarroz.Location = New System.Drawing.Point(115, 135)
        Me.Texarroz.Name = "Texarroz"
        Me.Texarroz.Size = New System.Drawing.Size(260, 23)
        Me.Texarroz.TabIndex = 4
        Me.Texarroz.Text = "0.0"
        '
        'Texfrijol
        '
        Me.Texfrijol.Location = New System.Drawing.Point(115, 25)
        Me.Texfrijol.Name = "Texfrijol"
        Me.Texfrijol.Size = New System.Drawing.Size(260, 23)
        Me.Texfrijol.TabIndex = 3
        Me.Texfrijol.Text = "0.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cant. Azúcar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cant. Arroz"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cant. Frijol"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.totaciva)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.todototal)
        Me.GroupBox2.Controls.Add(Me.desprec)
        Me.GroupBox2.Controls.Add(Me.calciva)
        Me.GroupBox2.Controls.Add(Me.totalsiniva)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 175)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Monto a Cancelar:"
        '
        'todototal
        '
        Me.todototal.AutoSize = True
        Me.todototal.Location = New System.Drawing.Point(146, 147)
        Me.todototal.Name = "todototal"
        Me.todototal.Size = New System.Drawing.Size(22, 15)
        Me.todototal.TabIndex = 7
        Me.todototal.Text = "0.0"
        '
        'desprec
        '
        Me.desprec.AutoSize = True
        Me.desprec.Location = New System.Drawing.Point(146, 121)
        Me.desprec.Name = "desprec"
        Me.desprec.Size = New System.Drawing.Size(22, 15)
        Me.desprec.TabIndex = 6
        Me.desprec.Text = "0.0"
        '
        'calciva
        '
        Me.calciva.AutoSize = True
        Me.calciva.Location = New System.Drawing.Point(146, 57)
        Me.calciva.Name = "calciva"
        Me.calciva.Size = New System.Drawing.Size(22, 15)
        Me.calciva.TabIndex = 5
        Me.calciva.Text = "0.0"
        '
        'totalsiniva
        '
        Me.totalsiniva.AutoSize = True
        Me.totalsiniva.Location = New System.Drawing.Point(146, 27)
        Me.totalsiniva.Name = "totalsiniva"
        Me.totalsiniva.Size = New System.Drawing.Size(22, 15)
        Me.totalsiniva.TabIndex = 4
        Me.totalsiniva.Text = "0.0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Aplica Descuento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "IVA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Subtotal:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 245)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Exit3)
        Me.GroupBox3.Controls.Add(Me.Clean2)
        Me.GroupBox3.Controls.Add(Me.Acept1)
        Me.GroupBox3.Location = New System.Drawing.Point(287, 263)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(388, 175)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones:"
        '
        'Exit3
        '
        Me.Exit3.Location = New System.Drawing.Point(127, 105)
        Me.Exit3.Name = "Exit3"
        Me.Exit3.Size = New System.Drawing.Size(137, 47)
        Me.Exit3.TabIndex = 2
        Me.Exit3.Text = "SALIR"
        Me.Exit3.UseVisualStyleBackColor = True
        '
        'Clean2
        '
        Me.Clean2.Location = New System.Drawing.Point(220, 27)
        Me.Clean2.Name = "Clean2"
        Me.Clean2.Size = New System.Drawing.Size(137, 47)
        Me.Clean2.TabIndex = 1
        Me.Clean2.Text = "LIMPIAR"
        Me.Clean2.UseVisualStyleBackColor = True
        '
        'Acept1
        '
        Me.Acept1.Location = New System.Drawing.Point(26, 25)
        Me.Acept1.Name = "Acept1"
        Me.Acept1.Size = New System.Drawing.Size(137, 47)
        Me.Acept1.TabIndex = 0
        Me.Acept1.Text = "ACEPTAR"
        Me.Acept1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total Con IVA:"
        '
        'totaciva
        '
        Me.totaciva.AutoSize = True
        Me.totaciva.Location = New System.Drawing.Point(146, 90)
        Me.totaciva.Name = "totaciva"
        Me.totaciva.Size = New System.Drawing.Size(22, 15)
        Me.totaciva.TabIndex = 9
        Me.totaciva.Text = "0.0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(721, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Texazucar As TextBox
    Friend WithEvents Texarroz As TextBox
    Friend WithEvents Texfrijol As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents todototal As Label
    Friend WithEvents desprec As Label
    Friend WithEvents calciva As Label
    Friend WithEvents totalsiniva As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Exit3 As Button
    Friend WithEvents Clean2 As Button
    Friend WithEvents Acept1 As Button
    Friend WithEvents totaciva As Label
    Friend WithEvents Label8 As Label
End Class
