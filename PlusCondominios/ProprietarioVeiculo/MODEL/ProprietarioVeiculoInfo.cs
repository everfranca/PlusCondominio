using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class ProprietarioVeiculoInfo : BaseInfo
	{
		public ProprietarioVeiculoInfo()
		{ }

		private int _PVE_Codigo;
		private string _PVE_Veiculo;
		private string _PVE_Placa;
		private int _PVE_PRT_Codigo;

		[AtributoCampo(true, "PVE_Codigo", 4, false)]
		public int PVE_Codigo
		{
			get { return _PVE_Codigo; }
			set
			{
				if(_PVE_Codigo != value)
					IsDirty = true;
				_PVE_Codigo = value;
			}
		}

		[AtributoCampo("PVE_Veiculo", 50, true)]
		public string PVE_Veiculo
		{
			get { return _PVE_Veiculo; }
			set
			{
				if(_PVE_Veiculo != value)
					IsDirty = true;
				_PVE_Veiculo = value;
			}
		}

		[AtributoCampo("PVE_Placa", 10, true)]
		public string PVE_Placa
		{
			get { return _PVE_Placa; }
			set
			{
				if(_PVE_Placa != value)
					IsDirty = true;
				_PVE_Placa = value;
			}
		}

		[AtributoCampo("PVE_PRT_Codigo", 4, false)]
		public int PVE_PRT_Codigo
		{
			get { return _PVE_PRT_Codigo; }
			set
			{
				if(_PVE_PRT_Codigo != value)
					IsDirty = true;
				_PVE_PRT_Codigo = value;
			}
		}
	}
}