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
	public interface IProprietarioBll
	{
		bool Salvar(ProprietarioInfo proprietario);
		bool Excluir(int prt_codigo);
        List<ProprietarioInfo> ListarPorParametro(ProprietarioInfo proprietarioInfo);
		ProprietarioInfo ListarPorCodigo(int prt_codigo);
	}
}