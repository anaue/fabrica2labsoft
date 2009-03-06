-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Felipe Yoshida
-- Create date: 27/02/2009
-- Description:	Insere um novo tipo de patrimonio no BD
-- =============================================

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_tipopatrimonioatributo_inserir' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_tipopatrimonioatributo_inserir
END

GO

CREATE PROCEDURE sp_tipopatrimonioatributo_inserir 
	-- Add the parameters for the stored procedure here
	@idAtributo			INT, 
	@idTipoPatrimonio	INT,	
	@RetSt				INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Validação
	IF EXISTS(SELECT idAtributo FROM tb_TipoPatrimonioAtributo WHERE idAtributo	= @idAtributo AND idTipoPatrimonio = @idTipoPatrimonio)
	BEGIN
		RAISERROR 60000 'Par de Ids Patrimonio e Tipo de Patrimonio ja existente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF NOT EXISTS(SELECT idAtributo FROM tb_Atributo WHERE idAtributo = @idAtributo)
	BEGIN
		RAISERROR 70000 'Atributo inexistente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	IF NOT EXISTS(SELECT idTipoPatrimonio FROM tb_TipoPatrimonio WHERE idTipoPatrimonio = @idTipoPatrimonio)
	BEGIN
		RAISERROR 70000 'Tipo de Patrimonio inexistente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

    -- Insert statements for procedure here
	INSERT INTO tb_TipoPatrimonioAtributo (idAtributo, idTipoPatrimonio) 
	VALUES( @idAtributo, @idTipoPatrimonio)
	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
