USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioTelefone_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioTelefone_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[ProprietarioTelefone_ListarPorParametro] 
 	@PTE_Codigo int = null,
	@PTE_Telefone varchar (15)  = null,
	@PTE_PRT_Codigo int = null
AS
	SELECT PTE_Codigo, PTE_Telefone, PTE_PRT_Codigo
	FROM ProprietarioTelefone
	WHERE  (PTE_Codigo = @PTE_Codigo OR @PTE_Codigo IS NULL) 
 	AND (PTE_Telefone LIKE @PTE_Telefone OR @PTE_Telefone IS NULL) 
 	AND (PTE_PRT_Codigo = @PTE_PRT_Codigo OR @PTE_PRT_Codigo IS NULL) 
 