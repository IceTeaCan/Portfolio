use NORTHWND
if object_id ('HistoryProducts', 'U') is not null
drop table HistoryProducts;



create table dbo.HistoryProducts
(
HistoryID int identity (1, 1) primary key,
ProductID int not null,
ProductName nvarchar (40) not null,
SupplierID int,
CategoryID int,
QuantityPerUnit nvarchar(20),
UnitPrice money,
UnitsInStock smallint,
UnitsOnOrder smallint,
ReorderLevel smallint,
Discontinued bit not null,
EventDateTime datetime not null,
Operation varchar (3)
)

drop table HistoryProducts