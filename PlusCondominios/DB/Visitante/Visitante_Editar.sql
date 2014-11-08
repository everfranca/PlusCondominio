USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visitante_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Visitante_Editar]
GO

CREATE PROCEDURE [dbo].[Visitante_Editar] 
 	@VIS_Codigo int = null,
	@VIS_Cpf varchar (20)  = null,
	@VIS_Rg varchar (20)  = null,
	@VIS_Nome varchar (100)  = null,
	@VIS_Telefone varchar (15)  = null,
	@VIS_Veiculo varchar (50)  = null,
	@VIS_Placa varchar (10)  = null,
	@VIS_Foto varchar (300)  = null
AS
	UPDATE Visitante
	SET
 		VIS_Cpf = @VIS_Cpf, 
		VIS_Rg = @VIS_Rg, 
		VIS_Nome = @VIS_Nome, 
		VIS_Telefone = @VIS_Telefone, 
		VIS_Veiculo = @VIS_Veiculo, 
		VIS_Placa = @VIS_Placa, 
		VIS_Foto = @VIS_Foto
	WHERE
 		VIS_Codigo = @VIS_Codigo;