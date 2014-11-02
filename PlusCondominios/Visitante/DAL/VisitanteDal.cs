using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class VisitanteDal : IVisitanteDal
	{
		private const string spListarTodos = "Visitante_ListarTodos";
		private const string spListarPorCodigo = "Visitante_ListarPorCodigo";
		private const string spInserir = "Visitante_Inserir";
		private const string spEditar = "Visitante_Editar";
		private const string spExcluir = "Visitante_Excluir";

		private const string paramVIS_Codigo = "@VIS_Codigo";
		private const string paramVIS_Cpf = "@VIS_Cpf";
		private const string paramVIS_Rg = "@VIS_Rg";
		private const string paramVIS_Nome = "@VIS_Nome";
		private const string paramVIS_Telefone = "@VIS_Telefone";
		private const string paramVIS_Veiculo = "@VIS_Veiculo";
		private const string paramVIS_Placa = "@VIS_Placa";
		private const string paramVIS_Foto = "@VIS_Foto";

		public bool Inserir(VisitanteInfo visitanteInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramVIS_Cpf, visitanteInfo.VIS_Cpf));
				lParam.Add(new SqlParameter(paramVIS_Rg, visitanteInfo.VIS_Rg));
				lParam.Add(new SqlParameter(paramVIS_Nome, visitanteInfo.VIS_Nome));
				lParam.Add(new SqlParameter(paramVIS_Telefone, visitanteInfo.VIS_Telefone));
				lParam.Add(new SqlParameter(paramVIS_Veiculo, visitanteInfo.VIS_Veiculo));
				lParam.Add(new SqlParameter(paramVIS_Placa, visitanteInfo.VIS_Placa));
				lParam.Add(new SqlParameter(paramVIS_Foto, visitanteInfo.VIS_Foto));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						visitanteInfo.VIS_Codigo = int.Parse(dr["VIS_Codigo"].ToString());
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

		public bool Editar(VisitanteInfo visitanteInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramVIS_Codigo, visitanteInfo.VIS_Codigo));
				lParam.Add(new SqlParameter(paramVIS_Cpf, visitanteInfo.VIS_Cpf));
				lParam.Add(new SqlParameter(paramVIS_Rg, visitanteInfo.VIS_Rg));
				lParam.Add(new SqlParameter(paramVIS_Nome, visitanteInfo.VIS_Nome));
				lParam.Add(new SqlParameter(paramVIS_Telefone, visitanteInfo.VIS_Telefone));
				lParam.Add(new SqlParameter(paramVIS_Veiculo, visitanteInfo.VIS_Veiculo));
				lParam.Add(new SqlParameter(paramVIS_Placa, visitanteInfo.VIS_Placa));
				lParam.Add(new SqlParameter(paramVIS_Foto, visitanteInfo.VIS_Foto));
				
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

		public bool Excluir(int vis_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramVIS_Codigo, vis_codigo));
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

		public List<VisitanteInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<VisitanteInfo> lst = new List<VisitanteInfo>();
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
						lst.Add(instancia.NovaInstancia<VisitanteInfo>(dr));
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

		public VisitanteInfo ListarPorCodigo(int vis_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<VisitanteInfo> lstVisitante = new List<VisitanteInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramVIS_Codigo, vis_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<VisitanteInfo>(dr);
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