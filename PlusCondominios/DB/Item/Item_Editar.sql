USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Item_Editar]
GO

CREATE PROCEDURE [dbo].[Item_Editar] 
 	@ITE_Codigo int = null,
	@ITE_Nome varchar (50)  = null,
	@ITE_Formulario varchar (100)  = null
AS
	UPDATE Item
	SET
 		ITE_Nome = @ITE_Nome, 
		ITE_Formulario = @ITE_Formulario
	WHERE
 		ITE_Codigo = @ITE_Codigo;