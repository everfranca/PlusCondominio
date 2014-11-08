USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Item_Inserir]
GO

CREATE PROCEDURE [dbo].[Item_Inserir] 
 	@ITE_Nome varchar (50)  = null ,
	@ITE_Formulario varchar (100)  = null AS 

	INSERT INTO Item
		 (ITE_Nome, ITE_Formulario) 
	VALUES
		 (@ITE_Nome, @ITE_Formulario); 

	SELECT * FROM Item WHERE ITE_Codigo = SCOPE_IDENTITY()