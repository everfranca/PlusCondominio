using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class UsuarioDal : IUsuarioDal
	{
		private const string spListarTodos = "Usuario_ListarTodos";
		private const string spListarPorCodigo = "Usuario_ListarPorCodigo";
		private const string spInserir = "Usuario_Inserir";
		private const string spEditar = "Usuario_Editar";
		private const string spExcluir = "Usuario_Excluir";

		private const string paramUSU_Codigo = "@USU_Codigo";
		private const string paramUSU_Login = "@USU_Login";
		private const string paramUSU_Senha = "@USU_Senha";
		private const string paramUSU_Email = "@USU_Email";
		private const string paramUSU_PRF_Codigo = "@USU_PRF_Codigo";
		private const string paramUSU_EMP_Codigo = "@USU_EMP_Codigo";

		public bool Inserir(UsuarioInfo usuarioInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramUSU_Login, usuarioInfo.USU_Login));
				lParam.Add(new SqlParameter(paramUSU_Senha, usuarioInfo.USU_Senha));
				lParam.Add(new SqlParameter(paramUSU_Email, usuarioInfo.USU_Email));
				lParam.Add(new SqlParameter(paramUSU_PRF_Codigo, usuarioInfo.USU_PRF_Codigo));
				lParam.Add(new SqlParameter(paramUSU_EMP_Codigo, usuarioInfo.USU_EMP_Codigo));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						usuarioInfo.USU_Codigo = int.Parse(dr["USU_Codigo"].ToString());
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

		public bool Editar(UsuarioInfo usuarioInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramUSU_Codigo, usuarioInfo.USU_Codigo));
				lParam.Add(new SqlParameter(paramUSU_Login, usuarioInfo.USU_Login));
				lParam.Add(new SqlParameter(paramUSU_Senha, usuarioInfo.USU_Senha));
				lParam.Add(new SqlParameter(paramUSU_Email, usuarioInfo.USU_Email));
				lParam.Add(new SqlParameter(paramUSU_PRF_Codigo, usuarioInfo.USU_PRF_Codigo));
				lParam.Add(new SqlParameter(paramUSU_EMP_Codigo, usuarioInfo.USU_EMP_Codigo));
				
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

		public bool Excluir(int usu_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramUSU_Codigo, usu_codigo));
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

		public List<UsuarioInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<UsuarioInfo> lst = new List<UsuarioInfo>();
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
						lst.Add(instancia.NovaInstancia<UsuarioInfo>(dr));
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

		public UsuarioInfo ListarPorCodigo(int usu_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<UsuarioInfo> lstUsuario = new List<UsuarioInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramUSU_Codigo, usu_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<UsuarioInfo>(dr);
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