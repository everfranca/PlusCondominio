using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IAcessoProfissionalDal
	{
		bool Inserir(AcessoProfissionalInfo acessoprofissionalInfo);
		bool Editar(AcessoProfissionalInfo acessoprofissionalInfo);
		bool Excluir(int apr_codigo);

		List<AcessoProfissionalInfo> ListarTodos();

		AcessoProfissionalInfo ListarPorCodigo(int apr_codigo);
	}
}