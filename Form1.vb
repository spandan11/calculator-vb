Public Class Form1
    Dim num1, num2, ans As Double
    Dim op As String
    Private Sub NumClick(sender As Object, e As MouseEventArgs) Handles btn9.MouseClick, btn8.MouseClick, btn7.MouseClick, btn6.MouseClick, btn5.MouseClick, btn4.MouseClick, btn3.MouseClick, btn2.MouseClick, btn1.MouseClick, btndot.MouseClick, btn0.MouseClick, btn00.MouseClick
        Dim b As Button = sender
        If (txtDisplay.Text = "0") Then
            txtDisplay.Clear()
            txtDisplay.Text = b.Text
        ElseIf (b.Text = ".") Then
            If (Not txtDisplay.Text.Contains(".")) Then
                txtDisplay.Text = txtDisplay.Text + b.Text
            End If
        Else
            txtDisplay.Text = txtDisplay.Text + b.Text
        End If
    End Sub

    Private Sub BtnCE(sender As Object, e As EventArgs) Handles btnclear.Click
        txtDisplay.Clear()
        Dim fn, sn As String
        fn = Convert.ToString(num1)
        sn = Convert.ToString(num2)
        fn = ""
        sn = ""
    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
        End If
        If txtDisplay.Text = "" Then
            txtDisplay.Text = "0"
        End If
    End Sub

    Private Sub ClickOp(sender As Object, e As MouseEventArgs) Handles btndivide.MouseClick, btnmultiply.MouseClick, btnplus.MouseClick, btnminus.MouseClick
        Dim b As Button = sender
        num1 = Convert.ToDouble(txtDisplay.Text)
        op = b.Text
        txtDisplay.Text = ""
    End Sub

    Private Sub BtnEquals_Click(sender As Object, e As EventArgs) Handles BtnEquals.Click
        num2 = Convert.ToDouble(txtDisplay.Text)

        If op = "+" Then
            ans = num1 + num2
            txtDisplay.Text = Convert.ToString(ans)
        ElseIf op = "-" Then
            ans = num1 - num2
            txtDisplay.Text = Convert.ToString(ans)
        ElseIf op = "/" Then
            ans = num1 / num2
            txtDisplay.Text = Convert.ToString(ans)
        ElseIf op = "*" Then
            ans = num1 * num2
            txtDisplay.Text = Convert.ToString(ans)
        End If
    End Sub
End Class
