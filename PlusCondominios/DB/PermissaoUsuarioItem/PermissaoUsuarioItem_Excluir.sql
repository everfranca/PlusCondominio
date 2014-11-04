USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PermissaoUsuarioItem_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PermissaoUsuarioItem_Excluir]
GO

CREATE PROCEDURE [dbo].[PermissaoUsuarioItem_Excluir] 
 	@PER_Codigo int
AS
	DELETE FROM PermissaoUsuarioItem
	WHERE
 		PER_Codigo = @PER_Codigo; 