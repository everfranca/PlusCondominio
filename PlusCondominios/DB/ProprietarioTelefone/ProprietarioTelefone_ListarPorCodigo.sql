USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioTelefone_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioTelefone_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[ProprietarioTelefone_ListarPorCodigo] 
 @PTE_Codigo int
AS
	SELECT PTE_Codigo, PTE_Telefone, PTE_PRT_Codigo
	FROM ProprietarioTelefone
	WHERE PTE_Codigo = @PTE_Codigo