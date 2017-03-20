Imports MySql.Data.MySqlClient

Public Class MinSideGiver
    Public tilkobling As MySqlConnection



    Private Sub MinSideGiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Setter bakgrunnsfarge til hvit
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip1.BackColor = Color.Red

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

        'Henter siste blodgivning

        Try


            Dim giverSporring = "SELECT MAX( bg.givning_dato ) AS MaxDate, DATEDIFF( CURDATE( ) , bg.givning_dato ) AS DiffDate
                FROM Blodgivning bg, Bruker b
                WHERE bg.giver_id = b.bruker_id
                AND b.epost ='" & Startside.brukernavn & "'"
            Dim sqlgiver As New MySqlCommand(giverSporring, tilkobling)
            Dim lesergiver = sqlgiver.ExecuteReader()

            'Viser siste blodgivning i label

            While lesergiver.Read()
                Forrige.Text = lesergiver("MaxDate")
                Neste.Text = 90 - lesergiver("DiffDate")
            End While
            lesergiver.Close()
        Catch ex As Exception
            Forrige.Text = "Ingen registrert blodgivning"
            Neste.Text = "Ingen registrert blodgivning"

        End Try

    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()
    End Sub

    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        'Avslutter programmet
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EndreInfo.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class