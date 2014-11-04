USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoAgendamento_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TipoAgendamento_Inserir]
GO

CREATE PROCEDURE [dbo].[TipoAgendamento_Inserir] 
 	@TAG_Descricao varchar (50)  = null AS 

	INSERT INTO TipoAgendamento
		 (TAG_Descricao) 
	VALUES
		 (@TAG_Descricao); 

	SELECT * FROM TipoAgendamento WHERE TAG_Codigo = SCOPE_IDENTITY()