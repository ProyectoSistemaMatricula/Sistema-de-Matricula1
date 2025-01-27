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
        PictureBox1 = New PictureBox()
        btneliminar = New Button()
        btnmodificar = New Button()
        btnguardar = New Button()
        PictureBox2 = New PictureBox()
        btnatras = New Button()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListMenu
        ' 
        ListMenu.FormattingEnabled = True
        ListMenu.Items.AddRange(New Object() {"Ingeniería en Sistemas", " Medicina", " Derecho", " Psicología", " Arquitectura", " Administración de Empresas", " Diseño Gráfico", " Contaduría Pública", " Ingeniería Industrial", "", "Comunicación Social"})
        ListMenu.Location = New Point(602, 136)
        ListMenu.Name = "ListMenu"
        ListMenu.Size = New Size(274, 244)
        ListMenu.TabIndex = 62
        ' 
        ' Chbcomunicacion
        ' 
        Chbcomunicacion.AutoSize = True
        Chbcomunicacion.BackColor = Color.Transparent
        Chbcomunicacion.Location = New Point(585, 336)
        Chbcomunicacion.Name = "Chbcomunicacion"
        Chbcomunicacion.Size = New Size(111, 24)
        Chbcomunicacion.TabIndex = 72
        Chbcomunicacion.Text = "CheckBox10"
        Chbcomunicacion.UseVisualStyleBackColor = False
        ' 
        ' Chbindustrial
        ' 
        Chbindustrial.AutoSize = True
        Chbindustrial.BackColor = Color.Transparent
        Chbindustrial.Location = New Point(585, 299)
        Chbindustrial.Name = "Chbindustrial"
        Chbindustrial.Size = New Size(103, 24)
        Chbindustrial.TabIndex = 71
        Chbindustrial.Text = "CheckBox9"
        Chbindustrial.UseVisualStyleBackColor = False
        ' 
        ' Chbcontaduria
        ' 
        Chbcontaduria.AutoSize = True
        Chbcontaduria.BackColor = Color.Transparent
        Chbcontaduria.Location = New Point(585, 278)
        Chbcontaduria.Name = "Chbcontaduria"
        Chbcontaduria.Size = New Size(103, 24)
        Chbcontaduria.TabIndex = 70
        Chbcontaduria.Text = "CheckBox8"
        Chbcontaduria.UseVisualStyleBackColor = False
        ' 
        ' Chbdiseño
        ' 
        Chbdiseño.AutoSize = True
        Chbdiseño.BackColor = Color.Transparent
        Chbdiseño.Location = New Point(585, 259)
        Chbdiseño.Name = "Chbdiseño"
        Chbdiseño.Size = New Size(103, 24)
        Chbdiseño.TabIndex = 69
        Chbdiseño.Text = "CheckBox7"
        Chbdiseño.UseVisualStyleBackColor = False
        ' 
        ' Chbadministracion
        ' 
        Chbadministracion.AutoSize = True
        Chbadministracion.BackColor = Color.Transparent
        Chbadministracion.Location = New Point(585, 238)
        Chbadministracion.Name = "Chbadministracion"
        Chbadministracion.Size = New Size(103, 24)
        Chbadministracion.TabIndex = 68
        Chbadministracion.Text = "CheckBox6"
        Chbadministracion.UseVisualStyleBackColor = False
        ' 
        ' Chbarquitectura
        ' 
        Chbarquitectura.AutoSize = True
        Chbarquitectura.BackColor = Color.Transparent
        Chbarquitectura.Location = New Point(585, 219)
        Chbarquitectura.Name = "Chbarquitectura"
        Chbarquitectura.Size = New Size(103, 24)
        Chbarquitectura.TabIndex = 67
        Chbarquitectura.Text = "CheckBox5"
        Chbarquitectura.UseVisualStyleBackColor = False
        ' 
        ' Chbpsicologia
        ' 
        Chbpsicologia.AutoSize = True
        Chbpsicologia.BackColor = Color.Transparent
        Chbpsicologia.Location = New Point(585, 199)
        Chbpsicologia.Name = "Chbpsicologia"
        Chbpsicologia.Size = New Size(103, 24)
        Chbpsicologia.TabIndex = 66
        Chbpsicologia.Text = "CheckBox4"
        Chbpsicologia.UseVisualStyleBackColor = False
        ' 
        ' Chbderecho
        ' 
        Chbderecho.AutoSize = True
        Chbderecho.BackColor = Color.Transparent
        Chbderecho.Location = New Point(585, 178)
        Chbderecho.Name = "Chbderecho"
        Chbderecho.Size = New Size(103, 24)
        Chbderecho.TabIndex = 65
        Chbderecho.Text = "CheckBox3"
        Chbderecho.UseVisualStyleBackColor = False
        ' 
        ' Chbmedicina
        ' 
        Chbmedicina.AutoSize = True
        Chbmedicina.BackColor = Color.Transparent
        Chbmedicina.Location = New Point(585, 157)
        Chbmedicina.Name = "Chbmedicina"
        Chbmedicina.Size = New Size(103, 24)
        Chbmedicina.TabIndex = 64
        Chbmedicina.Text = "CheckBox2"
        Chbmedicina.UseVisualStyleBackColor = False
        ' 
        ' Chbsistemas
        ' 
        Chbsistemas.AutoSize = True
        Chbsistemas.BackColor = Color.Transparent
        Chbsistemas.Location = New Point(585, 136)
        Chbsistemas.Name = "Chbsistemas"
        Chbsistemas.Size = New Size(103, 24)
        Chbsistemas.TabIndex = 63
        Chbsistemas.Text = "CheckBox1"
        Chbsistemas.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(286, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(415, 46)
        Label1.TabIndex = 55
        Label1.Text = "Carreras Disponibles"
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
        btneliminar.Location = New Point(12, 518)
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
        btnmodificar.Location = New Point(12, 347)
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
        btnguardar.Location = New Point(11, 181)
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
        PictureBox2.Size = New Size(96, 740)
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
        DataGridView1.Location = New Point(128, 397)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(758, 335)
        DataGridView1.TabIndex = 83
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 10.2F)
        Label2.Location = New Point(128, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 86
        Label2.Text = "Id Carrera"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Rockwell", 10.2F)
        Label3.Location = New Point(128, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 20)
        Label3.TabIndex = 87
        Label3.Text = "Nombre Carrera"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Rockwell", 10.2F)
        Label4.Location = New Point(128, 259)
        Label4.Name = "Label4"
        Label4.Size = New Size(167, 20)
        Label4.TabIndex = 88
        Label4.Text = "Duracion Semestres"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(326, 159)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 27)
        TextBox1.TabIndex = 89
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(326, 252)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(176, 27)
        TextBox2.TabIndex = 90
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(326, 204)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(176, 27)
        TextBox3.TabIndex = 91
        ' 
        ' Carreras
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(941, 744)
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnatras As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
