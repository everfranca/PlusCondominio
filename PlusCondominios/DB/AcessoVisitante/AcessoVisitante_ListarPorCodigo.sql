USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AcessoVisitante_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AcessoVisitante_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[AcessoVisitante_ListarPorCodigo] 
 @AVI_Codigo int
AS
	SELECT AVI_Codigo, AVI_VIS_Codigo, AVI_DataEntrada, AVI_DataSaida, AVI_Veiculo, AVI_Placa, AVI_RES_Codigo, AVI_Telefone, AVI_Observacao
	FROM AcessoVisitante
	WHERE AVI_Codigo = @AVI_Codigo