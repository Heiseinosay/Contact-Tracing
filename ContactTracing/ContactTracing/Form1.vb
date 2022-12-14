Public Class Form1
    Dim DTSample As New DataTable
    Dim MaxRows As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim userName As String = txtUserName.Text
        Dim password As String = txtPassword.Text

        If userName = "" Or password = "" Then
            status.Text = "Please fill the missing field"
        Else
            DTSample = ExecuteQuery("SELECT *
                                FROM tblAdmins 
                                WHERE UserName = '" & userName & "' and Password = '" & password & "'")

            MaxRows = DTSample.Rows.Count
            If MaxRows = 0 Then
                status.Text = "Incorrect username or password."
            Else
                Dim thirdFormSelction = New Form3_Selection()
                thirdFormSelction.Show()
                Me.Hide()
            End If
        End If


    End Sub

    Private Sub btnLocations_Click(sender As Object, e As EventArgs) Handles btnLocations.Click
        Dim form5 = New Form5LocationSelection()
        form5.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
