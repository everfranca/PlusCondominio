USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuario_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Usuario_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[Usuario_ListarPorParametro] 
 	@USU_Codigo int = null,
	@USU_Login varchar (50)  = null,
	@USU_Senha varchar (50)  = null,
	@USU_Email varchar (50)  = null,
	@USU_PRF_Codigo int = null,
	@USU_EMP_Codigo varchar (50)  = null
AS
	SELECT USU_Codigo, USU_Login, USU_Senha, USU_Email, USU_PRF_Codigo, USU_EMP_Codigo
	FROM Usuario
	WHERE  (USU_Codigo = @USU_Codigo OR @USU_Codigo IS NULL) 
 	AND (USU_Login LIKE @USU_Login OR @USU_Login IS NULL) 
 	AND (USU_Senha LIKE @USU_Senha OR @USU_Senha IS NULL) 
 	AND (USU_Email LIKE @USU_Email OR @USU_Email IS NULL) 
 	AND (USU_PRF_Codigo = @USU_PRF_Codigo OR @USU_PRF_Codigo IS NULL) 
 	AND (USU_EMP_Codigo LIKE @USU_EMP_Codigo OR @USU_EMP_Codigo IS NULL) 
 