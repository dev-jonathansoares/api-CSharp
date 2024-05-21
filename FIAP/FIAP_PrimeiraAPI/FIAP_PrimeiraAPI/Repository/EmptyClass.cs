using FIAP_PrimeiraAPI.Interfaces;
using FIAP_PrimeiraAPI.Models;

internal class AlunoRepository : IAlunoCadastro
{
    public IList<Aluno> ListaAluno { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void AtualizarAluno(Aluno dadosAluno)
    {
        throw new NotImplementedException();
    }

    public Aluno CriarAluno(Aluno dadosAluno)
    {
        throw new NotImplementedException();
    }

    public void DeleterAluno(Aluno Id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Aluno> ListaAlunos()
    {
        throw new NotImplementedException();
    }
}