<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MotherForm
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
        Me.LogoutBT = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DepartmentLabel = New System.Windows.Forms.Label()
        Me.JobLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.UserPicture = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Db_hrisDataSet = New Simple_HRIS.db_hrisDataSet()
        Me.InsertEmployeeButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_hrisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoutBT
        '
        Me.LogoutBT.Location = New System.Drawing.Point(175, 121)
        Me.LogoutBT.Name = "LogoutBT"
        Me.LogoutBT.Size = New System.Drawing.Size(75, 23)
        Me.LogoutBT.TabIndex = 0
        Me.LogoutBT.Text = "Logout"
        Me.LogoutBT.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DepartmentLabel)
        Me.GroupBox1.Controls.Add(Me.JobLabel)
        Me.GroupBox1.Controls.Add(Me.NameLabel)
        Me.GroupBox1.Controls.Add(Me.LogoutBT)
        Me.GroupBox1.Location = New System.Drawing.Point(168, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 150)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Profile"
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.AutoSize = True
        Me.DepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentLabel.Location = New System.Drawing.Point(8, 90)
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.Size = New System.Drawing.Size(234, 17)
        Me.DepartmentLabel.TabIndex = 3
        Me.DepartmentLabel.Text = "Information Technology Department"
        '
        'JobLabel
        '
        Me.JobLabel.AutoSize = True
        Me.JobLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobLabel.Location = New System.Drawing.Point(8, 62)
        Me.JobLabel.Name = "JobLabel"
        Me.JobLabel.Size = New System.Drawing.Size(141, 17)
        Me.JobLabel.TabIndex = 2
        Me.JobLabel.Text = "System Administrator"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(7, 31)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(152, 20)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Tomas, Jayson Paat"
        '
        'UserPicture
        '
        Me.UserPicture.Location = New System.Drawing.Point(12, 52)
        Me.UserPicture.Name = "UserPicture"
        Me.UserPicture.Size = New System.Drawing.Size(150, 150)
        Me.UserPicture.TabIndex = 2
        Me.UserPicture.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(165, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HRIS"
        '
        'Db_hrisDataSet
        '
        Me.Db_hrisDataSet.DataSetName = "db_hrisDataSet"
        Me.Db_hrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InsertEmployeeButton
        '
        Me.InsertEmployeeButton.Location = New System.Drawing.Point(349, 12)
        Me.InsertEmployeeButton.Name = "InsertEmployeeButton"
        Me.InsertEmployeeButton.Size = New System.Drawing.Size(75, 23)
        Me.InsertEmployeeButton.TabIndex = 4
        Me.InsertEmployeeButton.Text = "Add User"
        Me.InsertEmployeeButton.UseVisualStyleBackColor = True
        '
        'MotherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(446, 222)
        Me.Controls.Add(Me.InsertEmployeeButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserPicture)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MotherForm"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_hrisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogoutBT As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UserPicture As System.Windows.Forms.PictureBox
    Friend WithEvents DepartmentLabel As System.Windows.Forms.Label
    Friend WithEvents JobLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Db_hrisDataSet As Simple_HRIS.db_hrisDataSet
    Friend WithEvents InsertEmployeeButton As System.Windows.Forms.Button
End Class
