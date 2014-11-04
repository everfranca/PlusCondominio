USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Agendamento_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Agendamento_Excluir]
GO

CREATE PROCEDURE [dbo].[Agendamento_Excluir] 
 	@AGE_Codigo int
AS
	DELETE FROM Agendamento
	WHERE
 		AGE_Codigo = @AGE_Codigo; 