-- =============================================
-- Author: Bruno Kohn
-- Create date: 2009-03-05
-- Description: consulta as permissoes de um usuario para uma tela
-- =============================================

if exists (select * from sysobjects where type = 'p' and name = 'sp_permissoes_consultar')
	begin
		drop  procedure  sp_permissoes_consultar
	end

go

create procedure sp_permissoes_consultar
	(
	  @idUsuario		int	= null
	  ,@idTela			int = null
	 )
as	

set nocount on	
	
SELECT [idUsuario]
      ,[idTela]
      ,[incluir]
      ,[excluir]
      ,[consultar]
      ,[editar]
  FROM [tb_UsuarioTela]
  where idUsuario = @idUsuario
  and	idTela = @idTela
	
set nocount off
go