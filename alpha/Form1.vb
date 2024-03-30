Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PLAYBUTTON_Click(sender As Object, e As EventArgs) Handles PLAYBUTTON.Click
        Dim newForm As New Form2 ' Replace Form2 with the actual form class name
        newForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newForm As New Form3 ' Replace Form3 with the actual form class name
        newForm.Show()
    End Sub
End Class
