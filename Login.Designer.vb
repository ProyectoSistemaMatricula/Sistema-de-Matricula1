<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        txtuser = New TextBox()
        txtcontra = New TextBox()
        btnentrar = New Button()
        btnsalir = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(261, 41)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 106)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(113, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 23)
        Label1.TabIndex = 1
        Label1.Text = "USUARIO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(113, 253)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 23)
        Label2.TabIndex = 2
        Label2.Text = "CONTRASEÑA"
        ' 
        ' txtuser
        ' 
        txtuser.Location = New Point(273, 178)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(194, 27)
        txtuser.TabIndex = 3
        ' 
        ' txtcontra
        ' 
        txtcontra.Location = New Point(273, 249)
        txtcontra.Name = "txtcontra"
        txtcontra.PasswordChar = "*"c
        txtcontra.Size = New Size(194, 27)
        txtcontra.TabIndex = 4
        ' 
        ' btnentrar
        ' 
        btnentrar.Image = CType(resources.GetObject("btnentrar.Image"), Image)
        btnentrar.Location = New Point(154, 336)
        btnentrar.Name = "btnentrar"
        btnentrar.Size = New Size(94, 62)
        btnentrar.TabIndex = 5
        btnentrar.UseVisualStyleBackColor = True
        ' 
        ' btnsalir
        ' 
        btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), Image)
        btnsalir.Location = New Point(321, 336)
        btnsalir.Name = "btnsalir"
        btnsalir.Size = New Size(94, 62)
        btnsalir.TabIndex = 6
        btnsalir.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(618, 447)
        Controls.Add(btnsalir)
        Controls.Add(btnentrar)
        Controls.Add(txtcontra)
        Controls.Add(txtuser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtcontra As TextBox
    Friend WithEvents btnentrar As Button
    Friend WithEvents btnsalir As Button

End Class
