Public Class frm_Principal_03

    Dim ListaCurso As String

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        lbl_NomeProjeto.Text = "3 - Manipulando Texto"
        Btm_Principal.Text = "Clique para ver os resultados"
        Me.Text = "3 - Manipulando Texto"
        lbl_Curso.Text = "Digite o seu curso favorito"
        btm_adicionar.Text = "Adicione a sua lista"
        btm_MostraLista.Text = "Mostra lista atual"
    End Sub

    Private Sub btm_adicionar_Click(sender As Object, e As EventArgs) Handles btm_adicionar.Click
        Dim CursoDigitado As String = txt_curso.Text
        ListaCurso = ListaCurso + CursoDigitado + vbCrLf
        txt_lista.Text = ListaCurso
        txt_curso.Text = ""
    End Sub

    Private Sub btm_MostraLista_Click(sender As Object, e As EventArgs) Handles btm_MostraLista.Click
        MsgBox(ListaCurso)
    End Sub
End Class
