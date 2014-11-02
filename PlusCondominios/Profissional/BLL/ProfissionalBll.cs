using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class ProfissionalBll : IProfissionalBll
	{
		class Acessor
		{
			private IProfissionalDal _ProfissionalDal;
			internal IProfissionalDal ProfissionalDal
			{
				get
				{
					if (_ProfissionalDal == null)
					_ProfissionalDal = new ProfissionalDal();
				return _ProfissionalDal;
				}
				
			}
		}

		private bool ValidaProfissional(ProfissionalInfo profissionalInfo)
		{
			bool sucesso = true;
			try
			{
				if (profissionalInfo == null)
					throw new Exception("Objeto ProfissionalInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(ProfissionalInfo profissionalInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaProfissional(profissionalInfo))
					{
						if (profissionalInfo.IsNew)
							sucesso = acessor.ProfissionalDal.Inserir(profissionalInfo);
						else if (profissionalInfo.IsDirty)
							sucesso = acessor.ProfissionalDal.Editar(profissionalInfo);
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

		public bool Excluir(int pro_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. ProfissionalDal.Excluir(pro_codigo);
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

		public List<ProfissionalInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.ProfissionalDal.ListarTodos();
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

		public ProfissionalInfo ListarPorCodigo(int pro_codigo)
		{
			Acessor acessor = new Acessor();
			ProfissionalInfo profissionalInfo = new ProfissionalInfo();
			try
			{
				return profissionalInfo = acessor.ProfissionalDal.ListarPorCodigo(pro_codigo);
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