Public Class Form2
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Logo.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formNuevo As New Form3()
        Form3.Show()
        Close() ' Ocultar el formulario actual
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Logo_Click(sender As Object, e As EventArgs) Handles Logo.Click

    End Sub
End Class