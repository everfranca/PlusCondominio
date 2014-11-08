USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AcessoVisitante_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AcessoVisitante_Inserir]
GO

CREATE PROCEDURE [dbo].[AcessoVisitante_Inserir] 
 	@AVI_VIS_Codigo int = null ,
	@AVI_DataEntrada datetime = null ,
	@AVI_DataSaida datetime = null ,
	@AVI_Veiculo varchar (50)  = null ,
	@AVI_Placa varchar (10)  = null ,
	@AVI_RES_Codigo int = null ,
	@AVI_Telefone varchar (15)  = null ,
	@AVI_Observacao varchar (500)  = null AS 

	INSERT INTO AcessoVisitante
		 (AVI_VIS_Codigo, AVI_DataEntrada, AVI_DataSaida, AVI_Veiculo, AVI_Placa, AVI_RES_Codigo, AVI_Telefone, AVI_Observacao) 
	VALUES
		 (@AVI_VIS_Codigo, @AVI_DataEntrada, @AVI_DataSaida, @AVI_Veiculo, @AVI_Placa, @AVI_RES_Codigo, @AVI_Telefone, @AVI_Observacao); 

	SELECT * FROM AcessoVisitante WHERE AVI_Codigo = SCOPE_IDENTITY()