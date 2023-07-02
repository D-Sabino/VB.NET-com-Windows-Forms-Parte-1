<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btm_AloMundo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btm_AloMundo
        '
        Me.Btm_AloMundo.Location = New System.Drawing.Point(313, 156)
        Me.Btm_AloMundo.Name = "Btm_AloMundo"
        Me.Btm_AloMundo.Size = New System.Drawing.Size(162, 71)
        Me.Btm_AloMundo.TabIndex = 0
        Me.Btm_AloMundo.Text = "Button1"
        Me.Btm_AloMundo.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btm_AloMundo)
        Me.Name = "Frm_Principal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btm_AloMundo As Button
End Class
