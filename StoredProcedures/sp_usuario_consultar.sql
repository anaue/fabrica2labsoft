-- =============================================
-- Author: Bruno Kohn
-- Create date: 2009-02-19
-- Description: consulta um usuario com com o id especificado ou retorna todos os usuarios se nao for passado o id
-- =============================================

if exists (select * from sysobjects where type = 'p' and name = 'sp_usuario_consultar')
	begin
		drop  procedure  sp_usuario_consultar
	end

go

create procedure sp_usuario_consultar
	(
	  @idUsuario		int	 =null
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