<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgektToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProgektToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveProgektToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavaProgektAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExsportProgektAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PluginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramPluginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(654, 445)
        Me.SplitContainer1.SplitterDistance = 470
        Me.SplitContainer1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.MaxLength = 1000000
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(470, 445)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.WordWrap = False
        '
        'ListBox1
        '
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"Forwent", "Sustem", "STab", "Tabulation", "Forword", "Count", "Step", "Masters", "Piugin", "Corporate", "Terrictional", "Farrow", "CountZiro", "Text", "MyData", "DataProgram", "WindowsData", "GatData", "SetData", "WebData", "WebExplorer", "EnterData", "EnterSustem", "EnterProgram", "PlushProgram", "EnterKey", "Setup", "AutoSetup", "Key", "KeyProgram", "KeyWindows", "Plugining", "Control", ".", "..", "...", "<goto>", ">goto<", "Deliting", "Focus", "Activated", "Aktivate", "Game", "GameStat", "OpenPassword", "ClosePassword", "CopyPlugin", "Microsoft", "Web", "Network", "KeyConnect", "USB", "USBInfo", "DataInfo", "Mini-Data", "Reestr", "Regedit", "Register", "OnRegister", "OnMouse", "Mouse", "Up", "Down", "Clik", "ClifOptions", "Dir", "File", "DirOptions", "FileOptions", "MouseData", "Play", "Plugin", "Set", "Get"})
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(180, 445)
        Me.ListBox1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.ListBox1, "Help for write your plugin.")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopuToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 26)
        '
        'CopuToolStripMenuItem
        '
        Me.CopuToolStripMenuItem.Name = "CopuToolStripMenuItem"
        Me.CopuToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CopuToolStripMenuItem.Text = "Copu"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgektToolStripMenuItem, Me.FileToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(654, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgektToolStripMenuItem
        '
        Me.ProgektToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProgektToolStripMenuItem, Me.LoadToolStripMenuItem, Me.SaveProgektToolStripMenuItem, Me.SavaProgektAsToolStripMenuItem, Me.ExsportProgektAsToolStripMenuItem})
        Me.ProgektToolStripMenuItem.Name = "ProgektToolStripMenuItem"
        Me.ProgektToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ProgektToolStripMenuItem.Text = "Progekt"
        Me.ProgektToolStripMenuItem.ToolTipText = "Progekt option."
        '
        'NewProgektToolStripMenuItem
        '
        Me.NewProgektToolStripMenuItem.Name = "NewProgektToolStripMenuItem"
        Me.NewProgektToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NewProgektToolStripMenuItem.Text = "New progekt"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.LoadToolStripMenuItem.Text = "Load progekt"
        '
        'SaveProgektToolStripMenuItem
        '
        Me.SaveProgektToolStripMenuItem.Name = "SaveProgektToolStripMenuItem"
        Me.SaveProgektToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SaveProgektToolStripMenuItem.Text = "Save progekt"
        '
        'SavaProgektAsToolStripMenuItem
        '
        Me.SavaProgektAsToolStripMenuItem.Name = "SavaProgektAsToolStripMenuItem"
        Me.SavaProgektAsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SavaProgektAsToolStripMenuItem.Text = "Save progekt as"
        '
        'ExsportProgektAsToolStripMenuItem
        '
        Me.ExsportProgektAsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PluginToolStripMenuItem, Me.ProgramPluginToolStripMenuItem})
        Me.ExsportProgektAsToolStripMenuItem.Name = "ExsportProgektAsToolStripMenuItem"
        Me.ExsportProgektAsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ExsportProgektAsToolStripMenuItem.Text = "Exsport progekt"
        '
        'PluginToolStripMenuItem
        '
        Me.PluginToolStripMenuItem.Name = "PluginToolStripMenuItem"
        Me.PluginToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.PluginToolStripMenuItem.Text = "Plugin"
        '
        'ProgramPluginToolStripMenuItem
        '
        Me.ProgramPluginToolStripMenuItem.Name = "ProgramPluginToolStripMenuItem"
        Me.ProgramPluginToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ProgramPluginToolStripMenuItem.Text = "Program plugin"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFileToolStripMenuItem1, Me.FileControlToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddFileToolStripMenuItem1
        '
        Me.AddFileToolStripMenuItem1.Name = "AddFileToolStripMenuItem1"
        Me.AddFileToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.AddFileToolStripMenuItem1.Text = "Add file"
        '
        'FileControlToolStripMenuItem
        '
        Me.FileControlToolStripMenuItem.Name = "FileControlToolStripMenuItem"
        Me.FileControlToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.FileControlToolStripMenuItem.Text = "File control"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PositionToolStripMenuItem, Me.SavingToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.DataToolStripMenuItem.Text = "Settings"
        Me.DataToolStripMenuItem.ToolTipText = "Settings for program."
        '
        'PositionToolStripMenuItem
        '
        Me.PositionToolStripMenuItem.Name = "PositionToolStripMenuItem"
        Me.PositionToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.PositionToolStripMenuItem.Text = "Position"
        '
        'SavingToolStripMenuItem
        '
        Me.SavingToolStripMenuItem.Name = "SavingToolStripMenuItem"
        Me.SavingToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SavingToolStripMenuItem.Text = "Saving "
        '
        'ToolTip1
        '
        Me.ToolTip1.UseAnimation = False
        Me.ToolTip1.UseFading = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "File Write Plugin (.wp)|*.wp"
        Me.SaveFileDialog1.Title = "Save file"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "File Write Plugin (.wp)|*.wp"
        Me.OpenFileDialog1.Title = "Open file"
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'SaveFileDialog2
        '
        Me.SaveFileDialog2.Filter = "Plugin|*.ini"
        Me.SaveFileDialog2.Title = "Export to plugin"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(654, 472)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Plugin Writer"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgektToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewProgektToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveProgektToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExsportProgektAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PluginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramPluginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PositionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SavingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavaProgektAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
