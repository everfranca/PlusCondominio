using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class TipoEntregaBll : ITipoEntregaBll
	{
		class Acessor
		{
			private ITipoEntregaDal _TipoEntregaDal;
			internal ITipoEntregaDal TipoEntregaDal
			{
				get
				{
					if (_TipoEntregaDal == null)
					_TipoEntregaDal = new TipoEntregaDal();
				return _TipoEntregaDal;
				}
				
			}
		}

		private bool ValidaTipoEntrega(TipoEntregaInfo tipoentregaInfo)
		{
			bool sucesso = true;
			try
			{
				if (tipoentregaInfo == null)
					throw new Exception("Objeto TipoEntregaInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(TipoEntregaInfo tipoentregaInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaTipoEntrega(tipoentregaInfo))
					{
						if (tipoentregaInfo.IsNew)
							sucesso = acessor.TipoEntregaDal.Inserir(tipoentregaInfo);
						else if (tipoentregaInfo.IsDirty)
							sucesso = acessor.TipoEntregaDal.Editar(tipoentregaInfo);
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

		public bool Excluir(int ten_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. TipoEntregaDal.Excluir(ten_codigo);
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

		public List<TipoEntregaInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.TipoEntregaDal.ListarTodos();
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

		public TipoEntregaInfo ListarPorCodigo(int ten_codigo)
		{
			Acessor acessor = new Acessor();
			TipoEntregaInfo tipoentregaInfo = new TipoEntregaInfo();
			try
			{
				return tipoentregaInfo = acessor.TipoEntregaDal.ListarPorCodigo(ten_codigo);
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