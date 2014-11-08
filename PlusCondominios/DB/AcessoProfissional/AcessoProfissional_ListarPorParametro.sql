USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AcessoProfissional_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AcessoProfissional_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[AcessoProfissional_ListarPorParametro] 
 	@APR_Codigo int = null,
	@APR_PRO_Codigo int = null,
	@APR_DataEntrada datetime = null,
	@APR_DataSaida datetime = null,
	@APR_Veiculo varchar (50)  = null,
	@APR_Placa varchar (10)  = null,
	@APR_RES_Codigo int = null,
	@APR_Telefone varchar (15)  = null,
	@APR_Observacao varchar (500)  = null
AS
	SELECT APR_Codigo, APR_PRO_Codigo, APR_DataEntrada, APR_DataSaida, APR_Veiculo, APR_Placa, APR_RES_Codigo, APR_Telefone, APR_Observacao
	FROM AcessoProfissional
	WHERE  (APR_Codigo = @APR_Codigo OR @APR_Codigo IS NULL) 
 	AND (APR_PRO_Codigo = @APR_PRO_Codigo OR @APR_PRO_Codigo IS NULL) 
 	AND (APR_DataEntrada = @APR_DataEntrada OR @APR_DataEntrada IS NULL) 
 	AND (APR_DataSaida = @APR_DataSaida OR @APR_DataSaida IS NULL) 
 	AND (APR_Veiculo LIKE @APR_Veiculo OR @APR_Veiculo IS NULL) 
 	AND (APR_Placa LIKE @APR_Placa OR @APR_Placa IS NULL) 
 	AND (APR_RES_Codigo = @APR_RES_Codigo OR @APR_RES_Codigo IS NULL) 
 	AND (APR_Telefone LIKE @APR_Telefone OR @APR_Telefone IS NULL) 
 	AND (APR_Observacao LIKE @APR_Observacao OR @APR_Observacao IS NULL) 
 