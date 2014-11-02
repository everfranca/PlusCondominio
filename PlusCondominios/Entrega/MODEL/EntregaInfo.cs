using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class EntregaInfo : BaseInfo
	{
		public EntregaInfo()
		{ }

		private int _ENT_Codigo;
		private int _ENT_TEN_Codigo;
		private string _ENT_Descricao;
		private DateTime _ENT_Data;
		private int _ENT_RES_Codigo;
		private string _ENT_EmpresaEntregou;
		private string _ENT_NomeEntregador;
		private string _ENT_TelefoneContato;

		[AtributoCampo("ENT_Codigo", 4, false)]
		public int ENT_Codigo
		{
			get { return _ENT_Codigo; }
			set
			{
				if(_ENT_Codigo != value)
					IsDirty = true;
				_ENT_Codigo = value;
			}
		}

		[AtributoCampo("ENT_TEN_Codigo", 4, true)]
		public int ENT_TEN_Codigo
		{
			get { return _ENT_TEN_Codigo; }
			set
			{
				if(_ENT_TEN_Codigo != value)
					IsDirty = true;
				_ENT_TEN_Codigo = value;
			}
		}

		[AtributoCampo("ENT_Descricao", 100, true)]
		public string ENT_Descricao
		{
			get { return _ENT_Descricao; }
			set
			{
				if(_ENT_Descricao != value)
					IsDirty = true;
				_ENT_Descricao = value;
			}
		}

		[AtributoCampo("ENT_Data", 16, true)]
		public DateTime ENT_Data
		{
			get { return _ENT_Data; }
			set
			{
				if(_ENT_Data != value)
					IsDirty = true;
				_ENT_Data = value;
			}
		}

		[AtributoCampo("ENT_RES_Codigo", 4, true)]
		public int ENT_RES_Codigo
		{
			get { return _ENT_RES_Codigo; }
			set
			{
				if(_ENT_RES_Codigo != value)
					IsDirty = true;
				_ENT_RES_Codigo = value;
			}
		}

		[AtributoCampo("ENT_EmpresaEntregou", 100, true)]
		public string ENT_EmpresaEntregou
		{
			get { return _ENT_EmpresaEntregou; }
			set
			{
				if(_ENT_EmpresaEntregou != value)
					IsDirty = true;
				_ENT_EmpresaEntregou = value;
			}
		}

		[AtributoCampo("ENT_NomeEntregador", 100, true)]
		public string ENT_NomeEntregador
		{
			get { return _ENT_NomeEntregador; }
			set
			{
				if(_ENT_NomeEntregador != value)
					IsDirty = true;
				_ENT_NomeEntregador = value;
			}
		}

		[AtributoCampo("ENT_TelefoneContato", 15, true)]
		public string ENT_TelefoneContato
		{
			get { return _ENT_TelefoneContato; }
			set
			{
				if(_ENT_TelefoneContato != value)
					IsDirty = true;
				_ENT_TelefoneContato = value;
			}
		}
	}
}