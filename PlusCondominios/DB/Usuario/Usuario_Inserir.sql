USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuario_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Usuario_Inserir]
GO

CREATE PROCEDURE [dbo].[Usuario_Inserir] 
 	@USU_Login varchar (50)  = null ,
	@USU_Senha varchar (50)  = null ,
	@USU_Email varchar (50)  = null ,
	@USU_PRF_Codigo int = null ,
	@USU_EMP_Codigo varchar (50)  = null AS 

	INSERT INTO Usuario
		 (USU_Login, USU_Senha, USU_Email, USU_PRF_Codigo, USU_EMP_Codigo) 
	VALUES
		 (@USU_Login, @USU_Senha, @USU_Email, @USU_PRF_Codigo, @USU_EMP_Codigo); 

	SELECT * FROM Usuario WHERE USU_Codigo = SCOPE_IDENTITY()