<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exemple
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
        Me.Label_X = New System.Windows.Forms.Label()
        Me.Label_Y = New System.Windows.Forms.Label()
        Me.CheckBox_Sortie = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView_compte = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView_compte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_X
        '
        Me.Label_X.AutoSize = True
        Me.Label_X.Location = New System.Drawing.Point(46, 49)
        Me.Label_X.Name = "Label_X"
        Me.Label_X.Size = New System.Drawing.Size(39, 13)
        Me.Label_X.TabIndex = 0
        Me.Label_X.Text = "Label1"
        '
        'Label_Y
        '
        Me.Label_Y.AutoSize = True
        Me.Label_Y.Location = New System.Drawing.Point(52, 77)
        Me.Label_Y.Name = "Label_Y"
        Me.Label_Y.Size = New System.Drawing.Size(39, 13)
        Me.Label_Y.TabIndex = 1
        Me.Label_Y.Text = "Label2"
        '
        'CheckBox_Sortie
        '
        Me.CheckBox_Sortie.AutoSize = True
        Me.CheckBox_Sortie.Location = New System.Drawing.Point(20, 412)
        Me.CheckBox_Sortie.Name = "CheckBox_Sortie"
        Me.CheckBox_Sortie.Size = New System.Drawing.Size(106, 17)
        Me.CheckBox_Sortie.TabIndex = 2
        Me.CheckBox_Sortie.Text = "Autoriser la sortie"
        Me.CheckBox_Sortie.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(607, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView_compte
        '
        Me.DataGridView_compte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_compte.Location = New System.Drawing.Point(195, 32)
        Me.DataGridView_compte.Name = "DataGridView_compte"
        Me.DataGridView_compte.Size = New System.Drawing.Size(460, 265)
        Me.DataGridView_compte.TabIndex = 6
        '
        'Exemple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView_compte)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox_Sortie)
        Me.Controls.Add(Me.Label_Y)
        Me.Controls.Add(Me.Label_X)
        Me.Name = "Exemple"
        Me.RightToLeftLayout = True
        Me.Text = "Exemple"
        CType(Me.DataGridView_compte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_X As Label
    Friend WithEvents Label_Y As Label
    Friend WithEvents CheckBox_Sortie As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView_compte As DataGridView
End Class
