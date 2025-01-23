Public Class Carreras
    Public a, total As Double

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Hide()
        PaginaPrincipal.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btncarrera.Click
        ListBox1.Items.Clear()
        If CheckBox1.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(0))

        End If

        If CheckBox2.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(1))

        End If

        If CheckBox3.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(2))

        End If


        If CheckBox4.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(3))


        End If


        If CheckBox5.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(4))

        End If


        If CheckBox6.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(5))

        End If


        If CheckBox7.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(6))

        End If


        If CheckBox8.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(7))

        End If


        If CheckBox9.Checked = True Then
            ListBox1.Items.Add(ListMenu.Items(8))

        End If



        If CheckBox10.Checked = True Then
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
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False

    End Sub
End Class