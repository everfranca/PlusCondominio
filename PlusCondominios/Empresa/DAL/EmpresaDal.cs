using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class EmpresaDal : IEmpresaDal
	{
		private const string spListarTodos = "Empresa_ListarTodos";
		private const string spListarPorCodigo = "Empresa_ListarPorCodigo";
		private const string spInserir = "Empresa_Inserir";
		private const string spEditar = "Empresa_Editar";
		private const string spExcluir = "Empresa_Excluir";

		private const string paramEMP_Codigo = "@EMP_Codigo";
		private const string paramEMP_Nome = "@EMP_Nome";
		private const string paramEMP_FotoPequena = "@EMP_FotoPequena";
		private const string paramEMP_FotoMedia = "@EMP_FotoMedia";
		private const string paramEMP_FotoGrande = "@EMP_FotoGrande";
		private const string paramEMP_Cnpj = "@EMP_Cnpj";
		private const string paramEMP_Telefone = "@EMP_Telefone";

		public bool Inserir(EmpresaInfo empresaInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramEMP_Nome, empresaInfo.EMP_Nome));
				lParam.Add(new SqlParameter(paramEMP_FotoPequena, empresaInfo.EMP_FotoPequena));
				lParam.Add(new SqlParameter(paramEMP_FotoMedia, empresaInfo.EMP_FotoMedia));
				lParam.Add(new SqlParameter(paramEMP_FotoGrande, empresaInfo.EMP_FotoGrande));
				lParam.Add(new SqlParameter(paramEMP_Cnpj, empresaInfo.EMP_Cnpj));
				lParam.Add(new SqlParameter(paramEMP_Telefone, empresaInfo.EMP_Telefone));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						empresaInfo.EMP_Codigo = dr["EMP_Codigo"].ToString();
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

		public bool Editar(EmpresaInfo empresaInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramEMP_Codigo, empresaInfo.EMP_Codigo));
				lParam.Add(new SqlParameter(paramEMP_Nome, empresaInfo.EMP_Nome));
				lParam.Add(new SqlParameter(paramEMP_FotoPequena, empresaInfo.EMP_FotoPequena));
				lParam.Add(new SqlParameter(paramEMP_FotoMedia, empresaInfo.EMP_FotoMedia));
				lParam.Add(new SqlParameter(paramEMP_FotoGrande, empresaInfo.EMP_FotoGrande));
				lParam.Add(new SqlParameter(paramEMP_Cnpj, empresaInfo.EMP_Cnpj));
				lParam.Add(new SqlParameter(paramEMP_Telefone, empresaInfo.EMP_Telefone));
				
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

		public bool Excluir(string emp_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramEMP_Codigo, emp_codigo));
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

		public List<EmpresaInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<EmpresaInfo> lst = new List<EmpresaInfo>();
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
						lst.Add(instancia.NovaInstancia<EmpresaInfo>(dr));
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

		public EmpresaInfo ListarPorCodigo(int emp_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<EmpresaInfo> lstEmpresa = new List<EmpresaInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramEMP_Codigo, emp_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<EmpresaInfo>(dr);
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