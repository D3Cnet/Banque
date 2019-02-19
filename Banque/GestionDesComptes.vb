Public Class GestionDesComptes
    Private _ListeComptes As List(Of Object)

    Public Sub New()
        _ListeComptes = New List(Of Object)
    End Sub

    Public Function rechercherCompte(numCompte As String) As Object
        Dim leCompte As Compte
        For Each leCompte In _ListeComptes
            If leCompte.leNumeroCompte = numCompte Then
                Return leCompte
            End If
        Next

        Return Nothing
    End Function

    Public Sub ajouterUnCompte(leCompte As Object, Optional numCompte As String = "")
        Dim monCompte As Compte
        monCompte = CType(leCompte, Compte)

        If numCompte = "" Then
            monCompte.leNumeroCompte = monCompte.leTypeCompte & CInt(_ListeComptes.Count + 1)
        Else
            monCompte.leNumeroCompte = numCompte
        End If
        _ListeComptes.Add(leCompte)
    End Sub

    Public Function supprimerUnCompte(numCompte As String) As Boolean
        Dim leCompte As Compte
        For Each leCompte In _ListeComptes
            If leCompte.leNumeroCompte = numCompte Then
                _ListeComptes.Remove(leCompte)
                Return True
            End If
        Next
        Return False
    End Function

    Public Function modifierUnCompte(numCompte As String, compteModifie As Object) As Boolean
        If supprimerUnCompte(numCompte) Then
            ajouterUnCompte(compteModifie, numCompte)
            Return True
        End If
        Return False
    End Function


    Public Sub listeComptes(maCollection As ListBox.ObjectCollection)
        Dim leCompte As Compte

        For Each leCompte In _ListeComptes
            maCollection.Add(leCompte.leNumeroCompte)
        Next
    End Sub

End Class
