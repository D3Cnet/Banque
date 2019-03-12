Public Class GestionDesComptesDB
    Private _gestionDB As GestionDB

    Private _autoIncremental As Integer

    Public Sub New()
        _gestionDB = New GestionDB
        _gestionDB.OpenDataBase()
    End Sub

    Private Function nouvelIdentifiantCompte(monCompte As Compte) As String
        Dim identifiant As String
        _autoIncremental = _gestionDB.nouvelIdentifiantUniqueDB()

        identifiant = String.Format("{0:0000}", _autoIncremental) & "-" & Left(monCompte.leNom, 1) & Left(monCompte.lePrenom, 1) & "-" & Replace(monCompte.leTypeCompte, " ", "")

        Return identifiant
    End Function

    Public Function rechercherCompte(numCompte As String) As Object
        Return _gestionDB.chercherCompteDB(numCompte)
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


    Public Sub listeComptes(ByRef maCollection As ListBox.ObjectCollection)
        _gestionDB.listeComptesDB(maCollection)
    End Sub

    Public Function ListeCompteComplete(maRequete As String, maTable As String) As DataSet
        Return _gestionDB.LitSQL(maRequete, maTable)
    End Function

End Class
