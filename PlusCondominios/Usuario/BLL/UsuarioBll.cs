using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class UsuarioBll : IUsuarioBll
	{
		class Acessor
		{
			private IUsuarioDal _UsuarioDal;
			internal IUsuarioDal UsuarioDal
			{
				get
				{
					if (_UsuarioDal == null)
					_UsuarioDal = new UsuarioDal();
				return _UsuarioDal;
				}
				
			}
		}

		private bool ValidaUsuario(UsuarioInfo usuarioInfo)
		{
			bool sucesso = true;
			try
			{
				if (usuarioInfo == null)
					throw new Exception("Objeto UsuarioInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(UsuarioInfo usuarioInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaUsuario(usuarioInfo))
					{
						if (usuarioInfo.IsNew)
							sucesso = acessor.UsuarioDal.Inserir(usuarioInfo);
						else if (usuarioInfo.IsDirty)
							sucesso = acessor.UsuarioDal.Editar(usuarioInfo);
					}
					transacao.Complete();
				}
				return sucesso;
			}
			catch (Exception exc)
			{
				throw new Exception(exc.Message, exc);
			}
			finally
			{
				acessor = null;
			
			}
		}

		public bool Excluir(int usu_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. UsuarioDal.Excluir(usu_codigo);
			}
			catch (Exception exc)
			{
				throw new Exception(exc.Message, exc);
			}
			finally
			{
				acessor = null;
			}
		}

		public List<UsuarioInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.UsuarioDal.ListarTodos();
			}
			catch (Exception exc)
			{
				throw new Exception(exc.Message, exc);
			}
			finally
			{
				acessor = null;
			}
		}

		public UsuarioInfo ListarPorCodigo(int usu_codigo)
		{
			Acessor acessor = new Acessor();
			UsuarioInfo usuarioInfo = new UsuarioInfo();
			try
			{
				return usuarioInfo = acessor.UsuarioDal.ListarPorCodigo(usu_codigo);
			}
			catch (Exception exc)
			{
				throw new Exception(exc.Message, exc);
			}
			finally
			{
				acessor = null;
			}
		}
	}
}