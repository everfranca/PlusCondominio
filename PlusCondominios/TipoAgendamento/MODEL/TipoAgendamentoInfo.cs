using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class TipoAgendamentoInfo : BaseInfo
	{
		public TipoAgendamentoInfo()
		{ }

		private int _TAG_Codigo;
		private string _TAG_Descricao;

		[AtributoCampo(true, "TAG_Codigo", 4, false)]
		public int TAG_Codigo
		{
			get { return _TAG_Codigo; }
			set
			{
				if(_TAG_Codigo != value)
					IsDirty = true;
				_TAG_Codigo = value;
			}
		}

		[AtributoCampo("TAG_Descricao", 50, true)]
		public string TAG_Descricao
		{
			get { return _TAG_Descricao; }
			set
			{
				if(_TAG_Descricao != value)
					IsDirty = true;
				_TAG_Descricao = value;
			}
		}
	}
}