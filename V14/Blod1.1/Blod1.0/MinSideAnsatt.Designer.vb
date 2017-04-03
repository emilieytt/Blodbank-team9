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
        Me.Logg_ut = New System.Windows.Forms.Button()
        Me.Statistikk = New System.Windows.Forms.Button()
        Me.Blodlager = New System.Windows.Forms.Button()
        Me.Bestillinger = New System.Windows.Forms.Button()
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
        Me.MenuStrip2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(1295, 28)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
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
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(135, 26)
        Me.RestartToolStripMenuItem.Text = "Logg ut"
        '
        'AvsluttToolStripMenuItem
        '
        Me.AvsluttToolStripMenuItem.Name = "AvsluttToolStripMenuItem"
        Me.AvsluttToolStripMenuItem.Size = New System.Drawing.Size(135, 26)
        Me.AvsluttToolStripMenuItem.Text = "Avslutt"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.Header)
        Me.GroupBox3.Location = New System.Drawing.Point(56, 62)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(1164, 740)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
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
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(23, 177)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(491, 386)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Min informasjon:"
        '
        'Endre_informasjon
        '
        Me.Endre_informasjon.AutoSize = True
        Me.Endre_informasjon.Font = New System.Drawing.Font("Calibri Light", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Endre_informasjon.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Endre_informasjon.Location = New System.Drawing.Point(28, 319)
        Me.Endre_informasjon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Endre_informasjon.Name = "Endre_informasjon"
        Me.Endre_informasjon.Size = New System.Drawing.Size(174, 24)
        Me.Endre_informasjon.TabIndex = 17
        Me.Endre_informasjon.TabStop = True
        Me.Endre_informasjon.Text = "Endre informasjon"
        '
        'Blodtype
        '
        Me.Blodtype.AutoSize = True
        Me.Blodtype.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Blodtype.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Blodtype.Location = New System.Drawing.Point(203, 258)
        Me.Blodtype.Name = "Blodtype"
        Me.Blodtype.Size = New System.Drawing.Size(0, 24)
        Me.Blodtype.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(23, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Blodtype:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Navn: "
        '
        'Epost
        '
        Me.Epost.AutoSize = True
        Me.Epost.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Epost.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Epost.Location = New System.Drawing.Point(203, 219)
        Me.Epost.Name = "Epost"
        Me.Epost.Size = New System.Drawing.Size(0, 24)
        Me.Epost.TabIndex = 12
        '
        'Navn
        '
        Me.Navn.AutoSize = True
        Me.Navn.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Navn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Navn.Location = New System.Drawing.Point(203, 27)
        Me.Navn.Name = "Navn"
        Me.Navn.Size = New System.Drawing.Size(0, 24)
        Me.Navn.TabIndex = 1
        '
        'fdato
        '
        Me.fdato.AutoSize = True
        Me.fdato.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.fdato.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fdato.Location = New System.Drawing.Point(203, 142)
        Me.fdato.Name = "fdato"
        Me.fdato.Size = New System.Drawing.Size(0, 24)
        Me.fdato.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Postnr:"
        '
        'Mobilnummer
        '
        Me.Mobilnummer.AutoSize = True
        Me.Mobilnummer.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Mobilnummer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Mobilnummer.Location = New System.Drawing.Point(201, 178)
        Me.Mobilnummer.Name = "Mobilnummer"
        Me.Mobilnummer.Size = New System.Drawing.Size(0, 24)
        Me.Mobilnummer.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Adresse:"
        '
        'Postnr
        '
        Me.Postnr.AutoSize = True
        Me.Postnr.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Postnr.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Postnr.Location = New System.Drawing.Point(203, 65)
        Me.Postnr.Name = "Postnr"
        Me.Postnr.Size = New System.Drawing.Size(0, 24)
        Me.Postnr.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fødselsdato:"
        '
        'Adresse
        '
        Me.Adresse.AutoSize = True
        Me.Adresse.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Adresse.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Adresse.Location = New System.Drawing.Point(203, 103)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(0, 24)
        Me.Adresse.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Mobilnummer:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 24)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "E-postadresse:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Logg_ut)
        Me.GroupBox2.Controls.Add(Me.Statistikk)
        Me.GroupBox2.Controls.Add(Me.Blodlager)
        Me.GroupBox2.Controls.Add(Me.Bestillinger)
        Me.GroupBox2.Controls.Add(Me.Haste)
        Me.GroupBox2.Controls.Add(Me.Normal)
        Me.GroupBox2.Controls.Add(Me.Send_ut)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(531, 177)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(589, 386)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Administrering"
        '
        'Logg_ut
        '
        Me.Logg_ut.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Logg_ut.ForeColor = System.Drawing.Color.White
        Me.Logg_ut.Location = New System.Drawing.Point(471, 337)
        Me.Logg_ut.Margin = New System.Windows.Forms.Padding(4)
        Me.Logg_ut.Name = "Logg_ut"
        Me.Logg_ut.Size = New System.Drawing.Size(111, 43)
        Me.Logg_ut.TabIndex = 15
        Me.Logg_ut.Text = "Logg ut"
        Me.Logg_ut.UseVisualStyleBackColor = False
        '
        'Statistikk
        '
        Me.Statistikk.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Statistikk.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Statistikk.ForeColor = System.Drawing.Color.White
        Me.Statistikk.Location = New System.Drawing.Point(297, 205)
        Me.Statistikk.Margin = New System.Windows.Forms.Padding(4)
        Me.Statistikk.Name = "Statistikk"
        Me.Statistikk.Size = New System.Drawing.Size(265, 55)
        Me.Statistikk.TabIndex = 25
        Me.Statistikk.Text = "Se statistikk"
        Me.Statistikk.UseVisualStyleBackColor = False
        '
        'Blodlager
        '
        Me.Blodlager.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Blodlager.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Blodlager.ForeColor = System.Drawing.Color.White
        Me.Blodlager.Location = New System.Drawing.Point(24, 205)
        Me.Blodlager.Margin = New System.Windows.Forms.Padding(4)
        Me.Blodlager.Name = "Blodlager"
        Me.Blodlager.Size = New System.Drawing.Size(265, 55)
        Me.Blodlager.TabIndex = 24
        Me.Blodlager.Text = "Administrere blodlager"
        Me.Blodlager.UseVisualStyleBackColor = False
        '
        'Bestillinger
        '
        Me.Bestillinger.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Bestillinger.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Bestillinger.ForeColor = System.Drawing.Color.White
        Me.Bestillinger.Location = New System.Drawing.Point(297, 142)
        Me.Bestillinger.Margin = New System.Windows.Forms.Padding(4)
        Me.Bestillinger.Name = "Bestillinger"
        Me.Bestillinger.Size = New System.Drawing.Size(265, 55)
        Me.Bestillinger.TabIndex = 23
        Me.Bestillinger.Text = "Se bestillinger"
        Me.Bestillinger.UseVisualStyleBackColor = False
        '
        'Haste
        '
        Me.Haste.AutoSize = True
        Me.Haste.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Haste.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Haste.Location = New System.Drawing.Point(24, 89)
        Me.Haste.Margin = New System.Windows.Forms.Padding(4)
        Me.Haste.Name = "Haste"
        Me.Haste.Size = New System.Drawing.Size(172, 28)
        Me.Haste.TabIndex = 22
        Me.Haste.TabStop = True
        Me.Haste.Text = "Hasteprosedyre"
        Me.Haste.UseVisualStyleBackColor = True
        '
        'Normal
        '
        Me.Normal.AutoSize = True
        Me.Normal.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Normal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Normal.Location = New System.Drawing.Point(24, 51)
        Me.Normal.Margin = New System.Windows.Forms.Padding(4)
        Me.Normal.Name = "Normal"
        Me.Normal.Size = New System.Drawing.Size(186, 28)
        Me.Normal.TabIndex = 21
        Me.Normal.TabStop = True
        Me.Normal.Text = "Normalprosedyre"
        Me.Normal.UseVisualStyleBackColor = True
        '
        'Send_ut
        '
        Me.Send_ut.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Send_ut.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Send_ut.ForeColor = System.Drawing.Color.White
        Me.Send_ut.Location = New System.Drawing.Point(24, 142)
        Me.Send_ut.Margin = New System.Windows.Forms.Padding(4)
        Me.Send_ut.Name = "Send_ut"
        Me.Send_ut.Size = New System.Drawing.Size(265, 55)
        Me.Send_ut.TabIndex = 20
        Me.Send_ut.Text = "Send ut innkalling"
        Me.Send_ut.UseVisualStyleBackColor = False
        '
        'Header
        '
        Me.Header.AutoSize = True
        Me.Header.Font = New System.Drawing.Font("Calibri", 51.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Header.Location = New System.Drawing.Point(224, 18)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(671, 104)
        Me.Header.TabIndex = 0
        Me.Header.Text = "MIN SIDE ANSATT"
        '
        'MinSideAnsatt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1295, 748)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents Statistikk As Button
    Friend WithEvents Blodlager As Button
    Friend WithEvents Bestillinger As Button
    Friend WithEvents Haste As RadioButton
    Friend WithEvents Normal As RadioButton
    Friend WithEvents Logg_ut As Button
End Class
