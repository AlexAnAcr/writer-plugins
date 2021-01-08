Public Class Newing
    Dim newing As Boolean = False
    Dim otvet As Boolean = True
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Button1.Enabled = False
        newing = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim network As Boolean = My.Computer.Network.IsAvailable
        If ProgressBar1.Value = 40 And network = True Then
            Timer1.Enabled = False
            Dim dat1 As Integer = DateTime.Today.Month
            If DateTime.Today.Month = 12 Then
                dat1 = 1
            Else
                dat1 += 1
            End If
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "/dat.dat", dat1, False)
            MsgBox("Renovation end success!", , "Messenge")
            newing = False
            Me.Close()
        ElseIf network = False Then
            If otvet = True Then
                otvet = False
                Dim result As MsgBoxResult = MsgBox("No connection with internet!" & Chr(10) & "Repeat the attempt of the installing the connection?", MsgBoxStyle.YesNo, "Messenge")
                If result = 6 Then
                    Timer1.Interval = 5000
                    otvet = True
                Else
                    Timer1.Enabled = False
                    ProgressBar1.Value = 0
                    Button1.Enabled = True
                    newing = False
                    otvet = True
                End If
            End If
        Else
            Dim random As New Random()
            Dim dat As Integer = random.Next(500, 30000)
            Timer1.Interval = dat
            ProgressBar1.Increment(1)
        End If
    End Sub
    Private Sub CopuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopuToolStripMenuItem.Click
        If TextBox1.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(TextBox1.SelectedText)
        Else
            My.Computer.Clipboard.SetText(" ")
        End If
    End Sub
    Private Sub Newing_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim result As MsgBoxResult
        If newing = True Then
            result = MsgBox("The Renovation is not terminated!" & Chr(10) & "Stop the renovation?", MsgBoxStyle.YesNo, "Messenge")
            If result = 6 Then
                Timer1.Enabled = False
                ProgressBar1.Value = 0
                Button1.Enabled = True
                newing = False
                e.Cancel = True
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub Newing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim text1(3) As String
        Dim random As New Random()
        Dim random_result As Integer = random.Next(0, 10)
        Dim i_1 As Integer = 0
        For i As Integer = 0 To random.Next(2, 5) - 1
            If random_result = 0 Then
                text1(i) = "Will Added new possibilities: now works any combination of the keywords."
            ElseIf random_result = 1 Then
                text1(i) = "They Are Added exporting modules."
            ElseIf random_result = 2 Then
                text1(i) = "Will Added new functions: now plugin can add coments on site Micsrosoft"
            ElseIf random_result = 3 Then
                text1(i) = "Will Added new possibilities plugin: possible access to roll."
            ElseIf random_result = 4 Then
                text1(i) = "They Are Changed some standards to export: now plugin, export 2-ym way, are fixed on computer immediately."
            ElseIf random_result = 5 Then
                text1(i) = "The pay renovations left For this program. Automatically are fixed only free. Visit our site for their installation."
            ElseIf random_result = 6 Then
                text1(i) = "Now program installs plugin in several places on windows."
            ElseIf random_result = 7 Then
                text1(i) = "Plaginy to gain access to safety system windows."
            ElseIf random_result = 8 Then
                text1(i) = "The Added access to playing server."
            ElseIf random_result = 9 Then
                text1(i) = "Plaginy will be able to work in office."
            End If
            If random_result = 9 Then
                random_result = 0
            Else
                random_result += 1
            End If
            i_1 += 1
        Next
        Array.Resize(text1, i_1)
        TextBox1.Lines = text1
    End Sub
End Class