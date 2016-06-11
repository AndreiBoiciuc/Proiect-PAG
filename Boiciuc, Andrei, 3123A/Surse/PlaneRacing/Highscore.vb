Public Class Highscore

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Game.Reset_game()

        If Trim(TextBox1.Text).Length < 4 Then
            MessageBox.Show("Introduceti un nume de minim 4 caractere!")
        ElseIf Trim(TextBox1.Text).Length > 10 Then
            MessageBox.Show("Introduceti un nume de maxim 10 caractere!")
        Else
            Game.Label7.Text = Trim(TextBox1.Text)
            Me.Close()
        End If

    End Sub

End Class