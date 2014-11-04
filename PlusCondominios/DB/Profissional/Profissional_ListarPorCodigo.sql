USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Profissional_ListarPorCodigo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Profissional_ListarPorCodigo]
GO

CREATE PROCEDURE [dbo].[Profissional_ListarPorCodigo] 
 @PRO_Codigo int
AS
	SELECT PRO_Codigo, PRO_Cpf, PRO_Rg, PRO_Nome, PRO_Telefone, PRO_Veiculo, PRO_Placa, PRO_Foto, PRO_Empresa
	FROM Profissional
	WHERE PRO_Codigo = @PRO_Codigo