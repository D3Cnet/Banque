Option Explicit On
Option Strict On

Public Class form_principale

    Public gestionComptes As GestionDesComptesDB
    '    Public gestionComptesMEM As GestionDesComptes = New GestionDesComptes

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        gestionComptes = New GestionDesComptesDB
        rafraichirListeComptes()
    End Sub


    Private Sub Button_add_Click(sender As Object, e As EventArgs) Handles Button_add.Click
        Dim nouveauCompte As Object

        If ComboBox_type.Text = COMPTECOURANT Then
            nouveauCompte = New Compte
        Else
            nouveauCompte = New CompteAvecPlafond
            CType(nouveauCompte, CompteAvecPlafond).lePlafond = CDbl(TextBox_plafond.Text)
        End If

        CType(nouveauCompte, Compte).leNom = TextBox_nom.Text
        CType(nouveauCompte, Compte).lePrenom = TextBox_prenom.Text
        CType(nouveauCompte, Compte).laDateNaissance = TextBox_dateNaissance.Text
        CType(nouveauCompte, Compte).laDateCreation = TextBox_dateCreation.Text
        CType(nouveauCompte, Compte).leSolde = CDbl(TextBox_solde.Text)
        CType(nouveauCompte, Compte).leTypeCompte = ComboBox_type.Text

        gestionComptes.ajouterUnCompte(nouveauCompte)

        rafraichirListeComptes()
    End Sub


    Private Sub Button_moins_Click(sender As Object, e As EventArgs) Handles Button_moins.Click
        If Not ListBox_nom.SelectedIndex = -1 Then
            If MsgBox("Voulez-vous réellement effacer l'enregistrement ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Suppression") = MsgBoxResult.Yes Then
                gestionComptes.supprimerUnCompte(CType(ListBox_nom.Items(ListBox_nom.SelectedIndex), String))
                ListBox_nom.Items.Remove(ListBox_nom.SelectedItem)
                rafraichirListeComptes()
            End If
        End If
    End Sub

    Private Sub ListBox_nom_Click(sender As Object, e As EventArgs) Handles ListBox_nom.Click
        Dim monCompte As Object = Nothing

        If ListBox_nom.SelectedIndex = -1 Then
            Exit Sub
        End If

        monCompte = gestionComptes.rechercherCompte(CType(ListBox_nom.Items(ListBox_nom.SelectedIndex), String))

        If Not IsNothing(monCompte) Then
            If CType(monCompte, Compte).leTypeCompte = COMPTECOURANT Then
                TextBox_plafond.Enabled = False
                TextBox_plafond.Text = ""
            Else
                TextBox_plafond.Enabled = True
                TextBox_plafond.Text = CStr(CType(monCompte, CompteAvecPlafond).lePlafond)
            End If

            TextBox_nom.Text = CType(monCompte, Compte).leNom
            TextBox_prenom.Text = CType(monCompte, Compte).lePrenom
            TextBox_dateNaissance.Text = CType(monCompte, Compte).laDateNaissance
            TextBox_dateCreation.Text = CType(monCompte, Compte).laDateCreation
            TextBox_solde.Text = CStr(CType(monCompte, Compte).leSolde)
            ComboBox_type.Text = CType(monCompte, Compte).leTypeCompte

            ToolStripStatusLabel_compte.Text = "Le compte ouvert est : " & CStr(CType(monCompte, Compte).leNumeroCompte)
        End If

    End Sub



    Private Sub Button_modif_Click(sender As Object, e As EventArgs) Handles Button_modif.Click
        Dim nouveauCompte As Object

        If Not ListBox_nom.SelectedIndex = -1 Then
            If ComboBox_type.Text = COMPTECOURANT Then
                nouveauCompte = New Compte
            Else
                nouveauCompte = New CompteAvecPlafond
                CType(nouveauCompte, CompteAvecPlafond).lePlafond = CDbl(TextBox_plafond.Text)
            End If

            CType(nouveauCompte, Compte).leNom = TextBox_nom.Text
            CType(nouveauCompte, Compte).lePrenom = TextBox_prenom.Text
            CType(nouveauCompte, Compte).laDateNaissance = TextBox_dateNaissance.Text
            CType(nouveauCompte, Compte).laDateCreation = TextBox_dateCreation.Text
            CType(nouveauCompte, Compte).leSolde = CDbl(TextBox_solde.Text)
            CType(nouveauCompte, Compte).leTypeCompte = ComboBox_type.Text

            gestionComptes.modifierUnCompte(CType(ListBox_nom.Items(ListBox_nom.SelectedIndex), String), nouveauCompte)
        End If

        rafraichirListeComptes()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Dim nomFichier As String = ""

        If OpenFileDialog_fichier.ShowDialog() = DialogResult.OK Then
            nomFichier = OpenFileDialog_fichier.FileName
            ListBox_nom.Items.Clear()
            ListBox_nom.Items.AddRange(System.IO.File.ReadAllLines(nomFichier))
        End If
    End Sub

    Private Sub ComboBox_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_type.SelectedIndexChanged
        If ComboBox_type.Text = COMPTECOURANT Then
            TextBox_plafond.Enabled = False
            TextBox_plafond.Text = ""
        Else
            TextBox_plafond.Enabled = True
        End If
    End Sub

    Private Sub rafraichirListeComptes()
        ListBox_nom.Items.Clear()
        gestionComptes.listeComptes(ListBox_nom.Items)
    End Sub


    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        'Dim maFormAide As form_aide
        'maFormAide = New form_aide()
        'maFormAide.ShowDialog()

        With New Form_aide
            .ShowDialog()
        End With
    End Sub

    Private Sub FichierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichierToolStripMenuItem.Click

    End Sub

    Private Sub Button_quitter_Click(sender As Object, e As EventArgs) Handles Button_quitter.Click, QuitterToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ExempleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExempleToolStripMenuItem.Click
        With New Exemple
            .ShowDialog()
        End With
    End Sub
End Class
