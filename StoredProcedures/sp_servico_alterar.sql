USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_servico_alterar]    Script Date: 03/05/2009 18:47:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-04
    -- Description: Altera o nome e/ou endereco de um servico
    -- =============================================
CREATE PROCEDURE [dbo].[sp_servico_alterar]
	 @IdMaestroMapping	INT
    ,@NomeServico		VARCHAR(200) = NULL
    ,@EnderecoServico	VARCHAR(200) = NULL
	,@RetSt				INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-----------------------------------------------------
	-- Protecao

	-- Verifica se o servico existe
	IF NOT EXISTS(	SELECT @IdMaestroMapping 
					FROM MaestroMapping (NOLOCK) 
					WHERE IdMaestroMapping = @IdMaestroMapping)
	BEGIN
		RAISERROR 60000 'Servico nao encontrado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	--------------------------------------------------------


	-- Atualizando servico
	UPDATE MaestroMapping
	SET	 NomeServico = COALESCE(@NomeServico, NomeServico)
		,EnderecoServico = COALESCE(@EnderecoServico, EnderecoServico)
	WHERE IdMaestroMapping = @IdMaestroMapping
	
	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt



