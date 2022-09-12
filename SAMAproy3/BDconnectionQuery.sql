create database Agenda
use Agenda 
------Jeffrey's part
--------------------creacion de la tabla que almacena las contraseñas de la agenda personal

---tabla de usuario
create table Registro
(
Contraseña varchar(30) not null,
Usuario varchar(30) not null,
Correo varchar(100) not null,
Nombre varchar(60) not null,
Apellidos varchar(60) not null,
primary key(Usuario)
)

---tabla de empresas
create table Empresarial
(
Contraseña varchar(30) not null,
Usuario varchar(30) not null,
Nombre_Empresa varchar(60) not null,
Correo varchar(100) not null,
primary key(Usuario)
)

-----------------------------------------------------Jonathan's part

--primary key references UsuarioInv(Usuario)

create table Contacto(
Usuarios varchar(20) not null,
email varchar(20) not null,
Nombre varchar(20) not null,
Apellido varchar(20) not null,
TelEmp int not null,
TelCel int not null,
Direccion varchar(20) not null,
Empresa varchar(20) not null
) 
-------------------TABLAS------------------------audry's part 

create table ContactoPe(
Nombre varchar(20) not null,
Apellido varchar(20) not null,
Telefono_Celular int not null primary key,
Correo varchar(100)not null,
Direccion varchar(100)not null,
Fecha_Nacimiento varchar(50) not null,
Apodo varchar(50)
)

go 
create procedure Ingresar_contacto
@Usuario varchar(20) ,--Parametros
@email varchar(20),
@Nombre varchar(20),
@Apellido varchar(20),
@TelEmp int ,
@TelCel int ,
@Direccion varchar(30),
@Empresa varchar(20)
as
	insert into Contacto values(@Usuario,@email,@Nombre,@Apellido,@TelEmp,@TelCel,@Direccion,@Empresa)


go 
create procedure Consultar_Contacto
@Usuario varchar(20) ,--Parametros
@email varchar(20),
@Nombre varchar(20),
@Apellido varchar(20),
@TelEmp int ,
@TelCel int ,
@Direccion varchar(30),
@Empresa varchar(20)
as
	select * from Contacto
	--modificar a numero de telefono porque un nombre se puede repetir 
go 
create procedure Eliminar_contacto
@Tel int
as
	delete from Contacto where TelCel = @Tel
	
	drop procedure Eliminar_contacto

go 
create procedure Modificar_usuario
@Tel int,
@NewUsuario varchar(20)
as
	update Contacto set Usuarios = @NewUsuario where TelCel = @Tel


go 
create procedure Modificar_Nombre
@Tel int,
@NewNombre varchar(20)
as
	update Contacto set Nombre = @NewNombre where TelCel = @Tel

go 
create procedure Modificar_Apellido
@Tel int,
@NewApellido varchar(20)
as
	update Contacto set Apellido = @NewApellido where TelCel = @Tel

go 
create procedure Modificar_Email
@Tel int,
@NewEmail varchar(20)
as
	update Contacto set email = @NewEmail where TelCel = @Tel

go 
create procedure Modificar_Empresa
@Tel int,
@NewEmpresa varchar(20)
as
	update Contacto set Empresa = @NewEmpresa where TelCel = @Tel

go 
create procedure Modificar_Direccion
@Tel int,
@NewDireccion varchar(30)
as
	update Contacto set Direccion = @NewDireccion where TelCel = @Tel

go 
create procedure Modificar_TelEmp
@Tel int,
@NewTelEmp int
as
	update Contacto set TelEmp = @NewTelEmp where TelCel = @Tel

go 
create procedure Modificar_TelCel
@Tel int,
@NewTelCel int
as
	update Contacto set TelCel = @NewTelCel where TelCel = @Tel
	
---------------------------------------------------------------------------------Jeffrey procedures
select * from Registro
go
---ingreso del usuario
create procedure Ingreso
(
@Contraseña varchar(30),
@Usuario varchar(30),
@Correo varchar(100),
@Nombre varchar(60),
@Apellidos varchar(60)
)
as
insert into Registro(Contraseña,Usuario,Correo,Nombre,Apellidos)
values(@Contraseña,@Usuario,@Correo,@Nombre,@Apellidos)

go
-------------------------FIN DE LA PARTE DEL USUARIO----------------------------
--------------------------------------------------------------------------------
--------------------------------------------------------------------------------
---procedure empresa
create procedure Empresarial_reg
(
@Contraseña varchar(30),
@Usuario varchar(30),
@Nombre_Empresa varchar(60),
@Correo varchar(100)
)
as
insert into Empresarial(Contraseña,Usuario,Nombre_Empresa,Correo)
values(@Contraseña,@Usuario,@Nombre_Empresa,@Correo)


--------------------------------------------------------- audry's procedures
go
create procedure Insertar_ContactoPe
@Nombre varchar(20),
@Apellido varchar(20),
@Telefono_Celular int,
@Correo varchar(100), 
@Direccion varchar(100), 
@Fecha_Nacimiento varchar(50),
@Apodo varchar(50)
as 
  insert into ContactoPe(Nombre, Apellido, Telefono_Celular, Correo, Direccion, Apodo, Fecha_Nacimiento)
  values (@Nombre, @Apellido, @Telefono_Celular, @Correo, @Direccion, @Apodo, @Fecha_Nacimiento)

  select * from ContactoPe
--------------------------------------------------------------------------------------

  go 
  create procedure Eliminar_ContactoPe
  @Tel_Celular int 
  as
     delete from ContactoPe where Telefono_Celular = @Tel_Celular
----------------------------------------------------------------------------------------
  go 
create procedure Buscar_ContactoPe
@Nombre varchar(20),
@Apellido varchar(20),
@Telefono_Celular int,
@Correo varchar(100), 
@Direccion varchar(100), 
@Fecha_Nacimiento varchar(50),
@Apodo varchar(50)
as 
   select * from ContactoPe
 
-----------------------------------------------------------------------------------------
go 
create procedure Modificar_ContactoPe
@Nombre varchar(20),
@Apellido varchar(20),
@Telefono_Celular int,
@Correo varchar(100), 
@Direccion varchar(100), 
@Fecha_Nacimiento varchar(50),
@Apodo varchar(50)
as  
  update ContactoPe
  set Nombre = @Nombre,
  Apellido = @Apellido,
  Telefono_Celular = @Telefono_Celular,
  Correo = @Correo,
  Direccion = @Direccion,
  Fecha_Nacimiento = @Fecha_Nacimiento,
  Apodo = @Apodo
  Where Telefono_Celular = @Telefono_Celular
  