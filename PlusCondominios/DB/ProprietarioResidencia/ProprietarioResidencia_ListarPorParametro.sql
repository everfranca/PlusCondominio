USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioResidencia_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioResidencia_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[ProprietarioResidencia_ListarPorParametro] 
 	@PRE_Codigo int = null,
	@PRE_PRT_Codigo int = null,
	@PRE_RES_Codigo int = null
AS
	SELECT PRE_Codigo, PRE_PRT_Codigo, PRE_RES_Codigo
	FROM ProprietarioResidencia
	WHERE  (PRE_Codigo = @PRE_Codigo OR @PRE_Codigo IS NULL) 
 	AND (PRE_PRT_Codigo = @PRE_PRT_Codigo OR @PRE_PRT_Codigo IS NULL) 
 	AND (PRE_RES_Codigo = @PRE_RES_Codigo OR @PRE_RES_Codigo IS NULL) 
 