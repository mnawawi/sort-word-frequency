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
    Me.components = New System.ComponentModel.Container()
    Me.InputBox = New System.Windows.Forms.TextBox()
    Me.CountBtn = New System.Windows.Forms.Button()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.OutputList = New System.Windows.Forms.ListView()
    Me.Word = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.Freq = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.tableView = New System.Windows.Forms.ListView()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.Button4 = New System.Windows.Forms.Button()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Button5 = New System.Windows.Forms.Button()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'InputBox
    '
    Me.InputBox.Location = New System.Drawing.Point(28, 49)
    Me.InputBox.Multiline = True
    Me.InputBox.Name = "InputBox"
    Me.InputBox.Size = New System.Drawing.Size(360, 168)
    Me.InputBox.TabIndex = 0
    '
    'CountBtn
    '
    Me.CountBtn.Location = New System.Drawing.Point(414, 49)
    Me.CountBtn.Name = "CountBtn"
    Me.CountBtn.Size = New System.Drawing.Size(107, 83)
    Me.CountBtn.TabIndex = 2
    Me.CountBtn.Text = "Count"
    Me.CountBtn.UseVisualStyleBackColor = True
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(414, 138)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(107, 83)
    Me.Button1.TabIndex = 3
    Me.Button1.Text = "Clear"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(425, 302)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(83, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Total Character:"
    '
    'Label2
    '
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(443, 336)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(44, 29)
    Me.Label2.TabIndex = 5
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(601, 47)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(239, 20)
    Me.TextBox1.TabIndex = 6
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(546, 51)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(54, 13)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "File Name"
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(601, 73)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(114, 66)
    Me.Button2.TabIndex = 8
    Me.Button2.Text = "Save"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(726, 73)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(114, 66)
    Me.Button3.TabIndex = 9
    Me.Button3.Text = "Open"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.OutputList)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(391, 379)
    Me.GroupBox1.TabIndex = 11
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Insert Word"
    '
    'OutputList
    '
    Me.OutputList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Word, Me.Freq})
    Me.OutputList.Location = New System.Drawing.Point(16, 200)
    Me.OutputList.Name = "OutputList"
    Me.OutputList.Size = New System.Drawing.Size(360, 169)
    Me.OutputList.TabIndex = 19
    Me.OutputList.UseCompatibleStateImageBehavior = False
    Me.OutputList.View = System.Windows.Forms.View.Details
    '
    'Word
    '
    Me.Word.Text = "Word"
    Me.Word.Width = 165
    '
    'Freq
    '
    Me.Freq.Text = "Frequency"
    Me.Freq.Width = 193
    '
    'tableView
    '
    Me.tableView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
    Me.tableView.Location = New System.Drawing.Point(601, 149)
    Me.tableView.Name = "tableView"
    Me.tableView.Size = New System.Drawing.Size(239, 249)
    Me.tableView.TabIndex = 12
    Me.tableView.UseCompatibleStateImageBehavior = False
    Me.tableView.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Word"
    Me.ColumnHeader1.Width = 118
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "Frequency"
    Me.ColumnHeader2.Width = 193
    '
    'GroupBox2
    '
    Me.GroupBox2.Location = New System.Drawing.Point(531, 29)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(321, 379)
    Me.GroupBox2.TabIndex = 13
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Load Data"
    '
    'Button4
    '
    Me.Button4.Location = New System.Drawing.Point(893, 98)
    Me.Button4.Name = "Button4"
    Me.Button4.Size = New System.Drawing.Size(103, 48)
    Me.Button4.TabIndex = 14
    Me.Button4.Text = "Browse"
    Me.Button4.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(805, 9)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(47, 13)
    Me.Label4.TabIndex = 15
    Me.Label4.Text = "File path"
    '
    'Button5
    '
    Me.Button5.Location = New System.Drawing.Point(893, 182)
    Me.Button5.Name = "Button5"
    Me.Button5.Size = New System.Drawing.Size(103, 91)
    Me.Button5.TabIndex = 16
    Me.Button5.Text = "Excel"
    Me.Button5.UseVisualStyleBackColor = True
    '
    'GroupBox3
    '
    Me.GroupBox3.Location = New System.Drawing.Point(871, 29)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(138, 379)
    Me.GroupBox3.TabIndex = 18
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Open with"
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Menu
    Me.ClientSize = New System.Drawing.Size(1021, 431)
    Me.Controls.Add(Me.Button5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Button4)
    Me.Controls.Add(Me.tableView)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.CountBtn)
    Me.Controls.Add(Me.InputBox)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.GroupBox3)
    Me.Name = "MainForm"
    Me.Text = "Word Count"
    Me.TransparencyKey = System.Drawing.SystemColors.GradientActiveCaption
    Me.GroupBox1.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents InputBox As System.Windows.Forms.TextBox
  Friend WithEvents CountBtn As System.Windows.Forms.Button
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents tableView As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents Button4 As System.Windows.Forms.Button
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Button5 As System.Windows.Forms.Button
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents OutputList As System.Windows.Forms.ListView
  Friend WithEvents Word As System.Windows.Forms.ColumnHeader
  Friend WithEvents Freq As System.Windows.Forms.ColumnHeader

End Class
