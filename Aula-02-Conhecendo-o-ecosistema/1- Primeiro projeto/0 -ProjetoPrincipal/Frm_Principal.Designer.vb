<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btm_01 = New System.Windows.Forms.Button()
        Me.btm_02 = New System.Windows.Forms.Button()
        Me.btm_03 = New System.Windows.Forms.Button()
        Me.btm_04 = New System.Windows.Forms.Button()
        Me.btm_05 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btm_01
        '
        Me.btm_01.Location = New System.Drawing.Point(12, 12)
        Me.btm_01.Name = "btm_01"
        Me.btm_01.Size = New System.Drawing.Size(274, 42)
        Me.btm_01.TabIndex = 0
        Me.btm_01.Text = "Button1"
        Me.btm_01.UseVisualStyleBackColor = True
        '
        'btm_02
        '
        Me.btm_02.Location = New System.Drawing.Point(12, 60)
        Me.btm_02.Name = "btm_02"
        Me.btm_02.Size = New System.Drawing.Size(274, 42)
        Me.btm_02.TabIndex = 1
        Me.btm_02.Text = "Button2"
        Me.btm_02.UseVisualStyleBackColor = True
        '
        'btm_03
        '
        Me.btm_03.Location = New System.Drawing.Point(12, 108)
        Me.btm_03.Name = "btm_03"
        Me.btm_03.Size = New System.Drawing.Size(274, 42)
        Me.btm_03.TabIndex = 2
        Me.btm_03.Text = "Button3"
        Me.btm_03.UseVisualStyleBackColor = True
        '
        'btm_04
        '
        Me.btm_04.Location = New System.Drawing.Point(12, 156)
        Me.btm_04.Name = "btm_04"
        Me.btm_04.Size = New System.Drawing.Size(274, 42)
        Me.btm_04.TabIndex = 3
        Me.btm_04.Text = "Button4"
        Me.btm_04.UseVisualStyleBackColor = True
        '
        'btm_05
        '
        Me.btm_05.Location = New System.Drawing.Point(12, 204)
        Me.btm_05.Name = "btm_05"
        Me.btm_05.Size = New System.Drawing.Size(274, 42)
        Me.btm_05.TabIndex = 4
        Me.btm_05.Text = "Button5"
        Me.btm_05.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 259)
        Me.Controls.Add(Me.btm_05)
        Me.Controls.Add(Me.btm_04)
        Me.Controls.Add(Me.btm_03)
        Me.Controls.Add(Me.btm_02)
        Me.Controls.Add(Me.btm_01)
        Me.Name = "Frm_Principal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btm_01 As Button
    Friend WithEvents btm_02 As Button
    Friend WithEvents btm_03 As Button
    Friend WithEvents btm_04 As Button
    Friend WithEvents btm_05 As Button
End Class
