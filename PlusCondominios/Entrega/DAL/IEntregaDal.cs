using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IEntregaDal
	{
		bool Inserir(EntregaInfo entregaInfo);
		bool Editar(EntregaInfo entregaInfo);
		bool Excluir(int ent_codigo);

		List<EntregaInfo> ListarTodos();

		EntregaInfo ListarPorCodigo(int ent_codigo);
	}
}