using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class ResidenciaBll : IResidenciaBll
	{
		class Acessor
		{
			private IResidenciaDal _ResidenciaDal;
			internal IResidenciaDal ResidenciaDal
			{
				get
				{
					if (_ResidenciaDal == null)
					_ResidenciaDal = new ResidenciaDal();
				return _ResidenciaDal;
				}
				
			}
		}

		private bool ValidaResidencia(ResidenciaInfo residenciaInfo)
		{
			bool sucesso = true;
			try
			{
				if (residenciaInfo == null)
					throw new Exception("Objeto ResidenciaInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(ResidenciaInfo residenciaInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaResidencia(residenciaInfo))
					{
						if (residenciaInfo.IsNew)
							sucesso = acessor.ResidenciaDal.Inserir(residenciaInfo);
						else if (residenciaInfo.IsDirty)
							sucesso = acessor.ResidenciaDal.Editar(residenciaInfo);
						
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

		public bool Excluir(int res_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. ResidenciaDal.Excluir(res_codigo);
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

		public List<ResidenciaInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.ResidenciaDal.ListarTodos();
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

		public ResidenciaInfo ListarPorCodigo(int res_codigo)
		{
			Acessor acessor = new Acessor();
			ResidenciaInfo residenciaInfo = new ResidenciaInfo();
			try
			{
				return residenciaInfo = acessor.ResidenciaDal.ListarPorCodigo(res_codigo);
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