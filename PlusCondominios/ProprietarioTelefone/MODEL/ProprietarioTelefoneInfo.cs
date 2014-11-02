using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class ProprietarioTelefoneInfo : BaseInfo
	{
		public ProprietarioTelefoneInfo()
		{ }

		private int _PTE_Codigo;
		private string _PTE_Telefone;
		private int _PTE_PRT_Codigo;

		[AtributoCampo(true, "PTE_Codigo", 4, false)]
		public int PTE_Codigo
		{
			get { return _PTE_Codigo; }
			set
			{
				if(_PTE_Codigo != value)
					IsDirty = true;
				_PTE_Codigo = value;
			}
		}

		[AtributoCampo("PTE_Telefone", 15, true)]
		public string PTE_Telefone
		{
			get { return _PTE_Telefone; }
			set
			{
				if(_PTE_Telefone != value)
					IsDirty = true;
				_PTE_Telefone = value;
			}
		}

		[AtributoCampo("PTE_PRT_Codigo", 4, false)]
		public int PTE_PRT_Codigo
		{
			get { return _PTE_PRT_Codigo; }
			set
			{
				if(_PTE_PRT_Codigo != value)
					IsDirty = true;
				_PTE_PRT_Codigo = value;
			}
		}
	}
}