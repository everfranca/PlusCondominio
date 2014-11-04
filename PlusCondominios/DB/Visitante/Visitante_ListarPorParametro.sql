USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visitante_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Visitante_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[Visitante_ListarPorParametro] 
 	@VIS_Codigo int = null,
	@VIS_Cpf varchar (20)  = null,
	@VIS_Rg varchar (20)  = null,
	@VIS_Nome varchar (100)  = null,
	@VIS_Telefone varchar (15)  = null,
	@VIS_Veiculo varchar (50)  = null,
	@VIS_Placa varchar (10)  = null,
	@VIS_Foto varchar (300)  = null
AS
	SELECT VIS_Codigo, VIS_Cpf, VIS_Rg, VIS_Nome, VIS_Telefone, VIS_Veiculo, VIS_Placa, VIS_Foto
	FROM Visitante
	WHERE  (VIS_Codigo = @VIS_Codigo OR @VIS_Codigo IS NULL) 
 	AND (VIS_Cpf LIKE @VIS_Cpf OR @VIS_Cpf IS NULL) 
 	AND (VIS_Rg LIKE @VIS_Rg OR @VIS_Rg IS NULL) 
 	AND (VIS_Nome LIKE @VIS_Nome OR @VIS_Nome IS NULL) 
 	AND (VIS_Telefone LIKE @VIS_Telefone OR @VIS_Telefone IS NULL) 
 	AND (VIS_Veiculo LIKE @VIS_Veiculo OR @VIS_Veiculo IS NULL) 
 	AND (VIS_Placa LIKE @VIS_Placa OR @VIS_Placa IS NULL) 
 	AND (VIS_Foto LIKE @VIS_Foto OR @VIS_Foto IS NULL) 
 