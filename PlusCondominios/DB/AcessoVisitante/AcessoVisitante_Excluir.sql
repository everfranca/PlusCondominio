USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AcessoVisitante_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AcessoVisitante_Excluir]
GO

CREATE PROCEDURE [dbo].[AcessoVisitante_Excluir] 
 	@AVI_Codigo int
AS
	DELETE FROM AcessoVisitante
	WHERE
 		AVI_Codigo = @AVI_Codigo; 