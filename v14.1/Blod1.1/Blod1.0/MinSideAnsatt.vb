﻿Imports MySql.Data.MySqlClient

Public Class MinSideAnsatt
    Public tilkobling As MySqlConnection
    Private tilkobling3 As MySqlConnection
    Dim BtnClickCount As Integer = 0


    Private Sub MinSideAnsatt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje

        Me.BackColor = Color.WhiteSmoke
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip2.BackColor = Color.CornflowerBlue
        Normal.Checked = True
        tilkobling3 = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                                    "Database=g_oops_09;" &
                                                    "Uid=g_oops_09;" &
                                                    "Pwd=IxKu1h4H;")
        tilkobling3.Open()




        GroupBox3.Location = New Point((Me.Width \ 2) - (GroupBox3.Width \ 2), (Me.Height \ 2) - (GroupBox3.Height \ 2))

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

    End Sub


    Private Sub Send_ut_Click(sender As Object, e As EventArgs) Handles Send_ut.Click


        If Normal.Checked Then


        ElseIf Haste.Checked Then


        Else

        End If
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

    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        'Avslutter programmet
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Logg_ut.Click
        BtnClickCount = 1

        Dim loggav As DialogResult

        loggav = MessageBox.Show("Vil du logge av?", "Logg av", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If loggav = DialogResult.Yes Then
            Application.Restart()
        Else
        End If
    End Sub

    Private Sub Endre_informasjon_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Endre_informasjon.LinkClicked
        BtnClickCount = 1
        EndreAnsatt.Show()
        Me.Close()
    End Sub
    Private Sub Statistikk_Click(sender As Object, e As EventArgs) Handles Statistikk.Click
        BtnClickCount = 1
        Statistikk.Show()
        Me.Close()
    End Sub
    Private Sub Bestillinger_Click(sender As Object, e As EventArgs) Handles Bestillinger.Click
        BtnClickCount = 1
        SeBestillinger.Show()
        Me.Close()
    End Sub
    Private Sub Blodlager_Click(sender As Object, e As EventArgs) Handles Blodlager.Click
        BtnClickCount = 1
        AdministrerBlod.Show()
        Me.Close()
    End Sub

    Private Sub MinSideAnsatt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

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
End Class