create database Curso 
go 

use Curso
go 

create table CLIENTES 
(
	Id int identity(1,1)not null,
	NOMBRE varchar(50),
	LOCALIZACION varchar(50),
	primary key(ID)
);                                                                        