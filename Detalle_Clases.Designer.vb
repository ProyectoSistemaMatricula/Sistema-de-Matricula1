<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle_Clases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detalle_Clases))
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        btneliminar = New Button()
        btnguardar = New Button()
        PictureBox2 = New PictureBox()
        btnmodificar = New Button()
        Label1 = New Label()
        btnatras = New Button()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(364, 151)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(268, 27)
        TextBox3.TabIndex = 97
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(364, 184)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(268, 27)
        TextBox2.TabIndex = 96
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(364, 118)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(268, 27)
        TextBox1.TabIndex = 95
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Rockwell", 10.2F)
        Label4.Location = New Point(166, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 20)
        Label4.TabIndex = 94
        Label4.Text = "Horario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Rockwell", 10.2F)
        Label3.Location = New Point(166, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 93
        Label3.Text = "Id Clase"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 10.2F)
        Label2.Location = New Point(166, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 20)
        Label2.TabIndex = 92
        Label2.Text = "Id Detalle de clase"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(11, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(74, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 101
        PictureBox1.TabStop = False
        ' 
        ' btneliminar
        ' 
        btneliminar.BackColor = Color.Transparent
        btneliminar.FlatAppearance.BorderSize = 0
        btneliminar.FlatStyle = FlatStyle.Flat
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.TopCenter
        btneliminar.Location = New Point(10, 528)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(75, 81)
        btneliminar.TabIndex = 100
        btneliminar.Text = "Eliminar"
        btneliminar.TextAlign = ContentAlignment.BottomCenter
        btneliminar.UseVisualStyleBackColor = False
        ' 
        ' btnguardar
        ' 
        btnguardar.BackColor = Color.Transparent
        btnguardar.FlatAppearance.BorderSize = 0
        btnguardar.FlatStyle = FlatStyle.Flat
        btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), Image)
        btnguardar.ImageAlign = ContentAlignment.TopCenter
        btnguardar.Location = New Point(10, 158)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(75, 81)
        btnguardar.TabIndex = 98
        btnguardar.Text = "Guardar"
        btnguardar.TextAlign = ContentAlignment.BottomCenter
        btnguardar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-1, -1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(96, 851)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 102
        PictureBox2.TabStop = False
        ' 
        ' btnmodificar
        ' 
        btnmodificar.BackColor = Color.Transparent
        btnmodificar.FlatAppearance.BorderSize = 0
        btnmodificar.FlatStyle = FlatStyle.Flat
        btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), Image)
        btnmodificar.ImageAlign = ContentAlignment.TopCenter
        btnmodificar.Location = New Point(2, 359)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(86, 76)
        btnmodificar.TabIndex = 106
        btnmodificar.Text = "Modificar"
        btnmodificar.TextAlign = ContentAlignment.BottomCenter
        btnmodificar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(256, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(376, 46)
        Label1.TabIndex = 108
        Label1.Text = "Detalles de la clase"
        ' 
        ' btnatras
        ' 
        btnatras.BackColor = Color.Transparent
        btnatras.FlatAppearance.BorderSize = 0
        btnatras.FlatStyle = FlatStyle.Flat
        btnatras.Image = CType(resources.GetObject("btnatras.Image"), Image)
        btnatras.Location = New Point(780, 12)
        btnatras.Name = "btnatras"
        btnatras.Size = New Size(64, 65)
        btnatras.TabIndex = 107
        btnatras.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(364, 223)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(268, 27)
        TextBox4.TabIndex = 112
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(364, 257)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(268, 27)
        TextBox5.TabIndex = 111
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Rockwell", 10.2F)
        Label5.Location = New Point(166, 264)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 20)
        Label5.TabIndex = 110
        Label5.Text = "Modalidad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Rockwell", 10.2F)
        Label6.Location = New Point(166, 230)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 20)
        Label6.TabIndex = 109
        Label6.Text = "Docente"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(113, 334)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(731, 478)
        DataGridView1.TabIndex = 113
        ' 
        ' Detalle_Clases
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(856, 847)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(btnatras)
        Controls.Add(btnmodificar)
        Controls.Add(PictureBox1)
        Controls.Add(btneliminar)
        Controls.Add(btnguardar)
        Controls.Add(PictureBox2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Detalle_Clases"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Detalle_Clases"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnatras As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
