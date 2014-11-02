using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class PerfilBll : IPerfilBll
	{
		class Acessor
		{
			private IPerfilDal _PerfilDal;
			internal IPerfilDal PerfilDal
			{
				get
				{
					if (_PerfilDal == null)
					_PerfilDal = new PerfilDal();
				return _PerfilDal;
				}
				
			}

		}

		private bool ValidaPerfil(PerfilInfo perfilInfo)
		{
			bool sucesso = true;
			try
			{
				if (perfilInfo == null)
					throw new Exception("Objeto PerfilInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(PerfilInfo perfilInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaPerfil(perfilInfo))
					{
						if (perfilInfo.IsNew)
							sucesso = acessor.PerfilDal.Inserir(perfilInfo);
						else if (perfilInfo.IsDirty)
							sucesso = acessor.PerfilDal.Editar(perfilInfo);
						
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

		public bool Excluir(int prf_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. PerfilDal.Excluir(prf_codigo);
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

		public List<PerfilInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.PerfilDal.ListarTodos();
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

		public PerfilInfo ListarPorCodigo(int prf_codigo)
		{
			Acessor acessor = new Acessor();
			PerfilInfo perfilInfo = new PerfilInfo();
			try
			{
				return perfilInfo = acessor.PerfilDal.ListarPorCodigo(prf_codigo);
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