USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Profissional_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Profissional_Excluir]
GO

CREATE PROCEDURE [dbo].[Profissional_Excluir] 
 	@PRO_Codigo int
AS
	DELETE FROM Profissional
	WHERE
 		PRO_Codigo = @PRO_Codigo; 