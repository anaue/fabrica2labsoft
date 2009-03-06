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
-- Description:	Insere um novo atributo no BD
-- =============================================

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_atributo_inserir' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_atributo_inserir
END

GO

CREATE PROCEDURE sp_atributo_inserir 
	-- Add the parameters for the stored procedure here
	@nome			VARCHAR(50), 
	@desc			VARCHAR(255),
	@tipo			VARCHAR(20),
	@nulo			VARCHAR(20),
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Variáveis
	DECLARE @id INT

	-- Chave
	SELECT @id = COUNT(*) FROM tb_Atributo
	IF @id = 0
		BEGIN
			SELECT @id = 1
		END
	ELSE
		BEGIN
			SELECT  @id = max(idAtributo) + 1 FROM tb_Atributo
		END

	-- Validação
	IF EXISTS(SELECT nomeAtributo FROM tb_Atributo WHERE nomeAtributo = @nome)
	BEGIN
		RAISERROR 60002 'Atributo com nome duplicado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF NOT(@tipo = 'combo' OR @tipo = 'text')
	BEGIN
		RAISERROR 80002 'Tipo de atributo desconhecido'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF NOT(@nulo = 's' OR @nulo = 'n')
	BEGIN
		RAISERROR 90002 'Nulo desconhecido'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

    -- Insert statements for procedure here
	INSERT INTO tb_Atributo (idAtributo, nomeAtributo, descAtributo, tipoAtributo, nuloAtributo) 
	VALUES (@id, @nome, @desc, @tipo, @nulo)
	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
