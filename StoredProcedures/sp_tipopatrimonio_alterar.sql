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
-- Description:	Altera um tipo de patrimonio no BD
-- =============================================

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_tipopatrimonio_alterar' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_tipopatrimonio_alterar
END

GO

CREATE PROCEDURE sp_tipopatrimonio_alterar 
	-- Add the parameters for the stored procedure here
	@id				INT
	@nome			VARCHAR(50), 
	@desc			VARCHAR(255),
	@tipo			INT,
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Validação
	IF EXISTS(SELECT nomeTipoPatrimonio FROM tb_TipoPatrimonio WHERE nomeTipoPatrimonio = @nome AND idTipoPatrimonio <> @id)
	BEGIN
		RAISERROR 60001 'Tipo de patrimonio com nome duplicado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF NOT EXISTS(SELECT idTipoAcesso FROM tb_TipoAcesso WHERE idTipoAcesso = @tipo)
	BEGIN
		RAISERROR 70001 'Tipo de acesso inexistente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	IF NOT(@tipo = 1 OR @tipo = 2)
	BEGIN
		RAISERROR 80001 'Tipo de tipo de patrimonio desconhecido'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

    -- Insert statements for procedure here
	UPDATE tb_TipoPatrimonio	SET		nomeTipoPatrimonio = @nome,
										descTipoPatrimonio = @desc,
										idTipoAcesso = @tipo
								WHERE	idTipoPatrimonio = @id
	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
