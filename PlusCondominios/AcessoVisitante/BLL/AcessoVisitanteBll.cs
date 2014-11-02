using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class AcessoVisitanteBll : IAcessoVisitanteBll
	{
		class Acessor
		{
			private IAcessoVisitanteDal _AcessoVisitanteDal;
			internal IAcessoVisitanteDal AcessoVisitanteDal
			{
				get
				{
					if (_AcessoVisitanteDal == null)
					_AcessoVisitanteDal = new AcessoVisitanteDal();
				return _AcessoVisitanteDal;
				}
				
			}
		}

		private bool ValidaAcessoVisitante(AcessoVisitanteInfo acessovisitanteInfo)
		{
			bool sucesso = true;
			try
			{
				if (acessovisitanteInfo == null)
					throw new Exception("Objeto AcessoVisitanteInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(AcessoVisitanteInfo acessovisitanteInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaAcessoVisitante(acessovisitanteInfo))
					{
						if (acessovisitanteInfo.IsNew)
							sucesso = acessor.AcessoVisitanteDal.Inserir(acessovisitanteInfo);
						else if (acessovisitanteInfo.IsDirty)
							sucesso = acessor.AcessoVisitanteDal.Editar(acessovisitanteInfo);
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

		public bool Excluir(int avi_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. AcessoVisitanteDal.Excluir(avi_codigo);
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

		public List<AcessoVisitanteInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.AcessoVisitanteDal.ListarTodos();
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

		public AcessoVisitanteInfo ListarPorCodigo(int avi_codigo)
		{
			Acessor acessor = new Acessor();
			AcessoVisitanteInfo acessovisitanteInfo = new AcessoVisitanteInfo();
			try
			{
				return acessovisitanteInfo = acessor.AcessoVisitanteDal.ListarPorCodigo(avi_codigo);
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