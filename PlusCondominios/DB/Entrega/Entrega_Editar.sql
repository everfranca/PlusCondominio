USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Entrega_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Entrega_Editar]
GO

CREATE PROCEDURE [dbo].[Entrega_Editar] 
 	@ENT_Codigo int = null,
	@ENT_TEN_Codigo int = null,
	@ENT_Descricao varchar (100)  = null,
	@ENT_Data datetime = null,
	@ENT_RES_Codigo int = null,
	@ENT_EmpresaEntregou varchar (100)  = null,
	@ENT_NomeEntregador varchar (100)  = null,
	@ENT_TelefoneContato varchar (15)  = null
AS
	UPDATE Entrega
	SET
 		ENT_TEN_Codigo = @ENT_TEN_Codigo, 
		ENT_Descricao = @ENT_Descricao, 
		ENT_Data = @ENT_Data, 
		ENT_RES_Codigo = @ENT_RES_Codigo, 
		ENT_EmpresaEntregou = @ENT_EmpresaEntregou, 
		ENT_NomeEntregador = @ENT_NomeEntregador, 
		ENT_TelefoneContato = @ENT_TelefoneContato
	WHERE
 		ENT_Codigo = @ENT_Codigo;