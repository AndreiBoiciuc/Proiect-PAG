Public Class Controls_info


    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave
        Label8.ForeColor = Color.DarkGray
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles Label8.MouseEnter
        Label8.ForeColor = Color.Black
    End Sub
End Class