using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class ItemInfo : BaseInfo
	{
		public ItemInfo()
		{ }

		private int _ITE_Codigo;
		private string _ITE_Nome;
		private string _ITE_Formulario;

		[AtributoCampo(true, "ITE_Codigo", 4, false)]
		public int ITE_Codigo
		{
			get { return _ITE_Codigo; }
			set
			{
				if(_ITE_Codigo != value)
					IsDirty = true;
				_ITE_Codigo = value;
			}
		}

		[AtributoCampo("ITE_Nome", 50, true)]
		public string ITE_Nome
		{
			get { return _ITE_Nome; }
			set
			{
				if(_ITE_Nome != value)
					IsDirty = true;
				_ITE_Nome = value;
			}
		}

		[AtributoCampo("ITE_Formulario", 100, true)]
		public string ITE_Formulario
		{
			get { return _ITE_Formulario; }
			set
			{
				if(_ITE_Formulario != value)
					IsDirty = true;
				_ITE_Formulario = value;
			}
		}
	}
}