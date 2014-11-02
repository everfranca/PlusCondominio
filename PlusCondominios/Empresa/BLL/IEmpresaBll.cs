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
	public interface IEmpresaBll
	{
		bool Salvar(EmpresaInfo empresa);
		bool Excluir(string emp_codigo);
		List<EmpresaInfo> ListarTodos();
		EmpresaInfo ListarPorCodigo(int emp_codigo);
	}
}