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
	public interface IAcessoProfissionalBll
	{
		bool Salvar(AcessoProfissionalInfo acessoprofissional);
		bool Excluir(int apr_codigo);
		List<AcessoProfissionalInfo> ListarTodos();
		AcessoProfissionalInfo ListarPorCodigo(int apr_codigo);
	}
}