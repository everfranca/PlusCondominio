using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IProprietarioTelefoneDal
	{
		bool Inserir(ProprietarioTelefoneInfo proprietariotelefoneInfo);
		bool Editar(ProprietarioTelefoneInfo proprietariotelefoneInfo);
		bool Excluir(int pte_codigo);

		List<ProprietarioTelefoneInfo> ListarTodos();

		ProprietarioTelefoneInfo ListarPorCodigo(int pte_codigo);
	}
}