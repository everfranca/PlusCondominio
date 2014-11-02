using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface ITipoEntregaDal
	{
		bool Inserir(TipoEntregaInfo tipoentregaInfo);
		bool Editar(TipoEntregaInfo tipoentregaInfo);
		bool Excluir(int ten_codigo);

		List<TipoEntregaInfo> ListarTodos();

		TipoEntregaInfo ListarPorCodigo(int ten_codigo);
	}
}