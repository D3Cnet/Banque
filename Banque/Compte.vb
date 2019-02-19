Public Class Compte

    Private _nom As String
    Private _prenom As String
    Private _dateCreation As Date
    Private _numeroCompte As String
    Private _typeCompte As String
    Private _solde As Double

    Public libelleErreur As String

    Public Property laDateCreation As Date
        Get
            Return _dateCreation
        End Get
        Set(value As Date)
            _dateCreation = value
        End Set
    End Property

    Public Property leNom As String
        Get
            Return _nom
        End Get
        Set(value As String)
            _nom = value
        End Set
    End Property

    Public Property leNumeroCompte As String
        Get
            Return _numeroCompte
        End Get
        Set(value As String)
            _numeroCompte = value
        End Set
    End Property

    Public Property lePrenom As String
        Get
            Return _prenom
        End Get
        Set(value As String)
            _prenom = value
        End Set
    End Property

    Public Property leSolde As Double
        Get
            Return _solde
        End Get
        Set(value As Double)
            _solde = value
        End Set
    End Property

    Public Property leTypeCompte As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Function consulterSolde() As Double
        Return _solde
    End Function

    Public Overridable Function verserArgent(sommeVersee As Double) As Boolean
        _solde = _solde + sommeVersee
        Return True
    End Function




End Class
