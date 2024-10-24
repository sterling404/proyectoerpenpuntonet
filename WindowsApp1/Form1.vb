Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.alumno' Puede moverla o quitarla según sea necesario.
        Me.AlumnoTableAdapter.Fill(Me.DataSet1.alumno)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.alumno' Puede moverla o quitarla según sea necesario.
        'Me.AlumnoTableAdapter.Fill(Me.DataSet1.alumno)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.AlumnoTableAdapter.Delete2(1)
        'Me.AlumnoTableAdapter.Fill(Me.DataSet1.alumno)
        Me.AlumnoTableAdapter.Fill(Me.DataSet1.alumno)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.AlumnoTableAdapter.Insertalumno(1, "SEBASTIAN")
        'Me.AlumnoTableAdapter.Fill(Me.DataSet1.alumno)
        Me.AlumnoTableAdapter.Fill(Me.DataSet1.alumno)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.AlumnoTableAdapter.UpdateQuery("matias", 1)
        'Me.AlumnoTableAdapter.Fill(Me.DataSet1.alumno)
        Me.AlumnoTableAdapter.Fill(Me.DataSet1.alumno)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
