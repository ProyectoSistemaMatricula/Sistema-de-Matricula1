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
        DateTimePicker1 = New DateTimePicker()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label14 = New Label()
        Label1 = New Label()
        btnatras = New Button()
        DataGridView1 = New DataGridView()
        btnimprimir = New Button()
        btneliminar = New Button()
        btnmodificar = New Button()
        btnguardar = New Button()
        btnnuevo = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(441, 274)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(197, 27)
        DateTimePicker1.TabIndex = 113
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(441, 181)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(197, 27)
        TextBox3.TabIndex = 109
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 9F)
        TextBox2.Location = New Point(441, 226)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(197, 27)
        TextBox2.TabIndex = 108
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(441, 132)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(197, 27)
        TextBox1.TabIndex = 107
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Rockwell", 10.2F)
        Label5.Location = New Point(262, 277)
        Label5.Name = "Label5"
        Label5.Size = New Size(167, 20)
        Label5.TabIndex = 104
        Label5.Text = "Fecha Pre-Matrícula"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Rockwell", 10.2F)
        Label3.Location = New Point(262, 233)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 102
        Label3.Text = "Id Carrera"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 10.2F)
        Label2.Location = New Point(262, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 20)
        Label2.TabIndex = 101
        Label2.Text = "Id Estudiante"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Rockwell", 10.2F)
        Label14.Location = New Point(262, 139)
        Label14.Name = "Label14"
        Label14.Size = New Size(135, 20)
        Label14.TabIndex = 99
        Label14.Text = "Id Pre-Matricula"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(311, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 46)
        Label1.TabIndex = 115
        Label1.Text = "Prematrícula"
        ' 
        ' btnatras
        ' 
        btnatras.BackColor = Color.White
        btnatras.Image = CType(resources.GetObject("btnatras.Image"), Image)
        btnatras.Location = New Point(740, 35)
        btnatras.Name = "btnatras"
        btnatras.Size = New Size(70, 67)
        btnatras.TabIndex = 116
        btnatras.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.HighlightText
        DataGridView1.Location = New Point(161, 362)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(609, 337)
        DataGridView1.TabIndex = 118
        ' 
        ' btnimprimir
        ' 
        btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), Image)
        btnimprimir.Location = New Point(20, 702)
        btnimprimir.Name = "btnimprimir"
        btnimprimir.Size = New Size(86, 76)
        btnimprimir.TabIndex = 125
        btnimprimir.Text = "Imprimir"
        btnimprimir.TextAlign = ContentAlignment.BottomCenter
        btnimprimir.UseVisualStyleBackColor = True
        ' 
        ' btneliminar
        ' 
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.TopCenter
        btneliminar.Location = New Point(20, 561)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(86, 76)
        btneliminar.TabIndex = 122
        btneliminar.Text = "Eliminar"
        btneliminar.TextAlign = ContentAlignment.BottomCenter
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' btnmodificar
        ' 
        btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), Image)
        btnmodificar.ImageAlign = ContentAlignment.TopCenter
        btnmodificar.Location = New Point(20, 419)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(86, 76)
        btnmodificar.TabIndex = 121
        btnmodificar.Text = "Modificar"
        btnmodificar.TextAlign = ContentAlignment.BottomCenter
        btnmodificar.UseVisualStyleBackColor = True
        ' 
        ' btnguardar
        ' 
        btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), Image)
        btnguardar.ImageAlign = ContentAlignment.TopCenter
        btnguardar.Location = New Point(20, 283)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(86, 76)
        btnguardar.TabIndex = 120
        btnguardar.Text = "Guardar"
        btnguardar.TextAlign = ContentAlignment.BottomCenter
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' btnnuevo
        ' 
        btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), Image)
        btnnuevo.ImageAlign = ContentAlignment.TopCenter
        btnnuevo.Location = New Point(20, 139)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(86, 78)
        btnnuevo.TabIndex = 119
        btnnuevo.Text = "Nuevo"
        btnnuevo.TextAlign = ContentAlignment.BottomCenter
        btnnuevo.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(32, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(63, 55)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 124
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(119, 847)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 123
        PictureBox2.TabStop = False
        ' 
        ' PreMatricula
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(832, 786)
        Controls.Add(btnimprimir)
        Controls.Add(btneliminar)
        Controls.Add(btnmodificar)
        Controls.Add(btnguardar)
        Controls.Add(btnnuevo)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(DataGridView1)
        Controls.Add(btnatras)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label14)
        FormBorderStyle = FormBorderStyle.None
        Name = "PreMatricula"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnatras As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnimprimir As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
