USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visitante_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Visitante_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[Visitante_ListarPorCodigo] 
 @VIS_Codigo int
AS
	SELECT VIS_Codigo, VIS_Cpf, VIS_Rg, VIS_Nome, VIS_Telefone, VIS_Veiculo, VIS_Placa, VIS_Foto
	FROM Visitante
	WHERE VIS_Codigo = @VIS_Codigo