Public Class Form1
    Private Sub Logo_Click(sender As Object, e As EventArgs) Handles Logo.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 5000 ' Establecer el intervalo del timer a 5000 milisegundos (5 segundos)
        Timer1.Enabled = True ' Habilitar el timer
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False ' Deshabilitar el timer
        Me.Hide() ' Ocultar el formulario actual
        Dim form2 As New Form2 ' Crear una instancia del formulario siguiente
        form2.Show() ' Mostrar el formulario siguiente
    End Sub
End Class
