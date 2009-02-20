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
-- Author:		Fabio Gutiyama
-- Create date: 20.02.2009
-- Description:	Insere dados de atributo no banco
-- =============================================
CREATE PROCEDURE dbo.sp_insere_atributo
	-- Add the parameters for the stored procedure here
	@nome varchar(50),
	@descricao varchar(255),
	@tipo varchar(20),
	@nulo varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @idGerado int	

	SELECT @idGerado = id FROM 
		(SELECT TOP 1 idAtributo + 1 AS id FROM tb_Atributo ORDER BY idAtributo DESC) AS tb

    INSERT INTO tb_Atributo (idAtributo, nomeAtributo, descAtributo, tipoAtributo, nuloAtributo) 
	VALUES( @idGerado, @nome, @descricao, @tipo, @nulo)
END
GO
