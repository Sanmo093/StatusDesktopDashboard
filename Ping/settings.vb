Imports System.ComponentModel

Public Class settings
    Dim PingUrlObj As Object

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()

    End Sub

    Private Sub settings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PingUrlObj = TextBox1.Text.ToString



    End Sub
End Class