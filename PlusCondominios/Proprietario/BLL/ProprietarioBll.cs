using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class ProprietarioBll : IProprietarioBll
	{
		class Acessor
		{
			private IProprietarioDal _ProprietarioDal;
			internal IProprietarioDal ProprietarioDal
			{
				get
				{
					if (_ProprietarioDal == null)
					_ProprietarioDal = new ProprietarioDal();
				return _ProprietarioDal;
				}
				
			}

			private IAgendamentoBll _IAgendamentoBll;
			internal IAgendamentoBll AgendamentoBll
			{
				get
				{
					if(_IAgendamentoBll == null)
						_IAgendamentoBll = new AgendamentoBll();
					return _IAgendamentoBll;
				}
			}

			
		}

		private bool ValidaProprietario(ProprietarioInfo proprietarioInfo)
		{
			bool sucesso = true;
			try
			{
				if (proprietarioInfo == null)
					throw new Exception("Objeto ProprietarioInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(ProprietarioInfo proprietarioInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaProprietario(proprietarioInfo))
					{
						if (proprietarioInfo.IsNew)
							sucesso = acessor.ProprietarioDal.Inserir(proprietarioInfo);
						else if (proprietarioInfo.IsDirty)
							sucesso = acessor.ProprietarioDal.Editar(proprietarioInfo);
						
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

		public bool Excluir(int prt_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. ProprietarioDal.Excluir(prt_codigo);
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

		public List<ProprietarioInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.ProprietarioDal.ListarTodos();
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

		public ProprietarioInfo ListarPorCodigo(int prt_codigo)
		{
			Acessor acessor = new Acessor();
			ProprietarioInfo proprietarioInfo = new ProprietarioInfo();
			try
			{
				return proprietarioInfo = acessor.ProprietarioDal.ListarPorCodigo(prt_codigo);
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