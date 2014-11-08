USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Item_Excluir]
GO

CREATE PROCEDURE [dbo].[Item_Excluir] 
 	@ITE_Codigo int
AS
	DELETE FROM Item
	WHERE
 		ITE_Codigo = @ITE_Codigo; 