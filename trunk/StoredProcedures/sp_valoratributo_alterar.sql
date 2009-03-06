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
-- Create date: 05/03/2009
-- Description:	Altera um valor de atributo
-- =============================================

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_valoratributo_alterar' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_valoratributo_alterar
END

GO

CREATE PROCEDURE sp_valoratributo_alterar 
	-- Add the parameters for the stored procedure here
	@idvaloratributo	INT,
	@idatributo			INT, 
	@valor				VARCHAR(50),
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Validação
	IF NOT EXISTS(SELECT idValorAtributo FROM tb_ValorAtributo WHERE idValorAtributo = @idvaloratributo)
	BEGIN
		RAISERROR 90008 'Valor de atributo inexistente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF NOT EXISTS(SELECT idAtributo FROM tb_Atributo WHERE idAtributo = @idatributo)
	BEGIN
		RAISERROR 80008 'Atributo inexistente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF EXISTS(SELECT valor FROM tb_ValorAtributo WHERE valor = @valor AND idAtributo = @idatributo AND idValorAtributo <> @idvaloratributo)
	BEGIN
		RAISERROR 70008 'Valor duplicado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

    -- Insert statements for procedure here
	UPDATE tb_ValorAtributo	SET		idAtributo = @idatributo,
									valor = @valor
							WHERE	idValorAtributo = @idvaloratributo
	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
