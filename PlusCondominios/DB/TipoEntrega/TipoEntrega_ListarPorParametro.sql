USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoEntrega_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TipoEntrega_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[TipoEntrega_ListarPorParametro] 
 	@TEN_Codigo int = null,
	@TEN_Nome varchar (50)  = null
AS
	SELECT TEN_Codigo, TEN_Nome
	FROM TipoEntrega
	WHERE  (TEN_Codigo = @TEN_Codigo OR @TEN_Codigo IS NULL) 
 	AND (TEN_Nome LIKE @TEN_Nome OR @TEN_Nome IS NULL) 
 