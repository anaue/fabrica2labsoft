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
use fabrica2db

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_tipopatrimonio_inserir' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_tipopatrimonio_inserir
END

GO

CREATE PROCEDURE sp_tipopatrimonio_inserir 
	-- Add the parameters for the stored procedure here
	@nome			VARCHAR(50), 
	@desc			VARCHAR(255),
	@tipo			INT,
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Variáveis
	DECLARE @id INT

	-- Chave
	SELECT @id = COUNT(*) FROM tb_TipoPatrimonio
	IF @id = 0
		BEGIN
			SELECT @id = 1
		END
	ELSE
		BEGIN
			SELECT  @id = max(idTipoPatrimonio) + 1 FROM tb_TipoPatrimonio
		END

	-- Validação
	IF EXISTS(SELECT nomeTipoPatrimonio FROM tb_TipoPatrimonio WHERE nomeTipoPatrimonio = @nome)
	BEGIN
		RAISERROR 60000 'Tipo de patrimonio com nome duplicado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF NOT EXISTS(SELECT idTipoAcesso FROM tb_TipoAcesso WHERE idTipoAcesso = @tipo)
	BEGIN
		RAISERROR 70000 'Tipo de acesso inexistente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	IF NOT(@tipo = 1 OR @tipo = 2)
	BEGIN
		RAISERROR 80000 'Tipo de tipo de patrimonio desconhecido'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

    -- Insert statements for procedure here
	INSERT INTO tb_TipoPatrimonio (idTipoPatrimonio, nomeTipoPatrimonio, descTipoPatrimonio, idTipoAcesso) 
	VALUES( @id, @nome, @desc, @tipo)
	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
