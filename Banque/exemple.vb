Imports System.ComponentModel

Public Class Exemple
    Private Sub exemple_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub exemple_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        Label_X.Left = e.Location.X + 15
        Label_X.Top = e.Location.Y + 0

        Label_Y.Left = e.Location.X + 15
        Label_Y.Top = e.Location.Y + 15


        If e.Location.X < Me.ClientSize.Width And e.Location.X > 0 And
                e.Location.Y < Me.ClientSize.Height And e.Location.Y > 0 Then
            Label_X.Text = "X : " & e.Location.X
            Label_Y.Text = "Y : " & e.Location.Y
        Else
            Label_X.Text = ""
            Label_Y.Text = ""
        End If


    End Sub




    Private Sub index_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Short
        Cancel = Not CheckBox_Sortie.Checked
        e.Cancel = Cancel
    End Sub
End Class