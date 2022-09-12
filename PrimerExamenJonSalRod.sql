--R#1
CREATE DATABASE PrimerExamen
GO

USE PrimerExamen
GO

--R#2
CREATE TABLE Productos
(
	id_producto int primary key not null,
	descripcion_producto varchar(25),
	precio_producto int,
	cantidad_producto int,
	categoria_producto varchar(25) 
);

CREATE TABLE Inventario
(
	id_producto int primary key not null, 
	nombre_producto varchar(25), 
	cantidad_producto int 
);

CREATE TABLE CostoProducto
(
	id_producto int primary key not null,
	cantidad_producto int,
	costo_producto real,
	monto_total real
);
go 

--R#3
create procedure In_datos
@IdProd int,
@DescProd varchar(25),
@PrecProd int,
@CantProd int,
@CatProd varchar(25)
AS 
	BEGIN
		IF exists (SELECT * FROM Productos WHERE id_producto = @IdProd)
			begin
				PRINT('Este producto ya existe')
			end
		ELSE
			begin
				INSERT INTO Productos(id_producto,descripcion_producto,precio_producto,cantidad_producto,categoria_producto)
				VALUES(@IdProd, @DescProd, @PrecProd, @CantProd,@CatProd)
				INSERT INTO Inventario values (@IdProd,@DescProd,@CantProd)
				PRINT('Producto :' + @IdProd+'añadido con exito')
			end
	END

EXEC In_datos 1,'Balon Futbol',7500,10,'Jugeteria'
EXEC In_datos 2,'Celular',375500,7,'Tecnologia'
EXEC In_datos 3,'Laptop',1250,6,'Tecnologia'
EXEC In_datos 4,'Impresora',45000,15,'Tecnologia'
EXEC In_datos 5,'FunkoPop',7500,30,'Jugeteria'
go
--/////////////////////////////////// 
--R#4
create trigger ActualCant
on Productos
	after UPDATE
	as
			begin 
				insert into Inventario(cantidad_producto)
				select cantidad_producto from inserted
			end
go

--///////////////////////////////////
--R#5
DECLARE @Categoria varchar(25)
DECLARE @IdProd int
DECLARE @CantProd int 
DECLARE @Iva as int
DECLARE @Precio as int
DECLARE cursor_productos CURSOR SCROLL 
FOR SELECT id_producto,cantidad_producto,categoria_producto,precio_producto FROM Productos 

OPEN cursor_productos 
FETCH LAST FROM cursor_productos into @IdProd,@CantProd,@Categoria,@Precio
WHILE @@FETCH_STATUS = 0  
   BEGIN  
      IF(@Categoria = 'Jugeteria')
		begin
			SET @Iva = 13
			INSERT INTO CostoProducto VALUES (@IdProd,@CantProd,@Precio,SUM(SUM(SUM(@CantProd*@Precio)*@Iva/100))+ SUM(@CantProd*@Precio))
		end 

	  ELSE IF(@Categoria = 'Tecnologia')
		begin 
			SET @Iva = 16
			INSERT INTO CostoProducto VALUES (@IdProd,@CantProd,@Precio,SUM(SUM(SUM(@CantProd*@Precio)*@Iva/100))+ SUM(@CantProd*@Precio))
		end 

	  FETCH PRIOR FROM cursor_productos into @IdProd,@CantProd,@Categoria,@Precio 
   END 
CLOSE cursor_productos 
DEALLOCATE cursor_productos 
GO 
--//////////////////////////////////
--R#6
CREATE VIEW Vista_productos 
AS
	select id_producto,descripcion_producto,precio_producto,cantidad_producto from Productos
GO
--//////////////////////////////////
--R#7
SELECT * FROM Vista_productos

--//////////////////////////////////
--R#8
EXEC sp_helptext Vista_productos
go
--//////////////////////////////////
--R#9
ALTER VIEW Vista_productos WITH ENCRYPTION
AS
	select id_producto,descripcion_producto,precio_producto,cantidad_producto from Productos
GO

--//////////////////////////////////
--R#10
DROP VIEW Vista_productos

--//////////////////////////////////
--R#11
DECLARE @Id_producto AS INT 
DECLARE @Numero_campo AS INT 
DECLARE @Nombre_campo AS NVARCHAR(20)
SET @Id_producto = 3
SET @Numero_campo =4
IF(@Numero_campo = 2)
	begin 
		SET @Nombre_campo = N'descripcion_producto'
	end 
else if (@Numero_campo = 3)
	begin 
		SET @Nombre_campo = N'precio_producto'
	end
else if (@Numero_campo = 4)
	begin 
		SET @Nombre_campo = N'cantidad_producto'
	end
EXEC('UPDATE Productos SET ' +@Nombre_campo+ ' = 8 WHERE id_producto = '+@Id_producto)
--//////////////////////////////////
--R#12
DECLARE @Precio_minimo NVARCHAR(50)
DECLARE @Precio_maximo NVARCHAR(50)

SET @Precio_minimo = N'1000'
SET @Precio_maximo = N'3500'

EXEC('SELECT * FROM Productos WHERE precio_producto BETWEEN ' + @Precio_minimo + 'AND ' + @Precio_maximo)

--//////////////////////////////////
--R#13
DECLARE @Buscar NVARCHAR(50)

SET @Buscar = N'ul'

EXEC('SELECT * FROM Productos WHERE descripcion_producto LIKE ''%' + @Buscar + '%''')
