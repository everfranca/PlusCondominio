USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Residencia_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Residencia_Inserir]
GO

CREATE PROCEDURE [dbo].[Residencia_Inserir] 
 	@RES_Torre varchar (10)  = null ,
	@RES_Bloco varchar (10)  = null ,
	@RES_Numero varchar (10)  = null ,
	@RES_Ramal varchar (10)  = null ,
	@RES_EMP_Codigo varchar (50)  = null AS 

	INSERT INTO Residencia
		 (RES_Torre, RES_Bloco, RES_Numero, RES_Ramal, RES_EMP_Codigo) 
	VALUES
		 (@RES_Torre, @RES_Bloco, @RES_Numero, @RES_Ramal, @RES_EMP_Codigo); 

	SELECT * FROM Residencia WHERE RES_Codigo = SCOPE_IDENTITY()