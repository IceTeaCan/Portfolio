create database Facturacion
use Facturacion

create table Cliente(
Cedula bigint primary key not null,
Nombre varchar(30)
)

create table Producto(
Id_producto bigint primary key not null,
Nombre varchar(20) not null,
Tipo varchar(20),
Precio int not null,
CantStock int not null,
Company varchar(30)
)
create table Factura(
Id_factura bigint primary key not null,
NombreNegocio varchar(30),
CedJur bigint,
IdProforma bigint
)

create table Detalle(
Id_proforma bigint ,
Client bigint references Cliente(Cedula),
Id_prod bigint foreign key references Producto(Id_producto)not null,
PrecioTotal bigint not null,
Cantidad int not null
) 
-----------------------------------------------------------------------

insert into Producto values (1,'Pala','Herramienta',12000,50,'Truper')
insert into Producto values (2,'Baygon','Insecticida',7000,100,'Bayer')
insert into Producto values (3,'Caja jabón de baño','Cuidado personal',13000,500,'Batex')
insert into Producto values (4,'Desodorante Clinical','Cuidado personal',10900,500,'Rexona')
insert into Producto values (5,'bubbalo unidad','Chicle',50,5000,'Cadbury Adams')
insert into Producto values (6,'250ml Kapo','Jugo',500,200,'Dos Pinos')
insert into Producto values (7,'Choco CuQui','Galleta',250,150,'Gallito')
insert into Producto values (8,'Jaja 150g','Snaks',100,500,'Jacks')
insert into Producto values (9,'Meneitos','Snaks',12000,5000,'Truper')
insert into Producto values (10,'Pala','Snaks',12000,5000,'Truper')
insert into Producto values (11,'Monster Energy','Bebida energetica',1200,75,'Monster')
insert into Producto values (12,'Magnum','Helado',1000,50,'Magnum')

insert into Cliente values (3312342,'Vitaly')
insert into Cliente values (2210232,'Franchesko')
insert into Cliente values (1223131,'Grifindor')
go 
create procedure SetProducto
@Idproducto bigint,
@CantStock int,
@Nombre varchar(20),
@Tipo varchar(20),
@Compania varchar(20)
as 
	begin 
	insert into Producto values (@Idproducto,@CantStock,@Nombre,@Tipo,@Compania)
	end
	drop procedure SetDetalle

go 
create procedure SetCliente
@Cedula bigint ,
@Nombre varchar(30)
as
	begin
	insert into Cliente values (@Cedula,@Nombre)
	end

go 
create procedure SetDetalle
@Id_proforma bigint,
@Client bigint ,
@Id_prod bigint ,
@PrecioTotal bigint,
@Cantidad int 
as 
	begin 
	insert into Detalle values(@Id_proforma,@Client,@Id_prod,@PrecioTotal,@Cantidad)	
	end

	drop procedure SetDetalle
	drop table Detalle
	--f.Id_factura,f.NombreNegocio,f.CedJur,d.Client

go 
create procedure GetFacDetail
@Id_factura bigint ,
@cliente bigint
as
 begin 
 select f.Id_factura,f.NombreNegocio,f.CedJur,d.Client from Factura as f , Detalle as d  where @Id_factura = f.Id_factura and d.Client = @cliente
 end 

go 
create procedure Fact
@Id_factura bigint 
as
	begin
	select d.Id_prod,p.Precio,d.Cantidad,d.PrecioTotal from Factura as f , Detalle as d,Producto as p where IdProforma = Id_proforma and 1 = f.Id_factura and p.Id_producto = d.Id_prod
	end

go 
create procedure SetFactura
@Id_factura bigint ,
@Id_proforma bigint 
as
	begin
	insert into Factura values(@Id_factura,'Super Pepito',12314112,@Id_proforma)
	end
	select * from Factura

	SELECT        Detalle.Id_prod, Producto.Nombre, Detalle.Cantidad, Producto.Tipo, Producto.Precio, Detalle.PrecioTotal
FROM            
                         Detalle INNER JOIN
                         Producto ON Detalle.Id_prod = Producto.Id_producto CROSS JOIN
                         Factura WHERE factura.IdProforma = Detalle.Id_proforma

