
Imports Microsoft.Data.SqlClient


Public Class PaginaPrincipal

    Dim conexion As New SqlConnection("Data Source=DEB\SQLEXPRESS;Initial Catalog=SISTEMA_MATRICULA1;Integrated Security=True;")



    Private Sub btnprematricula_Click(sender As Object, e As EventArgs) Handles btnprematricula.Click
        PreMatricula.Show()
        Me.Hide()
    End Sub

    Private Sub btnmatricula_Click(sender As Object, e As EventArgs) Handles btnmatricula.Click
        Matricula.Show()
        Hide()
    End Sub

    Private Sub btnestudiantes_Click(sender As Object, e As EventArgs) Handles btnestudiantes.Click
        Estudiantes.Show()
        Me.Hide()
    End Sub

    Private Sub btncarreras_Click(sender As Object, e As EventArgs) Handles btncarreras.Click
        Carrera.Show()
        Me.Hide()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub PaginaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class