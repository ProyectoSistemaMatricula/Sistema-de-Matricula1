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
        PictureBox3 = New PictureBox()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnimprimir = New Button()
        TextBox7 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label15 = New Label()
        lblidestudiante = New Label()
        Label1 = New Label()
        TextBox6 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(218, 345)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(658, 384)
        DataGridView1.TabIndex = 13
        ' 
        ' btneliminar
        ' 
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.TopCenter
        btneliminar.Location = New Point(12, 490)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(86, 76)
        btneliminar.TabIndex = 12
        btneliminar.Text = "Eliminar"
        btneliminar.TextAlign = ContentAlignment.BottomCenter
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' btnmodificar
        ' 
        btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), Image)
        btnmodificar.ImageAlign = ContentAlignment.TopCenter
        btnmodificar.Location = New Point(12, 364)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(86, 76)
        btnmodificar.TabIndex = 11
        btnmodificar.Text = "Modificar"
        btnmodificar.TextAlign = ContentAlignment.BottomCenter
        btnmodificar.UseVisualStyleBackColor = True
        ' 
        ' btnguardar
        ' 
        btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), Image)
        btnguardar.ImageAlign = ContentAlignment.TopCenter
        btnguardar.Location = New Point(12, 235)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(86, 76)
        btnguardar.TabIndex = 10
        btnguardar.Text = "Guardar"
        btnguardar.TextAlign = ContentAlignment.BottomCenter
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' btnnuevo
        ' 
        btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), Image)
        btnnuevo.ImageAlign = ContentAlignment.TopCenter
        btnnuevo.Location = New Point(12, 108)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(86, 78)
        btnnuevo.TabIndex = 9
        btnnuevo.Text = "Nuevo"
        btnnuevo.TextAlign = ContentAlignment.BottomCenter
        btnnuevo.UseVisualStyleBackColor = True
        ' 
        ' btnatras
        ' 
        btnatras.Image = CType(resources.GetObject("btnatras.Image"), Image)
        btnatras.Location = New Point(818, 8)
        btnatras.Name = "btnatras"
        btnatras.Size = New Size(70, 66)
        btnatras.TabIndex = 8
        btnatras.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(196, -2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(704, 764)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 82
        PictureBox3.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(274, 57)
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
        PictureBox2.Size = New Size(111, 764)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 84
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(23, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(63, 55)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 85
        PictureBox1.TabStop = False
        ' 
        ' btnimprimir
        ' 
        btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), Image)
        btnimprimir.Location = New Point(10, 617)
        btnimprimir.Name = "btnimprimir"
        btnimprimir.Size = New Size(88, 76)
        btnimprimir.TabIndex = 86
        btnimprimir.Text = "Imprimir"
        btnimprimir.TextAlign = ContentAlignment.BottomCenter
        btnimprimir.UseVisualStyleBackColor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 9F)
        TextBox7.Location = New Point(676, 132)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(157, 27)
        TextBox7.TabIndex = 112
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(410, 218)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(141, 27)
        DateTimePicker1.TabIndex = 111
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 9F)
        TextBox5.Location = New Point(396, 257)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(454, 27)
        TextBox5.TabIndex = 110
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 9F)
        TextBox4.Location = New Point(661, 214)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(189, 27)
        TextBox4.TabIndex = 109
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(354, 179)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(197, 27)
        TextBox3.TabIndex = 108
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 9F)
        TextBox2.Location = New Point(661, 176)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(189, 27)
        TextBox2.TabIndex = 107
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(354, 130)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(197, 27)
        TextBox1.TabIndex = 106
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 10.2F)
        Label7.Location = New Point(571, 221)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 20)
        Label7.TabIndex = 105
        Label7.Text = "Edad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 10.2F)
        Label6.Location = New Point(229, 260)
        Label6.Name = "Label6"
        Label6.Size = New Size(161, 20)
        Label6.TabIndex = 104
        Label6.Text = "Correo Electrónico"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 10.2F)
        Label5.Location = New Point(231, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 20)
        Label5.TabIndex = 103
        Label5.Text = "Fecha de Nacimiento"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 10.2F)
        Label3.Location = New Point(563, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 20)
        Label3.TabIndex = 102
        Label3.Text = "Apellidos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 10.2F)
        Label2.Location = New Point(229, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 20)
        Label2.TabIndex = 101
        Label2.Text = "Nombres"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Rockwell", 10.2F)
        Label15.Location = New Point(564, 135)
        Label15.Name = "Label15"
        Label15.Size = New Size(106, 20)
        Label15.TabIndex = 100
        Label15.Text = "N° Identidad"
        ' 
        ' lblidestudiante
        ' 
        lblidestudiante.AutoSize = True
        lblidestudiante.Font = New Font("Rockwell", 10.2F)
        lblidestudiante.Location = New Point(229, 137)
        lblidestudiante.Name = "lblidestudiante"
        lblidestudiante.Size = New Size(111, 20)
        lblidestudiante.TabIndex = 99
        lblidestudiante.Text = "Id Estudiante"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 10.2F)
        Label1.Location = New Point(229, 291)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 20)
        Label1.TabIndex = 113
        Label1.Text = "Id Carrera"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 9F)
        TextBox6.Location = New Point(354, 291)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(189, 27)
        TextBox6.TabIndex = 114
        ' 
        ' Estudiantes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(900, 762)
        Controls.Add(TextBox6)
        Controls.Add(Label1)
        Controls.Add(TextBox7)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label15)
        Controls.Add(lblidestudiante)
        Controls.Add(btnimprimir)
        Controls.Add(btneliminar)
        Controls.Add(btnmodificar)
        Controls.Add(btnguardar)
        Controls.Add(btnnuevo)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(Label9)
        Controls.Add(DataGridView1)
        Controls.Add(btnatras)
        Controls.Add(PictureBox3)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "Estudiantes"
        Text = "Estudiantes"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnimprimir As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblidestudiante As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox6 As TextBox
End Class
