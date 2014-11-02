using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
	public class ProprietarioVeiculoBll : IProprietarioVeiculoBll
	{
		class Acessor
		{
			private IProprietarioVeiculoDal _ProprietarioVeiculoDal;
			internal IProprietarioVeiculoDal ProprietarioVeiculoDal
			{
				get
				{
					if (_ProprietarioVeiculoDal == null)
					_ProprietarioVeiculoDal = new ProprietarioVeiculoDal();
				return _ProprietarioVeiculoDal;
				}
				
			}
		}

		private bool ValidaProprietarioVeiculo(ProprietarioVeiculoInfo proprietarioveiculoInfo)
		{
			bool sucesso = true;
			try
			{
				if (proprietarioveiculoInfo == null)
					throw new Exception("Objeto ProprietarioVeiculoInfo é nulo");
			}
			catch
			{
				sucesso = false;
			}
			return sucesso;
		}
		public bool Salvar(ProprietarioVeiculoInfo proprietarioveiculoInfo)
		{
			Acessor acessor = new Acessor();
			bool sucesso = true;
			try
			{
				using (TransactionScope transacao = new TransactionScope())
				{
					if (ValidaProprietarioVeiculo(proprietarioveiculoInfo))
					{
						if (proprietarioveiculoInfo.IsNew)
							sucesso = acessor.ProprietarioVeiculoDal.Inserir(proprietarioveiculoInfo);
						else if (proprietarioveiculoInfo.IsDirty)
							sucesso = acessor.ProprietarioVeiculoDal.Editar(proprietarioveiculoInfo);
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

		public bool Excluir(int pve_codigo)
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor. ProprietarioVeiculoDal.Excluir(pve_codigo);
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

		public List<ProprietarioVeiculoInfo> ListarTodos()
		{
			Acessor acessor = new Acessor();
			try
			{
				return acessor.ProprietarioVeiculoDal.ListarTodos();
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

		public ProprietarioVeiculoInfo ListarPorCodigo(int pve_codigo)
		{
			Acessor acessor = new Acessor();
			ProprietarioVeiculoInfo proprietarioveiculoInfo = new ProprietarioVeiculoInfo();
			try
			{
				return proprietarioveiculoInfo = acessor.ProprietarioVeiculoDal.ListarPorCodigo(pve_codigo);
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