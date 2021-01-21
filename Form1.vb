Public Class Form1
    Dim num1, num2, temp As Integer
    Dim randomX As New Random
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        num1 = randomX.Next(1, 9)
        num2 = randomX.Next(1, 9)
        txtNum1.Text = num1
        txtNum2.Text = num2
    End Sub
    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtStatus.Text = ""
        txtProduct.Text = ""
        num1 = randomX.Next(1, 9)
        num2 = randomX.Next(1, 9)
    End Sub
    Private Sub btnverify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim userAns, key, rand, rand2 As Integer
        userAns = CInt(txtProduct.Text)
        key = num1 * num2
        rand = randomX.Next(1, 4)
        If key = userAns Then
            If rand = 1 Then
                txtStatus.Text = "Very good!"
            ElseIf rand = 2 Then
                txtStatus.Text = "Excellent"
            ElseIf rand = 3 Then
                txtStatus.Text = "Nice work!"
            ElseIf rand = 4 Then
                txtStatus.Text = "Keep up the good work!"
            End If
        ElseIf key <> userAns Then
            If rand = 1 Then
                txtStatus.Text = "No, but thanks for trying"
            ElseIf rand = 2 Then
                txtStatus.Text = "Close, but not quite right"
            ElseIf rand = 3 Then
                txtStatus.Text = "Wrong answer."
            ElseIf rand = 4 Then
                txtStatus.Text = "No, but it's ok to be wrong."
            End If
        End If
    End Sub
End Class
