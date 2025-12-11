-- Create -----------------------------------------------------------------------------------

USE master
GO

ALTER DATABASE Vipel
SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

DROP DATABASE Vipel;
GO

CREATE database Vipel;
GO

USE Vipel;
GO

-- Table -----------------------------------------------------------------------------------

CREATE TABLE [Vipel].[dbo].[user] (
	[ID] INT IDENTITY(1,1) NOT NULL,
	[Username] VARCHAR(256) NOT NULL,
	[Password] VARCHAR(600) NOT NULL,
	[Email] VARCHAR(256) NOT NULL,
	[Role] tinyint NOT NULL
);
GO

CREATE TABLE [Vipel].[dbo].[page] (
    [ID] [int] IDENTITY(1,1) NOT NULL,
);
GO

CREATE TABLE [Vipel].[dbo].[modulo] (
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [ID_ModuloType] INT NOT NULL,
    [Order] INT NOT NULL,
	[Json] NVARCHAR(MAX) NOT NULL 
);
GO

CREATE TABLE [Vipel].[dbo].[EnumModuloType] (
    [ID] INT PRIMARY KEY,
    [Name] VARCHAR(50) NOT NULL UNIQUE
);
GO

CREATE TABLE [Vipel].[dbo].[EnumUserStatus] (
    [ID] INT PRIMARY KEY,
    [Name] VARCHAR(50) NOT NULL UNIQUE
);
GO

-- Union ---------------------------------------------------------------------------------------

CREATE TABLE [Vipel].[dbo].[modulo__page] (
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [ID_modulo] [int] int NOT NULL,
	[ID_page] [int] int NOT NULL,
);
GO

-- CONSTRAINT -----------------------------------------------------------------------------------


ALTER TABLE [Vipel].[dbo].[user]
ADD ,
    CONSTRAINT [FK_user__user_role] FOREIGN KEY ([Role]) REFERENCES [Vipel].[dbo].[EnumUserStatus]([ID])
GO

ALTER TABLE [Vipel].[dbo].[modulo__page]
ADD 
    CONSTRAINT [FK_modulo__page_page] FOREIGN KEY ([ID_page]) REFERENCES [Vipel].[dbo].[page]([ID]),
    CONSTRAINT [FK_modulo__page_modulo] FOREIGN KEY ([ID_modulo]) REFERENCES [Vipel].[dbo].[modulo]([ID])
GO

ALTER TABLE [Vipel].[dbo].[modulo]
ADD ,
    CONSTRAINT [FK_modulo__modulo_modulo_type] FOREIGN KEY ([ID_ModuloType]) REFERENCES [Vipel].[dbo].[EnumModuloType]([ID])
GO



-- INSERT -----------------------------------------------------------------------------------


INSERT INTO [Vipel].[dbo].[EnumModuloType] 
([ID], [Name]) 
VALUES
(0, 'Main'),
(1, 'Section'),
(2, 'IMG'),
(3, 'Compost'),
(4, 'H20')
GO

INSERT INTO [Vipel].[dbo].[EnumUserStatus] 
([ID], [Name]) 
VALUES
(-2, 'Banned'),
(-1, 'Inactive'),
(0, 'Applicant'),
(1, 'Invited'),
(2, 'User'),
(10, 'Moderator'),
(100, 'Admin')
GO


-- Stored Procedure -----------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].InsertPlant
    @ID INT,
    @Username NVARCHAR(256),
    @Email NVARCHAR(256),
    @Role INT,
    @UpdateRole INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserExist BIT = 0;

    IF EXISTS (
        SELECT 1
        FROM [dbo].[User]
        WHERE [ID] = @ID AND [Username] = @Username AND [Email] = @Email AND [Role] = @Role
    )
    SET @UserExist = 1;

    DECLARE @Message NVARCHAR(600);

    IF (@UserExist = 1)
    BEGIN
        UPDATE [dbo].[user]
        SET [Role] = @UpdateRole
        WHERE [ID] = @ID AND [Username] = @Username AND [Email] = @Email;

        SET @Message = CONCAT('Update Rol: ', @Role, ' ID: ', @ID, ' User: ', @Username, ' Email: ', @Email);
    END
    ELSE
    BEGIN
        SET @Message = 'User not exist';
    END


    SELECT @Message AS ResultMessage;
END
GO


CREATE PROCEDURE [dbo].AdminCheckUser
    @ID INT,
    @Username NVARCHAR(256),
    @Email NVARCHAR(256),
    @Role INT,
    @UpdateRole INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserExist BIT = 0;

    IF EXISTS (
        SELECT 1
        FROM [dbo].[User]
        WHERE [ID] = @ID AND [Username] = @Username AND [Email] = @Email AND [Role] = @Role
    )
    SET @UserExist = 1;

    DECLARE @Message NVARCHAR(600);

    IF (@UserExist = 1)
    BEGIN
        UPDATE [dbo].[user]
        SET [Role] = @UpdateRole
        WHERE [ID] = @ID AND [Username] = @Username AND [Email] = @Email;

        SET @Message = CONCAT('Update Rol: ', @Role, ' ID: ', @ID, ' User: ', @Username, ' Email: ', @Email);
    END
    ELSE
    BEGIN
        SET @Message = 'User not exist';
    END


    SELECT @Message AS ResultMessage;
END
GO


CREATE PROCEDURE [dbo].CheckUserAndMail
    @Username NVARCHAR(256),
    @Email NVARCHAR(256)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserExists BIT = 0, @EmailExists BIT = 0;

    IF EXISTS (
        SELECT 1
        FROM [dbo].[User]
        WHERE [Username] = @Username
    )
    SET @UserExists = 1;


    IF EXISTS (
        SELECT 1
        FROM [dbo].[User]
        WHERE [Email] = @Email
    )
    SET @EmailExists = 1;

    DECLARE @Message NVARCHAR(200);

    IF (@UserExists = 1 AND @EmailExists = 1)
        SET @Message = 'Username and email already exist. Please try again.';
    ELSE IF (@UserExists = 1)
        SET @Message = 'Username already exists.';
    ELSE IF (@EmailExists = 1)
        SET @Message = 'Email already exists.';
    ELSE
        SET @Message = 'OK';

    SELECT @Message AS ResultMessage;
END
GO

SELECT *
FROM [Vipel].[dbo].[user]
GO