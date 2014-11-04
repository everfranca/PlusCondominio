USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empresa_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Empresa_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[Empresa_ListarPorCodigo] 
 @EMP_Codigo varchar (50) 
AS
	SELECT EMP_Codigo, EMP_Nome, EMP_FotoPequena, EMP_FotoMedia, EMP_FotoGrande, EMP_Cnpj, EMP_Telefone
	FROM Empresa
	WHERE EMP_Codigo = @EMP_Codigo