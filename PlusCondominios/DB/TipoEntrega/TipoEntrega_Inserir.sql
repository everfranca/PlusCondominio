USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoEntrega_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TipoEntrega_Inserir]
GO

CREATE PROCEDURE [dbo].[TipoEntrega_Inserir] 
 	@TEN_Nome varchar (50)  = null AS 

	INSERT INTO TipoEntrega
		 (TEN_Nome) 
	VALUES
		 (@TEN_Nome); 

	SELECT * FROM TipoEntrega WHERE TEN_Codigo = SCOPE_IDENTITY()