using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class ProprietarioTelefoneBll : IProprietarioTelefoneBll
	{
		class Acessor
		{
			private IProprietarioTelefoneDal _ProprietarioTelefoneDal;
			internal IProprietarioTelefoneDal ProprietarioTelefoneDal
			{
				get
				{
					if (_ProprietarioTelefoneDal == null)
					_ProprietarioTelefoneDal = new ProprietarioTelefoneDal();
				return _ProprietarioTelefoneDal;
				}
				
			}
		}

		private bool ValidaProprietarioTelefone(ProprietarioTelefoneInfo proprietariotelefoneInfo)
		{
			bool sucesso = true;
			try
			{
				if (proprietariotelefoneInfo == null)
					throw new Exception("Objeto ProprietarioTelefoneInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(ProprietarioTelefoneInfo proprietariotelefoneInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaProprietarioTelefone(proprietariotelefoneInfo))
					{
						if (proprietariotelefoneInfo.IsNew)
							sucesso = acessor.ProprietarioTelefoneDal.Inserir(proprietariotelefoneInfo);
						else if (proprietariotelefoneInfo.IsDirty)
							sucesso = acessor.ProprietarioTelefoneDal.Editar(proprietariotelefoneInfo);
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

		public bool Excluir(int pte_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. ProprietarioTelefoneDal.Excluir(pte_codigo);
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

		public List<ProprietarioTelefoneInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.ProprietarioTelefoneDal.ListarTodos();
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

		public ProprietarioTelefoneInfo ListarPorCodigo(int pte_codigo)
		{
			Acessor acessor = new Acessor();
			ProprietarioTelefoneInfo proprietariotelefoneInfo = new ProprietarioTelefoneInfo();
			try
			{
				return proprietariotelefoneInfo = acessor.ProprietarioTelefoneDal.ListarPorCodigo(pte_codigo);
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