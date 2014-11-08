USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoAgendamento_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TipoAgendamento_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[TipoAgendamento_ListarPorParametro] 
 	@TAG_Codigo int = null,
	@TAG_Descricao varchar (50)  = null
AS
	SELECT TAG_Codigo, TAG_Descricao
	FROM TipoAgendamento
	WHERE  (TAG_Codigo = @TAG_Codigo OR @TAG_Codigo IS NULL) 
 	AND (TAG_Descricao LIKE @TAG_Descricao OR @TAG_Descricao IS NULL) 
 