<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TelaPrincipal_02
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btm_NumerosInteiros = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btm_PontoFlutuante = New System.Windows.Forms.Button()
        Me.Btm_ConversaoNumeros = New System.Windows.Forms.Button()
        Me.txt_numerador = New System.Windows.Forms.TextBox()
        Me.txt_denominador = New System.Windows.Forms.TextBox()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btm_NumerosInteiros
        '
        Me.Btm_NumerosInteiros.Location = New System.Drawing.Point(12, 29)
        Me.Btm_NumerosInteiros.Name = "Btm_NumerosInteiros"
        Me.Btm_NumerosInteiros.Size = New System.Drawing.Size(125, 125)
        Me.Btm_NumerosInteiros.TabIndex = 0
        Me.Btm_NumerosInteiros.Text = "Exemplos Numeros Inteiros"
        Me.Btm_NumerosInteiros.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "2 - Criando variaveis"
        '
        'Btm_PontoFlutuante
        '
        Me.Btm_PontoFlutuante.Location = New System.Drawing.Point(143, 29)
        Me.Btm_PontoFlutuante.Name = "Btm_PontoFlutuante"
        Me.Btm_PontoFlutuante.Size = New System.Drawing.Size(125, 125)
        Me.Btm_PontoFlutuante.TabIndex = 3
        Me.Btm_PontoFlutuante.Text = "Exemplos Pontos Flutuantes"
        Me.Btm_PontoFlutuante.UseVisualStyleBackColor = True
        '
        'Btm_ConversaoNumeros
        '
        Me.Btm_ConversaoNumeros.Location = New System.Drawing.Point(274, 29)
        Me.Btm_ConversaoNumeros.Name = "Btm_ConversaoNumeros"
        Me.Btm_ConversaoNumeros.Size = New System.Drawing.Size(125, 125)
        Me.Btm_ConversaoNumeros.TabIndex = 4
        Me.Btm_ConversaoNumeros.Text = "Exemplos Conversao Numeros"
        Me.Btm_ConversaoNumeros.UseVisualStyleBackColor = True
        '
        'txt_numerador
        '
        Me.txt_numerador.Location = New System.Drawing.Point(405, 29)
        Me.txt_numerador.Name = "txt_numerador"
        Me.txt_numerador.Size = New System.Drawing.Size(284, 22)
        Me.txt_numerador.TabIndex = 5
        '
        'txt_denominador
        '
        Me.txt_denominador.Location = New System.Drawing.Point(405, 57)
        Me.txt_denominador.Name = "txt_denominador"
        Me.txt_denominador.Size = New System.Drawing.Size(284, 22)
        Me.txt_denominador.TabIndex = 6
        '
        'btnResultado
        '
        Me.btnResultado.Location = New System.Drawing.Point(405, 85)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Size = New System.Drawing.Size(125, 69)
        Me.btnResultado.TabIndex = 7
        Me.btnResultado.Text = "Resultado"
        Me.btnResultado.UseVisualStyleBackColor = True
        '
        'txt_resultado
        '
        Me.txt_resultado.Enabled = False
        Me.txt_resultado.Location = New System.Drawing.Point(536, 85)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(153, 22)
        Me.txt_resultado.TabIndex = 8
        '
        'Frm_TelaPrincipal_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 453)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.btnResultado)
        Me.Controls.Add(Me.txt_denominador)
        Me.Controls.Add(Me.txt_numerador)
        Me.Controls.Add(Me.Btm_ConversaoNumeros)
        Me.Controls.Add(Me.Btm_PontoFlutuante)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btm_NumerosInteiros)
        Me.Name = "Frm_TelaPrincipal_02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação - Ola Mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_NumerosInteiros As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btm_PontoFlutuante As Button
    Friend WithEvents Btm_ConversaoNumeros As Button
    Friend WithEvents txt_numerador As TextBox
    Friend WithEvents txt_denominador As TextBox
    Friend WithEvents btnResultado As Button
    Friend WithEvents txt_resultado As TextBox
End Class
