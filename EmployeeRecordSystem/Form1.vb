Imports System.Data
Imports System.IO
Public Class Form1
    Private employeesTable As New DataTable()
    Private nextId As Integer = 1
    Private dataFilePath As String = "employees.csv"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        employeesTable.Columns.Add("ID", GetType(Integer))
        employeesTable.Columns.Add("Name", GetType(String))
        employeesTable.Columns.Add("Position", GetType(String))
        employeesTable.Columns.Add("Salary", GetType(Decimal))
        employeesTable.Columns.Add("Department", GetType(String))

        LoadDataFromFile()

        dgvEmployees.DataSource = employeesTable
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not ValidateInputs() Then Return

        employeesTable.Rows.Add(nextId, txtName.Text, txtPosition.Text, Convert.ToDecimal(txtSalary.Text), txtDepartment.Text)
        nextId += 1

        MessageBox.Show("Employee added successfully!")
        ClearInputs()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an employee to update.")
            Return
        End If
        If Not ValidateInputs() Then Return

        Dim selectedRow As DataRow = employeesTable.Rows(dgvEmployees.SelectedRows(0).Index)

        selectedRow("Name") = txtName.Text
        selectedRow("Position") = txtPosition.Text
        selectedRow("Salary") = Convert.ToDecimal(txtSalary.Text)
        selectedRow("Department") = txtDepartment.Text

        MessageBox.Show("Employee updated successfully!")
        ClearInputs()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an employee to delete.")
            Return
        End If

        employeesTable.Rows.RemoveAt(dgvEmployees.SelectedRows(0).Index)

        MessageBox.Show("Employee deleted successfully!")
        ClearInputs()

        dgvEmployees.Refresh()
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        employeesTable.DefaultView.RowFilter = ""
    End Sub

    Private Sub btnSeach_Click(sender As Object, e As EventArgs) Handles btnSeach.Click
        employeesTable.DefaultView.RowFilter = $"Name LIKE '%{txtSearch.Text}%' OR Convert(ID, 'System.String') LIKE '%{txtSearch.Text}%'"
    End Sub

    Private Sub dgvEmployees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEmployees.Rows(e.RowIndex)
            txtName.Text = row.Cells("Name").Value.ToString()
            txtPosition.Text = row.Cells("Position").Value.ToString()
            txtSalary.Text = row.Cells("Salary").Value.ToString()
            txtDepartment.Text = row.Cells("Department").Value.ToString()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtName.Text) Or String.IsNullOrWhiteSpace(txtPosition.Text) Or
           String.IsNullOrWhiteSpace(txtSalary.Text) Or String.IsNullOrWhiteSpace(txtDepartment.Text) Then
            MessageBox.Show("All fields are required.")
            Return False
        End If
        If Not Decimal.TryParse(txtSalary.Text, Nothing) Then
            MessageBox.Show("Salary must be a valid number.")
            Return False
        End If
        Return True
    End Function

    Private Sub ClearInputs()
        txtName.Clear()
        txtPosition.Clear()
        txtSalary.Clear()
        txtDepartment.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        SaveDataToFile()

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub SaveDataToFile()
        Try
            Using writer As New StreamWriter(dataFilePath)
                writer.WriteLine("ID,Name,Position,Salary,Department")

                For Each row As DataRow In employeesTable.Rows
                    writer.WriteLine($"{row("ID")},{row("Name")},{row("Position")},{row("Salary")},{row("Department")}")
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadDataFromFile()
        If Not File.Exists(dataFilePath) Then Return

        Try
            Using reader As New StreamReader(dataFilePath)
                Dim line As String
                Dim isFirstLine As Boolean = True

                While Not reader.EndOfStream
                    line = reader.ReadLine()
                    If isFirstLine Then
                        isFirstLine = False
                        Continue While
                    End If

                    Dim parts As String() = line.Split(","c)
                    If parts.Length = 5 Then
                        Dim id As Integer = Convert.ToInt32(parts(0))
                        employeesTable.Rows.Add(id, parts(1), parts(2), Convert.ToDecimal(parts(3)), parts(4))
                        If id >= nextId Then nextId = id + 1
                    End If
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub
End Class