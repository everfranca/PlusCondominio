USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoAgendamento_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TipoAgendamento_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[TipoAgendamento_ListarPorCodigo] 
 @TAG_Codigo int
AS
	SELECT TAG_Codigo, TAG_Descricao
	FROM TipoAgendamento
	WHERE TAG_Codigo = @TAG_Codigo