USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioResidencia_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioResidencia_Editar]
GO

CREATE PROCEDURE [dbo].[ProprietarioResidencia_Editar] 
 	@PRE_Codigo int = null,
	@PRE_PRT_Codigo int = null,
	@PRE_RES_Codigo int = null
AS
	UPDATE ProprietarioResidencia
	SET
 		PRE_PRT_Codigo = @PRE_PRT_Codigo, 
		PRE_RES_Codigo = @PRE_RES_Codigo
	WHERE
 		PRE_Codigo = @PRE_Codigo;