using Nucleo;
using System;
namespace PlusCondominios.Model
{
	public class UsuarioInfo : BaseInfo
	{
		public UsuarioInfo()
		{ }

		private int _USU_Codigo;
		private string _USU_Login;
		private string _USU_Senha;
		private string _USU_Email;
		private int _USU_PRF_Codigo;
		private string _USU_EMP_Codigo;

		[AtributoCampo(true, "USU_Codigo", 4, false)]
		public int USU_Codigo
		{
			get { return _USU_Codigo; }
			set
			{
				if(_USU_Codigo != value)
					IsDirty = true;
				_USU_Codigo = value;
			}
		}

		[AtributoCampo("USU_Login", 50, true)]
		public string USU_Login
		{
			get { return _USU_Login; }
			set
			{
				if(_USU_Login != value)
					IsDirty = true;
				_USU_Login = value;
			}
		}

		[AtributoCampo("USU_Senha", 50, true)]
		public string USU_Senha
		{
			get { return _USU_Senha; }
			set
			{
				if(_USU_Senha != value)
					IsDirty = true;
				_USU_Senha = value;
			}
		}

		[AtributoCampo("USU_Email", 50, true)]
		public string USU_Email
		{
			get { return _USU_Email; }
			set
			{
				if(_USU_Email != value)
					IsDirty = true;
				_USU_Email = value;
			}
		}

		[AtributoCampo("USU_PRF_Codigo", 4, true)]
		public int USU_PRF_Codigo
		{
			get { return _USU_PRF_Codigo; }
			set
			{
				if(_USU_PRF_Codigo != value)
					IsDirty = true;
				_USU_PRF_Codigo = value;
			}
		}

		[AtributoCampo("USU_EMP_Codigo", 50, true)]
		public string USU_EMP_Codigo
		{
			get { return _USU_EMP_Codigo; }
			set
			{
				if(_USU_EMP_Codigo != value)
					IsDirty = true;
				_USU_EMP_Codigo = value;
			}
		}
	}
}