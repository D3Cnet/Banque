Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_add.Click
        ListBox_nom.Items.Add(TextBox_SaisieNom.Text)
        TextBox_SaisieNom.Text = ""
        TextBox_SaisieNom.Focus()

    End Sub

    Private Sub ListBox_nom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_nom.SelectedIndexChanged

    End Sub

    Private Sub Button_moins_Click(sender As Object, e As EventArgs) Handles Button_moins.Click
        If Not ListBox_nom.SelectedIndex = -1 Then
            ListBox_nom.Items.Remove(ListBox_nom.SelectedItem)
        End If
    End Sub

    Private Sub ListBox_nom_Click(sender As Object, e As EventArgs) Handles ListBox_nom.Click
        TextBox_SaisieNom.Text = ListBox_nom.Items(ListBox_nom.SelectedIndex)
        ' TextBox_SaisieNom.Text = ListBox_nom.SelectedItem
        TextBox1.Text = ListBox_nom.SelectedIndex

    End Sub

    Private Sub Button_modif_Click(sender As Object, e As EventArgs) Handles Button_modif.Click
        If Not ListBox_nom.SelectedIndex = -1 Then
            ListBox_nom.Items(ListBox_nom.SelectedIndex) = TextBox_SaisieNom.Text
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nomFichier As String = ""

        If OpenFileDialog_fichier.ShowDialog() = DialogResult.OK Then
            nomFichier = OpenFileDialog_fichier.FileName
            ListBox_nom.Items.Clear()
            ListBox_nom.Items.AddRange(System.IO.File.ReadAllLines(nomFichier))
        End If
    End Sub
End Class
