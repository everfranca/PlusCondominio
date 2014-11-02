using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IEmpresaDal
	{
		bool Inserir(EmpresaInfo empresaInfo);
		bool Editar(EmpresaInfo empresaInfo);
		bool Excluir(string emp_codigo);

		List<EmpresaInfo> ListarTodos();

		EmpresaInfo ListarPorCodigo(int emp_codigo);
	}
}