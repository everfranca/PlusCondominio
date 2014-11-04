USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Entrega_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Entrega_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[Entrega_ListarPorParametro] 
 	@ENT_Codigo int = null,
	@ENT_TEN_Codigo int = null,
	@ENT_Descricao varchar (100)  = null,
	@ENT_Data datetime = null,
	@ENT_RES_Codigo int = null,
	@ENT_EmpresaEntregou varchar (100)  = null,
	@ENT_NomeEntregador varchar (100)  = null,
	@ENT_TelefoneContato varchar (15)  = null
AS
	SELECT ENT_Codigo, ENT_TEN_Codigo, ENT_Descricao, ENT_Data, ENT_RES_Codigo, ENT_EmpresaEntregou, ENT_NomeEntregador, ENT_TelefoneContato
	FROM Entrega
	WHERE  (ENT_Codigo = @ENT_Codigo OR @ENT_Codigo IS NULL) 
 	AND (ENT_TEN_Codigo = @ENT_TEN_Codigo OR @ENT_TEN_Codigo IS NULL) 
 	AND (ENT_Descricao LIKE @ENT_Descricao OR @ENT_Descricao IS NULL) 
 	AND (ENT_Data = @ENT_Data OR @ENT_Data IS NULL) 
 	AND (ENT_RES_Codigo = @ENT_RES_Codigo OR @ENT_RES_Codigo IS NULL) 
 	AND (ENT_EmpresaEntregou LIKE @ENT_EmpresaEntregou OR @ENT_EmpresaEntregou IS NULL) 
 	AND (ENT_NomeEntregador LIKE @ENT_NomeEntregador OR @ENT_NomeEntregador IS NULL) 
 	AND (ENT_TelefoneContato LIKE @ENT_TelefoneContato OR @ENT_TelefoneContato IS NULL) 
 