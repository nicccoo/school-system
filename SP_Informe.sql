USE [Disenio_admin_BD]
GO

/****** Object:  StoredProcedure [dbo].[spTotAluInsc]    Script Date: 10/11/2020 09:11:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[spTotAluInsc]
@turno varchar(5),
@anio varchar(4)
as
if (@turno is null or @turno = '') and (@anio is null or @anio='')
	begin
	select exa.cod_turno,tur.desc_turno, count(exa.cod_turno) as 'cant_inscriptos' from Examenes exa inner join Turnos tur on exa.cod_turno=tur.cod_turno group by exa.cod_turno, tur.desc_turno
	end
else
	begin
	if (@turno is null or @turno = '') and @anio is not null 
		begin
		select exa.cod_turno,tur.desc_turno, count(exa.cod_turno) as 'cant_inscriptos' from Examenes exa inner join Turnos tur on exa.cod_turno=tur.cod_turno  where exa.año = @anio group by exa.cod_turno, tur.desc_turno
		end
	else
		begin
			if @turno is not null and (@anio is null or @anio = '')
				begin
				select exa.cod_turno,tur.desc_turno, count(exa.cod_turno) as 'cant_inscriptos' from Examenes exa inner join Turnos tur on exa.cod_turno=tur.cod_turno where exa.cod_turno = @turno group by exa.cod_turno, tur.desc_turno
				end
			else
				begin
					if @turno is not null and @anio is not null 
					begin
					select exa.cod_turno,tur.desc_turno, count(exa.cod_turno) as 'cant_inscriptos' from Examenes exa inner join Turnos tur on exa.cod_turno=tur.cod_turno where exa.cod_turno = @turno and exa.año = @anio group by exa.cod_turno, tur.desc_turno
					end
				end
		end
	end
GO


