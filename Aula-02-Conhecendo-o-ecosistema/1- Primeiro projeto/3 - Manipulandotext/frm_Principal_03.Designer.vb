<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Principal_03
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
        Me.lbl_Curso = New System.Windows.Forms.Label()
        Me.txt_curso = New System.Windows.Forms.TextBox()
        Me.btm_adicionar = New System.Windows.Forms.Button()
        Me.txt_lista = New System.Windows.Forms.TextBox()
        Me.btm_MostraLista = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.Location = New System.Drawing.Point(12, 29)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(458, 37)
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
        'lbl_Curso
        '
        Me.lbl_Curso.AutoSize = True
        Me.lbl_Curso.Location = New System.Drawing.Point(12, 81)
        Me.lbl_Curso.Name = "lbl_Curso"
        Me.lbl_Curso.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Curso.TabIndex = 2
        Me.lbl_Curso.Text = "Label1"
        '
        'txt_curso
        '
        Me.txt_curso.Location = New System.Drawing.Point(15, 101)
        Me.txt_curso.Name = "txt_curso"
        Me.txt_curso.Size = New System.Drawing.Size(209, 22)
        Me.txt_curso.TabIndex = 3
        '
        'btm_adicionar
        '
        Me.btm_adicionar.Location = New System.Drawing.Point(230, 81)
        Me.btm_adicionar.Name = "btm_adicionar"
        Me.btm_adicionar.Size = New System.Drawing.Size(240, 42)
        Me.btm_adicionar.TabIndex = 4
        Me.btm_adicionar.Text = "Clique aqui"
        Me.btm_adicionar.UseVisualStyleBackColor = True
        '
        'txt_lista
        '
        Me.txt_lista.Location = New System.Drawing.Point(15, 129)
        Me.txt_lista.Multiline = True
        Me.txt_lista.Name = "txt_lista"
        Me.txt_lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_lista.Size = New System.Drawing.Size(455, 210)
        Me.txt_lista.TabIndex = 5
        '
        'btm_MostraLista
        '
        Me.btm_MostraLista.Location = New System.Drawing.Point(15, 345)
        Me.btm_MostraLista.Name = "btm_MostraLista"
        Me.btm_MostraLista.Size = New System.Drawing.Size(455, 42)
        Me.btm_MostraLista.TabIndex = 6
        Me.btm_MostraLista.Text = "Clique aqui"
        Me.btm_MostraLista.UseVisualStyleBackColor = True
        '
        'frm_Principal_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.btm_MostraLista)
        Me.Controls.Add(Me.txt_lista)
        Me.Controls.Add(Me.btm_adicionar)
        Me.Controls.Add(Me.txt_curso)
        Me.Controls.Add(Me.lbl_Curso)
        Me.Controls.Add(Me.lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Name = "frm_Principal_03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação - Ola Mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents lbl_NomeProjeto As Label
    Friend WithEvents lbl_Curso As Label
    Friend WithEvents txt_curso As TextBox
    Friend WithEvents btm_adicionar As Button
    Friend WithEvents txt_lista As TextBox
    Friend WithEvents btm_MostraLista As Button
End Class
