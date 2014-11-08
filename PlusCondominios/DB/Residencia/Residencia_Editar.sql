USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Residencia_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Residencia_Editar]
GO

CREATE PROCEDURE [dbo].[Residencia_Editar] 
 	@RES_Codigo int = null,
	@RES_Torre varchar (10)  = null,
	@RES_Bloco varchar (10)  = null,
	@RES_Numero varchar (10)  = null,
	@RES_Ramal varchar (10)  = null,
	@RES_EMP_Codigo varchar (50)  = null
AS
	UPDATE Residencia
	SET
 		RES_Torre = @RES_Torre, 
		RES_Bloco = @RES_Bloco, 
		RES_Numero = @RES_Numero, 
		RES_Ramal = @RES_Ramal, 
		RES_EMP_Codigo = @RES_EMP_Codigo
	WHERE
 		RES_Codigo = @RES_Codigo;