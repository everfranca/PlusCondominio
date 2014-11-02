using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class TipoEntregaInfo : BaseInfo
	{
		public TipoEntregaInfo()
		{ }

		private int _TEN_Codigo;
		private string _TEN_Nome;

		[AtributoCampo(true, "TEN_Codigo", 4, false)]
		public int TEN_Codigo
		{
			get { return _TEN_Codigo; }
			set
			{
				if(_TEN_Codigo != value)
					IsDirty = true;
				_TEN_Codigo = value;
			}
		}

		[AtributoCampo("TEN_Nome", 50, true)]
		public string TEN_Nome
		{
			get { return _TEN_Nome; }
			set
			{
				if(_TEN_Nome != value)
					IsDirty = true;
				_TEN_Nome = value;
			}
		}
	}
}