USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proprietario_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proprietario_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[Proprietario_ListarPorCodigo] 
 @PRT_Codigo int
AS
	SELECT PRT_Codigo, PRT_Cpf, PRT_Rg, PRT_Nome, PRT_Foto, PRT_Ativo, PRT_Sindico, PRT_Aluguel
	FROM Proprietario
	WHERE PRT_Codigo = @PRT_Codigo