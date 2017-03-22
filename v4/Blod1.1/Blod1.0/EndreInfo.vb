Imports MySql.Data.MySqlClient

Public Class EndreInfo
    Public tilkobling As MySqlConnection
    Private Sub EndreInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip1.BackColor = Color.Red


        'Dim ds As New DataSet
        'Dim navnSporring = "SELECT epost, f_navn, e_navn from Bruker WHERE epost='" & Startside.brukernavn & "'"
        'Dim sqlnavn2 As New MySqlCommand(navnSporring, tilkobling)
        'Dim lesernavn = sqlnavn2.ExecuteReader()

        'While lesernavn.Read()

        '    TextBox1.Text = lesernavn("f_navn")
        '    TextBox2.Text = lesernavn("e_navn")
        '    '    'Epost.Text = lesernavn("epost")
        '    '    TextBox3.Text = lesernavn2("fodselsdato")
        '    '    'Adresse.Text = lesernavn("adresse")
        '    '    'Mobilnummer.Text = lesernavn("tlf_nr")
        '    '    'Blodtype.Text = lesernavn("blodtype")
        'End While
        'lesernavn.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim insertQuery As String = "INSERT INTO Bruker (f_navn, e_navn) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "' ) "
        Try
            Dim updateSporring = "UPDATE Bruker Set f_navn = @fn , e_navn = @en  WHERE epost='" & Startside.brukernavn & "'"
            Dim sqlupdate As New MySqlCommand(updateSporring, tilkobling)
            'Dim leserUpdate = sqlupdate.ExecuteReader()


            sqlupdate.ExecuteReader()

            sqlupdate.Parameters.AddWithValue("@fn", SqlDbType.VarChar).Value = TextBox1.Text
            sqlupdate.Parameters.AddWithValue("@en", SqlDbType.VarChar).Value = TextBox2.Text


            ' command.Parameters.AddWithValue("@dato", SqlDbType.Date).Value = TextBox3.Text

            '    command.ExecuteNonQuery()
            'While leserUpdate.Read()

            '    MsgBox("DATA")
            'End While
            'leserUpdate.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Avbryt_knapp.Click
        MinSideGiver.Show()
        Me.Hide()
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