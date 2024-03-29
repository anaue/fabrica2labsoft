USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_baixa_consultar]    Script Date: 03/05/2009 18:39:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-02-27
    -- Description: Consulta uma baixa
    -- =============================================
CREATE PROCEDURE [dbo].[sp_baixa_consultar]
	 @IdBaixa		INT				= NULL
	,@DtBaixa_Min	DATETIME		= NULL
	,@DtBaixa_Max	DATETIME		= NULL
	,@DestinoBaixa	VARCHAR(50)		= NULL
	,@Observacoes	VARCHAR(255)	= NULL
	,@IdUsuario		INT				= NULL
	,@IdPatrimonio	INT				= NULL
	,@RetSt			INT				= 0		OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	---------------------------------------------------------
	-- Consultar baixa
	SELECT DestinoBaixa, ObservacoesBaixa, IdUsuario, IdPatrimonio, IdBaixa, DtBaixa
	FROM tb_Baixa (NOLOCK)
	WHERE	IdBaixa = COALESCE(@IdBaixa, IdBaixa)
			AND DtBaixa BETWEEN COALESCE(@DtBaixa_Min, '1900-01-01')
							AND
							COALESCE(@DtBaixa_Max, '3000-01-01')
			AND DestinoBaixa LIKE '%' + COALESCE(@DestinoBaixa, DestinoBaixa) + '%'
			AND ObservacoesBaixa LIKE '%' + COALESCE(@Observacoes, ObservacoesBaixa) + '%'
			AND IdUsuario = COALESCE(@IdUsuario, IdUsuario)
			AND IdPatrimonio = COALESCE(@IdPatrimonio, IdPatrimonio)

	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt


