


-- se crea la base de datos 
create database Universidad

 --se da uso a la misma
use Universidad

-- se crean las tablas de la base de datos
create table Profesor(
codigo_prof int primary key not null,
nombre_prof varchar(20) not null,
apellidos_prof varchar(50) not null
)

create table Curso(
codigo_cur int primary key not null,
nombre_cur varchar(25) not null,
creditos_cur int not null,
codigo_prof int foreign key references profesores(codigo_prof)
)

create table Estudiante(
codigo_est int primary key not null,
nombre_est varchar(20) not null,
apellido_est varchar(50) not null
)

create table Estudiante_curso(
registro int primary key not null,
codigo_est int foreign key references Estudiante(codigo_est) not null,
codigo_cur int foreign key references Curso(codigo_cur) not null
)

-- cree 4 procedimientos almacenados de insercion y su sentencia de ejecución (1 para cada tabla) 
--no se especifica si es ingresado por el usuario asi que lo deje de solo ejecucion
go 
create procedure InsProf
@Cod_prof int,
@nom_prof varchar(20),
@Apell_prof varchar(20)
as
insert into Profesor values(@Cod_prof,@nom_prof,@Apell_prof)
--Execution of procedure
exec InsProf @Cod_prof = 1,@nom_prof = 'Pablo Emilio',@Apell_prof ='Escobar Gaviria'

--
go 
create procedure InsCurs
@codigo_cur int,
@nombre_cur varchar(25),
@creditos_cur int,
@codigo_prof int
as
insert into Curso values(@codigo_cur,@nombre_cur,@creditos_cur,@codigo_prof)
--Execution of procedure
exec InsCurs @codigo_cur = 1,@nombre_cur = 'Matemática financiera',@creditos_cur = 4,@codigo_prof = 1;

--
go 
create procedure InsEst
@codigo_est int,
@nombre_est varchar(20),
@apellido_est varchar(50)
as
insert into Estudiante values(@codigo_est,@nombre_est,@apellido_est)
--Execution of procedure
exec InsEst @codigo_est = 1,@nombre_est = 'Esteban',@apellido_est = 'Quito'

--
go 
create procedure InsEst_cur
@registro int,
@codigo_est int,
@codigo_cur int
as
insert into Estudiante_curso values(@registro,@codigo_est,@codigo_cur)
--Execution of procedure
exec InsEst_cur @registro = 1,@codigo_est = 1,@codigo_cur = 1 

-- cree 2 procedimientos almacenados de actualización de registros con parámetros de entrada

go 
create procedure SetCambioNombreCurso
@Quien as int,
@Que as varchar(25)
as 
	begin 
	update Curso set nombre_cur = @Que where codigo_cur = @Quien
	end

	--Execution of procedure
 exec SetCambioNombreCurso @Quien = 1, @Que = 'Jose';

go 

create procedure SetCambioNombreProfeso
@Quien as int,
@Que as varchar(25)
as 
	begin 
	update Profesor set nombre_prof = @Que where codigo_prof = @Quien
	end

	--Execution of procedure
 exec SetCambioNombreProfeso @Quien = 1, @Que = 'Jose';

-- cree 2 procedimientos almacenados de selección de registros con parámetros de entrada

go 
create procedure SeeCurso
@Curso as int
as 
	begin 
	select * from Estudiante_curso where codigo_cur = @Curso
	end
	--Execution of procedure
 exec SeeCurso @Curso = 1;

 go 
create procedure SeeAlumno
@Alumno as int
as 
	begin 
	select * from Estudiante where codigo_est = @Alumno
	end
	--Execution of procedure
 exec SeeAlumno @Alumno = 1;

-- cree un procedimiento almacenado de selección de registros con parámetros de entrada utilizando unión de tablas

go 
create procedure SearchCursoInfParaAlum
@CursoBus int 
as
	begin
		SELECT        Curso.nombre_cur, Curso.codigo_cur, Profesor.nombre_prof, Profesor.apellidos_prof, Profesor.codigo_prof
		FROM            
                         Curso INNER JOIN
                         Profesor ON Curso.codigo_prof = Profesor.codigo_prof where Curso.codigo_cur = @CursoBus
	end
 --Execution of procedure
 exec SearchCursoInfParaAlum @CursoBus = 1;

-- cree un procedimiento almacenado utilizando una sentencia if
go 
create function Ysi(@CursoSend as int)
returns varchar(20)
as
begin
	declare @CursoSearch as varchar(20) = '';
	declare @Text as varchar(50) = '';
	select @CursoSearch = C.nombre_cur from Curso as C where C.codigo_cur = @CursoSend
	if @CursoSearch = 0  set @Text = 'No Encontrado';
	else set @Text = 'Curso : '+ @CursoSearch;
	return @Text;
end

--Execution of procedure
go
select Ysi(1)
-- cree un procedimiento almacenado utilizando una sentencia while
-- utilice una sentencia case
