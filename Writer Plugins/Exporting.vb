Public Class Exporting
    Public text1 As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Dialog1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim plugin(IO.File.ReadAllLines(text1).Length + 2) As String
        ProgressBar1.Value = 0
        plugin(0) = "[sustem]"
        plugin(1) = "language = WinPiugin"
        Dim i_s As Integer = 0
        For Each i As String In IO.File.ReadAllLines(text1)
            For i_1 As Integer = 0 To i.Length
                Dim random1 As New Random()
                Dim dat As Integer = 1
                For i_2 As Integer = 0 To random1.Next(0, 10)
                    Dim random As New Random()
                    Dim text As Integer = random.Next(0, 30)
                    If dat = 1 Then
                        text += 1
                        dat += 1
                    ElseIf dat = 2 Then
                        text -= 1
                        dat += 1
                    ElseIf dat = 3 Then
                        text = text * 2
                        dat += 1
                    ElseIf dat = 4 Then
                        text = text * 3
                        dat = 1
                    End If
                    If text = 26 Or text = 27 Or text = 28 Or text = 29 Then
                        plugin(i_s + 2) &= " "
                    ElseIf text = 0 Then
                        plugin(i_s + 2) &= "adfgd"
                    ElseIf text = 1 Then
                        plugin(i_s + 2) &= "bfuiu"
                    ElseIf text = 2 Then
                        plugin(i_s + 2) &= "cufffhjg"
                    ElseIf text = 3 Then
                        plugin(i_s + 2) &= "dddjgj"
                    ElseIf text = 4 Then
                        plugin(i_s + 2) &= "iyiyityy"
                    ElseIf text = 5 Then
                        plugin(i_s + 2) &= "ftrerw"
                    ElseIf text = 6 Then
                        plugin(i_s + 2) &= "gjik;"
                    ElseIf text = 7 Then
                        plugin(i_s + 2) &= "htyyyj"
                    ElseIf text = 8 Then
                        plugin(i_s + 2) &= "ithipo"
                    ElseIf text = 9 Then
                        plugin(i_s + 2) &= "gghfeq"
                    ElseIf text = 10 Then
                        plugin(i_s + 2) &= "kgjo"
                    ElseIf text = 11 Then
                        plugin(i_s + 2) &= "lryeryr"
                    ElseIf text = 12 Then
                        plugin(i_s + 2) &= "mtry"
                    ElseIf text = 13 Then
                        plugin(i_s + 2) &= "ntrrewe"
                    ElseIf text = 14 Then
                        plugin(i_s + 2) &= "oewyuyui"
                    ElseIf text = 15 Then
                        plugin(i_s + 2) &= "ptryuyeyr"
                    ElseIf text = 16 Then
                        plugin(i_s + 2) &= "qreyy"
                    ElseIf text = 17 Then
                        plugin(i_s + 2) &= "etryryr"
                    ElseIf text = 18 Then
                        plugin(i_s + 2) &= "sryteuttu"
                    ElseIf text = 19 Then
                        plugin(i_s + 2) &= "trtutu"
                    ElseIf text = 20 Then
                        plugin(i_s + 2) &= "utuyii"
                    ElseIf text = 21 Then
                        plugin(i_s + 2) &= "vrtyuyiy"
                    ElseIf text = 22 Then
                        plugin(i_s + 2) &= "wrerw"
                    ElseIf text = 23 Then
                        plugin(i_s + 2) &= "xoipk"
                    ElseIf text = 24 Then
                        plugin(i_s + 2) &= "yew"
                    ElseIf text = 25 Then
                        plugin(i_s + 2) &= "zetyuth"
                    End If
                Next
            Next
            i_s += 1
            If 0 = Math.IEEERemainder(i_s, Math.Floor(i_s / 100)) Then
                ProgressBar1.Increment(1)
            End If
        Next
            ProgressBar1.Value = 100
            IO.File.WriteAllLines(text1, plugin)
            MsgBox("Export end success!", , "Messenge")
            Me.Close()
    End Sub
End Class
