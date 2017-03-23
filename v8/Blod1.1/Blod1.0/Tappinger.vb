Imports MySql.Data.MySqlClient

Public Class Tappinger
    Private tilkobling As MySqlConnection



    Private Sub Tappinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")


        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip1.BackColor = Color.CornflowerBlue
        Panel1.Location = New Point((Me.Width \ 2) - (Panel1.Width \ 2), (Me.Height \ 2) - (Panel1.Height \ 2))
        tilkobling.Open()
        Try


            Dim tappeSporring = "SELECT givning_dato, givning_klokkeslett
                            FROM Blodgivning WHERE giver_id = (SELECT bruker_id FROM Bruker WHERE epost='" & Startside.brukernavn & "')"
            Dim sqltapping As New MySqlCommand(tappeSporring, tilkobling)

            Dim lesertapping = sqltapping.ExecuteReader()

            ListBox1.Items.Clear()

            ListBox1.Items.Add("Dato:" & vbTab & vbTab & "Klokkeslett")

            While lesertapping.Read()
                Try

                    ListBox1.Items.Add(lesertapping("givning_dato") & vbTab & lesertapping("givning_klokkeslett"))

                Catch ex As Exception
                    ListBox1.Items.Add("Ingen registrerte blodgivninger")

                End Try

            End While
            lesertapping.Close()

        Catch ex As MySqlException

            ListBox1.Items.Add("Oops! Det skjedde noe galt")

        End Try




    End Sub

    Private Sub Tilbake_Click(sender As Object, e As EventArgs) Handles Tilbake.Click

        MinSideGiver.Show()
        Me.Close()

    End Sub

    Private Sub Tappinger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim dialog As DialogResult

        dialog = MessageBox.Show("Vil du avslutte?", "Avslutt", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If dialog = DialogResult.No Then

            e.Cancel = True

        Else
            Application.ExitThread()

        End If
    End Sub
End Class