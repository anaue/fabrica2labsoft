-- =============================================
-- Author: Bruno Kohn
-- Create date: 2009-02-19
-- Description: altera um usuario
-- =============================================

if exists (select * from sysobjects where type = 'p' and name = 'sp_usuario_alterar')
	begin
		drop  procedure  sp_usuario_alterar
	end

go

create procedure sp_usuario_alterar
	(
	  @idUsuario		int
	 ,@nomeUsuario		varchar(50)
	 ,@senhaUsuario		varchar(20)
	 ,@descUsuario		varchar(255)
	 )
as	

set nocount on	

	update tb_usuario
		set           
			nomeUsuario=@nomeUsuario
			,senhaUsuario=@senhaUsuario
			,descUsuario=@descUsuario
			,idTipoAcesso=0
	where
		idUsuario=@idUsuario

set nocount off
go
