using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class AgendamentoBll : IAgendamentoBll
	{
		class Acessor
		{
			private IAgendamentoDal _AgendamentoDal;
			internal IAgendamentoDal AgendamentoDal
			{
				get
				{
					if (_AgendamentoDal == null)
					_AgendamentoDal = new AgendamentoDal();
				return _AgendamentoDal;
				}
				
			}
		}

		private bool ValidaAgendamento(AgendamentoInfo agendamentoInfo)
		{
			bool sucesso = true;
			try
			{
				if (agendamentoInfo == null)
					throw new Exception("Objeto AgendamentoInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(AgendamentoInfo agendamentoInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaAgendamento(agendamentoInfo))
					{
						if (agendamentoInfo.IsNew)
							sucesso = acessor.AgendamentoDal.Inserir(agendamentoInfo);
						else if (agendamentoInfo.IsDirty)
							sucesso = acessor.AgendamentoDal.Editar(agendamentoInfo);
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

		public bool Excluir(int age_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. AgendamentoDal.Excluir(age_codigo);
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

		public List<AgendamentoInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.AgendamentoDal.ListarTodos();
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

		public AgendamentoInfo ListarPorCodigo(int age_codigo)
		{
			Acessor acessor = new Acessor();
			AgendamentoInfo agendamentoInfo = new AgendamentoInfo();
			try
			{
				return agendamentoInfo = acessor.AgendamentoDal.ListarPorCodigo(age_codigo);
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