using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class AgendamentoDal : IAgendamentoDal
	{
		private const string spListarTodos = "Agendamento_ListarTodos";
		private const string spListarPorCodigo = "Agendamento_ListarPorCodigo";
		private const string spInserir = "Agendamento_Inserir";
		private const string spEditar = "Agendamento_Editar";
		private const string spExcluir = "Agendamento_Excluir";

		private const string paramAGE_Codigo = "@AGE_Codigo";
		private const string paramAGE_TAG_Codigo = "@AGE_TAG_Codigo";
		private const string paramAGE_DataHoraInicio = "@AGE_DataHoraInicio";
		private const string paramAGE_DataHoraFim = "@AGE_DataHoraFim";
		private const string paramAGE_PRT_Codigo = "@AGE_PRT_Codigo";

		public bool Inserir(AgendamentoInfo agendamentoInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramAGE_TAG_Codigo, agendamentoInfo.AGE_TAG_Codigo));
				lParam.Add(new SqlParameter(paramAGE_DataHoraInicio, agendamentoInfo.AGE_DataHoraInicio));
				lParam.Add(new SqlParameter(paramAGE_DataHoraFim, agendamentoInfo.AGE_DataHoraFim));
				lParam.Add(new SqlParameter(paramAGE_PRT_Codigo, agendamentoInfo.AGE_PRT_Codigo));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						agendamentoInfo.AGE_Codigo = int.Parse(dr["AGE_Codigo"].ToString());
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

		public bool Editar(AgendamentoInfo agendamentoInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramAGE_Codigo, agendamentoInfo.AGE_Codigo));
				lParam.Add(new SqlParameter(paramAGE_TAG_Codigo, agendamentoInfo.AGE_TAG_Codigo));
				lParam.Add(new SqlParameter(paramAGE_DataHoraInicio, agendamentoInfo.AGE_DataHoraInicio));
				lParam.Add(new SqlParameter(paramAGE_DataHoraFim, agendamentoInfo.AGE_DataHoraFim));
				lParam.Add(new SqlParameter(paramAGE_PRT_Codigo, agendamentoInfo.AGE_PRT_Codigo));
				
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

		public bool Excluir(int age_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramAGE_Codigo, age_codigo));
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

		public List<AgendamentoInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<AgendamentoInfo> lst = new List<AgendamentoInfo>();
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
						lst.Add(instancia.NovaInstancia<AgendamentoInfo>(dr));
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

		public AgendamentoInfo ListarPorCodigo(int age_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<AgendamentoInfo> lstAgendamento = new List<AgendamentoInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramAGE_Codigo, age_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<AgendamentoInfo>(dr);
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