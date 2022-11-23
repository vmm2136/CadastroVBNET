Imports System.Data.SqlClient

Public Class Cadastro

    'Realiza a conexão com o BD
    Dim con As New SqlConnection(" Server = DESKTOP-FGL20RU\SQLEXPRESS01 ;Database=Alunos ;User Id= sa; Password=123;")

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click

        'Realiza o cadastro do aluno no BD

        Dim cod As Integer = CodAluno.Text
        Dim nomeAluno As String = Nome.Text
        Dim idadeAluno As Integer = Idade.Text
        Dim cidadeAluno As String = Cidade.Text
        Dim estadoAluno As String = Estado.Text
        Dim escolaridadeAluno As String = Escolaridade.Text

        con.Open()
        Dim command As New SqlCommand("insert into CadAlunos values('" & cod & "','" & nomeAluno & "' , '" & idadeAluno & "','" & cidadeAluno & "','" & estadoAluno & "','" & escolaridadeAluno & "' )", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Aluno Cadastrado Com Sucesso!")
        LoadDataInGrid()

    End Sub

    Private Sub LoadDataInGrid()

        'Exibe os dados ao lado do cadastro e os atualiza conforme as operações são realizadas

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

        'Busca os estados no BD para retorna-los na ComboBox "Escolar   idade"

        Dim command2 As New SqlCommand("select * from Escolaridade", con)
        Dim adapter2 As New SqlDataAdapter(command2)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        Escolaridade.DataSource = table2
        Escolaridade.DisplayMember = "Escolaridade"
        Escolaridade.ValueMember = "Id"


    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click

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
        MessageBox.Show("Aluno Alterado Com Sucesso!")
        LoadDataInGrid()

    End Sub


    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        'Realiza a exclusão do cadastro específicado pelo Código do aluno
        Dim cod As Integer = CodAluno.Text.ToString
        Dim takeName As New SqlCommand("Select Nome From CadAlunos where CodAluno = '" & cod & "'", con)

        con.Open()

        Dim nomeAluno As String = takeName.ExecuteScalar().ToString()


        If MessageBox.Show("Tem Certeza que deseja excluir o aluno '" & cod & "-" & nomeAluno & "' ", "Excluir Aluno", MessageBoxButtons.YesNo) = DialogResult.Yes Then



            Dim command As New SqlCommand("delete CadAlunos where  CodAluno = '" & cod & "'", con)
            command.ExecuteNonQuery()
            MessageBox.Show("Aluno Excluído Com Sucesso!")
            con.Close()
            LoadDataInGrid()

        End If


        con.Close()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click

        Dim referencia As String = Search.Text
        Dim command1 As New SqlCommand("select CodAluno, nome, idade from CadAlunos where Nome like  '%" & referencia & "%' or CodAluno like '%" & referencia & "%' or Idade like '%" & referencia & "%'", con)
        Dim sda1 As New SqlDataAdapter(command1)
        Dim dt1 As New DataTable
        sda1.Fill(dt1)
        dgvDados.DataSource = dt1




    End Sub
End Class
