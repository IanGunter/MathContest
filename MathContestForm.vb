'Ian Gunter
'RCET 0265
'Fall 2020
'Math Contest
'https://github.com/IanGunter/MathContest.git


'remove blank lines - TJR
Option Explicit On
Option Strict On

Public Class MathContestForm
    'Dim variables to be used across different subs - Global - TJR
    Dim attempts As Integer
    Dim correctattempts As Integer ' camelCase - TJR

    'ClearButton clears all fields and resets the program.
    Public Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        nameTextBox.Text = ""
        ageTextBox.Text = ""
        gradeTextBox.Text = ""
        addRadioButton.Checked = True
        answerTextbox.Text = ""
        attempts = 0
        correctattempts = 0
        summaryButton.Enabled = False
        submitButton.Enabled = True
    End Sub

    Public Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        'Variables used in sub 
        Dim rightAnswer As Integer
        Dim studentAnswer As Integer

        'Try Catch converts students input to an integer so it can be compared to the correct answer.
        Try
            studentAnswer = CInt(answerTextbox.Text)

        Catch ex As Exception
            'If input is not a number the sub exits and prompts the user.
            answerTextbox.ResetText()
            MsgBox("Enter Numbers Only.")
            Exit Sub

        End Try
        'Summary button is enabled onced one answer has been submitted.
        summaryButton.Enabled = True

        'Adds 1 to the amount of times the questions have been attempted by the user.
        attempts += 1

        'If statements change the value of textboxes 1st number and second number depending on the question assigned.
        If addRadioButton.Checked = True Then

            firstNumberTextbox.Text = 5 ' either generate random or let user enter new numbers - TJR
            secondNumberTextbox.Text = 3

            rightAnswer = CInt(firstNumberTextbox.Text) + CInt(secondNumberTextbox.Text)
        End If

        If subtractRadioButton.Checked = True Then

            firstNumberTextbox.Text = 21
            secondNumberTextbox.Text = 9

            rightAnswer = CInt(firstNumberTextbox.Text) - CInt(secondNumberTextbox.Text)
        End If

        If multiplyRadioButton.Checked = True Then

            firstNumberTextbox.Text = 5
            secondNumberTextbox.Text = 7

            rightAnswer = CInt(firstNumberTextbox.Text) * CInt(secondNumberTextbox.Text)
        End If

        If divideRadioButton.Checked = True Then

            firstNumberTextbox.Text = 36
            secondNumberTextbox.Text = 4

            rightAnswer = CInt(firstNumberTextbox.Text) / CInt(secondNumberTextbox.Text)
        End If


        If rightAnswer = studentAnswer Then

            'Adds 1 to the amount of correct answers submitted by the user.
            correctattempts += 1


            MsgBox("Congratulation! That is the correct answer.")
            answerTextbox.ResetText()


        Else MsgBox("Incorrect. The correct answer is " & CStr(rightAnswer))
            answerTextbox.ResetText()
        End If

        'remove blank lines - TJR

    End Sub

    Public Sub summaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click
        'Displays the amount of answers were correct.
        MsgBox(nameTextBox.Text & " got " & correctattempts & " out of " & attempts & " correct.")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MathContest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the startup conditions when the Form is launched. 
        problemTypeGroupBox.Enabled = False
        ageTextBox.Enabled = False
        gradeTextBox.Enabled = False
        addRadioButton.Checked = True
        firstNumberTextbox.Enabled = False
        secondNumberTextbox.Enabled = False
        answerTextbox.Enabled = False
        submitButton.Enabled = False
        summaryButton.Enabled = False

        'remove blank lines - TJR
    End Sub

    Private Sub nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles nameTextBox.TextChanged
        'Enable age textbox once name textbox has input.
        If nameTextBox.Text <> "" Then
            ageTextBox.Enabled = True
        Else
            ageTextBox.Enabled = False
        End If

        'remove blank lines - TJR
    End Sub

    Private Sub gradeTextBox_Unselected(sender As Object, e As EventArgs) Handles gradeTextBox.Leave ' too many pop ups - TJR
        Dim Grade As Integer

        ''When grade texbox is unselected the input is checked to see if they are integers and within the parameters required. 
        If gradeTextBox.Text <> "" Then

            Try
                Grade = CInt(gradeTextBox.Text)

            Catch ex As Exception
                gradeTextBox.ResetText()
                MsgBox("Enter Student Grade Level as a Number.")
                Exit Sub
            End Try

        Else
            problemTypeGroupBox.Enabled = False
        End If

        If Grade < 1 Or Grade > 4 Then
            gradeTextBox.ResetText()
            MsgBox("Student not eligible to compete.")

            'remove blank lines - TJR
        End If
    End Sub
    Private Sub gradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles gradeTextBox.TextChanged
        'Enable problem type group box once grade text box has input.

        If gradeTextBox.Text <> "" Then
            problemTypeGroupBox.Enabled = True
            answerTextbox.Enabled = True
        Else
            problemTypeGroupBox.Enabled = False
        End If

    End Sub

    Private Sub ageTextBox_Unselected(sender As Object, e As EventArgs) Handles ageTextBox.Leave ' too many pop ups - TJR
        Dim age As Integer

        'Set parameters for age and checks if age is an integer once the texbox is unselected.

        If ageTextBox.Text <> "" Then

            'remove blank lines - TJR
            Try
                age = CInt(ageTextBox.Text)

                'remove blank lines - TJR

            Catch ex As Exception

                ageTextBox.ResetText()
                MsgBox("Enter Student Age as a Number.")
                Exit Sub

            End Try

        Else
            gradeTextBox.Enabled = False

        End If

        If age < 7 Or age > 11 Then
            ageTextBox.ResetText()
            MsgBox("Student not eligible to compete.")
        End If

    End Sub

    Private Sub ageTextBox_TextChanged(sender As Object, e As EventArgs) Handles ageTextBox.TextChanged
        If ageTextBox.Text <> "" Then
            gradeTextBox.Enabled = True
        Else
            gradeTextBox.Enabled = False
        End If
    End Sub

    Private Sub addRadioButton_Checked(sender As Object, e As EventArgs) Handles addRadioButton.CheckedChanged
        Dim answer As Integer
        firstNumberTextbox.Text = 5
        secondNumberTextbox.Text = 3

        answer = CInt(firstNumberTextbox.Text) + CInt(secondNumberTextbox.Text)

        'remove blank lines - TJR
    End Sub

    Private Sub subtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles subtractRadioButton.CheckedChanged
        firstNumberTextbox.Text = 21
        secondNumberTextbox.Text = 9
    End Sub

    Private Sub multiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles multiplyRadioButton.CheckedChanged
        firstNumberTextbox.Text = 5
        secondNumberTextbox.Text = 7
    End Sub

    Private Sub divideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles divideRadioButton.CheckedChanged
        firstNumberTextbox.Text = 36
        secondNumberTextbox.Text = 4
    End Sub

    Private Sub answerTextbox_TextChanged(sender As Object, e As EventArgs) Handles answerTextbox.TextChanged
        If answerTextbox.Text <> "" Then
            submitButton.Enabled = True
        End If
    End Sub
End Class






