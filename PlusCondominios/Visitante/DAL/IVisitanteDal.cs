using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IVisitanteDal
	{
		bool Inserir(VisitanteInfo visitanteInfo);
		bool Editar(VisitanteInfo visitanteInfo);
		bool Excluir(int vis_codigo);

		List<VisitanteInfo> ListarTodos();

		VisitanteInfo ListarPorCodigo(int vis_codigo);
	}
}