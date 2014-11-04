USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Agendamento_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Agendamento_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[Agendamento_ListarPorCodigo] 
 @AGE_Codigo int
AS
	SELECT AGE_Codigo, AGE_TAG_Codigo, AGE_DataHoraInicio, AGE_DataHoraFim, AGE_PRT_Codigo
	FROM Agendamento
	WHERE AGE_Codigo = @AGE_Codigo