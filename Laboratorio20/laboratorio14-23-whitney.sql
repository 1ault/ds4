USE master
GO

DROP DATABASE Productos;
GO

CREATE database Productos;
GO

USE Productos;
GO

CREATE TABLE Laptops (
	id int not null identity,
	nombre varchar(50) not null,
	precio decimal(6,2),
	stock float,
	constraint pk_laptops primary key(id)
);
GO


SELECT
[id],
[nombre],
[precio],
[stock]
FROM
[Productos].[dbo].[Laptops]
WHERE
[id] = 2
GO
