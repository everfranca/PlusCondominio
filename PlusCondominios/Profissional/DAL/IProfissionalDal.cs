using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IProfissionalDal
	{
		bool Inserir(ProfissionalInfo profissionalInfo);
		bool Editar(ProfissionalInfo profissionalInfo);
		bool Excluir(int pro_codigo);

		List<ProfissionalInfo> ListarTodos();

		ProfissionalInfo ListarPorCodigo(int pro_codigo);
	}
}