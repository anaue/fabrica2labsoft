USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_baixa_alterar]    Script Date: 03/05/2009 21:00:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-04
    -- Description: Altera os dados de uma baixa
    -- =============================================
CREATE PROCEDURE [dbo].[sp_baixa_alterar]
	 @IdBaixa			INT
    ,@DtBaixa			DATETIME		= NULL
    ,@DestinoBaixa		VARCHAR(50)		= NULL
	,@ObservacoesBaixa	VARCHAR(255)	= NULL
	,@IdUsuario			INT				= NULL
	,@RetSt				INT				= 0		OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-----------------------------------------------------
	-- Protecao

	-- Verifica se a baixa existe
	IF NOT EXISTS(	SELECT IdBaixa 
					FROM tb_Baixa (NOLOCK) 
					WHERE IdBaixa = @IdBaixa)
	BEGIN
		RAISERROR 60000 'Baixa nao encontrada'
		SET @RetSt = @@ERROR
		GOTO FIM
	END

	-- Verifica se usuario existe
	IF @IdUsuario IS NOT NULL
		IF NOT EXISTS(	SELECT IdUsuario 
						FROM tb_Baixa (NOLOCK) 
						WHERE IdUsuario = @IdUsuario)
		BEGIN
			RAISERROR 70000 'Usuario nao encontrado'
			SET @RetSt = @@ERROR
			GOTO FIM
		END
	--------------------------------------------------------


	-- Atualizando servico
	UPDATE tb_Baixa
	SET	 DtBaixa = COALESCE(@DtBaixa, DtBaixa)
		,DestinoBaixa = COALESCE(@DestinoBaixa, DestinoBaixa)
		,ObservacoesBaixa = COALESCE(@ObservacoesBaixa, ObservacoesBaixa)
		,IdUsuario = COALESCE(@IdUsuario, IdUsuario)
	WHERE IdBaixa = @IdBaixa
	
	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt






