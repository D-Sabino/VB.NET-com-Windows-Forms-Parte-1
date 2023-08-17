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
        Me.Lbl_Periodos = New System.Windows.Forms.Label()
        Me.Txt_Periodos = New System.Windows.Forms.TextBox()
        Me.Grp_Grupo1 = New System.Windows.Forms.GroupBox()
        Me.Grp_Grupo2 = New System.Windows.Forms.GroupBox()
        Me.lbl_Principal2 = New System.Windows.Forms.Label()
        Me.Txt_Principal2 = New System.Windows.Forms.TextBox()
        Me.Txt_Rendimento2 = New System.Windows.Forms.TextBox()
        Me.Lbl_Rendimento2 = New System.Windows.Forms.Label()
        Me.txt_Anos = New System.Windows.Forms.TextBox()
        Me.Lbl_Anos = New System.Windows.Forms.Label()
        Me.txt_acrescimo_rendimento = New System.Windows.Forms.TextBox()
        Me.lbl_acrescimo_rendimento = New System.Windows.Forms.Label()
        Me.btm_calcula = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Grp_Grupo1.SuspendLayout()
        Me.Grp_Grupo2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.Location = New System.Drawing.Point(6, 74)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(270, 43)
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
        Me.lbl_Principal.Location = New System.Drawing.Point(3, 26)
        Me.lbl_Principal.Name = "lbl_Principal"
        Me.lbl_Principal.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Principal.TabIndex = 2
        Me.lbl_Principal.Text = "Label2"
        '
        'lbl_rendimento
        '
        Me.lbl_rendimento.AutoSize = True
        Me.lbl_rendimento.Location = New System.Drawing.Point(149, 26)
        Me.lbl_rendimento.Name = "lbl_rendimento"
        Me.lbl_rendimento.Size = New System.Drawing.Size(51, 17)
        Me.lbl_rendimento.TabIndex = 3
        Me.lbl_rendimento.Text = "Label3"
        '
        'Txt_Principal
        '
        Me.Txt_Principal.Location = New System.Drawing.Point(6, 46)
        Me.Txt_Principal.Name = "Txt_Principal"
        Me.Txt_Principal.Size = New System.Drawing.Size(125, 22)
        Me.Txt_Principal.TabIndex = 4
        '
        'Txt_Rendimento
        '
        Me.Txt_Rendimento.Location = New System.Drawing.Point(152, 46)
        Me.Txt_Rendimento.Name = "Txt_Rendimento"
        Me.Txt_Rendimento.Size = New System.Drawing.Size(125, 22)
        Me.Txt_Rendimento.TabIndex = 5
        '
        'Lbl_Periodos
        '
        Me.Lbl_Periodos.AutoSize = True
        Me.Lbl_Periodos.Location = New System.Drawing.Point(294, 26)
        Me.Lbl_Periodos.Name = "Lbl_Periodos"
        Me.Lbl_Periodos.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_Periodos.TabIndex = 6
        Me.Lbl_Periodos.Text = "Label3"
        '
        'Txt_Periodos
        '
        Me.Txt_Periodos.Location = New System.Drawing.Point(297, 46)
        Me.Txt_Periodos.Name = "Txt_Periodos"
        Me.Txt_Periodos.Size = New System.Drawing.Size(125, 22)
        Me.Txt_Periodos.TabIndex = 7
        '
        'Grp_Grupo1
        '
        Me.Grp_Grupo1.Controls.Add(Me.Btm_Principal)
        Me.Grp_Grupo1.Controls.Add(Me.Txt_Periodos)
        Me.Grp_Grupo1.Controls.Add(Me.lbl_Principal)
        Me.Grp_Grupo1.Controls.Add(Me.Lbl_Periodos)
        Me.Grp_Grupo1.Controls.Add(Me.lbl_rendimento)
        Me.Grp_Grupo1.Controls.Add(Me.Txt_Rendimento)
        Me.Grp_Grupo1.Controls.Add(Me.Txt_Principal)
        Me.Grp_Grupo1.Location = New System.Drawing.Point(15, 29)
        Me.Grp_Grupo1.Name = "Grp_Grupo1"
        Me.Grp_Grupo1.Size = New System.Drawing.Size(446, 129)
        Me.Grp_Grupo1.TabIndex = 8
        Me.Grp_Grupo1.TabStop = False
        Me.Grp_Grupo1.Text = "GroupBox1"
        '
        'Grp_Grupo2
        '
        Me.Grp_Grupo2.Controls.Add(Me.txtResultado)
        Me.Grp_Grupo2.Controls.Add(Me.btm_calcula)
        Me.Grp_Grupo2.Controls.Add(Me.txt_acrescimo_rendimento)
        Me.Grp_Grupo2.Controls.Add(Me.lbl_acrescimo_rendimento)
        Me.Grp_Grupo2.Controls.Add(Me.txt_Anos)
        Me.Grp_Grupo2.Controls.Add(Me.Lbl_Anos)
        Me.Grp_Grupo2.Controls.Add(Me.Txt_Rendimento2)
        Me.Grp_Grupo2.Controls.Add(Me.Lbl_Rendimento2)
        Me.Grp_Grupo2.Controls.Add(Me.Txt_Principal2)
        Me.Grp_Grupo2.Controls.Add(Me.lbl_Principal2)
        Me.Grp_Grupo2.Location = New System.Drawing.Point(15, 164)
        Me.Grp_Grupo2.Name = "Grp_Grupo2"
        Me.Grp_Grupo2.Size = New System.Drawing.Size(446, 277)
        Me.Grp_Grupo2.TabIndex = 9
        Me.Grp_Grupo2.TabStop = False
        Me.Grp_Grupo2.Text = "GroupBox1"
        '
        'lbl_Principal2
        '
        Me.lbl_Principal2.AutoSize = True
        Me.lbl_Principal2.Location = New System.Drawing.Point(3, 18)
        Me.lbl_Principal2.Name = "lbl_Principal2"
        Me.lbl_Principal2.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Principal2.TabIndex = 0
        Me.lbl_Principal2.Text = "Label2"
        '
        'Txt_Principal2
        '
        Me.Txt_Principal2.Location = New System.Drawing.Point(6, 38)
        Me.Txt_Principal2.Name = "Txt_Principal2"
        Me.Txt_Principal2.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Principal2.TabIndex = 1
        '
        'Txt_Rendimento2
        '
        Me.Txt_Rendimento2.Location = New System.Drawing.Point(112, 38)
        Me.Txt_Rendimento2.Name = "Txt_Rendimento2"
        Me.Txt_Rendimento2.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Rendimento2.TabIndex = 3
        '
        'Lbl_Rendimento2
        '
        Me.Lbl_Rendimento2.AutoSize = True
        Me.Lbl_Rendimento2.Location = New System.Drawing.Point(109, 18)
        Me.Lbl_Rendimento2.Name = "Lbl_Rendimento2"
        Me.Lbl_Rendimento2.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_Rendimento2.TabIndex = 2
        Me.Lbl_Rendimento2.Text = "Label3"
        '
        'txt_Anos
        '
        Me.txt_Anos.Location = New System.Drawing.Point(218, 38)
        Me.txt_Anos.Name = "txt_Anos"
        Me.txt_Anos.Size = New System.Drawing.Size(100, 22)
        Me.txt_Anos.TabIndex = 5
        '
        'Lbl_Anos
        '
        Me.Lbl_Anos.AutoSize = True
        Me.Lbl_Anos.Location = New System.Drawing.Point(215, 18)
        Me.Lbl_Anos.Name = "Lbl_Anos"
        Me.Lbl_Anos.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_Anos.TabIndex = 4
        Me.Lbl_Anos.Text = "Label4"
        '
        'txt_acrescimo_rendimento
        '
        Me.txt_acrescimo_rendimento.Location = New System.Drawing.Point(322, 38)
        Me.txt_acrescimo_rendimento.Name = "txt_acrescimo_rendimento"
        Me.txt_acrescimo_rendimento.Size = New System.Drawing.Size(100, 22)
        Me.txt_acrescimo_rendimento.TabIndex = 7
        '
        'lbl_acrescimo_rendimento
        '
        Me.lbl_acrescimo_rendimento.AutoSize = True
        Me.lbl_acrescimo_rendimento.Location = New System.Drawing.Point(319, 18)
        Me.lbl_acrescimo_rendimento.Name = "lbl_acrescimo_rendimento"
        Me.lbl_acrescimo_rendimento.Size = New System.Drawing.Size(51, 17)
        Me.lbl_acrescimo_rendimento.TabIndex = 6
        Me.lbl_acrescimo_rendimento.Text = "Label5"
        '
        'btm_calcula
        '
        Me.btm_calcula.Location = New System.Drawing.Point(7, 66)
        Me.btm_calcula.Name = "btm_calcula"
        Me.btm_calcula.Size = New System.Drawing.Size(415, 43)
        Me.btm_calcula.TabIndex = 8
        Me.btm_calcula.Text = "Clique aqui"
        Me.btm_calcula.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(6, 115)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResultado.Size = New System.Drawing.Size(416, 112)
        Me.txtResultado.TabIndex = 9
        '
        'Frm_Principal_05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.Grp_Grupo2)
        Me.Controls.Add(Me.Grp_Grupo1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_Principal_05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação - Ola Mundo"
        Me.Grp_Grupo1.ResumeLayout(False)
        Me.Grp_Grupo1.PerformLayout()
        Me.Grp_Grupo2.ResumeLayout(False)
        Me.Grp_Grupo2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Principal As Label
    Friend WithEvents lbl_rendimento As Label
    Friend WithEvents Txt_Principal As TextBox
    Friend WithEvents Txt_Rendimento As TextBox
    Friend WithEvents Lbl_Periodos As Label
    Friend WithEvents Txt_Periodos As TextBox
    Friend WithEvents Grp_Grupo1 As GroupBox
    Friend WithEvents Grp_Grupo2 As GroupBox
    Friend WithEvents txt_acrescimo_rendimento As TextBox
    Friend WithEvents lbl_acrescimo_rendimento As Label
    Friend WithEvents txt_Anos As TextBox
    Friend WithEvents Lbl_Anos As Label
    Friend WithEvents Txt_Rendimento2 As TextBox
    Friend WithEvents Lbl_Rendimento2 As Label
    Friend WithEvents Txt_Principal2 As TextBox
    Friend WithEvents lbl_Principal2 As Label
    Friend WithEvents btm_calcula As Button
    Friend WithEvents txtResultado As TextBox
End Class
