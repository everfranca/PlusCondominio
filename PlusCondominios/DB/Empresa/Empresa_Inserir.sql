USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empresa_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Empresa_Inserir]
GO

CREATE PROCEDURE [dbo].[Empresa_Inserir] 
 	@EMP_Nome varchar (100)  = null ,
	@EMP_FotoPequena varchar (300)  = null ,
	@EMP_FotoMedia varchar (300)  = null ,
	@EMP_FotoGrande varchar (300)  = null ,
	@EMP_Cnpj varchar (20)  = null ,
	@EMP_Telefone varchar (15)  = null AS 

	INSERT INTO Empresa
		 (EMP_Nome, EMP_FotoPequena, EMP_FotoMedia, EMP_FotoGrande, EMP_Cnpj, EMP_Telefone) 
	VALUES
		 (@EMP_Nome, @EMP_FotoPequena, @EMP_FotoMedia, @EMP_FotoGrande, @EMP_Cnpj, @EMP_Telefone); 

	SELECT * FROM Empresa WHERE EMP_Codigo = SCOPE_IDENTITY()