USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_manutencao_inserir]    Script Date: 03/05/2009 18:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-04
    -- Description: Insere manutencao
    -- =============================================
CREATE PROCEDURE [dbo].[sp_manutencao_inserir]
	 @DtManutencao		DATETIME
    ,@MotivoManutencao	VARCHAR(255)
    ,@Observacoes		VARCHAR(255)
    ,@IdUsuario			INT
	,@IdPatrimonio		INT
	,@RetSt				INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-- Variaveis que serao utilizadas
	DECLARE @IdManutencao INT

	-----------------------------------------------------
	-- Protecao

	-- Verifica se o usuario existe
	IF NOT EXISTS(SELECT IdUsuario FROM tb_Usuario (NOLOCK) WHERE IdUsuario = @IdUsuario)
	BEGIN
		RAISERROR 60000 'Usuario nao encontrado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END

	-- Verifica se o patrimonio existe
	IF NOT EXISTS(SELECT IdPatrimonio FROM tb_Patrimonio (NOLOCK) WHERE IdPatrimonio = @IdPatrimonio)
	BEGIN
		RAISERROR 70000 'Patrimonio nao encontrado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	--------------------------------------------------------


	-- Obtendo valor das variaveis
	-- IdManutencao
	SELECT @IdManutencao = MAX(IdManutencao) FROM tb_Manutencao (NOLOCK)

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

	IF @IdManutencao IS NULL
		SET @IdManutencao = 0
	
	SET @IdManutencao = @IdManutencao + 1

	---------------------------------------------------------
	-- Inserindo manutencao
	INSERT INTO tb_Manutencao (idManutencao, dtManutencao, motivoManutencao, observacoesManutencao, idUsuario, idPatrimonio)
	VALUES (@IdManutencao, @DtManutencao, @MotivoManutencao, @Observacoes, @IdUsuario, @IdPatrimonio)

	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt


