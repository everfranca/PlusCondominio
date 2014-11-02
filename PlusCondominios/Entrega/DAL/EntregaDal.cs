using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PlusCondominios.Model;
using Nucleo;

namespace PlusCondominios.Dal
{
	public class EntregaDal : IEntregaDal
	{
		private const string spListarTodos = "Entrega_ListarTodos";
		private const string spListarPorCodigo = "Entrega_ListarPorCodigo";
		private const string spInserir = "Entrega_Inserir";
		private const string spEditar = "Entrega_Editar";
		private const string spExcluir = "Entrega_Excluir";

		private const string paramENT_Codigo = "@ENT_Codigo";
		private const string paramENT_TEN_Codigo = "@ENT_TEN_Codigo";
		private const string paramENT_Descricao = "@ENT_Descricao";
		private const string paramENT_Data = "@ENT_Data";
		private const string paramENT_RES_Codigo = "@ENT_RES_Codigo";
		private const string paramENT_EmpresaEntregou = "@ENT_EmpresaEntregou";
		private const string paramENT_NomeEntregador = "@ENT_NomeEntregador";
		private const string paramENT_TelefoneContato = "@ENT_TelefoneContato";

		public bool Inserir(EntregaInfo entregaInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramENT_TEN_Codigo, entregaInfo.ENT_TEN_Codigo));
				lParam.Add(new SqlParameter(paramENT_Descricao, entregaInfo.ENT_Descricao));
				lParam.Add(new SqlParameter(paramENT_Data, entregaInfo.ENT_Data));
				lParam.Add(new SqlParameter(paramENT_RES_Codigo, entregaInfo.ENT_RES_Codigo));
				lParam.Add(new SqlParameter(paramENT_EmpresaEntregou, entregaInfo.ENT_EmpresaEntregou));
				lParam.Add(new SqlParameter(paramENT_NomeEntregador, entregaInfo.ENT_NomeEntregador));
				lParam.Add(new SqlParameter(paramENT_TelefoneContato, entregaInfo.ENT_TelefoneContato));
				
				using (sp = new StoredProcedure(spInserir, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					if (dr.Read())
					{
						entregaInfo.ENT_Codigo = int.Parse(dr["ENT_Codigo"].ToString());
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

		public bool Editar(EntregaInfo entregaInfo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramENT_Codigo, entregaInfo.ENT_Codigo));
				lParam.Add(new SqlParameter(paramENT_TEN_Codigo, entregaInfo.ENT_TEN_Codigo));
				lParam.Add(new SqlParameter(paramENT_Descricao, entregaInfo.ENT_Descricao));
				lParam.Add(new SqlParameter(paramENT_Data, entregaInfo.ENT_Data));
				lParam.Add(new SqlParameter(paramENT_RES_Codigo, entregaInfo.ENT_RES_Codigo));
				lParam.Add(new SqlParameter(paramENT_EmpresaEntregou, entregaInfo.ENT_EmpresaEntregou));
				lParam.Add(new SqlParameter(paramENT_NomeEntregador, entregaInfo.ENT_NomeEntregador));
				lParam.Add(new SqlParameter(paramENT_TelefoneContato, entregaInfo.ENT_TelefoneContato));
				
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

		public bool Excluir(int ent_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			bool sucesso = false;
			StoredProcedure sp = null;

			try
			{
				lParam.Add(new SqlParameter(paramENT_Codigo, ent_codigo));
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

		public List<EntregaInfo> ListarTodos()
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<EntregaInfo> lst = new List<EntregaInfo>();
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
						lst.Add(instancia.NovaInstancia<EntregaInfo>(dr));
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

		public EntregaInfo ListarPorCodigo(int ent_codigo)
		{
			List<SqlParameter> lParam = new List<SqlParameter>();
			List<EntregaInfo> lstEntrega = new List<EntregaInfo>();
			StoredProcedure sp = null;
			SqlDataReader dr = null;

			try
			{
				lParam.Add(new SqlParameter(paramENT_Codigo, ent_codigo));
			
				using (sp = new StoredProcedure(spListarPorCodigo, lParam, ConexoesBanco.PlusCondominios))
				{
					dr = sp.GetDataReader();
					NovaInstanciaClasse instancia = new NovaInstanciaClasse();

					if (dr.Read())
						return instancia.NovaInstancia<EntregaInfo>(dr);
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