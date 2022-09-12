use AdventureWorks2014
go 

create procedure OrderConsult
@Sale as int 
as
	begin
		 SELECT SalesOrderID,OrderDate,Status,AccountNumber
		 ,CustomerID,CreditCardID,SubTotal,TaxAmt
		 ,Freight,TotalDue
		 FROM Sales.SalesOrderHeader
		 where SalesOrderID = @Sale
end 
go

create proc DetalleConsulta
@Sale as int 
as 
	begin 
		 SELECT A.SalesOrderDetailID,A.OrderQty,B.NAME
		,A.ProductID,A.UnitPrice,A.LineTotal
		 FROM Sales.SalesOrderDetail A, Production.Product B
		where SalesOrderID = @Sale
		and A.ProductID = B.ProductID
	end