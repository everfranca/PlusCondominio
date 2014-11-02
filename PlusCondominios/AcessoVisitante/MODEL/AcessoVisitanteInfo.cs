using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class AcessoVisitanteInfo : BaseInfo
	{
		public AcessoVisitanteInfo()
		{ }

		private int _AVI_Codigo;
		private int _AVI_VIS_Codigo;
		private DateTime _AVI_DataEntrada;
		private DateTime _AVI_DataSaida;
		private string _AVI_Veiculo;
		private string _AVI_Placa;
		private int _AVI_RES_Codigo;
		private string _AVI_Telefone;
		private string _AVI_Observacao;

		[AtributoCampo(true, "AVI_Codigo", 4, false)]
		public int AVI_Codigo
		{
			get { return _AVI_Codigo; }
			set
			{
				if(_AVI_Codigo != value)
					IsDirty = true;
				_AVI_Codigo = value;
			}
		}

		[AtributoCampo("AVI_VIS_Codigo", 4, true)]
		public int AVI_VIS_Codigo
		{
			get { return _AVI_VIS_Codigo; }
			set
			{
				if(_AVI_VIS_Codigo != value)
					IsDirty = true;
				_AVI_VIS_Codigo = value;
			}
		}

		[AtributoCampo("AVI_DataEntrada", 16, true)]
		public DateTime AVI_DataEntrada
		{
			get { return _AVI_DataEntrada; }
			set
			{
				if(_AVI_DataEntrada != value)
					IsDirty = true;
				_AVI_DataEntrada = value;
			}
		}

		[AtributoCampo("AVI_DataSaida", 16, true)]
		public DateTime AVI_DataSaida
		{
			get { return _AVI_DataSaida; }
			set
			{
				if(_AVI_DataSaida != value)
					IsDirty = true;
				_AVI_DataSaida = value;
			}
		}

		[AtributoCampo("AVI_Veiculo", 50, true)]
		public string AVI_Veiculo
		{
			get { return _AVI_Veiculo; }
			set
			{
				if(_AVI_Veiculo != value)
					IsDirty = true;
				_AVI_Veiculo = value;
			}
		}

		[AtributoCampo("AVI_Placa", 10, true)]
		public string AVI_Placa
		{
			get { return _AVI_Placa; }
			set
			{
				if(_AVI_Placa != value)
					IsDirty = true;
				_AVI_Placa = value;
			}
		}

		[AtributoCampo("AVI_RES_Codigo", 4, true)]
		public int AVI_RES_Codigo
		{
			get { return _AVI_RES_Codigo; }
			set
			{
				if(_AVI_RES_Codigo != value)
					IsDirty = true;
				_AVI_RES_Codigo = value;
			}
		}

		[AtributoCampo("AVI_Telefone", 15, true)]
		public string AVI_Telefone
		{
			get { return _AVI_Telefone; }
			set
			{
				if(_AVI_Telefone != value)
					IsDirty = true;
				_AVI_Telefone = value;
			}
		}

		[AtributoCampo("AVI_Observacao", 500, true)]
		public string AVI_Observacao
		{
			get { return _AVI_Observacao; }
			set
			{
				if(_AVI_Observacao != value)
					IsDirty = true;
				_AVI_Observacao = value;
			}
		}
	}
}