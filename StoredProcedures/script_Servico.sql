
GO

PRINT 'Criando PROCs de SERVICO'

GO

PRINT 'Criando PROC sp_servico_inserir'
GO
---------------------------------------
-- 1
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-04
    -- Description: Inserir um novo serviço e seu endereço
    -- =============================================
CREATE PROCEDURE [dbo].[sp_servico_inserir]
	 @NomeServico		VARCHAR(200)
	,@EnderecoServico	VARCHAR(200)
	,@RetSt				INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-- Variaveis
	DECLARE @IdMaestroMapping INT

	-----------------------------------------------------------
	-- Validacao
	IF EXISTS (	SELECT NomeServico 
				FROM MaestroMapping (NOLOCK)
				WHERE NomeServico = @NomeServico 
				OR EnderecoServico = @EnderecoServico)
		BEGIN
			RAISERROR 60000 'Servico ja esta presente.'
			SET @RetSt = @@ERROR
			GOTO FIM
		END
	-------------------------------------------------------------

	-- Obtendo valor da varivel
	SELECT @IdMaestroMapping = MAX(IdMaestroMapping) FROM MaestroMapping (NOLOCK)

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

	IF @IdMaestroMapping IS NULL
		SET @IdMaestroMapping = 0
	
	SET @IdMaestroMapping = @IdMaestroMapping + 1


	-- Inserindo servico

	INSERT INTO MaestroMapping (idMaestroMapping, NomeServico, EnderecoServico)
	VALUES (@IdMaestroMapping, @NomeServico, @EnderecoServico)

	SET @RetSt = @@ERROR
FIM:
	RETURN @RetSt
---------------------------------------
GO

PRINT 'Criando PROC sp_servico_consultar'
GO
---------------------------------------
-- 2
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-02-27
    -- Description: Obtem endereco de determinado serviço
    -- =============================================
CREATE PROCEDURE [dbo].[sp_servico_consultar]
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
			AND nomeServico LIKE '%' + @NomeServico + '%'
			AND EnderecoServico LIKE '%' + @EnderecoServico + '%'

	SET @RetSt = @@ERROR
FIM:
	RETURN @RetSt
---------------------------------------
GO

PRINT 'Criando PROC sp_servico_alterar'
GO
---------------------------------------
-- 3
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
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
---------------------------------------
GO

PRINT 'Criando PROC sp_servico_remover'
GO
---------------------------------------
-- 4
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-03-04
    -- Description: Remove um servico
    -- =============================================
CREATE PROCEDURE [dbo].[sp_servico_remover]
	 @IdMaestroMapping	INT
	,@RetSt				INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	-----------------------------------------------------
	-- Protecao

	-- Verifica se o servico existe
	IF NOT EXISTS(	SELECT IdMaestroMapping 
					FROM MaestroMapping (NOLOCK) 
					WHERE IdMaestroMapping = @IdMaestroMapping)
	BEGIN
		RAISERROR 60000 'Servico nao encontrado'
		SET @RetSt = @@ERROR
		GOTO FIM
	END
	--------------------------------------------------------


	-- Removendo servico
	DELETE FROM MaestroMapping
	WHERE IdMaestroMapping = @IdMaestroMapping

	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt
---------------------------------------
GO

PRINT 'PROCs criadas com sucesso'
GO