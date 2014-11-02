using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class ProprietarioResidenciaInfo : BaseInfo
	{
		public ProprietarioResidenciaInfo()
		{ }

		private int _PRE_Codigo;
		private int _PRE_PRT_Codigo;
		private int _PRE_RES_Codigo;

		[AtributoCampo(true, "PRE_Codigo", 4, false)]
		public int PRE_Codigo
		{
			get { return _PRE_Codigo; }
			set
			{
				if(_PRE_Codigo != value)
					IsDirty = true;
				_PRE_Codigo = value;
			}
		}

		[AtributoCampo("PRE_PRT_Codigo", 4, true)]
		public int PRE_PRT_Codigo
		{
			get { return _PRE_PRT_Codigo; }
			set
			{
				if(_PRE_PRT_Codigo != value)
					IsDirty = true;
				_PRE_PRT_Codigo = value;
			}
		}

		[AtributoCampo("PRE_RES_Codigo", 4, true)]
		public int PRE_RES_Codigo
		{
			get { return _PRE_RES_Codigo; }
			set
			{
				if(_PRE_RES_Codigo != value)
					IsDirty = true;
				_PRE_RES_Codigo = value;
			}
		}
	}
}