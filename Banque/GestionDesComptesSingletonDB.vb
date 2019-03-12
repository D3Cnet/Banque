Public Class GestionDesComptesSingletonDB

    Private _gestionDB As GestionDB

    Private _autoIncremental As Integer

    Private Function nouvelIdentifiantCompte(monCompte As Compte) As String
        Dim identifiant As String
        Dim maRequete As String = "Select max(id) from compte"

        Dim donnees As DataSet = SqlDb.Instance.LitSQL(maRequete, "Compte")

        _autoIncremental = donnees.Tables("Compte").Rows(0).Item(0)

        identifiant = String.Format("{0:0000}", _autoIncremental) & "-" & Left(monCompte.leNom, 1) & Left(monCompte.lePrenom, 1) & "-" & Replace(monCompte.leTypeCompte, " ", "")

        Return identifiant
    End Function

    Public Function rechercherCompte(numCompte As String) As Object

        Dim maRequete As String = "SELECT * FROM compte WHERE codeCompte=""" & numCompte & """"
        Dim donnees As DataSet = SqlDb.Instance.LitSQL(maRequete, "Compte")

        Dim leCompte As New CompteAvecPlafond

        leCompte.leNom = donnees.Tables("Compte").Rows(0).Item("nom")
        leCompte.leNom = donnees.Tables("Compte").Rows(0).Item("prenom")
        leCompte.leNom = donnees.Tables("Compte").Rows(0).Item("dateNaissance")
        leCompte.leNom = donnees.Tables("Compte").Rows(0).Item("codeCompte")
        leCompte.leNom = donnees.Tables("Compte").Rows(0).Item("dateCreation")
        leCompte.leNom = donnees.Tables("Compte").Rows(0).Item("typeCompte")
        leCompte.leNom = donnees.Tables("Compte").Rows(0).Item("solde")
        leCompte.leNom = donnees.Tables("Compte").Rows(0).Item("plafond")

        Return leCompte
    End Function

    Public Sub listeComptes(ByRef maCollection As ListBox.ObjectCollection)
        Dim maRequete As String = "Select codeCompte from Compte"
        Dim donnees As DataSet = SqlDb.Instance.LitSQL(maRequete, "Compte")

        For monCompteur As Integer = 0 To donnees.Tables("Compte").Rows.Count - 1
            maCollection.Add(donnees.Tables("Compte").Rows(monCompteur).Item("codeCompte"))
        Next

    End Sub


    Public Function ListeCompteComplete(maRequete As String, maTable As String) As DataSet
        Return _gestionDB.LitSQL(maRequete, maTable)
    End Function




    Public Sub ajouterUnCompte(leCompte As Object, Optional numCompte As String = "")
        Dim monCompte As Compte = CType(leCompte, Compte)

        If numCompte = "" Then
            monCompte.leNumeroCompte = nouvelIdentifiantCompte(monCompte)
            _gestionDB.ajouterCompteDB(monCompte)
        Else
            monCompte.leNumeroCompte = numCompte
            _gestionDB.majCompteDB(monCompte)
        End If
    End Sub

    Public Function supprimerUnCompte(numCompte As String) As Boolean
        _gestionDB.supprimerCompteDB(numCompte)
        Return True
    End Function

    Public Function modifierUnCompte(numCompte As String, compteModifie As Object) As Boolean
        CType(compteModifie, Compte).leNumeroCompte = numCompte
        _gestionDB.majCompteDB(compteModifie)
        Return True
    End Function


End Class

