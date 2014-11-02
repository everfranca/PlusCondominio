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
	public interface IItemBll
	{
		bool Salvar(ItemInfo item);
		bool Excluir(int ite_codigo);
		List<ItemInfo> ListarTodos();
		ItemInfo ListarPorCodigo(int ite_codigo);
	}
}