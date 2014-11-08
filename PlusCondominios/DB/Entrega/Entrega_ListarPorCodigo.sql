USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Entrega_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Entrega_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[Entrega_ListarPorCodigo] 
 @ENT_Codigo int
AS
	SELECT ENT_Codigo, ENT_TEN_Codigo, ENT_Descricao, ENT_Data, ENT_RES_Codigo, ENT_EmpresaEntregou, ENT_NomeEntregador, ENT_TelefoneContato
	FROM Entrega
	WHERE ENT_Codigo = @ENT_Codigo