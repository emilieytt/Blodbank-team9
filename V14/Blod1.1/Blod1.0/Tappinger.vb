Imports MySql.Data.MySqlClient

Public Class Tappinger
    Private tilkobling5 As MySqlConnection



    Private Sub Tappinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tilkobling5 = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")


        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.WhiteSmoke
        Me.Text = "Blodbanken St. Olavs"
        Panel1.Location = New Point((Me.Width \ 2) - (Panel1.Width \ 2), (Me.Height \ 2) - (Panel1.Height \ 2))
        tilkobling5.Open()

        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)

        Try


            Dim tappeSporring = "SELECT givning_dato, givning_klokkeslett
                            FROM Blodgivning WHERE giver_id = (SELECT bruker_id FROM Bruker WHERE epost='" & Startside.brukernavn & "')"
            Dim sqltapping As New MySqlCommand(tappeSporring, tilkobling5)

            Dim lesertapping As MySqlDataReader = sqltapping.ExecuteReader()


            ListBox1.Items.Clear()

            ListBox1.Items.Add("Dato:" & vbTab)

            While lesertapping.Read()

                ListBox1.Items.Add(lesertapping("givning_dato") & vbTab)



                'Try

                '    ListBox1.Items.Add(lesertapping("givning_dato") & vbTab & lesertapping("givning_klokkeslett"))

                'Catch ex As Exception
                '    ListBox1.Items.Add("Ingen registrerte blodgivninger")

                'End Try

            End While
            lesertapping.Close()

        Catch ex As MySqlException

            ListBox1.Items.Add("Oops! Det skjedde noe galt")

        End Try




    End Sub

    Private Sub Tilbake_Click(sender As Object, e As EventArgs) Handles Tilbake.Click

        Me.Close()

    End Sub

    'Private Sub Tappinger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    '    tilkobling5.Close()
    '    tilkobling5.Dispose()

    '    If BtnClickCount = 0 Then

    '        Dim dialog As DialogResult

    '        dialog = MessageBox.Show("Vil du avslutte?", "Avslutt", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
    '        If dialog = DialogResult.No Then

    '            e.Cancel = True


    '        Else
    '            Application.ExitThread()

    '        End If
    '    End If

    'End Sub
End Class