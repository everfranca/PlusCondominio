USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuario_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Usuario_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[Usuario_ListarPorCodigo] 
 @USU_Codigo int
AS
	SELECT USU_Codigo, USU_Login, USU_Senha, USU_Email, USU_PRF_Codigo, USU_EMP_Codigo
	FROM Usuario
	WHERE USU_Codigo = @USU_Codigo