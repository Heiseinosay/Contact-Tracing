Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports ContactTracing.contactTracingDB1DataSet1TableAdapters
Imports ContactTracing.contactTracingDB1DataSetTableAdapters


Public Class Form4_Add
    'Variable Declarations
    Dim DTSample As New DataTable
    Dim MaxRows As Integer
    Dim increment As Integer = 0
    Dim statement As String
    Dim search As String

    Dim firstName As String
    Dim lastName As String
    Dim Age As String
    Dim contactNumber As Long
    Dim email As String
    Dim address As String

    'Initialize
    Dim gender As String = "False"
    Dim goClicked As Boolean = False
    Dim validation As Boolean = False
    Dim searchPlaceHolder As Boolean = False
    Private Sub Form4_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContactTracingDB1DataSet1.Persons' table. You can move, or remove it, as needed.
        Me.PersonsTableAdapter.Fill(Me.ContactTracingDB1DataSet1.Persons)

    End Sub
    Private Sub radioMale_CheckedChanged(sender As Object, e As EventArgs) Handles radioMale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub radioFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radioFemale.CheckedChanged
        gender = "Female"
    End Sub

    Public Sub inputvalidation()
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or numAge.Text = "" Or numContactNo.Text = "" Or txtEmail.Text = "" Or txtAddress.Text = "" Or gender = "False" Then
            MessageBox.Show("Please Input all fields")
        Else
            validation = True
        End If
    End Sub

    'BUTTONS FUNCTION
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        inputvalidation()
        If validation = True Then
            goClicked = False
            firstName = txtFirstName.Text
            lastName = txtLastName.Text
            Age = numAge.Text
            'contactNumber = numContactNo.Text
            email = txtEmail.Text
            address = txtAddress.Text

            DTSample = ExecuteQuery("INSERT INTO Persons VALUES(
                                '" & firstName & "', '" & lastName & "', " & Age &
                                    ", '" & gender & "', " & numContactNo.Text & ", '" & email &
                                    "', '" & address & "')")

            clearAllFields()
            MessageBox.Show("The record has been successfully updated!")

            'Update vars
            increment = 0
            labelCount.Text = "0"

        End If

        Me.PersonsTableAdapter.Fill(Me.ContactTracingDB1DataSet1.Persons)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim genderValue As String

        If IsNumeric(txtSearch.Text) = True Then
            search = CInt(txtSearch.Text)
            DTSample = ExecuteQuery("SELECT *
                                FROM Persons 
                                WHERE ID = " & search)

            MaxRows = DTSample.Rows.Count
            If MaxRows = 0 Then
                MessageBox.Show("Data Does not exist")
            Else
                goClicked = True
                txtID.Text = DTSample.Rows(0).Item(0)
                txtFirstName.Text = DTSample.Rows(0).Item(1)
                txtLastName.Text = DTSample.Rows(0).Item(2)
                numAge.Text = DTSample.Rows(0).Item(3)
                genderValue = DTSample.Rows(0).Item(4)
                Select Case genderValue
                    Case "Male"
                        radioMale.Checked = True
                    Case "Female"
                        radioFemale.Checked = True
                    Case Else
                        MessageBox.Show("Null Value")

                End Select
                numContactNo.Text = DTSample.Rows(0).Item(5)
                txtEmail.Text = DTSample.Rows(0).Item(6)
                txtAddress.Text = DTSample.Rows(0).Item(7)

                labelCount.Text = MaxRows
            End If

        Else
            search = txtSearch.Text
            DTSample = ExecuteQuery("SELECT *
            From Persons 
            WHERE firstName like '%" & search & "%'")
            MaxRows = DTSample.Rows.Count
            If MaxRows = 0 Then
                MessageBox.Show("Data do not exist")
            Else
                goClicked = True
                txtID.Text = DTSample.Rows(0).Item(0)
                txtFirstName.Text = DTSample.Rows(0).Item(1)
                txtLastName.Text = DTSample.Rows(0).Item(2)
                numAge.Text = DTSample.Rows(0).Item(3)
                genderValue = DTSample.Rows(0).Item(4)
                Select Case genderValue
                    Case "Male"
                        radioMale.Checked = True
                    Case "Female"
                        radioFemale.Checked = True
                    Case Else
                        MessageBox.Show("Null Value")
                End Select
                numContactNo.Text = DTSample.Rows(0).Item(5)
                txtEmail.Text = DTSample.Rows(0).Item(6)
                txtAddress.Text = DTSample.Rows(0).Item(7)
                labelCount.Text = MaxRows
            End If
        End If
    End Sub

    'NEXT BUTTON
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim genderValue As String
        If goClicked = False Then
            MessageBox.Show("Please search a value.")
        Else
            MaxRows = DTSample.Rows.Count
            If IsNumeric(txtSearch.Text) = True Then
                MessageBox.Show("Limit has been reach")
            Else
                search = txtSearch.Text
                DTSample = ExecuteQuery("SELECT *
                                FROM Persons 
                                WHERE FirstName = '" & search & "'")
                If increment < MaxRows - 1 Then
                    increment += 1
                    txtID.Text = DTSample.Rows(increment).Item(0)
                    txtFirstName.Text = DTSample.Rows(increment).Item(1)
                    txtLastName.Text = DTSample.Rows(increment).Item(2)
                    numAge.Text = DTSample.Rows(increment).Item(3)
                    genderValue = DTSample.Rows(increment).Item(4)
                    Select Case genderValue
                        Case "Male"
                            radioMale.Checked = True
                        Case "Female"
                            radioFemale.Checked = True
                        Case Else
                            MessageBox.Show("Null Value")
                    End Select
                    numContactNo.Text = DTSample.Rows(increment).Item(5)
                    txtEmail.Text = DTSample.Rows(increment).Item(6)
                    txtAddress.Text = DTSample.Rows(increment).Item(7)
                    labelCount.Text = MaxRows
                Else
                    MessageBox.Show("Limit has been reach")
                End If
            End If
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Dim genderValue As String
        If goClicked = False Then
            MessageBox.Show("Please search a value.")
        Else
            MaxRows = DTSample.Rows.Count
            If IsNumeric(txtSearch.Text) = True Then
                MessageBox.Show("Limit has been reach")
            Else
                search = txtSearch.Text
                DTSample = ExecuteQuery("SELECT *
                                FROM Persons 
                                WHERE FirstName = '" & search & "'")
                If increment > 0 Then
                    increment -= 1
                    txtID.Text = DTSample.Rows(increment).Item(0)
                    txtFirstName.Text = DTSample.Rows(increment).Item(1)
                    txtLastName.Text = DTSample.Rows(increment).Item(2)
                    numAge.Text = DTSample.Rows(increment).Item(3)
                    genderValue = DTSample.Rows(increment).Item(4)
                    Select Case genderValue
                        Case "Male"
                            radioMale.Checked = True
                        Case "Female"
                            radioFemale.Checked = True
                        Case Else
                            MessageBox.Show("Null Value")
                    End Select
                    numContactNo.Text = DTSample.Rows(increment).Item(5)
                    txtEmail.Text = DTSample.Rows(increment).Item(6)
                    txtAddress.Text = DTSample.Rows(increment).Item(7)
                    labelCount.Text = MaxRows
                Else
                    MessageBox.Show("Limit has been reach")
                End If
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtID.Text = "" Then
            MessageBox.Show("Please select a record to delete.")
        Else
            goClicked = False
            DTSample = ExecuteQuery("Delete
                                FROM Persons 
                                WHERE ID = " & txtID.Text)
            Me.PersonsTableAdapter.Fill(Me.ContactTracingDB1DataSet1.Persons)
            MessageBox.Show("The record has been successfully deleted.")
            clearAllFields()

            'Update vars
            increment = 0
            labelCount.Text = "0"
        End If


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        inputvalidation()
        firstName = txtFirstName.Text
        lastName = txtLastName.Text
        Age = numAge.Text
        email = txtEmail.Text
        address = txtAddress.Text

        If validation = False Then
            MessageBox.Show("Records do not exist.")
        ElseIf txtID.Text = "" Then
            MessageBox.Show("Please complete all fields.")
        Else
            goClicked = False
            DTSample = ExecuteQuery("Update Persons 
                               set FirstName = '" & firstName & "', LastName = '" & lastName & "', Age = " & Age & ",   Gender = '" & gender & "', ContactNumber = " & numContactNo.Text & ", Email = '" & email & "', Address = '" & address & "'" & "
                               WHERE ID = " & txtID.Text)
            Me.PersonsTableAdapter.Fill(Me.ContactTracingDB1DataSet1.Persons)
            MessageBox.Show("The record has been successfully updated")
            clearAllFields()

            'Update vars
            increment = 0
            labelCount.Text = "0"

        End If


    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        If searchPlaceHolder = False Then
            txtSearch.Text = ""
        End If
        searchPlaceHolder = True

    End Sub

    'CLEAR ALL FIELDS
    Public Sub clearAllFields()
        goClicked = False
        txtSearch.Text = ""
        txtID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        numAge.Text = ""
        radioMale.Checked = False
        radioFemale.Checked = False
        numContactNo.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""


    End Sub

    'KEYPRESS EVENTS VALIDATION
    Private Sub numContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numContactNo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This will accept numbers only")
        End If

        If numContactNo.Text.Length > 10 And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Phone number should only be 11 digit numbers")
        End If
    End Sub

    Private Sub numAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numAge.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This will accept numbers only")
        End If

        If numAge.Text.Length > 1 And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Damnnn! 3 digits you're so olddd")
        End If
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This will accept Letters only")
        End If
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This will accept Letters only")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim thirdFormSelction = New Form3_Selection()
        thirdFormSelction.Show()
        Me.Hide()
    End Sub
End Class