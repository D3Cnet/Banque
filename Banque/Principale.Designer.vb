﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_principale
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_principale))
        Me.Button_quitter = New System.Windows.Forms.Button()
        Me.OpenFileDialog_fichier = New System.Windows.Forms.OpenFileDialog()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_modif = New System.Windows.Forms.Button()
        Me.Button_moins = New System.Windows.Forms.Button()
        Me.Button_add = New System.Windows.Forms.Button()
        Me.ListBox_nom = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_aide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExempleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_compte = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_quitter
        '
        Me.Button_quitter.Location = New System.Drawing.Point(513, 335)
        Me.Button_quitter.Name = "Button_quitter"
        Me.Button_quitter.Size = New System.Drawing.Size(75, 23)
        Me.Button_quitter.TabIndex = 0
        Me.Button_quitter.Text = "Quitter"
        Me.Button_quitter.UseVisualStyleBackColor = True
        '
        'OpenFileDialog_fichier
        '
        Me.OpenFileDialog_fichier.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox_prenom)
        Me.GroupBox1.Controls.Add(Me.TextBox_dateNaissance)
        Me.GroupBox1.Controls.Add(Me.TextBox_nom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
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
        Me.TextBox_prenom.TabIndex = 2
        '
        'TextBox_dateNaissance
        '
        Me.TextBox_dateNaissance.Location = New System.Drawing.Point(134, 80)
        Me.TextBox_dateNaissance.Name = "TextBox_dateNaissance"
        Me.TextBox_dateNaissance.Size = New System.Drawing.Size(194, 20)
        Me.TextBox_dateNaissance.TabIndex = 3
        '
        'TextBox_nom
        '
        Me.TextBox_nom.Location = New System.Drawing.Point(134, 28)
        Me.TextBox_nom.Name = "TextBox_nom"
        Me.TextBox_nom.Size = New System.Drawing.Size(194, 20)
        Me.TextBox_nom.TabIndex = 1
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 188)
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
        Me.ComboBox_type.TabIndex = 4
        '
        'TextBox_dateCreation
        '
        Me.TextBox_dateCreation.Location = New System.Drawing.Point(134, 52)
        Me.TextBox_dateCreation.Name = "TextBox_dateCreation"
        Me.TextBox_dateCreation.Size = New System.Drawing.Size(194, 20)
        Me.TextBox_dateCreation.TabIndex = 5
        '
        'TextBox_solde
        '
        Me.TextBox_solde.Location = New System.Drawing.Point(134, 78)
        Me.TextBox_solde.Name = "TextBox_solde"
        Me.TextBox_solde.Size = New System.Drawing.Size(194, 20)
        Me.TextBox_solde.TabIndex = 6
        '
        'TextBox_plafond
        '
        Me.TextBox_plafond.Enabled = False
        Me.TextBox_plafond.Location = New System.Drawing.Point(134, 104)
        Me.TextBox_plafond.Name = "TextBox_plafond"
        Me.TextBox_plafond.Size = New System.Drawing.Size(194, 20)
        Me.TextBox_plafond.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Button_modif)
        Me.GroupBox3.Controls.Add(Me.Button_moins)
        Me.GroupBox3.Controls.Add(Me.Button_add)
        Me.GroupBox3.Controls.Add(Me.ListBox_nom)
        Me.GroupBox3.Location = New System.Drawing.Point(378, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(236, 286)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Liste des comptes"
        '
        'Button_modif
        '
        Me.Button_modif.Location = New System.Drawing.Point(185, 163)
        Me.Button_modif.Name = "Button_modif"
        Me.Button_modif.Size = New System.Drawing.Size(25, 23)
        Me.Button_modif.TabIndex = 10
        Me.Button_modif.Text = "="
        Me.Button_modif.UseVisualStyleBackColor = True
        '
        'Button_moins
        '
        Me.Button_moins.Location = New System.Drawing.Point(185, 134)
        Me.Button_moins.Name = "Button_moins"
        Me.Button_moins.Size = New System.Drawing.Size(25, 23)
        Me.Button_moins.TabIndex = 9
        Me.Button_moins.Text = "-"
        Me.Button_moins.UseVisualStyleBackColor = True
        '
        'Button_add
        '
        Me.Button_add.Location = New System.Drawing.Point(185, 105)
        Me.Button_add.Name = "Button_add"
        Me.Button_add.Size = New System.Drawing.Size(25, 23)
        Me.Button_add.TabIndex = 8
        Me.Button_add.Text = "+"
        Me.Button_add.UseVisualStyleBackColor = True
        '
        'ListBox_nom
        '
        Me.ListBox_nom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox_nom.FormattingEnabled = True
        Me.ListBox_nom.Location = New System.Drawing.Point(40, 29)
        Me.ListBox_nom.Name = "ListBox_nom"
        Me.ListBox_nom.Size = New System.Drawing.Size(120, 238)
        Me.ListBox_nom.Sorted = True
        Me.ListBox_nom.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ToolStripMenuItem_aide})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(626, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.ToolStripSeparator1, Me.OuvrirToolStripMenuItem, Me.FermerToolStripMenuItem, Me.ToolStripSeparator2, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "&Fichier"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NouveauToolStripMenuItem.Text = "&Nouveau"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir..."
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FermerToolStripMenuItem.Text = "Fermer"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'ToolStripMenuItem_aide
        '
        Me.ToolStripMenuItem_aide.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExempleToolStripMenuItem, Me.ToolStripSeparator3, Me.AProposToolStripMenuItem})
        Me.ToolStripMenuItem_aide.Name = "ToolStripMenuItem_aide"
        Me.ToolStripMenuItem_aide.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem_aide.Text = "?"
        '
        'ExempleToolStripMenuItem
        '
        Me.ExempleToolStripMenuItem.Name = "ExempleToolStripMenuItem"
        Me.ExempleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExempleToolStripMenuItem.Text = "Exemple"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AProposToolStripMenuItem.Text = "A propos"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_compte, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 369)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(626, 22)
        Me.StatusStrip1.TabIndex = 29
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel_compte
        '
        Me.ToolStripStatusLabel_compte.Name = "ToolStripStatusLabel_compte"
        Me.ToolStripStatusLabel_compte.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "gardeFace.bmp")
        Me.ImageList1.Images.SetKeyName(1, "homme1.bmp")
        Me.ImageList1.Images.SetKeyName(2, "capitaineFantomeFace.bmp")
        Me.ImageList1.Images.SetKeyName(3, "filleFace.bmp")
        Me.ImageList1.Images.SetKeyName(4, "GarconFace.bmp")
        '
        'form_principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 391)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_quitter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "form_principale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de comptes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_quitter As Button
    Friend WithEvents OpenFileDialog_fichier As OpenFileDialog
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button_modif As Button
    Friend WithEvents Button_moins As Button
    Friend WithEvents Button_add As Button
    Friend WithEvents ListBox_nom As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FermerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_aide As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel_compte As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ExempleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ImageList1 As ImageList
End Class
