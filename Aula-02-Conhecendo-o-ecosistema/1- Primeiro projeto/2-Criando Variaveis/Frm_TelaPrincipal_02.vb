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
End Class
