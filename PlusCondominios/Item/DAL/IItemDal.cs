using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IItemDal
	{
		bool Inserir(ItemInfo itemInfo);
		bool Editar(ItemInfo itemInfo);
		bool Excluir(int ite_codigo);

		List<ItemInfo> ListarTodos();

		ItemInfo ListarPorCodigo(int ite_codigo);
	}
}