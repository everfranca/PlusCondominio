USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AcessoVisitante_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AcessoVisitante_Editar]
GO

CREATE PROCEDURE [dbo].[AcessoVisitante_Editar] 
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
	UPDATE AcessoVisitante
	SET
 		AVI_VIS_Codigo = @AVI_VIS_Codigo, 
		AVI_DataEntrada = @AVI_DataEntrada, 
		AVI_DataSaida = @AVI_DataSaida, 
		AVI_Veiculo = @AVI_Veiculo, 
		AVI_Placa = @AVI_Placa, 
		AVI_RES_Codigo = @AVI_RES_Codigo, 
		AVI_Telefone = @AVI_Telefone, 
		AVI_Observacao = @AVI_Observacao
	WHERE
 		AVI_Codigo = @AVI_Codigo;