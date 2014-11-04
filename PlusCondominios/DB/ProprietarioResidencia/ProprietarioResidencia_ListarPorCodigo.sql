USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioResidencia_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioResidencia_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[ProprietarioResidencia_ListarPorCodigo] 
 @PRE_Codigo int
AS
	SELECT PRE_Codigo, PRE_PRT_Codigo, PRE_RES_Codigo
	FROM ProprietarioResidencia
	WHERE PRE_Codigo = @PRE_Codigo