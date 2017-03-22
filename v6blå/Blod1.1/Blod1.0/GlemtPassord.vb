Imports MySql.Data.MySqlClient


Public Class GlemtPassord

    Private tilkobling As MySqlConnection

    Private Sub GlemtPassord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip1.BackColor = Color.Red
        Panel1.Location = New Point((Me.Width \ 2) - (Panel1.Width \ 2), (Me.Height \ 2) - (Panel1.Height \ 2))


        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")


        tilkobling.Open()


    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()

    End Sub

    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        'Avslutter programmet
        Me.Close()
    End Sub

    Private Sub Avbryt_knapp_Click(sender As Object, e As EventArgs) Handles Avbryt_knapp.Click
        Startside.Show()
        Me.Close()
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
End Class