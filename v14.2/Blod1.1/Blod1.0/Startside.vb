Imports MySql.Data.MySqlClient

Public Class Startside
    'Oppretter tilkobling til SQL

    Private tilkobling As MySqlConnection
    Public brukernavn As String



    Private Sub Logg_inn_Click(sender As Object, e As EventArgs) Handles Logg_inn.Click

        '1 = giver
        '2 = ansatt 
        brukernavn = TextBox1.Text
        Dim passord As String = TextBox2.Text



        Try
            'Spørring for givere
            Dim sqlSporring1 = "SELECT epost FROM Bruker WHERE bruker_type =1 AND epost='" & brukernavn.Replace("'", "\'") & "' AND passord='" & passord.Replace("'", "\'") & "'"
            Dim sql1 As New MySqlCommand(sqlSporring1, tilkobling)

            'Spørring for ansatte
            Dim sqlSporring2 = "SELECT epost FROM Bruker WHERE bruker_type =2 AND epost='" & brukernavn.Replace("'", "\'") & "' AND passord='" & passord.Replace("'", "\'") & "'"
            Dim sql2 As New MySqlCommand(sqlSporring2, tilkobling)

            'Spørring for admin
            Dim sqlSporring3 = "SELECT admin_id FROM Admin WHERE admin_id='" & brukernavn.Replace("'", "\'") & "' AND passord='" & passord.Replace("'", "\'") & "'"
            Dim sql3 As New MySqlCommand(sqlSporring3, tilkobling)

            Dim da1 As New MySqlDataAdapter
            Dim da2 As New MySqlDataAdapter
            Dim da3 As New MySqlDataAdapter
            Dim internTabell1 As New DataTable
            Dim internTabell2 As New DataTable
            Dim internTabell3 As New DataTable
            da1.SelectCommand = sql1
            da1.Fill(internTabell1)
            da2.SelectCommand = sql2
            da2.Fill(internTabell2)
            da3.SelectCommand = sql3
            da3.Fill(internTabell3)


            'Innlogging for givere
            If internTabell1.Rows.Count > 0 Then
                MsgBox("Logget på")
                MinSideGiver.Show()
                Me.Visible = False

                'Innlogging for ansatte
            ElseIf internTabell2.Rows.Count > 0 Then
                MsgBox("Logget på")
                MinSideAnsatt.Show()
                Me.Visible = False

            ElseIf internTabell3.Rows.Count > 0 Then
                MsgBox("Logget på")
                MinSideAdmin.Show()

                Me.Visible = False
            Else
                MsgBox("Feil brukernavn eller passord")
            End If
        Catch ex As MySqlException
            MsgBox("En feil har oppstått" & ex.Message)
        End Try
        'resetter passordfeltet
        TextBox2.Text = ""

    End Sub



    Private Sub Startside_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje, setter fokus på første tekstboks, midtstiller panel
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip1.BackColor = Color.CornflowerBlue
        TextBox1.Focus()
        StartsidePanel.Location = New Point((Me.Width \ 2) - (StartsidePanel.Width \ 2), (Me.Height \ 2) - (StartsidePanel.Height \ 2))

        'Oppretter ny tilkobling
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")

        'Viderefører tilkobling til andre forms
        tilkobling.Open()
        MinSideGiver.tilkobling = tilkobling
        MinSideAdmin.tilkobling = tilkobling
        MinSideAnsatt.tilkobling = tilkobling
        EndreInfo.tilkobling = tilkobling
        EgenErklaering.tilkobling = tilkobling

    End Sub
    Private Sub Startside_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Nullstill_knapp.Click
        'Nullstiller tekstfeltene

        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        'Logger inn hvis man trykker enter - sammen funksjon som logg inn

        If e.KeyCode = Keys.Enter Then


            '1 = giver
            '2 = ansatt 
            brukernavn = TextBox1.Text
            Dim passord As String = TextBox2.Text


            Try
                'Spørring for givere
                Dim sqlSporring1 = "SELECT epost FROM Bruker WHERE bruker_type =1 AND epost='" & brukernavn.Replace("'", "\'") & "' AND passord='" & passord.Replace("'", "\'") & "'"
                Dim sql1 As New MySqlCommand(sqlSporring1, tilkobling)

                'Spørring for ansatte
                Dim sqlSporring2 = "SELECT epost FROM Bruker WHERE bruker_type =2 AND epost='" & brukernavn.Replace("'", "\'") & "' AND passord='" & passord.Replace("'", "\'") & "'"
                Dim sql2 As New MySqlCommand(sqlSporring2, tilkobling)

                'Spørring for admin
                Dim sqlSporring3 = "SELECT admin_id FROM Admin WHERE admin_id='" & brukernavn.Replace("'", "\'") & "' AND passord='" & passord.Replace("'", "\'") & "'"
                Dim sql3 As New MySqlCommand(sqlSporring3, tilkobling)

                Dim da1 As New MySqlDataAdapter
                Dim da2 As New MySqlDataAdapter
                Dim da3 As New MySqlDataAdapter
                Dim internTabell1 As New DataTable
                Dim internTabell2 As New DataTable
                Dim internTabell3 As New DataTable
                da1.SelectCommand = sql1
                da1.Fill(internTabell1)
                da2.SelectCommand = sql2
                da2.Fill(internTabell2)
                da3.SelectCommand = sql3
                da3.Fill(internTabell3)


                'Innlogging for givere
                If internTabell1.Rows.Count > 0 Then
                    MsgBox("Logget på")
                    MinSideGiver.Show()
                    Me.Visible = False

                    'Innlogging for ansatte
                ElseIf internTabell2.Rows.Count > 0 Then
                    MsgBox("Logget på")
                    MinSideAnsatt.Show()
                    Me.Visible = False

                ElseIf internTabell3.Rows.Count > 0 Then
                    MsgBox("Logget på")
                    MinSideAdmin.Show()

                    Me.Visible = False
                Else
                    MsgBox("Feil brukernavn eller passord")
                End If
            Catch ex As MySqlException
                MsgBox("En feil har oppstått" & ex.Message)
            End Try
            'resetter passordfeltet
            TextBox2.Text = ""


        End If

    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        'Logger inn hvis man trykker enter - sammen funksjon som logg inn

        If e.KeyCode = Keys.Enter Then


            '1 = giver
            '2 = ansatt 
            brukernavn = TextBox1.Text
            Dim passord As String = TextBox2.Text


            Try
                'Spørring for givere
                Dim sqlSporring1 = "SELECT epost FROM Bruker WHERE bruker_type =1 AND epost='" & brukernavn.Replace("'", "\'") & "' AND passord='" & passord.Replace("'", "\'") & "'"
                Dim sql1 As New MySqlCommand(sqlSporring1, tilkobling)

                'Spørring for ansatte
                Dim sqlSporring2 = "SELECT epost FROM Bruker WHERE bruker_type =2 AND epost='" & brukernavn.Replace("'", "\'") & "' AND passord='" & passord.Replace("'", "\'") & "'"
                Dim sql2 As New MySqlCommand(sqlSporring2, tilkobling)

                'Spørring for admin
                Dim sqlSporring3 = "SELECT admin_id FROM Admin WHERE admin_id='" & brukernavn.Replace("'", "\'") & "' AND passord='" & passord.Replace("'", "\'") & "'"
                Dim sql3 As New MySqlCommand(sqlSporring3, tilkobling)

                Dim da1 As New MySqlDataAdapter
                Dim da2 As New MySqlDataAdapter
                Dim da3 As New MySqlDataAdapter
                Dim internTabell1 As New DataTable
                Dim internTabell2 As New DataTable
                Dim internTabell3 As New DataTable
                da1.SelectCommand = sql1
                da1.Fill(internTabell1)
                da2.SelectCommand = sql2
                da2.Fill(internTabell2)
                da3.SelectCommand = sql3
                da3.Fill(internTabell3)


                'Innlogging for givere
                If internTabell1.Rows.Count > 0 Then
                    MsgBox("Logget på")
                    MinSideGiver.Show()
                    Me.Visible = False

                    'Innlogging for ansatte
                ElseIf internTabell2.Rows.Count > 0 Then
                    MsgBox("Logget på")
                    MinSideAnsatt.Show()
                    Me.Visible = False

                ElseIf internTabell3.Rows.Count > 0 Then
                    MsgBox("Logget på")
                    MinSideAdmin.Show()

                    Me.Visible = False
                Else
                    MsgBox("Feil brukernavn eller passord")
                End If
            Catch ex As MySqlException
                MsgBox("En feil har oppstått" & ex.Message)
            End Try
            'resetter passordfeltet
            TextBox2.Text = ""


        End If

    End Sub

    Private Sub AvsluttToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem1.Click
        'Avslutter programmet
        Me.Close()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Glemt_passord.LinkClicked
        GlemtPassord.Show()
        Me.Visible = False
    End Sub

    Private Sub Registrer_blodgiver_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Registrer_blodgiver.LinkClicked
        RegistrerBruker.Show()
        Me.Visible = False
    End Sub

    Private Sub Startside_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Application.ExitThread()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RegistrerAnsatt.Show()
        Me.Visible = False
    End Sub
End Class
