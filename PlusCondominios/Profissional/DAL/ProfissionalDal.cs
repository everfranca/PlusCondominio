using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class ProfissionalDal : IProfissionalDal
	{
		private const string spListarTodos = "Profissional_ListarTodos";
		private const string spListarPorCodigo = "Profissional_ListarPorCodigo";
		private const string spInserir = "Profissional_Inserir";
		private const string spEditar = "Profissional_Editar";
		private const string spExcluir = "Profissional_Excluir";

		private const string paramPRO_Codigo = "@PRO_Codigo";
		private const string paramPRO_Cpf = "@PRO_Cpf";
		private const string paramPRO_Rg = "@PRO_Rg";
		private const string paramPRO_Nome = "@PRO_Nome";
		private const string paramPRO_Telefone = "@PRO_Telefone";
		private const string paramPRO_Veiculo = "@PRO_Veiculo";
		private const string paramPRO_Placa = "@PRO_Placa";
		private const string paramPRO_Foto = "@PRO_Foto";
		private const string paramPRO_Empresa = "@PRO_Empresa";

		public bool Inserir(ProfissionalInfo profissionalInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRO_Cpf, profissionalInfo.PRO_Cpf));
				lParam.Add(new SqlParameter(paramPRO_Rg, profissionalInfo.PRO_Rg));
				lParam.Add(new SqlParameter(paramPRO_Nome, profissionalInfo.PRO_Nome));
				lParam.Add(new SqlParameter(paramPRO_Telefone, profissionalInfo.PRO_Telefone));
				lParam.Add(new SqlParameter(paramPRO_Veiculo, profissionalInfo.PRO_Veiculo));
				lParam.Add(new SqlParameter(paramPRO_Placa, profissionalInfo.PRO_Placa));
				lParam.Add(new SqlParameter(paramPRO_Foto, profissionalInfo.PRO_Foto));
				lParam.Add(new SqlParameter(paramPRO_Empresa, profissionalInfo.PRO_Empresa));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						profissionalInfo.PRO_Codigo = int.Parse(dr["PRO_Codigo"].ToString());
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

		public bool Editar(ProfissionalInfo profissionalInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRO_Codigo, profissionalInfo.PRO_Codigo));
				lParam.Add(new SqlParameter(paramPRO_Cpf, profissionalInfo.PRO_Cpf));
				lParam.Add(new SqlParameter(paramPRO_Rg, profissionalInfo.PRO_Rg));
				lParam.Add(new SqlParameter(paramPRO_Nome, profissionalInfo.PRO_Nome));
				lParam.Add(new SqlParameter(paramPRO_Telefone, profissionalInfo.PRO_Telefone));
				lParam.Add(new SqlParameter(paramPRO_Veiculo, profissionalInfo.PRO_Veiculo));
				lParam.Add(new SqlParameter(paramPRO_Placa, profissionalInfo.PRO_Placa));
				lParam.Add(new SqlParameter(paramPRO_Foto, profissionalInfo.PRO_Foto));
				lParam.Add(new SqlParameter(paramPRO_Empresa, profissionalInfo.PRO_Empresa));
				
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

		public bool Excluir(int pro_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRO_Codigo, pro_codigo));
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

		public List<ProfissionalInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<ProfissionalInfo> lst = new List<ProfissionalInfo>();
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
						lst.Add(instancia.NovaInstancia<ProfissionalInfo>(dr));
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

		public ProfissionalInfo ListarPorCodigo(int pro_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<ProfissionalInfo> lstProfissional = new List<ProfissionalInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRO_Codigo, pro_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<ProfissionalInfo>(dr);
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