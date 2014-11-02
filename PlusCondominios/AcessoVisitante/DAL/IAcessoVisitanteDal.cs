using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IAcessoVisitanteDal
	{
		bool Inserir(AcessoVisitanteInfo acessovisitanteInfo);
		bool Editar(AcessoVisitanteInfo acessovisitanteInfo);
		bool Excluir(int avi_codigo);

		List<AcessoVisitanteInfo> ListarTodos();

		AcessoVisitanteInfo ListarPorCodigo(int avi_codigo);
	}
}