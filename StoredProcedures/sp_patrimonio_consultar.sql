USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_patrimonio_consultar]    Script Date: 03/05/2009 18:45:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-05
    -- Description: Busca patrimonio
    -- =============================================
CREATE PROCEDURE [dbo].[sp_patrimonio_consultar]
	 @IdPatrimonio			INT				= NULL
	,@DtCompra_Min			DATETIME		= NULL
	,@DtCompra_Max			DATETIME		= NULL
	,@NumeroNotaFiscal		VARCHAR(30)		= NULL
	,@DtExpGarantia_Min		DATETIME		= NULL
	,@DtExpGarantia_Max		DATETIME		= NULL
	,@IdTipoPatrimonio		INT				= NULL
	,@CaminhoFotoNotaFiscal	VARCHAR(255)	= NULL
	,@CaminhoFotoPatrimonio	VARCHAR(255)	= NULL
	,@NumeroPece			INT				= NULL
	,@NumeroPedido			INT				= NULL
	,@Local					VARCHAR(100)	= NULL
	,@RetSt					INT				= 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	---------------------------------------------------------
	-- Consultar baixa
	SELECT	 IdPatrimonio
			,DtCompra
			,NumeroNotaFiscal
			,DtExpGarantia
			,IdTipoPatrimonio
			,CaminhoFotoNotaFiscal
			,CaminhoFotoPatrimonio
			,NumeroPece
			,NumeroPedido
			,Local
	FROM tb_Patrimonio (NOLOCK)
	WHERE	IdPatrimonio				=	COALESCE(@IdPatrimonio, IdPatrimonio)
			AND DtCompra				BETWEEN
											COALESCE(@DtCompra_Min, '1900-01-01')
											AND
											COALESCE(@DtCompra_Max, '3000-01-01')
			AND NumeroNotaFiscal		LIKE '%' + COALESCE(@NumeroNotaFiscal, NumeroNotaFiscal) + '%'
			AND DtExpGarantia			BETWEEN
											COALESCE(@DtExpGarantia_Min, '1900-01-01')
											AND
											COALESCE(@DtExpGarantia_Max, '3000-01-01')
			AND IdTipoPatrimonio		= COALESCE(@IdTipoPatrimonio, IdTipoPatrimonio)
			AND CaminhoFotoNotaFiscal	LIKE '%' + COALESCE(@CaminhoFotoNotaFiscal, CaminhoFotoNotaFiscal) + '%'
			AND CaminhoFotoPatrimonio	LIKE '%' + COALESCE(@CaminhoFotoPatrimonio, CaminhoFotoPatrimonio) + '%'
			AND NumeroPece				= COALESCE(@NumeroPece, NumeroPece)
			AND NumeroPedido			= COALESCE(@NumeroPedido, NumeroPedido)
			AND Local					LIKE '%' + COALESCE(@Local, Local) + '%'
	
	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt



