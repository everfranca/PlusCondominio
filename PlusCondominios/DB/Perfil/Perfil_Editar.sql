USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Perfil_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Perfil_Editar]
GO

CREATE PROCEDURE [dbo].[Perfil_Editar] 
 	@PRF_Codigo int = null,
	@PRF_Nome varchar (50)  = null
AS
	UPDATE Perfil
	SET
 		PRF_Nome = @PRF_Nome
	WHERE
 		PRF_Codigo = @PRF_Codigo;