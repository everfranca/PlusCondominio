using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IProprietarioResidenciaDal
	{
		bool Inserir(ProprietarioResidenciaInfo proprietarioresidenciaInfo);
		bool Editar(ProprietarioResidenciaInfo proprietarioresidenciaInfo);
		bool Excluir(int pre_codigo);

		List<ProprietarioResidenciaInfo> ListarTodos();

		ProprietarioResidenciaInfo ListarPorCodigo(int pre_codigo);
	}
}