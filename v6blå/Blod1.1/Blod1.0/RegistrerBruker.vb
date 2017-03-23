Public Class RegistrerBruker
    Private Sub RegistrerBruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setter bakgrunnsfarge til hvit, endrer programmets tittel, endrer farge på menylinje
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip1.BackColor = Color.CornflowerBlue

    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()

    End Sub

    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        'Avslutter programmet
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Avbryt_knapp.Click
        Startside.Show()
        Me.Hide()
    End Sub

    Private Sub RegistrerBruker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim dialog As DialogResult

        dialog = MessageBox.Show("Vil du avslutte?", "Avslutt", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If dialog = DialogResult.No Then

            e.Cancel = True

        Else
            Application.ExitThread()

        End If
    End Sub
End Class