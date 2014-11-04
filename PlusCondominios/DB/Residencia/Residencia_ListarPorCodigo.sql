USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Residencia_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Residencia_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[Residencia_ListarPorCodigo] 
 @RES_Codigo int
AS
	SELECT RES_Codigo, RES_Torre, RES_Bloco, RES_Numero, RES_Ramal, RES_EMP_Codigo
	FROM Residencia
	WHERE RES_Codigo = @RES_Codigo