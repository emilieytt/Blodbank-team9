Imports MySql.Data.MySqlClient
Public Class MinSideAdmin

    Public tilkobling As MySqlConnection
    Dim constring As String = "Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;"

    Dim tilkobling3 As New MySqlConnection(constring)
    Dim dt As New DataTable()
    Dim adapter As MySqlDataAdapter
    Dim cmd As MySqlCommand



    Private Sub MinSideAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip2.BackColor = Color.CornflowerBlue

        tilkobling3.Open()

        DataGridView2.ColumnCount = 13
        DataGridView2.Columns(0).Name = "Bruker-ID"
        DataGridView2.Columns(1).Name = "Brukertype"
        DataGridView2.Columns(2).Name = "Fødselsdato"
        DataGridView2.Columns(3).Name = "Fornavn"
        DataGridView2.Columns(4).Name = "Etternavn"
        DataGridView2.Columns(5).Name = "Epost"
        DataGridView2.Columns(6).Name = "Passord"
        DataGridView2.Columns(7).Name = "Tlfnr"
        DataGridView2.Columns(8).Name = "Adresse"
        DataGridView2.Columns(9).Name = "Postnr"
        DataGridView2.Columns(10).Name = "Kjønn"
        DataGridView2.Columns(11).Name = "Epost godtatt"
        DataGridView2.Columns(12).Name = "Blodtype"


        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        tilkobling3.Close()

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

    Private Function sporringadd(ByVal sql As String) As DataTable

        Dim tabell As New DataTable
        Try
            tilkobling3.Open()

            Dim kommando As New MySqlCommand(sql, tilkobling3)
            Dim da As New MySqlDataAdapter

            da.SelectCommand = kommando
            da.Fill(tabell)


            tilkobling3.Close()


        Catch ex As Exception
            MessageBox.Show("En feil har oppstått: " & ex.Message)
            tilkobling3.Close()
        End Try

        Return tabell
    End Function

    Private Sub Add()

        Try
            sporringadd("INSERT INTO Bruker (bruker_type, epost_godtatt, f_navn ,e_navn ,fodselsdato ,tlf_nr ,epost ,adresse , postnr,kjonn, passord)
VALUES (1,1 ,'" & Endre_fornavn.Text & "','" & Endre_enavn.Text & "','" & Endre_fodselsdato.Text & "','" & Endre_tlfnr.Text & "','" & Endre_epost.Text & "','" & Endre_adresse.Text & "','" & Endre_postnr.Text & "','" & Endre_kjønn.Text & "','" & Endre_passord.Text & "')")


        Catch ex As MySqlException
            MsgBox(ex.Message)


        End Try



    End Sub

    Private Sub Populate1(bruker_id As String, bruker_type As String, fodselsdato As String, f_navn As String, e_navn As String, epost As String, passord As String, tlf_nr As String,
                        adresse As String, postnr As String, kjonn As String, epost_godtatt As String, blodtype As String)

        Dim row As String() = New String() {bruker_id, bruker_type, fodselsdato, f_navn, e_navn, epost, passord, tlf_nr, adresse, postnr, kjonn, epost_godtatt, blodtype}
        DataGridView2.Rows.Add(row)



    End Sub
    Private Sub Populate2(bruker_id As String, bruker_type As String, fodselsdato As String, f_navn As String, e_navn As String, epost As String, passord As String, tlf_nr As String,
                        adresse As String, postnr As String, kjonn As String, epost_godtatt As String)

        Dim row As String() = New String() {bruker_id, bruker_type, fodselsdato, f_navn, e_navn, epost, passord, tlf_nr, adresse, postnr, kjonn, epost_godtatt}
        DataGridView2.Rows.Add(row)



    End Sub
    'Retrieve data

    Private Sub Retrieve()

        DataGridView2.Rows.Clear()
        Dim sql As String = "SELECT * FROM Bruker "
        Dim cmd As New MySqlCommand(sql, tilkobling3)
        Dim sql2 As String = "SELECT * FROM Bruker WHERE blodtype IS NULL"
        Dim cmd2 As New MySqlCommand(sql2, tilkobling3)


        Try
            tilkobling3.Open()
            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(dt)



            'Fyll rad

            For Each row In dt.Rows
                Try


                    Populate1(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12))

                Catch ex As Exception
                    Populate2(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11))

                End Try

                CLEARTEXT()
            Next
            tilkobling3.Close()


            dt.Rows.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
            tilkobling3.Close()

        End Try



    End Sub

    Private Sub UpdateDG(bruker_id As String)
        Dim sql As String = "UPDATE Bruker Set bruker_type =@BRUKER_type, fodselsdato =@FODSELSDATO, f_navn = @F_NAVN , e_navn = @E_NAVN , epost = @EPOST , passord = @PASSORD , adresse = @ADRESSE ,  tlf_nr = @TLF_NR ,  postnr = @POSTNR , kjonn =@KJONN , epost_godtatt = @EPOST_GODTATT , blodtype =@BLODTYPE WHERE bruker_id ='" & DataGridView2.SelectedRows(0).Cells(0).Value & "'"


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
            cmd.Parameters.AddWithValue("@EPOST", Endre_epost.Text)
            cmd.Parameters.AddWithValue("@PASSORD", Endre_passord.Text)
            cmd.Parameters.AddWithValue("@TLF_NR", Endre_tlfnr.Text)
            cmd.Parameters.AddWithValue("@ADRESSE", Endre_adresse.Text)
            cmd.Parameters.AddWithValue("@POSTNR", Endre_postnr.Text)
            cmd.Parameters.AddWithValue("@KJONN", Endre_kjønn.Text)
            cmd.Parameters.AddWithValue("@EPOST_GODTATT", Epost_godtatt.Text)
            cmd.Parameters.AddWithValue("@BLODTYPE", Endre_blodtype.Text)

            Try
                If MessageBox.Show("Vil du virkelig endre info?", "Endre info", MessageBoxButtons.YesNo) = vbYes Then
                    If cmd.ExecuteNonQuery() > 0 Then
                        MsgBox("Info endret!")
                    End If
                End If
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try

            tilkobling3.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            tilkobling3.Close()

        End Try
        DataGridView2.Rows.Clear()
        Retrieve()



    End Sub

    Private Sub Delete(bruker_id As String)
        Dim sql As String = "DELETE FROM g_oops_09.Bruker WHERE Bruker.bruker_id='" & DataGridView2.SelectedRows(0).Cells(0).Value & "'"
        Dim cmd As New MySqlCommand(sql, tilkobling3)

        Try
            tilkobling3.Open()


            If MessageBox.Show("Vil du slette info?", "Slette info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
                cmd.ExecuteNonQuery()

                MsgBox("Info slettet!")

            End If

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


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Dim id As String = DataGridView2.SelectedRows(0).Cells(0).Value
        UpdateDG(id)


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
        Retrieve()



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
        dt.Rows.Clear()
        DataGridView2.Rows.Clear()

        Retrieve()
    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        Dim id As String = DataGridView2.SelectedRows(0).Cells(0).Value
        Delete(id)
        Retrieve()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sok_btn.Click


        DataGridView2.Rows.Clear()
        Dim sql As String = "SELECT * FROM Bruker WHERE f_navn LIKE'%" + Sok.Text + "%' AND  e_navn LIKE'%" + Sok2.Text + "%' "
        Dim cmd As New MySqlCommand(sql, tilkobling3)

        dt.Rows.Clear()
        Try
            tilkobling3.Open()

            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(dt)

            'Fyll rad
            For Each row In dt.Rows

                Populate2(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11))

            Next

            tilkobling3.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            tilkobling3.Close()

        End Try


    End Sub


    Private Sub Endre_kjønn_Leave(sender As Object, e As EventArgs) Handles Endre_kjønn.Leave
        If IsNumeric(Endre_kjønn.Text) = 0 Or IsNumeric(Endre_kjønn.Text) = 1 Then

            MsgBox("Du må skrive inn et tall" & vbCrLf & "Mann = 0 " & vbCrLf & "Dame = 1 ")
            Endre_kjønn.Focus()
        End If
    End Sub



    Private Sub Epost_godtatt_Leave(sender As Object, e As EventArgs) Handles Epost_godtatt.Leave
        If IsNumeric(Epost_godtatt.Text) = 0 Or IsNumeric(Epost_godtatt.Text) = 1 Then

            MsgBox("Du må skrive inn et tall" & vbCrLf & "False = 0 " & vbCrLf & "True = 1 ")
            Epost_godtatt.Focus()
        End If
    End Sub


End Class