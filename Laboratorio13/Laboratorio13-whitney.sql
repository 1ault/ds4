USE master
go
use Northwind

SELECT*FROM Products
GO

SELECT[ProductID],[ProductName],[UnitPrice] 
FROM [dbo].[Products]
GO

SELECT[ProductID],[ProductName],[UnitPrice] 
FROM [dbo].[Products]
WHERE [UnitPrice]>15
GO


SELECT[ProductID],[ProductName],[UnitPrice] 
FROM [dbo].[Products]
WHERE [UnitPrice]>=15 AND [UnitPrice]<=50
GO

SELECT[ProductID],[ProductName],[UnitPrice] 
FROM [dbo].[Products]
WHERE [UnitPrice] BETWEEN 15 AND 50
GO

SELECT[ProductID],[ProductName],[UnitPrice] 
FROM [dbo].[Products]
WHERE NOT [UnitPrice]>15 
GO

SELECT[ProductID],[ProductName],[UnitPrice] 
FROM [dbo].[Products]
WHERE [UnitPrice]>15 OR [UnitPrice]<10 
GO

SELECT [EmployeeID],[LastName] 
FROM[dbo].[Employees]
WHERE [LastName] LIKE 'D%'
GO

SELECT [EmployeeID],[LastName] 
FROM[dbo].[Employees]
WHERE [LastName] LIKE '%N'
GO

SELECT [EmployeeID],[LastName],[Title]
FROM[dbo].[Employees]
WHERE [Title] LIKE '%SALES%'
GO

SELECT [EmployeeID],[LastName] 
FROM[dbo].[Employees]
WHERE [LastName] NOT LIKE 'D%'
GO


SELECT[ProductID],[ProductName],[UnitPrice] 
FROM [dbo].[Products]
ORDER BY  [ProductID] ASC
GO


SELECT[ProductID],[ProductName],[UnitPrice] 
FROM [dbo].[Products]
ORDER BY  [ProductID] DESC
GO


SELECT DISTINCT  [OrderID]
FROM [dbo].[Order Details]
GO

SELECT TOP 5  [OrderID],[ProductID],[Quantity]
FROM [dbo].[Order Details]
GO

SELECT TOP 10 PERCENT  [OrderID],[ProductID],[Quantity]
FROM [dbo].[Order Details]
GO


SELECT[CategoryName] AS [NOMBRE DE LA CATEGORIA]
FROM [dbo].[Categories]
GO

SELECT [OrderID],[OrderDate],[ShippedDate],[ShippedDate]+5 AS[RETRASOENVIO]
FROM[dbo].[Orders]
GO

SELECT OD.[OrderID],P.[ProductID],P.[ProductName]
FROM Products P
INNER JOIN [dbo].[Order Details] OD
ON P.ProductID =OD.ProductID
GO

SELECT P.[ProductName],S.[CompanyName],S.[ContactName]
FROM [dbo].[Products] P
FULL JOIN [dbo].[Suppliers] S
ON P.[SupplierID]=S.SupplierID
GO