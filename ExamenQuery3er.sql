use NORTHWND
create table OrderDetailsHistory
(OrderDetaildHistoryId int identity(1,1) primary key,
OrderId int,
OldProductId int,
OldUnitPrice money,
OldQuantity smallint,
OldDiscount real,
NewProductId int,
NewUnitPrice money,
NewQuantity smallint,
NewDiscount real,
DeltaUnitPrice money,
DeltaQuantity money,
DateAndTimeOperation datetime,
Operation varchar (10)
)

if OBJECT_ID ('FN_PROMEDIO_ORDEN', 'FN') is not null
drop function FN_PROMEDIO_ORDEN;
go
create function FN_PROMEDIO_ORDEN (@NumeroDeOrden as int)
returns int
as
begin
declare @resultado as int = 0;
select @resultado = count(ProductID)
from [Order Details] where OrderID = @NumeroDeOrden
return @resultado;
end;

select dbo.FN_PROMEDIO_ORDEN(10937)



if OBJECT_ID ('FN_TOTAL_NETO_ORDEN', 'FN') is not null
drop function FN_TOTAL_NETO_ORDEN;
go
create function FN_TOTAL_NETO_ORDEN (@NumeroDeOrden as int)
returns real
as
begin
declare @resultado as real = 0
select @resultado = sum(Quantity) *sum(UnitPrice)- sum(UnitPrice*Discount) 
from [Order Details] where OrderID = @NumeroDeOrden
return @resultado
end

select dbo.FN_TOTAL_NETO_ORDEN(10354)

select OrderID from [Order Details]

if OBJECT_ID ('FN_REGISTROS_ESPECIALES', 'FN') is not null
drop function FN_REGISTROS_ESPECIALES;
go
create function FN_REGISTROS_ESPECIALES (@NumeroDeOrden as int)
returns table
as
return
(select  min(UnitPrice) as valorMinimo,max(UnitPrice)as valorMaximo,count(ProductID) as Producto
from [Order Details] where OrderID = @NumeroDeOrden )

select * from dbo.FN_REGISTROS_ESPECIALES(10354)

select OrderID from [Order Details]

if OBJECT_ID ('TRG_UPD_ORDER_DETAILS', 'FN') is not null
drop TRIGGER TRG_UPD_ORDER_DETAILS;
go
CREATE TRIGGER dbo.TRG_UPD_ORDER_DETAILS 
ON dbo.[Order Details]
AFTER UPDATE
AS
BEGIN
SET NOCOUNT ON;
INSERT INTO OrderDetailsHistory(
i.OrderDetaildHistoryId ,
i.OrderId ,
i.OldProductId ,
i.OldUnitPrice ,
i.OldQuantity ,
i.OldDiscount ,
NewProductId ,
NewUnitPrice ,
NewQuantity ,
NewDiscount ,
DeltaUnitPrice,
DeltaQuantity ,
DateAndTimeOperation ,
Operation 
)
SELECT
i.OrderID,
i.OrderID,
i.ProductID,
i.UnitPrice,
i.Quantity,
i.Discount
FROM
 inserted i 
 UNION ALL
SELECT
d.ProductID,
d.UnitPrice,
d.Quantity,
d.Discount,
sum(UnitPrice-d.UnitPrice),
sum(Quantity-d.Quantity),
GETDATE(),
'UPDATE'
FROM
	deleted d;
END

end


declare @value as int = 18.05
update Products set UnitPrice = @value where ProductID = 1 and UnitPrice != @value
select * from HistoryProducts


if OBJECT_ID ('AplicacionDePorcentaje', 'FN') is not null
drop procedure AplicacionDePorcentaje;
go 
create procedure AplicacionDePorcentaje
@ProductId1 int ,--Parametros
@ProductId2 int,
@Percent real
as
	update [Order Details] set UnitPrice = UnitPrice+(UnitPrice*@Percent) where OrderID between @ProductId1 and @ProductId2;








	declare @resultadomin as real = 0;
declare @resultadomax as real = 0;
select @resultadomin = min(UnitPrice)
from [Order Details] 
select @resultadomax = max(UnitPrice)
from [Order Details] 
select @resultadomax
select @resultadomin


declare @valor as int = 0;
select @valor = min(UnitPrice)
from [Order Details]
select count(ProductID) from [Order Details] where UnitPrice =  @valor
select count(ProductID) from [Order Details] where UnitPrice =  min(UnitPrice)