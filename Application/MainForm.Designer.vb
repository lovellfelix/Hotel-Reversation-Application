<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.exitButton = New System.Windows.Forms.Button
        Me.logOffButton = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.checkOutButton = New System.Windows.Forms.Button
        Me.checkInButton = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(275, 182)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(69, 23)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'logOffButton
        '
        Me.logOffButton.Location = New System.Drawing.Point(192, 182)
        Me.logOffButton.Name = "logOffButton"
        Me.logOffButton.Size = New System.Drawing.Size(77, 23)
        Me.logOffButton.TabIndex = 2
        Me.logOffButton.Text = "&Log Off..."
        Me.logOffButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 193)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'checkOutButton
        '
        Me.checkOutButton.Location = New System.Drawing.Point(6, 92)
        Me.checkOutButton.Name = "checkOutButton"
        Me.checkOutButton.Size = New System.Drawing.Size(152, 64)
        Me.checkOutButton.TabIndex = 5
        Me.checkOutButton.Text = "Check &Out"
        Me.checkOutButton.UseVisualStyleBackColor = True
        '
        'checkInButton
        '
        Me.checkInButton.Location = New System.Drawing.Point(6, 22)
        Me.checkInButton.Name = "checkInButton"
        Me.checkInButton.Size = New System.Drawing.Size(152, 64)
        Me.checkInButton.TabIndex = 5
        Me.checkInButton.Text = "Check &In"
        Me.checkInButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkInButton)
        Me.GroupBox1.Controls.Add(Me.checkOutButton)
        Me.GroupBox1.Location = New System.Drawing.Point(186, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 161)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reservation &Menu"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 216)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.logOffButton)
        Me.Controls.Add(Me.exitButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Hotel Application| Reservation Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents logOffButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents checkOutButton As System.Windows.Forms.Button
    Friend WithEvents checkInButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
