USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_servico_consultar]    Script Date: 03/05/2009 18:47:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-02-27
    -- Description: Obtem endereco de determinado serviço
    -- =============================================
CREATE PROCEDURE [dbo].[sp_servico_consultar]
	 @NomeServico		VARCHAR(200)
	,@RetSt				INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	SELECT enderecoServico
	FROM MaestroMapping (NOLOCK) 
	WHERE nomeServico LIKE '%' + @NomeServico + '%'

	SET @RetSt = @@ERROR
FIM:
	RETURN @RetSt


