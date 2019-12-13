CREATE TABLE [dbo].[users]
(
	[user_id] nvarchar(255) NOT NULL PRIMARY KEY,
	[first_name] nvarchar(255) NULL,
	[last_name] nvarchar(255) NULL,
	[email_adress] nvarchar(255) NOT NULL UNIQUE,
	[phone_number] int NULL UNIQUE,
	[verfied_status] int NOT NULL Default 0,
	[created_at] datetime NOT NULL DEFAULT getutcdate()
)
