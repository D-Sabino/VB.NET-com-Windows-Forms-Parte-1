Public Class Frm_Principal_05
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Label1.Text = "5 - Laços de repetição"
        Me.Text = "5 - Laços de repetição"
        lbl_Principal.Text = "Valor investido"
        lbl_rendimento.Text = "Juros (%)"

        Btm_Principal.Text = "Calcular valor"
    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click
        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)

        investimento = investimento + (investimento * (rendimento / 100))

        MsgBox("O valor apos o rendimento é: " + investimento.ToString)
    End Sub
End Class
