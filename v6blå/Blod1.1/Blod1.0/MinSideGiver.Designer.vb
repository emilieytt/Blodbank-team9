<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MinSideGiver
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvsluttToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Se_tidligere = New System.Windows.Forms.LinkLabel()
        Me.Nestetekst = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Egenerklæring_knapp = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Neste = New System.Windows.Forms.Label()
        Me.Forrige = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Header = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Logg_ut = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1260, 28)
        Me.MenuStrip1.TabIndex = 1
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
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'AvsluttToolStripMenuItem
        '
        Me.AvsluttToolStripMenuItem.Name = "AvsluttToolStripMenuItem"
        Me.AvsluttToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.AvsluttToolStripMenuItem.Text = "Avslutt"
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
        Me.GroupBox1.Location = New System.Drawing.Point(56, 159)
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
        Me.Endre_informasjon.Font = New System.Drawing.Font("Cambria", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Endre_informasjon.Location = New System.Drawing.Point(23, 336)
        Me.Endre_informasjon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Endre_informasjon.Name = "Endre_informasjon"
        Me.Endre_informasjon.Size = New System.Drawing.Size(178, 23)
        Me.Endre_informasjon.TabIndex = 17
        Me.Endre_informasjon.TabStop = True
        Me.Endre_informasjon.Text = "Endre Informasjon"
        '
        'Blodtype
        '
        Me.Blodtype.AutoSize = True
        Me.Blodtype.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blodtype.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Blodtype.Location = New System.Drawing.Point(203, 258)
        Me.Blodtype.Name = "Blodtype"
        Me.Blodtype.Size = New System.Drawing.Size(0, 23)
        Me.Blodtype.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(23, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Blodtype:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Navn: "
        '
        'Epost
        '
        Me.Epost.AutoSize = True
        Me.Epost.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Epost.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Epost.Location = New System.Drawing.Point(203, 219)
        Me.Epost.Name = "Epost"
        Me.Epost.Size = New System.Drawing.Size(0, 23)
        Me.Epost.TabIndex = 12
        '
        'Navn
        '
        Me.Navn.AutoSize = True
        Me.Navn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Navn.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Navn.Location = New System.Drawing.Point(203, 27)
        Me.Navn.Name = "Navn"
        Me.Navn.Size = New System.Drawing.Size(0, 23)
        Me.Navn.TabIndex = 1
        '
        'fdato
        '
        Me.fdato.AutoSize = True
        Me.fdato.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fdato.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.fdato.Location = New System.Drawing.Point(203, 142)
        Me.fdato.Name = "fdato"
        Me.fdato.Size = New System.Drawing.Size(0, 23)
        Me.fdato.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Postnr:"
        '
        'Mobilnummer
        '
        Me.Mobilnummer.AutoSize = True
        Me.Mobilnummer.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobilnummer.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Mobilnummer.Location = New System.Drawing.Point(201, 178)
        Me.Mobilnummer.Name = "Mobilnummer"
        Me.Mobilnummer.Size = New System.Drawing.Size(0, 23)
        Me.Mobilnummer.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Adresse:"
        '
        'Postnr
        '
        Me.Postnr.AutoSize = True
        Me.Postnr.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Postnr.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Postnr.Location = New System.Drawing.Point(203, 65)
        Me.Postnr.Name = "Postnr"
        Me.Postnr.Size = New System.Drawing.Size(0, 23)
        Me.Postnr.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fødselsdato:"
        '
        'Adresse
        '
        Me.Adresse.AutoSize = True
        Me.Adresse.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adresse.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Adresse.Location = New System.Drawing.Point(203, 103)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(0, 23)
        Me.Adresse.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Mobilnummer:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "E-postadresse:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Se_tidligere)
        Me.GroupBox2.Controls.Add(Me.Nestetekst)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Egenerklæring_knapp)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Neste)
        Me.GroupBox2.Controls.Add(Me.Forrige)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox2.Location = New System.Drawing.Point(565, 159)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(536, 386)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tapping:"
        '
        'Se_tidligere
        '
        Me.Se_tidligere.AutoSize = True
        Me.Se_tidligere.Location = New System.Drawing.Point(25, 336)
        Me.Se_tidligere.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Se_tidligere.Name = "Se_tidligere"
        Me.Se_tidligere.Size = New System.Drawing.Size(275, 23)
        Me.Se_tidligere.TabIndex = 24
        Me.Se_tidligere.TabStop = True
        Me.Se_tidligere.Text = "Se alle tidliger blodtappinger"
        '
        'Nestetekst
        '
        Me.Nestetekst.AutoSize = True
        Me.Nestetekst.Location = New System.Drawing.Point(25, 103)
        Me.Nestetekst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Nestetekst.Name = "Nestetekst"
        Me.Nestetekst.Size = New System.Drawing.Size(0, 23)
        Me.Nestetekst.TabIndex = 23
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30"})
        Me.ComboBox1.Location = New System.Drawing.Point(103, 180)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(333, 31)
        Me.ComboBox1.TabIndex = 22
        Me.ComboBox1.Text = "Klokkeslett"
        '
        'Egenerklæring_knapp
        '
        Me.Egenerklæring_knapp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Egenerklæring_knapp.ForeColor = System.Drawing.Color.White
        Me.Egenerklæring_knapp.Location = New System.Drawing.Point(103, 273)
        Me.Egenerklæring_knapp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Egenerklæring_knapp.Name = "Egenerklæring_knapp"
        Me.Egenerklæring_knapp.Size = New System.Drawing.Size(335, 43)
        Me.Egenerklæring_knapp.TabIndex = 21
        Me.Egenerklæring_knapp.Text = "Egenerklæring"
        Me.Egenerklæring_knapp.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(103, 223)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(335, 43)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Bestill time"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 142)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(333, 31)
        Me.DateTimePicker1.TabIndex = 19
        '
        'Neste
        '
        Me.Neste.AutoSize = True
        Me.Neste.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Neste.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Neste.Location = New System.Drawing.Point(351, 65)
        Me.Neste.Name = "Neste"
        Me.Neste.Size = New System.Drawing.Size(62, 23)
        Me.Neste.TabIndex = 18
        Me.Neste.Text = "Neste"
        '
        'Forrige
        '
        Me.Forrige.AutoSize = True
        Me.Forrige.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forrige.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Forrige.Location = New System.Drawing.Point(217, 27)
        Me.Forrige.Name = "Forrige"
        Me.Forrige.Size = New System.Drawing.Size(76, 23)
        Me.Forrige.TabIndex = 17
        Me.Forrige.Text = "Forrige"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(21, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Siste blodtapping:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(289, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Dager til neste mulige tapping:"
        '
        'Header
        '
        Me.Header.AutoSize = True
        Me.Header.Font = New System.Drawing.Font("Calibri", 51.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Header.Location = New System.Drawing.Point(379, 23)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(375, 104)
        Me.Header.TabIndex = 0
        Me.Header.Text = "MIN SIDE"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Logg_ut)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Header)
        Me.Panel1.Location = New System.Drawing.Point(112, 129)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 596)
        Me.Panel1.TabIndex = 17
        '
        'Logg_ut
        '
        Me.Logg_ut.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Logg_ut.ForeColor = System.Drawing.Color.White
        Me.Logg_ut.Location = New System.Drawing.Point(1028, 564)
        Me.Logg_ut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Logg_ut.Name = "Logg_ut"
        Me.Logg_ut.Size = New System.Drawing.Size(100, 28)
        Me.Logg_ut.TabIndex = 24
        Me.Logg_ut.Text = "Logg ut"
        Me.Logg_ut.UseVisualStyleBackColor = False
        '
        'MinSideGiver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 1009)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MinSideGiver"
        Me.Text = "E"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvsluttToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Neste As Label
    Friend WithEvents Forrige As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Header As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Endre_informasjon As LinkLabel
    Friend WithEvents Egenerklæring_knapp As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Nestetekst As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Logg_ut As Button
    Friend WithEvents Se_tidligere As LinkLabel
End Class
