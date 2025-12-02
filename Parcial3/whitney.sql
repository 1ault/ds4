USE master
GO

CREATE DATABASE whitney
GO

USE whitney
GO

CREATE TABLE [whitney].[dbo].[wa_user] (
	[ID] INT IDENTITY(1,1) NOT NULL,
	[Username] VARCHAR(200) NOT NULL,
	[Password] VARCHAR(500) NOT NULL,
	[Role] INT NOT NULL
);
GO
CREATE TABLE [whitney].[dbo].[wa_user_x_doc] (
	[ID] INT IDENTITY(1,1) NOT NULL,
	[ID_User] INT NOT NULL,
	[ID_Doc] INT NOT NULL,
);
GO

CREATE TABLE [whitney].[dbo].[wa_doc] (
	[ID] INT IDENTITY(1,1) NOT NULL,
	[Path] VARCHAR(200) NOT NULL,
	[Type] VARCHAR(200) NOT NULL,
	[State] VARCHAR(200) NOT NULL,
	[Date_Start] Date NOT NULL,
	[Date_End] Date NOT NULL,
);
GO

CREATE TABLE [whitney].[dbo].[wa_user_x_reunion] (
	[ID] INT IDENTITY(1,1) NOT NULL,
	[ID_User] INT NOT NULL,
	[ID_Reunion] INT NOT NULL,
);
GO

CREATE TABLE [whitney].[dbo].[wa_reunion] (
	[ID] INT IDENTITY(1,1) NOT NULL,
	[Date_Start] Date NOT NULL,
	[Date_End] Date NOT NULL,
);

CREATE TABLE [whitney].[dbo].[wa_rol] (
	[ID] INT IDENTITY(1,1) NOT NULL,
	[rol] INT NOT NULL,
);


CREATE TABLE [whitney].[dbo].[wa_doc_type] (
	[ID] INT IDENTITY(1,1) NOT NULL,
	[rol] INT NOT NULL,
);




INSERT INTO [whitney].[dbo].[wa_user] ([Username], [Password], [Role])
VALUES ('admin', 'admin', 1)
GO