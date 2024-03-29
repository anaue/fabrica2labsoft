USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_manutencao_alterar]    Script Date: 03/05/2009 21:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-04
    -- Description: Altera os dados de uma manutencao
    -- =============================================
CREATE PROCEDURE [dbo].[sp_manutencao_alterar]
	 @IdManutencao			INT
    ,@DtManutencao			DATETIME		= NULL
    ,@MotivoManutencao		VARCHAR(50)		= NULL
	,@ObservacoesManutencao	VARCHAR(255)	= NULL
	,@IdUsuario				INT				= NULL
	,@RetSt					INT				= 0		OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-----------------------------------------------------
	-- Protecao

	-- Verifica se a manutencao existe
	IF NOT EXISTS(	SELECT idManutencao 
					FROM tb_Manutencao (NOLOCK) 
					WHERE idManutencao = @IdManutencao)
	BEGIN
		RAISERROR 60000 'Manutencao nao encontrada'
		SET @RetSt = @@ERROR
		GOTO FIM
	END

	-- Verifica se usuario existe
	IF @IdUsuario IS NOT NULL
		IF NOT EXISTS(	SELECT IdUsuario 
						FROM tb_Manutencao (NOLOCK) 
						WHERE IdUsuario = @IdUsuario)
		BEGIN
			RAISERROR 70000 'Usuario nao encontrado'
			SET @RetSt = @@ERROR
			GOTO FIM
		END
	--------------------------------------------------------


	-- Atualizando servico
	UPDATE tb_Manutencao
	SET	 DtManutencao = COALESCE(@DtManutencao, DtManutencao)
		,MotivoManutencao = COALESCE(@MotivoManutencao, MotivoManutencao)
		,ObservacoesManutencao = COALESCE(@ObservacoesManutencao, ObservacoesManutencao)
		,IdUsuario = COALESCE(@IdUsuario, IdUsuario)
	WHERE IdManutencao = @IdManutencao
	
	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt





