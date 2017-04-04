Imports MySql.Data.MySqlClient
Public Class SeBestillinger
    Public tilkobling As MySqlConnection
    Dim constring As String = "Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;"

    Dim tilkobling3 As New MySqlConnection(constring)
    Dim dt As New DataTable()
    Dim adapter As MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim ds As New DataSet
    Dim BtnClickCount As Integer
    Private Sub Bestillinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.WhiteSmoke
        Me.Text = "Blodbanken St. Olavs"
        Panel1.Location = New Point((Me.Width \ 2) - (Panel1.Width \ 2), (Me.Height \ 2) - (Panel1.Height \ 2))

        tilkobling3.Open()

        DataGridView2.ColumnCount = 8
        DataGridView2.Columns(0).Name = "f_navn"
        DataGridView2.Columns(1).Name = "e_navn"
        DataGridView2.Columns(2).Name = "epost"
        DataGridView2.Columns(3).Name = "bruker_id"
        DataGridView2.Columns(4).Name = "timebestilling_id"
        DataGridView2.Columns(5).Name = "bestilling_dato"
        DataGridView2.Columns(6).Name = "bestilling_klokke"
        DataGridView2.Columns(7).Name = "konsultasjon_id"


        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        tilkobling3.Close()

        Retrieve()

    End Sub

    Private Sub Retrieve()

        DataGridView2.Rows.Clear()
        Dim sql As String = "SELECT f_navn, e_navn, epost, bruker_id, timebestilling_id, bestilling_dato, bestilling_klokke, konsultasjon_id
                             FROM Sende_bestilling sb, Bruker b
                             WHERE sb.giver_id = b.bruker_id
                             AND sb.konsultasjon_id IS NULL"
        Dim cmd As New MySqlCommand(sql, tilkobling3)
        Dim sql2 As String = "SELECT f_navn, e_navn, epost, bruker_id, timebestilling_id, bestilling_dato, bestilling_klokke, konsultasjon_id
                             FROM Sende_bestilling sb, Bruker b
                             WHERE sb.giver_id = b.bruker_id
                             AND konsultasjon_id IS NULL"
        Dim cmd2 As New MySqlCommand(sql2, tilkobling3)

        Try
            tilkobling3.Open()

            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(dt)

            'Fyll rad
            For Each row In dt.Rows

                Try
                    Populate(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7))
                Catch ex As Exception
                    Populate2(row(0), row(1), row(2), row(3), row(4), row(5), row(6))
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

    Private Sub Populate(f_navn As String, e_navn As String, epost As String, bruker_id As String, timebestilling_id As String,
                        bestilling_dato As String, bestilling_klokke As String, konsultasjon_id As String)

        Dim row As String() = New String() {f_navn, e_navn, epost, bruker_id, timebestilling_id, bestilling_dato, bestilling_klokke, konsultasjon_id}
        DataGridView2.Rows.Add(row)

    End Sub

    Private Sub Populate2(f_navn As String, e_navn As String, epost As String, bruker_id As String, timebestilling_id As String,
                        bestilling_dato As String, bestilling_klokke As String)

        Dim row As String() = New String() {f_navn, e_navn, epost, bruker_id, timebestilling_id, bestilling_dato, bestilling_klokke}
        DataGridView2.Rows.Add(row)

    End Sub

    Private Sub DataGridView2_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseClick

        Dim f_navn As String = DataGridView2.SelectedRows(0).Cells(0).Value
        Dim e_navn As String = DataGridView2.SelectedRows(0).Cells(1).Value
        Dim epost As String = DataGridView2.SelectedRows(0).Cells(2).Value
        Dim bruker_id As Integer = DataGridView2.SelectedRows(0).Cells(3).Value
        Dim timebestilling_id As Integer = DataGridView2.SelectedRows(0).Cells(4).Value
        Dim bestilling_dato As Date = DataGridView2.SelectedRows(0).Cells(5).Value
        Dim bestilling_klokke As String = DataGridView2.SelectedRows(0).Cells(6).Value
        Dim konsultasjon_id As Integer = DataGridView2.SelectedRows(0).Cells(7).Value


        Bruker_txt.Text = bruker_id
        Bestillings_txt.Text = timebestilling_id
        Dato_txt.Text = bestilling_dato
        Fornavn_txt.Text = f_navn
        Enavn_txt.Text = e_navn
        Epost_txt.Text = epost
        Klokke_txt.Text = bestilling_klokke
        Konsultasjons_txt.Text = konsultasjon_id

    End Sub

    Private Sub CLEARTEXT()
        Bruker_txt.Text = ""
        Bestillings_txt.Text = ""
        Dato_txt.Text = ""
        Fornavn_txt.Text = ""
        Enavn_txt.Text = ""
        Epost_txt.Text = ""
        Klokke_txt.Text = ""
        Konsultasjons_txt.Text = ""

    End Sub

    Private Sub BekreftDG(bruker_id As String)
        Dim addSql As String = "INSERT INTO Legekonsultasjon (konsultasjon_id, giver_id, konsultasjon_klokkeslett, konsultasjon_dato, timebestilling_id)
                                SELECT konsultasjon_id, giver_id, bestilling_klokke, bestilling_dato, timebestilling_id
                                FROM Sende_bestilling sb
                                WHERE timebestilling_id = " & Bestillings_txt.Text & ";

                                UPDATE Sende_bestilling sb
                                INNER JOIN Legekonsultasjon lk
                                ON sb.timebestilling_id = lk.timebestilling_id
                                SET sb.konsultasjon_id = lk.konsultasjon_id"


        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(addSql, tilkobling3)
        'cmd.Parameters.AddWithValue("@GIVER_ID", Bruker_txt.Text)
        'cmd.Parameters.AddWithValue("@KONSULTASJON_DATO", Dato_txt.Text)
        'cmd.Parameters.AddWithValue("@KONSULTASJON_KLOKKESLETT", Klokke_txt.Text)

        Try
            tilkobling3.Open()
            'If cmd.ExecuteNonQuery() > 0 Then
            '    MsgBox("Data inserted")

            '    CLEARTEXT()

            'End If
            cmd.ExecuteNonQuery()
            tilkobling3.Close()
            MsgBox("Time bekreftet")
            Retrieve()
        Catch ex As MySqlException
            MsgBox("Denne timebestillingen er allerede bekreftet")
        End Try


    End Sub

    Private Sub Delete(bruker_id As String)
        'Dim sql As String = "DELETE FROM g_oops_09.Bruker WHERE Bruker.bruker_id='" & DataGridView2.SelectedRows(0).Cells(0).Value & "'"
        'Dim cmd As New MySqlCommand(sql, tilkobling3)

        'Try
        '    tilkobling3.Open()



        '    'adapter.DeleteCommand = tilkobling3.CreateCommand()
        '    'adapter.DeleteCommand.CommandText = sql

        '    If MessageBox.Show("Vil du slette info?", "Slette info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
        '        cmd.ExecuteNonQuery()


        '        MsgBox("Info slettet!")

        '    End If

        '    tilkobling3.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    tilkobling3.Close()
        'End Try

    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click

        '    Dim id As String = DataGridView2.SelectedRows(0).Cells(0).Value
        '    Delete(id)

    End Sub

    Private Sub Retrieve_btn_Click(sender As Object, e As EventArgs) Handles Retrieve_btn.Click
        DataGridView2.Rows.Clear()

        Retrieve()

    End Sub

    Private Sub Bekreft_btn_Click(sender As Object, e As EventArgs) Handles Bekreft_btn.Click
        Dim id As String = DataGridView2.SelectedRows(0).Cells(0).Value
        BekreftDG(id)
    End Sub

    Private Sub Sok_btn_Click(sender As Object, e As EventArgs) Handles Sok_btn.Click

        'Dim treff As DataGridViewCell() = (From row As DataGridViewRow In DataGridView2.Rows From cell As DataGridViewCell In row.Cells Select cell Where CStr(cell.FormattedValue).Contains(Sok.Text)).ToArray()





        '    DataGridView2.Rows.Clear()
        '    Dim sql As String = "SELECT * FROM Bruker WHERE f_navn LIKE'%" + Sok.Text + "%' AND  e_navn LIKE'%" + Sok2.Text + "%' "
        '    Dim cmd As New MySqlCommand(sql, tilkobling3)

        '    dt.Rows.Clear()
        '    Try
        '        tilkobling3.Open()

        '        adapter = New MySqlDataAdapter(cmd)
        '        adapter.Fill(dt)

        '        'Fyll rad
        '        For Each row In dt.Rows

        '            Populate(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12))
        '        Next

        '        tilkobling3.Close()

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        tilkobling3.Close()

        '    End Try
    End Sub
    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        'Avslutter programmet
        Me.Close()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click

        BtnClickCount = 1
        'Restarter programmet
        Dim loggav As DialogResult

        loggav = MessageBox.Show("Vil du logge av?", "Logg av", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If loggav = DialogResult.Yes Then
            Application.Restart()
        Else
        End If

    End Sub
    Private Sub Tilbake_Click(sender As Object, e As EventArgs) Handles Tilbake.Click
        BtnClickCount = 1
        MinSideAnsatt.Show()
        Me.Close()
    End Sub
    Private Sub SeBestillinger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If BtnClickCount = 0 Then

            Dim dialog As DialogResult

            dialog = MessageBox.Show("Vil du logge ut og avslutte?", "Avslutt", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dialog = DialogResult.No Then

                e.Cancel = True

            Else
                Application.Exit()

            End If
        End If
    End Sub

    'Private Sub Sok_TextChanged(sender As Object, e As EventArgs) Handles Sok.TextChanged
    '    DataGridView2.DataSource = ds.Tables(0)
    '    Dim dv As DataView
    '    dv = New DataView(ds.Tables(0), "f_navn = '" & Sok.Text & "' ", "type Desc", DataViewRowState.CurrentRows)
    '    DataGridView2.DataSource = dv
    'End Sub
End Class