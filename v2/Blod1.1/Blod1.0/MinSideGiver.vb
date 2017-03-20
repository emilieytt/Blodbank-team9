﻿Imports MySql.Data.MySqlClient

Public Class MinSideGiver
    Public tilkobling As MySqlConnection



    Private Sub MinSideGiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Setter bakgrunnsfarge til hvit
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip1.BackColor = Color.Red

        Dim ds As New DataSet
        Dim navnSporring = "SELECT epost, f_navn, e_navn, postnr, adresse, tlf_nr, fodselsdato, blodtype
                            from Bruker WHERE epost='" & Startside.brukernavn & "'"
        Dim sqlnavn As New MySqlCommand(navnSporring, tilkobling)
        Dim lesernavn = sqlnavn.ExecuteReader()

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

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()
    End Sub

    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        'Avslutter programmet
        Me.Close()
    End Sub
End Class