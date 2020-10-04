<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContest
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
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.ageTextBox = New System.Windows.Forms.TextBox()
        Me.gradeTextBox = New System.Windows.Forms.TextBox()
        Me.firstNumberTextbox = New System.Windows.Forms.TextBox()
        Me.secondNumberTextbox = New System.Windows.Forms.TextBox()
        Me.answerTextbox = New System.Windows.Forms.TextBox()
        Me.studentInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.gradeLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.mathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.problemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.divideRadioButton = New System.Windows.Forms.RadioButton()
        Me.multiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.subtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.addRadioButton = New System.Windows.Forms.RadioButton()
        Me.buttonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.summaryButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.studentInformationGroupBox.SuspendLayout()
        Me.mathProblemGroupBox.SuspendLayout()
        Me.problemTypeGroupBox.SuspendLayout()
        Me.buttonsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(22, 61)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(130, 24)
        Me.nameTextBox.TabIndex = 0
        '
        'ageTextBox
        '
        Me.ageTextBox.Location = New System.Drawing.Point(217, 63)
        Me.ageTextBox.Name = "ageTextBox"
        Me.ageTextBox.Size = New System.Drawing.Size(50, 24)
        Me.ageTextBox.TabIndex = 1
        '
        'gradeTextBox
        '
        Me.gradeTextBox.Location = New System.Drawing.Point(316, 63)
        Me.gradeTextBox.Name = "gradeTextBox"
        Me.gradeTextBox.Size = New System.Drawing.Size(50, 24)
        Me.gradeTextBox.TabIndex = 2
        '
        'firstNumberTextbox
        '
        Me.firstNumberTextbox.Location = New System.Drawing.Point(18, 72)
        Me.firstNumberTextbox.Name = "firstNumberTextbox"
        Me.firstNumberTextbox.Size = New System.Drawing.Size(130, 24)
        Me.firstNumberTextbox.TabIndex = 3
        '
        'secondNumberTextbox
        '
        Me.secondNumberTextbox.Location = New System.Drawing.Point(18, 139)
        Me.secondNumberTextbox.Name = "secondNumberTextbox"
        Me.secondNumberTextbox.Size = New System.Drawing.Size(130, 24)
        Me.secondNumberTextbox.TabIndex = 4
        '
        'answerTextbox
        '
        Me.answerTextbox.Location = New System.Drawing.Point(18, 201)
        Me.answerTextbox.Name = "answerTextbox"
        Me.answerTextbox.Size = New System.Drawing.Size(130, 24)
        Me.answerTextbox.TabIndex = 5
        '
        'studentInformationGroupBox
        '
        Me.studentInformationGroupBox.Controls.Add(Me.ageLabel)
        Me.studentInformationGroupBox.Controls.Add(Me.gradeLabel)
        Me.studentInformationGroupBox.Controls.Add(Me.nameLabel)
        Me.studentInformationGroupBox.Controls.Add(Me.ageTextBox)
        Me.studentInformationGroupBox.Controls.Add(Me.nameTextBox)
        Me.studentInformationGroupBox.Controls.Add(Me.gradeTextBox)
        Me.studentInformationGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentInformationGroupBox.Location = New System.Drawing.Point(18, 23)
        Me.studentInformationGroupBox.Name = "studentInformationGroupBox"
        Me.studentInformationGroupBox.Size = New System.Drawing.Size(437, 107)
        Me.studentInformationGroupBox.TabIndex = 6
        Me.studentInformationGroupBox.TabStop = False
        Me.studentInformationGroupBox.Text = "Student Information"
        '
        'ageLabel
        '
        Me.ageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageLabel.Location = New System.Drawing.Point(218, 41)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(48, 20)
        Me.ageLabel.TabIndex = 3
        Me.ageLabel.Text = "Age"
        '
        'gradeLabel
        '
        Me.gradeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeLabel.Location = New System.Drawing.Point(317, 42)
        Me.gradeLabel.Name = "gradeLabel"
        Me.gradeLabel.Size = New System.Drawing.Size(61, 20)
        Me.gradeLabel.TabIndex = 3
        Me.gradeLabel.Text = "Grade"
        '
        'nameLabel
        '
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(22, 41)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(48, 20)
        Me.nameLabel.TabIndex = 3
        Me.nameLabel.Text = "Name"
        '
        'mathProblemGroupBox
        '
        Me.mathProblemGroupBox.Controls.Add(Me.secondNumberTextbox)
        Me.mathProblemGroupBox.Controls.Add(Me.firstNumberTextbox)
        Me.mathProblemGroupBox.Controls.Add(Me.Label3)
        Me.mathProblemGroupBox.Controls.Add(Me.Label2)
        Me.mathProblemGroupBox.Controls.Add(Me.Label1)
        Me.mathProblemGroupBox.Controls.Add(Me.answerTextbox)
        Me.mathProblemGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mathProblemGroupBox.Location = New System.Drawing.Point(18, 152)
        Me.mathProblemGroupBox.Name = "mathProblemGroupBox"
        Me.mathProblemGroupBox.Size = New System.Drawing.Size(226, 241)
        Me.mathProblemGroupBox.TabIndex = 7
        Me.mathProblemGroupBox.TabStop = False
        Me.mathProblemGroupBox.Text = "Current Math Problem"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Student Answer"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "2nd Number"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "1st Number"
        '
        'problemTypeGroupBox
        '
        Me.problemTypeGroupBox.Controls.Add(Me.divideRadioButton)
        Me.problemTypeGroupBox.Controls.Add(Me.multiplyRadioButton)
        Me.problemTypeGroupBox.Controls.Add(Me.subtractRadioButton)
        Me.problemTypeGroupBox.Controls.Add(Me.addRadioButton)
        Me.problemTypeGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.problemTypeGroupBox.Location = New System.Drawing.Point(267, 152)
        Me.problemTypeGroupBox.Name = "problemTypeGroupBox"
        Me.problemTypeGroupBox.Size = New System.Drawing.Size(188, 241)
        Me.problemTypeGroupBox.TabIndex = 8
        Me.problemTypeGroupBox.TabStop = False
        Me.problemTypeGroupBox.Text = "Math Problem Type"
        '
        'divideRadioButton
        '
        Me.divideRadioButton.AutoSize = True
        Me.divideRadioButton.Location = New System.Drawing.Point(45, 177)
        Me.divideRadioButton.Name = "divideRadioButton"
        Me.divideRadioButton.Size = New System.Drawing.Size(66, 22)
        Me.divideRadioButton.TabIndex = 3
        Me.divideRadioButton.TabStop = True
        Me.divideRadioButton.Text = "Divide"
        Me.divideRadioButton.UseVisualStyleBackColor = True
        '
        'multiplyRadioButton
        '
        Me.multiplyRadioButton.AutoSize = True
        Me.multiplyRadioButton.Location = New System.Drawing.Point(45, 132)
        Me.multiplyRadioButton.Name = "multiplyRadioButton"
        Me.multiplyRadioButton.Size = New System.Drawing.Size(75, 22)
        Me.multiplyRadioButton.TabIndex = 2
        Me.multiplyRadioButton.TabStop = True
        Me.multiplyRadioButton.Text = "Multiply"
        Me.multiplyRadioButton.UseVisualStyleBackColor = True
        '
        'subtractRadioButton
        '
        Me.subtractRadioButton.AutoSize = True
        Me.subtractRadioButton.Location = New System.Drawing.Point(45, 92)
        Me.subtractRadioButton.Name = "subtractRadioButton"
        Me.subtractRadioButton.Size = New System.Drawing.Size(81, 22)
        Me.subtractRadioButton.TabIndex = 1
        Me.subtractRadioButton.TabStop = True
        Me.subtractRadioButton.Text = "Subtract"
        Me.subtractRadioButton.UseVisualStyleBackColor = True
        '
        'addRadioButton
        '
        Me.addRadioButton.AutoSize = True
        Me.addRadioButton.Location = New System.Drawing.Point(45, 53)
        Me.addRadioButton.Name = "addRadioButton"
        Me.addRadioButton.Size = New System.Drawing.Size(51, 22)
        Me.addRadioButton.TabIndex = 0
        Me.addRadioButton.TabStop = True
        Me.addRadioButton.Text = "Add"
        Me.addRadioButton.UseVisualStyleBackColor = True
        '
        'buttonsGroupBox
        '
        Me.buttonsGroupBox.Controls.Add(Me.exitButton)
        Me.buttonsGroupBox.Controls.Add(Me.summaryButton)
        Me.buttonsGroupBox.Controls.Add(Me.clearButton)
        Me.buttonsGroupBox.Controls.Add(Me.submitButton)
        Me.buttonsGroupBox.Location = New System.Drawing.Point(461, 23)
        Me.buttonsGroupBox.Name = "buttonsGroupBox"
        Me.buttonsGroupBox.Size = New System.Drawing.Size(237, 370)
        Me.buttonsGroupBox.TabIndex = 9
        Me.buttonsGroupBox.TabStop = False
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(56, 289)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(119, 51)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'summaryButton
        '
        Me.summaryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summaryButton.Location = New System.Drawing.Point(56, 204)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(119, 51)
        Me.summaryButton.TabIndex = 0
        Me.summaryButton.Text = "Summary"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(56, 115)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(119, 51)
        Me.clearButton.TabIndex = 0
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'submitButton
        '
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(56, 32)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(119, 51)
        Me.submitButton.TabIndex = 0
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'MathContest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 405)
        Me.Controls.Add(Me.buttonsGroupBox)
        Me.Controls.Add(Me.problemTypeGroupBox)
        Me.Controls.Add(Me.mathProblemGroupBox)
        Me.Controls.Add(Me.studentInformationGroupBox)
        Me.Name = "MathContest"
        Me.Text = "Form1"
        Me.studentInformationGroupBox.ResumeLayout(False)
        Me.studentInformationGroupBox.PerformLayout()
        Me.mathProblemGroupBox.ResumeLayout(False)
        Me.mathProblemGroupBox.PerformLayout()
        Me.problemTypeGroupBox.ResumeLayout(False)
        Me.problemTypeGroupBox.PerformLayout()
        Me.buttonsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents ageTextBox As TextBox
    Friend WithEvents gradeTextBox As TextBox
    Friend WithEvents firstNumberTextbox As TextBox
    Friend WithEvents secondNumberTextbox As TextBox
    Friend WithEvents answerTextbox As TextBox
    Friend WithEvents studentInformationGroupBox As GroupBox
    Friend WithEvents mathProblemGroupBox As GroupBox
    Friend WithEvents problemTypeGroupBox As GroupBox
    Friend WithEvents divideRadioButton As RadioButton
    Friend WithEvents multiplyRadioButton As RadioButton
    Friend WithEvents subtractRadioButton As RadioButton
    Friend WithEvents addRadioButton As RadioButton
    Friend WithEvents buttonsGroupBox As GroupBox
    Friend WithEvents exitButton As Button
    Friend WithEvents summaryButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents submitButton As Button
    Friend WithEvents ageLabel As Label
    Friend WithEvents gradeLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
