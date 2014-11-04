USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioVeiculo_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioVeiculo_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[ProprietarioVeiculo_ListarPorCodigo] 
 @PVE_Codigo int
AS
	SELECT PVE_Codigo, PVE_Veiculo, PVE_Placa, PVE_PRT_Codigo
	FROM ProprietarioVeiculo
	WHERE PVE_Codigo = @PVE_Codigo