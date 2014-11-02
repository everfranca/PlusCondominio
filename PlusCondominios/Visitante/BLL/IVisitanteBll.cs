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
	public interface IVisitanteBll
	{
		bool Salvar(VisitanteInfo visitante);
		bool Excluir(int vis_codigo);
		List<VisitanteInfo> ListarTodos();
		VisitanteInfo ListarPorCodigo(int vis_codigo);
	}
}