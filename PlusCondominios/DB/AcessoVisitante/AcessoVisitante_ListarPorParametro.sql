USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AcessoVisitante_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AcessoVisitante_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[AcessoVisitante_ListarPorParametro] 
 	@AVI_Codigo int = null,
	@AVI_VIS_Codigo int = null,
	@AVI_DataEntrada datetime = null,
	@AVI_DataSaida datetime = null,
	@AVI_Veiculo varchar (50)  = null,
	@AVI_Placa varchar (10)  = null,
	@AVI_RES_Codigo int = null,
	@AVI_Telefone varchar (15)  = null,
	@AVI_Observacao varchar (500)  = null
AS
	SELECT AVI_Codigo, AVI_VIS_Codigo, AVI_DataEntrada, AVI_DataSaida, AVI_Veiculo, AVI_Placa, AVI_RES_Codigo, AVI_Telefone, AVI_Observacao
	FROM AcessoVisitante
	WHERE  (AVI_Codigo = @AVI_Codigo OR @AVI_Codigo IS NULL) 
 	AND (AVI_VIS_Codigo = @AVI_VIS_Codigo OR @AVI_VIS_Codigo IS NULL) 
 	AND (AVI_DataEntrada = @AVI_DataEntrada OR @AVI_DataEntrada IS NULL) 
 	AND (AVI_DataSaida = @AVI_DataSaida OR @AVI_DataSaida IS NULL) 
 	AND (AVI_Veiculo LIKE @AVI_Veiculo OR @AVI_Veiculo IS NULL) 
 	AND (AVI_Placa LIKE @AVI_Placa OR @AVI_Placa IS NULL) 
 	AND (AVI_RES_Codigo = @AVI_RES_Codigo OR @AVI_RES_Codigo IS NULL) 
 	AND (AVI_Telefone LIKE @AVI_Telefone OR @AVI_Telefone IS NULL) 
 	AND (AVI_Observacao LIKE @AVI_Observacao OR @AVI_Observacao IS NULL) 
 