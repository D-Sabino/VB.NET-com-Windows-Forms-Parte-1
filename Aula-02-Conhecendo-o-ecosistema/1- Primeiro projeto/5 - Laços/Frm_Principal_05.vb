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
End Class
