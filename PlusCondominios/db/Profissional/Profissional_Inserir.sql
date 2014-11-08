USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Profissional_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Profissional_Inserir]
GO

CREATE PROCEDURE [dbo].[Profissional_Inserir] 
 	@PRO_Cpf varchar (20)  = null ,
	@PRO_Rg varchar (20)  = null ,
	@PRO_Nome varchar (100)  = null ,
	@PRO_Telefone varchar (15)  = null ,
	@PRO_Veiculo varchar (50)  = null ,
	@PRO_Placa varchar (10)  = null ,
	@PRO_Foto varchar (300)  = null ,
	@PRO_Empresa varchar (100)  = null AS 

	INSERT INTO Profissional
		 (PRO_Cpf, PRO_Rg, PRO_Nome, PRO_Telefone, PRO_Veiculo, PRO_Placa, PRO_Foto, PRO_Empresa) 
	VALUES
		 (@PRO_Cpf, @PRO_Rg, @PRO_Nome, @PRO_Telefone, @PRO_Veiculo, @PRO_Placa, @PRO_Foto, @PRO_Empresa); 

	SELECT * FROM Profissional WHERE PRO_Codigo = SCOPE_IDENTITY()