<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinSideAnsatt
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvsluttToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Logg_ut = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Endre_informasjon = New System.Windows.Forms.LinkLabel()
        Me.Blodtype = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Epost = New System.Windows.Forms.Label()
        Me.Navn = New System.Windows.Forms.Label()
        Me.fdato = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Mobilnummer = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Postnr = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Adresse = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Haste = New System.Windows.Forms.RadioButton()
        Me.Normal = New System.Windows.Forms.RadioButton()
        Me.Send_ut = New System.Windows.Forms.Button()
        Me.Header = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(971, 24)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Logg_ut)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.Header)
        Me.GroupBox3.Location = New System.Drawing.Point(42, 50)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(873, 601)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'Logg_ut
        '
        Me.Logg_ut.BackColor = System.Drawing.Color.Red
        Me.Logg_ut.ForeColor = System.Drawing.Color.White
        Me.Logg_ut.Location = New System.Drawing.Point(793, 515)
        Me.Logg_ut.Name = "Logg_ut"
        Me.Logg_ut.Size = New System.Drawing.Size(75, 23)
        Me.Logg_ut.TabIndex = 15
        Me.Logg_ut.Text = "Logg ut"
        Me.Logg_ut.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Endre_informasjon)
        Me.GroupBox1.Controls.Add(Me.Blodtype)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Epost)
        Me.GroupBox1.Controls.Add(Me.Navn)
        Me.GroupBox1.Controls.Add(Me.fdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Mobilnummer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Postnr)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Adresse)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(17, 144)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(368, 314)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Min informasjon:"
        '
        'Endre_informasjon
        '
        Me.Endre_informasjon.AutoSize = True
        Me.Endre_informasjon.Font = New System.Drawing.Font("Cambria", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Endre_informasjon.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Endre_informasjon.Location = New System.Drawing.Point(21, 259)
        Me.Endre_informasjon.Name = "Endre_informasjon"
        Me.Endre_informasjon.Size = New System.Drawing.Size(143, 19)
        Me.Endre_informasjon.TabIndex = 17
        Me.Endre_informasjon.TabStop = True
        Me.Endre_informasjon.Text = "Endre informasjon"
        '
        'Blodtype
        '
        Me.Blodtype.AutoSize = True
        Me.Blodtype.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blodtype.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Blodtype.Location = New System.Drawing.Point(152, 210)
        Me.Blodtype.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Blodtype.Name = "Blodtype"
        Me.Blodtype.Size = New System.Drawing.Size(0, 19)
        Me.Blodtype.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 210)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Blodtype:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Navn: "
        '
        'Epost
        '
        Me.Epost.AutoSize = True
        Me.Epost.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Epost.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Epost.Location = New System.Drawing.Point(152, 178)
        Me.Epost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Epost.Name = "Epost"
        Me.Epost.Size = New System.Drawing.Size(0, 19)
        Me.Epost.TabIndex = 12
        '
        'Navn
        '
        Me.Navn.AutoSize = True
        Me.Navn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Navn.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Navn.Location = New System.Drawing.Point(152, 22)
        Me.Navn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Navn.Name = "Navn"
        Me.Navn.Size = New System.Drawing.Size(0, 19)
        Me.Navn.TabIndex = 1
        '
        'fdato
        '
        Me.fdato.AutoSize = True
        Me.fdato.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fdato.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.fdato.Location = New System.Drawing.Point(152, 115)
        Me.fdato.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.fdato.Name = "fdato"
        Me.fdato.Size = New System.Drawing.Size(0, 19)
        Me.fdato.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Postnr:"
        '
        'Mobilnummer
        '
        Me.Mobilnummer.AutoSize = True
        Me.Mobilnummer.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobilnummer.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Mobilnummer.Location = New System.Drawing.Point(151, 145)
        Me.Mobilnummer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Mobilnummer.Name = "Mobilnummer"
        Me.Mobilnummer.Size = New System.Drawing.Size(0, 19)
        Me.Mobilnummer.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Adresse:"
        '
        'Postnr
        '
        Me.Postnr.AutoSize = True
        Me.Postnr.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Postnr.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Postnr.Location = New System.Drawing.Point(152, 53)
        Me.Postnr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Postnr.Name = "Postnr"
        Me.Postnr.Size = New System.Drawing.Size(0, 19)
        Me.Postnr.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fødselsdato:"
        '
        'Adresse
        '
        Me.Adresse.AutoSize = True
        Me.Adresse.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adresse.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Adresse.Location = New System.Drawing.Point(152, 84)
        Me.Adresse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(0, 19)
        Me.Adresse.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 145)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Mobilnummer:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 178)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "E-postadresse:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Haste)
        Me.GroupBox2.Controls.Add(Me.Normal)
        Me.GroupBox2.Controls.Add(Me.Send_ut)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox2.Location = New System.Drawing.Point(398, 144)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(442, 314)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tapping:"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(90, 271)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(215, 23)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Se statistikk"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(163, 220)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(252, 45)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Administrere blodlager"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(14, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 45)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Se bestillinger"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Haste
        '
        Me.Haste.AutoSize = True
        Me.Haste.Location = New System.Drawing.Point(14, 82)
        Me.Haste.Name = "Haste"
        Me.Haste.Size = New System.Drawing.Size(143, 23)
        Me.Haste.TabIndex = 22
        Me.Haste.TabStop = True
        Me.Haste.Text = "Hasteprosedyre"
        Me.Haste.UseVisualStyleBackColor = True
        '
        'Normal
        '
        Me.Normal.AutoSize = True
        Me.Normal.Location = New System.Drawing.Point(14, 51)
        Me.Normal.Name = "Normal"
        Me.Normal.Size = New System.Drawing.Size(156, 23)
        Me.Normal.TabIndex = 21
        Me.Normal.TabStop = True
        Me.Normal.Text = "Normalprosedyre"
        Me.Normal.UseVisualStyleBackColor = True
        '
        'Send_ut
        '
        Me.Send_ut.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Send_ut.ForeColor = System.Drawing.Color.White
        Me.Send_ut.Location = New System.Drawing.Point(14, 115)
        Me.Send_ut.Name = "Send_ut"
        Me.Send_ut.Size = New System.Drawing.Size(174, 35)
        Me.Send_ut.TabIndex = 20
        Me.Send_ut.Text = "Send ut innkalling"
        Me.Send_ut.UseVisualStyleBackColor = False
        '
        'Header
        '
        Me.Header.AutoSize = True
        Me.Header.Font = New System.Drawing.Font("Calibri", 51.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Header.Location = New System.Drawing.Point(168, 15)
        Me.Header.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(535, 83)
        Me.Header.TabIndex = 0
        Me.Header.Text = "MIN SIDE ANSATT"
        '
        'MinSideAnsatt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 577)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "MinSideAnsatt"
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvsluttToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Endre_informasjon As LinkLabel
    Friend WithEvents Blodtype As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Epost As Label
    Friend WithEvents Navn As Label
    Friend WithEvents fdato As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Mobilnummer As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Postnr As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Adresse As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Send_ut As Button
    Friend WithEvents Header As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Haste As RadioButton
    Friend WithEvents Normal As RadioButton
    Friend WithEvents Logg_ut As Button
End Class
