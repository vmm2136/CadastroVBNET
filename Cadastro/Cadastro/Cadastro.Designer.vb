<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CodAluno = New System.Windows.Forms.TextBox()
        Me.Nome = New System.Windows.Forms.TextBox()
        Me.Idade = New System.Windows.Forms.TextBox()
        Me.Cidade = New System.Windows.Forms.TextBox()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Escolaridade = New System.Windows.Forms.ComboBox()
        Me.Estado = New System.Windows.Forms.ComboBox()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.TextBox()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodAluno
        '
        Me.CodAluno.Location = New System.Drawing.Point(186, 46)
        Me.CodAluno.Name = "CodAluno"
        Me.CodAluno.Size = New System.Drawing.Size(121, 20)
        Me.CodAluno.TabIndex = 0
        '
        'Nome
        '
        Me.Nome.Location = New System.Drawing.Point(186, 79)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(121, 20)
        Me.Nome.TabIndex = 1
        '
        'Idade
        '
        Me.Idade.Location = New System.Drawing.Point(186, 116)
        Me.Idade.Name = "Idade"
        Me.Idade.Size = New System.Drawing.Size(121, 20)
        Me.Idade.TabIndex = 3
        '
        'Cidade
        '
        Me.Cidade.Location = New System.Drawing.Point(186, 153)
        Me.Cidade.Name = "Cidade"
        Me.Cidade.Size = New System.Drawing.Size(121, 20)
        Me.Cidade.TabIndex = 4
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(347, 41)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(455, 225)
        Me.dgvDados.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 23)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Código do Aluno"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 23)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Nome"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 23)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Idade"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(36, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 23)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Cidade"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(36, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 23)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Estado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Escolaridade"
        '
        'Escolaridade
        '
        Me.Escolaridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Escolaridade.FormattingEnabled = True
        Me.Escolaridade.Location = New System.Drawing.Point(186, 223)
        Me.Escolaridade.Name = "Escolaridade"
        Me.Escolaridade.Size = New System.Drawing.Size(121, 21)
        Me.Escolaridade.TabIndex = 14
        '
        'Estado
        '
        Me.Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Estado.FormattingEnabled = True
        Me.Estado.Location = New System.Drawing.Point(186, 185)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(121, 21)
        Me.Estado.TabIndex = 15
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(40, 271)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(97, 23)
        Me.btnCadastrar.TabIndex = 16
        Me.btnCadastrar.Text = "Cadastrar Aluno"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(382, 364)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(97, 23)
        Me.btnExcluir.TabIndex = 18
        Me.btnExcluir.Text = "Excluir Aluno"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(40, 364)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(97, 23)
        Me.btnConsulta.TabIndex = 19
        Me.btnConsulta.Text = "Consultar Aluno"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(188, 271)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(119, 23)
        Me.btnAtualizar.TabIndex = 20
        Me.btnAtualizar.Text = "Atualizar Cadastro"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(154, 367)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(176, 20)
        Me.Search.TabIndex = 21
        '
        'Cadastro
        '
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(814, 413)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.Estado)
        Me.Controls.Add(Me.Escolaridade)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.Cidade)
        Me.Controls.Add(Me.Idade)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.CodAluno)
        Me.Name = "Cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alunos"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents CodAluno As TextBox
    Friend WithEvents Nome As TextBox
    Friend WithEvents Idade As TextBox
    Friend WithEvents Cidade As TextBox
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Escolaridade As ComboBox
    Friend WithEvents Estado As ComboBox
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnConsulta As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents Search As TextBox
End Class
