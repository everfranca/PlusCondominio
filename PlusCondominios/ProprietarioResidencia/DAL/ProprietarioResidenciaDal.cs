using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class ProprietarioResidenciaDal : IProprietarioResidenciaDal
	{
		private const string spListarTodos = "ProprietarioResidencia_ListarTodos";
		private const string spListarPorCodigo = "ProprietarioResidencia_ListarPorCodigo";
		private const string spInserir = "ProprietarioResidencia_Inserir";
		private const string spEditar = "ProprietarioResidencia_Editar";
		private const string spExcluir = "ProprietarioResidencia_Excluir";

		private const string paramPRE_Codigo = "@PRE_Codigo";
		private const string paramPRE_PRT_Codigo = "@PRE_PRT_Codigo";
		private const string paramPRE_RES_Codigo = "@PRE_RES_Codigo";

		public bool Inserir(ProprietarioResidenciaInfo proprietarioresidenciaInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRE_PRT_Codigo, proprietarioresidenciaInfo.PRE_PRT_Codigo));
				lParam.Add(new SqlParameter(paramPRE_RES_Codigo, proprietarioresidenciaInfo.PRE_RES_Codigo));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						proprietarioresidenciaInfo.PRE_Codigo = int.Parse(dr["PRE_Codigo"].ToString());
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

		public bool Editar(ProprietarioResidenciaInfo proprietarioresidenciaInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRE_Codigo, proprietarioresidenciaInfo.PRE_Codigo));
				lParam.Add(new SqlParameter(paramPRE_PRT_Codigo, proprietarioresidenciaInfo.PRE_PRT_Codigo));
				lParam.Add(new SqlParameter(paramPRE_RES_Codigo, proprietarioresidenciaInfo.PRE_RES_Codigo));
				
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

		public bool Excluir(int pre_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRE_Codigo, pre_codigo));
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

		public List<ProprietarioResidenciaInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<ProprietarioResidenciaInfo> lst = new List<ProprietarioResidenciaInfo>();
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
						lst.Add(instancia.NovaInstancia<ProprietarioResidenciaInfo>(dr));
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

		public ProprietarioResidenciaInfo ListarPorCodigo(int pre_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<ProprietarioResidenciaInfo> lstProprietarioResidencia = new List<ProprietarioResidenciaInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRE_Codigo, pre_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<ProprietarioResidenciaInfo>(dr);
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