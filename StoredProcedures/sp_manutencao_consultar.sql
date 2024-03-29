USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_manutencao_consultar]    Script Date: 03/05/2009 18:42:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-04
    -- Description: Busca manutencao
    -- =============================================
CREATE PROCEDURE [dbo].[sp_manutencao_consultar]
	 @IdManutencao		INT				= NULL
	,@DtManutencao_Min	DATETIME		= NULL
	,@DtManutencao_Max	DATETIME		= NULL
	,@MotivoManutencao	VARCHAR(255)	= NULL
	,@Observacoes		VARCHAR(255)	= NULL
	,@IdUsuario			INT				= NULL
	,@IdPatrimonio		INT				= NULL
	,@RetSt				INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	---------------------------------------------------------
	-- Consultar baixa
	SELECT idManutencao
		  ,dtManutencao
		  ,motivoManutencao
		  ,observacoesManutencao
		  ,idUsuario
		  ,idPatrimonio
	FROM tb_Manutencao (NOLOCK)
	WHERE		IdManutencao			= COALESCE(@IdManutencao, IdManutencao)
			AND DtManutencao			BETWEEN
											COALESCE(@DtManutencao_Min, '1900-01-01')
											AND
											COALESCE(@DtManutencao_Max, '3000-01-01')
			AND MotivoManutencao		LIKE '%' + COALESCE(@MotivoManutencao, MotivoManutencao) + '%'
			AND ObservacoesManutencao	LIKE '%' + COALESCE(@Observacoes, ObservacoesManutencao) + '%'
			AND IdUsuario				= COALESCE(@IdUsuario, IdUsuario)
			AND IdPatrimonio			= COALESCE(@IdPatrimonio, IdPatrimonio)
	
	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt


