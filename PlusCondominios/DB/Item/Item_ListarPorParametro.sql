USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Item_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[Item_ListarPorParametro] 
 	@ITE_Codigo int = null,
	@ITE_Nome varchar (50)  = null,
	@ITE_Formulario varchar (100)  = null
AS
	SELECT ITE_Codigo, ITE_Nome, ITE_Formulario
	FROM Item
	WHERE  (ITE_Codigo = @ITE_Codigo OR @ITE_Codigo IS NULL) 
 	AND (ITE_Nome LIKE @ITE_Nome OR @ITE_Nome IS NULL) 
 	AND (ITE_Formulario LIKE @ITE_Formulario OR @ITE_Formulario IS NULL) 
 