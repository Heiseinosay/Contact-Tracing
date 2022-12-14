Imports WebCam_Capture
Public Class Form8Mall2Loc
    Dim DTTable As New DataTable
    Dim MaxRows As Integer
    Dim completed As Boolean = False

    WithEvents MyWebcam As WebCamCapture
    Private Sub MyWebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles MyWebcam.ImageCaptured
        PictureBox1.Image = e.WebCamImage

    End Sub

    Private Sub StartWebcam()
        Try
            'StopWebcam()
            MyWebcam = New WebCamCapture
            MyWebcam.Start(0)
            MyWebcam.Start(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StopWebcam()
        Try
            MyWebcam.Stop()
            MyWebcam.Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim form5 = New Form5LocationSelection()
        form5.Show()
        Me.Hide()
    End Sub

    Public Sub inputValidation()
        If txtScanID.Text = "" Then
            MessageBox.Show("Please Enter Person's ID.")
        Else
            completed = True
        End If
    End Sub

    Private Sub btnTimeIn_Click(sender As Object, e As EventArgs) Handles btnTimeIn.Click
        inputValidation()
        If completed = True Then
            Dim scannedID As Integer = txtScanID.Text
            DTTable = ExecuteQuery("SELECT * FROM Persons WHERE ID = " & scannedID)
            MaxRows = DTTable.Rows.Count

            If MaxRows = 0 Then
                MessageBox.Show("The record does not exist")
            Else
                DTTable = ExecuteQuery("INSERT INTO TimeEnter VALUES(" & scannedID & ", GETDATE(), CURRENT_TIMESTAMP, 102);")
            End If
        End If
        txtScanID.Text = ""
        completed = False

    End Sub

    Private Sub btnTimeOut_Click(sender As Object, e As EventArgs) Handles btnTimeOut.Click
        inputValidation()
        If completed = True Then
            Dim scannedID As Integer = txtScanID.Text
            Dim checked As Integer
            DTTable = ExecuteQuery("SELECT * FROM Persons WHERE ID = " & scannedID)
            MaxRows = DTTable.Rows.Count
            DTTable = ExecuteQuery("SELECT * FROM TimeEnter WHERE PersonID = " & scannedID & "AND locationID = 102")
            checked = DTTable.Rows.Count

            If MaxRows = 0 Then
                MessageBox.Show("The record does not exist")
            ElseIf checked = 0 Then
                MessageBox.Show("The Person does not undergo Time Enter.")
            Else
                DTTable = ExecuteQuery("INSERT INTO TimeExit VALUES(" & scannedID & ", GETDATE(), CURRENT_TIMESTAMP, 102);")
            End If
        End If
        txtScanID.Text = ""
        completed = False
    End Sub

    Private Sub txtScanID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScanID.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This will accept numbers only")
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartWebcam()
        txtScanID.Clear()
    End Sub

End Class