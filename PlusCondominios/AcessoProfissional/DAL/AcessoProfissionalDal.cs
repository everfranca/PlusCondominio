using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class AcessoProfissionalDal : IAcessoProfissionalDal
	{
		private const string spListarTodos = "AcessoProfissional_ListarTodos";
		private const string spListarPorCodigo = "AcessoProfissional_ListarPorCodigo";
		private const string spInserir = "AcessoProfissional_Inserir";
		private const string spEditar = "AcessoProfissional_Editar";
		private const string spExcluir = "AcessoProfissional_Excluir";

		private const string paramAPR_Codigo = "@APR_Codigo";
		private const string paramAPR_PRO_Codigo = "@APR_PRO_Codigo";
		private const string paramAPR_DataEntrada = "@APR_DataEntrada";
		private const string paramAPR_DataSaida = "@APR_DataSaida";
		private const string paramAPR_Veiculo = "@APR_Veiculo";
		private const string paramAPR_Placa = "@APR_Placa";
		private const string paramAPR_RES_Codigo = "@APR_RES_Codigo";
		private const string paramAPR_Telefone = "@APR_Telefone";
		private const string paramAPR_Observacao = "@APR_Observacao";

		public bool Inserir(AcessoProfissionalInfo acessoprofissionalInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramAPR_PRO_Codigo, acessoprofissionalInfo.APR_PRO_Codigo));
				lParam.Add(new SqlParameter(paramAPR_DataEntrada, acessoprofissionalInfo.APR_DataEntrada));
				lParam.Add(new SqlParameter(paramAPR_DataSaida, acessoprofissionalInfo.APR_DataSaida));
				lParam.Add(new SqlParameter(paramAPR_Veiculo, acessoprofissionalInfo.APR_Veiculo));
				lParam.Add(new SqlParameter(paramAPR_Placa, acessoprofissionalInfo.APR_Placa));
				lParam.Add(new SqlParameter(paramAPR_RES_Codigo, acessoprofissionalInfo.APR_RES_Codigo));
				lParam.Add(new SqlParameter(paramAPR_Telefone, acessoprofissionalInfo.APR_Telefone));
				lParam.Add(new SqlParameter(paramAPR_Observacao, acessoprofissionalInfo.APR_Observacao));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						acessoprofissionalInfo.APR_Codigo = int.Parse(dr["APR_Codigo"].ToString());
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

		public bool Editar(AcessoProfissionalInfo acessoprofissionalInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramAPR_Codigo, acessoprofissionalInfo.APR_Codigo));
				lParam.Add(new SqlParameter(paramAPR_PRO_Codigo, acessoprofissionalInfo.APR_PRO_Codigo));
				lParam.Add(new SqlParameter(paramAPR_DataEntrada, acessoprofissionalInfo.APR_DataEntrada));
				lParam.Add(new SqlParameter(paramAPR_DataSaida, acessoprofissionalInfo.APR_DataSaida));
				lParam.Add(new SqlParameter(paramAPR_Veiculo, acessoprofissionalInfo.APR_Veiculo));
				lParam.Add(new SqlParameter(paramAPR_Placa, acessoprofissionalInfo.APR_Placa));
				lParam.Add(new SqlParameter(paramAPR_RES_Codigo, acessoprofissionalInfo.APR_RES_Codigo));
				lParam.Add(new SqlParameter(paramAPR_Telefone, acessoprofissionalInfo.APR_Telefone));
				lParam.Add(new SqlParameter(paramAPR_Observacao, acessoprofissionalInfo.APR_Observacao));
				
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

		public bool Excluir(int apr_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramAPR_Codigo, apr_codigo));
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

		public List<AcessoProfissionalInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<AcessoProfissionalInfo> lst = new List<AcessoProfissionalInfo>();
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
						lst.Add(instancia.NovaInstancia<AcessoProfissionalInfo>(dr));
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

		public AcessoProfissionalInfo ListarPorCodigo(int apr_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<AcessoProfissionalInfo> lstAcessoProfissional = new List<AcessoProfissionalInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramAPR_Codigo, apr_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<AcessoProfissionalInfo>(dr);
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