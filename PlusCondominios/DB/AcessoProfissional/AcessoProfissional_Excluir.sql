USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AcessoProfissional_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AcessoProfissional_Excluir]
GO

CREATE PROCEDURE [dbo].[AcessoProfissional_Excluir] 
 	@APR_Codigo int
AS
	DELETE FROM AcessoProfissional
	WHERE
 		APR_Codigo = @APR_Codigo; 