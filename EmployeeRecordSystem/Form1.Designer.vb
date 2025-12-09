<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSeach = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(689, 271)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(175, 49)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(689, 316)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(175, 49)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(689, 362)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(175, 49)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSeach
        '
        Me.btnSeach.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeach.Location = New System.Drawing.Point(689, 408)
        Me.btnSeach.Name = "btnSeach"
        Me.btnSeach.Size = New System.Drawing.Size(175, 49)
        Me.btnSeach.TabIndex = 4
        Me.btnSeach.Text = "Search"
        Me.btnSeach.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(689, 226)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(175, 49)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(70, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(70, 24)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(61, 78)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(89, 24)
        Me.lblPosition.TabIndex = 7
        Me.lblPosition.Text = "Position:"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(69, 112)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(74, 24)
        Me.lblSalary.TabIndex = 8
        Me.lblSalary.Text = "Salary:"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(19, 146)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(124, 24)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Department:"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(61, 170)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(79, 24)
        Me.lblSearch.TabIndex = 10
        Me.lblSearch.Text = "Search:"
        '
        'dgvEmployees
        '
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(88, 226)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.Size = New System.Drawing.Size(542, 276)
        Me.dgvEmployees.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(146, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(773, 32)
        Me.txtName.TabIndex = 12
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Location = New System.Drawing.Point(146, 70)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(773, 32)
        Me.txtPosition.TabIndex = 13
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(146, 103)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(773, 32)
        Me.txtSalary.TabIndex = 14
        '
        'txtDepartment
        '
        Me.txtDepartment.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(146, 138)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(773, 32)
        Me.txtDepartment.TabIndex = 15
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(146, 173)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(773, 32)
        Me.txtSearch.TabIndex = 16
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(689, 453)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(175, 49)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(960, 543)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSeach)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Employee Record"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSeach As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnExit As Button
End Class
