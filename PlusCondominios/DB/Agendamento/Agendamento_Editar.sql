USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Agendamento_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Agendamento_Editar]
GO

CREATE PROCEDURE [dbo].[Agendamento_Editar] 
 	@AGE_Codigo int = null,
	@AGE_TAG_Codigo int = null,
	@AGE_DataHoraInicio datetime = null,
	@AGE_DataHoraFim datetime = null,
	@AGE_PRT_Codigo int = null
AS
	UPDATE Agendamento
	SET
 		AGE_TAG_Codigo = @AGE_TAG_Codigo, 
		AGE_DataHoraInicio = @AGE_DataHoraInicio, 
		AGE_DataHoraFim = @AGE_DataHoraFim, 
		AGE_PRT_Codigo = @AGE_PRT_Codigo
	WHERE
 		AGE_Codigo = @AGE_Codigo;