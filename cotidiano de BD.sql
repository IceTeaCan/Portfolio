declare @value as float = 1731213384.87324
declare @num as int = 
select round((LEFT(@value,10)- @value),5)
power = potencias
ceiling = hacia arriba redondeo sin decimales 
floor = hacia abajo redondeo sin decimales 
declare @x as varchar (20) = 'helto world to everybody';
--select UPPER(@x), LOWER (@x)
--select LEFT (@x, 5)
--select RIGHT (@x, 7)
--select SUBSTRING (@x, 5, 6)
select CHARINDEX('to', @x, 15)
-- haga una función que reciba un número y que devuelva su parte decimal
-- por ejemplo, recibe el número 17384.87324 y devuelve 0.87324
declare @x as float = 8714328.871234
declare @y as float = 0.0
declare @entero as int = floor (@x)
select @y= @x - @entero
select @y
declare @i as int = 80.5;
select @i
declare @f as float = 8023.99999
select CEILING(@f)
select FLOOR (@f)
declare @miVariable as int = 50;
declare @x as varchar(20) = 'Hello world';
declare @i as int = 80.5;
select @i
declare @f as float = 80.5
select @i, @f
select CAST(@f as int)
select round(@i +@f, -5)
select round (POWER(@f, 2), -5)
-- haga un udf que indique cuántos productos están en un rango predeterminado de precio
declare @valorMinimo as float = 21.5;
declare @valorMaximo as float = 110;

select count(*) from Products where UnitPrice between @valorMinimo and @valorMaximo;
if OBJECT_ID ('CantidadDeProductosPorRangoDePrecio', 'FN') is not null
drop function CantidadDeProductosPorRangoDePrecio;
go
create function CantidadDeProductosPorRangoDePrecio (@valorMinimo as float,
@valorMaximo as float)
returns int
as
begin
declare @resultado as int = 0;
select @resultado = count(*)
from Products where UnitPrice
between @valorMinimo and @valorMaximo;
return @resultado;
end;
-- haga un udf que indique cuántos productos están en un rango predeterminado de precio
declare @valorMinimo as float = 21.5;
declare @valorMaximo as float = 110;

select count(*) from Products where UnitPrice between @valorMinimo and @valorMaximo;
if OBJECT_ID ('CantidadDeProductosPorRangoDePrecio', 'FN') is not null
drop function CantidadDeProductosPorRangoDePrecio;
go
create function CantidadDeProductosPorRangoDePrecio (@valorMinimo as float,
@valorMaximo as float)
returns int
as
begin
declare @resultado as int = 0;
select @resultado = count(*)
from Products where UnitPrice
between @valorMinimo and @valorMaximo;
return @resultado;
end;