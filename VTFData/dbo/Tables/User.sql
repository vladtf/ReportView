CREATE TABLE [dbo].[User]
(
	[Id] nvarchar(128) NOT NULL PRIMARY KEY, 
    [FirstName] nvarchar(50) NOT NULL, 
    [LastName] nvarchar(50) NOT NULL, 
    [EmailAdress] nvarchar(50) NOT NULL, 
    [CreatedDate] DATETIME NOT NULL DEFAULT getutcdate()
)
