GO

PRINT 'Criando PROCs de PATRIMONIO'

GO

PRINT 'Criando PROC sp_patrimonio_inserir'
GO
---------------------------------------
-- 1
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
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
---------------------------------------
GO

PRINT 'Criando PROC sp_patrimonio_consultar'
GO
---------------------------------------
-- 2
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
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
---------------------------------------
GO

PRINT 'Criando PROC sp_patrimonio_alterar'
GO
---------------------------------------
-- 3
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
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
---------------------------------------
GO

PRINT 'Criando PROC sp_patrimonio_remover'
GO
---------------------------------------
-- 4
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-04
    -- Description: Remove um patrimonio e todas suas dependecias
    -- =============================================
CREATE PROCEDURE [dbo].[sp_patrimonio_remover]
	 @IdPatrimonio	INT
	,@RetSt			INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-----------------------------------------------------
	-- Protecao

	-- Verifica se o patrimonio existe
	IF NOT EXISTS(	SELECT IdPatrimonio 
					FROM tb_Baixa (NOLOCK) 
					WHERE IdPatrimonio = @IdPatrimonio)
	BEGIN
		RAISERROR 60000 'Patrimonio nao encontrado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	--------------------------------------------------------

	-- Variaveis
	DECLARE  @IdBaixa			INT
			,@IdManutencao		INT
			,@IdValorAtributo	INT

	-- Valores das variaveis
	SELECT @IdBaixa = IdBaixa FROM tb_Baixa (NOLOCK) WHERE IdPatrimonio = @IdPatrimonio
	SELECT @IdManutencao = IdManutencao FROM tb_Manutencao (NOLOCK) WHERE IdPatrimonio = @IdPatrimonio
	SELECT @IdValorAtributo = IdValorAtributo FROM tb_PatrimonioAtributo (NOLOCK) WHERE IdPatrimonio = @IdPatrimonio
	

	-- Removendo Patrimonio das tabelas relacionadas:
	-- Baixa
	EXEC sp_baixa_remover @IdBaixa, @RetSt OUTPUT
	
	IF @RetSt <> 0 GOTO FIM

	-- Manutencao
	EXEC sp_manutencao_remover @IdManutencao, @RetSt OUTPUT

	IF @RetSt <> 0 GOTO FIM

	-- Valor atributo
	EXEC sp_valoratributo_remover @IdValorAtributo, @RetSt OUTPUT

	IF @RetSt <> 0 GOTO FIM

	-- PatrimonioAtributo
	EXEC sp_patrimonioatributo_remover @IdPatrimonio, @RetSt OUTPUT

	IF @RetSt <> 0 GOTO FIM

	-- Removendo Patrimonio da tabela Patrimonio
	DELETE FROM tb_Patrimonio
	WHERE IdPatrimonio = @IdPatrimonio

	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt
---------------------------------------
GO

PRINT 'PROCs criadas com sucesso'
GO