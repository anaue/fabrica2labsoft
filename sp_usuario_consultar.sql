-- =============================================
-- Author: Bruno Kohn
-- Create date: 2009-02-19
-- Description: traz o usuario com o id passado como parametro ou lista todos os usuarios se nao for passado nenhum parametro
-- =============================================

if exists (select * from sysobjects where type = 'p' and name = 'sp_usuario_consultar')
	begin
		drop  procedure  sp_usuario_consultar
	end

go

create procedure sp_usuario_consultar
	(
	  @idUsuario	int	 = null
	 )
as	

set nocount on	

	select 
		 usuario.idUsuario
		,usuario.nomeUsuario
		,usuario.senhaUsuario
		,usuario.descUsuario
		,usuario.idTipoAcesso
		,tipoAcesso.nomeTipoAcesso	
	from tb_Usuario as usuario
	inner join tb_TipoAcesso as tipoAcesso 
	on usuario.idTipoAcesso=tipoAcesso.idTipoAcesso
	where (usuario.idUsuario=@idUsuario or @idUsuario is null)

set nocount off
go
