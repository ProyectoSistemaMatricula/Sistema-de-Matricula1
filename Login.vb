Public Class Login
    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click
        Dim usuario, password As String
        usuario = txtuser.Text
        password = txtcontra.Text
        If (usuario = "Proyecto") And (password = "12345") Then
            Dim Paginaprincipal As New PaginaPrincipal()
            Paginaprincipal.Show()
            Me.Hide()
        Else
            MsgBox("Los datos son incorrectos, por favor inténtelo de nuevo.")
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
