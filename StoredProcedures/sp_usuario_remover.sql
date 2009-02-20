-- =============================================
-- Author: Bruno Kohn
-- Create date: 2009-02-19
-- Description: remove um usuario
-- =============================================

if exists (select * from sysobjects where type = 'p' and name = 'sp_usuario_remover')
	begin
		drop  procedure  sp_usuario_remover
	end

go

create procedure sp_usuario_remover
	(
	  @idUsuario		int	 
	 )
as	

set nocount on	

	delete from tb_usuario
		where idUsuario=@idUsuario

set nocount off
go
