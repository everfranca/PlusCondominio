USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PermissaoUsuarioItem_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PermissaoUsuarioItem_Editar]
GO

CREATE PROCEDURE [dbo].[PermissaoUsuarioItem_Editar] 
 	@PER_Codigo int = null,
	@PER_PRF_Codigo int = null,
	@PER_USU_Codigo int = null,
	@PER_ITE_Codigo int = null
AS
	UPDATE PermissaoUsuarioItem
	SET
 		PER_PRF_Codigo = @PER_PRF_Codigo, 
		PER_USU_Codigo = @PER_USU_Codigo, 
		PER_ITE_Codigo = @PER_ITE_Codigo
	WHERE
 		PER_Codigo = @PER_Codigo;