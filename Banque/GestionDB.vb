Imports System.Data.SQLite
Imports System.IO
Public Class GestionDB
    ' Gestion de la base de données
    ' Code trouvé sur le site https://codes-sources.commentcamarche.net/source/54387-tutorial-utilisation-sqlite-avec-visual-basic-net-2010-express

    Private _Database As String = CHEMINDB
    Dim CON As New SQLiteConnection
    '
    Public Sub OpenDataBase()
        Try
            CON.ConnectionString = "Data Source=" & _Database
            CON.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '
    Public Sub CloseDatabase()
        CON.Close()
    End Sub


    'Private _nom As String
    'Private _prenom As String
    'Private _dateNaissance As String
    'Private _dateCreation As String
    'Private _numeroCompte As String
    'Private _typeCompte As String
    'Private _solde As Double
    'Private _plafond As Double

    Public Sub ajouterCompteDB(monCompte As Object)
        Try
            Dim strSQL As String = "INSERT INTO COMPTE VALUES (@id,@Nom,@prenom,@dateNaissance,@codeCompte,@dateCreation,@typeCompte,@solde,@plafond)"
            Dim cmd = New SQLiteCommand(strSQL, CON)
            cmd.Parameters.AddWithValue("@id", nouvelIdentifiantUniqueDB())
            cmd.Parameters.AddWithValue("@Nom", CType(monCompte, Compte).leNom)
            cmd.Parameters.AddWithValue("@prenom", CType(monCompte, Compte).lePrenom)
            cmd.Parameters.AddWithValue("@dateNaissance", CType(monCompte, Compte).laDateNaissance)
            cmd.Parameters.AddWithValue("@codeCompte", CType(monCompte, Compte).leNumeroCompte)
            cmd.Parameters.AddWithValue("@dateCreation", CType(monCompte, Compte).laDateCreation)
            cmd.Parameters.AddWithValue("@typeCompte", CType(monCompte, Compte).leTypeCompte)
            cmd.Parameters.AddWithValue("@solde", CType(monCompte, Compte).leSolde)

            If CType(monCompte, Compte).leTypeCompte <> COMPTECOURANT Then
                cmd.Parameters.AddWithValue("@plafond", CType(monCompte, CompteAvecPlafond).lePlafond)
            Else
                cmd.Parameters.AddWithValue("@plafond", "")
            End If

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub majCompteDB(monCompte As Object)
        Try
            Dim strSQL As String = "UPDATE Compte SET nom=@Nom,prenom=@prenom,dateNaissance=@dateNaissance,dateCreation=@dateCreation,typeCompte=@typeCompte,solde=@solde,plafond=@plafond WHERE codeCompte=@codeCompte"

            Dim cmd = New SQLiteCommand(strSQL, CON)
            cmd.Parameters.AddWithValue("@Nom", CType(monCompte, Compte).leNom)
            cmd.Parameters.AddWithValue("@prenom", CType(monCompte, Compte).lePrenom)
            cmd.Parameters.AddWithValue("@dateNaissance", CType(monCompte, Compte).laDateNaissance)
            cmd.Parameters.AddWithValue("@codeCompte", CType(monCompte, Compte).leNumeroCompte)
            cmd.Parameters.AddWithValue("@dateCreation", CType(monCompte, Compte).laDateCreation)
            cmd.Parameters.AddWithValue("@typeCompte", CType(monCompte, Compte).leTypeCompte)
            cmd.Parameters.AddWithValue("@solde", CType(monCompte, Compte).leSolde)

            If CType(monCompte, Compte).leTypeCompte <> COMPTECOURANT Then
                cmd.Parameters.AddWithValue("@plafond", CType(monCompte, CompteAvecPlafond).lePlafond)
            Else
                cmd.Parameters.AddWithValue("@plafond", "")
            End If

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function chercherCompteDB(numCompte As String) As Object
        Dim strSQL As String = "SELECT * FROM compte WHERE codeCompte=""" & numCompte & """"
        Dim leCompte As New CompteAvecPlafond
        Dim cmd = New SQLiteCommand(strSQL, CON)
        Dim DR As SQLiteDataReader = cmd.ExecuteReader
        '
        While (DR.Read())
            leCompte.leNom = DR("nom")
            leCompte.lePrenom = DR("prenom")
            leCompte.laDateNaissance = DR("dateNaissance")
            leCompte.leNumeroCompte = DR("codeCompte")
            leCompte.laDateCreation = DR("dateCreation")
            leCompte.leTypeCompte = DR("typeCompte")
            leCompte.leSolde = DR("solde")
            leCompte.lePlafond = DR("plafond")
        End While
        DR.Close()
        cmd.Dispose()
        Return leCompte
    End Function

    Public Sub supprimerCompteDB(numCompte As String)
        Dim strSQL As String = "DELETE FROM compte WHERE codeCompte=""" & numCompte & """"
        Dim cmd = New SQLiteCommand(strSQL, CON)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub


    Public Sub listeComptesDB(ByRef maCollection As ListBox.ObjectCollection)
        Dim cmd = New SQLiteCommand("SELECT codeCompte FROM compte", CON)
        Dim DR As SQLiteDataReader = cmd.ExecuteReader
        maCollection.Clear()
        While (DR.Read())
            'DR(4) est le codeCompte
            maCollection.Add(DR("codeCompte"))
        End While
        DR.Close()
    End Sub

    Public Function nouvelIdentifiantUniqueDB() As Integer
        Dim NewID As Integer = 1
        Dim cmd = New SQLiteCommand("SELECT MAX(id) FROM Compte", CON)
        Try
            Dim DR As SQLiteDataReader = cmd.ExecuteReader
            While (DR.Read())
                NewID = DR(0)
            End While
            DR.Close()
            Return NewID + 1
        Catch ex As Exception
            Return NewID
        End Try
    End Function
End Class
