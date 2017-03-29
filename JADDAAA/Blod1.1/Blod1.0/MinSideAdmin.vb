Imports MySql.Data.MySqlClient
Public Class MinSideAdmin

    Public tilkobling As MySqlConnection
    Dim constring As String = "Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;"
    'Private tilkobling2 As MySqlConnection
    Dim tilkobling3 As New MySqlConnection(constring)
    Dim dt As New DataTable()
    Dim adapter As MySqlDataAdapter
    Dim cmd As MySqlCommand



    Private Sub MinSideAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip2.BackColor = Color.CornflowerBlue

        ' tilkobling2 = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
        '"Database=g_oops_09;" &
        '"Uid=g_oops_09;" &
        '"Pwd=IxKu1h4H;")






        ' load_table()

        'Try
        tilkobling3.Open()

        DataGridView2.ColumnCount = 13
        DataGridView2.Columns(0).Name = "bruker_id"
        DataGridView2.Columns(1).Name = "bruker_type"
        DataGridView2.Columns(2).Name = "fodselsdato"
        DataGridView2.Columns(3).Name = "f_navn"
        DataGridView2.Columns(4).Name = "e_navn"
        DataGridView2.Columns(5).Name = "epost"
        DataGridView2.Columns(6).Name = "passord"
        DataGridView2.Columns(7).Name = "tlf_nr"
        DataGridView2.Columns(8).Name = "adresse"
        DataGridView2.Columns(9).Name = "postnr"
        DataGridView2.Columns(10).Name = "kjonn"
        DataGridView2.Columns(11).Name = "epost_godtatt"
        DataGridView2.Columns(12).Name = "blodtype"


        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        tilkobling3.Close()
        'Catch ex As MySqlException
        'MsgBox(ex.Message)
        ' End Try
        Retrieve()
    End Sub
    Private Sub CLEARTEXT()
        Endre_bruker.Text = ""
        Endre_brukertype.Text = ""
        Endre_fodselsdato.Text = ""
        Endre_fornavn.Text = ""
        Endre_enavn.Text = ""
        Endre_epost.Text = ""
        Endre_passord.Text = ""
        Endre_tlfnr.Text = ""
        Endre_adresse.Text = ""
        Endre_postnr.Text = ""
        Endre_kjønn.Text = ""
        Epost_godtatt.Text = ""
        Endre_blodtype.Text = ""
    End Sub
    Private Sub Add()
        Dim addSql As String = "INSERT INTO Bruker (bruker_id, bruker_type, fodselsdato, f_navn, e_navn, epost, passord, tlf_nr, adresse, postnr, kjonn, epost_godtatt, blodtype) 
                                            VALUES (@BRUKER_ID, @BRUKER_TYPE, @FODSELSDATO, @F_NAVN, @E_NAVN, @EPOST, @PASSORD, @TLF_NR, @ADRESSE, @POSTNR, @KJONN, @EPOST_GODTATT, @BLODTYPE) "
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(addSql, tilkobling3)
        cmd.Parameters.AddWithValue("@BRUKER_ID", Endre_bruker.Text)
        cmd.Parameters.AddWithValue("@BRUKER_TYPE", Endre_brukertype.Text)
        cmd.Parameters.AddWithValue("@FODSELSDATO", Endre_fodselsdato.Text)
        cmd.Parameters.AddWithValue("@F_NAVN", Endre_fornavn.Text)
        cmd.Parameters.AddWithValue("@E_NAVN", Endre_enavn.Text)
        cmd.Parameters.AddWithValue("@EPOST", Endre_epost.Text)
        cmd.Parameters.AddWithValue("@PASSORD", Endre_passord.Text)
        cmd.Parameters.AddWithValue("@TLF_NR", Endre_tlfnr.Text)
        cmd.Parameters.AddWithValue("@ADRESSE", Endre_adresse.Text)
        cmd.Parameters.AddWithValue("@POSTNR", Endre_postnr.Text)
        cmd.Parameters.AddWithValue("@KJONN", Endre_kjønn.Text)
        cmd.Parameters.AddWithValue("@EPOST_GODTATT", Epost_godtatt.Text)
        cmd.Parameters.AddWithValue("@BLODTYPE", Endre_blodtype.Text)

        Try
            tilkobling3.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Data inserted")

                CLEARTEXT()

            End If
            tilkobling3.Close()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Populate(bruker_id As String, bruker_type As String, fodselsdato As String, f_navn As String, e_navn As String, epost As String, passord As String, tlf_nr As String,
                        adresse As String, postnr As String, kjonn As String, epost_godtatt As String, blodtype As String)

        Dim row As String() = New String() {bruker_id, bruker_type, fodselsdato, f_navn, e_navn, epost, passord, tlf_nr, adresse, postnr, kjonn, epost_godtatt, blodtype}
        DataGridView2.Rows.Add(row)

    End Sub
    'Retrieve data

    Private Sub Retrieve()


        DataGridView2.Rows.Clear()
        ' bruker_id, bruker_type, fodselsdato, f_navn, e_navn, epost, passord, tlf_nr, adresse, postnr, kjonn, epost_godtatt, blodtype
        Dim sql As String = "SELECT * FROM Bruker"
        Dim cmd As New MySqlCommand(sql, tilkobling3)

        Try
            tilkobling3.Open()

            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(dt)

            'Fyll rad
            For Each row In dt.Rows

                Populate(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12))

                'Catch ex As Exception
                '    MsgBox(ex.Message)
                'End Try

                'Catch ex As Exception
                'dt.Rows.Add("NULL")
                ' End Try
            Next
            tilkobling3.Close()

            'Retrieve()

        Catch ex As Exception
            MsgBox(ex.Message)
            tilkobling3.Close()

        End Try


    End Sub

    Private Sub UpdateDG(bruker_id As String)
        'bruker_id='" & Endre_bruker.Text & "', 
        ' Dim sql As String = "UPDATE Bruker set bruker_type='" & Endre_brukertype.Text & "', fodselsdato='" & Endre_fodselsdato.Text & "', f_navn='" & Endre_fornavn.Text & "', e_navn='" & Endre_enavn.Text & "', epost='" & Endre_epost.Text & "', passord='" & Endre_passord.Text & "', tlf_nr='" & Endre_tlfnr.Text & "', adresse='" & Endre_adresse.Text & "', postnr='" & Endre_postnr.Text & "', kjonn='" & Endre_kjønn.Text & "', epost_godtatt='" & Epost_godtatt.Text & "', blodtype='" & Endre_blodtype.Text & "' "
        Dim sql As String = "UPDATE Bruker Set bruker_type =@BRUKER_type, fodselsdato =@FODSELSDATO, f_navn = @F_NAVN , e_navn = @E_NAVN , passord = @PASSORD , adresse = @ADRESSE ,  tlf_nr = @TLF_NR ,  postnr = @POSTNR , kjonn =@KJONN , epost_godtatt = @EPOST_GODTATT , blodtype =@BLODTYPE WHERE Bruker_ID ='" & DataGridView2.SelectedRows(0).Cells(0).Value & "'"


        Try
            tilkobling3.Open()
            'adapter.UpdateCommand = tilkobling3.CreateCommand()
            'adapter.UpdateCommand.CommandText = sql

            Dim cmd As New MySqlCommand(sql, tilkobling3)
            'cmd.Parameters.AddWithValue("@BRUKER_ID", Endre_bruker.Text)
            cmd.Parameters.AddWithValue("@BRUKER_TYPE", Endre_brukertype.Text)
            cmd.Parameters.AddWithValue("@FODSELSDATO", Endre_fodselsdato.Text)
            cmd.Parameters.AddWithValue("@F_NAVN", Endre_fornavn.Text)
            cmd.Parameters.AddWithValue("@E_NAVN", Endre_enavn.Text)
            'cmd.Parameters.AddWithValue("@EPOST", Endre_epost.Text)
            cmd.Parameters.AddWithValue("@PASSORD", Endre_passord.Text)
            cmd.Parameters.AddWithValue("@TLF_NR", Endre_tlfnr.Text)
            cmd.Parameters.AddWithValue("@ADRESSE", Endre_adresse.Text)
            cmd.Parameters.AddWithValue("@POSTNR", Endre_postnr.Text)
            cmd.Parameters.AddWithValue("@KJONN", Endre_kjønn.Text)
            cmd.Parameters.AddWithValue("@EPOST_GODTATT", Epost_godtatt.Text)
            cmd.Parameters.AddWithValue("@BLODTYPE", Endre_blodtype.Text)

            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("JIPPI ")

            End If

            tilkobling3.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            tilkobling3.Close()

        End Try


        'Try
        '    If Endre_passord1.Text <> Endre_passord2.Text Then
        '        MsgBox("Du må skrive inn samme passord")

        '    Else


        '        If MessageBox.Show("Vil du virkelig endre info?", "Endre info", MessageBoxButtons.YesNo) = vbYes Then
        '            cmd.ExecuteNonQuery()
        '            MsgBox("Info endret!")
        '            Me.Close()
        '            MinSideGiver.Show()

        '        End If


        '    End If


        'Catch ex As MySqlException
        '    MsgBox(ex.Message)

        '    Throw New Exception("Error " + ex.Message)


        'End Try

    End Sub

    Private Sub Delete(bruker_id As String)
        Dim sql As String = "DELETE FROM Bruker WHERE bruker_id='" + Endre_bruker.Text + "'"
        Dim cmd As New MySqlCommand(sql, tilkobling3)

        Try
            tilkobling3.Open()
            adapter.DeleteCommand = tilkobling3.CreateCommand()
            adapter.DeleteCommand.CommandText = sql

            ' If MessageBox.Show("Vil du slette data?", "Slett", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Window Then
            tilkobling3.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            tilkobling3.Close()
        End Try

    End Sub



    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()
    End Sub


    'Private Sub load_table()
    '    Dim SDA As New MySqlDataAdapter
    '    Dim dbDataset As New DataTable
    '    Dim bSource As New BindingSource
    '    Try

    '        Dim navnSporring = "SELECT epost, f_navn, e_navn, passord, adresse, tlf_nr, postnr from Bruker "
    '        Dim sqlnavn2 As New MySqlCommand(navnSporring, tilkobling2)
    '        SDA.SelectCommand = sqlnavn2
    '        SDA.Fill(dbDataset)
    '        bSource.DataSource = dbDataset
    '        DataGridView2.DataSource = bSource
    '        SDA.Update(dbDataset)

    '    Catch ex As MySqlException
    '        MsgBox(ex.Message)
    '    End Try


    'End Sub

    'Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
    '    'Avslutter programmet
    '    Me.Close()
    'End Sub




    'Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
    '    'Avslutter programmet
    '    Me.Close()
    'End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Dim id As String = DataGridView2.SelectedRows(0).Cells(0).Value
        UpdateDG(id)
    End Sub


    Private Sub Se_brukere_Click(sender As Object, e As EventArgs) Handles Se_brukere.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Try

            Dim navnSporring = "Select bruker_id, f_navn, e_navn, epost, passord, adresse, tlf_nr, postnr from Bruker "
            Dim sqlnavn2 As New MySqlCommand(navnSporring, tilkobling3)
            SDA.SelectCommand = sqlnavn2
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView2.DataSource = bSource
            SDA.Update(dbDataset)

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MinSideAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim dialog As DialogResult

        dialog = MessageBox.Show("Vil du avslutte?", "Avslutt", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If dialog = DialogResult.No Then

            e.Cancel = True

        Else
            Application.ExitThread()

        End If
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        Add()
    End Sub

    Private Sub DataGridView2_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseClick
        Dim bruker_id As Integer = DataGridView2.SelectedRows(0).Cells(0).Value
        Dim bruker_type As Integer = DataGridView2.SelectedRows(0).Cells(1).Value
        Dim fodselsdato As Date = DataGridView2.SelectedRows(0).Cells(2).Value
        Dim f_navn As String = DataGridView2.SelectedRows(0).Cells(3).Value
        Dim e_navn As String = DataGridView2.SelectedRows(0).Cells(4).Value
        Dim epost As String = DataGridView2.SelectedRows(0).Cells(5).Value
        Dim passord As String = DataGridView2.SelectedRows(0).Cells(6).Value
        Dim tlf_nr As Integer = DataGridView2.SelectedRows(0).Cells(7).Value
        Dim adresse As String = DataGridView2.SelectedRows(0).Cells(8).Value
        Dim postnr As Integer = DataGridView2.SelectedRows(0).Cells(9).Value
        Dim kjonn As Integer = DataGridView2.SelectedRows(0).Cells(10).Value
        Dim Epostgodtatt As Boolean = DataGridView2.SelectedRows(0).Cells(11).Value
        Dim blodtype As String = DataGridView2.SelectedRows(0).Cells(12).Value

        'Try
        '    Dim Epostgodtatt As Integer = DataGridView2.SelectedRows(0).Cells(12).Value
        '    Epost_godtatt.Text = Epostgodtatt
        'Catch ex As Exception
        '    Epost_godtatt.Text = "ost"
        'End Try

        'Try
        '    Dim blodtype As String = DataGridView2.SelectedRows(0).Cells(13).Value
        '    Endre_blodtype.Text = blodtype

        'Catch ex As Exception
        '    Endre_blodtype.Text = "ost"
        'End Try



        Endre_bruker.Text = bruker_id
        Endre_brukertype.Text = bruker_type
        Endre_fodselsdato.Text = fodselsdato
        Endre_fornavn.Text = f_navn
        Endre_enavn.Text = e_navn
        Endre_epost.Text = epost
        Endre_passord.Text = passord
        Endre_tlfnr.Text = tlf_nr
        Endre_adresse.Text = adresse
        Endre_postnr.Text = postnr
        Endre_kjønn.Text = kjonn
        Epost_godtatt.Text = Epostgodtatt
        Endre_blodtype.Text = blodtype






    End Sub

    Private Sub Retrieve_btn_Click(sender As Object, e As EventArgs) Handles Retrieve_btn.Click
        DataGridView2.Rows.Clear()

        Retrieve()
    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        Dim id As String = DataGridView2.SelectedRows(0).Cells(0).Value
        Delete(id)
    End Sub





    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    '    Dim posisjon As Integer
    '    Dim antall As Integer
    '    Dim ds As New DataSet
    '    Dim navnSporring = "Select bruker_id, epost, f_navn, e_navn, postnr, adresse, tlf_nr, Fodselsdato, blodtype
    '                        from Bruker WHERE bruker_id='" & posisjon & "'"
    '    Dim sqlnavn As New MySqlCommand(navnSporring, tilkobling)
    '    Dim lesernavn = sqlnavn.ExecuteReader()




    '    If posisjon < Antall Then
    '        Try
    '            While lesernavn.Read()
    '                posisjon = posisjon + 1
    '                Navn.Text = lesernavn("f_navn") & " " & lesernavn("e_navn")
    '                Postnr.Text = lesernavn("postnr")
    '                Epost.Text = lesernavn("epost")
    '                fdato.Text = lesernavn("fodselsdato")
    '                Adresse.Text = lesernavn("adresse")
    '                Mobilnummer.Text = lesernavn("tlf_nr")
    '                Blodtype.Text = lesernavn("blodtype")
    '            End While
    '            lesernavn.Close()

    '        Catch ex As Exception

    '        End Try

    '    End If

    'End Sub


End Class