Public Class Form3_Selection
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim FirstFormHome = New Form1()
        FirstFormHome.Show()
        Me.Close()
    End Sub

    Private Sub btnRegisterCitizen_Click(sender As Object, e As EventArgs) Handles btnRegisterCitizen.Click
        Dim fourthFormADD = New Form4_Add()
        fourthFormADD.Show()
        Me.Hide()
    End Sub

    Private Sub btnTrack_Click(sender As Object, e As EventArgs) Handles btnTrack.Click
        Dim form7 = New Form7Track()
        form7.Show()
        Me.Hide()
    End Sub
End Class