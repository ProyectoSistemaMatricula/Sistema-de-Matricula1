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
        PictureBox2 = New PictureBox()
        btnatras = New Button()
        DataGridView1 = New DataGridView()
        Btncarrera = New Button()
        CheckBox11 = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListMenu
        ' 
        ListMenu.FormattingEnabled = True
        ListMenu.Items.AddRange(New Object() {"Ingeniería en Sistemas", " Medicina", " Derecho", " Psicología", " Arquitectura", " Administración de Empresas", " Diseño Gráfico", " Contaduría Pública", " Ingeniería Industrial", "", "Comunicación Social"})
        ListMenu.Location = New Point(403, 323)
        ListMenu.Name = "ListMenu"
        ListMenu.Size = New Size(434, 244)
        ListMenu.TabIndex = 62
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(386, 529)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(111, 24)
        CheckBox10.TabIndex = 72
        CheckBox10.Text = "CheckBox10"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(386, 486)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(103, 24)
        CheckBox9.TabIndex = 71
        CheckBox9.Text = "CheckBox9"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(386, 465)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(103, 24)
        CheckBox8.TabIndex = 70
        CheckBox8.Text = "CheckBox8"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(386, 446)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(103, 24)
        CheckBox7.TabIndex = 69
        CheckBox7.Text = "CheckBox7"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(386, 425)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(103, 24)
        CheckBox6.TabIndex = 68
        CheckBox6.Text = "CheckBox6"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(386, 406)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(103, 24)
        CheckBox5.TabIndex = 67
        CheckBox5.Text = "CheckBox5"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(386, 386)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(103, 24)
        CheckBox4.TabIndex = 66
        CheckBox4.Text = "CheckBox4"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(386, 365)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(103, 24)
        CheckBox3.TabIndex = 65
        CheckBox3.Text = "CheckBox3"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(386, 344)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(103, 24)
        CheckBox2.TabIndex = 64
        CheckBox2.Text = "CheckBox2"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(386, 323)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(103, 24)
        CheckBox1.TabIndex = 63
        CheckBox1.Text = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(403, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(415, 46)
        Label1.TabIndex = 55
        Label1.Text = "Carreras Disponibles"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Rockwell", 10.2F)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(126, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 20)
        Label8.TabIndex = 74
        Label8.Text = "Carrera Elegida"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(116, 45)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(158, 124)
        ListBox1.TabIndex = 73
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 51)
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
        btnguardar.Location = New Point(12, 136)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(75, 81)
        btnguardar.TabIndex = 76
        btnguardar.Text = "Guardar"
        btnguardar.TextAlign = ContentAlignment.BottomCenter
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(2, 1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(96, 630)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 80
        PictureBox2.TabStop = False
        ' 
        ' btnatras
        ' 
        btnatras.Image = CType(resources.GetObject("btnatras.Image"), Image)
        btnatras.Location = New Point(859, 12)
        btnatras.Name = "btnatras"
        btnatras.Size = New Size(70, 66)
        btnatras.TabIndex = 82
        btnatras.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(320, 84)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(588, 217)
        DataGridView1.TabIndex = 83
        ' 
        ' Btncarrera
        ' 
        Btncarrera.Location = New Point(564, 573)
        Btncarrera.Name = "Btncarrera"
        Btncarrera.Size = New Size(130, 29)
        Btncarrera.TabIndex = 84
        Btncarrera.Text = "Tomar carrera"
        Btncarrera.UseVisualStyleBackColor = True
        ' 
        ' CheckBox11
        ' 
        CheckBox11.AutoSize = True
        CheckBox11.Location = New Point(625, 243)
        CheckBox11.Name = "CheckBox11"
        CheckBox11.Size = New Size(111, 24)
        CheckBox11.TabIndex = 85
        CheckBox11.Text = "CheckBox11"
        CheckBox11.UseVisualStyleBackColor = True
        ' 
        ' Carreras
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(941, 626)
        Controls.Add(Btncarrera)
        Controls.Add(DataGridView1)
        Controls.Add(btnatras)
        Controls.Add(PictureBox1)
        Controls.Add(btneliminar)
        Controls.Add(btnmodificar)
        Controls.Add(btnguardar)
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
        Controls.Add(PictureBox2)
        Controls.Add(CheckBox11)
        FormBorderStyle = FormBorderStyle.None
        Name = "Carreras"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Carreras"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnatras As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btncarrera As Button
    Friend WithEvents CheckBox11 As CheckBox
End Class
