<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GlemtPassord
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvsluttToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Avbryt_knapp = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Glemt1 = New System.Windows.Forms.TextBox()
        Me.Glemt2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.se_passord = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartToolStripMenuItem, Me.AvsluttToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'AvsluttToolStripMenuItem
        '
        Me.AvsluttToolStripMenuItem.Name = "AvsluttToolStripMenuItem"
        Me.AvsluttToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.AvsluttToolStripMenuItem.Text = "Avslutt"
        '
        'Avbryt_knapp
        '
        Me.Avbryt_knapp.BackColor = System.Drawing.Color.Red
        Me.Avbryt_knapp.ForeColor = System.Drawing.Color.White
        Me.Avbryt_knapp.Location = New System.Drawing.Point(283, 181)
        Me.Avbryt_knapp.Name = "Avbryt_knapp"
        Me.Avbryt_knapp.Size = New System.Drawing.Size(102, 40)
        Me.Avbryt_knapp.TabIndex = 1
        Me.Avbryt_knapp.Text = "Avbryt"
        Me.Avbryt_knapp.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.se_passord)
        Me.Panel1.Controls.Add(Me.Avbryt_knapp)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Glemt2)
        Me.Panel1.Controls.Add(Me.Glemt1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(132, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 265)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Epost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gjenta Epost"
        '
        'Glemt1
        '
        Me.Glemt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Glemt1.Location = New System.Drawing.Point(154, 66)
        Me.Glemt1.Name = "Glemt1"
        Me.Glemt1.Size = New System.Drawing.Size(258, 24)
        Me.Glemt1.TabIndex = 2
        '
        'Glemt2
        '
        Me.Glemt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Glemt2.Location = New System.Drawing.Point(154, 99)
        Me.Glemt2.Name = "Glemt2"
        Me.Glemt2.Size = New System.Drawing.Size(258, 24)
        Me.Glemt2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Passord"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(151, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 18)
        Me.Label4.TabIndex = 5
        '
        'se_passord
        '
        Me.se_passord.BackColor = System.Drawing.Color.Red
        Me.se_passord.ForeColor = System.Drawing.Color.White
        Me.se_passord.Location = New System.Drawing.Point(154, 181)
        Me.se_passord.Name = "se_passord"
        Me.se_passord.Size = New System.Drawing.Size(111, 40)
        Me.se_passord.TabIndex = 3
        Me.se_passord.Text = "Se passord"
        Me.se_passord.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(181, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Glemt passord"
        '
        'GlemtPassord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 534)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GlemtPassord"
        Me.Text = "GlemtPassord"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvsluttToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Avbryt_knapp As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Glemt2 As TextBox
    Friend WithEvents Glemt1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents se_passord As Button
    Friend WithEvents Label5 As Label
End Class
