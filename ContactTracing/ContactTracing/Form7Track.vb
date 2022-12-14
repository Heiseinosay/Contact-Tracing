Imports System.Data.SqlClient

Public Class Form7Track

    Dim connection As New SqlConnection("Server = DESKTOP-V3Q09HU\SQLEXPRESS; Database = contactTracingDB1; Integrated Security=True")
    Private Sub Form7Track_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Data Source=DESKTOP-V3Q09HU\SQLEXPRESS;Initial Catalog=contactTracingDB1;Integrated Security=True
        'DESKTOP-V3Q09HU\SQLEXPRESS

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim form3 = New Form3_Selection()
        form3.Show()
        Me.Hide()
    End Sub

    Public Sub filerData()
        Dim SearchQuery As String =
            "
            SELECT TimeEnter.PersonID, Persons.FirstName, Persons.FirstName, Persons.Age, Persons.Gender, Persons.ContactNumber, Persons.Email, Persons.Address, TimeEnter.TimeIn, TimeEnter.DateofEnter
            FROM ((Persons  
            INNER JOIN TimeEnter ON Persons.ID = TimeEnter.PersonID)
            LEFT JOIN tblLocation ON TimeEnter.LocationID = tblLocation.LocationID)
            WHERE TimeIn BETWEEN (SELECT TimeIn
								  FROM TimeEnter 
								  WHERE PersonID = " & txtSearchBox.Text & " AND TimeEnter.LocationID = 101 
                                  AND DateofEnter = '" & DateTimePicker1.Text & "') 
								  AND 
								 (SELECT TimeLeft
								  FROM TimeExit
								  WHERE PersonID = " & txtSearchBox.Text & " AND TimeExit.LocationID = 101  
                                  AND DateofExit = '" & DateTimePicker1.Text & "') 		
								  AND DateofEnter = '" & DateTimePicker1.Text & "'
								  AND NOT TimeEnter.PersonID = " & txtSearchBox.Text & ";"

        Dim command As New SqlCommand(SearchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dataGridContactRobinson.DataSource = table

    End Sub

    Public Sub filerData2()
        Dim SearchQuery As String = "
            SELECT TimeEnter.PersonID, Persons.FirstName, Persons.FirstName, Persons.Age, Persons.Gender, Persons.ContactNumber, Persons.Email, Persons.Address, TimeEnter.TimeIn, TimeEnter.DateofEnter
            FROM ((Persons  
            INNER JOIN TimeEnter ON Persons.ID = TimeEnter.PersonID)
            LEFT JOIN tblLocation ON TimeEnter.LocationID = tblLocation.LocationID)
            WHERE TimeIn BETWEEN (SELECT TimeIn
								  FROM TimeEnter 
								  WHERE PersonID = " & txtSearchBox.Text & " AND TimeEnter.LocationID = 102
                                  AND DateofEnter = '" & DateTimePicker1.Text & "') 
								  AND 
								 (SELECT TimeLeft
								  FROM TimeExit
								  WHERE PersonID = " & txtSearchBox.Text & " AND TimeExit.LocationID = 102
                                  AND DateofExit = '" & DateTimePicker1.Text & "') 		
								  AND DateofEnter = '" & DateTimePicker1.Text & "'
								  AND NOT TimeEnter.PersonID = " & txtSearchBox.Text & ";"

        Dim command As New SqlCommand(SearchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table2 As New DataTable()

        adapter.Fill(table2)

        dataGridContactSM.DataSource = table2
    End Sub

    Private Sub btnSearchContact_Click(sender As Object, e As EventArgs) Handles btnSearchContact.Click
        filerData()
        filerData2()
    End Sub

End Class