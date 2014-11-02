using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class AcessoProfissionalInfo : BaseInfo
	{
		public AcessoProfissionalInfo()
		{ }

		private int _APR_Codigo;
		private int _APR_PRO_Codigo;
		private DateTime _APR_DataEntrada;
		private DateTime _APR_DataSaida;
		private string _APR_Veiculo;
		private string _APR_Placa;
		private int _APR_RES_Codigo;
		private string _APR_Telefone;
		private string _APR_Observacao;

		[AtributoCampo(true, "APR_Codigo", 4, false)]
		public int APR_Codigo
		{
			get { return _APR_Codigo; }
			set
			{
				if(_APR_Codigo != value)
					IsDirty = true;
				_APR_Codigo = value;
			}
		}

		[AtributoCampo("APR_PRO_Codigo", 4, true)]
		public int APR_PRO_Codigo
		{
			get { return _APR_PRO_Codigo; }
			set
			{
				if(_APR_PRO_Codigo != value)
					IsDirty = true;
				_APR_PRO_Codigo = value;
			}
		}

		[AtributoCampo("APR_DataEntrada", 16, true)]
		public DateTime APR_DataEntrada
		{
			get { return _APR_DataEntrada; }
			set
			{
				if(_APR_DataEntrada != value)
					IsDirty = true;
				_APR_DataEntrada = value;
			}
		}

		[AtributoCampo("APR_DataSaida", 16, true)]
		public DateTime APR_DataSaida
		{
			get { return _APR_DataSaida; }
			set
			{
				if(_APR_DataSaida != value)
					IsDirty = true;
				_APR_DataSaida = value;
			}
		}

		[AtributoCampo("APR_Veiculo", 50, true)]
		public string APR_Veiculo
		{
			get { return _APR_Veiculo; }
			set
			{
				if(_APR_Veiculo != value)
					IsDirty = true;
				_APR_Veiculo = value;
			}
		}

		[AtributoCampo("APR_Placa", 10, true)]
		public string APR_Placa
		{
			get { return _APR_Placa; }
			set
			{
				if(_APR_Placa != value)
					IsDirty = true;
				_APR_Placa = value;
			}
		}

		[AtributoCampo("APR_RES_Codigo", 4, true)]
		public int APR_RES_Codigo
		{
			get { return _APR_RES_Codigo; }
			set
			{
				if(_APR_RES_Codigo != value)
					IsDirty = true;
				_APR_RES_Codigo = value;
			}
		}

		[AtributoCampo("APR_Telefone", 15, true)]
		public string APR_Telefone
		{
			get { return _APR_Telefone; }
			set
			{
				if(_APR_Telefone != value)
					IsDirty = true;
				_APR_Telefone = value;
			}
		}

		[AtributoCampo("APR_Observacao", 500, true)]
		public string APR_Observacao
		{
			get { return _APR_Observacao; }
			set
			{
				if(_APR_Observacao != value)
					IsDirty = true;
				_APR_Observacao = value;
			}
		}
	}
}