USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoAgendamento_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TipoAgendamento_Excluir]
GO

CREATE PROCEDURE [dbo].[TipoAgendamento_Excluir] 
 	@TAG_Codigo int
AS
	DELETE FROM TipoAgendamento
	WHERE
 		TAG_Codigo = @TAG_Codigo; 