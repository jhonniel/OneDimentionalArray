Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim array(29) As Integer
        Dim i, max, maxIndex As Integer

        For i = 0 To 29
            array(i) = Rnd() * 100
            ListBox1.Items.Add(array(i))
        Next i

        max = 0
        maxIndex = 0

        For i = 0 To 29
            If (array(i) > max) Then
                max = array(i)
                maxIndex = i
            End If
        Next i
        ListBox1.Items.Add("Max Number: " & max & " Index: " & maxIndex)
    End Sub
End Class
