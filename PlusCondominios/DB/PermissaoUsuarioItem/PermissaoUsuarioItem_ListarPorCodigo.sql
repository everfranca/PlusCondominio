USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PermissaoUsuarioItem_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PermissaoUsuarioItem_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[PermissaoUsuarioItem_ListarPorCodigo] 
 @PER_Codigo int
AS
	SELECT PER_Codigo, PER_PRF_Codigo, PER_USU_Codigo, PER_ITE_Codigo
	FROM PermissaoUsuarioItem
	WHERE PER_Codigo = @PER_Codigo