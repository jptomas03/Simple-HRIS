<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.UserLoginGB = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.StaffIDTB = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.UserLoginGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserLoginGB
        '
        Me.UserLoginGB.Controls.Add(Me.ClearButton)
        Me.UserLoginGB.Controls.Add(Me.SubmitButton)
        Me.UserLoginGB.Controls.Add(Me.PasswordTB)
        Me.UserLoginGB.Controls.Add(Me.StaffIDTB)
        Me.UserLoginGB.Controls.Add(Me.PasswordLabel)
        Me.UserLoginGB.Controls.Add(Me.UsernameLabel)
        Me.UserLoginGB.Location = New System.Drawing.Point(12, 12)
        Me.UserLoginGB.Name = "UserLoginGB"
        Me.UserLoginGB.Size = New System.Drawing.Size(260, 237)
        Me.UserLoginGB.TabIndex = 0
        Me.UserLoginGB.TabStop = False
        Me.UserLoginGB.Text = "Staff Login"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(115, 140)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(34, 140)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 4
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'PasswordTB
        '
        Me.PasswordTB.Location = New System.Drawing.Point(90, 101)
        Me.PasswordTB.MaxLength = 50
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTB.TabIndex = 3
        '
        'StaffIDTB
        '
        Me.StaffIDTB.Location = New System.Drawing.Point(90, 70)
        Me.StaffIDTB.MaxLength = 50
        Me.StaffIDTB.Name = "StaffIDTB"
        Me.StaffIDTB.Size = New System.Drawing.Size(100, 20)
        Me.StaffIDTB.TabIndex = 2
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(31, 108)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLabel.TabIndex = 1
        Me.PasswordLabel.Text = "Password"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(31, 77)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(43, 13)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Staff ID"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.UserLoginGB)
        Me.DoubleBuffered = True
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.UserLoginGB.ResumeLayout(False)
        Me.UserLoginGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserLoginGB As System.Windows.Forms.GroupBox
    Friend WithEvents PasswordTB As System.Windows.Forms.TextBox
    Friend WithEvents StaffIDTB As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents SubmitButton As System.Windows.Forms.Button

End Class
