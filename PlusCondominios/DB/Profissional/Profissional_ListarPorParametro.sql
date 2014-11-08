USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Profissional_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Profissional_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[Profissional_ListarPorParametro] 
 	@PRO_Codigo int = null,
	@PRO_Cpf varchar (20)  = null,
	@PRO_Rg varchar (20)  = null,
	@PRO_Nome varchar (100)  = null,
	@PRO_Telefone varchar (15)  = null,
	@PRO_Veiculo varchar (50)  = null,
	@PRO_Placa varchar (10)  = null,
	@PRO_Foto varchar (300)  = null,
	@PRO_Empresa varchar (100)  = null
AS
	SELECT PRO_Codigo, PRO_Cpf, PRO_Rg, PRO_Nome, PRO_Telefone, PRO_Veiculo, PRO_Placa, PRO_Foto, PRO_Empresa
	FROM Profissional
	WHERE  (PRO_Codigo = @PRO_Codigo OR @PRO_Codigo IS NULL) 
 	AND (PRO_Cpf LIKE @PRO_Cpf OR @PRO_Cpf IS NULL) 
 	AND (PRO_Rg LIKE @PRO_Rg OR @PRO_Rg IS NULL) 
 	AND (PRO_Nome LIKE @PRO_Nome OR @PRO_Nome IS NULL) 
 	AND (PRO_Telefone LIKE @PRO_Telefone OR @PRO_Telefone IS NULL) 
 	AND (PRO_Veiculo LIKE @PRO_Veiculo OR @PRO_Veiculo IS NULL) 
 	AND (PRO_Placa LIKE @PRO_Placa OR @PRO_Placa IS NULL) 
 	AND (PRO_Foto LIKE @PRO_Foto OR @PRO_Foto IS NULL) 
 	AND (PRO_Empresa LIKE @PRO_Empresa OR @PRO_Empresa IS NULL) 
 