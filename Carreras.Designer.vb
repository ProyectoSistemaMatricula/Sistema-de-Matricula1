<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carreras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carreras))
        ListMenu = New ListBox()
        CheckBox10 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        Label8 = New Label()
        ListBox1 = New ListBox()
        PictureBox1 = New PictureBox()
        btneliminar = New Button()
        btnmodificar = New Button()
        btnguardar = New Button()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListMenu
        ' 
        ListMenu.FormattingEnabled = True
        ListMenu.Items.AddRange(New Object() {"Ingeniería en Sistemas", " Medicina", " Derecho", " Psicología", " Arquitectura", " Administración de Empresas", " Diseño Gráfico", " Contaduría Pública", " Ingeniería Industrial", "", "Comunicación Social"})
        ListMenu.Location = New Point(390, 207)
        ListMenu.Name = "ListMenu"
        ListMenu.Size = New Size(434, 244)
        ListMenu.TabIndex = 62
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(373, 413)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(111, 24)
        CheckBox10.TabIndex = 72
        CheckBox10.Text = "CheckBox10"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(373, 370)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(103, 24)
        CheckBox9.TabIndex = 71
        CheckBox9.Text = "CheckBox9"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(373, 349)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(103, 24)
        CheckBox8.TabIndex = 70
        CheckBox8.Text = "CheckBox8"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(373, 330)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(103, 24)
        CheckBox7.TabIndex = 69
        CheckBox7.Text = "CheckBox7"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(373, 309)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(103, 24)
        CheckBox6.TabIndex = 68
        CheckBox6.Text = "CheckBox6"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(373, 290)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(103, 24)
        CheckBox5.TabIndex = 67
        CheckBox5.Text = "CheckBox5"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(373, 270)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(103, 24)
        CheckBox4.TabIndex = 66
        CheckBox4.Text = "CheckBox4"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(373, 249)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(103, 24)
        CheckBox3.TabIndex = 65
        CheckBox3.Text = "CheckBox3"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(373, 228)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(103, 24)
        CheckBox2.TabIndex = 64
        CheckBox2.Text = "CheckBox2"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(373, 207)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(103, 24)
        CheckBox1.TabIndex = 63
        CheckBox1.Text = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(390, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(415, 46)
        Label1.TabIndex = 55
        Label1.Text = "Carreras Disponibles"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell", 10.2F)
        Label8.Location = New Point(150, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 20)
        Label8.TabIndex = 74
        Label8.Text = "Carrera Elegida"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(138, 53)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(158, 124)
        ListBox1.TabIndex = 73
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(13, 14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 79
        PictureBox1.TabStop = False
        ' 
        ' btneliminar
        ' 
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.TopCenter
        btneliminar.Location = New Point(13, 473)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(75, 81)
        btneliminar.TabIndex = 78
        btneliminar.Text = "Eliminar"
        btneliminar.TextAlign = ContentAlignment.BottomCenter
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' btnmodificar
        ' 
        btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), Image)
        btnmodificar.ImageAlign = ContentAlignment.TopCenter
        btnmodificar.Location = New Point(13, 302)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(75, 81)
        btnmodificar.TabIndex = 77
        btnmodificar.Text = "Limpiar"
        btnmodificar.TextAlign = ContentAlignment.BottomCenter
        btnmodificar.UseVisualStyleBackColor = True
        ' 
        ' btnguardar
        ' 
        btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), Image)
        btnguardar.ImageAlign = ContentAlignment.TopCenter
        btnguardar.Location = New Point(13, 142)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(75, 81)
        btnguardar.TabIndex = 76
        btnguardar.Text = "Guardar"
        btnguardar.TextAlign = ContentAlignment.BottomCenter
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(-1, -2)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 630)
        Button1.TabIndex = 75
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.Location = New Point(326, 22)
        Button2.Name = "Button2"
        Button2.Size = New Size(558, 596)
        Button2.TabIndex = 56
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Carreras
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(941, 626)
        Controls.Add(PictureBox1)
        Controls.Add(btneliminar)
        Controls.Add(btnmodificar)
        Controls.Add(btnguardar)
        Controls.Add(Button1)
        Controls.Add(Label8)
        Controls.Add(ListBox1)
        Controls.Add(ListMenu)
        Controls.Add(CheckBox10)
        Controls.Add(CheckBox9)
        Controls.Add(CheckBox8)
        Controls.Add(CheckBox7)
        Controls.Add(CheckBox6)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label1)
        Controls.Add(Button2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Carreras"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Carreras"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListMenu As ListBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
