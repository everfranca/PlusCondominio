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
	public interface IProprietarioVeiculoBll
	{
		bool Salvar(ProprietarioVeiculoInfo proprietarioveiculo);
		bool Excluir(int pve_codigo);
		List<ProprietarioVeiculoInfo> ListarTodos();
		ProprietarioVeiculoInfo ListarPorCodigo(int pve_codigo);
	}
}