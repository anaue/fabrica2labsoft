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
-- Description:	Consulta tipo de patrimonio no BD
-- =============================================

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_tipopatrimonio_consultar' AND type = 'P')
BEGIN
  DROP PROCEDURE sp_tipopatrimonio_consultar
END

GO

CREATE PROCEDURE sp_tipopatrimonio_consultar 
	-- Add the parameters for the stored procedure here
	@id				INT,
	@nome			VARCHAR(50), 
	@desc			VARCHAR(255),
	@tipo			INT,
	@RetSt			INT = 0	OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tb_TipoPatrimonio WHERE
		idTipoPatrimonio = COALESCE(@id, 
		) AND
		nomeTipoPatrimonio LIKE '%' + COALESCE(@nome, nomeTipoPatrimonio) + '%' AND
		descTipoPatrimonio LIKE '%' + COALESCE(@desc, descTipoPatrimonio) + '%' AND
		idTipoAcesso = COALESCE(@tipo, idTipoAcesso)
	SET @RetSt = @@ERROR

FIM:
	RETURN @RetSt

END
GO
