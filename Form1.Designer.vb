<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.ExecuteButton = New System.Windows.Forms.Button()
        Me.ECIDTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ApNonceTxt = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.iOSTxt = New System.Windows.Forms.TextBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Location = New System.Drawing.Point(12, 172)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.Size = New System.Drawing.Size(280, 297)
        Me.OutputTextBox.TabIndex = 0
        '
        'ExecuteButton
        '
        Me.ExecuteButton.Location = New System.Drawing.Point(12, 143)
        Me.ExecuteButton.Name = "ExecuteButton"
        Me.ExecuteButton.Size = New System.Drawing.Size(118, 23)
        Me.ExecuteButton.TabIndex = 2
        Me.ExecuteButton.Text = "Save Blobs"
        Me.ExecuteButton.UseVisualStyleBackColor = True
        '
        'ECIDTxt
        '
        Me.ECIDTxt.Location = New System.Drawing.Point(127, 71)
        Me.ECIDTxt.Name = "ECIDTxt"
        Me.ECIDTxt.Size = New System.Drawing.Size(165, 20)
        Me.ECIDTxt.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ECID (Hex):"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"iPhone", "iPod", "iPad", "AppleTV"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(90, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(108, 26)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Identifier:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 96)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(109, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Specify ApNonce"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ApNonceTxt
        '
        Me.ApNonceTxt.Enabled = False
        Me.ApNonceTxt.Location = New System.Drawing.Point(12, 117)
        Me.ApNonceTxt.Name = "ApNonceTxt"
        Me.ApNonceTxt.Size = New System.Drawing.Size(280, 20)
        Me.ApNonceTxt.TabIndex = 10
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 52)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(113, 17)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "Latest iOS Version"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'iOSTxt
        '
        Me.iOSTxt.Location = New System.Drawing.Point(12, 71)
        Me.iOSTxt.Name = "iOSTxt"
        Me.iOSTxt.Size = New System.Drawing.Size(109, 20)
        Me.iOSTxt.TabIndex = 12
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(136, 143)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 14
        Me.saveBtn.Text = "Save Config"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "About"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 480)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.iOSTxt)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.ApNonceTxt)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ECIDTxt)
        Me.Controls.Add(Me.ExecuteButton)
        Me.Controls.Add(Me.OutputTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "SaveSHSH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents ExecuteButton As Button
    Friend WithEvents ECIDTxt As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Private WithEvents Label2 As Label
    Private WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ApNonceTxt As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents iOSTxt As TextBox
    Friend WithEvents saveBtn As Button
    Friend WithEvents Button1 As Button
End Class
