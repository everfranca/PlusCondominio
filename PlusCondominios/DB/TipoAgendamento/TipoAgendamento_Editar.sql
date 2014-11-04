USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoAgendamento_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TipoAgendamento_Editar]
GO

CREATE PROCEDURE [dbo].[TipoAgendamento_Editar] 
 	@TAG_Codigo int = null,
	@TAG_Descricao varchar (50)  = null
AS
	UPDATE TipoAgendamento
	SET
 		TAG_Descricao = @TAG_Descricao
	WHERE
 		TAG_Codigo = @TAG_Codigo;