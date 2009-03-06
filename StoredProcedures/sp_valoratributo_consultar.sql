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
-- Description:	Consulta valor de atributo
-- =============================================

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_valoratributo_consultar' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_valoratributo_consultar
END

GO

CREATE PROCEDURE sp_valoratributo_consultar 
	-- Add the parameters for the stored procedure here
	@idvaloratributo	INT,
	@idatributo			INT, 
	@valor				VARCHAR(255),
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tb_ValorAtributo WHERE
		idValorAtributo = COALESCE(@idvaloratributo, idValorAtributo) AND
		idAtributo = COALESCE(@idatributo, idAtributo) AND
		valor LIKE '%' + COALESCE(@valor, valor) + '%'
	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
