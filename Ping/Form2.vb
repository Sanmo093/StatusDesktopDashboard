Imports System.ComponentModel

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setp()
    End Sub



    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        setp()
    End Sub

    Public Sub setp()

        Dim Process As New Process()
        Dim Count As Integer = 0
        ListBox1.Items.Clear()
        For Each Process In Process.GetProcesses(My.Computer.Name)
            On Error Resume Next
            ListBox1.Items.Add(Process.ProcessName)

            Count += 1
        Next
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click

    End Sub
End Class