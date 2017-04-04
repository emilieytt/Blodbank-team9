Imports MySql.Data.MySqlClient


Public Class GlemtPassord

    Private tilkobling As MySqlConnection
    Dim BtnClickCount As Integer = 0

    Private Sub GlemtPassord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.WhiteSmoke
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip1.BackColor = Color.CornflowerBlue
        Panel1.Location = New Point((Me.Width \ 2) - (Panel1.Width \ 2), (Me.Height \ 2) - (Panel1.Height \ 2))


        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")


        tilkobling.Open()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles se_passord.Click

        If Glemt1.Text <> Glemt2.Text Then

            MsgBox("Du må skrive inn riktig epostadresse")
        Else
            Dim sqlSporring1 = "SELECT epost, passord FROM Bruker WHERE epost='" & Glemt1.Text.Replace("'", "\'") & "'"
            Dim sql1 As New MySqlCommand(sqlSporring1, tilkobling)


            Dim lesernavn = sql1.ExecuteReader()

            While lesernavn.Read()


                Label4.Text = lesernavn("passord")

            End While
            lesernavn.Close()

        End If
    End Sub
    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        BtnClickCount = 1

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

    Private Sub Avbryt_knapp_Click(sender As Object, e As EventArgs) Handles Avbryt_knapp.Click
        BtnClickCount = 1

        Dim loggav As DialogResult

        loggav = MessageBox.Show("Er du sikker på at du vil avbryte?", "Avbryt", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If loggav = DialogResult.Yes Then
            Application.Restart()
        Else
        End If
    End Sub

    Private Sub GlemtPassord_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

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
    End Sub
End Class