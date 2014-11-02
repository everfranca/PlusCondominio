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
	public interface IProprietarioTelefoneBll
	{
		bool Salvar(ProprietarioTelefoneInfo proprietariotelefone);
		bool Excluir(int pte_codigo);
		List<ProprietarioTelefoneInfo> ListarTodos();
		ProprietarioTelefoneInfo ListarPorCodigo(int pte_codigo);
	}
}