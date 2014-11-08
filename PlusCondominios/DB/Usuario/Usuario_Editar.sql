USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuario_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Usuario_Editar]
GO

CREATE PROCEDURE [dbo].[Usuario_Editar] 
 	@USU_Codigo int = null,
	@USU_Login varchar (50)  = null,
	@USU_Senha varchar (50)  = null,
	@USU_Email varchar (50)  = null,
	@USU_PRF_Codigo int = null,
	@USU_EMP_Codigo varchar (50)  = null
AS
	UPDATE Usuario
	SET
 		USU_Login = @USU_Login, 
		USU_Senha = @USU_Senha, 
		USU_Email = @USU_Email, 
		USU_PRF_Codigo = @USU_PRF_Codigo, 
		USU_EMP_Codigo = @USU_EMP_Codigo
	WHERE
 		USU_Codigo = @USU_Codigo;