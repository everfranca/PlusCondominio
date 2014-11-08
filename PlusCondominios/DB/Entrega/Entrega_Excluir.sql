USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Entrega_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Entrega_Excluir]
GO

CREATE PROCEDURE [dbo].[Entrega_Excluir] 
 	@ENT_Codigo int
AS
	DELETE FROM Entrega
	WHERE
 		ENT_Codigo = @ENT_Codigo; 