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
	public interface IResidenciaBll
	{
		bool Salvar(ResidenciaInfo residencia);
		bool Excluir(int res_codigo);
		List<ResidenciaInfo> ListarTodos();
		ResidenciaInfo ListarPorCodigo(int res_codigo);
	}
}