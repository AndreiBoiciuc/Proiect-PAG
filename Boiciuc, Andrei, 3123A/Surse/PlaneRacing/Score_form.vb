Public Class Score_form
    Dim wait As Integer = 0
    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Convert.ToString(Convert.ToInt32(Game.score))
        If Game.score < 10 Then
            Label2.Location = New Point(85, 165)
        ElseIf Game.score < 100 Then
            Label2.Location = New Point(67, 165)
        ElseIf Game.score < 1000 Then
            Label2.Location = New Point(48, 165)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        wait += 1

        If wait > 15 Then
            Game.Reset_game()
        End If

        If wait > 30 Then

            wait = 0
            Timer1.Enabled = False
            Me.Close()
        End If
    End Sub
End Class