USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_manutencao_remover]    Script Date: 03/05/2009 18:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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



