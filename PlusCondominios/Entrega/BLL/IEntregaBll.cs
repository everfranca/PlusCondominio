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
	public interface IEntregaBll
	{
		bool Salvar(EntregaInfo entrega);
		bool Excluir(int ent_codigo);
		List<EntregaInfo> ListarTodos();
		EntregaInfo ListarPorCodigo(int ent_codigo);
	}
}