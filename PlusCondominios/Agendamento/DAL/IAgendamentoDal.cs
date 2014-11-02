using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IAgendamentoDal
	{
		bool Inserir(AgendamentoInfo agendamentoInfo);
		bool Editar(AgendamentoInfo agendamentoInfo);
		bool Excluir(int age_codigo);

		List<AgendamentoInfo> ListarTodos();

		AgendamentoInfo ListarPorCodigo(int age_codigo);
	}
}