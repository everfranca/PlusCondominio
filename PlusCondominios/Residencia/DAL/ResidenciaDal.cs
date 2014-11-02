using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class ResidenciaDal : IResidenciaDal
	{
		private const string spListarTodos = "Residencia_ListarTodos";
		private const string spListarPorCodigo = "Residencia_ListarPorCodigo";
		private const string spInserir = "Residencia_Inserir";
		private const string spEditar = "Residencia_Editar";
		private const string spExcluir = "Residencia_Excluir";

		private const string paramRES_Codigo = "@RES_Codigo";
		private const string paramRES_Torre = "@RES_Torre";
		private const string paramRES_Bloco = "@RES_Bloco";
		private const string paramRES_Numero = "@RES_Numero";
		private const string paramRES_Ramal = "@RES_Ramal";
		private const string paramRES_EMP_Codigo = "@RES_EMP_Codigo";

		public bool Inserir(ResidenciaInfo residenciaInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramRES_Torre, residenciaInfo.RES_Torre));
				lParam.Add(new SqlParameter(paramRES_Bloco, residenciaInfo.RES_Bloco));
				lParam.Add(new SqlParameter(paramRES_Numero, residenciaInfo.RES_Numero));
				lParam.Add(new SqlParameter(paramRES_Ramal, residenciaInfo.RES_Ramal));
				lParam.Add(new SqlParameter(paramRES_EMP_Codigo, residenciaInfo.RES_EMP_Codigo));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						residenciaInfo.RES_Codigo = int.Parse(dr["RES_Codigo"].ToString());
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

		public bool Editar(ResidenciaInfo residenciaInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramRES_Codigo, residenciaInfo.RES_Codigo));
				lParam.Add(new SqlParameter(paramRES_Torre, residenciaInfo.RES_Torre));
				lParam.Add(new SqlParameter(paramRES_Bloco, residenciaInfo.RES_Bloco));
				lParam.Add(new SqlParameter(paramRES_Numero, residenciaInfo.RES_Numero));
				lParam.Add(new SqlParameter(paramRES_Ramal, residenciaInfo.RES_Ramal));
				lParam.Add(new SqlParameter(paramRES_EMP_Codigo, residenciaInfo.RES_EMP_Codigo));
				
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

		public bool Excluir(int res_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramRES_Codigo, res_codigo));
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

		public List<ResidenciaInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<ResidenciaInfo> lst = new List<ResidenciaInfo>();
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
						lst.Add(instancia.NovaInstancia<ResidenciaInfo>(dr));
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

		public ResidenciaInfo ListarPorCodigo(int res_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<ResidenciaInfo> lstResidencia = new List<ResidenciaInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramRES_Codigo, res_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<ResidenciaInfo>(dr);
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