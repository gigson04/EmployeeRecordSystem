
Public Class Form1

    Private employeesTable As New DataTable()
    Private nextId As Integer = 1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        employeesTable.Columns.Add("ID", GetType(Integer))
        employeesTable.Columns.Add("Name", GetType(String))
        employeesTable.Columns.Add("Position", GetType(String))
        employeesTable.Columns.Add("Salary", GetType(Decimal))
        employeesTable.Columns.Add("Department", GetType(String))


        dgvEmployees.DataSource = employeesTable


        AddSampleData()
    End Sub


    Private Sub AddSampleData()
        employeesTable.Rows.Add(nextId, "John Doe", "Manager", 50000.0, "HR")
        nextId += 1
        employeesTable.Rows.Add(nextId, "Jane Smith", "Developer", 45000.0, "IT")
        nextId += 1
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


        selectedRow("name") = txtName.Text
        selectedRow("position") = txtPosition.Text
        selectedRow("salary") = Convert.ToDecimal(txtSalary.Text)
        selectedRow("department") = txtDepartment.Text

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

        employeesTable.DefaultView.RowFilter = $"name LIKE '%{txtSearch.Text}%' OR Convert(id, 'System.String') LIKE '%{txtSearch.Text}%'"
    End Sub



    Private Sub dgvEmployees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEmployees.Rows(e.RowIndex)
            txtName.Text = row.Cells("name").Value.ToString()
            txtPosition.Text = row.Cells("position").Value.ToString()
            txtSalary.Text = row.Cells("salary").Value.ToString()
            txtDepartment.Text = row.Cells("department").Value.ToString()
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
End Class