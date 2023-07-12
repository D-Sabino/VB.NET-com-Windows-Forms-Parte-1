Public Class Frm_TelaPrincipal_02
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click
        Dim idade As Integer
        idade = 12

        MsgBox("O valor da idade é " + idade.ToString, MsgBoxStyle.Critical)

    End Sub
End Class
