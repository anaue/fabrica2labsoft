USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_baixa_inserir]    Script Date: 03/05/2009 18:40:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
    ,@IdEquipamento		INT
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

	-- Verifica se o equipamento existe
	IF NOT EXISTS(SELECT IdEquipamento FROM tb_Equipamento (NOLOCK) WHERE IdEquipamento = @IdEquipamento)
	BEGIN
		RAISERROR 70000 'Equipamento nao encontrado'
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
	VALUES (@DestinoBaixa, @ObservacoesBaixa, @IdUsuario, @IdEquipamento, @IdBaixa, @DtBaixa)

	SET @RetSt = @@ERROR
	---------------------------------------------------------

FIM:
	RETURN @RetSt


