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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Nullstill_knapp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AvsluttToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvsluttToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Registrer_blodgiver = New System.Windows.Forms.LinkLabel()
        Me.Glemt_passord = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Logg inn"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Nullstill_knapp
        '
        Me.Nullstill_knapp.BackColor = System.Drawing.Color.Red
        Me.Nullstill_knapp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nullstill_knapp.ForeColor = System.Drawing.Color.White
        Me.Nullstill_knapp.Location = New System.Drawing.Point(215, 369)
        Me.Nullstill_knapp.Name = "Nullstill_knapp"
        Me.Nullstill_knapp.Size = New System.Drawing.Size(186, 64)
        Me.Nullstill_knapp.TabIndex = 1
        Me.Nullstill_knapp.Text = "Nullstill"
        Me.Nullstill_knapp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Nullstill_knapp.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bruker-ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Passord"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(116, 286)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(285, 32)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "emileidesmo@live.no"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(116, 328)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(285, 32)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "123"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Blod1._0.My.Resources.Resources.Blod
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(412, 259)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
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
        Me.Registrer_blodgiver.Location = New System.Drawing.Point(12, 440)
        Me.Registrer_blodgiver.Name = "Registrer_blodgiver"
        Me.Registrer_blodgiver.Size = New System.Drawing.Size(95, 13)
        Me.Registrer_blodgiver.TabIndex = 8
        Me.Registrer_blodgiver.TabStop = True
        Me.Registrer_blodgiver.Text = "Registrer blodgiver"
        '
        'Glemt_passord
        '
        Me.Glemt_passord.AutoSize = True
        Me.Glemt_passord.Location = New System.Drawing.Point(194, 440)
        Me.Glemt_passord.Name = "Glemt_passord"
        Me.Glemt_passord.Size = New System.Drawing.Size(74, 13)
        Me.Glemt_passord.TabIndex = 9
        Me.Glemt_passord.TabStop = True
        Me.Glemt_passord.Text = "Glemt passord"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Glemt_passord)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Registrer_blodgiver)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Nullstill_knapp)
        Me.Panel1.Location = New System.Drawing.Point(55, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 469)
        Me.Panel1.TabIndex = 11
        '
        'Startside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 628)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Startside"
        Me.Text = "Glemt "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Nullstill_knapp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AvsluttToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvsluttToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Registrer_blodgiver As LinkLabel
    Friend WithEvents Glemt_passord As LinkLabel
    Friend WithEvents Panel1 As Panel
End Class
