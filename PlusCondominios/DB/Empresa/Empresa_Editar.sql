USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empresa_Editar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Empresa_Editar]
GO

CREATE PROCEDURE [dbo].[Empresa_Editar] 
 	@EMP_Codigo varchar (50)  = null,
	@EMP_Nome varchar (100)  = null,
	@EMP_FotoPequena varchar (300)  = null,
	@EMP_FotoMedia varchar (300)  = null,
	@EMP_FotoGrande varchar (300)  = null,
	@EMP_Cnpj varchar (20)  = null,
	@EMP_Telefone varchar (15)  = null
AS
	UPDATE Empresa
	SET
 		EMP_Nome = @EMP_Nome, 
		EMP_FotoPequena = @EMP_FotoPequena, 
		EMP_FotoMedia = @EMP_FotoMedia, 
		EMP_FotoGrande = @EMP_FotoGrande, 
		EMP_Cnpj = @EMP_Cnpj, 
		EMP_Telefone = @EMP_Telefone
	WHERE
 		EMP_Codigo = @EMP_Codigo;