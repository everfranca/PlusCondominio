USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Agendamento_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Agendamento_Inserir]
GO

CREATE PROCEDURE [dbo].[Agendamento_Inserir] 
 	@AGE_TAG_Codigo int = null ,
	@AGE_DataHoraInicio datetime = null ,
	@AGE_DataHoraFim datetime = null ,
	@AGE_PRT_Codigo int = null AS 

	INSERT INTO Agendamento
		 (AGE_TAG_Codigo, AGE_DataHoraInicio, AGE_DataHoraFim, AGE_PRT_Codigo) 
	VALUES
		 (@AGE_TAG_Codigo, @AGE_DataHoraInicio, @AGE_DataHoraFim, @AGE_PRT_Codigo); 

	SELECT * FROM Agendamento WHERE AGE_Codigo = SCOPE_IDENTITY()