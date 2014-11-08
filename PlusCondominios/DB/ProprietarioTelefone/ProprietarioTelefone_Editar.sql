USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioTelefone_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioTelefone_Editar]
GO

CREATE PROCEDURE [dbo].[ProprietarioTelefone_Editar] 
 	@PTE_Codigo int = null,
	@PTE_Telefone varchar (15)  = null,
	@PTE_PRT_Codigo int = null
AS
	UPDATE ProprietarioTelefone
	SET
 		PTE_Telefone = @PTE_Telefone, 
		PTE_PRT_Codigo = @PTE_PRT_Codigo
	WHERE
 		PTE_Codigo = @PTE_Codigo;