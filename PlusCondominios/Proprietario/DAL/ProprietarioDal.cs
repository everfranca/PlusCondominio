using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class ProprietarioDal : IProprietarioDal
	{
        private const string spListarPorParametro = "Proprietario_ListarPorParametro";
		private const string spListarPorCodigo = "Proprietario_ListarPorCodigo";
		private const string spInserir = "Proprietario_Inserir";
		private const string spEditar = "Proprietario_Editar";
		private const string spExcluir = "Proprietario_Excluir";

		private const string paramPRT_Codigo = "@PRT_Codigo";
		private const string paramPRT_Cpf = "@PRT_Cpf";
		private const string paramPRT_Rg = "@PRT_Rg";
		private const string paramPRT_Nome = "@PRT_Nome";
		private const string paramPRT_Foto = "@PRT_Foto";
		private const string paramPRT_Ativo = "@PRT_Ativo";
        private const string paramPRT_Sindico = "@PRT_Sindico";
        private const string paramPRT_Aluguel = "@PRT_Aluguel";

		public bool Inserir(ProprietarioInfo proprietarioInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRT_Cpf, proprietarioInfo.PRT_Cpf));
				lParam.Add(new SqlParameter(paramPRT_Rg, proprietarioInfo.PRT_Rg));
				lParam.Add(new SqlParameter(paramPRT_Nome, proprietarioInfo.PRT_Nome));
				lParam.Add(new SqlParameter(paramPRT_Foto, proprietarioInfo.PRT_Foto));
				lParam.Add(new SqlParameter(paramPRT_Ativo, proprietarioInfo.PRT_Ativo));
                lParam.Add(new SqlParameter(paramPRT_Aluguel, proprietarioInfo.PRT_Aluguel));
                lParam.Add(new SqlParameter(paramPRT_Sindico, proprietarioInfo.PRT_Sindico));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						proprietarioInfo.PRT_Codigo = int.Parse(dr["PRT_Codigo"].ToString());
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

		public bool Editar(ProprietarioInfo proprietarioInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRT_Codigo, proprietarioInfo.PRT_Codigo));
				lParam.Add(new SqlParameter(paramPRT_Cpf, proprietarioInfo.PRT_Cpf));
				lParam.Add(new SqlParameter(paramPRT_Rg, proprietarioInfo.PRT_Rg));
				lParam.Add(new SqlParameter(paramPRT_Nome, proprietarioInfo.PRT_Nome));
				lParam.Add(new SqlParameter(paramPRT_Foto, proprietarioInfo.PRT_Foto));
				lParam.Add(new SqlParameter(paramPRT_Ativo, proprietarioInfo.PRT_Ativo));
                lParam.Add(new SqlParameter(paramPRT_Sindico, proprietarioInfo.PRT_Sindico));
                lParam.Add(new SqlParameter(paramPRT_Aluguel, proprietarioInfo.PRT_Aluguel));
				
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

		public bool Excluir(int prt_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRT_Codigo, prt_codigo));
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

		public List<ProprietarioInfo> ListarPorParametro(ProprietarioInfo proprietarioInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<ProprietarioInfo> lst = new List<ProprietarioInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
                lParam.Add(new SqlParameter(paramPRT_Codigo, proprietarioInfo.PRT_Codigo));
                lParam.Add(new SqlParameter(paramPRT_Cpf, proprietarioInfo.PRT_Cpf));
                lParam.Add(new SqlParameter(paramPRT_Rg, proprietarioInfo.PRT_Rg));
                lParam.Add(new SqlParameter(paramPRT_Nome, proprietarioInfo.PRT_Nome));

				using (sp = new StoredProcedure(spListarPorParametro, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();

					while (dr.Read())
					{
						NovaInstanciaClasse instancia = new NovaInstanciaClasse();
						lst.Add(instancia.NovaInstancia<ProprietarioInfo>(dr));
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

		public ProprietarioInfo ListarPorCodigo(int prt_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<ProprietarioInfo> lstProprietario = new List<ProprietarioInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRT_Codigo, prt_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<ProprietarioInfo>(dr);
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