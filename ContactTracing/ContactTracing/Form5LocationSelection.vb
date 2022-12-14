Public Class Form5LocationSelection
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim home = New Form1()
        home.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form6MallLoc = New Form6MallLoc()
        form6MallLoc.Show()
        Me.Hide()
    End Sub

    Private Sub btnLocPark_Click(sender As Object, e As EventArgs) Handles btnLocPark.Click
        Dim form8 = New Form8Mall2Loc()
        form8.Show()
        Me.Hide()
    End Sub

End Class