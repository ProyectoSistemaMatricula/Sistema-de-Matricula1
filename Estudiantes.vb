﻿

Public Class Estudiantes


    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Hide()
        PaginaPrincipal.Show()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

    End Sub

    Private Sub Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtidentidadestu.Clear()
        txtnombresestu.Clear()
        txtapellidosestu.Clear()
        txtcorreoestu.Clear()
        txtedadestu.Clear()
        txtidcarreraestu.Clear()
    End Sub
End Class