use master
go

DROP DATABASE Productos;
go

create database Productos;
go

use Productos;
go

create table Laptops (
	id int not null identity,
	nombre varchar(50) not null,
	precio decimal(6,2),
	stock float,
	constraint pk_laptops primary key(id)
);
go


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