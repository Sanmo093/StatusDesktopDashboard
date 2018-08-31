
Public Class Form1
    Dim MyOBJ As Object
    Dim cpu As Object
    Dim RamKomplett As Double
    Dim RamVerf As Double
    Dim Line
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Me.Location = New Point(My.Computer.Screen.WorkingArea.Size.Width - 375, 0)

            Timer1.Start()

            Label16.Text = My.Computer.Screen.WorkingArea.Size.Width & " X " & My.Computer.Screen.WorkingArea.Size.Height

            Label2.Text = My.Computer.Name
            MyOBJ = GetObject("WinMgmts:").instancesof("Win32_Processor")
            For Each cpu In MyOBJ
                Label7.Text = cpu.Name.ToString + " " + cpu.CurrentClockSpeed.ToString + " Mhz"

            Next
            Label9.Text = My.Computer.Info.OSFullName & " (" & My.Computer.Info.OSVersion & ")"
            Label10.Text = My.User.Name
            Label13.Text = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.GetValue(3).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim Result As Net.NetworkInformation.PingReply
            Dim SendPing As New Net.NetworkInformation.Ping
            Dim ResponseTime As Long
            Try
                Result = SendPing.Send("www.google.de")
                ResponseTime = Result.RoundtripTime
                If Result.Status = Net.NetworkInformation.IPStatus.Success Then
                    Label1.Text = (ResponseTime.ToString) & "ms"
                Else
                    Label1.Text = ""
                End If
            Catch ex As Exception
            End Try
            RamKomplett = My.Computer.Info.TotalPhysicalMemory / (1024 ^ 3)
            RamVerf = My.Computer.Info.AvailablePhysicalMemory / (1024 ^ 3)
            Label8.Text = RamKomplett.ToString("0.00") & " GB" & " (" & RamVerf.ToString("0.00") & " GB Frei)"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        settings.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form2.Show()
    End Sub
End Class
