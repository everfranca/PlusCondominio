using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IProprietarioVeiculoDal
	{
		bool Inserir(ProprietarioVeiculoInfo proprietarioveiculoInfo);
		bool Editar(ProprietarioVeiculoInfo proprietarioveiculoInfo);
		bool Excluir(int pve_codigo);

		List<ProprietarioVeiculoInfo> ListarTodos();

		ProprietarioVeiculoInfo ListarPorCodigo(int pve_codigo);
	}
}