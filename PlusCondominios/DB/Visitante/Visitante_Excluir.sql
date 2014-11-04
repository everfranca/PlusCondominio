USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visitante_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Visitante_Excluir]
GO

CREATE PROCEDURE [dbo].[Visitante_Excluir] 
 	@VIS_Codigo int
AS
	DELETE FROM Visitante
	WHERE
 		VIS_Codigo = @VIS_Codigo; 