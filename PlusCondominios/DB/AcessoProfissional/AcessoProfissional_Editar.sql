USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AcessoProfissional_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AcessoProfissional_Editar]
GO

CREATE PROCEDURE [dbo].[AcessoProfissional_Editar] 
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
	UPDATE AcessoProfissional
	SET
 		APR_PRO_Codigo = @APR_PRO_Codigo, 
		APR_DataEntrada = @APR_DataEntrada, 
		APR_DataSaida = @APR_DataSaida, 
		APR_Veiculo = @APR_Veiculo, 
		APR_Placa = @APR_Placa, 
		APR_RES_Codigo = @APR_RES_Codigo, 
		APR_Telefone = @APR_Telefone, 
		APR_Observacao = @APR_Observacao
	WHERE
 		APR_Codigo = @APR_Codigo;