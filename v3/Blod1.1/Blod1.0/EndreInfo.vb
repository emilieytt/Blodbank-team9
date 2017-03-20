Imports MySql.Data.MySqlClient

Public Class EndreInfo
    Public tilkobling As MySqlConnection
    Private Sub EndreInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        Dim navnSporring = "SELECT epost, f_navn, e_navn, fodselsdato from Bruker WHERE epost='" & Startside.brukernavn & "'"
        Dim sqlnavn As New MySqlCommand(navnSporring, tilkobling)


        'While lesernavn.Read()

        '    TextBox1.Text = lesernavn2("f_navn")
        '    TextBox2.Text = lesernavn2("e_navn")
        '    'Epost.Text = lesernavn("epost")
        '    TextBox3.Text = lesernavn2("fodselsdato")
        '    'Adresse.Text = lesernavn("adresse")
        '    'Mobilnummer.Text = lesernavn("tlf_nr")
        '    'Blodtype.Text = lesernavn("blodtype")
        'End While
        'lesernavn.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim insertQuery As String = "INSERT INTO Bruker (f_navn, e_navn) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "' ) "


        Dim command As New MySqlCommand("UPDATE Bruker Set f_navn = @fn , e_navn = @en , fodselsdato = @dato WHERE epost='" & Startside.brukernavn & "'", tilkobling)
        command.Parameters.AddWithValue("@fn", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.AddWithValue("@en", SqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.AddWithValue("@dato", SqlDbType.Date).Value = TextBox3.Text

        If command.ExecuteNonQuery = 1 Then
            MsgBox("ja")
        End If

        'Try
        '    command.ExecuteNonQuery()

        'Catch ex As MySqlException
        '    MsgBox(ex.Message)
        'End Try

    End Sub
    'Public Sub ExecuteQuery(Query As String)
    '    Dim kommando As New MySqlCommand(Query, tilkobling)
    '    kommando.ExecuteNonQuery()

    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim updateQuery As String = "UPDATE Bruker Set f_navn = @fn , e_navn = @en  WHERE epost='" & Startside.brukernavn & "'"
    '    ExecuteQuery(updateQuery)
    '    MessageBox.Show("")
    'End Sub
End Class