using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class ProfissionalInfo : BaseInfo
	{
		public ProfissionalInfo()
		{ }

		private int _PRO_Codigo;
		private string _PRO_Cpf;
		private string _PRO_Rg;
		private string _PRO_Nome;
		private string _PRO_Telefone;
		private string _PRO_Veiculo;
		private string _PRO_Placa;
		private string _PRO_Foto;
		private string _PRO_Empresa;

		[AtributoCampo(true, "PRO_Codigo", 4, false)]
		public int PRO_Codigo
		{
			get { return _PRO_Codigo; }
			set
			{
				if(_PRO_Codigo != value)
					IsDirty = true;
				_PRO_Codigo = value;
			}
		}

		[AtributoCampo("PRO_Cpf", 20, true)]
		public string PRO_Cpf
		{
			get { return _PRO_Cpf; }
			set
			{
				if(_PRO_Cpf != value)
					IsDirty = true;
				_PRO_Cpf = value;
			}
		}

		[AtributoCampo("PRO_Rg", 20, true)]
		public string PRO_Rg
		{
			get { return _PRO_Rg; }
			set
			{
				if(_PRO_Rg != value)
					IsDirty = true;
				_PRO_Rg = value;
			}
		}

		[AtributoCampo("PRO_Nome", 100, true)]
		public string PRO_Nome
		{
			get { return _PRO_Nome; }
			set
			{
				if(_PRO_Nome != value)
					IsDirty = true;
				_PRO_Nome = value;
			}
		}

		[AtributoCampo("PRO_Telefone", 15, true)]
		public string PRO_Telefone
		{
			get { return _PRO_Telefone; }
			set
			{
				if(_PRO_Telefone != value)
					IsDirty = true;
				_PRO_Telefone = value;
			}
		}

		[AtributoCampo("PRO_Veiculo", 50, true)]
		public string PRO_Veiculo
		{
			get { return _PRO_Veiculo; }
			set
			{
				if(_PRO_Veiculo != value)
					IsDirty = true;
				_PRO_Veiculo = value;
			}
		}

		[AtributoCampo("PRO_Placa", 10, true)]
		public string PRO_Placa
		{
			get { return _PRO_Placa; }
			set
			{
				if(_PRO_Placa != value)
					IsDirty = true;
				_PRO_Placa = value;
			}
		}

		[AtributoCampo("PRO_Foto", 300, true)]
		public string PRO_Foto
		{
			get { return _PRO_Foto; }
			set
			{
				if(_PRO_Foto != value)
					IsDirty = true;
				_PRO_Foto = value;
			}
		}

		[AtributoCampo("PRO_Empresa", 100, true)]
		public string PRO_Empresa
		{
			get { return _PRO_Empresa; }
			set
			{
				if(_PRO_Empresa != value)
					IsDirty = true;
				_PRO_Empresa = value;
			}
		}
	}
}