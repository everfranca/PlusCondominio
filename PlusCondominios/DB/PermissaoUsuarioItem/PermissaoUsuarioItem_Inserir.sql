USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PermissaoUsuarioItem_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PermissaoUsuarioItem_Inserir]
GO

CREATE PROCEDURE [dbo].[PermissaoUsuarioItem_Inserir] 
 	@PER_PRF_Codigo int = null ,
	@PER_USU_Codigo int = null ,
	@PER_ITE_Codigo int = null AS 

	INSERT INTO PermissaoUsuarioItem
		 (PER_PRF_Codigo, PER_USU_Codigo, PER_ITE_Codigo) 
	VALUES
		 (@PER_PRF_Codigo, @PER_USU_Codigo, @PER_ITE_Codigo); 

	SELECT * FROM PermissaoUsuarioItem WHERE PER_Codigo = SCOPE_IDENTITY()