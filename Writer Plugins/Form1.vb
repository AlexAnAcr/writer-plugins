Public Class Form1
    Public dat() As String
    Dim file As String = ""
    Dim file_way As String = ""
    Dim dat_s As String = ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        file = "New progekt.wp"
        Text = "[New progekt] - Plugin Writer"
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/position.dat") Then
            dat = IO.File.ReadAllLines(Application.StartupPath + "/position.dat")
            If dat(4) = True Then
                Left = dat(0)
                Top = dat(1)
            End If
            If dat(5) = True Then
                Width = dat(2)
                Height = dat(3)
            End If
            If dat(6) = True Then
                SplitContainer1.SplitterDistance = dat(7)
            End If
            If dat(8) = True Then
                Timer1.Enabled = True
                Timer1.Interval = dat(9) * 30000
                Saving.NumericUpDown1.Value = dat(9)
            End If
            Position.CheckBox1.Checked = dat(4)
            Position.CheckBox2.Checked = dat(5)
            Position.CheckBox3.Checked = dat(6)
            Saving.CheckBox1.Checked = dat(8)
        Else
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "/position.dat", "", False)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "/data.dat", "", False)
            Dim dat1 As Integer
            If DateTime.Today.Month = 12 Then
                dat1 = 1
            Else
                dat1 += 1
            End If
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "/dat.dat", dat1, False)
            Array.Resize(dat, 10)
            dat(0) = 200
            dat(1) = 200
            dat(2) = 670
            dat(3) = 510
            Position.CheckBox1.Checked = True
            Position.CheckBox2.Checked = True
            Position.CheckBox3.Checked = True
            Saving.CheckBox1.Checked = True
            SplitContainer1.SplitterDistance = 470
            Saving.NumericUpDown1.Value = 2
            dat(4) = True
            dat(5) = True
            dat(6) = True
            dat(8) = True
            dat(7) = 470
            dat(9) = 2
            write()
        End If
    End Sub
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If dat(8) = True Then
            If My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/data.dat") <> "" Then
                Dim result As MsgBoxResult
                result = MsgBox("It Is Discovered not preserved progekt." + Chr(10) + "Load progekt?" + Chr(10) + "Under clicked buttons 'no' - progekt will is removed.", MsgBoxStyle.YesNo, "Messenge")
                If result = 6 Then
                    TextBox1.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/data.dat")
                    file = "Old progekt.wp"
                    Text = "[Old progekt] - Plugin Writer"
                Else
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath + "/data.dat", "", False)
                End If
            End If
        End If
        If DateTime.Today.Month >= My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/dat.dat") And My.Computer.Network.IsAvailable Then
            Newing.ShowDialog()
        End If
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If dat(4) = True Then
            dat(0) = Left
            dat(1) = Top
        End If
        If dat(5) = True Then
            dat(2) = Width
            dat(3) = Height
        End If
        If dat(6) = True Then
            dat(7) = SplitContainer1.SplitterDistance
        End If
        write()
        My.Computer.FileSystem.WriteAllText(Application.StartupPath + "/data.dat", "", False)
        If TextBox1.Text <> "" And dat_s <> TextBox1.Text Then
            Dim result As MsgBoxResult
            result = MsgBox("Your progekt don't saved." + Chr(10) + "Save progekt?" + Chr(10) + "(If you press button 'Cancelling', that window will locked be without termination of the program and closing the project.)", MsgBoxStyle.YesNoCancel, "Messenge")
            If result = MsgBoxResult.Yes Then
                If file <> "New progekt.wp" Then
                    result = MsgBox("Save progekt in former file?", MsgBoxStyle.YesNo, "Messenge")
                    If result = 6 Then
                        My.Computer.FileSystem.WriteAllText(file_way, TextBox1.Text, False)
                    Else
                        Dim result1 As DialogResult
                        result1 = SaveFileDialog1.ShowDialog()
                        If result1 = DialogResult.OK Then
                            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                        End If
                    End If
                Else
                    Dim result1 As DialogResult
                    result1 = SaveFileDialog1.ShowDialog()
                    If result1 = DialogResult.OK Then
                        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                    End If
                End If
            ElseIf result = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub write()
        IO.File.WriteAllLines(Application.StartupPath + "/position.dat", dat)
    End Sub
    Private Sub PositionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PositionToolStripMenuItem.Click
        Position.CheckBox1.Checked = dat(4)
        Position.CheckBox2.Checked = dat(5)
        Position.CheckBox3.Checked = dat(6)
        Dim result As DialogResult
        result = Position.ShowDialog()
        If result = DialogResult.OK Then
            dat(4) = Position.CheckBox1.Checked
            dat(5) = Position.CheckBox2.Checked
            dat(6) = Position.CheckBox3.Checked
            write()
        End If
    End Sub
    Private Sub NewProgektToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewProgektToolStripMenuItem.Click
        If TextBox1.Text <> "" And dat_s <> TextBox1.Text Then
            Dim result As MsgBoxResult
            result = MsgBox("Your progekt don't saved." + Chr(10) + "Save progekt?", MsgBoxStyle.YesNo, "Messenge")
            If result = 6 Then
                If file <> "New progekt.wp" And file <> "Old progekt.wp" Then
                    result = MsgBox("Save progekt in former file?", MsgBoxStyle.YesNo, "Messenge")
                    If result = 6 Then
                        My.Computer.FileSystem.WriteAllText(file_way, TextBox1.Text, False)
                    Else
                        Dim result1 As DialogResult
                        result1 = SaveFileDialog1.ShowDialog()
                        If result1 = DialogResult.OK Then
                            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                        End If
                    End If
                Else
                    Dim result1 As DialogResult
                    result1 = SaveFileDialog1.ShowDialog()
                    If result1 = DialogResult.OK Then
                        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                    End If
                End If
            End If
        End If
        file = "New progekt.wp"
        Text = "[New progekt] - Plugin Writer"
        TextBox1.Text = ""
        My.Computer.FileSystem.WriteAllText(Application.StartupPath + "/data.dat", "", False)
    End Sub
    Private Sub SaveProgektToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveProgektToolStripMenuItem.Click
        If file = "New progekt.wp" Or file = "Old progekt.wp" Then
            Dim result1 As DialogResult
            SaveFileDialog1.FileName = file
            result1 = SaveFileDialog1.ShowDialog()
            If result1 = DialogResult.OK Then
                file = Mid(SaveFileDialog1.FileName, SaveFileDialog1.FileName.LastIndexOf("\") + 2)
                Text = "[" & Mid(SaveFileDialog1.FileName, SaveFileDialog1.FileName.LastIndexOf("\") + 2) & "] - Plugin Writer"
                file_way = SaveFileDialog1.FileName
                dat_s = TextBox1.Text
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
            End If
        Else
            dat_s = TextBox1.Text
            My.Computer.FileSystem.WriteAllText(file_way, TextBox1.Text, False)
        End If
    End Sub
    Private Sub SavingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavingToolStripMenuItem.Click
        Saving.CheckBox1.Checked = dat(8)
        Saving.NumericUpDown1.Value = dat(9)
        Dim result As DialogResult
        result = Saving.ShowDialog()
        If result = DialogResult.OK Then
            dat(8) = Saving.CheckBox1.Checked
            dat(9) = Saving.NumericUpDown1.Value
            Timer1.Enabled = dat(8)
            Timer1.Interval = dat(9) * 30000
            write()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        My.Computer.FileSystem.WriteAllText(Application.StartupPath + "/data.dat", TextBox1.Text, False)
    End Sub
    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        Dim result As DialogResult
        result = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            file = Mid(OpenFileDialog1.FileName, OpenFileDialog1.FileName.LastIndexOf("\") + 2)
            file_way = OpenFileDialog1.FileName
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Text = "[" & Mid(OpenFileDialog1.FileName, OpenFileDialog1.FileName.LastIndexOf("\") + 2) & "] - Plugin Writer"
            dat_s = TextBox1.Text
        End If
    End Sub
    Private Sub SavaProgektAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavaProgektAsToolStripMenuItem.Click
        Dim result As DialogResult
        SaveFileDialog1.FileName = file
        result = SaveFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            file = Mid(SaveFileDialog1.FileName, SaveFileDialog1.FileName.LastIndexOf("\") + 2)
            Text = "[" & Mid(SaveFileDialog1.FileName, SaveFileDialog1.FileName.LastIndexOf("\") + 2) & "] - Plugin Writer"
            file_way = SaveFileDialog1.FileName
            dat_s = TextBox1.Text
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
        End If
    End Sub
    Private Sub PluginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PluginToolStripMenuItem.Click
        Dim result As DialogResult
        SaveFileDialog2.FileName = Mid(file, 1, file.LastIndexOf("."))
        result = SaveFileDialog2.ShowDialog()
        If result = DialogResult.OK Then
            Exporting.text1 = SaveFileDialog2.FileName
            My.Computer.FileSystem.WriteAllText(SaveFileDialog2.FileName, TextBox1.Text, True)
            Exporting.ShowDialog()
        End If
    End Sub
    Private Sub ProgramPluginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramPluginToolStripMenuItem.Click
        Dim result As DialogResult
        result = ExportProgram.ShowDialog()
        If result = DialogResult.OK Then
            Exporting.text1 = Application.StartupPath + "/time.tme"
            My.Computer.FileSystem.WriteAllText(Exporting.text1, TextBox1.Text, True)
            Exporting.ShowDialog()
        End If
    End Sub
    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        Dim dat As String
        Dim dat1 As String = TextBox1.SelectionStart
        TextBox1.Text = TextBox1.Text.Insert(TextBox1.SelectionStart, ListBox1.SelectedItem)
        dat = ListBox1.SelectedItem
        TextBox1.SelectionStart = dat1 + dat.Length
    End Sub
    Private Sub CopuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopuToolStripMenuItem.Click
        If ListBox1.SelectedIndex > -1 Then
            My.Computer.Clipboard.SetText(ListBox1.SelectedItem)
        Else
            My.Computer.Clipboard.SetText(ListBox1.Items.Item(0))
        End If
    End Sub
    Private Sub PositionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Position.CheckBox1.Checked = dat(4)
        Position.CheckBox2.Checked = dat(5)
        Position.CheckBox3.Checked = dat(6)
        Dim result As DialogResult
        result = Position.ShowDialog()
        If result = DialogResult.OK Then
            dat(4) = Position.CheckBox1.Checked
            dat(5) = Position.CheckBox2.Checked
            dat(6) = Position.CheckBox3.Checked
            write()
        End If
    End Sub
    Private Sub SavingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Saving.CheckBox1.Checked = dat(8)
        Saving.NumericUpDown1.Value = dat(9)
        Dim result As DialogResult
        result = Saving.ShowDialog()
        If result = DialogResult.OK Then
            dat(8) = Saving.CheckBox1.Checked
            dat(9) = Saving.NumericUpDown1.Value
            Timer1.Enabled = dat(8)
            Timer1.Interval = dat(9) * 30000
            write()
        End If
    End Sub
    Private Sub AddFileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFileToolStripMenuItem1.Click
        Dim result As DialogResult
        OpenFileDialog1.Filter = "All files|*"
        result = OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "File Write Plugin (.wp)|*.wp"
        If result = DialogResult.OK Then
            Dim dat As String
            Dim dat1 As String = TextBox1.SelectionStart
            TextBox1.Text = TextBox1.Text.Insert(TextBox1.SelectionStart, OpenFileDialog1.FileName)
            dat = OpenFileDialog1.FileName
            TextBox1.SelectionStart = dat1 + dat.Length
        End If
    End Sub
    Private Sub FileControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileControlToolStripMenuItem.Click
        Filecontrol.ShowDialog()
    End Sub
End Class
