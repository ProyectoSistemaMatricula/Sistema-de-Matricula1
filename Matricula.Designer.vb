<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Matricula))
        ComboBox1 = New ComboBox()
        Label10 = New Label()
        Label9 = New Label()
        btnatras = New Button()
        DataGridView1 = New DataGridView()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox5 = New ComboBox()
        ComboBox6 = New ComboBox()
        Docente = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
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
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        btnimprimir = New Button()
        btneliminar = New Button()
        btnmodificar = New Button()
        btnguardar = New Button()
        btnnuevo = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(473, 321)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(114, 28)
        ComboBox1.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Rockwell", 10.2F)
        Label10.Location = New Point(396, 331)
        Label10.Name = "Label10"
        Label10.Size = New Size(62, 20)
        Label10.TabIndex = 17
        Label10.Text = "Clases"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 10.2F)
        Label9.Location = New Point(189, 329)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 20)
        Label9.TabIndex = 16
        Label9.Text = "Carrera"
        ' 
        ' btnatras
        ' 
        btnatras.BackColor = Color.White
        btnatras.Image = CType(resources.GetObject("btnatras.Image"), Image)
        btnatras.Location = New Point(750, 3)
        btnatras.Name = "btnatras"
        btnatras.Size = New Size(70, 67)
        btnatras.TabIndex = 1
        btnatras.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.HighlightText
        DataGridView1.Location = New Point(168, 484)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(665, 337)
        DataGridView1.TabIndex = 6
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(719, 323)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(114, 28)
        ComboBox2.TabIndex = 18
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(266, 323)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(114, 28)
        ComboBox3.TabIndex = 18
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(266, 379)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(114, 28)
        ComboBox4.TabIndex = 18
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(473, 372)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(114, 28)
        ComboBox5.TabIndex = 18
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(719, 374)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(114, 28)
        ComboBox6.TabIndex = 18
        ' 
        ' Docente
        ' 
        Docente.AutoSize = True
        Docente.Font = New Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Docente.Location = New Point(607, 329)
        Docente.Name = "Docente"
        Docente.Size = New Size(84, 21)
        Docente.TabIndex = 19
        Docente.Text = "Docente"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(189, 381)
        Label11.Name = "Label11"
        Label11.Size = New Size(40, 21)
        Label11.TabIndex = 20
        Label11.Text = "Dia"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(396, 379)
        Label12.Name = "Label12"
        Label12.Size = New Size(52, 21)
        Label12.TabIndex = 21
        Label12.Text = "Hora"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(607, 379)
        Label13.Name = "Label13"
        Label13.Size = New Size(106, 21)
        Label13.TabIndex = 22
        Label13.Text = "Modalidad"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Rockwell", 10.2F)
        Label14.Location = New Point(166, 114)
        Label14.Name = "Label14"
        Label14.Size = New Size(158, 20)
        Label14.TabIndex = 23
        Label14.Text = "Cod. Pre-Matricula"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 9F)
        TextBox7.Location = New Point(630, 109)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(157, 27)
        TextBox7.TabIndex = 98
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(347, 195)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(141, 27)
        DateTimePicker1.TabIndex = 97
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 9F)
        TextBox5.Location = New Point(269, 237)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(518, 27)
        TextBox5.TabIndex = 95
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 9F)
        TextBox4.Location = New Point(598, 191)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(189, 27)
        TextBox4.TabIndex = 94
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(291, 156)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(197, 27)
        TextBox3.TabIndex = 93
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 9F)
        TextBox2.Location = New Point(598, 153)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(189, 27)
        TextBox2.TabIndex = 92
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(331, 111)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(157, 27)
        TextBox1.TabIndex = 91
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 10.2F)
        Label7.Location = New Point(508, 198)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 20)
        Label7.TabIndex = 90
        Label7.Text = "Teléfono"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 10.2F)
        Label6.Location = New Point(166, 237)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 89
        Label6.Text = "Dirección"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 10.2F)
        Label5.Location = New Point(168, 198)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 20)
        Label5.TabIndex = 88
        Label5.Text = "Fecha de Nacimiento"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 10.2F)
        Label3.Location = New Point(500, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 20)
        Label3.TabIndex = 86
        Label3.Text = "Apellidos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 10.2F)
        Label2.Location = New Point(166, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 20)
        Label2.TabIndex = 85
        Label2.Text = "Nombres"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Rockwell", 10.2F)
        Label15.Location = New Point(501, 112)
        Label15.Name = "Label15"
        Label15.Size = New Size(106, 20)
        Label15.TabIndex = 84
        Label15.Text = "N° Identidad"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(151, -6)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(704, 852)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 102
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(202, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(521, 46)
        Label1.TabIndex = 100
        Label1.Text = "Información Del Estudiante"
        ' 
        ' btnimprimir
        ' 
        btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), Image)
        btnimprimir.Location = New Point(12, 703)
        btnimprimir.Name = "btnimprimir"
        btnimprimir.Size = New Size(86, 76)
        btnimprimir.TabIndex = 109
        btnimprimir.Text = "Imprimir"
        btnimprimir.TextAlign = ContentAlignment.BottomCenter
        btnimprimir.UseVisualStyleBackColor = True
        ' 
        ' btneliminar
        ' 
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.TopCenter
        btneliminar.Location = New Point(12, 562)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(86, 76)
        btneliminar.TabIndex = 106
        btneliminar.Text = "Eliminar"
        btneliminar.TextAlign = ContentAlignment.BottomCenter
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' btnmodificar
        ' 
        btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), Image)
        btnmodificar.ImageAlign = ContentAlignment.TopCenter
        btnmodificar.Location = New Point(12, 420)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(86, 76)
        btnmodificar.TabIndex = 105
        btnmodificar.Text = "Modificar"
        btnmodificar.TextAlign = ContentAlignment.BottomCenter
        btnmodificar.UseVisualStyleBackColor = True
        ' 
        ' btnguardar
        ' 
        btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), Image)
        btnguardar.ImageAlign = ContentAlignment.TopCenter
        btnguardar.Location = New Point(12, 284)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(86, 76)
        btnguardar.TabIndex = 104
        btnguardar.Text = "Guardar"
        btnguardar.TextAlign = ContentAlignment.BottomCenter
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' btnnuevo
        ' 
        btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), Image)
        btnnuevo.ImageAlign = ContentAlignment.TopCenter
        btnnuevo.Location = New Point(12, 140)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(86, 78)
        btnnuevo.TabIndex = 103
        btnnuevo.Text = "Nuevo"
        btnnuevo.TextAlign = ContentAlignment.BottomCenter
        btnnuevo.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(63, 55)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 108
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-5, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(119, 847)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 107
        PictureBox2.TabStop = False
        ' 
        ' Matricula
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(856, 847)
        Controls.Add(btnimprimir)
        Controls.Add(btneliminar)
        Controls.Add(btnmodificar)
        Controls.Add(btnguardar)
        Controls.Add(btnnuevo)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
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
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Docente)
        Controls.Add(Label10)
        Controls.Add(ComboBox5)
        Controls.Add(ComboBox6)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox1)
        Controls.Add(Label9)
        Controls.Add(DataGridView1)
        Controls.Add(btnatras)
        Controls.Add(PictureBox3)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "Matricula"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Matricula"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnatras As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Docente As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
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
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnimprimir As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
