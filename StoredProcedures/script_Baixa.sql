
GO

PRINT 'Criando PROCs de BAIXA'

GO

PRINT 'Criando PROC sp_baixa_inserir'
GO
---------------------------------------
-- 1
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-02-19
    -- Description: Insere uma baixa
    -- =============================================
CREATE PROCEDURE [dbo].[sp_baixa_inserir]
	 @DestinoBaixa		VARCHAR(50)
	,@DtBaixa			DATETIME
    ,@ObservacoesBaixa	VARCHAR(255)
    ,@IdUsuario			INT
    ,@IdPatrimonio		INT
	,@RetSt				INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-- Variaveis que serao utilizadas
	DECLARE @IdBaixa INT

	-----------------------------------------------------
	-- Protecao

	-- Verifica se o usuario existe
	IF NOT EXISTS(SELECT IdUsuario FROM tb_Usuario (NOLOCK) WHERE IdUsuario = @IdUsuario)
	BEGIN
		RAISERROR 60000 'Usuario nao encontrado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END

	-- Verifica se o Patrimonio existe
	IF NOT EXISTS(SELECT IdPatrimonio FROM tb_Patrimonio (NOLOCK) WHERE IdPatrimonio = @IdPatrimonio)
	BEGIN
		RAISERROR 70000 'Patrimonio nao encontrado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	--------------------------------------------------------


	-- Obtendo valor das variaveis
	-- IdBaixa
	SELECT @IdBaixa = MAX(IdBaixa) FROM tb_Baixa (NOLOCK)

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

	IF @IdBaixa IS NULL
		SET @IdBaixa = 0
	
	SET @IdBaixa = @IdBaixa + 1

	---------------------------------------------------------
	-- Inserindo baixa
	INSERT INTO tb_Baixa (DestinoBaixa, ObservacoesBaixa, IdUsuario, IdPatrimonio, IdBaixa, DtBaixa)
	VALUES (@DestinoBaixa, @ObservacoesBaixa, @IdUsuario, @IdPatrimonio, @IdBaixa, @DtBaixa)

	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt
---------------------------------------
GO

PRINT 'Criando PROC sp_baixa_consultar'
GO
---------------------------------------
-- 2
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
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
---------------------------------------
GO

PRINT 'Criando PROC sp_baixa_alterar'
GO
---------------------------------------
-- 3
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
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
---------------------------------------
GO

PRINT 'Criando PROC sp_baixa_remover'
GO
---------------------------------------
-- 4
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-04
    -- Description: Remove uma baixa
    -- =============================================
CREATE PROCEDURE [dbo].[sp_baixa_remover]
	 @IdBaixa	INT
	,@RetSt		INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-----------------------------------------------------
	-- Protecao

	-- Verifica se o servico existe
	IF NOT EXISTS(	SELECT IdBaixa 
					FROM tb_Baixa (NOLOCK) 
					WHERE IdBaixa = @IdBaixa)
	BEGIN
		RAISERROR 60000 'Baixa nao encontrada'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	--------------------------------------------------------


	-- Removendo servico
	DELETE FROM tb_Baixa
	WHERE IdBaixa = @IdBaixa

	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt
---------------------------------------
GO

PRINT 'PROCs criadas com sucesso'
GO