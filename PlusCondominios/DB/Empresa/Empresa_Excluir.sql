USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empresa_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Empresa_Excluir]
GO

CREATE PROCEDURE [dbo].[Empresa_Excluir] 
 	@EMP_Codigo varchar
AS
	DELETE FROM Empresa
	WHERE
 		EMP_Codigo = @EMP_Codigo; 