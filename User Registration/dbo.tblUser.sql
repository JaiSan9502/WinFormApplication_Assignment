﻿CREATE TABLE [dbo].[tblUser]
(
	[UserID] INT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [Contact] VARCHAR(50) NULL, 
    [Address] VARCHAR(50) NULL, 
    [Username] VARCHAR(50) NULL, 
    [Password] VARCHAR(50) NULL
)
