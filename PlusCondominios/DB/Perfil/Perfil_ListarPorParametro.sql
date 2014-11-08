USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Perfil_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Perfil_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[Perfil_ListarPorParametro] 
 	@PRF_Codigo int = null,
	@PRF_Nome varchar (50)  = null
AS
	SELECT PRF_Codigo, PRF_Nome
	FROM Perfil
	WHERE  (PRF_Codigo = @PRF_Codigo OR @PRF_Codigo IS NULL) 
 	AND (PRF_Nome LIKE @PRF_Nome OR @PRF_Nome IS NULL) 
 