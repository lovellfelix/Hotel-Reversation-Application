<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.EmployeeInfoButton = New System.Windows.Forms.Button
        Me.PayRollButton = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.logOffButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EmployeeInfoButton)
        Me.GroupBox1.Controls.Add(Me.PayRollButton)
        Me.GroupBox1.Location = New System.Drawing.Point(175, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 161)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Infomation &Menu"
        '
        'EmployeeInfoButton
        '
        Me.EmployeeInfoButton.Location = New System.Drawing.Point(6, 22)
        Me.EmployeeInfoButton.Name = "EmployeeInfoButton"
        Me.EmployeeInfoButton.Size = New System.Drawing.Size(152, 64)
        Me.EmployeeInfoButton.TabIndex = 5
        Me.EmployeeInfoButton.Text = "Employee Information"
        Me.EmployeeInfoButton.UseVisualStyleBackColor = True
        '
        'PayRollButton
        '
        Me.PayRollButton.Location = New System.Drawing.Point(6, 92)
        Me.PayRollButton.Name = "PayRollButton"
        Me.PayRollButton.Size = New System.Drawing.Size(152, 64)
        Me.PayRollButton.TabIndex = 5
        Me.PayRollButton.Text = "Employee &PayRoll"
        Me.PayRollButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 193)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'logOffButton
        '
        Me.logOffButton.Location = New System.Drawing.Point(181, 182)
        Me.logOffButton.Name = "logOffButton"
        Me.logOffButton.Size = New System.Drawing.Size(77, 23)
        Me.logOffButton.TabIndex = 11
        Me.logOffButton.Text = "&Log Off..."
        Me.logOffButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(264, 182)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(69, 23)
        Me.exitButton.TabIndex = 10
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 222)
        Me.Controls.Add(Me.logOffButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel| Administrator Menu"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents EmployeeInfoButton As System.Windows.Forms.Button
    Friend WithEvents PayRollButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents logOffButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
End Class
