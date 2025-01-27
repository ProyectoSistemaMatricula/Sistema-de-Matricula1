Public Class Carreras
    Public a, total As Double

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Hide()
        PaginaPrincipal.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ListBox1.Items.Clear
        If Chbsistemas.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(0))

        End If

        If Chbmedicina.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(1))

        End If

        If Chbderecho.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(2))

        End If


        If Chbpsicologia.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(3))


        End If


        If Chbarquitectura.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(4))

        End If


        If Chbadministracion.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(5))

        End If


        If Chbdiseño.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(6))

        End If


        If Chbcontaduria.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(7))

        End If


        If Chbindustrial.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(8))

        End If



        If Chbcomunicacion.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(9))

        End If

        If CheckBox11.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(10))

        End If




    End Sub

    Private Sub ListMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListMenu.SelectedIndexChanged

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        total = 0
        ListBox1.Items.Clear()
        Chbsistemas.Checked = False
        Chbmedicina.Checked = False
        Chbderecho.Checked = False
        Chbpsicologia.Checked = False
        Chbarquitectura.Checked = False
        Chbadministracion.Checked = False
        Chbdiseño.Checked = False
        Chbcontaduria.Checked = False
        Chbindustrial.Checked = False
        Chbcomunicacion.Checked = False
        CheckBox11.Checked = False

    End Sub
End Class