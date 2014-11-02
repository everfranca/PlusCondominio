using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class PermissaoUsuarioItemBll : IPermissaoUsuarioItemBll
	{
		class Acessor
		{
			private IPermissaoUsuarioItemDal _PermissaoUsuarioItemDal;
			internal IPermissaoUsuarioItemDal PermissaoUsuarioItemDal
			{
				get
				{
					if (_PermissaoUsuarioItemDal == null)
					_PermissaoUsuarioItemDal = new PermissaoUsuarioItemDal();
				return _PermissaoUsuarioItemDal;
				}
				
			}
		}

		private bool ValidaPermissaoUsuarioItem(PermissaoUsuarioItemInfo permissaousuarioitemInfo)
		{
			bool sucesso = true;
			try
			{
				if (permissaousuarioitemInfo == null)
					throw new Exception("Objeto PermissaoUsuarioItemInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(PermissaoUsuarioItemInfo permissaousuarioitemInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaPermissaoUsuarioItem(permissaousuarioitemInfo))
					{
						if (permissaousuarioitemInfo.IsNew)
							sucesso = acessor.PermissaoUsuarioItemDal.Inserir(permissaousuarioitemInfo);
						else if (permissaousuarioitemInfo.IsDirty)
							sucesso = acessor.PermissaoUsuarioItemDal.Editar(permissaousuarioitemInfo);
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

		public bool Excluir(int per_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. PermissaoUsuarioItemDal.Excluir(per_codigo);
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

		public List<PermissaoUsuarioItemInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.PermissaoUsuarioItemDal.ListarTodos();
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

		public PermissaoUsuarioItemInfo ListarPorCodigo(int per_codigo)
		{
			Acessor acessor = new Acessor();
			PermissaoUsuarioItemInfo permissaousuarioitemInfo = new PermissaoUsuarioItemInfo();
			try
			{
				return permissaousuarioitemInfo = acessor.PermissaoUsuarioItemDal.ListarPorCodigo(per_codigo);
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