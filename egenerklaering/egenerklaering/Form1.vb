Imports MySql.Data.MySqlClient

Public Class Form1

    Private brukernavn As String = "g_oops_09"
    Private passord As String = "IxKu1h4H"
    Private databasenavn As String
    Private tjenernavn As String = "mysql.stud.iie.ntnu.no"

    Private tilkobling As New MySqlConnection
    Private connstring As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Setter bakgrunnsfarge til hvit
        Me.BackColor = Color.White

        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")

        tilkobling.Open()
        Me.tilkobling = tilkobling




    End Sub
End Class
