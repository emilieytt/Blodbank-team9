Imports MySql.Data.MySqlClient

Public Class AdministrerBlod
    Public tilkobling As MySqlConnection
    Private Sub AdministrerBlod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")
        tilkobling.Open()


        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.WhiteSmoke
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip1.BackColor = Color.CornflowerBlue

        Panel1.Location = New Point((Me.Width \ 2) - (Panel1.Width \ 2), (Me.Height \ 2) - (Panel1.Height \ 2))





    End Sub


    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()

    End Sub

    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        'Avslutter programmet
        Me.Close()
    End Sub


    Public Sub Oppdater()
        If ComboBox1.SelectedItem = "Plasma" Then

            'SQL-spørring som henter ut

            Dim typeSporring1 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='A+' And komponent_type ='Plasma';"
            Dim sqlsporring1 As New MySqlCommand(typeSporring1, tilkobling)

            Dim lesernavn1 = sqlsporring1.ExecuteReader()
            While lesernavn1.Read()
                type_ap.Text = lesernavn1("Antall")
            End While
            lesernavn1.Close()
            '--------------------------------------------------------------------------------------------------

            Dim typeSporring2 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='A-' And komponent_type ='Plasma';"
            Dim sqlsporring2 As New MySqlCommand(typeSporring2, tilkobling)

            Dim lesernavn2 = sqlsporring2.ExecuteReader()
            While lesernavn2.Read()
                type_a_m.Text = lesernavn2("Antall")
            End While
            lesernavn2.Close()
            '---------------------------------------------------------------------------------------------------

            Dim typeSporring3 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='AB+' And komponent_type ='Plasma';"
            Dim sqlsporring3 As New MySqlCommand(typeSporring3, tilkobling)

            Dim lesernavn3 = sqlsporring3.ExecuteReader()
            While lesernavn3.Read()
                type_ab_p.Text = lesernavn3("Antall")
            End While
            lesernavn3.Close()
            '---------------------------------------------------------------------------------------------------

            Dim typeSporring4 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='AB-' And komponent_type ='Plasma';"
            Dim sqlsporring4 As New MySqlCommand(typeSporring4, tilkobling)

            Dim lesernavn4 = sqlsporring4.ExecuteReader()
            While lesernavn4.Read()
                type_ab_m.Text = lesernavn4("Antall")
            End While
            lesernavn4.Close()
            '---------------------------------------------------------------------------------------------------
            Dim typeSporring5 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='B+' And komponent_type ='Plasma';"
            Dim sqlsporring5 As New MySqlCommand(typeSporring5, tilkobling)

            Dim lesernavn5 = sqlsporring5.ExecuteReader()
            While lesernavn5.Read()
                type_b_p.Text = lesernavn5("Antall")
            End While
            lesernavn5.Close()
            '---------------------------------------------------------------------------------------------------
            Dim typeSporring6 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='B-' And komponent_type ='Plasma';"
            Dim sqlsporring6 As New MySqlCommand(typeSporring6, tilkobling)

            Dim lesernavn6 = sqlsporring6.ExecuteReader()
            While lesernavn6.Read()
                type_b_m.Text = lesernavn6("Antall")
            End While
            lesernavn6.Close()
            '---------------------------------------------------------------------------------------------------
            Dim typeSporring7 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='O+' And komponent_type ='Plasma';"
            Dim sqlsporring7 As New MySqlCommand(typeSporring7, tilkobling)

            Dim lesernavn7 = sqlsporring7.ExecuteReader()
            While lesernavn7.Read()
                type_n_p.Text = lesernavn7("Antall")
            End While
            lesernavn7.Close()
            '---------------------------------------------------------------------------------------------------

            Dim typeSporring8 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='O-' And komponent_type ='Plasma';"
            Dim sqlsporring8 As New MySqlCommand(typeSporring8, tilkobling)

            Dim lesernavn8 = sqlsporring8.ExecuteReader()
            While lesernavn8.Read()
                type_n_m.Text = lesernavn8("Antall")
            End While
            lesernavn8.Close()
            '---------------------------------------------------------------------------------------------------



        End If

        If ComboBox1.SelectedItem = "Plate" Then

            'SQL-spørring som henter ut

            Dim typeSporring1 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='A+' And komponent_type ='Plate';"
            Dim sqlsporring1 As New MySqlCommand(typeSporring1, tilkobling)

            Dim lesernavn1 = sqlsporring1.ExecuteReader()
            While lesernavn1.Read()
                type_ap.Text = lesernavn1("Antall")
            End While
            lesernavn1.Close()
            '--------------------------------------------------------------------------------------------------

            Dim typeSporring2 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='A-' And komponent_type ='Plate';"
            Dim sqlsporring2 As New MySqlCommand(typeSporring2, tilkobling)

            Dim lesernavn2 = sqlsporring2.ExecuteReader()
            While lesernavn2.Read()
                type_a_m.Text = lesernavn2("Antall")
            End While
            lesernavn2.Close()
            '---------------------------------------------------------------------------------------------------

            Dim typeSporring3 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='AB+' And komponent_type ='Plate';"
            Dim sqlsporring3 As New MySqlCommand(typeSporring3, tilkobling)

            Dim lesernavn3 = sqlsporring3.ExecuteReader()
            While lesernavn3.Read()
                type_ab_p.Text = lesernavn3("Antall")
            End While
            lesernavn3.Close()
            '---------------------------------------------------------------------------------------------------

            Dim typeSporring4 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='AB-' And komponent_type ='Plate';"
            Dim sqlsporring4 As New MySqlCommand(typeSporring4, tilkobling)

            Dim lesernavn4 = sqlsporring4.ExecuteReader()
            While lesernavn4.Read()
                type_ab_m.Text = lesernavn4("Antall")
            End While
            lesernavn4.Close()
            '---------------------------------------------------------------------------------------------------
            Dim typeSporring5 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='B+' And komponent_type ='Plate';"
            Dim sqlsporring5 As New MySqlCommand(typeSporring5, tilkobling)

            Dim lesernavn5 = sqlsporring5.ExecuteReader()
            While lesernavn5.Read()
                type_b_p.Text = lesernavn5("Antall")
            End While
            lesernavn5.Close()
            '---------------------------------------------------------------------------------------------------
            Dim typeSporring6 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='B-' And komponent_type ='Plate';"
            Dim sqlsporring6 As New MySqlCommand(typeSporring6, tilkobling)

            Dim lesernavn6 = sqlsporring6.ExecuteReader()
            While lesernavn6.Read()
                type_b_m.Text = lesernavn6("Antall")
            End While
            lesernavn6.Close()
            '---------------------------------------------------------------------------------------------------
            Dim typeSporring7 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='O+' And komponent_type ='Plate';"
            Dim sqlsporring7 As New MySqlCommand(typeSporring7, tilkobling)

            Dim lesernavn7 = sqlsporring7.ExecuteReader()
            While lesernavn7.Read()
                type_n_p.Text = lesernavn7("Antall")
            End While
            lesernavn7.Close()
            '---------------------------------------------------------------------------------------------------

            Dim typeSporring8 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='O-' And komponent_type ='Plate';"
            Dim sqlsporring8 As New MySqlCommand(typeSporring8, tilkobling)

            Dim lesernavn8 = sqlsporring8.ExecuteReader()
            While lesernavn8.Read()
                type_n_m.Text = lesernavn8("Antall")
            End While
            lesernavn8.Close()
            '---------------------------------------------------------------------------------------------------



        End If

        If ComboBox1.SelectedItem = "Røde blodlegemer" Then

            'SQL-spørring som henter ut

            Dim typeSporring1 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='A+' And komponent_type ='Røde blodlegemer';"
            Dim sqlsporring1 As New MySqlCommand(typeSporring1, tilkobling)

            Dim lesernavn1 = sqlsporring1.ExecuteReader()
            While lesernavn1.Read()
                type_ap.Text = lesernavn1("Antall")
            End While
            lesernavn1.Close()
            '--------------------------------------------------------------------------------------------------

            Dim typeSporring2 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='A-' And komponent_type ='Røde blodlegemer';"
            Dim sqlsporring2 As New MySqlCommand(typeSporring2, tilkobling)

            Dim lesernavn2 = sqlsporring2.ExecuteReader()
            While lesernavn2.Read()
                type_a_m.Text = lesernavn2("Antall")
            End While
            lesernavn2.Close()
            '---------------------------------------------------------------------------------------------------

            Dim typeSporring3 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='AB+' And komponent_type ='Røde blodlegemer';"
            Dim sqlsporring3 As New MySqlCommand(typeSporring3, tilkobling)

            Dim lesernavn3 = sqlsporring3.ExecuteReader()
            While lesernavn3.Read()
                type_ab_p.Text = lesernavn3("Antall")
            End While
            lesernavn3.Close()
            '---------------------------------------------------------------------------------------------------

            Dim typeSporring4 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='AB-' And komponent_type ='Røde blodlegemer';"
            Dim sqlsporring4 As New MySqlCommand(typeSporring4, tilkobling)

            Dim lesernavn4 = sqlsporring4.ExecuteReader()
            While lesernavn4.Read()
                type_ab_m.Text = lesernavn4("Antall")
            End While
            lesernavn4.Close()
            '---------------------------------------------------------------------------------------------------
            Dim typeSporring5 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='B+' And komponent_type ='Røde blodlegemer';"
            Dim sqlsporring5 As New MySqlCommand(typeSporring5, tilkobling)

            Dim lesernavn5 = sqlsporring5.ExecuteReader()
            While lesernavn5.Read()
                type_b_p.Text = lesernavn5("Antall")
            End While
            lesernavn5.Close()
            '---------------------------------------------------------------------------------------------------
            Dim typeSporring6 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='B-' And komponent_type ='Røde blodlegemer';"
            Dim sqlsporring6 As New MySqlCommand(typeSporring6, tilkobling)

            Dim lesernavn6 = sqlsporring6.ExecuteReader()
            While lesernavn6.Read()
                type_b_m.Text = lesernavn6("Antall")
            End While
            lesernavn6.Close()
            '---------------------------------------------------------------------------------------------------
            Dim typeSporring7 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='O+' And komponent_type ='Røde blodlegemer';"
            Dim sqlsporring7 As New MySqlCommand(typeSporring7, tilkobling)

            Dim lesernavn7 = sqlsporring7.ExecuteReader()
            While lesernavn7.Read()
                type_n_p.Text = lesernavn7("Antall")
            End While
            lesernavn7.Close()
            '---------------------------------------------------------------------------------------------------

            Dim typeSporring8 = "Select COUNT(pose_id)As Antall, blodtype FROM Blodlager WHERE blodtype ='O-' And komponent_type ='Røde blodlegemer';"
            Dim sqlsporring8 As New MySqlCommand(typeSporring8, tilkobling)

            Dim lesernavn8 = sqlsporring8.ExecuteReader()
            While lesernavn8.Read()
                type_n_m.Text = lesernavn8("Antall")
            End While
            lesernavn8.Close()
            '---------------------------------------------------------------------------------------------------



        End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Oppdater()
    End Sub

    Private Sub Legg_til_Click(sender As Object, e As EventArgs) Handles Legg_til.Click

        If ComboBox1.SelectedItem = "Plasma" Then

            If A_p.Checked = False And a_m.Checked = False And ab_p.Checked = False And ab_m.Checked = False And b_m.Checked = False And b_p.Checked = False And n_p.Checked = False And n_m.Checked = False Then
                MsgBox("Du må krysse av blodtype")
            Else

                AddPlasma()
                Oppdater()
                Nullstill()
            End If
        End If

        If ComboBox1.SelectedItem = "Plate" Then
            If A_p.Checked = False And a_m.Checked = False And ab_p.Checked = False And ab_m.Checked = False And b_m.Checked = False And b_p.Checked = False And n_p.Checked = False And n_m.Checked = False Then
                MsgBox("Du må krysse av blodtype")
            Else
                AddPlate()
                Oppdater()
                Nullstill()
            End If

        End If
        If ComboBox1.SelectedItem = "Røde blodlegemer" Then
            If A_p.Checked = False And a_m.Checked = False And ab_p.Checked = False And ab_m.Checked = False And b_m.Checked = False And b_p.Checked = False And n_p.Checked = False And n_m.Checked = False Then
                MsgBox("Du må krysse av blodtype")
            Else

                AddRodeblodlegemer()
                Oppdater()
                Nullstill()
            End If
        End If
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Du må velge blodkomponent!")

        End If

    End Sub

    Private Sub Ta_ut_Click(sender As Object, e As EventArgs) Handles Ta_ut.Click

        If ComboBox1.SelectedItem = "Plasma" Then
            If A_p.Checked = False And a_m.Checked = False And ab_p.Checked = False And ab_m.Checked = False And b_m.Checked = False And b_p.Checked = False And n_p.Checked = False And n_m.Checked = False Then
                MsgBox("Du må krysse av blodtype")
            Else

                DeletePlasma()
                Oppdater()
                Nullstill()
            End If

        End If

        If ComboBox1.SelectedItem = "Plate" Then
            If A_p.Checked = False And a_m.Checked = False And ab_p.Checked = False And ab_m.Checked = False And b_m.Checked = False And b_p.Checked = False And n_p.Checked = False And n_m.Checked = False Then
                MsgBox("Du må krysse av blodtype")
            Else
                DeletePlate()
                Oppdater()
                Nullstill()
            End If
        End If
        If ComboBox1.SelectedItem = "Røde blodlegemer" Then
            If A_p.Checked = False And a_m.Checked = False And ab_p.Checked = False And ab_m.Checked = False And b_m.Checked = False And b_p.Checked = False And n_p.Checked = False And n_m.Checked = False Then
                MsgBox("Du må krysse av blodtype")
            Else
                DeleteRodeblodlegemer()
                Oppdater()
                Nullstill()
            End If

        End If
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Du må velge blodkomponent!")

        End If

    End Sub





    Private Function sporringadd(ByVal sql As String) As DataTable

        Dim tabell As New DataTable
        Try
            'tilkobling3.Open()

            Dim kommando As New MySqlCommand(sql, tilkobling)
            Dim da As New MySqlDataAdapter

            da.SelectCommand = kommando
            da.Fill(tabell)


            'tilkobling3.Close()


        Catch ex As Exception
            MessageBox.Show("En feil har oppstått: " & ex.Message)
            'tilkobling3.Close()
        End Try

        Return tabell
    End Function
    Private Sub sporringDelete(sql As String)

        Dim cmd As New MySqlCommand(sql, tilkobling)

        Try



            If MessageBox.Show("Vil du ta ut?", "Ta ut?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then

                cmd.ExecuteNonQuery()

                        MsgBox("Blod tatt ut!")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub DeletePlasma()

        Try

            If A_p.Checked Then
                If type_ap.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'A+' And komponent_type = 'Plasma' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------


            If a_m.Checked Then
                If type_a_m.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'A-' And komponent_type = 'Plasma' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------


            If ab_p.Checked Then
                If type_ab_p.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'AB+' And komponent_type = 'Plasma' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------

            If ab_m.Checked Then
                If type_ab_m.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'AB-' And komponent_type = 'Plasma' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------

            If b_p.Checked Then
                If type_b_p.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'B+' And komponent_type = 'Plasma' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------

            If b_m.Checked Then
                If type_b_m.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'B-' And komponent_type = 'Plasma' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------

            If n_p.Checked Then
                If type_n_p.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = '0+' And komponent_type = 'Plasma' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------


            If n_m.Checked Then
                If type_n_m.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = '0-' And komponent_type = 'Plasma' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If

        Catch ex As MySqlException
            MsgBox(ex.Message)


        End Try
    End Sub
    Private Sub DeletePlate()

        Try
            If A_p.Checked Then
                If type_ap.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'A+' And komponent_type = 'Plate' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------

            If a_m.Checked Then
                If type_a_m.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'A-' And komponent_type = 'Plate' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------

            If ab_p.Checked Then
                If type_ab_p.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'AB+' And komponent_type = 'Plate' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------

            If ab_m.Checked Then
                If type_ab_m.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'AB-' And komponent_type = 'Plate' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------

            If b_p.Checked Then
                If type_b_p.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'B+' And komponent_type = 'Plate' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------

            If b_m.Checked Then
                If type_b_m.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'B-' And komponent_type = 'Plate' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------

            If n_p.Checked Then
                If type_n_p.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'O+' And komponent_type = 'Plate' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            If n_m.Checked Then
                If type_n_m.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'O-' And komponent_type = 'Plate' Order By eks_dato ASC LIMIT 1 ;")
                Else

                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------

        Catch ex As MySqlException
            MsgBox(ex.Message)


        End Try



    End Sub
    Private Sub DeleteRodeblodlegemer()

        Try
            If A_p.Checked Then
                If type_ap.Text > 0 Then

                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'A+' And komponent_type = 'Røde blodlegemer' Order By eks_dato ASC LIMIT 1 ;")
                Else
                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '-----------------------------------------------------------------------------

            If a_m.Checked Then
                If type_a_m.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'A-' And komponent_type = 'Røde blodlegemer' Order By eks_dato ASC LIMIT 1 ;")
                Else
                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '----------------------------------------------------------------------------

            If ab_p.Checked Then
                If type_ab_p.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'AB+' And komponent_type = 'Røde blodlegemer' Order By eks_dato ASC LIMIT 1 ;")
                Else
                    MsgBox("Allerede tomt på lager.")
                End If
            End If
            '----------------------------------------------------------------------------

            If ab_m.Checked Then
                If type_ab_m.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'AB-' And komponent_type = 'Røde blodlegemer' Order By eks_dato ASC LIMIT 1 ;")
                Else
                    MsgBox("Allerede tomt på lager.")
            End If
            End If
            '----------------------------------------------------------------------------

            If b_p.Checked Then
                If type_b_p.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'B+' And komponent_type = 'Røde blodlegemer' Order By eks_dato ASC LIMIT 1 ;")
                Else
                    MsgBox("Allerede tomt på lager.")
            End If
            End If
            '----------------------------------------------------------------------------

            If b_m.Checked Then
                If type_b_m.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'B-' And komponent_type = 'Røde blodlegemer' Order By eks_dato ASC LIMIT 1 ;")
                Else
                    MsgBox("Allerede tomt på lager.")
            End If
            End If
            '----------------------------------------------------------------------------

            If n_p.Checked Then
                If type_n_p.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'O+' And komponent_type = 'Røde blodlegemer' Order By eks_dato ASC LIMIT 1 ;")
                Else
                    MsgBox("Allerede tomt på lager.")
            End If
            End If
            '----------------------------------------------------------------------------

            If n_m.Checked Then
                If type_n_m.Text > 0 Then
                    sporringDelete("DELETE FROM Blodlager Where blodtype = 'O-' And komponent_type = 'Røde blodlegemer' Order By eks_dato ASC LIMIT 1 ;")
                Else
                    MsgBox("Allerede tomt på lager.")
            End If
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)


        End Try
    End Sub
    Private Sub AddPlasma()

        Try
            If A_p.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plasma','A+',CURDATE(),CURDATE() + INTERVAL 1000 DAY);")

            End If
            If a_m.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plasma','A-',CURDATE(),CURDATE() + INTERVAL 1000 DAY);")

            End If
            If ab_p.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plasma','AB+',CURDATE(),CURDATE() + INTERVAL 1000 DAY);")

            End If
            If ab_m.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plasma','AB-',CURDATE(),CURDATE() + INTERVAL 1000 DAY);")

            End If
            If b_p.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plasma','B+',CURDATE(),CURDATE() + INTERVAL 1000 DAY);")

            End If
            If b_m.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plasma','B-',CURDATE(),CURDATE() + INTERVAL 1000 DAY);")

            End If
            If n_p.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plasma','O+',CURDATE(),CURDATE() + INTERVAL 1000 DAY);")

            End If
            If n_m.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plasma','O-',CURDATE(),CURDATE() + INTERVAL 1000 DAY);")

            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)


        End Try

    End Sub
    Private Sub AddPlate()

        Try
            If A_p.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plate','A+',CURDATE(),CURDATE() + INTERVAL 7 DAY);")

            End If
            If a_m.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plate','A-',CURDATE(),CURDATE() + INTERVAL 7 DAY);")

            End If
            If ab_p.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plate','AB+',CURDATE(),CURDATE() + INTERVAL 7 DAY);")

            End If
            If ab_m.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plate','AB-',CURDATE(),CURDATE() + INTERVAL 7 DAY);")

            End If
            If b_p.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plate','B+',CURDATE(),CURDATE() + INTERVAL 7 DAY);")

            End If
            If b_m.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plate','B-',CURDATE(),CURDATE() + INTERVAL 7 DAY);")

            End If
            If n_p.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plate','O+',CURDATE(),CURDATE() + INTERVAL 7 DAY);")

            End If
            If n_m.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Plate','O-',CURDATE(),CURDATE() + INTERVAL 7 DAY);")

            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)


        End Try



    End Sub
    Private Sub AddRodeblodlegemer()

        Try
            If A_p.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Røde blodlegemer','A+',CURDATE(),CURDATE() + INTERVAL 35 DAY);")

            End If
            If a_m.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Røde blodlegemer','A-',CURDATE(),CURDATE() + INTERVAL 35 DAY);")

            End If
            If ab_p.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Røde blodlegemer','AB+',CURDATE(),CURDATE() + INTERVAL 35 DAY);")

            End If
            If ab_m.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Røde blodlegemer','AB-',CURDATE(),CURDATE() + INTERVAL 35 DAY);")

            End If
            If b_p.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Røde blodlegemer','B+',CURDATE(),CURDATE() + INTERVAL 35 DAY);")

            End If
            If b_m.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Røde blodlegemer','B-',CURDATE(),CURDATE() + INTERVAL 35 DAY);")

            End If
            If n_p.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Røde blodlegemer','O+',CURDATE(),CURDATE() + INTERVAL 35 DAY);")

            End If
            If n_m.Checked Then
                sporringadd("INSERT INTO Blodlager (komponent_type, blodtype, tappe_dato, eks_dato) VALUES('Røde blodlegemer','O-',CURDATE(),CURDATE() + INTERVAL 35 DAY);")

            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)


        End Try



    End Sub
    Public Sub Nullstill()
        a_m.Checked = False
        A_p.Checked = False
        ab_m.Checked = False
        ab_p.Checked = False
        b_m.Checked = False
        b_p.Checked = False
        n_m.Checked = False
        n_p.Checked = False


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MinSideAnsatt.Show()
        Me.Close()


    End Sub
End Class