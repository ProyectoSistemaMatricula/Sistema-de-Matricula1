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
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnatras = New Button()
        btnnuevo = New Button()
        btnguardar = New Button()
        btnmodificar = New Button()
        btneliminar = New Button()
        DataGridView1 = New DataGridView()
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
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(15, 80)
        GroupBox1.Margin = New Padding(4, 4, 4, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 4, 4, 4)
        GroupBox1.Size = New Size(1010, 240)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Información del estudiante"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell", 10.2F)
        Label8.Location = New Point(24, 49)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(192, 23)
        Label8.TabIndex = 15
        Label8.Text = "Cod. Pre-Matricula"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 9F)
        TextBox7.Location = New Point(671, 42)
        TextBox7.Margin = New Padding(4, 4, 4, 4)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(330, 31)
        TextBox7.TabIndex = 14
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(249, 144)
        DateTimePicker1.Margin = New Padding(4, 4, 4, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(236, 31)
        DateTimePicker1.TabIndex = 13
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(179, 189)
        TextBox6.Margin = New Padding(4, 4, 4, 4)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(306, 35)
        TextBox6.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 9F)
        TextBox5.Location = New Point(632, 200)
        TextBox5.Margin = New Padding(4, 4, 4, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(369, 31)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 9F)
        TextBox4.Location = New Point(632, 142)
        TextBox4.Margin = New Padding(4, 4, 4, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(369, 31)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(179, 95)
        TextBox3.Margin = New Padding(4, 4, 4, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(306, 35)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 9F)
        TextBox2.Location = New Point(632, 95)
        TextBox2.Margin = New Padding(4, 4, 4, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(369, 31)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(229, 39)
        TextBox1.Margin = New Padding(4, 4, 4, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(256, 35)
        TextBox1.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 10.2F)
        Label7.Location = New Point(24, 195)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 23)
        Label7.TabIndex = 6
        Label7.Text = "Teléfono"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 10.2F)
        Label6.Location = New Point(510, 200)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 23)
        Label6.TabIndex = 5
        Label6.Text = "Dirección"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 10.2F)
        Label5.Location = New Point(24, 146)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(212, 23)
        Label5.TabIndex = 4
        Label5.Text = "Fecha de Nacimiento"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 10.2F)
        Label4.Location = New Point(510, 155)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 23)
        Label4.TabIndex = 3
        Label4.Text = "2°Apellido"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 10.2F)
        Label3.Location = New Point(24, 101)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 23)
        Label3.TabIndex = 2
        Label3.Text = "1°Apellido"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 10.2F)
        Label2.Location = New Point(510, 101)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 23)
        Label2.TabIndex = 1
        Label2.Text = "Nombres"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 10.2F)
        Label1.Location = New Point(510, 49)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 23)
        Label1.TabIndex = 0
        Label1.Text = "N° Documento"
        ' 
        ' btnatras
        ' 
        btnatras.Image = CType(resources.GetObject("btnatras.Image"), Image)
        btnatras.Location = New Point(937, 3)
        btnatras.Margin = New Padding(4, 4, 4, 4)
        btnatras.Name = "btnatras"
        btnatras.Size = New Size(88, 82)
        btnatras.TabIndex = 1
        btnatras.UseVisualStyleBackColor = True
        ' 
        ' btnnuevo
        ' 
        btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), Image)
        btnnuevo.ImageAlign = ContentAlignment.TopCenter
        btnnuevo.Location = New Point(275, 328)
        btnnuevo.Margin = New Padding(4, 4, 4, 4)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(118, 95)
        btnnuevo.TabIndex = 2
        btnnuevo.Text = "Nuevo"
        btnnuevo.TextAlign = ContentAlignment.BottomCenter
        btnnuevo.UseVisualStyleBackColor = True
        ' 
        ' btnguardar
        ' 
        btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), Image)
        btnguardar.ImageAlign = ContentAlignment.TopCenter
        btnguardar.Location = New Point(400, 328)
        btnguardar.Margin = New Padding(4, 4, 4, 4)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(118, 95)
        btnguardar.TabIndex = 3
        btnguardar.Text = "Guardar"
        btnguardar.TextAlign = ContentAlignment.BottomCenter
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' btnmodificar
        ' 
        btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), Image)
        btnmodificar.ImageAlign = ContentAlignment.TopCenter
        btnmodificar.Location = New Point(525, 328)
        btnmodificar.Margin = New Padding(4, 4, 4, 4)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(118, 95)
        btnmodificar.TabIndex = 4
        btnmodificar.Text = "Modificar"
        btnmodificar.TextAlign = ContentAlignment.BottomCenter
        btnmodificar.UseVisualStyleBackColor = True
        ' 
        ' btneliminar
        ' 
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.TopCenter
        btneliminar.Location = New Point(650, 328)
        btneliminar.Margin = New Padding(4, 4, 4, 4)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(118, 95)
        btneliminar.TabIndex = 5
        btneliminar.Text = "Eliminar"
        btneliminar.TextAlign = ContentAlignment.BottomCenter
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(39, 459)
        DataGridView1.Margin = New Padding(4, 4, 4, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(979, 424)
        DataGridView1.TabIndex = 6
        ' 
        ' Matricula
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1040, 921)
        Controls.Add(DataGridView1)
        Controls.Add(btneliminar)
        Controls.Add(btnmodificar)
        Controls.Add(btnguardar)
        Controls.Add(btnnuevo)
        Controls.Add(btnatras)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "Matricula"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Matricula"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
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
End Class
