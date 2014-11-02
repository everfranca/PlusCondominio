using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class VisitanteBll : IVisitanteBll
	{
		class Acessor
		{
			private IVisitanteDal _VisitanteDal;
			internal IVisitanteDal VisitanteDal
			{
				get
				{
					if (_VisitanteDal == null)
					_VisitanteDal = new VisitanteDal();
				return _VisitanteDal;
				}
				
			}
		}

		private bool ValidaVisitante(VisitanteInfo visitanteInfo)
		{
			bool sucesso = true;
			try
			{
				if (visitanteInfo == null)
					throw new Exception("Objeto VisitanteInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(VisitanteInfo visitanteInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaVisitante(visitanteInfo))
					{
						if (visitanteInfo.IsNew)
							sucesso = acessor.VisitanteDal.Inserir(visitanteInfo);
						else if (visitanteInfo.IsDirty)
							sucesso = acessor.VisitanteDal.Editar(visitanteInfo);
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

		public bool Excluir(int vis_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. VisitanteDal.Excluir(vis_codigo);
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

		public List<VisitanteInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.VisitanteDal.ListarTodos();
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

		public VisitanteInfo ListarPorCodigo(int vis_codigo)
		{
			Acessor acessor = new Acessor();
			VisitanteInfo visitanteInfo = new VisitanteInfo();
			try
			{
				return visitanteInfo = acessor.VisitanteDal.ListarPorCodigo(vis_codigo);
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