USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visitante_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Visitante_Inserir]
GO

CREATE PROCEDURE [dbo].[Visitante_Inserir] 
 	@VIS_Cpf varchar (20)  = null ,
	@VIS_Rg varchar (20)  = null ,
	@VIS_Nome varchar (100)  = null ,
	@VIS_Telefone varchar (15)  = null ,
	@VIS_Veiculo varchar (50)  = null ,
	@VIS_Placa varchar (10)  = null ,
	@VIS_Foto varchar (300)  = null AS 

	INSERT INTO Visitante
		 (VIS_Cpf, VIS_Rg, VIS_Nome, VIS_Telefone, VIS_Veiculo, VIS_Placa, VIS_Foto) 
	VALUES
		 (@VIS_Cpf, @VIS_Rg, @VIS_Nome, @VIS_Telefone, @VIS_Veiculo, @VIS_Placa, @VIS_Foto); 

	SELECT * FROM Visitante WHERE VIS_Codigo = SCOPE_IDENTITY()