
GO

PRINT 'Criando PROCs de MANUTENCAO'

GO

PRINT 'Criando PROC sp_manutencao_inserir'
GO
---------------------------------------
-- 1
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-04
    -- Description: Insere manutencao
    -- =============================================
CREATE PROCEDURE [dbo].[sp_manutencao_inserir]
	 @DtManutencao		DATETIME
    ,@MotivoManutencao	VARCHAR(255)
    ,@Observacoes		VARCHAR(255)
    ,@IdUsuario			INT
	,@IdPatrimonio		INT
	,@RetSt				INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-- Variaveis que serao utilizadas
	DECLARE @IdManutencao INT

	-----------------------------------------------------
	-- Protecao

	-- Verifica se o usuario existe
	IF NOT EXISTS(SELECT IdUsuario FROM tb_Usuario (NOLOCK) WHERE IdUsuario = @IdUsuario)
	BEGIN
		RAISERROR 60000 'Usuario nao encontrado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END

	-- Verifica se o patrimonio existe
	IF NOT EXISTS(SELECT IdPatrimonio FROM tb_Patrimonio (NOLOCK) WHERE IdPatrimonio = @IdPatrimonio)
	BEGIN
		RAISERROR 70000 'Patrimonio nao encontrado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	--------------------------------------------------------


	-- Obtendo valor das variaveis
	-- IdManutencao
	SELECT @IdManutencao = MAX(IdManutencao) FROM tb_Manutencao (NOLOCK)

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

	IF @IdManutencao IS NULL
		SET @IdManutencao = 0
	
	SET @IdManutencao = @IdManutencao + 1

	---------------------------------------------------------
	-- Inserindo manutencao
	INSERT INTO tb_Manutencao (idManutencao, dtManutencao, motivoManutencao, observacoesManutencao, idUsuario, idPatrimonio)
	VALUES (@IdManutencao, @DtManutencao, @MotivoManutencao, @Observacoes, @IdUsuario, @IdPatrimonio)

	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt
---------------------------------------
GO

PRINT 'Criando PROC sp_manutencao_consultar'
GO
---------------------------------------
-- 2
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
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
---------------------------------------
GO

PRINT 'Criando PROC sp_manutencao_alterar'
GO
---------------------------------------
-- 3
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-04
    -- Description: Altera os dados de uma manutencao
    -- =============================================
CREATE PROCEDURE [dbo].[sp_manutencao_alterar]
	 @IdManutencao			INT
    ,@DtManutencao			DATETIME		= NULL
    ,@MotivoManutencao		VARCHAR(50)		= NULL
	,@ObservacoesManutencao	VARCHAR(255)	= NULL
	,@IdUsuario				INT				= NULL
	,@RetSt					INT				= 0		OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-----------------------------------------------------
	-- Protecao

	-- Verifica se a manutencao existe
	IF NOT EXISTS(	SELECT idManutencao 
					FROM tb_Manutencao (NOLOCK) 
					WHERE idManutencao = @IdManutencao)
	BEGIN
		RAISERROR 60000 'Manutencao nao encontrada'
		SET @RetSt = @@ERROR
		GOTO FIM
	END

	-- Verifica se usuario existe
	IF @IdUsuario IS NOT NULL
		IF NOT EXISTS(	SELECT IdUsuario 
						FROM tb_Manutencao (NOLOCK) 
						WHERE IdUsuario = @IdUsuario)
		BEGIN
			RAISERROR 70000 'Usuario nao encontrado'
			SET @RetSt = @@ERROR
			GOTO FIM
		END
	--------------------------------------------------------


	-- Atualizando servico
	UPDATE tb_Manutencao
	SET	 DtManutencao = COALESCE(@DtManutencao, DtManutencao)
		,MotivoManutencao = COALESCE(@MotivoManutencao, MotivoManutencao)
		,ObservacoesManutencao = COALESCE(@ObservacoesManutencao, ObservacoesManutencao)
		,IdUsuario = COALESCE(@IdUsuario, IdUsuario)
	WHERE IdManutencao = @IdManutencao
	
	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt
---------------------------------------
GO

PRINT 'Criando PROC sp_manutencao_remover'
GO
---------------------------------------
-- 4
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-04
    -- Description: Remove uma manutencao
    -- =============================================
CREATE PROCEDURE [dbo].[sp_manutencao_remover]
	 @IdManutencao	INT
	,@RetSt			INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-----------------------------------------------------
	-- Protecao

	-- Verifica se o servico existe
	IF NOT EXISTS(	SELECT IdManutencao 
					FROM tb_Manutencao (NOLOCK) 
					WHERE IdManutencao = @IdManutencao)
	BEGIN
		RAISERROR 60000 'Manutencao nao encontrada'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	--------------------------------------------------------


	-- Removendo servico
	DELETE FROM tb_Manutencao
	WHERE IdManutencao = @IdManutencao

	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt
---------------------------------------
GO

PRINT 'PROCs criadas com sucesso'
GO