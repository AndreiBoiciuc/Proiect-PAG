Public Class Form1

    
    

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Credits.Show()
        Credits.Focus()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Controls_info.Show()
        Controls_info.Focus()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Game.Show()
        Game.Focus()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Size = New System.Drawing.Size(120, 120)
        PictureBox1.Location = New Point(90, 5)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size = New System.Drawing.Size(100, 100)
        PictureBox1.Location = New Point(100, 15)
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Size = New System.Drawing.Size(120, 120)
        PictureBox2.Location = New Point(20, 122)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Size = New System.Drawing.Size(100, 100)
        PictureBox2.Location = New Point(30, 132)
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Size = New System.Drawing.Size(120, 120)
        PictureBox3.Location = New Point(90, 240)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Size = New System.Drawing.Size(100, 100)
        PictureBox3.Location = New Point(100, 250)
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Size = New System.Drawing.Size(120, 120)
        PictureBox4.Location = New Point(166, 122)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Size = New System.Drawing.Size(100, 100)
        PictureBox4.Location = New Point(176, 132)
    End Sub


    
End Class
