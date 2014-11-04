USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proprietario_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proprietario_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[Proprietario_ListarPorParametro] 
 	@PRT_Codigo int = null,
	@PRT_Cpf varchar (20)  = null,
	@PRT_Rg varchar (20)  = null,
	@PRT_Nome varchar (100)  = null,
	@PRT_Foto varchar (300)  = null,
	@PRT_Ativo bit = null,
	@PRT_Sindico bit = null,
	@PRT_Aluguel bit = null
AS
	SELECT PRT_Codigo, PRT_Cpf, PRT_Rg, PRT_Nome, PRT_Foto, PRT_Ativo, PRT_Sindico, PRT_Aluguel
	FROM Proprietario
	WHERE  (PRT_Codigo = @PRT_Codigo OR @PRT_Codigo IS NULL) 
 	AND (PRT_Cpf LIKE @PRT_Cpf OR @PRT_Cpf IS NULL) 
 	AND (PRT_Rg LIKE @PRT_Rg OR @PRT_Rg IS NULL) 
 	AND (PRT_Nome LIKE @PRT_Nome OR @PRT_Nome IS NULL) 
 	AND (PRT_Foto LIKE @PRT_Foto OR @PRT_Foto IS NULL) 
 	AND (PRT_Ativo = @PRT_Ativo OR @PRT_Ativo IS NULL) 
 	AND (PRT_Sindico = @PRT_Sindico OR @PRT_Sindico IS NULL) 
 	AND (PRT_Aluguel = @PRT_Aluguel OR @PRT_Aluguel IS NULL) 
 