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
        GroupBox1 = New GroupBox()
        Label8 = New Label()
        TextBox7 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label10 = New Label()
        Label9 = New Label()
        btnatras = New Button()
        btnnuevo = New Button()
        btnguardar = New Button()
        btnmodificar = New Button()
        btneliminar = New Button()
        DataGridView1 = New DataGridView()
        btnimprimir = New Button()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox5 = New ComboBox()
        ComboBox6 = New ComboBox()
        Docente = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(TextBox7)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(11, 64)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(808, 207)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Información del estudiante"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell", 10.2F)
        Label8.Location = New Point(19, 39)
        Label8.Name = "Label8"
        Label8.Size = New Size(158, 20)
        Label8.TabIndex = 15
        Label8.Text = "Cod. Pre-Matricula"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 9F)
        TextBox7.Location = New Point(537, 35)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(265, 27)
        TextBox7.TabIndex = 14
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(199, 115)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(190, 27)
        DateTimePicker1.TabIndex = 13
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(143, 151)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(246, 30)
        TextBox6.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 9F)
        TextBox5.Location = New Point(506, 160)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(297, 27)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 9F)
        TextBox4.Location = New Point(506, 115)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(297, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(143, 76)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(246, 30)
        TextBox3.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 10.2F)
        Label2.Location = New Point(19, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nombres"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 9F)
        TextBox2.Location = New Point(506, 76)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(297, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(183, 31)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(206, 30)
        TextBox1.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 10.2F)
        Label7.Location = New Point(19, 156)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 20)
        Label7.TabIndex = 6
        Label7.Text = "Teléfono"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 10.2F)
        Label6.Location = New Point(408, 160)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 5
        Label6.Text = "Dirección"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 10.2F)
        Label5.Location = New Point(19, 117)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 20)
        Label5.TabIndex = 4
        Label5.Text = "Fecha de Nacimiento"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 10.2F)
        Label4.Location = New Point(408, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 20)
        Label4.TabIndex = 3
        Label4.Text = "2°Apellido"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 10.2F)
        Label3.Location = New Point(408, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 20)
        Label3.TabIndex = 2
        Label3.Text = "1°Apellido"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 10.2F)
        Label1.Location = New Point(408, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 20)
        Label1.TabIndex = 0
        Label1.Text = "N° Documento"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(105, 383)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(138, 28)
        ComboBox1.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Rockwell", 10.2F)
        Label10.Location = New Point(323, 391)
        Label10.Name = "Label10"
        Label10.Size = New Size(62, 20)
        Label10.TabIndex = 17
        Label10.Text = "Clases"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 10.2F)
        Label9.Location = New Point(31, 383)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 20)
        Label9.TabIndex = 16
        Label9.Text = "Carrera"
        ' 
        ' btnatras
        ' 
        btnatras.Image = CType(resources.GetObject("btnatras.Image"), Image)
        btnatras.Location = New Point(750, 3)
        btnatras.Name = "btnatras"
        btnatras.Size = New Size(70, 67)
        btnatras.TabIndex = 1
        btnatras.UseVisualStyleBackColor = True
        ' 
        ' btnnuevo
        ' 
        btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), Image)
        btnnuevo.ImageAlign = ContentAlignment.TopCenter
        btnnuevo.Location = New Point(223, 281)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(94, 76)
        btnnuevo.TabIndex = 2
        btnnuevo.Text = "Nuevo"
        btnnuevo.TextAlign = ContentAlignment.BottomCenter
        btnnuevo.UseVisualStyleBackColor = True
        ' 
        ' btnguardar
        ' 
        btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), Image)
        btnguardar.ImageAlign = ContentAlignment.TopCenter
        btnguardar.Location = New Point(323, 281)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(94, 76)
        btnguardar.TabIndex = 3
        btnguardar.Text = "Guardar"
        btnguardar.TextAlign = ContentAlignment.BottomCenter
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' btnmodificar
        ' 
        btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), Image)
        btnmodificar.ImageAlign = ContentAlignment.TopCenter
        btnmodificar.Location = New Point(424, 281)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(94, 76)
        btnmodificar.TabIndex = 4
        btnmodificar.Text = "Modificar"
        btnmodificar.TextAlign = ContentAlignment.BottomCenter
        btnmodificar.UseVisualStyleBackColor = True
        ' 
        ' btneliminar
        ' 
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.TopCenter
        btneliminar.Location = New Point(525, 281)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(94, 76)
        btneliminar.TabIndex = 5
        btneliminar.Text = "Eliminar"
        btneliminar.TextAlign = ContentAlignment.BottomCenter
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.HighlightText
        DataGridView1.Location = New Point(14, 484)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(829, 337)
        DataGridView1.TabIndex = 6
        ' 
        ' btnimprimir
        ' 
        btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), Image)
        btnimprimir.Location = New Point(635, 281)
        btnimprimir.Name = "btnimprimir"
        btnimprimir.Size = New Size(88, 76)
        btnimprimir.TabIndex = 7
        btnimprimir.Text = "Imprimir"
        btnimprimir.TextAlign = ContentAlignment.BottomCenter
        btnimprimir.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(408, 389)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(159, 28)
        ComboBox2.TabIndex = 18
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(702, 383)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(140, 28)
        ComboBox3.TabIndex = 18
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(105, 433)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(138, 28)
        ComboBox4.TabIndex = 18
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(408, 433)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(159, 28)
        ComboBox5.TabIndex = 18
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(702, 433)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(140, 28)
        ComboBox6.TabIndex = 18
        ' 
        ' Docente
        ' 
        Docente.AutoSize = True
        Docente.Font = New Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Docente.Location = New Point(600, 389)
        Docente.Name = "Docente"
        Docente.Size = New Size(84, 21)
        Docente.TabIndex = 19
        Docente.Text = "Docente"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(42, 435)
        Label11.Name = "Label11"
        Label11.Size = New Size(40, 21)
        Label11.TabIndex = 20
        Label11.Text = "Dia"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(323, 437)
        Label12.Name = "Label12"
        Label12.Size = New Size(52, 21)
        Label12.TabIndex = 21
        Label12.Text = "Hora"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(600, 437)
        Label13.Name = "Label13"
        Label13.Size = New Size(106, 21)
        Label13.TabIndex = 22
        Label13.Text = "Modalidad"
        ' 
        ' Matricula
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(856, 847)
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
        Controls.Add(btnimprimir)
        Controls.Add(DataGridView1)
        Controls.Add(btneliminar)
        Controls.Add(btnmodificar)
        Controls.Add(btnguardar)
        Controls.Add(btnnuevo)
        Controls.Add(btnatras)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "Matricula"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Matricula"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnatras As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnimprimir As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Docente As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
