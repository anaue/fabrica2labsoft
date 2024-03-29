USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_patrimonio_remover]    Script Date: 03/05/2009 18:46:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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




