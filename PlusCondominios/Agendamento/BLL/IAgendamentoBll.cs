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
	public interface IAgendamentoBll
	{
		bool Salvar(AgendamentoInfo agendamento);
		bool Excluir(int age_codigo);
		List<AgendamentoInfo> ListarTodos();
		AgendamentoInfo ListarPorCodigo(int age_codigo);
	}
}