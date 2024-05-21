using System;
using FIAP_PrimeiraAPI.Models;

namespace FIAP_PrimeiraAPI.Interfaces
{
	public interface IAlunoCadastro
	{
		IList<Aluno> ListaAluno { get; set; }

		//Contratos que serão utlizados na nossa implementação
		public IEnumerable<Aluno> ListaAlunos();
		public Aluno CriarAluno(Aluno dadosAluno);
		public void AtualizarAluno(Aluno dadosAluno);
		public void DeleterAluno(Aluno Id);
	}
}

