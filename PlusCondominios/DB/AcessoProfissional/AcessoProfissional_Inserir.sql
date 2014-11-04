USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AcessoProfissional_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AcessoProfissional_Inserir]
GO

CREATE PROCEDURE [dbo].[AcessoProfissional_Inserir] 
 	@APR_PRO_Codigo int = null ,
	@APR_DataEntrada datetime = null ,
	@APR_DataSaida datetime = null ,
	@APR_Veiculo varchar (50)  = null ,
	@APR_Placa varchar (10)  = null ,
	@APR_RES_Codigo int = null ,
	@APR_Telefone varchar (15)  = null ,
	@APR_Observacao varchar (500)  = null AS 

	INSERT INTO AcessoProfissional
		 (APR_PRO_Codigo, APR_DataEntrada, APR_DataSaida, APR_Veiculo, APR_Placa, APR_RES_Codigo, APR_Telefone, APR_Observacao) 
	VALUES
		 (@APR_PRO_Codigo, @APR_DataEntrada, @APR_DataSaida, @APR_Veiculo, @APR_Placa, @APR_RES_Codigo, @APR_Telefone, @APR_Observacao); 

	SELECT * FROM AcessoProfissional WHERE APR_Codigo = SCOPE_IDENTITY()