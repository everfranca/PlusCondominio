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
	public interface ITipoEntregaBll
	{
		bool Salvar(TipoEntregaInfo tipoentrega);
		bool Excluir(int ten_codigo);
		List<TipoEntregaInfo> ListarTodos();
		TipoEntregaInfo ListarPorCodigo(int ten_codigo);
	}
}