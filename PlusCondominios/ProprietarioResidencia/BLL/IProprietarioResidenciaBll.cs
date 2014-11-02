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
	public interface IProprietarioResidenciaBll
	{
		bool Salvar(ProprietarioResidenciaInfo proprietarioresidencia);
		bool Excluir(int pre_codigo);
		List<ProprietarioResidenciaInfo> ListarTodos();
		ProprietarioResidenciaInfo ListarPorCodigo(int pre_codigo);
	}
}