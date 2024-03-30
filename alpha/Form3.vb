
Imports System.IO

Public Class Form3

    Private numberIndex As Integer = 0
    Private numbers As String() = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"}
    Private imagesFolder As String = "C:\Users\hp\Desktop\sem4\numbers"  ' Replace with your images folder

    Public Property ImagesFolder1 As String
        Get
            Return imagesFolder
        End Get
        Set(value As String)
            imagesFolder = value
        End Set
    End Property

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateNumberDisplay()
    End Sub

    Private Sub UpdateNumberDisplay()
        Label2.Text = numbers(numberIndex)
        Label4.Text = numbers(numberIndex)
        Try
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom  ' Set SizeMode to Zoom
            PictureBox1.Image = Image.FromFile(Path.Combine(ImagesFolder1, numbers(numberIndex) + ".jpg")) ' Assuming PNG format
        Catch ex As Exception
            ' Handle potential image loading errors (e.g., display a default image)
            PictureBox1.Image = Nothing
        End Try
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        numberIndex += 1
        If numberIndex >= numbers.Length Then
            numberIndex = 0 ' Loop back to the beginning
        End If
        UpdateNumberDisplay()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()  ' Hide the current form
        Form1.Show()  ' Show the first form
    End Sub

    Private Sub LButton_Click(sender As Object, e As EventArgs) Handles LButton.Click
        numberIndex -= 1
        If numberIndex < 0 Then
            numberIndex = numbers.Length - 1 ' Loop back to the end
        End If
        UpdateNumberDisplay()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class