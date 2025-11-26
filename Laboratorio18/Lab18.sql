USE MASTER
GO

DROP DATABASE laboratoriomvc
GO

CREATE DATABASE laboratoriomvc
GO

USE laboratoriomvc
GO

CREATE TABLE [dbo].[User] (
	id INT NOT NULL IDENTITY(1,1),
	email Varchar(50) NOT NULL,
	password Varchar(100) NOT NULL
)
GO

INSERT INTO [dbo].[User] (email, password)
VALUES
('a', '123'),
('b', '123');
GO
