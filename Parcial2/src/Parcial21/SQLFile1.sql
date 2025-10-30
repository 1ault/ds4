USE master
GO

DROP DATABASE IF EXISTS historial
GO

CREATE DATABASE historial
GO

USE historial
GO

CREATE TABLE historial_data (
	id INT NOT NULL IDENTITY(1,1),
	typo Varchar(200) NOT NULL,
	original FLOAT NOT NULL,
	calc FLOAT NOT null,
)
GO

INSERT INTO historial_data 
(typo, original, calc)  
VALUES(
	'test',
	21321,
	232421)
GO

SELECT * FROM historial_data
GO