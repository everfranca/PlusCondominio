using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class EmpresaInfo : BaseInfo
	{
		public EmpresaInfo()
		{ }

		private string _EMP_Codigo;
		private string _EMP_Nome;
		private string _EMP_FotoPequena;
		private string _EMP_FotoMedia;
		private string _EMP_FotoGrande;
		private string _EMP_Cnpj;
		private string _EMP_Telefone;

		[AtributoCampo("EMP_Codigo", 50, false)]
		public string EMP_Codigo
		{
			get { return _EMP_Codigo; }
			set
			{
				if(_EMP_Codigo != value)
					IsDirty = true;
				_EMP_Codigo = value;
			}
		}

		[AtributoCampo("EMP_Nome", 100, true)]
		public string EMP_Nome
		{
			get { return _EMP_Nome; }
			set
			{
				if(_EMP_Nome != value)
					IsDirty = true;
				_EMP_Nome = value;
			}
		}

		[AtributoCampo("EMP_FotoPequena", 300, true)]
		public string EMP_FotoPequena
		{
			get { return _EMP_FotoPequena; }
			set
			{
				if(_EMP_FotoPequena != value)
					IsDirty = true;
				_EMP_FotoPequena = value;
			}
		}

		[AtributoCampo("EMP_FotoMedia", 300, true)]
		public string EMP_FotoMedia
		{
			get { return _EMP_FotoMedia; }
			set
			{
				if(_EMP_FotoMedia != value)
					IsDirty = true;
				_EMP_FotoMedia = value;
			}
		}

		[AtributoCampo("EMP_FotoGrande", 300, true)]
		public string EMP_FotoGrande
		{
			get { return _EMP_FotoGrande; }
			set
			{
				if(_EMP_FotoGrande != value)
					IsDirty = true;
				_EMP_FotoGrande = value;
			}
		}

		[AtributoCampo("EMP_Cnpj", 20, true)]
		public string EMP_Cnpj
		{
			get { return _EMP_Cnpj; }
			set
			{
				if(_EMP_Cnpj != value)
					IsDirty = true;
				_EMP_Cnpj = value;
			}
		}

		[AtributoCampo("EMP_Telefone", 15, true)]
		public string EMP_Telefone
		{
			get { return _EMP_Telefone; }
			set
			{
				if(_EMP_Telefone != value)
					IsDirty = true;
				_EMP_Telefone = value;
			}
		}
	}
}