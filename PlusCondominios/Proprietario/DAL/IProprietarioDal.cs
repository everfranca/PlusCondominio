using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IProprietarioDal
	{
		bool Inserir(ProprietarioInfo proprietarioInfo);
		bool Editar(ProprietarioInfo proprietarioInfo);
		bool Excluir(int prt_codigo);

        List<ProprietarioInfo> ListarPorParametro(ProprietarioInfo proprietarioInfo);

		ProprietarioInfo ListarPorCodigo(int prt_codigo);
	}
}