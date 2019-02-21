<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_aide
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
        Me.Button_ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_ok
        '
        Me.Button_ok.Location = New System.Drawing.Point(225, 318)
        Me.Button_ok.Name = "Button_ok"
        Me.Button_ok.Size = New System.Drawing.Size(75, 23)
        Me.Button_ok.TabIndex = 0
        Me.Button_ok.Text = "Ok"
        Me.Button_ok.UseVisualStyleBackColor = True
        '
        'Form_aide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 360)
        Me.Controls.Add(Me.Button_ok)
        Me.Name = "Form_aide"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aide"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_ok As Button
End Class
