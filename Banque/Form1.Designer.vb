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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 482)
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
End Class
