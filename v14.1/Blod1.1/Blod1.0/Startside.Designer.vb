<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startside
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Logg_inn = New System.Windows.Forms.Button()
        Me.Nullstill_knapp = New System.Windows.Forms.Button()
        Me.BrukerID = New System.Windows.Forms.Label()
        Me.PassordS = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AvsluttToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvsluttToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Registrer_blodgiver = New System.Windows.Forms.LinkLabel()
        Me.Glemt_passord = New System.Windows.Forms.LinkLabel()
        Me.StartsidePanel = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StartsidePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logg_inn
        '
        Me.Logg_inn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Logg_inn.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Logg_inn.ForeColor = System.Drawing.Color.White
        Me.Logg_inn.Location = New System.Drawing.Point(16, 491)
        Me.Logg_inn.Name = "Logg_inn"
        Me.Logg_inn.Size = New System.Drawing.Size(197, 64)
        Me.Logg_inn.TabIndex = 0
        Me.Logg_inn.Text = "Logg inn"
        Me.Logg_inn.UseVisualStyleBackColor = False
        '
        'Nullstill_knapp
        '
        Me.Nullstill_knapp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Nullstill_knapp.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Nullstill_knapp.ForeColor = System.Drawing.Color.White
        Me.Nullstill_knapp.Location = New System.Drawing.Point(219, 491)
        Me.Nullstill_knapp.Name = "Nullstill_knapp"
        Me.Nullstill_knapp.Size = New System.Drawing.Size(186, 64)
        Me.Nullstill_knapp.TabIndex = 1
        Me.Nullstill_knapp.Text = "Nullstill"
        Me.Nullstill_knapp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Nullstill_knapp.UseVisualStyleBackColor = False
        '
        'BrukerID
        '
        Me.BrukerID.AutoSize = True
        Me.BrukerID.Font = New System.Drawing.Font("Calibri Light", 16.2!, System.Drawing.FontStyle.Bold)
        Me.BrukerID.Location = New System.Drawing.Point(11, 412)
        Me.BrukerID.Name = "BrukerID"
        Me.BrukerID.Size = New System.Drawing.Size(104, 27)
        Me.BrukerID.TabIndex = 2
        Me.BrukerID.Text = "Bruker-ID"
        '
        'PassordS
        '
        Me.PassordS.AutoSize = True
        Me.PassordS.Font = New System.Drawing.Font("Calibri Light", 16.2!, System.Drawing.FontStyle.Bold)
        Me.PassordS.Location = New System.Drawing.Point(11, 454)
        Me.PassordS.Name = "PassordS"
        Me.PassordS.Size = New System.Drawing.Size(88, 27)
        Me.PassordS.TabIndex = 3
        Me.PassordS.Text = "Passord"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri Light", 16.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(120, 408)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(285, 34)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "e@live.no"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(120, 450)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(285, 32)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "12"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvsluttToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1051, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AvsluttToolStripMenuItem
        '
        Me.AvsluttToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartToolStripMenuItem, Me.AvsluttToolStripMenuItem1})
        Me.AvsluttToolStripMenuItem.Name = "AvsluttToolStripMenuItem"
        Me.AvsluttToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.AvsluttToolStripMenuItem.Text = "File"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'AvsluttToolStripMenuItem1
        '
        Me.AvsluttToolStripMenuItem1.Name = "AvsluttToolStripMenuItem1"
        Me.AvsluttToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.AvsluttToolStripMenuItem1.Text = "Avslutt"
        '
        'Registrer_blodgiver
        '
        Me.Registrer_blodgiver.AutoSize = True
        Me.Registrer_blodgiver.Location = New System.Drawing.Point(16, 562)
        Me.Registrer_blodgiver.Name = "Registrer_blodgiver"
        Me.Registrer_blodgiver.Size = New System.Drawing.Size(95, 13)
        Me.Registrer_blodgiver.TabIndex = 8
        Me.Registrer_blodgiver.TabStop = True
        Me.Registrer_blodgiver.Text = "Registrer blodgiver"
        '
        'Glemt_passord
        '
        Me.Glemt_passord.AutoSize = True
        Me.Glemt_passord.Location = New System.Drawing.Point(287, 562)
        Me.Glemt_passord.Name = "Glemt_passord"
        Me.Glemt_passord.Size = New System.Drawing.Size(74, 13)
        Me.Glemt_passord.TabIndex = 9
        Me.Glemt_passord.TabStop = True
        Me.Glemt_passord.Text = "Glemt passord"
        '
        'StartsidePanel
        '
        Me.StartsidePanel.Controls.Add(Me.LinkLabel1)
        Me.StartsidePanel.Controls.Add(Me.PictureBox1)
        Me.StartsidePanel.Controls.Add(Me.Glemt_passord)
        Me.StartsidePanel.Controls.Add(Me.TextBox1)
        Me.StartsidePanel.Controls.Add(Me.Registrer_blodgiver)
        Me.StartsidePanel.Controls.Add(Me.PassordS)
        Me.StartsidePanel.Controls.Add(Me.Logg_inn)
        Me.StartsidePanel.Controls.Add(Me.BrukerID)
        Me.StartsidePanel.Controls.Add(Me.TextBox2)
        Me.StartsidePanel.Controls.Add(Me.Nullstill_knapp)
        Me.StartsidePanel.Location = New System.Drawing.Point(192, 29)
        Me.StartsidePanel.Name = "StartsidePanel"
        Me.StartsidePanel.Size = New System.Drawing.Size(410, 587)
        Me.StartsidePanel.TabIndex = 11
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(163, 562)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(81, 13)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Registrer ansatt"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Blod1._0.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(68, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 350)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Startside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1051, 628)
        Me.Controls.Add(Me.StartsidePanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Startside"
        Me.Text = "Glemt "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StartsidePanel.ResumeLayout(False)
        Me.StartsidePanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Logg_inn As Button
    Friend WithEvents Nullstill_knapp As Button
    Friend WithEvents BrukerID As Label
    Friend WithEvents PassordS As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AvsluttToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvsluttToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Registrer_blodgiver As LinkLabel
    Friend WithEvents Glemt_passord As LinkLabel
    Friend WithEvents StartsidePanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
