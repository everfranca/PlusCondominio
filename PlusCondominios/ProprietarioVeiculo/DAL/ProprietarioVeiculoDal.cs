using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class ProprietarioVeiculoDal : IProprietarioVeiculoDal
	{
		private const string spListarTodos = "ProprietarioVeiculo_ListarTodos";
		private const string spListarPorCodigo = "ProprietarioVeiculo_ListarPorCodigo";
		private const string spInserir = "ProprietarioVeiculo_Inserir";
		private const string spEditar = "ProprietarioVeiculo_Editar";
		private const string spExcluir = "ProprietarioVeiculo_Excluir";

		private const string paramPVE_Codigo = "@PVE_Codigo";
		private const string paramPVE_Veiculo = "@PVE_Veiculo";
		private const string paramPVE_Placa = "@PVE_Placa";
		private const string paramPVE_PRT_Codigo = "@PVE_PRT_Codigo";

		public bool Inserir(ProprietarioVeiculoInfo proprietarioveiculoInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPVE_Veiculo, proprietarioveiculoInfo.PVE_Veiculo));
				lParam.Add(new SqlParameter(paramPVE_Placa, proprietarioveiculoInfo.PVE_Placa));
				lParam.Add(new SqlParameter(paramPVE_PRT_Codigo, proprietarioveiculoInfo.PVE_PRT_Codigo));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						proprietarioveiculoInfo.PVE_Codigo = int.Parse(dr["PVE_Codigo"].ToString());
						sucesso = true;
					}
					else
						sucesso = false;
				}
			}
			catch (Exception exc)
			{
				sucesso = false;
				throw new Exception(exc.Message, exc);
			}
			finally
			{
				lParam = null;
				dr.Close();
			}
			return sucesso;
		}

		public bool Editar(ProprietarioVeiculoInfo proprietarioveiculoInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPVE_Codigo, proprietarioveiculoInfo.PVE_Codigo));
				lParam.Add(new SqlParameter(paramPVE_Veiculo, proprietarioveiculoInfo.PVE_Veiculo));
				lParam.Add(new SqlParameter(paramPVE_Placa, proprietarioveiculoInfo.PVE_Placa));
				lParam.Add(new SqlParameter(paramPVE_PRT_Codigo, proprietarioveiculoInfo.PVE_PRT_Codigo));
				
				using (sp = new StoredProcedure(spEditar, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read() && dr.HasRows)
						sucesso = true;
				}
			}
			catch (Exception exc)
			{
				sucesso = false;
				throw new Exception(exc.Message, exc);
			}
			finally
			{
				lParam = null;
				dr.Close();
			}
			return sucesso;
		}

		public bool Excluir(int pve_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramPVE_Codigo, pve_codigo));
				using (sp = new StoredProcedure(spExcluir, lParam, ConexoesBanco.PlusCondominios))
					sucesso = sp.ExecuteQuery() > 0;
			}
			catch (Exception exc)
			{
				sucesso = false;
				throw new Exception(exc.Message, exc);
			}
			finally
			{
				lParam = null;
			}
			return sucesso;
		}

		public List<ProprietarioVeiculoInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<ProprietarioVeiculoInfo> lst = new List<ProprietarioVeiculoInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				using (sp = new StoredProcedure(spListarTodos, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();

					while (dr.Read())
					{
						NovaInstanciaClasse instancia = new NovaInstanciaClasse();
						lst.Add(instancia.NovaInstancia<ProprietarioVeiculoInfo>(dr));
						instancia = null;
					}
				}
			}
			catch (Exception exc)
			{
				throw new Exception(exc.Message, exc);
			}
			finally
			{
				lParam = null;
			}
			return lst;
		}

		public ProprietarioVeiculoInfo ListarPorCodigo(int pve_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<ProprietarioVeiculoInfo> lstProprietarioVeiculo = new List<ProprietarioVeiculoInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPVE_Codigo, pve_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<ProprietarioVeiculoInfo>(dr);
					return null;
				}
			}
			catch (Exception exc)
			{
				throw new Exception(exc.Message, exc);
			}
			finally
			{
				lParam = null;
			}
		}
	}
}