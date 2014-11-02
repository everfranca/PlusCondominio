using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class ItemBll : IItemBll
	{
		class Acessor
		{
			private IItemDal _ItemDal;
			internal IItemDal ItemDal
			{
				get
				{
					if (_ItemDal == null)
					_ItemDal = new ItemDal();
				return _ItemDal;
				}
				
			}

		}

		private bool ValidaItem(ItemInfo itemInfo)
		{
			bool sucesso = true;
			try
			{
				if (itemInfo == null)
					throw new Exception("Objeto ItemInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(ItemInfo itemInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaItem(itemInfo))
					{
						if (itemInfo.IsNew)
							sucesso = acessor.ItemDal.Inserir(itemInfo);
						else if (itemInfo.IsDirty)
							sucesso = acessor.ItemDal.Editar(itemInfo);
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

		public bool Excluir(int ite_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. ItemDal.Excluir(ite_codigo);
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

		public List<ItemInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.ItemDal.ListarTodos();
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

		public ItemInfo ListarPorCodigo(int ite_codigo)
		{
			Acessor acessor = new Acessor();
			ItemInfo itemInfo = new ItemInfo();
			try
			{
				return itemInfo = acessor.ItemDal.ListarPorCodigo(ite_codigo);
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