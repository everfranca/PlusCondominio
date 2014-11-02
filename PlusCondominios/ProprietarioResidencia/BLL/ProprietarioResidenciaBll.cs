using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class ProprietarioResidenciaBll : IProprietarioResidenciaBll
	{
		class Acessor
		{
			private IProprietarioResidenciaDal _ProprietarioResidenciaDal;
			internal IProprietarioResidenciaDal ProprietarioResidenciaDal
			{
				get
				{
					if (_ProprietarioResidenciaDal == null)
					_ProprietarioResidenciaDal = new ProprietarioResidenciaDal();
				return _ProprietarioResidenciaDal;
				}
				
			}
		}

		private bool ValidaProprietarioResidencia(ProprietarioResidenciaInfo proprietarioresidenciaInfo)
		{
			bool sucesso = true;
			try
			{
				if (proprietarioresidenciaInfo == null)
					throw new Exception("Objeto ProprietarioResidenciaInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(ProprietarioResidenciaInfo proprietarioresidenciaInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaProprietarioResidencia(proprietarioresidenciaInfo))
					{
						if (proprietarioresidenciaInfo.IsNew)
							sucesso = acessor.ProprietarioResidenciaDal.Inserir(proprietarioresidenciaInfo);
						else if (proprietarioresidenciaInfo.IsDirty)
							sucesso = acessor.ProprietarioResidenciaDal.Editar(proprietarioresidenciaInfo);
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

		public bool Excluir(int pre_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. ProprietarioResidenciaDal.Excluir(pre_codigo);
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

		public List<ProprietarioResidenciaInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.ProprietarioResidenciaDal.ListarTodos();
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

		public ProprietarioResidenciaInfo ListarPorCodigo(int pre_codigo)
		{
			Acessor acessor = new Acessor();
			ProprietarioResidenciaInfo proprietarioresidenciaInfo = new ProprietarioResidenciaInfo();
			try
			{
				return proprietarioresidenciaInfo = acessor.ProprietarioResidenciaDal.ListarPorCodigo(pre_codigo);
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