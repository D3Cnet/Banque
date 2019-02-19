Public Class Compte

    Private _nom As String
    Private _prenom As String
    Private _dateNaissance As String
    Private _dateCreation As String
    Private _numeroCompte As String
    Private _typeCompte As String
    Private _solde As Double

    Public libelleErreur As String

    Public Property laDateNaissance As String
        Get
            Return _dateNaissance
        End Get
        Set(value As String)
            _dateNaissance = value
        End Set
    End Property

    Public Property laDateCreation As String
        Get
            Return _dateCreation
        End Get
        Set(value As String)
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
            Return _typeCompte
        End Get
        Set(value As String)
            _typeCompte = value
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
