USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PermissaoUsuarioItem_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PermissaoUsuarioItem_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[PermissaoUsuarioItem_ListarPorParametro] 
 	@PER_Codigo int = null,
	@PER_PRF_Codigo int = null,
	@PER_USU_Codigo int = null,
	@PER_ITE_Codigo int = null
AS
	SELECT PER_Codigo, PER_PRF_Codigo, PER_USU_Codigo, PER_ITE_Codigo
	FROM PermissaoUsuarioItem
	WHERE  (PER_Codigo = @PER_Codigo OR @PER_Codigo IS NULL) 
 	AND (PER_PRF_Codigo = @PER_PRF_Codigo OR @PER_PRF_Codigo IS NULL) 
 	AND (PER_USU_Codigo = @PER_USU_Codigo OR @PER_USU_Codigo IS NULL) 
 	AND (PER_ITE_Codigo = @PER_ITE_Codigo OR @PER_ITE_Codigo IS NULL) 
 