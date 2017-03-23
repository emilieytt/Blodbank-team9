Imports MySql.Data.MySqlClient
Public Class MinSideAdmin
    Public tilkobling As MySqlConnection
    Private tilkobling2 As MySqlConnection

    Private Sub MinSideAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip2.BackColor = Color.CornflowerBlue



        tilkobling2 = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")
        tilkobling2.Open()

        load_table()


    End Sub



    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()
    End Sub

    Private Sub load_table()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Try

            Dim navnSporring = "SELECT epost, f_navn, e_navn, passord, adresse, tlf_nr, postnr from Bruker "
            Dim sqlnavn2 As New MySqlCommand(navnSporring, tilkobling2)
            SDA.SelectCommand = sqlnavn2
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView2.DataSource = bSource
            SDA.Update(dbDataset)

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try


    End Sub

    'Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
    '    'Avslutter programmet
    '    Me.Close()
    'End Sub
    Private Function sporring(ByVal sql As String) As DataTable
        Dim tabell As New DataTable

        Try
            tilkobling.Open()

            Dim kommando As New MySqlCommand(sql, tilkobling)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = kommando
            da.Fill(tabell)
            tilkobling.Close()
        Catch ex As MySqlException
            MessageBox.Show("en feil har oppstått" & ex.Message)
        End Try

        Return tabell
    End Function




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Update_btn.Click

    End Sub

    Private Sub Se_brukere_Click(sender As Object, e As EventArgs) Handles Se_brukere.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Try

            Dim navnSporring = "SELECT bruker_id, f_navn, e_navn, epost, passord, adresse, tlf_nr, postnr from Bruker "
            Dim sqlnavn2 As New MySqlCommand(navnSporring, tilkobling2)
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





    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    '    Dim posisjon As Integer
    '    Dim antall As Integer
    '    Dim ds As New DataSet
    '    Dim navnSporring = "SELECT bruker_id, epost, f_navn, e_navn, postnr, adresse, tlf_nr, fodselsdato, blodtype
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