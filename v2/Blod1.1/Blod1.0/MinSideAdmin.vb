Imports MySql.Data.MySqlClient
Public Class MinSideAdmin
    Public tilkobling As MySqlConnection
    Private Sub MinSideAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setter bakgrunnsfarge til hvit
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip2.BackColor = Color.Red
    End Sub



    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()
    End Sub

    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        'Avslutter programmet
        Me.Close()
    End Sub
    Private Function sporring(ByVal sql As String) As DataTable
        Dim tabell As New DataTable

        Try
            tilkobling.Open()

            Dim kommando As New MySqlCommand(sql, tilkobling)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = kommando
            da.Fill(tabell)
            tilkobling.Close()
        Catch ex As MySqlException
            MessageBox.Show("en feil har oppstått" & ex.Message)
        End Try

        Return tabell
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim ds As New DataSet
        Dim navnSporring = "SELECT bruker_id, epost, f_navn, e_navn, postnr, adresse, tlf_nr, blodtype
                            from Bruker WHERE bruker_type =2 ORDER BY bruker_id "
        Dim sqlnavn As New MySqlCommand(navnSporring, tilkobling)
        Dim lesernavn = sqlnavn.ExecuteReader()

        ListBox1.Items.Clear()

        ListBox1.Items.Add("Bruker ID" & "Fornavn" & vbTab & vbTab & "Etternavn" & vbTab & vbTab & "Epost")



        While lesernavn.Read()



            ListBox1.Items.Add(lesernavn("bruker_id") & vbTab & lesernavn("f_navn") & vbTab & vbTab & lesernavn("e_navn") & vbTab & vbTab & lesernavn("epost"))


        End While
        lesernavn.Close()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim ds As New DataSet
        Dim navnSporring = "SELECT bruker_id, epost, f_navn, e_navn, postnr, adresse, tlf_nr, blodtype
                            from Bruker WHERE bruker_type =1 ORDER BY bruker_id "
        Dim sqlnavn As New MySqlCommand(navnSporring, tilkobling)
        Dim lesernavn = sqlnavn.ExecuteReader()

        ListBox1.Items.Clear()

        ListBox1.Items.Add("Bruker ID" & "Fornavn" & vbTab & vbTab & "Etternavn" & vbTab & vbTab & "Epost")



        While lesernavn.Read()



            ListBox1.Items.Add(lesernavn("bruker_id") & vbTab & lesernavn("f_navn") & vbTab & vbTab & lesernavn("e_navn") & vbTab & vbTab & lesernavn("epost"))


        End While
        lesernavn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim posisjon As Integer
        Dim antall As Integer
        Dim ds As New DataSet
        Dim navnSporring = "SELECT bruker_id, epost, f_navn, e_navn, postnr, adresse, tlf_nr, fodselsdato, blodtype
                            from Bruker WHERE bruker_id='" & posisjon & "'"
        Dim sqlnavn As New MySqlCommand(navnSporring, tilkobling)
        Dim lesernavn = sqlnavn.ExecuteReader()




        If posisjon < Antall Then
            Try
                While lesernavn.Read()
                    posisjon = posisjon + 1
                    Navn.Text = lesernavn("f_navn") & " " & lesernavn("e_navn")
                    Postnr.Text = lesernavn("postnr")
                    Epost.Text = lesernavn("epost")
                    fdato.Text = lesernavn("fodselsdato")
                    Adresse.Text = lesernavn("adresse")
                    Mobilnummer.Text = lesernavn("tlf_nr")
                    Blodtype.Text = lesernavn("blodtype")
                End While
                lesernavn.Close()

            Catch ex As Exception

            End Try

        End If

    End Sub
End Class