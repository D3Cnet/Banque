Imports System.IO
Imports System.Data.SQLite

Public Class SqlDb
    Private Shared _instance As SqlDb = Nothing
    Private Shared _db As String = ""
    Private _connect As String = ""

    Private Sub New()
        Init()
        If Not File.Exists(_db) Then
            ' Création du fichier
            If Not DbCreation() Then
                ' TODO : générer notre propre exception et la gérer.
                Throw New FileNotFoundException($"Fichier de données SQLite {_db} non trouvé")
            End If
        End If
    End Sub

    Private Sub Init()
        ' Initialisations
        _db = CHEMINDB
        _connect = $"DataSource={_db};Version=3;New=False;Compress=True;"
    End Sub

    Public Shared Function Instance() As SqlDb
        If CHEMINDB <> _db Or IsNothing(_instance) Then
            _instance = New SqlDb
        End If
        Return _instance
    End Function

    Private Function DbCreation() As Boolean
        Dim connexion As SQLiteConnection = New SQLiteConnection
        Try
            SQLiteConnection.CreateFile(_db)
        Catch e As SQLiteException
            ' TODO : gérer le fait que la base de données ne pourra pas être utilisée.
            MsgBox(e.ToString)
            Return False
        End Try

        Using Query As New SQLiteCommand()
            connexion.ConnectionString = _connect
            connexion.Open()
            With Query
                .Connection = connexion
                .CommandText = "CREATE TABLE Compte (id	Integer Not NULL UNIQUE, nom TEXT Not NULL, prenom	TEXT Not NULL, dateNaissance TEXT Not NULL, codeCompte TEXT Not NULL UNIQUE, dateCreation TEXT Not NULL, typeCompte TEXT Not NULL, solde REAL Not NULL, plafond REAL, PRIMARY KEY(`codeCompte`));"
            End With
            Query.ExecuteNonQuery()
            connexion.Close()
        End Using

        Return True
    End Function

    Public Function LitSQL(requete As String, table As String) As DataSet
        Dim donnees As DataSet = New DataSet
        Dim connexion As New SQLiteConnection(_connect)
        Dim Commande As New SQLiteCommand(requete, connexion)
        Dim Adaptateur As New SQLiteDataAdapter(Commande)
        Adaptateur.Fill(donnees, table)
        Return donnees
    End Function

    Public Sub InsereSQL(insertions As List(Of String))
        Using cn As New SQLiteConnection(_connect), cmd As New SQLiteCommand()
            cn.Open()
            For Each insertion As String In insertions
                cmd.CommandText = insertion
                cmd.Connection = cn
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox($"Erreur d'insertion pour \{insertion}\ : {ex.Message}")
                End Try
            Next
            cn.Close()
        End Using
    End Sub

    Public Sub InsereSQL(insertion As String)
        Dim liste As List(Of String) = New List(Of String)
        liste.Add(insertion)
        InsereSQL(liste)
    End Sub

End Class


