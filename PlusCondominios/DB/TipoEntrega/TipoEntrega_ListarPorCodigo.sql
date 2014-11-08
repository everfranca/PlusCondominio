USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoEntrega_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TipoEntrega_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[TipoEntrega_ListarPorCodigo] 
 @TEN_Codigo int
AS
	SELECT TEN_Codigo, TEN_Nome
	FROM TipoEntrega
	WHERE TEN_Codigo = @TEN_Codigo