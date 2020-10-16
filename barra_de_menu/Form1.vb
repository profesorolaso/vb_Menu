Public Class Form1
    Private Sub mnuAuto_Click(sender As Object, e As EventArgs) Handles mnuAuto.Click
        lblPrueba.ForeColor = Color.Black
    End Sub
    Private Sub mnuRojo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRojo.Click
        lblPrueba.ForeColor = Color.Red
    End Sub
    Private Sub mnuAzul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAzul.Click
        lblPrueba.ForeColor = Color.Blue
    End Sub
    Private Sub mnuVerde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVerde.Click
        lblPrueba.ForeColor = Color.Green
    End Sub
    Private Sub mnuNinguno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNinguno.Click
        lblPrueba.BorderStyle = BorderStyle.None
    End Sub
    Private Sub mnuSencillo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSencillo.Click
        lblPrueba.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Private Sub mnuEfecto3D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEfecto3D.Click
        lblPrueba.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
        End
    End Sub
End Class
