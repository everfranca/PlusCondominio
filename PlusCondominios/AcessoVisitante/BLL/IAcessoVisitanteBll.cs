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
	public interface IAcessoVisitanteBll
	{
		bool Salvar(AcessoVisitanteInfo acessovisitante);
		bool Excluir(int avi_codigo);
		List<AcessoVisitanteInfo> ListarTodos();
		AcessoVisitanteInfo ListarPorCodigo(int avi_codigo);
	}
}