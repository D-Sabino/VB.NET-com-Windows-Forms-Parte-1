<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_04
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
        Me.lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.lbl_idade = New System.Windows.Forms.Label()
        Me.txt_idade = New System.Windows.Forms.TextBox()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.grp_pais = New System.Windows.Forms.GroupBox()
        Me.Rdb_Sim = New System.Windows.Forms.RadioButton()
        Me.Rdb_Nao = New System.Windows.Forms.RadioButton()
        Me.grp_pais.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.Location = New System.Drawing.Point(15, 108)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(308, 72)
        Me.Btm_Principal.TabIndex = 0
        Me.Btm_Principal.Text = "Clique aqui"
        Me.Btm_Principal.UseVisualStyleBackColor = True
        '
        'lbl_NomeProjeto
        '
        Me.lbl_NomeProjeto.AutoSize = True
        Me.lbl_NomeProjeto.Location = New System.Drawing.Point(12, 9)
        Me.lbl_NomeProjeto.Name = "lbl_NomeProjeto"
        Me.lbl_NomeProjeto.Size = New System.Drawing.Size(129, 17)
        Me.lbl_NomeProjeto.TabIndex = 1
        Me.lbl_NomeProjeto.Text = "1 - Primeiro projeto"
        '
        'lbl_idade
        '
        Me.lbl_idade.AutoSize = True
        Me.lbl_idade.Location = New System.Drawing.Point(12, 26)
        Me.lbl_idade.Name = "lbl_idade"
        Me.lbl_idade.Size = New System.Drawing.Size(51, 17)
        Me.lbl_idade.TabIndex = 2
        Me.lbl_idade.Text = "Label1"
        '
        'txt_idade
        '
        Me.txt_idade.Location = New System.Drawing.Point(15, 46)
        Me.txt_idade.Name = "txt_idade"
        Me.txt_idade.Size = New System.Drawing.Size(112, 22)
        Me.txt_idade.TabIndex = 3
        '
        'txt_resultado
        '
        Me.txt_resultado.Location = New System.Drawing.Point(12, 229)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(455, 22)
        Me.txt_resultado.TabIndex = 4
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Location = New System.Drawing.Point(12, 209)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(51, 17)
        Me.lbl_resultado.TabIndex = 5
        Me.lbl_resultado.Text = "Label1"
        '
        'grp_pais
        '
        Me.grp_pais.Controls.Add(Me.Rdb_Nao)
        Me.grp_pais.Controls.Add(Me.Rdb_Sim)
        Me.grp_pais.Location = New System.Drawing.Point(133, 26)
        Me.grp_pais.Name = "grp_pais"
        Me.grp_pais.Size = New System.Drawing.Size(200, 76)
        Me.grp_pais.TabIndex = 6
        Me.grp_pais.TabStop = False
        Me.grp_pais.Text = "GroupBox1"
        '
        'Rdb_Sim
        '
        Me.Rdb_Sim.AutoSize = True
        Me.Rdb_Sim.Location = New System.Drawing.Point(6, 21)
        Me.Rdb_Sim.Name = "Rdb_Sim"
        Me.Rdb_Sim.Size = New System.Drawing.Size(115, 21)
        Me.Rdb_Sim.TabIndex = 7
        Me.Rdb_Sim.TabStop = True
        Me.Rdb_Sim.Text = "RadioButton1"
        Me.Rdb_Sim.UseVisualStyleBackColor = True
        '
        'Rdb_Nao
        '
        Me.Rdb_Nao.AutoSize = True
        Me.Rdb_Nao.Location = New System.Drawing.Point(6, 48)
        Me.Rdb_Nao.Name = "Rdb_Nao"
        Me.Rdb_Nao.Size = New System.Drawing.Size(115, 21)
        Me.Rdb_Nao.TabIndex = 8
        Me.Rdb_Nao.TabStop = True
        Me.Rdb_Nao.Text = "RadioButton1"
        Me.Rdb_Nao.UseVisualStyleBackColor = True
        '
        'Frm_Principal_04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.grp_pais)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.txt_idade)
        Me.Controls.Add(Me.lbl_idade)
        Me.Controls.Add(Me.lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Name = "Frm_Principal_04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação - Ola Mundo"
        Me.grp_pais.ResumeLayout(False)
        Me.grp_pais.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents lbl_NomeProjeto As Label
    Friend WithEvents lbl_idade As Label
    Friend WithEvents txt_idade As TextBox
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents lbl_resultado As Label
    Friend WithEvents lbl_pais As Label
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents grp_pais As GroupBox
    Friend WithEvents Rdb_Sim As RadioButton
    Friend WithEvents Rdb_Nao As RadioButton
End Class
