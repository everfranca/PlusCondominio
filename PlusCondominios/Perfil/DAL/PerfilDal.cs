using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class PerfilDal : IPerfilDal
	{
		private const string spListarTodos = "Perfil_ListarTodos";
		private const string spListarPorCodigo = "Perfil_ListarPorCodigo";
		private const string spInserir = "Perfil_Inserir";
		private const string spEditar = "Perfil_Editar";
		private const string spExcluir = "Perfil_Excluir";
        private const string spListarPerfilPorNome = "Perfil_ListarPorNome";

		private const string paramPRF_Codigo = "@PRF_Codigo";
		private const string paramPRF_Nome = "@PRF_Nome";

		public bool Inserir(PerfilInfo perfilInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRF_Nome, perfilInfo.PRF_Nome));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						perfilInfo.PRF_Codigo = int.Parse(dr["PRF_Codigo"].ToString());
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

		public bool Editar(PerfilInfo perfilInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRF_Codigo, perfilInfo.PRF_Codigo));
				lParam.Add(new SqlParameter(paramPRF_Nome, perfilInfo.PRF_Nome));
				
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

		public bool Excluir(int prf_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRF_Codigo, prf_codigo));
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

		public List<PerfilInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<PerfilInfo> lst = new List<PerfilInfo>();
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
						lst.Add(instancia.NovaInstancia<PerfilInfo>(dr));
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

        public List<PerfilInfo> ListarPerfilPorNome(string prf_nome)
        {
            List<SqlParameter> lParam = new List<SqlParameter>();
            List<PerfilInfo> lst = new List<PerfilInfo>();
            StoredProcedure sp = null;
            SqlDataReader dr = null;

            try
            {
                lParam.Add(new SqlParameter(paramPRF_Nome, prf_nome));
                using (sp = new StoredProcedure(spListarPerfilPorNome, lParam, ConexoesBanco.PlusCondominios))
                {
                    dr = sp.GetDataReader();

                    while (dr.Read())
                    {
                        NovaInstanciaClasse instancia = new NovaInstanciaClasse();
                        lst.Add(instancia.NovaInstancia<PerfilInfo>(dr));
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

		public PerfilInfo ListarPorCodigo(int prf_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<PerfilInfo> lstPerfil = new List<PerfilInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramPRF_Codigo, prf_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<PerfilInfo>(dr);
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