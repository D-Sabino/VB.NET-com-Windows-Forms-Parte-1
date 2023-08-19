Imports _1__Primeiro_projeto
Imports _2_Criando_Variaveis
Imports _3___Manipulandotext
Imports _4___Controledefluxo
Imports _5___Laços

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Projeto Principal"

        btm_01.Text = "1 - Primeiro projeto"
        btm_02.Text = "2 - Criando variaveis"
        btm_03.Text = "3 - Manipulando textos"
        btm_04.Text = "4 - Controle de Fluxo"
        btm_05.Text = "5 - Laços de repetição"
    End Sub

    Private Sub btm_01_Click(sender As Object, e As EventArgs) Handles btm_01.Click
        Dim f As New Frm_Principal_01
        f.ShowDialog()
    End Sub

    Private Sub btm_02_Click(sender As Object, e As EventArgs) Handles btm_02.Click
        Dim f As New Frm_Principal_02
        f.ShowDialog()
    End Sub

    Private Sub btm_03_Click(sender As Object, e As EventArgs) Handles btm_03.Click
        Dim f As New frm_Principal_03
        f.ShowDialog()
    End Sub

    Private Sub btm_04_Click(sender As Object, e As EventArgs) Handles btm_04.Click
        Dim f As New Frm_Principal_04
        f.ShowDialog()
    End Sub

    Private Sub btm_05_Click(sender As Object, e As EventArgs) Handles btm_05.Click
        Dim f As New Frm_Principal_05
        f.ShowDialog()
    End Sub
End Class
