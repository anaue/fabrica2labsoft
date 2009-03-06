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
-- Description:	Insere um novo valor de atributo
-- =============================================

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_valoratributo_inserir' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_valoratributo_inserir
END

GO

CREATE PROCEDURE sp_valoratributo_inserir 
	-- Add the parameters for the stored procedure here
	@idatributo			INT,
	@valor				VARCHAR(50),
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Variáveis
	DECLARE @id INT

	-- Chave
	SELECT @id = COUNT(*) FROM tb_ValorAtributo
	IF @id = 0
		BEGIN
			SELECT @id = 1
		END
	ELSE
		BEGIN
			SELECT  @id = max(idValorAtributo) + 1 FROM tb_ValorAtributo
		END

	-- Validação
	IF NOT EXISTS(SELECT idAtributo FROM tb_Atributo WHERE idAtributo = @idatributo)
	BEGIN
		RAISERROR 50005 'Atributo Inexistente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF EXISTS (SELECT valor FROM tb_ValorAtributo WHERE idAtributo = @idatributo AND valor = @valor)
	BEGIN
		RAISERROR 60005 'Valor duplicado para o mesmo atributo'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

    -- Insert statements for procedure here
	INSERT INTO tb_ValorAtributo (idValorAtributo, idAtributo, valor) 
	VALUES( @id, @idatributo, @valor)
	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
