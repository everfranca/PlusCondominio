USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoEntrega_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TipoEntrega_Excluir]
GO

CREATE PROCEDURE [dbo].[TipoEntrega_Excluir] 
 	@TEN_Codigo int
AS
	DELETE FROM TipoEntrega
	WHERE
 		TEN_Codigo = @TEN_Codigo; 