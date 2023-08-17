Public Class Frm_Principal_05
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Label1.Text = "5 - Laços de repetição"
        Me.Text = "5 - Laços de repetição"
        lbl_Principal.Text = "Valor investido"
        lbl_rendimento.Text = "Juros (%)"
        Lbl_Periodos.Text = "Periodos"

        Btm_Principal.Text = "Calcular valor"

        Grp_Grupo1.Text = "Calculo do investimento..."
        Grp_Grupo2.Text = "Calculo do investimento anual"
        lbl_Principal2.Text = "Valor investido"
        Lbl_Rendimento2.Text = "Juros mensais(%)"
        Lbl_Anos.Text = "Anos aplicados"
        lbl_acrescimo_rendimento.Text = "Acrescimo Juros (%)"
        btm_calcula.Text = "Efetua calculo"
    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click
        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodos As Integer = Val(Txt_Periodos.Text)
        Dim contador As Integer = 1

        While contador < periodos
            investimento = investimento + (investimento * (rendimento / 100))

            contador += 1
        End While

        MsgBox("O valor apos o rendimento é: " + investimento.ToString + " apos " + periodos.ToString + " meses")
    End Sub

    Private Sub btm_calcula_Click(sender As Object, e As EventArgs) Handles btm_calcula.Click
        Dim investimento As Double = Val(Txt_Principal2.Text)
        Dim rendimento As Double = Val(Txt_Rendimento2.Text)
        Dim anos As Double = Val(txt_Anos.Text)
        Dim acrescimosJuros As Double = Val(txt_acrescimo_rendimento.Text)
        Dim extrato As String = ""
        Dim contador As Integer = 1

        For i As Integer = 1 To anos
            For j As Integer = 1 To 12
                investimento = (investimento + (investimento * (rendimento / 100)))
                extrato += "O saldo do investimento no mes " + contador.ToString + " é " + investimento.ToString + " usando a taxa " +
                            rendimento.ToString + "% mes" + vbCrLf
                contador += 1
            Next

            rendimento = rendimento + (rendimento * acrescimosJuros / 100)
        Next
        txtResultado.Text = extrato
    End Sub

    Private Sub BtmTabuada_Click(sender As Object, e As EventArgs) Handles BtmTabuada.Click
        Dim tabuada As String = ""
        Dim multiplicacao As Integer = 1

        For i As Integer = 1 To 3
            For j As Integer = 1 To 10
                multiplicacao = i * j
                tabuada = tabuada + "O numero " + i.ToString + " X " + j.ToString + " é " + multiplicacao.ToString + vbCrLf
            Next
            tabuada = tabuada + vbCrLf

        Next

        MsgBox(tabuada)

    End Sub
End Class
