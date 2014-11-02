using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class PermissaoUsuarioItemInfo : BaseInfo
	{
		public PermissaoUsuarioItemInfo()
		{ }

		private int _PER_Codigo;
		private int _PER_PRF_Codigo;
		private int _PER_USU_Codigo;
		private int _PER_ITE_Codigo;

		[AtributoCampo(true, "PER_Codigo", 4, false)]
		public int PER_Codigo
		{
			get { return _PER_Codigo; }
			set
			{
				if(_PER_Codigo != value)
					IsDirty = true;
				_PER_Codigo = value;
			}
		}

		[AtributoCampo("PER_PRF_Codigo", 4, true)]
		public int PER_PRF_Codigo
		{
			get { return _PER_PRF_Codigo; }
			set
			{
				if(_PER_PRF_Codigo != value)
					IsDirty = true;
				_PER_PRF_Codigo = value;
			}
		}

		[AtributoCampo("PER_USU_Codigo", 4, true)]
		public int PER_USU_Codigo
		{
			get { return _PER_USU_Codigo; }
			set
			{
				if(_PER_USU_Codigo != value)
					IsDirty = true;
				_PER_USU_Codigo = value;
			}
		}

		[AtributoCampo("PER_ITE_Codigo", 4, true)]
		public int PER_ITE_Codigo
		{
			get { return _PER_ITE_Codigo; }
			set
			{
				if(_PER_ITE_Codigo != value)
					IsDirty = true;
				_PER_ITE_Codigo = value;
			}
		}
	}
}