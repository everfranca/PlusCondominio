USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioVeiculo_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioVeiculo_Editar]
GO

CREATE PROCEDURE [dbo].[ProprietarioVeiculo_Editar] 
 	@PVE_Codigo int = null,
	@PVE_Veiculo varchar (50)  = null,
	@PVE_Placa varchar (10)  = null,
	@PVE_PRT_Codigo int = null
AS
	UPDATE ProprietarioVeiculo
	SET
 		PVE_Veiculo = @PVE_Veiculo, 
		PVE_Placa = @PVE_Placa, 
		PVE_PRT_Codigo = @PVE_PRT_Codigo
	WHERE
 		PVE_Codigo = @PVE_Codigo;