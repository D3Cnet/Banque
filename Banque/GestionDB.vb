Imports System.Data.SQLite
Imports System.IO
Public Class GestionDB
    ' Gestion de la base de données
    ' Code trouvé sur le site https://codes-sources.commentcamarche.net/source/54387-tutorial-utilisation-sqlite-avec-visual-basic-net-2010-express

    Private _Database As String
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
            Dim strSQL As String = "INSERT INTO COMPTE VALUES (@Nom,@prenom,@dateNaissance,@codeCompte,@dateCreation,@typeCompte,@solde,@plafond)"
            Dim cmd = New SQLiteCommand(strSQL, CON)
            cmd.Parameters.AddWithValue("@Nom", CType(monCompte, Compte).leNom)
            cmd.Parameters.AddWithValue("@prenom", CType(monCompte, Compte).lePrenom)
            cmd.Parameters.AddWithValue("@dateNaissance", CType(monCompte, Compte).laDateNaissance)
            cmd.Parameters.AddWithValue("@codeCompte", CType(monCompte, Compte).leNumeroCompte)
            cmd.Parameters.AddWithValue("@dateCreation", CType(monCompte, Compte).laDateCreation))
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

    Public Sub DBupdateINDIVIDU(ByVal INDIVIDU As m_INDIVIDU)
        Try
            Dim strSQL As String = "UPDATE INDIVIDU SET Nom=@Nom,Age=@Age,Membre=@Membre,Photo=@Photo WHERE ID=@ID"
            Dim cmd = New SQLiteCommand(strSQL, CON)
            cmd.Parameters.AddWithValue("@ID", INDIVIDU.ID)
            cmd.Parameters.AddWithValue("@Nom", INDIVIDU.Nom)
            cmd.Parameters.AddWithValue("@Age", INDIVIDU.Age)
            cmd.Parameters.AddWithValue("@Membre", INDIVIDU.Membre)
            cmd.Parameters.AddWithValue("@Photo", ImageToByteArray(INDIVIDU.Photo))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DBgetINDIVIDU(ByVal Idx As Integer) As m_INDIVIDU
        Dim strSQL As String = "SELECT * FROM INDIVIDU WHERE ID= " & Idx
        Dim INDIVIDU As New m_INDIVIDU
        Dim cmd = New SQLiteCommand(strSQL, CON)
        Dim DR As SQLiteDataReader = cmd.ExecuteReader
        '
        While (DR.Read())
            INDIVIDU.ID = DR(0)
            INDIVIDU.Nom = DR(1)
            INDIVIDU.Age = DR(2)
            INDIVIDU.Membre = DR(3)
            INDIVIDU.Photo = ByteArrayToImage(DR(4))
        End While
        DR.Close()
        cmd.Dispose()
        Return INDIVIDU
    End Function

    Public Sub DBdeleteINDIVIDU(ByVal Idx As Integer)
        Dim strSQL As String = "DELETE FROM INDIVIDU WHERE ID= " & Idx
        Dim cmd = New SQLiteCommand(strSQL, CON)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function DBNewIndexINDIVIDU() As Integer
        Dim NewID As Integer = 1
        Dim cmd = New SQLiteCommand("SELECT MAX(ID) FROM INDIVIDU", CON)
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

    Public Sub DBremplirListe(ByRef LST As ListBox) 'remarquez le ByRef
        Dim cmd = New SQLiteCommand("SELECT ID,Nom FROM INDIVIDU", CON)
        Dim DR As SQLiteDataReader = cmd.ExecuteReader
        LST.Items.Clear()
        While (DR.Read())
            'DR(1) est le nom DR(0) est ID
            LST.Items.Add(DR(1) & "    |" & DR(0))
        End While
        DR.Close()
    End Sub

End Class
