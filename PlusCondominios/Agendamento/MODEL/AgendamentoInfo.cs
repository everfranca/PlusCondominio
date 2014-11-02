using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class AgendamentoInfo : BaseInfo
	{
		public AgendamentoInfo()
		{ }

		private int _AGE_Codigo;
		private int _AGE_TAG_Codigo;
		private DateTime _AGE_DataHoraInicio;
		private DateTime _AGE_DataHoraFim;
		private int _AGE_PRT_Codigo;

		[AtributoCampo(true, "AGE_Codigo", 4, false)]
		public int AGE_Codigo
		{
			get { return _AGE_Codigo; }
			set
			{
				if(_AGE_Codigo != value)
					IsDirty = true;
				_AGE_Codigo = value;
			}
		}

		[AtributoCampo("AGE_TAG_Codigo", 4, true)]
		public int AGE_TAG_Codigo
		{
			get { return _AGE_TAG_Codigo; }
			set
			{
				if(_AGE_TAG_Codigo != value)
					IsDirty = true;
				_AGE_TAG_Codigo = value;
			}
		}

		[AtributoCampo("AGE_DataHoraInicio", 16, true)]
		public DateTime AGE_DataHoraInicio
		{
			get { return _AGE_DataHoraInicio; }
			set
			{
				if(_AGE_DataHoraInicio != value)
					IsDirty = true;
				_AGE_DataHoraInicio = value;
			}
		}

		[AtributoCampo("AGE_DataHoraFim", 16, true)]
		public DateTime AGE_DataHoraFim
		{
			get { return _AGE_DataHoraFim; }
			set
			{
				if(_AGE_DataHoraFim != value)
					IsDirty = true;
				_AGE_DataHoraFim = value;
			}
		}

		[AtributoCampo("AGE_PRT_Codigo", 4, true)]
		public int AGE_PRT_Codigo
		{
			get { return _AGE_PRT_Codigo; }
			set
			{
				if(_AGE_PRT_Codigo != value)
					IsDirty = true;
				_AGE_PRT_Codigo = value;
			}
		}
	}
}