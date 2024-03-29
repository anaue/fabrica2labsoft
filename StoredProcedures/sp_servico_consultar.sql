
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
    -- Author: Renan
    -- Create date: 2009-02-27
    -- Description: Obtem endereco de determinado serviço
    -- =============================================
ALTER PROCEDURE [dbo].[sp_servico_consultar]
	 @IdMaestroMapping	INT				= NULL
	,@EnderecoServico	VARCHAR(200)	= NULL
	,@NomeServico		VARCHAR(200)	= NULL
	,@RetSt				INT				= 0		OUTPUT
AS
-- Para evitar 1 row affected
    SET NOCOUNT ON

	SELECT idMaestroMapping, NomeServico, EnderecoServico
	FROM MaestroMapping (NOLOCK)
	WHERE	IdMaestroMapping = COALESCE(@IdMaestroMapping, IdMaestroMapping)
			AND nomeServico LIKE '%' + COALESCE(@NomeServico, NomeServico) + '%'
			AND EnderecoServico LIKE '%' + COALESCE(@EnderecoServico, EnderecoServico) + '%'

	SET @RetSt = @@ERROR
FIM:
	RETURN @RetSt
---------------------------------------
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO

