Public Class Frm_TelaPrincipal_02
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_NumerosInteiros.Click
        Dim idade As Integer
        idade = 12

        MsgBox("O valor da idade é " + idade.ToString, MsgBoxStyle.Critical)

    End Sub

    Private Sub Btm_PontoFlutuante_Click(sender As Object, e As EventArgs) Handles Btm_PontoFlutuante.Click
        Dim valor As Double
        valor = 9.2

        MsgBox("A variavel valor é igual a " + valor.ToString, MsgBoxStyle.Critical)




        Dim numerador As Integer = 5
        Dim denominador As Integer = 2

        valor = numerador / denominador

        MsgBox("Divisão é igual a " + valor.ToString, MsgBoxStyle.Critical)


    End Sub

    Private Sub Btm_ConversaoNumeros_Click(sender As Object, e As EventArgs) Handles Btm_ConversaoNumeros.Click
        Dim Salario As Double
        Salario = 1300.45

        Dim SalarioInteiro As Integer
        SalarioInteiro = Salario

        MsgBox("O valor do salario inteiro é " + SalarioInteiro.ToString, MsgBoxStyle.Critical)

    End Sub

    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        Dim numerador As Double
        Dim denominador As Double
        Dim resultado As Double

        numerador = txt_numerador.Text
        denominador = txt_denominador.Text

        resultado = numerador / denominador

        MsgBox("O resultado entre a divisão de " + numerador.ToString + " por " _
               + denominador.ToString + " é " + resultado.ToString + ".")

        txt_resultado.Text = resultado

    End Sub
End Class
