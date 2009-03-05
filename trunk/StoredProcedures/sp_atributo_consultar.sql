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

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_atributo_consultar' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_atributo_consultar
END

GO

CREATE PROCEDURE sp_atributo_consultar 
	-- Add the parameters for the stored procedure here
	@id				INT,
	@nome			VARCHAR(50), 
	@desc			VARCHAR(255),
	@tipo			VARCHAR(20),
	@nulo			VARCHAR(20),
	@tipoPatrimonio	INT,
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SET @RetSt = @@ERROR
	IF @RetSt <> 0 GOTO FIM

    -- Insert statements for procedure here
	SELECT * FROM tb_Atributo WHERE
	idAtributo = COALESCE(@id, idAtributo) AND
	nomeAtributo LIKE '%' + COALESCE(@nome, nomeAtributo) + '%' AND
	descAtributo LIKE '%' + COALESCE(@desc, descAtributo) + '%' AND
	tipoAtributo LIKE '%' + COALESCE(@tipo, tipoAtributo) + '%' AND
	nuloAtributo LIKE '%' + COALESCE(@nulo, nuloAtributo) + '%' AND
	idTipoPatrimonio = COALESCE(@tipoPatrimonio, idTipoPatrimonio)

	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
