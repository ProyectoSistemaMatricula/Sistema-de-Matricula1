<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaginaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaginaPrincipal))
        btnprematricula = New Button()
        btnmatricula = New Button()
        btnestudiantes = New Button()
        btncarreras = New Button()
        PictureBox1 = New PictureBox()
        btnsalir = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnprematricula
        ' 
        btnprematricula.BackColor = Color.Transparent
        btnprematricula.FlatAppearance.BorderSize = 0
        btnprematricula.FlatStyle = FlatStyle.Flat
        btnprematricula.Image = CType(resources.GetObject("btnprematricula.Image"), Image)
        btnprematricula.Location = New Point(61, 225)
        btnprematricula.Name = "btnprematricula"
        btnprematricula.Size = New Size(172, 157)
        btnprematricula.TabIndex = 0
        btnprematricula.UseVisualStyleBackColor = False
        ' 
        ' btnmatricula
        ' 
        btnmatricula.BackColor = Color.Transparent
        btnmatricula.FlatAppearance.BorderSize = 0
        btnmatricula.FlatStyle = FlatStyle.Flat
        btnmatricula.Image = CType(resources.GetObject("btnmatricula.Image"), Image)
        btnmatricula.Location = New Point(338, 225)
        btnmatricula.Name = "btnmatricula"
        btnmatricula.Size = New Size(172, 157)
        btnmatricula.TabIndex = 1
        btnmatricula.UseVisualStyleBackColor = False
        ' 
        ' btnestudiantes
        ' 
        btnestudiantes.BackColor = Color.Transparent
        btnestudiantes.FlatAppearance.BorderSize = 0
        btnestudiantes.FlatStyle = FlatStyle.Flat
        btnestudiantes.Image = CType(resources.GetObject("btnestudiantes.Image"), Image)
        btnestudiantes.Location = New Point(608, 225)
        btnestudiantes.Name = "btnestudiantes"
        btnestudiantes.Size = New Size(172, 157)
        btnestudiantes.TabIndex = 2
        btnestudiantes.UseVisualStyleBackColor = False
        ' 
        ' btncarreras
        ' 
        btncarreras.BackColor = Color.Transparent
        btncarreras.FlatAppearance.BorderSize = 0
        btncarreras.FlatStyle = FlatStyle.Flat
        btncarreras.Image = CType(resources.GetObject("btncarreras.Image"), Image)
        btncarreras.Location = New Point(338, 422)
        btncarreras.Name = "btncarreras"
        btncarreras.Size = New Size(172, 169)
        btncarreras.TabIndex = 3
        btncarreras.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(61, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(138, 142)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnsalir
        ' 
        btnsalir.BackColor = Color.Transparent
        btnsalir.FlatAppearance.BorderSize = 0
        btnsalir.FlatStyle = FlatStyle.Flat
        btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), Image)
        btnsalir.Location = New Point(756, 12)
        btnsalir.Name = "btnsalir"
        btnsalir.Size = New Size(64, 62)
        btnsalir.TabIndex = 6
        btnsalir.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(265, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(421, 46)
        Label1.TabIndex = 7
        Label1.Text = "SISTEMA DE MATRÍCULA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Stencil", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(407, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 52)
        Label2.TabIndex = 8
        Label2.Text = "2025"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(76, 392)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 23)
        Label3.TabIndex = 9
        Label3.Text = "PRE-MATRÍCULA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(367, 392)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 23)
        Label4.TabIndex = 10
        Label4.Text = "MATRÍCULA"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label5.Location = New Point(638, 392)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 23)
        Label5.TabIndex = 11
        Label5.Text = "ESTUDIANTES"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label6.Location = New Point(377, 594)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 23)
        Label6.TabIndex = 12
        Label6.Text = "CARRERAS"
        ' 
        ' PaginaPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(832, 626)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnsalir)
        Controls.Add(PictureBox1)
        Controls.Add(btncarreras)
        Controls.Add(btnestudiantes)
        Controls.Add(btnmatricula)
        Controls.Add(btnprematricula)
        FormBorderStyle = FormBorderStyle.None
        Name = "PaginaPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PaginaPrincipal"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnprematricula As Button
    Friend WithEvents btnmatricula As Button
    Friend WithEvents btnestudiantes As Button
    Friend WithEvents btncarreras As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
