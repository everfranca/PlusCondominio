USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Residencia_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Residencia_Excluir]
GO

CREATE PROCEDURE [dbo].[Residencia_Excluir] 
 	@RES_Codigo int
AS
	DELETE FROM Residencia
	WHERE
 		RES_Codigo = @RES_Codigo; 