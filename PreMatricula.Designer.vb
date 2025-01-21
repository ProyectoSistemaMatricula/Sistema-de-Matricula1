<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreMatricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreMatricula))
        Label1 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox7 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label7 = New Label()
        TextBox5 = New TextBox()
        Label9 = New Label()
        TextBox6 = New TextBox()
        btnnuevo = New Button()
        btnguardar = New Button()
        btnmodificar = New Button()
        btneliminar = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(311, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 31)
        Label1.TabIndex = 0
        Label1.Text = "PREMATRICULA"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell", 10.2F)
        Label8.Location = New Point(30, 104)
        Label8.Name = "Label8"
        Label8.Size = New Size(158, 20)
        Label8.TabIndex = 19
        Label8.Text = "Cod. Pre-Matricula"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(227, 104)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(206, 27)
        TextBox1.TabIndex = 20
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(173, 179)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(246, 27)
        TextBox3.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 10.2F)
        Label2.Location = New Point(39, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 20)
        Label2.TabIndex = 22
        Label2.Text = "Nombres"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 10.2F)
        Label5.Location = New Point(30, 248)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 20)
        Label5.TabIndex = 23
        Label5.Text = "Fecha de Nacimiento"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(255, 241)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(190, 27)
        DateTimePicker1.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 10.2F)
        Label3.Location = New Point(30, 323)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 20)
        Label3.TabIndex = 25
        Label3.Text = "Carrera"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(187, 323)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(246, 27)
        TextBox2.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 10.2F)
        Label4.Location = New Point(462, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 20)
        Label4.TabIndex = 27
        Label4.Text = "N° Documento"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 9F)
        TextBox7.Location = New Point(591, 104)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(229, 27)
        TextBox7.TabIndex = 28
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 10.2F)
        Label6.Location = New Point(462, 179)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 20)
        Label6.TabIndex = 29
        Label6.Text = "1°Apellido"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 9F)
        TextBox4.Location = New Point(576, 179)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(229, 27)
        TextBox4.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 10.2F)
        Label7.Location = New Point(473, 241)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 20)
        Label7.TabIndex = 31
        Label7.Text = "2°Apellido"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 9F)
        TextBox5.Location = New Point(571, 243)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(229, 27)
        TextBox5.TabIndex = 32
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 10.2F)
        Label9.Location = New Point(473, 326)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 20)
        Label9.TabIndex = 33
        Label9.Text = "Dirección"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 9F)
        TextBox6.Location = New Point(576, 320)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(229, 27)
        TextBox6.TabIndex = 34
        ' 
        ' btnnuevo
        ' 
        btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), Image)
        btnnuevo.ImageAlign = ContentAlignment.TopCenter
        btnnuevo.Location = New Point(164, 411)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(94, 76)
        btnnuevo.TabIndex = 35
        btnnuevo.Text = "Nuevo"
        btnnuevo.TextAlign = ContentAlignment.BottomCenter
        btnnuevo.UseVisualStyleBackColor = True
        ' 
        ' btnguardar
        ' 
        btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), Image)
        btnguardar.ImageAlign = ContentAlignment.TopCenter
        btnguardar.Location = New Point(298, 411)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(94, 76)
        btnguardar.TabIndex = 36
        btnguardar.Text = "Guardar"
        btnguardar.TextAlign = ContentAlignment.BottomCenter
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' btnmodificar
        ' 
        btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), Image)
        btnmodificar.ImageAlign = ContentAlignment.TopCenter
        btnmodificar.Location = New Point(417, 411)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(94, 76)
        btnmodificar.TabIndex = 37
        btnmodificar.Text = "Modificar"
        btnmodificar.TextAlign = ContentAlignment.BottomCenter
        btnmodificar.UseVisualStyleBackColor = True
        ' 
        ' btneliminar
        ' 
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.TopCenter
        btneliminar.Location = New Point(554, 411)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(94, 76)
        btneliminar.TabIndex = 38
        btneliminar.Text = "Eliminar"
        btneliminar.TextAlign = ContentAlignment.BottomCenter
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ActiveBorder
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.HighlightText
        DataGridView1.Location = New Point(62, 507)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(706, 246)
        DataGridView1.TabIndex = 39
        ' 
        ' PreMatricula
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(832, 786)
        Controls.Add(DataGridView1)
        Controls.Add(btneliminar)
        Controls.Add(btnmodificar)
        Controls.Add(btnguardar)
        Controls.Add(btnnuevo)
        Controls.Add(TextBox6)
        Controls.Add(Label9)
        Controls.Add(TextBox5)
        Controls.Add(Label7)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(TextBox7)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PreMatricula"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
