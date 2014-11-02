using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class EmpresaBll : IEmpresaBll
	{
		class Acessor
		{
			private IEmpresaDal _EmpresaDal;
			internal IEmpresaDal EmpresaDal
			{
				get
				{
					if (_EmpresaDal == null)
					_EmpresaDal = new EmpresaDal();
				return _EmpresaDal;
				}
				
			}
		}

		private bool ValidaEmpresa(EmpresaInfo empresaInfo)
		{
			bool sucesso = true;
			try
			{
				if (empresaInfo == null)
					throw new Exception("Objeto EmpresaInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(EmpresaInfo empresaInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaEmpresa(empresaInfo))
					{
						if (empresaInfo.IsNew)
							sucesso = acessor.EmpresaDal.Inserir(empresaInfo);
						else if (empresaInfo.IsDirty)
							sucesso = acessor.EmpresaDal.Editar(empresaInfo);
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

		public bool Excluir(string emp_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. EmpresaDal.Excluir(emp_codigo);
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

		public List<EmpresaInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.EmpresaDal.ListarTodos();
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

		public EmpresaInfo ListarPorCodigo(int emp_codigo)
		{
			Acessor acessor = new Acessor();
			EmpresaInfo empresaInfo = new EmpresaInfo();
			try
			{
				return empresaInfo = acessor.EmpresaDal.ListarPorCodigo(emp_codigo);
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