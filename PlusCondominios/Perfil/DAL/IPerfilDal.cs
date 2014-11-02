using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IPerfilDal
	{
		bool Inserir(PerfilInfo perfilInfo);
		bool Editar(PerfilInfo perfilInfo);
		bool Excluir(int prf_codigo);

		List<PerfilInfo> ListarTodos();

		PerfilInfo ListarPorCodigo(int prf_codigo);
	}
}