using PlusCondominios.Model;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlusCondominios.Model;
using PlusCondominios.Bll;

namespace PlusCondominios.Bll
{
	public interface ITipoAgendamentoBll
	{
		bool Salvar(TipoAgendamentoInfo tipoagendamento);
		bool Excluir(int tag_codigo);
		List<TipoAgendamentoInfo> ListarTodos();
		TipoAgendamentoInfo ListarPorCodigo(int tag_codigo);
	}
}