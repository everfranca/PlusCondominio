USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Agendamento_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Agendamento_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[Agendamento_ListarPorParametro] 
 	@AGE_Codigo int = null,
	@AGE_TAG_Codigo int = null,
	@AGE_DataHoraInicio datetime = null,
	@AGE_DataHoraFim datetime = null,
	@AGE_PRT_Codigo int = null
AS
	SELECT AGE_Codigo, AGE_TAG_Codigo, AGE_DataHoraInicio, AGE_DataHoraFim, AGE_PRT_Codigo
	FROM Agendamento
	WHERE  (AGE_Codigo = @AGE_Codigo OR @AGE_Codigo IS NULL) 
 	AND (AGE_TAG_Codigo = @AGE_TAG_Codigo OR @AGE_TAG_Codigo IS NULL) 
 	AND (AGE_DataHoraInicio = @AGE_DataHoraInicio OR @AGE_DataHoraInicio IS NULL) 
 	AND (AGE_DataHoraFim = @AGE_DataHoraFim OR @AGE_DataHoraFim IS NULL) 
 	AND (AGE_PRT_Codigo = @AGE_PRT_Codigo OR @AGE_PRT_Codigo IS NULL) 
 