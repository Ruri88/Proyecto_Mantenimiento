Public Class Form3
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Form2.Show() ' Mostrar el formulario anterior
        Close() ' Ocultar el formulario actual
    End Sub
End Class