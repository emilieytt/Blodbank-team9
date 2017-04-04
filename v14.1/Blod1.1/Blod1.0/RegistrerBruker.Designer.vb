<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrerBruker
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvsluttToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.År = New System.Windows.Forms.ComboBox()
        Me.Måned = New System.Windows.Forms.ComboBox()
        Me.Dag = New System.Windows.Forms.ComboBox()
        Me.kjonn = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Passord2 = New System.Windows.Forms.TextBox()
        Me.Passord1 = New System.Windows.Forms.TextBox()
        Me.nyGiverBtn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Post_nr = New System.Windows.Forms.TextBox()
        Me.Adresse = New System.Windows.Forms.TextBox()
        Me.Epost = New System.Windows.Forms.TextBox()
        Me.tlf_nr = New System.Windows.Forms.TextBox()
        Me.Etternavn = New System.Windows.Forms.TextBox()
        Me.Fornavn = New System.Windows.Forms.TextBox()
        Me.ErrorEpost = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorFornavn = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorEtternavn = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorFodslesnr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorTelefon = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorAdresse = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorPostnr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorPassord = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Errorkjonn = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Errordag = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorPassord2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Errormåned = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Errorår = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorEpost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorFornavn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorEtternavn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorFodslesnr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTelefon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorAdresse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPostnr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPassord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errorkjonn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errordag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPassord2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errormåned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errorår, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(995, 24)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.label14)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.År)
        Me.Panel1.Controls.Add(Me.Måned)
        Me.Panel1.Controls.Add(Me.Dag)
        Me.Panel1.Controls.Add(Me.kjonn)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Passord2)
        Me.Panel1.Controls.Add(Me.Passord1)
        Me.Panel1.Controls.Add(Me.nyGiverBtn)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Post_nr)
        Me.Panel1.Controls.Add(Me.Adresse)
        Me.Panel1.Controls.Add(Me.Epost)
        Me.Panel1.Controls.Add(Me.tlf_nr)
        Me.Panel1.Controls.Add(Me.Etternavn)
        Me.Panel1.Controls.Add(Me.Fornavn)
        Me.Panel1.Location = New System.Drawing.Point(55, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1041, 584)
        Me.Panel1.TabIndex = 1
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(863, 335)
        Me.label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(19, 19)
        Me.label14.TabIndex = 73
        Me.label14.Text = "?"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(716, 438)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 69)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Neste"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(668, 137)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Måned"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(768, 137)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 13)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "År"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(579, 137)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Dag"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(729, 393)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(111, 21)
        Me.RadioButton2.TabIndex = 68
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Skjul passord"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(609, 393)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(100, 21)
        Me.RadioButton1.TabIndex = 67
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Vis passord"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'År
        '
        Me.År.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.År.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.År.FormatString = "d"
        Me.År.FormattingEnabled = True
        Me.År.Items.AddRange(New Object() {"2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910", "1909", "1908", "1907", "1906", "1905", "1904", "1903", "1902", "1901", "1900"})
        Me.År.Location = New System.Drawing.Point(771, 154)
        Me.År.Name = "År"
        Me.År.Size = New System.Drawing.Size(91, 24)
        Me.År.TabIndex = 66
        '
        'Måned
        '
        Me.Måned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Måned.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Måned.FormattingEnabled = True
        Me.Måned.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Måned.Location = New System.Drawing.Point(676, 154)
        Me.Måned.Name = "Måned"
        Me.Måned.Size = New System.Drawing.Size(79, 24)
        Me.Måned.TabIndex = 65
        '
        'Dag
        '
        Me.Dag.AccessibleName = ""
        Me.Dag.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Dag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Dag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dag.FormattingEnabled = True
        Me.Dag.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.Dag.Location = New System.Drawing.Point(582, 154)
        Me.Dag.Name = "Dag"
        Me.Dag.Size = New System.Drawing.Size(69, 24)
        Me.Dag.TabIndex = 64
        '
        'kjonn
        '
        Me.kjonn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kjonn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kjonn.FormattingEnabled = True
        Me.kjonn.Items.AddRange(New Object() {"Kvinne", "Mann"})
        Me.kjonn.Location = New System.Drawing.Point(676, 47)
        Me.kjonn.Margin = New System.Windows.Forms.Padding(2)
        Me.kjonn.Name = "kjonn"
        Me.kjonn.Size = New System.Drawing.Size(101, 28)
        Me.kjonn.TabIndex = 63
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label11.Location = New System.Drawing.Point(455, 365)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 17)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Gjenta passord"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label10.Location = New System.Drawing.Point(455, 339)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 17)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Passord"
        '
        'Passord2
        '
        Me.Passord2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passord2.Location = New System.Drawing.Point(581, 361)
        Me.Passord2.Margin = New System.Windows.Forms.Padding(2)
        Me.Passord2.Name = "Passord2"
        Me.Passord2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passord2.Size = New System.Drawing.Size(281, 22)
        Me.Passord2.TabIndex = 60
        Me.Passord2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Passord1
        '
        Me.Passord1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passord1.Location = New System.Drawing.Point(581, 335)
        Me.Passord1.Margin = New System.Windows.Forms.Padding(2)
        Me.Passord1.Name = "Passord1"
        Me.Passord1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passord1.Size = New System.Drawing.Size(281, 22)
        Me.Passord1.TabIndex = 59
        Me.Passord1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nyGiverBtn
        '
        Me.nyGiverBtn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.nyGiverBtn.ForeColor = System.Drawing.Color.White
        Me.nyGiverBtn.Location = New System.Drawing.Point(580, 438)
        Me.nyGiverBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.nyGiverBtn.Name = "nyGiverBtn"
        Me.nyGiverBtn.Size = New System.Drawing.Size(140, 69)
        Me.nyGiverBtn.TabIndex = 58
        Me.nyGiverBtn.Text = "Fullfør Registrering"
        Me.nyGiverBtn.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(579, 518)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(91, 13)
        Me.LinkLabel1.TabIndex = 57
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Avbryt registrering"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label9.Location = New System.Drawing.Point(473, 13)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 26)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Ny blodgiver"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label7.Location = New System.Drawing.Point(456, 283)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Postnummer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label6.Location = New System.Drawing.Point(456, 251)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Adresse"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label5.Location = New System.Drawing.Point(456, 219)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Epost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Location = New System.Drawing.Point(456, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Mobilnummer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Location = New System.Drawing.Point(456, 156)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Fødselsdato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Location = New System.Drawing.Point(455, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Etternavn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(455, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Fornavn"
        '
        'Post_nr
        '
        Me.Post_nr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Post_nr.Location = New System.Drawing.Point(582, 280)
        Me.Post_nr.Margin = New System.Windows.Forms.Padding(2)
        Me.Post_nr.Name = "Post_nr"
        Me.Post_nr.Size = New System.Drawing.Size(281, 22)
        Me.Post_nr.TabIndex = 48
        Me.Post_nr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Adresse
        '
        Me.Adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adresse.Location = New System.Drawing.Point(582, 248)
        Me.Adresse.Margin = New System.Windows.Forms.Padding(2)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(281, 22)
        Me.Adresse.TabIndex = 47
        Me.Adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Epost
        '
        Me.Epost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Epost.Location = New System.Drawing.Point(582, 216)
        Me.Epost.Margin = New System.Windows.Forms.Padding(2)
        Me.Epost.Name = "Epost"
        Me.Epost.Size = New System.Drawing.Size(281, 22)
        Me.Epost.TabIndex = 46
        Me.Epost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tlf_nr
        '
        Me.tlf_nr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlf_nr.Location = New System.Drawing.Point(582, 183)
        Me.tlf_nr.Margin = New System.Windows.Forms.Padding(2)
        Me.tlf_nr.Name = "tlf_nr"
        Me.tlf_nr.Size = New System.Drawing.Size(281, 22)
        Me.tlf_nr.TabIndex = 45
        Me.tlf_nr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Etternavn
        '
        Me.Etternavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etternavn.Location = New System.Drawing.Point(580, 113)
        Me.Etternavn.Margin = New System.Windows.Forms.Padding(2)
        Me.Etternavn.Name = "Etternavn"
        Me.Etternavn.Size = New System.Drawing.Size(282, 22)
        Me.Etternavn.TabIndex = 44
        Me.Etternavn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fornavn
        '
        Me.Fornavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fornavn.Location = New System.Drawing.Point(581, 82)
        Me.Fornavn.Margin = New System.Windows.Forms.Padding(2)
        Me.Fornavn.Name = "Fornavn"
        Me.Fornavn.Size = New System.Drawing.Size(281, 22)
        Me.Fornavn.TabIndex = 43
        Me.Fornavn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ErrorEpost
        '
        Me.ErrorEpost.ContainerControl = Me
        '
        'ErrorFornavn
        '
        Me.ErrorFornavn.ContainerControl = Me
        '
        'ErrorEtternavn
        '
        Me.ErrorEtternavn.ContainerControl = Me
        '
        'ErrorFodslesnr
        '
        Me.ErrorFodslesnr.ContainerControl = Me
        '
        'ErrorTelefon
        '
        Me.ErrorTelefon.ContainerControl = Me
        '
        'ErrorAdresse
        '
        Me.ErrorAdresse.ContainerControl = Me
        '
        'ErrorPostnr
        '
        Me.ErrorPostnr.ContainerControl = Me
        '
        'ErrorPassord
        '
        Me.ErrorPassord.ContainerControl = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Errorkjonn
        '
        Me.Errorkjonn.ContainerControl = Me
        '
        'Errordag
        '
        Me.Errordag.ContainerControl = Me
        '
        'ErrorPassord2
        '
        Me.ErrorPassord2.ContainerControl = Me
        '
        'Errormåned
        '
        Me.Errormåned.ContainerControl = Me
        '
        'Errorår
        '
        Me.Errorår.ContainerControl = Me
        '
        'RegistrerBruker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 718)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RegistrerBruker"
        Me.Text = "RegistrerBruker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorEpost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorFornavn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorEtternavn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorFodslesnr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTelefon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorAdresse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPostnr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPassord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errorkjonn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errordag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPassord2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errormåned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errorår, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvsluttToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents label14 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents År As ComboBox
    Friend WithEvents Måned As ComboBox
    Friend WithEvents Dag As ComboBox
    Friend WithEvents kjonn As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Passord2 As TextBox
    Friend WithEvents Passord1 As TextBox
    Friend WithEvents nyGiverBtn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Post_nr As TextBox
    Friend WithEvents Adresse As TextBox
    Friend WithEvents Epost As TextBox
    Friend WithEvents tlf_nr As TextBox
    Friend WithEvents Etternavn As TextBox
    Friend WithEvents Fornavn As TextBox
    Friend WithEvents ErrorEpost As ErrorProvider
    Friend WithEvents ErrorFornavn As ErrorProvider
    Friend WithEvents ErrorEtternavn As ErrorProvider
    Friend WithEvents ErrorFodslesnr As ErrorProvider
    Friend WithEvents ErrorTelefon As ErrorProvider
    Friend WithEvents ErrorAdresse As ErrorProvider
    Friend WithEvents ErrorPostnr As ErrorProvider
    Friend WithEvents ErrorPassord As ErrorProvider
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Errorkjonn As ErrorProvider
    Friend WithEvents Errordag As ErrorProvider
    Friend WithEvents ErrorPassord2 As ErrorProvider
    Friend WithEvents Errormåned As ErrorProvider
    Friend WithEvents Errorår As ErrorProvider
End Class
