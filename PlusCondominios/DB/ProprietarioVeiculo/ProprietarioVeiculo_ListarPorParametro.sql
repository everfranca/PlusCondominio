USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioVeiculo_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioVeiculo_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[ProprietarioVeiculo_ListarPorParametro] 
 	@PVE_Codigo int = null,
	@PVE_Veiculo varchar (50)  = null,
	@PVE_Placa varchar (10)  = null,
	@PVE_PRT_Codigo int = null
AS
	SELECT PVE_Codigo, PVE_Veiculo, PVE_Placa, PVE_PRT_Codigo
	FROM ProprietarioVeiculo
	WHERE  (PVE_Codigo = @PVE_Codigo OR @PVE_Codigo IS NULL) 
 	AND (PVE_Veiculo LIKE @PVE_Veiculo OR @PVE_Veiculo IS NULL) 
 	AND (PVE_Placa LIKE @PVE_Placa OR @PVE_Placa IS NULL) 
 	AND (PVE_PRT_Codigo = @PVE_PRT_Codigo OR @PVE_PRT_Codigo IS NULL) 
 