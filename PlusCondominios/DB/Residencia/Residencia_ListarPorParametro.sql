USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Residencia_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Residencia_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[Residencia_ListarPorParametro] 
 	@RES_Codigo int = null,
	@RES_Torre varchar (10)  = null,
	@RES_Bloco varchar (10)  = null,
	@RES_Numero varchar (10)  = null,
	@RES_Ramal varchar (10)  = null,
	@RES_EMP_Codigo varchar (50)  = null
AS
	SELECT RES_Codigo, RES_Torre, RES_Bloco, RES_Numero, RES_Ramal, RES_EMP_Codigo
	FROM Residencia
	WHERE  (RES_Codigo = @RES_Codigo OR @RES_Codigo IS NULL) 
 	AND (RES_Torre LIKE @RES_Torre OR @RES_Torre IS NULL) 
 	AND (RES_Bloco LIKE @RES_Bloco OR @RES_Bloco IS NULL) 
 	AND (RES_Numero LIKE @RES_Numero OR @RES_Numero IS NULL) 
 	AND (RES_Ramal LIKE @RES_Ramal OR @RES_Ramal IS NULL) 
 	AND (RES_EMP_Codigo LIKE @RES_EMP_Codigo OR @RES_EMP_Codigo IS NULL) 
 