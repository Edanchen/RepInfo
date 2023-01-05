Public Class Form1
    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub GattungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GattungToolStripMenuItem.Click
        gattung.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gattung.Show()
    End Sub
End Class
