using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class AcessoVisitanteDal : IAcessoVisitanteDal
	{
		private const string spListarTodos = "AcessoVisitante_ListarTodos";
		private const string spListarPorCodigo = "AcessoVisitante_ListarPorCodigo";
		private const string spInserir = "AcessoVisitante_Inserir";
		private const string spEditar = "AcessoVisitante_Editar";
		private const string spExcluir = "AcessoVisitante_Excluir";

		private const string paramAVI_Codigo = "@AVI_Codigo";
		private const string paramAVI_VIS_Codigo = "@AVI_VIS_Codigo";
		private const string paramAVI_DataEntrada = "@AVI_DataEntrada";
		private const string paramAVI_DataSaida = "@AVI_DataSaida";
		private const string paramAVI_Veiculo = "@AVI_Veiculo";
		private const string paramAVI_Placa = "@AVI_Placa";
		private const string paramAVI_RES_Codigo = "@AVI_RES_Codigo";
		private const string paramAVI_Telefone = "@AVI_Telefone";
		private const string paramAVI_Observacao = "@AVI_Observacao";

		public bool Inserir(AcessoVisitanteInfo acessovisitanteInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramAVI_VIS_Codigo, acessovisitanteInfo.AVI_VIS_Codigo));
				lParam.Add(new SqlParameter(paramAVI_DataEntrada, acessovisitanteInfo.AVI_DataEntrada));
				lParam.Add(new SqlParameter(paramAVI_DataSaida, acessovisitanteInfo.AVI_DataSaida));
				lParam.Add(new SqlParameter(paramAVI_Veiculo, acessovisitanteInfo.AVI_Veiculo));
				lParam.Add(new SqlParameter(paramAVI_Placa, acessovisitanteInfo.AVI_Placa));
				lParam.Add(new SqlParameter(paramAVI_RES_Codigo, acessovisitanteInfo.AVI_RES_Codigo));
				lParam.Add(new SqlParameter(paramAVI_Telefone, acessovisitanteInfo.AVI_Telefone));
				lParam.Add(new SqlParameter(paramAVI_Observacao, acessovisitanteInfo.AVI_Observacao));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						acessovisitanteInfo.AVI_Codigo = int.Parse(dr["AVI_Codigo"].ToString());
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

		public bool Editar(AcessoVisitanteInfo acessovisitanteInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramAVI_Codigo, acessovisitanteInfo.AVI_Codigo));
				lParam.Add(new SqlParameter(paramAVI_VIS_Codigo, acessovisitanteInfo.AVI_VIS_Codigo));
				lParam.Add(new SqlParameter(paramAVI_DataEntrada, acessovisitanteInfo.AVI_DataEntrada));
				lParam.Add(new SqlParameter(paramAVI_DataSaida, acessovisitanteInfo.AVI_DataSaida));
				lParam.Add(new SqlParameter(paramAVI_Veiculo, acessovisitanteInfo.AVI_Veiculo));
				lParam.Add(new SqlParameter(paramAVI_Placa, acessovisitanteInfo.AVI_Placa));
				lParam.Add(new SqlParameter(paramAVI_RES_Codigo, acessovisitanteInfo.AVI_RES_Codigo));
				lParam.Add(new SqlParameter(paramAVI_Telefone, acessovisitanteInfo.AVI_Telefone));
				lParam.Add(new SqlParameter(paramAVI_Observacao, acessovisitanteInfo.AVI_Observacao));
				
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

		public bool Excluir(int avi_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramAVI_Codigo, avi_codigo));
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

		public List<AcessoVisitanteInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<AcessoVisitanteInfo> lst = new List<AcessoVisitanteInfo>();
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
						lst.Add(instancia.NovaInstancia<AcessoVisitanteInfo>(dr));
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

		public AcessoVisitanteInfo ListarPorCodigo(int avi_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<AcessoVisitanteInfo> lstAcessoVisitante = new List<AcessoVisitanteInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramAVI_Codigo, avi_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<AcessoVisitanteInfo>(dr);
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