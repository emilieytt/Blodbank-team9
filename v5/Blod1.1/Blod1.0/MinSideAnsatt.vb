Imports MySql.Data.MySqlClient

Public Class MinSideAnsatt
    Public tilkobling As MySqlConnection
    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()
    End Sub

    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        'Avslutter programmet
        Me.Close()
    End Sub



    Private Sub MinSideAnsatt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Setter bakgrunnsfarge til hvit
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip2.BackColor = Color.Red

        'SQL-spørring som henter ut personlig informasjon

        Dim navnSporring = "SELECT epost, f_navn, e_navn, postnr, adresse, tlf_nr, fodselsdato, blodtype
                            from Bruker WHERE epost='" & Startside.brukernavn & "'"
        Dim sqlnavn As New MySqlCommand(navnSporring, tilkobling)
        Dim lesernavn = sqlnavn.ExecuteReader()

        'Leser som lister ut informasjonen i labelsene

        While lesernavn.Read()

            Navn.Text = lesernavn("f_navn") & " " & lesernavn("e_navn")
            Postnr.Text = lesernavn("postnr")
            Epost.Text = lesernavn("epost")
            fdato.Text = lesernavn("fodselsdato")
            Adresse.Text = lesernavn("adresse")
            Mobilnummer.Text = lesernavn("tlf_nr")
            Blodtype.Text = lesernavn("blodtype")
        End While
        lesernavn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Logg_ut.Click
        'Restarter programmet
        Application.Restart()
    End Sub

    Private Sub Send_ut_Click(sender As Object, e As EventArgs) Handles Send_ut.Click


        If Normal.Checked Then


        ElseIf Haste.Checked Then


        Else

        End If
    End Sub
End Class