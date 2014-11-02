using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class TipoAgendamentoDal : ITipoAgendamentoDal
	{
		private const string spListarTodos = "TipoAgendamento_ListarTodos";
		private const string spListarPorCodigo = "TipoAgendamento_ListarPorCodigo";
		private const string spInserir = "TipoAgendamento_Inserir";
		private const string spEditar = "TipoAgendamento_Editar";
		private const string spExcluir = "TipoAgendamento_Excluir";

		private const string paramTAG_Codigo = "@TAG_Codigo";
		private const string paramTAG_Descricao = "@TAG_Descricao";

		public bool Inserir(TipoAgendamentoInfo tipoagendamentoInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramTAG_Descricao, tipoagendamentoInfo.TAG_Descricao));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						tipoagendamentoInfo.TAG_Codigo = int.Parse(dr["TAG_Codigo"].ToString());
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

		public bool Editar(TipoAgendamentoInfo tipoagendamentoInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramTAG_Codigo, tipoagendamentoInfo.TAG_Codigo));
				lParam.Add(new SqlParameter(paramTAG_Descricao, tipoagendamentoInfo.TAG_Descricao));
				
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

		public bool Excluir(int tag_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramTAG_Codigo, tag_codigo));
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

		public List<TipoAgendamentoInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<TipoAgendamentoInfo> lst = new List<TipoAgendamentoInfo>();
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
						lst.Add(instancia.NovaInstancia<TipoAgendamentoInfo>(dr));
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

		public TipoAgendamentoInfo ListarPorCodigo(int tag_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<TipoAgendamentoInfo> lstTipoAgendamento = new List<TipoAgendamentoInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramTAG_Codigo, tag_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<TipoAgendamentoInfo>(dr);
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