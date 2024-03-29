USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_patrimonio_alterar]    Script Date: 03/05/2009 18:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-05
    -- Description: Altera os dados de um patrimonio
    -- =============================================
CREATE PROCEDURE [dbo].[sp_patrimonio_alterar]
	 @IdPatrimonio			INT
	,@DtCompra				DATETIME		= NULL
	,@NumeroNotaFiscal		VARCHAR(30)		= NULL
	,@DtExpGarantia			DATETIME		= NULL
	,@IdTipoPatrimonio		INT				= NULL
	,@CaminhoFotoNotaFiscal	VARCHAR(255)	= NULL
	,@CaminhoFotoPatrimonio	VARCHAR(255)	= NULL
	,@NumeroPece			INT				= NULL
	,@NumeroPedido			INT				= NULL
	,@Local					VARCHAR(100)	= NULL
	,@RetSt					INT				= 0		OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-----------------------------------------------------
	-- Protecao

	-- Verifica se o patrimonio existe
	IF NOT EXISTS(	SELECT IdPatrimonio 
					FROM tb_Patrimonio (NOLOCK) 
					WHERE IdPatrimonio = @IdPatrimonio)
	BEGIN
		RAISERROR 60000 'Patrimonio nao encontrado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END

	-- Verifica se TipoPatrimonio existe
	IF @IdTipoPatrimonio IS NOT NULL 
		BEGIN
			IF NOT EXISTS(	SELECT IdTipoPatrimonio
							FROM tb_TipoPatrimonio (NOLOCK) 
							WHERE IdTipoPatrimonio = @IdTipoPatrimonio)
			BEGIN
				RAISERROR 70000 'TipoPatrimonio nao encontrado'
				SET @RetSt = @@ERROR
				GOTO FIM
			END
		END
	--------------------------------------------------------


	-- Atualizando patrimonio
	UPDATE tb_Patrimonio
	SET	 DtCompra				= COALESCE(@DtCompra, DtCompra)
		,NumeroNotaFiscal		= COALESCE(@NumeroNotaFiscal, NumeroNotaFiscal)
		,DtExpGarantia			= COALESCE(@DtExpGarantia, DtExpGarantia)
		,IdTipoPatrimonio		= COALESCE(@IdTipoPatrimonio, IdTipoPatrimonio)
		,CaminhoFotoNotaFiscal	= COALESCE(@CaminhoFotoNotaFiscal, CaminhoFotoNotaFiscal)
		,CaminhoFotoPatrimonio	= COALESCE(@CaminhoFotoPatrimonio, CaminhoFotoPatrimonio)
		,NumeroPece				= COALESCE(@NumeroPece, NumeroPece)
		,NumeroPedido			= COALESCE(@NumeroPedido, NumeroPedido)
		,Local					= COALESCE(@Local, Local)
	WHERE IdPatrimonio = @IdPatrimonio
	
	
	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt





