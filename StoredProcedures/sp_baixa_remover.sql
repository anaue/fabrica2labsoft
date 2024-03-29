USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_baixa_remover]    Script Date: 03/05/2009 18:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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



