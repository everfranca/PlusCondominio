using System.Collections.Generic;
using PlusCondominios.Model;

namespace PlusCondominios.Dal
{
	public interface IUsuarioDal
	{
		bool Inserir(UsuarioInfo usuarioInfo);
		bool Editar(UsuarioInfo usuarioInfo);
		bool Excluir(int usu_codigo);

		List<UsuarioInfo> ListarTodos();

		UsuarioInfo ListarPorCodigo(int usu_codigo);
        UsuarioInfo ListarUsuario(string usu_login);
	}
}