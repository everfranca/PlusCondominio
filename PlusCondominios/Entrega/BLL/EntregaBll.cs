using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class EntregaBll : IEntregaBll
	{
		class Acessor
		{
			private IEntregaDal _EntregaDal;
			internal IEntregaDal EntregaDal
			{
				get
				{
					if (_EntregaDal == null)
					_EntregaDal = new EntregaDal();
				return _EntregaDal;
				}
				
			}
		}

		private bool ValidaEntrega(EntregaInfo entregaInfo)
		{
			bool sucesso = true;
			try
			{
				if (entregaInfo == null)
					throw new Exception("Objeto EntregaInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(EntregaInfo entregaInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaEntrega(entregaInfo))
					{
						if (entregaInfo.IsNew)
							sucesso = acessor.EntregaDal.Inserir(entregaInfo);
						else if (entregaInfo.IsDirty)
							sucesso = acessor.EntregaDal.Editar(entregaInfo);
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

		public bool Excluir(int ent_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. EntregaDal.Excluir(ent_codigo);
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

		public List<EntregaInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.EntregaDal.ListarTodos();
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

		public EntregaInfo ListarPorCodigo(int ent_codigo)
		{
			Acessor acessor = new Acessor();
			EntregaInfo entregaInfo = new EntregaInfo();
			try
			{
				return entregaInfo = acessor.EntregaDal.ListarPorCodigo(ent_codigo);
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