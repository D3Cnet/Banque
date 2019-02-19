
Public Class ImportComptes

    Public Sub New(moduleGestionComptes As GestionDesComptes)
        Dim monCompte As Compte = Nothing

        monCompte = New Compte
        monCompte.leNom = "CAMENEN"
        monCompte.lePrenom = "Daniel"
        monCompte.laDateNaissance = "01/01/1901"
        monCompte.laDateCreation = "22/05/1999"
        monCompte.leSolde = 1000
        monCompte.leTypeCompte = COMPTECOURANT
        moduleGestionComptes.ajouterUnCompte(monCompte)

        monCompte = New Compte
        monCompte.leNom = "BAH"
        monCompte.lePrenom = "Ibrahim"
        monCompte.laDateNaissance = "01/01/1901"
        monCompte.laDateCreation = "22/05/1999"
        monCompte.leSolde = 1523
        monCompte.leTypeCompte = COMPTECOURANT
        moduleGestionComptes.ajouterUnCompte(monCompte)

        monCompte = New Compte
        monCompte.leNom = "BONNETAIN"
        monCompte.lePrenom = "Maxime"
        monCompte.laDateNaissance = "01/01/1901"
        monCompte.laDateCreation = "22/05/1999"
        monCompte.leSolde = 12000
        monCompte.leTypeCompte = COMPTECOURANT
        moduleGestionComptes.ajouterUnCompte(monCompte)

        monCompte = New CompteAvecPlafond
        monCompte.leNom = "GORSE"
        monCompte.lePrenom = "Thierry"
        monCompte.laDateNaissance = "01/01/1901"
        monCompte.laDateCreation = "22/05/1999"
        monCompte.leSolde = 2798.25
        monCompte.leTypeCompte = PEL
        CType(monCompte, CompteAvecPlafond).lePlafond = 1200
        moduleGestionComptes.ajouterUnCompte(monCompte)

        monCompte = New CompteAvecPlafond
        monCompte.leNom = "BOUDOT"
        monCompte.lePrenom = "Serge"
        monCompte.laDateNaissance = "01/01/1901"
        monCompte.laDateCreation = "22/05/1999"
        monCompte.leSolde = 125000
        monCompte.leTypeCompte = JEUNE
        CType(monCompte, CompteAvecPlafond).lePlafond = 1200
        moduleGestionComptes.ajouterUnCompte(monCompte)

        monCompte = New CompteAvecPlafond
        monCompte.leNom = "CELLIER"
        monCompte.lePrenom = "Florent"
        monCompte.laDateNaissance = "01/01/1901"
        monCompte.laDateCreation = "22/05/1999"
        monCompte.leSolde = 12.5
        monCompte.leTypeCompte = JEUNE
        CType(monCompte, CompteAvecPlafond).lePlafond = 1200
        moduleGestionComptes.ajouterUnCompte(monCompte)

        monCompte = New Compte
        monCompte.leNom = "LEMAISTRE"
        monCompte.lePrenom = "François"
        monCompte.laDateNaissance = "01/01/1901"
        monCompte.laDateCreation = "22/05/1999"
        monCompte.leSolde = 652.3
        monCompte.leTypeCompte = COMPTECOURANT
        moduleGestionComptes.ajouterUnCompte(monCompte)

        monCompte = New Compte
        monCompte.leNom = "DAUVERGNE"
        monCompte.lePrenom = "Maxime"
        monCompte.laDateNaissance = "01/01/1901"
        monCompte.laDateCreation = "22/05/1999"
        monCompte.leSolde = 2961
        monCompte.leTypeCompte = COMPTECOURANT
        moduleGestionComptes.ajouterUnCompte(monCompte)

        monCompte = New Compte
        monCompte.leNom = "DE ROQUEMAUREL"
        monCompte.lePrenom = "Ambroise"
        monCompte.laDateNaissance = "01/01/1901"
        monCompte.laDateCreation = "22/05/1999"
        monCompte.leSolde = -527.62
        monCompte.leTypeCompte = COMPTECOURANT
        moduleGestionComptes.ajouterUnCompte(monCompte)

        monCompte = New CompteAvecPlafond
        monCompte.leNom = "POUPARD"
        monCompte.lePrenom = "Benjamin"
        monCompte.laDateNaissance = "01/01/1901"
        monCompte.laDateCreation = "22/05/1999"
        monCompte.leSolde = 99.8
        monCompte.leTypeCompte = JEUNE
        CType(monCompte, CompteAvecPlafond).lePlafond = 1200
        moduleGestionComptes.ajouterUnCompte(monCompte)


    End Sub


End Class
