USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Perfil_Inserir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Perfil_Inserir]
GO

CREATE PROCEDURE [dbo].[Perfil_Inserir] 
 	@PRF_Nome varchar (50)  = null AS 

	INSERT INTO Perfil
		 (PRF_Nome) 
	VALUES
		 (@PRF_Nome); 

	SELECT * FROM Perfil WHERE PRF_Codigo = SCOPE_IDENTITY()