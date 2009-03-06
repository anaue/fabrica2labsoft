-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Felipe Yoshida
-- Create date: 05/03/2009
-- Description:	Remove valor de atributo
-- =============================================

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_valoratributo_remover' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_valoratributo_remover
END

GO

CREATE PROCEDURE sp_valoratributo_remover 
	-- Add the parameters for the stored procedure here
	@id				INT,
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Validação
	IF NOT EXISTS(SELECT idValorAtributo FROM tb_ValorAtributo WHERE idValorAtributo = @id)
	BEGIN
		RAISERROR 50007 'Valor de atributo inexistente'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	
	IF EXISTS(SELECT idValorAtributo FROM tb_PatrimonioAtributo WHERE idValorAtributo = @id)
	BEGIN
		RAISERROR 60007 'Há um patrimonio usando este atributo'
		SET @RetSt = @@ERROR
		GOTO FIM
	END	

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

    -- Insert statements for procedure here
	DELETE FROM tb_ValorAtributo WHERE idValorAtributo = @id

	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
