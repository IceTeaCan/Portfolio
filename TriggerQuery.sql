use NORTHWND

go
CREATE TRIGGER dbo.trg_product
ON dbo.Products
AFTER UPDATE
AS
BEGIN
SET NOCOUNT ON;
INSERT INTO HistoryProducts(
i.ProductID,
i.ProductName ,
i.SupplierID ,
i.CategoryID ,
i.QuantityPerUnit ,
i.UnitPrice ,
i.UnitsInStock ,
i.UnitsOnOrder ,
i.ReorderLevel ,
i.Discontinued ,
i.EventDateTime,
i.Operation
)
SELECT
ProductID,
ProductName ,
SupplierID ,
CategoryID ,
QuantityPerUnit ,
UnitPrice ,
UnitsInStock ,
UnitsOnOrder ,
ReorderLevel ,
Discontinued ,
GETDATE(),
'UP'
FROM
inserted i
end



declare @value as int = 18.05
update Products set UnitPrice = @value where ProductID = 1 and UnitPrice != @value
select * from HistoryProducts






















--UNION ALL
--SELECT
--d.ProductID,
--d.ProductName ,
--d.SupplierID ,
--d.CategoryID ,
--d.QuantityPerUnit ,
--d.UnitPrice ,
--d.UnitsInStock ,
--d.UnitsOnOrder ,
--d.ReorderLevel ,
--d.Discontinued ,
--GETDATE(),
--'DEL'
--FROM
--deleted d;
--END