USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioTelefone_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioTelefone_Inserir]
GO

CREATE PROCEDURE [dbo].[ProprietarioTelefone_Inserir] 
 	@PTE_Telefone varchar (15)  = null ,
	@PTE_PRT_Codigo int = null AS 

	INSERT INTO ProprietarioTelefone
		 (PTE_Telefone, PTE_PRT_Codigo) 
	VALUES
		 (@PTE_Telefone, @PTE_PRT_Codigo); 

	SELECT * FROM ProprietarioTelefone WHERE PTE_Codigo = SCOPE_IDENTITY()