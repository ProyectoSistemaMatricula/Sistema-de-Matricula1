<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carrera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carrera))
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        btnatras = New Button()
        PictureBox1 = New PictureBox()
        btneliminar = New Button()
        btnmodificar = New Button()
        btnguardar = New Button()
        ListMenu = New ListBox()
        Chbcomunicacion = New CheckBox()
        Chbindustrial = New CheckBox()
        Chbcontaduria = New CheckBox()
        Chbdiseño = New CheckBox()
        Chbadministracion = New CheckBox()
        Chbarquitectura = New CheckBox()
        Chbpsicologia = New CheckBox()
        Chbderecho = New CheckBox()
        Chbmedicina = New CheckBox()
        Chbsistemas = New CheckBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(323, 203)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(176, 27)
        TextBox3.TabIndex = 116
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(323, 251)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(176, 27)
        TextBox2.TabIndex = 115
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(323, 158)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 27)
        TextBox1.TabIndex = 114
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Rockwell", 10.2F)
        Label4.Location = New Point(125, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(167, 20)
        Label4.TabIndex = 113
        Label4.Text = "Duracion Semestres"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Rockwell", 10.2F)
        Label3.Location = New Point(125, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 20)
        Label3.TabIndex = 112
        Label3.Text = "Nombre Carrera"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 10.2F)
        Label2.Location = New Point(125, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 111
        Label2.Text = "Id Carrera"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(98, 404)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(743, 430)
        DataGridView1.TabIndex = 110
        ' 
        ' btnatras
        ' 
        btnatras.BackColor = Color.Transparent
        btnatras.FlatAppearance.BorderSize = 0
        btnatras.FlatStyle = FlatStyle.Flat
        btnatras.Image = CType(resources.GetObject("btnatras.Image"), Image)
        btnatras.Location = New Point(755, 6)
        btnatras.Name = "btnatras"
        btnatras.Size = New Size(70, 66)
        btnatras.TabIndex = 109
        btnatras.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(63, 67)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 107
        PictureBox1.TabStop = False
        ' 
        ' btneliminar
        ' 
        btneliminar.BackColor = Color.Transparent
        btneliminar.FlatAppearance.BorderSize = 0
        btneliminar.FlatStyle = FlatStyle.Flat
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.TopCenter
        btneliminar.Location = New Point(9, 517)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(75, 81)
        btneliminar.TabIndex = 106
        btneliminar.Text = "Eliminar"
        btneliminar.TextAlign = ContentAlignment.BottomCenter
        btneliminar.UseVisualStyleBackColor = False
        ' 
        ' btnmodificar
        ' 
        btnmodificar.BackColor = Color.Transparent
        btnmodificar.FlatAppearance.BorderSize = 0
        btnmodificar.FlatStyle = FlatStyle.Flat
        btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), Image)
        btnmodificar.ImageAlign = ContentAlignment.TopCenter
        btnmodificar.Location = New Point(9, 346)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(75, 81)
        btnmodificar.TabIndex = 105
        btnmodificar.Text = "Limpiar"
        btnmodificar.TextAlign = ContentAlignment.BottomCenter
        btnmodificar.UseVisualStyleBackColor = False
        ' 
        ' btnguardar
        ' 
        btnguardar.BackColor = Color.Transparent
        btnguardar.FlatAppearance.BorderSize = 0
        btnguardar.FlatStyle = FlatStyle.Flat
        btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), Image)
        btnguardar.ImageAlign = ContentAlignment.TopCenter
        btnguardar.Location = New Point(8, 180)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(75, 81)
        btnguardar.TabIndex = 104
        btnguardar.Text = "Guardar"
        btnguardar.TextAlign = ContentAlignment.BottomCenter
        btnguardar.UseVisualStyleBackColor = False
        ' 
        ' ListMenu
        ' 
        ListMenu.FormattingEnabled = True
        ListMenu.Items.AddRange(New Object() {"Ingeniería en Sistemas", " Medicina", " Derecho", " Psicología", " Arquitectura", " Administración de Empresas", " Diseño Gráfico", " Contaduría Pública", " Ingeniería Industrial", "", "Comunicación Social"})
        ListMenu.Location = New Point(541, 140)
        ListMenu.Name = "ListMenu"
        ListMenu.Size = New Size(274, 244)
        ListMenu.TabIndex = 93
        ' 
        ' Chbcomunicacion
        ' 
        Chbcomunicacion.AutoSize = True
        Chbcomunicacion.BackColor = Color.Transparent
        Chbcomunicacion.Location = New Point(523, 340)
        Chbcomunicacion.Name = "Chbcomunicacion"
        Chbcomunicacion.Size = New Size(111, 24)
        Chbcomunicacion.TabIndex = 103
        Chbcomunicacion.Text = "CheckBox10"
        Chbcomunicacion.UseVisualStyleBackColor = False
        ' 
        ' Chbindustrial
        ' 
        Chbindustrial.AutoSize = True
        Chbindustrial.BackColor = Color.Transparent
        Chbindustrial.Location = New Point(523, 303)
        Chbindustrial.Name = "Chbindustrial"
        Chbindustrial.Size = New Size(103, 24)
        Chbindustrial.TabIndex = 102
        Chbindustrial.Text = "CheckBox9"
        Chbindustrial.UseVisualStyleBackColor = False
        ' 
        ' Chbcontaduria
        ' 
        Chbcontaduria.AutoSize = True
        Chbcontaduria.BackColor = Color.Transparent
        Chbcontaduria.Location = New Point(523, 282)
        Chbcontaduria.Name = "Chbcontaduria"
        Chbcontaduria.Size = New Size(103, 24)
        Chbcontaduria.TabIndex = 101
        Chbcontaduria.Text = "CheckBox8"
        Chbcontaduria.UseVisualStyleBackColor = False
        ' 
        ' Chbdiseño
        ' 
        Chbdiseño.AutoSize = True
        Chbdiseño.BackColor = Color.Transparent
        Chbdiseño.Location = New Point(523, 263)
        Chbdiseño.Name = "Chbdiseño"
        Chbdiseño.Size = New Size(103, 24)
        Chbdiseño.TabIndex = 100
        Chbdiseño.Text = "CheckBox7"
        Chbdiseño.UseVisualStyleBackColor = False
        ' 
        ' Chbadministracion
        ' 
        Chbadministracion.AutoSize = True
        Chbadministracion.BackColor = Color.Transparent
        Chbadministracion.Location = New Point(523, 242)
        Chbadministracion.Name = "Chbadministracion"
        Chbadministracion.Size = New Size(103, 24)
        Chbadministracion.TabIndex = 99
        Chbadministracion.Text = "CheckBox6"
        Chbadministracion.UseVisualStyleBackColor = False
        ' 
        ' Chbarquitectura
        ' 
        Chbarquitectura.AutoSize = True
        Chbarquitectura.BackColor = Color.Transparent
        Chbarquitectura.Location = New Point(523, 223)
        Chbarquitectura.Name = "Chbarquitectura"
        Chbarquitectura.Size = New Size(103, 24)
        Chbarquitectura.TabIndex = 98
        Chbarquitectura.Text = "CheckBox5"
        Chbarquitectura.UseVisualStyleBackColor = False
        ' 
        ' Chbpsicologia
        ' 
        Chbpsicologia.AutoSize = True
        Chbpsicologia.BackColor = Color.Transparent
        Chbpsicologia.Location = New Point(523, 203)
        Chbpsicologia.Name = "Chbpsicologia"
        Chbpsicologia.Size = New Size(103, 24)
        Chbpsicologia.TabIndex = 97
        Chbpsicologia.Text = "CheckBox4"
        Chbpsicologia.UseVisualStyleBackColor = False
        ' 
        ' Chbderecho
        ' 
        Chbderecho.AutoSize = True
        Chbderecho.BackColor = Color.Transparent
        Chbderecho.Location = New Point(523, 182)
        Chbderecho.Name = "Chbderecho"
        Chbderecho.Size = New Size(103, 24)
        Chbderecho.TabIndex = 96
        Chbderecho.Text = "CheckBox3"
        Chbderecho.UseVisualStyleBackColor = False
        ' 
        ' Chbmedicina
        ' 
        Chbmedicina.AutoSize = True
        Chbmedicina.BackColor = Color.Transparent
        Chbmedicina.Location = New Point(523, 161)
        Chbmedicina.Name = "Chbmedicina"
        Chbmedicina.Size = New Size(103, 24)
        Chbmedicina.TabIndex = 95
        Chbmedicina.Text = "CheckBox2"
        Chbmedicina.UseVisualStyleBackColor = False
        ' 
        ' Chbsistemas
        ' 
        Chbsistemas.AutoSize = True
        Chbsistemas.BackColor = Color.Transparent
        Chbsistemas.Location = New Point(523, 140)
        Chbsistemas.Name = "Chbsistemas"
        Chbsistemas.Size = New Size(103, 24)
        Chbsistemas.TabIndex = 94
        Chbsistemas.Text = "CheckBox1"
        Chbsistemas.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(235, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(415, 46)
        Label1.TabIndex = 92
        Label1.Text = "Carreras Disponibles"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-4, -1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(96, 851)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 108
        PictureBox2.TabStop = False
        ' 
        ' Carrera
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(856, 847)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(btnatras)
        Controls.Add(PictureBox1)
        Controls.Add(btneliminar)
        Controls.Add(btnmodificar)
        Controls.Add(btnguardar)
        Controls.Add(ListMenu)
        Controls.Add(Chbcomunicacion)
        Controls.Add(Chbindustrial)
        Controls.Add(Chbcontaduria)
        Controls.Add(Chbdiseño)
        Controls.Add(Chbadministracion)
        Controls.Add(Chbarquitectura)
        Controls.Add(Chbpsicologia)
        Controls.Add(Chbderecho)
        Controls.Add(Chbmedicina)
        Controls.Add(Chbsistemas)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Carrera"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Carrera"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnatras As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents ListMenu As ListBox
    Friend WithEvents Chbcomunicacion As CheckBox
    Friend WithEvents Chbindustrial As CheckBox
    Friend WithEvents Chbcontaduria As CheckBox
    Friend WithEvents Chbdiseño As CheckBox
    Friend WithEvents Chbadministracion As CheckBox
    Friend WithEvents Chbarquitectura As CheckBox
    Friend WithEvents Chbpsicologia As CheckBox
    Friend WithEvents Chbderecho As CheckBox
    Friend WithEvents Chbmedicina As CheckBox
    Friend WithEvents Chbsistemas As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
