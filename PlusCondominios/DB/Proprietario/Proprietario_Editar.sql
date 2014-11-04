USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proprietario_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proprietario_Editar]
GO

CREATE PROCEDURE [dbo].[Proprietario_Editar] 
 	@PRT_Codigo int = null,
	@PRT_Cpf varchar (20)  = null,
	@PRT_Rg varchar (20)  = null,
	@PRT_Nome varchar (100)  = null,
	@PRT_Foto varchar (300)  = null,
	@PRT_Ativo bit = null,
	@PRT_Sindico bit = null,
	@PRT_Aluguel bit = null
AS
	UPDATE Proprietario
	SET
 		PRT_Cpf = @PRT_Cpf, 
		PRT_Rg = @PRT_Rg, 
		PRT_Nome = @PRT_Nome, 
		PRT_Foto = @PRT_Foto, 
		PRT_Ativo = @PRT_Ativo, 
		PRT_Sindico = @PRT_Sindico, 
		PRT_Aluguel = @PRT_Aluguel
	WHERE
 		PRT_Codigo = @PRT_Codigo;