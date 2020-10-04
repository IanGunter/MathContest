Public Class MathContest



    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click

    End Sub

    Private Sub summaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

    End Sub

    Private Sub MathContest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        problemTypeGroupBox.Enabled = False
        ageTextBox.Enabled = False
        gradeTextBox.Enabled = False


    End Sub

    Private Sub nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles nameTextBox.TextChanged
        If nameTextBox.Text <> "" Then
            ageTextBox.Enabled = True
        Else
            ageTextBox.Enabled = False
        End If


    End Sub

    Private Sub gradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles gradeTextBox.TextChanged

    End Sub

    Private Sub ageTextBox_TextChanged(sender As Object, e As EventArgs) Handles ageTextBox.TextChanged
        If ageTextBox.Text <> "" Then
            gradeTextBox.Enabled = True
        Else
            gradeTextBox.Enabled = False
        End If
    End Sub
End Class
