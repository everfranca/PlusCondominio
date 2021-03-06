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
        List<PerfilInfo> ListarPerfilPorNome(string prf_nome);

		PerfilInfo ListarPorCodigo(int prf_codigo);
	}
}