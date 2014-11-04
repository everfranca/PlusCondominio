USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuario_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Usuario_Excluir]
GO

CREATE PROCEDURE [dbo].[Usuario_Excluir] 
 	@USU_Codigo int
AS
	DELETE FROM Usuario
	WHERE
 		USU_Codigo = @USU_Codigo; 