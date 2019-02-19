<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox_SaisieNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_add = New System.Windows.Forms.Button()
        Me.ListBox_nom = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button_moins = New System.Windows.Forms.Button()
        Me.Button_modif = New System.Windows.Forms.Button()
        Me.OpenFileDialog_fichier = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_prenom = New System.Windows.Forms.TextBox()
        Me.TextBox_dateNaissance = New System.Windows.Forms.TextBox()
        Me.TextBox_nom = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_type = New System.Windows.Forms.ComboBox()
        Me.TextBox_dateCreation = New System.Windows.Forms.TextBox()
        Me.TextBox_solde = New System.Windows.Forms.TextBox()
        Me.TextBox_plafond = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(539, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox_SaisieNom
        '
        Me.TextBox_SaisieNom.Location = New System.Drawing.Point(64, 73)
        Me.TextBox_SaisieNom.Name = "TextBox_SaisieNom"
        Me.TextBox_SaisieNom.Size = New System.Drawing.Size(120, 20)
        Me.TextBox_SaisieNom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom :"
        '
        'Button_add
        '
        Me.Button_add.Location = New System.Drawing.Point(190, 99)
        Me.Button_add.Name = "Button_add"
        Me.Button_add.Size = New System.Drawing.Size(25, 23)
        Me.Button_add.TabIndex = 3
        Me.Button_add.Text = "+"
        Me.Button_add.UseVisualStyleBackColor = True
        '
        'ListBox_nom
        '
        Me.ListBox_nom.FormattingEnabled = True
        Me.ListBox_nom.Items.AddRange(New Object() {"vsdsdsdvsdv", "sdvxctyev", "sdfsfee"})
        Me.ListBox_nom.Location = New System.Drawing.Point(64, 99)
        Me.ListBox_nom.Name = "ListBox_nom"
        Me.ListBox_nom.Size = New System.Drawing.Size(120, 199)
        Me.ListBox_nom.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(190, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Button_moins
        '
        Me.Button_moins.Location = New System.Drawing.Point(190, 128)
        Me.Button_moins.Name = "Button_moins"
        Me.Button_moins.Size = New System.Drawing.Size(25, 23)
        Me.Button_moins.TabIndex = 6
        Me.Button_moins.Text = "-"
        Me.Button_moins.UseVisualStyleBackColor = True
        '
        'Button_modif
        '
        Me.Button_modif.Location = New System.Drawing.Point(190, 157)
        Me.Button_modif.Name = "Button_modif"
        Me.Button_modif.Size = New System.Drawing.Size(25, 23)
        Me.Button_modif.TabIndex = 7
        Me.Button_modif.Text = "="
        Me.Button_modif.UseVisualStyleBackColor = True
        '
        'OpenFileDialog_fichier
        '
        Me.OpenFileDialog_fichier.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(190, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Ouvrir..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox_prenom)
        Me.GroupBox1.Controls.Add(Me.TextBox_dateNaissance)
        Me.GroupBox1.Controls.Add(Me.TextBox_nom)
        Me.GroupBox1.Location = New System.Drawing.Point(367, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 123)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Date de naissance :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Prénom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nom :"
        '
        'TextBox_prenom
        '
        Me.TextBox_prenom.Location = New System.Drawing.Point(134, 54)
        Me.TextBox_prenom.Name = "TextBox_prenom"
        Me.TextBox_prenom.Size = New System.Drawing.Size(194, 20)
        Me.TextBox_prenom.TabIndex = 28
        '
        'TextBox_dateNaissance
        '
        Me.TextBox_dateNaissance.Location = New System.Drawing.Point(134, 80)
        Me.TextBox_dateNaissance.Name = "TextBox_dateNaissance"
        Me.TextBox_dateNaissance.Size = New System.Drawing.Size(194, 20)
        Me.TextBox_dateNaissance.TabIndex = 27
        '
        'TextBox_nom
        '
        Me.TextBox_nom.Location = New System.Drawing.Point(134, 28)
        Me.TextBox_nom.Name = "TextBox_nom"
        Me.TextBox_nom.Size = New System.Drawing.Size(194, 20)
        Me.TextBox_nom.TabIndex = 26
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ComboBox_type)
        Me.GroupBox2.Controls.Add(Me.TextBox_dateCreation)
        Me.GroupBox2.Controls.Add(Me.TextBox_solde)
        Me.GroupBox2.Controls.Add(Me.TextBox_plafond)
        Me.GroupBox2.Location = New System.Drawing.Point(367, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 141)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compte"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Type de compte :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Plafond :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Solde :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Date de création :"
        '
        'ComboBox_type
        '
        Me.ComboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_type.FormattingEnabled = True
        Me.ComboBox_type.Items.AddRange(New Object() {"Compte courant", "Compte jeune", "Plan d'épargne logement"})
        Me.ComboBox_type.Location = New System.Drawing.Point(134, 25)
        Me.ComboBox_type.Name = "ComboBox_type"
        Me.ComboBox_type.Size = New System.Drawing.Size(194, 21)
        Me.ComboBox_type.Sorted = True
        Me.ComboBox_type.TabIndex = 26
        '
        'TextBox_dateCreation
        '
        Me.TextBox_dateCreation.Location = New System.Drawing.Point(134, 52)
        Me.TextBox_dateCreation.Name = "TextBox_dateCreation"
        Me.TextBox_dateCreation.Size = New System.Drawing.Size(194, 20)
        Me.TextBox_dateCreation.TabIndex = 25
        '
        'TextBox_solde
        '
        Me.TextBox_solde.Location = New System.Drawing.Point(134, 78)
        Me.TextBox_solde.Name = "TextBox_solde"
        Me.TextBox_solde.Size = New System.Drawing.Size(194, 20)
        Me.TextBox_solde.TabIndex = 24
        '
        'TextBox_plafond
        '
        Me.TextBox_plafond.Location = New System.Drawing.Point(134, 104)
        Me.TextBox_plafond.Name = "TextBox_plafond"
        Me.TextBox_plafond.Size = New System.Drawing.Size(194, 20)
        Me.TextBox_plafond.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(214, 329)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 44)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 482)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button_modif)
        Me.Controls.Add(Me.Button_moins)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox_nom)
        Me.Controls.Add(Me.Button_add)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_SaisieNom)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox_SaisieNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_add As Button
    Friend WithEvents ListBox_nom As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button_moins As Button
    Friend WithEvents Button_modif As Button
    Friend WithEvents OpenFileDialog_fichier As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_prenom As TextBox
    Friend WithEvents TextBox_dateNaissance As TextBox
    Friend WithEvents TextBox_nom As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_type As ComboBox
    Friend WithEvents TextBox_dateCreation As TextBox
    Friend WithEvents TextBox_solde As TextBox
    Friend WithEvents TextBox_plafond As TextBox
    Friend WithEvents Button3 As Button
End Class
