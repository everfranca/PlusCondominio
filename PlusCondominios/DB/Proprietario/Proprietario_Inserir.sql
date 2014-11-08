USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proprietario_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proprietario_Inserir]
GO

CREATE PROCEDURE [dbo].[Proprietario_Inserir] 
 	@PRT_Cpf varchar (20)  = null ,
	@PRT_Rg varchar (20)  = null ,
	@PRT_Nome varchar (100)  = null ,
	@PRT_Foto varchar (300)  = null ,
	@PRT_Ativo bit = null ,
	@PRT_Sindico bit = null ,
	@PRT_Aluguel bit = null AS 

	INSERT INTO Proprietario
		 (PRT_Cpf, PRT_Rg, PRT_Nome, PRT_Foto, PRT_Ativo, PRT_Sindico, PRT_Aluguel) 
	VALUES
		 (@PRT_Cpf, @PRT_Rg, @PRT_Nome, @PRT_Foto, @PRT_Ativo, @PRT_Sindico, @PRT_Aluguel); 

	SELECT * FROM Proprietario WHERE PRT_Codigo = SCOPE_IDENTITY()