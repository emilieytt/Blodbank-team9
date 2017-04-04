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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.se_passord = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Glemt2 = New System.Windows.Forms.TextBox()
        Me.Glemt1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(945, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartToolStripMenuItem, Me.AvsluttToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.RestartToolStripMenuItem.Text = "Logg ut"
        '
        'AvsluttToolStripMenuItem
        '
        Me.AvsluttToolStripMenuItem.Name = "AvsluttToolStripMenuItem"
        Me.AvsluttToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.AvsluttToolStripMenuItem.Text = "Avslutt"
        '
        'Avbryt_knapp
        '
        Me.Avbryt_knapp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Avbryt_knapp.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Avbryt_knapp.ForeColor = System.Drawing.Color.White
        Me.Avbryt_knapp.Location = New System.Drawing.Point(377, 223)
        Me.Avbryt_knapp.Margin = New System.Windows.Forms.Padding(4)
        Me.Avbryt_knapp.Name = "Avbryt_knapp"
        Me.Avbryt_knapp.Size = New System.Drawing.Size(136, 49)
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
        Me.Panel1.Location = New System.Drawing.Point(176, 129)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 326)
        Me.Panel1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(241, 21)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 37)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Glemt passord"
        '
        'se_passord
        '
        Me.se_passord.BackColor = System.Drawing.Color.CornflowerBlue
        Me.se_passord.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.se_passord.ForeColor = System.Drawing.Color.White
        Me.se_passord.Location = New System.Drawing.Point(205, 223)
        Me.se_passord.Margin = New System.Windows.Forms.Padding(4)
        Me.se_passord.Name = "se_passord"
        Me.se_passord.Size = New System.Drawing.Size(148, 49)
        Me.se_passord.TabIndex = 3
        Me.se_passord.Text = "Se passord"
        Me.se_passord.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(201, 186)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 24)
        Me.Label4.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(56, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Passord"
        '
        'Glemt2
        '
        Me.Glemt2.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Glemt2.Location = New System.Drawing.Point(205, 122)
        Me.Glemt2.Margin = New System.Windows.Forms.Padding(4)
        Me.Glemt2.Name = "Glemt2"
        Me.Glemt2.Size = New System.Drawing.Size(343, 32)
        Me.Glemt2.TabIndex = 3
        '
        'Glemt1
        '
        Me.Glemt1.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Glemt1.Location = New System.Drawing.Point(205, 81)
        Me.Glemt1.Margin = New System.Windows.Forms.Padding(4)
        Me.Glemt1.Name = "Glemt1"
        Me.Glemt1.Size = New System.Drawing.Size(343, 32)
        Me.Glemt1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(56, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gjenta Epost"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(56, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Epost"
        '
        'GlemtPassord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 657)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
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
