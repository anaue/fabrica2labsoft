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
-- Description:	Consulta atributo no BD
-- =============================================

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_atributo_consultar_by_patrimonio' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_atributo_consultar_by_patrimonio
END

GO

CREATE PROCEDURE sp_atributo_consultar_by_patrimonio 
	-- Add the parameters for the stored procedure here
	@IdPatrimonio				INT,
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

    -- Insert statements for procedure here
	SELECT A.IdAtributo, A.NomeAtributo, A.DescAtributo, A.TipoAtributo, A.NuloAtributo
	FROM tb_Atributo as A
	INNER JOIN tb_PatrimonioAtributo as B ON A.IdAtributo = B.IdAtributo
	WHERE B.IdPatrimonio = @IdPatrimonio

	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
