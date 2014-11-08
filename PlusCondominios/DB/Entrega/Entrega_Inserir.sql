USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Entrega_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Entrega_Inserir]
GO

CREATE PROCEDURE [dbo].[Entrega_Inserir] 
 	@ENT_TEN_Codigo int = null ,
	@ENT_Descricao varchar (100)  = null ,
	@ENT_Data datetime = null ,
	@ENT_RES_Codigo int = null ,
	@ENT_EmpresaEntregou varchar (100)  = null ,
	@ENT_NomeEntregador varchar (100)  = null ,
	@ENT_TelefoneContato varchar (15)  = null AS 

	INSERT INTO Entrega
		 (ENT_TEN_Codigo, ENT_Descricao, ENT_Data, ENT_RES_Codigo, ENT_EmpresaEntregou, ENT_NomeEntregador, ENT_TelefoneContato) 
	VALUES
		 (@ENT_TEN_Codigo, @ENT_Descricao, @ENT_Data, @ENT_RES_Codigo, @ENT_EmpresaEntregou, @ENT_NomeEntregador, @ENT_TelefoneContato); 

	SELECT * FROM Entrega WHERE ENT_Codigo = SCOPE_IDENTITY()