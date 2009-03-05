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
-- Create date: 27/02/2009
-- Description:	Remove um atributo no BD
-- =============================================

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_atributo_remover' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_atributo_remover
END

GO

CREATE PROCEDURE sp_atributo_remover 
	-- Add the parameters for the stored procedure here
	@id				INT,
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

    -- Insert statements for procedure here
	DELETE FROM tb_TipoPatrimonioAtributo WHERE idAtributo IN 
	        (SELECT idAtributo FROM tb_Atributo WHERE idAtributo = @id)
	DELETE FROM tb_TipoPatrimonioAtributo WHERE idAtributo IN 
	        (SELECT idAtributo FROM tb_Atributo WHERE idAtributo = @id)
	DELETE FROM tb_ValorAtributo WHERE idAtributo IN 
	        (SELECT idAtributo FROM tb_Atributo WHERE idAtributo = @id)
	DELETE FROM tb_PatrimonioAtributo WHERE idAtributo IN 
	        (SELECT idAtributo FROM tb_Atributo WHERE idAtributo = @id)
	DELETE FROM tb_Atributo WHERE idAtributo = @id

	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
