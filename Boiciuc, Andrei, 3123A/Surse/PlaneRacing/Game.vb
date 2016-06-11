Public Class Game
    

    Public my_row As Integer
    Public y1 As Integer = 10
    Public y2 As Integer = 243
    Public x1 As Integer = 1
    Public x2 As Integer = 2
    Public score As Double = 0
    Public max_score As Integer = 0
    Dim score_counter As Double = 0.05
    Dim nume As String
    Dim wait As Integer = 0


    Private Sub Game_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawRectangle(Pens.Blue, 10, 83, 188, 392)
    End Sub


    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PictureBox1.Location = New Point(74, 332)
        my_row = 2
    End Sub


    Private Sub Game_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Left And Not my_row = 1 And Timer1.Enabled = True Then
            my_row -= 1
            PictureBox1.Location = New Point(10 + ((my_row - 1) * 3 * 21), 403)
        End If

        If e.KeyCode = Keys.Right And Not my_row = 3 And Timer1.Enabled = True Then
            my_row += 1
            PictureBox1.Location = New Point(10 + ((my_row - 1) * 3 * 21), 403)
        End If

        If e.KeyCode = Keys.Down And Convert.ToString((10 / Timer1.Interval) * 100) > 8.3 Then
            Timer1.Interval += 20
            score_counter -= 0.01
            If ((10 / Timer1.Interval) * 100) > 50 Then
                Label1.Text = "Rocket mode activated!"
                Label1.ForeColor = Color.Red
                PictureBox6.Image = My.Resources.rocket
            ElseIf ((10 / Timer1.Interval) * 100) > 46 Then
                Label1.Text = "I like to live dangerous!"
                Label1.ForeColor = Color.Orange
                PictureBox6.Image = My.Resources.danger
            ElseIf ((10 / Timer1.Interval) * 100) > 24 Then
                Label1.Text = "Watch the speedometer!"
                Label1.ForeColor = Color.Gold
                PictureBox6.Image = My.Resources.speed
            ElseIf ((10 / Timer1.Interval) * 100) > 16 Then
                Label1.Text = "That's all you got?"
                Label1.ForeColor = Color.Gray
                PictureBox6.Image = My.Resources.better
            ElseIf ((10 / Timer1.Interval) * 100) > 12 Then
                Label1.Text = "Boring!"
                Label1.ForeColor = Color.Black
                PictureBox6.Image = My.Resources.boring
            ElseIf ((10 / Timer1.Interval) * 100) > 9.5 Then
                Label1.Text = "Better grab my bike!"
                Label1.ForeColor = Color.Green
                PictureBox6.Image = My.Resources.bike
            ElseIf ((10 / Timer1.Interval) * 100) > 8 Then
                Label1.Text = "My grandma walks faster!"
                Label1.ForeColor = Color.RoyalBlue
                PictureBox6.Image = My.Resources.grandma
            End If
        End If

        If e.KeyCode = Keys.Up And Timer1.Interval - 20 > 0 Then

            Timer1.Interval -= 20
            score_counter += 0.01
            'Label2.Text = Convert.ToString((10 / Timer1.Interval) * 100)
            If ((10 / Timer1.Interval) * 100) > 50 Then
                Label1.Text = "Rocket mode activated!"
                Label1.ForeColor = Color.Red
                PictureBox6.Image = My.Resources.rocket
            ElseIf ((10 / Timer1.Interval) * 100) > 46 Then
                Label1.Text = "I like to live dangerous!"
                Label1.ForeColor = Color.Orange
                PictureBox6.Image = My.Resources.danger
            ElseIf ((10 / Timer1.Interval) * 100) > 24 Then
                Label1.Text = "Watch the speedometer!"
                Label1.ForeColor = Color.Gold
                PictureBox6.Image = My.Resources.speed
            ElseIf ((10 / Timer1.Interval) * 100) > 16 Then
                Label1.Text = "That's all you got?"
                Label1.ForeColor = Color.Gray
                PictureBox6.Image = My.Resources.better
            ElseIf ((10 / Timer1.Interval) * 100) > 12 Then
                Label1.Text = "Boring!"
                Label1.ForeColor = Color.Black
                PictureBox6.Image = My.Resources.boring
            ElseIf ((10 / Timer1.Interval) * 100) > 9.5 Then
                Label1.Text = "Better grab my bike!"
                Label1.ForeColor = Color.Green
                PictureBox6.Image = My.Resources.bike
            ElseIf ((10 / Timer1.Interval) * 100) > 8 Then
                Label1.Text = "My grandma walks faster!"
                Label1.ForeColor = Color.RoyalBlue
                PictureBox6.Image = My.Resources.grandma
            End If
        End If


        If e.KeyCode = Keys.Space And Not PictureBox1.Tag = "crashed" Then
            Timer1.Enabled = Not Timer1.Enabled
        End If

        If e.KeyCode = Keys.R Then
            Reset_game()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        score += score_counter
        Label4.Text = Convert.ToString(Convert.ToInt32(score))


        If y1 = 10 Then
            Randomize()
            x1 = CInt(Int((3 * Rnd()) + 1))
        End If

        If x1 = 1 Then
            PictureBox2.Location = New Point(73, y1)
            PictureBox3.Location = New Point(136, y1)
        ElseIf x1 = 2 Then
            PictureBox2.Location = New Point(10, y1)
            PictureBox3.Location = New Point(136, y1)
        ElseIf x1 = 3 Then
            PictureBox2.Location = New Point(10, y1)
            PictureBox3.Location = New Point(73, y1)
        End If

        If y2 = 10 Then
            Randomize()
            x2 = CInt(Int((3 * Rnd()) + 1))
        End If
        If x2 = 1 Then
            PictureBox4.Location = New Point(73, y2)
            PictureBox5.Location = New Point(136, y2)
        ElseIf x2 = 2 Then
            PictureBox4.Location = New Point(10, y2)
            PictureBox5.Location = New Point(136, y2)
        ElseIf x2 = 3 Then
            PictureBox4.Location = New Point(10, y2)
            PictureBox5.Location = New Point(73, y2)
        End If

        y1 += 11.5
        If y1 > 476 Then
            y1 = 10
        End If

        y2 += 11.5
        If y2 > 476 Then
            y2 = 10
        End If


        For i As Integer = 0 To Me.Controls.Count - 1 Step 1
            If (Me.Controls(i).GetType.ToString().Equals("System.Windows.Forms.PictureBox")) And Not Me.Controls(i).Name = "PictureBox1" Then
                If PictureBox1.Bounds.IntersectsWith(Me.Controls(i).Bounds) Then
                    PictureBox1.Image = My.Resources.explode
                    PictureBox1.Tag = "crashed"
                    Timer1.Stop()
                    If max_score < score Then
                        Label5.Text = Convert.ToString(Convert.ToInt32(score))
                        max_score = score

                        Timer2.Enabled = True
                    Else
                        Score_form.Show()

                    End If
                End If
            End If
        Next




    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        wait += 1
        If wait > 10 Then
            Highscore.Show()
            wait = 0
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub



    Public Sub Reset_game()
        Timer1.Interval = 41
        Timer1.Enabled = False
        Label1.Text = "Watch the speedometer!"
        Label1.ForeColor = Color.Gold
        PictureBox1.Image = My.Resources.myplane
        PictureBox1.Tag = ""
        PictureBox1.Location = New Point(73, 403)
        PictureBox6.Image = My.Resources.speed
        my_row = 2
        score_counter = 0.05
        score = 0

        y1 = 10
        y2 = 243
        x1 = 1
        x2 = 2

        PictureBox2.Location = New Point(73, y1)
        PictureBox3.Location = New Point(136, y1)

        PictureBox4.Location = New Point(10, y2)
        PictureBox5.Location = New Point(136, y2)

        Label4.Text = "0"
    End Sub

   
End Class

