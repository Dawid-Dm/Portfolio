Public Class Form1
    Public moveStep As Integer

    Private Sub Form1_DpiChangedAfterParent(sender As Object, e As EventArgs) Handles MyBase.DpiChangedAfterParent

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Image Clicked")

    End Sub

    Private Sub PictureBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles PictureBox1.PreviewKeyDown

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim moveStep As Integer = 10 'this is movement speed value

        Select Case e.KeyCode
            Case Keys.Left 'checks if user uses left arrow key
                PictureBox1.Left -= moveStep
                If PictureBox1.Left < 0 Then PictureBox1.Left = 1

            Case Keys.Right 'checks if user uses right arrow key
                PictureBox1.Left += moveStep
                If PictureBox1.Right > 585 Then PictureBox1.Left = 435

            Case Keys.Up 'checks if user uses up arrow key
                PictureBox1.Top -= moveStep
                If PictureBox1.Top < 0 Then PictureBox1.Top = 1

            Case Keys.Down 'checks if user uses down arrow key
                PictureBox1.Top += moveStep
                If PictureBox1.Top > 410 Then PictureBox1.Top = 410

        End Select


        Select Case e.KeyCode
        Case Keys.A
                PictureBox2.Left -= moveStep 'checks if user uses A key
                If PictureBox2.Left < 0 Then PictureBox2.Left = 1

            Case Keys.D
                PictureBox2.Left += moveStep 'checks if user uses D key
                If PictureBox2.Right > 585 Then PictureBox2.Left = 435

            Case Keys.W
                PictureBox2.Top -= moveStep 'checks if user uses W key
                If PictureBox2.Top < 0 Then PictureBox2.Top = 1

            Case Keys.S
                PictureBox2.Top += moveStep 'checks if user uses S key
                If PictureBox2.Top > 410 Then PictureBox2.Top = 410 'stops right before image starts going of screen

        End Select

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MessageBox.Show("Image Clicked")
    End Sub
End Class
