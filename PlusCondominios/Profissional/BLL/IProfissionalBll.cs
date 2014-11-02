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
	public interface IProfissionalBll
	{
		bool Salvar(ProfissionalInfo profissional);
		bool Excluir(int pro_codigo);
		List<ProfissionalInfo> ListarTodos();
		ProfissionalInfo ListarPorCodigo(int pro_codigo);
	}
}