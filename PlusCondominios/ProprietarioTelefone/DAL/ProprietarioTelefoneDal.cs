using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class ProprietarioTelefoneDal : IProprietarioTelefoneDal
	{
		private const string spListarTodos = "ProprietarioTelefone_ListarTodos";
		private const string spListarPorCodigo = "ProprietarioTelefone_ListarPorCodigo";
		private const string spInserir = "ProprietarioTelefone_Inserir";
		private const string spEditar = "ProprietarioTelefone_Editar";
		private const string spExcluir = "ProprietarioTelefone_Excluir";

		private const string paramPTE_Codigo = "@PTE_Codigo";
		private const string paramPTE_Telefone = "@PTE_Telefone";
		private const string paramPTE_PRT_Codigo = "@PTE_PRT_Codigo";

		public bool Inserir(ProprietarioTelefoneInfo proprietariotelefoneInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPTE_Telefone, proprietariotelefoneInfo.PTE_Telefone));
				lParam.Add(new SqlParameter(paramPTE_PRT_Codigo, proprietariotelefoneInfo.PTE_PRT_Codigo));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						proprietariotelefoneInfo.PTE_Codigo = int.Parse(dr["PTE_Codigo"].ToString());
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

		public bool Editar(ProprietarioTelefoneInfo proprietariotelefoneInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPTE_Codigo, proprietariotelefoneInfo.PTE_Codigo));
				lParam.Add(new SqlParameter(paramPTE_Telefone, proprietariotelefoneInfo.PTE_Telefone));
				lParam.Add(new SqlParameter(paramPTE_PRT_Codigo, proprietariotelefoneInfo.PTE_PRT_Codigo));
				
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

		public bool Excluir(int pte_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramPTE_Codigo, pte_codigo));
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

		public List<ProprietarioTelefoneInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<ProprietarioTelefoneInfo> lst = new List<ProprietarioTelefoneInfo>();
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
						lst.Add(instancia.NovaInstancia<ProprietarioTelefoneInfo>(dr));
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

		public ProprietarioTelefoneInfo ListarPorCodigo(int pte_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<ProprietarioTelefoneInfo> lstProprietarioTelefone = new List<ProprietarioTelefoneInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPTE_Codigo, pte_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<ProprietarioTelefoneInfo>(dr);
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