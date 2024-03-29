USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_servico_inserir]    Script Date: 03/05/2009 18:48:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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


