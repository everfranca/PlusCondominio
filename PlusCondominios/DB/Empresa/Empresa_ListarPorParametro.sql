USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empresa_ListarPorParametro]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Empresa_ListarPorParametro]
GO

CREATE PROCEDURE [dbo].[Empresa_ListarPorParametro] 
 	@EMP_Codigo varchar (50)  = null,
	@EMP_Nome varchar (100)  = null,
	@EMP_FotoPequena varchar (300)  = null,
	@EMP_FotoMedia varchar (300)  = null,
	@EMP_FotoGrande varchar (300)  = null,
	@EMP_Cnpj varchar (20)  = null,
	@EMP_Telefone varchar (15)  = null
AS
	SELECT EMP_Codigo, EMP_Nome, EMP_FotoPequena, EMP_FotoMedia, EMP_FotoGrande, EMP_Cnpj, EMP_Telefone
	FROM Empresa
	WHERE  (EMP_Codigo LIKE @EMP_Codigo OR @EMP_Codigo IS NULL) 
 	AND (EMP_Nome LIKE @EMP_Nome OR @EMP_Nome IS NULL) 
 	AND (EMP_FotoPequena LIKE @EMP_FotoPequena OR @EMP_FotoPequena IS NULL) 
 	AND (EMP_FotoMedia LIKE @EMP_FotoMedia OR @EMP_FotoMedia IS NULL) 
 	AND (EMP_FotoGrande LIKE @EMP_FotoGrande OR @EMP_FotoGrande IS NULL) 
 	AND (EMP_Cnpj LIKE @EMP_Cnpj OR @EMP_Cnpj IS NULL) 
 	AND (EMP_Telefone LIKE @EMP_Telefone OR @EMP_Telefone IS NULL) 
 