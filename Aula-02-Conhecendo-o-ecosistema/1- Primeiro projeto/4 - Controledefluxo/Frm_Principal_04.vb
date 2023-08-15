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
        grp_pais.Text = "Acompanhado dos pais?"
        Rdb_Sim.Text = "Sim"
        Rdb_Nao.Text = "Não"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click
        txt_resultado.Text = ""

        Dim idade As Integer
        idade = txt_idade.Text

        Dim acompanhadoPais As String
        If Rdb_Sim.Checked Then
            acompanhadoPais = "S"
        Else
            acompanhadoPais = "N"
        End If

        Dim PodeEntrar As Boolean = (idade >= 18) Or (acompanhadoPais = "S" And idade >= 16)
        Dim NaoPodeEntrar As Boolean = (acompanhadoPais = "N" And idade >= 16) Or (idade < 16)

        Dim MensagemAdicional As String
        If acompanhadoPais = "S" Then
            MensagemAdicional = "Esta acompanhado."
        Else
            MensagemAdicional = "Não esta acompanhado."
        End If

        If PodeEntrar Then
            txt_resultado.ForeColor = Color.Green
            txt_resultado.Text = "A pessoa pode assistir a peça." + MensagemAdicional
        ElseIf NaoPodeEntrar Then
            txt_resultado.ForeColor = Color.Red
            txt_resultado.Text = "A pessoa não pode assistir a peça." + MensagemAdicional
        End If

    End Sub
End Class
