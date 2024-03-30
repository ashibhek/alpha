Imports System.IO

Public Class Form2

    Private letterIndex As Integer = 0
    Private letters As String()
    Private imagesFolder As String = "C:\Users\hp\Desktop\sem4\alphabets"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim letters(25) ' Allocate memory for 26 characters
        For i As Integer = 0 To 25
            letters(i) = Chr(i + 65) ' Assign characters (A-Z) using their ASCII codes
        Next
        UpdateLetterDisplay()
    End Sub

    Private Sub UpdateLetterDisplay()
        Label1.Text = letters(letterIndex)
        Label3.Text = letters(letterIndex)
        Try
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom ' Set SizeMode to Zoom
            ' in the below line you can change the image from jpg to png and vice versa
            PictureBox1.Image = Image.FromFile(Path.Combine(imagesFolder, letters(letterIndex) + ".png")) ' Assuming JPG format
        Catch ex As Exception
            ' Handle potential image loading errors (e.g., display a default image)
            PictureBox1.Image = Nothing
        End Try
    End Sub

    Private Sub LButton_Click(sender As Object, e As EventArgs) Handles LButton.Click
        letterIndex -= 1
        If letterIndex < 0 Then
            letterIndex = letters.Length - 1 ' Loop back to the end
        End If
        UpdateLetterDisplay()
    End Sub

    Private Sub RButton_Click(sender As Object, e As EventArgs) Handles RButton.Click
        letterIndex += 1
        If letterIndex >= letters.Length Then
            letterIndex = 0 ' Loop back to the beginning
        End If
        UpdateLetterDisplay()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()  ' Hide the current form
        Form1.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
