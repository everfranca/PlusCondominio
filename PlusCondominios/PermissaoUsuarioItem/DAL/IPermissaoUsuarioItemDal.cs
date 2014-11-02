using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IPermissaoUsuarioItemDal
	{
		bool Inserir(PermissaoUsuarioItemInfo permissaousuarioitemInfo);
		bool Editar(PermissaoUsuarioItemInfo permissaousuarioitemInfo);
		bool Excluir(int per_codigo);

		List<PermissaoUsuarioItemInfo> ListarTodos();

		PermissaoUsuarioItemInfo ListarPorCodigo(int per_codigo);
	}
}