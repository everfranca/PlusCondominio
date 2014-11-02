using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class PerfilInfo : BaseInfo
	{
		public PerfilInfo()
		{ }

		private int _PRF_Codigo;
		private string _PRF_Nome;

		[AtributoCampo(true, "PRF_Codigo", 4, false)]
		public int PRF_Codigo
		{
			get { return _PRF_Codigo; }
			set
			{
				if(_PRF_Codigo != value)
					IsDirty = true;
				_PRF_Codigo = value;
			}
		}

		[AtributoCampo("PRF_Nome", 50, true)]
		public string PRF_Nome
		{
			get { return _PRF_Nome; }
			set
			{
				if(_PRF_Nome != value)
					IsDirty = true;
				_PRF_Nome = value;
			}
		}
	}
}