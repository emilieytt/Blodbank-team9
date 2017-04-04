<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrerBlod
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.A_p = New System.Windows.Forms.CheckBox()
        Me.n_m = New System.Windows.Forms.CheckBox()
        Me.n_p = New System.Windows.Forms.CheckBox()
        Me.b_m = New System.Windows.Forms.CheckBox()
        Me.b_p = New System.Windows.Forms.CheckBox()
        Me.ab_m = New System.Windows.Forms.CheckBox()
        Me.ab_p = New System.Windows.Forms.CheckBox()
        Me.a_m = New System.Windows.Forms.CheckBox()
        Me.type_n_m = New System.Windows.Forms.Label()
        Me.type_n_p = New System.Windows.Forms.Label()
        Me.type_b_m = New System.Windows.Forms.Label()
        Me.type_b_p = New System.Windows.Forms.Label()
        Me.type_ab_m = New System.Windows.Forms.Label()
        Me.type_ab_p = New System.Windows.Forms.Label()
        Me.type_a_m = New System.Windows.Forms.Label()
        Me.type_ap = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Legg_til = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvsluttToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ta_ut = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Ta_ut)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Legg_til)
        Me.Panel1.Location = New System.Drawing.Point(102, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 596)
        Me.Panel1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Plasma", "Plate", "Røde blodlegemer"})
        Me.ComboBox1.Location = New System.Drawing.Point(26, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(362, 33)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "Velg komponenttype"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.A_p)
        Me.GroupBox1.Controls.Add(Me.n_m)
        Me.GroupBox1.Controls.Add(Me.n_p)
        Me.GroupBox1.Controls.Add(Me.b_m)
        Me.GroupBox1.Controls.Add(Me.b_p)
        Me.GroupBox1.Controls.Add(Me.ab_m)
        Me.GroupBox1.Controls.Add(Me.ab_p)
        Me.GroupBox1.Controls.Add(Me.a_m)
        Me.GroupBox1.Controls.Add(Me.type_n_m)
        Me.GroupBox1.Controls.Add(Me.type_n_p)
        Me.GroupBox1.Controls.Add(Me.type_b_m)
        Me.GroupBox1.Controls.Add(Me.type_b_p)
        Me.GroupBox1.Controls.Add(Me.type_ab_m)
        Me.GroupBox1.Controls.Add(Me.type_ab_p)
        Me.GroupBox1.Controls.Add(Me.type_a_m)
        Me.GroupBox1.Controls.Add(Me.type_ap)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(26, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 406)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Underline)
        Me.Label10.Location = New System.Drawing.Point(119, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 23)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Antall blodposer"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Underline)
        Me.Label9.Location = New System.Drawing.Point(7, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 23)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Blodtype"
        '
        'A_p
        '
        Me.A_p.AutoSize = True
        Me.A_p.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_p.Location = New System.Drawing.Point(295, 89)
        Me.A_p.Name = "A_p"
        Me.A_p.Size = New System.Drawing.Size(15, 14)
        Me.A_p.TabIndex = 16
        Me.A_p.UseVisualStyleBackColor = True
        '
        'n_m
        '
        Me.n_m.AutoSize = True
        Me.n_m.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n_m.Location = New System.Drawing.Point(295, 377)
        Me.n_m.Name = "n_m"
        Me.n_m.Size = New System.Drawing.Size(15, 14)
        Me.n_m.TabIndex = 22
        Me.n_m.UseVisualStyleBackColor = True
        '
        'n_p
        '
        Me.n_p.AutoSize = True
        Me.n_p.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n_p.Location = New System.Drawing.Point(295, 335)
        Me.n_p.Name = "n_p"
        Me.n_p.Size = New System.Drawing.Size(15, 14)
        Me.n_p.TabIndex = 21
        Me.n_p.UseVisualStyleBackColor = True
        '
        'b_m
        '
        Me.b_m.AutoSize = True
        Me.b_m.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_m.Location = New System.Drawing.Point(295, 293)
        Me.b_m.Name = "b_m"
        Me.b_m.Size = New System.Drawing.Size(15, 14)
        Me.b_m.TabIndex = 20
        Me.b_m.UseVisualStyleBackColor = True
        '
        'b_p
        '
        Me.b_p.AutoSize = True
        Me.b_p.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_p.Location = New System.Drawing.Point(295, 254)
        Me.b_p.Name = "b_p"
        Me.b_p.Size = New System.Drawing.Size(15, 14)
        Me.b_p.TabIndex = 19
        Me.b_p.UseVisualStyleBackColor = True
        '
        'ab_m
        '
        Me.ab_m.AutoSize = True
        Me.ab_m.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ab_m.Location = New System.Drawing.Point(295, 215)
        Me.ab_m.Name = "ab_m"
        Me.ab_m.Size = New System.Drawing.Size(15, 14)
        Me.ab_m.TabIndex = 18
        Me.ab_m.UseVisualStyleBackColor = True
        '
        'ab_p
        '
        Me.ab_p.AutoSize = True
        Me.ab_p.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ab_p.Location = New System.Drawing.Point(295, 170)
        Me.ab_p.Name = "ab_p"
        Me.ab_p.Size = New System.Drawing.Size(15, 14)
        Me.ab_p.TabIndex = 17
        Me.ab_p.UseVisualStyleBackColor = True
        '
        'a_m
        '
        Me.a_m.AutoSize = True
        Me.a_m.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_m.Location = New System.Drawing.Point(295, 130)
        Me.a_m.Name = "a_m"
        Me.a_m.Size = New System.Drawing.Size(15, 14)
        Me.a_m.TabIndex = 16
        Me.a_m.UseVisualStyleBackColor = True
        '
        'type_n_m
        '
        Me.type_n_m.AutoSize = True
        Me.type_n_m.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.type_n_m.Location = New System.Drawing.Point(149, 369)
        Me.type_n_m.Name = "type_n_m"
        Me.type_n_m.Size = New System.Drawing.Size(0, 23)
        Me.type_n_m.TabIndex = 15
        '
        'type_n_p
        '
        Me.type_n_p.AutoSize = True
        Me.type_n_p.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.type_n_p.Location = New System.Drawing.Point(149, 327)
        Me.type_n_p.Name = "type_n_p"
        Me.type_n_p.Size = New System.Drawing.Size(0, 23)
        Me.type_n_p.TabIndex = 14
        '
        'type_b_m
        '
        Me.type_b_m.AutoSize = True
        Me.type_b_m.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.type_b_m.Location = New System.Drawing.Point(149, 285)
        Me.type_b_m.Name = "type_b_m"
        Me.type_b_m.Size = New System.Drawing.Size(0, 23)
        Me.type_b_m.TabIndex = 13
        '
        'type_b_p
        '
        Me.type_b_p.AutoSize = True
        Me.type_b_p.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.type_b_p.Location = New System.Drawing.Point(149, 245)
        Me.type_b_p.Name = "type_b_p"
        Me.type_b_p.Size = New System.Drawing.Size(0, 23)
        Me.type_b_p.TabIndex = 12
        '
        'type_ab_m
        '
        Me.type_ab_m.AutoSize = True
        Me.type_ab_m.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.type_ab_m.Location = New System.Drawing.Point(149, 207)
        Me.type_ab_m.Name = "type_ab_m"
        Me.type_ab_m.Size = New System.Drawing.Size(0, 23)
        Me.type_ab_m.TabIndex = 11
        '
        'type_ab_p
        '
        Me.type_ab_p.AutoSize = True
        Me.type_ab_p.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.type_ab_p.Location = New System.Drawing.Point(149, 162)
        Me.type_ab_p.Name = "type_ab_p"
        Me.type_ab_p.Size = New System.Drawing.Size(0, 23)
        Me.type_ab_p.TabIndex = 10
        '
        'type_a_m
        '
        Me.type_a_m.AutoSize = True
        Me.type_a_m.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.type_a_m.Location = New System.Drawing.Point(149, 121)
        Me.type_a_m.Name = "type_a_m"
        Me.type_a_m.Size = New System.Drawing.Size(0, 23)
        Me.type_a_m.TabIndex = 9
        '
        'type_ap
        '
        Me.type_ap.AutoSize = True
        Me.type_ap.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.type_ap.Location = New System.Drawing.Point(149, 80)
        Me.type_ap.Name = "type_ap"
        Me.type_ap.Size = New System.Drawing.Size(0, 23)
        Me.type_ap.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(7, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "0-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "0+"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(7, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "B-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(7, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "B+"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(7, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "AB-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "AB+"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A+"
        '
        'Legg_til
        '
        Me.Legg_til.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Legg_til.ForeColor = System.Drawing.Color.White
        Me.Legg_til.Location = New System.Drawing.Point(26, 512)
        Me.Legg_til.Name = "Legg_til"
        Me.Legg_til.Size = New System.Drawing.Size(182, 58)
        Me.Legg_til.TabIndex = 2
        Me.Legg_til.Text = "Legg til en blodpose"
        Me.Legg_til.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(863, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'Ta_ut
        '
        Me.Ta_ut.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Ta_ut.ForeColor = System.Drawing.Color.White
        Me.Ta_ut.Location = New System.Drawing.Point(214, 512)
        Me.Ta_ut.Name = "Ta_ut"
        Me.Ta_ut.Size = New System.Drawing.Size(174, 58)
        Me.Ta_ut.TabIndex = 3
        Me.Ta_ut.Text = "Ta ut en blodpose"
        Me.Ta_ut.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(351, 579)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(37, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Avbryt"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(133, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 31)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Blodlager"
        '
        'AdministrerBlod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 629)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdministrerBlod"
        Me.Text = "AdministrerBlod"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvsluttToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents type_n_m As Label
    Friend WithEvents type_n_p As Label
    Friend WithEvents type_b_m As Label
    Friend WithEvents type_b_p As Label
    Friend WithEvents type_ab_m As Label
    Friend WithEvents type_ab_p As Label
    Friend WithEvents type_a_m As Label
    Friend WithEvents type_ap As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Legg_til As Button
    Friend WithEvents Ta_ut As Button
    Friend WithEvents n_m As CheckBox
    Friend WithEvents n_p As CheckBox
    Friend WithEvents b_m As CheckBox
    Friend WithEvents b_p As CheckBox
    Friend WithEvents ab_m As CheckBox
    Friend WithEvents ab_p As CheckBox
    Friend WithEvents a_m As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents A_p As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label11 As Label
End Class
