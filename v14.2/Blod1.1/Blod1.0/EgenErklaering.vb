Imports MySql.Data.MySqlClient


Public Class EgenErklaering
    Public tilkobling As MySqlConnection
    Dim BtnClickCount As Integer = 0
    Private Sub EgenEgerklaering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.WhiteSmoke
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip1.BackColor = Color.CornflowerBlue

    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click

        'Restarter programmet
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

    Private Sub EgenErklaering_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If BtnClickCount = 0 Then

            Dim dialog As DialogResult

            dialog = MessageBox.Show("Vil du logge ut og avslutte?", "Avslutt", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dialog = DialogResult.No Then

                e.Cancel = True

            Else
                Application.Exit()

            End If
        End If
    End Sub

    Private Sub Avbryt_Click(sender As Object, e As EventArgs) Handles Avbryt.Click
        Dim loggav As DialogResult

        loggav = MessageBox.Show("Er du sikker på at du vil avbryte?", "Avbryt", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If loggav = DialogResult.Yes Then
            BtnClickCount = 1
            MinSideGiver.Show()
            Me.Close()
        Else
        End If

    End Sub
End Class