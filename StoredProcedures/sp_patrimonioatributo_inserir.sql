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
-- Create date: 05/04/2009
-- Description:	Associa um atributo em um patrimonio
-- =============================================

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_patrimonioatributo_inserir' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_patrimonioatributo_inserir
END

GO

CREATE PROCEDURE sp_patrimonioatributo_inserir 
	-- Add the parameters for the stored procedure here
	@idpatrimonio			INT,
	@idatributo				INT,
	@idvaloratributo		INT,
	@valoratributotexto		VARCHAR(255),
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Validação
	IF NOT EXISTS(SELECT idPatrimonio FROM tb_Patrimonio WHERE idPatrimonio = @idpatrimonio)
	BEGIN
		RAISERROR 50010 'Patrimonio Inexistente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF NOT EXISTS (SELECT idAtributo FROM tb_Atributo WHERE idAtributo = @idatributo)
	BEGIN
		RAISERROR 60010 'Atributo inexistente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

    -- Insert statements for procedure here
	INSERT INTO tb_PatrimonioAtributo (idPatrimonio, idAtributo, idValorAtributo, valorAtributoTexto) 
	VALUES( @idpatrimonio, @idatributo, @idvaloratributo, @valoratributotexto)
	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
