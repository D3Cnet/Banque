Imports System.Data.SQLite
Imports System.IO
Public Class GestionExempleDB
    Public Database As String = CHEMINDB
    Dim CON As New SQLiteConnection
        '
        Public Sub OpenDataBase()
            Try
                CON.ConnectionString = "Data Source=" & Database
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
            Dim strSQL As String = "INSERT INTO Compte VALUES (@id,@nom,@prenom,@dateNaissance,@codeCompte,@dateCreation,@typeCompte,@solde,@plafond)"
            Dim cmd = New SQLiteCommand(strSQL, CON)

            cmd.Parameters.AddWithValue("@id", lireNouvelIndiceDB())
            cmd.Parameters.AddWithValue("@Nom", CType(monCompte, Compte).leNom)
            cmd.Parameters.AddWithValue("@prenom", CType(monCompte, Compte).lePrenom)
            cmd.Parameters.AddWithValue("@dateNaissance", CType(monCompte, Compte).laDateNaissance)
            cmd.Parameters.AddWithValue("@codeCompte", CType(monCompte, Compte).leNumeroCompte)
            cmd.Parameters.AddWithValue("@dateCreation", CType(monCompte, Compte).laDateCreation)
            cmd.Parameters.AddWithValue("@typeCompte", CType(monCompte, Compte).leTypeCompte)
            cmd.Parameters.AddWithValue("@solde", CType(monCompte, Compte).leSolde)

            If CType(monCompte, Compte).leTypeCompte = COMPTECOURANT Then
                cmd.Parameters.AddWithValue("@plafond", "")
            Else
                cmd.Parameters.AddWithValue("@plafond", CType(monCompte, CompteAvecPlafond).lePlafond)
            End If

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub majCompteDB(monCompte As Object)
        Try
            Dim strSQL As String = "UPDATE compte SET nom=@nom,prenom=@prenom,dateNaissance=@dateNaissance,codeCompte=@codeCompte,dateCreation=@dateCreation,typeCompte=@typeCompte,solde=@solde,plafond@plafond WHERE codeCompte=@codeCompte"
            Dim cmd = New SQLiteCommand(strSQL, CON)

            cmd.Parameters.AddWithValue("@id", lireNouvelIndiceDB())
            cmd.Parameters.AddWithValue("@Nom", CType(monCompte, Compte).leNom)
            cmd.Parameters.AddWithValue("@prenom", CType(monCompte, Compte).lePrenom)
            cmd.Parameters.AddWithValue("@dateNaissance", CType(monCompte, Compte).laDateNaissance)
            cmd.Parameters.AddWithValue("@codeCompte", CType(monCompte, Compte).leNumeroCompte)
            cmd.Parameters.AddWithValue("@dateCreation", CType(monCompte, Compte).laDateCreation)
            cmd.Parameters.AddWithValue("@typeCompte", CType(monCompte, Compte).leTypeCompte)
            cmd.Parameters.AddWithValue("@solde", CType(monCompte, Compte).leSolde)

            If CType(monCompte, Compte).leTypeCompte = COMPTECOURANT Then
                cmd.Parameters.AddWithValue("@plafond", "")
            Else
                cmd.Parameters.AddWithValue("@plafond", CType(monCompte, CompteAvecPlafond).lePlafond)
            End If

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function lireCompteDB(codeCompte As String) As Object
        Dim strSQL As String = "SELECT * FROM Compte WHERE codeCompte= """ & codeCompte & """"
        Dim leCompte As Object = Nothing
        Dim cmd = New SQLiteCommand(strSQL, CON)
        Dim DR As SQLiteDataReader = cmd.ExecuteReader

        If DR.Read() Then
            If DR("codeCompte") = COMPTECOURANT Then
                leCompte = New Compte
            Else
                leCompte = New CompteAvecPlafond
                CType(leCompte, CompteAvecPlafond).lePlafond = DR("plafond")
            End If
            CType(leCompte, Compte).leNom = DR("nom")
            CType(leCompte, Compte).lePrenom = DR("prenom")
            CType(leCompte, Compte).laDateNaissance = DR("dateNaissance")
            CType(leCompte, Compte).leNumeroCompte = DR("codeCompte")
            CType(leCompte, Compte).laDateCreation = DR("dateCreation")
            CType(leCompte, Compte).leTypeCompte = DR("typeCompte")
            CType(leCompte, Compte).leSolde = DR("solde")
        End If

        DR.Close()
        cmd.Dispose()

        Return leCompte
    End Function


    Public Sub supprimerCompteDB(leCodeCompte As String)
        Dim strSQL As String = "DELETE FROM Compte WHERE codeCompte=""" & leCodeCompte & """"
        Dim cmd = New SQLiteCommand(strSQL, CON)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub



    Public Sub DBremplirListe(ByRef LST As ListBox) 'remarquez le ByRef
        Dim cmd = New SQLiteCommand("SELECT codeCompte FROM Compte", CON)
        Dim DR As SQLiteDataReader = cmd.ExecuteReader
            LST.Items.Clear()
            While (DR.Read())
            LST.Items.Add(DR("codeCompte"))
        End While
            DR.Close()
        End Sub



    Public Function lireNouvelIndiceDB() As Integer
        Dim NewID As Integer = 1
        Dim cmd = New SQLiteCommand("SELECT MAX(ID) FROM Compte", CON)
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
