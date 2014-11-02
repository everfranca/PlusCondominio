using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class VisitanteInfo : BaseInfo
	{
		public VisitanteInfo()
		{ }

		private int _VIS_Codigo;
		private string _VIS_Cpf;
		private string _VIS_Rg;
		private string _VIS_Nome;
		private string _VIS_Telefone;
		private string _VIS_Veiculo;
		private string _VIS_Placa;
		private string _VIS_Foto;

		[AtributoCampo(true, "VIS_Codigo", 4, false)]
		public int VIS_Codigo
		{
			get { return _VIS_Codigo; }
			set
			{
				if(_VIS_Codigo != value)
					IsDirty = true;
				_VIS_Codigo = value;
			}
		}

		[AtributoCampo("VIS_Cpf", 20, true)]
		public string VIS_Cpf
		{
			get { return _VIS_Cpf; }
			set
			{
				if(_VIS_Cpf != value)
					IsDirty = true;
				_VIS_Cpf = value;
			}
		}

		[AtributoCampo("VIS_Rg", 20, true)]
		public string VIS_Rg
		{
			get { return _VIS_Rg; }
			set
			{
				if(_VIS_Rg != value)
					IsDirty = true;
				_VIS_Rg = value;
			}
		}

		[AtributoCampo("VIS_Nome", 100, true)]
		public string VIS_Nome
		{
			get { return _VIS_Nome; }
			set
			{
				if(_VIS_Nome != value)
					IsDirty = true;
				_VIS_Nome = value;
			}
		}

		[AtributoCampo("VIS_Telefone", 15, true)]
		public string VIS_Telefone
		{
			get { return _VIS_Telefone; }
			set
			{
				if(_VIS_Telefone != value)
					IsDirty = true;
				_VIS_Telefone = value;
			}
		}

		[AtributoCampo("VIS_Veiculo", 50, true)]
		public string VIS_Veiculo
		{
			get { return _VIS_Veiculo; }
			set
			{
				if(_VIS_Veiculo != value)
					IsDirty = true;
				_VIS_Veiculo = value;
			}
		}

		[AtributoCampo("VIS_Placa", 10, true)]
		public string VIS_Placa
		{
			get { return _VIS_Placa; }
			set
			{
				if(_VIS_Placa != value)
					IsDirty = true;
				_VIS_Placa = value;
			}
		}

		[AtributoCampo("VIS_Foto", 300, true)]
		public string VIS_Foto
		{
			get { return _VIS_Foto; }
			set
			{
				if(_VIS_Foto != value)
					IsDirty = true;
				_VIS_Foto = value;
			}
		}
	}
}