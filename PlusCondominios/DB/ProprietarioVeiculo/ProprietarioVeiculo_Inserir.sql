USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioVeiculo_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioVeiculo_Inserir]
GO

CREATE PROCEDURE [dbo].[ProprietarioVeiculo_Inserir] 
 	@PVE_Veiculo varchar (50)  = null ,
	@PVE_Placa varchar (10)  = null ,
	@PVE_PRT_Codigo int = null AS 

	INSERT INTO ProprietarioVeiculo
		 (PVE_Veiculo, PVE_Placa, PVE_PRT_Codigo) 
	VALUES
		 (@PVE_Veiculo, @PVE_Placa, @PVE_PRT_Codigo); 

	SELECT * FROM ProprietarioVeiculo WHERE PVE_Codigo = SCOPE_IDENTITY()