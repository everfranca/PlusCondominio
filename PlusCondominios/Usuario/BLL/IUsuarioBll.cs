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
	public interface IUsuarioBll
	{
		bool Salvar(UsuarioInfo usuario);
		bool Excluir(int usu_codigo);
		List<UsuarioInfo> ListarTodos();
		UsuarioInfo ListarPorCodigo(int usu_codigo);
        UsuarioInfo ListarUsuario(string usu_login);
	}
}