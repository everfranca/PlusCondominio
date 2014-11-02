using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class ResidenciaInfo : BaseInfo
	{
		public ResidenciaInfo()
		{ }

		private int _RES_Codigo;
		private string _RES_Torre;
		private string _RES_Bloco;
		private string _RES_Numero;
		private string _RES_Ramal;
		private string _RES_EMP_Codigo;

		[AtributoCampo(true, "RES_Codigo", 4, false)]
		public int RES_Codigo
		{
			get { return _RES_Codigo; }
			set
			{
				if(_RES_Codigo != value)
					IsDirty = true;
				_RES_Codigo = value;
			}
		}

		[AtributoCampo("RES_Torre", 10, true)]
		public string RES_Torre
		{
			get { return _RES_Torre; }
			set
			{
				if(_RES_Torre != value)
					IsDirty = true;
				_RES_Torre = value;
			}
		}

		[AtributoCampo("RES_Bloco", 10, true)]
		public string RES_Bloco
		{
			get { return _RES_Bloco; }
			set
			{
				if(_RES_Bloco != value)
					IsDirty = true;
				_RES_Bloco = value;
			}
		}

		[AtributoCampo("RES_Numero", 10, true)]
		public string RES_Numero
		{
			get { return _RES_Numero; }
			set
			{
				if(_RES_Numero != value)
					IsDirty = true;
				_RES_Numero = value;
			}
		}

		[AtributoCampo("RES_Ramal", 10, true)]
		public string RES_Ramal
		{
			get { return _RES_Ramal; }
			set
			{
				if(_RES_Ramal != value)
					IsDirty = true;
				_RES_Ramal = value;
			}
		}

		[AtributoCampo("RES_EMP_Codigo", 50, true)]
		public string RES_EMP_Codigo
		{
			get { return _RES_EMP_Codigo; }
			set
			{
				if(_RES_EMP_Codigo != value)
					IsDirty = true;
				_RES_EMP_Codigo = value;
			}
		}
	}
}