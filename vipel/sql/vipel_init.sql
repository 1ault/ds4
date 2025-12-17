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

CREATE TABLE [dbo].[user] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    [Username] VARCHAR(256) NOT NULL,
    [Password] VARCHAR(600) NOT NULL,
    [Email] VARCHAR(256) NOT NULL,
    [Role] INT NOT NULL
);
GO

CREATE TABLE [dbo].[page] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY NOT NULL
);
GO

CREATE TABLE [dbo].[module] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    [ID_moduleType] INT NOT NULL,
    [Order] INT NOT NULL,
    [Json] NVARCHAR(MAX) NOT NULL 
);
GO

CREATE TABLE [dbo].[EnummoduleType] (
    [ID] INT PRIMARY KEY NOT NULL,
    [Name] VARCHAR(50) NOT NULL UNIQUE
);
GO

CREATE TABLE [dbo].[EnumUserStatus] (
    [ID] INT PRIMARY KEY NOT NULL,
    [Name] VARCHAR(50) NOT NULL UNIQUE
);
GO

-- Union / Junction table -------------------------------------------------------------------

CREATE TABLE [dbo].[module__page] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    [ID_module] INT NOT NULL,
    [ID_page]   INT NOT NULL
);
GO

-- CONSTRAINT -----------------------------------------------------------------------------------


ALTER TABLE [dbo].[user]
ADD CONSTRAINT [FK_user__user_role]
    FOREIGN KEY ([Role]) REFERENCES [dbo].[EnumUserStatus]([ID]);
GO

ALTER TABLE [dbo].[module__page]
ADD 
    CONSTRAINT [FK_module__page_page]   FOREIGN KEY ([ID_page])   REFERENCES [dbo].[page]([ID]),
    CONSTRAINT [FK_module__page_module] FOREIGN KEY ([ID_module]) REFERENCES [dbo].[module]([ID]),
    CONSTRAINT [UQ_module__page] UNIQUE ([ID_module], [ID_page]);
GO


ALTER TABLE [dbo].[module]
ADD CONSTRAINT [FK_module__module_module_type]
    FOREIGN KEY ([ID_moduleType]) REFERENCES [dbo].[EnummoduleType]([ID]);
GO

-- INSERT -----------------------------------------------------------------------------------

INSERT INTO [dbo].[EnummoduleType] 
([ID], [Name]) 
VALUES
(0, 'Main'),
(1, 'Section'),
(2, 'IMG'),
(3, 'Compost'),
(4, 'H2O');
GO

INSERT INTO [dbo].[EnumUserStatus] 
([ID], [Name]) 
VALUES
(-2, 'Banned'),
(-1, 'Inactive'),
(0, 'Applicant'),
(1, 'Invited'),
(2, 'UserM'),
(3, 'UserF'),
(99, 'Moderator'),
(100, 'Admin');
GO

-- Stored Procedures ---------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE [dbo].[UserGetPost]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        p.[ID]            AS PageID,
        m.[ID]            AS ModuleID,
        m.[ID_moduleType] AS ModuleTypeID,
        m.[Order]         AS ModuleOrder,
        m.[Json]          AS ModuleJson
    FROM [dbo].[module__page] AS mp
    INNER JOIN [dbo].[page]   AS p ON mp.[ID_page]   = p.[ID]
    INNER JOIN [dbo].[module] AS m ON mp.[ID_module] = m.[ID]
    WHERE m.[ID_moduleType] = 1;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[UserGetPostId]
    @ID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        mp.[ID_page]      AS PageID,
        m.[ID]            AS ModuleID,
        m.[ID_moduleType] AS ModuleTypeID,
        m.[Order]         AS ModuleOrder,
        m.[Json]          AS ModuleJson
    FROM dbo.[module__page] AS mp
    INNER JOIN dbo.[module] AS m ON m.[ID] = mp.[ID_module]
    WHERE mp.[ID_page] = @ID
    ORDER BY m.[Order];
END
GO


CREATE PROCEDURE [dbo].[PageCreate]
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.[page] DEFAULT VALUES;
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS PageID;
END
GO

CREATE PROCEDURE [dbo].[UserInsertPost]
    @PageID        INT,
    @ModuleTypeID  INT,
    @ModuleOrder   INT,
    @ModuleJson    NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ModuleID INT;

    BEGIN TRY
        INSERT INTO [dbo].[module] (
            [ID_moduleType],
            [Order],
            [Json]
        )
        VALUES (
            @ModuleTypeID,
            @ModuleOrder,
            @ModuleJson
        );

        SET @ModuleID = SCOPE_IDENTITY();

        INSERT INTO [dbo].[module__page] (
            [ID_page],
            [ID_module]
        )
        VALUES (
            @PageID,
            @ModuleID
        );

        SELECT 'Insertion successful' AS Message, @ModuleID AS ModuleID;
    END TRY
    BEGIN CATCH
        SELECT 'Insertion failed: ' + ERROR_MESSAGE() AS Message;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE [dbo].[AlterUserRol]
    @ID         INT,
    @Username   VARCHAR(256),
    @Email      VARCHAR(256),
    -- @Role       INT,
    @UpdateRole INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserExist BIT = 0;

    IF EXISTS (
        SELECT 1
        FROM [dbo].[user]
        WHERE [ID] = @ID
          AND [Username] = @Username
          AND [Email] = @Email
          -- AND [Role] = @Role
    )
        SET @UserExist = 1;

    DECLARE @Message NVARCHAR(600);

    IF (@UserExist = 1)
    BEGIN
        UPDATE [dbo].[user]
        SET [Role] = @UpdateRole
        WHERE [ID] = @ID
          AND [Username] = @Username
          AND [Email] = @Email;

        SET @Message = CONCAT(
            -- 'Update Role from ', @Role,
            ' to ', @UpdateRole,
            ' | ID: ', @ID,
            ' | User: ', @Username,
            ' | Email: ', @Email
        );
    END
    ELSE
    BEGIN
        SET @Message = 'User not exist';
    END

    SELECT @Message AS ResultMessage;
END
GO

CREATE PROCEDURE [dbo].[AdminCheckUser]
    @ID         INT,
    @Username   VARCHAR(256),
    @Email      VARCHAR(256),
    @Role       INT,
    @UpdateRole INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserExist BIT = 0;

    IF EXISTS (
        SELECT 1
        FROM [dbo].[user]
        WHERE [ID] = @ID
          AND [Username] = @Username
          AND [Email] = @Email
          AND [Role] = @Role
    )
        SET @UserExist = 1;

    DECLARE @Message NVARCHAR(600);

    IF (@UserExist = 1)
    BEGIN
        UPDATE [dbo].[user]
        SET [Role] = @UpdateRole
        WHERE [ID] = @ID
          AND [Username] = @Username
          AND [Email] = @Email;

        SET @Message = CONCAT(
            'Update Role from ', @Role,
            ' to ', @UpdateRole,
            ' | ID: ', @ID,
            ' | User: ', @Username,
            ' | Email: ', @Email
        );
    END
    ELSE
    BEGIN
        SET @Message = 'User not exist';
    END

    SELECT @Message AS ResultMessage;
END
GO

CREATE PROCEDURE [dbo].[CheckUserAndMail]
    @Username VARCHAR(256),
    @Email    VARCHAR(256)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserExists  BIT = 0,
            @EmailExists BIT = 0;

    IF EXISTS (
        SELECT 1
        FROM [dbo].[user]
        WHERE [Username] = @Username
    )
        SET @UserExists = 1;

    IF EXISTS (
        SELECT 1
        FROM [dbo].[user]
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
FROM [dbo].[user];
GO

SELECT *
FROM [dbo].[page];
GO


SELECT *
FROM [dbo].[module];
GO


SELECT *
FROM [dbo].[module__page]
GO