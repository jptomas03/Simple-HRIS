<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertEmployeeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstNameTB = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.LastNameTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmailTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddressTB = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmployeeIDTB = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Basic Information"
        '
        'FirstNameTB
        '
        Me.FirstNameTB.Location = New System.Drawing.Point(110, 89)
        Me.FirstNameTB.Name = "FirstNameTB"
        Me.FirstNameTB.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTB.TabIndex = 1
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(30, 253)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First Name"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(16, 118)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.LastNameLabel.TabIndex = 5
        Me.LastNameLabel.Text = "Last Name"
        '
        'LastNameTB
        '
        Me.LastNameTB.Location = New System.Drawing.Point(110, 115)
        Me.LastNameTB.Name = "LastNameTB"
        Me.LastNameTB.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTB.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Email"
        '
        'EmailTB
        '
        Me.EmailTB.Location = New System.Drawing.Point(110, 167)
        Me.EmailTB.Name = "EmailTB"
        Me.EmailTB.Size = New System.Drawing.Size(100, 20)
        Me.EmailTB.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Address"
        '
        'AddressTB
        '
        Me.AddressTB.Location = New System.Drawing.Point(110, 141)
        Me.AddressTB.Name = "AddressTB"
        Me.AddressTB.Size = New System.Drawing.Size(100, 20)
        Me.AddressTB.TabIndex = 6
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(111, 253)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Employee ID"
        '
        'EmployeeIDTB
        '
        Me.EmployeeIDTB.Location = New System.Drawing.Point(110, 193)
        Me.EmployeeIDTB.Name = "EmployeeIDTB"
        Me.EmployeeIDTB.Size = New System.Drawing.Size(100, 20)
        Me.EmployeeIDTB.TabIndex = 11
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(16, 222)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(53, 13)
        Me.Label.TabIndex = 14
        Me.Label.Text = "Password"
        '
        'PasswordTB
        '
        Me.PasswordTB.Location = New System.Drawing.Point(110, 219)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTB.TabIndex = 13
        Me.PasswordTB.UseSystemPasswordChar = True
        '
        'InsertEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 321)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EmployeeIDTB)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EmailTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AddressTB)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.LastNameTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.FirstNameTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InsertEmployeeForm"
        Me.Text = "Enter New Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FirstNameTB As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LastNameLabel As System.Windows.Forms.Label
    Friend WithEvents LastNameTB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EmailTB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AddressTB As System.Windows.Forms.TextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EmployeeIDTB As System.Windows.Forms.TextBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents PasswordTB As System.Windows.Forms.TextBox
End Class
