USE PlusCondominios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProprietarioVeiculo_Excluir]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProprietarioVeiculo_Excluir]
GO

CREATE PROCEDURE [dbo].[ProprietarioVeiculo_Excluir] 
 	@PVE_Codigo int
AS
	DELETE FROM ProprietarioVeiculo
	WHERE
 		PVE_Codigo = @PVE_Codigo; 