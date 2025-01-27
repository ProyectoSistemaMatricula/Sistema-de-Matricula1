<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estudiantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estudiantes))
        DataGridView1 = New DataGridView()
        btneliminar = New Button()
        btnmodificar = New Button()
        btnguardar = New Button()
        btnnuevo = New Button()
        btnatras = New Button()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        txtidentidadestu = New TextBox()
        dtpfechaestu = New DateTimePicker()
        txtcorreoestu = New TextBox()
        txtedadestu = New TextBox()
        txtnombresestu = New TextBox()
        txtapellidosestu = New TextBox()
        txtidestudiante = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label15 = New Label()
        lblidestudiante = New Label()
        Label1 = New Label()
        txtidcarreraestu = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(129, 338)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(711, 484)
        DataGridView1.TabIndex = 13
        ' 
        ' btneliminar
        ' 
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.TopCenter
        btneliminar.Location = New Point(10, 619)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(86, 76)
        btneliminar.TabIndex = 12
        btneliminar.Text = "Eliminar"
        btneliminar.TextAlign = ContentAlignment.BottomCenter
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' btnmodificar
        ' 
        btnmodificar.BackColor = Color.Transparent
        btnmodificar.FlatAppearance.BorderSize = 0
        btnmodificar.FlatStyle = FlatStyle.Flat
        btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), Image)
        btnmodificar.ImageAlign = ContentAlignment.TopCenter
        btnmodificar.Location = New Point(10, 471)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(86, 76)
        btnmodificar.TabIndex = 11
        btnmodificar.Text = "Modificar"
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
        btnguardar.Location = New Point(10, 327)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(86, 76)
        btnguardar.TabIndex = 10
        btnguardar.Text = "Guardar"
        btnguardar.TextAlign = ContentAlignment.BottomCenter
        btnguardar.UseVisualStyleBackColor = False
        ' 
        ' btnnuevo
        ' 
        btnnuevo.BackColor = Color.Transparent
        btnnuevo.FlatAppearance.BorderSize = 0
        btnnuevo.FlatStyle = FlatStyle.Flat
        btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), Image)
        btnnuevo.ImageAlign = ContentAlignment.TopCenter
        btnnuevo.Location = New Point(10, 175)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(86, 78)
        btnnuevo.TabIndex = 9
        btnnuevo.Text = "Nuevo"
        btnnuevo.TextAlign = ContentAlignment.BottomCenter
        btnnuevo.UseVisualStyleBackColor = False
        ' 
        ' btnatras
        ' 
        btnatras.BackColor = Color.Transparent
        btnatras.FlatAppearance.BorderSize = 0
        btnatras.FlatStyle = FlatStyle.Flat
        btnatras.Image = CType(resources.GetObject("btnatras.Image"), Image)
        btnatras.Location = New Point(774, 12)
        btnatras.Name = "btnatras"
        btnatras.Size = New Size(70, 66)
        btnatras.TabIndex = 8
        btnatras.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(230, 56)
        Label9.Name = "Label9"
        Label9.Size = New Size(521, 46)
        Label9.TabIndex = 83
        Label9.Text = "Información Del Estudiante"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, -2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(111, 854)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 84
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(23, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(63, 55)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 85
        PictureBox1.TabStop = False
        ' 
        ' txtidentidadestu
        ' 
        txtidentidadestu.BorderStyle = BorderStyle.FixedSingle
        txtidentidadestu.Font = New Font("Segoe UI", 9F)
        txtidentidadestu.Location = New Point(651, 131)
        txtidentidadestu.Name = "txtidentidadestu"
        txtidentidadestu.Size = New Size(189, 27)
        txtidentidadestu.TabIndex = 112
        ' 
        ' dtpfechaestu
        ' 
        dtpfechaestu.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpfechaestu.Location = New Point(345, 219)
        dtpfechaestu.Name = "dtpfechaestu"
        dtpfechaestu.Size = New Size(195, 27)
        dtpfechaestu.TabIndex = 111
        ' 
        ' txtcorreoestu
        ' 
        txtcorreoestu.BorderStyle = BorderStyle.FixedSingle
        txtcorreoestu.Font = New Font("Segoe UI", 9F)
        txtcorreoestu.Location = New Point(333, 258)
        txtcorreoestu.Name = "txtcorreoestu"
        txtcorreoestu.Size = New Size(454, 27)
        txtcorreoestu.TabIndex = 110
        ' 
        ' txtedadestu
        ' 
        txtedadestu.BorderStyle = BorderStyle.FixedSingle
        txtedadestu.Font = New Font("Segoe UI", 9F)
        txtedadestu.Location = New Point(651, 213)
        txtedadestu.Name = "txtedadestu"
        txtedadestu.Size = New Size(189, 27)
        txtedadestu.TabIndex = 109
        ' 
        ' txtnombresestu
        ' 
        txtnombresestu.BorderStyle = BorderStyle.FixedSingle
        txtnombresestu.Location = New Point(289, 180)
        txtnombresestu.Name = "txtnombresestu"
        txtnombresestu.Size = New Size(251, 27)
        txtnombresestu.TabIndex = 108
        ' 
        ' txtapellidosestu
        ' 
        txtapellidosestu.BorderStyle = BorderStyle.FixedSingle
        txtapellidosestu.Font = New Font("Segoe UI", 9F)
        txtapellidosestu.Location = New Point(651, 175)
        txtapellidosestu.Name = "txtapellidosestu"
        txtapellidosestu.Size = New Size(189, 27)
        txtapellidosestu.TabIndex = 107
        ' 
        ' txtidestudiante
        ' 
        txtidestudiante.BorderStyle = BorderStyle.FixedSingle
        txtidestudiante.Location = New Point(289, 131)
        txtidestudiante.Name = "txtidestudiante"
        txtidestudiante.Size = New Size(251, 27)
        txtidestudiante.TabIndex = 106
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Rockwell", 10.2F)
        Label7.Location = New Point(554, 220)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 20)
        Label7.TabIndex = 105
        Label7.Text = "Edad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Rockwell", 10.2F)
        Label6.Location = New Point(166, 261)
        Label6.Name = "Label6"
        Label6.Size = New Size(161, 20)
        Label6.TabIndex = 104
        Label6.Text = "Correo Electrónico"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Rockwell", 10.2F)
        Label5.Location = New Point(165, 222)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 20)
        Label5.TabIndex = 103
        Label5.Text = "Fecha de Nacimiento"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Rockwell", 10.2F)
        Label3.Location = New Point(546, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 20)
        Label3.TabIndex = 102
        Label3.Text = "Apellidos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 10.2F)
        Label2.Location = New Point(164, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 20)
        Label2.TabIndex = 101
        Label2.Text = "Nombres"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Rockwell", 10.2F)
        Label15.Location = New Point(547, 134)
        Label15.Name = "Label15"
        Label15.Size = New Size(106, 20)
        Label15.TabIndex = 100
        Label15.Text = "N° Identidad"
        ' 
        ' lblidestudiante
        ' 
        lblidestudiante.AutoSize = True
        lblidestudiante.BackColor = Color.Transparent
        lblidestudiante.Font = New Font("Rockwell", 10.2F)
        lblidestudiante.Location = New Point(164, 138)
        lblidestudiante.Name = "lblidestudiante"
        lblidestudiante.Size = New Size(111, 20)
        lblidestudiante.TabIndex = 99
        lblidestudiante.Text = "Id Estudiante"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rockwell", 10.2F)
        Label1.Location = New Point(166, 292)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 20)
        Label1.TabIndex = 113
        Label1.Text = "Id Carrera"
        ' 
        ' txtidcarreraestu
        ' 
        txtidcarreraestu.BorderStyle = BorderStyle.FixedSingle
        txtidcarreraestu.Font = New Font("Segoe UI", 9F)
        txtidcarreraestu.Location = New Point(291, 292)
        txtidcarreraestu.Name = "txtidcarreraestu"
        txtidcarreraestu.Size = New Size(189, 27)
        txtidcarreraestu.TabIndex = 114
        ' 
        ' Estudiantes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(856, 847)
        Controls.Add(txtidcarreraestu)
        Controls.Add(Label1)
        Controls.Add(txtidentidadestu)
        Controls.Add(dtpfechaestu)
        Controls.Add(txtcorreoestu)
        Controls.Add(txtedadestu)
        Controls.Add(txtnombresestu)
        Controls.Add(txtapellidosestu)
        Controls.Add(txtidestudiante)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label15)
        Controls.Add(lblidestudiante)
        Controls.Add(btneliminar)
        Controls.Add(btnmodificar)
        Controls.Add(btnguardar)
        Controls.Add(btnnuevo)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(Label9)
        Controls.Add(DataGridView1)
        Controls.Add(btnatras)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "Estudiantes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Estudiantes"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnatras As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtidentidadestu As TextBox
    Friend WithEvents dtpfechaestu As DateTimePicker
    Friend WithEvents txtcorreoestu As TextBox
    Friend WithEvents txtedadestu As TextBox
    Friend WithEvents txtnombresestu As TextBox
    Friend WithEvents txtapellidosestu As TextBox
    Friend WithEvents txtidestudiante As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblidestudiante As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidcarreraestu As TextBox
End Class
