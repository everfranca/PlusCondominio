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
	public interface IPermissaoUsuarioItemBll
	{
		bool Salvar(PermissaoUsuarioItemInfo permissaousuarioitem);
		bool Excluir(int per_codigo);
		List<PermissaoUsuarioItemInfo> ListarTodos();
		PermissaoUsuarioItemInfo ListarPorCodigo(int per_codigo);
	}
}