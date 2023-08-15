Public Class Frm_Principal_04
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        lbl_NomeProjeto.Text = "4 - Controle de fluxo"
        Btm_Principal.Text = "Clique para ver os resultados"
        Me.Text = "4 - Controle de fluxo"

        lbl_idade.Text = "Idade"
        lbl_resultado.Text = "Resultado"
        lbl_pais.Text = "Esta acompanhado dos pais? S ou N"
    End Sub

    Private Sub Frm_Principal_04_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click
        txt_resultado.Text = ""

        Dim idade As Integer
        idade = txt_idade.Text

        Dim acompanhadoPais As String
        acompanhadoPais = txt_pais.Text

        Dim PodeEntrar As Boolean = (idade >= 18) Or (acompanhadoPais = "S" And idade >= 16)
        Dim NaoPodeEntrar As Boolean = (acompanhadoPais = "N" And idade >= 16) Or (idade < 16)

        If PodeEntrar Then
            txt_resultado.Text = "A pessoa pode assistir a peça."
        ElseIf NaoPodeEntrar Then
            txt_resultado.Text = "A pessoa não pode assistir a peça."
        End If

    End Sub
End Class
