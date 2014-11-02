using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface ITipoAgendamentoDal
	{
		bool Inserir(TipoAgendamentoInfo tipoagendamentoInfo);
		bool Editar(TipoAgendamentoInfo tipoagendamentoInfo);
		bool Excluir(int tag_codigo);

		List<TipoAgendamentoInfo> ListarTodos();

		TipoAgendamentoInfo ListarPorCodigo(int tag_codigo);
	}
}