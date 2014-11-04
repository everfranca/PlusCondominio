USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioResidencia_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioResidencia_Inserir]
GO

CREATE PROCEDURE [dbo].[ProprietarioResidencia_Inserir] 
 	@PRE_PRT_Codigo int = null ,
	@PRE_RES_Codigo int = null AS 

	INSERT INTO ProprietarioResidencia
		 (PRE_PRT_Codigo, PRE_RES_Codigo) 
	VALUES
		 (@PRE_PRT_Codigo, @PRE_RES_Codigo); 

	SELECT * FROM ProprietarioResidencia WHERE PRE_Codigo = SCOPE_IDENTITY()