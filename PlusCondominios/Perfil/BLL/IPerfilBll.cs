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
	public interface IPerfilBll
	{
		bool Salvar(PerfilInfo perfil);
		bool Excluir(int prf_codigo);
		List<PerfilInfo> ListarTodos();
		PerfilInfo ListarPorCodigo(int prf_codigo);
        List<PerfilInfo> ListarPerfilPorNome(string prf_nome);
	}
}