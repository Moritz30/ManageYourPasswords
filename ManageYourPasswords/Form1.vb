Public Class Form1

    Dim loc As Point

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown

        If e.Button = MouseButtons.Left Then

            loc = e.Location

        End If

    End Sub

    Private Sub MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, Label1.MouseMove

        If e.Button = MouseButtons.Left Then

            Me.Location += e.Location - loc

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        WindowState = FormWindowState.Minimized

    End Sub

End Class
