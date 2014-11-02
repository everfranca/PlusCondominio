using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class PermissaoUsuarioItemDal : IPermissaoUsuarioItemDal
	{
		private const string spListarTodos = "PermissaoUsuarioItem_ListarTodos";
		private const string spListarPorCodigo = "PermissaoUsuarioItem_ListarPorCodigo";
		private const string spInserir = "PermissaoUsuarioItem_Inserir";
		private const string spEditar = "PermissaoUsuarioItem_Editar";
		private const string spExcluir = "PermissaoUsuarioItem_Excluir";

		private const string paramPER_Codigo = "@PER_Codigo";
		private const string paramPER_PRF_Codigo = "@PER_PRF_Codigo";
		private const string paramPER_USU_Codigo = "@PER_USU_Codigo";
		private const string paramPER_ITE_Codigo = "@PER_ITE_Codigo";

		public bool Inserir(PermissaoUsuarioItemInfo permissaousuarioitemInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPER_PRF_Codigo, permissaousuarioitemInfo.PER_PRF_Codigo));
				lParam.Add(new SqlParameter(paramPER_USU_Codigo, permissaousuarioitemInfo.PER_USU_Codigo));
				lParam.Add(new SqlParameter(paramPER_ITE_Codigo, permissaousuarioitemInfo.PER_ITE_Codigo));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						permissaousuarioitemInfo.PER_Codigo = int.Parse(dr["PER_Codigo"].ToString());
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

		public bool Editar(PermissaoUsuarioItemInfo permissaousuarioitemInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPER_Codigo, permissaousuarioitemInfo.PER_Codigo));
				lParam.Add(new SqlParameter(paramPER_PRF_Codigo, permissaousuarioitemInfo.PER_PRF_Codigo));
				lParam.Add(new SqlParameter(paramPER_USU_Codigo, permissaousuarioitemInfo.PER_USU_Codigo));
				lParam.Add(new SqlParameter(paramPER_ITE_Codigo, permissaousuarioitemInfo.PER_ITE_Codigo));
				
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

		public bool Excluir(int per_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramPER_Codigo, per_codigo));
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

		public List<PermissaoUsuarioItemInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<PermissaoUsuarioItemInfo> lst = new List<PermissaoUsuarioItemInfo>();
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
						lst.Add(instancia.NovaInstancia<PermissaoUsuarioItemInfo>(dr));
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

		public PermissaoUsuarioItemInfo ListarPorCodigo(int per_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<PermissaoUsuarioItemInfo> lstPermissaoUsuarioItem = new List<PermissaoUsuarioItemInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPER_Codigo, per_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<PermissaoUsuarioItemInfo>(dr);
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