USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Perfil_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Perfil_Excluir]
GO

CREATE PROCEDURE [dbo].[Perfil_Excluir] 
 	@PRF_Codigo int
AS
	DELETE FROM Perfil
	WHERE
 		PRF_Codigo = @PRF_Codigo; 