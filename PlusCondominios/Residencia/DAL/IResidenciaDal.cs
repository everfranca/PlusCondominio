using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IResidenciaDal
	{
		bool Inserir(ResidenciaInfo residenciaInfo);
		bool Editar(ResidenciaInfo residenciaInfo);
		bool Excluir(int res_codigo);

		List<ResidenciaInfo> ListarTodos();

		ResidenciaInfo ListarPorCodigo(int res_codigo);
	}
}