USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Profissional_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Profissional_Editar]
GO

CREATE PROCEDURE [dbo].[Profissional_Editar] 
 	@PRO_Codigo int = null,
	@PRO_Cpf varchar (20)  = null,
	@PRO_Rg varchar (20)  = null,
	@PRO_Nome varchar (100)  = null,
	@PRO_Telefone varchar (15)  = null,
	@PRO_Veiculo varchar (50)  = null,
	@PRO_Placa varchar (10)  = null,
	@PRO_Foto varchar (300)  = null,
	@PRO_Empresa varchar (100)  = null
AS
	UPDATE Profissional
	SET
 		PRO_Cpf = @PRO_Cpf, 
		PRO_Rg = @PRO_Rg, 
		PRO_Nome = @PRO_Nome, 
		PRO_Telefone = @PRO_Telefone, 
		PRO_Veiculo = @PRO_Veiculo, 
		PRO_Placa = @PRO_Placa, 
		PRO_Foto = @PRO_Foto, 
		PRO_Empresa = @PRO_Empresa
	WHERE
 		PRO_Codigo = @PRO_Codigo;