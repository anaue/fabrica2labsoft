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
-- Description:	Altera atributo no BD
-- =============================================

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_atributo_alterar' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_atributo_alterar
END

GO

CREATE PROCEDURE sp_atributo_alterar 
	-- Add the parameters for the stored procedure here
	@id				INT,
	@nome			VARCHAR(50), 
	@desc			VARCHAR(255),
	@tipo			VARCHAR(20),
	@nulo			VARCHAR(20),
	@tipoPatrimonio	INT,
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Salva idTipoPatrimonio antigo
	DECLARE @old INT
	SELECT @old = idTipoPatrimonio FROM tb_Atributo WHERE idAtributo = @id

	-- Validação
	IF NOT EXISTS(SELECT idAtributo FROM tb_Atributo WHERE idAtributo = @id)
	BEGIN
		RAISERROR 100004 'Atributo inexistente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF EXISTS(SELECT nomeAtributo FROM tb_Atributo WHERE nomeAtributo = @nome AND idAtributo <> @id)
	BEGIN
		RAISERROR 60004 'Atributo com nome duplicado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF NOT EXISTS(SELECT idTipoPatrimonio FROM tb_TipoPatrimonio WHERE idTipoPatrimonio = @tipoPatrimonio)
	BEGIN
		RAISERROR 70004 'Tipo de patrimonio inexistente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	IF NOT(@tipo = 'combo' OR @tipo = 'text')
	BEGIN
		RAISERROR 80004 'Tipo de atributo desconhecido'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF NOT(@nulo = 's' OR @nulo = 'n')
	BEGIN
		RAISERROR 90004 'Nulo desconhecido'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

    -- Insert statements for procedure here
	UPDATE tb_Atributo	SET		nomeAtributo = @nome,
								descAtributo = @desc,
								tipoAtributo = @tipo,
								nuloAtributo = @nulo, 
								idTipoPatrimonio = @tipoPatrimonio
								WHERE	idAtributo = @id

	UPDATE tb_TipoPatrimonioAtributo	SET		idAtributo = @id,
												idTipoPatrimonio = @tipoPatrimonio
										WHERE	idAtributo = @id AND idTipoPatrimonio = @old

	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
