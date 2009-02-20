-- =============================================
-- Author: Bruno Kohn
-- Create date: 2009-02-19
-- Description: Insere um usuario
-- =============================================

if exists (select * from sysobjects where type = 'p' and name = 'sp_usuario_inserir')
	begin
		drop  procedure  sp_usuario_inserir
	end

go

create procedure sp_usuario_inserir
	(
	  @nomeUsuario		varchar(50)
	 ,@senhaUsuario		varchar(20)
	 ,@descUsuario		varchar(255)
	 )
as	

set nocount on

	DECLARE @idUsuario int
	SELECT  @idUsuario = COUNT(*)+1 FROM tb_Usuario

	insert into tb_usuario
           (idUsuario
			,nomeUsuario
			,senhaUsuario
			,descUsuario
			,idTipoAcesso)
     values
           (@idUsuario
			,@nomeUsuario
			,@senhaUsuario
			,@descUsuario
			,0)

set nocount off
go
