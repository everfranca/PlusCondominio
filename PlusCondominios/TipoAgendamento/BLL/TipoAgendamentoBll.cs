using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class TipoAgendamentoBll : ITipoAgendamentoBll
	{
		class Acessor
		{
			private ITipoAgendamentoDal _TipoAgendamentoDal;
			internal ITipoAgendamentoDal TipoAgendamentoDal
			{
				get
				{
					if (_TipoAgendamentoDal == null)
					_TipoAgendamentoDal = new TipoAgendamentoDal();
				return _TipoAgendamentoDal;
				}
				
			}
		}

		private bool ValidaTipoAgendamento(TipoAgendamentoInfo tipoagendamentoInfo)
		{
			bool sucesso = true;
			try
			{
				if (tipoagendamentoInfo == null)
					throw new Exception("Objeto TipoAgendamentoInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(TipoAgendamentoInfo tipoagendamentoInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaTipoAgendamento(tipoagendamentoInfo))
					{
						if (tipoagendamentoInfo.IsNew)
							sucesso = acessor.TipoAgendamentoDal.Inserir(tipoagendamentoInfo);
						else if (tipoagendamentoInfo.IsDirty)
							sucesso = acessor.TipoAgendamentoDal.Editar(tipoagendamentoInfo);
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

		public bool Excluir(int tag_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. TipoAgendamentoDal.Excluir(tag_codigo);
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

		public List<TipoAgendamentoInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.TipoAgendamentoDal.ListarTodos();
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

		public TipoAgendamentoInfo ListarPorCodigo(int tag_codigo)
		{
			Acessor acessor = new Acessor();
			TipoAgendamentoInfo tipoagendamentoInfo = new TipoAgendamentoInfo();
			try
			{
				return tipoagendamentoInfo = acessor.TipoAgendamentoDal.ListarPorCodigo(tag_codigo);
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