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
        Me.SuspendLayout()
        '
        'LogoutBT
        '
        Me.LogoutBT.Location = New System.Drawing.Point(98, 115)
        Me.LogoutBT.Name = "LogoutBT"
        Me.LogoutBT.Size = New System.Drawing.Size(75, 23)
        Me.LogoutBT.TabIndex = 0
        Me.LogoutBT.Text = "Logout"
        Me.LogoutBT.UseVisualStyleBackColor = True
        '
        'MotherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LogoutBT)
        Me.Name = "MotherForm"
        Me.Text = "MotherForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogoutBT As System.Windows.Forms.Button
End Class
