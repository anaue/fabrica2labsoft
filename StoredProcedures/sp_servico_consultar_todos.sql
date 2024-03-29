USE [fabrica2db]
GO
/****** Object:  StoredProcedure [dbo].[sp_servico_consultar_todos]    Script Date: 03/05/2009 18:47:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    -- =============================================
    -- Author: Renan
    -- Create date: 2009-02-27
    -- Description: Obtem endereco de todos os serviços
    -- =============================================
CREATE PROCEDURE [dbo].[sp_servico_consultar_todos]
	@RetSt				INT = 0	OUTPUT
AS
	-- Para evitar 1 row affected
    SET NOCOUNT ON

	SELECT enderecoServico
	FROM MaestroMapping (NOLOCK) 
	
	SET @RetSt = @@ERROR
FIM:
	RETURN @RetSt

