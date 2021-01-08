Public Class Filecontrol
    Dim result As DialogResult
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        result = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            ListBox1.Items.Add(OpenFileDialog1.FileName)
            Form1.ListBox1.Items.Add(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex <> -1 Then
            Form1.ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class