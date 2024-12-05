Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnFun141_Click(sender As Object, e As EventArgs) Handles BtnFun141.Click
        ' Пример позднего связывания
        Dim obj As Object
        obj = CreateObject("Lb34MyFn.1")

        txtResult.Text = obj.Fun141(txtOp1.Text, txtOp2.Text)
        obj = Nothing
    End Sub

    Private Sub BtnFun142_Click(sender As Object, e As EventArgs) Handles BtnFun142.Click
        ' Пример ID-связывания указание на TypeLib
        Dim obj As Lb34Task2ServerATLFNLib.MyFn
        obj = New Lb34Task2ServerATLFNLib.MyFn

        txtResult.Text = obj.Fun142(txtOp1.Text, txtOp2.Text, txtOp3.Text)

    End Sub

    Private Sub BtnFun143_Click(sender As Object, e As EventArgs) Handles BtnFun143.Click
        ' Пример связывания через vtbl (очень раннее связывание)

        Dim obj As New Lb34Task2ServerATLFNLib.MyFn
        Dim inputValue As Double
        Dim outputValue As Double

        ' Преобразование текста в число
        If Double.TryParse(txtOp1.Text, inputValue) Then
            obj.Fun143(inputValue, outputValue)

            txtResult.Text = outputValue.ToString()
        Else
            MessageBox.Show("Введите корректное число в поле Op1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class
