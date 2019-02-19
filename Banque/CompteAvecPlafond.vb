Public Class CompteAvecPlafond
    Inherits Compte

    Private _plafond As Double

    Public Property lePlafond As Double
        Get
            Return _plafond
        End Get
        Set(value As Double)
            _plafond = value
        End Set
    End Property


    Public Overrides Function verserArgent(sommeVersee As Double) As Boolean
        If leSolde + sommeVersee > lePlafond Then
            libelleErreur = "Dépassement du plafond."
            Return False
        Else
            leSolde = leSolde + sommeVersee
            Return True
        End If
    End Function

End Class
