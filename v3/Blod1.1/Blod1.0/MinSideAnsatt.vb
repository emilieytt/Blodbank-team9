Public Class MinSideAnsatt
    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()
    End Sub

    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        'Avslutter programmet
        Me.Close()
    End Sub



    Private Sub MinSideAnsatt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setter bakgrunnsfarge til hvit
        Me.BackColor = Color.White
        Me.Text = "Blodbanken St. Olavs"
        MenuStrip1.BackColor = Color.Red
    End Sub
End Class