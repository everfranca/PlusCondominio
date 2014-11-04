USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioResidencia_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioResidencia_Excluir]
GO

CREATE PROCEDURE [dbo].[ProprietarioResidencia_Excluir] 
 	@PRE_Codigo int
AS
	DELETE FROM ProprietarioResidencia
	WHERE
 		PRE_Codigo = @PRE_Codigo; 