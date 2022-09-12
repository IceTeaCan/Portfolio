   
create database TikiFoodSA

use TikiFoodSA


create table Soda(
IdSoda int identity(1,1) primary key not null,
Nombre varchar(50),
Telefono varchar(14),
Localizacion varchar(60),
Descripcion varchar(200),
Horario_ap varchar(20),
Horario_ci varchar(20)

)
--ComentariosUsuario join Usuario




create table Carrito( 
IdCarrito int    primary key not null
)




create table Usuario(
IdUsuario int primary key ,
Nombre  varchar(20),
Apellido varchar(20),--volatil
Correo varchar(50),
Contraseña varchar(20), 
Telefono varchar (14),
Localizacion Varchar(50),--FotoLog imagen 
IdCarrito int foreign key references Carrito(Idcarrito),

)



create table Administrador(
IdUsuario varchar(20) primary key not null,
Nombre  varchar(20),
Apellido varchar(20),--volatil
Correo varchar(20),
Contraseña varchar(20), 
Telefono varchar (14),
Localizacion Varchar(50),
IdSoda int foreign key references Soda(IdSoda)

)


create table Producto(
IdProducto int identity(1,1) primary key not null,
IdSoda int foreign key references Soda(IdSoda),
Nombre varchar(20),
CostoUnitario money
)

create table Contenido(
IdContenido int identity(1,1) primary key not null,
Descripcion varchar (50),
CantUniDisponible int,
PrecioUnidad money
)

create table Contenido_producto(
IdProducto int foreign key references Producto(IdProducto),
IdContenido int,
Cantidad int
)

create table Contenido_prod_pers(
IdProducto int foreign key references Producto(IdProducto),
IdentDeProduct int not null,
IdContenido int foreign key references Contenido(IdContenido),
ContNomb varchar(50),
IdCarrito int foreign key references Carrito(IdCarrito),
IdPedido int not null,
Cantidad int 
)

create table Pedido(
IdPedido int not null,
IdCarrito int foreign key references Carrito(IdCarrito) not null,
IdProducto int foreign key references Producto(IdProducto) not null,
IdSoda int foreign key references Soda(IdSoda),
Cantidad int ,
CostoUnitario money,
CostoTotal money
)
go


create proc Consulta_Soda
@IdSoda int
as 
	begin
		select * from Producto where IdSoda = @IdSoda
	end

insert into Soda values ('Soda Sol y Luna','70263342','Cartago','La delicias de cartago en un solo lugar','L-V:8am S-D:9am','L-V:8pm S-D:9pm')
insert into Soda values ('Soda Baru','70543218','Guanacaste','El mejor sabor de guanacaste','L-V:8.30am S-D:9am','L-V:8pm S-D:9pm')
insert into Soda values ('Soda Tapia','89722234','San Jose','La n�mero 1 de todo san jose','L-V:6am S-D:8am','L-V:8.30pm S-D:8pm')

insert into Producto values (1,'Chalupa',3200)
insert into Producto values (1,'Taco con papas',3600)
insert into Producto values (2,'Alas de Pollo',4350)
insert into Producto values (2,'Lapiz',1600)
insert into Producto values (3,'Hamburguesa',3750)
insert into Producto values (3,'Doraditas',500)

truncate table Usuario
truncate table Carrito

insert into Carrito values (1)
insert into Carrito values (13)

insert into Usuario values (1,'Jonathan','Salazar','jonathan@hotmail.com','1','78990098','Paraiso',1)


insert into Administrador values ('123456','Jonathan','Salazar','jonathan@hotmail.com','4','78990098','Paraiso',1)
insert into Administrador values ('252525','Angel','Gomez','jonathan@hotmail.com','18','78990098','Paraiso',2)
insert into Administrador values ('121212','Fernando','Constantino','jonathan@hotmail.com','13','78990098','Paraiso',3)

insert into Administrador values ('1','Jonathan','Salazar','jonathan@hotmail.com','2','78990098','Paraiso')
insert into Contenido values ('Pepinillo',5,2000)
insert into Contenido values ('Papas Fritas',10,6300)
insert into Contenido values ('Torta de carne',30,1200)
insert into Contenido values ('Tomate',8,100)
insert into Contenido values ('Lechuga',10,500)
insert into Contenido values ('Pan brioche',40,800)
insert into Contenido values ('Carne mechada',40,800)
insert into Contenido values ('Salsa Tomate',4,2250)
insert into Contenido values ('Mayonesa',5,2350)
insert into Contenido values ('Tortilla Tostada',20,200)
insert into Contenido values ('Taco',30,600)
insert into Contenido values ('Repollo',2,400)
insert into Contenido values ('Queso amarillo',100,100)
insert into Contenido values ('Queso Rallado',6,1300)
insert into Contenido values ('Ala de pollo',70,500)
insert into Contenido values ('Salsa BBQ',8,2150)
insert into Contenido values ('Salsa Ranch',5,2050)
insert into Contenido values ('Salsa Mostaza miel',6,3150)
insert into Contenido values ('Aguacate',5,750)
insert into Contenido values ('Mantequilla',5,1750)
insert into Contenido values ('Pan cuadrado',3,2450)

truncate table Contenido_producto
insert into Contenido_producto values (1,7,1)
insert into Contenido_producto values (1,4,1)
insert into Contenido_producto values (1,14,1)
insert into Contenido_producto values (1,5,1)

insert into Contenido_producto values (2,2,1)
insert into Contenido_producto values (2,11,2)
insert into Contenido_producto values (2,12,1)
insert into Contenido_producto values (2,8,1)
insert into Contenido_producto values (2,9,1)

insert into Contenido_producto values (3,15,8)
insert into Contenido_producto values (3,16,1)
insert into Contenido_producto values (3,17,1)
insert into Contenido_producto values (3,18,1)

insert into Contenido_producto values (4,21,2)
insert into Contenido_producto values (4,7,1)
insert into Contenido_producto values (4,12,1)
insert into Contenido_producto values (4,13,2)
insert into Contenido_producto values (4,20,2)

insert into Contenido_producto values (5,6,2)
insert into Contenido_producto values (5,20,2)
insert into Contenido_producto values (5,4,1)
insert into Contenido_producto values (5,5,1)
insert into Contenido_producto values (5,3,1)
insert into Contenido_producto values (5,13,1)
insert into Contenido_producto values (5,8,1)
insert into Contenido_producto values (5,9,1)
insert into Contenido_producto values (5,1,3)

insert into Contenido_producto values (6,10,3)
insert into Contenido_producto values (6,9,1)
insert into Contenido_producto values (6,8,1)

truncate table usuario
truncate table pedido
truncate table Contenido_prod_pers

--////////////////////////////////////////////////////////////////////// Insert chalupa

insert into Contenido_prod_pers values (1,1,7,'Carne mechada',1,1,1)
insert into Contenido_prod_pers values (1,1,4,'Tomate',1,1,0)
insert into Contenido_prod_pers values (1,1,14,'Queso Rallado',1,1,1)
insert into Contenido_prod_pers values (1,1,5,'Lechuga',1,1,1)
insert into Pedido values (1,1,1,1,1,3200,3200)

insert into Contenido_prod_pers values (1,2,7,'Carne mechada',1,1,1)
insert into Contenido_prod_pers values (1,2,4,'Tomate',1,1,1)
insert into Contenido_prod_pers values (1,2,14,'Queso Rallado',1,1,1)
insert into Contenido_prod_pers values (1,2,5,'Lechuga',1,1,0)
insert into Pedido values (1,1,1,1,2,3200,6400)

--////////////////////////////////////////////////////////////////////// Insert tacopapa

insert into Contenido_prod_pers values (2,1,2,'Papas Fritas',1,1,1)
insert into Contenido_prod_pers values (2,1,11,'Taco',1,1,0)
insert into Contenido_prod_pers values (2,1,12,'Repollo',1,1,1)
insert into Contenido_prod_pers values (2,1,8,'Salsa Tomate',1,1,0)
insert into Contenido_prod_pers values (2,1,9,'Mayonesa',1,1,1)
insert into Pedido values (1,1,2,1,1,3600,3600)

insert into Contenido_prod_pers values (2,2,2,'Papas Fritas',1,1,1)
insert into Contenido_prod_pers values (2,2,11,'Taco',1,1,0)
insert into Contenido_prod_pers values (2,2,12,'Repollo',1,1,1)
insert into Contenido_prod_pers values (2,2,8,'Salsa Tomate',1,1,1)
insert into Contenido_prod_pers values (2,2,9,'Mayonesa',1,1,0)
insert into Pedido values (1,1,2,1,2,3200,7200)

--////////////////////////////////////////////////////////////////////// Insert alitas

insert into Contenido_prod_pers values (3,1,15,'Ala de pollo',1,1,8)
insert into Contenido_prod_pers values (3,1,16,'Salsa BBQ',1,1,0)
insert into Contenido_prod_pers values (3,1,17,'Salsa Ranch',1,1,1)
insert into Contenido_prod_pers values (3,1,18,'Salsa Mostaza miel',1,1,1)
insert into Pedido values (1,1,3,2,1,4350,4350)

insert into Contenido_prod_pers values (3,2,15,'Ala de pollo',1,1,8)
insert into Contenido_prod_pers values (3,2,16,'Salsa BBQ',1,1,1)
insert into Contenido_prod_pers values (3,2,17,'Salsa Ranch',1,1,1)
insert into Contenido_prod_pers values (3,2,18,'Salsa Mostaza miel',1,1,1)
insert into Pedido values (1,1,3,2,2,4350,8700)

--////////////////////////////////////////////////////////////////////// Insert lapiz

insert into Contenido_prod_pers values (4,1,21,'Pan cuadrado',1,1,2)
insert into Contenido_prod_pers values (4,1,7,'Carne mechada',1,1,1)
insert into Contenido_prod_pers values (4,1,12,'Repollo',1,1,1)
insert into Contenido_prod_pers values (4,1,13,'Queso amarillo',1,1,2)
insert into Contenido_prod_pers values (4,1,20,'Mantequilla',1,1,0)
insert into Pedido values (1,1,4,2,1,1600,1600)

insert into Contenido_prod_pers values (4,2,21,'Pan cuadrado',1,1,2)
insert into Contenido_prod_pers values (4,2,7,'Carne mechada',1,1,1)
insert into Contenido_prod_pers values (4,2,12,'Repollo',1,1,1)
insert into Contenido_prod_pers values (4,2,13,'Queso amarillo',1,1,2)
insert into Contenido_prod_pers values (4,2,20,'Mantequilla',1,1,2)
insert into Pedido values (1,1,4,2,2,1600,2200)

--/////////////////////////////////////////////////////////////////////////////// Insert Hamburguesa 

insert into Contenido_prod_pers values (5,1,6,'Pan brioche',1,1,2)
insert into Contenido_prod_pers values (5,1,20,'Mantequilla',1,1,2)
insert into Contenido_prod_pers values (5,1,4,'Tomate',1,1,1)
insert into Contenido_prod_pers values (5,1,5,'Lechuga',1,1,1)
insert into Contenido_prod_pers values (5,1,3,'Torta de carne',1,1,2)
insert into Contenido_prod_pers values (5,1,13,'Queso amarillo',1,1,0)
insert into Contenido_prod_pers values (5,1,8,'Salsa Tomate',1,1,1)
insert into Contenido_prod_pers values (5,1,9,'Mayonesa',1,1,1)
insert into Contenido_prod_pers values (5,1,1,'Pepinillo',1,1,1)
insert into Pedido values (1,1,5,3,1,3750,3750)

insert into Contenido_prod_pers values (5,2,6,'Pan brioche',1,1,2)
insert into Contenido_prod_pers values (5,2,20,'Mantequilla',1,1,1)
insert into Contenido_prod_pers values (5,2,4,'Tomate',1,1,1)
insert into Contenido_prod_pers values (5,2,5,'Lechuga',1,1,2)
insert into Contenido_prod_pers values (5,2,3,'Torta de carne',1,1,2)
insert into Contenido_prod_pers values (5,2,13,'Queso amarillo',1,1,1)
insert into Contenido_prod_pers values (5,2,8,'Salsa Tomate',1,1,1)
insert into Contenido_prod_pers values (5,2,9,'Mayonesa',1,1,0)
insert into Contenido_prod_pers values (5,2,1,'Pepinillo',1,1,1)
insert into Pedido values (1,1,5,3,2,3750,7500)

--//////////////////////////////////////////////////////////////////////Insert doraditas

insert into Contenido_prod_pers values (6,1,10,'Tortilla Tostada',1,1,3)
insert into Contenido_prod_pers values (6,1,9,'Mayonesa',1,1,0)
insert into Contenido_prod_pers values (6,1,8,'Salsa Tomate',1,1,1)
insert into Pedido values (1,1,6,3,1,500,500)

insert into Contenido_prod_pers values (6,2,10,'Tortilla Tostada',1,1,3)
insert into Contenido_prod_pers values (6,2,9,'Mayonesa',1,1,1)
insert into Contenido_prod_pers values (6,2,8,'Salsa Tomate',1,1,1)
insert into Pedido values (1,1,6,3,2,500,1000)



--/////////////////////////////////////////////////////// 2do pedido

truncate table Pedido
truncate table Contenido_prod_pers

select * from Pedido
select * from Contenido_prod_pers

--////////////////////////////////////////////////////////////////////// Insert chalupa

insert into Contenido_prod_pers values (1,1,7,'Carne mechada',1,2,1)
insert into Contenido_prod_pers values (1,1,4,'Tomate',1,2,0)
insert into Contenido_prod_pers values (1,1,14,'Queso Rallado',1,2,1)
insert into Contenido_prod_pers values (1,1,5,'Lechuga',1,2,1)
insert into Pedido values (2,1,1,1,1,3200,3200)

insert into Contenido_prod_pers values (1,2,7,'Carne mechada',1,2,1)
insert into Contenido_prod_pers values (1,2,4,'Tomate',1,2,0)
insert into Contenido_prod_pers values (1,2,14,'Queso Rallado',1,2,0)
insert into Contenido_prod_pers values (1,2,5,'Lechuga',1,2,1)
insert into Pedido values (2,1,1,1,2,3200,6400)

--////////////////////////////////////////////////////////////////////// Insert tacopapa

insert into Contenido_prod_pers values (2,1,2,'Papas Fritas',1,2,1)
insert into Contenido_prod_pers values (2,1,11,'Taco',1,2,2)
insert into Contenido_prod_pers values (2,1,12,'Repollo',1,2,0)
insert into Contenido_prod_pers values (2,1,8,'Salsa Tomate',1,2,1)
insert into Contenido_prod_pers values (2,1,9,'Mayonesa',1,2,1)
insert into Pedido values (2,1,2,1,1,3600,3600)

insert into Contenido_prod_pers values (2,2,2,'Papas Fritas',1,2,1)
insert into Contenido_prod_pers values (2,2,11,'Taco',1,2,2)
insert into Contenido_prod_pers values (2,2,12,'Repollo',1,2,1)
insert into Contenido_prod_pers values (2,2,8,'Salsa Tomate',1,2,0)
insert into Contenido_prod_pers values (2,2,9,'Mayonesa',1,2,1)
insert into Pedido values (2,1,2,1,2,3200,7200)
--////////////////////////////////////////////////////////////////////// Insert alitas

insert into Contenido_prod_pers values (3,1,15,'Ala de pollo',1,2,8)
insert into Contenido_prod_pers values (3,1,16,'Salsa BBQ',1,2,0)
insert into Contenido_prod_pers values (3,1,17,'Salsa Ranch',1,2,1)
insert into Contenido_prod_pers values (3,1,18,'Salsa Mostaza miel',1,2,1)
insert into Pedido values (2,1,3,2,1,4350,4350)

insert into Contenido_prod_pers values (3,2,15,'Ala de pollo',1,2,8)
insert into Contenido_prod_pers values (3,2,16,'Salsa BBQ',1,2,1)
insert into Contenido_prod_pers values (3,2,17,'Salsa Ranch',1,2,1)
insert into Contenido_prod_pers values (3,2,18,'Salsa Mostaza miel',1,2,1)
insert into Pedido values (2,1,3,2,2,4350,8700)

--////////////////////////////////////////////////////////////////////// Insert lapiz

insert into Contenido_prod_pers values (4,1,21,'Pan cuadrado',1,2,2)
insert into Contenido_prod_pers values (4,1,7,'Carne mechada',1,2,1)
insert into Contenido_prod_pers values (4,1,12,'Repollo',1,2,0)
insert into Contenido_prod_pers values (4,1,13,'Queso amarillo',1,2,2)
insert into Contenido_prod_pers values (4,1,20,'Mantequilla',1,2,2)
insert into Pedido values (2,1,4,2,1,1600,1600)

insert into Contenido_prod_pers values (4,2,21,'Pan cuadrado',1,2,2)
insert into Contenido_prod_pers values (4,2,7,'Carne mechada',1,2,1)
insert into Contenido_prod_pers values (4,2,12,'Repollo',1,2,1)
insert into Contenido_prod_pers values (4,2,13,'Queso amarillo',1,2,2)
insert into Contenido_prod_pers values (4,2,20,'Mantequilla',1,2,0)
insert into Pedido values (2,1,4,2,2,1600,2200)

--/////////////////////////////////////////////////////////////////////////////// Insert Hamburguesa 

insert into Contenido_prod_pers values (5,1,6,'Pan brioche',1,2,2)
insert into Contenido_prod_pers values (5,1,20,'Mantequilla',1,2,2)
insert into Contenido_prod_pers values (5,1,4,'Tomate',1,2,1)
insert into Contenido_prod_pers values (5,1,5,'Lechuga',1,2,1)
insert into Contenido_prod_pers values (5,1,3,'Torta de carne',1,2,2)
insert into Contenido_prod_pers values (5,1,13,'Queso amarillo',1,2,1)
insert into Contenido_prod_pers values (5,1,8,'Salsa Tomate',1,2,1)
insert into Contenido_prod_pers values (5,1,9,'Mayonesa',1,2,1)
insert into Contenido_prod_pers values (5,1,1,'Pepinillo',1,2,0)
insert into Pedido values (2,1,5,3,1,3750,3750)

insert into Contenido_prod_pers values (5,2,6,'Pan brioche',1,2,2)
insert into Contenido_prod_pers values (5,2,20,'Mantequilla',1,2,0)
insert into Contenido_prod_pers values (5,2,4,'Tomate',1,2,0)
insert into Contenido_prod_pers values (5,2,5,'Lechuga',1,2,2)
insert into Contenido_prod_pers values (5,2,3,'Torta de carne',1,2,2)
insert into Contenido_prod_pers values (5,2,13,'Queso amarillo',1,2,1)
insert into Contenido_prod_pers values (5,2,8,'Salsa Tomate',1,2,1)
insert into Contenido_prod_pers values (5,2,9,'Mayonesa',1,2,1)
insert into Contenido_prod_pers values (5,2,1,'Pepinillo',1,2,0)
insert into Pedido values (2,1,5,3,2,3750,7500)

--//////////////////////////////////////////////////////////////////////Insert doraditas

insert into Contenido_prod_pers values (6,1,10,'Tortilla Tostada',1,2,3)
insert into Contenido_prod_pers values (6,1,9,'Mayonesa',1,2,1)
insert into Contenido_prod_pers values (6,1,8,'Salsa Tomate',1,2,0)
insert into Pedido values (2,1,6,3,1,500,500)

insert into Contenido_prod_pers values (6,2,10,'Tortilla Tostada',1,2,3)
insert into Contenido_prod_pers values (6,2,9,'Mayonesa',1,2,1)
insert into Contenido_prod_pers values (6,2,8,'Salsa Tomate',1,2,1)
insert into Pedido values (2,1,6,3,2,500,1000)


select * from Usuario
select * from Pedido
select * from Contenido_prod_pers
select * from carrito








--///////////////////////////////////////////////////UsuarioCreado



--////////////////////////////////////////////////////////////////////// Insert chalupa

insert into Contenido_prod_pers values (1,1,7,'Carne mechada',2,1,1)
insert into Contenido_prod_pers values (1,1,4,'Tomate',2,1,1)
insert into Contenido_prod_pers values (1,1,14,'Queso Rallado',2,1,1)
insert into Contenido_prod_pers values (1,1,5,'Lechuga',2,1,1)
insert into Pedido values (1,2,1,1,1,3200,3200)

insert into Contenido_prod_pers values (1,2,7,'Carne mechada',2,1,1)
insert into Contenido_prod_pers values (1,2,4,'Tomate',2,1,1)
insert into Contenido_prod_pers values (1,2,14,'Queso Rallado',2,1,1)
insert into Contenido_prod_pers values (1,2,5,'Lechuga',2,1,1)
insert into Pedido values (1,2,1,1,2,3200,6400)

--////////////////////////////////////////////////////////////////////// Insert tacopapa

insert into Contenido_prod_pers values (2,1,2,'Papas Fritas',2,1,1)
insert into Contenido_prod_pers values (2,1,11,'Taco',2,1,2)
insert into Contenido_prod_pers values (2,1,12,'Repollo',2,1,0)
insert into Contenido_prod_pers values (2,1,8,'Salsa Tomate',2,1,1)
insert into Contenido_prod_pers values (2,1,9,'Mayonesa',2,1,1)
insert into Pedido values (1,2,2,1,1,3600,3600)

insert into Contenido_prod_pers values (2,2,2,'Papas Fritas',2,1,0)
insert into Contenido_prod_pers values (2,2,11,'Taco',2,1,2)
insert into Contenido_prod_pers values (2,2,12,'Repollo',2,1,1)
insert into Contenido_prod_pers values (2,2,8,'Salsa Tomate',2,1,1)
insert into Contenido_prod_pers values (2,2,9,'Mayonesa',2,1,1)
insert into Pedido values (1,2,2,1,2,3200,7200)

--////////////////////////////////////////////////////////////////////// Insert alitas

insert into Contenido_prod_pers values (3,1,15,'Ala de pollo',2,1,8)
insert into Contenido_prod_pers values (3,1,16,'Salsa BBQ',2,1,1)
insert into Contenido_prod_pers values (3,1,17,'Salsa Ranch',2,1,0)
insert into Contenido_prod_pers values (3,1,18,'Salsa Mostaza miel',2,1,1)
insert into Pedido values (1,2,3,2,1,4350,4350)

insert into Contenido_prod_pers values (3,2,15,'Ala de pollo',2,1,8)
insert into Contenido_prod_pers values (3,2,16,'Salsa BBQ',2,1,0)
insert into Contenido_prod_pers values (3,2,17,'Salsa Ranch',2,1,0)
insert into Contenido_prod_pers values (3,2,18,'Salsa Mostaza miel',2,1,1)
insert into Pedido values (1,2,3,2,2,4350,8700)

--////////////////////////////////////////////////////////////////////// Insert lapiz

insert into Contenido_prod_pers values (4,1,21,'Pan cuadrado',2,1,2)
insert into Contenido_prod_pers values (4,1,7,'Carne mechada',2,1,1)
insert into Contenido_prod_pers values (4,1,12,'Repollo',2,1,1)
insert into Contenido_prod_pers values (4,1,13,'Queso amarillo',2,1,2)
insert into Contenido_prod_pers values (4,1,20,'Mantequilla',2,1,2)
insert into Pedido values (1,2,4,2,1,1600,1600)

insert into Contenido_prod_pers values (4,2,21,'Pan cuadrado',2,1,2)
insert into Contenido_prod_pers values (4,2,7,'Carne mechada',2,1,1)
insert into Contenido_prod_pers values (4,2,12,'Repollo',2,1,1)
insert into Contenido_prod_pers values (4,2,13,'Queso amarillo',2,1,2)
insert into Contenido_prod_pers values (4,2,20,'Mantequilla',2,1,2)
insert into Pedido values (1,2,4,2,2,1600,2200)

--/////////////////////////////////////////////////////////////////////////////// Insert Hamburguesa 

insert into Contenido_prod_pers values (5,1,6,'Pan brioche',2,1,2)
insert into Contenido_prod_pers values (5,1,20,'Mantequilla',2,1,2)
insert into Contenido_prod_pers values (5,1,4,'Tomate',2,1,1)
insert into Contenido_prod_pers values (5,1,5,'Lechuga',2,1,2)
insert into Contenido_prod_pers values (5,1,3,'Torta de carne',2,1,2)
insert into Contenido_prod_pers values (5,1,13,'Queso amarillo',2,1,1)
insert into Contenido_prod_pers values (5,1,8,'Salsa Tomate',2,1,1)
insert into Contenido_prod_pers values (5,1,9,'Mayonesa',2,1,1)
insert into Contenido_prod_pers values (5,1,1,'Pepinillo',2,1,0)
insert into Pedido values (1,2,5,3,1,3750,3750)

insert into Contenido_prod_pers values (5,2,6,'Pan brioche',2,1,2)
insert into Contenido_prod_pers values (5,2,20,'Mantequilla',2,1,2)
insert into Contenido_prod_pers values (5,2,4,'Tomate',2,1,1)
insert into Contenido_prod_pers values (5,2,5,'Lechuga',2,1,2)
insert into Contenido_prod_pers values (5,2,3,'Torta de carne',2,1,2)
insert into Contenido_prod_pers values (5,2,13,'Queso amarillo',2,1,1)
insert into Contenido_prod_pers values (5,2,8,'Salsa Tomate',2,1,1)
insert into Contenido_prod_pers values (5,2,9,'Mayonesa',2,1,1)
insert into Contenido_prod_pers values (5,2,1,'Pepinillo',2,1,1)
insert into Pedido values (1,2,5,3,2,3750,7500)

--//////////////////////////////////////////////////////////////////////Insert doraditas

insert into Contenido_prod_pers values (6,1,10,'Tortilla Tostada',2,1,3)
insert into Contenido_prod_pers values (6,1,9,'Mayonesa',2,1,1)
insert into Contenido_prod_pers values (6,1,8,'Salsa Tomate',2,1,0)
insert into Pedido values (1,2,6,3,1,500,500)

insert into Contenido_prod_pers values (6,2,10,'Tortilla Tostada',2,1,3)
insert into Contenido_prod_pers values (6,2,9,'Mayonesa',2,1,0)
insert into Contenido_prod_pers values (6,2,8,'Salsa Tomate',2,1,1)
insert into Pedido values (1,2,6,3,2,500,1000)


select * from Producto
select * from Contenido
select * from Contenido_producto
select * from Contenido_prod_pers


drop table Pedido
drop table Contenido_prod_pers
drop table Usuario
drop table Carrito



select * from Usuario
select * from Administrador
select * from Producto
select * from Contenido_producto
select * from Soda
select * from Carrito
select * from Contenido
select * from Contenido_producto
select * from Contenido_prod_pers
select * from Pedido
 
--pedido chalupa
insert into Pedido values (1,1,1,1,1,3200,3200)
insert into Pedido values (1,1,1,1,2,3200,6400)
--pedido taco
insert into Pedido values (1,1,2,1,1,3600,3600)
insert into Pedido values (1,1,2,1,2,3200,7200)
--pedido alas de pollo
insert into Pedido values (1,1,3,2,1,4350,4350)
insert into Pedido values (1,1,3,2,2,4350,8700)
--pedido lapiz
insert into Pedido values (1,1,4,2,1,1600,1600)
insert into Pedido values (1,1,4,2,2,1600,2200)
--pedido hamburguesa 
insert into Pedido values (1,1,5,3,1,3750,3750)
insert into Pedido values (1,1,5,3,2,3750,7500)
--pedido doraditas 
insert into Pedido values (1,1,6,3,1,500,500)
insert into Pedido values (1,1,6,3,2,500,1000)

--/////////////////////////////////////////////////////// 2do pedido

--pedido chalupa
insert into Pedido values (2,1,1,1,1,3200,3200)
insert into Pedido values (2,1,1,1,2,3200,6400)
--pedido taco
insert into Pedido values (2,1,2,1,1,3600,3600)
insert into Pedido values (2,1,2,1,2,3200,7200)
--pedido alas de pollo
insert into Pedido values (2,1,3,2,1,4350,4350)
insert into Pedido values (2,1,3,2,2,4350,8700)
--pedido lapiz
insert into Pedido values (2,1,4,2,1,1600,1600)
insert into Pedido values (2,1,4,2,2,1600,2200)
--pedido hamburguesa 
insert into Pedido values (2,1,5,3,1,3750,3750)
insert into Pedido values (2,1,5,3,2,3750,7500)
--pedido doraditas 
insert into Pedido values (2,1,6,3,1,500,500)
insert into Pedido values (2,1,6,3,2,500,1000)