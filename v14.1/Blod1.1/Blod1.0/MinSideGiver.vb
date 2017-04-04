﻿Imports MySql.Data.MySqlClient

Public Class MinSideGiver
    Public tilkobling As MySqlConnection
    Private tilkobling3 As MySqlConnection
    Dim BtnClickCount As Integer


    Private Sub MinSideGiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling3 = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")
        tilkobling3.Open()


        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.WhiteSmoke
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip2.BackColor = Color.CornflowerBlue

        Panel1.Location = New Point((Me.Width \ 2) - (Panel1.Width \ 2), (Me.Height \ 2) - (Panel1.Height \ 2))

        'SQL-spørring som henter ut personlig informasjon

        Dim navnSporring = "SELECT epost, f_navn, e_navn, postnr, adresse, tlf_nr, fodselsdato, blodtype
                            from Bruker WHERE epost='" & Startside.brukernavn & "'"
        Dim sqlnavn As New MySqlCommand(navnSporring, tilkobling3)

        'Leser som lister ut informasjonen i labelsene

        Dim lesernavn = sqlnavn.ExecuteReader()

        While lesernavn.Read()

            Navn.Text = lesernavn("f_navn") & " " & lesernavn("e_navn")
            Postnr.Text = lesernavn("postnr")
            Epost.Text = lesernavn("epost")
            fdato.Text = lesernavn("fodselsdato")
            Adresse.Text = lesernavn("adresse")
            Mobilnummer.Text = lesernavn("tlf_nr")

            Try
                Blodtype.Text = lesernavn("blodtype")
            Catch ex As Exception
                Blodtype.Text = "Ingen blodtype registrert"
            End Try
        End While
        lesernavn.Close()


        'Henter siste blodgivning og antall dager siden sist

        Try

            Dim giverSporring = "SELECT MAX( bg.givning_dato ) AS MaxDate, DATEDIFF( CURDATE( ) , bg.givning_dato ) AS DiffDate
                FROM Blodgivning bg, Bruker b
                WHERE bg.giver_id = b.bruker_id
                AND b.epost ='" & Startside.brukernavn & "'"
            Dim sqlgiver As New MySqlCommand(giverSporring, tilkobling3)
            Dim lesergiver = sqlgiver.ExecuteReader()

            'Viser siste blodgivning og antall dager til neste blodgivning i label

            While lesergiver.Read()
                Forrige.Text = lesergiver("MaxDate")
                Neste.Text = 90 - lesergiver("DiffDate")
            End While

            lesergiver.Close()


            If Neste.Text < 1 Then
                Neste.Text = ""
                Nestetekst.Text = "Du kan nå gi blod igjen. Send timebestilling nå!"
            End If

            'Håndterer dersom spørringen ikke returnerer noen blodgivninger

        Catch ex As Exception
            Forrige.Text = "Ingen registrert blodgivning"
            Neste.Text = ""
            Nestetekst.Text = "Ingen registrert blodgivning"

        End Try

    End Sub


    Private Sub RestartToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem2.Click
        BtnClickCount = 1

        Dim loggav As DialogResult

        loggav = MessageBox.Show("Vil du logge av?", "Logg av", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If loggav = DialogResult.Yes Then
            Application.Restart()
        Else
        End If
    End Sub

    Private Sub AvsluttToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem2.Click
        'Avslutter programmet
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Endre_informasjon.LinkClicked
        BtnClickCount = 1
        EndreInfo.Show()
        Me.Close()


    End Sub

    Private Sub Bestill_Click(sender As Object, e As EventArgs) Handles Bestill.Click


        'Validerer input

        If ComboBox1.Text = "Klokkeslett" Then
            MsgBox("Vennligst velg et tidspunkt fra menyen")

        ElseIf DateTimePicker1.Value.Date <= Date.Today Then
            MsgBox("Du kan kun bestille time fra og med i morgen")

        Else

            'Sender timebestilling

            Try


                Dim dato As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
                Dim tid As String = ComboBox1.Text & ":00"

                'MsgBox("Dato: " & dato & " Tid: " & tid)

                Dim bestillSporring = "INSERT INTO `Sende_bestilling` ( `bestilling_dato`, `bestilling_klokke`, `giver_id`)
                                   VALUES ('" & dato & "' ,'" & tid & "' , (SELECT bruker_id FROM Bruker
                                   WHERE epost ='" & Startside.brukernavn & "'))"

                Dim sqlbestill As New MySqlCommand(bestillSporring, tilkobling3)
                Dim leserbestill = sqlbestill.ExecuteReader()
                leserbestill.Close()

                MsgBox("Din bestilling er sendt." & vbCrLf & vbCrLf & "Dato: " & dato & " Tid: " & tid)
            Catch ex As Exception
                MsgBox("Du må sende inn egenerklæring først")
            End Try

        End If

    End Sub

    Private Sub Se_tidligere_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Se_tidligere.LinkClicked
        Tappinger.Show()
    End Sub

    Private Sub Logg_ut_Click(sender As Object, e As EventArgs) Handles Logg_ut.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Vil du logge av?", "Logg av", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If dialog = DialogResult.No Then

        Else
            'Logger ut brukeren og restarter applikasjonen
            Application.Restart()
        End If
    End Sub

    Private Sub MinSideGiver_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub Egenerklæring_knapp_Click(sender As Object, e As EventArgs) Handles Egenerklæring_knapp.Click
        BtnClickCount = 1
        EgenErklaering.Show()
        Me.Close()
    End Sub
End Class