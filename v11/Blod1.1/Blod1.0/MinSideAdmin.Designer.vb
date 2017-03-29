<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MinSideAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvsluttToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Retrieve_btn = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Endre_kjønn = New System.Windows.Forms.TextBox()
        Me.Endre_postnr = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Epost_godtatt = New System.Windows.Forms.TextBox()
        Me.Endre_adresse = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Endre_tlfnr = New System.Windows.Forms.TextBox()
        Me.Endre_brukertype = New System.Windows.Forms.TextBox()
        Me.Endre_bruker = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Endre_epost = New System.Windows.Forms.TextBox()
        Me.Endre_enavn = New System.Windows.Forms.TextBox()
        Me.Endre_fornavn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Se_brukere = New System.Windows.Forms.Button()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.Endre_blodtype = New System.Windows.Forms.TextBox()
        Me.Endre_passord = New System.Windows.Forms.TextBox()
        Me.Endre_fodselsdato = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fodselsdato = New System.Windows.Forms.Label()
        Me.Delete_btn = New System.Windows.Forms.Button()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(1511, 28)
        Me.MenuStrip2.TabIndex = 7
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
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'AvsluttToolStripMenuItem
        '
        Me.AvsluttToolStripMenuItem.Name = "AvsluttToolStripMenuItem"
        Me.AvsluttToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.AvsluttToolStripMenuItem.Text = "Avslutt"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(468, 113)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1027, 673)
        Me.DataGridView2.TabIndex = 41
        '
        'Retrieve_btn
        '
        Me.Retrieve_btn.Location = New System.Drawing.Point(49, 636)
        Me.Retrieve_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Retrieve_btn.Name = "Retrieve_btn"
        Me.Retrieve_btn.Size = New System.Drawing.Size(100, 28)
        Me.Retrieve_btn.TabIndex = 127
        Me.Retrieve_btn.Text = "Retrieve"
        Me.Retrieve_btn.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(73, 504)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 17)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "Endre kjønn"
        '
        'Endre_kjønn
        '
        Me.Endre_kjønn.Location = New System.Drawing.Point(192, 501)
        Me.Endre_kjønn.Margin = New System.Windows.Forms.Padding(4)
        Me.Endre_kjønn.Name = "Endre_kjønn"
        Me.Endre_kjønn.Size = New System.Drawing.Size(132, 22)
        Me.Endre_kjønn.TabIndex = 125
        '
        'Endre_postnr
        '
        Me.Endre_postnr.Location = New System.Drawing.Point(192, 435)
        Me.Endre_postnr.Margin = New System.Windows.Forms.Padding(4)
        Me.Endre_postnr.Name = "Endre_postnr"
        Me.Endre_postnr.Size = New System.Drawing.Size(132, 22)
        Me.Endre_postnr.TabIndex = 124
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(75, 444)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "Postnr"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(75, 572)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 17)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Blodtype"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 536)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Epost godtatt"
        '
        'Epost_godtatt
        '
        Me.Epost_godtatt.Location = New System.Drawing.Point(192, 533)
        Me.Epost_godtatt.Margin = New System.Windows.Forms.Padding(4)
        Me.Epost_godtatt.Name = "Epost_godtatt"
        Me.Epost_godtatt.Size = New System.Drawing.Size(132, 22)
        Me.Epost_godtatt.TabIndex = 120
        '
        'Endre_adresse
        '
        Me.Endre_adresse.Location = New System.Drawing.Point(192, 466)
        Me.Endre_adresse.Margin = New System.Windows.Forms.Padding(4)
        Me.Endre_adresse.Name = "Endre_adresse"
        Me.Endre_adresse.Size = New System.Drawing.Size(132, 22)
        Me.Endre_adresse.TabIndex = 119
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(75, 475)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "Adresse"
        '
        'Endre_tlfnr
        '
        Me.Endre_tlfnr.Location = New System.Drawing.Point(192, 405)
        Me.Endre_tlfnr.Margin = New System.Windows.Forms.Padding(4)
        Me.Endre_tlfnr.Name = "Endre_tlfnr"
        Me.Endre_tlfnr.Size = New System.Drawing.Size(132, 22)
        Me.Endre_tlfnr.TabIndex = 117
        '
        'Endre_brukertype
        '
        Me.Endre_brukertype.Location = New System.Drawing.Point(192, 211)
        Me.Endre_brukertype.Margin = New System.Windows.Forms.Padding(4)
        Me.Endre_brukertype.Name = "Endre_brukertype"
        Me.Endre_brukertype.Size = New System.Drawing.Size(132, 22)
        Me.Endre_brukertype.TabIndex = 116
        '
        'Endre_bruker
        '
        Me.Endre_bruker.Location = New System.Drawing.Point(192, 179)
        Me.Endre_bruker.Margin = New System.Windows.Forms.Padding(4)
        Me.Endre_bruker.Name = "Endre_bruker"
        Me.Endre_bruker.Size = New System.Drawing.Size(132, 22)
        Me.Endre_bruker.TabIndex = 115
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Location = New System.Drawing.Point(73, 211)
        Me.Label99.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(77, 17)
        Me.Label99.TabIndex = 114
        Me.Label99.Text = "Brukertype"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(73, 179)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 17)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Bruker ID"
        '
        'Endre_epost
        '
        Me.Endre_epost.Location = New System.Drawing.Point(192, 344)
        Me.Endre_epost.Margin = New System.Windows.Forms.Padding(4)
        Me.Endre_epost.Name = "Endre_epost"
        Me.Endre_epost.Size = New System.Drawing.Size(132, 22)
        Me.Endre_epost.TabIndex = 112
        '
        'Endre_enavn
        '
        Me.Endre_enavn.Location = New System.Drawing.Point(192, 311)
        Me.Endre_enavn.Margin = New System.Windows.Forms.Padding(4)
        Me.Endre_enavn.Name = "Endre_enavn"
        Me.Endre_enavn.Size = New System.Drawing.Size(132, 22)
        Me.Endre_enavn.TabIndex = 111
        '
        'Endre_fornavn
        '
        Me.Endre_fornavn.Location = New System.Drawing.Point(192, 279)
        Me.Endre_fornavn.Margin = New System.Windows.Forms.Padding(4)
        Me.Endre_fornavn.Name = "Endre_fornavn"
        Me.Endre_fornavn.Size = New System.Drawing.Size(132, 22)
        Me.Endre_fornavn.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 344)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Epost"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 311)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Etternavn"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(73, 279)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Fornavn"
        '
        'Se_brukere
        '
        Me.Se_brukere.Location = New System.Drawing.Point(77, 113)
        Me.Se_brukere.Margin = New System.Windows.Forms.Padding(4)
        Me.Se_brukere.Name = "Se_brukere"
        Me.Se_brukere.Size = New System.Drawing.Size(311, 28)
        Me.Se_brukere.TabIndex = 106
        Me.Se_brukere.Text = "Se brukere"
        Me.Se_brukere.UseVisualStyleBackColor = True
        '
        'Add_btn
        '
        Me.Add_btn.Location = New System.Drawing.Point(49, 599)
        Me.Add_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(100, 28)
        Me.Add_btn.TabIndex = 105
        Me.Add_btn.Text = "Add"
        Me.Add_btn.UseVisualStyleBackColor = True
        '
        'Endre_blodtype
        '
        Me.Endre_blodtype.Location = New System.Drawing.Point(192, 568)
        Me.Endre_blodtype.Margin = New System.Windows.Forms.Padding(4)
        Me.Endre_blodtype.Name = "Endre_blodtype"
        Me.Endre_blodtype.Size = New System.Drawing.Size(132, 22)
        Me.Endre_blodtype.TabIndex = 104
        '
        'Endre_passord
        '
        Me.Endre_passord.Location = New System.Drawing.Point(192, 371)
        Me.Endre_passord.Margin = New System.Windows.Forms.Padding(4)
        Me.Endre_passord.Name = "Endre_passord"
        Me.Endre_passord.Size = New System.Drawing.Size(132, 22)
        Me.Endre_passord.TabIndex = 103
        '
        'Endre_fodselsdato
        '
        Me.Endre_fodselsdato.Location = New System.Drawing.Point(192, 241)
        Me.Endre_fodselsdato.Margin = New System.Windows.Forms.Padding(4)
        Me.Endre_fodselsdato.Name = "Endre_fodselsdato"
        Me.Endre_fodselsdato.Size = New System.Drawing.Size(132, 22)
        Me.Endre_fodselsdato.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 413)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Tlfnr"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 378)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Passord"
        '
        'Fodselsdato
        '
        Me.Fodselsdato.AutoSize = True
        Me.Fodselsdato.Location = New System.Drawing.Point(73, 241)
        Me.Fodselsdato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Fodselsdato.Name = "Fodselsdato"
        Me.Fodselsdato.Size = New System.Drawing.Size(85, 17)
        Me.Fodselsdato.TabIndex = 99
        Me.Fodselsdato.Text = "Fødselsdato"
        '
        'Delete_btn
        '
        Me.Delete_btn.Location = New System.Drawing.Point(288, 600)
        Me.Delete_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Delete_btn.Name = "Delete_btn"
        Me.Delete_btn.Size = New System.Drawing.Size(100, 28)
        Me.Delete_btn.TabIndex = 98
        Me.Delete_btn.Text = "Delete"
        Me.Delete_btn.UseVisualStyleBackColor = True
        '
        'Update_btn
        '
        Me.Update_btn.Location = New System.Drawing.Point(180, 600)
        Me.Update_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(100, 28)
        Me.Update_btn.TabIndex = 97
        Me.Update_btn.Text = "Update"
        Me.Update_btn.UseVisualStyleBackColor = True
        '
        'MinSideAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1511, 747)
        Me.Controls.Add(Me.Retrieve_btn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Endre_kjønn)
        Me.Controls.Add(Me.Endre_postnr)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Epost_godtatt)
        Me.Controls.Add(Me.Endre_adresse)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Endre_tlfnr)
        Me.Controls.Add(Me.Endre_brukertype)
        Me.Controls.Add(Me.Endre_bruker)
        Me.Controls.Add(Me.Label99)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Endre_epost)
        Me.Controls.Add(Me.Endre_enavn)
        Me.Controls.Add(Me.Endre_fornavn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Se_brukere)
        Me.Controls.Add(Me.Add_btn)
        Me.Controls.Add(Me.Endre_blodtype)
        Me.Controls.Add(Me.Endre_passord)
        Me.Controls.Add(Me.Endre_fodselsdato)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Fodselsdato)
        Me.Controls.Add(Me.Delete_btn)
        Me.Controls.Add(Me.Update_btn)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MinSideAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvsluttToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Retrieve_btn As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Endre_kjønn As TextBox
    Friend WithEvents Endre_postnr As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Epost_godtatt As TextBox
    Friend WithEvents Endre_adresse As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Endre_tlfnr As TextBox
    Friend WithEvents Endre_brukertype As TextBox
    Friend WithEvents Endre_bruker As TextBox
    Friend WithEvents Label99 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Endre_epost As TextBox
    Friend WithEvents Endre_enavn As TextBox
    Friend WithEvents Endre_fornavn As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Se_brukere As Button
    Friend WithEvents Add_btn As Button
    Friend WithEvents Endre_blodtype As TextBox
    Friend WithEvents Endre_passord As TextBox
    Friend WithEvents Endre_fodselsdato As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Fodselsdato As Label
    Friend WithEvents Delete_btn As Button
    Friend WithEvents Update_btn As Button
End Class
