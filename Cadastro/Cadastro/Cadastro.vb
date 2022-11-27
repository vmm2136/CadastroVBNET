Imports System.Data.SqlClient

Public Class Cadastro

    'Realiza a conexão com o BD
    Dim con As New SqlConnection(" Server = DESKTOP-FGL20RU\SQLEXPRESS01 ;Database=Alunos ;User Id= sa; Password=123;")


    Private Sub validarCamposPreenchidos()

        'Valida os campos do formulário. Primeiro valida se os campos estão preenchidos e depois valida se o código do aluno ou o nome ja estão cadastrados.
        If Not IsNumeric(CodAluno.Text) Then

            MsgBox("É necessário informar o código do aluno!", MsgBoxStyle.Exclamation)
            CodAluno.SelectAll()
            CodAluno.Focus()

        ElseIf Nome.Text = "" Then

            MsgBox("É necessário informar o nome do aluno!", MsgBoxStyle.Exclamation)
            Nome.SelectAll()
            Nome.Focus()

        ElseIf Not IsNumeric(Idade.Text) Then

            MsgBox("É necessário informar a idade do aluno!", MsgBoxStyle.Exclamation)
            Idade.SelectAll()
            Idade.Focus()

        ElseIf Cidade.Text = "" Then

            MsgBox("É necessário informar a cidade do aluno!", MsgBoxStyle.Exclamation)
            Cidade.SelectAll()
            Cidade.Focus()
        ElseIf CodAluno IsNot Nothing Then

            Dim cod As Integer = CodAluno.Text
            con.Open()
            Dim validaCod As New SqlCommand("select count(CodAluno) from CadAlunos where CodAluno = '" & cod & "'", con)
            Dim existeCod As Integer = validaCod.ExecuteScalar()

            If existeCod > 0 Then

                MsgBox("Código ja cadastrado!! ", MsgBoxStyle.Exclamation)

            ElseIf Nome.Text <> "" Then

                Dim nomeAluno As String = Nome.Text
                Dim validaNome As New SqlCommand("select count(nome) from CadAlunos where Nome = '" & nomeAluno & "'", con)
                Dim existeNome As Integer = validaNome.ExecuteScalar()

                If existeNome > 0 Then

                    MsgBox("Nome ja cadastrado!! ", MsgBoxStyle.Exclamation)

                Else

                    cadastraAluno()

                End If
                con.Close()
            End If
            con.Close()
        End If


    End Sub

    Public Sub limpaCampos()

        'Limpa os campos após realizar a inclusão, alteração ou exclusão.

        CodAluno.Clear()
        Nome.Clear()
        Idade.Clear()
        Cidade.Clear()

    End Sub

    Private Sub cadastraAluno()

        'Realiza o cadastro do aluno no banco de dados, caso os dados passem nas validações.

        Dim cod As Integer = CodAluno.Text
        Dim nomeAluno As String = Nome.Text
        Dim idadeAluno As Integer = Idade.Text
        Dim cidadeAluno As String = Cidade.Text
        Dim estadoAluno As String = Estado.Text
        Dim escolaridadeAluno As String = Escolaridade.Text

        Dim command As New SqlCommand("insert into CadAlunos values('" & cod & "','" & nomeAluno & "' , '" & idadeAluno & "','" & cidadeAluno & "','" & estadoAluno & "','" & escolaridadeAluno & "' )", con)

        command.ExecuteNonQuery()
        MsgBox("Aluno Cadastrado Com Sucesso!", MsgBoxStyle.Information)
        LoadDataInGrid()
        con.Close()

    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click

        'O botão de cadastrar quando 'pressionado' chama o procedimento validarCamposPreenchidos que por sua vez chama o cadastraAluno.
        validarCamposPreenchidos()

        limpaCampos()

    End Sub

    Private Sub LoadDataInGrid()

        'Exibe os dados ao lado do cadastro e os atualiza conforme as operações são realizadas.

        Dim command As New SqlCommand("select CodAluno, Nome, Idade from CadAlunos", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        dgvDados.DataSource = dt

    End Sub

    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDataInGrid()

        'Busca os estados no BD para retorna-los na ComboBox "Estado"

        Dim command As New SqlCommand("select * from Estados", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        Estado.DataSource = table
        Estado.DisplayMember = "Estado"
        Estado.ValueMember = "Id"

        'Busca os estados no BD para retorna-los na ComboBox "Escolaridade"

        Dim command2 As New SqlCommand("select * from Escolaridade", con)
        Dim adapter2 As New SqlDataAdapter(command2)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        Escolaridade.DataSource = table2
        Escolaridade.DisplayMember = "Escolaridade"
        Escolaridade.ValueMember = "Id"
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click

        'Realiza a alteração do cadastro com base no código do aluno

        If Not IsNumeric(CodAluno.Text) Then

            MsgBox("É necessário informar o código do aluno para realizar a alteração!", MsgBoxStyle.Exclamation)

        Else

            Dim cod As Integer = CodAluno.Text
            Dim nomeAluno As String = Nome.Text
            Dim idadeAluno As Integer = Idade.Text
            Dim cidadeAluno As String = Cidade.Text
            Dim estadoAluno As String = Estado.Text
            Dim escolaridadeAluno As String = Escolaridade.Text

            con.Open()
            Dim command As New SqlCommand("update CadAlunos set Nome = '" & nomeAluno & "' , Idade =  '" & idadeAluno & "', Cidade = '" & cidadeAluno & "', Estado = '" & estadoAluno & "',Escolaridade = '" & escolaridadeAluno & "' where  CodAluno = '" & cod & "'", con)
            command.ExecuteNonQuery()
            con.Close()
            MsgBox("Aluno Alterado Com Sucesso!", MsgBoxStyle.Information)
            LoadDataInGrid()

            limpaCampos()
        End If
    End Sub


    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        'Realiza a exclusão do cadastro específicado pelo Código do aluno - Botão Excluir

        If Not IsNumeric(CodAluno.Text) Then

            MsgBox("É necessário informar o código do aluno para realizar a exclusão!", MsgBoxStyle.Exclamation)

        Else

            Dim cod As Integer = CodAluno.Text
            Dim takeName As New SqlCommand("Select Nome From CadAlunos where CodAluno = '" & cod & "'", con)
            con.Open()
            Dim nomeAluno As String = takeName.ExecuteScalar().ToString()

            If MsgBox("Tem Certeza que deseja excluir o aluno " & cod & "-" & nomeAluno & "", MsgBoxStyle.YesNo) = DialogResult.Yes Then

                Dim command As New SqlCommand("delete CadAlunos where CodAluno = '" & cod & "'", con)
                command.ExecuteNonQuery()
                MsgBox("Aluno Excluído Com Sucesso!", MsgBoxStyle.Information)
                con.Close()
                LoadDataInGrid()

            End If
            con.Close()
        End If

        limpaCampos()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click

        'Realiza a consulta do aluno pelo valor informado no campo "Search", seja este valor referente ao nome, idade ou código do aluno - Botão Consultar Aluno

        Dim referencia As String = Search.Text
        Dim command1 As New SqlCommand("select CodAluno, nome, idade from CadAlunos where Nome like  '%" & referencia & "%' or CodAluno like '" & referencia & "%' or Idade like '" & referencia & "%'", con)
        Dim sda1 As New SqlDataAdapter(command1)
        Dim dt1 As New DataTable
        sda1.Fill(dt1)
        dgvDados.DataSource = dt1

    End Sub


End Class
