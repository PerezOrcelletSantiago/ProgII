create database Facultad
go
use Facultad

create table Asignatura
(cod_materia int identity(1,1),
nombre varchar(150) not null,
constraint pk_materia primary key (cod_materia)
)

create table Carrera
(cod_carrera int,
nombre varchar(150),
titulo varchar(250),
disponible bit,
constraint pk_carrera primary key (cod_carrera)
)

create table DetalleCarrera
(cod_detalle_carrera int identity(500,1),
anio_cursado int,
cuatrimestre varchar(25),
cod_materia int,
cod_carrera int,
constraint pk_detalle_carrera primary key (cod_detalle_carrera),
constraint fk_asignatura foreign key (cod_materia)
references Asignatura (cod_materia),
constraint fk_carrera foreign key (cod_carrera)
references Carrera (cod_carrera)
)

insert into Asignatura (nombre)
values ('Ingles')
insert into Asignatura (nombre)
values ('Matematica')
insert into Asignatura (nombre)
values ('SPD')
insert into Asignatura (nombre)
values ('Lab Computacion 1')
insert into Asignatura (nombre)
values ('Programacion 1')
insert into Asignatura (nombre)
values ('Ingles 2')
insert into Asignatura (nombre)
values ('Estadistica')
insert into Asignatura (nombre)
values ('ASO')
insert into Asignatura (nombre)
values ('Lab Computacion 2')
insert into Asignatura (nombre)
values ('Programacion 2')
insert into Asignatura (nombre)
values ('Met Investigacion')

insert into Carrera (cod_carrera, nombre, titulo, disponible)
values (100, 'TUP', 'Tecnico Universitario en Programacion', 1)

insert into Carrera (cod_carrera, nombre, titulo, disponible)
values (110, 'MiniTUP', 'Algo raro', 1)

insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Primero', 1, 100)
insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Primero', 2, 100)
insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Primero', 3, 100)
insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Primero', 4, 100)
insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Primero', 5, 100)
insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Segundo', 6, 100)
insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Segundo', 7, 100)
insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Segundo', 8, 100)
insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Segundo', 9, 100)
insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Segundo', 10, 100)
insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Segundo', 11, 100)

insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Primero', 1, 110)
insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (1, 'Segundo', 11, 110)

select * from Asignatura
select * from DetalleCarrera
select * from Carrera

create procedure SP_TUP_SegundoCuatrimestre
as
select c.nombre Carrera, anio_cursado 'Año Cursado', cuatrimestre, a.nombre Asignatura
from DetalleCarrera d join Carrera c on d.cod_carrera=c.cod_carrera 
join Asignatura a on a.cod_materia=d.cod_materia
where cuatrimestre like 'Segundo'

exec SP_TUP_SegundoCuatrimestre

create procedure SP_InsertarMaestro
@cod_carrera int,
@nombre varchar(150),
@titulo varchar(150),
@cod_carrera_salida int output
as
insert into Carrera (cod_carrera, nombre, titulo, disponible)
values (@cod_carrera, @nombre, @titulo, 1)
set @cod_carrera_salida=@cod_carrera

exec SP_InsertarMaestro

create procedure SP_InsertarDetalle
@anio_cursado int,
@cuatrimestre varchar(50),
@cod_materia int,
@cod_carrera_salida int
as
insert into DetalleCarrera (anio_cursado, cuatrimestre, cod_materia, cod_carrera)
values (@anio_cursado, @cuatrimestre, @cod_materia, @cod_carrera_salida)

exec SP_InsertarDetalle

create procedure SP_ComboAsignaturas
as
select *
from Asignatura

exec SP_ComboAsignaturas

create procedure SP_ComboCarreras
as
select *
from Carrera

exec SP_ComboCarreras


create procedure SP_BajaLogica
@cod_carrera int
as
update Carrera
set disponible=0
where cod_carrera=@cod_carrera

exec SP_BajaLogica

create procedure SP_AltaLogica	
@cod_carrera int
as
update Carrera
set disponible=1
where cod_carrera=@cod_carrera

exec SP_AltaLogica

create procedure SP_DeleteDetalle
@cod_carrera int
as
delete DetalleCarrera
where cod_carrera=@cod_carrera

exec SP_DeleteDetalle

create procedure SP_CargarDetalles
@cod_carrera int
as
select a.cod_materia id, anio_cursado, cuatrimestre, a.nombre asignatura
from DetalleCarrera d join Asignatura a on a.cod_materia=d.cod_materia
join Carrera c on c.cod_carrera=d.cod_carrera
where c.cod_carrera=@cod_carrera

exec SP_CargarDetalles

create procedure SP_ReporteMateriasTUP
as
select nombre Asignatura, anio_cursado
from Asignatura a join DetalleCarrera d on a.cod_materia=d.cod_materia
where cuatrimestre like '%Primero%'
order by anio_cursado, nombre

exec SP_ReporteMateriasTUP