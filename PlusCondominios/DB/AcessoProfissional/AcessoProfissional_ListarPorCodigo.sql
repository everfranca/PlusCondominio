USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AcessoProfissional_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AcessoProfissional_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[AcessoProfissional_ListarPorCodigo] 
 @APR_Codigo int
AS
	SELECT APR_Codigo, APR_PRO_Codigo, APR_DataEntrada, APR_DataSaida, APR_Veiculo, APR_Placa, APR_RES_Codigo, APR_Telefone, APR_Observacao
	FROM AcessoProfissional
	WHERE APR_Codigo = @APR_Codigo