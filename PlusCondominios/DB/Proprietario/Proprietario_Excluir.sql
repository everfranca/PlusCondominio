USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proprietario_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proprietario_Excluir]
GO

CREATE PROCEDURE [dbo].[Proprietario_Excluir] 
 	@PRT_Codigo int
AS
	DELETE FROM Proprietario
	WHERE
 		PRT_Codigo = @PRT_Codigo; 