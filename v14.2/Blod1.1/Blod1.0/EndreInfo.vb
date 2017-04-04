Imports MySql.Data.MySqlClient

Public Class EndreInfo
    Public tilkobling As MySqlConnection
    Private tilkobling2 As MySqlConnection
    Dim BtnClickCount As Integer = 0
    Private Sub EndreInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tilkobling2 = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")


        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.WhiteSmoke
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip1.BackColor = Color.CornflowerBlue
        Panel1.Location = New Point((Me.Width \ 2) - (Panel1.Width \ 2), (Me.Height \ 2) - (Panel1.Height \ 2))
        tilkobling2.Open()

        Dim ds As New DataSet
        Dim navnSporring = "SELECT epost, f_navn, e_navn, passord, adresse, tlf_nr, postnr from Bruker WHERE epost='" & Startside.brukernavn & "'"
        Dim sqlnavn2 As New MySqlCommand(navnSporring, tilkobling2)
        Dim lesernavn = sqlnavn2.ExecuteReader()
        Try


            While lesernavn.Read()

                Endre_fornavn.Text = lesernavn("f_navn")
                Endre_etternavn.Text = lesernavn("e_navn")
                Endre_epost.Text = lesernavn("epost")
                Endre_passord1.Text = lesernavn("passord")
                Endre_passord2.Text = lesernavn("passord")
                Endre_adresse.Text = lesernavn("adresse")
                Endre_postnr.Text = lesernavn("postnr")
                Endre_tlfnr.Text = lesernavn("tlf_nr")
                '    'Mobilnummer.Text = lesernavn("tlf_nr")
                '    'Blodtype.Text = lesernavn("blodtype")
            End While
            lesernavn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        BtnClickCount += 1


        Dim query As String

        query = "UPDATE Bruker Set f_navn = @fn , e_navn = @en , epost = @epost , passord = @passord , adresse = @adresse ,  tlf_nr = @tlf_nr ,  postnr = @postnr WHERE epost='" & Startside.brukernavn & "'"
        Dim cmd As New MySqlCommand(query, tilkobling2)
        cmd.Parameters.AddWithValue("@fn", Endre_fornavn.Text)
        cmd.Parameters.AddWithValue("@en", Endre_etternavn.Text)
        cmd.Parameters.AddWithValue("@epost", Endre_epost.Text)
        cmd.Parameters.AddWithValue("@passord", Endre_passord2.Text)
        cmd.Parameters.AddWithValue("@adresse", Endre_adresse.Text)
        cmd.Parameters.AddWithValue("@tlf_nr", Endre_tlfnr.Text)
        cmd.Parameters.AddWithValue("@postnr", Endre_postnr.Text)

        Try
            If Endre_passord1.Text <> Endre_passord2.Text Then
                MsgBox("Du må skrive inn samme passord")

            Else


                If MessageBox.Show("Vil du virkelig endre info?", "Endre info", MessageBoxButtons.YesNo) = vbYes Then
                    cmd.ExecuteNonQuery()
                    MsgBox("Info endret!")
                    Me.Close()
                    MinSideGiver.Show()

                End If


            End If


        Catch ex As MySqlException
            MsgBox(ex.Message)

            Throw New Exception("Error " + ex.Message)


        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Avbryt_knapp.Click
        BtnClickCount = 1
        MinSideGiver.Show()
        Me.Hide()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click


        Dim loggav As DialogResult

        loggav = MessageBox.Show("Vil du logge av?", "Logg av", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If loggav = DialogResult.Yes Then
            BtnClickCount = 1
            Application.Restart()
        Else
        End If
    End Sub

    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        'Avslutter programmet
        Me.Close()
    End Sub

    Private Sub EndreInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If BtnClickCount = 0 Then


            Dim dialog As DialogResult

            dialog = MessageBox.Show("Vil du avslutte?", "Avslutt", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dialog = DialogResult.No Then

                e.Cancel = True

            Else
                Application.ExitThread()

            End If

        End If

    End Sub
End Class