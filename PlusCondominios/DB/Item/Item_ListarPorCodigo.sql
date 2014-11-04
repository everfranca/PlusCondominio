USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Item_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[Item_ListarPorCodigo] 
 @ITE_Codigo int
AS
	SELECT ITE_Codigo, ITE_Nome, ITE_Formulario
	FROM Item
	WHERE ITE_Codigo = @ITE_Codigo