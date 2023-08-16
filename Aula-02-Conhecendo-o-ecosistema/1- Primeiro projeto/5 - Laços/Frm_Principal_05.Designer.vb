<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_05
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
        Me.Btm_Principal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Principal = New System.Windows.Forms.Label()
        Me.lbl_rendimento = New System.Windows.Forms.Label()
        Me.Txt_Principal = New System.Windows.Forms.TextBox()
        Me.Txt_Rendimento = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.Location = New System.Drawing.Point(345, 316)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(125, 125)
        Me.Btm_Principal.TabIndex = 0
        Me.Btm_Principal.Text = "Clique aqui"
        Me.Btm_Principal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1 - Primeiro projeto"
        '
        'lbl_Principal
        '
        Me.lbl_Principal.AutoSize = True
        Me.lbl_Principal.Location = New System.Drawing.Point(12, 26)
        Me.lbl_Principal.Name = "lbl_Principal"
        Me.lbl_Principal.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Principal.TabIndex = 2
        Me.lbl_Principal.Text = "Label2"
        '
        'lbl_rendimento
        '
        Me.lbl_rendimento.AutoSize = True
        Me.lbl_rendimento.Location = New System.Drawing.Point(201, 26)
        Me.lbl_rendimento.Name = "lbl_rendimento"
        Me.lbl_rendimento.Size = New System.Drawing.Size(51, 17)
        Me.lbl_rendimento.TabIndex = 3
        Me.lbl_rendimento.Text = "Label3"
        '
        'Txt_Principal
        '
        Me.Txt_Principal.Location = New System.Drawing.Point(15, 46)
        Me.Txt_Principal.Name = "Txt_Principal"
        Me.Txt_Principal.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Principal.TabIndex = 4
        '
        'Txt_Rendimento
        '
        Me.Txt_Rendimento.Location = New System.Drawing.Point(204, 46)
        Me.Txt_Rendimento.Name = "Txt_Rendimento"
        Me.Txt_Rendimento.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Rendimento.TabIndex = 5
        '
        'Frm_Principal_05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.Txt_Rendimento)
        Me.Controls.Add(Me.Txt_Principal)
        Me.Controls.Add(Me.lbl_rendimento)
        Me.Controls.Add(Me.lbl_Principal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Name = "Frm_Principal_05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação - Ola Mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Principal As Label
    Friend WithEvents lbl_rendimento As Label
    Friend WithEvents Txt_Principal As TextBox
    Friend WithEvents Txt_Rendimento As TextBox
End Class
