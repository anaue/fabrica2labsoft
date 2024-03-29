USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_patrimonio_inserir]    Script Date: 03/05/2009 18:46:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-05
    -- Description: Insere patrimonio
    -- =============================================
CREATE PROCEDURE [dbo].[sp_patrimonio_inserir]
	 @DtCompra				DATETIME
	,@NumeroNotaFiscal		VARCHAR(30)
	,@DtExpGarantia			DATETIME
	,@IdTipoPatrimonio		INT
	,@CaminhoFotoNotaFiscal	VARCHAR(255)
	,@CaminhoFotoPatrimonio	VARCHAR(255)
	,@NumeroPece			INT
	,@NumeroPedido			INT
	,@Local					VARCHAR(100)
	,@RetSt					INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-- Variaveis que serao utilizadas
	DECLARE @IdPatrimonio INT

	-----------------------------------------------------
	-- Protecao

	-- Verifica se o tipo patrimonio existe
	IF NOT EXISTS(SELECT IdTipoPatrimonio FROM tb_TipoPatrimonio (NOLOCK) WHERE IdTipoPatrimonio = @IdTipoPatrimonio)
	BEGIN
		RAISERROR 60000 'Tipo Patrimonio nao encontrado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	--------------------------------------------------------


	-- Obtendo valor das variaveis
	-- IdManutencao
	SELECT @IdPatrimonio = MAX(IdPatrimonio) FROM tb_Patrimonio (NOLOCK)

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

	IF @IdPatrimonio IS NULL
		SET @IdPatrimonio = 0
	
	SET @IdPatrimonio = @IdPatrimonio + 1

	---------------------------------------------------------
	-- Inserindo manutencao
	INSERT INTO tb_Patrimonio
           (idPatrimonio
           ,dtCompra
           ,numeroNotaFiscal
           ,dtExpGarantia
           ,idTipoPatrimonio
           ,caminhoFotoNotaFiscal
           ,caminhoFotoPatrimonio
           ,numeroPece
           ,numeroPedido
           ,local)
     VALUES
           (@IdPatrimonio
           ,@DtCompra
           ,@NumeroNotaFiscal
           ,@DtExpGarantia
           ,@IdTipoPatrimonio
           ,@CaminhoFotoNotaFiscal
           ,@CaminhoFotoPatrimonio
           ,@NumeroPece
           ,@NumeroPedido
           ,@Local)

	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt



