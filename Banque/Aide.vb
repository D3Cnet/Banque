Public Class Form_aide
    Private Sub Button_ok_Click(sender As Object, e As EventArgs) Handles Button_ok.Click
        Close()
    End Sub

    Private Sub Button_ok_MouseMove(sender As Object, e As MouseEventArgs) Handles Button_ok.MouseMove
        Dim monPoint As Point
        Randomize()
        monPoint = New Point

        monPoint.Y = CInt(Int(((Me.Size.Height - Button_ok.Size.Height) * Rnd())))
        monPoint.X = CInt(Int(((Me.Size.Width - Button_ok.Size.Width) * Rnd())))

        Button_ok.Location = monPoint

        ToolStripStatusLabel_x.Text = "x : " & monPoint.X
        ToolStripStatusLabel_y.Text = "y : " & monPoint.Y


    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub MiseÀ0DuGroupeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiseÀ0DuGroupeToolStripMenuItem.Click

        ContextMenuStrip1.SourceControl.Controls(4).Select()
        'If ContextMenuStrip1.SourceControl.Name = "GroupBox1" Then

        '    MsgBox(ContextMenuStrip1.SourceControl.Name)
        'Else
        '    If ContextMenuStrip1.SourceControl.Name = "GroupBox2" Then
        '        MsgBox(ContextMenuStrip1.SourceControl.Name)
        '    End If
        'End If
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel_x.Click

    End Sub

    Private Sub Form_aide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_aide_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        ToolStripStatusLabel_x.Text = "x : " & e.Location.X
        ToolStripStatusLabel_y.Text = "y : " & e.Location.Y

        Label_X.Text = Size.Width
        Label_Y.Text = Size.Height
    End Sub
End Class