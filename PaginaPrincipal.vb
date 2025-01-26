
Public Class PaginaPrincipal
    Private Sub btnprematricula_Click(sender As Object, e As EventArgs) Handles btnprematricula.Click
        PreMatricula.Show()
        Me.Hide()
    End Sub

    Private Sub btnmatricula_Click(sender As Object, e As EventArgs) Handles btnmatricula.Click, Button1.Click
        Matricula.Show
        Hide
    End Sub

    Private Sub btnestudiantes_Click(sender As Object, e As EventArgs) Handles btnestudiantes.Click
        Estudiantes.Show()
        Me.Hide()
    End Sub

    Private Sub btncarreras_Click(sender As Object, e As EventArgs) Handles btncarreras.Click
        Carreras.Show()
        Me.Hide()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub


End Class