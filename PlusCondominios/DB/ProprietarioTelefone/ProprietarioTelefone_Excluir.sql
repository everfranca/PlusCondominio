USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioTelefone_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioTelefone_Excluir]
GO

CREATE PROCEDURE [dbo].[ProprietarioTelefone_Excluir] 
 	@PTE_Codigo int
AS
	DELETE FROM ProprietarioTelefone
	WHERE
 		PTE_Codigo = @PTE_Codigo; 