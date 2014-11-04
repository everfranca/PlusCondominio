USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoEntrega_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TipoEntrega_Editar]
GO

CREATE PROCEDURE [dbo].[TipoEntrega_Editar] 
 	@TEN_Codigo int = null,
	@TEN_Nome varchar (50)  = null
AS
	UPDATE TipoEntrega
	SET
 		TEN_Nome = @TEN_Nome
	WHERE
 		TEN_Codigo = @TEN_Codigo;