using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class AcessoProfissionalBll : IAcessoProfissionalBll
	{
		class Acessor
		{
			private IAcessoProfissionalDal _AcessoProfissionalDal;
			internal IAcessoProfissionalDal AcessoProfissionalDal
			{
				get
				{
					if (_AcessoProfissionalDal == null)
					_AcessoProfissionalDal = new AcessoProfissionalDal();
				return _AcessoProfissionalDal;
				}
				
			}
		}

		private bool ValidaAcessoProfissional(AcessoProfissionalInfo acessoprofissionalInfo)
		{
			bool sucesso = true;
			try
			{
				if (acessoprofissionalInfo == null)
					throw new Exception("Objeto AcessoProfissionalInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(AcessoProfissionalInfo acessoprofissionalInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaAcessoProfissional(acessoprofissionalInfo))
					{
						if (acessoprofissionalInfo.IsNew)
							sucesso = acessor.AcessoProfissionalDal.Inserir(acessoprofissionalInfo);
						else if (acessoprofissionalInfo.IsDirty)
							sucesso = acessor.AcessoProfissionalDal.Editar(acessoprofissionalInfo);
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

		public bool Excluir(int apr_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. AcessoProfissionalDal.Excluir(apr_codigo);
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

		public List<AcessoProfissionalInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.AcessoProfissionalDal.ListarTodos();
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

		public AcessoProfissionalInfo ListarPorCodigo(int apr_codigo)
		{
			Acessor acessor = new Acessor();
			AcessoProfissionalInfo acessoprofissionalInfo = new AcessoProfissionalInfo();
			try
			{
				return acessoprofissionalInfo = acessor.AcessoProfissionalDal.ListarPorCodigo(apr_codigo);
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