USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Perfil_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Perfil_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[Perfil_ListarPorCodigo] 
 @PRF_Codigo int
AS
	SELECT PRF_Codigo, PRF_Nome
	FROM Perfil
	WHERE PRF_Codigo = @PRF_Codigo