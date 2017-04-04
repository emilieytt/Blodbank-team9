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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvsluttToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Endre_informasjon = New System.Windows.Forms.LinkLabel()
        Me.Blodtype = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Epost = New System.Windows.Forms.Label()
        Me.Navn = New System.Windows.Forms.Label()
        Me.fdato = New System.Windows.Forms.Label()
        Me.Mobilnummer = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Postnr = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Adresse = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bestill = New System.Windows.Forms.Button()
        Me.Logg_ut = New System.Windows.Forms.Button()
        Me.Se_tidligere = New System.Windows.Forms.LinkLabel()
        Me.Nestetekst = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Egenerklæring_knapp = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Neste = New System.Windows.Forms.Label()
        Me.Forrige = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Header = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1071, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartToolStripMenuItem2, Me.AvsluttToolStripMenuItem2})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RestartToolStripMenuItem2
        '
        Me.RestartToolStripMenuItem2.Name = "RestartToolStripMenuItem2"
        Me.RestartToolStripMenuItem2.Size = New System.Drawing.Size(115, 22)
        Me.RestartToolStripMenuItem2.Text = "Logg ut"
        '
        'AvsluttToolStripMenuItem2
        '
        Me.AvsluttToolStripMenuItem2.Name = "AvsluttToolStripMenuItem2"
        Me.AvsluttToolStripMenuItem2.Size = New System.Drawing.Size(115, 22)
        Me.AvsluttToolStripMenuItem2.Text = "Avslutt"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Endre_informasjon)
        Me.GroupBox1.Controls.Add(Me.Blodtype)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Epost)
        Me.GroupBox1.Controls.Add(Me.Navn)
        Me.GroupBox1.Controls.Add(Me.fdato)
        Me.GroupBox1.Controls.Add(Me.Mobilnummer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Postnr)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Adresse)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(42, 129)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(368, 314)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Min informasjon:"
        '
        'Endre_informasjon
        '
        Me.Endre_informasjon.AutoSize = True
        Me.Endre_informasjon.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Endre_informasjon.Location = New System.Drawing.Point(17, 273)
        Me.Endre_informasjon.Name = "Endre_informasjon"
        Me.Endre_informasjon.Size = New System.Drawing.Size(146, 19)
        Me.Endre_informasjon.TabIndex = 17
        Me.Endre_informasjon.TabStop = True
        Me.Endre_informasjon.Text = "Endre Informasjon"
        '
        'Blodtype
        '
        Me.Blodtype.AutoSize = True
        Me.Blodtype.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Blodtype.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Blodtype.Location = New System.Drawing.Point(152, 210)
        Me.Blodtype.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Blodtype.Name = "Blodtype"
        Me.Blodtype.Size = New System.Drawing.Size(0, 19)
        Me.Blodtype.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 210)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Blodtype:"
        '
        'Epost
        '
        Me.Epost.AutoSize = True
        Me.Epost.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Epost.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Epost.Location = New System.Drawing.Point(152, 178)
        Me.Epost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Epost.Name = "Epost"
        Me.Epost.Size = New System.Drawing.Size(0, 19)
        Me.Epost.TabIndex = 12
        '
        'Navn
        '
        Me.Navn.AutoSize = True
        Me.Navn.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Navn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Navn.Location = New System.Drawing.Point(152, 22)
        Me.Navn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Navn.Name = "Navn"
        Me.Navn.Size = New System.Drawing.Size(0, 19)
        Me.Navn.TabIndex = 1
        '
        'fdato
        '
        Me.fdato.AutoSize = True
        Me.fdato.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.fdato.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fdato.Location = New System.Drawing.Point(152, 115)
        Me.fdato.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.fdato.Name = "fdato"
        Me.fdato.Size = New System.Drawing.Size(0, 19)
        Me.fdato.TabIndex = 11
        '
        'Mobilnummer
        '
        Me.Mobilnummer.AutoSize = True
        Me.Mobilnummer.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Mobilnummer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Mobilnummer.Location = New System.Drawing.Point(151, 145)
        Me.Mobilnummer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Mobilnummer.Name = "Mobilnummer"
        Me.Mobilnummer.Size = New System.Drawing.Size(0, 19)
        Me.Mobilnummer.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Adresse:"
        '
        'Postnr
        '
        Me.Postnr.AutoSize = True
        Me.Postnr.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Postnr.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Postnr.Location = New System.Drawing.Point(152, 53)
        Me.Postnr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Postnr.Name = "Postnr"
        Me.Postnr.Size = New System.Drawing.Size(0, 19)
        Me.Postnr.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
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
        Me.Adresse.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Adresse.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Adresse.Location = New System.Drawing.Point(152, 84)
        Me.Adresse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(0, 19)
        Me.Adresse.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 145)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Mobilnummer:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 178)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "E-postadresse:"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Bestill)
        Me.GroupBox2.Controls.Add(Me.Logg_ut)
        Me.GroupBox2.Controls.Add(Me.Se_tidligere)
        Me.GroupBox2.Controls.Add(Me.Nestetekst)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Egenerklæring_knapp)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Neste)
        Me.GroupBox2.Controls.Add(Me.Forrige)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(424, 129)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(402, 314)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Givning:"
        '
        'Bestill
        '
        Me.Bestill.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Bestill.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Bestill.ForeColor = System.Drawing.Color.White
        Me.Bestill.Location = New System.Drawing.Point(76, 178)
        Me.Bestill.Name = "Bestill"
        Me.Bestill.Size = New System.Drawing.Size(251, 35)
        Me.Bestill.TabIndex = 26
        Me.Bestill.Text = "Bestill time"
        Me.Bestill.UseVisualStyleBackColor = False
        '
        'Logg_ut
        '
        Me.Logg_ut.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Logg_ut.ForeColor = System.Drawing.Color.White
        Me.Logg_ut.Location = New System.Drawing.Point(314, 273)
        Me.Logg_ut.Name = "Logg_ut"
        Me.Logg_ut.Size = New System.Drawing.Size(83, 35)
        Me.Logg_ut.TabIndex = 25
        Me.Logg_ut.Text = "Logg ut"
        Me.Logg_ut.UseVisualStyleBackColor = False
        '
        'Se_tidligere
        '
        Me.Se_tidligere.AutoSize = True
        Me.Se_tidligere.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Se_tidligere.Location = New System.Drawing.Point(19, 273)
        Me.Se_tidligere.Name = "Se_tidligere"
        Me.Se_tidligere.Size = New System.Drawing.Size(227, 19)
        Me.Se_tidligere.TabIndex = 24
        Me.Se_tidligere.TabStop = True
        Me.Se_tidligere.Text = "Se alle tidliger blodtappinger"
        '
        'Nestetekst
        '
        Me.Nestetekst.AutoSize = True
        Me.Nestetekst.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Nestetekst.Location = New System.Drawing.Point(19, 84)
        Me.Nestetekst.Name = "Nestetekst"
        Me.Nestetekst.Size = New System.Drawing.Size(0, 19)
        Me.Nestetekst.TabIndex = 23
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30"})
        Me.ComboBox1.Location = New System.Drawing.Point(77, 146)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(251, 27)
        Me.ComboBox1.TabIndex = 22
        Me.ComboBox1.Text = "Klokkeslett"
        '
        'Egenerklæring_knapp
        '
        Me.Egenerklæring_knapp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Egenerklæring_knapp.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Egenerklæring_knapp.ForeColor = System.Drawing.Color.White
        Me.Egenerklæring_knapp.Location = New System.Drawing.Point(77, 222)
        Me.Egenerklæring_knapp.Name = "Egenerklæring_knapp"
        Me.Egenerklæring_knapp.Size = New System.Drawing.Size(251, 35)
        Me.Egenerklæring_knapp.TabIndex = 21
        Me.Egenerklæring_knapp.Text = "Egenerklæring"
        Me.Egenerklæring_knapp.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker1.Location = New System.Drawing.Point(77, 115)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(251, 27)
        Me.DateTimePicker1.TabIndex = 19
        '
        'Neste
        '
        Me.Neste.AutoSize = True
        Me.Neste.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Neste.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Neste.Location = New System.Drawing.Point(263, 53)
        Me.Neste.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Neste.Name = "Neste"
        Me.Neste.Size = New System.Drawing.Size(51, 19)
        Me.Neste.TabIndex = 18
        Me.Neste.Text = "Neste"
        '
        'Forrige
        '
        Me.Forrige.AutoSize = True
        Me.Forrige.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Forrige.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Forrige.Location = New System.Drawing.Point(163, 22)
        Me.Forrige.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Forrige.Name = "Forrige"
        Me.Forrige.Size = New System.Drawing.Size(63, 19)
        Me.Forrige.TabIndex = 17
        Me.Forrige.Text = "Forrige"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Siste blodtapping:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 53)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(241, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Dager til neste mulige tapping:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(103, 223)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(335, 43)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Bestill time"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Header
        '
        Me.Header.AutoSize = True
        Me.Header.Font = New System.Drawing.Font("Calibri", 51.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Header.Location = New System.Drawing.Point(284, 19)
        Me.Header.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(298, 83)
        Me.Header.TabIndex = 0
        Me.Header.Text = "MIN SIDE"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Header)
        Me.Panel1.Location = New System.Drawing.Point(84, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 484)
        Me.Panel1.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 22)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 19)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Navn:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(17, 53)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 19)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Postnr:"
        '
        'MinSideGiver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1071, 703)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MinSideGiver"
        Me.Text = "E"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AvsluttToolStripMenuItem2 As ToolStripMenuItem
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
    Friend WithEvents Se_tidligere As LinkLabel
    Friend WithEvents Logg_ut As Button
    Friend WithEvents Bestill As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
